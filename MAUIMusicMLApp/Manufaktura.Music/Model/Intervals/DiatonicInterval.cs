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

namespace Manufaktura.Music.Model
{
    /// <summary>
    /// Represents an interval in diatonic scale (with unspecified size such as major, minor or perfect).
    /// </summary>
    public class DiatonicInterval
    {
        /// <summary>
        /// Returns a fifth
        /// </summary>
        public static DiatonicInterval Fifth { get { return new DiatonicInterval(5); } }

        /// <summary>
        /// Returns a fourth
        /// </summary>
        public static DiatonicInterval Fourth { get { return new DiatonicInterval(4); } }

        /// <summary>
        /// Returns an octave
        /// </summary>
        public static DiatonicInterval Octave { get { return new DiatonicInterval(8); } }

        /// <summary>
        /// Returns a second
        /// </summary>
        public static DiatonicInterval Second { get { return new DiatonicInterval(2); } }

        /// <summary>
        /// Returns a seventh
        /// </summary>
        public static DiatonicInterval Seventh { get { return new DiatonicInterval(7); } }

        /// <summary>
        /// Returns a sixth
        /// </summary>
        public static DiatonicInterval Sixth { get { return new DiatonicInterval(6); } }

        /// <summary>
        /// Returns a third
        /// </summary>
        public static DiatonicInterval Third { get { return new DiatonicInterval(3); } }

        /// <summary>
        /// Returns a unison
        /// </summary>
        public static DiatonicInterval Unison { get { return new DiatonicInterval(1); } }

        /// <summary>
        /// Number of steps
        /// </summary>
        public int Steps { get; protected set; }

        /// <summary>
        /// Initializes a new DiatonicInterval instance with specific number of steps
        /// </summary>
        /// <param name="steps"></param>
        public DiatonicInterval(int steps)
        {
            Steps = steps;
        }

        /// <summary>
        /// Converts interval to ascending interval.
        /// </summary>
        /// <returns>Ascending interval.</returns>
        public DiatonicInterval MakeAscending()
        {
            return new DiatonicInterval(Math.Abs(Steps));
        }

        /// <summary>
        /// Converts interval to descending interval.
        /// </summary>
        /// <returns>Descending interval.</returns>
        public DiatonicInterval MakeDescending()
        {
            return new DiatonicInterval(Math.Abs(Steps) * -1);
        }

        /// <summary>
        /// Converts diatonic interval to interval.
        /// </summary>
        /// <param name="halftones">Number of halftones</param>
        /// <returns></returns>
        public Interval ToInterval(int halftones)
        {
            return new Interval(this.Steps, halftones);
        }
    }
}