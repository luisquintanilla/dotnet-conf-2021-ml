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
using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using System;

namespace Manufaktura.Controls.Primitives
{
    /// <summary>
    /// Represents a 2D point.
    /// </summary>
    public struct Point
    {
        public Point(double x, double y) : this()
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; set; }

        public double Y { get; set; }

        /// <summary>
        /// Calculates beam angle
        /// </summary>
        /// <param name="beamStart">Beam start position</param>
        /// <param name="beamEnd">Beam end position</param>
        /// <returns></returns>
        public static double BeamAngle(Point beamStart, Point beamEnd)
        {
            return UsefulMath.BeamAngle(beamStart.X, beamStart.Y, beamEnd.X, beamEnd.Y);
        }

        /// <summary>
        /// Calculates distance between two points
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        /// <summary>
        /// Calculates distance between two points
        /// </summary>
        public static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }

        public override string ToString()
        {
            return $"[{X}, {Y}]";
        }

        /// <summary>
        /// Translates Point according to page margins
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public Point Translate(ScorePage page)
        {
            return new Point(this.X + (page.MarginLeft ?? 0), this.Y + (page.MarginTop ?? 0));
        }

        /// <summary>
        /// Translates Point by dx and dy coordinates
        /// </summary>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        /// <returns></returns>
        public Point Translate(double dx, double dy)
        {
            return new Point(X + dx, Y + dy);
        }

        /// <summary>
        /// Translates point by dx in given direction
        /// </summary>
        public Point TranslateByAngleOld(double angle, double length)
        {
            var dy = Math.Sin(angle) * length;
            var dx = Math.Cos(angle) * length;
            return new Point(X + dx, Y + dy);
        }

        /// <summary>
        /// Translates point by dx in given direction
        /// </summary>
        public Point TranslateByAngle(double angle, double length)
        {
            var dy = Math.Cos(angle) * length;
            var dx = Math.Sin(angle) * length;
            return new Point(X + dx, Y + dy);
        }

        /// <summary>
        /// Translates horizontally by dx but also translates vertically to maintain angle. In this method point always translates by dx regardless of angle.
        /// </summary>
        public Point TranslateHorizontallyAndMaintainAngle(double angle, double dx)
        {
            var dy = Math.Tan(angle) * dx;
            return new Point(X + dx, Y + dy);
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }
    }
}