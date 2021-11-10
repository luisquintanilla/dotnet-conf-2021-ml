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
    /// Represents a tempo.
    /// </summary>
    public struct Tempo
    {
        /// <summary>
        /// Beat unit (i.e. quarter, half, etc.)
        /// </summary>
        public RhythmicDuration BeatUnit { get; set; }

        /// <summary>
        /// Indicates how many BeatUnits are played per minute.
        /// </summary>
        public int BeatsPerMinute { get; set; }

        /// <summary>
        /// Duration of a single beat.
        /// </summary>
        public TimeSpan BeatTimeSpan
        {
            get
            {
                return TimeSpan.FromSeconds(60d / BeatsPerMinute);
            }
        }

        public Tempo(RhythmicDuration beatUnit, int beatsPerMinute) : this()
        {
            BeatUnit = beatUnit;
            BeatsPerMinute = beatsPerMinute;
        }

        /// <summary>
        /// Returns a tempo of q=120.
        /// </summary>
        public static Tempo Allegro { get { return new Tempo(RhythmicDuration.Quarter, 120); } }

        /// <summary>
        /// Returns a tempo of q=80.
        /// </summary>
        public static Tempo Andante { get { return new Tempo(RhythmicDuration.Quarter, 80); } }

        /// <summary>
        /// Returns a tempo of q=40.
        /// </summary>
        public static Tempo Adagio { get { return new Tempo(RhythmicDuration.Quarter, 40); } }
    }
}