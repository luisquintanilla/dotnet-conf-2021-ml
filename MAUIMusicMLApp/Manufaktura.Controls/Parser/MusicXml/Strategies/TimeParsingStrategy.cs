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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    class TimeParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "time"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            int numberOfBeats = 4;
            int beatType = 4;
            TimeSignatureType sType = TimeSignatureType.Numbers;

            element.IfElement("beats").HasValue<int>().Then(v => numberOfBeats = v);
            element.IfElement("beat-type").HasValue<int>().Then(v => beatType = v);
            element.IfAttribute("symbol").HasValue(new Dictionary<string, TimeSignatureType> {
                    {"common", TimeSignatureType.Common},
                    {"cut", TimeSignatureType.Cut}
                }).Then(s => sType = s);

            if (staff.Part != null && staff.Part.Staves.Any())  //If part contains many staves, add to all staves
            {
                foreach (var s in staff.Part.Staves)
                {
                    var t = new TimeSignature(sType, numberOfBeats, beatType);
                    s.Elements.Add(t);
                }
            }
            else
            {
                var t = new TimeSignature(sType, numberOfBeats, beatType);
                staff.Elements.Add(t);
            }
        }
    }
}
