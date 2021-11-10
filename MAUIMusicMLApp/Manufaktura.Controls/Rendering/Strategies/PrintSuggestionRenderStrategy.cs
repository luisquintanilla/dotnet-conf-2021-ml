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
using Manufaktura.Controls.Services;
using System.Linq;

namespace Manufaktura.Controls.Rendering.Strategies
{
    /// <summary>
    /// Strategy for rendering a print suggestion.
    /// </summary>
    public class PrintSuggestionRenderStrategy : MusicalSymbolRenderStrategy<PrintSuggestion>
    {
        /// <summary>
        /// Initializes a new instance of PrintSuggestionRenderStrategy
        /// </summary>
        /// <param name="scoreService"></param>
        public PrintSuggestionRenderStrategy(IScoreService scoreService) : base(scoreService)
        {
        }

        /// <summary>
        /// Renders print suggestion with specific score renderer
        /// </summary>
        /// <param name="element"></param>
        /// <param name="renderer"></param>
		public override void Render(PrintSuggestion element, ScoreRendererBase renderer, FontProfile fontProfile)
        {
            if (element.IsSystemBreak && renderer.Settings.RenderingMode != ScoreRenderingModes.Panorama)
            {
                renderer.BreakSystem(renderer.TenthsToPixels(element.SystemDistance ?? scoreService.CurrentScore.DefaultPageSettings.DefaultSystemDistance ?? 0), element.IsPageBreak);

                var clefRenderStrategy = new ClefRenderStrategy(scoreService) { WasSystemChanged = true };
                clefRenderStrategy.Render(scoreService.CurrentClef, renderer);

                //Draw virtual key signature but only if there is no key change:
                var nextKeyChange = scoreService.CurrentStaff.Peek<Key>(element, Model.PeekStrategies.PeekType.NextElement);
                var nextNoteOrRest = scoreService.CurrentStaff.Peek<NoteOrRest>(element, Model.PeekStrategies.PeekType.NextElement);
                if (nextKeyChange != null && (nextNoteOrRest == null || scoreService.CurrentStaff.Elements.IndexOf(nextNoteOrRest) > scoreService.CurrentStaff.Elements.IndexOf(nextKeyChange)))
                {
                    //Do not draw key signature
                }
                else
                {
                    var keyRenderStrategy = new KeyRenderStrategy(scoreService) { IsVirtualKey = true };
                    keyRenderStrategy.Render(scoreService.CurrentKey, renderer);
                }

                //Time signature is not rendered in new line.

                //Render measure number:
                if (scoreService.CurrentStaff == scoreService.CurrentScore.FirstStaff)
                {
                    renderer.DrawString((scoreService.CurrentMeasureNo).ToString(), MusicFontStyles.LyricsFont,
                        new Primitives.Point(0, scoreService.CurrentLinePositions[0] - renderer.LinespacesToPixels(2)), scoreService.CurrentStaff);
                }
            }

            //Issue #44: Jeśli jesteśmy w trybie panoramy, to trzeba uzupełnić line positions dla pozostałych systemów:
            if (renderer.Settings.RenderingMode == ScoreRenderingModes.Panorama)
            {
                var firstSystem = scoreService.Systems.First();
                foreach (var system in scoreService.Systems)
                {
                    system.BuildStaffFragments(firstSystem.LinePositions.ToDictionary(p => scoreService.CurrentScore.Staves[p.Key - 1], p => p.Value));
                }
            }
        }
    }
}