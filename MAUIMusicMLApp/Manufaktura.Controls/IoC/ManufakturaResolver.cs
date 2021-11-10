/*
 * Copyright 2018 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE
 
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Manufaktura.Controls.IoC
{
    /// <summary>
    /// Simple dependency resolver.
    /// </summary>
    public class ManufakturaResolver
    {
        private List<object> createdServices = new List<object>();

        /// <summary>
        /// Register object which will be used as a dependency when needed.
        /// </summary>
        /// <param name="service">Any object</param>
        public void AddService(object service)
        {
            createdServices.Add(service);
        }

        /// <summary>
        /// Register objects which will be used as dependencies when needed.
        /// </summary>
        /// <param name="services">Any objects</param>
        public void AddServices(params object[] services)
        {
            createdServices.AddRange(services);
        }

        /// <summary>
        /// Create objects of type T. If the constructor has dependencies they will be matched from createdServices list.
        /// </summary>
        /// <typeparam name="T">Type of objects to create</typeparam>
        /// <returns>Created object</returns>
        public IEnumerable<T> ResolveAll<T>() where T : class
        {
#if CSHTML5
            var assemblies = new List<Assembly> { GetType().Assembly };
            if (!assemblies.Contains(typeof(T).Assembly)) assemblies.Add(typeof(T).Assembly);
            var types = assemblies.SelectMany(a => a.GetTypes()).Where(t => !t.IsAbstract && (t.IsSubclassOf(typeof(T)) || typeof(T).IsAssignableFrom(t)));
            foreach (var type in types)
            {
                var constructors = type.GetConstructors();
                if (!constructors.Any()) yield return ExpressionActivator.CreateInstance<T>(type);

                foreach (var constructor in constructors)
                {
                    object[] matchedParameters;

                    if (TryBindParameters(constructor, out matchedParameters))
                        yield return Activator.CreateInstance(type, matchedParameters) as T;
                }
            }
#else
            var assemblies = new List<Assembly> { GetType().GetTypeInfo().Assembly };
            if (!assemblies.Contains(typeof(T).GetTypeInfo().Assembly)) assemblies.Add(typeof(T).GetTypeInfo().Assembly);
            var types = assemblies.SelectMany(a => a.DefinedTypes).Where(t => !t.IsAbstract && (t.IsSubclassOf(typeof(T)) || typeof(T).GetTypeInfo().IsAssignableFrom(t)));
            foreach (var type in types)
            {
                var constructors = type.DeclaredConstructors;

                if (!constructors.Any()) yield return ExpressionActivator.CreateInstance<T>(type.AsType());

                foreach (var constructor in constructors)
                {
                    object[] matchedParameters;

                    if (TryBindParameters(constructor, out matchedParameters))
                        yield return Activator.CreateInstance(type.AsType(), matchedParameters) as T;
                }
            }
#endif
        }

        private bool TryBindParameters(ConstructorInfo constructor, out object[] matchedParameters)
        {
            var matchedParameterList = new List<object>();
            var constructorParameters = constructor.GetParameters();
            foreach (var parameter in constructorParameters)
            {
                var matchingService = createdServices.FirstOrDefault(cs => parameter.ParameterType == cs.GetType() ||
                    parameter.ParameterType.GetTypeInfo().IsAssignableFrom(cs.GetType().GetTypeInfo()));
                if (matchingService == null) break;
                matchedParameterList.Add(matchingService);
            }
            matchedParameters = matchedParameterList.ToArray();
            return constructorParameters.Length == matchedParameters.Length;
        }
    }
}