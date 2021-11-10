using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Manufaktura.Controls.Model.SMuFL
{
    public interface ISMuFLFontMetadata
    {
        [DataMember(Name = "fontName")]
        string FontName { get; }

        [DataMember(Name = "fontVersion")]
        double FontVersion { get; }

        [DataMember(Name = "engravingDefaults")]
        Dictionary<string, double> EngravingDefaults { get; }

        [DataMember(Name = "glyphBBoxes")]
        IGlyphBBoxes GlyphBBoxes { get; }

        [DataMember(Name = "glyphsWithAlternates")]
        Dictionary<string, GlyphsWithAlternate> GlyphsWithAlternates { get; }

        [DataMember(Name = "glyphsWithAnchors")]
        GlyphsWithAnchors GlyphsWithAnchors { get; }

        [DataMember(Name = "ligatures")]
        Dictionary<string, Ligature> Ligatures { get; }

        [DataMember(Name = "optionalGlyphs")]
        OptionalGlyphs OptionalGlyphs { get; }

        [DataMember(Name = "sets")]
        Dictionary<string, GlyphSet> Sets { get; }
    }
}