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

using Manufaktura.Music.Extensions;

namespace Manufaktura.Controls.Primitives
{
    /// <summary>
    /// Represents pen settings used to draw objects.
    /// </summary>
    public struct Pen
    {
        /// <summary>
        /// Pen color
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Pen thickness
        /// </summary>
        public double Thickness { get; set; }

        /// <summary>
        /// Z-index
        /// </summary>
        public double ZIndex { get; set; }

        public Pen(Color color, double thickness, double zIndex)
            : this()
        {
            Thickness = thickness;
            Color = color;
            ZIndex = zIndex;
        }

        public Pen(Color color, double thickness)
            : this(color, thickness, 0)
        {
        }

        public Pen(Color color)
            : this(color, 1, 0)
        {
        }

        /// <summary>
        /// Converts pen settings to CSS style
        /// </summary>
        /// <returns></returns>
        public string ToCss()
        {
            return string.Format("fill:none;stroke:rgb({0},{1},{2});stroke-width:{3}", Color.R.ToStringInvariant(),
                Color.G.ToStringInvariant(),
                Color.B.ToStringInvariant(),
                Thickness.ToStringInvariant());
        }
    }
}