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
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Controls.Services;
using System;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    /// <summary>
    /// Strategy for rendering a TimeSignature.
    /// </summary>
    public class TimeSignatureRenderStrategy : MusicalSymbolRenderStrategy<TimeSignature>
    {

        /// <summary>
        /// Initializes a new instance of TimeSignatureRenderStrategy
        /// </summary>
        /// <param name="scoreService"></param>
        public TimeSignatureRenderStrategy(IScoreService scoreService) : base(scoreService)
        {
        }

        /// <summary>
        /// Renders time signature symbol with specific score renderer
        /// </summary>
        /// <param name="element"></param>
        /// <param name="renderer"></param>
        public override void Render(TimeSignature element, ScoreRendererBase renderer, FontProfile fontProfile)
        {
            var topLinePosition = scoreService.CurrentLinePositions[0];
            if (element.Measure != null && element.Measure.Elements.FirstOrDefault() == element)
                scoreService.CursorPositionX += renderer.LinespacesToPixels(1); //Żeby był lekki margines między kreską taktową a symbolem. Być może ta linijka będzie do usunięcia

            if (element.SignatureType != TimeSignatureType.Numbers)
            {
                renderer.DrawCharacter(element.GetCharacter(fontProfile.MusicFont), MusicFontStyles.MusicFont,
                    scoreService.CursorPositionX, topLinePosition + renderer.LinespacesToPixels(2), element);
                element.TextBlockLocation = new Primitives.Point(scoreService.CursorPositionX, topLinePosition + renderer.LinespacesToPixels(2));
            }
            else
            {
                if (renderer.IsSMuFLFont)
                {
                    renderer.DrawString(fontProfile.MusicFont.BuildTimeSignature(element.NumberOfBeats),
                        MusicFontStyles.MusicFont, scoreService.CursorPositionX - fontProfile.MusicFont.GetTimeSignatureNumberWidthPx(renderer, element.NumberOfBeats) / 2, topLinePosition + renderer.LinespacesToPixels(1), element);
                    renderer.DrawString(fontProfile.MusicFont.BuildTimeSignature(element.TypeOfBeats),
                        MusicFontStyles.MusicFont, scoreService.CursorPositionX - fontProfile.MusicFont.GetTimeSignatureNumberWidthPx(renderer, element.TypeOfBeats) / 2, topLinePosition + renderer.LinespacesToPixels(3), element);

                    element.TextBlockLocation = new Primitives.Point(scoreService.CursorPositionX, topLinePosition + renderer.LinespacesToPixels(3));
                }
                else
                {
                    renderer.DrawString(Convert.ToString(element.NumberOfBeats),
                        MusicFontStyles.TimeSignatureFont, scoreService.CursorPositionX, topLinePosition + renderer.LinespacesToPixels(2), element);
                    renderer.DrawString(Convert.ToString(element.TypeOfBeats),
                        MusicFontStyles.TimeSignatureFont, scoreService.CursorPositionX, topLinePosition + renderer.LinespacesToPixels(4), element);

                    element.TextBlockLocation = new Primitives.Point(scoreService.CursorPositionX, topLinePosition + renderer.LinespacesToPixels(4));
                }
            }
            scoreService.CursorPositionX += 20;
        }


    }
}