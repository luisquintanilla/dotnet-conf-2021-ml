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

using Manufaktura.Controls.Model.Fonts;
using System;
using System.Collections.Generic;

namespace Manufaktura.Controls.Rendering.Implementations
{
    /// <summary>
    /// Width adjusting mode for HTML based score renderers
    /// </summary>
    public enum HtmlSizeHint
    {
        /// <summary>
        /// Not set
        /// </summary>
        None,

        /// <summary>
        /// Score will be rendered in fixed width. In SVG mode it will also have viewBox attribute.
        /// </summary>
        FixedWidth,

        /// <summary>
        /// Score will be rendered in 100% width
        /// </summary>
        Stretch
    }

    /// <summary>
    /// Score renderer settings for HTML based score renderers
    /// </summary>
    public class HtmlScoreRendererSettings : ScoreRendererSettings
    {
        public HtmlScoreRendererSettings()
        {
            Fonts = new Dictionary<MusicFontStyles, HtmlFontInfo>();
            RenderSurface = HtmlRenderSurface.Canvas;
            Height = 150;
            RenderingMode = ScoreRenderingModes.Panorama;
        }

        /// <summary>
        /// Render surface for HTML based score renderers
        /// </summary>
        public enum HtmlRenderSurface
        {
            /// <summary>
            /// Indicates that the score will be rendered on HTML Canvas
            /// </summary>
            Canvas,

            /// <summary>
            /// Indicates that the score will be renderer in SVG tag
            /// </summary>
            Svg
        }

        /// <summary>
        /// Font mappings
        /// </summary>
        public Dictionary<MusicFontStyles, HtmlFontInfo> Fonts { get; private set; }

        [Obsolete("Use ScoreClass property instead to set class of the score container and set height in css class definition. You can also use AddFullWidthStyle property to automatically generate css style.")]
        public double Height { get; set; }

        public bool IgnorePageMargins { get; set; }

        /// <summary>
        /// Moves all musical symbols a specific number of pixels to right. Used for improving readability of some music fonts.
        /// </summary>
        public double MusicalFontShiftX { get; set; }

        /// <summary>
        /// Moves all musical symbols a specigic number of pixels down. Used for improving readability of some music fonts.
        /// </summary>
        public double MusicalFontShiftY { get; set; }

        /// <summary>
        /// Default playback tempo for JS based MIDI players
        /// </summary>
        public int PlaybackTempo { get; set; } = 120;

        /// <summary>
        /// Render surface (Canvas or SVG)
        /// </summary>
        public HtmlRenderSurface RenderSurface { get; set; }

        public double Scale { get; set; } = 1d;

        /// <summary>
        /// Score CSS class
        /// </summary>
        public string ScoreClass { get; set; }

        /// <summary>
        /// Width adjusting mode
        /// </summary>
        public HtmlSizeHint SizeHint { get; set; } = HtmlSizeHint.FixedWidth;

        public void SetFont(MusicFontStyles style, string name, double size, params string[] fontFiles)
        {
            var fontInfo = new HtmlFontInfo(name, size, fontFiles);
            if (!Fonts.ContainsKey(style)) Fonts.Add(style, fontInfo);
            else Fonts[style] = fontInfo;
        }

        public void SetMusicFont(FontProfile musicFontProfile, string fontName, params string[] fontPaths)
        {
            SetMusicFontProfile(musicFontProfile);
            foreach (var fontSize in musicFontProfile.FontSizes)
                SetFont(fontSize.Key, fontName, fontSize.Value, fontPaths);
        }
    }
}