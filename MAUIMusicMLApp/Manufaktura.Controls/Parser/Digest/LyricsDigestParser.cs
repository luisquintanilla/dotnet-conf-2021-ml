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
    public class LyricsDigestParser : ScoreParser<string>
    {
        public override Model.Score Parse(string source)
        {
            throw new NotImplementedException();
        }

        public override string ParseBack(Score score)
        {
            List<StringBuilder> verses = new List<StringBuilder>();
            foreach (Staff staff in score.Staves)
            {
                foreach (Note note in staff.Elements.OfType<Note>())
                {
                    for (int i = 0; i < note.Lyrics.Count; i++)
                    {
                        if (verses.Count < i + 1) verses.Add(new StringBuilder());
                        Lyrics currentLyrics = note.Lyrics[i];
                        verses[i].Append(currentLyrics.Text);
                        if (currentLyrics.Type == SyllableType.End || currentLyrics.Type == SyllableType.Single) verses[i].Append(" ");
                    }
                }
            }
            return string.Join(" ", verses).Trim();
        }
    }
}
