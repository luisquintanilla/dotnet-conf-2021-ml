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
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Formatting
{
    /// <summary>
    /// This class performs some basic formatting on the score. Currently it's only used after parsing MusicXml files created with Sibelius
    /// to make them look more similar to those created in Finale. It might become obsolete when MusicXml import function improves.
    /// </summary>
    public class DefaultScoreFormatter : IScoreFormatter
    {
        /// <summary>
        /// Formats a score using some basic rules
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public Score Format(Score score)
        {
            SetMeasureWidths(score);
            SetElementPositions(score);
            return score;
        }

        private Dictionary<StaffSystem, IEnumerable<Measure>> GetSystems(Score score)
        {
            return score.FirstStaff.Measures.GroupBy(m => m.System).ToDictionary(g => g.Key, g => g.Select(m => m));
        }

        private void SetElementPositions(Score score)
        {
            foreach (var staff in score.Staves)
            {
                StaffSystem lastSystem = null;
                foreach (var measure in staff.Measures)
                {
                    var marginLeft = lastSystem == null || score.Systems.ToList().IndexOf(measure.System) != score.Systems.ToList().IndexOf(lastSystem) ? 85 : 14;    //First symbol in system should have bigger margin
                    foreach (var group in measure.Elements.GroupBy(e => e is NoteOrRest ? ((NoteOrRest)e).Voice : 1))
                    {
                        double x = marginLeft;
                        foreach (var element in group)
                        {
                            if (!measure.Width.HasValue) throw new Exception("Measure does not have width. Run SetMeasureWidths first.");

                            var durationElement = element as IHasDuration;
                            if (durationElement == null) continue;
                            var defaultXElement = element as IHasCustomXPosition;
                            if (defaultXElement == null) continue;

                            defaultXElement.DefaultXPosition = x;
                            var chordElement = element as ICanBeUpperMemberOfChord;
                            if (chordElement != null && chordElement.IsUpperMemberOfChord) continue;

                            var time = staff.Peek<TimeSignature>(element, Model.PeekStrategies.PeekType.PreviousElement);
                            var duration = durationElement.BaseDuration.AddDots(durationElement.NumberOfDots).ToDouble() * time.WholeNoteCapacity;    //TODO: Dots!
                            x += (measure.Width.Value - marginLeft) * duration;
                        }
                    }
                    lastSystem = measure.System;
                }
            }
        }

        private void SetMeasureWidths(Score score)
        {
            int index = 0;
            foreach (var measuresInSystem in GetSystems(score).Values)
            {
                var averageMeasureWidth = score.DefaultPageSettings.Width / measuresInSystem.Count();
                foreach (var measure in measuresInSystem)
                {
                    foreach (var staff in score.Staves)
                    {
                        Measure staffMeasure;
                        if (staff.Measures.Count > index)
                            staffMeasure = staff.Measures[index];
                        else
                        {
                            staffMeasure = new Measure(staff, measure.System);
                            staff.Measures.Add(staffMeasure);
                        }
                        staffMeasure.Width = averageMeasureWidth;
                    }
                    index++;
                }
            }
        }
    }
}