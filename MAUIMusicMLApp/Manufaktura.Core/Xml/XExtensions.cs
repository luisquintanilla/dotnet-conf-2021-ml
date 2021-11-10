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
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Core.Xml
{
    public static class XExtensions
    {
        public static IXHelper IfAttribute(this XElement element, string name)
        {
            if (element == null) return new XAttributeHelper(null);
            var attribute = element.Attributes().FirstOrDefault(d => d.Name == name);
            return new XAttributeHelper(attribute);
        }

        public static IXHelper IfDescendant(this XElement element, string name)
        {
            if (element == null) return new XAttributeHelper(null);
            var descendant = element.Descendants().FirstOrDefault(d => d.Name == name);
            return new XElementHelper(descendant);
        }

        public static void ForEachDescendant(this XElement element, string name, Action<XElementHelper> action)
        {
            if (element == null) return;
            var descendants = element.Descendants().Where(d => d.Name == name);
            foreach (var descendant in descendants) action(new XElementHelper(descendant));
        }

        public static IXHelper IfElement(this XElement element, string name)
        {
            if (element == null) return new XAttributeHelper(null);
            var descendant = element.Elements().FirstOrDefault(d => d.Name == name);
            return new XElementHelper(descendant);
        }

        public static XElement GetElement(this XElement element, string name)
        {
            if (element == null) return null;
            return element.Elements().FirstOrDefault(x => x.Name == name);
        }

        public static XHelperExistsResult IfHasElement(this XElement element, string name)
        {
            var child = element == null ? null : element.Elements().FirstOrDefault(x => x.Name == name);
            return new XHelperExistsResult(child != null, child, child?.Value);
        }
    }
}