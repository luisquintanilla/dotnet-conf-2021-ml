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
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Rendering.Implementations
{
    public class Score2HtmlSvgBuilder : Score2HtmlBuilder<HtmlSvgScoreRenderer, XElement>
    {
        public Score2HtmlSvgBuilder(IEnumerable<Score> scores, string canvasPrefix, HtmlScoreRendererSettings settings)
        {
            if (string.IsNullOrWhiteSpace(canvasPrefix)) throw new ArgumentNullException("canvasPrefix");
            Scores = scores;
            CanvasPrefix = canvasPrefix;
            Settings = settings;
        }

        public Score2HtmlSvgBuilder(Score score, string canvasName, HtmlScoreRendererSettings settings)
            : this(new List<Score> { score }, canvasName, settings)
        {
        }

        /// <summary>
        /// Creates font styles declaration
        /// </summary>
        /// <param name="canvas"></param>
        protected override void BuildFontInformation(XElement canvas)
        {
            var element = new XElement("style", new XAttribute("type", "text/css"));
            element.Value = GetFontFaceDeclaration();
            canvas.Add(element);
        }

        protected override void BuildScoreElementWrapper(XElement canvas, XElement scoreCanvas, Score score, string scoreElementName, Size calculatedScoreSize, double clippedAreaY)
        {
			var wrapper = new XElement("svg");//,
			if (!string.IsNullOrWhiteSpace(Settings.ScoreClass)) wrapper.Add(new XAttribute("class", Settings.ScoreClass));
			canvas.Add(wrapper);
            foreach (var element in scoreCanvas.Elements())
            {
                wrapper.Add(element);
            }
			
			if (Settings.SizeHint == HtmlSizeHint.Stretch)
                wrapper.Add(new XAttribute("style", $"width:100%; height:{calculatedScoreSize.Height.ToStringInvariant()}px;"));
            else if (Settings.SizeHint ==  HtmlSizeHint.FixedWidth)
            {
                var antiClipStyle = clippedAreaY < 0 ? $" overflow: visible; margin-top:{(clippedAreaY * -1 * Settings.Scale).ToStringInvariant()}px;" : "";
                wrapper.Add(new XAttribute("style", $"width:{(calculatedScoreSize.Width * Settings.Scale).ToStringInvariant()}px; height:{(calculatedScoreSize.Height * Settings.Scale).ToStringInvariant()}px;{antiClipStyle}"));
                wrapper.Add(new XAttribute("viewBox", $"0 0 {calculatedScoreSize.Width.ToStringInvariant()} {calculatedScoreSize.Height.ToStringInvariant()}"));
            }
        }

        protected override string GetHtmlStringFromCanvas(XElement canvas)
        {
            var sb = new StringBuilder();
            foreach (var element in canvas.Elements())
            {
                sb.Append(element.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Creates a new XElement instance which will be used to render SVG
        /// </summary>
        /// <returns></returns>
        public override XElement CreateCanvas()
        {
            return new XElement("root");
        }
    }
}
