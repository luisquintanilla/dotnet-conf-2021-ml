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

namespace Manufaktura.Music.Model.Intervals
{
    [Obsolete("Alpha version. Don't use it :)")]
    public class TuningDictionary : Dictionary<BoundInterval, double>
    {
        public new double this[BoundInterval interval]
        {
            get
            {
                var bin = Keys.FirstOrDefault(bi => bi.StartingPitch == interval.StartingPitch && bi.EndingPitch == interval.EndingPitch);
                if (bin != null) return base[bin];
                var startingPitch = Keys.First().StartingPitch;
                var intervalToStartingPitch = Keys.FirstOrDefault(bi => NormalizePitch(bi.StartingPitch) == NormalizePitch(startingPitch) && NormalizePitch(bi.EndingPitch) == NormalizePitch(interval.StartingPitch));
                var intervalToEndingPitch = Keys.FirstOrDefault(bi => NormalizePitch(bi.StartingPitch) == NormalizePitch(startingPitch) && NormalizePitch(bi.EndingPitch) == NormalizePitch(interval.EndingPitch));
                base[interval] = base[intervalToEndingPitch] - base[intervalToStartingPitch];
                return base[interval];
            }
            set
            {
                base[interval] = value;
            }
        }

        private Pitch NormalizePitch(Pitch p)
        {
            return Pitch.FromStep(p.ToStep(), 4);
        }
    }
}