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
using System.Linq.Expressions;

namespace Manufaktura.Core.Expressions.Cutters
{
    /// <summary>
    /// Preprocessor for Power expressions.
    /// There is no power operator in C# (it's only in VB .NET) but power expression is supported (it calls Math.Pow method by default or some other method
    /// if exponentiation operator is overridden (which can be done only in VB.NET, I suppose)); Anyway, in MathConverter you can use ^ operator - it will
    /// be converted to power expression - this conversion might be faster by using Math.Pow because our FunctionParser searches all assemblies in the app domain.
    /// </summary>
    public class PowerExpressionCutter : ExpressionCutter
    {
        public override string Operator => "^";
        public override int Priority => 3;

        public override Expression CreateExpression(Expression left, Expression right)
        {
            return Expression.Power(left, right);
        }
    }
}