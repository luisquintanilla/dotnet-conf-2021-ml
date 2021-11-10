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
using Manufaktura.Music.Model;
using System.Text;

namespace Manufaktura.Controls.Rendering.Implementations
{
    /// <summary>
    /// Implementation of HtmlScoreRenderer which utilises HTML canvas for rendering
    /// </summary>
    public class HtmlCanvasScoreRenderer : HtmlScoreRenderer<StringBuilder>
    {
        public override bool CanDrawCharacterInBounds => false;

        public HtmlCanvasScoreRenderer()
            : base(null)
        {
        }

        public HtmlCanvasScoreRenderer(StringBuilder stringBuilder, string canvasName, HtmlScoreRendererSettings settings)
            : base(stringBuilder)
        {
            Settings = settings;

            stringBuilder.AppendLine(string.Format("var canvas = document.getElementById('{0}');", canvasName));
            stringBuilder.AppendLine("var context = canvas.getContext('2d');");
        }

        /// <summary>
        /// Ads arc to HTML canvas
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="startAngle"></param>
        /// <param name="sweepAngle"></param>
        /// <param name="pen"></param>
        /// <param name="owner"></param>
		public override void DrawArc(Primitives.Rectangle rect, double startAngle, double sweepAngle, Primitives.Pen pen, Model.MusicalSymbol owner)
        {
            Canvas.AppendLine("context.beginPath();");
            Canvas.AppendLine(string.Format("context.arc({0},{1},{2},{3},{4});", rect.X.ToStringInvariant(), rect.Y.ToStringInvariant(),
                rect.Height.ToStringInvariant(),
                UsefulMath.GradToRadians(startAngle).ToStringInvariant(),
                UsefulMath.GradToRadians(sweepAngle).ToStringInvariant()));
            Canvas.AppendLine("context.stroke();");

            if (rect.X + rect.Width > ActualWidth) ActualWidth = rect.X + rect.Width;
            if (rect.Y + rect.Height > ActualHeight) ActualHeight = rect.Y + rect.Height;
        }

        /// <summary>
        /// Adds a bezier curve to HTML canvas
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <param name="p4"></param>
        /// <param name="pen"></param>
        /// <param name="owner"></param>
		public override void DrawBezier(Primitives.Point p1, Primitives.Point p2, Primitives.Point p3, Primitives.Point p4, Primitives.Pen pen, Model.MusicalSymbol owner)
        {
            Canvas.AppendLine("context.beginPath();");
            Canvas.AppendLine(string.Format("context.moveTo({0}, {1});", p1.X.ToStringInvariant(), p1.Y.ToStringInvariant()));
            Canvas.AppendLine(string.Format("context.bezierCurveTo({0},{1},{2},{3},{4},{5});",
                p2.X.ToStringInvariant(),
                p2.Y.ToStringInvariant(),
                p3.X.ToStringInvariant(),
                p3.Y.ToStringInvariant(),
                p4.X.ToStringInvariant(),
                p4.Y.ToStringInvariant()));
            Canvas.AppendLine("context.stroke();");

            if (p4.X > ActualWidth) ActualWidth = p4.X;
            if (p1.Y > ActualHeight) ActualHeight = p1.Y;
        }

        /// <summary>
        /// Adds a line to HTML canvas
        /// </summary>
        /// <param name="startPoint"></param>
        /// <param name="endPoint"></param>
        /// <param name="pen"></param>
        /// <param name="owner"></param>
		public override void DrawLine(Primitives.Point startPoint, Primitives.Point endPoint, Primitives.Pen pen, Model.MusicalSymbol owner)
        {
            Canvas.AppendLine("context.beginPath();");
            Canvas.AppendLine(string.Format("context.moveTo({0}, {1});", startPoint.X.ToStringInvariant(), startPoint.Y.ToStringInvariant()));
            Canvas.AppendLine(string.Format("context.lineTo({0}, {1});", endPoint.X.ToStringInvariant(), endPoint.Y.ToStringInvariant()));
            Canvas.AppendLine("context.stroke();");

            if (startPoint.X > ActualWidth) ActualWidth = startPoint.X;
            if (endPoint.X > ActualWidth) ActualWidth = endPoint.X;
            if (startPoint.Y > ActualHeight) ActualHeight = startPoint.Y;
            if (endPoint.Y > ActualHeight) ActualHeight = endPoint.Y;
        }

        /// <summary>
        /// Adds a string to HTML canvas
        /// </summary>
        /// <param name="text"></param>
        /// <param name="fontStyle"></param>
        /// <param name="location"></param>
        /// <param name="color"></param>
        /// <param name="owner"></param>
		public override void DrawString(string text, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Color color, Model.MusicalSymbol owner)
        {
            if (!TypedSettings.Fonts.ContainsKey(fontStyle)) return;   //Nie ma takiego fontu zdefiniowanego. Nie rysuj.

            location = TranslateTextLocation(location, fontStyle);

            Canvas.AppendLine(string.Format("context.font = '{0}pt {1}';", TypedSettings.Fonts[fontStyle].Size.ToStringInvariant(), TypedSettings.Fonts[fontStyle].Name));
            Canvas.AppendLine(string.Format("context.fillText('{0}', {1}, {2});", text, location.X.ToStringInvariant(), location.Y.ToStringInvariant()));

            if (location.X > ActualWidth) ActualWidth = location.X;
            if (location.Y > ActualHeight) ActualHeight = location.Y;
        }

        public override void DrawCharacterInBounds(char character, MusicFontStyles fontStyle, Point location, Size size, Color color, Model.MusicalSymbol owner)
        {
        }

        protected override void DrawPlaybackCursor(PlaybackCursorPosition position, Point start, Point end)
        {
        }
    }
}