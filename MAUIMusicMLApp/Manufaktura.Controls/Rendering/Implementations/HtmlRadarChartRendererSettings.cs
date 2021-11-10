using Manufaktura.Controls.Primitives;

namespace Manufaktura.Controls.Rendering.Implementations
{
    public class HtmlRadarChartRendererSettings
    {
        public double AxisLabelFontSize { get; set; } = 12;
        public Pen AxisLinePen { get; set; } = new Pen(Color.Black);
        public Pen SamplePen { get; set; } = new Pen(Color.Red);
        public double Height { get; set; } = 300;
        public int MaxValue { get; set; } = 100;
        public int NumberOfTicks { get; set; } = 5;
        public double SampleDiameter { get; set; } = 5;
        public double Width { get; set; } = 300;
    }
}