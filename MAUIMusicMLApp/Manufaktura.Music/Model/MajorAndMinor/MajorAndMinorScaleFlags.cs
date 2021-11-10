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
namespace Manufaktura.Music.Model.MajorAndMinor
{
    /// <summary>
    /// Represents flags that describe a Minor or Major scale
    /// </summary>
    public struct MajorAndMinorScaleFlags
    {
        private MajorAndMinorScaleFlags(bool isMinor, bool isFlat)
                    : this()
        {
            IsMinor = isMinor;
            IsFlat = isFlat;
        }

        /// <summary>
        /// Returns MajorAndMinorScaleFlags for Major flat scale
        /// </summary>
        public static MajorAndMinorScaleFlags MajorFlat { get { return new MajorAndMinorScaleFlags(false, true); } }

        /// <summary>
        /// Returns MajorAndMinorScaleFlags for Major sharp scale
        /// </summary>

        public static MajorAndMinorScaleFlags MajorSharp { get { return new MajorAndMinorScaleFlags(false, false); } }

        /// <summary>
        /// Returns MajorAndMinorScaleFlags for Minor flat scale
        /// </summary>

        public static MajorAndMinorScaleFlags MinorFlat { get { return new MajorAndMinorScaleFlags(true, true); } }

        /// <summary>
        /// Returns MajorAndMinorScaleFlags for Minor sharp scale
        /// </summary>

        public static MajorAndMinorScaleFlags MinorSharp { get { return new MajorAndMinorScaleFlags(true, false); } }

        /// <summary>
        /// Idicates that this scale is flat scale.
        /// </summary>
        public bool IsFlat { get; set; }

        /// <summary>
        /// Indicates that this scale is minor scale.
        /// </summary>
        public bool IsMinor { get; set; }
    }
}