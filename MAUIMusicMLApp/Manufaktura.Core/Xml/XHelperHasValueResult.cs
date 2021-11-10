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

namespace Manufaktura.Core.Xml
{
	public class XHelperHasValueResult<T> : IXHelperResult<T>
	{
		private string rawValue;
		private T value;

		internal XHelperHasValueResult(T value, string rawValue, bool hasValue)
		{
			this.value = value;
			this.rawValue = rawValue;
			HasValue = hasValue;
		}


		public bool HasValue { get; private set; }

		public T Value
		{
			get
			{
				if (!HasValue) throw new Exception("Value does not exist.");
				return value;
			}
		}

		public T AndReturnResult()
		{
			return HasValue ? value : default(T);
		}

		public IXHelperResult Otherwise(Action<string> action)
		{
			if (!HasValue && action != null) action(rawValue);
			return this;
		}

		public IXHelperResult<T> Then(Action<T> action)
		{
			if (HasValue && action != null) action(Value);
			return this;
		}

		public IXHelperResult Then(Action action)
		{
			if (HasValue && action != null) action();
			return this;
		}

		public T ThenReturnResult()
		{
			return AndReturnResult();
		}
	}
}