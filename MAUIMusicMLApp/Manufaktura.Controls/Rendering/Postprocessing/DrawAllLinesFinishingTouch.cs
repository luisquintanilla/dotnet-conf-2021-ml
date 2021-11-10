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
    /// Draws lines of the staff
    /// </summary>
    public class DrawAllLinesFinishingTouch : IFinishingTouch
    {
        private readonly IScoreService scoreService;

        public DrawAllLinesFinishingTouch(IScoreService scoreService)
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

        public void PerformOnScore(Score score, ScoreRendererBase renderer)
        {
        }

        public void PerformOnStaff(Staff staff, ScoreRendererBase renderer)
        {
            var staffLinePen = renderer.CreatePenFromDefaults(staff, "staffLineThickness", s => s.DefaultStaffLineThickness);
            staffLinePen.ZIndex = -1;

            var staffLineWidth = renderer.Settings.IsMusicPaperMode && scoreService.Systems.Any() ?
                (double?)scoreService.Systems.Max(s => CalculateStaffLineWidth(staff, s, renderer.Settings)) : null;
            foreach (var system in scoreService.Systems)
            {
                if (system.LinePositions == null) continue;
                var staffFragment = system.Staves[scoreService.CurrentStaffNo - 1];
                Draw(staff, renderer, staffFragment, system, staffLinePen, staffLineWidth);
            }
        }

        private double CalculateStaffLineWidth(Staff staff, StaffSystem system, ScoreRendererSettings settings)
        {
            var lastMeasureInSystem = staff.Measures.LastOrDefault(m => m.System == system);
            var endPositionX = lastMeasureInSystem?.BarlineLocationX ?? system.Width;
            if (endPositionX == 0) endPositionX = system.Width;

            if (settings.RenderingMode != ScoreRenderingModes.Panorama)
                endPositionX = ExtendXPositionForMemoElements(endPositionX, lastMeasureInSystem, staff, system);

            return endPositionX;
        }

        private void Draw(Staff staff, ScoreRendererBase renderer, StaffFragment staffFragment, StaffSystem system, Pen staffLinePen, double? staffLineWidth)
        {
            renderer.DrawLine(0, staffFragment.LinePositions[0], 0, staffFragment.LinePositions[4], staffLinePen, staffFragment);
            var endPositionX = staffLineWidth ?? CalculateStaffLineWidth(staff, system, renderer.Settings);
            
            foreach (double linePositionY in staffFragment.LinePositions)
            {
                Point startPoint = new Point(0, linePositionY);
                Point endPoint = new Point(endPositionX, linePositionY);
                renderer.DrawLine(startPoint, endPoint, staffLinePen, staffFragment);
            }
        }

        /// <summary>
        /// Extends lines for clefs, keys and time signatures at the end of the system (which are actually members of the next measure)
        /// </summary>
        /// <param name="endPositionX"></param>
        /// <param name="lastMeasureInSystem"></param>
        /// <param name="staff"></param>
        /// <param name="system"></param>
        /// <returns></returns>
        private double ExtendXPositionForMemoElements(double endPositionX, Measure lastMeasureInSystem, Staff staff, StaffSystem system)
        {
            var nextMeasure = lastMeasureInSystem == null ? null : staff.Measures.ElementAtOrDefault(staff.Measures.IndexOf(lastMeasureInSystem) + 1);
            if (nextMeasure != null)    //Wydłuż linie, jeśli są na końcu taktu nowe znaki przykluczowe lub nowe metrum
            {
                var elementsWithPosition = nextMeasure.Elements.OfType<IRenderedAsTextBlock>().Where(e => e is Clef || e is TimeSignature || e is Key);
                var memoElement =  elementsWithPosition.OrderBy(e => e.TextBlockLocation.X).LastOrDefault();
                if (memoElement == null) return endPositionX;

                if (endPositionX < memoElement.TextBlockLocation.X + memoElement.RenderedWidth) endPositionX = memoElement.TextBlockLocation.X + memoElement.RenderedWidth;
            }

            return endPositionX;
        }
    }
}