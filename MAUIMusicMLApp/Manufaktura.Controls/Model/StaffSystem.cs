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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Staff system information.
    /// </summary>
    public class StaffSystem
    {
        public StaffSystem(Score score)
        {
            Score = score;
        }

        /// <summary>
        /// Height of staff.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Vertical line positions in the staff.
        /// </summary>
        public Dictionary<int, double[]> LinePositions
        {
            get
            {
                if (!Staves.Any()) return null;
                return Staves.ToDictionary(s => s.Staff.Score.Staves.IndexOf(s.Staff) + 1, s => s.LinePositions);
            }
        }

        public ScorePage Page { get; internal set; }
        public Score Score { get; internal set; }
        public List<StaffFragment> Staves { get; internal set; } = new List<StaffFragment>();

        /// <summary>
        /// Width of staff.
        /// </summary>
        public double Width { get; set; }

        public override string ToString()
        {
            return string.Format("Staff system {0}", Score.Systems.ToList().IndexOf(this) + 1);
        }

        internal void BuildStaffFragments(Dictionary<Staff, double[]> linePositions)
        {
            foreach (var kvp in linePositions)
            {
                var staffFragmentForThisStaff = Staves.FirstOrDefault(s => s.Staff == kvp.Key);
                if (staffFragmentForThisStaff == null)
                {
                    staffFragmentForThisStaff = new StaffFragment(kvp.Key);
                    Staves.Add(staffFragmentForThisStaff);
                }
                staffFragmentForThisStaff.LinePositions = kvp.Value;
            }
        }
    }
}