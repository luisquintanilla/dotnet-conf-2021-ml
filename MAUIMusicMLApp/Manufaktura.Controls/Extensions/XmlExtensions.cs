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
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Extensions
{
    /// <summary>
    /// Extension methods for parsing Xml files
    /// </summary>
	public static class XmlExtensions
	{
		public static T? ParseAttribute<T>(this XElement element, string name) where T : struct
		{
			var childElement = element.Attributes().FirstOrDefault(d => d.Name == name);
			if (childElement == null) return null;
			return ParseValue<T>(childElement.Value);
		}

        /// <summary>
        /// Returns attribute value
        /// </summary>
        /// <param name="element"></param>
        /// <param name="name"></param>
        /// <returns></returns>
		public static string ParseAttribute(this XElement element, string name)
		{
			var childElement = element.Attributes().FirstOrDefault(d => d.Name == name);
			if (childElement == null) return null;
			return childElement.Value;
		}

		public static string ParseChildElement(this XElement element, string name)
		{
			var childElement = element.Descendants().FirstOrDefault(d => d.Name == name);
			if (childElement == null) return null;
			return childElement.Value;
		}

		public static T? ParseChildElement<T>(this XElement element, string name) where T : struct
		{
			var childElement = element.Descendants().FirstOrDefault(d => d.Name == name);
			if (childElement == null) return null;
			return ParseValue<T>(childElement.Value);
		}

		public static IEnumerable<T?> ParseChildElements<T>(this XElement element, string name) where T : struct
		{
			var childElements = element.Descendants().Where(d => d.Name == name);
			foreach (var el in childElements) yield return ParseValue<T>(el.Value);
		}

		public static IEnumerable<string> ParseChildElements(this XElement element, string name)
		{
			var childElements = element.Descendants().Where(d => d.Name == name);
			foreach (var el in childElements) yield return el.Value;
		}

		public static void ParseNodeWithDictionaryValue<T>(this XElement element, Action<T> useParseResultAction, string name, Dictionary<string, T> values)
		{
			var childElement = element.Descendants().FirstOrDefault(d => d.Name == name);
			if (childElement == null) return;
			if (values.ContainsKey(childElement.Value)) useParseResultAction(values[childElement.Value]);
		}

		private static T? ParseValue<T>(string value) where T : struct
		{
			if (typeof(T) == typeof(int)) return UsefulMath.TryParseInt(value) as T?;
			if (typeof(T) == typeof(double)) return UsefulMath.TryParse(value) as T?;
			if (typeof(T) == typeof(DateTime)) return UsefulMath.TryParseDateTime(value) as T?;
			throw new NotImplementedException("Type not supported");
		}
	}
}