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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Manufaktura.Controls.Model
{
	/// <summary>
	/// Measure information.
	/// </summary>
	public class Measure
	{
		/// <summary>
		/// Createa a new instance of Measure in specific staff in specific system.
		/// </summary>
		/// <param name="staff">Staff</param>
		/// <param name="system">System</param>
		public Measure(Staff staff, StaffSystem system)
		{
			Staff = staff;
			System = system;
			Elements = new List<MusicalSymbol>();
		}

		/// <summary>
		/// Barline object that represents the right barline
		/// </summary>
		public Barline Barline { get; set; }

		/// <summary>
		/// Location of right barline in measure
		/// </summary>
		public double BarlineLocationX { get; set; }

        /// <summary>
        /// Elements in measure
        /// </summary>
		public List<MusicalSymbol> Elements { get; private set; }

		/// <summary>
		/// Position of first note in measure
		/// </summary>
		public double FirstNoteInMeasureXPosition { get; set; }

        /// <summary>
        /// Measure number
        /// </summary>
		public int? Number { get; set; }

		/// <summary>
		/// Staff to which this measure belongs
		/// </summary>
		public Staff Staff { get; set; }

		/// <summary>
		/// Staff to which this measure belongs
		/// </summary>
		public StaffSystem System { get; set; }

		/// <summary>
		/// Width of measure.
		/// </summary>
		public double? Width { get; set; }

		public override string ToString()
		{
            if (System != null && Staff?.Score != null && Staff.Score.Systems.Contains(System))
                return $"Measure {(Number.HasValue ? Number.Value.ToString() : "(unnumbered)")} in system {Staff.Score.Systems.IndexOf(System) + 1}";
            return string.Format("Measure {0}", Number.HasValue ? Number.Value.ToString() : "(unnumbered)");
		}
	}
}