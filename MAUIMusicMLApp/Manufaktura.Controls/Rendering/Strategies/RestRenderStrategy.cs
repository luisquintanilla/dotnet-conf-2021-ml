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
using Manufaktura.Controls.Model.Assertions;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Services;
using Manufaktura.Music.Model;
using System;
using System.Linq;

namespace Manufaktura.Controls.Rendering
{
    /// <summary>
    /// Strategy for rendering a Rest.
    /// </summary>
    public class RestRenderStrategy : MusicalSymbolRenderStrategy<Rest>
    {
        private readonly IMeasurementService measurementService;

        /// <summary>
        /// Initializes a new instance of RestRenderStrategy
        /// </summary>
        /// <param name="measurementService"></param>
        /// <param name="scoreService"></param>
        public RestRenderStrategy(IMeasurementService measurementService, IScoreService scoreService) : base(scoreService)
        {
            this.measurementService = measurementService;
        }



        /// <summary>
        /// Renders a rest with specific score renderer
        /// </summary>
        /// <param name="element"></param>
        /// <param name="renderer"></param>
		public override void Render(Rest element, ScoreRendererBase renderer, FontProfile fontProfile)
        {
            var isOnlyElementInMeasure = element.Measure?.Elements?.OfType<NoteOrRest>().Count() == 1;
            if (!renderer.Settings.IgnoreCustomElementPositions && element.DefaultXPosition.HasValue) //Jeśli ustalono default-x, to pozycjonuj wg default-x, a nie automatycznie
            {
                scoreService.CursorPositionX = measurementService.LastMeasurePositionX +
                    element.DefaultXPosition.Value * renderer.Settings.CustomElementPositionRatio;
            }
            else if (isOnlyElementInMeasure && (element.Measure?.Width.HasValue ?? false))
            {
                scoreService.CursorPositionX = measurementService.LastMeasurePositionX + (element.Measure.Width.Value / 2) * renderer.Settings.CustomElementPositionRatio;
            }

            if (scoreService.CurrentMeasure.FirstNoteInMeasureXPosition == 0) scoreService.CurrentMeasure.FirstNoteInMeasureXPosition = scoreService.CursorPositionX;

            //If it's second voice, rewind position to the beginning of measure (but only if default-x is not set or is ignored):
            if (element.Voice > scoreService.CurrentVoice && (renderer.Settings.IgnoreCustomElementPositions || !element.DefaultXPosition.HasValue))
            {
                scoreService.CursorPositionX = scoreService.CurrentMeasure.FirstNoteInMeasureXPosition;
                measurementService.LastNoteInMeasureEndXPosition = measurementService.LastNoteEndXPosition;
            }
            scoreService.CurrentVoice = element.Voice;

            double restPositionY = scoreService.CurrentLinePositions[0] +
                (element.DefaultYPosition.HasValue ? renderer.TenthsToPixels(element.DefaultYPosition.Value) : renderer.LinespacesToPixels(2));

            renderer.DrawCharacter(element.GetCharacter(fontProfile.MusicFont), MusicFontStyles.MusicFont, scoreService.CursorPositionX, restPositionY, element);
            measurementService.LastNotePositionX = scoreService.CursorPositionX;
            element.TextBlockLocation = new Point(scoreService.CursorPositionX, restPositionY);

            //Draw number of measures for multimeasure rests / Rysuj ilość taktów dla pauz wielotaktowych:
            if (element.MultiMeasure > 1)
            {
                if (renderer.IsSMuFLFont)
                    renderer.DrawString(fontProfile.MusicFont.BuildTupletNumber(element.MultiMeasure),
                        MusicFontStyles.MusicFont, scoreService.CursorPositionX + 
                        (element.GetRestWidthPx(renderer) / 2) - (fontProfile.MusicFont.GetTupletNumberWidthPx(renderer, element.MultiMeasure) / 2), 
                        restPositionY - renderer.LinespacesToPixels(1.5), element);
                else
                    renderer.DrawString(Convert.ToString(element.MultiMeasure), MusicFontStyles.DirectionFont, scoreService.CursorPositionX + 6, restPositionY, element);
            }

            //Draw dots / Rysuj kropki:
            if (element.NumberOfDots > 0) scoreService.CursorPositionX += 16;
            for (int i = 0; i < element.NumberOfDots; i++)
            {
                renderer.DrawCharacter(fontProfile.MusicFont.AugmentationDot, MusicFontStyles.MusicFont, scoreService.CursorPositionX, restPositionY, element);
                scoreService.CursorPositionX += 6;
            }

            if (renderer.Settings.IgnoreCustomElementPositions || !element.DefaultXPosition.HasValue) //Pozycjonowanie automatyczne tylko, gdy nie określono default-x
            {
                if (element.Duration == RhythmicDuration.Whole) scoreService.CursorPositionX += 48;
                else if (element.Duration == RhythmicDuration.Half) scoreService.CursorPositionX += 28;
                else if (element.Duration == RhythmicDuration.Quarter) scoreService.CursorPositionX += 17;
                else if (element.Duration == RhythmicDuration.Eighth) scoreService.CursorPositionX += 15;
                else scoreService.CursorPositionX += 14;
            }

            measurementService.LastNoteEndXPosition = scoreService.CursorPositionX;
        }
    }
}