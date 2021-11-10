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
using Manufaktura.Music.Model;
using System.Linq;

namespace Manufaktura.Controls.Model.Rules
{
    /// <summary>
    /// Rule that applies proper stem direction for notes on the staff. Every note on the third line and above has downward stem direction.
    /// This rule is applied when rhythmic duration of inserted note is not RhythmicDuration.Whole and SubjectToNoteStemRule on Note is set to true.
    /// </summary>
    public class NoteStemRule : StaffRule<Note>
    {
        public override void Apply(Staff staff, Note newElement)
        {
            var clef = staff.Elements.OfType<Clef>().LastOrDefault(c => staff.Elements.IndexOf(c) < staff.Elements.IndexOf(newElement));
            if (clef == null) return;

            var line = newElement.GetLineInSpecificClef(clef);
            newElement.StemDirection = line >= 3 ? VerticalDirection.Down : VerticalDirection.Up;
        }

        public override bool Condition(Staff staff, Note newElement)
        {
            return newElement.Duration != RhythmicDuration.Whole && newElement.SubjectToNoteStemRule;
        }
    }
}