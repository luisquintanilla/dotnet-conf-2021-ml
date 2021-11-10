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

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a slur.
    /// </summary>
    public class Slur : IHasCustomXPosition, IHasCustomYPosition
    {
        public Slur()
        {
            Type = NoteSlurType.None;
        }

        public Slur(NoteSlurType type)
        {
            Type = type;
        }

        public double? BezierX { get; set; }
        public double? BezierY { get; set; }

        public Point BezierControlPoint => BezierX.HasValue && BezierY.HasValue ? new Point(BezierX.Value, BezierY.Value) : default(Point);
        public double? DefaultXPosition { get; set; }
        public double? DefaultYPosition { get; set; }
        public bool IsDefinedAsBezierCurve => false;// DefaultXPosition.HasValue && DefaultYPosition.HasValue && BezierX.HasValue && BezierY.HasValue;
        public int Number { get; set; }
        public VerticalPlacement? Placement { get; set; }
        public Point BezierStartOrEndPoint => DefaultXPosition.HasValue && DefaultYPosition.HasValue ? new Point(DefaultXPosition.Value, DefaultYPosition.Value) : default(Point);
        public NoteSlurType Type { get; set; }
    }
}