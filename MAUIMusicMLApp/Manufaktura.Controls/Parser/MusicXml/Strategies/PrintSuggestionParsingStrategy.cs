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
using Manufaktura.Core.Xml;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
	public class PrintSuggestionParsingStrategy : MusicXmlParsingStrategy
	{
		public override string ElementName
		{
			get { return "print"; }
		}



		public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
		{
			PrintSuggestion suggestion = CreateSuggestion(element, state, staff);
            staff.Elements.Add(suggestion);

            if (staff.Part?.Staves.Any() ?? false)  //If part contains many staves, add to all staves
			{
				foreach (var s in staff.Part.Staves.Skip(1))
				{
					s.Elements.Add(suggestion.Clone());
				}
			}

			if (suggestion.IsPageBreak)
			{
				var page = new ScorePage(staff.Score);
				staff.Score.Pages.Add(page);
			}
			if (suggestion.IsSystemBreak)
			{
				state.CurrentSystemNo++;
				var system = NewSystem(state, staff);
				staff.Measures.Last().System = system;
				if (staff.Part != null && staff.Part.Staves.Any())  //If part contains many staves, add to all staves
				{
					foreach (var s in staff.Part.Staves)
					{
						s.Measures.Last().System = system;
					}
				}
			}
		}

		private static StaffSystem NewSystem(MusicXmlParserState state, Staff staff)
		{
			if (staff == staff.Score.Staves.First())
			{
				var system = new StaffSystem(staff.Score);
				staff.Score.Pages.Last().Systems.Add(system);
				return system;
			}
			return staff.Score.Systems[state.CurrentSystemNo - 1];
		}

		private PrintSuggestion CreateSuggestion(XElement element, MusicXmlParserState state, Staff staff)
		{
			PrintSuggestion suggestion = new PrintSuggestion();

			element.IfAttribute("new-system").HasValue("yes").Then(() => suggestion.IsSystemBreak = true);
			element.IfAttribute("new-page").HasValue("yes").Then(() => suggestion.IsPageBreak = true);
			if (suggestion.IsPageBreak) suggestion.IsSystemBreak = true;    //Page breaks are treated also as system breaks.

			element.IfDescendant("system-distance").Exists().Then(n =>
			{
				suggestion.SystemDistance = UsefulMath.TryParse(n.Value);
			});

			//Issue #45: Kopiujemy ustawienia z pierwszego staffa do wszystkich pozostałych staffów (bo są zdefiniowane tylko w pierwszym), innaczej się układ rozjedzie:
			if (!suggestion.SystemDistance.HasValue && staff != staff.Score.Staves.First())
			{
				var thisStaffPrintSuggestions = staff.Elements.OfType<PrintSuggestion>().ToList();
				var firstStaffPrintSuggestions = staff.Score.Staves.First().Elements.OfType<PrintSuggestion>().ToList();
				var indexOfThisBreak = (thisStaffPrintSuggestions.Any() ? thisStaffPrintSuggestions.IndexOf(thisStaffPrintSuggestions.Last()) : -1) + 1;
				if (firstStaffPrintSuggestions.Count > indexOfThisBreak) suggestion.SystemDistance = firstStaffPrintSuggestions[indexOfThisBreak].SystemDistance;
			}
			element.IfDescendant("staff-distance").Exists().Then(n =>
			{
				staff.Score.Pages.Last().DefaultStaffDistance = UsefulMath.TryParse(n.Value);
			});

			return suggestion;
		}
	}
}