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
using Manufaktura.Core.Expressions.Cutters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Manufaktura.Core.Expressions.Parsers
{
    public class String2ExpressionParser
    {
        private Lazy<IExpressionCutter[]> cutters;

        public String2ExpressionParser()
        {
            cutters = new Lazy<IExpressionCutter[]>(() => typeof(IExpressionCutter).GetTypeInfo().Assembly.DefinedTypes
                .Where(t => !t.IsAbstract && typeof(IExpressionCutter).GetTypeInfo().IsAssignableFrom(t))
                .Select(t => Activator.CreateInstance(t.AsType())).Cast<IExpressionCutter>().ToArray());
        }

        public List<ParameterExpression> Parameters { get; } = new List<ParameterExpression>();

        public Expression Parse(string s)
        {
            Debug.WriteLine($"Parsing expression: {s}");
            var cuttedExpression = CutExpression(s);
            if (cuttedExpression == null) return ParseUnaryExpression(s);
            return Parse(cuttedExpression);
        }

        public SplitExpression CutExpression(string s)
        {
            Debug.WriteLine($"Trying to cut expression {s}...");

            var matchingPreprocessors = cutters.Value.Where(p => s.Contains(p.Operator)).OrderBy(p => p.Priority);

            int level = 0;
            IExpressionCutter matchingCutter = null;
            int operatorIndex = 0;
            while (level <= s.MaxParenthesisLevel())
            {
                foreach (var current in IterateString(s, level, cutters.Value.Select(c => c.Operator).OrderByDescending(o => o.Length).ToArray()))
                {
                    var candidateForPreprocessor = matchingPreprocessors.FirstOrDefault(p => p.Operator == current.Current);
                    if (candidateForPreprocessor == null) continue;
                    if (matchingCutter == null || matchingCutter.Priority > candidateForPreprocessor.Priority)
                    {
                        operatorIndex = current.Index;
                        matchingCutter = candidateForPreprocessor;
                    }
                }
                if (matchingCutter == null) level++;
                else break;
            }

            if (matchingCutter != null)
            {
                var res = matchingCutter.Cut(s, operatorIndex);
                res.PreparsedLeft = CutExpression(res.Left);
                res.PreparsedRight = CutExpression(res.Right);

                return res;
            }

            return null;
        }

        private static IEnumerable<IterationResult> IterateString(string s, int parenthesisLevel, string[] availableOperators)
        {
            int currentParenthesisLevel = 0;
            for (int i = s.Length - 1; i >= 0;)
            {
                char current = s[i];
                if (current == ')') currentParenthesisLevel++;
                if (current == '(') currentParenthesisLevel--;
                if (currentParenthesisLevel != parenthesisLevel)
                {
                    i--;
                    continue;
                }

                var possibleOperators = availableOperators.Where(o => i - o.Length > 0);
                var matchingOperator = possibleOperators.FirstOrDefault(o =>
                {
                    var charactersToMatch = s.Substring(i - o.Length, o.Length);
                    return charactersToMatch == o;
                });

                if (matchingOperator != null)
                {
                    i -= matchingOperator.Length;
                    yield return new IterationResult(matchingOperator, i);
                }
                else i--;
            }
        }

        private Expression Parse(SplitExpression preparsedExpression)
        {
            var preprocessor = cutters.Value.FirstOrDefault(p => p.Operator == preparsedExpression.Operator);
            if (preprocessor == null) throw new Exception($"Unsupported operator {preparsedExpression.Operator}.");

            if (preprocessor is I3ArgumentExpressionCutter threeArgumentPreprocessor)
            {
                var firstExpression = preparsedExpression.PreparsedLeft == null ? ParseUnaryExpression(preparsedExpression.Left) : Parse(preparsedExpression.PreparsedLeft);
                if (preparsedExpression.PreparsedRight == null)
                    throw new Exception("Error in three-argument operator. Missing second and third argument.");
                var secondExpression = preparsedExpression.PreparsedRight.PreparsedLeft == null ? ParseUnaryExpression(preparsedExpression.PreparsedRight.Left) : Parse(preparsedExpression.PreparsedRight.PreparsedLeft);
                var thirdExpression = preparsedExpression.PreparsedRight.PreparsedRight == null ? ParseUnaryExpression(preparsedExpression.PreparsedRight.Right) : Parse(preparsedExpression.PreparsedRight.PreparsedRight);

                return threeArgumentPreprocessor.CreateExpression(firstExpression, secondExpression, thirdExpression);
            }
            else
            {
                var leftExpression = preparsedExpression.PreparsedLeft == null ? ParseUnaryExpression(preparsedExpression.Left) : Parse(preparsedExpression.PreparsedLeft);
                var rightExpression = preparsedExpression.PreparsedRight == null ? ParseUnaryExpression(preparsedExpression.Right) : Parse(preparsedExpression.PreparsedRight);

                return preprocessor.CreateExpression(leftExpression, rightExpression);
            }
        }

        private Expression ParseUnaryExpression(string s)
        {
            var relevantParser = UnaryExpressionParser.For(s);
            if (relevantParser == null) throw new Exception($"Unrecognized expression {s}.");

            var expression = relevantParser.Parse(s);
            var parameterExpression = expression as ParameterExpression;
            if (parameterExpression != null)
            {
                Parameters.Add(parameterExpression);
            }
            else if (expression.NodeType == ExpressionType.Not)
            {
                Parameters.Add(((UnaryExpression)expression).Operand as ParameterExpression);
            }
            else if (expression.NodeType == ExpressionType.Call)
            {
                var methodCallExpression = expression as MethodCallExpression;
                foreach (var param in methodCallExpression.Arguments)
                {
                    var paramExpression = ((UnaryExpression)param).Operand as ParameterExpression ?? param as ParameterExpression;
                    Parameters.Add(paramExpression);
                }
            }

            return expression;
        }

        private class IterationResult
        {
            public IterationResult(string current, int index)
            {
                Current = current;
                Index = index;
            }

            public string Current { get; private set; }
            public int Index { get; private set; }
        }
    }
}