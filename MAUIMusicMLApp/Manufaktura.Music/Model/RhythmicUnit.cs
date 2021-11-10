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
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Music.Model
{
    /// <summary>
    /// Structure that represents a RhythicDuration with additional flag that tells if this is a duration of note or a rest.
    /// </summary>
    public struct RhythmicUnit
    {
        public RhythmicUnit(RhythmicDuration duration, bool isRest) : this()
        {
            Duration = duration;
            IsRest = isRest;
        }

        /// <summary>
        /// RhythmicDuration of this RhythmicUnit
        /// </summary>
        public RhythmicDuration Duration { get; set; }

        /// <summary>
        /// True if this RhythmicUnit represents a duration of a Rest.
        /// </summary>
        public bool IsRest { get; set; }

        public static IEnumerable<RhythmicUnit> Parse(string s, string separator)
        {
            return RhythmicDuration.Parse(s, separator).Select(d => d.ToRhythmicUnit(false));
        }

        public static IEnumerable<RhythmicUnit> Parse(params int[] durations)
        {
            return RhythmicDuration.Parse(durations).Select(d => new RhythmicUnit(d, false)).ToArray();
        }
    }
}