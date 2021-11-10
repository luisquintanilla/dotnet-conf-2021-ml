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
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Manufaktura.Controls.Model.Collections
{
	/// <summary>
	/// Collection that performs special actions on items on adding and removing.
	/// </summary>
	/// <typeparam name="TItem">Item type</typeparam>
	public abstract class ItemManagingCollection<TItem> : IList<TItem>, ICollection<TItem>, IEnumerable<TItem>, INotifyCollectionChanged
	{
		private List<TItem> innerList = new List<TItem>();

        /// <summary>
        /// Event raised when collection is changed
        /// </summary>
		public event NotifyCollectionChangedEventHandler CollectionChanged;

		/// <summary>
		/// Returns the number of elements in list.
		/// </summary>
		public int Count
		{
			get { return innerList.Count; }
		}

		public bool IsFixedSize
		{
			get { return false; }
		}

		public bool IsReadOnly
		{
			get { return false; }
		}

		public TItem this[int index]
		{
			get
			{
				if (index > Count - 1) throw CreateOutOfBoundsException(index);
				return innerList[index];
			}
			set
			{
				if (index > Count - 1) throw CreateOutOfBoundsException(index);
				innerList[index] = value;
			}
		}

        /// <summary>
        /// Adds element to collection and performs additional special actions
        /// </summary>
        /// <param name="item"></param>
		public void Add(TItem item)
		{
			innerList.Add(item);
			ManageItemOnAdd(item);
			UnbindEvents(item);
			BindEvents(item);
			CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
		}

        /// <summary>
        /// Adds element range to collection and performs additional special actions
        /// </summary>
        /// <param name="item"></param>
        public void AddRange(IEnumerable<TItem> items)
		{
			innerList.AddRange(items);
			foreach (var item in items)
			{
				ManageItemOnAdd(item);
				UnbindEvents(item);
				BindEvents(item);
			}
			CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, items.ToList()));
		}

        /// <summary>
        /// Clears collection and raises CollectionChanged event.
        /// </summary>
		public void Clear()
		{
			foreach (var i in innerList) UnbindEvents(i);
			innerList.Clear();
			CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset, null));
		}

		public bool Contains(TItem item)
		{
			return innerList.Contains(item);
		}

		public bool Contains(object value)
		{
			return innerList.Contains((TItem)value);
		}

		public void CopyTo(TItem[] array, int arrayIndex)
		{
			innerList.CopyTo(array, arrayIndex);
		}

		public IEnumerator<TItem> GetEnumerator()
		{
			return innerList.GetEnumerator();
		}

		public List<TItem> GetRange(int index, int count)
		{
#if CSHTML5
            return innerList.Skip(index).Take(count).ToList();
#else
            return innerList.GetRange(index, count);
#endif
        }

		IEnumerator IEnumerable.GetEnumerator()
		{
			return innerList.GetEnumerator();
		}

		IEnumerator<TItem> IEnumerable<TItem>.GetEnumerator()
		{
			return innerList.GetEnumerator();
		}

		public int IndexOf(TItem item)
		{
			return innerList.IndexOf(item);
		}

		public void Insert(int index, TItem item)
		{
			innerList.Insert(index, item);
			ManageItemOnAdd(item);
			UnbindEvents(item);
			BindEvents(item);
			CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
		}

		public bool Remove(TItem item)
		{
			ManageItemOnRemove(item);
			var ret = innerList.Remove(item);
			CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item));
			return ret;
		}

		public void RemoveAt(int index)
		{
			var item = innerList.ElementAt(index);
			ManageItemOnRemove(item);
			UnbindEvents(item);
			innerList.Remove(item);
			CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item));
		}

		protected abstract void BindEvents(TItem item);

		protected abstract ScoreException CreateOutOfBoundsException(int index);

		protected abstract void ManageItemOnAdd(TItem item);

		protected abstract void ManageItemOnRemove(TItem item);

		protected abstract void UnbindEvents(TItem item);
	}
}