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
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Manufaktura.Core.Serialization
{
    public abstract class LazyLoadJsonStaticProxy<TInterface> : IMeasureDeserializationPerformance
    {
        protected readonly ConcurrentDictionary<string, object> cache = new ConcurrentDictionary<string, object>();
        protected readonly ConcurrentDictionary<string, TimeSpan> performanceLog = new ConcurrentDictionary<string, TimeSpan>();
        private readonly Type[] concreteTypes;
        private readonly string jsonString;

        public LazyLoadJsonStaticProxy(string jsonString, Type[] concreteTypes)
        {
            this.jsonString = jsonString;
            this.concreteTypes = concreteTypes;
        }

        public int NumberOfAccessedMethods => cache.Count;
        public IDictionary<string, TimeSpan> PerformanceLog => performanceLog;

        public TimeSpan TotalTimeSpentOnDeserialization => TimeSpan.FromTicks(PerformanceLog.Sum(pl => pl.Value.Ticks));

        public TimeSpan GetTotalDeserializationTimeWithChildElements()
        {
            var time = TotalTimeSpentOnDeserialization;
            foreach (var prop in typeof(TInterface).GetRuntimeProperties().Where(p => p.PropertyType.GetTypeInfo().IsInterface))
            {
                var proxy = prop.GetValue(this) as IMeasureDeserializationPerformance;
                if (proxy == null) continue;
                time += proxy.GetTotalDeserializationTimeWithChildElements();
            }
            return time;
        }

        public int GetTotalNumberOfAccessedMethodsWithChildElements()
        {
            var count = NumberOfAccessedMethods;
            foreach (var prop in typeof(TInterface).GetRuntimeProperties().Where(p => p.PropertyType.GetTypeInfo().IsInterface))
            {
                var proxy = prop.GetValue(this) as IMeasureDeserializationPerformance;
                if (proxy == null) continue;
                count += proxy.GetTotalNumberOfAccessedMethodsWithChildElements();
            }
            return count;
        }

        protected object Load([CallerMemberName] string propertyName = null)
        {
            if (cache.ContainsKey(propertyName)) return cache[propertyName];

            var sw = new Stopwatch();
            sw.Start();
            try
            {
                var jsonProperty = typeof(TInterface).GetTypeInfo().GetDeclaredProperty(propertyName);
                var jsonPropertyName = jsonProperty?.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName ??
                    jsonProperty?.GetCustomAttribute<DataMemberAttribute>()?.Name;

                if (string.IsNullOrWhiteSpace(jsonPropertyName)) return TryAddDefaultValue(propertyName, jsonProperty.PropertyType);

                using (var textReader = new StringReader(jsonString))
                using (var reader = new JsonTextReader(textReader))
                {
                    while (reader.Read())
                    {
                        if (reader.Path != jsonPropertyName) continue;

                        var token = JToken.Load(reader);
                        if (jsonProperty.PropertyType.GetTypeInfo().IsInterface)
                        {
                            var prop = token as JProperty;
                            if (prop != null)
                            {
                                var proxy = Create(jsonProperty.PropertyType, prop.Value.ToString());
                                return TryAddValue(propertyName, proxy);
                            }
                            else
                            {
                                var proxy = Create(jsonProperty.PropertyType, token.ToString());
                                return TryAddValue(propertyName, proxy);
                            }
                        }

                        var property = token as JProperty;
                        if (property != null)
                            return TryAddValue(propertyName, property.Value.ToObject(jsonProperty.PropertyType));
                        else
                            return TryAddValue(propertyName, token.ToObject(jsonProperty.PropertyType));
                    }
                }
                return TryAddDefaultValue(propertyName, jsonProperty.PropertyType);
            }
            finally
            {
                sw.Stop();
                performanceLog.TryAdd(propertyName, sw.Elapsed);
            }
        }

        private object Create(Type interfaceType, string innerJson)
        {
            var abstractLoaderType = typeof(LazyLoadJsonStaticProxy<>).MakeGenericType(interfaceType);
            var concreteLoaderType = concreteTypes.FirstOrDefault(t => t.GetTypeInfo().IsSubclassOf(abstractLoaderType));
            return Activator.CreateInstance(concreteLoaderType, innerJson);
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