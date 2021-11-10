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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering
{
    /// <summary>
    /// Strategy for rendering a Direction.
    /// </summary>
    public class DirectionRenderStrategy : MusicalSymbolRenderStrategy<Direction>
    {

        /// <summary>
        /// /// Initializes a new instance of DirectionRenderStrategy
        /// </summary>
        /// <param name="scoreService"></param>
        public DirectionRenderStrategy(IScoreService scoreService) : base(scoreService)
        {
        }

        /// <summary>
        /// Renders a Direction using specific score renderer.
        /// </summary>
        /// <param name="element">Direction</param>
        /// <param name="renderer">Score renderer</param>
        public override void Render(Direction element, ScoreRendererBase renderer, FontProfile fontProfile)
        {
			//Performance directions / Wskazówki wykonawcze:
			double dirPositionY = 0;
			if (element.Placement == DirectionPlacementType.Custom)
				dirPositionY = scoreService.CurrentStaffTop - renderer.TenthsToPixels(element.DefaultYPosition.Value);
			else if (element.Placement == DirectionPlacementType.Above)
				dirPositionY = 0;
			else if (element.Placement == DirectionPlacementType.Below)
				dirPositionY = 50;

			var metronomeDirection = element as MetronomeDirection;
			if (metronomeDirection != null)
			{
				var note = new Note(metronomeDirection.Tempo.BeatUnit);
				renderer.DrawCharacter(note.GetCharacter(fontProfile.MusicFont), MusicFontStyles.GraceNoteFont, scoreService.CursorPositionX, dirPositionY - 8, element);
				if (metronomeDirection.Tempo.BeatUnit.Denominator > 1)
				{
					renderer.DrawLine(scoreService.CursorPositionX + 10, dirPositionY + 9, scoreService.CursorPositionX + 10, dirPositionY - 2, metronomeDirection);
					if (metronomeDirection.Tempo.BeatUnit.Denominator > 4)
					{
						renderer.DrawCharacter(note.GetNoteFlagCharacter(fontProfile.MusicFont, false), MusicFontStyles.GraceNoteFont, new Point(scoreService.CursorPositionX + 6, dirPositionY - 24), element);
					}
				}
				renderer.DrawString($" = {metronomeDirection.Tempo.BeatsPerMinute}", MusicFontStyles.DirectionFont, scoreService.CursorPositionX + 12, dirPositionY, element);
				return;
			}

            
            renderer.DrawString(element.Text, MusicFontStyles.DirectionFont, scoreService.CursorPositionX, dirPositionY, element);
        }
    }
}
