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
using Manufaktura.Controls.Parser.MusicXml;
using Manufaktura.Music.Model;
using System.Collections.Generic;

namespace Manufaktura.Controls.Model.Builders
{
    /// <summary>
    /// Helper class to build notes and rests.
    /// </summary>
    public class NoteOrRestBuilder : IHasDuration
    {
        public int Alter { get; set; }

        public ArticulationType Articulation { get; set; }

        public VerticalPlacement ArticulationPlacement { get; set; }

        public RhythmicDuration BaseDuration { get; set; }

        public List<NoteBeamType> BeamList { get; set; }

        public bool CustomStemEndPosition { get; set; }

        public double? DefaultX { get; set; }

        public bool FullMeasure { get; set; }

        public bool HasFermataSign { get; set; }

        public bool HasNatural { get; set; }

        public bool IsChordElement { get; set; }

        public bool IsCueNote { get; set; }

        public GraceNoteType GraceNoteType { get; set; }

        public bool IsRest { get; set; }

        public bool IsVisible { get; set; }

        public List<Lyrics> Lyrics { get; set; }

        public Mordent Mordent { get; set; }

        public int NumberOfDots { get; set; }

        public int Octave { get; set; }

        public List<Slur> Slurs { get; } = new List<Slur>();

        public Staff Staff { get; set; }

        public MusicXmlParserState State { get; protected set; }

        public float StemDefaultY { get; set; }

        public VerticalDirection StemDirection { get; set; }

        public string Step { get; set; }

        public bool IsUnpitched { get; set; }

        public NoteTieType TieType { get; set; }

        public int TremoloLevel { get; set; }

        public NoteTrillMark TrillMark { get; set; }

        public TupletType Tuplet { get; set; }

        public VerticalPlacement? TupletPlacement { get; set; }

        public int Voice { get; set; }

        public NoteOrRestSize Size { get; set; }

        public NoteOrRestBuilder(MusicXmlParserState state)
        {
            State = state;

            Octave = 0;
            Alter = 0;
            Step = "C";
            IsRest = false;
            NumberOfDots = 0;
            BaseDuration = RhythmicDuration.Whole;
            StemDirection = VerticalDirection.Up;
            TieType = NoteTieType.None;
            Tuplet = TupletType.None;
            TupletPlacement = null;
            BeamList = new List<NoteBeamType>();
            Lyrics = new List<Lyrics>();
            ArticulationPlacement = VerticalPlacement.Below;
            Articulation = ArticulationType.None;
            HasNatural = false;
            GraceNoteType = GraceNoteType.None;
            IsCueNote = false;
            IsChordElement = false;
            HasFermataSign = false;
            StemDefaultY = 28;
            CustomStemEndPosition = false;
            TremoloLevel = 0;
            TrillMark = NoteTrillMark.None;
            Mordent = null;
            Voice = 1;
            IsVisible = true;
        }

        public NoteOrRest Build()
        {
            if (!IsRest)
            {
                Note nt = new Note(Step, Alter, Octave, BaseDuration, StemDirection, TieType, BeamList);
                nt.NumberOfDots = NumberOfDots;
                nt.Tuplet = Tuplet;
                nt.TupletPlacement = TupletPlacement;
                nt.Lyrics.Clear();
                nt.Lyrics.AddRange(Lyrics);
                nt.Articulation = Articulation;
                nt.ArticulationPlacement = ArticulationPlacement;
                nt.HasNatural = HasNatural;
                nt.GraceNoteType = GraceNoteType;
                nt.Size = Size;
                nt.IsUnpitched = IsUnpitched;
                nt.IsUpperMemberOfChord = IsChordElement;
                nt.StemDefaultY = StemDefaultY;
                nt.DefaultXPosition = DefaultX;
                nt.HasCustomStemEndPosition = CustomStemEndPosition;
                nt.TrillMark = TrillMark;
                nt.HasFermataSign = HasFermataSign;
                nt.TremoloLevel = TremoloLevel;
                nt.Voice = Voice;
                nt.IsVisible = IsVisible;
                nt.Staff = Staff;
                if (Mordent != null) nt.Ornaments.Add(Mordent);
                nt.Slurs.Clear();
                nt.Slurs.AddRange(Slurs);
                return nt;
            }
            else
            {
                Rest rt = new Rest(BaseDuration);
                rt.NumberOfDots = NumberOfDots;
                rt.Tuplet = Tuplet;
                rt.TupletPlacement = TupletPlacement;
                rt.MultiMeasure = State.SkipMeasures + 1;
                rt.HasFermataSign = HasFermataSign;
                rt.Voice = Voice;
                rt.DefaultXPosition = DefaultX;
                rt.IsVisible = IsVisible;
                rt.FullMeasure = FullMeasure;
                rt.Staff = Staff;
                rt.Size = Size;
                return rt;
            }
        }
    }
}