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
using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Model;
using System;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml.Strategies
{
    public class MeasureParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "measure"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
#if CSHTML5
            throw new NotImplementedException("This method is not yet implemented for CSHTML5.");
#else

            var part = staff.Part;
			if (!staff.Score.Systems.Any())
			{
				staff.Score.Pages.Last().Systems.Add(new StaffSystem(staff.Score));
			}
			var system = staff.Score.Systems[state.CurrentSystemNo - 1];

            var measure = new Measure(staff, system);
            measure.Number = element.ParseAttribute<int>("number");
            staff.Measures.Add(measure);
            state.BarlineAlreadyAdded = false;
            if (element.Parent.Name == "part")  //Don't take the other voices than the upper into account / Nie uwzględniaj innych głosów niż górny
            {
                if (!state.FirstLoop)
                {
                    if (element.Parent.Attribute(XName.Get("id")).Value != state.PartID) return;
                }
                else
                {
                    state.PartID = element.Parent.Attribute(XName.Get("id")).Value;
                }
            }

            //Skip measure if needed:
            if (state.SkipMeasures > 0) { state.SkipMeasures--; return; }

            //Read width measure:
            measure.Width = element.ParseAttribute<double>("width");

            //Skip if measure node is empty:
            if (!element.HasElements) return;

            //Parse measure nodes:
            foreach (XElement elementNode in element.Elements().Where(e => e.Name == "attributes"))
            {
                MusicXmlParsingStrategy parsingStrategy = MusicXmlParsingStrategy.GetProperStrategy(elementNode);
                if (parsingStrategy != null) parsingStrategy.ParseElement(state, staff, elementNode);
            }
            foreach (var partStaff in part.Staves.Skip(1))
            {
                partStaff.Measures.Add(new Measure(partStaff, measure.System));
            }

            //Parse measure nodes:
            foreach (XElement elementNode in element.Elements().Where(e => e.Name != "attributes"))
            {
                MusicXmlParsingStrategy parsingStrategy = MusicXmlParsingStrategy.GetProperStrategy(elementNode);
                if (parsingStrategy != null) parsingStrategy.ParseElement(state, staff, elementNode);
            }

            if (!state.BarlineAlreadyAdded)
            {
                if (staff.Part != null && staff.Part.Staves.Any())  //If part contains many staves, add to all staves
                {
                    foreach (var s in staff.Part.Staves)
                    {
                        s.Elements.Add(new Barline());
                    }
                }
                else
                {
                    staff.Elements.Add(new Barline());
                }
            }
            state.FirstLoop = false;

#endif
        }
    }
}