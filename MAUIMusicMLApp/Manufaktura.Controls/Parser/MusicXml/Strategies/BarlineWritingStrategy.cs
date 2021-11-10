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
using Manufaktura.Controls.Model.Exceptions;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    /// <summary>
    /// Strategy for writing barlines.
    /// </summary>
    public class BarlineWritingStrategy : MusicXmlWritingStrategy<Barline>
    {
        public override string ElementName => "barline";

        public override bool IsAttributeElement => false;

        protected override void WriteElementInner(Barline symbol, XElement element, int quarterNoteDuration)
        {
            if (symbol.Style == BarlineStyle.Regular) return;
            element.Add(new XAttribute("location", symbol.Location.ToString().ToLowerInvariant()));
            element.Add(new XElement("bar-style", GetBarlineStyle(symbol)));
        }

        private static string GetBarlineStyle(Barline barline)
        {
            switch (barline.Style)
            {
                case BarlineStyle.Regular:
                    return "regular";

                case BarlineStyle.LightHeavy:
                    return "light-heavy";

                default:
                    throw new ScoreException(barline, $"Unsupported barline style {barline.Style}.");
            }
        }
    }
}