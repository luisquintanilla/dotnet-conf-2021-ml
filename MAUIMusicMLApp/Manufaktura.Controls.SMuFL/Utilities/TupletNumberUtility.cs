using Manufaktura.Controls.Model.SMuFL;
using System;
using System.Text;

namespace Manufaktura.Controls.SMuFL.Utilities
{
    public class TupletNumberUtility : NumberUtility
    {
        private readonly ISMuFLGlyphs glyphsInstance;
        public TupletNumberUtility(ISMuFLGlyphs glyphsInstance)
        {
            this.glyphsInstance = glyphsInstance;
        }

        public override string BuildNumber(int number)
        {
            var sb = new StringBuilder();
            var digits = number.ToString();
            foreach (var digit in digits)
            {
                if (digit == '0') sb.Append(glyphsInstance.Tuplet0.Character);
                if (digit == '1') sb.Append(glyphsInstance.Tuplet1.Character);
                if (digit == '2') sb.Append(glyphsInstance.Tuplet2.Character);
                if (digit == '3') sb.Append(glyphsInstance.Tuplet3.Character);
                if (digit == '4') sb.Append(glyphsInstance.Tuplet4.Character);
                if (digit == '5') sb.Append(glyphsInstance.Tuplet5.Character);
                if (digit == '6') sb.Append(glyphsInstance.Tuplet6.Character);
                if (digit == '7') sb.Append(glyphsInstance.Tuplet7.Character);
                if (digit == '8') sb.Append(glyphsInstance.Tuplet8.Character);
                if (digit == '9') sb.Append(glyphsInstance.Tuplet9.Character);
            }
            return sb.ToString();
        }

        public override BoundingBox GetBoundingBox(ISMuFLFontMetadata metadata, char digit)
        {
            if (digit == '0') return metadata.GlyphBBoxes.Tuplet0;
            if (digit == '1') return metadata.GlyphBBoxes.Tuplet1;
            if (digit == '2') return metadata.GlyphBBoxes.Tuplet2;
            if (digit == '3') return metadata.GlyphBBoxes.Tuplet3;
            if (digit == '4') return metadata.GlyphBBoxes.Tuplet4;
            if (digit == '5') return metadata.GlyphBBoxes.Tuplet5;
            if (digit == '6') return metadata.GlyphBBoxes.Tuplet6;
            if (digit == '7') return metadata.GlyphBBoxes.Tuplet7;
            if (digit == '8') return metadata.GlyphBBoxes.Tuplet8;
            if (digit == '9') return metadata.GlyphBBoxes.Tuplet9;
            throw new Exception($"Character {digit} is not a digit.");
        }
    }
}