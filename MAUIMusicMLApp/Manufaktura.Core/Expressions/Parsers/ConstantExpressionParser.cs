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
using System.Globalization;
using System.Linq.Expressions;

namespace Manufaktura.Core.Expressions.Parsers
{
    /// <summary>
    /// Parser that converts strings to ConstantExpressions
    /// </summary>
    public class ConstantExpressionParser : IUnaryExpressionParser
    {
        public bool IsRelevant(string s)
        {
            return double.TryParse(s.StripParentheses(), NumberStyles.Number, CultureInfo.InvariantCulture, out _) || bool.TryParse(s.StripParentheses(), out _);
        }

        public Expression Parse(string s)
        {
            double parsedDouble;
            if (double.TryParse(s.StripParentheses(), NumberStyles.Number, CultureInfo.InvariantCulture, out parsedDouble)) return Expression.Constant(parsedDouble);

            bool parsedBool;
            if (bool.TryParse(s.StripParentheses(), out parsedBool)) return Expression.Constant(parsedBool);

            throw new Exception($"Could not parse constant value {s}.");
        }
    }
}