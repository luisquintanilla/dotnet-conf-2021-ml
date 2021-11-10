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
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering;
using Manufaktura.Music.Model;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a clef.
    /// </summary>
    public class Clef : MusicalSymbol, IHasPitch, IRenderedAsTextBlock, ICanCalculateRenderedBounds
    {
        private int line;
        private int octaveChange;
        private ClefType typeOfClef;

        /// <summary>
        /// Initializes a new instance of Clef.
        /// </summary>
        /// <param name="clefType">Type of clef (C, F, G)</param>
        /// <param name="whichLine">Line</param>
        public Clef(ClefType clefType, int whichLine, int octaveShift = 0)
        {
            typeOfClef = clefType;
            line = whichLine;
            if (typeOfClef == ClefType.GClef)
            {
                Pitch = Pitch.FromStep(Step.G, 4 + octaveShift);
            }
            else if (typeOfClef == ClefType.FClef)
            {
                Pitch = Pitch.FromStep(Step.F, 3 + octaveShift);
            }
            else if (typeOfClef == ClefType.CClef)
            {
                Pitch = Pitch.FromStep(Step.C, 4 + octaveShift);
            }
            else if (typeOfClef == ClefType.Percussion)
            {
                Pitch = Pitch.FromStep(Step.G, 4 + octaveShift);
            }
        }

        /// <summary>
        /// Returns a new instance of alto clef.
        /// </summary>
        public static Clef Alto
        {
            get { return new Clef(ClefType.CClef, 3); }
        }

        /// <summary>
        /// Returns a new instance of baritone "C" clef.
        /// </summary>
        public static Clef BaritoneC
        {
            get { return new Clef(ClefType.CClef, 5); }
        }

        /// <summary>
        /// Returns a new instance of baritone "F" clef.
        /// </summary>
        public static Clef BaritoneF
        {
            get { return new Clef(ClefType.FClef, 3); }
        }

        /// <summary>
        /// Returns a new instance of bass clef.
        /// </summary>
        public static Clef Bass
        {
            get { return new Clef(ClefType.FClef, 4); }
        }

        /// <summary>
        /// Returns a new instance of french violin clef.
        /// </summary>
        public static Clef FrenchViolin
        {
            get { return new Clef(ClefType.GClef, 1); }
        }

        /// <summary>
        /// Returns a new instance of mezzosoprano clef.
        /// </summary>
        public static Clef Mezzosoprano
        {
            get { return new Clef(ClefType.CClef, 2); }
        }

        /// <summary>
        /// Returns a new instance of soprano clef.
        /// </summary>
        public static Clef Soprano
        {
            get { return new Clef(ClefType.CClef, 1); }
        }

        /// <summary>
        /// Returns a new instance of subbass clef.
        /// </summary>
        public static Clef Subbass
        {
            get { return new Clef(ClefType.FClef, 5); }
        }

        /// <summary>
        /// Returns a new instance of tenor clef.
        /// </summary>
        public static Clef Tenor
        {
            get { return new Clef(ClefType.CClef, 4, -1); }
        }

        /// <summary>
        /// Returns a new instance of treble clef.
        /// </summary>
        public static Clef Treble
        {
            get { return new Clef(ClefType.GClef, 2); }
        }

        /// <summary>
        /// Clef line
        /// </summary>
        public int Line { get { return line; } }

        public int OctaveChange
        {
            get
            {
                return octaveChange;
            }

            set
            {
                if (value > 0) for (var i = 0; i < value; i++) Pitch = Pitch.OctaveUp();
                if (value < 0) for (var i = 0; i > value; i--) Pitch = Pitch.OctaveDown();
                octaveChange = value; OnPropertyChanged();
            }
        }

        /// <summary>
        /// Pitch of clef.
        /// </summary>
        /// <remarks>
        /// Note that only some pitches (steps C, F, G) are valid for clefs.
        /// </remarks>
        public Pitch Pitch { get; private set; }

        public Point TextBlockLocation
        {
            get;
            set;
        }

        /// <summary>
        /// Type of clef (C-clef, G-clef or F-clef)
        /// </summary>
        public ClefType TypeOfClef { get { return typeOfClef; } }

        /// <summary>
        /// This methods selects a appropriate clef for a note to make the note comfortably visible in the staff.
        /// </summary>
        /// <param name="n">Note</param>
        /// <returns>Appropriate clef</returns>
        public static Clef SuggestClefForANote(Note n)
        {
            if (n.MidiPitch < 55) return new Clef(ClefType.FClef, 4);
            else return new Clef(ClefType.GClef, 2);
        }

        /// <summary>
        /// This methods selects a appropriate clef for a note to make the note comfortably visible in the staff.
        /// </summary>
        /// <param name="n">Note</param>
        /// <param name="currentClef">Current clef</param>
        /// <returns>Appropriate clef</returns>
        public static Clef SuggestClefForANote(Note n, Clef currentClef)
        {
            if (currentClef.TypeOfClef == ClefType.GClef)
            {
                if ((currentClef.Line == 1) && (n.MidiPitch < 59)) return new Clef(ClefType.FClef, 4);
                else if ((currentClef.Line == 2) && (n.MidiPitch < 55)) return new Clef(ClefType.FClef, 4);
                else if ((currentClef.Line == 3) && (n.MidiPitch < 52)) return new Clef(ClefType.FClef, 4);
                else if ((currentClef.Line == 4) && (n.MidiPitch < 48)) return new Clef(ClefType.FClef, 4);
                else if ((currentClef.Line == 5) && (n.MidiPitch < 45)) return new Clef(ClefType.FClef, 4);
                else return currentClef;
            }
            else if (currentClef.TypeOfClef == ClefType.FClef)
            {
                if ((currentClef.Line == 1) && (n.MidiPitch > 74)) return new Clef(ClefType.GClef, 2);
                else if ((currentClef.Line == 2) && (n.MidiPitch > 71)) return new Clef(ClefType.GClef, 2);
                else if ((currentClef.Line == 3) && (n.MidiPitch > 67)) return new Clef(ClefType.GClef, 2);
                else if ((currentClef.Line == 4) && (n.MidiPitch > 64)) return new Clef(ClefType.GClef, 2);
                else if ((currentClef.Line == 5) && (n.MidiPitch > 60)) return new Clef(ClefType.GClef, 2);
                else return currentClef;
            }
            else return new Clef(ClefType.GClef, 2);
        }

        public Quadrangle GetBounds(ScoreRendererBase renderer)
        {
            var baseline = TextBlockLocation.Y;
            double upper = 0;
            double lower = 0;
            double left = 0;
            double right = 0;
            if (renderer.IsSMuFLFont)
            {
                switch (typeOfClef)
                {
                    case ClefType.GClef:
                        upper = baseline - renderer.LinespacesToPixels( renderer.Settings.MusicFontProfile.SMuFLMetadata.GlyphBBoxes.GClef.BBoxNe[1]);
                        lower = baseline - renderer.LinespacesToPixels(renderer.Settings.MusicFontProfile.SMuFLMetadata.GlyphBBoxes.GClef.BBoxSw[1]);
                        left = baseline - renderer.LinespacesToPixels(renderer.Settings.MusicFontProfile.SMuFLMetadata.GlyphBBoxes.GClef.BBoxSw[0]);
                        right = baseline - renderer.LinespacesToPixels(renderer.Settings.MusicFontProfile.SMuFLMetadata.GlyphBBoxes.GClef.BBoxNe[0]);
                        break;

                    case ClefType.CClef:
                        upper = baseline- renderer.LinespacesToPixels(renderer.Settings.MusicFontProfile.SMuFLMetadata.GlyphBBoxes.CClef.BBoxNe[1]);
                        lower = baseline - renderer.LinespacesToPixels(renderer.Settings.MusicFontProfile.SMuFLMetadata.GlyphBBoxes.CClef.BBoxSw[1]);
                        left = baseline - renderer.LinespacesToPixels(renderer.Settings.MusicFontProfile.SMuFLMetadata.GlyphBBoxes.CClef.BBoxSw[0]);
                        right = baseline - renderer.LinespacesToPixels(renderer.Settings.MusicFontProfile.SMuFLMetadata.GlyphBBoxes.CClef.BBoxNe[0]);
                        break;

                    case ClefType.FClef:
                        upper = baseline- renderer.LinespacesToPixels(renderer.Settings.MusicFontProfile.SMuFLMetadata.GlyphBBoxes.FClef.BBoxNe[1]);
                        lower = baseline - renderer.LinespacesToPixels(renderer.Settings.MusicFontProfile.SMuFLMetadata.GlyphBBoxes.FClef.BBoxSw[1]);
                        left = baseline - renderer.LinespacesToPixels(renderer.Settings.MusicFontProfile.SMuFLMetadata.GlyphBBoxes.FClef.BBoxSw[0]);
                        right = baseline - renderer.LinespacesToPixels(renderer.Settings.MusicFontProfile.SMuFLMetadata.GlyphBBoxes.FClef.BBoxNe[0]);
                        break;
                }
            }
            return new Quadrangle(
             new Point(right, upper),
             new Point(left, upper),
             new Point(right, lower),
             new Point(left, lower)
         );
        }

        public char GetCharacter(IMusicFont font)
        {
            if (typeOfClef == ClefType.GClef && OctaveChange == 1) return font.GClef8va;
            else if (typeOfClef == ClefType.GClef && OctaveChange == -1) return font.GClef8vb;
            else if (typeOfClef == ClefType.GClef && OctaveChange == 2) return font.GClef15ma;
            else if (typeOfClef == ClefType.GClef && OctaveChange == -2) return font.GClef15mb;
            else if (typeOfClef == ClefType.GClef) return font.GClef;
            else if (typeOfClef == ClefType.FClef && OctaveChange == 1) return font.FClef8va;
            else if (typeOfClef == ClefType.FClef && OctaveChange == -1) return font.FClef8vb;
            else if (typeOfClef == ClefType.FClef && OctaveChange == 2) return font.FClef15ma;
            else if (typeOfClef == ClefType.FClef && OctaveChange == -2) return font.FClef15mb;
            else if (typeOfClef == ClefType.FClef) return font.FClef;
            else if (typeOfClef == ClefType.CClef && OctaveChange == 1) return font.CClef8va;
            else if (typeOfClef == ClefType.CClef && OctaveChange == -1) return font.CClef8vb;
            else if (typeOfClef == ClefType.CClef && OctaveChange == 2) return font.CClef15ma;
            else if (typeOfClef == ClefType.CClef && OctaveChange == -2) return font.CClef15mb;
            else if (typeOfClef == ClefType.CClef) return font.CClef;
            else if (typeOfClef == ClefType.Percussion) return font.PercussionClef;
            else return '\0';
        }

        public BoundingBox GetSMuFLBoundingBox(ISMuFLFontMetadata metadata)
        {
            if (typeOfClef == ClefType.GClef) return metadata.GlyphBBoxes.GClef;
            else if (typeOfClef == ClefType.FClef) return metadata.GlyphBBoxes.FClef;
            else if (typeOfClef == ClefType.CClef) return metadata.GlyphBBoxes.CClef;
            else if (typeOfClef == ClefType.Percussion) return metadata.GlyphBBoxes.SemipitchedPercussionClef1;
            else return metadata.GlyphBBoxes.GClef;
        }

        /// <summary>
        /// Returns a string representation of this symbol for debugging purposes
        /// </summary>
        /// <returns>String representation of this symbol for debugging purposes</returns>
        public override string ToString()
        {
            return string.Format("{0} {1} on line {2}", base.ToString(), TypeOfClef.ToString(), Line);
        }
    }
}