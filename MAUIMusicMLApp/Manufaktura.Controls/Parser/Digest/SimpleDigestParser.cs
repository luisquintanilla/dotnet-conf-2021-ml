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
using Manufaktura.Music.Model.MajorAndMinor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Parser.Digest
{
	public class SimpleDigestParser : ScoreParser<string>
	{
		public override Model.Score Parse(string source)
		{
			var score = Score.CreateOneStaffScore(Clef.Treble, MajorScale.C);
			var splitted = source.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			foreach (var element in splitted)
			{
				if (element.Contains("_"))
				{
					var pitchAndDuration = element.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
					var midiPitch = int.Parse(pitchAndDuration[1]);
					var denominator = int.Parse(pitchAndDuration[0].Replace(".", ""));
					var numberOfNotes = pitchAndDuration[0].ToCharArray().Where(c => c == '.').Count();
                    var denominatorAsPowerOfTwo = UsefulMath.Log2(denominator);
                    var note = Note.FromMidiPitch(midiPitch, new RhythmicDuration(denominatorAsPowerOfTwo, numberOfNotes));
					score.FirstStaff.Elements.Add(note);
				}
				else if (element == "|")
				{
					score.FirstStaff.Elements.Add(new Barline());
				}
				else
				{
					var denominator = int.Parse(element.Replace(".", ""));
					var numberOfNotes = element.ToCharArray().Where(c => c == '.').Count();
                    var denominatorAsPowerOfTwo = UsefulMath.Log2(denominator);
                    var rest = new Rest(new RhythmicDuration(denominatorAsPowerOfTwo, numberOfNotes));
					score.FirstStaff.Elements.Add(rest);
				}
			}
			return score;
		}

		public override string ParseBack(Score score)
		{
			var strings = new List<string>();
			foreach (var element in score.FirstStaff.Elements)
			{
				var noteOrRest = element as NoteOrRest;
				if (noteOrRest != null)
				{
					var sb = new StringBuilder();
					sb.Append(noteOrRest.Duration.Denominator);
					for (var i = 0; i < noteOrRest.Duration.Dots; i++) sb.Append(".");
					var note = element as Note;
					if (note != null)
					{
						sb.Append("_");
						sb.Append(note.MidiPitch);
					}
					strings.Add(sb.ToString());
				}
				
				var barline = element as Barline;
				if (barline != null) strings.Add("|");
			}
			return string.Join(" ", strings);
		}
	}
}