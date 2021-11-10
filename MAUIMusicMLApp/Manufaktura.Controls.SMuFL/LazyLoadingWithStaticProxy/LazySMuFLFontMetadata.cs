using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Core.Serialization;
using System.Collections.Generic;

namespace Manufaktura.Controls.SMuFL.LazyLoadingWithStaticProxy
{
    public class LazySMuFLFontMetadata : LazyLoadJsonStaticProxy<ISMuFLFontMetadata>, ISMuFLFontMetadata
    {
        public LazySMuFLFontMetadata(string jsonString) : base(jsonString, new[] {typeof(LazySMuFLFontMetadata), typeof(LazySMuFLGlyphs), typeof(LazyGlyphBBoxes) })
        {
        }

        public string FontName => Load() as string;

        public double FontVersion => (double)Load();

        public Dictionary<string, double> EngravingDefaults => Load() as Dictionary<string, double>;

        public IGlyphBBoxes GlyphBBoxes => Load() as IGlyphBBoxes;

        public Dictionary<string, GlyphsWithAlternate> GlyphsWithAlternates => Load() as Dictionary<string, GlyphsWithAlternate>;

        public GlyphsWithAnchors GlyphsWithAnchors => Load() as GlyphsWithAnchors;

        public Dictionary<string, Ligature> Ligatures => Load() as Dictionary<string, Ligature>;

        public OptionalGlyphs OptionalGlyphs => Load() as OptionalGlyphs;

        public Dictionary<string, GlyphSet> Sets => Load() as Dictionary<string, GlyphSet>;
    }
}