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
using Manufaktura.Controls.Model.Exceptions;

namespace Manufaktura.Controls.Model.Collections
{
    /// <summary>
    /// Collection of staves in a Part
    /// </summary>
	public class PartStavesCollection : ItemManagingCollection<Staff>
	{
		private readonly Part part;

		public PartStavesCollection(Part part)
		{
			this.part = part;
		}

		protected override void BindEvents(Staff item)
		{
		}

		protected override ScoreException CreateOutOfBoundsException(int index)
		{
			return new ScoreException(part, $"Index {index} is out of bounds of part's staves collection.");
		}

		protected override void ManageItemOnAdd(Staff item)
		{
			item.Part = part;
		}

		protected override void ManageItemOnRemove(Staff item)
		{
			item.Part = null;
		}

		protected override void UnbindEvents(Staff item)
		{
		}
	}
}