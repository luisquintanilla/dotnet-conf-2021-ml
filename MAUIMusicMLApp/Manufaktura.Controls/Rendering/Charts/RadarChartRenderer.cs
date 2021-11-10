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
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Rendering.Charts
{
    public abstract class RadarChartRenderer<TControl, TCanvas>
    {
        public RadarChartRenderer(TControl control, TCanvas canvas)
        {
            Canvas = canvas;
            Control = control;
        }

        public double CalculatedMaxLineLength { get; private set; } = 0;
        public TCanvas Canvas { get; private set; }
        public TControl Control { get; private set; }
        public Dictionary<RadarChartSample, double> SampleToAngleDictionary { get; } = new Dictionary<RadarChartSample, double>();
        protected abstract double CanvasHeight { get; }
        protected abstract double CanvasWidth { get; }
        protected abstract double MaxValue { get; }
        protected abstract int NumberOfTicks { get; }
        public void RedrawChart(RadarChartSample[] samples)
        {
            SampleToAngleDictionary.Clear();
            ClearCanvas();
            if (samples == null || !samples.Any()) return;

            var axes = samples.Select(s => s.AxisShortName).ToArray();
            var currentAngle = 0d;
            var angleChange = (2 * Math.PI) / axes.Length;
            var lineLength = CanvasHeight < CanvasWidth ? CanvasHeight / 2 : CanvasWidth / 2;
            CalculatedMaxLineLength = lineLength;

            List<Tuple<double, double>> previousTicks = null;
            List<Tuple<double, double>> firstTicks = null;
            foreach (var axis in axes)
            {
                DrawAxis(axis, lineLength, currentAngle);

                var ticks = CalculateTicks(axis, currentAngle, lineLength, axes.Length < 3);
                if (axes.Length > 2)
                {
                    if (firstTicks == null) firstTicks = new List<Tuple<double, double>>(ticks);
                    if (previousTicks != null) DrawWebLines(previousTicks, ticks);
                    previousTicks = ticks;
                }

                DrawSamples(samples, axis, lineLength, currentAngle);

                currentAngle += angleChange;
            }
            if (axes.Length > 2) DrawWebLines(firstTicks, previousTicks);

            DrawValueRangePolygon(samples, lineLength, MaxValue);
            DrawValueCompartmentsPolygons(lineLength);
        }

        protected abstract void ClearCanvas();

        protected abstract void DrawAxisLabel(Primitives.Point position, double currentAngle, string axisName);

        protected abstract void DrawAxisLine(Primitives.Point start, Primitives.Point end);

        protected abstract void DrawPolygon(IEnumerable<Primitives.Point> innerPoints, IEnumerable<Primitives.Point> outerPoints);
        protected abstract void DrawSample(RadarChartSample sample, double dx, double dy, double currentAngle);

        protected abstract void DrawTick(double x1, double y1, double x2, double y2);

        protected abstract void DrawValueCompartmentsPolygons(double lineLength);

        protected abstract void DrawWebLine(Point p1, Point p2);

        private List<Tuple<double, double>> CalculateTicks(string axis, double currentAngle, double lineLength, bool alsoDraw)
        {
            var ticks = new List<Tuple<double, double>>();
            for (int i = 0; i < NumberOfTicks; i++)
            {
                var tickOffset = (lineLength / NumberOfTicks) * (i + 1);
                var tickLocation = new Primitives.Point(CanvasWidth / 2, CanvasHeight / 2).TranslateByAngle(currentAngle, tickOffset);
                ticks.Add(new Tuple<double, double>(tickLocation.X + 0.5, tickLocation.Y + 0.5));

                if (alsoDraw) DrawTick(tickLocation.X, tickLocation.Y, tickLocation.TranslateByAngle(currentAngle, 1).X, tickLocation.TranslateByAngle(currentAngle, 1).Y);
            }
            return ticks;
        }

        private void DrawAxis(string axisName, double axisLength, double currentAngle)
        {
            var startPosition = new Primitives.Point(CanvasWidth / 2, CanvasHeight / 2);
            var endPosition = new Primitives.Point(startPosition.TranslateByAngle(currentAngle, axisLength).X, startPosition.TranslateByAngle(currentAngle, axisLength).Y);
            DrawAxisLine(startPosition, endPosition);
            DrawAxisLabel(endPosition, currentAngle, axisName);
        }

        private void DrawSamples(RadarChartSample[] samples, string axis, double lineLength, double currentAngle)
        {
            var axisSamples = samples.Where(s => s.AxisShortName == axis);
            foreach (var sample in axisSamples)
            {
                var valueLength = sample.Value * sample.Scale * lineLength / MaxValue;
                var dx = valueLength * Math.Sin(currentAngle);
                var dy = valueLength * Math.Cos(currentAngle);

                SampleToAngleDictionary.Add(sample, currentAngle);
                DrawSample(sample, CanvasWidth / 2 + dx, CanvasHeight / 2 + dy, currentAngle);
            }
        }

        private void DrawValueRangePolygon(RadarChartSample[] samples, double lineLength, double maxValue)
        {
            var innerPoints = new List<Primitives.Point>();
            var outerPoints = new List<Primitives.Point>();
            foreach (var sample in samples)
            {
                var currentAngle = SampleToAngleDictionary[sample];

                var valueLength = sample.ValidationMaxValue * sample.Scale * lineLength / maxValue;
                var dx = valueLength * Math.Sin(currentAngle);
                var dy = valueLength * Math.Cos(currentAngle);
                outerPoints.Add(new Primitives.Point(CanvasWidth / 2 + dx, CanvasHeight / 2 + dy));

                valueLength = sample.ValidationMinValue * sample.Scale * lineLength / maxValue;
                dx = valueLength * Math.Sin(currentAngle);
                dy = valueLength * Math.Cos(currentAngle);
                innerPoints.Add(new Primitives.Point(CanvasWidth / 2 + dx, CanvasHeight / 2 + dy));
            }

            DrawPolygon(innerPoints, outerPoints);
        }

        private void DrawWebLines(List<Tuple<double, double>> ticksOnOneAxis, List<Tuple<double, double>> ticksOnAnotherAxis)
        {
            for (int i = 0; i < NumberOfTicks; i++)
            {
                DrawWebLine(new Point(ticksOnOneAxis[i].Item1, ticksOnOneAxis[i].Item2), new Point(ticksOnAnotherAxis[i].Item1, ticksOnAnotherAxis[i].Item2));
            }
        }
    }
}