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

namespace Manufaktura.Core.Xml
{
    public abstract class XHelperBase : IXHelper
    {
        public XHelperExistsResult Exists()
        {
            return new XHelperExistsResult(ElementExists(), GetObject(), GetValue());
        }

        public XHelperHasValueResult<string> HasAnyValue()
        {
            if (!ElementExists()) return new XHelperHasValueResult<string>(null, null, false);
            var value = GetValue();
            return !string.IsNullOrWhiteSpace(value) ? new XHelperHasValueResult<string>(value, value, true) : new XHelperHasValueResult<string>(null, null, false);
        }

        public XHelperHasValueResult<T> HasValue<T>(Dictionary<string, T> values)
        {
            if (ElementExists() && values.ContainsKey(GetValue())) return new XHelperHasValueResult<T>(values[GetValue()], GetValue(), true);
            return new XHelperHasValueResult<T>(default(T), GetValue(), false);
        }

        public XHelperHasValueResult<T> HasValue<T>() where T : struct
        {
            if (!ElementExists()) return new XHelperHasValueResult<T>(default(T), null, false);
            var value = ParseValue<T>(GetValue());
            return value.HasValue ? new XHelperHasValueResult<T>(value.Value, GetValue(), true) : new XHelperHasValueResult<T>(default(T), GetValue(), false);
        }

        public XHelperHasValueResult<string> HasValue(string s)
        {
            if (!ElementExists()) return new XHelperHasValueResult<string>(null, null, false);
            var value = GetValue();
            return !string.IsNullOrWhiteSpace(value) && s == value ? new XHelperHasValueResult<string>(value, GetValue(), true) : new XHelperHasValueResult<string>(null, GetValue(), false);
        }

        protected abstract bool ElementExists();

        protected abstract string GetValue();

        protected abstract object GetObject();

        private static T? ParseValue<T>(string value) where T : struct
        {
            if (typeof(T) == typeof(int)) return ParseExtensions.TryParseInt(value) as T?;
            if (typeof(T) == typeof(double)) return ParseExtensions.TryParse(value) as T?;
            if (typeof(T) == typeof(float)) return ParseExtensions.TryParse(value) as T?;
            if (typeof(T) == typeof(DateTime)) return ParseExtensions.TryParseDateTime(value) as T?;
            throw new NotImplementedException("Type not supported");
        }

        public XHelperHasValueResult<T> HasValue<T>(Func<Dictionary<string, T>, Dictionary<string, T>> valueFactory)
        {
#if !CSHTML5
            var dict = valueFactory(new Dictionary<string, T>());
#else
            var dict = valueFactory(new List<KeyValuePair<string, T>>().ToDictionary(x => x.Key, x => x.Value));
#endif
            return HasValue(dict);
        }
    }
}