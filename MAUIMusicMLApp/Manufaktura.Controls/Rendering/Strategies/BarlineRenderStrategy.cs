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
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Services;
using System;
using System.Linq;

namespace Manufaktura.Controls.Rendering
{
    /// <summary>
    /// Strategy for rendering a Barline.
    /// </summary>
    public class BarlineRenderStrategy : MusicalSymbolRenderStrategy<Barline>
    {
        private readonly IAlterationService alterationService;
        private readonly IMeasurementService measurementService;

        /// <summary>
        /// Initializes a new instance of BarlineRenderStrategy
        /// </summary>
        /// <param name="measurementService"></param>
        /// <param name="alterationService"></param>
        /// <param name="scoreService"></param>
        public BarlineRenderStrategy(IMeasurementService measurementService, IAlterationService alterationService, IScoreService scoreService) : base(scoreService)
        {
            this.measurementService = measurementService;
            this.alterationService = alterationService;
        }

        public double? GetCursorPositionForCurrentBarline(ScoreRendererBase renderer)
        {
            Staff staff = scoreService.CurrentStaff;
            if (staff.Measures.Count < scoreService.CurrentMeasureNo) return null;
            double? width = staff.Measures[scoreService.CurrentMeasureNo - 1].Width;
            if (!width.HasValue) return null;
            return measurementService.LastMeasurePositionX + width * renderer.Settings.CustomElementPositionRatio;
        }

        public override void Render(Barline element, ScoreRendererBase renderer, FontProfile fontProfile)
        {
            var partGroup = element.Staff?.Part?.Group;
            var doNotDraw = partGroup != null && partGroup.GroupBarline == GroupBarlineType.Mensurstrich;

            var lightPen = new Pen(element.CoalesceColor(renderer), 1);
            var thickPen = new Pen(element.CoalesceColor(renderer), 3);
            var barlinePen = renderer.CreatePenFromDefaults(element, "thinBarlineThickness", s => s.DefaultBarlineThickness);

            if (measurementService.LastNoteInMeasureEndXPosition > scoreService.CursorPositionX)
            {
                scoreService.CursorPositionX = measurementService.LastNoteInMeasureEndXPosition;
            }

            double? measureWidth = GetCursorPositionForCurrentBarline(renderer);
            if (!renderer.Settings.IgnoreCustomElementPositions && measureWidth.HasValue && element.Location == HorizontalPlacement.Right) scoreService.CursorPositionX = measureWidth.Value;
            else if (element.RepeatSign == RepeatSignType.None)
            {
                //If measure width is not set, get barline location from the first staff:
                if (scoreService.CurrentStaff != scoreService.CurrentScore.FirstStaff)
                {
                    var correspondingMeasure = scoreService.GetCorrespondingMeasure(scoreService.CurrentMeasure, scoreService.CurrentScore.FirstStaff);
                    if (correspondingMeasure != null) scoreService.CursorPositionX = correspondingMeasure.BarlineLocationX - 16;
                }
            }

            if (element.RepeatSign == RepeatSignType.None)
            {
                if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue) scoreService.CursorPositionX += 16;
                if (element.Location == HorizontalPlacement.Right) measurementService.LastMeasurePositionX = scoreService.CursorPositionX;
                if (!doNotDraw)
                {
                    if (element.Style == BarlineStyle.LightHeavy)
                    {
                        renderer.DrawLine(new Point(scoreService.CursorPositionX - 6, scoreService.CurrentLinePositions[4]),
                                          new Point(scoreService.CursorPositionX - 6, scoreService.CurrentLinePositions[0]), lightPen, element);
                        renderer.DrawLine(new Point(scoreService.CursorPositionX - 1.5, scoreService.CurrentLinePositions[4]),
                                          new Point(scoreService.CursorPositionX - 1.5, scoreService.CurrentLinePositions[0]), thickPen, element);
                    }
                    else if (element.Style == BarlineStyle.Dashed)
                    {
                        var barlineHeight = Math.Abs(scoreService.CurrentLinePositions[4] - scoreService.CurrentLinePositions[0]);
                        var currentPositionY = scoreService.CurrentLinePositions[0];
                        var numberOfSegments = 6;
                        var dy = barlineHeight / numberOfSegments;
                        for (int i = 0; i < numberOfSegments; i++)
                        {
                            if (i % 2 == 0)
                            {
                                renderer.DrawLine(new Point(scoreService.CursorPositionX, currentPositionY),
                                              new Point(scoreService.CursorPositionX, currentPositionY + dy), barlinePen, element);
                            }
                            currentPositionY += dy;
                        }
                    }
                    else if (element.Style != BarlineStyle.None)
                    {
                        renderer.DrawLine(new Point(scoreService.CursorPositionX, scoreService.CurrentLinePositions[4]),
                                          new Point(scoreService.CursorPositionX, scoreService.CurrentLinePositions[0]), lightPen, element);
                    }

                    element.ActualRenderedBounds = new Quadrangle(
                        new Point(scoreService.CursorPositionX, scoreService.CurrentLinePositions[0]),
                        new Point(scoreService.CursorPositionX, scoreService.CurrentLinePositions[0]),
                        new Point(scoreService.CursorPositionX, scoreService.CurrentLinePositions[4]),
                        new Point(scoreService.CursorPositionX, scoreService.CurrentLinePositions[4]));
                }
                scoreService.CurrentMeasure.BarlineLocationX = scoreService.CursorPositionX;
                scoreService.CurrentMeasure.Barline = element;
                if (!IsLastBarline(element) && (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue))
                    scoreService.CursorPositionX += 6;
            }
            else if (element.RepeatSign == RepeatSignType.Forward)
            {
                BeforeDrawRepeatSign(renderer, element, measureWidth);

                //TODO: Usunąć warunek na HtmlScoreRendererSettings jak zaimplementuję w SVG DrawCharacterInBounds
                if (renderer.IsSMuFLFont && fontProfile.SMuFLMetadata != null && renderer.CanDrawCharacterInBounds)
                    DrawRepeatSignSMuFL(renderer, element, measureWidth, fontProfile);
                else
                    DrawRepeatSignAsText(renderer, element, measureWidth, 4, fontProfile);

                AfterDrawRepeatSign(renderer, element, measureWidth, 20);
            }
            else if (element.RepeatSign == RepeatSignType.Backward)
            {
                BeforeDrawRepeatSign(renderer, element, measureWidth);

                //TODO: Usunąć warunek na HtmlScoreRendererSettings jak zaimplementuję w SVG DrawCharacterInBounds
                if (renderer.IsSMuFLFont && fontProfile.SMuFLMetadata != null && renderer.CanDrawCharacterInBounds)
                    DrawRepeatSignSMuFL(renderer, element, measureWidth, fontProfile);
                else
                    DrawRepeatSignAsText(renderer, element, measureWidth, -14.5, fontProfile);

                AfterDrawRepeatSign(renderer, element, measureWidth, 6);
            }

