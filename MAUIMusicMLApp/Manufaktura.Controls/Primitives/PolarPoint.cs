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

namespace Manufaktura.Controls.Primitives
{
    /// <summary>
    /// Point in polar coordinates
    /// </summary>
	public struct PolarPoint
	{
        /// <summary>
        /// Initializes a new instance of PolarPoint structure
        /// </summary>
        /// <param name="angle"></param>
        /// <param name="r"></param>
		public PolarPoint(double angle, double r) : this()
		{
			Angle = angle;
			R = r;
		}

        /// <summary>
        /// Angle
        /// </summary>
		public double Angle { get; set; }

        /// <summary>
        /// Radius
        /// </summary>
		public double R { get; set; }

        /// <summary>
        /// Converts PolarPoint to carthesian coordinates
        /// </summary>
        /// <returns></returns>
		public Point ToCartesian()
		{
			return new Point(R * Math.Sin(Angle), R * Math.Cos(Angle));
		}
	}
}