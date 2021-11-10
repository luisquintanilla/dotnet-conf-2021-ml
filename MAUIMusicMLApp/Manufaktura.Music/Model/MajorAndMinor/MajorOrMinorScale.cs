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

namespace Manufaktura.Music.Model.MajorAndMinor
{
    /// <summary>
    /// Represents major or minor scale
    /// </summary>
    public abstract class MajorOrMinorScale : Scale
    {
        /// <summary>
        /// Number of fifths (positive or negative)
        /// </summary>
        public int Fifths { get; protected set; }

        /// <summary>
        /// Tonic step (keynote)
        /// </summary>
        public Step Tonic { get; protected set; }

        /// <summary>
        /// Initializes a new instance of MajorOrMinorScale based on specific midiPitch and MajorAndMinorScaleFlags
        /// </summary>
        /// <param name="midiPitch"></param>
        /// <param name="flags"></param>
        protected MajorOrMinorScale(int midiPitch, MajorAndMinorScaleFlags flags)
            : base(GetMode(flags.IsMinor), midiPitch, flags.IsFlat ? Pitch.MidiPitchTranslationMode.Flats : Pitch.MidiPitchTranslationMode.Sharps)
        {
            Tonic = Pitch.FromMidiPitch(midiPitch, MidiPitchTranslationMode);
            Fifths = CircleOfFifths.CalculateFifths(Tonic, flags);
        }

        /// <summary>
        /// Initialized a new instance of MajorAndMinorScale based on specific step and MajorAndMinorScaleFlags
        /// </summary>
        /// <param name="step"></param>
        /// <param name="flags"></param>
        protected MajorOrMinorScale(Step step, MajorAndMinorScaleFlags flags)
            : base(GetMode(flags.IsMinor), Pitch.FromStep(step).MidiPitch, flags.IsFlat ? Pitch.MidiPitchTranslationMode.Flats : Pitch.MidiPitchTranslationMode.Sharps)
        {
            Fifths = CircleOfFifths.CalculateFifths(step, flags);
            if (CircleOfFifths.GetAlterOfStepFromNumberOfFifths(step, Fifths) != step.Alter)
            {
                throw new MalformedScaleException(string.Format("There is no {0} {1} scale beginning on step {2}.",
                    flags.IsMinor ? "minor" : "major", flags.IsFlat ? "flat" : (Math.Abs(Fifths) > 0 ? "sharp" : "natural"), step));
            }

            Tonic = step;
        }

        /// <summary>
        /// Returns a proper Mode class (MinorMode or MajorMode).
        /// </summary>
        /// <param name="isMinor">If true returns MinorMode. Otheerwise returnsa MajorMode.</param>
        /// <returns></returns>
        public static Mode GetMode(bool isMinor)
        {
            return isMinor ? (Mode)new MinorMode() : new MajorMode();
        }
    }
}