            if (element.Location == HorizontalPlacement.Right)   //Start new measure only if it's right barline
            {
                alterationService.Reset();
                scoreService.BeginNewMeasure();
            }
        }

        private void AfterDrawRepeatSign(ScoreRendererBase renderer, Barline element, double? measureWidth, double spaceAfter)
        {
            if (scoreService.CurrentStaffNo == 1) element.RenderedXPositionForFirstStaffInMultiStaffPart = scoreService.CursorPositionX;

            element.ActualRenderedBounds = new Quadrangle(
                new Point(scoreService.CursorPositionX, scoreService.CurrentLinePositions[0]),
                new Point(scoreService.CursorPositionX, scoreService.CurrentLinePositions[0]),
                new Point(scoreService.CursorPositionX, scoreService.CurrentLinePositions[4]),
                new Point(scoreService.CursorPositionX, scoreService.CurrentLinePositions[4]));

            if (element.RepeatSign == RepeatSignType.Backward)
            {
                scoreService.CurrentMeasure.BarlineLocationX = scoreService.CursorPositionX;
                scoreService.CurrentMeasure.Barline = element;
            }
            if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue) scoreService.CursorPositionX += spaceAfter;
        }

        private void BeforeDrawRepeatSign(ScoreRendererBase renderer, Barline element, double? measureWidth)
        {
            if (element.RepeatSign == RepeatSignType.Forward && scoreService.CurrentStaff.Elements.IndexOf(element) > 0)
            {
                if (!renderer.IsSMuFLFont)
                    scoreService.CursorPositionX -= 8;   //TODO: Temporary workaround!!
                else if (!renderer.CanDrawCharacterInBounds)
                    scoreService.CursorPositionX -= renderer.LinespacesToPixels(1);
            }

            if (renderer.Settings.IgnoreCustomElementPositions || !measureWidth.HasValue)
                scoreService.CursorPositionX += 2 * (element.RepeatSign == RepeatSignType.Backward ? 1 : -1);
            if (element.Location == HorizontalPlacement.Right)
                measurementService.LastMeasurePositionX = scoreService.CursorPositionX;

            if (scoreService.CurrentStaffNo > 1 && element.RenderedXPositionForFirstStaffInMultiStaffPart > 0)
                scoreService.CursorPositionX = element.RenderedXPositionForFirstStaffInMultiStaffPart;
        }

        private void DrawRepeatSignAsText(ScoreRendererBase renderer, Barline element, double? measureWidth, double shiftX, FontProfile fontProfile)
        {
            var positionY = scoreService.CurrentLinePositions[renderer.IsSMuFLFont ? 4 : 2];
            renderer.DrawCharacter(element.GetCharacter(fontProfile.MusicFont), MusicFontStyles.StaffFont, scoreService.CursorPositionX + shiftX,
                positionY, element);
        }

        private void DrawRepeatSignSMuFL(ScoreRendererBase renderer, Barline element, double? measureWidth, FontProfile fontProfile)
        {
            var bounds = element.GetSMuFLBoundingBoxPx(fontProfile.SMuFLMetadata, renderer.Settings);
            var shiftX = element.RepeatSign == RepeatSignType.Forward ? bounds.BBoxSw[0] : bounds.BBoxNe[0];
            renderer.DrawCharacterInBounds(
                element.GetCharacter(fontProfile.MusicFont),
                MusicFontStyles.MusicFont,
                new Point(scoreService.CursorPositionX - shiftX, scoreService.CurrentLinePositions[0]),
                new Size(bounds.BBoxNe[0] - bounds.BBoxSw[0], bounds.BBoxNe[1] - bounds.BBoxSw[1]),
                element);
        }

        private bool IsLastBarline(Barline element)
        {
            return element == scoreService.CurrentStaff.Elements.OfType<Barline>().LastOrDefault()                          //Element is the last barline in the staff 
                && scoreService.CurrentStaff.Peek<NoteOrRest>(element, Model.PeekStrategies.PeekType.NextElement) == null;  //and there are no notes or rests after it
        }
    }
}