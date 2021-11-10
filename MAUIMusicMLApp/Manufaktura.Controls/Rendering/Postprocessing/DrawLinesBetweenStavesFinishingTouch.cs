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
using System.Linq;

namespace Manufaktura.Controls.Rendering.Postprocessing
{
	/// <summary>
	/// Finishing touch that draws lines between staves if multiple staves are present in the score.
	/// </summary>
	public class DrawLinesBetweenStavesFinishingTouch : IFinishingTouch
	{
		private readonly IScoreService scoreService;

		public DrawLinesBetweenStavesFinishingTouch(IScoreService scoreService)
		{
			this.scoreService = scoreService;
		}

        /// <summary>
        /// This method does nothing in this implementation of IFinishingTouch.
        /// </summary>
        /// <param name="measure">Measure</param>
        /// <param name="renderer">Score renderer</param>
        public void PerformOnMeasure(Measure measure, ScoreRendererBase renderer)
		{
		}

        /// <summary>
        /// Applies DrawLinesBetweenStavesFinishingTouch to the score.
        /// </summary>
        /// <param name="score">Score</param>
        /// <param name="renderer">Score renderer</param>
		public void PerformOnScore(Score score, ScoreRendererBase renderer)
		{
			var lightPen = new Pen(renderer.Settings.DefaultColor, 1);
			var thickPen = new Pen(renderer.Settings.DefaultColor, 3);
            var defaultPen = new Pen(renderer.Settings.DefaultColor, renderer.Settings.DefaultStaffLineThickness);


            for (var i = 0; i < scoreService.CurrentScore.Staves.Count - 1; i++)
			{
				var staff = scoreService.CurrentScore.Staves[i];
                var barlinePen = renderer.CreatePenFromDefaults(staff, "thinBarlineThickness", s => s.DefaultBarlineThickness);
                foreach (var system in scoreService.CurrentScore.Systems)
				{
					if (renderer.Settings.RenderingMode == ScoreRenderingModes.SinglePage)
					{
						var page = staff.Score.Pages.FirstOrDefault(p => p.Systems.Contains(system));
						var pageNumber = page == null ? -1 : staff.Score.Pages.IndexOf(page) + 1;
						if (pageNumber != renderer.Settings.CurrentPage) continue;
					}

					if (system.LinePositions == null) continue;
					var staffFragment = system.Staves[i];
					if (!system.LinePositions.ContainsKey(i + 1) || !system.LinePositions.ContainsKey(i + 2)) continue;
					renderer.DrawLine(0, system.LinePositions[i + 1][4], 0, system.LinePositions[i + 2][0], barlinePen, staffFragment);
					foreach (var measure in staff.Measures.Where(m => m.Barline != null && m.System == system))
					{
						if (measure.Barline?.Style == BarlineStyle.LightHeavy)
						{
							renderer.DrawLine(measure.BarlineLocationX - 6, system.LinePositions[i + 1][4], measure.BarlineLocationX - 6, system.LinePositions[i + 2][0], lightPen, measure.Barline);
							renderer.DrawLine(measure.BarlineLocationX - 1.5, system.LinePositions[i + 1][4], measure.BarlineLocationX - 1.5, system.LinePositions[i + 2][0], thickPen, measure.Barline);
						}
						else if (measure.Barline?.Style != BarlineStyle.None)
						{
							renderer.DrawLine(measure.BarlineLocationX, system.LinePositions[i + 1][4], measure.BarlineLocationX, system.LinePositions[i + 2][0], barlinePen, measure.Barline);
						}
					}
				}
			}
		}

        /// <summary>
        /// This method does nothing in this implementation of IFinishingTouch.
        /// </summary>
        /// <param name="staff">Staff</param>
        /// <param name="renderer">Score renderer</param>
        public void PerformOnStaff(Staff staff, ScoreRendererBase renderer)
		{
		}
	}
}