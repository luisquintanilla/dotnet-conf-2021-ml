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

namespace Manufaktura.Controls.Parser.Digest
{
    public class RhythmDigestParser : ScoreParser<string>
    {
        public bool MarkRests { get; set; }
        public bool IncludeBarlines { get; set; }

        public RhythmDigestParser()
        {
            MarkRests = true;
            IncludeBarlines = true;
        }

        public override Model.Score Parse(string source)
        {
            throw new NotImplementedException();
        }

        public override string ParseBack(Model.Score score)
        {
            if (score == null) throw new ArgumentNullException("Score");

            StringBuilder sb = new StringBuilder();
            foreach (Staff staff in score.Staves)
            {
                foreach (var element in staff.Elements.Where(el => el is IHasDuration || el is Barline))
                {
                    if (element is Barline && IncludeBarlines)
                    {
                        sb.Append("| ");
                        continue;
                    }
                    IHasDuration durationElement = element as IHasDuration;
                    if (durationElement == null) continue;
                    sb.Append((int)durationElement.BaseDuration.Denominator);
                    for (int i = 0; i < durationElement.NumberOfDots; i++) sb.Append(".");
                    if (element is Rest && MarkRests) sb.Append("r");
                    sb.Append(" ");
                }
            }
            return sb.ToString().Trim();
        }
    }
}
