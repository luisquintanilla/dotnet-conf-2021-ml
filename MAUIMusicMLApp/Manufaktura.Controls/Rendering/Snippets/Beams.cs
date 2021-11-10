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

using Manufaktura.Controls.Linq;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Model.PeekStrategies;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Rendering.Snippets
{
    /// <summary>
    /// Helper class for drawing beams
    /// </summary>
	public static class Beams
    {
        public static bool IsDebugMode { get; set; } = false;

        /// <summary>
        /// Draws note flag
        /// </summary>
        /// <param name="beamingService"></param>
        /// <param name="measurementService"></param>
        /// <param name="scoreService"></param>
        /// <param name="renderer"></param>
        /// <param name="element"></param>
        /// <param name="beamSpaceDirection"></param>
        /// <param name="beamNumber"></param>
        /// <param name="beamOffset"></param>
		public static void Flag(IBeamingService beamingService, IMeasurementService measurementService, IScoreService scoreService, ScoreRendererBase renderer, Note element, int beamSpaceDirection, int beamNumber, int beamOffset)
        {
            //Rysuj chorągiewkę tylko najniższego dźwięku w akordzie
            //Draw a hook only of the lowest element in a chord
            double xPos = beamingService.CurrentStemPositionX - (renderer.GetEngravingDefault("stemThickness") ?? renderer.Settings.DefaultStemThickness) / 2;      //Align to the center of the stem;

            if (element.StemDirection == VerticalDirection.Down)
            {
                if (element.IsGraceNote || element.IsCueNote)
                    renderer.DrawCharacter(element.GetNoteFlagCharacter(renderer.Settings.MusicFontProfile.MusicFont, true), MusicFontStyles.GraceNoteFont, new Point(xPos, beamingService.CurrentStemEndPositionY), element);
                else
                    renderer.DrawCharacter(element.GetNoteFlagCharacter(renderer.Settings.MusicFontProfile.MusicFont, true), MusicFontStyles.MusicFont, new Point(xPos, beamingService.CurrentStemEndPositionY), element);
            }
            else
            {
                if (element.IsGraceNote || element.IsCueNote)
                    renderer.DrawCharacter(element.GetNoteFlagCharacter(renderer.Settings.MusicFontProfile.MusicFont, false), MusicFontStyles.GraceNoteFont, new Point(xPos, beamingService.CurrentStemEndPositionY), element);
                else
                    renderer.DrawCharacter(element.GetNoteFlagCharacter(renderer.Settings.MusicFontProfile.MusicFont, false), MusicFontStyles.MusicFont, new Point(xPos, beamingService.CurrentStemEndPositionY), element);
            }
            if (measurementService.TupletState != null)
            {
                measurementService.TupletState.AreSingleBeamsPresentUnderTuplet = true;
                if (element.Tuplet == TupletType.Stop)
                {
                    TupletMark(measurementService, scoreService, renderer, element);
                    measurementService.TupletState = null;
                }
            }
        }

        /// <summary>
        /// Draws tuplet mark
        /// </summary>
        /// <param name="measurementService"></param>
        /// <param name="scoreService"></param>
        /// <param name="renderer"></param>
        /// <param name="element"></param>
        public static void TupletMark(IMeasurementService measurementService, IScoreService scoreService, ScoreRendererBase renderer, NoteOrRest element)
        {
            if (measurementService.TupletState == null)
                throw new Exception("DrawTupletMark was called but no tuplet is currently open in staff.");

            var tupletBracketPen = renderer.CreatePenFromDefaults(element, "tupletBracketThickness", s => s.DefaultTupletBracketThickness);
            Staff staff = scoreService.CurrentStaff;

            NoteOrRest firstElementInTuplet = staff.Peek<NoteOrRest>(element, PeekType.BeginningOfTuplet);
            int index = staff.Elements.IndexOf(firstElementInTuplet);
            List<MusicalSymbol> elementsUnderTuplet = staff.Elements.GetRange(index, staff.Elements.IndexOf(element) - index + 1);

            var noteGroupBounds = elementsUnderTuplet.OfType<Note>().GetBounds(renderer);
            if (IsDebugMode) DrawNoteGroupOutline(renderer, noteGroupBounds, element);

            var boundsOnOneSide = measurementService.TupletState.TupletPlacement == VerticalPlacement.Above ?
                new Tuple<Point, Point>(noteGroupBounds.NW, noteGroupBounds.NE) :
                new Tuple<Point, Point>(noteGroupBounds.SW, noteGroupBounds.SE);

            int placementMod = measurementService.TupletState.TupletPlacement == VerticalPlacement.Above ? -1 : 1;
            var bracketDefinition = new TupletBracketDefinition(
                boundsOnOneSide.Item1.X,
                boundsOnOneSide.Item1.Y + renderer.LinespacesToPixels(2) * placementMod,
                boundsOnOneSide.Item2.X,
                boundsOnOneSide.Item2.Y + renderer.LinespacesToPixels(2) * placementMod);

            if (measurementService.TupletState.AreSingleBeamsPresentUnderTuplet)    //Draw tuplet bracket
            {
                renderer.DrawLine(bracketDefinition.StartPoint, bracketDefinition.Point25, tupletBracketPen, element);
                renderer.DrawLine(bracketDefinition.Point75, bracketDefinition.EndPoint, tupletBracketPen, element);
                renderer.DrawLine(bracketDefinition.StartPoint, bracketDefinition.StartPoint.Translate(0, renderer.LinespacesToPixels(-1) * placementMod), tupletBracketPen, element);
                renderer.DrawLine(bracketDefinition.EndPoint, bracketDefinition.EndPoint.Translate(0, renderer.LinespacesToPixels(-1) * placementMod), tupletBracketPen, element);
            }

            var tupletNumber = CalculateTupletNumber(elementsUnderTuplet.OfType<NoteOrRest>());

            var textToWrite = renderer.Settings.MusicFontProfile.MusicFont.BuildTupletNumber(tupletNumber);
            var fontStyle = renderer.IsSMuFLFont ? MusicFontStyles.MusicFont : MusicFontStyles.LyricsFont;
            var textSize = renderer.CanMeasureString ? renderer.MeasureString(fontStyle, textToWrite) : new Size();
            var textPosition = renderer.CanMeasureString ?
                bracketDefinition.MidPoint.Translate(textSize.Width / -2, textSize.Height / 2) :
                bracketDefinition.MidPoint.Translate(-3.7, 4.7);

            renderer.DrawString(textToWrite, fontStyle, textPosition, element);
        }

        private static int CalculateTupletNumber(IEnumerable<NoteOrRest> elements)
        {
            var smallNotes = EnumerateSmallNotes(elements).ToArray();
            var largeNotes = EnumerateLargeNotes(elements).ToArray();

            var query = largeNotes.Length == 0 ? smallNotes : largeNotes;

            double weight = 0;
            double smallestDenominator = query.Min(p => p.BaseDuration.Denominator);
            foreach (var element in query)
            {
                if (element.TupletWeightOverride.HasValue) weight += element.TupletWeightOverride.Value;
                else weight += smallestDenominator / element.BaseDuration.Denominator;
            }
            return (int)weight;
        }

        private static void DrawNoteGroupOutline(ScoreRendererBase renderer, Quadrangle noteGroupBounds, NoteOrRest element)
        {
            renderer.DrawLine(noteGroupBounds.NW, noteGroupBounds.NE, new Pen(Color.Red), element);
            renderer.DrawLine(noteGroupBounds.NE, noteGroupBounds.SE, new Pen(Color.Red), element);
            renderer.DrawLine(noteGroupBounds.SE, noteGroupBounds.SW, new Pen(Color.Red), element);
            renderer.DrawLine(noteGroupBounds.SW, noteGroupBounds.NW, new Pen(Color.Red), element);
        }

        private static IEnumerable<NoteOrRest> EnumerateLargeNotes(IEnumerable<NoteOrRest> elements)
        {
            foreach (var element in elements)
            {
                if (element is Rest) yield return element;
                if (element is Note note && !note.IsCueNote && !note.IsGraceNote && !note.IsUpperMemberOfChord) yield return note;
            }
        }

        private static IEnumerable<NoteOrRest> EnumerateSmallNotes(IEnumerable<NoteOrRest> elements)
        {
            foreach (var element in elements)
            {
                if (element is Rest) yield return element;
                if (element is Note note && (note.IsCueNote || note.IsGraceNote) && !note.IsUpperMemberOfChord) yield return note;
            }
        }

        private static double GetAverageStemLength(IEnumerable<Note> notes, IMeasurementService measurementService)
        {
            var elementsUnderTupletForAverageStemLength = notes.Where(n => MusicalSymbol.DirectionToPlacement(n.StemDirection) == measurementService.TupletState.TupletPlacement).ToList();
            double averageStemLength = elementsUnderTupletForAverageStemLength.Count == 0 ? 0 : elementsUnderTupletForAverageStemLength.Average(n => n.ActualStemLength);
            averageStemLength += 10;    //Add space
            return averageStemLength;
        }
    }
}