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
using Manufaktura.Controls.Model.Collections;
using System.Collections.Generic;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a score part.
    /// </summary>
    public class Part
    {
        /// <summary>
        /// Initializes a new instance of multi-staff Part
        /// </summary>
        /// <param name="staves">Staves</param>
        public Part(IEnumerable<Staff> staves)
        {
            Staves = new PartStavesCollection(this);
            Staves.AddRange(staves);
        }

        /// <summary>
        /// Initializes a new instance of one-staff Part
        /// </summary>
        /// <param name="staves">Staff</param>
        public Part(Staff staff)
        {
            Staves = new PartStavesCollection(this);
            Staves.Add(staff);
        }

        /// <summary>
        /// Part group containing this Part
        /// </summary>
        public PartGroup Group { get; set; }

        /// <summary>
        /// Name of Part
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Part Id
        /// </summary>
        public string PartId { get; set; }

        /// <summary>
        /// Staves in Part
        /// </summary>
        public PartStavesCollection Staves { get; private set; }
    }
}