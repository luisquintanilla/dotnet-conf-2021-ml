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
using Manufaktura.Controls.Formatting;
using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Manufaktura.Controls.Extensions
{
    /// <summary>
    /// Extension methods for building staves fluent way
    /// </summary>
	public static class StaffBuilder
    {
        /// <summary>
        /// Adds dots to notes
        /// </summary>
        /// <param name="notes"></param>
        /// <param name="dots"></param>
        /// <returns></returns>
		public static IEnumerable<Note> AddDots(this IEnumerable<Note> notes, params int[] dots)
        {
            if (notes.Count() != dots.Length) throw new Exception("Dots must have the same count as notes.");
            int i = 0;
            foreach (var n in notes)
            {
                n.NumberOfDots = dots[i];
                i++;
            }
            return notes;
        }

        /// <summary>
        /// Creates chord from notes
        /// </summary>
        /// <param name="notes">Notes</param>
        /// <returns>Chord</returns>
        public static IEnumerable<Note> MakeChord(this IEnumerable<Note> notes)
        {
            foreach (var note in notes.Skip(1))
            {
                note.IsUpperMemberOfChord = true;
            }
            return notes;
        }

        /// <summary>
        /// Applies lyrics to notes. Text is split into syllables with '-' sign and subsequent syllables are assigned to subsequent notes.
        /// </summary>
        /// <param name="notes"></param>
        /// <param name="text"></param>
        /// <returns></returns>
		public static IEnumerable<NoteOrRest> AddLyrics(this IEnumerable<NoteOrRest> notes, string text)
        {
            var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var noteQueue = new Queue<NoteOrRest>();
            foreach (var n in notes) noteQueue.Enqueue(n);

            var syllableQueue = new Queue<Lyrics.Syllable>();
            foreach (var word in words)
            {
                var syllables = word.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var syllable in syllables)
                {
                    var syllableType = SyllableType.Middle;
                    if (syllables.Length == 1) syllableType = SyllableType.Single;
                    else if (syllable == syllables.Last()) syllableType = SyllableType.End;
                    else if (syllable == syllables.First()) syllableType = SyllableType.Begin;

                    syllableQueue.Enqueue(new Lyrics.Syllable { Text = syllable, Type = syllableType });
                }
            }

            while (noteQueue.Count > 0 && syllableQueue.Count > 0)
            {
                var note = noteQueue.Dequeue() as Note;
                if (note == null) continue;
                var syllable = syllableQueue.Dequeue();

                note.Lyrics.Clear();
                note.Lyrics.Add(new Lyrics(syllable.Type, syllable.Text));
            }

            return notes;
        }

        /// <summary>
        /// Applies pithes to RhythmicDurations (converts RhythmicDurations into Notes).
        /// </summary>
        /// <param name="durations">Durations</param>
        /// <param name="pitches">Pitches</param>
        /// <returns>Notes</returns>
		public static IEnumerable<Note> AddPitches(this IEnumerable<RhythmicDuration> durations, params Pitch[] pitches)
        {
            if (pitches.Length != durations.Count()) throw new Exception("Durations must have the same count as pitches.");
            var i = 0;
            return durations.Select(d => new Note(pitches[i++], d)).ToArray();
        }

        /// <summary>
        /// Applies rhythm to Pitches (converts Pitches into Notes)
        /// </summary>
        /// <param name="pitches">Pithes</param>
        /// <param name="durations">RhythmicDurations</param>
        /// <returns>Notes</returns>
		public static IEnumerable<Note> AddRhythm(this IEnumerable<Pitch> pitches, params int[] durations)
        {
            if (pitches.Count() != durations.Length) throw new Exception("Durations must have the same count as pitches.");
            var units = new Queue<RhythmicUnit>();
            foreach (var u in RhythmicUnit.Parse(durations)) units.Enqueue(u);
            return pitches.Select(p => new Note(p, units.Dequeue().Duration)).ToArray();
        }

        public static IEnumerable<Note> AddUniformRhythm(this IEnumerable<Pitch> pitches, int duration)
        {
            var durationAsPowerOfTwo = UsefulMath.Log2(duration);
            return AddUniformRhythm(pitches, new RhythmicDuration(durationAsPowerOfTwo));
        }

        public static IEnumerable<Note> AddUniformRhythm(this IEnumerable<Pitch> pitches, RhythmicDuration duration)
        {
            return pitches.Select(p => new Note(p, duration)).ToArray();
        }

        /// <summary>
        /// Applies rhythm to Pitches (converts Pitches into Notes)
        /// </summary>
        /// <param name="pitches">Pithes</param>
        /// <param name="durations">RhythmicDurations</param>
        /// <returns>Notes</returns>
        public static IEnumerable<Note> AddRhythm(this IEnumerable<Pitch> pitches, string durations)
        {
            var units = new Queue<RhythmicUnit>();
            foreach (var u in RhythmicUnit.Parse(durations, " ")) units.Enqueue(u);
            if (pitches.Count() != units.Count) throw new Exception("Durations must have the same count as pitches.");
            return pitches.Select(p => new Note(p, units.Dequeue().Duration)).ToArray();
        }

        /// <summary>
        /// Applies specific stem direction to Notes
        /// </summary>
        /// <param name="notes">Notes</param>
        /// <param name="direction">Stem direction</param>
        /// <returns>Notes</returns>
		public static IEnumerable<Note> ApplyStemDirection(this IEnumerable<Note> notes, VerticalDirection direction)
        {
            foreach (var n in notes)
            {
                n.StemDirection = direction;
                n.SubjectToNoteStemRule = false;
            }
            return notes;
        }

        /// <summary>
        /// Starts building a Staff with a set of Pitches (pitch-first approach)
        /// </summary>
        /// <param name="pitches"></param>
        /// <returns></returns>
		public static IEnumerable<Pitch> FromPitches(params Pitch[] pitches)
        {
            return pitches;
        }

        /// <summary>
        /// Starts building a Staff with a set of RhythmicDurations (rhythm-first approach)
        /// </summary>
        /// <param name="durations"></param>
        /// <returns></returns>
		public static IEnumerable<RhythmicDuration> FromRhythm(params RhythmicDuration[] durations)
        {
            return durations;
        }

        /// <summary>
        /// Starts building a Staff with a set of rhythmic durations expressed by numbers (rhythm-first approach)
        /// </summary>
        /// <param name="durations"></param>
        /// <returns></returns>
		public static IEnumerable<RhythmicDuration> FromRhythm(params int[] durations)
        {
            return RhythmicDuration.Parse(durations);
        }

        /// <summary>
        /// Starts building a Staff with a set of rhythmic durations expressed by string (rhythm-first approach)
        /// </summary>
        /// <param name="durations"></param>
        /// <returns></returns>
        public static IEnumerable<RhythmicDuration> FromRhythm(string durations)
        {
            return RhythmicDuration.Parse(durations, " ");
        }

        /// <summary>
        /// Performs rebeaming on staff elements with a specific rebeam mode
        /// </summary>
        /// <param name="notes">Notes to rebeam</param>
        /// <param name="mode">Rebeam mode</param>
        /// <param name="hookDirectionAlgorithm">Algorithm to determine hook direction (applies only for RebeamMode.Simple)</param>
        /// <returns></returns>
		public static IEnumerable<NoteOrRest> Rebeam(this IEnumerable<NoteOrRest> notes, RebeamMode mode = RebeamMode.Simple, HookDirectionAlgorithm hookDirectionAlgorithm = HookDirectionAlgorithm.ProductionCandidate)
        {
#if CSHTML5
            var strategies = typeof(IRebeamStrategy).Assembly.GetTypes()
                .Where(t => !t.IsAbstract && typeof(IRebeamStrategy).IsAssignableFrom(t))
                .Select(t => Expression.Lambda(Expression.New(t)).Compile().DynamicInvoke())
                .Cast<IRebeamStrategy>()
                .ToArray();
#else
            var strategies = typeof(IRebeamStrategy).GetTypeInfo().Assembly.DefinedTypes
                .Where(t => !t.IsAbstract && typeof(IRebeamStrategy).GetTypeInfo().IsAssignableFrom(t))
                .Select(t => Expression.Lambda(Expression.New(t.AsType())).Compile().DynamicInvoke())
                .Cast<IRebeamStrategy>()
                .ToArray();
#endif
            var matchingStrategy = strategies.FirstOrDefault(s => s.Mode == mode);
            if (matchingStrategy == null) throw new Exception($"Rebeam strategy not found for rebeam mode {mode}.");
            foreach (var n in notes.OfType<Note>()) n.ModeUsedForRebeaming = mode;
            return matchingStrategy.Rebeam(notes, hookDirectionAlgorithm);
        }

        /// <summary>
        /// Splits notes and rests to beat groups for specific time signature
        /// </summary>
        /// <param name="notes"></param>
        /// <param name="timeSignature"></param>
        /// <returns></returns>
		public static IEnumerable<NoteOrRest>[] SplitByBeats(this IEnumerable<NoteOrRest> notes, TimeSignature timeSignature)
        {
            var groups = new List<List<NoteOrRest>>();
            var queue = new Queue<NoteOrRest>();
            foreach (var n in notes) queue.Enqueue(n);

            while (queue.Count > 0)
            {
                var sum = 0d;
                var currentGroup = new List<NoteOrRest>();
                while (sum == 0 || sum - Math.Floor(sum) != 0)
                {
                    if (queue.Count == 0) break;
                    var currentNote = queue.Dequeue();
                    currentGroup.Add(currentNote);
                    sum += ((1d + Enumerable.Range(1, currentNote.NumberOfDots).Sum(r => Math.Pow(0.5d, r))) / currentNote.BaseDuration.Denominator) * timeSignature.TypeOfBeats;
                }
                groups.Add(currentGroup);
            }
            return groups.ToArray();
        }

        /// <summary>
        /// Splits notes and rest to groups according to lyric syllables
        /// </summary>
        /// <param name="notes"></param>
        /// <returns></returns>
		public static IEnumerable<NoteOrRest>[] SplitByLyrics(this IEnumerable<NoteOrRest> notes)
        {
            var groups = new List<List<NoteOrRest>>();
            var queue = new Queue<NoteOrRest>();
            foreach (var n in notes) queue.Enqueue(n);

            var currentGroup = new List<NoteOrRest>();
            while (queue.Count > 0)
            {
                var currentNote = queue.Dequeue() as Note;
                currentGroup.Add(currentNote);
                if (currentNote == null) continue;

                if (currentNote.Lyrics.Any(l => l.Syllables.Any(s => s.Type == SyllableType.End || s.Type == SyllableType.Single)))
                {
                    groups.Add(currentGroup);
                    currentGroup = new List<NoteOrRest>();
                }
            }
            return groups.ToArray();
        }
    }
}