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
using Manufaktura.Controls.Primitives;
using Manufaktura.Music.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering.Implementations
{
    public class Score2HtmlCanvasBuilder : Score2HtmlBuilder<HtmlCanvasScoreRenderer, StringBuilder>
    {
        public Score2HtmlCanvasBuilder(IEnumerable<Score> scores, string canvasPrefix, HtmlScoreRendererSettings settings)
        {
            if (string.IsNullOrWhiteSpace(canvasPrefix)) throw new ArgumentNullException("canvasPrefix");
            Scores = scores;
            CanvasPrefix = canvasPrefix;
            Settings = settings;
        }

        public Score2HtmlCanvasBuilder(Score score, string canvasName, HtmlScoreRendererSettings settings)
            : this(new List<Score> { score }, canvasName, settings)
        {
        }

        /// <summary>
        /// Creates font styles declaration
        /// </summary>
        /// <param name="stringBuilder"></param>
        protected override void BuildFontInformation(StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine("<style type=\"text/css\">");
            stringBuilder.AppendLine(GetFontFaceDeclaration());
            stringBuilder.AppendLine("</style>");
        }

        protected override void BuildScoreElementWrapper(StringBuilder stringBuilder, StringBuilder scoreStringBuilder, Score score, string scoreElementName, Size calculatedScoreSize, double clippedAreaY)
        {
            stringBuilder.AppendLine(string.Format("<div><canvas id=\"{0}\" height=\"{1}\"></canvas>", scoreElementName, calculatedScoreSize.Height.ToStringInvariant()));
            stringBuilder.AppendLine("<script>");

            string scriptBody = @"(function() {
                        var canvas = document.getElementById('{0}'),
                        context = canvas.getContext('2d');

                        window.addEventListener('resize', resizeCanvas, false);
                        window.setTimeout(resizeCanvas, 200);
                        window.setTimeout(resizeCanvas, 2000);

                        function resizeCanvas() {
                                canvas.width = window.innerWidth;
                                drawScore(); 
                        }
                        resizeCanvas();

                        function drawScore() {
                                {1}
                        }
                    })();".Replace("{", "@@@").Replace("}", "***").Replace("@@@0***", "{0}").Replace("@@@1***", "{1}");
            scriptBody = string.Format(scriptBody, scoreElementName, scoreStringBuilder.ToString()).Replace("@@@", "{").Replace("***", "}");
            stringBuilder.AppendLine(scriptBody);
            stringBuilder.AppendLine("</script></div>");
        }

        /// <summary>
        /// Converts cancas to HTML string
        /// </summary>
        /// <param name="canvas"></param>
        /// <returns></returns>
        protected override string GetHtmlStringFromCanvas(StringBuilder canvas)
        {
            return canvas.ToString();
        }

        /// <summary>
        /// Returns a new instance of StringBuilder which will be used to build HTML canvas
        /// </summary>
        /// <returns></returns>
        public override StringBuilder CreateCanvas()
        {
            return new StringBuilder();
        }
    }
}
