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
using Manufaktura.Music.Tuning;
using System;
using System.Collections.Generic;

namespace Manufaktura.Music.Model
{
    /// <summary>
    /// Represents a pitch.
    /// </summary>
    public class Pitch : Step, IComparable<Pitch>
    {
        private static Dictionary<string, int> pitches = new Dictionary<string, int>
        {
            {"C", 60}, {"D", 62}, {"E", 64}, {"F", 65}, {"G", 67}, {"A", 69}, {"B", 71}
        };

        public static Pitch A1 { get { return Pitch.FromStep(Step.A, 1); } }

        public static Pitch A2 { get { return Pitch.FromStep(Step.A, 2); } }

        public static Pitch A3 { get { return Pitch.FromStep(Step.A, 3); } }

        public static Pitch A4 { get { return Pitch.FromStep(Step.A, 4); } }

        public static Pitch A5 { get { return Pitch.FromStep(Step.A, 5); } }

        public static Pitch A6 { get { return Pitch.FromStep(Step.A, 6); } }

        public static Pitch Ab1 { get { return Pitch.FromStep(Step.Ab, 1); } }

        public static Pitch Ab2 { get { return Pitch.FromStep(Step.Ab, 2); } }

        public static Pitch Ab3 { get { return Pitch.FromStep(Step.Ab, 3); } }

        public static Pitch ASharp1 { get { return Pitch.FromStep(Step.ASharp, 1); } }

        public static Pitch ASharp2 { get { return Pitch.FromStep(Step.ASharp, 2); } }

        public static Pitch ASharp3 { get { return Pitch.FromStep(Step.ASharp, 3); } }

        public static Pitch ASharp4 { get { return Pitch.FromStep(Step.ASharp, 4); } }

        public static Pitch ASharp5 { get { return Pitch.FromStep(Step.ASharp, 5); } }

        public static Pitch ASharp6 { get { return Pitch.FromStep(Step.ASharp, 6); } }

        public static Pitch B1 { get { return Pitch.FromStep(Step.B, 1); } }

        public static Pitch B2 { get { return Pitch.FromStep(Step.B, 2); } }

        public static Pitch B3 { get { return Pitch.FromStep(Step.B, 3); } }

        public static Pitch B4 { get { return Pitch.FromStep(Step.B, 4); } }

        public static Pitch B5 { get { return Pitch.FromStep(Step.B, 5); } }

        public static Pitch B6 { get { return Pitch.FromStep(Step.B, 6); } }

        public static Pitch Bb1 { get { return Pitch.FromStep(Step.Bb, 1); } }

        public static Pitch Bb2 { get { return Pitch.FromStep(Step.Bb, 2); } }

        public static Pitch Bb3 { get { return Pitch.FromStep(Step.Bb, 3); } }

        public static Pitch BSharp1 { get { return Pitch.FromStep(Step.BSharp, 1); } }

        public static Pitch BSharp2 { get { return Pitch.FromStep(Step.BSharp, 2); } }

        public static Pitch BSharp3 { get { return Pitch.FromStep(Step.BSharp, 3); } }

        public static Pitch BSharp4 { get { return Pitch.FromStep(Step.BSharp, 4); } }

        public static Pitch BSharp5 { get { return Pitch.FromStep(Step.BSharp, 5); } }

        public static Pitch BSharp6 { get { return Pitch.FromStep(Step.BSharp, 6); } }

        public static Pitch C1 { get { return Pitch.FromStep(Step.C, 1); } }

        public static Pitch C2 { get { return Pitch.FromStep(Step.C, 2); } }

        public static Pitch C3 { get { return Pitch.FromStep(Step.C, 3); } }

        public static Pitch C4 { get { return Pitch.FromStep(Step.C, 4); } }

        public static Pitch C5 { get { return Pitch.FromStep(Step.C, 5); } }

        public static Pitch C6 { get { return Pitch.FromStep(Step.C, 6); } }

