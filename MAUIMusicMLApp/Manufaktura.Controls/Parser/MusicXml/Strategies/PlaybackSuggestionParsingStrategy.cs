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
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public class BackupParsingStrategy : PlaybackSuggestionParsingStrategy
    {
        public override string ElementName => "backup";

        protected override bool IsBackward => true;
    }

    public class ForwardParsingStrategy : PlaybackSuggestionParsingStrategy
    {
        public override string ElementName => "forward";

        protected override bool IsBackward => false;
    }

    public abstract class PlaybackSuggestionParsingStrategy : MusicXmlParsingStrategy
    {
        protected abstract bool IsBackward { get; }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            var suggestion = new PlaybackSuggestion { IsBackward = IsBackward };
            element.IfElement("duration").HasValue<int>().Then(d => suggestion.MusicXmlDuration = d);
            element.IfElement("voice").HasValue<int>().Then(v => suggestion.Voice = v);
            staff.Elements.Add(suggestion);
        }
    }
}