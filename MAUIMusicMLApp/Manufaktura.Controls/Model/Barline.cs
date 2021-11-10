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

using Manufaktura.Controls.Model.Assertions;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Controls.Rendering;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a barline.
    /// </summary>
    public class Barline : MusicalSymbol
    {
        private RepeatSignType repeatSign;

        /// <summary>
        /// Initializes a new instance of Barline.
        /// </summary>
        public Barline()
        {
            Location = HorizontalPlacement.Right;
            repeatSign = RepeatSignType.None;
        }

        /// <summary>
        /// Initializes a new instance of Barline with specific BarlineStyle
        /// </summary>
        public Barline(BarlineStyle style) : this()
        {
            Style = style;
        }

        /// <summary>
        /// Barline horizontal location
        /// </summary>
        public HorizontalPlacement Location { get; set; }

        public double RenderedXPositionForFirstStaffInMultiStaffPart { get; internal set; }

        /// <summary>
        /// Barline repeat sign
        /// </summary>
		public RepeatSignType RepeatSign { get { return repeatSign; } set { repeatSign = value; } }

        /// <summary>
        /// Barline style
        /// </summary>
		public BarlineStyle Style { get; set; } = BarlineStyle.Regular;

        public char GetCharacter(IMusicFont font)
        {
            if (RepeatSign == RepeatSignType.Backward) return font.RepeatBackward;
            else if (RepeatSign == RepeatSignType.Forward) return font.RepeatForward;
            else return '\0';
        }

        [Units(Units.Linespaces)]
        public BoundingBox GetSMuFLBoundingBox(ISMuFLFontMetadata metadata)
        {
            if (RepeatSign == RepeatSignType.Backward) return metadata.GlyphBBoxes.RepeatRight;
            else if (RepeatSign == RepeatSignType.Forward) return metadata.GlyphBBoxes.RepeatLeft;
            else return null;
        }

        [Units(Units.Pixels)]
        public BoundingBox GetSMuFLBoundingBoxPx(ISMuFLFontMetadata metadata, ScoreRendererSettings settings)
        {
            var bbox = GetSMuFLBoundingBox(metadata);
            return new BoundingBox
            {
                BBoxNe = new double[] { bbox.BBoxNe[0] * settings.LineSpacing, bbox.BBoxNe[1] * settings.LineSpacing },
                BBoxSw = new double[] { bbox.BBoxSw[0] * settings.LineSpacing, bbox.BBoxSw[1] * settings.LineSpacing }
            };
        }
    }
}