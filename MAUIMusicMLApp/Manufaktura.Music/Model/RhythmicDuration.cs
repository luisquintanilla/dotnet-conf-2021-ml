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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    /// <summary>
    /// Represents a rhythmic duration.
    /// </summary>
    public struct RhythmicDuration
    {
        public RhythmicDuration(int denominatorAsPowerOfTwo, int dots)
            : this()
        {
            DenominatorAsPowerOfTwo = denominatorAsPowerOfTwo;
            Dots = dots;
        }

        public RhythmicDuration(int denominatorAsPowerOfTwo)
            : this(denominatorAsPowerOfTwo, 0)
        {
        }

        /// <summary>
        /// Rhythmic duration of 128th note or rest.
        /// </summary>
		public static RhythmicDuration D128th { get { return new RhythmicDuration(7); } }

        /// <summary>
        /// Rhythmic duration of 256th note or rest.
        /// </summary>
        public static RhythmicDuration D256th { get { return new RhythmicDuration(8); } }

        /// <summary>
        /// Rhythmic duration of 32nd note or rest.
        /// </summary>
        public static RhythmicDuration D32nd { get { return new RhythmicDuration(5); } }

        /// <summary>
        /// Rhythmic duration of 64th note or rest.
        /// </summary>
        public static RhythmicDuration D64th { get { return new RhythmicDuration(6); } }

        /// <summary>
        /// Rhythmic duration of eighth note or rest.
        /// </summary>
        public static RhythmicDuration Eighth { get { return new RhythmicDuration(3); } }

        /// <summary>
        /// Rhythmic duration of half note or rest.
        /// </summary>
        public static RhythmicDuration Half { get { return new RhythmicDuration(1); } }

        /// <summary>
        /// Rhythmic duration of quarter note or rest.
        /// </summary>
        public static RhythmicDuration Quarter { get { return new RhythmicDuration(2); } }

        /// <summary>
        /// Rhythmic duration of sixteenth note or rest.
        /// </summary>
        public static RhythmicDuration Sixteenth { get { return new RhythmicDuration(4); } }

        /// <summary>
        /// Rhythmic duration of whole note or rest.
        /// </summary>
        public static RhythmicDuration Whole { get { return new RhythmicDuration(0); } }

        /// <summary>
        /// Rhythmic duration of double whole note or rest.
        /// </summary>
        public static RhythmicDuration DoubleWhole { get { return new RhythmicDuration(-1); } }

        /// <summary>
        /// Rhythmic duration denominator, i.e. 1 for whole, 2 for half, 8 for eighth, 16 for sixteenth, etc.
        /// </summary>
        public double Denominator => Math.Pow(2, DenominatorAsPowerOfTwo);

        public int DenominatorAsPowerOfTwo { get; private set; }

        /// <summary>
        /// Number of dots
        /// </summary>
		public int Dots { get; set; }

        /// <summary>
        /// Returns a clone of this RhythmicDuration object but without dots
        /// </summary>
		public RhythmicDuration WithoutDots => new RhythmicDuration(DenominatorAsPowerOfTwo);

        /// <summary>
        /// Subtracts two rhythmic durations
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
		public static Proportion operator -(RhythmicDuration d1, RhythmicDuration d2)
        {
            var sum = d1.ToProportion() - d2.ToProportion();
            return sum.Normalize();
        }

        /// <summary>
        /// Returns true if two RhythmicDurations are different
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
		public static bool operator !=(RhythmicDuration d1, RhythmicDuration d2)
        {
            return d1.Denominator != d2.Denominator || d1.Dots != d2.Dots;
        }

        /// <summary>
        /// Adds two RhythmicDurations
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
		public static Proportion operator +(RhythmicDuration d1, RhythmicDuration d2)
        {
            var sum = d1.ToProportion() + d2.ToProportion();
            return sum.Normalize();
        }

        /// <summary>
        /// Returns true if first RhythmicDuration is less than the second RhythmicDuration
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
		public static bool operator <(RhythmicDuration d1, RhythmicDuration d2)
        {
            if (d1.DenominatorAsPowerOfTwo == d2.DenominatorAsPowerOfTwo) return d1.Dots > d2.Dots;
            return d1.DenominatorAsPowerOfTwo > d2.DenominatorAsPowerOfTwo;
        }

        /// <summary>
        /// Returns true if first RhythmicDuration is less than or equal to the second RhythmicDuration
        /// </summary>
        public static bool operator <=(RhythmicDuration d1, RhythmicDuration d2)
        {
            if (d1.DenominatorAsPowerOfTwo == d2.DenominatorAsPowerOfTwo) return d1.Dots >= d2.Dots;
            return d1.DenominatorAsPowerOfTwo > d2.DenominatorAsPowerOfTwo;
        }

        /// <summary>
        /// Returns true if first RhythmicDuration is equal to the second RhythmicDuration
        /// </summary>
        public static bool operator ==(RhythmicDuration d1, RhythmicDuration d2)
        {
            return d1.DenominatorAsPowerOfTwo == d2.DenominatorAsPowerOfTwo && d1.Dots == d2.Dots;
        }

        /// <summary>
        /// Returns true if first RhythmicDuration is greater than the second RhythmicDuration
        /// </summary>
        public static bool operator >(RhythmicDuration d1, RhythmicDuration d2)
        {
            if (d1.DenominatorAsPowerOfTwo == d2.DenominatorAsPowerOfTwo) return d1.Dots < d2.Dots;
            return d1.DenominatorAsPowerOfTwo < d2.DenominatorAsPowerOfTwo;
        }

        /// <summary>
        /// Returns true if first RhythmicDuration is greater than or equal to the second RhythmicDuration
        /// </summary>
        public static bool operator >=(RhythmicDuration d1, RhythmicDuration d2)
        {
            if (d1.DenominatorAsPowerOfTwo == d2.DenominatorAsPowerOfTwo) return d1.Dots <= d2.Dots;
            return d1.DenominatorAsPowerOfTwo < d2.DenominatorAsPowerOfTwo;
        }

        /// <summary>
        /// Parses RhythmicDuration from a string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
		public static RhythmicDuration Parse(string s)
        {
            var numberOfDots = s.ToCharArray().Count(c => c == '.');
            int denominator;
            if (!int.TryParse(s.Replace(".", ""), out denominator)) throw new Exception("Could not parse string. Unrecognized duration.");

            var denominatorAsPowerOfTwo = UsefulMath.Log2(denominator);
            return new RhythmicDuration(denominatorAsPowerOfTwo, numberOfDots);
        }

        public static IEnumerable<RhythmicDuration> Parse(string s, string separator)
        {
            var result = new List<RhythmicDuration>();
            foreach (var substring in s.Split(separator.ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
            {
                result.Add(Parse(substring));
            }
            return result;
        }

        public static IEnumerable<RhythmicDuration> Parse(params int[] durations)
        {
            return durations.Select(i =>
            {
                var denominatorAsPowerOfTwo = UsefulMath.Log2(i);
                return new RhythmicDuration(denominatorAsPowerOfTwo);
            }).ToArray();
        }

        public static bool TryParse(string s, out RhythmicDuration duration)
        {
            int val;
            if (!int.TryParse(s, out val))
            {
                duration = default(RhythmicDuration);
                return false;
            }
            var denominatorAsPowerOfTwo = UsefulMath.Log2(val);
            duration = new RhythmicDuration(denominatorAsPowerOfTwo);
            return true;
        }

        /// <summary>
        /// Returns a RhythmicDuration with a specific number of dots added
        /// </summary>
        /// <param name="dots"></param>
        /// <returns></returns>
		public RhythmicDuration AddDots(int dots)
        {
            return new RhythmicDuration(DenominatorAsPowerOfTwo, dots);
        }

#if !CSHTML5

        /// <summary>
        /// Returns a fraction representing this RhythmicDuration as decimal value
        /// </summary>
        /// <returns></returns>
        public decimal ToDecimal()
        {
            return ToProportion().DecimalValue;
        }

#endif

        /// <summary>
        /// Returns a fraction representing this RhythmicDuration as double value
        /// </summary>
        public double ToDouble()
        {
            return ToProportion().DoubleValue;
        }

        /// <summary>
        /// Returns a proportion of this RhythmicDuration to the second RhythmicDuration. Dots are not taken into account.
        /// For example if this RhythmicDuration is half note duration and the second duration is quarter note duration, the proportion of 4:2 will be returned.
        /// </summary>
        /// <param name="duration"></param>
        /// <returns></returns>
		public Proportion ToFractionOf(RhythmicDuration duration)
        {
            var factor = GetFactor();
            return new Proportion(((int)duration.Denominator * factor), (int)(Denominator * factor));
        }

        private int GetFactor()
        {
            var dp2 = Denominator;
            int factor = 1;
            while (dp2 < 1)
            {
                dp2 *= 2;
                factor *= 2;
            }
            return factor;
        }

        /// <summary>
        /// Converts this RhythmicDuration to fraction and returns it as Proportion structure. Dots are taken into account.
        /// </summary>
        /// <returns></returns>
		public Proportion ToProportion()
        {
            var factor = GetFactor();
            var prop = new Proportion(factor, (int)(Denominator * factor));
            for (int i = 0; i < Dots; i++)
            {
                prop += new Proportion(factor, (int)(Denominator * factor) * (int)Math.Pow(2, i + 1));
            }
            return prop;
        }

        /// <summary>
        /// Converts this RhythmicDuration to RhythmicUnit.
        /// </summary>
        /// <param name="isRest"></param>
        /// <returns></returns>
		public RhythmicUnit ToRhythmicUnit(bool isRest)
        {
            return new RhythmicUnit(this, isRest);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (var i = 0; i < Dots; i++) sb.Append(".");
            return string.Format("{0}{1}", Denominator, sb);
        }

        /// <summary>
        /// Converts this RhythmicDuration to TimeSpan for a specific Tempo.
        /// I.e. returns the real duration of this RhythmicDuration in time units for a specific Tempo.
        /// </summary>
        /// <param name="tempo"></param>
        /// <returns></returns>
		public TimeSpan ToTimeSpan(Tempo tempo)
        {
            var proportion = ToFractionOf(tempo.BeatUnit);
            return TimeSpan.FromMilliseconds(tempo.BeatTimeSpan.TotalMilliseconds * proportion.DoubleValue);
        }
    }
}