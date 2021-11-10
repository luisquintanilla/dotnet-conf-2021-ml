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
using System.Collections.Concurrent;
using System.Linq;
using System.Linq.Expressions;

namespace Manufaktura.Core.Expressions.Parsers
{
    public static class ParserExtensions
    {
        private static ConcurrentDictionary<string, LambdaExpression> expressionCache = new ConcurrentDictionary<string, LambdaExpression>();

        /// <summary>
        /// Returns maximum parenthesis level in string
        /// </summary>
        /// <param name="s">String to check</param>
        /// <returns>Max parenthesis level</returns>
        public static int MaxParenthesisLevel(this string s)
        {
            return s.OfType<char>().Count(c => c == '(');
        }

        public static string StripParentheses(this string s)
        {
            return s.Replace("(", "").Replace(")", "");
        }

        /// <summary>
        /// Converts expression string to Expression.
        /// </summary>
        /// <param name="s">Expression string</param>
        /// <param name="parameters">Detected parameters. Parameters in expression string have to be preceded by @ sign.</param>
        /// <returns>Parsed expression</returns>
        public static Expression ToExpression(this string s, out ParameterExpression[] parameters)
        {
            var parser = new String2ExpressionParser();
            var expression = parser.Parse(s);
            parameters = parser.Parameters.ToArray();
            return expression;
        }
        /// <summary>
        /// Converts expression string to Expression and wraps it in lambda expression.
        /// </summary>
        /// <param name="s">Expression string</param>
        /// <returns>Lambda expression which wraps the parsed expression</returns>
        public static LambdaExpression ToLambdaExpression(this string s)
        {
            if (expressionCache.ContainsKey(s)) return expressionCache[s];

            ParameterExpression[] parameters;
            var expression = s.ToExpression(out parameters);
            var lambda = Expression.Lambda(expression, parameters);
            expressionCache.TryAdd(s, lambda);
            return lambda;
        }
    }
}