        public static Pitch C7 { get { return Pitch.FromStep(Step.C, 7); } }

        public static Pitch Cb1 { get { return Pitch.FromStep(Step.Cb, 1); } }

        public static Pitch Cb2 { get { return Pitch.FromStep(Step.Cb, 2); } }

        public static Pitch Cb3 { get { return Pitch.FromStep(Step.Cb, 3); } }

        public static Pitch CSharp1 { get { return Pitch.FromStep(Step.CSharp, 1); } }

        public static Pitch CSharp2 { get { return Pitch.FromStep(Step.CSharp, 2); } }

        public static Pitch CSharp3 { get { return Pitch.FromStep(Step.CSharp, 3); } }

        public static Pitch CSharp4 { get { return Pitch.FromStep(Step.CSharp, 4); } }

        public static Pitch CSharp5 { get { return Pitch.FromStep(Step.CSharp, 5); } }

        public static Pitch CSharp6 { get { return Pitch.FromStep(Step.CSharp, 6); } }

        public static Pitch CSharp7 { get { return Pitch.FromStep(Step.CSharp, 7); } }

        public static Pitch D1 { get { return Pitch.FromStep(Step.D, 1); } }

        public static Pitch D2 { get { return Pitch.FromStep(Step.D, 2); } }

        public static Pitch D3 { get { return Pitch.FromStep(Step.D, 3); } }

        public static Pitch D4 { get { return Pitch.FromStep(Step.D, 4); } }

        public static Pitch D5 { get { return Pitch.FromStep(Step.D, 5); } }

        public static Pitch D6 { get { return Pitch.FromStep(Step.D, 6); } }

        public static Pitch Db1 { get { return Pitch.FromStep(Step.Db, 1); } }

        public static Pitch Db2 { get { return Pitch.FromStep(Step.Db, 2); } }

        public static Pitch Db3 { get { return Pitch.FromStep(Step.Db, 3); } }

        public static Pitch DSharp1 { get { return Pitch.FromStep(Step.DSharp, 1); } }

        public static Pitch DSharp2 { get { return Pitch.FromStep(Step.DSharp, 2); } }

        public static Pitch DSharp3 { get { return Pitch.FromStep(Step.DSharp, 3); } }

        public static Pitch DSharp4 { get { return Pitch.FromStep(Step.DSharp, 4); } }

        public static Pitch DSharp5 { get { return Pitch.FromStep(Step.DSharp, 5); } }

        public static Pitch DSharp6 { get { return Pitch.FromStep(Step.DSharp, 6); } }

        public static Pitch E1 { get { return Pitch.FromStep(Step.E, 1); } }

        public static Pitch E2 { get { return Pitch.FromStep(Step.E, 2); } }

        public static Pitch E3 { get { return Pitch.FromStep(Step.E, 3); } }

        public static Pitch E4 { get { return Pitch.FromStep(Step.E, 4); } }

        public static Pitch E5 { get { return Pitch.FromStep(Step.E, 5); } }

        public static Pitch E6 { get { return Pitch.FromStep(Step.E, 6); } }

        public static Pitch Eb1 { get { return Pitch.FromStep(Step.Eb, 1); } }

        public static Pitch Eb2 { get { return Pitch.FromStep(Step.Eb, 2); } }

        public static Pitch Eb3 { get { return Pitch.FromStep(Step.Eb, 3); } }

        public static Pitch ESharp4 { get { return Pitch.FromStep(Step.ESharp, 4); } }

        public static Pitch ESharp5 { get { return Pitch.FromStep(Step.ESharp, 5); } }

        public static Pitch ESharp6 { get { return Pitch.FromStep(Step.ESharp, 6); } }

        public static Pitch F1 { get { return Pitch.FromStep(Step.F, 1); } }

        public static Pitch F2 { get { return Pitch.FromStep(Step.F, 2); } }

        public static Pitch F3 { get { return Pitch.FromStep(Step.F, 3); } }

