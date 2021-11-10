/*
Copyright 2018 Manufaktura Programów Jacek Salamon
Website: http://musicengravingcontrols.com/
Patreon: https://www.patreon.com/jacek_salamon

MIT LICENCE

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"),
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using Manufaktura.Core.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace Manufaktura.Core.Serialization
{
    public abstract class LazyLoadJsonProxy : DispatchProxy, IMeasureDeserializationPerformance
    {
        protected readonly ConcurrentDictionary<string, object> cache = new ConcurrentDictionary<string, object>();
        protected readonly ConcurrentDictionary<string, TimeSpan> performanceLog = new ConcurrentDictionary<string, TimeSpan>();
        public int NumberOfAccessedMethods => cache.Count;
        public IDictionary<string, TimeSpan> PerformanceLog => performanceLog;

        public TimeSpan TotalTimeSpentOnDeserialization => TimeSpan.FromTicks(PerformanceLog.Sum(pl => pl.Value.Ticks));

        public static object Create(Type interfaceType, string json)
        {
            var proxyType = typeof(LazyLoadJsonProxy<>).MakeGenericType(interfaceType);
            var method = proxyType.GetTypeInfo().GetDeclaredMethods(nameof(Create)).First(m => m.GetParameters().First().ParameterType == typeof(string));
            return method.Invoke(null, new object[] { json });
        }

        public string DumpCache(Type type)
        {
            var sb = new StringBuilder();
            var index = 0;
            using (var textWriter = new StringWriter(sb))
            using (var writer = new JsonTextWriter(textWriter))
            {
                writer.WriteStartObject();
                foreach (var entry in cache)
                {
                    var property = type.GetTypeInfo().GetDeclaredProperty(entry.Key.Replace("get_", ""));
                    var jsonPropertyName = property?.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName ??
                        property?.GetCustomAttribute<DataMemberAttribute>()?.Name;

                    writer.WritePropertyName(jsonPropertyName);
                    if (property.PropertyType.GetTypeInfo().IsInterface)
                    {
                        var valueAsProxy = entry.Value as LazyLoadJsonProxy;
                        writer.WriteRawValue(valueAsProxy?.DumpCache(property.PropertyType));
                    }
                    else
                    {
                        var token = JToken.FromObject(entry.Value);
                        writer.WriteRawValue(token?.ToString());
                    }

                    //if (index != cache.Count - 1) writer.WriteRaw(",");
                    index++;
                }
                writer.WriteEnd();
            }
            return sb.ToString();
        }

        public TimeSpan GetTotalDeserializationTimeWithChildElements()
        {
            var time = TotalTimeSpentOnDeserialization;
            foreach (var prop in GetType().GetRuntimeProperties().Where(p => p.PropertyType.GetTypeInfo().IsInterface))
            {
                var proxy = prop.GetValue(this) as LazyLoadJsonProxy;
                if (proxy == null) continue;
                time += proxy.GetTotalDeserializationTimeWithChildElements();
            }
            return time;
        }

        public int GetTotalNumberOfAccessedMethodsWithChildElements()
        {
            var count = NumberOfAccessedMethods;
            foreach (var prop in GetType().GetRuntimeProperties().Where(p => p.PropertyType.GetTypeInfo().IsInterface))
            {
                var proxy = prop.GetValue(this) as LazyLoadJsonProxy;
                if (proxy == null) continue;
                count += proxy.GetTotalNumberOfAccessedMethodsWithChildElements();
            }
            return count;
        }
    }

    public class LazyLoadJsonProxy<TInterface> : LazyLoadJsonProxy
    {
        private string jsonString;

        public static TInterface Create(string json)
        {
            var proxy = Create<TInterface, LazyLoadJsonProxy<TInterface>>() as LazyLoadJsonProxy<TInterface>;
            proxy.jsonString = json;
            return (TInterface)(object)proxy;
        }

        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            if (cache.ContainsKey(targetMethod.Name)) return cache[targetMethod.Name];

            var sw = new Stopwatch();
            sw.Start();
            try
            {
                var propertyOfThisGetter = targetMethod.DeclaringType
                    .GetTypeInfo()
                    .GetDeclaredProperty(targetMethod.Name.Replace("get_", ""));
                var jsonPropertyName = propertyOfThisGetter?.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName ??
                    propertyOfThisGetter?.GetCustomAttribute<DataMemberAttribute>()?.Name;

                if (string.IsNullOrWhiteSpace(jsonPropertyName)) return TryAddDefaultValue(targetMethod.Name, targetMethod.ReturnType);

                using (var textReader = new StringReader(jsonString))
                using (var reader = new JsonTextReader(textReader))
                {
                    while (reader.Read())
                    {
                        if (reader.Path != jsonPropertyName) continue;

                        var token = JToken.Load(reader);
                        if (targetMethod.ReturnType.GetTypeInfo().IsInterface)
                        {
                            var prop = token as JProperty;
                            if (prop != null)
                            {
                                var proxy = Create(targetMethod.ReturnType, prop.Value.ToString());
                                return TryAddValue(targetMethod.Name, proxy);
                            }
                            else
                            {
                                var proxy = Create(targetMethod.ReturnType, token.ToString());
                                return TryAddValue(targetMethod.Name, proxy);
                            }
                        }

                        var property = token as JProperty;
                        if (property != null)
                            return TryAddValue(targetMethod.Name, property.Value.ToObject(targetMethod.ReturnType));
                        else
                            return TryAddValue(targetMethod.Name, token.ToObject(targetMethod.ReturnType));
                    }
                }
                return TryAddDefaultValue(targetMethod.Name, targetMethod.ReturnType);
            }
            finally
            {
                sw.Stop();
                performanceLog.TryAdd(targetMethod.Name, sw.Elapsed);
            }
        }

        private object TryAddDefaultValue(string name, Type type)
        {
            var value = type.GetDefaultValue();
            return TryAddValue(name, value);
        }

        private object TryAddValue(string name, object value)
        {
            cache.TryAdd(name, value);
            return value;
        }
    }
}