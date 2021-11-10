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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Model.PeekStrategies
{
    public class HighestNoteInChordPeekStrategy<TSymbol> : PeekStrategy<TSymbol> where TSymbol : MusicalSymbol
    {
        public HighestNoteInChordPeekStrategy(Staff staff) : base(staff)
        {
            if (typeof(TSymbol) != typeof(Note)) throw new Exception("This strategy can be only used for notes.");
        }

        public override TSymbol Peek(MusicalSymbol relativeTo)
        {
            Note lowestNote = relativeTo as Note;
            List<Note> chordElements = new List<Note>() { lowestNote };
            for (int i = Staff.Elements.IndexOf(lowestNote) + 1; i < Staff.Elements.Count(); i++)
            {
                Note currentNote = Staff.Elements[i] as Note;
                if (currentNote == null) continue;
                if (currentNote.IsUpperMemberOfChord) chordElements.Add(currentNote);
                else break;
            }
            return chordElements.First(n => n.MidiPitch == chordElements.Max(n1 => n1.MidiPitch)) as TSymbol;
        }
    }
}
