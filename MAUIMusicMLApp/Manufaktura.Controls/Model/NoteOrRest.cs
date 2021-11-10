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
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Music.Model;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Base class that represents note or rest.
    /// </summary>
    public abstract class NoteOrRest : DurationElement, ICanBeElementOfTuplet, IHasCustomXPosition, IRenderedAsTextBlock
    {
        protected bool hasFermataSign = false;
        protected Point location = new Point();

        private NoteOrRestSize size;

        /// <summary>
        /// Default X position of note or rest
        /// </summary>
		public double? DefaultXPosition { get; set; }

        /// <summary>
        /// Indicates if note has fermata sign
        /// </summary>
        public bool HasFermataSign { get { return hasFermataSign; } set { hasFermataSign = value; OnPropertyChanged(); } }

        /// <summary>
        /// Position of text block part of this NoteOrRest. Rests are rendered wholly as text blocks.
        /// Notes are rendered as text blocks (noteheads and flags) and lines (stems and beams).
        /// </summary>
		public Point TextBlockLocation { get { return location; } set { location = value; } }

        /// <summary>
        /// Only applicable if this NoteOrRest is part of a tuplet. If null, the number above tuplet is calculated as sum of (R_min / R_n)
        /// where R_min in the smallest rhythmic duration denominator and R_n is rhythmic duration denominator of n-th element.
        /// If not null, TupletWeightOverride will be used instead of (R_min / R_n).
        /// </summary>
		public double? TupletWeightOverride { get; set; }

        /// <summary>
        /// Tuplet sign placement (above or below).
        /// </summary>
		public VerticalPlacement? TupletPlacement { get; set; }

        public NoteOrRestSize Size { get => size; set { size = value; OnPropertyChanged(); } }

        /// <summary>
        /// Creates a Note or Rest from RhythmicUnit.
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        public static NoteOrRest FromRhythmicUnit(RhythmicUnit unit)
        {
            return unit.IsRest ? (NoteOrRest)new Rest(unit.Duration) : new Note(unit.Duration);
        }

        public abstract char GetCharacter(IMusicFont font);
    }
}