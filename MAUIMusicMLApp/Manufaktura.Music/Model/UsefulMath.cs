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
using System.Globalization;
using System.Linq;

namespace Manufaktura.Music.Model
{
    /// <summary>
    /// Math methods useful for music usage
    /// </summary>
	public static class UsefulMath
    {
        /// <summary>
        /// Calculates angle of note beam
        /// </summary>
        /// <param name="beamStartX">Beam start X coordinate</param>
        /// <param name="beamStartY">Beam start Y coordinate</param>
        /// <param name="beamEndX">Beam end X coordinate</param>
        /// <param name="beamEndY">Beam end Y coordinate</param>
        /// <returns></returns>
		public static double BeamAngle(double beamStartX, double beamStartY, double beamEndX, double beamEndY)
        {
            if (beamEndX - beamStartX == 0) return 0;
            return Math.Atan((beamEndY - beamStartY) / (beamEndX - beamStartX));
        }

        /// <summary>
        /// Converts cents (logarythmic interval units) to linear proportion
        /// </summary>
        /// <param name="cents">Cents</param>
        /// <returns>Linear proportion</returns>
		public static double CentsToLinear(double cents)
        {
            return Math.Pow(2, cents / 1200);
        }

        /// <summary>
        /// Converts angle in grads to radians
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
		public static double GradToRadians(double angle)
        {
            return angle * (Math.PI / 180d);
        }

        public static int Log2(int number)
        {
            if (number <= 0) throw new Exception("Number must be greater than or equal 0.");
            if (number == 1) return 0;
            if (!IsPowerOfTwo(number)) throw new Exception("Number must be power of 2.");

            var logarithm = 0;
            while (Math.Pow(2, logarithm) != number) logarithm++;
            return logarithm;
        }

        public static bool IsPowerOfTwo(int x) => (x & (x - 1)) == 0;

        /// <summary>
        /// Returns mean value of double values
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
		public static double Mean(params double[] values)
        {
            if (values == null) throw new ArgumentNullException(nameof(values));
            return (double)values.Sum(t => t) / values.Count();
        }

        /// <summary>
        /// Returns median value of double values
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
		public static double Median(params double[] values)
        {
            if (values == null) throw new ArgumentNullException(nameof(values));

            int valuesCount = values.Count();
            if (valuesCount == 0) return default(double);
            if (valuesCount == 1) return values.First();
            var sortedValues = values.OrderBy(v => v).ToArray();
            int midIndex = valuesCount / 2;
            if (valuesCount % 2 == 0)
            {
                return Mean(sortedValues[midIndex - 1], sortedValues[midIndex]);
            }
            else
            {
                return sortedValues[midIndex];
            }
        }

        public static string NumberToOrdinal(int number)
        {
            if (number == 1) return "1st";
            if (number == 2) return "2nd";
            if (number == 3) return "3rd";
            if (number > 3) return number + "th";
            else return number.ToString();
        }

        /// <summary>
        /// Returns stem end position for middle note in a group of notes under one beam.
        /// </summary>
        /// <param name="firstNote"></param>
        /// <param name="lastNote"></param>
        /// <param name="searchedNote"></param>
        /// <returns></returns>
        public static double StemEnd(double firstNoteX, double firstNoteY, double middleNoteX, double lastNoteX, double lastNoteY)
        {
            var firstToMiddleX = middleNoteX - firstNoteX;
            var lastToFirstX = lastNoteX - firstNoteX;
            var lastToFirstY = lastNoteY - firstNoteY;
            if (lastToFirstX == 0) return 0;
            return (firstToMiddleX * lastToFirstY) / lastToFirstX;
        }

        public static double? TryParse(string s)
        {
            double result;
            if (double.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out result)) return result;
            return null;
        }

        public static DateTime? TryParseDateTime(string s)
        {
            DateTime result;
            if (DateTime.TryParse(s, out result)) return result;
            return null;
        }

        public static int? TryParseInt(string s)
        {
            int result;
            if (int.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out result)) return result;
            return null;
        }
    }
}