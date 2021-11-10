using Manufaktura.Controls.Model;
using System;
using System.Diagnostics;
using System.Linq;

namespace Manufaktura.Controls.Rendering.Postprocessing
{
    public class MeasureStaffFragmentPerformanceFinishingTouch : IFinishingTouch
    {
        public void PerformOnMeasure(Measure measure, ScoreRendererBase renderer)
        {
        }

        public void PerformOnScore(Score score, ScoreRendererBase renderer)
        {
            if (!Debugger.IsAttached) return;

            foreach (var system in score.Systems)
            {
                foreach (var staffFragment in system.Staves)
                {
                    var elementsOnThisFragment = staffFragment.Staff?.Elements?.Where(e => e.Measure?.System == system).ToArray() ?? new MusicalSymbol[0];
                    if (elementsOnThisFragment.Length > 0)
                        staffFragment.ActualRenderingTime = TimeSpan.FromTicks(elementsOnThisFragment.Sum(e => e.ActualRenderingTime.Ticks));
                }
            }
        }

        public void PerformOnStaff(Staff staff, ScoreRendererBase renderer)
        {
        }
    }
}