        public static Pitch F4 { get { return Pitch.FromStep(Step.F, 4); } }

        public static Pitch F5 { get { return Pitch.FromStep(Step.F, 5); } }

        public static Pitch F6 { get { return Pitch.FromStep(Step.F, 6); } }

        public static Pitch Fb1 { get { return Pitch.FromStep(Step.Fb, 1); } }

        public static Pitch Fb2 { get { return Pitch.FromStep(Step.Fb, 2); } }

        public static Pitch Fb3 { get { return Pitch.FromStep(Step.Fb, 3); } }

        public static Pitch FSharp1 { get { return Pitch.FromStep(Step.FSharp, 1); } }

        public static Pitch FSharp2 { get { return Pitch.FromStep(Step.FSharp, 2); } }

        public static Pitch FSharp3 { get { return Pitch.FromStep(Step.FSharp, 3); } }

        public static Pitch FSharp4 { get { return Pitch.FromStep(Step.FSharp, 4); } }

        public static Pitch FSharp5 { get { return Pitch.FromStep(Step.FSharp, 5); } }

        public static Pitch FSharp6 { get { return Pitch.FromStep(Step.FSharp, 6); } }

        public static Pitch G1 { get { return Pitch.FromStep(Step.G, 1); } }

        public static Pitch G2 { get { return Pitch.FromStep(Step.G, 2); } }

        public static Pitch G3 { get { return Pitch.FromStep(Step.G, 3); } }

        public static Pitch G4 { get { return Pitch.FromStep(Step.G, 4); } }

        public static Pitch G5 { get { return Pitch.FromStep(Step.G, 5); } }

        public static Pitch G6 { get { return Pitch.FromStep(Step.G, 6); } }

        public static Pitch Gb1 { get { return Pitch.FromStep(Step.Gb, 1); } }

        public static Pitch Gb2 { get { return Pitch.FromStep(Step.Gb, 2); } }

        public static Pitch Gb3 { get { return Pitch.FromStep(Step.Gb, 3); } }

        public static Pitch GSharp1 { get { return Pitch.FromStep(Step.GSharp, 1); } }

        public static Pitch GSharp2 { get { return Pitch.FromStep(Step.GSharp, 2); } }

        public static Pitch GSharp3 { get { return Pitch.FromStep(Step.GSharp, 3); } }

        public static Pitch GSharp4 { get { return Pitch.FromStep(Step.GSharp, 4); } }

        public static Pitch GSharp5 { get { return Pitch.FromStep(Step.GSharp, 5); } }

        public static Pitch GSharp6 { get { return Pitch.FromStep(Step.GSharp, 6); } }

        public int MidiPitch { get; set; }

        public int Octave { get; set; }

        /// <summary>
        /// Initializes a new instance of pitch with specific step name, alteration and octave number.
        /// </summary>
        /// <param name="stepName"></param>
        /// <param name="alter"></param>
        /// <param name="octaveNumber"></param>
        public Pitch(string stepName, int alter, int octaveNumber)
        {
            StepName = stepName;
            Alter = alter;
            MidiPitch = pitches[stepName] + alter + (octaveNumber - 4) * 12;
            Octave = octaveNumber;
        }

        protected Pitch()
        {
        }

        /// <summary>
        /// Way of resolving enharmonically ambigous pitch after translation by interval.
        /// </summary>
        public enum MidiPitchTranslationMode
        {
            /// <summary>
            /// If resulting pitch is enharmonically ambigous, pitch name will be determined automatically.
            /// </summary>
            Auto,

            /// <summary>
            /// If resulting pitch is enharmonically ambigous, augmented step will be preferred.
            /// </summary>
            Sharps,

            /// <summary>
            /// If resulting pitch is enharmonically ambigous, dimnished step will be preferred.
            /// </summary>
            Flats
        }

