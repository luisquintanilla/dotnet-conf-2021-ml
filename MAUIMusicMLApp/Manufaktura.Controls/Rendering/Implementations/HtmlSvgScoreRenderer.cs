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
using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Music.Extensions;
using System.Xml.Linq;

namespace Manufaktura.Controls.Rendering.Implementations
{
    public class HtmlSvgScoreRenderer : HtmlScoreRenderer<XElement>
    {
        private const string EmptyCharacterWithWidth = "j";

        public HtmlSvgScoreRenderer()
            : base(null)
        {
        }

        public HtmlSvgScoreRenderer(XElement element, string svgCanvasName, HtmlScoreRendererSettings settings)
            : base(element)
        {
            Settings = settings;
        }


        public override bool CanDrawCharacterInBounds => false;

        public override void DrawArc(Rectangle rect, double startAngle, double sweepAngle, Pen pen, Model.MusicalSymbol owner)
        {
            if (!EnsureProperPage(owner)) return;
            if (Settings.RenderingMode != ScoreRenderingModes.Panorama && !TypedSettings.IgnorePageMargins) rect = rect.Translate(CurrentScore.DefaultPageSettings);

            var element = new XElement("path",
                new XAttribute("d", string.Format("M{0} {1} A{2} {3} {4} {5} {6} {7} {8}",
                    rect.X.ToStringInvariant(),
                    rect.Y.ToStringInvariant(),
                    (rect.X + rect.Width).ToStringInvariant(),
                    rect.Y.ToStringInvariant(),
                    startAngle.ToStringInvariant(),
                    sweepAngle > 180 ? 1 : 0,
                    sweepAngle < 180 ? 0 : 1,
                    (rect.X + rect.Width).ToStringInvariant(),
                    (rect.Y).ToStringInvariant())),
                new XAttribute("style", pen.ToCss()),
                new XAttribute("id", BuildElementId(owner)));

            var playbackAttributes = BuildPlaybackAttributes(owner);
            foreach (var playbackAttr in playbackAttributes)
            {
                element.Add(new XAttribute(playbackAttr.Key, playbackAttr.Value));
            }

            if (rect.Y < ClippedAreaY) ClippedAreaY = rect.Y;
            if (rect.X + rect.Width > ActualWidth) ActualWidth = rect.X + rect.Width;
            if (rect.Y + rect.Height > ActualHeight) ActualHeight = rect.Y + rect.Height;

            Canvas.Add(element);
        }

        public override void DrawBezier(Point p1, Point p2, Point p3, Point p4, Pen pen, Model.MusicalSymbol owner)
        {
            if (!EnsureProperPage(owner)) return;
            if (Settings.RenderingMode != ScoreRenderingModes.Panorama && !TypedSettings.IgnorePageMargins)
            {
                p1 = p1.Translate(CurrentScore.DefaultPageSettings);
                p2 = p2.Translate(CurrentScore.DefaultPageSettings);
                p3 = p3.Translate(CurrentScore.DefaultPageSettings);
                p4 = p4.Translate(CurrentScore.DefaultPageSettings);
            }

            var element = new XElement("path",
                new XAttribute("d", string.Format("M{0} {1} C{2} {3}, {4} {5}, {6} {7}",
                    p1.X.ToStringInvariant(),
                    p1.Y.ToStringInvariant(),
                    p2.X.ToStringInvariant(),
                    p2.Y.ToStringInvariant(),
                    p3.X.ToStringInvariant(),
                    p3.Y.ToStringInvariant(),
                    p4.X.ToStringInvariant(),
                    p4.Y.ToStringInvariant())),
                new XAttribute("style", pen.ToCss()),
                new XAttribute("id", BuildElementId(owner)));

            var playbackAttributes = BuildPlaybackAttributes(owner);
            foreach (var playbackAttr in playbackAttributes)
            {
                element.Add(new XAttribute(playbackAttr.Key, playbackAttr.Value));
            }

            if (p1.Y < ClippedAreaY) ClippedAreaY = p1.Y;
            if (p2.Y < ClippedAreaY) ClippedAreaY = p2.Y;
            if (p3.Y < ClippedAreaY) ClippedAreaY = p3.Y;
            if (p4.Y < ClippedAreaY) ClippedAreaY = p4.Y;
            if (p4.X > ActualWidth) ActualWidth = p4.X;
            if (p1.Y > ActualHeight) ActualHeight = p1.Y;

            Canvas.Add(element);
        }

