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
using Manufaktura.Controls.Primitives;
using System;

namespace Manufaktura.Controls.Rendering.Snippets
{
    public struct TupletBracketDefinition
    {
        public TupletBracketDefinition(double startX, double startY, double endX, double endY)
        {
            StartPoint = new Point(startX, startY);
            EndPoint = new Point(endX, endY);
            Width = Point.Distance(StartPoint, EndPoint);
            Angle =  Point.BeamAngle(StartPoint, EndPoint);
            Point25 = StartPoint.TranslateByAngleOld(Angle, Width * 0.25);
            MidPoint = StartPoint.TranslateByAngleOld(Angle, Width * 0.5);
            Point75 = StartPoint.TranslateByAngleOld(Angle, Width * 0.75);
        }

        public double Angle { get; private set; }
        public Point EndPoint { get; private set; }
        public Point MidPoint { get; private set; }
        public Point Point25 { get; private set; }
        public Point Point75 { get; private set; }
        public Point StartPoint { get; private set; }
        public double Width { get; private set; }
    }
}