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
using System.Linq;

namespace Manufaktura.Controls.Model.Rules
{
    /// <summary>
    /// This rule automatically adds new measure to the staff if a barline is inserted.
    /// This rule is applied if MeasureAddingRule property on Staff is set to Staff.MeasureAddingRuleEnum.AddMeasureOnInsertingBarline.
    /// </summary>
    public class AutomaticAddMeasuresRule : StaffRule<MusicalSymbol>
    {
        public override void Apply(Staff staff, MusicalSymbol newElement)
        {
            var currentMeasure = staff.Measures.LastOrDefault();
            if (currentMeasure == null)
            {
                currentMeasure = new Measure(staff, GetSystem(staff)) { Number = staff.Measures.Count + 1 };
                staff.Measures.Add(currentMeasure);
            }

            var barline = newElement as Barline;
            if (barline != null)
            {
                currentMeasure.Elements.Add(barline);
                barline.Measure = currentMeasure;
                staff.Measures.Add(new Measure(staff, GetSystem(staff)) { Number = staff.Measures.Count + 1 });
                return;
            }

            currentMeasure.Elements.Add(newElement);
            newElement.Measure = currentMeasure;
        }



        public override bool Condition(Staff staff, MusicalSymbol newElement)
        {
            return staff.MeasureAddingRule == Staff.MeasureAddingRuleEnum.AddMeasureOnInsertingBarline;
        }
    }
}