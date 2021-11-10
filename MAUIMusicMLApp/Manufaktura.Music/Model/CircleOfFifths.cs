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

using Manufaktura.Music.Model.MajorAndMinor;
using System;
using System.Collections.Generic;

namespace Manufaktura.Music.Model
{
    /// <summary>
    /// Helper class for calculations involving the circle of fifths.
    /// </summary>
    public static class CircleOfFifths
    {
        public static Step[] Sharps => new[] { Step.F, Step.C, Step.G, Step.D, Step.A, Step.E, Step.B };
        public static Step[] Flats => new[] { Step.B, Step.E, Step.A, Step.D, Step.G, Step.C, Step.F };

        public static IEnumerable<Step> EnumerateSharps()
        {
            while (true) foreach (var sharp in Sharps) yield return sharp;
        }

        public static IEnumerable<Step> EnumerateFlats()
        {
            while (true) foreach (var flat in Flats) yield return flat;
        }

        /// <summary>
        /// Calculates number of fiths for specific key described by midiPitch and flags.
        /// </summary>
        /// <param name="midiPitch">Midi pitch</param>
        /// <param name="flags">Key flags</param>
        /// <returns></returns>
        public static int CalculateFifths(int midiPitch, MajorAndMinorScaleFlags flags)
        {
            var fifths = 0;
            var neutralScaleTonicMidiPitch = flags.IsMinor ? Pitch.A3.MidiPitch : Pitch.C4.MidiPitch;
            var currentPitch = neutralScaleTonicMidiPitch;
            while (currentPitch != midiPitch)
            {
                if (!flags.IsFlat)
                {
                    if (currentPitch - midiPitch > Interval.PerfectFifth.Halftones)
                    {
                        currentPitch -= Interval.PerfectOctave.Halftones;
                    }
                    else
                    {
                        currentPitch += Interval.PerfectFifth.Halftones;
                        fifths++;
                    }
                }
                else
                {
                    if (currentPitch - midiPitch < Interval.PerfectFifth.MakeDescending().Halftones)
                    {
                        currentPitch += Interval.PerfectOctave.Halftones;
                    }
                    else
                    {
                        currentPitch -= Interval.PerfectFifth.Halftones;
                        fifths--;
                    }
                }
            }
            return fifths % 12;
        }

        /// <summary>
        /// Calculates number of fifths for specific key described by step and flags
        /// </summary>
        /// <param name="step"></param>
        /// <param name="flags"></param>
        /// <returns></returns>
        public static int CalculateFifths(Step step, MajorAndMinorScaleFlags flags)
        {
            return CalculateFifths(step.ToPitch(4).MidiPitch, flags);
        }

        /// <summary>
        /// Gets alteration of specific step in key described by positive or negative nuber of fifths
        /// </summary>
        /// <param name="step"></param>
        /// <param name="fifths"></param>
        /// <returns></returns>
        public static int GetAlterOfStepFromNumberOfFifths(Step step, int fifths)
        {
            int[] alterTable = new int[7];
            int numberOfStepsToAlter = Math.Abs(fifths);
            for (int i = 0; i < numberOfStepsToAlter; i++)
            {
                alterTable[i] += 1;
                if (i == 6)
                {
                    i = -1;
                    numberOfStepsToAlter -= 6;
                }
            }
            if (fifths > 0)
            {
                if (step.StepName == "C") return alterTable[1];
                else if (step.StepName == "D") return alterTable[3];
                else if (step.StepName == "E") return alterTable[5];
                else if (step.StepName == "F") return alterTable[0];
                else if (step.StepName == "G") return alterTable[2];
                else if (step.StepName == "A") return alterTable[4];
                else if (step.StepName == "B") return alterTable[6];
            }
            else if (fifths < 0)
            {
                if (step.StepName == "C") return alterTable[5] * -1;
                else if (step.StepName == "D") return alterTable[3] * -1;
                else if (step.StepName == "E") return alterTable[1] * -1;
                else if (step.StepName == "F") return alterTable[6] * -1;
                else if (step.StepName == "G") return alterTable[4] * -1;
                else if (step.StepName == "A") return alterTable[2] * -1;
                else if (step.StepName == "B") return alterTable[0] * -1;
            }

            return 0;
        }
    }
}