        /// <summary>
        /// TODO: Sprawdzić czy ta metoda daje takie same efekty jak konstruktor klasy Pitch i ewentualnie wywalić
        /// </summary>
        /// <param name="stepName"></param>
        /// <param name="alter"></param>
        /// <param name="octave"></param>
        /// <returns></returns>
        public static int CalculateMidiPitch(string stepName, int alter, int octave)
        {
            int pitch;
            if (stepName == "A") pitch = 21;
            else if (stepName == "B") pitch = 23;
            else if (stepName == "C") pitch = 24;
            else if (stepName == "D") pitch = 26;
            else if (stepName == "E") pitch = 28;
            else if (stepName == "F") pitch = 29;
            else if (stepName == "G") pitch = 31;
            else return 0;
            //Dźwięki A i B(H) są w standardzie MIDI w oktawie 0:
            //Notes A0 and B0 are in octave 0 in MIDI standard:
            if ((stepName == "A") || (stepName == "B")) pitch = pitch + octave * 12;
            else pitch = pitch + (octave - 1) * 12;  //The other are in octave 1 / A pozostałe w pierwszej oktawie
            pitch = pitch + alter;
            return pitch;
        }

        /// <summary>
        /// Enumerates pitches in chromatic range between two pitches.
        /// </summary>
        /// <param name="p1">First pitch</param>
        /// <param name="p2">Second pitch</param>
        /// <param name="translationMode">Pitch naming mode</param>
        /// <returns>Enumerator of range of pitches</returns>
        public static IEnumerable<Pitch> ChromaticRange(Pitch p1, Pitch p2, MidiPitchTranslationMode translationMode)
        {
            if (p1 == p2) yield return p1;
            int direction = p1 < p2 ? 1 : -1;
            var pitch = p1;
            while (pitch != p2)
            {
                yield return pitch = Pitch.FromMidiPitch(pitch.MidiPitch + direction, translationMode);
            }
        }

        /// <summary>
        /// Converts frequency to midi pitch in a simple naive way, using equal temperament.
        /// </summary>
        /// <param name="freq">Frequency</param>
        /// <returns>Midi pitch</returns>
        public static int FrequencyToMidiPitch(double freq)
        {
            double i = 0;
            //27,5 Hz to częstotliwość dźwięku A subkontra (najniższego w standardzie MIDI)
            //27,5 Hz is the frequency of note A0 (the lowest in MIDI standard)
            while (true)
            {
                if ((freq < 27.5f * Math.Pow(2, 1.0f / 36) * Math.Pow(2, i / 12)) &&
                    (freq >= 27.5f * Math.Pow(2, -1.0f / 18) * Math.Pow(2, i / 12)))
                    break;
                i++;
                if (i > 100) break;
            }
            return (int)i + 21;
        }

        /// <summary>
        /// Creates a Pitch from midi pitch.
        /// </summary>
        /// <param name="midiPitch">Midi pitch</param>
        /// <param name="mode">Ambigous name resolving mode</param>
        /// <returns>Pitch</returns>
        public static Pitch FromMidiPitch(int midiPitch, MidiPitchTranslationMode mode)
        {
            var pitch = new Pitch();
            pitch.ApplyMidiPitch(midiPitch, mode);
            return pitch;
        }

        /// <summary>
        /// Creates Pitch from Step
        /// </summary>
        /// <param name="step"></param>
        /// <param name="octaveNumber"></param>
        /// <returns></returns>
        public static Pitch FromStep(Step step, int octaveNumber = 4)
        {
            return new Pitch { StepName = step.StepName, Alter = step.Alter, MidiPitch = pitches[step.StepName] + step.Alter + (octaveNumber - 4) * 12, Octave = octaveNumber };
        }

        public static Pitch operator -(Pitch pitch, Interval interval)
        {
            return pitch.Translate(interval.MakeDescending(), MidiPitchTranslationMode.Auto);
        }

        public static bool operator !=(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch != p2.MidiPitch;
        }