        public override void DrawCharacterInBounds(char character, MusicFontStyles fontStyle, Point location, Size size, Color color, Model.MusicalSymbol owner)
        {
            if (!EnsureProperPage(owner)) return;
            if (Settings.RenderingMode != ScoreRenderingModes.Panorama && !TypedSettings.IgnorePageMargins) location = location.Translate(CurrentScore.DefaultPageSettings);

            var element = GetTextElement(character.ToString(), fontStyle, new Point(0, 0), color, owner);
            var svg = new XElement("svg",
                new XAttribute("x", location.X.ToStringInvariant()),
                new XAttribute("y", location.Y.ToStringInvariant()),
                new XAttribute("width", size.Width.ToStringInvariant()),
                new XAttribute("height", size.Height.ToStringInvariant()),
                new XAttribute("viewBox", $"0 0 {size.Width.ToStringInvariant()} {size.Height.ToStringInvariant()}"));
            svg.Add(element);

            //element.SetAttributeValue(XName.Get("viewBox"), $"0 0 {size.Width.ToStringInvariant()} {size.Height.ToStringInvariant()}");

            if (location.Y < ClippedAreaY) ClippedAreaY = location.Y;
            if (location.X > ActualWidth) ActualWidth = location.X;
            if (location.Y > ActualHeight) ActualHeight = location.Y;

            Canvas.Add(svg);
        }

        public override void DrawLine(Point startPoint, Point endPoint, Pen pen, Model.MusicalSymbol owner)
        {
            if (!EnsureProperPage(owner)) return;
            if (Settings.RenderingMode != ScoreRenderingModes.Panorama && !TypedSettings.IgnorePageMargins)
            {
                startPoint = startPoint.Translate(CurrentScore.DefaultPageSettings);
                endPoint = endPoint.Translate(CurrentScore.DefaultPageSettings);
            }

            var element = new XElement("line",
                new XAttribute("x1", startPoint.X.ToStringInvariant()),
                new XAttribute("y1", startPoint.Y.ToStringInvariant()),
                new XAttribute("x2", endPoint.X.ToStringInvariant()),
                new XAttribute("y2", endPoint.Y.ToStringInvariant()),
                new XAttribute("style", pen.ToCss()),
                new XAttribute("id", BuildElementId(owner)));

            var playbackAttributes = BuildPlaybackAttributes(owner);
            foreach (var playbackAttr in playbackAttributes)
            {
                element.Add(new XAttribute(playbackAttr.Key, playbackAttr.Value));
            }

            if (startPoint.Y < ClippedAreaY) ClippedAreaY = startPoint.Y;
            if (endPoint.Y < ClippedAreaY) ClippedAreaY = endPoint.Y;
            if (startPoint.X > ActualWidth) ActualWidth = startPoint.X;
            if (endPoint.X > ActualWidth) ActualWidth = endPoint.X;
            if (startPoint.Y > ActualHeight) ActualHeight = startPoint.Y;
            if (endPoint.Y > ActualHeight) ActualHeight = endPoint.Y;

            Canvas.Add(element);
        }

        public override void DrawString(string text, MusicFontStyles fontStyle, Point location, Color color, Model.MusicalSymbol owner)
        {
            if (!TypedSettings.Fonts.ContainsKey(fontStyle)) return;   //Nie ma takiego fontu zdefiniowanego. Nie rysuj.

            if (!EnsureProperPage(owner)) return;
            if (Settings.RenderingMode != ScoreRenderingModes.Panorama && !TypedSettings.IgnorePageMargins) location = location.Translate(CurrentScore.DefaultPageSettings);

            location = TranslateTextLocation(location, fontStyle);

            var element = GetTextElement(text, fontStyle, location, color, owner);

            if (location.Y - 15 < ClippedAreaY) ClippedAreaY = location.Y - 15;
            if (location.X > ActualWidth) ActualWidth = location.X;
            if (location.Y > ActualHeight) ActualHeight = location.Y;

            Canvas.Add(element);
        }

        protected override void DrawPlaybackCursor(PlaybackCursorPosition position, Point start, Point end)
        {
        }

        private XElement GetTextElement(string text, MusicFontStyles fontStyle, Point location, Color color, Model.MusicalSymbol owner)
        {
            var element = new XElement("text",
               new XAttribute("x", location.X.ToStringInvariant()),
               new XAttribute("y", location.Y.ToStringInvariant()),
               new XAttribute("style", string.Format("fill:{0}; font-size:{1}pt; font-family: {2};",
                   color.ToCss(),
                   TypedSettings.Fonts[fontStyle].Size.ToStringInvariant(),
                   TypedSettings.Fonts[fontStyle].Name)),
               new XAttribute("id", BuildElementId(owner)));
            element.Value = TypedSettings.Fonts[fontStyle].Name == "Polihymnia" ? string.Format("{0}{1}", text, EmptyCharacterWithWidth) : text;

            var playbackAttributes = BuildPlaybackAttributes(owner);
            foreach (var playbackAttr in playbackAttributes)
            {
                element.Add(new XAttribute(playbackAttr.Key, playbackAttr.Value));
            }
            return element;
        }
    }
}