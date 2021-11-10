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
using Manufaktura.Controls.Model.Events;
using Manufaktura.Controls.Model.Exceptions;
using System;
using System.Collections.Generic;

namespace Manufaktura.Controls.Model.Collections
{
	public class SystemCollection : ItemManagingCollection<StaffSystem>
	{
		private List<StaffSystem> innerList = new List<StaffSystem>();
		private ScorePage page;
		private Score score;

		public SystemCollection(ScorePage page)
		{
			this.score = page.Score;
			this.page = page;
		}

		public event EventHandler<InvalidateEventArgs<Score>> ScoreInvalidated;

		protected override void BindEvents(StaffSystem item)
		{
		}

		protected override ScoreException CreateOutOfBoundsException(int index)
		{
			return new ScoreException(page, $"Index {index} is out of bounds of staff systems collection.");
		}

		protected override void ManageItemOnAdd(StaffSystem item)
		{
			item.Score = score;
			item.Page = page;
		}

		protected override void ManageItemOnRemove(StaffSystem item)
		{
			item.Score = null;
			item.Page = null;
		}

		protected override void UnbindEvents(StaffSystem item)
		{
		}

		private void Item_ScoreInvalidated(object sender, Events.InvalidateEventArgs<Score> e)
		{
			ScoreInvalidated?.Invoke(sender, e);
		}
	}
}