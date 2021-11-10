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
    /// Contains historic interval names
    /// </summary>
    public static class HistoricIntervalNames
    {
        /// <summary>
        /// Returns a perfect unison interval
        /// </summary>
        public static Interval Unisonus { get { return Interval.PerfectUnison; } }
        /// <summary>
        /// Returns a augmented unison interval
        /// </summary>
        public static Interval UnisonusSuperflua { get { return Interval.AugmentedUnison; } }
        /// <summary>
        /// Returns a minor second interval
        /// </summary>
        public static Interval Semitonus { get { return Interval.MinorSecond; } }
        /// <summary>
        /// Returns a major second interval
        /// </summary>
        public static Interval Tonus { get { return Interval.MajorSecond; } }
        /// <summary>
        /// Returns a minor third interval
        /// </summary>
        public static Interval Semiditonus { get { return Interval.MinorThird; } }
        public static Interval Ditonus { get { return Interval.MajorThird; } }
        public static Interval Semidiatessaron { get { return Interval.DimnishedFourth; } }
        public static Interval Diatessaron { get { return Interval.PerfectFourth; } }
        public static Interval Tritonus { get { return Interval.AugmentedFourth; } }
        public static Interval Semitritonus { get { return Interval.DimnishedFifth; } }
        public static Interval Semidiapente { get { return Interval.DimnishedFifth; } }
        public static Interval Diapente { get { return Interval.PerfectFifth; } }
        public static Interval DiapenteSuperflua { get { return Interval.AugmentedFifth; } }
        public static Interval Semihexachordum { get { return Interval.DimnishedSixth; } }
        public static Interval HexachordumMinus { get { return Interval.MinorSixth; } }
        public static Interval HexachordumMaius { get { return Interval.MajorSixth; } }
        public static Interval TonusCumDiapente { get { return Interval.MajorSixth; } }
        public static Interval Pentatonus { get { return Interval.MinorSeventh; } }
        public static Interval HeptachordumMinus { get { return Interval.MinorSeventh; } }
        public static Interval HeptachordumMaius { get { return Interval.MajorSeventh; } }
        public static Interval HeptachordumSuperflua { get { return Interval.AugmentedSeventh; } }
        public static Interval Semidiapason { get { return Interval.DimnishedOctave; } }
        /// <summary>
        /// Returns a perfect ovtave interval
        /// </summary>
        public static Interval Diapason { get { return Interval.PerfectOctave; } }

    }
}
