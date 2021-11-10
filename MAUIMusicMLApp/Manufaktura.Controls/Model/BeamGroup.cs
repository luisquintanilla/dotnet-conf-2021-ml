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
using Manufaktura.Controls.Primitives;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a beam group
    /// </summary>
    public class BeamGroup : MusicalSymbol
    {
        /// <summary>
        /// Initializes a new instance of BeamGroup for specific Staff
        /// </summary>
        /// <param name="staff"></param>
        public BeamGroup(Staff staff)
        {
            Staff = staff;
        }

        /// <summary>
        /// Beam angle
        /// </summary>
        public double Angle => Point.BeamAngle(Start, End);

        /// <summary>
        /// Beam group end point
        /// </summary>
        public Point End { get; internal set; }

        /// <summary>
        /// First measure containing this BeamGroup
        /// </summary>
        public override Measure Measure
        {
            get
            {
                return Members.FirstOrDefault(m => m.Measure != null)?.Measure;
            }

            internal set
            {
            }
        }

        /// <summary>
        /// Notes and rests under this Beam
        /// </summary>
        public ICollection<NoteOrRest> Members { get; private set; } = new List<NoteOrRest>();

        /// <summary>
        /// Beam group start position
        /// </summary>
        public Point Start { get; internal set; }

        /// <summary>
        /// Returns a string representation of this class for debugging purposes
        /// </summary>
        /// <returns>String representation of this class for debugging purposes</returns>
        public override string ToString()
        {
            return $"Beam group of {Members.Count} members with angle {Angle}.";
        }
    }
}