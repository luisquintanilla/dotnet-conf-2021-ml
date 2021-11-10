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
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    /// <summary>
    /// Strategy of writing elements of specific type into MusicXml.
    /// </summary>
    /// <typeparam name="TSymbol"></typeparam>
    public abstract class MusicXmlWritingStrategy<TSymbol> : MusicXmlWritingStrategyBase where TSymbol : MusicalSymbol
    {
        /// <summary>
        /// Symbol type
        /// </summary>
        public override Type SymbolType
        {
            get { return typeof(TSymbol); }
        }

        /// <summary>
        /// Writes element int MusicXml.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="element"></param>
        /// <param name="quarterNoteDuration"></param>
        protected abstract void WriteElementInner(TSymbol symbol, XElement element, int quarterNoteDuration);

        /// <summary>
        /// Writes element into MusicXml
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="element"></param>
        /// <param name="quarterNoteDuration"></param>
        protected override void WriteElementInner(MusicalSymbol symbol, XElement element, int quarterNoteDuration)
        {
            if (symbol.Staff?.Part?.Staves.Count > 1)
            {
                var staffNumber = symbol.Staff.Part.Staves.IndexOf(symbol.Staff) + 1;
                element.Add(new XElement("staff", staffNumber));
            }
            WriteElementInner((TSymbol)symbol, element, quarterNoteDuration);
        }
    }
}