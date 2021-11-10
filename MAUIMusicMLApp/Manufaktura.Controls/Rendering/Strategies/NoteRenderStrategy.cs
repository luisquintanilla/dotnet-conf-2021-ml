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
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Model.Misc;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering.Snippets;
using Manufaktura.Controls.Rendering.Strategies.Slurs;
using Manufaktura.Controls.Services;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    /// <summary>
    /// Strategy for rendering Notes
    /// </summary>
	public class NoteRenderStrategy : MusicalSymbolRenderStrategy<Note>
    {
        private readonly IAlterationService alterationService;
        private readonly IBeamingService beamingService;
        private readonly IMeasurementService measurementService;
        private SlurRenderStrategy[] slurRenderStrategies;

        /// <summary>
        /// Initializes a new instance of NoteRenderStrategy
        /// </summary>
        /// <param name="measurementService"></param>
        /// <param name="alterationService"></param>
        /// <param name="scoreService"></param>
        /// <param name="beamingService"></param>
		public NoteRenderStrategy(IMeasurementService measurementService, IAlterationService alterationService, IScoreService scoreService, IBeamingService beamingService) : base(scoreService)
        {
            this.measurementService = measurementService;
            this.alterationService = alterationService;
            this.beamingService = beamingService;
        }

        public static Note[] GetChord(Note lowestNote, Staff staff)
        {
            var chordElements = new List<Note>() { lowestNote };
            for (int i = staff.Elements.IndexOf(lowestNote) + 1; i < staff.Elements.Count; i++)
            {
                Note currentNote = staff.Elements[i] as Note;
                if (currentNote == null) continue;
                if (currentNote.IsUpperMemberOfChord) chordElements.Add(currentNote);
                else break;
            }
            return chordElements.ToArray();
        }

        /// <summary>
        /// Renders a note with a specific score renderer
        /// </summary>
        /// <param name="element"></param>
        /// <param name="renderer"></param>
		public override void Render(Note element, ScoreRendererBase renderer, FontProfile fontProfile)
        {
            if (slurRenderStrategies == null) slurRenderStrategies = renderer.Resolver.ResolveAll<SlurRenderStrategy>().ToArray();

            //Jeśli ustalono default-x, to pozycjonuj wg default-x, a nie automatycznie
            if (!renderer.Settings.IgnoreCustomElementPositions && element.DefaultXPosition.HasValue)
            {
                scoreService.CursorPositionX = measurementService.LastMeasurePositionX + element.DefaultXPosition.Value * renderer.Settings.CustomElementPositionRatio;
            }

            if (scoreService.CurrentMeasure.FirstNoteInMeasureXPosition == 0) scoreService.CurrentMeasure.FirstNoteInMeasureXPosition = scoreService.CursorPositionX;

            //If it's second voice, rewind position to the beginning of measure (but only if default-x is not set or is ignored):
            if (element.Voice > scoreService.CurrentVoice && (renderer.Settings.IgnoreCustomElementPositions || !element.DefaultXPosition.HasValue))
            {
                scoreService.CursorPositionX = scoreService.CurrentMeasure.FirstNoteInMeasureXPosition;
                measurementService.LastNoteInMeasureEndXPosition = measurementService.LastNoteEndXPosition;
            }
            scoreService.CurrentVoice = element.Voice;

            if (element.Tuplet == TupletType.Start)
            {
                Tuplet tuplet = new Tuplet();
                measurementService.TupletState = tuplet;
                tuplet.NumberOfNotesUnderTuplet = 0;
                tuplet.TupletPlacement = element.TupletPlacement.HasValue ? element.TupletPlacement.Value :
                    (element.StemDirection == VerticalDirection.Down ? VerticalPlacement.Below : VerticalPlacement.Above);
            }
            if (measurementService.TupletState != null && !element.IsUpperMemberOfChord) measurementService.TupletState.NumberOfNotesUnderTuplet++;

            if (element.IsUpperMemberOfChord) scoreService.CursorPositionX = measurementService.LastNotePositionX;

            double noteTextBlockPositionY = CalculateNotePositionY(element, renderer);
            var chord = GetChord(element, scoreService.CurrentStaff);   //Chord or single note

            MakeSpaceForAccidentals(renderer, element, chord);                  //Move the element a bit to the right if it has accidentals / Przesuń nutę trochę w prawo, jeśli nuta ma znaki przygodne
            DrawNotehead(renderer, element, noteTextBlockPositionY, fontProfile);   //Draw an element / Rysuj nutę
            DrawLedgerLines(renderer, element, noteTextBlockPositionY);         //Ledger lines / Linie dodane
            DrawStems(renderer, element, noteTextBlockPositionY, chord, fontProfile);        //Stems are vertical lines, beams are horizontal lines / Rysuj ogonki (ogonki to są te w pionie - poziome są belki)
            DrawFlagsAndTupletMarks(renderer, element);                         //Draw beams / Rysuj belki
            DrawTies(renderer, element, noteTextBlockPositionY);                //Draw ties / Rysuj łuki
            DrawSlurs(renderer, element, noteTextBlockPositionY, fontProfile);  //Draw slurs / Rysuj łuki legatowe
            DrawLyrics(renderer, element);                                      //Draw lyrics / Rysuj tekst
            DrawArticulation(renderer, element, noteTextBlockPositionY, fontProfile);        //Draw articulation / Rysuj artykulację:
            DrawTrills(renderer, element, noteTextBlockPositionY, fontProfile);              //Draw trills / Rysuj tryle //TODO: REFAKTOR - Przenieść do DrawOrnaments
            DrawOrnaments(renderer, element, noteTextBlockPositionY, fontProfile);           //Draw ornaments / Rysuj ornamenty
            DrawTremolos(renderer, element, noteTextBlockPositionY);                         //Draw tremolos / Rysuj tremola
            DrawFermataSign(renderer, element, noteTextBlockPositionY, fontProfile);         //Draw fermata sign / Rysuj symbol fermaty
            DrawAccidentals(renderer, element, noteTextBlockPositionY, fontProfile);         //Draw accidentals / Rysuj znaki przygodne:
            DrawDots(renderer, element, noteTextBlockPositionY, fontProfile);                //Draw dots / Rysuj kropki

            if (renderer.Settings.IgnoreCustomElementPositions || !element.DefaultXPosition.HasValue) //Pozycjonowanie automatyczne tylko, gdy nie określono default-x
            {
                if (element.Duration == RhythmicDuration.Whole) scoreService.CursorPositionX += 50;
                else if (element.Duration == RhythmicDuration.Half) scoreService.CursorPositionX += 30;
                else if (element.Duration == RhythmicDuration.Quarter) scoreService.CursorPositionX += 18;
                else if (element.Duration == RhythmicDuration.Eighth) scoreService.CursorPositionX += 15;
                else scoreService.CursorPositionX += 14;

                //Przesuń trochę w prawo, jeśli nuta ma tekst, żeby litery nie wchodziły na siebie
                //Move a bit right if the element has a lyric to prevent letters from hiding each other
                if (element.Lyrics.Count > 0)
                {
                    scoreService.CursorPositionX += element.Lyrics[0].Text.Length * 2;
                }
            }
            measurementService.LastNoteEndXPosition = scoreService.CursorPositionX;

            element.ActualRenderedBounds = element.GetBounds(renderer);
        }

        private static double CalculateNotePositionYForClef(Note element, Clef clef, ScoreRendererBase renderer)
        {
            var stepDistanceFromClef = Pitch.StepDistance(clef, element.Pitch);
            element.GoverningClef = clef;
            element.Line = element.GetLineInSpecificClef(element.GoverningClef);
            return clef.TextBlockLocation.Y + stepDistanceFromClef * ((double)renderer.Settings.LineSpacing / 2.0f);
        }

        private static double CalculateSpaceForAccidentals(Note element, Key key)
        {
            int numberOfSingleAccidentals = Math.Abs(element.Alter) % 2;
            int numberOfDoubleAccidentals = Convert.ToInt32(Math.Floor((double)(Math.Abs(element.Alter) / 2)));

            var space = 0;
            if (element.Alter - key.StepToAlter(element.Step) != 0)
            {
                if (numberOfSingleAccidentals > 0) space += 9;
                if (numberOfDoubleAccidentals > 0)
                    space += (numberOfDoubleAccidentals) * 9;
            }
            if (element.HasNatural == true) space += 9;

            return space;
        }

        private static double CorrectOrnamentYPositionToAvoidIntersection(ScoreRendererBase renderer, VerticalPlacement placement,
            double ornamentHeight,
            double yPosition, Note element, double notePositionY)
        {
            if (placement == VerticalPlacement.Above && yPosition + ornamentHeight > element.StemEndLocation.Y)
                yPosition = element.StemEndLocation.Y - ornamentHeight - renderer.Settings.LineSpacing;
            if (placement == VerticalPlacement.Above && yPosition + ornamentHeight > notePositionY)
                yPosition = notePositionY - ornamentHeight - renderer.Settings.LineSpacing;
            if (placement == VerticalPlacement.Below && yPosition + ornamentHeight < element.StemEndLocation.Y)
                yPosition = element.StemEndLocation.Y + ornamentHeight + renderer.Settings.LineSpacing;
            if (placement == VerticalPlacement.Below && yPosition + ornamentHeight < notePositionY)
                yPosition = notePositionY + ornamentHeight + renderer.Settings.LineSpacing;

            return yPosition;
        }

        private static ICanCalculateRenderedBounds[] GetElementsUnderBeam(Note firstOrLastNote, Staff staff)
        {
            var notesUnderOneBeam = new List<ICanCalculateRenderedBounds>();
            if (firstOrLastNote.BeamList.Any() && firstOrLastNote.BeamList[0] == NoteBeamType.Start)
            {
                notesUnderOneBeam.Add(firstOrLastNote);
                for (int i = staff.Elements.IndexOf(firstOrLastNote) + 1; i < staff.Elements.Count; i++)
                {
                    Note currentNote = staff.Elements[i] as Note;
                    if (currentNote == null)
                    {
                        var el = staff.Elements[i] as ICanCalculateRenderedBounds;
                        if (el != null) notesUnderOneBeam.Add(el);
                        continue;
                    }

                    notesUnderOneBeam.Add(currentNote);
                    if (currentNote.BeamList.Any() && currentNote.BeamList[0] == NoteBeamType.End) break;
                }
            }
            else if (firstOrLastNote.BeamList.Any() && firstOrLastNote.BeamList[0] == NoteBeamType.End)
            {
                for (int i = staff.Elements.IndexOf(firstOrLastNote) - 1; i > 0; i--)
                {
                    Note currentNote = staff.Elements[i] as Note;
                    if (currentNote == null)
                    {
                        var el = staff.Elements[i] as ICanCalculateRenderedBounds;
                        if (el != null) notesUnderOneBeam.Insert(0, el);
                        continue;
                    }

                    notesUnderOneBeam.Insert(0, currentNote);
                    if (currentNote.BeamList.Any() && currentNote.BeamList[0] == NoteBeamType.Start) break;
                }
                notesUnderOneBeam.Add(firstOrLastNote);
            }
            return notesUnderOneBeam.ToArray();
        }

        private static double GetNoteheadWidthPx(Note element, ScoreRendererBase renderer, double ratio = 1) =>
                            renderer.LinespacesToPixels(element.GetNoteheadWidthLs(renderer) * ratio);

        private double CalculateNotePositionY(Note element, ScoreRendererBase renderer) => CalculateNotePositionYForClef(element, scoreService.CurrentClef, renderer);

        /// <summary>
        /// Adds some slope to beam according to line distance between first and last note
        /// </summary>
        /// <param name="notesUnderBeam"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        private double CreateBeamSlope(Note[] notesUnderBeam, Note element)
        {
            //Previously I was counting the distance between midi pitches but it was misleading if clef changed under beam. Now I compare positions on lines.
            var firstNoteLine = notesUnderBeam.First().Line;
            var lastNoteLine = notesUnderBeam.Last().Line;
            var lineDistanceBetweenBounds = lastNoteLine - firstNoteLine;

            var isFirstNote = element == notesUnderBeam.First();
            return lineDistanceBetweenBounds * (isFirstNote ? 2.4 : -2.4);
        }

        private void DrawAccidentals(ScoreRendererBase renderer, Note element, double notePositionY, FontProfile fontProfile)
        {
            int numberOfSingleAccidentals = Math.Abs(element.Alter) % 2;
            int numberOfDoubleAccidentals = Convert.ToInt32(Math.Floor((double)(Math.Abs(element.Alter) / 2)));

            if (element.Alter - scoreService.CurrentKey.StepToAlter(element.Step) - alterationService.Get(element.Step) > 0)
            {
                alterationService.Set(element.Step, element.Alter - scoreService.CurrentKey.StepToAlter(element.Step));
                double accPlacement = scoreService.CursorPositionX - 8 * numberOfSingleAccidentals - 6 * numberOfDoubleAccidentals;
                for (int i = 0; i < numberOfSingleAccidentals; i++)
                {
                    renderer.DrawCharacter(fontProfile.MusicFont.Sharp, MusicFontStyles.MusicFont, accPlacement, notePositionY, element);
                    accPlacement += 9;
                }
                for (int i = 0; i < numberOfDoubleAccidentals; i++)
                {
                    renderer.DrawCharacter(fontProfile.MusicFont.DoubleSharp, MusicFontStyles.MusicFont, accPlacement, notePositionY, element);
                    accPlacement += 9;
                }
            }
            else if (element.Alter - scoreService.CurrentKey.StepToAlter(element.Step) - alterationService.Get(element.Step) < 0)
            {
                alterationService.Set(element.Step, element.Alter - scoreService.CurrentKey.StepToAlter(element.Step));
                double accPlacement = scoreService.CursorPositionX - 8 * numberOfSingleAccidentals -
                    6 * numberOfDoubleAccidentals;
                for (int i = 0; i < numberOfSingleAccidentals; i++)
                {
                    renderer.DrawCharacter(fontProfile.MusicFont.Flat, MusicFontStyles.MusicFont, accPlacement, notePositionY, element);
                    accPlacement += 9;
                }
                for (int i = 0; i < numberOfDoubleAccidentals; i++)
                {
                    renderer.DrawCharacter(fontProfile.MusicFont.DoubleFlat, MusicFontStyles.MusicFont, accPlacement, notePositionY, element);
                    accPlacement += 9;
                }
            }
            if (element.HasNatural == true)
            {
                renderer.DrawCharacter(fontProfile.MusicFont.Natural, MusicFontStyles.MusicFont, scoreService.CursorPositionX - 10, notePositionY, element);
            }
        }

        private void DrawArticulation(ScoreRendererBase renderer, Note element, double notePositionY, FontProfile fontProfile)
        {
            if (element.Articulation != ArticulationType.None)
            {
                double articulationPosition = notePositionY + 10;
                if (element.ArticulationPlacement == VerticalPlacement.Above)
                    articulationPosition = notePositionY - 10;
                else if (element.ArticulationPlacement == VerticalPlacement.Below)
                    articulationPosition = notePositionY + 10;

                if (element.Articulation == ArticulationType.Staccato)
                    renderer.DrawCharacter(fontProfile.MusicFont.AugmentationDot, MusicFontStyles.MusicFont, scoreService.CursorPositionX - 1, articulationPosition, element);
                else if (element.Articulation == ArticulationType.Accent)
                    renderer.DrawString(">", MusicFontStyles.DirectionFont, scoreService.CursorPositionX - 1, articulationPosition + 16, element);
            }
        }

        private void DrawDots(ScoreRendererBase renderer, Note element, double notePositionY, FontProfile fontProfile)
        {
            if (element.NumberOfDots > 0) scoreService.CursorPositionX += 16;
            for (int i = 0; i < element.NumberOfDots; i++)
            {
                renderer.DrawCharacter(fontProfile.MusicFont.AugmentationDot, MusicFontStyles.MusicFont, scoreService.CursorPositionX, notePositionY, element);
                scoreService.CursorPositionX += 6;
            }
        }

        private void DrawFermataSign(ScoreRendererBase renderer, Note element, double notePositionY, FontProfile fontProfile)
        {
            if (element.HasFermataSign)
            {
                double ferPosY = scoreService.CurrentLinePositions[0] - renderer.LinespacesToPixels(2.5);
                while (ferPosY > notePositionY || ferPosY > element.StemEndLocation.Y)
                {
                    ferPosY -= renderer.LinespacesToPixels(0.5);
                    if (ferPosY < scoreService.CurrentLinePositions[0] - renderer.LinespacesToPixels(4)) break;
                }
                char fermataVersion = fontProfile.MusicFont.FermataUp;

                renderer.DrawCharacter(fermataVersion, MusicFontStyles.MusicFont, scoreService.CursorPositionX, ferPosY, element);
            }
        }

        private void DrawFlagsAndTupletMarks(ScoreRendererBase renderer, Note element)
        {
            int beamOffset = 0;
            //Powiększ listę poprzednich pozycji stemów jeśli aktualna liczba belek jest większa
            //Extend the list of previous stem positions if current number of beams is greater than the list size
            if (beamingService.PreviousStemEndPositionsY.Count < element.BeamList.Count)
            {
                int tmpCount = beamingService.PreviousStemEndPositionsY.Count;
                for (int i = 0; i < element.BeamList.Count - tmpCount; i++)
                    beamingService.PreviousStemEndPositionsY.Add(new int());
            }
            if (beamingService.PreviousStemPositionsX.Count < element.BeamList.Count)
            {
                int tmpCount = beamingService.PreviousStemPositionsX.Count;
                for (int i = 0; i < element.BeamList.Count - tmpCount; i++)
                    beamingService.PreviousStemPositionsX.Add(new int());
            }
            int beamLoop = 0;
            foreach (NoteBeamType beam in element.BeamList)
            {
                var beamSpaceDirection = element.StemDirection == VerticalDirection.Up ? 1 : -1;
                if (beam == NoteBeamType.Start)
                {
                    if (beamLoop == 0)
                    {
                        beamingService.PreviousStemEndPositionsY[beamLoop] = beamingService.CurrentStemEndPositionY;
                    }
                    beamingService.PreviousStemPositionsX[beamLoop] = beamingService.CurrentStemPositionX;
                }
                else if (beam == NoteBeamType.End)
                {
                    //Draw tuplet mark / Rysuj oznaczenie trioli:
                    if (element.Tuplet == TupletType.Stop && measurementService.TupletState != null)
                    {
                        Beams.TupletMark(measurementService, scoreService, renderer, element);
                        measurementService.TupletState = null;
                    }
                }
                else if (beam == NoteBeamType.Single && !element.IsUpperMemberOfChord)
                {
                    Beams.Flag(beamingService, measurementService, scoreService, renderer, element, beamSpaceDirection, beamLoop, beamOffset);
                }

                beamOffset += 4;
                beamLoop++;
            }
        }

        private void DrawLedgerLines(ScoreRendererBase renderer, Note element, double notePositionY)
        {
            var ledgerLinePen = renderer.CreatePenFromDefaults(element, "legerLineThickness", s => s.DefaultStaffLineThickness);

            double startPositionX = scoreService.CursorPositionX - (renderer.IsSMuFLFont ? element.GetNoteheadWidthPx(renderer) * 0.5 : 0);
            double endPositionX = scoreService.CursorPositionX + (renderer.IsSMuFLFont ? element.GetNoteheadWidthPx(renderer) * 1.5 : renderer.LinespacesToPixels(element.GetNoteheadWidthLs(renderer) * 2.2));
            if (notePositionY > scoreService.CurrentLinePositions[4] + renderer.Settings.LineSpacing / 2.0f)
            {
                for (double i = scoreService.CurrentLinePositions[4]; i < notePositionY - renderer.Settings.LineSpacing / 2.0f; i += renderer.Settings.LineSpacing)
                {
                    renderer.DrawLine(
                        new Point(startPositionX, i + renderer.Settings.LineSpacing),
                        new Point(endPositionX, i + renderer.Settings.LineSpacing), ledgerLinePen, element);
                }
            }
            if (notePositionY < scoreService.CurrentLinePositions[0] - renderer.Settings.LineSpacing / 2)
            {
                for (double i = scoreService.CurrentLinePositions[0]; i > notePositionY + renderer.Settings.LineSpacing / 2.0f; i -= renderer.Settings.LineSpacing)
                {
                    renderer.DrawLine(
                        new Point(startPositionX, i - renderer.Settings.LineSpacing),
                        new Point(endPositionX, i - renderer.Settings.LineSpacing), ledgerLinePen, element);
                }
            }
        }

        private void DrawLyrics(ScoreRendererBase renderer, Note element)
        {
            double versePositionY = scoreService.CurrentLinePositions[4] + 10;    //Default value if default-y is not set
            foreach (Lyrics lyrics in element.Lyrics)
            {
                var textPosition = lyrics.DefaultYPosition.HasValue ?
                    scoreService.CurrentLinePositions[0] - renderer.TenthsToPixels(lyrics.DefaultYPosition.Value) :
                    versePositionY;

                StringBuilder sBuilder = new StringBuilder();
                sBuilder.Append(lyrics.Text);

                //TODO: Dodać do kalkulacji wyliczoną szerokość stringa w poprzednim lyricu i odkomentować :)
                //A, i jeszcze wtedy wywalić warunek na middleDistance.
                //double middleDistanceBetweenTwoLyrics = (scoreService.CursorPositionX - renderer.State.LastNoteEndXPosition) / 2.0d;
                // double hyphenXPosition = scoreService.CursorPositionX - middleDistanceBetweenTwoLyrics;
                //if ((lyrics.Type == SyllableType.Middle || lyrics.Type == SyllableType.End) && middleDistanceBetweenTwoLyrics > 20)
                //{
                //    renderer.DrawString("-", FontStyles.LyricsFont, hyphenXPosition, textPositionY, element);
                //}
                //else
                if (lyrics.Type == SyllableType.Begin || lyrics.Type == SyllableType.Middle) sBuilder.Append("-");

                renderer.DrawString(sBuilder.ToString(), MusicFontStyles.LyricsFont, scoreService.CursorPositionX, textPosition, lyrics);

                if (!lyrics.DefaultYPosition.HasValue) versePositionY += 12; //Move down if default-y is not set
            }
        }

        private void DrawNotehead(ScoreRendererBase renderer, Note element, double notePositionY, FontProfile fontProfile)
        {
            if (element.IsGraceNote || element.IsCueNote)
                renderer.DrawCharacter(element.GetCharacter(fontProfile.MusicFont), MusicFontStyles.GraceNoteFont, scoreService.CursorPositionX, notePositionY, element);
            else
                renderer.DrawCharacter(element.GetCharacter(fontProfile.MusicFont), MusicFontStyles.MusicFont, scoreService.CursorPositionX, notePositionY, element);

            measurementService.LastNotePositionX = scoreService.CursorPositionX;
            element.TextBlockLocation = new Point(scoreService.CursorPositionX, notePositionY);
        }

        private void DrawOrnaments(ScoreRendererBase renderer, Note element, double notePositionY, FontProfile fontProfile)
        {
            foreach (Ornament ornament in element.Ornaments)
            {
                double yPosition;
                if (ornament.DefaultYPosition.HasValue)
                {
                    var yShift = renderer.TenthsToPixels(ornament.DefaultYPosition.Value);
                    yPosition = scoreService.CurrentLinePositions[0] + yShift;
                }
                else
                    yPosition = notePositionY + (ornament.Placement == VerticalPlacement.Above ? -20 : 20);

                yPosition = CorrectOrnamentYPositionToAvoidIntersection(renderer, ornament.Placement, renderer.LinespacesToPixels(1), yPosition, element, notePositionY);

                Mordent mordent = ornament as Mordent;
                if (mordent != null)
                {
                    if (renderer.IsSMuFLFont)
                    {
                        renderer.DrawCharacter(mordent.GetCharacter(fontProfile.MusicFont),
                            MusicFontStyles.MusicFont, scoreService.CursorPositionX - element.GetNoteheadWidthPx(renderer) / 2,
                            yPosition, element);
                    }
                    else
                    {
                        renderer.DrawCharacter(fontProfile.MusicFont.MordentShort, MusicFontStyles.GraceNoteFont, scoreService.CursorPositionX, yPosition, element);
                        renderer.DrawCharacter(fontProfile.MusicFont.Mordent, MusicFontStyles.GraceNoteFont, scoreService.CursorPositionX + 5.5, yPosition, element);
                    }
                }
            }
        }

        private void DrawSlurs(ScoreRendererBase renderer, Note element, double notePositionY, FontProfile fontProfile)
        {
            if (!element.Slurs.Any()) return;

            foreach (var slur in element.Slurs)
            {
                slurRenderStrategies.First(s => s.IsRelevant(element, slur)).Draw(renderer, slur, element, notePositionY);
            }
        }

        private void DrawStems(ScoreRendererBase renderer, Note element, double notePositionY, Note[] chord, FontProfile fontProfile)
        {
            if (element.BaseDuration > RhythmicDuration.Half || element.IsUpperMemberOfChord) return;

            var defaultStemLengthLs = fontProfile.IsSMuFLFont ? element.GetStemLength(fontProfile.SMuFLMetadata) : 3.5;
            var defaultStemLength = renderer.LinespacesToPixels(defaultStemLengthLs);
            //var stemEndFix = fontProfile.IsSMuFLFont ? renderer.LinespacesToPixels(element.GetStemEndY(fontProfile.SMuFLMetadata) - element.GetStemOriginY(fontProfile.SMuFLMetadata)) : 0;

            double customStemEndPosition = scoreService.CurrentStaffTop + renderer.TenthsToPixels(element.StemDefaultY);
            double notePositionForCalculatingStemEnd = GetNotePositionForCalculatingStemEnd(renderer, element, notePositionY, chord);
            double notePositionForCalculatingStemStart = GetNotePositionForCalculatingStemStart(renderer, element, notePositionY, chord);

            if (element.StemDirection == VerticalDirection.Down)
            {
                if (renderer.Settings.IgnoreCustomElementPositions || !element.HasCustomStemEndPosition)
                    beamingService.CurrentStemEndPositionY = notePositionForCalculatingStemEnd + defaultStemLength;
                else
                    beamingService.CurrentStemEndPositionY = customStemEndPosition - 4;
            }
            else
            {
                if (renderer.Settings.IgnoreCustomElementPositions || !element.HasCustomStemEndPosition)
                    beamingService.CurrentStemEndPositionY = notePositionForCalculatingStemEnd - defaultStemLength;
                else
                    beamingService.CurrentStemEndPositionY = customStemEndPosition - 6;
            }

            if (renderer.IsSMuFLFont)
            {
                beamingService.CurrentStemPositionX = scoreService.CursorPositionX +
                    element.GetNoteheadWidthPx(renderer) * (element.StemDirection == VerticalDirection.Down ? 0 : 1);  //Upward stems are placed on the right side of notehead
            }
            else
            {
                var polihymniaBadDesignFontFix = element.GetNoteheadWidthPx(renderer) * (element.IsCueNote || element.IsGraceNote ? 2 : 1) + 0.5;
                beamingService.CurrentStemPositionX = scoreService.CursorPositionX +
                    polihymniaBadDesignFontFix +
                    (element.GetNoteheadWidthPx(renderer) / 2) * (element.StemDirection == VerticalDirection.Down ? -1 : 1) +
                    (element.IsGraceNote || element.IsCueNote ? -2 : 0);
            }

            if (element.BeamList.Count > 0 && (element.BeamList[0] != NoteBeamType.Continue || element.HasCustomStemEndPosition))
            {
                var stemPen = renderer.CreatePenFromDefaults(element, "stemThickness", s => s.DefaultStemThickness);
                renderer.DrawLine(
                    new Point(beamingService.CurrentStemPositionX, notePositionForCalculatingStemStart),
                    new Point(beamingService.CurrentStemPositionX, beamingService.CurrentStemEndPositionY),
                    stemPen,
                    element);
            }
            element.StemEndLocation = new Point(beamingService.CurrentStemPositionX, beamingService.CurrentStemEndPositionY);

            if (element.GraceNoteType == GraceNoteType.Slashed)
            {
                renderer.DrawLine(beamingService.CurrentStemPositionX - 5, notePositionY - 5,
                    beamingService.CurrentStemPositionX + 5, notePositionY - 5 - 6, element);
            }
        }

        private void DrawTies(ScoreRendererBase renderer, Note element, double notePositionY)
        {
            if (element.TieType == NoteTieType.Start)
            {
                measurementService.TieStartSystem = element.Measure?.System;
                measurementService.TieStartPoint = new Point(scoreService.CursorPositionX + GetNoteheadWidthPx(element, renderer) / 2, notePositionY);
                measurementService.TieStartElement = element;
            }
            else if (element.TieType != NoteTieType.None) //Stop or StopAndStartAnother / Stop lub StopAndStartAnother
            {
                var tieEndpointThickness = renderer.GetEngravingDefault("tieEndpointThickness") ?? 1;
                var tieMidpointThickness = renderer.GetEngravingDefault("tieMidpointThickness") ?? 2;
                var tiePen = new Pen(element.CoalesceColor(renderer), tieEndpointThickness);

                double arcHeight = renderer.LinespacesToPixels(2);
                var modifierY = element.StemDirection == VerticalDirection.Down ? -1 : 1;
                var arcStartX = measurementService.TieStartPoint.X;// - element.GetNoteheadWidthPx(renderer) / 2;
                var arcStartY = measurementService.TieStartPoint.Y + renderer.LinespacesToPixels(1) * modifierY;

                if (renderer.Settings.RenderingMode == ScoreRenderingModes.Panorama || element.Measure?.System == measurementService.TieStartSystem)
                {
                    double arcWidth = scoreService.CursorPositionX - measurementService.TieStartPoint.X + element.GetNoteheadWidthPx(renderer) / 2 - 2; //-2 to modyfikator, żeby łuki się nie krzyżowały
                    DrawTiesInternal(renderer, arcStartX, arcStartY, arcStartY, arcWidth, arcHeight, modifierY, element, tiePen, tieMidpointThickness);
                }
                else
                {
                    //Draw ties at system breaks
                    var firstHalfOfArcWidth = (measurementService.TieStartElement.Measure?.BarlineLocationX ?? measurementService.TieStartSystem.Width)
                        - measurementService.TieStartElement.TextBlockLocation.X - measurementService.TieStartElement.GetNoteheadWidthPx(renderer) / 2;
                    DrawTiesInternal(renderer, arcStartX, arcStartY, arcStartY + arcHeight * modifierY, firstHalfOfArcWidth, arcHeight, modifierY, measurementService.TieStartElement, tiePen, tieMidpointThickness);

                    var secondHalfOfArcStartX = element.TextBlockLocation.X - 20;
                    var arcStartYSecondHalf = element.TextBlockLocation.Y + renderer.LinespacesToPixels(1) * modifierY;
                    DrawTiesInternal(renderer, secondHalfOfArcStartX, arcStartYSecondHalf, arcStartYSecondHalf,
                        element.TextBlockLocation.X - secondHalfOfArcStartX, arcHeight, modifierY, element, tiePen, tieMidpointThickness);
                }

                if (element.TieType == NoteTieType.StopAndStartAnother)
                {
                    measurementService.TieStartPoint = new Point(scoreService.CursorPositionX + 2, notePositionY);
                }
            }
        }

        private void DrawTiesInternal(ScoreRendererBase renderer, double arcStartX, double arcStartY, double arcEndY, double arcWidth, double arcHeight, int modifierY, Note element, Pen tiePen, double tieMidpointThickness)
        {
            var gap = tieMidpointThickness - tiePen.Thickness;

            renderer.DrawBezier(
                new Point(arcStartX, arcStartY),
                new Point(arcStartX + 0.25 * arcWidth, arcStartY + arcHeight * modifierY),
                new Point(arcStartX + 0.75 * arcWidth, arcStartY + arcHeight * modifierY),
                new Point(arcStartX + arcWidth, arcEndY),
                tiePen,
                element);
            if (gap >= tiePen.Thickness)
            {
                renderer.DrawBezier(
                    new Point(arcStartX, arcStartY),
                    new Point(arcStartX + 0.25 * arcWidth, arcStartY + (arcHeight + tieMidpointThickness / 2) * modifierY),
                    new Point(arcStartX + 0.75 * arcWidth, arcStartY + (arcHeight + tieMidpointThickness / 2) * modifierY),
                    new Point(arcStartX + arcWidth, arcEndY),
                    tiePen,
                    element);
            }
            renderer.DrawBezier(
                new Point(arcStartX, arcStartY),
                new Point(arcStartX + 0.25 * arcWidth, arcStartY + (arcHeight + tieMidpointThickness) * modifierY),
                new Point(arcStartX + 0.75 * arcWidth, arcStartY + (arcHeight + tieMidpointThickness) * modifierY),
                new Point(arcStartX + arcWidth, arcEndY),
                tiePen,
                element);
        }

        private void DrawTremolos(ScoreRendererBase renderer, Note element, double notePositionY)
        {
            double currentTremoloPos = notePositionY + 18;
            for (int j = 0; j < element.TremoloLevel; j++)
            {
                if (element.StemDirection == VerticalDirection.Up)
                {
                    currentTremoloPos -= 4;
                    renderer.DrawLine(scoreService.CursorPositionX + 2, currentTremoloPos + 1, scoreService.CursorPositionX + 9, currentTremoloPos - 1, element);
                    renderer.DrawLine(scoreService.CursorPositionX + 2, currentTremoloPos + 2, scoreService.CursorPositionX + 9, currentTremoloPos, element);
                }
                else
                {
                    currentTremoloPos += 4;
                    renderer.DrawLine(scoreService.CursorPositionX - 4, currentTremoloPos + 11 + 1, scoreService.CursorPositionX + 4, currentTremoloPos + 11 - 1, element);
                    renderer.DrawLine(scoreService.CursorPositionX - 4, currentTremoloPos + 11 + 2, scoreService.CursorPositionX + 4, currentTremoloPos + 11, element);
                }
            }
        }

        private void DrawTrills(ScoreRendererBase renderer, Note element, double notePositionY, FontProfile fontProfile)
        {
            if (element.TrillMark != NoteTrillMark.None)
            {
                var placement = element.TrillMark == NoteTrillMark.Above ? VerticalPlacement.Above : VerticalPlacement.Below;
                double trillPos = CorrectOrnamentYPositionToAvoidIntersection(renderer, placement, renderer.LinespacesToPixels(2), notePositionY, element, notePositionY);

                renderer.DrawCharacter(fontProfile.MusicFont.Trill, MusicFontStyles.MusicFont, scoreService.CursorPositionX - 1, trillPos, element);
            }
        }

        /// <summary>
        /// Calculates note position for drawing collision-free beams and chords with proper stem length.
        /// </summary>
        /// <param name="renderer"></param>
        /// <param name="element"></param>
        /// <param name="notePositionY"></param>
        /// <param name="chord"></param>
        /// <returns></returns>
        private double GetNotePositionForCalculatingStemEnd(ScoreRendererBase renderer, Note element, double notePositionY, Note[] chord)
        {
            //If note is an element of a chord which has upwards stem, the lowest note is taken into account:
            if (chord.Length > 1)
            {
                if (element.StemDirection == VerticalDirection.Up) return CalculateNotePositionY(chord.Last(), renderer);
                else return notePositionY;
            }

            //If note is placed under a beam, the lowest or highest element under beam is taken into account to avoid collisions:
            var elementsUnderBeam = GetElementsUnderBeam(element, scoreService.CurrentStaff);
            var notesUnderBeam = elementsUnderBeam.OfType<Note>().ToArray();
            if (notesUnderBeam.Length > 2)
            {
                var bounds = InitializeYPositionsForElementsUnderBeam(renderer, elementsUnderBeam).ToArray();
                var lowestElementPos = bounds.Select(b => b.Lower).Max();
                var highestElementPos = bounds.Select(b => b.Upper).Min();

                if (element.StemDirection == VerticalDirection.Down)
                    return lowestElementPos + CreateBeamSlope(notesUnderBeam, element);
                if (element.StemDirection == VerticalDirection.Up)
                    return highestElementPos + CreateBeamSlope(notesUnderBeam, element);
            }

            return notePositionY + (renderer.IsSMuFLFont ? element.GetStemOriginY(renderer.Settings.MusicFontProfile.SMuFLMetadata) : 0);
        }

        private double GetNotePositionForCalculatingStemStart(ScoreRendererBase renderer, Note element, double notePositionY, Note[] chord)
        {
            if (chord.Length == 1 && element == chord[0]) return notePositionY;
            if (element.StemDirection == VerticalDirection.Down) return CalculateNotePositionY(chord.Last(), renderer);
            else return notePositionY;
        }

        /// <summary>
        /// Calculates Y positions for elements under beam (which were not yet rendered so they don't have bounds calcualated)
        /// </summary>
        /// <param name="elementsUnderBeam"></param>
        /// <param name="getUpperBound"></param>
        /// <returns></returns>
        private IEnumerable<VerticalBounds> InitializeYPositionsForElementsUnderBeam(ScoreRendererBase renderer, ICanCalculateRenderedBounds[] elementsUnderBeam)
        {
            var currentClef = scoreService.CurrentClef;
            foreach (var element in elementsUnderBeam)
            {
                var clef = element as Clef;
                if (clef != null)
                {
                    currentClef = clef;
                    clef.TextBlockLocation = new Point(clef.TextBlockLocation.X, scoreService.CurrentLinePositions[4] - (clef.Line - 1) * renderer.Settings.LineSpacing);
                    var bounds = clef.GetBounds(renderer);
                    yield return new VerticalBounds(bounds.NE.Y, bounds.SE.Y);
                    continue;
                }

                var note = element as Note;
                if (note != null)
                {
                    var notePositionY = CalculateNotePositionYForClef(note, currentClef, renderer);
                    yield return new VerticalBounds(notePositionY, notePositionY);
                    continue;
                }

                //TODO: Calculate for every element type
            }
        }

        private void MakeSpaceForAccidentals(ScoreRendererBase renderer, Note element, Note[] chord)
        {
            if (element.DefaultXPosition.HasValue && !renderer.Settings.IgnoreCustomElementPositions) return;
            if (element.IsUpperMemberOfChord) return;

            var maxSpaceNeeded = chord.Max(n => CalculateSpaceForAccidentals(n, scoreService.CurrentKey));
            scoreService.CursorPositionX += maxSpaceNeeded;
        }
    }
}