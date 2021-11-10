using System.Linq;

namespace Manufaktura.Controls.Model.Rules
{
    public class BreakSystemRule : StaffRule<PrintSuggestion>
    {
        public override void Apply(Staff staff, PrintSuggestion newElement)
        {
            if (!newElement.IsSystemBreak) return;

            var lastMeasure = staff.Measures.LastOrDefault();
            if (lastMeasure == null) return;

            var system = GetSystem(staff);
            if (system != staff.Score.Systems.LastOrDefault()) return;

            system = new StaffSystem(staff.Score);
            staff.Score.Pages.Last().Systems.Add(system);
            lastMeasure.System = system;
        }

        public override bool Condition(Staff staff, PrintSuggestion newElement) => staff.MeasureAddingRule == Staff.MeasureAddingRuleEnum.AddMeasureOnInsertingBarline;
    }
}