        public static Pitch operator +(Pitch pitch, Interval interval)
        {
            return pitch.Translate(interval, MidiPitchTranslationMode.Auto);
        }

        public static bool operator <(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch < p2.MidiPitch;
        }

        public static bool operator <=(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch <= p2.MidiPitch;
        }

        public static bool operator ==(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch == p2.MidiPitch;
        }

        public static bool operator >(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch > p2.MidiPitch;
        }

        public static bool operator >=(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch >= p2.MidiPitch;
        }

        /// <summary>
        /// Calculates distance between two pitches.
        /// </summary>
        /// <param name="p1">First pitch</param>
        /// <param name="p2">Second pitch</param>
        /// <returns>Step distance</returns>
        public static int StepDistance(Pitch p1, Pitch p2)
        {
            return (p1.ToStepNumber() - 1 + p1.Octave * 7) - (p2.ToStepNumber() - 1 + p2.Octave * 7);    //Kolejność p1 - p2 jest dobra. Ze względów historycznych :)
        }

        /// <summary>
        /// Calculates distance between a pitch and a pitch of element that has a pitch.
        /// </summary>
        /// <param name="h2">Element with pitch</param>
        /// <param name="p1">Pitch</param>
        /// <returns>Distance in steps</returns>
        public static int StepDistance(IHasPitch h1, Pitch p2)
        {
            return StepDistance(h1.Pitch, p2);
        }

        /// <summary>
        /// Calculates distance between a pitch and a pitch of element that has a pitch.
        /// </summary>
        /// <param name="p1">Pitch</param>
        /// <param name="h2">Element with pitch</param>
        /// <returns>Distance in steps</returns>
        public static int StepDistance(Pitch p1, IHasPitch h2)
        {
            return StepDistance(p1, h2.Pitch);
        }

        /// <summary>
        /// Calculates distance between pitches of two elements that have pitch.
        /// </summary>
        /// <param name="h1">First element with pitch</param>
        /// <param name="h2">Second element with pitch</param>
        /// <returns>Distance in steps</returns>
        public static int StepDistance(IHasPitch h1, IHasPitch h2)
        {
            return StepDistance(h1.Pitch, h2.Pitch);
        }

        public void ApplyMidiPitch(int midiPitch, MidiPitchTranslationMode mode)
        {
            int midiPitchInLowestOctave = midiPitch;

            while (midiPitchInLowestOctave > 32)
            {
                midiPitchInLowestOctave -= 12;
            }

            switch (mode)
            {
                case MidiPitchTranslationMode.Auto:
                    if (midiPitchInLowestOctave == 21) { StepName = "A"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 22) { StepName = "B"; Alter = -1; }
                    else if (midiPitchInLowestOctave == 23) { StepName = "B"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 24) { StepName = "C"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 25) { StepName = "C"; Alter = 1; }
                    else if (midiPitchInLowestOctave == 26) { StepName = "D"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 27) { StepName = "E"; Alter = -1; }
                    else if (midiPitchInLowestOctave == 28) { StepName = "E"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 29) { StepName = "F"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 30) { StepName = "F"; Alter = 1; }
                    else if (midiPitchInLowestOctave == 31) { StepName = "G"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 32) { StepName = "G"; Alter = 1; }
                    break;

                case MidiPitchTranslationMode.Sharps:
                    if (midiPitchInLowestOctave == 21) { StepName = "A"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 22) { StepName = "A"; Alter = 1; }
                    else if (midiPitchInLowestOctave == 23) { StepName = "B"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 24) { StepName = "C"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 25) { StepName = "C"; Alter = 1; }
                    else if (midiPitchInLowestOctave == 26) { StepName = "D"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 27) { StepName = "D"; Alter = 1; }
                    else if (midiPitchInLowestOctave == 28) { StepName = "E"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 29) { StepName = "F"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 30) { StepName = "F"; Alter = 1; }
                    else if (midiPitchInLowestOctave == 31) { StepName = "G"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 32) { StepName = "G"; Alter = 1; }
                    break;

                case MidiPitchTranslationMode.Flats:
                    if (midiPitchInLowestOctave == 21) { StepName = "A"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 22) { StepName = "B"; Alter = -1; }
                    else if (midiPitchInLowestOctave == 23) { StepName = "B"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 24) { StepName = "C"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 25) { StepName = "D"; Alter = -1; }
                    else if (midiPitchInLowestOctave == 26) { StepName = "D"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 27) { StepName = "E"; Alter = -1; }
                    else if (midiPitchInLowestOctave == 28) { StepName = "E"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 29) { StepName = "F"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 30) { StepName = "G"; Alter = -1; }
                    else if (midiPitchInLowestOctave == 31) { StepName = "G"; Alter = 0; }
                    else if (midiPitchInLowestOctave == 32) { StepName = "A"; Alter = -1; }
                    break;

                default:
                    throw new NotImplementedException("Unsupported midi pitch translation mode.");
            }

            if (midiPitch < 24) Octave = 0;
            else if (midiPitch < 36) Octave = 1;
            else if (midiPitch < 48) Octave = 2;
            else if (midiPitch < 60) Octave = 3;
            else if (midiPitch < 72) Octave = 4;
            else if (midiPitch < 84) Octave = 5;
            else if (midiPitch < 96) Octave = 6;
            else if (midiPitch < 108) Octave = 7;
            else if (midiPitch < 120) Octave = 8;

            this.MidiPitch = midiPitch;
        }

