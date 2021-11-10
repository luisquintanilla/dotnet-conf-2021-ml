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
using Manufaktura.Music.Model;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public class RestWritingStrategy : NoteOrRestWritingStrategy<Rest>
    {
        public override string ElementName => "note";

        public override bool IsAttributeElement => false;

        protected override void WriteElementInner(Rest symbol, XElement element, int quarterNoteDuration)
        {
            element.Add(new XElement("rest"));

            element.Add(new XElement("duration", (symbol.Duration.ToDouble() * quarterNoteDuration) / RhythmicDuration.Quarter.ToDouble()));

            if (symbol.Voice != 0) element.Add(new XElement("voice", symbol.Voice));
            element.Add(new XElement("type", NoteWritingStrategy.GetDurationName(symbol)));

            for (var dot = 0; dot < symbol.NumberOfDots; dot++) element.Add(new XElement("dot"));

            var notations = CreateNotations(symbol).ToArray();
            if (notations.Any())
            {
                element.Add(new XElement("notations", notations));
            }
        }
    }
}