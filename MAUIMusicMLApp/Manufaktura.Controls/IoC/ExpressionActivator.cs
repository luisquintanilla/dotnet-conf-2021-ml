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
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Manufaktura.Controls.IoC
{
    /// <summary>
    /// Helper class to create objects using expression tree compilation.
    /// </summary>
    public class ExpressionActivator
    {
        /// <summary>
        /// Create instance of type <typeparam name="T" />.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type"></param>
        /// <returns></returns>
        public static T CreateInstance<T>(Type type) where T : class
        {
#if CSHTML5
            return Activator.CreateInstance(type) as T;
#else
            var expr = Expression.Lambda(Expression.New(type));
            return expr.Compile().DynamicInvoke() as T;
#endif
        }

        /// <summary>
        /// Creates instance of an object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="constructor"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static T CreateInstance<T>(ConstructorInfo constructor, params object[] parameters) where T : class
        {
#if CSHTML5
            throw new NotImplementedException();
#else
            var expr = Expression.Lambda(Expression.New(constructor, parameters.Select(p => Expression.Parameter(p.GetType(),
                string.Format("p{0}", parameters.ToList().IndexOf(p))))));
            return expr.Compile().DynamicInvoke(parameters) as T;
#endif
        }
    }
}