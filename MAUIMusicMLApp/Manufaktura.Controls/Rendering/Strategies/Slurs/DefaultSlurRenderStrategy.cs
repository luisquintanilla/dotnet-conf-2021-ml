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
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Services;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Rendering.Strategies.Slurs
{
    /// <summary>
    /// Default strategy for rendering slurs. Renders slurs as Bezier curves, whose parameters are automatically computed to avoid collisions with note stems.
    /// </summary>
    public class DefaultSlurRenderStrategy : SlurRenderStrategy
    {
        /// <summary>
        /// Initializes a new instance of SlurRenderStrategy with specific services.
        /// </summary>
        /// <param name="measurementService">Measurement service</param>
        /// <param name="scoreService">Score service</param>
        public DefaultSlurRenderStrategy(IMeasurementService measurementService, IScoreService scoreService) : base(measurementService, scoreService)
        {
        }

        /// <summary>
        /// Returns true if this strategy type is relevant for drawing a specific slur
        /// </summary>
        /// <param name="element">Element with a slur</param>
        /// <param name="slur">Slur</param>
        /// <returns>True if this strategy is relevant for rendering a specific slur</returns>
        public override bool IsRelevant(Note element, Slur slur)
        {
            return !slur.IsDefinedAsBezierCurve;
        }

        /// <summary>
        /// Draws of performs additional logic at slur end
        /// </summary>
        /// <param name="renderer">Score renderer</param>
        /// <param name="slur">Slur</param>
        /// <param name="element">Element with a slur</param>
        /// <param name="notePositionY">Y position of element with a slur</param>
        /// <param name="slurStartInfo">Information about slur start point</param>
        /// <param name="slurPlacement">Information about slur placement</param>
        protected override void ProcessSlurEnd(ScoreRendererBase renderer, Slur slur, Note element, double notePositionY, SlurInfo slurStartInfo, VerticalPlacement slurPlacement)
        {
            Point endPoint;
            var noteheadWidth = element.GetNoteheadWidthPx(renderer);
            
            if (slurStartInfo.StartPlacement == VerticalPlacement.Above)
            {
                var xShiftConcerningStemDirectionEnd = noteheadWidth / 2;
                bool hasFlagOrBeam = element.BaseDuration.Denominator > 4;
                endPoint = new Point(scoreService.CursorPositionX + xShiftConcerningStemDirectionEnd,
                    (element.StemDirection == VerticalDirection.Up ? element.StemEndLocation.Y + (hasFlagOrBeam ? -2 : 0) : notePositionY - 7));
            }
            else if (slurStartInfo.StartPlacement == VerticalPlacement.Below)
            {
                var xShiftConcerningStemDirectionEnd = noteheadWidth / 2;
                endPoint = new Point(scoreService.CursorPositionX + xShiftConcerningStemDirectionEnd, notePositionY + 5);
            }
            else throw new Exception("Unsupported placement type.");

            var slurHeight = DetermineSlurHeight(element, slur, slurStartInfo, endPoint);
            for (int i = 0; i < 3; i++) //Draw a few curves one by one to simulate a curve with variable thickness. It will be replaced by a path in future releases.
            {
                var controlPoints = GetBezierControlPoints(slurStartInfo.StartPoint, endPoint, slurStartInfo.StartPlacement, slurHeight + i);
                renderer.DrawBezier(slurStartInfo.StartPoint, controlPoints.Item1, controlPoints.Item2, endPoint, element);
            }

            //DrawSlurFrame(renderer, startPoint, controlPoints.Item1, controlPoints.Item2, endPoint, element);
        }

        /// <summary>
        /// Draws or performs additional logic at slur start
        /// </summary>
        /// <param name="renderer">Score renderer</param>
        /// <param name="slur">Slur</param>
        /// <param name="element">Element with a slur</param>
        /// <param name="notePositionY"></param>
        /// <param name="slurStartInfo">Information about slur start point</param>
        /// <param name="slurPlacement">Information about slur placement</param>
        protected override void ProcessSlurStart(ScoreRendererBase renderer, Slur slur, Note element, double notePositionY, SlurInfo slurStartInfo, VerticalPlacement slurPlacement)
        {
            slurStartInfo.StartPlacement = slurPlacement;
            slurStartInfo.StartPointStemDirection = element.StemDirection;
            var polihymniaFix = renderer.LinespacesToPixels(element.GetNoteheadWidthLs(renderer) * 0.5);
            if (slurPlacement == VerticalPlacement.Above)
            {
                bool hasFlagOrBeam = element.BaseDuration.Denominator > 4;  //If note has a flag or beam start the slur above the note. If not, start a bit to the right and down.
                var xShiftConcerningStemDirectionStart = slurStartInfo.StartPointStemDirection == VerticalDirection.Up ? (hasFlagOrBeam ? 5 : 10) : 1;
                slurStartInfo.StartPoint = new Point(scoreService.CursorPositionX + xShiftConcerningStemDirectionStart + polihymniaFix, element.StemDirection == VerticalDirection.Down ? notePositionY - 7 : element.StemEndLocation.Y + (hasFlagOrBeam ? -3 : 8));
            }
            else
                slurStartInfo.StartPoint = new Point(scoreService.CursorPositionX + 3 + polihymniaFix, notePositionY + 5);
        }

        private static Tuple<Point, Point> GetBezierControlPoints(Point start, Point end, VerticalPlacement placement, double height)
        {
            var factor = placement == VerticalPlacement.Above ? -1 : 1;
            var angle = UsefulMath.BeamAngle(start.X, start.Y, end.X, end.Y);
            var angle2 = angle + (Math.PI / 2) * factor;
            var distance = Point.Distance(start, end);
            var startPointForControlPoints = start.TranslateByAngleOld(angle2, height);
            var control1 = startPointForControlPoints.TranslateByAngleOld(angle, distance * 0.25);
            var control2 = startPointForControlPoints.TranslateByAngleOld(angle, distance * 0.75);
            return new Tuple<Point, Point>(control1, control2);
        }

        /// <summary>
        /// Calculates slur height trying to avoid collisions with stems
        /// </summary>
        /// <param name="note"></param>
        /// <param name="endPoint"></param>
        /// <returns></returns>
        private double DetermineSlurHeight(Note note, Slur slur, SlurInfo slurStartInfo, Point endPoint)
        {
            var notesUnderSlur = note.Staff.EnumerateUntilConditionMet<Note>(note, n => n.Slurs.FirstOrDefault(s => s.Number == slur.Number)?.Type == NoteSlurType.Start, true).ToArray();
            if (notesUnderSlur.Length < 3) return 10;

            var notesUnderSlurExclusive = notesUnderSlur.Take(notesUnderSlur.Length - 1).Skip(1);
            var mostExtremePoint = GetMostExtremePoint(notesUnderSlurExclusive, slurStartInfo.StartPlacement);

            var angle = UsefulMath.BeamAngle(slurStartInfo.StartPoint.X, slurStartInfo.StartPoint.Y, endPoint.X, endPoint.Y);
            var slurYPositionInMostExtremePoint = slurStartInfo.StartPoint.TranslateHorizontallyAndMaintainAngle(angle, mostExtremePoint.X - slurStartInfo.StartPoint.X).Y;
            var mostExtremeYPosition = mostExtremePoint.Y;
            if (slurStartInfo.StartPlacement == VerticalPlacement.Above && mostExtremeYPosition < slurYPositionInMostExtremePoint) return Math.Abs(mostExtremeYPosition - slurYPositionInMostExtremePoint) + 10;
            if (slurStartInfo.StartPlacement == VerticalPlacement.Below && mostExtremeYPosition > slurYPositionInMostExtremePoint) return Math.Abs(slurYPositionInMostExtremePoint - mostExtremeYPosition) + 10;

            return 10;
        }

        /// <summary>
        /// For debug purposes. It will be used in slur edit mode in the future.
        /// </summary>
        private void DrawSlurFrame(ScoreRendererBase renderer, Point p1, Point p2, Point p3, Point p4, MusicalSymbol owner)
        {
            renderer.DrawLine(p1, p2, owner);
            renderer.DrawLine(p2, p3, owner);
            renderer.DrawLine(p3, p4, owner);
            renderer.DrawLine(p4, p1, owner);
        }

        private Point GetMostExtremePoint(IEnumerable<Note> notes, VerticalPlacement slurStartPlacement)
        {
            if (slurStartPlacement == VerticalPlacement.Above)
            {
                var mostExtremeStemEnd = notes.First(n => n.StemEndLocation.Y == notes.Min(nus => nus.StemEndLocation.Y)).StemEndLocation;
                var mostExtremeNotehead = notes.First(n => n.TextBlockLocation.Y == notes.Min(nus => nus.TextBlockLocation.Y)).TextBlockLocation;
                mostExtremeNotehead += new Point(0, -8);
                return mostExtremeStemEnd.Y < mostExtremeNotehead.Y ? mostExtremeStemEnd : mostExtremeNotehead;
            }
            else
            {
                var mostExtremeStemEnd = notes.First(n => n.StemEndLocation.Y == notes.Max(nus => nus.StemEndLocation.Y)).StemEndLocation;
                var mostExtremeNotehead = notes.First(n => n.TextBlockLocation.Y == notes.Max(nus => nus.TextBlockLocation.Y)).TextBlockLocation;
                mostExtremeNotehead += new Point(0, 8);
                return mostExtremeStemEnd.Y > mostExtremeNotehead.Y ? mostExtremeStemEnd : mostExtremeNotehead;
            }
        }
    }
}