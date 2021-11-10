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
using System.Text.RegularExpressions;

namespace Manufaktura.Core.Expressions.Parsers
{
    /// <summary>
    /// Parser that converts functions written as strings to MethodCallExpressions.
    /// </summary>
    public class FunctionParser : IUnaryExpressionParser
    {
        public bool IsRelevant(string s)
        {
            var regex = new Regex(@"[A-Z](.*)\(.*\)");
            return regex.IsMatch(s) && regex.Match(s).Value == s.Trim();
        }

        public Expression Parse(string s)
        {
            s = s.Trim();
            var fullName = s.Substring(0, s.IndexOf("("));
            var dotIndex = fullName.LastIndexOf(".");
            if (dotIndex == -1) throw new Exception($"You have to specify static type for function {fullName}, for example Math.Sin(30).");
            var typeName = fullName.Substring(0, dotIndex);
            var staticType = Type.GetType(typeName);
            if (staticType == null) throw new Exception($"Could not find type {typeName}.");
            var methodName = fullName.Substring(dotIndex + 1, fullName.Length - dotIndex - 1);
            var method = staticType.GetTypeInfo().GetDeclaredMethod(methodName);
            if (method == null) throw new Exception($"Could not find metehod {methodName} in type {typeName}.");
            var unparsedParameters = s.Replace(fullName, "").Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(up => up.Trim()).ToArray();
            var methodParameters = method.GetParameters();
            var paramIndex = 0;
            var parameters = unparsedParameters.Select(up =>
                {
                    var parser = UnaryExpressionParser.For(up);
                    if (up == null) throw new Exception($"Unrecognized expression {up} in parameters of function {fullName}.");
                    var parameterExpression = parser.Parse(up);
                    return Expression.Convert(parameterExpression, methodParameters[paramIndex++].ParameterType);
                }
            ).ToArray();

            return Expression.Call(method, parameters);
        }
    }
}