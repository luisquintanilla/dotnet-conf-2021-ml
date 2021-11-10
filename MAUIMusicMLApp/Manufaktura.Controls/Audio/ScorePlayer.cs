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
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.PeekStrategies;
using Manufaktura.Controls.Parser;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Audio
{
    /// <summary>
    /// Base class for implementing audio players.
    /// </summary>
    public abstract class ScorePlayer : ViewModel
    {
        private MusicalSymbol _currentElement;
        private PlaybackState _state;
        private Tempo _tempo;
        private TimeSpan elapsedTime;
        private PlaybackCursorPosition lastPosition = default(PlaybackCursorPosition);
        private bool playCueNotes = false;

        /// <summary>
        /// Initializes a new instance of ScorePlayer.
        /// </summary>
        /// <param name="score">Score</param>
        protected ScorePlayer(Score score)
        {
            Score = score;
            Tempo = Tempo.Allegro;
            State = PlaybackState.Idle;
            PlaybackExceptions = new List<Exception>();
        }

        /// <summary>
        /// Playback state
        /// </summary>
        public enum PlaybackState
        {
            /// <summary>
            /// Playback has not started yet
            /// </summary>
            Idle,

            /// <summary>
            /// Playback is paused
            /// </summary>
            Paused,

            /// <summary>
            /// Playing in progress
            /// </summary>
            Playing
        }

        [Flags]
        private enum PlayElementStrategies
        {
            DoNothing = 0,
            Play = 1,
            IncreaseElapsedTime = 2
        }

        /// <summary>
        /// Currently played element.
        /// </summary>
        public virtual MusicalSymbol CurrentElement
        {
            get { return _currentElement; }
            protected set { _currentElement = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Position of playback cursor
        /// </summary>
        public PlaybackCursorPosition CurrentPosition
        {
            get
            {
                var noteOrRest = CurrentElement as NoteOrRest;
                if (noteOrRest == null) return lastPosition;
                lastPosition = new PlaybackCursorPosition(Score.Systems.IndexOf(noteOrRest.Measure.System) + 1, noteOrRest.TextBlockLocation.X, DateTime.Now, new RhythmicDuration(noteOrRest.BaseDuration.DenominatorAsPowerOfTwo, noteOrRest.NumberOfDots).ToTimeSpan(Tempo));
                return lastPosition;
            }
        }

        /// <summary>
        /// Elapsed playback time
        /// </summary>
        public virtual TimeSpan ElapsedTime
        {
            get { return elapsedTime; }
            set { elapsedTime = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// List of exceptions that occured during playback.
        /// </summary>
        public List<Exception> PlaybackExceptions { get; private set; }

        public bool PlayCueNotes { get => playCueNotes; set { playCueNotes = value; OnPropertyChanged(); } }

        /// <summary>
        /// Score to play.
        /// </summary>
        public virtual Score Score { get; set; }

        /// <summary>
        /// Current playback state.
        /// </summary>
        public PlaybackState State
        {
            get { return _state; }
            set { _state = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Playback tempo.
        /// </summary>
        public Tempo Tempo
        {
            get { return _tempo; }
            set { _tempo = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Pause playback
        /// </summary>
        public abstract void Pause();

        /// <summary>
        /// Start playback.
        /// </summary>
        public abstract void Play();

        /// <summary>
        /// Play specific element from the score.
        /// </summary>
        /// <param name="element">Element</param>
        public abstract void PlayElement(MusicalSymbol element);

        /// <summary>
        /// Stop playback
        /// </summary>
        public abstract void Stop();

        /// <summary>
        /// Enumerates playback timeline
        /// </summary>
        /// <returns></returns>
        protected IEnumerable<TimelineElement<IHasDuration>> EnumerateTimeline()
        {
            var elapsedTime = TimeSpan.Zero;
            var quarterNoteDuration = MusicXmlParser.CalculateQuarterNoteDuration(Score);
            var repeats = new Stack<int>();
            var triggeredRepeats = new List<Barline>();
            for (var i = 0; i < Score.FirstStaff.Measures.Count; i++)
            {
                var orderedElements = BuildMeasureTimeLine(i, quarterNoteDuration, repeats, triggeredRepeats, out bool repeat).OrderBy(e => e.Item1).ToList();
                foreach (var element in orderedElements)
                {
                    yield return new TimelineElement<IHasDuration>(TimeSpan.FromMilliseconds(element.Item1 * (4 * 4 / Tempo.BeatUnit.Denominator) * Tempo.BeatTimeSpan.TotalMilliseconds) + elapsedTime, element.Item2);
                }
                var lastItem = orderedElements.Any() ? orderedElements.Last() : null;
                if (lastItem != null)
                {
                    var endOfMeasure = lastItem.Item1 + new RhythmicDuration(lastItem.Item2.BaseDuration.DenominatorAsPowerOfTwo, lastItem.Item2.NumberOfDots).ToDouble();
                    elapsedTime += TimeSpan.FromMilliseconds(endOfMeasure * (4 * 4 / Tempo.BeatUnit.Denominator) * Tempo.BeatTimeSpan.TotalMilliseconds);
                }
                if (repeat && repeats.Any()) i = repeats.Pop() - 1; 
            }
        }

        private List<Tuple<double, IHasDuration>> BuildMeasureTimeLine(Measure measure, Staff staff, int quarterNoteDuration)
        {
            var elements = new List<Tuple<double, IHasDuration>>();
            var elapsed = new Dictionary<int, double>();
            var chordBaseStartTime = 0d;
            Tuplet tupletState = null;
            foreach (var durationElement in measure.Elements.OfType<IHasDuration>())
            {
                var voice = (durationElement as DurationElement)?.Voice ?? 1;
                if (!elapsed.ContainsKey(voice)) elapsed.Add(voice, 0d);

                if (durationElement is PlaybackSuggestion playbackSuggestion)
                {
                    playbackSuggestion.CalculateDurationFromMusicXmlDuration(quarterNoteDuration);
                    var dueTime = new RhythmicDuration(durationElement.BaseDuration.DenominatorAsPowerOfTwo, durationElement.NumberOfDots).ToDouble() * 
                        playbackSuggestion.DurationMultiplicator *
                        (playbackSuggestion.IsBackward ? -1 : 1);
                    elapsed[voice] += dueTime;
                    if (elapsed[voice] < 0) elapsed[voice] = 0;
                    continue;
                }

                var strategy = GetProperStrategy(durationElement);

                if (strategy.HasFlag(PlayElementStrategies.Play))
                {
                    var realElapsedTime = ((durationElement as Note)?.IsUpperMemberOfChord ?? false) ? chordBaseStartTime : elapsed[voice];
                    elements.Add(new Tuple<double, IHasDuration>(realElapsedTime, durationElement));
                }
                if (strategy.HasFlag(PlayElementStrategies.IncreaseElapsedTime))
                {
                    if (durationElement.Tuplet == TupletType.Start)
                    {
                        NoteOrRest tupletStart = staff.Peek<NoteOrRest>((MusicalSymbol)durationElement, PeekType.BeginningOfTuplet);
                        NoteOrRest tupletEnd = staff.Peek<NoteOrRest>((MusicalSymbol)durationElement, PeekType.EndOfTuplet);
                        if (tupletStart != null && tupletEnd != null)
                        {
                            tupletState = new Tuplet();
                            tupletState.NumberOfNotesUnderTuplet = staff.Elements.GetRange(staff.Elements.IndexOf(tupletStart), staff.Elements.IndexOf(tupletEnd) -
                                staff.Elements.IndexOf(tupletStart)).OfType<NoteOrRest>().Where(nr => !(nr is Note) || (nr is Note && !((Note)nr).IsUpperMemberOfChord)).Count() + 1;
                        }
                    }

                    var dueTime = new RhythmicDuration(durationElement.BaseDuration.DenominatorAsPowerOfTwo, durationElement.NumberOfDots).ToDouble();
                    if (tupletState != null) dueTime = dueTime / tupletState.NumberOfNotesUnderTuplet * (durationElement.BaseDuration.Denominator / Tempo.BeatUnit.Denominator);

                    chordBaseStartTime = elapsed[voice];
                    elapsed[voice] += dueTime;
                    if (durationElement.Tuplet == TupletType.Stop) tupletState = null;
                }
            }
            return elements;
        }

        private List<Tuple<double, IHasDuration>> BuildMeasureTimeLine(int measureIndex, int quarterNoteDuration, Stack<int> repeats, List<Barline> triggeredRepeats, out bool repeat)
        {
            repeat = false;
            var elements = new List<Tuple<double, IHasDuration>>();
            foreach (var staff in Score.Staves)
            {
                var measure = staff.Measures[measureIndex];
                var forwardRepeat = measure.Elements.OfType<Barline>().FirstOrDefault(b => b.RepeatSign == RepeatSignType.Forward);
                if (forwardRepeat != null && !triggeredRepeats.Contains(forwardRepeat))
                {
                    repeats.Push(measureIndex);
                    triggeredRepeats.Add(forwardRepeat);
                }
                var backwardRepeat = measure.Elements.OfType<Barline>().FirstOrDefault(b => b.RepeatSign == RepeatSignType.Backward);
                if (backwardRepeat != null && !triggeredRepeats.Contains(backwardRepeat))
                {
                    repeat = true;
                    triggeredRepeats.Add(backwardRepeat);
                }
                elements.AddRange(BuildMeasureTimeLine(measure, staff, quarterNoteDuration));
            }
            return elements;
        }

        private PlayElementStrategies GetProperStrategy(IHasDuration durationElement)
        {
            var note = durationElement as Note;
            if (note != null)
            {
                if (note.IsGraceNote) return PlayElementStrategies.DoNothing;
                if (note.IsCueNote) return PlayCueNotes ? PlayElementStrategies.Play | PlayElementStrategies.IncreaseElapsedTime : PlayElementStrategies.DoNothing;
                if (note.IsUpperMemberOfChord) return PlayElementStrategies.Play;
                if (note.TieType == NoteTieType.Stop || note.TieType == NoteTieType.StopAndStartAnother) return PlayElementStrategies.IncreaseElapsedTime;
            }

            return PlayElementStrategies.Play | PlayElementStrategies.IncreaseElapsedTime;
        }
    }
}