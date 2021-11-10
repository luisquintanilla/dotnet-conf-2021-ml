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

namespace Manufaktura.Controls.Rendering
{
    /// <summary>
    /// Strategy for rendering a Clef.
    /// </summary>
    public class ClefRenderStrategy : MusicalSymbolRenderStrategy<Clef>
    {
        /// <summary>
        /// /// Initializes a new instance of ClefRenderStrategy
        /// </summary>
        /// <param name="scoreService"></param>
        public ClefRenderStrategy(IScoreService scoreService) : base(scoreService)
        {
        }

        public bool WasSystemChanged { get; set; }

        public void DrawPercussionClef(Clef element, ScoreRendererBase renderer)
        {
            renderer.DrawLine(new Point(element.TextBlockLocation.X + 10, scoreService.CurrentLinePositions[1]),
                new Point(element.TextBlockLocation.X + 10, scoreService.CurrentLinePositions[3]), new Pen(element.CoalesceColor(renderer), 3), element);
            renderer.DrawLine(new Point(element.TextBlockLocation.X + 15, scoreService.CurrentLinePositions[1]),
                new Point(element.TextBlockLocation.X + 15, scoreService.CurrentLinePositions[3]), new Pen(element.CoalesceColor(renderer), 3), element);
        }

        public override void Render(Clef element, ScoreRendererBase renderer, FontProfile fontProfile)
        {
            if (!(fontProfile.IsSMuFLFont))
            {
                var yPosition = element.OctaveChange > 0 ? scoreService.CurrentLinePositions[0] - renderer.LinespacesToPixels(2) : scoreService.CurrentLinePositions[4] + renderer.LinespacesToPixels(3.5);
                var octaveChangeText = GetOctaveChangeNumberForPolihymniaFont(element.OctaveChange);
                renderer.DrawString(octaveChangeText, MusicFontStyles.DirectionFont, element.TextBlockLocation.X + 6, yPosition, element);
            }

            //Don't draw clef if it's current clef:
            if (!WasSystemChanged && element.TypeOfClef == scoreService.CurrentClef.TypeOfClef && element.Pitch == scoreService.CurrentClef.Pitch && element.Line == scoreService.CurrentClef.Line) return;

            element.TextBlockLocation = new Point(scoreService.CursorPositionX, scoreService.CurrentLinePositions[4] - (element.Line - 1) * renderer.Settings.LineSpacing);

            scoreService.CurrentClef = element;
            if (element.TypeOfClef == ClefType.Percussion)
                DrawPercussionClef(element, renderer);
            else
                renderer.DrawCharacter(element.GetCharacter(fontProfile.MusicFont), MusicFontStyles.MusicFont, element.TextBlockLocation.X, element.TextBlockLocation.Y, element);

            scoreService.CursorPositionX += 20;

            element.ActualRenderedBounds = element.GetBounds(renderer);
        }

        private static string GetOctaveChangeNumberForPolihymniaFont(int octaveChange)
        {
            switch (octaveChange)
            {
                case 1: return "8";
                case -1: return "8";
                case 2: return "15";
                case -2: return "15";
                default: return "";
            }
        }
    }
}