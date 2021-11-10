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
using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    class AttributeParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "attributes"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            var elementList = element.Elements().ToList();

            //Element "staves" must be the first element:
            var stavesElement = elementList.FirstOrDefault(e => e.Name == "staves");
            if (stavesElement != null)
            {
                elementList.Remove(stavesElement);
                elementList.Insert(0, stavesElement);
            }

			var attributePriorities = new[] { "clef", "key", "time" }.ToList();
            foreach (XElement attribute in elementList.OrderBy(k => attributePriorities.IndexOf(k.Name.LocalName)))
            {
                MusicXmlParsingStrategy parsingStrategy = GetProperStrategy(attribute);
                if (parsingStrategy != null) parsingStrategy.ParseElement(state, staff, attribute);
            }
        }
    }
}
