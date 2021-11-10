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
using Manufaktura.Controls.Model.Collections;
using Manufaktura.Controls.Model.Events;
using Manufaktura.Controls.Model.PeekStrategies;
using Manufaktura.Controls.Model.Rules;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a staff.
    /// </summary>
    public class Staff : MusicalSymbol
    {
        /// <summary>
        /// Initializes a new Staff.
        /// </summary>
        public Staff()
        {
            Elements = new MusicalSymbolCollection(this);
            Elements.CollectionChanged += Elements_CollectionChanged;
            Rules = new List<StaffRule> { new NoteStemRule(), new ManualAddMeasuresRule(), new AutomaticAddMeasuresRule(), new BreakSystemRule() };
            Measures = new List<Measure>();
            MeasureAddingRule = MeasureAddingRuleEnum.AddMeasureOnInsertingBarline;
        }

        public event EventHandler<InvalidateEventArgs<Measure>> MeasureInvalidated;

        public event EventHandler<InvalidateEventArgs<Staff>> StaffInvalidated;

        /// <summary>
        /// Way of adding new Measures
        /// </summary>
        public enum MeasureAddingRuleEnum
        {
            /// <summary>
            /// Measure is added automatically when new Barline is addes to Staff's Elements collection.
            /// </summary>
            AddMeasureOnInsertingBarline,

            /// <summary>
            /// Measures can be added only manually. This setting is used by MusicXml parsers.
            /// </summary>
            AddMeasuresManually
        }

        public ICollection<BeamGroup> BeamGroups { get; private set; } = new List<BeamGroup>();

        /// <summary>
        /// Elements in Staff
        /// </summary>
        public MusicalSymbolCollection Elements { get; private set; }

        /// <summary>
        /// Height of Staff
        /// </summary>
        public double Height { get; set; }

        public MeasureAddingRuleEnum MeasureAddingRule { get; set; }

        /// <summary>
        /// Measures in Staff
        /// </summary>
        public List<Measure> Measures { get; private set; }

        /// <summary>
        /// Parent Part
        /// </summary>
        public Part Part { get; internal set; }

        /// <summary>
        /// Rules to apply when adding notes to the staff.
        /// </summary>
        public List<StaffRule> Rules { get; private set; }

        /// <summary>
        /// Parent Score
        /// </summary>
        public Score Score { get; internal set; }

        public Staff Add(MusicalSymbol element)
        {
            Elements.Add(element);
            return this;
        }

        public Staff AddBarline(BarlineStyle style = BarlineStyle.None)
        {
            Elements.Add(new Barline(style));
            return this;
        }

        public Staff AddNote(Pitch pitch, RhythmicDuration duration)
        {
            Elements.Add(new Note(pitch, duration));
            return this;
        }

        public Staff AddRange(IEnumerable<MusicalSymbol> elements)
        {
            Elements.AddRange(elements);
            return this;
        }

        public Staff AddTimeSignature(TimeSignatureType type, int beats, int beatType)
        {
            Elements.Add(new TimeSignature(type, beats, beatType));
            return this;
        }
        public IEnumerable<TElement> EnumerateUntilConditionMet<TElement>(MusicalSymbol startElement, Func<TElement, bool> condition, bool backward) where TElement : class
        {
            for (int i = Elements.IndexOf(startElement); i >= 0 && i < Elements.Count; i += backward ? -1 : 1)
            {
                var element = Elements[i] as TElement;
                if (element == null) continue;
                yield return element;
                if (condition(element)) break;
            }
        }

        /// <summary>
        /// Retrieves a symbol that meats specific requirements and is relative to specific symbol.
        /// </summary>
        /// <typeparam name="TSymbol">Type of symbol</typeparam>
        /// <param name="relativeTo"></param>
        /// <param name="peekType"></param>
        /// <returns></returns>
        public TSymbol Peek<TSymbol>(MusicalSymbol relativeTo, PeekType peekType) where TSymbol : MusicalSymbol
        {
            PeekStrategy<TSymbol> strategy;
            switch (peekType)
            {
                case PeekType.BeginningOfMeasure:
                    strategy = new BeginningOfMeasurePeekStrategy<TSymbol>(this);
                    break;

                case PeekType.BeginningOfTuplet:
                    strategy = new BeginningOfTupletPeekStrategy<TSymbol>(this);
                    break;

                case PeekType.EndOfTuplet:
                    strategy = new EndOfTupletPeekStrategy<TSymbol>(this);
                    break;

                case PeekType.NextElement:
                    strategy = new NextElementPeekStrategy<TSymbol>(this);
                    break;

                case PeekType.PreviousElement:
                    strategy = new PreviousElementPeekStrategy<TSymbol>(this);
                    break;

                case PeekType.HighestNoteInChord:
                    strategy = new HighestNoteInChordPeekStrategy<TSymbol>(this);
                    break;

                default:
                    throw new NotImplementedException("Peek type not implemented.");
            }
            return strategy.Peek(relativeTo);
        }

        /// <summary>
        /// Wraps the staff with a score (creates a new score with this staff).
        /// </summary>
        /// <returns>Score</returns>
        public Score ToOneStaffScore()
        {
            var score = new Score();
            score.Staves.Add(this);
            return score;
        }

        public override string ToString()
        {
            if (Score == null || !Score.Staves.Contains(this)) string.Format("Staff (detached from score).");
            if (Part == null || !Part.Staves.Contains(this)) return string.Format("Staff ({0} in score).", UsefulMath.NumberToOrdinal(Score.Staves.IndexOf(this) + 1));
            return string.Format("Staff {0} of part {1} ({2} in score).", Part.Staves.IndexOf(this) + 1, Part.PartId, UsefulMath.NumberToOrdinal(Score.Staves.IndexOf(this) + 1));
        }

        internal void ApplyRules(MusicalSymbol item)
        {
            foreach (var rule in Rules.Where(r => r.Condition(this, item))) rule.Apply(this, item);
        }

        internal void FireMeasureInvalidated(MusicalSymbol sender, Measure measure)
        {
            MeasureInvalidated?.Invoke(sender, new InvalidateEventArgs<Measure>(measure));
        }

        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            StaffInvalidated?.Invoke(this, new InvalidateEventArgs<Staff>(this));
        }

        private void Elements_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            StaffInvalidated?.Invoke(sender, new InvalidateEventArgs<Staff>(this));
        }
    }
}