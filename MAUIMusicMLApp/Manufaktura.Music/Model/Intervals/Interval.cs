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
    /// Represents an interval with specific number of steps and halftones.
    /// </summary>
    public class Interval : DiatonicInterval
    {
        /// <summary>
        /// Returns one halftone.
        /// </summary>
        public static int HalfTone = 1;

        /// <summary>
        /// Returns number of halftones in tritone (6).
        /// </summary>
        public static int Tritone = 6;

        /// <summary>
        /// Returns number of halftones in whole tone (2).
        /// </summary>
        public static int WholeTone = 2;

        public static Interval AugmentedFifth { get { return new Interval(5, 8); } }

        public static Interval AugmentedFourth { get { return new Interval(4, Tritone); } }

        public static Interval AugmentedSecond { get { return new Interval(2, 3); } }

        public static Interval AugmentedSeventh { get { return new Interval(7, 12); } }

        public static Interval AugmentedThird { get { return new Interval(3, 5); } }

        public static Interval AugmentedUnison { get { return new Interval(1, HalfTone); ; } }

        public static Interval DimnishedFifth { get { return new Interval(5, Tritone); } }

        public static Interval DimnishedFourth { get { return new Interval(4, 4); } }

        public static Interval DimnishedOctave { get { return new Interval(8, 11); } }

        public static Interval DimnishedSeventh { get { return new Interval(7, 9); } }

        public static Interval DimnishedSixth { get { return new Interval(6, 7); } }

        public static Interval DimnishedThird { get { return new Interval(3, 2); } }

        public static Interval MajorSecond { get { return new Interval(2, WholeTone); } }

        public static Interval MajorSeventh { get { return new Interval(7, 11); } }

        public static Interval MajorSixth { get { return new Interval(6, 9); } }

        public static Interval MajorThird { get { return new Interval(3, 4); } }

        public static Interval MinorSecond { get { return new Interval(2, HalfTone); } }

        public static Interval MinorSeventh { get { return new Interval(7, 10); } }

        public static Interval MinorSixth { get { return new Interval(6, 8); } }

        public static Interval MinorThird { get { return new Interval(3, 3); } }

        public static Interval PerfectFifth { get { return new Interval(5, 7); } }

        public static Interval PerfectFourth { get { return new Interval(4, 5); } }

        public static Interval PerfectOctave { get { return new Interval(8, 12); } }

        public static Interval PerfectUnison { get { return new Interval(1, 0); } }

        /// <summary>
        /// Number of halftones in interval.
        /// </summary>
        public int Halftones { get; protected set; }

        /// <summary>
        /// Initializes a new instance of Interval with specific number of steps and halftones.
        /// </summary>
        /// <param name="steps">Steps</param>
        /// <param name="halftones">Halftones</param>
        public Interval(int steps, int halftones)
            : base(steps)
        {
            Halftones = halftones;
        }

        /// <summary>
        /// Returns an interval between two pitches.
        /// </summary>
        /// <param name="p1">First pitch</param>
        /// <param name="p2">Second pitch</param>
        /// <returns>Interval between two pitches.</returns>
        public static Interval Between(Pitch p1, Pitch p2)
        {
            return new Interval(p2.ToStep().ToStepNumber() - p1.ToStep().ToStepNumber() + 1, (p2.MidiPitch - p1.MidiPitch) % 12);
        }

        /// <summary>
        /// Converts interval to ascending interval.
        /// </summary>
        /// <returns>Ascending interval</returns>
        public new Interval MakeAscending()
        {
            return new Interval(Math.Abs(Steps), Math.Abs(Halftones));
        }

        /// <summary>
        /// Converts interval to descending interval.
        /// </summary>
        /// <returns>Descending interval</returns>
        public new Interval MakeDescending()
        {
            return new Interval(Math.Abs(Steps) * -1, Math.Abs(Halftones) * -1);
        }

        public override string ToString()
        {
            if (this == PerfectUnison) return "Perfect unison";
            if (this == PerfectFifth) return "Perfect fifth";
            if (this == PerfectFourth) return "Perfect fourth";
            if (this == PerfectOctave) return "Perfect octave";
            return string.Format("Steps: {0}, Halftones: {1}", Steps, Halftones);
        }
    }
}