        public int CompareTo(Pitch other)
        {
            return MidiPitch - other.MidiPitch;
        }

        /// <summary>
        /// Flattens a pitch.
        /// </summary>
        /// <returns>Flattened pitch</returns>
        public Pitch Flatten()
        {
            return new Pitch(StepName, Alter - 1, Octave);
        }

        /// <summary>
        /// Translates a pitch down an octave.
        /// </summary>
        /// <returns>Translated pitch</returns>
        public Pitch OctaveDown()
        {
            return new Pitch(StepName, Alter, Octave - 1);
        }

        /// <summary>
        /// Translates a pitch up an octave.
        /// </summary>
        /// <returns>Translated pitch</returns>
        public Pitch OctaveUp()
        {
            return new Pitch(StepName, Alter, Octave + 1);
        }

        /// <summary>
        /// Sharpens a pitch.
        /// </summary>
        /// <returns>Sharpened pitch</returns>
        public Pitch Sharpen()
        {
            return new Pitch(StepName, Alter + 1, Octave);
        }

        /// <summary>
        /// Converts this Pitch to Step (forgets information about octave number).
        /// </summary>
        /// <returns></returns>
        public Step ToStep()
        {
            return Step.FromPitch(this);
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}", StepName, AlterToSigns(Alter), Octave);
        }

        /// <summary>
        /// Translates Pitch by specific interval.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public Pitch Translate(Interval interval, MidiPitchTranslationMode mode)
        {
            return Pitch.FromMidiPitch(MidiPitch + interval.Halftones, mode);
        }

        /// <summary>
        /// Tunes this Pitch to TunedPitch using a specific standard pitch and a specific tuning system.
        /// </summary>
        /// <param name="standardPitch">Standard pitch (i.e. A4 = 440 Hz, etc.)</param>
        /// <param name="tuningSystem"></param>
        /// <returns>Pitch with assigned frequency</returns>
        public TunedPitch Tune(TunedPitch standardPitch, TuningSystem tuningSystem)
        {
            var logarythmicProportion = tuningSystem.AllIntervalRatios[new BoundInterval(standardPitch, this)];
            var freq = standardPitch.Frequency * UsefulMath.CentsToLinear(logarythmicProportion);
            freq *= (this.Octave - standardPitch.Octave) + 1;
            return new TunedPitch(this, freq);
        }
    }
}