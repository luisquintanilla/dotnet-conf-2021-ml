using Manufaktura.Core.Expressions.Parsers;
using System.Collections.Concurrent;
using System.Linq;
using System.Linq.Expressions;

namespace Manufaktura.Core.Expressions.Extensions
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