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
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Music.MelodicTrails
{
    /// <summary>
    /// This class builds melodic trails by randomizing intervals
    /// </summary>
    public abstract class RandomIntervalsMelodicTrail : IMelodicTrail
    {
        /// <summary>
        /// Allowed intervals with weights
        /// </summary>
        public abstract Dictionary<DiatonicInterval, double> AllowedIntervals { get; }

        /// <summary>
        /// Maximum number of notes to generate.
        /// </summary>
        public int MaxNotes { get; set; }

        /// <summary>
        /// Highest allowed pitch.
        /// </summary>
        public Pitch MaxPitch { get; set; }

        /// <summary>
        /// Minimum number of notes to generate.
        /// </summary>
        public int MinNotes { get; set; }

        /// <summary>
        /// Lowest allowed pitch.
        /// </summary>
        public Pitch MinPitch { get; set; }

        protected RandomIntervalsMelodicTrail()
        {
            MinPitch = Pitch.FromMidiPitch(0, Pitch.MidiPitchTranslationMode.Auto);
            MaxPitch = Pitch.FromMidiPitch(int.MaxValue, Pitch.MidiPitchTranslationMode.Auto);
            MinNotes = 2;
            MaxNotes = 10;
        }

        /// <summary>
        /// Initializes a new instance of RandomIntervalsMelodicTrail.
        /// </summary>
        /// <param name="minPitch">Lowest allowed pitch.</param>
        /// <param name="maxPitch">Highest allowed pitch.</param>
        /// <param name="minNotes">Minimum number of notes to generate.</param>
        /// <param name="maxNotes">Maximum number of notes to generate.</param>
        protected RandomIntervalsMelodicTrail(Pitch minPitch, Pitch maxPitch, int minNotes, int maxNotes)
        {
            MinPitch = minPitch;
            MaxPitch = maxPitch;
            MinNotes = minNotes;
            MaxNotes = maxNotes;
        }

        /// <summary>
        /// Builds random melody on specific scale
        /// </summary>
        /// <param name="scale">Scale</param>
        /// <param name="startingPitch">Starting pitch</param>
        /// <returns>Random melody</returns>
        public IEnumerable<Pitch> BuildMelody(Scale scale, Pitch startingPitch)
        {
            if (MinNotes < 1) throw new ArgumentException("MinNotes must be greater than 0.", "MinNotes");
            if (MinNotes > MaxNotes) throw new ArgumentException("MinNotes must not be greater than MaxNotes.", "MinNotes");

            var randomGenerator = new Random((int)DateTime.Now.Ticks);
            var numberOfNotes = randomGenerator.Next(MinNotes, MaxNotes);

            var sumOfWeights = AllowedIntervals.Sum(ai => ai.Value);
            var sortedIntervals = AllowedIntervals.OrderBy(ai => ai.Value).ToList();
            var newSortedIntervals = new List<KeyValuePair<DiatonicInterval, double>>();
            double previousValues = 0;
            foreach (var kvp in sortedIntervals)
            {
                newSortedIntervals.Add(new KeyValuePair<DiatonicInterval, double>(kvp.Key, kvp.Value + previousValues));
                previousValues += kvp.Value;
            }
            sortedIntervals = newSortedIntervals;

            var melody = new List<Pitch> { startingPitch };
            for (var i = 1; i < numberOfNotes; i++)
            {
                var randomNumber = randomGenerator.NextDouble() * sumOfWeights;
                var interval = sortedIntervals.Where(ai => ai.Value >= randomNumber).First().Key;
                var newPitch = scale.TranslatePitch(melody.Last(), interval);
                if (newPitch > MaxPitch || newPitch < MinPitch)
                {
                    interval = OnAmbitusExceeded(interval, newPitch);
                    newPitch = scale.TranslatePitch(melody.Last(), interval);
                }
                melody.Add(newPitch);
            }
            return melody;
        }

        protected virtual DiatonicInterval OnAmbitusExceeded(DiatonicInterval generatedInterval, Pitch generatedPitch)
        {
            return generatedInterval;
        }
    }
}