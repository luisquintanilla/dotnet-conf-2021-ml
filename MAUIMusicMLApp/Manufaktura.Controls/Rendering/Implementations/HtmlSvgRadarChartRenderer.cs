/*
Copyright 2018 Manufaktura Programów Jacek Salamon
Website: http://musicengravingcontrols.com/
Patreon: https://www.patreon.com/jacek_salamon

MIT LICENCE

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"),
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering.Charts;
using Manufaktura.Music.Extensions;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manufaktura.Controls.Rendering.Implementations
{
    public class HtmlSvgRadarChartRenderer : RadarChartRenderer<HtmlRadarChartRendererSettings, XElement>
    {
        public HtmlSvgRadarChartRenderer(HtmlRadarChartRendererSettings control, XElement canvas) : base(control, canvas)
        {
        }

        protected override double MaxValue => Control.MaxValue;
        protected override int NumberOfTicks => Control.NumberOfTicks;
        protected override double CanvasHeight => Control.Height;

        protected override double CanvasWidth => Control.Width;
        protected override void ClearCanvas()
        {
        }

        protected override void DrawAxisLabel(Point position, double currentAngle, string axisName)
        {
            var element = new XElement("text",
               new XAttribute("x", position.X.ToStringInvariant()),
               new XAttribute("y", position.Y.ToStringInvariant()),
               new XAttribute("style", string.Format("fill:{0}; font-size:{1}pt;",
                   Control.AxisLinePen.Color.ToCss(),
                   Control.AxisLabelFontSize.ToStringInvariant())));
            element.Value = axisName;

            Canvas.Add(element);
        }

        protected override void DrawAxisLine(Point start, Point end)
        {
            var element = new XElement("line",
                            new XAttribute("x1", start.X.ToStringInvariant()),
                            new XAttribute("y1", start.Y.ToStringInvariant()),
                            new XAttribute("x2", end.X.ToStringInvariant()),
                            new XAttribute("y2", end.Y.ToStringInvariant()),
                            new XAttribute("style", Control.AxisLinePen.ToCss()));

            Canvas.Add(element);
        }

        protected override void DrawPolygon(IEnumerable<Point> innerPoints, IEnumerable<Point> outerPoints)
        {
        }
        protected override void DrawSample(RadarChartSample sample, double dx, double dy, double currentAngle)
        {
            var element = new XElement("ellipse",
                            new XAttribute("cx", (dx - Control.SampleDiameter / 2).ToStringInvariant()),
                            new XAttribute("cy", (dy - Control.SampleDiameter / 2).ToStringInvariant()),
                            new XAttribute("rx", Control.SampleDiameter.ToStringInvariant()),
                            new XAttribute("ry", Control.SampleDiameter.ToStringInvariant()),
                            new XAttribute("style", Control.SamplePen.ToCss()));

            Canvas.Add(element);
        }

        protected override void DrawTick(double x1, double y1, double x2, double y2)
        {
            DrawAxisLine(new Point(x1, y1), new Point(x2, y2));
        }

        protected override void DrawValueCompartmentsPolygons(double lineLength)
        {
        }

        protected override void DrawWebLine(Point p1, Point p2)
        {
            var element = new XElement("line",
                new XAttribute("x1", p1.X.ToStringInvariant()),
                new XAttribute("y1", p1.Y.ToStringInvariant()),
                new XAttribute("x2", p2.X.ToStringInvariant()),
                new XAttribute("y2", p2.Y.ToStringInvariant()),
                new XAttribute("style", Control.AxisLinePen.ToCss()));

            Canvas.Add(element);
        }
    }
}