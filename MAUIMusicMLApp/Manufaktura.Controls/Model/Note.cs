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

using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Formatting;
using Manufaktura.Controls.Model.Assertions;
using Manufaktura.Controls.Model.Collections;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a note.
    /// </summary>
    public class Note : NoteOrRest, IHasPitch, ICanBeUpperMemberOfChord, ICanCalculateRenderedBounds
    {
        private ArticulationType articulation = ArticulationType.None;

        private VerticalPlacement articulationPlacement = VerticalPlacement.Below;

        private List<NoteBeamType> beamList = new List<NoteBeamType>();

        private bool customStemEndPosition = false;

        private DesiredHookDirections desiredHookDirection = DesiredHookDirections.Any;

        private GraceNoteType graceNoteType;

        private bool hasNatural = false;

        private bool isChordElement = false;

        private LyricsCollection lyrics;

        private Pitch pitch;

        private double stemDefaultY;

        private VerticalDirection stemDirection = VerticalDirection.Up;

        private Point stemEndLocation = new Point();

        private NoteTieType tieType = NoteTieType.None;

        private int tremoloLevel = 0;

        private NoteTrillMark trillMark = NoteTrillMark.None;

        /// <summary>
        /// Creates a new instance of a Note.
        /// </summary>
        /// <param name="notePitch">Pitch</param>
        /// <param name="noteDuration">Duration</param>
        /// <param name="noteStemDirection">Stem direction</param>
        /// <param name="noteTieType">Tie type</param>
        /// <param name="noteBeamList">Beam list</param>
        public Note(Pitch notePitch, RhythmicDuration noteDuration, VerticalDirection noteStemDirection, NoteTieType noteTieType, List<NoteBeamType> noteBeamList)
        {
            Duration = noteDuration;
            pitch = notePitch;
            stemDirection = noteStemDirection;
            beamList = noteBeamList;
            tieType = noteTieType;
            Lyrics = new LyricsCollection(this);
            Ornaments = new List<Ornament>();
            DetermineMusicalCharacter();
        }

        /// <summary>
        /// Create a new A4 note with a specific duration.
        /// </summary>
        /// <param name="noteDuration">Duration</param>
        public Note(RhythmicDuration noteDuration)
            : this("A", 0, 4, noteDuration, VerticalDirection.Up, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.Single })
        {
        }

        /// <summary>
        /// Creates a new note with specific pitch, duration and stem direction.
        /// </summary>
        /// <param name="notePitch">Pitch</param>
        /// <param name="noteDuration">Duration</param>
        /// <param name="noteStemDirection">Stem direction</param>
        public Note(Pitch notePitch, RhythmicDuration noteDuration, VerticalDirection noteStemDirection)
            : this(notePitch, noteDuration, noteStemDirection, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.Single })
        {
        }

        /// <summary>
        /// Creates a new note with specific pitch and duration. Stem direction can be automatically determined upon adding the note to a staff.
        /// </summary>
        /// <param name="notePitch">Pitch</param>
        /// <param name="noteDuration">Duration</param>
        /// <param name="determineStemDirectionOnAddingToStaff">If true, stem direction will be automatically determined when note is added to a staff.</param>
        public Note(Pitch notePitch, RhythmicDuration noteDuration, bool determineStemDirectionOnAddingToStaff = true)
            : this(notePitch, noteDuration, VerticalDirection.Up, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.Single })
        {
            SubjectToNoteStemRule = determineStemDirectionOnAddingToStaff;
        }

        /// <summary>
        /// Creates a new A4 quarter note.
        /// </summary>
        public Note()
            : this("A", 0, 4, RhythmicDuration.Quarter, VerticalDirection.Up, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.Single })
        {
        }

        internal Note(string noteStep, int noteAlter, int noteOctave, RhythmicDuration noteDuration,
            VerticalDirection noteStemDirection, NoteTieType noteTieType, List<NoteBeamType> noteBeamList) :
            this(new Pitch(noteStep, noteAlter, noteOctave), noteDuration, noteStemDirection, noteTieType, noteBeamList)
        {
        }

        public double ActualStemLength { get { return Math.Abs(StemEndLocation.Y - TextBlockLocation.Y); } }

        public int Alter { get { return pitch.Alter; } }
        public ArticulationType Articulation { get { return articulation; } set { articulation = value; OnPropertyChanged(); } }

        public VerticalPlacement ArticulationPlacement
        {
            get { return articulationPlacement; }
            set { articulationPlacement = value; }
        }

        public List<NoteBeamType> BeamList { get { return beamList; } set { beamList = value; OnPropertyChanged(); } }

        public DesiredHookDirections DesiredHookDirection
        {
            get { return desiredHookDirection; }

            set { desiredHookDirection = value; OnPropertyChanged(); }
        }

        public override RhythmicDuration Duration
        {
            get
            {
                return base.Duration;
            }

            set
            {
                duration = value;
                DetermineMusicalCharacter();
                RestoreBeams();
                OnPropertyChanged();
            }
        }

        public Clef GoverningClef { get; internal set; }

        public GraceNoteType GraceNoteType
        {
            get
            {
                return graceNoteType;
            }

            set
            {
                graceNoteType = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsGraceNote));
            }
        }

        public bool HasCustomStemEndPosition { get { return customStemEndPosition; } set { customStemEndPosition = value; } }

        /// <summary>
        /// Indicates that the note has a natural sign.
        /// </summary>
        public bool HasNatural { get { return hasNatural; } set { hasNatural = value; OnPropertyChanged(); } }

        /// <summary>
        /// Indicates that the note is cue note.
        /// </summary>
        public bool IsCueNote => Size == NoteOrRestSize.Cue;

        /// <summary>
        /// Indicates that the note is grace note.
        /// </summary>
        public bool IsGraceNote { get { return graceNoteType != GraceNoteType.None; } }
        public bool IsUnpitched { get; set; }

        /// <summary>
        /// Indicates that the note belongs to a chord.
        /// </summary>
        public bool IsUpperMemberOfChord { get { return isChordElement; } set { isChordElement = value; OnPropertyChanged(); } }

        public double Line { get; internal set; }
        public LyricsCollection Lyrics { get { return lyrics; } private set { lyrics = value; } }
        public int MidiPitch { get { return pitch.MidiPitch; } }
        public RebeamMode? ModeUsedForRebeaming { get; internal set; }

        /// <summary>
        /// Gets octave number of the note's pitch.
        /// </summary>
        public int Octave { get { return pitch.Octave; } }

        /// <summary>
        /// List of ornaments applied on the note.
        /// </summary>
        public List<Ornament> Ornaments { get; private set; }

        /// <summary>
        /// Pitch of note.
        /// </summary>
        public Pitch Pitch
        {
            get { return pitch; }
            set
            {
                pitch = value; OnPropertyChanged();
            }
        }

        public List<Slur> Slurs { get; } = new List<Slur>();
        public double StemDefaultY { get { return stemDefaultY; } set { stemDefaultY = value; } }
        public VerticalDirection StemDirection { get { return stemDirection; } set { stemDirection = value; OnPropertyChanged(); } }
        public Point StemEndLocation { get { return stemEndLocation; } set { stemEndLocation = value; OnPropertyChanged(); } }

        /// <summary>
        /// Location of stem start point. This property is set in the last pass of rendering (DrawBeamsFinishingTouch).
        /// </summary>
        public Point StemStartLocation { get; internal set; }

        /// <summary>
        /// Step of note.
        /// </summary>
        public string Step { get { return pitch.StepName; } }

        /// <summary>
        /// If True, NoteStemRule is applied when this Note is inserted into a Staff.
        /// </summary>
        public bool SubjectToNoteStemRule { get; set; }

        /// <summary>
        /// Note tie type
        /// </summary>
        public NoteTieType TieType { get { return tieType; } set { tieType = value; OnPropertyChanged(); } }

        /// <summary>
        /// Note tremolo level
        /// </summary>
        public int TremoloLevel { get { return tremoloLevel; } set { tremoloLevel = value; OnPropertyChanged(); } }

        /// <summary>
        /// Note trill mark
        /// </summary>
        public NoteTrillMark TrillMark { get { return trillMark; } set { trillMark = value; OnPropertyChanged(); } }

        /// <summary>
        /// Creates a new instance of Note from given midi pitch and duration.
        /// </summary>
        /// <param name="midiPitch">Midi pitch</param>
        /// <param name="duration">Duration</param>
        /// <returns></returns>
        public static Note FromMidiPitch(int midiPitch, RhythmicDuration duration)
        {
            Note note = new Note(duration);
            note.ApplyMidiPitch(midiPitch);
            return note;
        }

        /// <summary>
        /// Creates a new instance of Note from given midi pitch.
        /// </summary>
        /// <param name="midiPitch">Midi pitch</param>
        public static Note FromMidiPitch(int midiPitch)
        {
            Note note = new Note();
            note.ApplyMidiPitch(midiPitch);
            return note;
        }

        /// <summary>
        /// Creates a new instance of Note from given pitch and duration.
        /// </summary>
        /// <param name="midiPitch">Pitch</param>
        /// <param name="duration">Duration</param>
        public static Note FromPitch(Pitch pitch, RhythmicDuration duration)
        {
            Note note = new Note(duration);
            note.Pitch = pitch;
            return note;
        }

        /// <summary>
        /// Creates a new instance of Note from given pitch.
        /// </summary>
        /// <param name="pitch">Pitch</param>
        public static Note FromPitch(Pitch pitch)
        {
            Note note = new Note();
            note.Pitch = pitch;
            return note;
        }

        /// <summary>
        /// Changes pitch of the note to the specific midi pitch.
        /// </summary>
        /// <param name="midiPitch">Midi pitch</param>
        public void ApplyMidiPitch(int midiPitch)
        {
            Pitch = Pitch.FromMidiPitch(midiPitch, Pitch.MidiPitchTranslationMode.Auto);
        }

        public Quadrangle GetBounds(ScoreRendererBase renderer)
        {
            var upperY = TextBlockLocation.Y < StemEndLocation.Y || StemEndLocation.Y == 0 ? TextBlockLocation.Y : StemEndLocation.Y;
            var lowerY = TextBlockLocation.Y > StemEndLocation.Y || StemEndLocation.Y == 0 ? TextBlockLocation.Y : StemEndLocation.Y;
            var leftX = TextBlockLocation.X < StemEndLocation.X || StemEndLocation.X == 0 ? TextBlockLocation.X : StemEndLocation.X;
            var rightX = TextBlockLocation.X > StemEndLocation.X || StemEndLocation.X == 0 ? TextBlockLocation.X : StemEndLocation.X;
            if (StemDirection == VerticalDirection.Down) rightX += GetNoteheadWidthPx(renderer);

            return new Quadrangle(
                new Point(rightX, upperY),
                new Point(leftX, upperY),
                new Point(rightX, lowerY),
                new Point(leftX, lowerY)
            );
        }

        public override char GetCharacter(IMusicFont font)
        {
            switch (Size)
            {
                case NoteOrRestSize.Full:
                    if (BaseDuration == RhythmicDuration.DoubleWhole) return font.NoteDoubleWhole;
                    else if (BaseDuration == RhythmicDuration.Whole) return font.NoteWhole;
                    else if (BaseDuration == RhythmicDuration.Half) return font.NoteheadHalf;
                    else return font.NoteheadBlack;

                case NoteOrRestSize.Cue:
                    if (BaseDuration == RhythmicDuration.DoubleWhole) return font.NoteDoubleWholeCue;
                    else if (BaseDuration == RhythmicDuration.Whole) return font.NoteWholeCue;
                    else if (BaseDuration == RhythmicDuration.Half) return font.NoteheadHalfCue;
                    else return font.NoteheadBlackCue;

                case NoteOrRestSize.Large:
                    if (BaseDuration == RhythmicDuration.DoubleWhole) return font.NoteDoubleWholeLarge;
                    else if (BaseDuration == RhythmicDuration.Whole) return font.NoteWholeLarge;
                    else if (BaseDuration == RhythmicDuration.Half) return font.NoteheadHalfLarge;
                    else return font.NoteheadBlackLarge;

                default:
                    throw new Exception($"Note size {Size} not supported.");
            }
        }

        /// <summary>
        /// Gets line number for this Note for specific Clef. Fractional numbers represent staff spaces, i.e. 1.5 == first space, etc.
        /// </summary>
        /// <param name="clef"></param>
        /// <returns></returns>
        public double GetLineInSpecificClef(Clef clef)
        {
            var stepDistance = (double)Pitch.StepDistance(this, clef);
            return clef.Line + (stepDistance / 2);
        }
        public char GetNoteFlagCharacter(IMusicFont font, bool isReverse)
        {
            if (BaseDuration == RhythmicDuration.Eighth) return isReverse ? font.NoteFlagEighthRev : font.NoteFlagEighth;
            else if (BaseDuration == RhythmicDuration.Sixteenth) return isReverse ? font.NoteFlagSixteenthRev : font.NoteFlagSixteenth;
            else if (BaseDuration == RhythmicDuration.D32nd) return isReverse ? font.NoteFlag32ndRev : font.NoteFlag32nd;
            else if (BaseDuration == RhythmicDuration.D64th) return isReverse ? font.NoteFlag64thRev : font.NoteFlag64th;
            else if (BaseDuration == RhythmicDuration.D128th) return isReverse ? font.NoteFlag128thRev : font.NoteFlag128th;
            else return '\0';
        }

        [Units(Units.Linespaces)]
        public double GetNoteheadHeightLs(ScoreRendererBase renderer)
        {
            if (renderer.IsSMuFLFont)
            {
                if (renderer.Settings.MusicFontProfile.SMuFLMetadata == null) return 1;
                var bounds = GetSMuFLNoteheadBounds(Size, IsGraceNote, BaseDuration, renderer.Settings.MusicFontProfile.SMuFLMetadata);
                return bounds.BBoxNe[1] - bounds.BBoxSw[1];
            }
            return IsGraceNote || IsCueNote ? 0.8 : 1;
        }

        [Units(Units.Pixels)]
        public double GetNoteheadHeightPx(ScoreRendererBase renderer)
        {
            return renderer.LinespacesToPixels(GetNoteheadHeightLs(renderer));
        }

        [Units(Units.Linespaces)]
        public double GetNoteheadWidthLs(ScoreRendererBase renderer)
        {
            if (renderer.IsSMuFLFont)
            {
                if (renderer.Settings.MusicFontProfile.SMuFLMetadata == null) return 1.18;
                var bounds = GetSMuFLNoteheadBounds(Size, IsGraceNote, BaseDuration, renderer.Settings.MusicFontProfile.SMuFLMetadata);
                var width = bounds.BBoxNe[0] - bounds.BBoxSw[0];

                if (IsGraceNote || Size == NoteOrRestSize.Cue)
                {
                    var fullSizeBounds = GetSMuFLNoteheadBounds(NoteOrRestSize.Full, false, BaseDuration, renderer.Settings.MusicFontProfile.SMuFLMetadata);
                    var fullSizeWidth = fullSizeBounds.BBoxNe[0] - fullSizeBounds.BBoxSw[0];
                    var isMetadataBroken = width > fullSizeWidth;
                    if (isMetadataBroken) return fullSizeWidth * 0.8;
                }
                return width;
            }
            return IsGraceNote || IsCueNote ? 0.6 : 1.1;
        }

        [Units(Units.Pixels)]
        public double GetNoteheadWidthPx(ScoreRendererBase renderer)
        {
            return renderer.LinespacesToPixels(GetNoteheadWidthLs(renderer));
        }

        public double GetStemEndY(ISMuFLFontMetadata metadata)
        {
            if (BaseDuration == RhythmicDuration.Eighth && StemDirection == VerticalDirection.Up) return metadata.GlyphsWithAnchors.Flag8ThUp.StemUpNw?[1] ?? 0;
            if (BaseDuration == RhythmicDuration.Sixteenth && StemDirection == VerticalDirection.Up) return metadata.GlyphsWithAnchors.Flag16ThUp.StemUpNw?[1] ?? 0;
            if (BaseDuration == RhythmicDuration.D32nd && StemDirection == VerticalDirection.Up) return metadata.GlyphsWithAnchors.Flag32NdUp.StemUpNw?[1] ?? 0;
            if (BaseDuration == RhythmicDuration.D64th && StemDirection == VerticalDirection.Up) return metadata.GlyphsWithAnchors.Flag64ThUp.StemUpNw?[1] ?? 0;
            if (BaseDuration == RhythmicDuration.D128th && StemDirection == VerticalDirection.Up) return metadata.GlyphsWithAnchors.Flag128ThUp.StemUpNw?[1] ?? 0;

            if (BaseDuration == RhythmicDuration.Eighth && StemDirection == VerticalDirection.Down) return metadata.GlyphsWithAnchors.Flag8ThDown.StemDownSw?[1] ?? 0;
            if (BaseDuration == RhythmicDuration.Sixteenth && StemDirection == VerticalDirection.Down) return metadata.GlyphsWithAnchors.Flag16ThDown.StemDownSw?[1] ?? 0;
            if (BaseDuration == RhythmicDuration.D32nd && StemDirection == VerticalDirection.Down) return metadata.GlyphsWithAnchors.Flag32NdDown.StemDownSw?[1] ?? 0;
            if (BaseDuration == RhythmicDuration.D64th && StemDirection == VerticalDirection.Down) return metadata.GlyphsWithAnchors.Flag64ThDown.StemDownSw?[1] ?? 0;
            if (BaseDuration == RhythmicDuration.D128th && StemDirection == VerticalDirection.Down) return metadata.GlyphsWithAnchors.Flag128ThDown.StemDownSw?[1] ?? 0;

            return 0;
        }

        public double GetStemLength(ISMuFLFontMetadata metadata)
        {
            return Math.Abs(metadata.GlyphBBoxes.Stem.BBoxNe[1] - metadata.GlyphBBoxes.Stem.BBoxSw[1]);
        }

        public double GetStemOriginY(ISMuFLFontMetadata metadata)
        {
            if (BaseDuration == RhythmicDuration.Eighth && StemDirection == VerticalDirection.Up) return metadata.GlyphsWithAnchors.Flag8ThUp.StemUpSe?[1] ?? 0;
            if (BaseDuration == RhythmicDuration.Sixteenth && StemDirection == VerticalDirection.Up) return metadata.GlyphsWithAnchors.Flag16ThUp.StemUpSe?[1] ?? 0;
            if (BaseDuration == RhythmicDuration.D32nd && StemDirection == VerticalDirection.Up) return metadata.GlyphsWithAnchors.Flag32NdUp.StemUpSe?[1] ?? 0;
            if (BaseDuration == RhythmicDuration.D64th && StemDirection == VerticalDirection.Up) return metadata.GlyphsWithAnchors.Flag64ThUp.StemUpSe?[1] ?? 0;
            if (BaseDuration == RhythmicDuration.D128th && StemDirection == VerticalDirection.Up) return metadata.GlyphsWithAnchors.Flag128ThUp.StemUpSe?[1] ?? 0;

            if (BaseDuration == RhythmicDuration.Eighth && StemDirection == VerticalDirection.Down) return metadata.GlyphsWithAnchors.Flag8ThDown.StemDownNw?[1] ?? 0;
            if (BaseDuration == RhythmicDuration.Sixteenth && StemDirection == VerticalDirection.Down) return metadata.GlyphsWithAnchors.Flag16ThDown.StemDownNw?[1] ?? 0;
            if (BaseDuration == RhythmicDuration.D32nd && StemDirection == VerticalDirection.Down) return metadata.GlyphsWithAnchors.Flag32NdDown.StemDownNw?[1] ?? 0;
            if (BaseDuration == RhythmicDuration.D64th && StemDirection == VerticalDirection.Down) return metadata.GlyphsWithAnchors.Flag64ThDown.StemDownNw?[1] ?? 0;
            if (BaseDuration == RhythmicDuration.D128th && StemDirection == VerticalDirection.Down) return metadata.GlyphsWithAnchors.Flag128ThDown.StemDownNw?[1] ?? 0;

            return 0;
        }

        /// <summary>
        /// Returns a string representation of this symbol for debugging purposes
        /// </summary>
        /// <returns>String representation of this symbol for debugging purposes</returns>
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", base.ToString(), Pitch.ToString(), Duration.ToString());
        }

        private static BoundingBox GetSMuFLNoteheadBounds(NoteOrRestSize size, bool isGraceNote, RhythmicDuration duration, ISMuFLFontMetadata metadata)
        {
            if (isGraceNote)
            {
                if (duration == RhythmicDuration.Whole) return metadata.GlyphBBoxes.NoteheadWholeSmall;
                else if (duration == RhythmicDuration.Half) return metadata.GlyphBBoxes.NoteheadHalfSmall;
                else return metadata.GlyphBBoxes.NoteheadBlackSmall;
            }

            switch (size)
            {
                case NoteOrRestSize.Full:
                    if (duration == RhythmicDuration.Whole) return metadata.GlyphBBoxes.NoteheadWhole;
                    else if (duration == RhythmicDuration.Half) return metadata.GlyphBBoxes.NoteheadHalf;
                    else return metadata.GlyphBBoxes.NoteheadBlack;

                case NoteOrRestSize.Cue:
                    if (duration == RhythmicDuration.Whole) return metadata.GlyphBBoxes.NoteheadWholeSmall;
                    else if (duration == RhythmicDuration.Half) return metadata.GlyphBBoxes.NoteheadHalfSmall;
                    else return metadata.GlyphBBoxes.NoteheadBlackSmall;

                case NoteOrRestSize.Large:
                    if (duration == RhythmicDuration.Whole) return metadata.GlyphBBoxes.NoteheadWholeOversized;
                    else if (duration == RhythmicDuration.Half) return metadata.GlyphBBoxes.NoteheadHalfOversized;
                    else return metadata.GlyphBBoxes.NoteheadBlackOversized;

                default:
                    throw new Exception($"Note size {size} not supported.");
            }
        }

        private void DetermineMusicalCharacter()
        {
        }

        private void RestoreBeams()
        {
            if (Staff == null) return;
            var beamGroup = Staff.BeamGroups.FirstOrDefault(bg => bg.Members.Contains(this));
            if (beamGroup == null) return;
            var rebeamMode = beamGroup.Members.OfType<Note>().Select(n => n.ModeUsedForRebeaming).FirstOrDefault();
            if (rebeamMode == null) return;
            StaffBuilder.Rebeam(beamGroup.Members, rebeamMode.Value);
        }
    }
}