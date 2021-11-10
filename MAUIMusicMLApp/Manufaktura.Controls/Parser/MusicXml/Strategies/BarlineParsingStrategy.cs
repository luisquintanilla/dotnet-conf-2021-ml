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
using Manufaktura.Core.Xml;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    internal class BarlineParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "barline"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            var b = new Barline();

            element.IfAttribute("location").HasValue("left")
                .Then(() => b.Location = HorizontalPlacement.Left)
                .Otherwise(r => b.Location = HorizontalPlacement.Right);

            element.IfElement("bar-style").HasValue("light-heavy").Then(() => b.Style = BarlineStyle.LightHeavy);
            element.IfElement("bar-style").HasValue("none").Then(() => b.Style = BarlineStyle.None);
            element.IfElement("bar-style").HasValue("dashed").Then(() => b.Style = BarlineStyle.Dashed);
            var repeatAttribute = element.Elements().FirstOrDefault(e => e.Name == "repeat");
            var attribute = repeatAttribute?.Attributes().FirstOrDefault(a => a.Name == "direction");

            bool add = false;
            if (attribute != null)
            {
                if (attribute.Value == "forward") b.RepeatSign = RepeatSignType.Forward;
                else if (attribute.Value == "backward")
                {
                    b.RepeatSign = RepeatSignType.Backward;
                    state.BarlineAlreadyAdded = true;
                }
                add = true;
            }
            else if (b.Style != BarlineStyle.Regular)
            {
                state.BarlineAlreadyAdded = true;
                add = true;
            }

            if (add)
            {
                if (staff.Part?.Staves.Any() ?? false)  //If part contains many staves, add to all staves
                {
                    foreach (var s in staff.Part.Staves)
                    {
                        s.Elements.Add(b);
                    }
                }
                else
                {
                    staff.Elements.Add(b);
                }
            }
        }
    }
}