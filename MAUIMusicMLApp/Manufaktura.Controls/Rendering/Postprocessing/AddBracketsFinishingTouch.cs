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
using System;
using System.Linq;

namespace Manufaktura.Controls.Rendering.Postprocessing
{
    /// <summary>
    /// Adds brackets for parts.
    /// </summary>
    public class AddBracketsFinishingTouch : IFinishingTouch
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
        /// Applies AddBracketsFinishingTouch to the score.
        /// </summary>
        /// <param name="score">Score</param>
        /// <param name="renderer">Score renderer</param>
		public void PerformOnScore(Score score, ScoreRendererBase renderer)
        {
            foreach (var part in score.Parts)
            {
                if (part.Staves.Count < 2) continue;
                foreach (var system in score.Systems)
                {
                    DrawBracket(system, part, renderer);
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

        private void DrawBracket(StaffSystem system, Part part, ScoreRendererBase renderer)
        {
            if (system.LinePositions == null) return;

            var locationXAndWidth = GetBraceLocationXAndWidth(renderer);

            var location = new Point(locationXAndWidth.Item1, system.LinePositions[1][0]);
            var size = new Size(locationXAndWidth.Item2, system.LinePositions[part.Staves.Count][4] - system.LinePositions[1][0]);
            renderer.DrawCharacterInBounds(renderer.Settings.MusicFontProfile.MusicFont.BraceLeft, Model.Fonts.MusicFontStyles.MusicFont, location, size,
                renderer.Settings.DefaultColor, part.Staves.First());
        }

        private Tuple<double, double> GetBraceLocationXAndWidth(ScoreRendererBase renderer)
        {
            if (renderer.IsSMuFLFont && renderer.Settings.MusicFontProfile.SMuFLMetadata != null)
            {
                var bounds = renderer.Settings.MusicFontProfile.SMuFLMetadata.GlyphBBoxes.Brace;
                var width = (bounds.BBoxNe[0] + bounds.BBoxSw[0]) * 3;  //TODO: Sprawdzić czemu Brace ma tak mały bounding box w SMuFL
                return new Tuple<double, double>(renderer.LinespacesToPixels(bounds.BBoxSw[0] * -3 - width), renderer.LinespacesToPixels(width));
            }
            else return new Tuple<double, double>(-17.5, 15);
        }
    }
}