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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering.Implementations
{
    /// <summary>
    /// Renders Scores in HTML format
    /// </summary>
    /// <typeparam name="TRenderer">Score renderer type</typeparam>
    /// <typeparam name="TCanvas">Canvas type</typeparam>
    public abstract class Score2HtmlBuilder<TRenderer, TCanvas> : IScore2HtmlBuilder where TRenderer : HtmlScoreRenderer<TCanvas>, new()
    {
        /// <summary>
        /// Scores to render
        /// </summary>
        public IEnumerable<Score> Scores { get; protected set; }
        public string CanvasPrefix { get; protected set; }
        public HtmlScoreRendererSettings Settings { get; protected set; }

        private readonly FontFormat[] fontFormats = new FontFormat[] {
            new FontFormat("ttf", "truetype", false),
            new FontFormat("woff", "woff", false),
            new FontFormat("woff2", "woff2", false),
            new FontFormat("otf", "opentype", false),
            new FontFormat("svg", "svg", true)
        };

        protected abstract void BuildFontInformation(TCanvas canvas);
        protected abstract void BuildScoreElementWrapper(TCanvas canvas, TCanvas scoreCanvas, Score score, string scoreElementName, Size calculatedScoreSize, double clippedAreaY);
        protected abstract string GetHtmlStringFromCanvas(TCanvas canvas);
        public abstract TCanvas CreateCanvas();

        public string Build()
        {
            TCanvas canvas = CreateCanvas();
            BuildFontInformation(canvas);

            int count = Scores.Count();
            for (int i = 0; i < count; i++)
            {
                string canvasName = count == 1 ? CanvasPrefix : string.Format("{0}{1}", CanvasPrefix, i);

                TCanvas scoreCanvas = CreateCanvas();
                var renderer = new TRenderer()
                {
                    Canvas = scoreCanvas,
                    ScoreElementName = canvasName,
                    Settings = this.Settings
                };
                var score = Scores.ElementAt(i);
                renderer.Render(score);

                BuildScoreElementWrapper(canvas, scoreCanvas, score, canvasName, new Size(renderer.ActualWidth + 20, renderer.ActualHeight + 20), renderer.ClippedAreaY);
            }
            return GetHtmlStringFromCanvas(canvas);
        }

        protected FontFormat GetFontFormatFromUri(string uri)
        {
            return fontFormats.FirstOrDefault(ff => uri.EndsWith(ff.Extension, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Builds CSS @font-face declaration
        /// </summary>
        /// <returns></returns>
        protected string GetFontFaceDeclaration()
        {
            var stringBuilder = new StringBuilder();
            Dictionary<string, List<string>> fontFaceDictionary = new Dictionary<string, List<string>>();
            foreach (var font in Settings.Fonts.Values)
            {
                if (!fontFaceDictionary.ContainsKey(font.Name)) fontFaceDictionary.Add(font.Name, font.Uris);
            }
            foreach (var fontFace in fontFaceDictionary)
            {
                stringBuilder.AppendLine("@font-face {");
                stringBuilder.AppendLine(string.Format("font-family: '{0}';", fontFace.Key));
                stringBuilder.Append("src: ");
                bool first = true;
                foreach (var uri in fontFace.Value)
                {
                    if (!first) stringBuilder.AppendLine(", ");
                    var fontFormat = GetFontFormatFromUri(uri);
                    stringBuilder.Append(string.Format("url('{0}{1}') format('{2}') ",
                        uri,
                        fontFormat.CanHaveMultipleFonts ? "#" + fontFace.Key : "",
                        fontFormat.FormatName));
                    first = false;
                }
                stringBuilder.AppendLine("}");
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Font format information used for building CSS font-face declarations
        /// </summary>
        public class FontFormat
        {
            public string Extension { get; set; }
            public string FormatName { get; set; }
            public bool CanHaveMultipleFonts { get; set; }

            public FontFormat(string extension, string name, bool canHaveMultipleFonts)
            {
                Extension = extension;
                FormatName = name;
                CanHaveMultipleFonts = canHaveMultipleFonts;
            }
        }
    }
}
