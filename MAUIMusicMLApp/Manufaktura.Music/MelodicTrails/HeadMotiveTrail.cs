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
using Manufaktura.Music.Model;
using System.Collections.Generic;

namespace Manufaktura.Music.MelodicTrails
{
    /// <summary>
    /// Generates random melodies in head motive style (like head motive in fugues, etc.)
    /// </summary>
    public class HeadMotiveTrail : RandomIntervalsMelodicTrail
    {
        private Dictionary<DiatonicInterval, double> allowedIntervals = new Dictionary<DiatonicInterval, double>
        {
            {DiatonicInterval.Fifth, 10},
            {DiatonicInterval.Fourth, 10},
            {DiatonicInterval.Octave, 5},
            {DiatonicInterval.Sixth, 3},
            {DiatonicInterval.Third, 3},
            {DiatonicInterval.Fifth.MakeDescending(), 10},
            {DiatonicInterval.Fourth.MakeDescending(), 10},
            {DiatonicInterval.Octave.MakeDescending(), 5},
            {DiatonicInterval.Sixth.MakeDescending(), 3},
            {DiatonicInterval.Third.MakeDescending(), 3}
        };

        public override Dictionary<DiatonicInterval, double> AllowedIntervals
        {
            get { return allowedIntervals; }
        }

        public HeadMotiveTrail(Pitch minPitch, Pitch maxPitch, int minNotes, int maxNotes)
            : base(minPitch, maxPitch, minNotes, maxNotes)
        {
        }

        protected override DiatonicInterval OnAmbitusExceeded(DiatonicInterval generatedInterval, Pitch generatedPitch)
        {
            if (generatedPitch > MaxPitch) generatedInterval = generatedInterval.MakeDescending();
            if (generatedPitch < MinPitch) generatedInterval = generatedInterval.MakeAscending();
            return generatedInterval;
        }
    }
}