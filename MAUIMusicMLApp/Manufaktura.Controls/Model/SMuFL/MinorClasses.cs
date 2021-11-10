using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Manufaktura.Controls.Model.SMuFL
{
    public partial class BoundingBox
    {
        [DataMember(Name = "bBoxNE")]
        public double[] BBoxNe { get; set; }

        [DataMember(Name = "bBoxSW")]
        public double[] BBoxSw { get; set; }
    }

    public partial class GlyphsWithAlternate
    {
        [DataMember(Name = "alternates")]
        public Alternate[] Alternates { get; set; }
    }

    public partial class Alternate
    {
        [DataMember(Name = "codepoint")]
        public string Codepoint { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
    }

    public partial class RepeatDefinition
    {
        [DataMember(Name = "repeatOffset")]
        public double[] RepeatOffset { get; set; }
    }

    public partial class Dynamic
    {
        [DataMember(Name = "opticalCenter")]
        public double[] OpticalCenter { get; set; }
    }

    public partial class GClefLigatedNumber
    {
        [DataMember(Name = "numeralBottom")]
        public double[] NumeralBottom { get; set; }
    }

    public partial class GlyphsWithAnchorsNoteheadCircleXDoubleWhole
    {
        [DataMember(Name = "noteheadOrigin")]
        public double[] NoteheadOrigin { get; set; }
    }

    public partial class Wiggle
    {
        [DataMember(Name = "repeatOffset")]
        public long[] RepeatOffset { get; set; }
    }

    public partial class Ligature
    {
        [DataMember(Name = "codepoint")]
        public string Codepoint { get; set; }

        [DataMember(Name = "componentGlyphs")]
        public string[] ComponentGlyphs { get; set; }
    }

    public partial class The4StringTabClefSerif
    {
        [DataMember(Name = "classes")]
        public string[] Classes { get; set; }

        [DataMember(Name = "codepoint")]
        public string Codepoint { get; set; }
    }

    public partial class AccidentalDoubleFlatParens
    {
        [DataMember(Name = "codepoint")]
        public string Codepoint { get; set; }
    }
}
