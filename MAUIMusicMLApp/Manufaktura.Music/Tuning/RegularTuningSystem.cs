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
using Manufaktura.Music.Model.Intervals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Tuning
{
    /// <summary>
    /// Base class for creating tunings based on various algorithms. In algorithmic tunings
    /// octaves can be imperfect and interval ratios may vary in different keys.
    /// </summary>
    public abstract class RegularTuningSystem : TuningSystem
    {
        public abstract TunedInterval GetGenerator(int tuningIteration);
        public Pitch StartingPitch { get; protected set; }

        /// <summary>
        /// Returns a comma between last interval and perfect octave (a Pythagorean Comma in Pythagorean Tuning).
        /// </summary>
        public double CommaBetweenLastIntervalAndPerfectOctave
        {
            get;
            protected set;
        }

        protected RegularTuningSystem(Pitch startingPitch)
        {
            StartingPitch = startingPitch;
            AllIntervalRatios = new TuningDictionary();
            GenerateIntervals();
        }

        protected virtual void GenerateIntervals()
        {
            var intervals = new List<double>();

            var currentProportion = new Proportion(1, 1);
            var currentPitch = StartingPitch;
            var endPitch = StartingPitch.OctaveUp();
            var iteration = 0;
            do
            {
                var generator = GetGenerator(iteration);
                currentProportion = (currentProportion * generator.IntervalProportion).Normalize();
                currentPitch = currentPitch.Translate(generator.Interval, Pitch.MidiPitchTranslationMode.Auto);
                while (currentProportion > Proportion.Dupla)
                {
                    currentProportion /= 2;
                    currentPitch = currentPitch.OctaveDown();
                }
                AllIntervalRatios[new BoundInterval(StartingPitch, currentPitch)] = currentProportion.Cents;
                intervals.Add(currentProportion.Cents);
                iteration++;
            }
            while (Math.Abs(currentPitch.MidiPitch - endPitch.MidiPitch) % 12 != 0);
            CommaBetweenLastIntervalAndPerfectOctave = intervals.Last();
        }


        public override IEnumerable<double> TuneScale(Scale scale)
        {
            throw new NotImplementedException();
        }
    }
}
