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

//#define DemoVersion

using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using System.Linq;

namespace Manufaktura.Controls.Rendering.Postprocessing
{
	/// <summary>
	/// Draws text "Demo" in the corners of controls.
	/// </summary>
	public class DemoVersionFinishingTouch : IFinishingTouch
	{
        /// <summary>
        /// This method does nothing in this implementation of IFinishingTouch.
        /// </summary>
        /// <param name="measure">Measure</param>
        /// <param name="renderer">Score renderer</param>
        public void PerformOnMeasure(Measure measure, ScoreRendererBase renderer)
		{
		}

        /// <summary>
        /// Applies DemoVersionFinishingTouch to the score.
        /// </summary>
        /// <param name="score">Score</param>
        /// <param name="renderer">Score renderer</param>
		public void PerformOnScore(Score score, ScoreRendererBase renderer)
		{
#if DemoVersion
			foreach (var location in new[] {
				new Point(0, 15),
				new Point(renderer.ScoreInformation.Systems.Max(s => s.Width) - 30, 15)})
			{
				renderer.DrawString("DEMO", MusicFontStyles.LyricsFont, location, Color.Red, MusicalSymbol.Null);
			}
#endif
		}

        /// <summary>
        /// This method does nothing in this implementation of IFinishingTouch.
        /// </summary>
        /// <param name="staff">staff</param>
        /// <param name="renderer">Score renderer</param>
        public void PerformOnStaff(Staff staff, ScoreRendererBase renderer)
		{
		}
	}
}