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

using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Articulation types
    /// </summary>
    public enum ArticulationType { None, Staccato, Accent };

    /// <summary>
    /// Barline styles
    /// </summary>
    public enum BarlineStyle { Regular, LightHeavy, None, Dashed }

    /// <summary>
    /// Clef types
    /// </summary>
    public enum ClefType { GClef, CClef, FClef, Percussion };

    /// <summary>
    /// Desired hook directions
    /// </summary>
    public enum DesiredHookDirections { Any, ForwardHook, BackwardHook };

    public enum DirectionPlacementType { Above, Below, Custom };

    public enum GraceNoteType { None, Simple, Slashed };

    public enum HorizontalPlacement { Left, Right };

    public enum NoteBeamType { Single, Start, Continue, End, ForwardHook, BackwardHook };

    public enum NoteSlurType { None, Start, Stop };

    public enum NoteTieType { None, Start, Stop, StopAndStartAnother };

    public enum NoteTrillMark { None, Above, Below };

    public enum RepeatSignType { None, Forward, Backward };

    public enum SyllableType { None, Begin, Middle, End, Single };

    public enum TimeSignatureType { Common, Cut, Numbers };

    public enum TupletType { None, Start, Stop };

    public enum VerticalDirection { Up, Down };

    public enum VerticalPlacement { Above, Below };

    /// <summary>
    /// Base class for all musical symbols
    /// </summary>
    public abstract class MusicalSymbol : ViewModel
    {
        private static Dictionary<Guid, long> idDictionary = new Dictionary<Guid, long>();
        private static object syncRoot = new object();
        private Color? customColor;
        private bool isVisible;

        protected MusicalSymbol()
        {
            isVisible = true;
            Id = Guid.NewGuid();
        }

        /// <summary>
        /// Returns a new instance of null musical symbol
        /// </summary>
        public static NullMusicalSymbol Null
        {
            get
            {
                return new NullMusicalSymbol();
            }
        }

        public Quadrangle ActualRenderedBounds { get; internal set; }

        public TimeSpan ActualRenderingTime { get; internal set; }

        /// <summary>
        /// Defines a custom color for drawing this MusicalSymbol. If null, the default color will be used.
        /// </summary>
        public Color? CustomColor { get { return customColor; } set { customColor = value; OnPropertyChanged(); } }

        /// <summary>
        /// Random id of MusicalSymbol
        /// </summary>
        public Guid Id { get; private set; }

        public bool IsBreakpointSet { get; set; }

        /// <summary>
        /// Gets or sets the symbol's visibility. Visibility can be treated differently varying on implementation of rendering.
        /// </summary>
        public bool IsVisible { get { return isVisible; } set { isVisible = value; OnPropertyChanged(); } }

        public long LongId
        {
            get
            {
                if (idDictionary.ContainsKey(Id)) return idDictionary[Id];
                lock (syncRoot)
                {
                    if (idDictionary.ContainsKey(Id)) return idDictionary[Id];
                    idDictionary.Add(Id, idDictionary.Count);
                    return idDictionary[Id];
                }
            }
        }

        /// <summary>
        /// Measure that contains this MusicalSymbol. Null if MusicalSymbol doesn't belong to any measure.
        /// </summary>
        public virtual Measure Measure { get; internal set; }

        /// <summary>
        /// Score page that contains this MusicalSymbol. Null if MusicalSymbol doesn't belong to any measure.
        /// </summary>
        public ScorePage Page => Measure?.System?.Page;

        /// <summary>
        /// Number of score page that contains this MusicalSymbol. Null if MusicalSymbol doesn't belong to any measure.
        /// </summary>
        public int? PageNumber => Page == null ? null : Staff?.Score?.Pages?.IndexOf(Page) + 1;

        /// <summary>
        /// Difference between scoreService.CursorPositionX at the beginning and at the end of Render method
        /// </summary>
        public double RenderedWidth { get; internal set; }

        /// <summary>
        /// Staff that contains this MusicalSymbol. Null if MusicalSymbol doesn't belong to any staff.
        /// </summary>
        public virtual Staff Staff { get; internal set; }

        /// <summary>
        /// If true, MusicalSymbol will not fire any PropertyChanged events and MusicalSymbol's staff will not raise MeasureInvalidated events when MusicalSymbol's property is changed.
        /// </summary>
        internal bool SuppressEvents { get; set; }

        /// <summary>
        /// Converts a VerticalDirection to VerticalPlacement.
        /// </summary>
        /// <param name="direction">VerticalDirection to convert to VerticalPlacement.</param>
        /// <returns>VerticalPlacement converted from VerticalDirection.</returns>
        public static VerticalPlacement DirectionToPlacement(VerticalDirection direction)
        {
            return direction == VerticalDirection.Up ? VerticalPlacement.Above : VerticalPlacement.Below;
        }

        [Obsolete("Use Duration.ToTimeSpan() instead")]
        public static TimeSpan DurationToTime(IHasDuration durationElement, Tempo tempo)
        {
            double singleNoteDuration = 60d / tempo.BeatsPerMinute;
            double ratio = (double)tempo.BeatUnit.Denominator / (double)durationElement.BaseDuration.Denominator;
            if (durationElement.NumberOfDots > 0)
            {
                ratio += ratio * Math.Pow(0.5, durationElement.NumberOfDots);
            }
            return TimeSpan.FromSeconds(singleNoteDuration * ratio);
        }

        /// <summary>
        /// Returns a color that will be used to draw this MusicalSymbol. If CustomColor is defined, CustomColor will be used. Otherwise, renderer's DefaultColor will be used.
        /// </summary>
        /// <param name="renderer"></param>
        /// <returns></returns>
        public Color CoalesceColor(ScoreRendererBase renderer)
        {
            return CustomColor.HasValue ? CustomColor.Value : renderer.Settings.DefaultColor;
        }

        /// <summary>
        /// Forces a Staff containing this MusicalSymbol to fire it's MeasureInvalidated events.
        /// </summary>
        internal void InvalidateMeasure()
        {
            Staff?.FireMeasureInvalidated(this, Measure);
        }

        /// <summary>
        /// Raises a PropertyChanged event and forces a Staff containing this MusicalSymbol to fire it's MeasureInvalidated events.
        /// </summary>
        /// <param name="propertyName"></param>
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (SuppressEvents) return;
            base.OnPropertyChanged(propertyName);
            Staff?.FireMeasureInvalidated(this, Measure);
        }
    }
}