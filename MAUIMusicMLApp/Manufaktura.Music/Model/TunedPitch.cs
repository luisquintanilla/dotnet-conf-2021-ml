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
    /// Represents a pitch with a specific frequency (i.e. A4 at 440Hz, A4 at 415Hz, etc.)
    /// </summary>
    public class TunedPitch : Pitch
    {
        /// <summary>
        /// Frequency [Hz]
        /// </summary>
        public double Frequency { get; protected set; }

        /// <summary>
        /// Initializes a new instance of TunedPitch with specific pitch and frequency.
        /// </summary>
        /// <param name="pitch">Pitch</param>
        /// <param name="freq">Frequency [Hz]</param>
        public TunedPitch(Pitch pitch, double freq) : base(pitch.StepName, pitch.Alter, pitch.Octave)
        {
            Frequency = freq;
        }

        /// <summary>
        /// Returns a string value of this object (mainly for debug purposes)
        /// </summary>
        /// <returns>String value of this object (mainly for debug purposes)</returns>
        public override string ToString()
        {
            return string.Format("{0} ({1} Hz)", base.ToString(), Frequency);
        }
    }
}
