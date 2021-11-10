using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Manufaktura.Controls.Model.SMuFL
{
    public interface IGlyphBBoxes
    {
        [DataMember(Name = "4stringTabClef")]
        BoundingBox The4StringTabClef { get; }

        [DataMember(Name = "4stringTabClefSerif")]
        BoundingBox The4StringTabClefSerif { get; }

        [DataMember(Name = "4stringTabClefTall")]
        BoundingBox The4StringTabClefTall { get; }

        [DataMember(Name = "6stringTabClef")]
        BoundingBox The6StringTabClef { get; }

        [DataMember(Name = "6stringTabClefSerif")]
        BoundingBox The6StringTabClefSerif { get; }

        [DataMember(Name = "6stringTabClefTall")]
        BoundingBox The6StringTabClefTall { get; }

        [DataMember(Name = "accSagittal11LargeDiesisDown")]
        BoundingBox AccSagittal11LargeDiesisDown { get; }

        [DataMember(Name = "accSagittal11LargeDiesisUp")]
        BoundingBox AccSagittal11LargeDiesisUp { get; }

        [DataMember(Name = "accSagittal11MediumDiesisDown")]
        BoundingBox AccSagittal11MediumDiesisDown { get; }

        [DataMember(Name = "accSagittal11MediumDiesisUp")]
        BoundingBox AccSagittal11MediumDiesisUp { get; }

        [DataMember(Name = "accSagittal11v19LargeDiesisDown")]
        BoundingBox AccSagittal11V19LargeDiesisDown { get; }

        [DataMember(Name = "accSagittal11v19LargeDiesisUp")]
        BoundingBox AccSagittal11V19LargeDiesisUp { get; }

        [DataMember(Name = "accSagittal11v19MediumDiesisDown")]
        BoundingBox AccSagittal11V19MediumDiesisDown { get; }

        [DataMember(Name = "accSagittal11v19MediumDiesisUp")]
        BoundingBox AccSagittal11V19MediumDiesisUp { get; }

        [DataMember(Name = "accSagittal11v49CommaDown")]
        BoundingBox AccSagittal11V49CommaDown { get; }

        [DataMember(Name = "accSagittal11v49CommaUp")]
        BoundingBox AccSagittal11V49CommaUp { get; }

        [DataMember(Name = "accSagittal143CommaDown")]
        BoundingBox AccSagittal143CommaDown { get; }

        [DataMember(Name = "accSagittal143CommaUp")]
        BoundingBox AccSagittal143CommaUp { get; }

        [DataMember(Name = "accSagittal17CommaDown")]
        BoundingBox AccSagittal17CommaDown { get; }

        [DataMember(Name = "accSagittal17CommaUp")]
        BoundingBox AccSagittal17CommaUp { get; }

        [DataMember(Name = "accSagittal17KleismaDown")]
        BoundingBox AccSagittal17KleismaDown { get; }

        [DataMember(Name = "accSagittal17KleismaUp")]
        BoundingBox AccSagittal17KleismaUp { get; }

        [DataMember(Name = "accSagittal19CommaDown")]
        BoundingBox AccSagittal19CommaDown { get; }

        [DataMember(Name = "accSagittal19CommaUp")]
        BoundingBox AccSagittal19CommaUp { get; }

        [DataMember(Name = "accSagittal19SchismaDown")]
        BoundingBox AccSagittal19SchismaDown { get; }

        [DataMember(Name = "accSagittal19SchismaUp")]
        BoundingBox AccSagittal19SchismaUp { get; }

        [DataMember(Name = "accSagittal23CommaDown")]
        BoundingBox AccSagittal23CommaDown { get; }

        [DataMember(Name = "accSagittal23CommaUp")]
        BoundingBox AccSagittal23CommaUp { get; }

        [DataMember(Name = "accSagittal23SmallDiesisDown")]
        BoundingBox AccSagittal23SmallDiesisDown { get; }

        [DataMember(Name = "accSagittal23SmallDiesisUp")]
        BoundingBox AccSagittal23SmallDiesisUp { get; }

        [DataMember(Name = "accSagittal25SmallDiesisDown")]
        BoundingBox AccSagittal25SmallDiesisDown { get; }

        [DataMember(Name = "accSagittal25SmallDiesisUp")]
        BoundingBox AccSagittal25SmallDiesisUp { get; }

        [DataMember(Name = "accSagittal35LargeDiesisDown")]
        BoundingBox AccSagittal35LargeDiesisDown { get; }

        [DataMember(Name = "accSagittal35LargeDiesisUp")]
        BoundingBox AccSagittal35LargeDiesisUp { get; }

        [DataMember(Name = "accSagittal35MediumDiesisDown")]
        BoundingBox AccSagittal35MediumDiesisDown { get; }

        [DataMember(Name = "accSagittal35MediumDiesisUp")]
        BoundingBox AccSagittal35MediumDiesisUp { get; }

        [DataMember(Name = "accSagittal49LargeDiesisDown")]
        BoundingBox AccSagittal49LargeDiesisDown { get; }

        [DataMember(Name = "accSagittal49LargeDiesisUp")]
        BoundingBox AccSagittal49LargeDiesisUp { get; }

        [DataMember(Name = "accSagittal49MediumDiesisDown")]
        BoundingBox AccSagittal49MediumDiesisDown { get; }

        [DataMember(Name = "accSagittal49MediumDiesisUp")]
        BoundingBox AccSagittal49MediumDiesisUp { get; }

        [DataMember(Name = "accSagittal49SmallDiesisDown")]
        BoundingBox AccSagittal49SmallDiesisDown { get; }

        [DataMember(Name = "accSagittal49SmallDiesisUp")]
        BoundingBox AccSagittal49SmallDiesisUp { get; }

        [DataMember(Name = "accSagittal55CommaDown")]
        BoundingBox AccSagittal55CommaDown { get; }

        [DataMember(Name = "accSagittal55CommaUp")]
        BoundingBox AccSagittal55CommaUp { get; }

        [DataMember(Name = "accSagittal5CommaDown")]
        BoundingBox AccSagittal5CommaDown { get; }

        [DataMember(Name = "accSagittal5CommaUp")]
        BoundingBox AccSagittal5CommaUp { get; }

        [DataMember(Name = "accSagittal5v11SmallDiesisDown")]
        BoundingBox AccSagittal5V11SmallDiesisDown { get; }

        [DataMember(Name = "accSagittal5v11SmallDiesisUp")]
        BoundingBox AccSagittal5V11SmallDiesisUp { get; }

        [DataMember(Name = "accSagittal5v13LargeDiesisDown")]
        BoundingBox AccSagittal5V13LargeDiesisDown { get; }

        [DataMember(Name = "accSagittal5v13LargeDiesisUp")]
        BoundingBox AccSagittal5V13LargeDiesisUp { get; }

        [DataMember(Name = "accSagittal5v13MediumDiesisDown")]
        BoundingBox AccSagittal5V13MediumDiesisDown { get; }

        [DataMember(Name = "accSagittal5v13MediumDiesisUp")]
        BoundingBox AccSagittal5V13MediumDiesisUp { get; }

        [DataMember(Name = "accSagittal5v19CommaDown")]
        BoundingBox AccSagittal5V19CommaDown { get; }

        [DataMember(Name = "accSagittal5v19CommaUp")]
        BoundingBox AccSagittal5V19CommaUp { get; }

        [DataMember(Name = "accSagittal5v23SmallDiesisDown")]
        BoundingBox AccSagittal5V23SmallDiesisDown { get; }

        [DataMember(Name = "accSagittal5v23SmallDiesisUp")]
        BoundingBox AccSagittal5V23SmallDiesisUp { get; }

        [DataMember(Name = "accSagittal5v49MediumDiesisDown")]
        BoundingBox AccSagittal5V49MediumDiesisDown { get; }

        [DataMember(Name = "accSagittal5v49MediumDiesisUp")]
        BoundingBox AccSagittal5V49MediumDiesisUp { get; }

        [DataMember(Name = "accSagittal5v7KleismaDown")]
        BoundingBox AccSagittal5V7KleismaDown { get; }

        [DataMember(Name = "accSagittal5v7KleismaUp")]
        BoundingBox AccSagittal5V7KleismaUp { get; }

        [DataMember(Name = "accSagittal7CommaDown")]
        BoundingBox AccSagittal7CommaDown { get; }

        [DataMember(Name = "accSagittal7CommaUp")]
        BoundingBox AccSagittal7CommaUp { get; }

        [DataMember(Name = "accSagittal7v11CommaDown")]
        BoundingBox AccSagittal7V11CommaDown { get; }

        [DataMember(Name = "accSagittal7v11CommaUp")]
        BoundingBox AccSagittal7V11CommaUp { get; }

        [DataMember(Name = "accSagittal7v11KleismaDown")]
        BoundingBox AccSagittal7V11KleismaDown { get; }

        [DataMember(Name = "accSagittal7v11KleismaUp")]
        BoundingBox AccSagittal7V11KleismaUp { get; }

        [DataMember(Name = "accSagittal7v19CommaDown")]
        BoundingBox AccSagittal7V19CommaDown { get; }

        [DataMember(Name = "accSagittal7v19CommaUp")]
        BoundingBox AccSagittal7V19CommaUp { get; }

        [DataMember(Name = "accSagittalAcute")]
        BoundingBox AccSagittalAcute { get; }

        [DataMember(Name = "accSagittalDoubleFlat")]
        BoundingBox AccSagittalDoubleFlat { get; }

        [DataMember(Name = "accSagittalDoubleFlat11v49CUp")]
        BoundingBox AccSagittalDoubleFlat11V49CUp { get; }

        [DataMember(Name = "accSagittalDoubleFlat143CUp")]
        BoundingBox AccSagittalDoubleFlat143CUp { get; }

        [DataMember(Name = "accSagittalDoubleFlat17CUp")]
        BoundingBox AccSagittalDoubleFlat17CUp { get; }

        [DataMember(Name = "accSagittalDoubleFlat17kUp")]
        BoundingBox AccSagittalDoubleFlat17KUp { get; }

        [DataMember(Name = "accSagittalDoubleFlat19CUp")]
        BoundingBox AccSagittalDoubleFlat19CUp { get; }

        [DataMember(Name = "accSagittalDoubleFlat19sUp")]
        BoundingBox AccSagittalDoubleFlat19SUp { get; }

        [DataMember(Name = "accSagittalDoubleFlat23CUp")]
        BoundingBox AccSagittalDoubleFlat23CUp { get; }

        [DataMember(Name = "accSagittalDoubleFlat23SUp")]
        BoundingBox AccSagittalDoubleFlat23SUp { get; }

        [DataMember(Name = "accSagittalDoubleFlat25SUp")]
        BoundingBox AccSagittalDoubleFlat25SUp { get; }

        [DataMember(Name = "accSagittalDoubleFlat49SUp")]
        BoundingBox AccSagittalDoubleFlat49SUp { get; }

        [DataMember(Name = "accSagittalDoubleFlat55CUp")]
        BoundingBox AccSagittalDoubleFlat55CUp { get; }

        [DataMember(Name = "accSagittalDoubleFlat5CUp")]
        BoundingBox AccSagittalDoubleFlat5CUp { get; }

        [DataMember(Name = "accSagittalDoubleFlat5v11SUp")]
        BoundingBox AccSagittalDoubleFlat5V11SUp { get; }

        [DataMember(Name = "accSagittalDoubleFlat5v19CUp")]
        BoundingBox AccSagittalDoubleFlat5V19CUp { get; }

        [DataMember(Name = "accSagittalDoubleFlat5v23SUp")]
        BoundingBox AccSagittalDoubleFlat5V23SUp { get; }

        [DataMember(Name = "accSagittalDoubleFlat5v7kUp")]
        BoundingBox AccSagittalDoubleFlat5V7KUp { get; }

        [DataMember(Name = "accSagittalDoubleFlat7CUp")]
        BoundingBox AccSagittalDoubleFlat7CUp { get; }

        [DataMember(Name = "accSagittalDoubleFlat7v11CUp")]
        BoundingBox AccSagittalDoubleFlat7V11CUp { get; }

        [DataMember(Name = "accSagittalDoubleFlat7v11kUp")]
        BoundingBox AccSagittalDoubleFlat7V11KUp { get; }

        [DataMember(Name = "accSagittalDoubleFlat7v19CUp")]
        BoundingBox AccSagittalDoubleFlat7V19CUp { get; }

        [DataMember(Name = "accSagittalDoubleSharp")]
        BoundingBox AccSagittalDoubleSharp { get; }

        [DataMember(Name = "accSagittalDoubleSharp11v49CDown")]
        BoundingBox AccSagittalDoubleSharp11V49CDown { get; }

        [DataMember(Name = "accSagittalDoubleSharp143CDown")]
        BoundingBox AccSagittalDoubleSharp143CDown { get; }

        [DataMember(Name = "accSagittalDoubleSharp17CDown")]
        BoundingBox AccSagittalDoubleSharp17CDown { get; }

        [DataMember(Name = "accSagittalDoubleSharp17kDown")]
        BoundingBox AccSagittalDoubleSharp17KDown { get; }

        [DataMember(Name = "accSagittalDoubleSharp19CDown")]
        BoundingBox AccSagittalDoubleSharp19CDown { get; }

        [DataMember(Name = "accSagittalDoubleSharp19sDown")]
        BoundingBox AccSagittalDoubleSharp19SDown { get; }

        [DataMember(Name = "accSagittalDoubleSharp23CDown")]
        BoundingBox AccSagittalDoubleSharp23CDown { get; }

        [DataMember(Name = "accSagittalDoubleSharp23SDown")]
        BoundingBox AccSagittalDoubleSharp23SDown { get; }

        [DataMember(Name = "accSagittalDoubleSharp25SDown")]
        BoundingBox AccSagittalDoubleSharp25SDown { get; }

        [DataMember(Name = "accSagittalDoubleSharp49SDown")]
        BoundingBox AccSagittalDoubleSharp49SDown { get; }

        [DataMember(Name = "accSagittalDoubleSharp55CDown")]
        BoundingBox AccSagittalDoubleSharp55CDown { get; }

        [DataMember(Name = "accSagittalDoubleSharp5CDown")]
        BoundingBox AccSagittalDoubleSharp5CDown { get; }

        [DataMember(Name = "accSagittalDoubleSharp5v11SDown")]
        BoundingBox AccSagittalDoubleSharp5V11SDown { get; }

        [DataMember(Name = "accSagittalDoubleSharp5v19CDown")]
        BoundingBox AccSagittalDoubleSharp5V19CDown { get; }

        [DataMember(Name = "accSagittalDoubleSharp5v23SDown")]
        BoundingBox AccSagittalDoubleSharp5V23SDown { get; }

        [DataMember(Name = "accSagittalDoubleSharp5v7kDown")]
        BoundingBox AccSagittalDoubleSharp5V7KDown { get; }

        [DataMember(Name = "accSagittalDoubleSharp7CDown")]
        BoundingBox AccSagittalDoubleSharp7CDown { get; }

        [DataMember(Name = "accSagittalDoubleSharp7v11CDown")]
        BoundingBox AccSagittalDoubleSharp7V11CDown { get; }

        [DataMember(Name = "accSagittalDoubleSharp7v11kDown")]
        BoundingBox AccSagittalDoubleSharp7V11KDown { get; }

        [DataMember(Name = "accSagittalDoubleSharp7v19CDown")]
        BoundingBox AccSagittalDoubleSharp7V19CDown { get; }

        [DataMember(Name = "accSagittalFlat")]
        BoundingBox AccSagittalFlat { get; }

        [DataMember(Name = "accSagittalFlat11LDown")]
        BoundingBox AccSagittalFlat11LDown { get; }

        [DataMember(Name = "accSagittalFlat11MDown")]
        BoundingBox AccSagittalFlat11MDown { get; }

        [DataMember(Name = "accSagittalFlat11v19LDown")]
        BoundingBox AccSagittalFlat11V19LDown { get; }

        [DataMember(Name = "accSagittalFlat11v19MDown")]
        BoundingBox AccSagittalFlat11V19MDown { get; }

        [DataMember(Name = "accSagittalFlat11v49CDown")]
        BoundingBox AccSagittalFlat11V49CDown { get; }

        [DataMember(Name = "accSagittalFlat11v49CUp")]
        BoundingBox AccSagittalFlat11V49CUp { get; }

        [DataMember(Name = "accSagittalFlat143CDown")]
        BoundingBox AccSagittalFlat143CDown { get; }

        [DataMember(Name = "accSagittalFlat143CUp")]
        BoundingBox AccSagittalFlat143CUp { get; }

        [DataMember(Name = "accSagittalFlat17CDown")]
        BoundingBox AccSagittalFlat17CDown { get; }

        [DataMember(Name = "accSagittalFlat17CUp")]
        BoundingBox AccSagittalFlat17CUp { get; }

        [DataMember(Name = "accSagittalFlat17kDown")]
        BoundingBox AccSagittalFlat17KDown { get; }

        [DataMember(Name = "accSagittalFlat17kUp")]
        BoundingBox AccSagittalFlat17KUp { get; }

        [DataMember(Name = "accSagittalFlat19CDown")]
        BoundingBox AccSagittalFlat19CDown { get; }

        [DataMember(Name = "accSagittalFlat19CUp")]
        BoundingBox AccSagittalFlat19CUp { get; }

        [DataMember(Name = "accSagittalFlat19sDown")]
        BoundingBox AccSagittalFlat19SDown { get; }

        [DataMember(Name = "accSagittalFlat19sUp")]
        BoundingBox AccSagittalFlat19SUp { get; }

        [DataMember(Name = "accSagittalFlat23CDown")]
        BoundingBox AccSagittalFlat23CDown { get; }

        [DataMember(Name = "accSagittalFlat23CUp")]
        BoundingBox AccSagittalFlat23CUp { get; }

        [DataMember(Name = "accSagittalFlat23SDown")]
        BoundingBox AccSagittalFlat23SDown { get; }

        [DataMember(Name = "accSagittalFlat23SUp")]
        BoundingBox AccSagittalFlat23SUp { get; }

        [DataMember(Name = "accSagittalFlat25SDown")]
        BoundingBox AccSagittalFlat25SDown { get; }

        [DataMember(Name = "accSagittalFlat25SUp")]
        BoundingBox AccSagittalFlat25SUp { get; }

        [DataMember(Name = "accSagittalFlat35LDown")]
        BoundingBox AccSagittalFlat35LDown { get; }

        [DataMember(Name = "accSagittalFlat35MDown")]
        BoundingBox AccSagittalFlat35MDown { get; }

        [DataMember(Name = "accSagittalFlat49LDown")]
        BoundingBox AccSagittalFlat49LDown { get; }

        [DataMember(Name = "accSagittalFlat49MDown")]
        BoundingBox AccSagittalFlat49MDown { get; }

        [DataMember(Name = "accSagittalFlat49SDown")]
        BoundingBox AccSagittalFlat49SDown { get; }

        [DataMember(Name = "accSagittalFlat49SUp")]
        BoundingBox AccSagittalFlat49SUp { get; }

        [DataMember(Name = "accSagittalFlat55CDown")]
        BoundingBox AccSagittalFlat55CDown { get; }

        [DataMember(Name = "accSagittalFlat55CUp")]
        BoundingBox AccSagittalFlat55CUp { get; }

        [DataMember(Name = "accSagittalFlat5CDown")]
        BoundingBox AccSagittalFlat5CDown { get; }

        [DataMember(Name = "accSagittalFlat5CUp")]
        BoundingBox AccSagittalFlat5CUp { get; }

        [DataMember(Name = "accSagittalFlat5v11SDown")]
        BoundingBox AccSagittalFlat5V11SDown { get; }

        [DataMember(Name = "accSagittalFlat5v11SUp")]
        BoundingBox AccSagittalFlat5V11SUp { get; }

        [DataMember(Name = "accSagittalFlat5v13LDown")]
        BoundingBox AccSagittalFlat5V13LDown { get; }

        [DataMember(Name = "accSagittalFlat5v13MDown")]
        BoundingBox AccSagittalFlat5V13MDown { get; }

        [DataMember(Name = "accSagittalFlat5v19CDown")]
        BoundingBox AccSagittalFlat5V19CDown { get; }

        [DataMember(Name = "accSagittalFlat5v19CUp")]
        BoundingBox AccSagittalFlat5V19CUp { get; }

        [DataMember(Name = "accSagittalFlat5v23SDown")]
        BoundingBox AccSagittalFlat5V23SDown { get; }

        [DataMember(Name = "accSagittalFlat5v23SUp")]
        BoundingBox AccSagittalFlat5V23SUp { get; }

        [DataMember(Name = "accSagittalFlat5v49MDown")]
        BoundingBox AccSagittalFlat5V49MDown { get; }

        [DataMember(Name = "accSagittalFlat5v7kDown")]
        BoundingBox AccSagittalFlat5V7KDown { get; }

        [DataMember(Name = "accSagittalFlat5v7kUp")]
        BoundingBox AccSagittalFlat5V7KUp { get; }

        [DataMember(Name = "accSagittalFlat7CDown")]
        BoundingBox AccSagittalFlat7CDown { get; }

        [DataMember(Name = "accSagittalFlat7CUp")]
        BoundingBox AccSagittalFlat7CUp { get; }

        [DataMember(Name = "accSagittalFlat7v11CDown")]
        BoundingBox AccSagittalFlat7V11CDown { get; }

        [DataMember(Name = "accSagittalFlat7v11CUp")]
        BoundingBox AccSagittalFlat7V11CUp { get; }

        [DataMember(Name = "accSagittalFlat7v11kDown")]
        BoundingBox AccSagittalFlat7V11KDown { get; }

        [DataMember(Name = "accSagittalFlat7v11kUp")]
        BoundingBox AccSagittalFlat7V11KUp { get; }

        [DataMember(Name = "accSagittalFlat7v19CDown")]
        BoundingBox AccSagittalFlat7V19CDown { get; }

        [DataMember(Name = "accSagittalFlat7v19CUp")]
        BoundingBox AccSagittalFlat7V19CUp { get; }

        [DataMember(Name = "accSagittalGrave")]
        BoundingBox AccSagittalGrave { get; }

        [DataMember(Name = "accSagittalShaftDown")]
        BoundingBox AccSagittalShaftDown { get; }

        [DataMember(Name = "accSagittalShaftUp")]
        BoundingBox AccSagittalShaftUp { get; }

        [DataMember(Name = "accSagittalSharp")]
        BoundingBox AccSagittalSharp { get; }

        [DataMember(Name = "accSagittalSharp11LUp")]
        BoundingBox AccSagittalSharp11LUp { get; }

        [DataMember(Name = "accSagittalSharp11MUp")]
        BoundingBox AccSagittalSharp11MUp { get; }

        [DataMember(Name = "accSagittalSharp11v19LUp")]
        BoundingBox AccSagittalSharp11V19LUp { get; }

        [DataMember(Name = "accSagittalSharp11v19MUp")]
        BoundingBox AccSagittalSharp11V19MUp { get; }

        [DataMember(Name = "accSagittalSharp11v49CDown")]
        BoundingBox AccSagittalSharp11V49CDown { get; }

        [DataMember(Name = "accSagittalSharp11v49CUp")]
        BoundingBox AccSagittalSharp11V49CUp { get; }

        [DataMember(Name = "accSagittalSharp143CDown")]
        BoundingBox AccSagittalSharp143CDown { get; }

        [DataMember(Name = "accSagittalSharp143CUp")]
        BoundingBox AccSagittalSharp143CUp { get; }

        [DataMember(Name = "accSagittalSharp17CDown")]
        BoundingBox AccSagittalSharp17CDown { get; }

        [DataMember(Name = "accSagittalSharp17CUp")]
        BoundingBox AccSagittalSharp17CUp { get; }

        [DataMember(Name = "accSagittalSharp17kDown")]
        BoundingBox AccSagittalSharp17KDown { get; }

        [DataMember(Name = "accSagittalSharp17kUp")]
        BoundingBox AccSagittalSharp17KUp { get; }

        [DataMember(Name = "accSagittalSharp19CDown")]
        BoundingBox AccSagittalSharp19CDown { get; }

        [DataMember(Name = "accSagittalSharp19CUp")]
        BoundingBox AccSagittalSharp19CUp { get; }

        [DataMember(Name = "accSagittalSharp19sDown")]
        BoundingBox AccSagittalSharp19SDown { get; }

        [DataMember(Name = "accSagittalSharp19sUp")]
        BoundingBox AccSagittalSharp19SUp { get; }

        [DataMember(Name = "accSagittalSharp23CDown")]
        BoundingBox AccSagittalSharp23CDown { get; }

        [DataMember(Name = "accSagittalSharp23CUp")]
        BoundingBox AccSagittalSharp23CUp { get; }

        [DataMember(Name = "accSagittalSharp23SDown")]
        BoundingBox AccSagittalSharp23SDown { get; }

        [DataMember(Name = "accSagittalSharp23SUp")]
        BoundingBox AccSagittalSharp23SUp { get; }

        [DataMember(Name = "accSagittalSharp25SDown")]
        BoundingBox AccSagittalSharp25SDown { get; }

        [DataMember(Name = "accSagittalSharp25SUp")]
        BoundingBox AccSagittalSharp25SUp { get; }

        [DataMember(Name = "accSagittalSharp35LUp")]
        BoundingBox AccSagittalSharp35LUp { get; }

        [DataMember(Name = "accSagittalSharp35MUp")]
        BoundingBox AccSagittalSharp35MUp { get; }

        [DataMember(Name = "accSagittalSharp49LUp")]
        BoundingBox AccSagittalSharp49LUp { get; }

        [DataMember(Name = "accSagittalSharp49MUp")]
        BoundingBox AccSagittalSharp49MUp { get; }

        [DataMember(Name = "accSagittalSharp49SDown")]
        BoundingBox AccSagittalSharp49SDown { get; }

        [DataMember(Name = "accSagittalSharp49SUp")]
        BoundingBox AccSagittalSharp49SUp { get; }

        [DataMember(Name = "accSagittalSharp55CDown")]
        BoundingBox AccSagittalSharp55CDown { get; }

        [DataMember(Name = "accSagittalSharp55CUp")]
        BoundingBox AccSagittalSharp55CUp { get; }

        [DataMember(Name = "accSagittalSharp5CDown")]
        BoundingBox AccSagittalSharp5CDown { get; }

        [DataMember(Name = "accSagittalSharp5CUp")]
        BoundingBox AccSagittalSharp5CUp { get; }

        [DataMember(Name = "accSagittalSharp5v11SDown")]
        BoundingBox AccSagittalSharp5V11SDown { get; }

        [DataMember(Name = "accSagittalSharp5v11SUp")]
        BoundingBox AccSagittalSharp5V11SUp { get; }

        [DataMember(Name = "accSagittalSharp5v13LUp")]
        BoundingBox AccSagittalSharp5V13LUp { get; }

        [DataMember(Name = "accSagittalSharp5v13MUp")]
        BoundingBox AccSagittalSharp5V13MUp { get; }

        [DataMember(Name = "accSagittalSharp5v19CDown")]
        BoundingBox AccSagittalSharp5V19CDown { get; }

        [DataMember(Name = "accSagittalSharp5v19CUp")]
        BoundingBox AccSagittalSharp5V19CUp { get; }

        [DataMember(Name = "accSagittalSharp5v23SDown")]
        BoundingBox AccSagittalSharp5V23SDown { get; }

        [DataMember(Name = "accSagittalSharp5v23SUp")]
        BoundingBox AccSagittalSharp5V23SUp { get; }

        [DataMember(Name = "accSagittalSharp5v49MUp")]
        BoundingBox AccSagittalSharp5V49MUp { get; }

        [DataMember(Name = "accSagittalSharp5v7kDown")]
        BoundingBox AccSagittalSharp5V7KDown { get; }

        [DataMember(Name = "accSagittalSharp5v7kUp")]
        BoundingBox AccSagittalSharp5V7KUp { get; }

        [DataMember(Name = "accSagittalSharp7CDown")]
        BoundingBox AccSagittalSharp7CDown { get; }

        [DataMember(Name = "accSagittalSharp7CUp")]
        BoundingBox AccSagittalSharp7CUp { get; }

        [DataMember(Name = "accSagittalSharp7v11CDown")]
        BoundingBox AccSagittalSharp7V11CDown { get; }

        [DataMember(Name = "accSagittalSharp7v11CUp")]
        BoundingBox AccSagittalSharp7V11CUp { get; }

        [DataMember(Name = "accSagittalSharp7v11kDown")]
        BoundingBox AccSagittalSharp7V11KDown { get; }

        [DataMember(Name = "accSagittalSharp7v11kUp")]
        BoundingBox AccSagittalSharp7V11KUp { get; }

        [DataMember(Name = "accSagittalSharp7v19CDown")]
        BoundingBox AccSagittalSharp7V19CDown { get; }

        [DataMember(Name = "accSagittalSharp7v19CUp")]
        BoundingBox AccSagittalSharp7V19CUp { get; }

        [DataMember(Name = "accdnCombDot")]
        BoundingBox AccdnCombDot { get; }

        [DataMember(Name = "accdnCombLH2RanksEmpty")]
        BoundingBox AccdnCombLh2RanksEmpty { get; }

        [DataMember(Name = "accdnCombLH3RanksEmptySquare")]
        BoundingBox AccdnCombLh3RanksEmptySquare { get; }

        [DataMember(Name = "accdnCombRH3RanksEmpty")]
        BoundingBox AccdnCombRh3RanksEmpty { get; }

        [DataMember(Name = "accdnCombRH4RanksEmpty")]
        BoundingBox AccdnCombRh4RanksEmpty { get; }

        [DataMember(Name = "accdnDiatonicClef")]
        BoundingBox AccdnDiatonicClef { get; }

        [DataMember(Name = "accdnLH2Ranks16Round")]
        BoundingBox AccdnLh2Ranks16Round { get; }

        [DataMember(Name = "accdnLH2Ranks8Plus16Round")]
        BoundingBox AccdnLh2Ranks8Plus16Round { get; }

        [DataMember(Name = "accdnLH2Ranks8Round")]
        BoundingBox AccdnLh2Ranks8Round { get; }

        [DataMember(Name = "accdnLH2RanksFullMasterRound")]
        BoundingBox AccdnLh2RanksFullMasterRound { get; }

        [DataMember(Name = "accdnLH2RanksMasterPlus16Round")]
        BoundingBox AccdnLh2RanksMasterPlus16Round { get; }

        [DataMember(Name = "accdnLH2RanksMasterRound")]
        BoundingBox AccdnLh2RanksMasterRound { get; }

        [DataMember(Name = "accdnLH3Ranks2Plus8Square")]
        BoundingBox AccdnLh3Ranks2Plus8Square { get; }

        [DataMember(Name = "accdnLH3Ranks2Square")]
        BoundingBox AccdnLh3Ranks2Square { get; }

        [DataMember(Name = "accdnLH3Ranks8Square")]
        BoundingBox AccdnLh3Ranks8Square { get; }

        [DataMember(Name = "accdnLH3RanksDouble8Square")]
        BoundingBox AccdnLh3RanksDouble8Square { get; }

        [DataMember(Name = "accdnLH3RanksTuttiSquare")]
        BoundingBox AccdnLh3RanksTuttiSquare { get; }

        [DataMember(Name = "accdnPull")]
        BoundingBox AccdnPull { get; }

        [DataMember(Name = "accdnPush")]
        BoundingBox AccdnPush { get; }

        [DataMember(Name = "accdnPushAlt")]
        BoundingBox AccdnPushAlt { get; }

        [DataMember(Name = "accdnRH3RanksAccordion")]
        BoundingBox AccdnRh3RanksAccordion { get; }

        [DataMember(Name = "accdnRH3RanksAuthenticMusette")]
        BoundingBox AccdnRh3RanksAuthenticMusette { get; }

        [DataMember(Name = "accdnRH3RanksBandoneon")]
        BoundingBox AccdnRh3RanksBandoneon { get; }

        [DataMember(Name = "accdnRH3RanksBassoon")]
        BoundingBox AccdnRh3RanksBassoon { get; }

        [DataMember(Name = "accdnRH3RanksClarinet")]
        BoundingBox AccdnRh3RanksClarinet { get; }

        [DataMember(Name = "accdnRH3RanksDoubleTremoloLower8ve")]
        BoundingBox AccdnRh3RanksDoubleTremoloLower8Ve { get; }

        [DataMember(Name = "accdnRH3RanksDoubleTremoloUpper8ve")]
        BoundingBox AccdnRh3RanksDoubleTremoloUpper8Ve { get; }

        [DataMember(Name = "accdnRH3RanksFullFactory")]
        BoundingBox AccdnRh3RanksFullFactory { get; }

        [DataMember(Name = "accdnRH3RanksHarmonium")]
        BoundingBox AccdnRh3RanksHarmonium { get; }

        [DataMember(Name = "accdnRH3RanksImitationMusette")]
        BoundingBox AccdnRh3RanksImitationMusette { get; }

        [DataMember(Name = "accdnRH3RanksLowerTremolo8")]
        BoundingBox AccdnRh3RanksLowerTremolo8 { get; }

        [DataMember(Name = "accdnRH3RanksMaster")]
        BoundingBox AccdnRh3RanksMaster { get; }

        [DataMember(Name = "accdnRH3RanksOboe")]
        BoundingBox AccdnRh3RanksOboe { get; }

        [DataMember(Name = "accdnRH3RanksOrgan")]
        BoundingBox AccdnRh3RanksOrgan { get; }

        [DataMember(Name = "accdnRH3RanksPiccolo")]
        BoundingBox AccdnRh3RanksPiccolo { get; }

        [DataMember(Name = "accdnRH3RanksTremoloLower8ve")]
        BoundingBox AccdnRh3RanksTremoloLower8Ve { get; }

        [DataMember(Name = "accdnRH3RanksTremoloUpper8ve")]
        BoundingBox AccdnRh3RanksTremoloUpper8Ve { get; }

        [DataMember(Name = "accdnRH3RanksTwoChoirs")]
        BoundingBox AccdnRh3RanksTwoChoirs { get; }

        [DataMember(Name = "accdnRH3RanksUpperTremolo8")]
        BoundingBox AccdnRh3RanksUpperTremolo8 { get; }

        [DataMember(Name = "accdnRH3RanksViolin")]
        BoundingBox AccdnRh3RanksViolin { get; }

        [DataMember(Name = "accdnRH4RanksAlto")]
        BoundingBox AccdnRh4RanksAlto { get; }

        [DataMember(Name = "accdnRH4RanksBassAlto")]
        BoundingBox AccdnRh4RanksBassAlto { get; }

        [DataMember(Name = "accdnRH4RanksMaster")]
        BoundingBox AccdnRh4RanksMaster { get; }

        [DataMember(Name = "accdnRH4RanksSoftBass")]
        BoundingBox AccdnRh4RanksSoftBass { get; }

        [DataMember(Name = "accdnRH4RanksSoftTenor")]
        BoundingBox AccdnRh4RanksSoftTenor { get; }

        [DataMember(Name = "accdnRH4RanksSoprano")]
        BoundingBox AccdnRh4RanksSoprano { get; }

        [DataMember(Name = "accdnRH4RanksTenor")]
        BoundingBox AccdnRh4RanksTenor { get; }

        [DataMember(Name = "accdnRicochet2")]
        BoundingBox AccdnRicochet2 { get; }

        [DataMember(Name = "accdnRicochet3")]
        BoundingBox AccdnRicochet3 { get; }

        [DataMember(Name = "accdnRicochet4")]
        BoundingBox AccdnRicochet4 { get; }

        [DataMember(Name = "accdnRicochet5")]
        BoundingBox AccdnRicochet5 { get; }

        [DataMember(Name = "accdnRicochet6")]
        BoundingBox AccdnRicochet6 { get; }

        [DataMember(Name = "accdnRicochetStem2")]
        BoundingBox AccdnRicochetStem2 { get; }

        [DataMember(Name = "accdnRicochetStem3")]
        BoundingBox AccdnRicochetStem3 { get; }

        [DataMember(Name = "accdnRicochetStem4")]
        BoundingBox AccdnRicochetStem4 { get; }

        [DataMember(Name = "accdnRicochetStem5")]
        BoundingBox AccdnRicochetStem5 { get; }

        [DataMember(Name = "accdnRicochetStem6")]
        BoundingBox AccdnRicochetStem6 { get; }

        [DataMember(Name = "accidental1CommaFlat")]
        BoundingBox Accidental1CommaFlat { get; }

        [DataMember(Name = "accidental1CommaSharp")]
        BoundingBox Accidental1CommaSharp { get; }

        [DataMember(Name = "accidental2CommaFlat")]
        BoundingBox Accidental2CommaFlat { get; }

        [DataMember(Name = "accidental2CommaSharp")]
        BoundingBox Accidental2CommaSharp { get; }

        [DataMember(Name = "accidental3CommaFlat")]
        BoundingBox Accidental3CommaFlat { get; }

        [DataMember(Name = "accidental3CommaSharp")]
        BoundingBox Accidental3CommaSharp { get; }

        [DataMember(Name = "accidental4CommaFlat")]
        BoundingBox Accidental4CommaFlat { get; }

        [DataMember(Name = "accidental5CommaSharp")]
        BoundingBox Accidental5CommaSharp { get; }

        [DataMember(Name = "accidentalArrowDown")]
        BoundingBox AccidentalArrowDown { get; }

        [DataMember(Name = "accidentalArrowUp")]
        BoundingBox AccidentalArrowUp { get; }

        [DataMember(Name = "accidentalBakiyeFlat")]
        BoundingBox AccidentalBakiyeFlat { get; }

        [DataMember(Name = "accidentalBakiyeSharp")]
        BoundingBox AccidentalBakiyeSharp { get; }

        [DataMember(Name = "accidentalBracketLeft")]
        BoundingBox AccidentalBracketLeft { get; }

        [DataMember(Name = "accidentalBracketRight")]
        BoundingBox AccidentalBracketRight { get; }

        [DataMember(Name = "accidentalBuyukMucennebFlat")]
        BoundingBox AccidentalBuyukMucennebFlat { get; }

        [DataMember(Name = "accidentalBuyukMucennebSharp")]
        BoundingBox AccidentalBuyukMucennebSharp { get; }

        [DataMember(Name = "accidentalCombiningCloseCurlyBrace")]
        BoundingBox AccidentalCombiningCloseCurlyBrace { get; }

        [DataMember(Name = "accidentalCombiningLower17Schisma")]
        BoundingBox AccidentalCombiningLower17Schisma { get; }

        [DataMember(Name = "accidentalCombiningLower19Schisma")]
        BoundingBox AccidentalCombiningLower19Schisma { get; }

        [DataMember(Name = "accidentalCombiningLower23Limit29LimitComma")]
        BoundingBox AccidentalCombiningLower23Limit29LimitComma { get; }

        [DataMember(Name = "accidentalCombiningLower31Schisma")]
        BoundingBox AccidentalCombiningLower31Schisma { get; }

        [DataMember(Name = "accidentalCombiningLower53LimitComma")]
        BoundingBox AccidentalCombiningLower53LimitComma { get; }

        [DataMember(Name = "accidentalCombiningOpenCurlyBrace")]
        BoundingBox AccidentalCombiningOpenCurlyBrace { get; }

        [DataMember(Name = "accidentalCombiningRaise17Schisma")]
        BoundingBox AccidentalCombiningRaise17Schisma { get; }

        [DataMember(Name = "accidentalCombiningRaise19Schisma")]
        BoundingBox AccidentalCombiningRaise19Schisma { get; }

        [DataMember(Name = "accidentalCombiningRaise23Limit29LimitComma")]
        BoundingBox AccidentalCombiningRaise23Limit29LimitComma { get; }

        [DataMember(Name = "accidentalCombiningRaise31Schisma")]
        BoundingBox AccidentalCombiningRaise31Schisma { get; }

        [DataMember(Name = "accidentalCombiningRaise53LimitComma")]
        BoundingBox AccidentalCombiningRaise53LimitComma { get; }

        [DataMember(Name = "accidentalCommaSlashDown")]
        BoundingBox AccidentalCommaSlashDown { get; }

        [DataMember(Name = "accidentalCommaSlashUp")]
        BoundingBox AccidentalCommaSlashUp { get; }

        [DataMember(Name = "accidentalDoubleFlat")]
        BoundingBox AccidentalDoubleFlat { get; }

        [DataMember(Name = "accidentalDoubleFlatArabic")]
        BoundingBox AccidentalDoubleFlatArabic { get; }

        [DataMember(Name = "accidentalDoubleFlatEqualTempered")]
        BoundingBox AccidentalDoubleFlatEqualTempered { get; }

        [DataMember(Name = "accidentalDoubleFlatJoinedStems")]
        BoundingBox AccidentalDoubleFlatJoinedStems { get; }

        [DataMember(Name = "accidentalDoubleFlatOneArrowDown")]
        BoundingBox AccidentalDoubleFlatOneArrowDown { get; }

        [DataMember(Name = "accidentalDoubleFlatOneArrowUp")]
        BoundingBox AccidentalDoubleFlatOneArrowUp { get; }

        [DataMember(Name = "accidentalDoubleFlatParens")]
        BoundingBox AccidentalDoubleFlatParens { get; }

        [DataMember(Name = "accidentalDoubleFlatReversed")]
        BoundingBox AccidentalDoubleFlatReversed { get; }

        [DataMember(Name = "accidentalDoubleFlatThreeArrowsDown")]
        BoundingBox AccidentalDoubleFlatThreeArrowsDown { get; }

        [DataMember(Name = "accidentalDoubleFlatThreeArrowsUp")]
        BoundingBox AccidentalDoubleFlatThreeArrowsUp { get; }

        [DataMember(Name = "accidentalDoubleFlatTurned")]
        BoundingBox AccidentalDoubleFlatTurned { get; }

        [DataMember(Name = "accidentalDoubleFlatTwoArrowsDown")]
        BoundingBox AccidentalDoubleFlatTwoArrowsDown { get; }

        [DataMember(Name = "accidentalDoubleFlatTwoArrowsUp")]
        BoundingBox AccidentalDoubleFlatTwoArrowsUp { get; }

        [DataMember(Name = "accidentalDoubleSharp")]
        BoundingBox AccidentalDoubleSharp { get; }

        [DataMember(Name = "accidentalDoubleSharpArabic")]
        BoundingBox AccidentalDoubleSharpArabic { get; }

        [DataMember(Name = "accidentalDoubleSharpEqualTempered")]
        BoundingBox AccidentalDoubleSharpEqualTempered { get; }

        [DataMember(Name = "accidentalDoubleSharpOneArrowDown")]
        BoundingBox AccidentalDoubleSharpOneArrowDown { get; }

        [DataMember(Name = "accidentalDoubleSharpOneArrowUp")]
        BoundingBox AccidentalDoubleSharpOneArrowUp { get; }

        [DataMember(Name = "accidentalDoubleSharpParens")]
        BoundingBox AccidentalDoubleSharpParens { get; }

        [DataMember(Name = "accidentalDoubleSharpThreeArrowsDown")]
        BoundingBox AccidentalDoubleSharpThreeArrowsDown { get; }

        [DataMember(Name = "accidentalDoubleSharpThreeArrowsUp")]
        BoundingBox AccidentalDoubleSharpThreeArrowsUp { get; }

        [DataMember(Name = "accidentalDoubleSharpTwoArrowsDown")]
        BoundingBox AccidentalDoubleSharpTwoArrowsDown { get; }

        [DataMember(Name = "accidentalDoubleSharpTwoArrowsUp")]
        BoundingBox AccidentalDoubleSharpTwoArrowsUp { get; }

        [DataMember(Name = "accidentalEnharmonicAlmostEqualTo")]
        BoundingBox AccidentalEnharmonicAlmostEqualTo { get; }

        [DataMember(Name = "accidentalEnharmonicEquals")]
        BoundingBox AccidentalEnharmonicEquals { get; }

        [DataMember(Name = "accidentalEnharmonicTilde")]
        BoundingBox AccidentalEnharmonicTilde { get; }

        [DataMember(Name = "accidentalFilledReversedFlatAndFlat")]
        BoundingBox AccidentalFilledReversedFlatAndFlat { get; }

        [DataMember(Name = "accidentalFilledReversedFlatAndFlatArrowDown")]
        BoundingBox AccidentalFilledReversedFlatAndFlatArrowDown { get; }

        [DataMember(Name = "accidentalFilledReversedFlatAndFlatArrowUp")]
        BoundingBox AccidentalFilledReversedFlatAndFlatArrowUp { get; }

        [DataMember(Name = "accidentalFilledReversedFlatArrowDown")]
        BoundingBox AccidentalFilledReversedFlatArrowDown { get; }

        [DataMember(Name = "accidentalFilledReversedFlatArrowUp")]
        BoundingBox AccidentalFilledReversedFlatArrowUp { get; }

        [DataMember(Name = "accidentalFiveQuarterTonesFlatArrowDown")]
        BoundingBox AccidentalFiveQuarterTonesFlatArrowDown { get; }

        [DataMember(Name = "accidentalFiveQuarterTonesSharpArrowUp")]
        BoundingBox AccidentalFiveQuarterTonesSharpArrowUp { get; }

        [DataMember(Name = "accidentalFlat")]
        BoundingBox AccidentalFlat { get; }

        [DataMember(Name = "accidentalFlatArabic")]
        BoundingBox AccidentalFlatArabic { get; }

        [DataMember(Name = "accidentalFlatEqualTempered")]
        BoundingBox AccidentalFlatEqualTempered { get; }

        [DataMember(Name = "accidentalFlatJohnstonDown")]
        BoundingBox AccidentalFlatJohnstonDown { get; }

        [DataMember(Name = "accidentalFlatJohnstonEl")]
        BoundingBox AccidentalFlatJohnstonEl { get; }

        [DataMember(Name = "accidentalFlatJohnstonElDown")]
        BoundingBox AccidentalFlatJohnstonElDown { get; }

        [DataMember(Name = "accidentalFlatJohnstonUp")]
        BoundingBox AccidentalFlatJohnstonUp { get; }

        [DataMember(Name = "accidentalFlatJohnstonUpEl")]
        BoundingBox AccidentalFlatJohnstonUpEl { get; }

        [DataMember(Name = "accidentalFlatLoweredStockhausen")]
        BoundingBox AccidentalFlatLoweredStockhausen { get; }

        [DataMember(Name = "accidentalFlatOneArrowDown")]
        BoundingBox AccidentalFlatOneArrowDown { get; }

        [DataMember(Name = "accidentalFlatOneArrowUp")]
        BoundingBox AccidentalFlatOneArrowUp { get; }

        [DataMember(Name = "accidentalFlatParens")]
        BoundingBox AccidentalFlatParens { get; }

        [DataMember(Name = "accidentalFlatRaisedStockhausen")]
        BoundingBox AccidentalFlatRaisedStockhausen { get; }

        [DataMember(Name = "accidentalFlatRepeatedLineStockhausen")]
        BoundingBox AccidentalFlatRepeatedLineStockhausen { get; }

        [DataMember(Name = "accidentalFlatRepeatedSpaceStockhausen")]
        BoundingBox AccidentalFlatRepeatedSpaceStockhausen { get; }

        [DataMember(Name = "accidentalFlatSmall")]
        BoundingBox AccidentalFlatSmall { get; }

        [DataMember(Name = "accidentalFlatThreeArrowsDown")]
        BoundingBox AccidentalFlatThreeArrowsDown { get; }

        [DataMember(Name = "accidentalFlatThreeArrowsUp")]
        BoundingBox AccidentalFlatThreeArrowsUp { get; }

        [DataMember(Name = "accidentalFlatTurned")]
        BoundingBox AccidentalFlatTurned { get; }

        [DataMember(Name = "accidentalFlatTwoArrowsDown")]
        BoundingBox AccidentalFlatTwoArrowsDown { get; }

        [DataMember(Name = "accidentalFlatTwoArrowsUp")]
        BoundingBox AccidentalFlatTwoArrowsUp { get; }

        [DataMember(Name = "accidentalHalfSharpArrowDown")]
        BoundingBox AccidentalHalfSharpArrowDown { get; }

        [DataMember(Name = "accidentalHalfSharpArrowUp")]
        BoundingBox AccidentalHalfSharpArrowUp { get; }

        [DataMember(Name = "accidentalJohnston13")]
        BoundingBox AccidentalJohnston13 { get; }

        [DataMember(Name = "accidentalJohnston31")]
        BoundingBox AccidentalJohnston31 { get; }

        [DataMember(Name = "accidentalJohnstonDown")]
        BoundingBox AccidentalJohnstonDown { get; }

        [DataMember(Name = "accidentalJohnstonDownEl")]
        BoundingBox AccidentalJohnstonDownEl { get; }

        [DataMember(Name = "accidentalJohnstonEl")]
        BoundingBox AccidentalJohnstonEl { get; }

        [DataMember(Name = "accidentalJohnstonMinus")]
        BoundingBox AccidentalJohnstonMinus { get; }

        [DataMember(Name = "accidentalJohnstonPlus")]
        BoundingBox AccidentalJohnstonPlus { get; }

        [DataMember(Name = "accidentalJohnstonSeven")]
        BoundingBox AccidentalJohnstonSeven { get; }

        [DataMember(Name = "accidentalJohnstonSevenDown")]
        BoundingBox AccidentalJohnstonSevenDown { get; }

        [DataMember(Name = "accidentalJohnstonSevenFlat")]
        BoundingBox AccidentalJohnstonSevenFlat { get; }

        [DataMember(Name = "accidentalJohnstonSevenFlatDown")]
        BoundingBox AccidentalJohnstonSevenFlatDown { get; }

        [DataMember(Name = "accidentalJohnstonSevenFlatUp")]
        BoundingBox AccidentalJohnstonSevenFlatUp { get; }

        [DataMember(Name = "accidentalJohnstonSevenSharp")]
        BoundingBox AccidentalJohnstonSevenSharp { get; }

        [DataMember(Name = "accidentalJohnstonSevenSharpDown")]
        BoundingBox AccidentalJohnstonSevenSharpDown { get; }

        [DataMember(Name = "accidentalJohnstonSevenSharpUp")]
        BoundingBox AccidentalJohnstonSevenSharpUp { get; }

        [DataMember(Name = "accidentalJohnstonSevenUp")]
        BoundingBox AccidentalJohnstonSevenUp { get; }

        [DataMember(Name = "accidentalJohnstonUp")]
        BoundingBox AccidentalJohnstonUp { get; }

        [DataMember(Name = "accidentalJohnstonUpEl")]
        BoundingBox AccidentalJohnstonUpEl { get; }

        [DataMember(Name = "accidentalKomaFlat")]
        BoundingBox AccidentalKomaFlat { get; }

        [DataMember(Name = "accidentalKomaSharp")]
        BoundingBox AccidentalKomaSharp { get; }

        [DataMember(Name = "accidentalKoron")]
        BoundingBox AccidentalKoron { get; }

        [DataMember(Name = "accidentalKucukMucennebFlat")]
        BoundingBox AccidentalKucukMucennebFlat { get; }

        [DataMember(Name = "accidentalKucukMucennebSharp")]
        BoundingBox AccidentalKucukMucennebSharp { get; }

        [DataMember(Name = "accidentalLargeDoubleSharp")]
        BoundingBox AccidentalLargeDoubleSharp { get; }

        [DataMember(Name = "accidentalLowerOneSeptimalComma")]
        BoundingBox AccidentalLowerOneSeptimalComma { get; }

        [DataMember(Name = "accidentalLowerOneTridecimalQuartertone")]
        BoundingBox AccidentalLowerOneTridecimalQuartertone { get; }

        [DataMember(Name = "accidentalLowerOneUndecimalQuartertone")]
        BoundingBox AccidentalLowerOneUndecimalQuartertone { get; }

        [DataMember(Name = "accidentalLowerTwoSeptimalCommas")]
        BoundingBox AccidentalLowerTwoSeptimalCommas { get; }

        [DataMember(Name = "accidentalLoweredStockhausen")]
        BoundingBox AccidentalLoweredStockhausen { get; }

        [DataMember(Name = "accidentalNarrowReversedFlat")]
        BoundingBox AccidentalNarrowReversedFlat { get; }

        [DataMember(Name = "accidentalNarrowReversedFlatAndFlat")]
        BoundingBox AccidentalNarrowReversedFlatAndFlat { get; }

        [DataMember(Name = "accidentalNatural")]
        BoundingBox AccidentalNatural { get; }

        [DataMember(Name = "accidentalNaturalArabic")]
        BoundingBox AccidentalNaturalArabic { get; }

        [DataMember(Name = "accidentalNaturalEqualTempered")]
        BoundingBox AccidentalNaturalEqualTempered { get; }

        [DataMember(Name = "accidentalNaturalFlat")]
        BoundingBox AccidentalNaturalFlat { get; }

        [DataMember(Name = "accidentalNaturalLoweredStockhausen")]
        BoundingBox AccidentalNaturalLoweredStockhausen { get; }

        [DataMember(Name = "accidentalNaturalOneArrowDown")]
        BoundingBox AccidentalNaturalOneArrowDown { get; }

        [DataMember(Name = "accidentalNaturalOneArrowUp")]
        BoundingBox AccidentalNaturalOneArrowUp { get; }

        [DataMember(Name = "accidentalNaturalParens")]
        BoundingBox AccidentalNaturalParens { get; }

        [DataMember(Name = "accidentalNaturalRaisedStockhausen")]
        BoundingBox AccidentalNaturalRaisedStockhausen { get; }

        [DataMember(Name = "accidentalNaturalReversed")]
        BoundingBox AccidentalNaturalReversed { get; }

        [DataMember(Name = "accidentalNaturalSharp")]
        BoundingBox AccidentalNaturalSharp { get; }

        [DataMember(Name = "accidentalNaturalSmall")]
        BoundingBox AccidentalNaturalSmall { get; }

        [DataMember(Name = "accidentalNaturalThreeArrowsDown")]
        BoundingBox AccidentalNaturalThreeArrowsDown { get; }

        [DataMember(Name = "accidentalNaturalThreeArrowsUp")]
        BoundingBox AccidentalNaturalThreeArrowsUp { get; }

        [DataMember(Name = "accidentalNaturalTwoArrowsDown")]
        BoundingBox AccidentalNaturalTwoArrowsDown { get; }

        [DataMember(Name = "accidentalNaturalTwoArrowsUp")]
        BoundingBox AccidentalNaturalTwoArrowsUp { get; }

        [DataMember(Name = "accidentalOneAndAHalfSharpsArrowDown")]
        BoundingBox AccidentalOneAndAHalfSharpsArrowDown { get; }

        [DataMember(Name = "accidentalOneAndAHalfSharpsArrowUp")]
        BoundingBox AccidentalOneAndAHalfSharpsArrowUp { get; }

        [DataMember(Name = "accidentalOneQuarterToneFlatFerneyhough")]
        BoundingBox AccidentalOneQuarterToneFlatFerneyhough { get; }

        [DataMember(Name = "accidentalOneQuarterToneFlatStockhausen")]
        BoundingBox AccidentalOneQuarterToneFlatStockhausen { get; }

        [DataMember(Name = "accidentalOneQuarterToneSharpFerneyhough")]
        BoundingBox AccidentalOneQuarterToneSharpFerneyhough { get; }

        [DataMember(Name = "accidentalOneQuarterToneSharpStockhausen")]
        BoundingBox AccidentalOneQuarterToneSharpStockhausen { get; }

        [DataMember(Name = "accidentalOneThirdToneFlatFerneyhough")]
        BoundingBox AccidentalOneThirdToneFlatFerneyhough { get; }

        [DataMember(Name = "accidentalOneThirdToneSharpFerneyhough")]
        BoundingBox AccidentalOneThirdToneSharpFerneyhough { get; }

        [DataMember(Name = "accidentalParensLeft")]
        BoundingBox AccidentalParensLeft { get; }

        [DataMember(Name = "accidentalParensRight")]
        BoundingBox AccidentalParensRight { get; }

        [DataMember(Name = "accidentalQuarterFlatEqualTempered")]
        BoundingBox AccidentalQuarterFlatEqualTempered { get; }

        [DataMember(Name = "accidentalQuarterSharpEqualTempered")]
        BoundingBox AccidentalQuarterSharpEqualTempered { get; }

        [DataMember(Name = "accidentalQuarterToneFlat4")]
        BoundingBox AccidentalQuarterToneFlat4 { get; }

        [DataMember(Name = "accidentalQuarterToneFlatArabic")]
        BoundingBox AccidentalQuarterToneFlatArabic { get; }

        [DataMember(Name = "accidentalQuarterToneFlatArrowUp")]
        BoundingBox AccidentalQuarterToneFlatArrowUp { get; }

        [DataMember(Name = "accidentalQuarterToneFlatFilledReversed")]
        BoundingBox AccidentalQuarterToneFlatFilledReversed { get; }

        [DataMember(Name = "accidentalQuarterToneFlatNaturalArrowDown")]
        BoundingBox AccidentalQuarterToneFlatNaturalArrowDown { get; }

        [DataMember(Name = "accidentalQuarterToneFlatPenderecki")]
        BoundingBox AccidentalQuarterToneFlatPenderecki { get; }

        [DataMember(Name = "accidentalQuarterToneFlatStein")]
        BoundingBox AccidentalQuarterToneFlatStein { get; }

        [DataMember(Name = "accidentalQuarterToneFlatVanBlankenburg")]
        BoundingBox AccidentalQuarterToneFlatVanBlankenburg { get; }

        [DataMember(Name = "accidentalQuarterToneSharp4")]
        BoundingBox AccidentalQuarterToneSharp4 { get; }

        [DataMember(Name = "accidentalQuarterToneSharpArabic")]
        BoundingBox AccidentalQuarterToneSharpArabic { get; }

        [DataMember(Name = "accidentalQuarterToneSharpArrowDown")]
        BoundingBox AccidentalQuarterToneSharpArrowDown { get; }

        [DataMember(Name = "accidentalQuarterToneSharpBusotti")]
        BoundingBox AccidentalQuarterToneSharpBusotti { get; }

        [DataMember(Name = "accidentalQuarterToneSharpNaturalArrowUp")]
        BoundingBox AccidentalQuarterToneSharpNaturalArrowUp { get; }

        [DataMember(Name = "accidentalQuarterToneSharpStein")]
        BoundingBox AccidentalQuarterToneSharpStein { get; }

        [DataMember(Name = "accidentalQuarterToneSharpWiggle")]
        BoundingBox AccidentalQuarterToneSharpWiggle { get; }

        [DataMember(Name = "accidentalRaiseOneSeptimalComma")]
        BoundingBox AccidentalRaiseOneSeptimalComma { get; }

        [DataMember(Name = "accidentalRaiseOneTridecimalQuartertone")]
        BoundingBox AccidentalRaiseOneTridecimalQuartertone { get; }

        [DataMember(Name = "accidentalRaiseOneUndecimalQuartertone")]
        BoundingBox AccidentalRaiseOneUndecimalQuartertone { get; }

        [DataMember(Name = "accidentalRaiseTwoSeptimalCommas")]
        BoundingBox AccidentalRaiseTwoSeptimalCommas { get; }

        [DataMember(Name = "accidentalRaisedStockhausen")]
        BoundingBox AccidentalRaisedStockhausen { get; }

        [DataMember(Name = "accidentalReversedFlatAndFlatArrowDown")]
        BoundingBox AccidentalReversedFlatAndFlatArrowDown { get; }

        [DataMember(Name = "accidentalReversedFlatAndFlatArrowUp")]
        BoundingBox AccidentalReversedFlatAndFlatArrowUp { get; }

        [DataMember(Name = "accidentalReversedFlatArrowDown")]
        BoundingBox AccidentalReversedFlatArrowDown { get; }

        [DataMember(Name = "accidentalReversedFlatArrowUp")]
        BoundingBox AccidentalReversedFlatArrowUp { get; }

        [DataMember(Name = "accidentalSharp")]
        BoundingBox AccidentalSharp { get; }

        [DataMember(Name = "accidentalSharpArabic")]
        BoundingBox AccidentalSharpArabic { get; }

        [DataMember(Name = "accidentalSharpEqualTempered")]
        BoundingBox AccidentalSharpEqualTempered { get; }

        [DataMember(Name = "accidentalSharpJohnstonDown")]
        BoundingBox AccidentalSharpJohnstonDown { get; }

        [DataMember(Name = "accidentalSharpJohnstonDownEl")]
        BoundingBox AccidentalSharpJohnstonDownEl { get; }

        [DataMember(Name = "accidentalSharpJohnstonEl")]
        BoundingBox AccidentalSharpJohnstonEl { get; }

        [DataMember(Name = "accidentalSharpJohnstonUp")]
        BoundingBox AccidentalSharpJohnstonUp { get; }

        [DataMember(Name = "accidentalSharpJohnstonUpEl")]
        BoundingBox AccidentalSharpJohnstonUpEl { get; }

        [DataMember(Name = "accidentalSharpLoweredStockhausen")]
        BoundingBox AccidentalSharpLoweredStockhausen { get; }

        [DataMember(Name = "accidentalSharpOneArrowDown")]
        BoundingBox AccidentalSharpOneArrowDown { get; }

        [DataMember(Name = "accidentalSharpOneArrowUp")]
        BoundingBox AccidentalSharpOneArrowUp { get; }

        [DataMember(Name = "accidentalSharpOneHorizontalStroke")]
        BoundingBox AccidentalSharpOneHorizontalStroke { get; }

        [DataMember(Name = "accidentalSharpParens")]
        BoundingBox AccidentalSharpParens { get; }

        [DataMember(Name = "accidentalSharpRaisedStockhausen")]
        BoundingBox AccidentalSharpRaisedStockhausen { get; }

        [DataMember(Name = "accidentalSharpRepeatedLineStockhausen")]
        BoundingBox AccidentalSharpRepeatedLineStockhausen { get; }

        [DataMember(Name = "accidentalSharpRepeatedSpaceStockhausen")]
        BoundingBox AccidentalSharpRepeatedSpaceStockhausen { get; }

        [DataMember(Name = "accidentalSharpReversed")]
        BoundingBox AccidentalSharpReversed { get; }

        [DataMember(Name = "accidentalSharpSharp")]
        BoundingBox AccidentalSharpSharp { get; }

        [DataMember(Name = "accidentalSharpSmall")]
        BoundingBox AccidentalSharpSmall { get; }

        [DataMember(Name = "accidentalSharpThreeArrowsDown")]
        BoundingBox AccidentalSharpThreeArrowsDown { get; }

        [DataMember(Name = "accidentalSharpThreeArrowsUp")]
        BoundingBox AccidentalSharpThreeArrowsUp { get; }

        [DataMember(Name = "accidentalSharpTwoArrowsDown")]
        BoundingBox AccidentalSharpTwoArrowsDown { get; }

        [DataMember(Name = "accidentalSharpTwoArrowsUp")]
        BoundingBox AccidentalSharpTwoArrowsUp { get; }

        [DataMember(Name = "accidentalSims12Down")]
        BoundingBox AccidentalSims12Down { get; }

        [DataMember(Name = "accidentalSims12Up")]
        BoundingBox AccidentalSims12Up { get; }

        [DataMember(Name = "accidentalSims4Down")]
        BoundingBox AccidentalSims4Down { get; }

        [DataMember(Name = "accidentalSims4Up")]
        BoundingBox AccidentalSims4Up { get; }

        [DataMember(Name = "accidentalSims6Down")]
        BoundingBox AccidentalSims6Down { get; }

        [DataMember(Name = "accidentalSims6Up")]
        BoundingBox AccidentalSims6Up { get; }

        [DataMember(Name = "accidentalSori")]
        BoundingBox AccidentalSori { get; }

        [DataMember(Name = "accidentalTavenerFlat")]
        BoundingBox AccidentalTavenerFlat { get; }

        [DataMember(Name = "accidentalTavenerSharp")]
        BoundingBox AccidentalTavenerSharp { get; }

        [DataMember(Name = "accidentalThreeQuarterTonesFlatArabic")]
        BoundingBox AccidentalThreeQuarterTonesFlatArabic { get; }

        [DataMember(Name = "accidentalThreeQuarterTonesFlatArrowDown")]
        BoundingBox AccidentalThreeQuarterTonesFlatArrowDown { get; }

        [DataMember(Name = "accidentalThreeQuarterTonesFlatArrowUp")]
        BoundingBox AccidentalThreeQuarterTonesFlatArrowUp { get; }

        [DataMember(Name = "accidentalThreeQuarterTonesFlatCouper")]
        BoundingBox AccidentalThreeQuarterTonesFlatCouper { get; }

        [DataMember(Name = "accidentalThreeQuarterTonesFlatGrisey")]
        BoundingBox AccidentalThreeQuarterTonesFlatGrisey { get; }

        [DataMember(Name = "accidentalThreeQuarterTonesFlatTartini")]
        BoundingBox AccidentalThreeQuarterTonesFlatTartini { get; }

        [DataMember(Name = "accidentalThreeQuarterTonesFlatZimmermann")]
        BoundingBox AccidentalThreeQuarterTonesFlatZimmermann { get; }

        [DataMember(Name = "accidentalThreeQuarterTonesSharpArabic")]
        BoundingBox AccidentalThreeQuarterTonesSharpArabic { get; }

        [DataMember(Name = "accidentalThreeQuarterTonesSharpArrowDown")]
        BoundingBox AccidentalThreeQuarterTonesSharpArrowDown { get; }

        [DataMember(Name = "accidentalThreeQuarterTonesSharpArrowUp")]
        BoundingBox AccidentalThreeQuarterTonesSharpArrowUp { get; }

        [DataMember(Name = "accidentalThreeQuarterTonesSharpBusotti")]
        BoundingBox AccidentalThreeQuarterTonesSharpBusotti { get; }

        [DataMember(Name = "accidentalThreeQuarterTonesSharpStein")]
        BoundingBox AccidentalThreeQuarterTonesSharpStein { get; }

        [DataMember(Name = "accidentalThreeQuarterTonesSharpStockhausen")]
        BoundingBox AccidentalThreeQuarterTonesSharpStockhausen { get; }

        [DataMember(Name = "accidentalTripleFlat")]
        BoundingBox AccidentalTripleFlat { get; }

        [DataMember(Name = "accidentalTripleFlatJoinedStems")]
        BoundingBox AccidentalTripleFlatJoinedStems { get; }

        [DataMember(Name = "accidentalTripleSharp")]
        BoundingBox AccidentalTripleSharp { get; }

        [DataMember(Name = "accidentalTwoThirdTonesFlatFerneyhough")]
        BoundingBox AccidentalTwoThirdTonesFlatFerneyhough { get; }

        [DataMember(Name = "accidentalTwoThirdTonesSharpFerneyhough")]
        BoundingBox AccidentalTwoThirdTonesSharpFerneyhough { get; }

        [DataMember(Name = "accidentalWilsonMinus")]
        BoundingBox AccidentalWilsonMinus { get; }

        [DataMember(Name = "accidentalWilsonPlus")]
        BoundingBox AccidentalWilsonPlus { get; }

        [DataMember(Name = "accidentalWyschnegradsky10TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky10TwelfthsFlat { get; }

        [DataMember(Name = "accidentalWyschnegradsky10TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky10TwelfthsSharp { get; }

        [DataMember(Name = "accidentalWyschnegradsky11TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky11TwelfthsFlat { get; }

        [DataMember(Name = "accidentalWyschnegradsky11TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky11TwelfthsSharp { get; }

        [DataMember(Name = "accidentalWyschnegradsky1TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky1TwelfthsFlat { get; }

        [DataMember(Name = "accidentalWyschnegradsky1TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky1TwelfthsSharp { get; }

        [DataMember(Name = "accidentalWyschnegradsky2TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky2TwelfthsFlat { get; }

        [DataMember(Name = "accidentalWyschnegradsky2TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky2TwelfthsSharp { get; }

        [DataMember(Name = "accidentalWyschnegradsky3TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky3TwelfthsFlat { get; }

        [DataMember(Name = "accidentalWyschnegradsky3TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky3TwelfthsSharp { get; }

        [DataMember(Name = "accidentalWyschnegradsky4TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky4TwelfthsFlat { get; }

        [DataMember(Name = "accidentalWyschnegradsky4TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky4TwelfthsSharp { get; }

        [DataMember(Name = "accidentalWyschnegradsky5TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky5TwelfthsFlat { get; }

        [DataMember(Name = "accidentalWyschnegradsky5TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky5TwelfthsSharp { get; }

        [DataMember(Name = "accidentalWyschnegradsky6TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky6TwelfthsFlat { get; }

        [DataMember(Name = "accidentalWyschnegradsky6TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky6TwelfthsSharp { get; }

        [DataMember(Name = "accidentalWyschnegradsky7TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky7TwelfthsFlat { get; }

        [DataMember(Name = "accidentalWyschnegradsky7TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky7TwelfthsSharp { get; }

        [DataMember(Name = "accidentalWyschnegradsky8TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky8TwelfthsFlat { get; }

        [DataMember(Name = "accidentalWyschnegradsky8TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky8TwelfthsSharp { get; }

        [DataMember(Name = "accidentalWyschnegradsky9TwelfthsFlat")]
        BoundingBox AccidentalWyschnegradsky9TwelfthsFlat { get; }

        [DataMember(Name = "accidentalWyschnegradsky9TwelfthsSharp")]
        BoundingBox AccidentalWyschnegradsky9TwelfthsSharp { get; }

        [DataMember(Name = "accidentalXenakisOneThirdToneSharp")]
        BoundingBox AccidentalXenakisOneThirdToneSharp { get; }

        [DataMember(Name = "accidentalXenakisTwoThirdTonesSharp")]
        BoundingBox AccidentalXenakisTwoThirdTonesSharp { get; }

        [DataMember(Name = "analyticsChoralmelodie")]
        BoundingBox AnalyticsChoralmelodie { get; }

        [DataMember(Name = "analyticsEndStimme")]
        BoundingBox AnalyticsEndStimme { get; }

        [DataMember(Name = "analyticsHauptrhythmus")]
        BoundingBox AnalyticsHauptrhythmus { get; }

        [DataMember(Name = "analyticsHauptrhythmusR")]
        BoundingBox AnalyticsHauptrhythmusR { get; }

        [DataMember(Name = "analyticsHauptstimme")]
        BoundingBox AnalyticsHauptstimme { get; }

        [DataMember(Name = "analyticsInversion1")]
        BoundingBox AnalyticsInversion1 { get; }

        [DataMember(Name = "analyticsNebenstimme")]
        BoundingBox AnalyticsNebenstimme { get; }

        [DataMember(Name = "analyticsStartStimme")]
        BoundingBox AnalyticsStartStimme { get; }

        [DataMember(Name = "analyticsTheme")]
        BoundingBox AnalyticsTheme { get; }

        [DataMember(Name = "analyticsTheme1")]
        BoundingBox AnalyticsTheme1 { get; }

        [DataMember(Name = "analyticsThemeInversion")]
        BoundingBox AnalyticsThemeInversion { get; }

        [DataMember(Name = "analyticsThemeRetrograde")]
        BoundingBox AnalyticsThemeRetrograde { get; }

        [DataMember(Name = "analyticsThemeRetrogradeInversion")]
        BoundingBox AnalyticsThemeRetrogradeInversion { get; }

        [DataMember(Name = "arpeggiatoDown")]
        BoundingBox ArpeggiatoDown { get; }

        [DataMember(Name = "arpeggiatoUp")]
        BoundingBox ArpeggiatoUp { get; }

        [DataMember(Name = "arrowBlackDown")]
        BoundingBox ArrowBlackDown { get; }

        [DataMember(Name = "arrowBlackDownLeft")]
        BoundingBox ArrowBlackDownLeft { get; }

        [DataMember(Name = "arrowBlackDownRight")]
        BoundingBox ArrowBlackDownRight { get; }

        [DataMember(Name = "arrowBlackLeft")]
        BoundingBox ArrowBlackLeft { get; }

        [DataMember(Name = "arrowBlackRight")]
        BoundingBox ArrowBlackRight { get; }

        [DataMember(Name = "arrowBlackUp")]
        BoundingBox ArrowBlackUp { get; }

        [DataMember(Name = "arrowBlackUpLeft")]
        BoundingBox ArrowBlackUpLeft { get; }

        [DataMember(Name = "arrowBlackUpRight")]
        BoundingBox ArrowBlackUpRight { get; }

        [DataMember(Name = "arrowOpenDown")]
        BoundingBox ArrowOpenDown { get; }

        [DataMember(Name = "arrowOpenDownLeft")]
        BoundingBox ArrowOpenDownLeft { get; }

        [DataMember(Name = "arrowOpenDownRight")]
        BoundingBox ArrowOpenDownRight { get; }

        [DataMember(Name = "arrowOpenLeft")]
        BoundingBox ArrowOpenLeft { get; }

        [DataMember(Name = "arrowOpenRight")]
        BoundingBox ArrowOpenRight { get; }

        [DataMember(Name = "arrowOpenUp")]
        BoundingBox ArrowOpenUp { get; }

        [DataMember(Name = "arrowOpenUpLeft")]
        BoundingBox ArrowOpenUpLeft { get; }

        [DataMember(Name = "arrowOpenUpRight")]
        BoundingBox ArrowOpenUpRight { get; }

        [DataMember(Name = "arrowWhiteDown")]
        BoundingBox ArrowWhiteDown { get; }

        [DataMember(Name = "arrowWhiteDownLeft")]
        BoundingBox ArrowWhiteDownLeft { get; }

        [DataMember(Name = "arrowWhiteDownRight")]
        BoundingBox ArrowWhiteDownRight { get; }

        [DataMember(Name = "arrowWhiteLeft")]
        BoundingBox ArrowWhiteLeft { get; }

        [DataMember(Name = "arrowWhiteRight")]
        BoundingBox ArrowWhiteRight { get; }

        [DataMember(Name = "arrowWhiteUp")]
        BoundingBox ArrowWhiteUp { get; }

        [DataMember(Name = "arrowWhiteUpLeft")]
        BoundingBox ArrowWhiteUpLeft { get; }

        [DataMember(Name = "arrowWhiteUpRight")]
        BoundingBox ArrowWhiteUpRight { get; }

        [DataMember(Name = "arrowheadBlackDown")]
        BoundingBox ArrowheadBlackDown { get; }

        [DataMember(Name = "arrowheadBlackDownLeft")]
        BoundingBox ArrowheadBlackDownLeft { get; }

        [DataMember(Name = "arrowheadBlackDownRight")]
        BoundingBox ArrowheadBlackDownRight { get; }

        [DataMember(Name = "arrowheadBlackLeft")]
        BoundingBox ArrowheadBlackLeft { get; }

        [DataMember(Name = "arrowheadBlackRight")]
        BoundingBox ArrowheadBlackRight { get; }

        [DataMember(Name = "arrowheadBlackUp")]
        BoundingBox ArrowheadBlackUp { get; }

        [DataMember(Name = "arrowheadBlackUpLeft")]
        BoundingBox ArrowheadBlackUpLeft { get; }

        [DataMember(Name = "arrowheadBlackUpRight")]
        BoundingBox ArrowheadBlackUpRight { get; }

        [DataMember(Name = "arrowheadOpenDown")]
        BoundingBox ArrowheadOpenDown { get; }

        [DataMember(Name = "arrowheadOpenDownLeft")]
        BoundingBox ArrowheadOpenDownLeft { get; }

        [DataMember(Name = "arrowheadOpenDownRight")]
        BoundingBox ArrowheadOpenDownRight { get; }

        [DataMember(Name = "arrowheadOpenLeft")]
        BoundingBox ArrowheadOpenLeft { get; }

        [DataMember(Name = "arrowheadOpenRight")]
        BoundingBox ArrowheadOpenRight { get; }

        [DataMember(Name = "arrowheadOpenUp")]
        BoundingBox ArrowheadOpenUp { get; }

        [DataMember(Name = "arrowheadOpenUpLeft")]
        BoundingBox ArrowheadOpenUpLeft { get; }

        [DataMember(Name = "arrowheadOpenUpRight")]
        BoundingBox ArrowheadOpenUpRight { get; }

        [DataMember(Name = "arrowheadWhiteDown")]
        BoundingBox ArrowheadWhiteDown { get; }

        [DataMember(Name = "arrowheadWhiteDownLeft")]
        BoundingBox ArrowheadWhiteDownLeft { get; }

        [DataMember(Name = "arrowheadWhiteDownRight")]
        BoundingBox ArrowheadWhiteDownRight { get; }

        [DataMember(Name = "arrowheadWhiteLeft")]
        BoundingBox ArrowheadWhiteLeft { get; }

        [DataMember(Name = "arrowheadWhiteRight")]
        BoundingBox ArrowheadWhiteRight { get; }

        [DataMember(Name = "arrowheadWhiteUp")]
        BoundingBox ArrowheadWhiteUp { get; }

        [DataMember(Name = "arrowheadWhiteUpLeft")]
        BoundingBox ArrowheadWhiteUpLeft { get; }

        [DataMember(Name = "arrowheadWhiteUpRight")]
        BoundingBox ArrowheadWhiteUpRight { get; }

        [DataMember(Name = "articAccentAbove")]
        BoundingBox ArticAccentAbove { get; }

        [DataMember(Name = "articAccentAboveLarge")]
        BoundingBox ArticAccentAboveLarge { get; }

        [DataMember(Name = "articAccentAboveSmall")]
        BoundingBox ArticAccentAboveSmall { get; }

        [DataMember(Name = "articAccentBelow")]
        BoundingBox ArticAccentBelow { get; }

        [DataMember(Name = "articAccentBelowLarge")]
        BoundingBox ArticAccentBelowLarge { get; }

        [DataMember(Name = "articAccentBelowSmall")]
        BoundingBox ArticAccentBelowSmall { get; }

        [DataMember(Name = "articAccentStaccatoAbove")]
        BoundingBox ArticAccentStaccatoAbove { get; }

        [DataMember(Name = "articAccentStaccatoAboveSmall")]
        BoundingBox ArticAccentStaccatoAboveSmall { get; }

        [DataMember(Name = "articAccentStaccatoBelow")]
        BoundingBox ArticAccentStaccatoBelow { get; }

        [DataMember(Name = "articAccentStaccatoBelowSmall")]
        BoundingBox ArticAccentStaccatoBelowSmall { get; }

        [DataMember(Name = "articLaissezVibrerAbove")]
        BoundingBox ArticLaissezVibrerAbove { get; }

        [DataMember(Name = "articLaissezVibrerBelow")]
        BoundingBox ArticLaissezVibrerBelow { get; }

        [DataMember(Name = "articMarcatoAbove")]
        BoundingBox ArticMarcatoAbove { get; }

        [DataMember(Name = "articMarcatoAboveSmall")]
        BoundingBox ArticMarcatoAboveSmall { get; }

        [DataMember(Name = "articMarcatoBelow")]
        BoundingBox ArticMarcatoBelow { get; }

        [DataMember(Name = "articMarcatoBelowSmall")]
        BoundingBox ArticMarcatoBelowSmall { get; }

        [DataMember(Name = "articMarcatoStaccatoAbove")]
        BoundingBox ArticMarcatoStaccatoAbove { get; }

        [DataMember(Name = "articMarcatoStaccatoAboveSmall")]
        BoundingBox ArticMarcatoStaccatoAboveSmall { get; }

        [DataMember(Name = "articMarcatoStaccatoBelow")]
        BoundingBox ArticMarcatoStaccatoBelow { get; }

        [DataMember(Name = "articMarcatoStaccatoBelowSmall")]
        BoundingBox ArticMarcatoStaccatoBelowSmall { get; }

        [DataMember(Name = "articMarcatoTenutoAbove")]
        BoundingBox ArticMarcatoTenutoAbove { get; }

        [DataMember(Name = "articMarcatoTenutoBelow")]
        BoundingBox ArticMarcatoTenutoBelow { get; }

        [DataMember(Name = "articSoftAccentAbove")]
        BoundingBox ArticSoftAccentAbove { get; }

        [DataMember(Name = "articSoftAccentBelow")]
        BoundingBox ArticSoftAccentBelow { get; }

        [DataMember(Name = "articSoftAccentStaccatoAbove")]
        BoundingBox ArticSoftAccentStaccatoAbove { get; }

        [DataMember(Name = "articSoftAccentStaccatoBelow")]
        BoundingBox ArticSoftAccentStaccatoBelow { get; }

        [DataMember(Name = "articSoftAccentTenutoAbove")]
        BoundingBox ArticSoftAccentTenutoAbove { get; }

        [DataMember(Name = "articSoftAccentTenutoBelow")]
        BoundingBox ArticSoftAccentTenutoBelow { get; }

        [DataMember(Name = "articSoftAccentTenutoStaccatoAbove")]
        BoundingBox ArticSoftAccentTenutoStaccatoAbove { get; }

        [DataMember(Name = "articSoftAccentTenutoStaccatoBelow")]
        BoundingBox ArticSoftAccentTenutoStaccatoBelow { get; }

        [DataMember(Name = "articStaccatissimoAbove")]
        BoundingBox ArticStaccatissimoAbove { get; }

        [DataMember(Name = "articStaccatissimoAboveSmall")]
        BoundingBox ArticStaccatissimoAboveSmall { get; }

        [DataMember(Name = "articStaccatissimoBelow")]
        BoundingBox ArticStaccatissimoBelow { get; }

        [DataMember(Name = "articStaccatissimoBelowSmall")]
        BoundingBox ArticStaccatissimoBelowSmall { get; }

        [DataMember(Name = "articStaccatissimoStrokeAbove")]
        BoundingBox ArticStaccatissimoStrokeAbove { get; }

        [DataMember(Name = "articStaccatissimoStrokeAboveSmall")]
        BoundingBox ArticStaccatissimoStrokeAboveSmall { get; }

        [DataMember(Name = "articStaccatissimoStrokeBelow")]
        BoundingBox ArticStaccatissimoStrokeBelow { get; }

        [DataMember(Name = "articStaccatissimoStrokeBelowSmall")]
        BoundingBox ArticStaccatissimoStrokeBelowSmall { get; }

        [DataMember(Name = "articStaccatissimoWedgeAbove")]
        BoundingBox ArticStaccatissimoWedgeAbove { get; }

        [DataMember(Name = "articStaccatissimoWedgeAboveSmall")]
        BoundingBox ArticStaccatissimoWedgeAboveSmall { get; }

        [DataMember(Name = "articStaccatissimoWedgeBelow")]
        BoundingBox ArticStaccatissimoWedgeBelow { get; }

        [DataMember(Name = "articStaccatissimoWedgeBelowSmall")]
        BoundingBox ArticStaccatissimoWedgeBelowSmall { get; }

        [DataMember(Name = "articStaccatoAbove")]
        BoundingBox ArticStaccatoAbove { get; }

        [DataMember(Name = "articStaccatoAboveSmall")]
        BoundingBox ArticStaccatoAboveSmall { get; }

        [DataMember(Name = "articStaccatoBelow")]
        BoundingBox ArticStaccatoBelow { get; }

        [DataMember(Name = "articStaccatoBelowSmall")]
        BoundingBox ArticStaccatoBelowSmall { get; }

        [DataMember(Name = "articStressAbove")]
        BoundingBox ArticStressAbove { get; }

        [DataMember(Name = "articStressBelow")]
        BoundingBox ArticStressBelow { get; }

        [DataMember(Name = "articTenutoAbove")]
        BoundingBox ArticTenutoAbove { get; }

        [DataMember(Name = "articTenutoAboveSmall")]
        BoundingBox ArticTenutoAboveSmall { get; }

        [DataMember(Name = "articTenutoAccentAbove")]
        BoundingBox ArticTenutoAccentAbove { get; }

        [DataMember(Name = "articTenutoAccentAboveSmall")]
        BoundingBox ArticTenutoAccentAboveSmall { get; }

        [DataMember(Name = "articTenutoAccentBelow")]
        BoundingBox ArticTenutoAccentBelow { get; }

        [DataMember(Name = "articTenutoAccentBelowSmall")]
        BoundingBox ArticTenutoAccentBelowSmall { get; }

        [DataMember(Name = "articTenutoBelow")]
        BoundingBox ArticTenutoBelow { get; }

        [DataMember(Name = "articTenutoBelowSmall")]
        BoundingBox ArticTenutoBelowSmall { get; }

        [DataMember(Name = "articTenutoStaccatoAbove")]
        BoundingBox ArticTenutoStaccatoAbove { get; }

        [DataMember(Name = "articTenutoStaccatoAboveSmall")]
        BoundingBox ArticTenutoStaccatoAboveSmall { get; }

        [DataMember(Name = "articTenutoStaccatoBelow")]
        BoundingBox ArticTenutoStaccatoBelow { get; }

        [DataMember(Name = "articTenutoStaccatoBelowSmall")]
        BoundingBox ArticTenutoStaccatoBelowSmall { get; }

        [DataMember(Name = "articUnstressAbove")]
        BoundingBox ArticUnstressAbove { get; }

        [DataMember(Name = "articUnstressBelow")]
        BoundingBox ArticUnstressBelow { get; }

        [DataMember(Name = "augmentationDot")]
        BoundingBox AugmentationDot { get; }

        [DataMember(Name = "barlineDashed")]
        BoundingBox BarlineDashed { get; }

        [DataMember(Name = "barlineDotted")]
        BoundingBox BarlineDotted { get; }

        [DataMember(Name = "barlineDouble")]
        BoundingBox BarlineDouble { get; }

        [DataMember(Name = "barlineFinal")]
        BoundingBox BarlineFinal { get; }

        [DataMember(Name = "barlineHeavy")]
        BoundingBox BarlineHeavy { get; }

        [DataMember(Name = "barlineHeavyHeavy")]
        BoundingBox BarlineHeavyHeavy { get; }

        [DataMember(Name = "barlineReverseFinal")]
        BoundingBox BarlineReverseFinal { get; }

        [DataMember(Name = "barlineShort")]
        BoundingBox BarlineShort { get; }

        [DataMember(Name = "barlineSingle")]
        BoundingBox BarlineSingle { get; }

        [DataMember(Name = "barlineTick")]
        BoundingBox BarlineTick { get; }

        [DataMember(Name = "beamAccelRit1")]
        BoundingBox BeamAccelRit1 { get; }

        [DataMember(Name = "beamAccelRit10")]
        BoundingBox BeamAccelRit10 { get; }

        [DataMember(Name = "beamAccelRit11")]
        BoundingBox BeamAccelRit11 { get; }

        [DataMember(Name = "beamAccelRit12")]
        BoundingBox BeamAccelRit12 { get; }

        [DataMember(Name = "beamAccelRit13")]
        BoundingBox BeamAccelRit13 { get; }

        [DataMember(Name = "beamAccelRit14")]
        BoundingBox BeamAccelRit14 { get; }

        [DataMember(Name = "beamAccelRit15")]
        BoundingBox BeamAccelRit15 { get; }

        [DataMember(Name = "beamAccelRit2")]
        BoundingBox BeamAccelRit2 { get; }

        [DataMember(Name = "beamAccelRit3")]
        BoundingBox BeamAccelRit3 { get; }

        [DataMember(Name = "beamAccelRit4")]
        BoundingBox BeamAccelRit4 { get; }

        [DataMember(Name = "beamAccelRit5")]
        BoundingBox BeamAccelRit5 { get; }

        [DataMember(Name = "beamAccelRit6")]
        BoundingBox BeamAccelRit6 { get; }

        [DataMember(Name = "beamAccelRit7")]
        BoundingBox BeamAccelRit7 { get; }

        [DataMember(Name = "beamAccelRit8")]
        BoundingBox BeamAccelRit8 { get; }

        [DataMember(Name = "beamAccelRit9")]
        BoundingBox BeamAccelRit9 { get; }

        [DataMember(Name = "beamAccelRitFinal")]
        BoundingBox BeamAccelRitFinal { get; }

        [DataMember(Name = "brace")]
        BoundingBox Brace { get; }

        [DataMember(Name = "braceFlat")]
        BoundingBox BraceFlat { get; }

        [DataMember(Name = "braceLarge")]
        BoundingBox BraceLarge { get; }

        [DataMember(Name = "braceLarger")]
        BoundingBox BraceLarger { get; }

        [DataMember(Name = "braceSmall")]
        BoundingBox BraceSmall { get; }

        [DataMember(Name = "bracket")]
        BoundingBox Bracket { get; }

        [DataMember(Name = "bracketBottom")]
        BoundingBox BracketBottom { get; }

        [DataMember(Name = "bracketTop")]
        BoundingBox BracketTop { get; }

        [DataMember(Name = "brassBend")]
        BoundingBox BrassBend { get; }

        [DataMember(Name = "brassDoitLong")]
        BoundingBox BrassDoitLong { get; }

        [DataMember(Name = "brassDoitMedium")]
        BoundingBox BrassDoitMedium { get; }

        [DataMember(Name = "brassDoitShort")]
        BoundingBox BrassDoitShort { get; }

        [DataMember(Name = "brassFallLipLong")]
        BoundingBox BrassFallLipLong { get; }

        [DataMember(Name = "brassFallLipMedium")]
        BoundingBox BrassFallLipMedium { get; }

        [DataMember(Name = "brassFallLipShort")]
        BoundingBox BrassFallLipShort { get; }

        [DataMember(Name = "brassFallRoughLong")]
        BoundingBox BrassFallRoughLong { get; }

        [DataMember(Name = "brassFallRoughMedium")]
        BoundingBox BrassFallRoughMedium { get; }

        [DataMember(Name = "brassFallRoughShort")]
        BoundingBox BrassFallRoughShort { get; }

        [DataMember(Name = "brassFallSmoothLong")]
        BoundingBox BrassFallSmoothLong { get; }

        [DataMember(Name = "brassFallSmoothMedium")]
        BoundingBox BrassFallSmoothMedium { get; }

        [DataMember(Name = "brassFallSmoothShort")]
        BoundingBox BrassFallSmoothShort { get; }

        [DataMember(Name = "brassFlip")]
        BoundingBox BrassFlip { get; }

        [DataMember(Name = "brassHarmonMuteClosed")]
        BoundingBox BrassHarmonMuteClosed { get; }

        [DataMember(Name = "brassHarmonMuteStemHalfLeft")]
        BoundingBox BrassHarmonMuteStemHalfLeft { get; }

        [DataMember(Name = "brassHarmonMuteStemHalfRight")]
        BoundingBox BrassHarmonMuteStemHalfRight { get; }

        [DataMember(Name = "brassHarmonMuteStemOpen")]
        BoundingBox BrassHarmonMuteStemOpen { get; }

        [DataMember(Name = "brassJazzTurn")]
        BoundingBox BrassJazzTurn { get; }

        [DataMember(Name = "brassLiftLong")]
        BoundingBox BrassLiftLong { get; }

        [DataMember(Name = "brassLiftMedium")]
        BoundingBox BrassLiftMedium { get; }

        [DataMember(Name = "brassLiftShort")]
        BoundingBox BrassLiftShort { get; }

        [DataMember(Name = "brassLiftSmoothLong")]
        BoundingBox BrassLiftSmoothLong { get; }

        [DataMember(Name = "brassLiftSmoothMedium")]
        BoundingBox BrassLiftSmoothMedium { get; }

        [DataMember(Name = "brassLiftSmoothShort")]
        BoundingBox BrassLiftSmoothShort { get; }

        [DataMember(Name = "brassMuteClosed")]
        BoundingBox BrassMuteClosed { get; }

        [DataMember(Name = "brassMuteHalfClosed")]
        BoundingBox BrassMuteHalfClosed { get; }

        [DataMember(Name = "brassMuteOpen")]
        BoundingBox BrassMuteOpen { get; }

        [DataMember(Name = "brassPlop")]
        BoundingBox BrassPlop { get; }

        [DataMember(Name = "brassScoop")]
        BoundingBox BrassScoop { get; }

        [DataMember(Name = "brassSmear")]
        BoundingBox BrassSmear { get; }

        [DataMember(Name = "brassValveTrill")]
        BoundingBox BrassValveTrill { get; }

        [DataMember(Name = "breathMarkComma")]
        BoundingBox BreathMarkComma { get; }

        [DataMember(Name = "breathMarkSalzedo")]
        BoundingBox BreathMarkSalzedo { get; }

        [DataMember(Name = "breathMarkTick")]
        BoundingBox BreathMarkTick { get; }

        [DataMember(Name = "breathMarkUpbow")]
        BoundingBox BreathMarkUpbow { get; }

        [DataMember(Name = "bridgeClef")]
        BoundingBox BridgeClef { get; }

        [DataMember(Name = "buzzRoll")]
        BoundingBox BuzzRoll { get; }

        [DataMember(Name = "cClef")]
        BoundingBox CClef { get; }

        [DataMember(Name = "cClef8vb")]
        BoundingBox CClef8Vb { get; }

        [DataMember(Name = "cClefArrowDown")]
        BoundingBox CClefArrowDown { get; }

        [DataMember(Name = "cClefArrowUp")]
        BoundingBox CClefArrowUp { get; }

        [DataMember(Name = "cClefChange")]
        BoundingBox CClefChange { get; }

        [DataMember(Name = "cClefCombining")]
        BoundingBox CClefCombining { get; }

        [DataMember(Name = "cClefFrench")]
        BoundingBox CClefFrench { get; }

        [DataMember(Name = "cClefFrench20C")]
        BoundingBox CClefFrench20C { get; }

        [DataMember(Name = "cClefFrench20CChange")]
        BoundingBox CClefFrench20CChange { get; }

        [DataMember(Name = "cClefReversed")]
        BoundingBox CClefReversed { get; }

        [DataMember(Name = "cClefSmall")]
        BoundingBox CClefSmall { get; }

        [DataMember(Name = "cClefSquare")]
        BoundingBox CClefSquare { get; }

        [DataMember(Name = "caesura")]
        BoundingBox Caesura { get; }

        [DataMember(Name = "caesuraCurved")]
        BoundingBox CaesuraCurved { get; }

        [DataMember(Name = "caesuraShort")]
        BoundingBox CaesuraShort { get; }

        [DataMember(Name = "caesuraSingleStroke")]
        BoundingBox CaesuraSingleStroke { get; }

        [DataMember(Name = "caesuraThick")]
        BoundingBox CaesuraThick { get; }

        [DataMember(Name = "chantAccentusAbove")]
        BoundingBox ChantAccentusAbove { get; }

        [DataMember(Name = "chantAccentusBelow")]
        BoundingBox ChantAccentusBelow { get; }

        [DataMember(Name = "chantAuctumAsc")]
        BoundingBox ChantAuctumAsc { get; }

        [DataMember(Name = "chantAuctumDesc")]
        BoundingBox ChantAuctumDesc { get; }

        [DataMember(Name = "chantAugmentum")]
        BoundingBox ChantAugmentum { get; }

        [DataMember(Name = "chantCaesura")]
        BoundingBox ChantCaesura { get; }

        [DataMember(Name = "chantCclef")]
        BoundingBox ChantCclef { get; }

        [DataMember(Name = "chantCclefHufnagel")]
        BoundingBox ChantCclefHufnagel { get; }

        [DataMember(Name = "chantCirculusAbove")]
        BoundingBox ChantCirculusAbove { get; }

        [DataMember(Name = "chantCirculusBelow")]
        BoundingBox ChantCirculusBelow { get; }

        [DataMember(Name = "chantConnectingLineAsc2nd")]
        BoundingBox ChantConnectingLineAsc2Nd { get; }

        [DataMember(Name = "chantConnectingLineAsc3rd")]
        BoundingBox ChantConnectingLineAsc3Rd { get; }

        [DataMember(Name = "chantConnectingLineAsc4th")]
        BoundingBox ChantConnectingLineAsc4Th { get; }

        [DataMember(Name = "chantConnectingLineAsc5th")]
        BoundingBox ChantConnectingLineAsc5Th { get; }

        [DataMember(Name = "chantConnectingLineAsc6th")]
        BoundingBox ChantConnectingLineAsc6Th { get; }

        [DataMember(Name = "chantCustosStemDownPosHigh")]
        BoundingBox ChantCustosStemDownPosHigh { get; }

        [DataMember(Name = "chantCustosStemDownPosHighest")]
        BoundingBox ChantCustosStemDownPosHighest { get; }

        [DataMember(Name = "chantCustosStemDownPosMiddle")]
        BoundingBox ChantCustosStemDownPosMiddle { get; }

        [DataMember(Name = "chantCustosStemUpPosLow")]
        BoundingBox ChantCustosStemUpPosLow { get; }

        [DataMember(Name = "chantCustosStemUpPosLowest")]
        BoundingBox ChantCustosStemUpPosLowest { get; }

        [DataMember(Name = "chantCustosStemUpPosMiddle")]
        BoundingBox ChantCustosStemUpPosMiddle { get; }

        [DataMember(Name = "chantDeminutumLower")]
        BoundingBox ChantDeminutumLower { get; }

        [DataMember(Name = "chantDeminutumUpper")]
        BoundingBox ChantDeminutumUpper { get; }

        [DataMember(Name = "chantDivisioFinalis")]
        BoundingBox ChantDivisioFinalis { get; }

        [DataMember(Name = "chantDivisioMaior")]
        BoundingBox ChantDivisioMaior { get; }

        [DataMember(Name = "chantDivisioMaxima")]
        BoundingBox ChantDivisioMaxima { get; }

        [DataMember(Name = "chantDivisioMinima")]
        BoundingBox ChantDivisioMinima { get; }

        [DataMember(Name = "chantEntryLineAsc2nd")]
        BoundingBox ChantEntryLineAsc2Nd { get; }

        [DataMember(Name = "chantEntryLineAsc3rd")]
        BoundingBox ChantEntryLineAsc3Rd { get; }

        [DataMember(Name = "chantEntryLineAsc4th")]
        BoundingBox ChantEntryLineAsc4Th { get; }

        [DataMember(Name = "chantEntryLineAsc5th")]
        BoundingBox ChantEntryLineAsc5Th { get; }

        [DataMember(Name = "chantEntryLineAsc6th")]
        BoundingBox ChantEntryLineAsc6Th { get; }

        [DataMember(Name = "chantEpisema")]
        BoundingBox ChantEpisema { get; }

        [DataMember(Name = "chantFclef")]
        BoundingBox ChantFclef { get; }

        [DataMember(Name = "chantFclefHufnagel")]
        BoundingBox ChantFclefHufnagel { get; }

        [DataMember(Name = "chantIctusAbove")]
        BoundingBox ChantIctusAbove { get; }

        [DataMember(Name = "chantIctusBelow")]
        BoundingBox ChantIctusBelow { get; }

        [DataMember(Name = "chantLigaturaDesc2nd")]
        BoundingBox ChantLigaturaDesc2Nd { get; }

        [DataMember(Name = "chantLigaturaDesc3rd")]
        BoundingBox ChantLigaturaDesc3Rd { get; }

        [DataMember(Name = "chantLigaturaDesc4th")]
        BoundingBox ChantLigaturaDesc4Th { get; }

        [DataMember(Name = "chantLigaturaDesc5th")]
        BoundingBox ChantLigaturaDesc5Th { get; }

        [DataMember(Name = "chantOriscusAscending")]
        BoundingBox ChantOriscusAscending { get; }

        [DataMember(Name = "chantOriscusDescending")]
        BoundingBox ChantOriscusDescending { get; }

        [DataMember(Name = "chantOriscusLiquescens")]
        BoundingBox ChantOriscusLiquescens { get; }

        [DataMember(Name = "chantPodatusLower")]
        BoundingBox ChantPodatusLower { get; }

        [DataMember(Name = "chantPodatusUpper")]
        BoundingBox ChantPodatusUpper { get; }

        [DataMember(Name = "chantPunctum")]
        BoundingBox ChantPunctum { get; }

        [DataMember(Name = "chantPunctumCavum")]
        BoundingBox ChantPunctumCavum { get; }

        [DataMember(Name = "chantPunctumDeminutum")]
        BoundingBox ChantPunctumDeminutum { get; }

        [DataMember(Name = "chantPunctumInclinatum")]
        BoundingBox ChantPunctumInclinatum { get; }

        [DataMember(Name = "chantPunctumInclinatumAuctum")]
        BoundingBox ChantPunctumInclinatumAuctum { get; }

        [DataMember(Name = "chantPunctumInclinatumDeminutum")]
        BoundingBox ChantPunctumInclinatumDeminutum { get; }

        [DataMember(Name = "chantPunctumLinea")]
        BoundingBox ChantPunctumLinea { get; }

        [DataMember(Name = "chantPunctumLineaCavum")]
        BoundingBox ChantPunctumLineaCavum { get; }

        [DataMember(Name = "chantPunctumVirga")]
        BoundingBox ChantPunctumVirga { get; }

        [DataMember(Name = "chantPunctumVirgaReversed")]
        BoundingBox ChantPunctumVirgaReversed { get; }

        [DataMember(Name = "chantQuilisma")]
        BoundingBox ChantQuilisma { get; }

        [DataMember(Name = "chantSemicirculusAbove")]
        BoundingBox ChantSemicirculusAbove { get; }

        [DataMember(Name = "chantSemicirculusBelow")]
        BoundingBox ChantSemicirculusBelow { get; }

        [DataMember(Name = "chantStaff")]
        BoundingBox ChantStaff { get; }

        [DataMember(Name = "chantStaffNarrow")]
        BoundingBox ChantStaffNarrow { get; }

        [DataMember(Name = "chantStaffWide")]
        BoundingBox ChantStaffWide { get; }

        [DataMember(Name = "chantStrophicus")]
        BoundingBox ChantStrophicus { get; }

        [DataMember(Name = "chantStrophicusAuctus")]
        BoundingBox ChantStrophicusAuctus { get; }

        [DataMember(Name = "chantStrophicusLiquescens2nd")]
        BoundingBox ChantStrophicusLiquescens2Nd { get; }

        [DataMember(Name = "chantStrophicusLiquescens3rd")]
        BoundingBox ChantStrophicusLiquescens3Rd { get; }

        [DataMember(Name = "chantStrophicusLiquescens4th")]
        BoundingBox ChantStrophicusLiquescens4Th { get; }

        [DataMember(Name = "chantStrophicusLiquescens5th")]
        BoundingBox ChantStrophicusLiquescens5Th { get; }

        [DataMember(Name = "chantVirgula")]
        BoundingBox ChantVirgula { get; }

        [DataMember(Name = "clef15")]
        BoundingBox Clef15 { get; }

        [DataMember(Name = "clef8")]
        BoundingBox Clef8 { get; }

        [DataMember(Name = "coda")]
        BoundingBox Coda { get; }

        [DataMember(Name = "codaJapanese")]
        BoundingBox CodaJapanese { get; }

        [DataMember(Name = "codaSquare")]
        BoundingBox CodaSquare { get; }

        [DataMember(Name = "conductorBeat2Compound")]
        BoundingBox ConductorBeat2Compound { get; }

        [DataMember(Name = "conductorBeat2Simple")]
        BoundingBox ConductorBeat2Simple { get; }

        [DataMember(Name = "conductorBeat3Compound")]
        BoundingBox ConductorBeat3Compound { get; }

        [DataMember(Name = "conductorBeat3Simple")]
        BoundingBox ConductorBeat3Simple { get; }

        [DataMember(Name = "conductorBeat4Compound")]
        BoundingBox ConductorBeat4Compound { get; }

        [DataMember(Name = "conductorBeat4Simple")]
        BoundingBox ConductorBeat4Simple { get; }

        [DataMember(Name = "conductorLeftBeat")]
        BoundingBox ConductorLeftBeat { get; }

        [DataMember(Name = "conductorRightBeat")]
        BoundingBox ConductorRightBeat { get; }

        [DataMember(Name = "conductorStrongBeat")]
        BoundingBox ConductorStrongBeat { get; }

        [DataMember(Name = "conductorUnconducted")]
        BoundingBox ConductorUnconducted { get; }

        [DataMember(Name = "conductorWeakBeat")]
        BoundingBox ConductorWeakBeat { get; }

        [DataMember(Name = "csymAugmented")]
        BoundingBox CsymAugmented { get; }

        [DataMember(Name = "csymBracketLeftTall")]
        BoundingBox CsymBracketLeftTall { get; }

        [DataMember(Name = "csymBracketRightTall")]
        BoundingBox CsymBracketRightTall { get; }

        [DataMember(Name = "csymDiminished")]
        BoundingBox CsymDiminished { get; }

        [DataMember(Name = "csymHalfDiminished")]
        BoundingBox CsymHalfDiminished { get; }

        [DataMember(Name = "csymMajorSeventh")]
        BoundingBox CsymMajorSeventh { get; }

        [DataMember(Name = "csymMinor")]
        BoundingBox CsymMinor { get; }

        [DataMember(Name = "csymParensLeftTall")]
        BoundingBox CsymParensLeftTall { get; }

        [DataMember(Name = "csymParensRightTall")]
        BoundingBox CsymParensRightTall { get; }

        [DataMember(Name = "curlewSign")]
        BoundingBox CurlewSign { get; }

        [DataMember(Name = "daCapo")]
        BoundingBox DaCapo { get; }

        [DataMember(Name = "dalSegno")]
        BoundingBox DalSegno { get; }

        [DataMember(Name = "daseianExcellentes1")]
        BoundingBox DaseianExcellentes1 { get; }

        [DataMember(Name = "daseianExcellentes2")]
        BoundingBox DaseianExcellentes2 { get; }

        [DataMember(Name = "daseianExcellentes3")]
        BoundingBox DaseianExcellentes3 { get; }

        [DataMember(Name = "daseianExcellentes4")]
        BoundingBox DaseianExcellentes4 { get; }

        [DataMember(Name = "daseianFinales1")]
        BoundingBox DaseianFinales1 { get; }

        [DataMember(Name = "daseianFinales2")]
        BoundingBox DaseianFinales2 { get; }

        [DataMember(Name = "daseianFinales3")]
        BoundingBox DaseianFinales3 { get; }

        [DataMember(Name = "daseianFinales4")]
        BoundingBox DaseianFinales4 { get; }

        [DataMember(Name = "daseianGraves1")]
        BoundingBox DaseianGraves1 { get; }

        [DataMember(Name = "daseianGraves2")]
        BoundingBox DaseianGraves2 { get; }

        [DataMember(Name = "daseianGraves3")]
        BoundingBox DaseianGraves3 { get; }

        [DataMember(Name = "daseianGraves4")]
        BoundingBox DaseianGraves4 { get; }

        [DataMember(Name = "daseianResidua1")]
        BoundingBox DaseianResidua1 { get; }

        [DataMember(Name = "daseianResidua2")]
        BoundingBox DaseianResidua2 { get; }

        [DataMember(Name = "daseianSuperiores1")]
        BoundingBox DaseianSuperiores1 { get; }

        [DataMember(Name = "daseianSuperiores2")]
        BoundingBox DaseianSuperiores2 { get; }

        [DataMember(Name = "daseianSuperiores3")]
        BoundingBox DaseianSuperiores3 { get; }

        [DataMember(Name = "daseianSuperiores4")]
        BoundingBox DaseianSuperiores4 { get; }

        [DataMember(Name = "doubleTongueAbove")]
        BoundingBox DoubleTongueAbove { get; }

        [DataMember(Name = "doubleTongueAboveNoSlur")]
        BoundingBox DoubleTongueAboveNoSlur { get; }

        [DataMember(Name = "doubleTongueBelow")]
        BoundingBox DoubleTongueBelow { get; }

        [DataMember(Name = "doubleTongueBelowNoSlur")]
        BoundingBox DoubleTongueBelowNoSlur { get; }

        [DataMember(Name = "dynamicCombinedSeparatorColon")]
        BoundingBox DynamicCombinedSeparatorColon { get; }

        [DataMember(Name = "dynamicCombinedSeparatorHyphen")]
        BoundingBox DynamicCombinedSeparatorHyphen { get; }

        [DataMember(Name = "dynamicCrescendoHairpin")]
        BoundingBox DynamicCrescendoHairpin { get; }

        [DataMember(Name = "dynamicDiminuendoHairpin")]
        BoundingBox DynamicDiminuendoHairpin { get; }

        [DataMember(Name = "dynamicFF")]
        BoundingBox DynamicFf { get; }

        [DataMember(Name = "dynamicFFF")]
        BoundingBox DynamicFff { get; }

        [DataMember(Name = "dynamicFFFF")]
        BoundingBox DynamicFfff { get; }

        [DataMember(Name = "dynamicFFFFF")]
        BoundingBox DynamicFffff { get; }

        [DataMember(Name = "dynamicFFFFFF")]
        BoundingBox DynamicFfffff { get; }

        [DataMember(Name = "dynamicForte")]
        BoundingBox DynamicForte { get; }

        [DataMember(Name = "dynamicFortePiano")]
        BoundingBox DynamicFortePiano { get; }

        [DataMember(Name = "dynamicForteSmall")]
        BoundingBox DynamicForteSmall { get; }

        [DataMember(Name = "dynamicForzando")]
        BoundingBox DynamicForzando { get; }

        [DataMember(Name = "dynamicHairpinBracketLeft")]
        BoundingBox DynamicHairpinBracketLeft { get; }

        [DataMember(Name = "dynamicHairpinBracketRight")]
        BoundingBox DynamicHairpinBracketRight { get; }

        [DataMember(Name = "dynamicHairpinParenthesisLeft")]
        BoundingBox DynamicHairpinParenthesisLeft { get; }

        [DataMember(Name = "dynamicHairpinParenthesisRight")]
        BoundingBox DynamicHairpinParenthesisRight { get; }

        [DataMember(Name = "dynamicMF")]
        BoundingBox DynamicMf { get; }

        [DataMember(Name = "dynamicMP")]
        BoundingBox DynamicMp { get; }

        [DataMember(Name = "dynamicMessaDiVoce")]
        BoundingBox DynamicMessaDiVoce { get; }

        [DataMember(Name = "dynamicMezzo")]
        BoundingBox DynamicMezzo { get; }

        [DataMember(Name = "dynamicMezzoSmall")]
        BoundingBox DynamicMezzoSmall { get; }

        [DataMember(Name = "dynamicNiente")]
        BoundingBox DynamicNiente { get; }

        [DataMember(Name = "dynamicNienteForHairpin")]
        BoundingBox DynamicNienteForHairpin { get; }

        [DataMember(Name = "dynamicNienteSmall")]
        BoundingBox DynamicNienteSmall { get; }

        [DataMember(Name = "dynamicPF")]
        BoundingBox DynamicPf { get; }

        [DataMember(Name = "dynamicPP")]
        BoundingBox DynamicPp { get; }

        [DataMember(Name = "dynamicPPP")]
        BoundingBox DynamicPpp { get; }

        [DataMember(Name = "dynamicPPPP")]
        BoundingBox DynamicPppp { get; }

        [DataMember(Name = "dynamicPPPPP")]
        BoundingBox DynamicPpppp { get; }

        [DataMember(Name = "dynamicPPPPPP")]
        BoundingBox DynamicPppppp { get; }

        [DataMember(Name = "dynamicPiano")]
        BoundingBox DynamicPiano { get; }

        [DataMember(Name = "dynamicPianoSmall")]
        BoundingBox DynamicPianoSmall { get; }

        [DataMember(Name = "dynamicRinforzando")]
        BoundingBox DynamicRinforzando { get; }

        [DataMember(Name = "dynamicRinforzando1")]
        BoundingBox DynamicRinforzando1 { get; }

        [DataMember(Name = "dynamicRinforzando2")]
        BoundingBox DynamicRinforzando2 { get; }

        [DataMember(Name = "dynamicRinforzandoSmall")]
        BoundingBox DynamicRinforzandoSmall { get; }

        [DataMember(Name = "dynamicSforzando")]
        BoundingBox DynamicSforzando { get; }

        [DataMember(Name = "dynamicSforzando1")]
        BoundingBox DynamicSforzando1 { get; }

        [DataMember(Name = "dynamicSforzandoPianissimo")]
        BoundingBox DynamicSforzandoPianissimo { get; }

        [DataMember(Name = "dynamicSforzandoPiano")]
        BoundingBox DynamicSforzandoPiano { get; }

        [DataMember(Name = "dynamicSforzandoSmall")]
        BoundingBox DynamicSforzandoSmall { get; }

        [DataMember(Name = "dynamicSforzato")]
        BoundingBox DynamicSforzato { get; }

        [DataMember(Name = "dynamicSforzatoFF")]
        BoundingBox DynamicSforzatoFf { get; }

        [DataMember(Name = "dynamicSforzatoPiano")]
        BoundingBox DynamicSforzatoPiano { get; }

        [DataMember(Name = "dynamicZ")]
        BoundingBox DynamicZ { get; }

        [DataMember(Name = "dynamicZSmall")]
        BoundingBox DynamicZSmall { get; }

        [DataMember(Name = "elecAudioChannelsEight")]
        BoundingBox ElecAudioChannelsEight { get; }

        [DataMember(Name = "elecAudioChannelsFive")]
        BoundingBox ElecAudioChannelsFive { get; }

        [DataMember(Name = "elecAudioChannelsFour")]
        BoundingBox ElecAudioChannelsFour { get; }

        [DataMember(Name = "elecAudioChannelsOne")]
        BoundingBox ElecAudioChannelsOne { get; }

        [DataMember(Name = "elecAudioChannelsSeven")]
        BoundingBox ElecAudioChannelsSeven { get; }

        [DataMember(Name = "elecAudioChannelsSix")]
        BoundingBox ElecAudioChannelsSix { get; }

        [DataMember(Name = "elecAudioChannelsThreeFrontal")]
        BoundingBox ElecAudioChannelsThreeFrontal { get; }

        [DataMember(Name = "elecAudioChannelsThreeSurround")]
        BoundingBox ElecAudioChannelsThreeSurround { get; }

        [DataMember(Name = "elecAudioChannelsTwo")]
        BoundingBox ElecAudioChannelsTwo { get; }

        [DataMember(Name = "elecAudioIn")]
        BoundingBox ElecAudioIn { get; }

        [DataMember(Name = "elecAudioMono")]
        BoundingBox ElecAudioMono { get; }

        [DataMember(Name = "elecAudioOut")]
        BoundingBox ElecAudioOut { get; }

        [DataMember(Name = "elecAudioStereo")]
        BoundingBox ElecAudioStereo { get; }

        [DataMember(Name = "elecCamera")]
        BoundingBox ElecCamera { get; }

        [DataMember(Name = "elecDataIn")]
        BoundingBox ElecDataIn { get; }

        [DataMember(Name = "elecDataOut")]
        BoundingBox ElecDataOut { get; }

        [DataMember(Name = "elecDisc")]
        Dictionary<string, long[]> ElecDisc { get; }

        [DataMember(Name = "elecDownload")]
        BoundingBox ElecDownload { get; }

        [DataMember(Name = "elecEject")]
        BoundingBox ElecEject { get; }

        [DataMember(Name = "elecFastForward")]
        BoundingBox ElecFastForward { get; }

        [DataMember(Name = "elecHeadphones")]
        BoundingBox ElecHeadphones { get; }

        [DataMember(Name = "elecHeadset")]
        BoundingBox ElecHeadset { get; }

        [DataMember(Name = "elecLineIn")]
        BoundingBox ElecLineIn { get; }

        [DataMember(Name = "elecLineOut")]
        BoundingBox ElecLineOut { get; }

        [DataMember(Name = "elecLoop")]
        BoundingBox ElecLoop { get; }

        [DataMember(Name = "elecLoudspeaker")]
        BoundingBox ElecLoudspeaker { get; }

        [DataMember(Name = "elecMIDIController0")]
        BoundingBox ElecMidiController0 { get; }

        [DataMember(Name = "elecMIDIController100")]
        BoundingBox ElecMidiController100 { get; }

        [DataMember(Name = "elecMIDIController20")]
        BoundingBox ElecMidiController20 { get; }

        [DataMember(Name = "elecMIDIController40")]
        BoundingBox ElecMidiController40 { get; }

        [DataMember(Name = "elecMIDIController60")]
        BoundingBox ElecMidiController60 { get; }

        [DataMember(Name = "elecMIDIController80")]
        BoundingBox ElecMidiController80 { get; }

        [DataMember(Name = "elecMIDIIn")]
        BoundingBox ElecMidiIn { get; }

        [DataMember(Name = "elecMIDIOut")]
        BoundingBox ElecMidiOut { get; }

        [DataMember(Name = "elecMicrophone")]
        BoundingBox ElecMicrophone { get; }

        [DataMember(Name = "elecMicrophoneMute")]
        BoundingBox ElecMicrophoneMute { get; }

        [DataMember(Name = "elecMicrophoneUnmute")]
        BoundingBox ElecMicrophoneUnmute { get; }

        [DataMember(Name = "elecMixingConsole")]
        BoundingBox ElecMixingConsole { get; }

        [DataMember(Name = "elecMonitor")]
        BoundingBox ElecMonitor { get; }

        [DataMember(Name = "elecMute")]
        BoundingBox ElecMute { get; }

        [DataMember(Name = "elecPause")]
        BoundingBox ElecPause { get; }

        [DataMember(Name = "elecPlay")]
        BoundingBox ElecPlay { get; }

        [DataMember(Name = "elecPowerOnOff")]
        BoundingBox ElecPowerOnOff { get; }

        [DataMember(Name = "elecProjector")]
        BoundingBox ElecProjector { get; }

        [DataMember(Name = "elecReplay")]
        BoundingBox ElecReplay { get; }

        [DataMember(Name = "elecRewind")]
        BoundingBox ElecRewind { get; }

        [DataMember(Name = "elecShuffle")]
        BoundingBox ElecShuffle { get; }

        [DataMember(Name = "elecSkipBackwards")]
        BoundingBox ElecSkipBackwards { get; }

        [DataMember(Name = "elecSkipForwards")]
        BoundingBox ElecSkipForwards { get; }

        [DataMember(Name = "elecStop")]
        BoundingBox ElecStop { get; }

        [DataMember(Name = "elecTape")]
        BoundingBox ElecTape { get; }

        [DataMember(Name = "elecUSB")]
        BoundingBox ElecUsb { get; }

        [DataMember(Name = "elecUnmute")]
        BoundingBox ElecUnmute { get; }

        [DataMember(Name = "elecUpload")]
        BoundingBox ElecUpload { get; }

        [DataMember(Name = "elecVideoCamera")]
        BoundingBox ElecVideoCamera { get; }

        [DataMember(Name = "elecVideoIn")]
        BoundingBox ElecVideoIn { get; }

        [DataMember(Name = "elecVideoOut")]
        BoundingBox ElecVideoOut { get; }

        [DataMember(Name = "elecVolumeFader")]
        BoundingBox ElecVolumeFader { get; }

        [DataMember(Name = "elecVolumeFaderThumb")]
        BoundingBox ElecVolumeFaderThumb { get; }

        [DataMember(Name = "elecVolumeLevel0")]
        BoundingBox ElecVolumeLevel0 { get; }

        [DataMember(Name = "elecVolumeLevel100")]
        BoundingBox ElecVolumeLevel100 { get; }

        [DataMember(Name = "elecVolumeLevel20")]
        BoundingBox ElecVolumeLevel20 { get; }

        [DataMember(Name = "elecVolumeLevel40")]
        BoundingBox ElecVolumeLevel40 { get; }

        [DataMember(Name = "elecVolumeLevel60")]
        BoundingBox ElecVolumeLevel60 { get; }

        [DataMember(Name = "elecVolumeLevel80")]
        BoundingBox ElecVolumeLevel80 { get; }

        [DataMember(Name = "fClef")]
        BoundingBox FClef { get; }

        [DataMember(Name = "fClef15ma")]
        BoundingBox FClef15Ma { get; }

        [DataMember(Name = "fClef15mb")]
        BoundingBox FClef15Mb { get; }

        [DataMember(Name = "fClef19thCentury")]
        BoundingBox FClef19ThCentury { get; }

        [DataMember(Name = "fClef5Below")]
        BoundingBox FClef5Below { get; }

        [DataMember(Name = "fClef8va")]
        BoundingBox FClef8Va { get; }

        [DataMember(Name = "fClef8vb")]
        BoundingBox FClef8Vb { get; }

        [DataMember(Name = "fClefArrowDown")]
        BoundingBox FClefArrowDown { get; }

        [DataMember(Name = "fClefArrowUp")]
        BoundingBox FClefArrowUp { get; }

        [DataMember(Name = "fClefChange")]
        BoundingBox FClefChange { get; }

        [DataMember(Name = "fClefFrench")]
        BoundingBox FClefFrench { get; }

        [DataMember(Name = "fClefReversed")]
        BoundingBox FClefReversed { get; }

        [DataMember(Name = "fClefSmall")]
        BoundingBox FClefSmall { get; }

        [DataMember(Name = "fClefTurned")]
        BoundingBox FClefTurned { get; }

        [DataMember(Name = "fermataAbove")]
        BoundingBox FermataAbove { get; }

        [DataMember(Name = "fermataBelow")]
        BoundingBox FermataBelow { get; }

        [DataMember(Name = "fermataLongAbove")]
        BoundingBox FermataLongAbove { get; }

        [DataMember(Name = "fermataLongBelow")]
        BoundingBox FermataLongBelow { get; }

        [DataMember(Name = "fermataLongHenzeAbove")]
        BoundingBox FermataLongHenzeAbove { get; }

        [DataMember(Name = "fermataLongHenzeBelow")]
        BoundingBox FermataLongHenzeBelow { get; }

        [DataMember(Name = "fermataShortAbove")]
        BoundingBox FermataShortAbove { get; }

        [DataMember(Name = "fermataShortBelow")]
        BoundingBox FermataShortBelow { get; }

        [DataMember(Name = "fermataShortHenzeAbove")]
        BoundingBox FermataShortHenzeAbove { get; }

        [DataMember(Name = "fermataShortHenzeBelow")]
        BoundingBox FermataShortHenzeBelow { get; }

        [DataMember(Name = "fermataVeryLongAbove")]
        BoundingBox FermataVeryLongAbove { get; }

        [DataMember(Name = "fermataVeryLongBelow")]
        BoundingBox FermataVeryLongBelow { get; }

        [DataMember(Name = "fermataVeryShortAbove")]
        BoundingBox FermataVeryShortAbove { get; }

        [DataMember(Name = "fermataVeryShortBelow")]
        BoundingBox FermataVeryShortBelow { get; }

        [DataMember(Name = "figbass0")]
        BoundingBox Figbass0 { get; }

        [DataMember(Name = "figbass1")]
        BoundingBox Figbass1 { get; }

        [DataMember(Name = "figbass2")]
        BoundingBox Figbass2 { get; }

        [DataMember(Name = "figbass2Raised")]
        BoundingBox Figbass2Raised { get; }

        [DataMember(Name = "figbass3")]
        BoundingBox Figbass3 { get; }

        [DataMember(Name = "figbass4")]
        BoundingBox Figbass4 { get; }

        [DataMember(Name = "figbass4Raised")]
        BoundingBox Figbass4Raised { get; }

        [DataMember(Name = "figbass5")]
        BoundingBox Figbass5 { get; }

        [DataMember(Name = "figbass5Raised1")]
        BoundingBox Figbass5Raised1 { get; }

        [DataMember(Name = "figbass5Raised2")]
        BoundingBox Figbass5Raised2 { get; }

        [DataMember(Name = "figbass5Raised3")]
        BoundingBox Figbass5Raised3 { get; }

        [DataMember(Name = "figbass6")]
        BoundingBox Figbass6 { get; }

        [DataMember(Name = "figbass6Raised")]
        BoundingBox Figbass6Raised { get; }

        [DataMember(Name = "figbass6Raised2")]
        BoundingBox Figbass6Raised2 { get; }

        [DataMember(Name = "figbass7")]
        BoundingBox Figbass7 { get; }

        [DataMember(Name = "figbass7Diminished")]
        BoundingBox Figbass7Diminished { get; }

        [DataMember(Name = "figbass7Raised1")]
        BoundingBox Figbass7Raised1 { get; }

        [DataMember(Name = "figbass7Raised2")]
        BoundingBox Figbass7Raised2 { get; }

        [DataMember(Name = "figbass8")]
        BoundingBox Figbass8 { get; }

        [DataMember(Name = "figbass9")]
        BoundingBox Figbass9 { get; }

        [DataMember(Name = "figbass9Raised")]
        BoundingBox Figbass9Raised { get; }

        [DataMember(Name = "figbassBracketLeft")]
        BoundingBox FigbassBracketLeft { get; }

        [DataMember(Name = "figbassBracketRight")]
        BoundingBox FigbassBracketRight { get; }

        [DataMember(Name = "figbassCombiningLowering")]
        BoundingBox FigbassCombiningLowering { get; }

        [DataMember(Name = "figbassCombiningRaising")]
        BoundingBox FigbassCombiningRaising { get; }

        [DataMember(Name = "figbassDoubleFlat")]
        BoundingBox FigbassDoubleFlat { get; }

        [DataMember(Name = "figbassDoubleSharp")]
        BoundingBox FigbassDoubleSharp { get; }

        [DataMember(Name = "figbassFlat")]
        BoundingBox FigbassFlat { get; }

        [DataMember(Name = "figbassNatural")]
        BoundingBox FigbassNatural { get; }

        [DataMember(Name = "figbassParensLeft")]
        BoundingBox FigbassParensLeft { get; }

        [DataMember(Name = "figbassParensRight")]
        BoundingBox FigbassParensRight { get; }

        [DataMember(Name = "figbassPlus")]
        BoundingBox FigbassPlus { get; }

        [DataMember(Name = "figbassSharp")]
        BoundingBox FigbassSharp { get; }

        [DataMember(Name = "fingering0")]
        BoundingBox Fingering0 { get; }

        [DataMember(Name = "fingering1")]
        BoundingBox Fingering1 { get; }

        [DataMember(Name = "fingering2")]
        BoundingBox Fingering2 { get; }

        [DataMember(Name = "fingering3")]
        BoundingBox Fingering3 { get; }

        [DataMember(Name = "fingering4")]
        BoundingBox Fingering4 { get; }

        [DataMember(Name = "fingering5")]
        BoundingBox Fingering5 { get; }

        [DataMember(Name = "fingeringALower")]
        BoundingBox FingeringALower { get; }

        [DataMember(Name = "fingeringCLower")]
        BoundingBox FingeringCLower { get; }

        [DataMember(Name = "fingeringELower")]
        BoundingBox FingeringELower { get; }

        [DataMember(Name = "fingeringILower")]
        BoundingBox FingeringILower { get; }

        [DataMember(Name = "fingeringMLower")]
        BoundingBox FingeringMLower { get; }

        [DataMember(Name = "fingeringMultipleNotes")]
        BoundingBox FingeringMultipleNotes { get; }

        [DataMember(Name = "fingeringOLower")]
        BoundingBox FingeringOLower { get; }

        [DataMember(Name = "fingeringPLower")]
        BoundingBox FingeringPLower { get; }

        [DataMember(Name = "fingeringSubstitutionAbove")]
        BoundingBox FingeringSubstitutionAbove { get; }

        [DataMember(Name = "fingeringSubstitutionBelow")]
        BoundingBox FingeringSubstitutionBelow { get; }

        [DataMember(Name = "fingeringSubstitutionDash")]
        BoundingBox FingeringSubstitutionDash { get; }

        [DataMember(Name = "fingeringTLower")]
        BoundingBox FingeringTLower { get; }

        [DataMember(Name = "fingeringTUpper")]
        BoundingBox FingeringTUpper { get; }

        [DataMember(Name = "fingeringXLower")]
        BoundingBox FingeringXLower { get; }

        [DataMember(Name = "flag1024thDown")]
        BoundingBox Flag1024ThDown { get; }

        [DataMember(Name = "flag1024thDownSmall")]
        BoundingBox Flag1024ThDownSmall { get; }

        [DataMember(Name = "flag1024thDownStraight")]
        BoundingBox Flag1024ThDownStraight { get; }

        [DataMember(Name = "flag1024thUp")]
        BoundingBox Flag1024ThUp { get; }

        [DataMember(Name = "flag1024thUpShort")]
        BoundingBox Flag1024ThUpShort { get; }

        [DataMember(Name = "flag1024thUpSmall")]
        BoundingBox Flag1024ThUpSmall { get; }

        [DataMember(Name = "flag1024thUpStraight")]
        BoundingBox Flag1024ThUpStraight { get; }

        [DataMember(Name = "flag128thDown")]
        BoundingBox Flag128ThDown { get; }

        [DataMember(Name = "flag128thDownSmall")]
        BoundingBox Flag128ThDownSmall { get; }

        [DataMember(Name = "flag128thDownStraight")]
        BoundingBox Flag128ThDownStraight { get; }

        [DataMember(Name = "flag128thUp")]
        BoundingBox Flag128ThUp { get; }

        [DataMember(Name = "flag128thUpShort")]
        BoundingBox Flag128ThUpShort { get; }

        [DataMember(Name = "flag128thUpSmall")]
        BoundingBox Flag128ThUpSmall { get; }

        [DataMember(Name = "flag128thUpStraight")]
        BoundingBox Flag128ThUpStraight { get; }

        [DataMember(Name = "flag16thDown")]
        BoundingBox Flag16ThDown { get; }

        [DataMember(Name = "flag16thDownSmall")]
        BoundingBox Flag16ThDownSmall { get; }

        [DataMember(Name = "flag16thDownStraight")]
        BoundingBox Flag16ThDownStraight { get; }

        [DataMember(Name = "flag16thUp")]
        BoundingBox Flag16ThUp { get; }

        [DataMember(Name = "flag16thUpShort")]
        BoundingBox Flag16ThUpShort { get; }

        [DataMember(Name = "flag16thUpSmall")]
        BoundingBox Flag16ThUpSmall { get; }

        [DataMember(Name = "flag16thUpStraight")]
        BoundingBox Flag16ThUpStraight { get; }

        [DataMember(Name = "flag256thDown")]
        BoundingBox Flag256ThDown { get; }

        [DataMember(Name = "flag256thDownSmall")]
        BoundingBox Flag256ThDownSmall { get; }

        [DataMember(Name = "flag256thDownStraight")]
        BoundingBox Flag256ThDownStraight { get; }

        [DataMember(Name = "flag256thUp")]
        BoundingBox Flag256ThUp { get; }

        [DataMember(Name = "flag256thUpShort")]
        BoundingBox Flag256ThUpShort { get; }

        [DataMember(Name = "flag256thUpSmall")]
        BoundingBox Flag256ThUpSmall { get; }

        [DataMember(Name = "flag256thUpStraight")]
        BoundingBox Flag256ThUpStraight { get; }

        [DataMember(Name = "flag32ndDown")]
        BoundingBox Flag32NdDown { get; }

        [DataMember(Name = "flag32ndDownSmall")]
        BoundingBox Flag32NdDownSmall { get; }

        [DataMember(Name = "flag32ndDownStraight")]
        BoundingBox Flag32NdDownStraight { get; }

        [DataMember(Name = "flag32ndUp")]
        BoundingBox Flag32NdUp { get; }

        [DataMember(Name = "flag32ndUpShort")]
        BoundingBox Flag32NdUpShort { get; }

        [DataMember(Name = "flag32ndUpSmall")]
        BoundingBox Flag32NdUpSmall { get; }

        [DataMember(Name = "flag32ndUpStraight")]
        BoundingBox Flag32NdUpStraight { get; }

        [DataMember(Name = "flag512thDown")]
        BoundingBox Flag512ThDown { get; }

        [DataMember(Name = "flag512thDownSmall")]
        BoundingBox Flag512ThDownSmall { get; }

        [DataMember(Name = "flag512thDownStraight")]
        BoundingBox Flag512ThDownStraight { get; }

        [DataMember(Name = "flag512thUp")]
        BoundingBox Flag512ThUp { get; }

        [DataMember(Name = "flag512thUpShort")]
        BoundingBox Flag512ThUpShort { get; }

        [DataMember(Name = "flag512thUpSmall")]
        BoundingBox Flag512ThUpSmall { get; }

        [DataMember(Name = "flag512thUpStraight")]
        BoundingBox Flag512ThUpStraight { get; }

        [DataMember(Name = "flag64thDown")]
        BoundingBox Flag64ThDown { get; }

        [DataMember(Name = "flag64thDownSmall")]
        BoundingBox Flag64ThDownSmall { get; }

        [DataMember(Name = "flag64thDownStraight")]
        BoundingBox Flag64ThDownStraight { get; }

        [DataMember(Name = "flag64thUp")]
        BoundingBox Flag64ThUp { get; }

        [DataMember(Name = "flag64thUpShort")]
        BoundingBox Flag64ThUpShort { get; }

        [DataMember(Name = "flag64thUpSmall")]
        BoundingBox Flag64ThUpSmall { get; }

        [DataMember(Name = "flag64thUpStraight")]
        BoundingBox Flag64ThUpStraight { get; }

        [DataMember(Name = "flag8thDown")]
        BoundingBox Flag8ThDown { get; }

        [DataMember(Name = "flag8thDownSmall")]
        BoundingBox Flag8ThDownSmall { get; }

        [DataMember(Name = "flag8thDownStraight")]
        BoundingBox Flag8ThDownStraight { get; }

        [DataMember(Name = "flag8thUp")]
        BoundingBox Flag8ThUp { get; }

        [DataMember(Name = "flag8thUpShort")]
        BoundingBox Flag8ThUpShort { get; }

        [DataMember(Name = "flag8thUpSmall")]
        BoundingBox Flag8ThUpSmall { get; }

        [DataMember(Name = "flag8thUpStraight")]
        BoundingBox Flag8ThUpStraight { get; }

        [DataMember(Name = "flagInternalDown")]
        BoundingBox FlagInternalDown { get; }

        [DataMember(Name = "flagInternalUp")]
        BoundingBox FlagInternalUp { get; }

        [DataMember(Name = "fretboard3String")]
        BoundingBox Fretboard3String { get; }

        [DataMember(Name = "fretboard3StringNut")]
        BoundingBox Fretboard3StringNut { get; }

        [DataMember(Name = "fretboard4String")]
        BoundingBox Fretboard4String { get; }

        [DataMember(Name = "fretboard4StringNut")]
        BoundingBox Fretboard4StringNut { get; }

        [DataMember(Name = "fretboard5String")]
        BoundingBox Fretboard5String { get; }

        [DataMember(Name = "fretboard5StringNut")]
        BoundingBox Fretboard5StringNut { get; }

        [DataMember(Name = "fretboard6String")]
        BoundingBox Fretboard6String { get; }

        [DataMember(Name = "fretboard6StringNut")]
        BoundingBox Fretboard6StringNut { get; }

        [DataMember(Name = "fretboardFilledCircle")]
        BoundingBox FretboardFilledCircle { get; }

        [DataMember(Name = "fretboardO")]
        BoundingBox FretboardO { get; }

        [DataMember(Name = "fretboardX")]
        BoundingBox FretboardX { get; }

        [DataMember(Name = "functionAngleLeft")]
        BoundingBox FunctionAngleLeft { get; }

        [DataMember(Name = "functionAngleRight")]
        BoundingBox FunctionAngleRight { get; }

        [DataMember(Name = "functionBracketLeft")]
        BoundingBox FunctionBracketLeft { get; }

        [DataMember(Name = "functionBracketRight")]
        BoundingBox FunctionBracketRight { get; }

        [DataMember(Name = "functionDD")]
        BoundingBox FunctionDd { get; }

        [DataMember(Name = "functionDLower")]
        BoundingBox FunctionDLower { get; }

        [DataMember(Name = "functionDUpper")]
        BoundingBox FunctionDUpper { get; }

        [DataMember(Name = "functionEight")]
        BoundingBox FunctionEight { get; }

        [DataMember(Name = "functionFUpper")]
        BoundingBox FunctionFUpper { get; }

        [DataMember(Name = "functionFive")]
        BoundingBox FunctionFive { get; }

        [DataMember(Name = "functionFour")]
        BoundingBox FunctionFour { get; }

        [DataMember(Name = "functionGLower")]
        BoundingBox FunctionGLower { get; }

        [DataMember(Name = "functionGUpper")]
        BoundingBox FunctionGUpper { get; }

        [DataMember(Name = "functionGreaterThan")]
        BoundingBox FunctionGreaterThan { get; }

        [DataMember(Name = "functionILower")]
        BoundingBox FunctionILower { get; }

        [DataMember(Name = "functionIUpper")]
        BoundingBox FunctionIUpper { get; }

        [DataMember(Name = "functionKLower")]
        BoundingBox FunctionKLower { get; }

        [DataMember(Name = "functionKUpper")]
        BoundingBox FunctionKUpper { get; }

        [DataMember(Name = "functionLLower")]
        BoundingBox FunctionLLower { get; }

        [DataMember(Name = "functionLUpper")]
        BoundingBox FunctionLUpper { get; }

        [DataMember(Name = "functionLessThan")]
        BoundingBox FunctionLessThan { get; }

        [DataMember(Name = "functionMLower")]
        BoundingBox FunctionMLower { get; }

        [DataMember(Name = "functionMUpper")]
        BoundingBox FunctionMUpper { get; }

        [DataMember(Name = "functionMinus")]
        BoundingBox FunctionMinus { get; }

        [DataMember(Name = "functionNLower")]
        BoundingBox FunctionNLower { get; }

        [DataMember(Name = "functionNUpper")]
        BoundingBox FunctionNUpper { get; }

        [DataMember(Name = "functionNUpperSuperscript")]
        BoundingBox FunctionNUpperSuperscript { get; }

        [DataMember(Name = "functionNine")]
        BoundingBox FunctionNine { get; }

        [DataMember(Name = "functionOne")]
        BoundingBox FunctionOne { get; }

        [DataMember(Name = "functionPLower")]
        BoundingBox FunctionPLower { get; }

        [DataMember(Name = "functionPUpper")]
        BoundingBox FunctionPUpper { get; }

        [DataMember(Name = "functionParensLeft")]
        BoundingBox FunctionParensLeft { get; }

        [DataMember(Name = "functionParensRight")]
        BoundingBox FunctionParensRight { get; }

        [DataMember(Name = "functionPlus")]
        BoundingBox FunctionPlus { get; }

        [DataMember(Name = "functionRLower")]
        BoundingBox FunctionRLower { get; }

        [DataMember(Name = "functionRepetition1")]
        BoundingBox FunctionRepetition1 { get; }

        [DataMember(Name = "functionRepetition2")]
        BoundingBox FunctionRepetition2 { get; }

        [DataMember(Name = "functionRing")]
        BoundingBox FunctionRing { get; }

        [DataMember(Name = "functionSLower")]
        BoundingBox FunctionSLower { get; }

        [DataMember(Name = "functionSSLower")]
        BoundingBox FunctionSsLower { get; }

        [DataMember(Name = "functionSSUpper")]
        BoundingBox FunctionSsUpper { get; }

        [DataMember(Name = "functionSUpper")]
        BoundingBox FunctionSUpper { get; }

        [DataMember(Name = "functionSeven")]
        BoundingBox FunctionSeven { get; }

        [DataMember(Name = "functionSix")]
        BoundingBox FunctionSix { get; }

        [DataMember(Name = "functionSlashedDD")]
        BoundingBox FunctionSlashedDd { get; }

        [DataMember(Name = "functionTLower")]
        BoundingBox FunctionTLower { get; }

        [DataMember(Name = "functionTUpper")]
        BoundingBox FunctionTUpper { get; }

        [DataMember(Name = "functionThree")]
        BoundingBox FunctionThree { get; }

        [DataMember(Name = "functionTwo")]
        BoundingBox FunctionTwo { get; }

        [DataMember(Name = "functionVLower")]
        BoundingBox FunctionVLower { get; }

        [DataMember(Name = "functionVUpper")]
        BoundingBox FunctionVUpper { get; }

        [DataMember(Name = "functionZero")]
        BoundingBox FunctionZero { get; }

        [DataMember(Name = "gClef")]
        BoundingBox GClef { get; }

        [DataMember(Name = "gClef0Below")]
        BoundingBox GClef0Below { get; }

        [DataMember(Name = "gClef10Below")]
        BoundingBox GClef10Below { get; }

        [DataMember(Name = "gClef11Below")]
        BoundingBox GClef11Below { get; }

        [DataMember(Name = "gClef12Below")]
        BoundingBox GClef12Below { get; }

        [DataMember(Name = "gClef13Below")]
        BoundingBox GClef13Below { get; }

        [DataMember(Name = "gClef14Below")]
        BoundingBox GClef14Below { get; }

        [DataMember(Name = "gClef15Below")]
        BoundingBox GClef15Below { get; }

        [DataMember(Name = "gClef15ma")]
        BoundingBox GClef15Ma { get; }

        [DataMember(Name = "gClef15mb")]
        BoundingBox GClef15Mb { get; }

        [DataMember(Name = "gClef16Below")]
        BoundingBox GClef16Below { get; }

        [DataMember(Name = "gClef17Below")]
        BoundingBox GClef17Below { get; }

        [DataMember(Name = "gClef2Above")]
        BoundingBox GClef2Above { get; }

        [DataMember(Name = "gClef2Below")]
        BoundingBox GClef2Below { get; }

        [DataMember(Name = "gClef3Above")]
        BoundingBox GClef3Above { get; }

        [DataMember(Name = "gClef3Below")]
        BoundingBox GClef3Below { get; }

        [DataMember(Name = "gClef4Above")]
        BoundingBox GClef4Above { get; }

        [DataMember(Name = "gClef4Below")]
        BoundingBox GClef4Below { get; }

        [DataMember(Name = "gClef5Above")]
        BoundingBox GClef5Above { get; }

        [DataMember(Name = "gClef5Below")]
        BoundingBox GClef5Below { get; }

        [DataMember(Name = "gClef6Above")]
        BoundingBox GClef6Above { get; }

        [DataMember(Name = "gClef6Below")]
        BoundingBox GClef6Below { get; }

        [DataMember(Name = "gClef7Above")]
        BoundingBox GClef7Above { get; }

        [DataMember(Name = "gClef7Below")]
        BoundingBox GClef7Below { get; }

        [DataMember(Name = "gClef8Above")]
        BoundingBox GClef8Above { get; }

        [DataMember(Name = "gClef8Below")]
        BoundingBox GClef8Below { get; }

        [DataMember(Name = "gClef8va")]
        BoundingBox GClef8Va { get; }

        [DataMember(Name = "gClef8vb")]
        BoundingBox GClef8Vb { get; }

        [DataMember(Name = "gClef8vbCClef")]
        BoundingBox GClef8VbCClef { get; }

        [DataMember(Name = "gClef8vbOld")]
        BoundingBox GClef8VbOld { get; }

        [DataMember(Name = "gClef8vbParens")]
        BoundingBox GClef8VbParens { get; }

        [DataMember(Name = "gClef9Above")]
        BoundingBox GClef9Above { get; }

        [DataMember(Name = "gClef9Below")]
        BoundingBox GClef9Below { get; }

        [DataMember(Name = "gClefArrowDown")]
        BoundingBox GClefArrowDown { get; }

        [DataMember(Name = "gClefArrowUp")]
        BoundingBox GClefArrowUp { get; }

        [DataMember(Name = "gClefChange")]
        BoundingBox GClefChange { get; }

        [DataMember(Name = "gClefFlat10Below")]
        BoundingBox GClefFlat10Below { get; }

        [DataMember(Name = "gClefFlat11Below")]
        BoundingBox GClefFlat11Below { get; }

        [DataMember(Name = "gClefFlat13Below")]
        BoundingBox GClefFlat13Below { get; }

        [DataMember(Name = "gClefFlat14Below")]
        BoundingBox GClefFlat14Below { get; }

        [DataMember(Name = "gClefFlat15Below")]
        BoundingBox GClefFlat15Below { get; }

        [DataMember(Name = "gClefFlat16Below")]
        BoundingBox GClefFlat16Below { get; }

        [DataMember(Name = "gClefFlat1Below")]
        BoundingBox GClefFlat1Below { get; }

        [DataMember(Name = "gClefFlat2Above")]
        BoundingBox GClefFlat2Above { get; }

        [DataMember(Name = "gClefFlat2Below")]
        BoundingBox GClefFlat2Below { get; }

        [DataMember(Name = "gClefFlat3Above")]
        BoundingBox GClefFlat3Above { get; }

        [DataMember(Name = "gClefFlat3Below")]
        BoundingBox GClefFlat3Below { get; }

        [DataMember(Name = "gClefFlat4Below")]
        BoundingBox GClefFlat4Below { get; }

        [DataMember(Name = "gClefFlat5Above")]
        BoundingBox GClefFlat5Above { get; }

        [DataMember(Name = "gClefFlat6Above")]
        BoundingBox GClefFlat6Above { get; }

        [DataMember(Name = "gClefFlat6Below")]
        BoundingBox GClefFlat6Below { get; }

        [DataMember(Name = "gClefFlat7Above")]
        BoundingBox GClefFlat7Above { get; }

        [DataMember(Name = "gClefFlat7Below")]
        BoundingBox GClefFlat7Below { get; }

        [DataMember(Name = "gClefFlat8Above")]
        BoundingBox GClefFlat8Above { get; }

        [DataMember(Name = "gClefFlat9Above")]
        BoundingBox GClefFlat9Above { get; }

        [DataMember(Name = "gClefFlat9Below")]
        BoundingBox GClefFlat9Below { get; }

        [DataMember(Name = "gClefLigatedNumberAbove")]
        BoundingBox GClefLigatedNumberAbove { get; }

        [DataMember(Name = "gClefLigatedNumberBelow")]
        BoundingBox GClefLigatedNumberBelow { get; }

        [DataMember(Name = "gClefNat2Below")]
        BoundingBox GClefNat2Below { get; }

        [DataMember(Name = "gClefNatural10Below")]
        BoundingBox GClefNatural10Below { get; }

        [DataMember(Name = "gClefNatural13Below")]
        BoundingBox GClefNatural13Below { get; }

        [DataMember(Name = "gClefNatural17Below")]
        BoundingBox GClefNatural17Below { get; }

        [DataMember(Name = "gClefNatural2Above")]
        BoundingBox GClefNatural2Above { get; }

        [DataMember(Name = "gClefNatural3Above")]
        BoundingBox GClefNatural3Above { get; }

        [DataMember(Name = "gClefNatural3Below")]
        BoundingBox GClefNatural3Below { get; }

        [DataMember(Name = "gClefNatural6Above")]
        BoundingBox GClefNatural6Above { get; }

        [DataMember(Name = "gClefNatural6Below")]
        BoundingBox GClefNatural6Below { get; }

        [DataMember(Name = "gClefNatural7Above")]
        BoundingBox GClefNatural7Above { get; }

        [DataMember(Name = "gClefNatural9Above")]
        BoundingBox GClefNatural9Above { get; }

        [DataMember(Name = "gClefNatural9Below")]
        BoundingBox GClefNatural9Below { get; }

        [DataMember(Name = "gClefReversed")]
        BoundingBox GClefReversed { get; }

        [DataMember(Name = "gClefSharp12Below")]
        BoundingBox GClefSharp12Below { get; }

        [DataMember(Name = "gClefSharp1Above")]
        BoundingBox GClefSharp1Above { get; }

        [DataMember(Name = "gClefSharp4Above")]
        BoundingBox GClefSharp4Above { get; }

        [DataMember(Name = "gClefSharp5Below")]
        BoundingBox GClefSharp5Below { get; }

        [DataMember(Name = "gClefSmall")]
        BoundingBox GClefSmall { get; }

        [DataMember(Name = "gClefTurned")]
        BoundingBox GClefTurned { get; }

        [DataMember(Name = "glissandoDown")]
        BoundingBox GlissandoDown { get; }

        [DataMember(Name = "glissandoUp")]
        BoundingBox GlissandoUp { get; }

        [DataMember(Name = "graceNoteAcciaccaturaStemDown")]
        BoundingBox GraceNoteAcciaccaturaStemDown { get; }

        [DataMember(Name = "graceNoteAcciaccaturaStemUp")]
        BoundingBox GraceNoteAcciaccaturaStemUp { get; }

        [DataMember(Name = "graceNoteAppoggiaturaStemDown")]
        BoundingBox GraceNoteAppoggiaturaStemDown { get; }

        [DataMember(Name = "graceNoteAppoggiaturaStemUp")]
        BoundingBox GraceNoteAppoggiaturaStemUp { get; }

        [DataMember(Name = "graceNoteSlashStemDown")]
        BoundingBox GraceNoteSlashStemDown { get; }

        [DataMember(Name = "graceNoteSlashStemUp")]
        BoundingBox GraceNoteSlashStemUp { get; }

        [DataMember(Name = "guitarBarreFull")]
        BoundingBox GuitarBarreFull { get; }

        [DataMember(Name = "guitarBarreHalf")]
        BoundingBox GuitarBarreHalf { get; }

        [DataMember(Name = "guitarBarreHalfHorizontalFractionSlash")]
        BoundingBox GuitarBarreHalfHorizontalFractionSlash { get; }

        [DataMember(Name = "guitarClosePedal")]
        BoundingBox GuitarClosePedal { get; }

        [DataMember(Name = "guitarFadeIn")]
        BoundingBox GuitarFadeIn { get; }

        [DataMember(Name = "guitarFadeOut")]
        BoundingBox GuitarFadeOut { get; }

        [DataMember(Name = "guitarGolpe")]
        BoundingBox GuitarGolpe { get; }

        [DataMember(Name = "guitarGolpeFlamenco")]
        BoundingBox GuitarGolpeFlamenco { get; }

        [DataMember(Name = "guitarHalfOpenPedal")]
        BoundingBox GuitarHalfOpenPedal { get; }

        [DataMember(Name = "guitarLeftHandTapping")]
        BoundingBox GuitarLeftHandTapping { get; }

        [DataMember(Name = "guitarOpenPedal")]
        BoundingBox GuitarOpenPedal { get; }

        [DataMember(Name = "guitarRightHandTapping")]
        BoundingBox GuitarRightHandTapping { get; }

        [DataMember(Name = "guitarShake")]
        BoundingBox GuitarShake { get; }

        [DataMember(Name = "guitarString0")]
        BoundingBox GuitarString0 { get; }

        [DataMember(Name = "guitarString1")]
        BoundingBox GuitarString1 { get; }

        [DataMember(Name = "guitarString2")]
        BoundingBox GuitarString2 { get; }

        [DataMember(Name = "guitarString3")]
        BoundingBox GuitarString3 { get; }

        [DataMember(Name = "guitarString4")]
        BoundingBox GuitarString4 { get; }

        [DataMember(Name = "guitarString5")]
        BoundingBox GuitarString5 { get; }

        [DataMember(Name = "guitarString6")]
        BoundingBox GuitarString6 { get; }

        [DataMember(Name = "guitarString7")]
        BoundingBox GuitarString7 { get; }

        [DataMember(Name = "guitarString8")]
        BoundingBox GuitarString8 { get; }

        [DataMember(Name = "guitarString9")]
        BoundingBox GuitarString9 { get; }

        [DataMember(Name = "guitarStrumDown")]
        BoundingBox GuitarStrumDown { get; }

        [DataMember(Name = "guitarStrumUp")]
        BoundingBox GuitarStrumUp { get; }

        [DataMember(Name = "guitarVibratoBarDip")]
        BoundingBox GuitarVibratoBarDip { get; }

        [DataMember(Name = "guitarVibratoBarScoop")]
        BoundingBox GuitarVibratoBarScoop { get; }

        [DataMember(Name = "guitarVibratoStroke")]
        BoundingBox GuitarVibratoStroke { get; }

        [DataMember(Name = "guitarVolumeSwell")]
        BoundingBox GuitarVolumeSwell { get; }

        [DataMember(Name = "guitarWideVibratoStroke")]
        BoundingBox GuitarWideVibratoStroke { get; }

        [DataMember(Name = "handbellsBelltree")]
        BoundingBox HandbellsBelltree { get; }

        [DataMember(Name = "handbellsDamp3")]
        BoundingBox HandbellsDamp3 { get; }

        [DataMember(Name = "handbellsEcho1")]
        BoundingBox HandbellsEcho1 { get; }

        [DataMember(Name = "handbellsEcho2")]
        BoundingBox HandbellsEcho2 { get; }

        [DataMember(Name = "handbellsGyro")]
        BoundingBox HandbellsGyro { get; }

        [DataMember(Name = "handbellsHandMartellato")]
        BoundingBox HandbellsHandMartellato { get; }

        [DataMember(Name = "handbellsMalletBellOnTable")]
        BoundingBox HandbellsMalletBellOnTable { get; }

        [DataMember(Name = "handbellsMalletBellSuspended")]
        BoundingBox HandbellsMalletBellSuspended { get; }

        [DataMember(Name = "handbellsMalletLft")]
        BoundingBox HandbellsMalletLft { get; }

        [DataMember(Name = "handbellsMartellato")]
        BoundingBox HandbellsMartellato { get; }

        [DataMember(Name = "handbellsMartellatoLift")]
        BoundingBox HandbellsMartellatoLift { get; }

        [DataMember(Name = "handbellsMutedMartellato")]
        BoundingBox HandbellsMutedMartellato { get; }

        [DataMember(Name = "handbellsPluckLift")]
        BoundingBox HandbellsPluckLift { get; }

        [DataMember(Name = "handbellsSwing")]
        BoundingBox HandbellsSwing { get; }

        [DataMember(Name = "handbellsSwingDown")]
        BoundingBox HandbellsSwingDown { get; }

        [DataMember(Name = "handbellsSwingUp")]
        BoundingBox HandbellsSwingUp { get; }

        [DataMember(Name = "handbellsTablePairBells")]
        BoundingBox HandbellsTablePairBells { get; }

        [DataMember(Name = "handbellsTableSingleBell")]
        BoundingBox HandbellsTableSingleBell { get; }

        [DataMember(Name = "harpMetalRod")]
        BoundingBox HarpMetalRod { get; }

        [DataMember(Name = "harpMetalRodAlt")]
        BoundingBox HarpMetalRodAlt { get; }

        [DataMember(Name = "harpPedalCentered")]
        BoundingBox HarpPedalCentered { get; }

        [DataMember(Name = "harpPedalDivider")]
        Dictionary<string, long[]> HarpPedalDivider { get; }

        [DataMember(Name = "harpPedalLowered")]
        BoundingBox HarpPedalLowered { get; }

        [DataMember(Name = "harpPedalRaised")]
        BoundingBox HarpPedalRaised { get; }

        [DataMember(Name = "harpSalzedoAeolianAscending")]
        BoundingBox HarpSalzedoAeolianAscending { get; }

        [DataMember(Name = "harpSalzedoAeolianDescending")]
        BoundingBox HarpSalzedoAeolianDescending { get; }

        [DataMember(Name = "harpSalzedoDampAbove")]
        BoundingBox HarpSalzedoDampAbove { get; }

        [DataMember(Name = "harpSalzedoDampBelow")]
        BoundingBox HarpSalzedoDampBelow { get; }

        [DataMember(Name = "harpSalzedoDampBothHands")]
        BoundingBox HarpSalzedoDampBothHands { get; }

        [DataMember(Name = "harpSalzedoDampLowStrings")]
        BoundingBox HarpSalzedoDampLowStrings { get; }

        [DataMember(Name = "harpSalzedoFluidicSoundsLeft")]
        BoundingBox HarpSalzedoFluidicSoundsLeft { get; }

        [DataMember(Name = "harpSalzedoFluidicSoundsRight")]
        BoundingBox HarpSalzedoFluidicSoundsRight { get; }

        [DataMember(Name = "harpSalzedoIsolatedSounds")]
        BoundingBox HarpSalzedoIsolatedSounds { get; }

        [DataMember(Name = "harpSalzedoMetallicSounds")]
        BoundingBox HarpSalzedoMetallicSounds { get; }

        [DataMember(Name = "harpSalzedoMetallicSoundsOneString")]
        BoundingBox HarpSalzedoMetallicSoundsOneString { get; }

        [DataMember(Name = "harpSalzedoMuffleTotally")]
        BoundingBox HarpSalzedoMuffleTotally { get; }

        [DataMember(Name = "harpSalzedoOboicFlux")]
        BoundingBox HarpSalzedoOboicFlux { get; }

        [DataMember(Name = "harpSalzedoPlayUpperEnd")]
        BoundingBox HarpSalzedoPlayUpperEnd { get; }

        [DataMember(Name = "harpSalzedoSlideWithSuppleness")]
        BoundingBox HarpSalzedoSlideWithSuppleness { get; }

        [DataMember(Name = "harpSalzedoSnareDrum")]
        Dictionary<string, long[]> HarpSalzedoSnareDrum { get; }

        [DataMember(Name = "harpSalzedoTamTamSounds")]
        BoundingBox HarpSalzedoTamTamSounds { get; }

        [DataMember(Name = "harpSalzedoThunderEffect")]
        BoundingBox HarpSalzedoThunderEffect { get; }

        [DataMember(Name = "harpSalzedoTimpanicSounds")]
        BoundingBox HarpSalzedoTimpanicSounds { get; }

        [DataMember(Name = "harpSalzedoWhistlingSounds")]
        BoundingBox HarpSalzedoWhistlingSounds { get; }

        [DataMember(Name = "harpStringNoiseStem")]
        BoundingBox HarpStringNoiseStem { get; }

        [DataMember(Name = "harpTuningKey")]
        BoundingBox HarpTuningKey { get; }

        [DataMember(Name = "harpTuningKeyAlt")]
        BoundingBox HarpTuningKeyAlt { get; }

        [DataMember(Name = "harpTuningKeyGlissando")]
        BoundingBox HarpTuningKeyGlissando { get; }

        [DataMember(Name = "harpTuningKeyHandle")]
        BoundingBox HarpTuningKeyHandle { get; }

        [DataMember(Name = "harpTuningKeyShank")]
        BoundingBox HarpTuningKeyShank { get; }

        [DataMember(Name = "keyboardBebung2DotsAbove")]
        BoundingBox KeyboardBebung2DotsAbove { get; }

        [DataMember(Name = "keyboardBebung2DotsBelow")]
        BoundingBox KeyboardBebung2DotsBelow { get; }

        [DataMember(Name = "keyboardBebung3DotsAbove")]
        BoundingBox KeyboardBebung3DotsAbove { get; }

        [DataMember(Name = "keyboardBebung3DotsBelow")]
        BoundingBox KeyboardBebung3DotsBelow { get; }

        [DataMember(Name = "keyboardBebung4DotsAbove")]
        BoundingBox KeyboardBebung4DotsAbove { get; }

        [DataMember(Name = "keyboardBebung4DotsBelow")]
        BoundingBox KeyboardBebung4DotsBelow { get; }

        [DataMember(Name = "keyboardLeftPedalPictogram")]
        BoundingBox KeyboardLeftPedalPictogram { get; }

        [DataMember(Name = "keyboardMiddlePedalPictogram")]
        BoundingBox KeyboardMiddlePedalPictogram { get; }

        [DataMember(Name = "keyboardPedalD")]
        BoundingBox KeyboardPedalD { get; }

        [DataMember(Name = "keyboardPedalDot")]
        BoundingBox KeyboardPedalDot { get; }

        [DataMember(Name = "keyboardPedalE")]
        BoundingBox KeyboardPedalE { get; }

        [DataMember(Name = "keyboardPedalHalf")]
        BoundingBox KeyboardPedalHalf { get; }

        [DataMember(Name = "keyboardPedalHalf2")]
        BoundingBox KeyboardPedalHalf2 { get; }

        [DataMember(Name = "keyboardPedalHalf3")]
        BoundingBox KeyboardPedalHalf3 { get; }

        [DataMember(Name = "keyboardPedalHeel1")]
        BoundingBox KeyboardPedalHeel1 { get; }

        [DataMember(Name = "keyboardPedalHeel2")]
        BoundingBox KeyboardPedalHeel2 { get; }

        [DataMember(Name = "keyboardPedalHeel3")]
        Dictionary<string, long[]> KeyboardPedalHeel3 { get; }

        [DataMember(Name = "keyboardPedalHeelToToe")]
        BoundingBox KeyboardPedalHeelToToe { get; }

        [DataMember(Name = "keyboardPedalHeelToe")]
        BoundingBox KeyboardPedalHeelToe { get; }

        [DataMember(Name = "keyboardPedalHookEnd")]
        BoundingBox KeyboardPedalHookEnd { get; }

        [DataMember(Name = "keyboardPedalHookStart")]
        BoundingBox KeyboardPedalHookStart { get; }

        [DataMember(Name = "keyboardPedalHyphen")]
        BoundingBox KeyboardPedalHyphen { get; }

        [DataMember(Name = "keyboardPedalP")]
        BoundingBox KeyboardPedalP { get; }

        [DataMember(Name = "keyboardPedalPed")]
        BoundingBox KeyboardPedalPed { get; }

        [DataMember(Name = "keyboardPedalPedNoDot")]
        BoundingBox KeyboardPedalPedNoDot { get; }

        [DataMember(Name = "keyboardPedalS")]
        BoundingBox KeyboardPedalS { get; }

        [DataMember(Name = "keyboardPedalSost")]
        BoundingBox KeyboardPedalSost { get; }

        [DataMember(Name = "keyboardPedalSostNoDot")]
        BoundingBox KeyboardPedalSostNoDot { get; }

        [DataMember(Name = "keyboardPedalToe1")]
        BoundingBox KeyboardPedalToe1 { get; }

        [DataMember(Name = "keyboardPedalToe2")]
        BoundingBox KeyboardPedalToe2 { get; }

        [DataMember(Name = "keyboardPedalToeToHeel")]
        BoundingBox KeyboardPedalToeToHeel { get; }

        [DataMember(Name = "keyboardPedalUp")]
        BoundingBox KeyboardPedalUp { get; }

        [DataMember(Name = "keyboardPedalUpNotch")]
        BoundingBox KeyboardPedalUpNotch { get; }

        [DataMember(Name = "keyboardPedalUpSpecial")]
        BoundingBox KeyboardPedalUpSpecial { get; }

        [DataMember(Name = "keyboardPlayWithLH")]
        BoundingBox KeyboardPlayWithLh { get; }

        [DataMember(Name = "keyboardPlayWithLHEnd")]
        BoundingBox KeyboardPlayWithLhEnd { get; }

        [DataMember(Name = "keyboardPlayWithRH")]
        BoundingBox KeyboardPlayWithRh { get; }

        [DataMember(Name = "keyboardPlayWithRHEnd")]
        BoundingBox KeyboardPlayWithRhEnd { get; }

        [DataMember(Name = "keyboardPluckInside")]
        BoundingBox KeyboardPluckInside { get; }

        [DataMember(Name = "keyboardRightPedalPictogram")]
        BoundingBox KeyboardRightPedalPictogram { get; }

        [DataMember(Name = "kievanAccidentalFlat")]
        BoundingBox KievanAccidentalFlat { get; }

        [DataMember(Name = "kievanAccidentalSharp")]
        BoundingBox KievanAccidentalSharp { get; }

        [DataMember(Name = "kievanAugmentationDot")]
        BoundingBox KievanAugmentationDot { get; }

        [DataMember(Name = "kievanCClef")]
        BoundingBox KievanCClef { get; }

        [DataMember(Name = "kievanEndingSymbol")]
        BoundingBox KievanEndingSymbol { get; }

        [DataMember(Name = "kievanNote8thStemDown")]
        BoundingBox KievanNote8ThStemDown { get; }

        [DataMember(Name = "kievanNote8thStemUp")]
        BoundingBox KievanNote8ThStemUp { get; }

        [DataMember(Name = "kievanNoteBeam")]
        BoundingBox KievanNoteBeam { get; }

        [DataMember(Name = "kievanNoteHalfStaffLine")]
        BoundingBox KievanNoteHalfStaffLine { get; }

        [DataMember(Name = "kievanNoteHalfStaffSpace")]
        BoundingBox KievanNoteHalfStaffSpace { get; }

        [DataMember(Name = "kievanNoteQuarterStemDown")]
        BoundingBox KievanNoteQuarterStemDown { get; }

        [DataMember(Name = "kievanNoteQuarterStemUp")]
        BoundingBox KievanNoteQuarterStemUp { get; }

        [DataMember(Name = "kievanNoteReciting")]
        BoundingBox KievanNoteReciting { get; }

        [DataMember(Name = "kievanNoteWhole")]
        BoundingBox KievanNoteWhole { get; }

        [DataMember(Name = "kievanNoteWholeFinal")]
        BoundingBox KievanNoteWholeFinal { get; }

        [DataMember(Name = "kodalyHandDo")]
        BoundingBox KodalyHandDo { get; }

        [DataMember(Name = "kodalyHandFa")]
        BoundingBox KodalyHandFa { get; }

        [DataMember(Name = "kodalyHandLa")]
        BoundingBox KodalyHandLa { get; }

        [DataMember(Name = "kodalyHandMi")]
        BoundingBox KodalyHandMi { get; }

        [DataMember(Name = "kodalyHandRe")]
        BoundingBox KodalyHandRe { get; }

        [DataMember(Name = "kodalyHandSo")]
        BoundingBox KodalyHandSo { get; }

        [DataMember(Name = "kodalyHandTi")]
        BoundingBox KodalyHandTi { get; }

        [DataMember(Name = "leftRepeatSmall")]
        BoundingBox LeftRepeatSmall { get; }

        [DataMember(Name = "legerLine")]
        BoundingBox LegerLine { get; }

        [DataMember(Name = "legerLineNarrow")]
        BoundingBox LegerLineNarrow { get; }

        [DataMember(Name = "legerLineWide")]
        BoundingBox LegerLineWide { get; }

        [DataMember(Name = "luteBarlineEndRepeat")]
        BoundingBox LuteBarlineEndRepeat { get; }

        [DataMember(Name = "luteBarlineFinal")]
        BoundingBox LuteBarlineFinal { get; }

        [DataMember(Name = "luteBarlineStartRepeat")]
        BoundingBox LuteBarlineStartRepeat { get; }

        [DataMember(Name = "luteDuration16th")]
        BoundingBox LuteDuration16Th { get; }

        [DataMember(Name = "luteDuration32nd")]
        BoundingBox LuteDuration32Nd { get; }

        [DataMember(Name = "luteDuration8th")]
        BoundingBox LuteDuration8Th { get; }

        [DataMember(Name = "luteDurationDoubleWhole")]
        BoundingBox LuteDurationDoubleWhole { get; }

        [DataMember(Name = "luteDurationHalf")]
        BoundingBox LuteDurationHalf { get; }

        [DataMember(Name = "luteDurationQuarter")]
        BoundingBox LuteDurationQuarter { get; }

        [DataMember(Name = "luteDurationWhole")]
        BoundingBox LuteDurationWhole { get; }

        [DataMember(Name = "luteFingeringRHFirst")]
        BoundingBox LuteFingeringRhFirst { get; }

        [DataMember(Name = "luteFingeringRHSecond")]
        BoundingBox LuteFingeringRhSecond { get; }

        [DataMember(Name = "luteFingeringRHThird")]
        BoundingBox LuteFingeringRhThird { get; }

        [DataMember(Name = "luteFingeringRHThirdAlt")]
        BoundingBox LuteFingeringRhThirdAlt { get; }

        [DataMember(Name = "luteFingeringRHThumb")]
        BoundingBox LuteFingeringRhThumb { get; }

        [DataMember(Name = "luteFrench10thCourse")]
        BoundingBox LuteFrench10ThCourse { get; }

        [DataMember(Name = "luteFrench10thCourseRight")]
        BoundingBox LuteFrench10ThCourseRight { get; }

        [DataMember(Name = "luteFrench10thCourseStrikethru")]
        BoundingBox LuteFrench10ThCourseStrikethru { get; }

        [DataMember(Name = "luteFrench10thCourseUnderline")]
        BoundingBox LuteFrench10ThCourseUnderline { get; }

        [DataMember(Name = "luteFrench7thCourse")]
        BoundingBox LuteFrench7ThCourse { get; }

        [DataMember(Name = "luteFrench7thCourseRight")]
        BoundingBox LuteFrench7ThCourseRight { get; }

        [DataMember(Name = "luteFrench7thCourseStrikethru")]
        BoundingBox LuteFrench7ThCourseStrikethru { get; }

        [DataMember(Name = "luteFrench7thCourseUnderline")]
        BoundingBox LuteFrench7ThCourseUnderline { get; }

        [DataMember(Name = "luteFrench8thCourse")]
        BoundingBox LuteFrench8ThCourse { get; }

        [DataMember(Name = "luteFrench8thCourseRight")]
        BoundingBox LuteFrench8ThCourseRight { get; }

        [DataMember(Name = "luteFrench8thCourseStrikethru")]
        BoundingBox LuteFrench8ThCourseStrikethru { get; }

        [DataMember(Name = "luteFrench8thCourseUnderline")]
        BoundingBox LuteFrench8ThCourseUnderline { get; }

        [DataMember(Name = "luteFrench9thCourse")]
        BoundingBox LuteFrench9ThCourse { get; }

        [DataMember(Name = "luteFrench9thCourseRight")]
        BoundingBox LuteFrench9ThCourseRight { get; }

        [DataMember(Name = "luteFrench9thCourseStrikethru")]
        BoundingBox LuteFrench9ThCourseStrikethru { get; }

        [DataMember(Name = "luteFrench9thCourseUnderline")]
        BoundingBox LuteFrench9ThCourseUnderline { get; }

        [DataMember(Name = "luteFrenchAppoggiaturaAbove")]
        BoundingBox LuteFrenchAppoggiaturaAbove { get; }

        [DataMember(Name = "luteFrenchAppoggiaturaBelow")]
        BoundingBox LuteFrenchAppoggiaturaBelow { get; }

        [DataMember(Name = "luteFrenchFretA")]
        BoundingBox LuteFrenchFretA { get; }

        [DataMember(Name = "luteFrenchFretB")]
        BoundingBox LuteFrenchFretB { get; }

        [DataMember(Name = "luteFrenchFretC")]
        BoundingBox LuteFrenchFretC { get; }

        [DataMember(Name = "luteFrenchFretCAlt")]
        BoundingBox LuteFrenchFretCAlt { get; }

        [DataMember(Name = "luteFrenchFretD")]
        BoundingBox LuteFrenchFretD { get; }

        [DataMember(Name = "luteFrenchFretE")]
        BoundingBox LuteFrenchFretE { get; }

        [DataMember(Name = "luteFrenchFretF")]
        BoundingBox LuteFrenchFretF { get; }

        [DataMember(Name = "luteFrenchFretG")]
        BoundingBox LuteFrenchFretG { get; }

        [DataMember(Name = "luteFrenchFretH")]
        BoundingBox LuteFrenchFretH { get; }

        [DataMember(Name = "luteFrenchFretI")]
        BoundingBox LuteFrenchFretI { get; }

        [DataMember(Name = "luteFrenchFretK")]
        BoundingBox LuteFrenchFretK { get; }

        [DataMember(Name = "luteFrenchFretL")]
        BoundingBox LuteFrenchFretL { get; }

        [DataMember(Name = "luteFrenchFretM")]
        BoundingBox LuteFrenchFretM { get; }

        [DataMember(Name = "luteFrenchFretN")]
        BoundingBox LuteFrenchFretN { get; }

        [DataMember(Name = "luteFrenchMordentInverted")]
        BoundingBox LuteFrenchMordentInverted { get; }

        [DataMember(Name = "luteFrenchMordentLower")]
        BoundingBox LuteFrenchMordentLower { get; }

        [DataMember(Name = "luteFrenchMordentUpper")]
        BoundingBox LuteFrenchMordentUpper { get; }

        [DataMember(Name = "luteGermanALower")]
        BoundingBox LuteGermanALower { get; }

        [DataMember(Name = "luteGermanAUpper")]
        BoundingBox LuteGermanAUpper { get; }

        [DataMember(Name = "luteGermanBLower")]
        BoundingBox LuteGermanBLower { get; }

        [DataMember(Name = "luteGermanBUpper")]
        BoundingBox LuteGermanBUpper { get; }

        [DataMember(Name = "luteGermanCLower")]
        BoundingBox LuteGermanCLower { get; }

        [DataMember(Name = "luteGermanCUpper")]
        BoundingBox LuteGermanCUpper { get; }

        [DataMember(Name = "luteGermanDLower")]
        BoundingBox LuteGermanDLower { get; }

        [DataMember(Name = "luteGermanDUpper")]
        BoundingBox LuteGermanDUpper { get; }

        [DataMember(Name = "luteGermanELower")]
        BoundingBox LuteGermanELower { get; }

        [DataMember(Name = "luteGermanEUpper")]
        BoundingBox LuteGermanEUpper { get; }

        [DataMember(Name = "luteGermanFLower")]
        BoundingBox LuteGermanFLower { get; }

        [DataMember(Name = "luteGermanFUpper")]
        BoundingBox LuteGermanFUpper { get; }

        [DataMember(Name = "luteGermanGLower")]
        BoundingBox LuteGermanGLower { get; }

        [DataMember(Name = "luteGermanGUpper")]
        BoundingBox LuteGermanGUpper { get; }

        [DataMember(Name = "luteGermanHLower")]
        BoundingBox LuteGermanHLower { get; }

        [DataMember(Name = "luteGermanHUpper")]
        BoundingBox LuteGermanHUpper { get; }

        [DataMember(Name = "luteGermanILower")]
        BoundingBox LuteGermanILower { get; }

        [DataMember(Name = "luteGermanIUpper")]
        BoundingBox LuteGermanIUpper { get; }

        [DataMember(Name = "luteGermanKLower")]
        BoundingBox LuteGermanKLower { get; }

        [DataMember(Name = "luteGermanKUpper")]
        BoundingBox LuteGermanKUpper { get; }

        [DataMember(Name = "luteGermanLLower")]
        BoundingBox LuteGermanLLower { get; }

        [DataMember(Name = "luteGermanLUpper")]
        BoundingBox LuteGermanLUpper { get; }

        [DataMember(Name = "luteGermanMLower")]
        BoundingBox LuteGermanMLower { get; }

        [DataMember(Name = "luteGermanMUpper")]
        BoundingBox LuteGermanMUpper { get; }

        [DataMember(Name = "luteGermanNLower")]
        BoundingBox LuteGermanNLower { get; }

        [DataMember(Name = "luteGermanNUpper")]
        BoundingBox LuteGermanNUpper { get; }

        [DataMember(Name = "luteGermanOLower")]
        BoundingBox LuteGermanOLower { get; }

        [DataMember(Name = "luteGermanPLower")]
        BoundingBox LuteGermanPLower { get; }

        [DataMember(Name = "luteGermanQLower")]
        BoundingBox LuteGermanQLower { get; }

        [DataMember(Name = "luteGermanRLower")]
        BoundingBox LuteGermanRLower { get; }

        [DataMember(Name = "luteGermanSLower")]
        BoundingBox LuteGermanSLower { get; }

        [DataMember(Name = "luteGermanTLower")]
        BoundingBox LuteGermanTLower { get; }

        [DataMember(Name = "luteGermanVLower")]
        BoundingBox LuteGermanVLower { get; }

        [DataMember(Name = "luteGermanXLower")]
        BoundingBox LuteGermanXLower { get; }

        [DataMember(Name = "luteGermanYLower")]
        BoundingBox LuteGermanYLower { get; }

        [DataMember(Name = "luteGermanZLower")]
        BoundingBox LuteGermanZLower { get; }

        [DataMember(Name = "luteItalianClefCSolFaUt")]
        BoundingBox LuteItalianClefCSolFaUt { get; }

        [DataMember(Name = "luteItalianClefFFaUt")]
        BoundingBox LuteItalianClefFFaUt { get; }

        [DataMember(Name = "luteItalianFret0")]
        BoundingBox LuteItalianFret0 { get; }

        [DataMember(Name = "luteItalianFret1")]
        BoundingBox LuteItalianFret1 { get; }

        [DataMember(Name = "luteItalianFret2")]
        BoundingBox LuteItalianFret2 { get; }

        [DataMember(Name = "luteItalianFret3")]
        BoundingBox LuteItalianFret3 { get; }

        [DataMember(Name = "luteItalianFret4")]
        BoundingBox LuteItalianFret4 { get; }

        [DataMember(Name = "luteItalianFret5")]
        BoundingBox LuteItalianFret5 { get; }

        [DataMember(Name = "luteItalianFret6")]
        BoundingBox LuteItalianFret6 { get; }

        [DataMember(Name = "luteItalianFret7")]
        BoundingBox LuteItalianFret7 { get; }

        [DataMember(Name = "luteItalianFret8")]
        BoundingBox LuteItalianFret8 { get; }

        [DataMember(Name = "luteItalianFret9")]
        BoundingBox LuteItalianFret9 { get; }

        [DataMember(Name = "luteItalianHoldFinger")]
        BoundingBox LuteItalianHoldFinger { get; }

        [DataMember(Name = "luteItalianHoldNote")]
        BoundingBox LuteItalianHoldNote { get; }

        [DataMember(Name = "luteItalianReleaseFinger")]
        BoundingBox LuteItalianReleaseFinger { get; }

        [DataMember(Name = "luteItalianTempoFast")]
        BoundingBox LuteItalianTempoFast { get; }

        [DataMember(Name = "luteItalianTempoNeitherFastNorSlow")]
        BoundingBox LuteItalianTempoNeitherFastNorSlow { get; }

        [DataMember(Name = "luteItalianTempoSlow")]
        BoundingBox LuteItalianTempoSlow { get; }

        [DataMember(Name = "luteItalianTempoSomewhatFast")]
        BoundingBox LuteItalianTempoSomewhatFast { get; }

        [DataMember(Name = "luteItalianTempoVerySlow")]
        BoundingBox LuteItalianTempoVerySlow { get; }

        [DataMember(Name = "luteItalianTimeTriple")]
        BoundingBox LuteItalianTimeTriple { get; }

        [DataMember(Name = "luteItalianTremolo")]
        BoundingBox LuteItalianTremolo { get; }

        [DataMember(Name = "luteItalianVibrato")]
        BoundingBox LuteItalianVibrato { get; }

        [DataMember(Name = "luteStaff6Lines")]
        BoundingBox LuteStaff6Lines { get; }

        [DataMember(Name = "luteStaff6LinesNarrow")]
        BoundingBox LuteStaff6LinesNarrow { get; }

        [DataMember(Name = "luteStaff6LinesWide")]
        BoundingBox LuteStaff6LinesWide { get; }

        [DataMember(Name = "lyricsElision")]
        BoundingBox LyricsElision { get; }

        [DataMember(Name = "lyricsElisionNarrow")]
        BoundingBox LyricsElisionNarrow { get; }

        [DataMember(Name = "lyricsElisionWide")]
        BoundingBox LyricsElisionWide { get; }

        [DataMember(Name = "lyricsHyphenBaseline")]
        BoundingBox LyricsHyphenBaseline { get; }

        [DataMember(Name = "lyricsHyphenBaselineNonBreaking")]
        BoundingBox LyricsHyphenBaselineNonBreaking { get; }

        [DataMember(Name = "medRenFlatHardB")]
        BoundingBox MedRenFlatHardB { get; }

        [DataMember(Name = "medRenFlatSoftB")]
        BoundingBox MedRenFlatSoftB { get; }

        [DataMember(Name = "medRenFlatSoftBHufnagel")]
        BoundingBox MedRenFlatSoftBHufnagel { get; }

        [DataMember(Name = "medRenFlatSoftBOld")]
        BoundingBox MedRenFlatSoftBOld { get; }

        [DataMember(Name = "medRenFlatWithDot")]
        BoundingBox MedRenFlatWithDot { get; }

        [DataMember(Name = "medRenGClefCMN")]
        BoundingBox MedRenGClefCmn { get; }

        [DataMember(Name = "medRenLiquescenceCMN")]
        BoundingBox MedRenLiquescenceCmn { get; }

        [DataMember(Name = "medRenLiquescentAscCMN")]
        BoundingBox MedRenLiquescentAscCmn { get; }

        [DataMember(Name = "medRenLiquescentDescCMN")]
        BoundingBox MedRenLiquescentDescCmn { get; }

        [DataMember(Name = "medRenNatural")]
        BoundingBox MedRenNatural { get; }

        [DataMember(Name = "medRenNaturalWithCross")]
        BoundingBox MedRenNaturalWithCross { get; }

        [DataMember(Name = "medRenOriscusCMN")]
        BoundingBox MedRenOriscusCmn { get; }

        [DataMember(Name = "medRenPlicaCMN")]
        BoundingBox MedRenPlicaCmn { get; }

        [DataMember(Name = "medRenPunctumCMN")]
        BoundingBox MedRenPunctumCmn { get; }

        [DataMember(Name = "medRenQuilismaCMN")]
        BoundingBox MedRenQuilismaCmn { get; }

        [DataMember(Name = "medRenSharpCroix")]
        BoundingBox MedRenSharpCroix { get; }

        [DataMember(Name = "medRenStrophicusCMN")]
        BoundingBox MedRenStrophicusCmn { get; }

        [DataMember(Name = "mensuralAlterationSign")]
        BoundingBox MensuralAlterationSign { get; }

        [DataMember(Name = "mensuralBlackBrevis")]
        BoundingBox MensuralBlackBrevis { get; }

        [DataMember(Name = "mensuralBlackBrevisVoid")]
        BoundingBox MensuralBlackBrevisVoid { get; }

        [DataMember(Name = "mensuralBlackDragma")]
        BoundingBox MensuralBlackDragma { get; }

        [DataMember(Name = "mensuralBlackLonga")]
        BoundingBox MensuralBlackLonga { get; }

        [DataMember(Name = "mensuralBlackMaxima")]
        BoundingBox MensuralBlackMaxima { get; }

        [DataMember(Name = "mensuralBlackMinima")]
        BoundingBox MensuralBlackMinima { get; }

        [DataMember(Name = "mensuralBlackMinimaVoid")]
        BoundingBox MensuralBlackMinimaVoid { get; }

        [DataMember(Name = "mensuralBlackSemibrevis")]
        BoundingBox MensuralBlackSemibrevis { get; }

        [DataMember(Name = "mensuralBlackSemibrevisCaudata")]
        BoundingBox MensuralBlackSemibrevisCaudata { get; }

        [DataMember(Name = "mensuralBlackSemibrevisOblique")]
        BoundingBox MensuralBlackSemibrevisOblique { get; }

        [DataMember(Name = "mensuralBlackSemibrevisVoid")]
        BoundingBox MensuralBlackSemibrevisVoid { get; }

        [DataMember(Name = "mensuralBlackSemiminima")]
        BoundingBox MensuralBlackSemiminima { get; }

        [DataMember(Name = "mensuralCclef")]
        BoundingBox MensuralCclef { get; }

        [DataMember(Name = "mensuralCclefBlack")]
        BoundingBox MensuralCclefBlack { get; }

        [DataMember(Name = "mensuralCclefPetrucciPosHigh")]
        BoundingBox MensuralCclefPetrucciPosHigh { get; }

        [DataMember(Name = "mensuralCclefPetrucciPosHighest")]
        BoundingBox MensuralCclefPetrucciPosHighest { get; }

        [DataMember(Name = "mensuralCclefPetrucciPosLow")]
        BoundingBox MensuralCclefPetrucciPosLow { get; }

        [DataMember(Name = "mensuralCclefPetrucciPosLowest")]
        BoundingBox MensuralCclefPetrucciPosLowest { get; }

        [DataMember(Name = "mensuralCclefPetrucciPosMiddle")]
        BoundingBox MensuralCclefPetrucciPosMiddle { get; }

        [DataMember(Name = "mensuralCclefVoid")]
        BoundingBox MensuralCclefVoid { get; }

        [DataMember(Name = "mensuralColorationEndRound")]
        BoundingBox MensuralColorationEndRound { get; }

        [DataMember(Name = "mensuralColorationEndSquare")]
        BoundingBox MensuralColorationEndSquare { get; }

        [DataMember(Name = "mensuralColorationStartRound")]
        BoundingBox MensuralColorationStartRound { get; }

        [DataMember(Name = "mensuralColorationStartSquare")]
        BoundingBox MensuralColorationStartSquare { get; }

        [DataMember(Name = "mensuralCombStemDiagonal")]
        BoundingBox MensuralCombStemDiagonal { get; }

        [DataMember(Name = "mensuralCombStemDown")]
        BoundingBox MensuralCombStemDown { get; }

        [DataMember(Name = "mensuralCombStemDownFlagExtended")]
        BoundingBox MensuralCombStemDownFlagExtended { get; }

        [DataMember(Name = "mensuralCombStemDownFlagFlared")]
        BoundingBox MensuralCombStemDownFlagFlared { get; }

        [DataMember(Name = "mensuralCombStemDownFlagFusa")]
        BoundingBox MensuralCombStemDownFlagFusa { get; }

        [DataMember(Name = "mensuralCombStemDownFlagLeft")]
        BoundingBox MensuralCombStemDownFlagLeft { get; }

        [DataMember(Name = "mensuralCombStemDownFlagRight")]
        BoundingBox MensuralCombStemDownFlagRight { get; }

        [DataMember(Name = "mensuralCombStemDownFlagSemiminima")]
        BoundingBox MensuralCombStemDownFlagSemiminima { get; }

        [DataMember(Name = "mensuralCombStemUp")]
        BoundingBox MensuralCombStemUp { get; }

        [DataMember(Name = "mensuralCombStemUpFlagExtended")]
        BoundingBox MensuralCombStemUpFlagExtended { get; }

        [DataMember(Name = "mensuralCombStemUpFlagFlared")]
        BoundingBox MensuralCombStemUpFlagFlared { get; }

        [DataMember(Name = "mensuralCombStemUpFlagFusa")]
        BoundingBox MensuralCombStemUpFlagFusa { get; }

        [DataMember(Name = "mensuralCombStemUpFlagLeft")]
        BoundingBox MensuralCombStemUpFlagLeft { get; }

        [DataMember(Name = "mensuralCombStemUpFlagRight")]
        BoundingBox MensuralCombStemUpFlagRight { get; }

        [DataMember(Name = "mensuralCombStemUpFlagSemiminima")]
        BoundingBox MensuralCombStemUpFlagSemiminima { get; }

        [DataMember(Name = "mensuralCustosCheckmark")]
        BoundingBox MensuralCustosCheckmark { get; }

        [DataMember(Name = "mensuralCustosDown")]
        BoundingBox MensuralCustosDown { get; }

        [DataMember(Name = "mensuralCustosTurn")]
        BoundingBox MensuralCustosTurn { get; }

        [DataMember(Name = "mensuralCustosUp")]
        BoundingBox MensuralCustosUp { get; }

        [DataMember(Name = "mensuralFclef")]
        BoundingBox MensuralFclef { get; }

        [DataMember(Name = "mensuralFclefPetrucci")]
        BoundingBox MensuralFclefPetrucci { get; }

        [DataMember(Name = "mensuralFusaBlackStemDown")]
        BoundingBox MensuralFusaBlackStemDown { get; }

        [DataMember(Name = "mensuralFusaBlackStemUp")]
        BoundingBox MensuralFusaBlackStemUp { get; }

        [DataMember(Name = "mensuralFusaBlackVoidStemDown")]
        BoundingBox MensuralFusaBlackVoidStemDown { get; }

        [DataMember(Name = "mensuralFusaBlackVoidStemUp")]
        BoundingBox MensuralFusaBlackVoidStemUp { get; }

        [DataMember(Name = "mensuralFusaVoidStemDown")]
        BoundingBox MensuralFusaVoidStemDown { get; }

        [DataMember(Name = "mensuralFusaVoidStemUp")]
        BoundingBox MensuralFusaVoidStemUp { get; }

        [DataMember(Name = "mensuralGclef")]
        BoundingBox MensuralGclef { get; }

        [DataMember(Name = "mensuralGclefPetrucci")]
        BoundingBox MensuralGclefPetrucci { get; }

        [DataMember(Name = "mensuralLongaBlackStemDownLeft")]
        BoundingBox MensuralLongaBlackStemDownLeft { get; }

        [DataMember(Name = "mensuralLongaBlackStemDownRight")]
        BoundingBox MensuralLongaBlackStemDownRight { get; }

        [DataMember(Name = "mensuralLongaBlackStemUpLeft")]
        BoundingBox MensuralLongaBlackStemUpLeft { get; }

        [DataMember(Name = "mensuralLongaBlackStemUpRight")]
        BoundingBox MensuralLongaBlackStemUpRight { get; }

        [DataMember(Name = "mensuralLongaBlackVoidStemDownLeft")]
        BoundingBox MensuralLongaBlackVoidStemDownLeft { get; }

        [DataMember(Name = "mensuralLongaBlackVoidStemDownRight")]
        BoundingBox MensuralLongaBlackVoidStemDownRight { get; }

        [DataMember(Name = "mensuralLongaBlackVoidStemUpLeft")]
        BoundingBox MensuralLongaBlackVoidStemUpLeft { get; }

        [DataMember(Name = "mensuralLongaBlackVoidStemUpRight")]
        BoundingBox MensuralLongaBlackVoidStemUpRight { get; }

        [DataMember(Name = "mensuralLongaVoidStemDownLeft")]
        BoundingBox MensuralLongaVoidStemDownLeft { get; }

        [DataMember(Name = "mensuralLongaVoidStemDownRight")]
        BoundingBox MensuralLongaVoidStemDownRight { get; }

        [DataMember(Name = "mensuralLongaVoidStemUpLeft")]
        BoundingBox MensuralLongaVoidStemUpLeft { get; }

        [DataMember(Name = "mensuralLongaVoidStemUpRight")]
        BoundingBox MensuralLongaVoidStemUpRight { get; }

        [DataMember(Name = "mensuralMaximaBlackStemDownLeft")]
        BoundingBox MensuralMaximaBlackStemDownLeft { get; }

        [DataMember(Name = "mensuralMaximaBlackStemDownRight")]
        BoundingBox MensuralMaximaBlackStemDownRight { get; }

        [DataMember(Name = "mensuralMaximaBlackStemUpLeft")]
        BoundingBox MensuralMaximaBlackStemUpLeft { get; }

        [DataMember(Name = "mensuralMaximaBlackStemUpRight")]
        BoundingBox MensuralMaximaBlackStemUpRight { get; }

        [DataMember(Name = "mensuralMaximaBlackVoidStemDownLeft")]
        BoundingBox MensuralMaximaBlackVoidStemDownLeft { get; }

        [DataMember(Name = "mensuralMaximaBlackVoidStemDownRight")]
        BoundingBox MensuralMaximaBlackVoidStemDownRight { get; }

        [DataMember(Name = "mensuralMaximaBlackVoidStemUpLeft")]
        BoundingBox MensuralMaximaBlackVoidStemUpLeft { get; }

        [DataMember(Name = "mensuralMaximaBlackVoidStemUpRight")]
        BoundingBox MensuralMaximaBlackVoidStemUpRight { get; }

        [DataMember(Name = "mensuralMaximaVoidStemDownLeft")]
        BoundingBox MensuralMaximaVoidStemDownLeft { get; }

        [DataMember(Name = "mensuralMaximaVoidStemDownRight")]
        BoundingBox MensuralMaximaVoidStemDownRight { get; }

        [DataMember(Name = "mensuralMaximaVoidStemUpLeft")]
        BoundingBox MensuralMaximaVoidStemUpLeft { get; }

        [DataMember(Name = "mensuralMaximaVoidStemUpRight")]
        BoundingBox MensuralMaximaVoidStemUpRight { get; }

        [DataMember(Name = "mensuralMinimaBlackStemDown")]
        BoundingBox MensuralMinimaBlackStemDown { get; }

        [DataMember(Name = "mensuralMinimaBlackStemDownExtendedFlag")]
        BoundingBox MensuralMinimaBlackStemDownExtendedFlag { get; }

        [DataMember(Name = "mensuralMinimaBlackStemDownFlagLeft")]
        BoundingBox MensuralMinimaBlackStemDownFlagLeft { get; }

        [DataMember(Name = "mensuralMinimaBlackStemDownFlagRight")]
        BoundingBox MensuralMinimaBlackStemDownFlagRight { get; }

        [DataMember(Name = "mensuralMinimaBlackStemDownFlaredFlag")]
        BoundingBox MensuralMinimaBlackStemDownFlaredFlag { get; }

        [DataMember(Name = "mensuralMinimaBlackStemUp")]
        BoundingBox MensuralMinimaBlackStemUp { get; }

        [DataMember(Name = "mensuralMinimaBlackStemUpExtendedFlag")]
        BoundingBox MensuralMinimaBlackStemUpExtendedFlag { get; }

        [DataMember(Name = "mensuralMinimaBlackStemUpFlagLeft")]
        BoundingBox MensuralMinimaBlackStemUpFlagLeft { get; }

        [DataMember(Name = "mensuralMinimaBlackStemUpFlagRight")]
        BoundingBox MensuralMinimaBlackStemUpFlagRight { get; }

        [DataMember(Name = "mensuralMinimaBlackStemUpFlaredFlag")]
        BoundingBox MensuralMinimaBlackStemUpFlaredFlag { get; }

        [DataMember(Name = "mensuralMinimaBlackVoidStemDown")]
        BoundingBox MensuralMinimaBlackVoidStemDown { get; }

        [DataMember(Name = "mensuralMinimaBlackVoidStemDownExtendedFlag")]
        BoundingBox MensuralMinimaBlackVoidStemDownExtendedFlag { get; }

        [DataMember(Name = "mensuralMinimaBlackVoidStemDownFlagLeft")]
        BoundingBox MensuralMinimaBlackVoidStemDownFlagLeft { get; }

        [DataMember(Name = "mensuralMinimaBlackVoidStemDownFlagRight")]
        BoundingBox MensuralMinimaBlackVoidStemDownFlagRight { get; }

        [DataMember(Name = "mensuralMinimaBlackVoidStemDownFlaredFlag")]
        BoundingBox MensuralMinimaBlackVoidStemDownFlaredFlag { get; }

        [DataMember(Name = "mensuralMinimaBlackVoidStemUp")]
        BoundingBox MensuralMinimaBlackVoidStemUp { get; }

        [DataMember(Name = "mensuralMinimaBlackVoidStemUpExtendedFlag")]
        BoundingBox MensuralMinimaBlackVoidStemUpExtendedFlag { get; }

        [DataMember(Name = "mensuralMinimaBlackVoidStemUpFlagLeft")]
        BoundingBox MensuralMinimaBlackVoidStemUpFlagLeft { get; }

        [DataMember(Name = "mensuralMinimaBlackVoidStemUpFlagRight")]
        BoundingBox MensuralMinimaBlackVoidStemUpFlagRight { get; }

        [DataMember(Name = "mensuralMinimaBlackVoidStemUpFlaredFlag")]
        BoundingBox MensuralMinimaBlackVoidStemUpFlaredFlag { get; }

        [DataMember(Name = "mensuralMinimaVoidStemDown")]
        BoundingBox MensuralMinimaVoidStemDown { get; }

        [DataMember(Name = "mensuralMinimaVoidStemDownExtendedFlag")]
        BoundingBox MensuralMinimaVoidStemDownExtendedFlag { get; }

        [DataMember(Name = "mensuralMinimaVoidStemDownFlagLeft")]
        BoundingBox MensuralMinimaVoidStemDownFlagLeft { get; }

        [DataMember(Name = "mensuralMinimaVoidStemDownFlagRight")]
        BoundingBox MensuralMinimaVoidStemDownFlagRight { get; }

        [DataMember(Name = "mensuralMinimaVoidStemDownFlaredFlag")]
        BoundingBox MensuralMinimaVoidStemDownFlaredFlag { get; }

        [DataMember(Name = "mensuralMinimaVoidStemUp")]
        BoundingBox MensuralMinimaVoidStemUp { get; }

        [DataMember(Name = "mensuralMinimaVoidStemUpExtendedFlag")]
        BoundingBox MensuralMinimaVoidStemUpExtendedFlag { get; }

        [DataMember(Name = "mensuralMinimaVoidStemUpFlagLeft")]
        BoundingBox MensuralMinimaVoidStemUpFlagLeft { get; }

        [DataMember(Name = "mensuralMinimaVoidStemUpFlagRight")]
        BoundingBox MensuralMinimaVoidStemUpFlagRight { get; }

        [DataMember(Name = "mensuralMinimaVoidStemUpFlaredFlag")]
        BoundingBox MensuralMinimaVoidStemUpFlaredFlag { get; }

        [DataMember(Name = "mensuralModusImperfectumVert")]
        BoundingBox MensuralModusImperfectumVert { get; }

        [DataMember(Name = "mensuralModusPerfectumVert")]
        BoundingBox MensuralModusPerfectumVert { get; }

        [DataMember(Name = "mensuralNoteheadLongaBlack")]
        BoundingBox MensuralNoteheadLongaBlack { get; }

        [DataMember(Name = "mensuralNoteheadLongaBlackVoid")]
        BoundingBox MensuralNoteheadLongaBlackVoid { get; }

        [DataMember(Name = "mensuralNoteheadLongaVoid")]
        BoundingBox MensuralNoteheadLongaVoid { get; }

        [DataMember(Name = "mensuralNoteheadLongaWhite")]
        BoundingBox MensuralNoteheadLongaWhite { get; }

        [DataMember(Name = "mensuralNoteheadMaximaBlack")]
        BoundingBox MensuralNoteheadMaximaBlack { get; }

        [DataMember(Name = "mensuralNoteheadMaximaBlackVoid")]
        BoundingBox MensuralNoteheadMaximaBlackVoid { get; }

        [DataMember(Name = "mensuralNoteheadMaximaVoid")]
        BoundingBox MensuralNoteheadMaximaVoid { get; }

        [DataMember(Name = "mensuralNoteheadMaximaWhite")]
        BoundingBox MensuralNoteheadMaximaWhite { get; }

        [DataMember(Name = "mensuralNoteheadMinimaWhite")]
        BoundingBox MensuralNoteheadMinimaWhite { get; }

        [DataMember(Name = "mensuralNoteheadSemibrevisBlack")]
        BoundingBox MensuralNoteheadSemibrevisBlack { get; }

        [DataMember(Name = "mensuralNoteheadSemibrevisBlackVoid")]
        BoundingBox MensuralNoteheadSemibrevisBlackVoid { get; }

        [DataMember(Name = "mensuralNoteheadSemibrevisBlackVoidTurned")]
        BoundingBox MensuralNoteheadSemibrevisBlackVoidTurned { get; }

        [DataMember(Name = "mensuralNoteheadSemibrevisVoid")]
        BoundingBox MensuralNoteheadSemibrevisVoid { get; }

        [DataMember(Name = "mensuralNoteheadSemiminimaWhite")]
        BoundingBox MensuralNoteheadSemiminimaWhite { get; }

        [DataMember(Name = "mensuralObliqueAsc2ndBlack")]
        BoundingBox MensuralObliqueAsc2NdBlack { get; }

        [DataMember(Name = "mensuralObliqueAsc2ndBlackVoid")]
        BoundingBox MensuralObliqueAsc2NdBlackVoid { get; }

        [DataMember(Name = "mensuralObliqueAsc2ndVoid")]
        BoundingBox MensuralObliqueAsc2NdVoid { get; }

        [DataMember(Name = "mensuralObliqueAsc2ndWhite")]
        BoundingBox MensuralObliqueAsc2NdWhite { get; }

        [DataMember(Name = "mensuralObliqueAsc3rdBlack")]
        BoundingBox MensuralObliqueAsc3RdBlack { get; }

        [DataMember(Name = "mensuralObliqueAsc3rdBlackVoid")]
        BoundingBox MensuralObliqueAsc3RdBlackVoid { get; }

        [DataMember(Name = "mensuralObliqueAsc3rdVoid")]
        BoundingBox MensuralObliqueAsc3RdVoid { get; }

        [DataMember(Name = "mensuralObliqueAsc3rdWhite")]
        BoundingBox MensuralObliqueAsc3RdWhite { get; }

        [DataMember(Name = "mensuralObliqueAsc4thBlack")]
        BoundingBox MensuralObliqueAsc4ThBlack { get; }

        [DataMember(Name = "mensuralObliqueAsc4thBlackVoid")]
        BoundingBox MensuralObliqueAsc4ThBlackVoid { get; }

        [DataMember(Name = "mensuralObliqueAsc4thVoid")]
        BoundingBox MensuralObliqueAsc4ThVoid { get; }

        [DataMember(Name = "mensuralObliqueAsc4thWhite")]
        BoundingBox MensuralObliqueAsc4ThWhite { get; }

        [DataMember(Name = "mensuralObliqueAsc5thBlack")]
        BoundingBox MensuralObliqueAsc5ThBlack { get; }

        [DataMember(Name = "mensuralObliqueAsc5thBlackVoid")]
        BoundingBox MensuralObliqueAsc5ThBlackVoid { get; }

        [DataMember(Name = "mensuralObliqueAsc5thVoid")]
        BoundingBox MensuralObliqueAsc5ThVoid { get; }

        [DataMember(Name = "mensuralObliqueAsc5thWhite")]
        BoundingBox MensuralObliqueAsc5ThWhite { get; }

        [DataMember(Name = "mensuralObliqueDesc2ndBlack")]
        BoundingBox MensuralObliqueDesc2NdBlack { get; }

        [DataMember(Name = "mensuralObliqueDesc2ndBlackVoid")]
        BoundingBox MensuralObliqueDesc2NdBlackVoid { get; }

        [DataMember(Name = "mensuralObliqueDesc2ndVoid")]
        BoundingBox MensuralObliqueDesc2NdVoid { get; }

        [DataMember(Name = "mensuralObliqueDesc2ndWhite")]
        BoundingBox MensuralObliqueDesc2NdWhite { get; }

        [DataMember(Name = "mensuralObliqueDesc3rdBlack")]
        BoundingBox MensuralObliqueDesc3RdBlack { get; }

        [DataMember(Name = "mensuralObliqueDesc3rdBlackVoid")]
        BoundingBox MensuralObliqueDesc3RdBlackVoid { get; }

        [DataMember(Name = "mensuralObliqueDesc3rdVoid")]
        BoundingBox MensuralObliqueDesc3RdVoid { get; }

        [DataMember(Name = "mensuralObliqueDesc3rdWhite")]
        BoundingBox MensuralObliqueDesc3RdWhite { get; }

        [DataMember(Name = "mensuralObliqueDesc4thBlack")]
        BoundingBox MensuralObliqueDesc4ThBlack { get; }

        [DataMember(Name = "mensuralObliqueDesc4thBlackVoid")]
        BoundingBox MensuralObliqueDesc4ThBlackVoid { get; }

        [DataMember(Name = "mensuralObliqueDesc4thVoid")]
        BoundingBox MensuralObliqueDesc4ThVoid { get; }

        [DataMember(Name = "mensuralObliqueDesc4thWhite")]
        BoundingBox MensuralObliqueDesc4ThWhite { get; }

        [DataMember(Name = "mensuralObliqueDesc5thBlack")]
        BoundingBox MensuralObliqueDesc5ThBlack { get; }

        [DataMember(Name = "mensuralObliqueDesc5thBlackVoid")]
        BoundingBox MensuralObliqueDesc5ThBlackVoid { get; }

        [DataMember(Name = "mensuralObliqueDesc5thVoid")]
        BoundingBox MensuralObliqueDesc5ThVoid { get; }

        [DataMember(Name = "mensuralObliqueDesc5thWhite")]
        BoundingBox MensuralObliqueDesc5ThWhite { get; }

        [DataMember(Name = "mensuralProlation1")]
        BoundingBox MensuralProlation1 { get; }

        [DataMember(Name = "mensuralProlation10")]
        BoundingBox MensuralProlation10 { get; }

        [DataMember(Name = "mensuralProlation11")]
        BoundingBox MensuralProlation11 { get; }

        [DataMember(Name = "mensuralProlation2")]
        BoundingBox MensuralProlation2 { get; }

        [DataMember(Name = "mensuralProlation3")]
        BoundingBox MensuralProlation3 { get; }

        [DataMember(Name = "mensuralProlation4")]
        BoundingBox MensuralProlation4 { get; }

        [DataMember(Name = "mensuralProlation5")]
        BoundingBox MensuralProlation5 { get; }

        [DataMember(Name = "mensuralProlation6")]
        BoundingBox MensuralProlation6 { get; }

        [DataMember(Name = "mensuralProlation7")]
        BoundingBox MensuralProlation7 { get; }

        [DataMember(Name = "mensuralProlation8")]
        BoundingBox MensuralProlation8 { get; }

        [DataMember(Name = "mensuralProlation9")]
        BoundingBox MensuralProlation9 { get; }

        [DataMember(Name = "mensuralProlationCombiningDot")]
        BoundingBox MensuralProlationCombiningDot { get; }

        [DataMember(Name = "mensuralProlationCombiningDotVoid")]
        BoundingBox MensuralProlationCombiningDotVoid { get; }

        [DataMember(Name = "mensuralProlationCombiningStroke")]
        BoundingBox MensuralProlationCombiningStroke { get; }

        [DataMember(Name = "mensuralProlationCombiningThreeDots")]
        BoundingBox MensuralProlationCombiningThreeDots { get; }

        [DataMember(Name = "mensuralProlationCombiningThreeDotsTri")]
        BoundingBox MensuralProlationCombiningThreeDotsTri { get; }

        [DataMember(Name = "mensuralProlationCombiningTwoDots")]
        BoundingBox MensuralProlationCombiningTwoDots { get; }

        [DataMember(Name = "mensuralProportion1")]
        BoundingBox MensuralProportion1 { get; }

        [DataMember(Name = "mensuralProportion2")]
        BoundingBox MensuralProportion2 { get; }

        [DataMember(Name = "mensuralProportion3")]
        BoundingBox MensuralProportion3 { get; }

        [DataMember(Name = "mensuralProportion4")]
        BoundingBox MensuralProportion4 { get; }

        [DataMember(Name = "mensuralProportion4Old")]
        BoundingBox MensuralProportion4Old { get; }

        [DataMember(Name = "mensuralProportionMajor")]
        BoundingBox MensuralProportionMajor { get; }

        [DataMember(Name = "mensuralProportionMinor")]
        BoundingBox MensuralProportionMinor { get; }

        [DataMember(Name = "mensuralProportionProportioDupla1")]
        BoundingBox MensuralProportionProportioDupla1 { get; }

        [DataMember(Name = "mensuralProportionProportioDupla2")]
        BoundingBox MensuralProportionProportioDupla2 { get; }

        [DataMember(Name = "mensuralProportionProportioQuadrupla")]
        BoundingBox MensuralProportionProportioQuadrupla { get; }

        [DataMember(Name = "mensuralProportionProportioTripla")]
        BoundingBox MensuralProportionProportioTripla { get; }

        [DataMember(Name = "mensuralProportionTempusPerfectum")]
        BoundingBox MensuralProportionTempusPerfectum { get; }

        [DataMember(Name = "mensuralRestBrevis")]
        BoundingBox MensuralRestBrevis { get; }

        [DataMember(Name = "mensuralRestFusa")]
        BoundingBox MensuralRestFusa { get; }

        [DataMember(Name = "mensuralRestLongaImperfecta")]
        BoundingBox MensuralRestLongaImperfecta { get; }

        [DataMember(Name = "mensuralRestLongaPerfecta")]
        BoundingBox MensuralRestLongaPerfecta { get; }

        [DataMember(Name = "mensuralRestMaxima")]
        BoundingBox MensuralRestMaxima { get; }

        [DataMember(Name = "mensuralRestMinima")]
        BoundingBox MensuralRestMinima { get; }

        [DataMember(Name = "mensuralRestSemibrevis")]
        BoundingBox MensuralRestSemibrevis { get; }

        [DataMember(Name = "mensuralRestSemifusa")]
        BoundingBox MensuralRestSemifusa { get; }

        [DataMember(Name = "mensuralRestSemiminima")]
        BoundingBox MensuralRestSemiminima { get; }

        [DataMember(Name = "mensuralSemiminimaBlackStemDown")]
        BoundingBox MensuralSemiminimaBlackStemDown { get; }

        [DataMember(Name = "mensuralSemiminimaBlackStemUp")]
        BoundingBox MensuralSemiminimaBlackStemUp { get; }

        [DataMember(Name = "mensuralSemiminimaBlackVoidStemDown")]
        BoundingBox MensuralSemiminimaBlackVoidStemDown { get; }

        [DataMember(Name = "mensuralSemiminimaBlackVoidStemUp")]
        BoundingBox MensuralSemiminimaBlackVoidStemUp { get; }

        [DataMember(Name = "mensuralSemiminimaVoidStemDown")]
        BoundingBox MensuralSemiminimaVoidStemDown { get; }

        [DataMember(Name = "mensuralSemiminimaVoidStemUp")]
        BoundingBox MensuralSemiminimaVoidStemUp { get; }

        [DataMember(Name = "mensuralSignumDown")]
        BoundingBox MensuralSignumDown { get; }

        [DataMember(Name = "mensuralSignumUp")]
        BoundingBox MensuralSignumUp { get; }

        [DataMember(Name = "mensuralTempusImperfectumHoriz")]
        BoundingBox MensuralTempusImperfectumHoriz { get; }

        [DataMember(Name = "mensuralTempusPerfectumHoriz")]
        BoundingBox MensuralTempusPerfectumHoriz { get; }

        [DataMember(Name = "mensuralWhiteBrevis")]
        BoundingBox MensuralWhiteBrevis { get; }

        [DataMember(Name = "mensuralWhiteFusa")]
        BoundingBox MensuralWhiteFusa { get; }

        [DataMember(Name = "mensuralWhiteLonga")]
        BoundingBox MensuralWhiteLonga { get; }

        [DataMember(Name = "mensuralWhiteMaxima")]
        BoundingBox MensuralWhiteMaxima { get; }

        [DataMember(Name = "mensuralWhiteMinima")]
        BoundingBox MensuralWhiteMinima { get; }

        [DataMember(Name = "mensuralWhiteSemiminima")]
        BoundingBox MensuralWhiteSemiminima { get; }

        [DataMember(Name = "metAugmentationDot")]
        BoundingBox MetAugmentationDot { get; }

        [DataMember(Name = "metNote1024thDown")]
        BoundingBox MetNote1024ThDown { get; }

        [DataMember(Name = "metNote1024thUp")]
        BoundingBox MetNote1024ThUp { get; }

        [DataMember(Name = "metNote128thDown")]
        BoundingBox MetNote128ThDown { get; }

        [DataMember(Name = "metNote128thUp")]
        BoundingBox MetNote128ThUp { get; }

        [DataMember(Name = "metNote16thDown")]
        BoundingBox MetNote16ThDown { get; }

        [DataMember(Name = "metNote16thUp")]
        BoundingBox MetNote16ThUp { get; }

        [DataMember(Name = "metNote256thDown")]
        BoundingBox MetNote256ThDown { get; }

        [DataMember(Name = "metNote256thUp")]
        BoundingBox MetNote256ThUp { get; }

        [DataMember(Name = "metNote32ndDown")]
        BoundingBox MetNote32NdDown { get; }

        [DataMember(Name = "metNote32ndUp")]
        BoundingBox MetNote32NdUp { get; }

        [DataMember(Name = "metNote512thDown")]
        BoundingBox MetNote512ThDown { get; }

        [DataMember(Name = "metNote512thUp")]
        BoundingBox MetNote512ThUp { get; }

        [DataMember(Name = "metNote64thDown")]
        BoundingBox MetNote64ThDown { get; }

        [DataMember(Name = "metNote64thUp")]
        BoundingBox MetNote64ThUp { get; }

        [DataMember(Name = "metNote8thDown")]
        BoundingBox MetNote8ThDown { get; }

        [DataMember(Name = "metNote8thUp")]
        BoundingBox MetNote8ThUp { get; }

        [DataMember(Name = "metNoteDoubleWhole")]
        BoundingBox MetNoteDoubleWhole { get; }

        [DataMember(Name = "metNoteDoubleWholeSquare")]
        BoundingBox MetNoteDoubleWholeSquare { get; }

        [DataMember(Name = "metNoteHalfDown")]
        BoundingBox MetNoteHalfDown { get; }

        [DataMember(Name = "metNoteHalfUp")]
        BoundingBox MetNoteHalfUp { get; }

        [DataMember(Name = "metNoteQuarterDown")]
        BoundingBox MetNoteQuarterDown { get; }

        [DataMember(Name = "metNoteQuarterUp")]
        BoundingBox MetNoteQuarterUp { get; }

        [DataMember(Name = "metNoteWhole")]
        BoundingBox MetNoteWhole { get; }

        [DataMember(Name = "metricModulationArrowLeft")]
        BoundingBox MetricModulationArrowLeft { get; }

        [DataMember(Name = "metricModulationArrowRight")]
        BoundingBox MetricModulationArrowRight { get; }

        [DataMember(Name = "miscDoNotCopy")]
        BoundingBox MiscDoNotCopy { get; }

        [DataMember(Name = "miscDoNotPhotocopy")]
        BoundingBox MiscDoNotPhotocopy { get; }

        [DataMember(Name = "miscEyeglasses")]
        BoundingBox MiscEyeglasses { get; }

        [DataMember(Name = "note1024thDown")]
        BoundingBox Note1024ThDown { get; }

        [DataMember(Name = "note1024thUp")]
        BoundingBox Note1024ThUp { get; }

        [DataMember(Name = "note128thDown")]
        BoundingBox Note128ThDown { get; }

        [DataMember(Name = "note128thUp")]
        BoundingBox Note128ThUp { get; }

        [DataMember(Name = "note16thDown")]
        BoundingBox Note16ThDown { get; }

        [DataMember(Name = "note16thUp")]
        BoundingBox Note16ThUp { get; }

        [DataMember(Name = "note256thDown")]
        BoundingBox Note256ThDown { get; }

        [DataMember(Name = "note256thUp")]
        BoundingBox Note256ThUp { get; }

        [DataMember(Name = "note32ndDown")]
        BoundingBox Note32NdDown { get; }

        [DataMember(Name = "note32ndUp")]
        BoundingBox Note32NdUp { get; }

        [DataMember(Name = "note512thDown")]
        BoundingBox Note512ThDown { get; }

        [DataMember(Name = "note512thUp")]
        BoundingBox Note512ThUp { get; }

        [DataMember(Name = "note64thDown")]
        BoundingBox Note64ThDown { get; }

        [DataMember(Name = "note64thUp")]
        BoundingBox Note64ThUp { get; }

        [DataMember(Name = "note8thDown")]
        BoundingBox Note8ThDown { get; }

        [DataMember(Name = "note8thUp")]
        BoundingBox Note8ThUp { get; }

        [DataMember(Name = "noteABlack")]
        BoundingBox NoteABlack { get; }

        [DataMember(Name = "noteAFlatBlack")]
        BoundingBox NoteAFlatBlack { get; }

        [DataMember(Name = "noteAFlatHalf")]
        BoundingBox NoteAFlatHalf { get; }

        [DataMember(Name = "noteAFlatWhole")]
        BoundingBox NoteAFlatWhole { get; }

        [DataMember(Name = "noteAHalf")]
        BoundingBox NoteAHalf { get; }

        [DataMember(Name = "noteASharpBlack")]
        BoundingBox NoteASharpBlack { get; }

        [DataMember(Name = "noteASharpHalf")]
        BoundingBox NoteASharpHalf { get; }

        [DataMember(Name = "noteASharpWhole")]
        BoundingBox NoteASharpWhole { get; }

        [DataMember(Name = "noteAWhole")]
        BoundingBox NoteAWhole { get; }

        [DataMember(Name = "noteBBlack")]
        BoundingBox NoteBBlack { get; }

        [DataMember(Name = "noteBFlatBlack")]
        BoundingBox NoteBFlatBlack { get; }

        [DataMember(Name = "noteBFlatHalf")]
        BoundingBox NoteBFlatHalf { get; }

        [DataMember(Name = "noteBFlatWhole")]
        BoundingBox NoteBFlatWhole { get; }

        [DataMember(Name = "noteBHalf")]
        BoundingBox NoteBHalf { get; }

        [DataMember(Name = "noteBSharpBlack")]
        BoundingBox NoteBSharpBlack { get; }

        [DataMember(Name = "noteBSharpHalf")]
        BoundingBox NoteBSharpHalf { get; }

        [DataMember(Name = "noteBSharpWhole")]
        BoundingBox NoteBSharpWhole { get; }

        [DataMember(Name = "noteBWhole")]
        BoundingBox NoteBWhole { get; }

        [DataMember(Name = "noteCBlack")]
        BoundingBox NoteCBlack { get; }

        [DataMember(Name = "noteCFlatBlack")]
        BoundingBox NoteCFlatBlack { get; }

        [DataMember(Name = "noteCFlatHalf")]
        BoundingBox NoteCFlatHalf { get; }

        [DataMember(Name = "noteCFlatWhole")]
        BoundingBox NoteCFlatWhole { get; }

        [DataMember(Name = "noteCHalf")]
        BoundingBox NoteCHalf { get; }

        [DataMember(Name = "noteCSharpBlack")]
        BoundingBox NoteCSharpBlack { get; }

        [DataMember(Name = "noteCSharpHalf")]
        BoundingBox NoteCSharpHalf { get; }

        [DataMember(Name = "noteCSharpWhole")]
        BoundingBox NoteCSharpWhole { get; }

        [DataMember(Name = "noteCWhole")]
        BoundingBox NoteCWhole { get; }

        [DataMember(Name = "noteDBlack")]
        BoundingBox NoteDBlack { get; }

        [DataMember(Name = "noteDFlatBlack")]
        BoundingBox NoteDFlatBlack { get; }

        [DataMember(Name = "noteDFlatHalf")]
        BoundingBox NoteDFlatHalf { get; }

        [DataMember(Name = "noteDFlatWhole")]
        BoundingBox NoteDFlatWhole { get; }

        [DataMember(Name = "noteDHalf")]
        BoundingBox NoteDHalf { get; }

        [DataMember(Name = "noteDSharpBlack")]
        BoundingBox NoteDSharpBlack { get; }

        [DataMember(Name = "noteDSharpHalf")]
        BoundingBox NoteDSharpHalf { get; }

        [DataMember(Name = "noteDSharpWhole")]
        BoundingBox NoteDSharpWhole { get; }

        [DataMember(Name = "noteDWhole")]
        BoundingBox NoteDWhole { get; }

        [DataMember(Name = "noteDoBlack")]
        BoundingBox NoteDoBlack { get; }

        [DataMember(Name = "noteDoHalf")]
        BoundingBox NoteDoHalf { get; }

        [DataMember(Name = "noteDoWhole")]
        BoundingBox NoteDoWhole { get; }

        [DataMember(Name = "noteDoubleWhole")]
        BoundingBox NoteDoubleWhole { get; }

        [DataMember(Name = "noteDoubleWholeAlt")]
        BoundingBox NoteDoubleWholeAlt { get; }

        [DataMember(Name = "noteDoubleWholeSquare")]
        BoundingBox NoteDoubleWholeSquare { get; }

        [DataMember(Name = "noteEBlack")]
        BoundingBox NoteEBlack { get; }

        [DataMember(Name = "noteEFlatBlack")]
        BoundingBox NoteEFlatBlack { get; }

        [DataMember(Name = "noteEFlatHalf")]
        BoundingBox NoteEFlatHalf { get; }

        [DataMember(Name = "noteEFlatWhole")]
        BoundingBox NoteEFlatWhole { get; }

        [DataMember(Name = "noteEHalf")]
        BoundingBox NoteEHalf { get; }

        [DataMember(Name = "noteESharpBlack")]
        BoundingBox NoteESharpBlack { get; }

        [DataMember(Name = "noteESharpHalf")]
        BoundingBox NoteESharpHalf { get; }

        [DataMember(Name = "noteESharpWhole")]
        BoundingBox NoteESharpWhole { get; }

        [DataMember(Name = "noteEWhole")]
        BoundingBox NoteEWhole { get; }

        [DataMember(Name = "noteEmptyBlack")]
        BoundingBox NoteEmptyBlack { get; }

        [DataMember(Name = "noteEmptyHalf")]
        BoundingBox NoteEmptyHalf { get; }

        [DataMember(Name = "noteEmptyWhole")]
        BoundingBox NoteEmptyWhole { get; }

        [DataMember(Name = "noteFBlack")]
        BoundingBox NoteFBlack { get; }

        [DataMember(Name = "noteFFlatBlack")]
        BoundingBox NoteFFlatBlack { get; }

        [DataMember(Name = "noteFFlatHalf")]
        BoundingBox NoteFFlatHalf { get; }

        [DataMember(Name = "noteFFlatWhole")]
        BoundingBox NoteFFlatWhole { get; }

        [DataMember(Name = "noteFHalf")]
        BoundingBox NoteFHalf { get; }

        [DataMember(Name = "noteFSharpBlack")]
        BoundingBox NoteFSharpBlack { get; }

        [DataMember(Name = "noteFSharpHalf")]
        BoundingBox NoteFSharpHalf { get; }

        [DataMember(Name = "noteFSharpWhole")]
        BoundingBox NoteFSharpWhole { get; }

        [DataMember(Name = "noteFWhole")]
        BoundingBox NoteFWhole { get; }

        [DataMember(Name = "noteFaBlack")]
        BoundingBox NoteFaBlack { get; }

        [DataMember(Name = "noteFaHalf")]
        BoundingBox NoteFaHalf { get; }

        [DataMember(Name = "noteFaWhole")]
        BoundingBox NoteFaWhole { get; }

        [DataMember(Name = "noteGBlack")]
        BoundingBox NoteGBlack { get; }

        [DataMember(Name = "noteGFlatBlack")]
        BoundingBox NoteGFlatBlack { get; }

        [DataMember(Name = "noteGFlatHalf")]
        BoundingBox NoteGFlatHalf { get; }

        [DataMember(Name = "noteGFlatWhole")]
        BoundingBox NoteGFlatWhole { get; }

        [DataMember(Name = "noteGHalf")]
        BoundingBox NoteGHalf { get; }

        [DataMember(Name = "noteGSharpBlack")]
        BoundingBox NoteGSharpBlack { get; }

        [DataMember(Name = "noteGSharpHalf")]
        BoundingBox NoteGSharpHalf { get; }

        [DataMember(Name = "noteGSharpWhole")]
        BoundingBox NoteGSharpWhole { get; }

        [DataMember(Name = "noteGWhole")]
        BoundingBox NoteGWhole { get; }

        [DataMember(Name = "noteHBlack")]
        BoundingBox NoteHBlack { get; }

        [DataMember(Name = "noteHHalf")]
        BoundingBox NoteHHalf { get; }

        [DataMember(Name = "noteHSharpBlack")]
        BoundingBox NoteHSharpBlack { get; }

        [DataMember(Name = "noteHSharpHalf")]
        BoundingBox NoteHSharpHalf { get; }

        [DataMember(Name = "noteHSharpWhole")]
        BoundingBox NoteHSharpWhole { get; }

        [DataMember(Name = "noteHWhole")]
        BoundingBox NoteHWhole { get; }

        [DataMember(Name = "noteHalfDown")]
        BoundingBox NoteHalfDown { get; }

        [DataMember(Name = "noteHalfUp")]
        BoundingBox NoteHalfUp { get; }

        [DataMember(Name = "noteLaBlack")]
        BoundingBox NoteLaBlack { get; }

        [DataMember(Name = "noteLaHalf")]
        BoundingBox NoteLaHalf { get; }

        [DataMember(Name = "noteLaWhole")]
        BoundingBox NoteLaWhole { get; }

        [DataMember(Name = "noteMiBlack")]
        BoundingBox NoteMiBlack { get; }

        [DataMember(Name = "noteMiHalf")]
        BoundingBox NoteMiHalf { get; }

        [DataMember(Name = "noteMiWhole")]
        BoundingBox NoteMiWhole { get; }

        [DataMember(Name = "noteQuarterDown")]
        BoundingBox NoteQuarterDown { get; }

        [DataMember(Name = "noteQuarterUp")]
        BoundingBox NoteQuarterUp { get; }

        [DataMember(Name = "noteReBlack")]
        BoundingBox NoteReBlack { get; }

        [DataMember(Name = "noteReHalf")]
        BoundingBox NoteReHalf { get; }

        [DataMember(Name = "noteReWhole")]
        BoundingBox NoteReWhole { get; }

        [DataMember(Name = "noteShapeArrowheadLeftBlack")]
        BoundingBox NoteShapeArrowheadLeftBlack { get; }

        [DataMember(Name = "noteShapeArrowheadLeftDoubleWhole")]
        BoundingBox NoteShapeArrowheadLeftDoubleWhole { get; }

        [DataMember(Name = "noteShapeArrowheadLeftWhite")]
        BoundingBox NoteShapeArrowheadLeftWhite { get; }

        [DataMember(Name = "noteShapeDiamondBlack")]
        BoundingBox NoteShapeDiamondBlack { get; }

        [DataMember(Name = "noteShapeDiamondDoubleWhole")]
        BoundingBox NoteShapeDiamondDoubleWhole { get; }

        [DataMember(Name = "noteShapeDiamondWhite")]
        BoundingBox NoteShapeDiamondWhite { get; }

        [DataMember(Name = "noteShapeIsoscelesTriangleBlack")]
        BoundingBox NoteShapeIsoscelesTriangleBlack { get; }

        [DataMember(Name = "noteShapeIsoscelesTriangleDoubleWhole")]
        BoundingBox NoteShapeIsoscelesTriangleDoubleWhole { get; }

        [DataMember(Name = "noteShapeIsoscelesTriangleWhite")]
        BoundingBox NoteShapeIsoscelesTriangleWhite { get; }

        [DataMember(Name = "noteShapeKeystoneBlack")]
        BoundingBox NoteShapeKeystoneBlack { get; }

        [DataMember(Name = "noteShapeKeystoneDoubleWhole")]
        BoundingBox NoteShapeKeystoneDoubleWhole { get; }

        [DataMember(Name = "noteShapeKeystoneWhite")]
        BoundingBox NoteShapeKeystoneWhite { get; }

        [DataMember(Name = "noteShapeMoonBlack")]
        BoundingBox NoteShapeMoonBlack { get; }

        [DataMember(Name = "noteShapeMoonDoubleWhole")]
        BoundingBox NoteShapeMoonDoubleWhole { get; }

        [DataMember(Name = "noteShapeMoonLeftBlack")]
        BoundingBox NoteShapeMoonLeftBlack { get; }

        [DataMember(Name = "noteShapeMoonLeftDoubleWhole")]
        BoundingBox NoteShapeMoonLeftDoubleWhole { get; }

        [DataMember(Name = "noteShapeMoonLeftWhite")]
        BoundingBox NoteShapeMoonLeftWhite { get; }

        [DataMember(Name = "noteShapeMoonWhite")]
        BoundingBox NoteShapeMoonWhite { get; }

        [DataMember(Name = "noteShapeQuarterMoonBlack")]
        BoundingBox NoteShapeQuarterMoonBlack { get; }

        [DataMember(Name = "noteShapeQuarterMoonDoubleWhole")]
        BoundingBox NoteShapeQuarterMoonDoubleWhole { get; }

        [DataMember(Name = "noteShapeQuarterMoonWhite")]
        BoundingBox NoteShapeQuarterMoonWhite { get; }

        [DataMember(Name = "noteShapeRoundBlack")]
        BoundingBox NoteShapeRoundBlack { get; }

        [DataMember(Name = "noteShapeRoundDoubleWhole")]
        BoundingBox NoteShapeRoundDoubleWhole { get; }

        [DataMember(Name = "noteShapeRoundWhite")]
        BoundingBox NoteShapeRoundWhite { get; }

        [DataMember(Name = "noteShapeSquareBlack")]
        BoundingBox NoteShapeSquareBlack { get; }

        [DataMember(Name = "noteShapeSquareDoubleWhole")]
        BoundingBox NoteShapeSquareDoubleWhole { get; }

        [DataMember(Name = "noteShapeSquareWhite")]
        BoundingBox NoteShapeSquareWhite { get; }

        [DataMember(Name = "noteShapeTriangleLeftBlack")]
        BoundingBox NoteShapeTriangleLeftBlack { get; }

        [DataMember(Name = "noteShapeTriangleLeftDoubleWhole")]
        BoundingBox NoteShapeTriangleLeftDoubleWhole { get; }

        [DataMember(Name = "noteShapeTriangleLeftWhite")]
        BoundingBox NoteShapeTriangleLeftWhite { get; }

        [DataMember(Name = "noteShapeTriangleRightBlack")]
        BoundingBox NoteShapeTriangleRightBlack { get; }

        [DataMember(Name = "noteShapeTriangleRightDoubleWhole")]
        BoundingBox NoteShapeTriangleRightDoubleWhole { get; }

        [DataMember(Name = "noteShapeTriangleRightWhite")]
        BoundingBox NoteShapeTriangleRightWhite { get; }

        [DataMember(Name = "noteShapeTriangleRoundBlack")]
        BoundingBox NoteShapeTriangleRoundBlack { get; }

        [DataMember(Name = "noteShapeTriangleRoundDoubleWhole")]
        BoundingBox NoteShapeTriangleRoundDoubleWhole { get; }

        [DataMember(Name = "noteShapeTriangleRoundLeftBlack")]
        BoundingBox NoteShapeTriangleRoundLeftBlack { get; }

        [DataMember(Name = "noteShapeTriangleRoundLeftDoubleWhole")]
        BoundingBox NoteShapeTriangleRoundLeftDoubleWhole { get; }

        [DataMember(Name = "noteShapeTriangleRoundLeftWhite")]
        BoundingBox NoteShapeTriangleRoundLeftWhite { get; }

        [DataMember(Name = "noteShapeTriangleRoundWhite")]
        BoundingBox NoteShapeTriangleRoundWhite { get; }

        [DataMember(Name = "noteShapeTriangleUpBlack")]
        BoundingBox NoteShapeTriangleUpBlack { get; }

        [DataMember(Name = "noteShapeTriangleUpDoubleWhole")]
        BoundingBox NoteShapeTriangleUpDoubleWhole { get; }

        [DataMember(Name = "noteShapeTriangleUpWhite")]
        BoundingBox NoteShapeTriangleUpWhite { get; }

        [DataMember(Name = "noteSiBlack")]
        BoundingBox NoteSiBlack { get; }

        [DataMember(Name = "noteSiHalf")]
        BoundingBox NoteSiHalf { get; }

        [DataMember(Name = "noteSiWhole")]
        BoundingBox NoteSiWhole { get; }

        [DataMember(Name = "noteSoBlack")]
        BoundingBox NoteSoBlack { get; }

        [DataMember(Name = "noteSoHalf")]
        BoundingBox NoteSoHalf { get; }

        [DataMember(Name = "noteSoWhole")]
        BoundingBox NoteSoWhole { get; }

        [DataMember(Name = "noteTiBlack")]
        BoundingBox NoteTiBlack { get; }

        [DataMember(Name = "noteTiHalf")]
        BoundingBox NoteTiHalf { get; }

        [DataMember(Name = "noteTiWhole")]
        BoundingBox NoteTiWhole { get; }

        [DataMember(Name = "noteWhole")]
        BoundingBox NoteWhole { get; }

        [DataMember(Name = "noteheadBlack")]
        BoundingBox NoteheadBlack { get; }

        [DataMember(Name = "noteheadBlackOversized")]
        BoundingBox NoteheadBlackOversized { get; }

        [DataMember(Name = "noteheadBlackParens")]
        BoundingBox NoteheadBlackParens { get; }

        [DataMember(Name = "noteheadBlackSmall")]
        BoundingBox NoteheadBlackSmall { get; }

        [DataMember(Name = "noteheadCircleSlash")]
        BoundingBox NoteheadCircleSlash { get; }

        [DataMember(Name = "noteheadCircleX")]
        BoundingBox NoteheadCircleX { get; }

        [DataMember(Name = "noteheadCircleXDoubleWhole")]
        BoundingBox NoteheadCircleXDoubleWhole { get; }

        [DataMember(Name = "noteheadCircleXHalf")]
        BoundingBox NoteheadCircleXHalf { get; }

        [DataMember(Name = "noteheadCircleXWhole")]
        BoundingBox NoteheadCircleXWhole { get; }

        [DataMember(Name = "noteheadCircledBlack")]
        BoundingBox NoteheadCircledBlack { get; }

        [DataMember(Name = "noteheadCircledBlackLarge")]
        BoundingBox NoteheadCircledBlackLarge { get; }

        [DataMember(Name = "noteheadCircledDoubleWhole")]
        BoundingBox NoteheadCircledDoubleWhole { get; }

        [DataMember(Name = "noteheadCircledDoubleWholeLarge")]
        BoundingBox NoteheadCircledDoubleWholeLarge { get; }

        [DataMember(Name = "noteheadCircledHalf")]
        BoundingBox NoteheadCircledHalf { get; }

        [DataMember(Name = "noteheadCircledHalfLarge")]
        BoundingBox NoteheadCircledHalfLarge { get; }

        [DataMember(Name = "noteheadCircledWhole")]
        BoundingBox NoteheadCircledWhole { get; }

        [DataMember(Name = "noteheadCircledWholeLarge")]
        BoundingBox NoteheadCircledWholeLarge { get; }

        [DataMember(Name = "noteheadCircledXLarge")]
        BoundingBox NoteheadCircledXLarge { get; }

        [DataMember(Name = "noteheadClusterDoubleWhole2nd")]
        BoundingBox NoteheadClusterDoubleWhole2Nd { get; }

        [DataMember(Name = "noteheadClusterDoubleWhole3rd")]
        BoundingBox NoteheadClusterDoubleWhole3Rd { get; }

        [DataMember(Name = "noteheadClusterDoubleWholeBottom")]
        BoundingBox NoteheadClusterDoubleWholeBottom { get; }

        [DataMember(Name = "noteheadClusterDoubleWholeMiddle")]
        BoundingBox NoteheadClusterDoubleWholeMiddle { get; }

        [DataMember(Name = "noteheadClusterDoubleWholeTop")]
        BoundingBox NoteheadClusterDoubleWholeTop { get; }

        [DataMember(Name = "noteheadClusterHalf2nd")]
        BoundingBox NoteheadClusterHalf2Nd { get; }

        [DataMember(Name = "noteheadClusterHalf3rd")]
        BoundingBox NoteheadClusterHalf3Rd { get; }

        [DataMember(Name = "noteheadClusterHalfBottom")]
        BoundingBox NoteheadClusterHalfBottom { get; }

        [DataMember(Name = "noteheadClusterHalfMiddle")]
        BoundingBox NoteheadClusterHalfMiddle { get; }

        [DataMember(Name = "noteheadClusterHalfTop")]
        BoundingBox NoteheadClusterHalfTop { get; }

        [DataMember(Name = "noteheadClusterQuarter2nd")]
        BoundingBox NoteheadClusterQuarter2Nd { get; }

        [DataMember(Name = "noteheadClusterQuarter3rd")]
        BoundingBox NoteheadClusterQuarter3Rd { get; }

        [DataMember(Name = "noteheadClusterQuarterBottom")]
        BoundingBox NoteheadClusterQuarterBottom { get; }

        [DataMember(Name = "noteheadClusterQuarterMiddle")]
        BoundingBox NoteheadClusterQuarterMiddle { get; }

        [DataMember(Name = "noteheadClusterQuarterTop")]
        BoundingBox NoteheadClusterQuarterTop { get; }

        [DataMember(Name = "noteheadClusterRoundBlack")]
        BoundingBox NoteheadClusterRoundBlack { get; }

        [DataMember(Name = "noteheadClusterRoundWhite")]
        BoundingBox NoteheadClusterRoundWhite { get; }

        [DataMember(Name = "noteheadClusterSquareBlack")]
        BoundingBox NoteheadClusterSquareBlack { get; }

        [DataMember(Name = "noteheadClusterSquareWhite")]
        BoundingBox NoteheadClusterSquareWhite { get; }

        [DataMember(Name = "noteheadClusterWhole2nd")]
        BoundingBox NoteheadClusterWhole2Nd { get; }

        [DataMember(Name = "noteheadClusterWhole3rd")]
        BoundingBox NoteheadClusterWhole3Rd { get; }

        [DataMember(Name = "noteheadClusterWholeBottom")]
        BoundingBox NoteheadClusterWholeBottom { get; }

        [DataMember(Name = "noteheadClusterWholeMiddle")]
        BoundingBox NoteheadClusterWholeMiddle { get; }

        [DataMember(Name = "noteheadClusterWholeTop")]
        BoundingBox NoteheadClusterWholeTop { get; }

        [DataMember(Name = "noteheadDiamondBlack")]
        BoundingBox NoteheadDiamondBlack { get; }

        [DataMember(Name = "noteheadDiamondBlackOld")]
        BoundingBox NoteheadDiamondBlackOld { get; }

        [DataMember(Name = "noteheadDiamondBlackWide")]
        BoundingBox NoteheadDiamondBlackWide { get; }

        [DataMember(Name = "noteheadDiamondClusterBlack2nd")]
        BoundingBox NoteheadDiamondClusterBlack2Nd { get; }

        [DataMember(Name = "noteheadDiamondClusterBlack3rd")]
        BoundingBox NoteheadDiamondClusterBlack3Rd { get; }

        [DataMember(Name = "noteheadDiamondClusterBlackBottom")]
        BoundingBox NoteheadDiamondClusterBlackBottom { get; }

        [DataMember(Name = "noteheadDiamondClusterBlackMiddle")]
        BoundingBox NoteheadDiamondClusterBlackMiddle { get; }

        [DataMember(Name = "noteheadDiamondClusterBlackTop")]
        BoundingBox NoteheadDiamondClusterBlackTop { get; }

        [DataMember(Name = "noteheadDiamondClusterWhite2nd")]
        BoundingBox NoteheadDiamondClusterWhite2Nd { get; }

        [DataMember(Name = "noteheadDiamondClusterWhite3rd")]
        BoundingBox NoteheadDiamondClusterWhite3Rd { get; }

        [DataMember(Name = "noteheadDiamondClusterWhiteBottom")]
        BoundingBox NoteheadDiamondClusterWhiteBottom { get; }

        [DataMember(Name = "noteheadDiamondClusterWhiteMiddle")]
        BoundingBox NoteheadDiamondClusterWhiteMiddle { get; }

        [DataMember(Name = "noteheadDiamondClusterWhiteTop")]
        BoundingBox NoteheadDiamondClusterWhiteTop { get; }

        [DataMember(Name = "noteheadDiamondDoubleWhole")]
        BoundingBox NoteheadDiamondDoubleWhole { get; }

        [DataMember(Name = "noteheadDiamondDoubleWholeOld")]
        BoundingBox NoteheadDiamondDoubleWholeOld { get; }

        [DataMember(Name = "noteheadDiamondHalf")]
        BoundingBox NoteheadDiamondHalf { get; }

        [DataMember(Name = "noteheadDiamondHalfFilled")]
        BoundingBox NoteheadDiamondHalfFilled { get; }

        [DataMember(Name = "noteheadDiamondHalfOld")]
        BoundingBox NoteheadDiamondHalfOld { get; }

        [DataMember(Name = "noteheadDiamondHalfWide")]
        BoundingBox NoteheadDiamondHalfWide { get; }

        [DataMember(Name = "noteheadDiamondOpen")]
        BoundingBox NoteheadDiamondOpen { get; }

        [DataMember(Name = "noteheadDiamondWhite")]
        BoundingBox NoteheadDiamondWhite { get; }

        [DataMember(Name = "noteheadDiamondWhiteWide")]
        BoundingBox NoteheadDiamondWhiteWide { get; }

        [DataMember(Name = "noteheadDiamondWhole")]
        BoundingBox NoteheadDiamondWhole { get; }

        [DataMember(Name = "noteheadDiamondWholeOld")]
        BoundingBox NoteheadDiamondWholeOld { get; }

        [DataMember(Name = "noteheadDoubleWhole")]
        BoundingBox NoteheadDoubleWhole { get; }

        [DataMember(Name = "noteheadDoubleWholeAlt")]
        BoundingBox NoteheadDoubleWholeAlt { get; }

        [DataMember(Name = "noteheadDoubleWholeOversized")]
        BoundingBox NoteheadDoubleWholeOversized { get; }

        [DataMember(Name = "noteheadDoubleWholeParens")]
        BoundingBox NoteheadDoubleWholeParens { get; }

        [DataMember(Name = "noteheadDoubleWholeSmall")]
        BoundingBox NoteheadDoubleWholeSmall { get; }

        [DataMember(Name = "noteheadDoubleWholeSquare")]
        BoundingBox NoteheadDoubleWholeSquare { get; }

        [DataMember(Name = "noteheadDoubleWholeSquareOversized")]
        BoundingBox NoteheadDoubleWholeSquareOversized { get; }

        [DataMember(Name = "noteheadDoubleWholeWithX")]
        BoundingBox NoteheadDoubleWholeWithX { get; }

        [DataMember(Name = "noteheadHalf")]
        BoundingBox NoteheadHalf { get; }

        [DataMember(Name = "noteheadHalfFilled")]
        BoundingBox NoteheadHalfFilled { get; }

        [DataMember(Name = "noteheadHalfOversized")]
        BoundingBox NoteheadHalfOversized { get; }

        [DataMember(Name = "noteheadHalfParens")]
        BoundingBox NoteheadHalfParens { get; }

        [DataMember(Name = "noteheadHalfSmall")]
        BoundingBox NoteheadHalfSmall { get; }

        [DataMember(Name = "noteheadHalfWithX")]
        BoundingBox NoteheadHalfWithX { get; }

        [DataMember(Name = "noteheadHeavyX")]
        BoundingBox NoteheadHeavyX { get; }

        [DataMember(Name = "noteheadHeavyXHat")]
        BoundingBox NoteheadHeavyXHat { get; }

        [DataMember(Name = "noteheadLargeArrowDownBlack")]
        BoundingBox NoteheadLargeArrowDownBlack { get; }

        [DataMember(Name = "noteheadLargeArrowDownDoubleWhole")]
        BoundingBox NoteheadLargeArrowDownDoubleWhole { get; }

        [DataMember(Name = "noteheadLargeArrowDownHalf")]
        BoundingBox NoteheadLargeArrowDownHalf { get; }

        [DataMember(Name = "noteheadLargeArrowDownWhole")]
        BoundingBox NoteheadLargeArrowDownWhole { get; }

        [DataMember(Name = "noteheadLargeArrowUpBlack")]
        BoundingBox NoteheadLargeArrowUpBlack { get; }

        [DataMember(Name = "noteheadLargeArrowUpDoubleWhole")]
        BoundingBox NoteheadLargeArrowUpDoubleWhole { get; }

        [DataMember(Name = "noteheadLargeArrowUpHalf")]
        BoundingBox NoteheadLargeArrowUpHalf { get; }

        [DataMember(Name = "noteheadLargeArrowUpWhole")]
        BoundingBox NoteheadLargeArrowUpWhole { get; }

        [DataMember(Name = "noteheadMoonBlack")]
        BoundingBox NoteheadMoonBlack { get; }

        [DataMember(Name = "noteheadMoonWhite")]
        BoundingBox NoteheadMoonWhite { get; }

        [DataMember(Name = "noteheadParenthesis")]
        BoundingBox NoteheadParenthesis { get; }

        [DataMember(Name = "noteheadParenthesisLeft")]
        BoundingBox NoteheadParenthesisLeft { get; }

        [DataMember(Name = "noteheadParenthesisRight")]
        BoundingBox NoteheadParenthesisRight { get; }

        [DataMember(Name = "noteheadPlusBlack")]
        BoundingBox NoteheadPlusBlack { get; }

        [DataMember(Name = "noteheadPlusDoubleWhole")]
        BoundingBox NoteheadPlusDoubleWhole { get; }

        [DataMember(Name = "noteheadPlusHalf")]
        BoundingBox NoteheadPlusHalf { get; }

        [DataMember(Name = "noteheadPlusWhole")]
        BoundingBox NoteheadPlusWhole { get; }

        [DataMember(Name = "noteheadRectangularClusterBlackBottom")]
        BoundingBox NoteheadRectangularClusterBlackBottom { get; }

        [DataMember(Name = "noteheadRectangularClusterBlackMiddle")]
        BoundingBox NoteheadRectangularClusterBlackMiddle { get; }

        [DataMember(Name = "noteheadRectangularClusterBlackTop")]
        BoundingBox NoteheadRectangularClusterBlackTop { get; }

        [DataMember(Name = "noteheadRectangularClusterWhiteBottom")]
        BoundingBox NoteheadRectangularClusterWhiteBottom { get; }

        [DataMember(Name = "noteheadRectangularClusterWhiteMiddle")]
        BoundingBox NoteheadRectangularClusterWhiteMiddle { get; }

        [DataMember(Name = "noteheadRectangularClusterWhiteTop")]
        BoundingBox NoteheadRectangularClusterWhiteTop { get; }

        [DataMember(Name = "noteheadRoundBlack")]
        BoundingBox NoteheadRoundBlack { get; }

        [DataMember(Name = "noteheadRoundBlackDoubleSlashed")]
        BoundingBox NoteheadRoundBlackDoubleSlashed { get; }

        [DataMember(Name = "noteheadRoundBlackLarge")]
        Dictionary<string, long[]> NoteheadRoundBlackLarge { get; }

        [DataMember(Name = "noteheadRoundBlackSlashed")]
        BoundingBox NoteheadRoundBlackSlashed { get; }

        [DataMember(Name = "noteheadRoundBlackSlashedLarge")]
        BoundingBox NoteheadRoundBlackSlashedLarge { get; }

        [DataMember(Name = "noteheadRoundWhite")]
        BoundingBox NoteheadRoundWhite { get; }

        [DataMember(Name = "noteheadRoundWhiteDoubleSlashed")]
        BoundingBox NoteheadRoundWhiteDoubleSlashed { get; }

        [DataMember(Name = "noteheadRoundWhiteLarge")]
        Dictionary<string, long[]> NoteheadRoundWhiteLarge { get; }

        [DataMember(Name = "noteheadRoundWhiteSlashed")]
        BoundingBox NoteheadRoundWhiteSlashed { get; }

        [DataMember(Name = "noteheadRoundWhiteSlashedLarge")]
        BoundingBox NoteheadRoundWhiteSlashedLarge { get; }

        [DataMember(Name = "noteheadRoundWhiteWithDot")]
        BoundingBox NoteheadRoundWhiteWithDot { get; }

        [DataMember(Name = "noteheadRoundWhiteWithDotLarge")]
        BoundingBox NoteheadRoundWhiteWithDotLarge { get; }

        [DataMember(Name = "noteheadSlashDiamondWhite")]
        Dictionary<string, long[]> NoteheadSlashDiamondWhite { get; }

        [DataMember(Name = "noteheadSlashHorizontalEnds")]
        BoundingBox NoteheadSlashHorizontalEnds { get; }

        [DataMember(Name = "noteheadSlashHorizontalEndsMuted")]
        BoundingBox NoteheadSlashHorizontalEndsMuted { get; }

        [DataMember(Name = "noteheadSlashVerticalEnds")]
        BoundingBox NoteheadSlashVerticalEnds { get; }

        [DataMember(Name = "noteheadSlashVerticalEndsMuted")]
        BoundingBox NoteheadSlashVerticalEndsMuted { get; }

        [DataMember(Name = "noteheadSlashVerticalEndsSmall")]
        BoundingBox NoteheadSlashVerticalEndsSmall { get; }

        [DataMember(Name = "noteheadSlashWhiteDoubleWhole")]
        BoundingBox NoteheadSlashWhiteDoubleWhole { get; }

        [DataMember(Name = "noteheadSlashWhiteHalf")]
        BoundingBox NoteheadSlashWhiteHalf { get; }

        [DataMember(Name = "noteheadSlashWhiteMuted")]
        BoundingBox NoteheadSlashWhiteMuted { get; }

        [DataMember(Name = "noteheadSlashWhiteWhole")]
        BoundingBox NoteheadSlashWhiteWhole { get; }

        [DataMember(Name = "noteheadSlashX")]
        BoundingBox NoteheadSlashX { get; }

        [DataMember(Name = "noteheadSlashedBlack1")]
        BoundingBox NoteheadSlashedBlack1 { get; }

        [DataMember(Name = "noteheadSlashedBlack2")]
        BoundingBox NoteheadSlashedBlack2 { get; }

        [DataMember(Name = "noteheadSlashedDoubleWhole1")]
        BoundingBox NoteheadSlashedDoubleWhole1 { get; }

        [DataMember(Name = "noteheadSlashedDoubleWhole2")]
        BoundingBox NoteheadSlashedDoubleWhole2 { get; }

        [DataMember(Name = "noteheadSlashedHalf1")]
        BoundingBox NoteheadSlashedHalf1 { get; }

        [DataMember(Name = "noteheadSlashedHalf2")]
        BoundingBox NoteheadSlashedHalf2 { get; }

        [DataMember(Name = "noteheadSlashedWhole1")]
        BoundingBox NoteheadSlashedWhole1 { get; }

        [DataMember(Name = "noteheadSlashedWhole2")]
        BoundingBox NoteheadSlashedWhole2 { get; }

        [DataMember(Name = "noteheadSquareBlack")]
        BoundingBox NoteheadSquareBlack { get; }

        [DataMember(Name = "noteheadSquareBlackLarge")]
        Dictionary<string, long[]> NoteheadSquareBlackLarge { get; }

        [DataMember(Name = "noteheadSquareBlackWhite")]
        Dictionary<string, long[]> NoteheadSquareBlackWhite { get; }

        [DataMember(Name = "noteheadSquareWhite")]
        BoundingBox NoteheadSquareWhite { get; }

        [DataMember(Name = "noteheadTriangleDownBlack")]
        BoundingBox NoteheadTriangleDownBlack { get; }

        [DataMember(Name = "noteheadTriangleDownDoubleWhole")]
        BoundingBox NoteheadTriangleDownDoubleWhole { get; }

        [DataMember(Name = "noteheadTriangleDownHalf")]
        BoundingBox NoteheadTriangleDownHalf { get; }

        [DataMember(Name = "noteheadTriangleDownWhite")]
        BoundingBox NoteheadTriangleDownWhite { get; }

        [DataMember(Name = "noteheadTriangleDownWhole")]
        BoundingBox NoteheadTriangleDownWhole { get; }

        [DataMember(Name = "noteheadTriangleLeftBlack")]
        BoundingBox NoteheadTriangleLeftBlack { get; }

        [DataMember(Name = "noteheadTriangleLeftWhite")]
        BoundingBox NoteheadTriangleLeftWhite { get; }

        [DataMember(Name = "noteheadTriangleRightBlack")]
        BoundingBox NoteheadTriangleRightBlack { get; }

        [DataMember(Name = "noteheadTriangleRightWhite")]
        BoundingBox NoteheadTriangleRightWhite { get; }

        [DataMember(Name = "noteheadTriangleRoundDownBlack")]
        BoundingBox NoteheadTriangleRoundDownBlack { get; }

        [DataMember(Name = "noteheadTriangleRoundDownWhite")]
        BoundingBox NoteheadTriangleRoundDownWhite { get; }

        [DataMember(Name = "noteheadTriangleUpBlack")]
        BoundingBox NoteheadTriangleUpBlack { get; }

        [DataMember(Name = "noteheadTriangleUpDoubleWhole")]
        BoundingBox NoteheadTriangleUpDoubleWhole { get; }

        [DataMember(Name = "noteheadTriangleUpHalf")]
        BoundingBox NoteheadTriangleUpHalf { get; }

        [DataMember(Name = "noteheadTriangleUpRightBlack")]
        BoundingBox NoteheadTriangleUpRightBlack { get; }

        [DataMember(Name = "noteheadTriangleUpRightWhite")]
        BoundingBox NoteheadTriangleUpRightWhite { get; }

        [DataMember(Name = "noteheadTriangleUpWhite")]
        BoundingBox NoteheadTriangleUpWhite { get; }

        [DataMember(Name = "noteheadTriangleUpWhole")]
        BoundingBox NoteheadTriangleUpWhole { get; }

        [DataMember(Name = "noteheadVoidWithX")]
        BoundingBox NoteheadVoidWithX { get; }

        [DataMember(Name = "noteheadWhole")]
        BoundingBox NoteheadWhole { get; }

        [DataMember(Name = "noteheadWholeFilled")]
        BoundingBox NoteheadWholeFilled { get; }

        [DataMember(Name = "noteheadWholeOversized")]
        BoundingBox NoteheadWholeOversized { get; }

        [DataMember(Name = "noteheadWholeParens")]
        BoundingBox NoteheadWholeParens { get; }

        [DataMember(Name = "noteheadWholeSmall")]
        BoundingBox NoteheadWholeSmall { get; }

        [DataMember(Name = "noteheadWholeWithX")]
        BoundingBox NoteheadWholeWithX { get; }

        [DataMember(Name = "noteheadXBlack")]
        BoundingBox NoteheadXBlack { get; }

        [DataMember(Name = "noteheadXDoubleWhole")]
        BoundingBox NoteheadXDoubleWhole { get; }

        [DataMember(Name = "noteheadXHalf")]
        BoundingBox NoteheadXHalf { get; }

        [DataMember(Name = "noteheadXOrnate")]
        BoundingBox NoteheadXOrnate { get; }

        [DataMember(Name = "noteheadXOrnateEllipse")]
        BoundingBox NoteheadXOrnateEllipse { get; }

        [DataMember(Name = "noteheadXWhole")]
        BoundingBox NoteheadXWhole { get; }

        [DataMember(Name = "octaveBaselineA")]
        BoundingBox OctaveBaselineA { get; }

        [DataMember(Name = "octaveBaselineB")]
        BoundingBox OctaveBaselineB { get; }

        [DataMember(Name = "octaveBaselineM")]
        BoundingBox OctaveBaselineM { get; }

        [DataMember(Name = "octaveBaselineV")]
        BoundingBox OctaveBaselineV { get; }

        [DataMember(Name = "octaveBassa")]
        BoundingBox OctaveBassa { get; }

        [DataMember(Name = "octaveLoco")]
        BoundingBox OctaveLoco { get; }

        [DataMember(Name = "octaveParensLeft")]
        BoundingBox OctaveParensLeft { get; }

        [DataMember(Name = "octaveParensRight")]
        BoundingBox OctaveParensRight { get; }

        [DataMember(Name = "octaveSuperscriptA")]
        BoundingBox OctaveSuperscriptA { get; }

        [DataMember(Name = "octaveSuperscriptB")]
        BoundingBox OctaveSuperscriptB { get; }

        [DataMember(Name = "octaveSuperscriptM")]
        BoundingBox OctaveSuperscriptM { get; }

        [DataMember(Name = "octaveSuperscriptV")]
        BoundingBox OctaveSuperscriptV { get; }

        [DataMember(Name = "ornamentBottomLeftConcaveStroke")]
        BoundingBox OrnamentBottomLeftConcaveStroke { get; }

        [DataMember(Name = "ornamentBottomLeftConcaveStrokeLarge")]
        BoundingBox OrnamentBottomLeftConcaveStrokeLarge { get; }

        [DataMember(Name = "ornamentBottomLeftConvexStroke")]
        BoundingBox OrnamentBottomLeftConvexStroke { get; }

        [DataMember(Name = "ornamentBottomRightConcaveStroke")]
        BoundingBox OrnamentBottomRightConcaveStroke { get; }

        [DataMember(Name = "ornamentBottomRightConvexStroke")]
        BoundingBox OrnamentBottomRightConvexStroke { get; }

        [DataMember(Name = "ornamentComma")]
        BoundingBox OrnamentComma { get; }

        [DataMember(Name = "ornamentDoubleObliqueLinesAfterNote")]
        BoundingBox OrnamentDoubleObliqueLinesAfterNote { get; }

        [DataMember(Name = "ornamentDoubleObliqueLinesBeforeNote")]
        BoundingBox OrnamentDoubleObliqueLinesBeforeNote { get; }

        [DataMember(Name = "ornamentDownCurve")]
        BoundingBox OrnamentDownCurve { get; }

        [DataMember(Name = "ornamentHaydn")]
        BoundingBox OrnamentHaydn { get; }

        [DataMember(Name = "ornamentHighLeftConcaveStroke")]
        BoundingBox OrnamentHighLeftConcaveStroke { get; }

        [DataMember(Name = "ornamentHighLeftConvexStroke")]
        BoundingBox OrnamentHighLeftConvexStroke { get; }

        [DataMember(Name = "ornamentHighRightConcaveStroke")]
        BoundingBox OrnamentHighRightConcaveStroke { get; }

        [DataMember(Name = "ornamentHighRightConvexStroke")]
        BoundingBox OrnamentHighRightConvexStroke { get; }

        [DataMember(Name = "ornamentHookAfterNote")]
        BoundingBox OrnamentHookAfterNote { get; }

        [DataMember(Name = "ornamentHookBeforeNote")]
        BoundingBox OrnamentHookBeforeNote { get; }

        [DataMember(Name = "ornamentLeftFacingHalfCircle")]
        BoundingBox OrnamentLeftFacingHalfCircle { get; }

        [DataMember(Name = "ornamentLeftFacingHook")]
        BoundingBox OrnamentLeftFacingHook { get; }

        [DataMember(Name = "ornamentLeftPlus")]
        BoundingBox OrnamentLeftPlus { get; }

        [DataMember(Name = "ornamentLeftShakeT")]
        BoundingBox OrnamentLeftShakeT { get; }

        [DataMember(Name = "ornamentLeftVerticalStroke")]
        BoundingBox OrnamentLeftVerticalStroke { get; }

        [DataMember(Name = "ornamentLeftVerticalStrokeWithCross")]
        BoundingBox OrnamentLeftVerticalStrokeWithCross { get; }

        [DataMember(Name = "ornamentLowLeftConcaveStroke")]
        BoundingBox OrnamentLowLeftConcaveStroke { get; }

        [DataMember(Name = "ornamentLowLeftConvexStroke")]
        BoundingBox OrnamentLowLeftConvexStroke { get; }

        [DataMember(Name = "ornamentLowRightConcaveStroke")]
        BoundingBox OrnamentLowRightConcaveStroke { get; }

        [DataMember(Name = "ornamentLowRightConvexStroke")]
        BoundingBox OrnamentLowRightConvexStroke { get; }

        [DataMember(Name = "ornamentMiddleVerticalStroke")]
        BoundingBox OrnamentMiddleVerticalStroke { get; }

        [DataMember(Name = "ornamentMordent")]
        BoundingBox OrnamentMordent { get; }

        [DataMember(Name = "ornamentMordentInverted")]
        BoundingBox OrnamentMordentInverted { get; }

        [DataMember(Name = "ornamentObliqueLineAfterNote")]
        BoundingBox OrnamentObliqueLineAfterNote { get; }

        [DataMember(Name = "ornamentObliqueLineBeforeNote")]
        BoundingBox OrnamentObliqueLineBeforeNote { get; }

        [DataMember(Name = "ornamentObliqueLineHorizAfterNote")]
        BoundingBox OrnamentObliqueLineHorizAfterNote { get; }

        [DataMember(Name = "ornamentObliqueLineHorizBeforeNote")]
        BoundingBox OrnamentObliqueLineHorizBeforeNote { get; }

        [DataMember(Name = "ornamentOriscus")]
        BoundingBox OrnamentOriscus { get; }

        [DataMember(Name = "ornamentPinceCouperin")]
        BoundingBox OrnamentPinceCouperin { get; }

        [DataMember(Name = "ornamentPortDeVoixV")]
        BoundingBox OrnamentPortDeVoixV { get; }

        [DataMember(Name = "ornamentPrecompAppoggTrill")]
        BoundingBox OrnamentPrecompAppoggTrill { get; }

        [DataMember(Name = "ornamentPrecompAppoggTrillSuffix")]
        BoundingBox OrnamentPrecompAppoggTrillSuffix { get; }

        [DataMember(Name = "ornamentPrecompCadence")]
        BoundingBox OrnamentPrecompCadence { get; }

        [DataMember(Name = "ornamentPrecompCadenceUpperPrefix")]
        BoundingBox OrnamentPrecompCadenceUpperPrefix { get; }

        [DataMember(Name = "ornamentPrecompCadenceUpperPrefixTurn")]
        BoundingBox OrnamentPrecompCadenceUpperPrefixTurn { get; }

        [DataMember(Name = "ornamentPrecompCadenceWithTurn")]
        BoundingBox OrnamentPrecompCadenceWithTurn { get; }

        [DataMember(Name = "ornamentPrecompDescendingSlide")]
        BoundingBox OrnamentPrecompDescendingSlide { get; }

        [DataMember(Name = "ornamentPrecompDoubleCadenceLowerPrefix")]
        BoundingBox OrnamentPrecompDoubleCadenceLowerPrefix { get; }

        [DataMember(Name = "ornamentPrecompDoubleCadenceUpperPrefix")]
        BoundingBox OrnamentPrecompDoubleCadenceUpperPrefix { get; }

        [DataMember(Name = "ornamentPrecompDoubleCadenceUpperPrefixTurn")]
        BoundingBox OrnamentPrecompDoubleCadenceUpperPrefixTurn { get; }

        [DataMember(Name = "ornamentPrecompInvertedMordentUpperPrefix")]
        BoundingBox OrnamentPrecompInvertedMordentUpperPrefix { get; }

        [DataMember(Name = "ornamentPrecompMordentRelease")]
        BoundingBox OrnamentPrecompMordentRelease { get; }

        [DataMember(Name = "ornamentPrecompMordentUpperPrefix")]
        BoundingBox OrnamentPrecompMordentUpperPrefix { get; }

        [DataMember(Name = "ornamentPrecompPortDeVoixMordent")]
        BoundingBox OrnamentPrecompPortDeVoixMordent { get; }

        [DataMember(Name = "ornamentPrecompSlide")]
        BoundingBox OrnamentPrecompSlide { get; }

        [DataMember(Name = "ornamentPrecompSlideTrillBach")]
        BoundingBox OrnamentPrecompSlideTrillBach { get; }

        [DataMember(Name = "ornamentPrecompSlideTrillDAnglebert")]
        BoundingBox OrnamentPrecompSlideTrillDAnglebert { get; }

        [DataMember(Name = "ornamentPrecompSlideTrillMarpurg")]
        BoundingBox OrnamentPrecompSlideTrillMarpurg { get; }

        [DataMember(Name = "ornamentPrecompSlideTrillMuffat")]
        BoundingBox OrnamentPrecompSlideTrillMuffat { get; }

        [DataMember(Name = "ornamentPrecompSlideTrillSuffixMuffat")]
        BoundingBox OrnamentPrecompSlideTrillSuffixMuffat { get; }

        [DataMember(Name = "ornamentPrecompTrillLowerSuffix")]
        BoundingBox OrnamentPrecompTrillLowerSuffix { get; }

        [DataMember(Name = "ornamentPrecompTrillSuffixDandrieu")]
        BoundingBox OrnamentPrecompTrillSuffixDandrieu { get; }

        [DataMember(Name = "ornamentPrecompTrillWithMordent")]
        BoundingBox OrnamentPrecompTrillWithMordent { get; }

        [DataMember(Name = "ornamentPrecompTurnTrillBach")]
        BoundingBox OrnamentPrecompTurnTrillBach { get; }

        [DataMember(Name = "ornamentPrecompTurnTrillDAnglebert")]
        BoundingBox OrnamentPrecompTurnTrillDAnglebert { get; }

        [DataMember(Name = "ornamentQuilisma")]
        BoundingBox OrnamentQuilisma { get; }

        [DataMember(Name = "ornamentRightFacingHalfCircle")]
        BoundingBox OrnamentRightFacingHalfCircle { get; }

        [DataMember(Name = "ornamentRightFacingHook")]
        BoundingBox OrnamentRightFacingHook { get; }

        [DataMember(Name = "ornamentRightVerticalStroke")]
        BoundingBox OrnamentRightVerticalStroke { get; }

        [DataMember(Name = "ornamentSchleifer")]
        BoundingBox OrnamentSchleifer { get; }

        [DataMember(Name = "ornamentShake3")]
        BoundingBox OrnamentShake3 { get; }

        [DataMember(Name = "ornamentShakeMuffat1")]
        BoundingBox OrnamentShakeMuffat1 { get; }

        [DataMember(Name = "ornamentShortObliqueLineAfterNote")]
        BoundingBox OrnamentShortObliqueLineAfterNote { get; }

        [DataMember(Name = "ornamentShortObliqueLineBeforeNote")]
        BoundingBox OrnamentShortObliqueLineBeforeNote { get; }

        [DataMember(Name = "ornamentTopLeftConcaveStroke")]
        BoundingBox OrnamentTopLeftConcaveStroke { get; }

        [DataMember(Name = "ornamentTopLeftConvexStroke")]
        BoundingBox OrnamentTopLeftConvexStroke { get; }

        [DataMember(Name = "ornamentTopRightConcaveStroke")]
        BoundingBox OrnamentTopRightConcaveStroke { get; }

        [DataMember(Name = "ornamentTopRightConvexStroke")]
        BoundingBox OrnamentTopRightConvexStroke { get; }

        [DataMember(Name = "ornamentTremblement")]
        BoundingBox OrnamentTremblement { get; }

        [DataMember(Name = "ornamentTremblementCouperin")]
        BoundingBox OrnamentTremblementCouperin { get; }

        [DataMember(Name = "ornamentTrill")]
        BoundingBox OrnamentTrill { get; }

        [DataMember(Name = "ornamentTrillFlatAbove")]
        BoundingBox OrnamentTrillFlatAbove { get; }

        [DataMember(Name = "ornamentTrillNaturalAbove")]
        BoundingBox OrnamentTrillNaturalAbove { get; }

        [DataMember(Name = "ornamentTrillSharpAbove")]
        BoundingBox OrnamentTrillSharpAbove { get; }

        [DataMember(Name = "ornamentTurn")]
        BoundingBox OrnamentTurn { get; }

        [DataMember(Name = "ornamentTurnFlatAbove")]
        BoundingBox OrnamentTurnFlatAbove { get; }

        [DataMember(Name = "ornamentTurnFlatAboveSharpBelow")]
        BoundingBox OrnamentTurnFlatAboveSharpBelow { get; }

        [DataMember(Name = "ornamentTurnFlatBelow")]
        BoundingBox OrnamentTurnFlatBelow { get; }

        [DataMember(Name = "ornamentTurnInverted")]
        BoundingBox OrnamentTurnInverted { get; }

        [DataMember(Name = "ornamentTurnNaturalAbove")]
        BoundingBox OrnamentTurnNaturalAbove { get; }

        [DataMember(Name = "ornamentTurnNaturalBelow")]
        BoundingBox OrnamentTurnNaturalBelow { get; }

        [DataMember(Name = "ornamentTurnSharpAbove")]
        BoundingBox OrnamentTurnSharpAbove { get; }

        [DataMember(Name = "ornamentTurnSharpAboveFlatBelow")]
        BoundingBox OrnamentTurnSharpAboveFlatBelow { get; }

        [DataMember(Name = "ornamentTurnSharpBelow")]
        BoundingBox OrnamentTurnSharpBelow { get; }

        [DataMember(Name = "ornamentTurnSlash")]
        BoundingBox OrnamentTurnSlash { get; }

        [DataMember(Name = "ornamentTurnUp")]
        BoundingBox OrnamentTurnUp { get; }

        [DataMember(Name = "ornamentTurnUpS")]
        BoundingBox OrnamentTurnUpS { get; }

        [DataMember(Name = "ornamentUpCurve")]
        BoundingBox OrnamentUpCurve { get; }

        [DataMember(Name = "ornamentVerticalLine")]
        BoundingBox OrnamentVerticalLine { get; }

        [DataMember(Name = "ornamentZigZagLineNoRightEnd")]
        BoundingBox OrnamentZigZagLineNoRightEnd { get; }

        [DataMember(Name = "ornamentZigZagLineWithRightEnd")]
        BoundingBox OrnamentZigZagLineWithRightEnd { get; }

        [DataMember(Name = "ottava")]
        BoundingBox Ottava { get; }

        [DataMember(Name = "ottavaAlta")]
        BoundingBox OttavaAlta { get; }

        [DataMember(Name = "ottavaBassa")]
        BoundingBox OttavaBassa { get; }

        [DataMember(Name = "ottavaBassaBa")]
        BoundingBox OttavaBassaBa { get; }

        [DataMember(Name = "ottavaBassaVb")]
        BoundingBox OttavaBassaVb { get; }

        [DataMember(Name = "pendereckiTremolo")]
        BoundingBox PendereckiTremolo { get; }

        [DataMember(Name = "pictAgogo")]
        BoundingBox PictAgogo { get; }

        [DataMember(Name = "pictAlmglocken")]
        BoundingBox PictAlmglocken { get; }

        [DataMember(Name = "pictAnvil")]
        BoundingBox PictAnvil { get; }

        [DataMember(Name = "pictBambooChimes")]
        BoundingBox PictBambooChimes { get; }

        [DataMember(Name = "pictBambooScraper")]
        BoundingBox PictBambooScraper { get; }

        [DataMember(Name = "pictBassDrum")]
        BoundingBox PictBassDrum { get; }

        [DataMember(Name = "pictBassDrumOnSide")]
        BoundingBox PictBassDrumOnSide { get; }

        [DataMember(Name = "pictBassDrumPeinkofer")]
        BoundingBox PictBassDrumPeinkofer { get; }

        [DataMember(Name = "pictBeaterBow")]
        BoundingBox PictBeaterBow { get; }

        [DataMember(Name = "pictBeaterBox")]
        BoundingBox PictBeaterBox { get; }

        [DataMember(Name = "pictBeaterBrassMalletsDown")]
        BoundingBox PictBeaterBrassMalletsDown { get; }

        [DataMember(Name = "pictBeaterBrassMalletsUp")]
        BoundingBox PictBeaterBrassMalletsUp { get; }

        [DataMember(Name = "pictBeaterCombiningDashedCircle")]
        BoundingBox PictBeaterCombiningDashedCircle { get; }

        [DataMember(Name = "pictBeaterCombiningParentheses")]
        BoundingBox PictBeaterCombiningParentheses { get; }

        [DataMember(Name = "pictBeaterDoubleBassDrumDown")]
        BoundingBox PictBeaterDoubleBassDrumDown { get; }

        [DataMember(Name = "pictBeaterDoubleBassDrumUp")]
        BoundingBox PictBeaterDoubleBassDrumUp { get; }

        [DataMember(Name = "pictBeaterFinger")]
        BoundingBox PictBeaterFinger { get; }

        [DataMember(Name = "pictBeaterFingernails")]
        BoundingBox PictBeaterFingernails { get; }

        [DataMember(Name = "pictBeaterFist")]
        BoundingBox PictBeaterFist { get; }

        [DataMember(Name = "pictBeaterGuiroScraper")]
        BoundingBox PictBeaterGuiroScraper { get; }

        [DataMember(Name = "pictBeaterHammer")]
        BoundingBox PictBeaterHammer { get; }

        [DataMember(Name = "pictBeaterHammerMetalDown")]
        BoundingBox PictBeaterHammerMetalDown { get; }

        [DataMember(Name = "pictBeaterHammerMetalUp")]
        BoundingBox PictBeaterHammerMetalUp { get; }

        [DataMember(Name = "pictBeaterHammerPlasticDown")]
        BoundingBox PictBeaterHammerPlasticDown { get; }

        [DataMember(Name = "pictBeaterHammerPlasticUp")]
        BoundingBox PictBeaterHammerPlasticUp { get; }

        [DataMember(Name = "pictBeaterHammerWoodDown")]
        BoundingBox PictBeaterHammerWoodDown { get; }

        [DataMember(Name = "pictBeaterHammerWoodUp")]
        BoundingBox PictBeaterHammerWoodUp { get; }

        [DataMember(Name = "pictBeaterHand")]
        BoundingBox PictBeaterHand { get; }

        [DataMember(Name = "pictBeaterHardBassDrumDown")]
        BoundingBox PictBeaterHardBassDrumDown { get; }

        [DataMember(Name = "pictBeaterHardBassDrumUp")]
        BoundingBox PictBeaterHardBassDrumUp { get; }

        [DataMember(Name = "pictBeaterHardGlockenspielDown")]
        BoundingBox PictBeaterHardGlockenspielDown { get; }

        [DataMember(Name = "pictBeaterHardGlockenspielLeft")]
        BoundingBox PictBeaterHardGlockenspielLeft { get; }

        [DataMember(Name = "pictBeaterHardGlockenspielRight")]
        BoundingBox PictBeaterHardGlockenspielRight { get; }

        [DataMember(Name = "pictBeaterHardGlockenspielUp")]
        BoundingBox PictBeaterHardGlockenspielUp { get; }

        [DataMember(Name = "pictBeaterHardTimpaniDown")]
        BoundingBox PictBeaterHardTimpaniDown { get; }

        [DataMember(Name = "pictBeaterHardTimpaniLeft")]
        BoundingBox PictBeaterHardTimpaniLeft { get; }

        [DataMember(Name = "pictBeaterHardTimpaniRight")]
        BoundingBox PictBeaterHardTimpaniRight { get; }

        [DataMember(Name = "pictBeaterHardTimpaniUp")]
        BoundingBox PictBeaterHardTimpaniUp { get; }

        [DataMember(Name = "pictBeaterHardXylophoneDown")]
        BoundingBox PictBeaterHardXylophoneDown { get; }

        [DataMember(Name = "pictBeaterHardXylophoneLeft")]
        BoundingBox PictBeaterHardXylophoneLeft { get; }

        [DataMember(Name = "pictBeaterHardXylophoneRight")]
        BoundingBox PictBeaterHardXylophoneRight { get; }

        [DataMember(Name = "pictBeaterHardXylophoneUp")]
        BoundingBox PictBeaterHardXylophoneUp { get; }

        [DataMember(Name = "pictBeaterHardYarnDown")]
        BoundingBox PictBeaterHardYarnDown { get; }

        [DataMember(Name = "pictBeaterHardYarnLeft")]
        BoundingBox PictBeaterHardYarnLeft { get; }

        [DataMember(Name = "pictBeaterHardYarnRight")]
        BoundingBox PictBeaterHardYarnRight { get; }

        [DataMember(Name = "pictBeaterHardYarnUp")]
        BoundingBox PictBeaterHardYarnUp { get; }

        [DataMember(Name = "pictBeaterJazzSticksDown")]
        BoundingBox PictBeaterJazzSticksDown { get; }

        [DataMember(Name = "pictBeaterJazzSticksUp")]
        BoundingBox PictBeaterJazzSticksUp { get; }

        [DataMember(Name = "pictBeaterKnittingNeedle")]
        BoundingBox PictBeaterKnittingNeedle { get; }

        [DataMember(Name = "pictBeaterMallet")]
        BoundingBox PictBeaterMallet { get; }

        [DataMember(Name = "pictBeaterMediumBassDrumDown")]
        BoundingBox PictBeaterMediumBassDrumDown { get; }

        [DataMember(Name = "pictBeaterMediumBassDrumUp")]
        BoundingBox PictBeaterMediumBassDrumUp { get; }

        [DataMember(Name = "pictBeaterMediumTimpaniDown")]
        BoundingBox PictBeaterMediumTimpaniDown { get; }

        [DataMember(Name = "pictBeaterMediumTimpaniLeft")]
        BoundingBox PictBeaterMediumTimpaniLeft { get; }

        [DataMember(Name = "pictBeaterMediumTimpaniRight")]
        BoundingBox PictBeaterMediumTimpaniRight { get; }

        [DataMember(Name = "pictBeaterMediumTimpaniUp")]
        BoundingBox PictBeaterMediumTimpaniUp { get; }

        [DataMember(Name = "pictBeaterMediumXylophoneDown")]
        BoundingBox PictBeaterMediumXylophoneDown { get; }

        [DataMember(Name = "pictBeaterMediumXylophoneLeft")]
        BoundingBox PictBeaterMediumXylophoneLeft { get; }

        [DataMember(Name = "pictBeaterMediumXylophoneRight")]
        BoundingBox PictBeaterMediumXylophoneRight { get; }

        [DataMember(Name = "pictBeaterMediumXylophoneUp")]
        BoundingBox PictBeaterMediumXylophoneUp { get; }

        [DataMember(Name = "pictBeaterMediumYarnDown")]
        BoundingBox PictBeaterMediumYarnDown { get; }

        [DataMember(Name = "pictBeaterMediumYarnLeft")]
        BoundingBox PictBeaterMediumYarnLeft { get; }

        [DataMember(Name = "pictBeaterMediumYarnRight")]
        BoundingBox PictBeaterMediumYarnRight { get; }

        [DataMember(Name = "pictBeaterMediumYarnUp")]
        BoundingBox PictBeaterMediumYarnUp { get; }

        [DataMember(Name = "pictBeaterMetalBassDrumDown")]
        BoundingBox PictBeaterMetalBassDrumDown { get; }

        [DataMember(Name = "pictBeaterMetalBassDrumUp")]
        BoundingBox PictBeaterMetalBassDrumUp { get; }

        [DataMember(Name = "pictBeaterMetalDown")]
        BoundingBox PictBeaterMetalDown { get; }

        [DataMember(Name = "pictBeaterMetalHammer")]
        BoundingBox PictBeaterMetalHammer { get; }

        [DataMember(Name = "pictBeaterMetalLeft")]
        BoundingBox PictBeaterMetalLeft { get; }

        [DataMember(Name = "pictBeaterMetalRight")]
        BoundingBox PictBeaterMetalRight { get; }

        [DataMember(Name = "pictBeaterMetalUp")]
        BoundingBox PictBeaterMetalUp { get; }

        [DataMember(Name = "pictBeaterSnareSticksDown")]
        BoundingBox PictBeaterSnareSticksDown { get; }

        [DataMember(Name = "pictBeaterSnareSticksUp")]
        BoundingBox PictBeaterSnareSticksUp { get; }

        [DataMember(Name = "pictBeaterSoftBassDrumDown")]
        BoundingBox PictBeaterSoftBassDrumDown { get; }

        [DataMember(Name = "pictBeaterSoftBassDrumUp")]
        BoundingBox PictBeaterSoftBassDrumUp { get; }

        [DataMember(Name = "pictBeaterSoftGlockenspielDown")]
        BoundingBox PictBeaterSoftGlockenspielDown { get; }

        [DataMember(Name = "pictBeaterSoftGlockenspielLeft")]
        BoundingBox PictBeaterSoftGlockenspielLeft { get; }

        [DataMember(Name = "pictBeaterSoftGlockenspielRight")]
        BoundingBox PictBeaterSoftGlockenspielRight { get; }

        [DataMember(Name = "pictBeaterSoftGlockenspielUp")]
        BoundingBox PictBeaterSoftGlockenspielUp { get; }

        [DataMember(Name = "pictBeaterSoftTimpaniDown")]
        BoundingBox PictBeaterSoftTimpaniDown { get; }

        [DataMember(Name = "pictBeaterSoftTimpaniLeft")]
        BoundingBox PictBeaterSoftTimpaniLeft { get; }

        [DataMember(Name = "pictBeaterSoftTimpaniRight")]
        BoundingBox PictBeaterSoftTimpaniRight { get; }

        [DataMember(Name = "pictBeaterSoftTimpaniUp")]
        BoundingBox PictBeaterSoftTimpaniUp { get; }

        [DataMember(Name = "pictBeaterSoftXylophone")]
        BoundingBox PictBeaterSoftXylophone { get; }

        [DataMember(Name = "pictBeaterSoftXylophoneDown")]
        BoundingBox PictBeaterSoftXylophoneDown { get; }

        [DataMember(Name = "pictBeaterSoftXylophoneLeft")]
        BoundingBox PictBeaterSoftXylophoneLeft { get; }

        [DataMember(Name = "pictBeaterSoftXylophoneRight")]
        BoundingBox PictBeaterSoftXylophoneRight { get; }

        [DataMember(Name = "pictBeaterSoftXylophoneUp")]
        BoundingBox PictBeaterSoftXylophoneUp { get; }

        [DataMember(Name = "pictBeaterSoftYarnDown")]
        BoundingBox PictBeaterSoftYarnDown { get; }

        [DataMember(Name = "pictBeaterSoftYarnLeft")]
        BoundingBox PictBeaterSoftYarnLeft { get; }

        [DataMember(Name = "pictBeaterSoftYarnRight")]
        BoundingBox PictBeaterSoftYarnRight { get; }

        [DataMember(Name = "pictBeaterSoftYarnUp")]
        BoundingBox PictBeaterSoftYarnUp { get; }

        [DataMember(Name = "pictBeaterSpoonWoodenMallet")]
        BoundingBox PictBeaterSpoonWoodenMallet { get; }

        [DataMember(Name = "pictBeaterSuperballDown")]
        BoundingBox PictBeaterSuperballDown { get; }

        [DataMember(Name = "pictBeaterSuperballLeft")]
        BoundingBox PictBeaterSuperballLeft { get; }

        [DataMember(Name = "pictBeaterSuperballRight")]
        BoundingBox PictBeaterSuperballRight { get; }

        [DataMember(Name = "pictBeaterSuperballUp")]
        BoundingBox PictBeaterSuperballUp { get; }

        [DataMember(Name = "pictBeaterTriangleDown")]
        BoundingBox PictBeaterTriangleDown { get; }

        [DataMember(Name = "pictBeaterTriangleUp")]
        BoundingBox PictBeaterTriangleUp { get; }

        [DataMember(Name = "pictBeaterWireBrushesDown")]
        BoundingBox PictBeaterWireBrushesDown { get; }

        [DataMember(Name = "pictBeaterWireBrushesUp")]
        BoundingBox PictBeaterWireBrushesUp { get; }

        [DataMember(Name = "pictBeaterWoodTimpaniDown")]
        BoundingBox PictBeaterWoodTimpaniDown { get; }

        [DataMember(Name = "pictBeaterWoodTimpaniLeft")]
        BoundingBox PictBeaterWoodTimpaniLeft { get; }

        [DataMember(Name = "pictBeaterWoodTimpaniRight")]
        BoundingBox PictBeaterWoodTimpaniRight { get; }

        [DataMember(Name = "pictBeaterWoodTimpaniUp")]
        BoundingBox PictBeaterWoodTimpaniUp { get; }

        [DataMember(Name = "pictBeaterWoodXylophoneDown")]
        BoundingBox PictBeaterWoodXylophoneDown { get; }

        [DataMember(Name = "pictBeaterWoodXylophoneLeft")]
        BoundingBox PictBeaterWoodXylophoneLeft { get; }

        [DataMember(Name = "pictBeaterWoodXylophoneRight")]
        BoundingBox PictBeaterWoodXylophoneRight { get; }

        [DataMember(Name = "pictBeaterWoodXylophoneUp")]
        BoundingBox PictBeaterWoodXylophoneUp { get; }

        [DataMember(Name = "pictBell")]
        BoundingBox PictBell { get; }

        [DataMember(Name = "pictBellOfCymbal")]
        BoundingBox PictBellOfCymbal { get; }

        [DataMember(Name = "pictBellPlate")]
        BoundingBox PictBellPlate { get; }

        [DataMember(Name = "pictBellTree")]
        BoundingBox PictBellTree { get; }

        [DataMember(Name = "pictBirdWhistle")]
        BoundingBox PictBirdWhistle { get; }

        [DataMember(Name = "pictBoardClapper")]
        BoundingBox PictBoardClapper { get; }

        [DataMember(Name = "pictBongos")]
        BoundingBox PictBongos { get; }

        [DataMember(Name = "pictBongosPeinkofer")]
        BoundingBox PictBongosPeinkofer { get; }

        [DataMember(Name = "pictBrakeDrum")]
        BoundingBox PictBrakeDrum { get; }

        [DataMember(Name = "pictCabasa")]
        BoundingBox PictCabasa { get; }

        [DataMember(Name = "pictCannon")]
        BoundingBox PictCannon { get; }

        [DataMember(Name = "pictCarHorn")]
        BoundingBox PictCarHorn { get; }

        [DataMember(Name = "pictCastanets")]
        BoundingBox PictCastanets { get; }

        [DataMember(Name = "pictCastanetsSmithBrindle")]
        BoundingBox PictCastanetsSmithBrindle { get; }

        [DataMember(Name = "pictCastanetsWithHandle")]
        BoundingBox PictCastanetsWithHandle { get; }

        [DataMember(Name = "pictCelesta")]
        BoundingBox PictCelesta { get; }

        [DataMember(Name = "pictCencerro")]
        BoundingBox PictCencerro { get; }

        [DataMember(Name = "pictCenter1")]
        BoundingBox PictCenter1 { get; }

        [DataMember(Name = "pictCenter2")]
        BoundingBox PictCenter2 { get; }

        [DataMember(Name = "pictCenter3")]
        BoundingBox PictCenter3 { get; }

        [DataMember(Name = "pictChainRattle")]
        BoundingBox PictChainRattle { get; }

        [DataMember(Name = "pictChimes")]
        BoundingBox PictChimes { get; }

        [DataMember(Name = "pictChineseCymbal")]
        BoundingBox PictChineseCymbal { get; }

        [DataMember(Name = "pictChokeCymbal")]
        BoundingBox PictChokeCymbal { get; }

        [DataMember(Name = "pictClaves")]
        BoundingBox PictClaves { get; }

        [DataMember(Name = "pictCoins")]
        BoundingBox PictCoins { get; }

        [DataMember(Name = "pictConga")]
        BoundingBox PictConga { get; }

        [DataMember(Name = "pictCongaPeinkofer")]
        BoundingBox PictCongaPeinkofer { get; }

        [DataMember(Name = "pictCowBell")]
        BoundingBox PictCowBell { get; }

        [DataMember(Name = "pictCowBellBerio")]
        BoundingBox PictCowBellBerio { get; }

        [DataMember(Name = "pictCrashCymbals")]
        BoundingBox PictCrashCymbals { get; }

        [DataMember(Name = "pictCrotales")]
        BoundingBox PictCrotales { get; }

        [DataMember(Name = "pictCrushStem")]
        BoundingBox PictCrushStem { get; }

        [DataMember(Name = "pictCuica")]
        BoundingBox PictCuica { get; }

        [DataMember(Name = "pictCymbalTongs")]
        BoundingBox PictCymbalTongs { get; }

        [DataMember(Name = "pictDamp1")]
        BoundingBox PictDamp1 { get; }

        [DataMember(Name = "pictDamp2")]
        BoundingBox PictDamp2 { get; }

        [DataMember(Name = "pictDamp3")]
        BoundingBox PictDamp3 { get; }

        [DataMember(Name = "pictDamp4")]
        BoundingBox PictDamp4 { get; }

        [DataMember(Name = "pictDeadNoteStem")]
        BoundingBox PictDeadNoteStem { get; }

        [DataMember(Name = "pictDrumStick")]
        BoundingBox PictDrumStick { get; }

        [DataMember(Name = "pictDuckCall")]
        BoundingBox PictDuckCall { get; }

        [DataMember(Name = "pictEdgeOfCymbal")]
        BoundingBox PictEdgeOfCymbal { get; }

        [DataMember(Name = "pictEmptyTrap")]
        BoundingBox PictEmptyTrap { get; }

        [DataMember(Name = "pictFingerCymbals")]
        BoundingBox PictFingerCymbals { get; }

        [DataMember(Name = "pictFlexatone")]
        BoundingBox PictFlexatone { get; }

        [DataMember(Name = "pictFlexatonePeinkofer")]
        BoundingBox PictFlexatonePeinkofer { get; }

        [DataMember(Name = "pictFootballRatchet")]
        BoundingBox PictFootballRatchet { get; }

        [DataMember(Name = "pictGlassHarmonica")]
        BoundingBox PictGlassHarmonica { get; }

        [DataMember(Name = "pictGlassHarp")]
        BoundingBox PictGlassHarp { get; }

        [DataMember(Name = "pictGlassPlateChimes")]
        BoundingBox PictGlassPlateChimes { get; }

        [DataMember(Name = "pictGlassTubeChimes")]
        BoundingBox PictGlassTubeChimes { get; }

        [DataMember(Name = "pictGlsp")]
        BoundingBox PictGlsp { get; }

        [DataMember(Name = "pictGlspPeinkofer")]
        BoundingBox PictGlspPeinkofer { get; }

        [DataMember(Name = "pictGlspSmithBrindle")]
        BoundingBox PictGlspSmithBrindle { get; }

        [DataMember(Name = "pictGobletDrum")]
        BoundingBox PictGobletDrum { get; }

        [DataMember(Name = "pictGong")]
        BoundingBox PictGong { get; }

        [DataMember(Name = "pictGongWithButton")]
        BoundingBox PictGongWithButton { get; }

        [DataMember(Name = "pictGuiro")]
        BoundingBox PictGuiro { get; }

        [DataMember(Name = "pictGuiroPeinkofer")]
        BoundingBox PictGuiroPeinkofer { get; }

        [DataMember(Name = "pictGuiroSevsay")]
        BoundingBox PictGuiroSevsay { get; }

        [DataMember(Name = "pictGumHardDown")]
        BoundingBox PictGumHardDown { get; }

        [DataMember(Name = "pictGumHardLeft")]
        BoundingBox PictGumHardLeft { get; }

        [DataMember(Name = "pictGumHardRight")]
        BoundingBox PictGumHardRight { get; }

        [DataMember(Name = "pictGumHardUp")]
        BoundingBox PictGumHardUp { get; }

        [DataMember(Name = "pictGumMediumDown")]
        BoundingBox PictGumMediumDown { get; }

        [DataMember(Name = "pictGumMediumLeft")]
        BoundingBox PictGumMediumLeft { get; }

        [DataMember(Name = "pictGumMediumRight")]
        BoundingBox PictGumMediumRight { get; }

        [DataMember(Name = "pictGumMediumUp")]
        BoundingBox PictGumMediumUp { get; }

        [DataMember(Name = "pictGumSoftDown")]
        BoundingBox PictGumSoftDown { get; }

        [DataMember(Name = "pictGumSoftLeft")]
        BoundingBox PictGumSoftLeft { get; }

        [DataMember(Name = "pictGumSoftRight")]
        BoundingBox PictGumSoftRight { get; }

        [DataMember(Name = "pictGumSoftUp")]
        BoundingBox PictGumSoftUp { get; }

        [DataMember(Name = "pictHalfOpen1")]
        BoundingBox PictHalfOpen1 { get; }

        [DataMember(Name = "pictHalfOpen2")]
        BoundingBox PictHalfOpen2 { get; }

        [DataMember(Name = "pictHandbell")]
        BoundingBox PictHandbell { get; }

        [DataMember(Name = "pictHiHat")]
        BoundingBox PictHiHat { get; }

        [DataMember(Name = "pictHiHatOnStand")]
        BoundingBox PictHiHatOnStand { get; }

        [DataMember(Name = "pictJawHarp")]
        Dictionary<string, long[]> PictJawHarp { get; }

        [DataMember(Name = "pictJingleBells")]
        BoundingBox PictJingleBells { get; }

        [DataMember(Name = "pictKlaxonHorn")]
        BoundingBox PictKlaxonHorn { get; }

        [DataMember(Name = "pictLeftHandCircle")]
        BoundingBox PictLeftHandCircle { get; }

        [DataMember(Name = "pictLionsRoar")]
        BoundingBox PictLionsRoar { get; }

        [DataMember(Name = "pictLithophone")]
        BoundingBox PictLithophone { get; }

        [DataMember(Name = "pictLithophonePeinkofer")]
        BoundingBox PictLithophonePeinkofer { get; }

        [DataMember(Name = "pictLogDrum")]
        BoundingBox PictLogDrum { get; }

        [DataMember(Name = "pictLotusFlute")]
        BoundingBox PictLotusFlute { get; }

        [DataMember(Name = "pictLotusFlutePeinkofer")]
        BoundingBox PictLotusFlutePeinkofer { get; }

        [DataMember(Name = "pictMar")]
        BoundingBox PictMar { get; }

        [DataMember(Name = "pictMarPeinkofer")]
        BoundingBox PictMarPeinkofer { get; }

        [DataMember(Name = "pictMarSmithBrindle")]
        BoundingBox PictMarSmithBrindle { get; }

        [DataMember(Name = "pictMaraca")]
        BoundingBox PictMaraca { get; }

        [DataMember(Name = "pictMaracaSmithBrindle")]
        BoundingBox PictMaracaSmithBrindle { get; }

        [DataMember(Name = "pictMaracas")]
        BoundingBox PictMaracas { get; }

        [DataMember(Name = "pictMegaphone")]
        BoundingBox PictMegaphone { get; }

        [DataMember(Name = "pictMetalPlateChimes")]
        BoundingBox PictMetalPlateChimes { get; }

        [DataMember(Name = "pictMetalTubeChimes")]
        BoundingBox PictMetalTubeChimes { get; }

        [DataMember(Name = "pictMusicalSaw")]
        BoundingBox PictMusicalSaw { get; }

        [DataMember(Name = "pictMusicalSawPeinkofer")]
        BoundingBox PictMusicalSawPeinkofer { get; }

        [DataMember(Name = "pictNormalPosition")]
        BoundingBox PictNormalPosition { get; }

        [DataMember(Name = "pictOnRim")]
        BoundingBox PictOnRim { get; }

        [DataMember(Name = "pictOpen")]
        BoundingBox PictOpen { get; }

        [DataMember(Name = "pictOpenRimShot")]
        BoundingBox PictOpenRimShot { get; }

        [DataMember(Name = "pictPistolShot")]
        BoundingBox PictPistolShot { get; }

        [DataMember(Name = "pictPoliceWhistle")]
        BoundingBox PictPoliceWhistle { get; }

        [DataMember(Name = "pictQuijada")]
        BoundingBox PictQuijada { get; }

        [DataMember(Name = "pictRainstick")]
        BoundingBox PictRainstick { get; }

        [DataMember(Name = "pictRatchet")]
        BoundingBox PictRatchet { get; }

        [DataMember(Name = "pictRecoReco")]
        BoundingBox PictRecoReco { get; }

        [DataMember(Name = "pictRightHandSquare")]
        BoundingBox PictRightHandSquare { get; }

        [DataMember(Name = "pictRim1")]
        BoundingBox PictRim1 { get; }

        [DataMember(Name = "pictRim2")]
        BoundingBox PictRim2 { get; }

        [DataMember(Name = "pictRim3")]
        BoundingBox PictRim3 { get; }

        [DataMember(Name = "pictRimShotOnStem")]
        BoundingBox PictRimShotOnStem { get; }

        [DataMember(Name = "pictSandpaperBlocks")]
        BoundingBox PictSandpaperBlocks { get; }

        [DataMember(Name = "pictScrapeAroundRim")]
        BoundingBox PictScrapeAroundRim { get; }

        [DataMember(Name = "pictScrapeAroundRimClockwise")]
        BoundingBox PictScrapeAroundRimClockwise { get; }

        [DataMember(Name = "pictScrapeCenterToEdge")]
        BoundingBox PictScrapeCenterToEdge { get; }

        [DataMember(Name = "pictScrapeEdgeToCenter")]
        BoundingBox PictScrapeEdgeToCenter { get; }

        [DataMember(Name = "pictShellBells")]
        Dictionary<string, long[]> PictShellBells { get; }

        [DataMember(Name = "pictShellChimes")]
        BoundingBox PictShellChimes { get; }

        [DataMember(Name = "pictSiren")]
        BoundingBox PictSiren { get; }

        [DataMember(Name = "pictSistrum")]
        BoundingBox PictSistrum { get; }

        [DataMember(Name = "pictSizzleCymbal")]
        BoundingBox PictSizzleCymbal { get; }

        [DataMember(Name = "pictSleighBell")]
        BoundingBox PictSleighBell { get; }

        [DataMember(Name = "pictSleighBellSmithBrindle")]
        BoundingBox PictSleighBellSmithBrindle { get; }

        [DataMember(Name = "pictSlideBrushOnGong")]
        BoundingBox PictSlideBrushOnGong { get; }

        [DataMember(Name = "pictSlideWhistle")]
        BoundingBox PictSlideWhistle { get; }

        [DataMember(Name = "pictSlitDrum")]
        BoundingBox PictSlitDrum { get; }

        [DataMember(Name = "pictSnareDrum")]
        BoundingBox PictSnareDrum { get; }

        [DataMember(Name = "pictSnareDrumMilitary")]
        BoundingBox PictSnareDrumMilitary { get; }

        [DataMember(Name = "pictSnareDrumSnaresOff")]
        BoundingBox PictSnareDrumSnaresOff { get; }

        [DataMember(Name = "pictSteelDrums")]
        BoundingBox PictSteelDrums { get; }

        [DataMember(Name = "pictStickShot")]
        BoundingBox PictStickShot { get; }

        [DataMember(Name = "pictSuperball")]
        BoundingBox PictSuperball { get; }

        [DataMember(Name = "pictSuspendedCymbal")]
        BoundingBox PictSuspendedCymbal { get; }

        [DataMember(Name = "pictSwishStem")]
        BoundingBox PictSwishStem { get; }

        [DataMember(Name = "pictTabla")]
        BoundingBox PictTabla { get; }

        [DataMember(Name = "pictTamTam")]
        BoundingBox PictTamTam { get; }

        [DataMember(Name = "pictTamTamWithBeater")]
        BoundingBox PictTamTamWithBeater { get; }

        [DataMember(Name = "pictTambourine")]
        BoundingBox PictTambourine { get; }

        [DataMember(Name = "pictTambourineStockhausen")]
        BoundingBox PictTambourineStockhausen { get; }

        [DataMember(Name = "pictTempleBlocks")]
        BoundingBox PictTempleBlocks { get; }

        [DataMember(Name = "pictTenorDrum")]
        BoundingBox PictTenorDrum { get; }

        [DataMember(Name = "pictThundersheet")]
        BoundingBox PictThundersheet { get; }

        [DataMember(Name = "pictTimbales")]
        BoundingBox PictTimbales { get; }

        [DataMember(Name = "pictTimbalesPeinkofer")]
        BoundingBox PictTimbalesPeinkofer { get; }

        [DataMember(Name = "pictTimpani")]
        BoundingBox PictTimpani { get; }

        [DataMember(Name = "pictTimpaniPeinkofer")]
        BoundingBox PictTimpaniPeinkofer { get; }

        [DataMember(Name = "pictTomTom")]
        BoundingBox PictTomTom { get; }

        [DataMember(Name = "pictTomTomChinese")]
        BoundingBox PictTomTomChinese { get; }

        [DataMember(Name = "pictTomTomChinesePeinkofer")]
        BoundingBox PictTomTomChinesePeinkofer { get; }

        [DataMember(Name = "pictTomTomIndoAmerican")]
        BoundingBox PictTomTomIndoAmerican { get; }

        [DataMember(Name = "pictTomTomJapanese")]
        BoundingBox PictTomTomJapanese { get; }

        [DataMember(Name = "pictTomTomPeinkofer")]
        BoundingBox PictTomTomPeinkofer { get; }

        [DataMember(Name = "pictTriangle")]
        BoundingBox PictTriangle { get; }

        [DataMember(Name = "pictTubaphone")]
        BoundingBox PictTubaphone { get; }

        [DataMember(Name = "pictTubaphonePeinkofer")]
        BoundingBox PictTubaphonePeinkofer { get; }

        [DataMember(Name = "pictTubularBells")]
        BoundingBox PictTubularBells { get; }

        [DataMember(Name = "pictTurnLeftStem")]
        BoundingBox PictTurnLeftStem { get; }

        [DataMember(Name = "pictTurnRightLeftStem")]
        BoundingBox PictTurnRightLeftStem { get; }

        [DataMember(Name = "pictTurnRightStem")]
        BoundingBox PictTurnRightStem { get; }

        [DataMember(Name = "pictVib")]
        BoundingBox PictVib { get; }

        [DataMember(Name = "pictVibMotorOff")]
        BoundingBox PictVibMotorOff { get; }

        [DataMember(Name = "pictVibMotorOffPeinkofer")]
        BoundingBox PictVibMotorOffPeinkofer { get; }

        [DataMember(Name = "pictVibPeinkofer")]
        BoundingBox PictVibPeinkofer { get; }

        [DataMember(Name = "pictVibSmithBrindle")]
        BoundingBox PictVibSmithBrindle { get; }

        [DataMember(Name = "pictVibraslap")]
        BoundingBox PictVibraslap { get; }

        [DataMember(Name = "pictVietnameseHat")]
        BoundingBox PictVietnameseHat { get; }

        [DataMember(Name = "pictWhip")]
        BoundingBox PictWhip { get; }

        [DataMember(Name = "pictWindChimesGlass")]
        BoundingBox PictWindChimesGlass { get; }

        [DataMember(Name = "pictWindMachine")]
        BoundingBox PictWindMachine { get; }

        [DataMember(Name = "pictWindWhistle")]
        BoundingBox PictWindWhistle { get; }

        [DataMember(Name = "pictWoodBlock")]
        BoundingBox PictWoodBlock { get; }

        [DataMember(Name = "pictWoundHardDown")]
        BoundingBox PictWoundHardDown { get; }

        [DataMember(Name = "pictWoundHardLeft")]
        BoundingBox PictWoundHardLeft { get; }

        [DataMember(Name = "pictWoundHardRight")]
        BoundingBox PictWoundHardRight { get; }

        [DataMember(Name = "pictWoundHardUp")]
        BoundingBox PictWoundHardUp { get; }

        [DataMember(Name = "pictWoundSoftDown")]
        BoundingBox PictWoundSoftDown { get; }

        [DataMember(Name = "pictWoundSoftLeft")]
        BoundingBox PictWoundSoftLeft { get; }

        [DataMember(Name = "pictWoundSoftRight")]
        BoundingBox PictWoundSoftRight { get; }

        [DataMember(Name = "pictWoundSoftUp")]
        BoundingBox PictWoundSoftUp { get; }

        [DataMember(Name = "pictXyl")]
        BoundingBox PictXyl { get; }

        [DataMember(Name = "pictXylBass")]
        BoundingBox PictXylBass { get; }

        [DataMember(Name = "pictXylBassPeinkofer")]
        BoundingBox PictXylBassPeinkofer { get; }

        [DataMember(Name = "pictXylPeinkofer")]
        BoundingBox PictXylPeinkofer { get; }

        [DataMember(Name = "pictXylSmithBrindle")]
        BoundingBox PictXylSmithBrindle { get; }

        [DataMember(Name = "pictXylTenor")]
        BoundingBox PictXylTenor { get; }

        [DataMember(Name = "pictXylTenorPeinkofer")]
        BoundingBox PictXylTenorPeinkofer { get; }

        [DataMember(Name = "pictXylTenorTrough")]
        BoundingBox PictXylTenorTrough { get; }

        [DataMember(Name = "pictXylTrough")]
        BoundingBox PictXylTrough { get; }

        [DataMember(Name = "pluckedBuzzPizzicato")]
        BoundingBox PluckedBuzzPizzicato { get; }

        [DataMember(Name = "pluckedDamp")]
        BoundingBox PluckedDamp { get; }

        [DataMember(Name = "pluckedDampAll")]
        BoundingBox PluckedDampAll { get; }

        [DataMember(Name = "pluckedDampOnStem")]
        BoundingBox PluckedDampOnStem { get; }

        [DataMember(Name = "pluckedFingernailFlick")]
        BoundingBox PluckedFingernailFlick { get; }

        [DataMember(Name = "pluckedLeftHandPizzicato")]
        BoundingBox PluckedLeftHandPizzicato { get; }

        [DataMember(Name = "pluckedPlectrum")]
        BoundingBox PluckedPlectrum { get; }

        [DataMember(Name = "pluckedSnapPizzicatoAbove")]
        BoundingBox PluckedSnapPizzicatoAbove { get; }

        [DataMember(Name = "pluckedSnapPizzicatoAboveGerman")]
        BoundingBox PluckedSnapPizzicatoAboveGerman { get; }

        [DataMember(Name = "pluckedSnapPizzicatoBelow")]
        BoundingBox PluckedSnapPizzicatoBelow { get; }

        [DataMember(Name = "pluckedSnapPizzicatoBelowGerman")]
        BoundingBox PluckedSnapPizzicatoBelowGerman { get; }

        [DataMember(Name = "pluckedWithFingernails")]
        BoundingBox PluckedWithFingernails { get; }

        [DataMember(Name = "quindicesima")]
        BoundingBox Quindicesima { get; }

        [DataMember(Name = "quindicesimaAlta")]
        BoundingBox QuindicesimaAlta { get; }

        [DataMember(Name = "quindicesimaBassa")]
        BoundingBox QuindicesimaBassa { get; }

        [DataMember(Name = "quindicesimaBassaMb")]
        BoundingBox QuindicesimaBassaMb { get; }

        [DataMember(Name = "repeat1Bar")]
        BoundingBox Repeat1Bar { get; }

        [DataMember(Name = "repeat2Bars")]
        BoundingBox Repeat2Bars { get; }

        [DataMember(Name = "repeat4Bars")]
        BoundingBox Repeat4Bars { get; }

        [DataMember(Name = "repeatDot")]
        BoundingBox RepeatDot { get; }

        [DataMember(Name = "repeatDots")]
        BoundingBox RepeatDots { get; }

        [DataMember(Name = "repeatLeft")]
        BoundingBox RepeatLeft { get; }

        [DataMember(Name = "repeatRight")]
        BoundingBox RepeatRight { get; }

        [DataMember(Name = "repeatRightLeft")]
        BoundingBox RepeatRightLeft { get; }

        [DataMember(Name = "repeatRightLeftThick")]
        BoundingBox RepeatRightLeftThick { get; }

        [DataMember(Name = "rest1024th")]
        BoundingBox Rest1024Th { get; }

        [DataMember(Name = "rest128th")]
        BoundingBox Rest128Th { get; }

        [DataMember(Name = "rest16th")]
        BoundingBox Rest16Th { get; }

        [DataMember(Name = "rest256th")]
        BoundingBox Rest256Th { get; }

        [DataMember(Name = "rest32nd")]
        BoundingBox Rest32Nd { get; }

        [DataMember(Name = "rest512th")]
        BoundingBox Rest512Th { get; }

        [DataMember(Name = "rest64th")]
        BoundingBox Rest64Th { get; }

        [DataMember(Name = "rest8th")]
        BoundingBox Rest8Th { get; }

        [DataMember(Name = "restDoubleWhole")]
        BoundingBox RestDoubleWhole { get; }

        [DataMember(Name = "restDoubleWholeLegerLine")]
        BoundingBox RestDoubleWholeLegerLine { get; }

        [DataMember(Name = "restHBar")]
        BoundingBox RestHBar { get; }

        [DataMember(Name = "restHBarLeft")]
        BoundingBox RestHBarLeft { get; }

        [DataMember(Name = "restHBarMiddle")]
        BoundingBox RestHBarMiddle { get; }

        [DataMember(Name = "restHBarRight")]
        BoundingBox RestHBarRight { get; }

        [DataMember(Name = "restHalf")]
        BoundingBox RestHalf { get; }

        [DataMember(Name = "restHalfLegerLine")]
        BoundingBox RestHalfLegerLine { get; }

        [DataMember(Name = "restLonga")]
        BoundingBox RestLonga { get; }

        [DataMember(Name = "restMaxima")]
        BoundingBox RestMaxima { get; }

        [DataMember(Name = "restQuarter")]
        BoundingBox RestQuarter { get; }

        [DataMember(Name = "restQuarterOld")]
        BoundingBox RestQuarterOld { get; }

        [DataMember(Name = "restQuarterZ")]
        BoundingBox RestQuarterZ { get; }

        [DataMember(Name = "restWhole")]
        BoundingBox RestWhole { get; }

        [DataMember(Name = "restWholeLegerLine")]
        BoundingBox RestWholeLegerLine { get; }

        [DataMember(Name = "reversedBrace")]
        BoundingBox ReversedBrace { get; }

        [DataMember(Name = "reversedBracketBottom")]
        BoundingBox ReversedBracketBottom { get; }

        [DataMember(Name = "reversedBracketTop")]
        BoundingBox ReversedBracketTop { get; }

        [DataMember(Name = "rightRepeatSmall")]
        BoundingBox RightRepeatSmall { get; }

        [DataMember(Name = "schaefferClef")]
        BoundingBox SchaefferClef { get; }

        [DataMember(Name = "schaefferFClefToGClef")]
        BoundingBox SchaefferFClefToGClef { get; }

        [DataMember(Name = "schaefferGClefToFClef")]
        BoundingBox SchaefferGClefToFClef { get; }

        [DataMember(Name = "schaefferPreviousClef")]
        BoundingBox SchaefferPreviousClef { get; }

        [DataMember(Name = "sedicesima")]
        BoundingBox Sedicesima { get; }

        [DataMember(Name = "sedicesimaAlta")]
        BoundingBox SedicesimaAlta { get; }

        [DataMember(Name = "sedicesimaBassa")]
        BoundingBox SedicesimaBassa { get; }

        [DataMember(Name = "sedicesimaBassaMb")]
        BoundingBox SedicesimaBassaMb { get; }

        [DataMember(Name = "segno")]
        BoundingBox Segno { get; }

        [DataMember(Name = "segnoJapanese")]
        BoundingBox SegnoJapanese { get; }

        [DataMember(Name = "segnoSerpent1")]
        BoundingBox SegnoSerpent1 { get; }

        [DataMember(Name = "segnoSerpent2")]
        BoundingBox SegnoSerpent2 { get; }

        [DataMember(Name = "semipitchedPercussionClef1")]
        BoundingBox SemipitchedPercussionClef1 { get; }

        [DataMember(Name = "semipitchedPercussionClef2")]
        BoundingBox SemipitchedPercussionClef2 { get; }

        [DataMember(Name = "smnFlat")]
        BoundingBox SmnFlat { get; }

        [DataMember(Name = "smnFlatWhite")]
        BoundingBox SmnFlatWhite { get; }

        [DataMember(Name = "smnHistoryDoubleFlat")]
        BoundingBox SmnHistoryDoubleFlat { get; }

        [DataMember(Name = "smnHistoryDoubleSharp")]
        BoundingBox SmnHistoryDoubleSharp { get; }

        [DataMember(Name = "smnHistoryFlat")]
        BoundingBox SmnHistoryFlat { get; }

        [DataMember(Name = "smnHistorySharp")]
        BoundingBox SmnHistorySharp { get; }

        [DataMember(Name = "smnNatural")]
        BoundingBox SmnNatural { get; }

        [DataMember(Name = "smnSharp")]
        BoundingBox SmnSharp { get; }

        [DataMember(Name = "smnSharpDown")]
        BoundingBox SmnSharpDown { get; }

        [DataMember(Name = "smnSharpWhite")]
        BoundingBox SmnSharpWhite { get; }

        [DataMember(Name = "smnSharpWhiteDown")]
        BoundingBox SmnSharpWhiteDown { get; }

        [DataMember(Name = "splitBarDivider")]
        BoundingBox SplitBarDivider { get; }

        [DataMember(Name = "staff1Line")]
        BoundingBox Staff1Line { get; }

        [DataMember(Name = "staff1LineNarrow")]
        BoundingBox Staff1LineNarrow { get; }

        [DataMember(Name = "staff1LineWide")]
        BoundingBox Staff1LineWide { get; }

        [DataMember(Name = "staff2Lines")]
        BoundingBox Staff2Lines { get; }

        [DataMember(Name = "staff2LinesNarrow")]
        BoundingBox Staff2LinesNarrow { get; }

        [DataMember(Name = "staff2LinesWide")]
        BoundingBox Staff2LinesWide { get; }

        [DataMember(Name = "staff3Lines")]
        BoundingBox Staff3Lines { get; }

        [DataMember(Name = "staff3LinesNarrow")]
        BoundingBox Staff3LinesNarrow { get; }

        [DataMember(Name = "staff3LinesWide")]
        BoundingBox Staff3LinesWide { get; }

        [DataMember(Name = "staff4Lines")]
        BoundingBox Staff4Lines { get; }

        [DataMember(Name = "staff4LinesNarrow")]
        BoundingBox Staff4LinesNarrow { get; }

        [DataMember(Name = "staff4LinesWide")]
        BoundingBox Staff4LinesWide { get; }

        [DataMember(Name = "staff5Lines")]
        BoundingBox Staff5Lines { get; }

        [DataMember(Name = "staff5LinesNarrow")]
        BoundingBox Staff5LinesNarrow { get; }

        [DataMember(Name = "staff5LinesWide")]
        BoundingBox Staff5LinesWide { get; }

        [DataMember(Name = "staff6Lines")]
        BoundingBox Staff6Lines { get; }

        [DataMember(Name = "staff6LinesNarrow")]
        BoundingBox Staff6LinesNarrow { get; }

        [DataMember(Name = "staff6LinesWide")]
        BoundingBox Staff6LinesWide { get; }

        [DataMember(Name = "staffDivideArrowDown")]
        BoundingBox StaffDivideArrowDown { get; }

        [DataMember(Name = "staffDivideArrowUp")]
        BoundingBox StaffDivideArrowUp { get; }

        [DataMember(Name = "staffDivideArrowUpDown")]
        BoundingBox StaffDivideArrowUpDown { get; }

        [DataMember(Name = "stem")]
        BoundingBox Stem { get; }

        [DataMember(Name = "stemBowOnBridge")]
        BoundingBox StemBowOnBridge { get; }

        [DataMember(Name = "stemBowOnTailpiece")]
        BoundingBox StemBowOnTailpiece { get; }

        [DataMember(Name = "stemBuzzRoll")]
        BoundingBox StemBuzzRoll { get; }

        [DataMember(Name = "stemDamp")]
        BoundingBox StemDamp { get; }

        [DataMember(Name = "stemHarpStringNoise")]
        BoundingBox StemHarpStringNoise { get; }

        [DataMember(Name = "stemMultiphonicsBlack")]
        BoundingBox StemMultiphonicsBlack { get; }

        [DataMember(Name = "stemMultiphonicsBlackWhite")]
        BoundingBox StemMultiphonicsBlackWhite { get; }

        [DataMember(Name = "stemMultiphonicsWhite")]
        BoundingBox StemMultiphonicsWhite { get; }

        [DataMember(Name = "stemPendereckiTremolo")]
        BoundingBox StemPendereckiTremolo { get; }

        [DataMember(Name = "stemRimShot")]
        BoundingBox StemRimShot { get; }

        [DataMember(Name = "stemSprechgesang")]
        BoundingBox StemSprechgesang { get; }

        [DataMember(Name = "stemSulPonticello")]
        BoundingBox StemSulPonticello { get; }

        [DataMember(Name = "stemSussurando")]
        BoundingBox StemSussurando { get; }

        [DataMember(Name = "stemSwished")]
        BoundingBox StemSwished { get; }

        [DataMember(Name = "stemVibratoPulse")]
        BoundingBox StemVibratoPulse { get; }

        [DataMember(Name = "stockhausenTremolo")]
        BoundingBox StockhausenTremolo { get; }

        [DataMember(Name = "stringsBowBehindBridge")]
        BoundingBox StringsBowBehindBridge { get; }

        [DataMember(Name = "stringsBowBehindBridgeFourStrings")]
        BoundingBox StringsBowBehindBridgeFourStrings { get; }

        [DataMember(Name = "stringsBowBehindBridgeOneString")]
        BoundingBox StringsBowBehindBridgeOneString { get; }

        [DataMember(Name = "stringsBowBehindBridgeThreeStrings")]
        BoundingBox StringsBowBehindBridgeThreeStrings { get; }

        [DataMember(Name = "stringsBowBehindBridgeTwoStrings")]
        BoundingBox StringsBowBehindBridgeTwoStrings { get; }

        [DataMember(Name = "stringsBowOnBridge")]
        BoundingBox StringsBowOnBridge { get; }

        [DataMember(Name = "stringsBowOnTailpiece")]
        BoundingBox StringsBowOnTailpiece { get; }

        [DataMember(Name = "stringsChangeBowDirection")]
        BoundingBox StringsChangeBowDirection { get; }

        [DataMember(Name = "stringsChangeBowDirectionImposed")]
        BoundingBox StringsChangeBowDirectionImposed { get; }

        [DataMember(Name = "stringsChangeBowDirectionLiga")]
        BoundingBox StringsChangeBowDirectionLiga { get; }

        [DataMember(Name = "stringsDownBow")]
        BoundingBox StringsDownBow { get; }

        [DataMember(Name = "stringsDownBowTurned")]
        BoundingBox StringsDownBowTurned { get; }

        [DataMember(Name = "stringsFouette")]
        BoundingBox StringsFouette { get; }

        [DataMember(Name = "stringsHalfHarmonic")]
        BoundingBox StringsHalfHarmonic { get; }

        [DataMember(Name = "stringsHarmonic")]
        BoundingBox StringsHarmonic { get; }

        [DataMember(Name = "stringsJeteAbove")]
        BoundingBox StringsJeteAbove { get; }

        [DataMember(Name = "stringsJeteBelow")]
        BoundingBox StringsJeteBelow { get; }

        [DataMember(Name = "stringsMuteOff")]
        BoundingBox StringsMuteOff { get; }

        [DataMember(Name = "stringsMuteOn")]
        BoundingBox StringsMuteOn { get; }

        [DataMember(Name = "stringsOverpressureDownBow")]
        BoundingBox StringsOverpressureDownBow { get; }

        [DataMember(Name = "stringsOverpressureNoDirection")]
        BoundingBox StringsOverpressureNoDirection { get; }

        [DataMember(Name = "stringsOverpressurePossibileDownBow")]
        BoundingBox StringsOverpressurePossibileDownBow { get; }

        [DataMember(Name = "stringsOverpressurePossibileUpBow")]
        BoundingBox StringsOverpressurePossibileUpBow { get; }

        [DataMember(Name = "stringsOverpressureUpBow")]
        BoundingBox StringsOverpressureUpBow { get; }

        [DataMember(Name = "stringsThumbPosition")]
        BoundingBox StringsThumbPosition { get; }

        [DataMember(Name = "stringsThumbPositionTurned")]
        BoundingBox StringsThumbPositionTurned { get; }

        [DataMember(Name = "stringsUpBow")]
        BoundingBox StringsUpBow { get; }

        [DataMember(Name = "stringsUpBowTurned")]
        BoundingBox StringsUpBowTurned { get; }

        [DataMember(Name = "stringsVibratoPulse")]
        BoundingBox StringsVibratoPulse { get; }

        [DataMember(Name = "systemDivider")]
        BoundingBox SystemDivider { get; }

        [DataMember(Name = "systemDividerExtraLong")]
        BoundingBox SystemDividerExtraLong { get; }

        [DataMember(Name = "systemDividerLong")]
        BoundingBox SystemDividerLong { get; }

        [DataMember(Name = "textAugmentationDot")]
        BoundingBox TextAugmentationDot { get; }

        [DataMember(Name = "textBlackNoteFrac16thLongStem")]
        BoundingBox TextBlackNoteFrac16ThLongStem { get; }

        [DataMember(Name = "textBlackNoteFrac16thShortStem")]
        BoundingBox TextBlackNoteFrac16ThShortStem { get; }

        [DataMember(Name = "textBlackNoteFrac32ndLongStem")]
        BoundingBox TextBlackNoteFrac32NdLongStem { get; }

        [DataMember(Name = "textBlackNoteFrac8thLongStem")]
        BoundingBox TextBlackNoteFrac8ThLongStem { get; }

        [DataMember(Name = "textBlackNoteFrac8thShortStem")]
        BoundingBox TextBlackNoteFrac8ThShortStem { get; }

        [DataMember(Name = "textBlackNoteLongStem")]
        BoundingBox TextBlackNoteLongStem { get; }

        [DataMember(Name = "textBlackNoteShortStem")]
        BoundingBox TextBlackNoteShortStem { get; }

        [DataMember(Name = "textCont16thBeamLongStem")]
        BoundingBox TextCont16ThBeamLongStem { get; }

        [DataMember(Name = "textCont16thBeamShortStem")]
        BoundingBox TextCont16ThBeamShortStem { get; }

        [DataMember(Name = "textCont32ndBeamLongStem")]
        BoundingBox TextCont32NdBeamLongStem { get; }

        [DataMember(Name = "textCont8thBeamLongStem")]
        BoundingBox TextCont8ThBeamLongStem { get; }

        [DataMember(Name = "textCont8thBeamShortStem")]
        BoundingBox TextCont8ThBeamShortStem { get; }

        [DataMember(Name = "textTie")]
        BoundingBox TextTie { get; }

        [DataMember(Name = "textTuplet3LongStem")]
        BoundingBox TextTuplet3LongStem { get; }

        [DataMember(Name = "textTuplet3ShortStem")]
        BoundingBox TextTuplet3ShortStem { get; }

        [DataMember(Name = "textTupletBracketEndLongStem")]
        BoundingBox TextTupletBracketEndLongStem { get; }

        [DataMember(Name = "textTupletBracketEndShortStem")]
        BoundingBox TextTupletBracketEndShortStem { get; }

        [DataMember(Name = "textTupletBracketStartLongStem")]
        BoundingBox TextTupletBracketStartLongStem { get; }

        [DataMember(Name = "textTupletBracketStartShortStem")]
        BoundingBox TextTupletBracketStartShortStem { get; }

        [DataMember(Name = "timeSig0")]
        BoundingBox TimeSig0 { get; }

        [DataMember(Name = "timeSig0Denominator")]
        BoundingBox TimeSig0Denominator { get; }

        [DataMember(Name = "timeSig0Large")]
        BoundingBox TimeSig0Large { get; }

        [DataMember(Name = "timeSig0Numerator")]
        BoundingBox TimeSig0Numerator { get; }

        [DataMember(Name = "timeSig0Reversed")]
        BoundingBox TimeSig0Reversed { get; }

        [DataMember(Name = "timeSig0Small")]
        BoundingBox TimeSig0Small { get; }

        [DataMember(Name = "timeSig0Turned")]
        BoundingBox TimeSig0Turned { get; }

        [DataMember(Name = "timeSig1")]
        BoundingBox TimeSig1 { get; }

        [DataMember(Name = "timeSig12over8")]
        BoundingBox TimeSig12Over8 { get; }

        [DataMember(Name = "timeSig1Denominator")]
        BoundingBox TimeSig1Denominator { get; }

        [DataMember(Name = "timeSig1Large")]
        BoundingBox TimeSig1Large { get; }

        [DataMember(Name = "timeSig1Numerator")]
        BoundingBox TimeSig1Numerator { get; }

        [DataMember(Name = "timeSig1Reversed")]
        BoundingBox TimeSig1Reversed { get; }

        [DataMember(Name = "timeSig1Small")]
        BoundingBox TimeSig1Small { get; }

        [DataMember(Name = "timeSig1Turned")]
        BoundingBox TimeSig1Turned { get; }

        [DataMember(Name = "timeSig2")]
        BoundingBox TimeSig2 { get; }

        [DataMember(Name = "timeSig2Denominator")]
        BoundingBox TimeSig2Denominator { get; }

        [DataMember(Name = "timeSig2Large")]
        BoundingBox TimeSig2Large { get; }

        [DataMember(Name = "timeSig2Numerator")]
        BoundingBox TimeSig2Numerator { get; }

        [DataMember(Name = "timeSig2Reversed")]
        BoundingBox TimeSig2Reversed { get; }

        [DataMember(Name = "timeSig2Small")]
        BoundingBox TimeSig2Small { get; }

        [DataMember(Name = "timeSig2Turned")]
        BoundingBox TimeSig2Turned { get; }

        [DataMember(Name = "timeSig2over2")]
        BoundingBox TimeSig2Over2 { get; }

        [DataMember(Name = "timeSig2over4")]
        BoundingBox TimeSig2Over4 { get; }

        [DataMember(Name = "timeSig3")]
        BoundingBox TimeSig3 { get; }

        [DataMember(Name = "timeSig3Denominator")]
        BoundingBox TimeSig3Denominator { get; }

        [DataMember(Name = "timeSig3Large")]
        BoundingBox TimeSig3Large { get; }

        [DataMember(Name = "timeSig3Numerator")]
        BoundingBox TimeSig3Numerator { get; }

        [DataMember(Name = "timeSig3Reversed")]
        BoundingBox TimeSig3Reversed { get; }

        [DataMember(Name = "timeSig3Small")]
        BoundingBox TimeSig3Small { get; }

        [DataMember(Name = "timeSig3Turned")]
        BoundingBox TimeSig3Turned { get; }

        [DataMember(Name = "timeSig3over2")]
        BoundingBox TimeSig3Over2 { get; }

        [DataMember(Name = "timeSig3over4")]
        BoundingBox TimeSig3Over4 { get; }

        [DataMember(Name = "timeSig3over8")]
        BoundingBox TimeSig3Over8 { get; }

        [DataMember(Name = "timeSig4")]
        BoundingBox TimeSig4 { get; }

        [DataMember(Name = "timeSig4Denominator")]
        BoundingBox TimeSig4Denominator { get; }

        [DataMember(Name = "timeSig4Large")]
        BoundingBox TimeSig4Large { get; }

        [DataMember(Name = "timeSig4Numerator")]
        BoundingBox TimeSig4Numerator { get; }

        [DataMember(Name = "timeSig4Reversed")]
        BoundingBox TimeSig4Reversed { get; }

        [DataMember(Name = "timeSig4Small")]
        BoundingBox TimeSig4Small { get; }

        [DataMember(Name = "timeSig4Turned")]
        BoundingBox TimeSig4Turned { get; }

        [DataMember(Name = "timeSig4over4")]
        BoundingBox TimeSig4Over4 { get; }

        [DataMember(Name = "timeSig5")]
        BoundingBox TimeSig5 { get; }

        [DataMember(Name = "timeSig5Denominator")]
        BoundingBox TimeSig5Denominator { get; }

        [DataMember(Name = "timeSig5Large")]
        BoundingBox TimeSig5Large { get; }

        [DataMember(Name = "timeSig5Numerator")]
        BoundingBox TimeSig5Numerator { get; }

        [DataMember(Name = "timeSig5Reversed")]
        BoundingBox TimeSig5Reversed { get; }

        [DataMember(Name = "timeSig5Small")]
        BoundingBox TimeSig5Small { get; }

        [DataMember(Name = "timeSig5Turned")]
        BoundingBox TimeSig5Turned { get; }

        [DataMember(Name = "timeSig5over4")]
        BoundingBox TimeSig5Over4 { get; }

        [DataMember(Name = "timeSig5over8")]
        BoundingBox TimeSig5Over8 { get; }

        [DataMember(Name = "timeSig6")]
        BoundingBox TimeSig6 { get; }

        [DataMember(Name = "timeSig6Denominator")]
        BoundingBox TimeSig6Denominator { get; }

        [DataMember(Name = "timeSig6Large")]
        BoundingBox TimeSig6Large { get; }

        [DataMember(Name = "timeSig6Numerator")]
        BoundingBox TimeSig6Numerator { get; }

        [DataMember(Name = "timeSig6Reversed")]
        BoundingBox TimeSig6Reversed { get; }

        [DataMember(Name = "timeSig6Small")]
        BoundingBox TimeSig6Small { get; }

        [DataMember(Name = "timeSig6Turned")]
        BoundingBox TimeSig6Turned { get; }

        [DataMember(Name = "timeSig6over4")]
        BoundingBox TimeSig6Over4 { get; }

        [DataMember(Name = "timeSig6over8")]
        BoundingBox TimeSig6Over8 { get; }

        [DataMember(Name = "timeSig7")]
        BoundingBox TimeSig7 { get; }

        [DataMember(Name = "timeSig7Denominator")]
        BoundingBox TimeSig7Denominator { get; }

        [DataMember(Name = "timeSig7Large")]
        BoundingBox TimeSig7Large { get; }

        [DataMember(Name = "timeSig7Numerator")]
        BoundingBox TimeSig7Numerator { get; }

        [DataMember(Name = "timeSig7Reversed")]
        BoundingBox TimeSig7Reversed { get; }

        [DataMember(Name = "timeSig7Small")]
        BoundingBox TimeSig7Small { get; }

        [DataMember(Name = "timeSig7Turned")]
        BoundingBox TimeSig7Turned { get; }

        [DataMember(Name = "timeSig7over8")]
        BoundingBox TimeSig7Over8 { get; }

        [DataMember(Name = "timeSig8")]
        BoundingBox TimeSig8 { get; }

        [DataMember(Name = "timeSig8Denominator")]
        BoundingBox TimeSig8Denominator { get; }

        [DataMember(Name = "timeSig8Large")]
        BoundingBox TimeSig8Large { get; }

        [DataMember(Name = "timeSig8Numerator")]
        BoundingBox TimeSig8Numerator { get; }

        [DataMember(Name = "timeSig8Reversed")]
        BoundingBox TimeSig8Reversed { get; }

        [DataMember(Name = "timeSig8Small")]
        BoundingBox TimeSig8Small { get; }

        [DataMember(Name = "timeSig8Turned")]
        BoundingBox TimeSig8Turned { get; }

        [DataMember(Name = "timeSig9")]
        BoundingBox TimeSig9 { get; }

        [DataMember(Name = "timeSig9Large")]
        BoundingBox TimeSig9Large { get; }

        [DataMember(Name = "timeSig9Reversed")]
        BoundingBox TimeSig9Reversed { get; }

        [DataMember(Name = "timeSig9Small")]
        BoundingBox TimeSig9Small { get; }

        [DataMember(Name = "timeSig9Turned")]
        BoundingBox TimeSig9Turned { get; }

        [DataMember(Name = "timeSig9over8")]
        BoundingBox TimeSig9Over8 { get; }

        [DataMember(Name = "timeSigBracketLeft")]
        BoundingBox TimeSigBracketLeft { get; }

        [DataMember(Name = "timeSigBracketLeftSmall")]
        BoundingBox TimeSigBracketLeftSmall { get; }

        [DataMember(Name = "timeSigBracketRight")]
        BoundingBox TimeSigBracketRight { get; }

        [DataMember(Name = "timeSigBracketRightSmall")]
        BoundingBox TimeSigBracketRightSmall { get; }

        [DataMember(Name = "timeSigComma")]
        BoundingBox TimeSigComma { get; }

        [DataMember(Name = "timeSigCommon")]
        BoundingBox TimeSigCommon { get; }

        [DataMember(Name = "timeSigCommonLarge")]
        BoundingBox TimeSigCommonLarge { get; }

        [DataMember(Name = "timeSigCommonReversed")]
        BoundingBox TimeSigCommonReversed { get; }

        [DataMember(Name = "timeSigCommonTurned")]
        BoundingBox TimeSigCommonTurned { get; }

        [DataMember(Name = "timeSigCut2")]
        BoundingBox TimeSigCut2 { get; }

        [DataMember(Name = "timeSigCut3")]
        BoundingBox TimeSigCut3 { get; }

        [DataMember(Name = "timeSigCutCommon")]
        BoundingBox TimeSigCutCommon { get; }

        [DataMember(Name = "timeSigCutCommonLarge")]
        BoundingBox TimeSigCutCommonLarge { get; }

        [DataMember(Name = "timeSigCutCommonReversed")]
        BoundingBox TimeSigCutCommonReversed { get; }

        [DataMember(Name = "timeSigCutCommonTurned")]
        BoundingBox TimeSigCutCommonTurned { get; }

        [DataMember(Name = "timeSigEquals")]
        BoundingBox TimeSigEquals { get; }

        [DataMember(Name = "timeSigFractionHalf")]
        BoundingBox TimeSigFractionHalf { get; }

        [DataMember(Name = "timeSigFractionOneThird")]
        BoundingBox TimeSigFractionOneThird { get; }

        [DataMember(Name = "timeSigFractionQuarter")]
        BoundingBox TimeSigFractionQuarter { get; }

        [DataMember(Name = "timeSigFractionThreeQuarters")]
        BoundingBox TimeSigFractionThreeQuarters { get; }

        [DataMember(Name = "timeSigFractionTwoThirds")]
        BoundingBox TimeSigFractionTwoThirds { get; }

        [DataMember(Name = "timeSigFractionalSlash")]
        BoundingBox TimeSigFractionalSlash { get; }

        [DataMember(Name = "timeSigMinus")]
        BoundingBox TimeSigMinus { get; }

        [DataMember(Name = "timeSigMultiply")]
        BoundingBox TimeSigMultiply { get; }

        [DataMember(Name = "timeSigOpenPenderecki")]
        BoundingBox TimeSigOpenPenderecki { get; }

        [DataMember(Name = "timeSigParensLeft")]
        BoundingBox TimeSigParensLeft { get; }

        [DataMember(Name = "timeSigParensLeftSmall")]
        BoundingBox TimeSigParensLeftSmall { get; }

        [DataMember(Name = "timeSigParensRight")]
        BoundingBox TimeSigParensRight { get; }

        [DataMember(Name = "timeSigParensRightSmall")]
        BoundingBox TimeSigParensRightSmall { get; }

        [DataMember(Name = "timeSigPlus")]
        BoundingBox TimeSigPlus { get; }

        [DataMember(Name = "timeSigPlusLarge")]
        BoundingBox TimeSigPlusLarge { get; }

        [DataMember(Name = "timeSigPlusSmall")]
        BoundingBox TimeSigPlusSmall { get; }

        [DataMember(Name = "timeSigSlash")]
        BoundingBox TimeSigSlash { get; }

        [DataMember(Name = "timeSigX")]
        BoundingBox TimeSigX { get; }

        [DataMember(Name = "tremolo1")]
        BoundingBox Tremolo1 { get; }

        [DataMember(Name = "tremolo2")]
        BoundingBox Tremolo2 { get; }

        [DataMember(Name = "tremolo3")]
        BoundingBox Tremolo3 { get; }

        [DataMember(Name = "tremolo4")]
        BoundingBox Tremolo4 { get; }

        [DataMember(Name = "tremolo5")]
        BoundingBox Tremolo5 { get; }

        [DataMember(Name = "tremoloDivisiDots2")]
        BoundingBox TremoloDivisiDots2 { get; }

        [DataMember(Name = "tremoloDivisiDots3")]
        BoundingBox TremoloDivisiDots3 { get; }

        [DataMember(Name = "tremoloDivisiDots4")]
        BoundingBox TremoloDivisiDots4 { get; }

        [DataMember(Name = "tremoloDivisiDots6")]
        BoundingBox TremoloDivisiDots6 { get; }

        [DataMember(Name = "tremoloFingered1")]
        BoundingBox TremoloFingered1 { get; }

        [DataMember(Name = "tremoloFingered2")]
        BoundingBox TremoloFingered2 { get; }

        [DataMember(Name = "tremoloFingered3")]
        BoundingBox TremoloFingered3 { get; }

        [DataMember(Name = "tremoloFingered4")]
        BoundingBox TremoloFingered4 { get; }

        [DataMember(Name = "tremoloFingered5")]
        BoundingBox TremoloFingered5 { get; }

        [DataMember(Name = "tripleTongueAbove")]
        BoundingBox TripleTongueAbove { get; }

        [DataMember(Name = "tripleTongueAboveNoSlur")]
        BoundingBox TripleTongueAboveNoSlur { get; }

        [DataMember(Name = "tripleTongueBelow")]
        BoundingBox TripleTongueBelow { get; }

        [DataMember(Name = "tripleTongueBelowNoSlur")]
        BoundingBox TripleTongueBelowNoSlur { get; }

        [DataMember(Name = "tuplet0")]
        BoundingBox Tuplet0 { get; }

        [DataMember(Name = "tuplet1")]
        BoundingBox Tuplet1 { get; }

        [DataMember(Name = "tuplet2")]
        BoundingBox Tuplet2 { get; }

        [DataMember(Name = "tuplet3")]
        BoundingBox Tuplet3 { get; }

        [DataMember(Name = "tuplet4")]
        BoundingBox Tuplet4 { get; }

        [DataMember(Name = "tuplet5")]
        BoundingBox Tuplet5 { get; }

        [DataMember(Name = "tuplet6")]
        BoundingBox Tuplet6 { get; }

        [DataMember(Name = "tuplet7")]
        BoundingBox Tuplet7 { get; }

        [DataMember(Name = "tuplet8")]
        BoundingBox Tuplet8 { get; }

        [DataMember(Name = "tuplet9")]
        BoundingBox Tuplet9 { get; }

        [DataMember(Name = "tupletColon")]
        BoundingBox TupletColon { get; }

        [DataMember(Name = "unmeasuredTremolo")]
        BoundingBox UnmeasuredTremolo { get; }

        [DataMember(Name = "unmeasuredTremoloSimple")]
        BoundingBox UnmeasuredTremoloSimple { get; }

        [DataMember(Name = "unpitchedPercussionClef1")]
        BoundingBox UnpitchedPercussionClef1 { get; }

        [DataMember(Name = "unpitchedPercussionClef1Alt")]
        BoundingBox UnpitchedPercussionClef1Alt { get; }

        [DataMember(Name = "unpitchedPercussionClef2")]
        BoundingBox UnpitchedPercussionClef2 { get; }

        [DataMember(Name = "ventiduesima")]
        BoundingBox Ventiduesima { get; }

        [DataMember(Name = "ventiduesimaAlta")]
        BoundingBox VentiduesimaAlta { get; }

        [DataMember(Name = "ventiduesimaBassa")]
        BoundingBox VentiduesimaBassa { get; }

        [DataMember(Name = "ventiduesimaBassaMb")]
        BoundingBox VentiduesimaBassaMb { get; }

        [DataMember(Name = "ventiquattresima")]
        BoundingBox Ventiquattresima { get; }

        [DataMember(Name = "ventiquattresimaAlta")]
        BoundingBox VentiquattresimaAlta { get; }

        [DataMember(Name = "ventiquattresimaBassa")]
        BoundingBox VentiquattresimaBassa { get; }

        [DataMember(Name = "ventiquattresimaBassaMb")]
        BoundingBox VentiquattresimaBassaMb { get; }

        [DataMember(Name = "vocalFingerClickStockhausen")]
        BoundingBox VocalFingerClickStockhausen { get; }

        [DataMember(Name = "vocalMouthClosed")]
        BoundingBox VocalMouthClosed { get; }

        [DataMember(Name = "vocalMouthOpen")]
        BoundingBox VocalMouthOpen { get; }

        [DataMember(Name = "vocalMouthPursed")]
        BoundingBox VocalMouthPursed { get; }

        [DataMember(Name = "vocalMouthSlightlyOpen")]
        BoundingBox VocalMouthSlightlyOpen { get; }

        [DataMember(Name = "vocalMouthWideOpen")]
        BoundingBox VocalMouthWideOpen { get; }

        [DataMember(Name = "vocalNasalVoice")]
        BoundingBox VocalNasalVoice { get; }

        [DataMember(Name = "vocalSprechgesang")]
        BoundingBox VocalSprechgesang { get; }

        [DataMember(Name = "vocalTongueClickStockhausen")]
        BoundingBox VocalTongueClickStockhausen { get; }

        [DataMember(Name = "vocalTongueFingerClickStockhausen")]
        BoundingBox VocalTongueFingerClickStockhausen { get; }

        [DataMember(Name = "vocalsSussurando")]
        BoundingBox VocalsSussurando { get; }

        [DataMember(Name = "wiggleArpeggiatoDown")]
        BoundingBox WiggleArpeggiatoDown { get; }

        [DataMember(Name = "wiggleArpeggiatoDownArrow")]
        BoundingBox WiggleArpeggiatoDownArrow { get; }

        [DataMember(Name = "wiggleArpeggiatoDownSwash")]
        BoundingBox WiggleArpeggiatoDownSwash { get; }

        [DataMember(Name = "wiggleArpeggiatoDownSwashCouperin")]
        BoundingBox WiggleArpeggiatoDownSwashCouperin { get; }

        [DataMember(Name = "wiggleArpeggiatoUp")]
        BoundingBox WiggleArpeggiatoUp { get; }

        [DataMember(Name = "wiggleArpeggiatoUpArrow")]
        BoundingBox WiggleArpeggiatoUpArrow { get; }

        [DataMember(Name = "wiggleArpeggiatoUpSwash")]
        BoundingBox WiggleArpeggiatoUpSwash { get; }

        [DataMember(Name = "wiggleArpeggiatoUpSwashCouperin")]
        BoundingBox WiggleArpeggiatoUpSwashCouperin { get; }

        [DataMember(Name = "wiggleCircular")]
        BoundingBox WiggleCircular { get; }

        [DataMember(Name = "wiggleCircularConstant")]
        BoundingBox WiggleCircularConstant { get; }

        [DataMember(Name = "wiggleCircularConstantFlipped")]
        BoundingBox WiggleCircularConstantFlipped { get; }

        [DataMember(Name = "wiggleCircularConstantFlippedLarge")]
        BoundingBox WiggleCircularConstantFlippedLarge { get; }

        [DataMember(Name = "wiggleCircularConstantLarge")]
        BoundingBox WiggleCircularConstantLarge { get; }

        [DataMember(Name = "wiggleCircularEnd")]
        BoundingBox WiggleCircularEnd { get; }

        [DataMember(Name = "wiggleCircularLarge")]
        BoundingBox WiggleCircularLarge { get; }

        [DataMember(Name = "wiggleCircularLarger")]
        BoundingBox WiggleCircularLarger { get; }

        [DataMember(Name = "wiggleCircularLargerStill")]
        BoundingBox WiggleCircularLargerStill { get; }

        [DataMember(Name = "wiggleCircularLargest")]
        BoundingBox WiggleCircularLargest { get; }

        [DataMember(Name = "wiggleCircularSmall")]
        BoundingBox WiggleCircularSmall { get; }

        [DataMember(Name = "wiggleCircularStart")]
        BoundingBox WiggleCircularStart { get; }

        [DataMember(Name = "wiggleGlissando")]
        BoundingBox WiggleGlissando { get; }

        [DataMember(Name = "wiggleGlissandoGroup1")]
        BoundingBox WiggleGlissandoGroup1 { get; }

        [DataMember(Name = "wiggleGlissandoGroup2")]
        BoundingBox WiggleGlissandoGroup2 { get; }

        [DataMember(Name = "wiggleGlissandoGroup3")]
        BoundingBox WiggleGlissandoGroup3 { get; }

        [DataMember(Name = "wiggleRandom1")]
        BoundingBox WiggleRandom1 { get; }

        [DataMember(Name = "wiggleRandom2")]
        BoundingBox WiggleRandom2 { get; }

        [DataMember(Name = "wiggleRandom3")]
        BoundingBox WiggleRandom3 { get; }

        [DataMember(Name = "wiggleRandom4")]
        BoundingBox WiggleRandom4 { get; }

        [DataMember(Name = "wiggleSawtooth")]
        BoundingBox WiggleSawtooth { get; }

        [DataMember(Name = "wiggleSawtoothNarrow")]
        BoundingBox WiggleSawtoothNarrow { get; }

        [DataMember(Name = "wiggleSawtoothWide")]
        BoundingBox WiggleSawtoothWide { get; }

        [DataMember(Name = "wiggleSquareWave")]
        BoundingBox WiggleSquareWave { get; }

        [DataMember(Name = "wiggleSquareWaveNarrow")]
        BoundingBox WiggleSquareWaveNarrow { get; }

        [DataMember(Name = "wiggleSquareWaveWide")]
        BoundingBox WiggleSquareWaveWide { get; }

        [DataMember(Name = "wiggleTrill")]
        BoundingBox WiggleTrill { get; }

        [DataMember(Name = "wiggleTrillFast")]
        BoundingBox WiggleTrillFast { get; }

        [DataMember(Name = "wiggleTrillFaster")]
        BoundingBox WiggleTrillFaster { get; }

        [DataMember(Name = "wiggleTrillFasterStill")]
        BoundingBox WiggleTrillFasterStill { get; }

        [DataMember(Name = "wiggleTrillFastest")]
        BoundingBox WiggleTrillFastest { get; }

        [DataMember(Name = "wiggleTrillSlow")]
        BoundingBox WiggleTrillSlow { get; }

        [DataMember(Name = "wiggleTrillSlower")]
        BoundingBox WiggleTrillSlower { get; }

        [DataMember(Name = "wiggleTrillSlowerStill")]
        BoundingBox WiggleTrillSlowerStill { get; }

        [DataMember(Name = "wiggleTrillSlowest")]
        BoundingBox WiggleTrillSlowest { get; }

        [DataMember(Name = "wiggleVIbratoLargestSlower")]
        BoundingBox WiggleVIbratoLargestSlower { get; }

        [DataMember(Name = "wiggleVIbratoMediumSlower")]
        BoundingBox WiggleVIbratoMediumSlower { get; }

        [DataMember(Name = "wiggleVibrato")]
        BoundingBox WiggleVibrato { get; }

        [DataMember(Name = "wiggleVibratoLargeFast")]
        BoundingBox WiggleVibratoLargeFast { get; }

        [DataMember(Name = "wiggleVibratoLargeFaster")]
        BoundingBox WiggleVibratoLargeFaster { get; }

        [DataMember(Name = "wiggleVibratoLargeFasterStill")]
        BoundingBox WiggleVibratoLargeFasterStill { get; }

        [DataMember(Name = "wiggleVibratoLargeFastest")]
        BoundingBox WiggleVibratoLargeFastest { get; }

        [DataMember(Name = "wiggleVibratoLargeSlow")]
        BoundingBox WiggleVibratoLargeSlow { get; }

        [DataMember(Name = "wiggleVibratoLargeSlower")]
        BoundingBox WiggleVibratoLargeSlower { get; }

        [DataMember(Name = "wiggleVibratoLargeSlowest")]
        BoundingBox WiggleVibratoLargeSlowest { get; }

        [DataMember(Name = "wiggleVibratoLargestFast")]
        BoundingBox WiggleVibratoLargestFast { get; }

        [DataMember(Name = "wiggleVibratoLargestFaster")]
        BoundingBox WiggleVibratoLargestFaster { get; }

        [DataMember(Name = "wiggleVibratoLargestFasterStill")]
        BoundingBox WiggleVibratoLargestFasterStill { get; }

        [DataMember(Name = "wiggleVibratoLargestFastest")]
        BoundingBox WiggleVibratoLargestFastest { get; }

        [DataMember(Name = "wiggleVibratoLargestSlow")]
        BoundingBox WiggleVibratoLargestSlow { get; }

        [DataMember(Name = "wiggleVibratoLargestSlowest")]
        BoundingBox WiggleVibratoLargestSlowest { get; }

        [DataMember(Name = "wiggleVibratoMediumFast")]
        BoundingBox WiggleVibratoMediumFast { get; }

        [DataMember(Name = "wiggleVibratoMediumFaster")]
        BoundingBox WiggleVibratoMediumFaster { get; }

        [DataMember(Name = "wiggleVibratoMediumFasterStill")]
        BoundingBox WiggleVibratoMediumFasterStill { get; }

        [DataMember(Name = "wiggleVibratoMediumFastest")]
        BoundingBox WiggleVibratoMediumFastest { get; }

        [DataMember(Name = "wiggleVibratoMediumSlow")]
        BoundingBox WiggleVibratoMediumSlow { get; }

        [DataMember(Name = "wiggleVibratoMediumSlowest")]
        BoundingBox WiggleVibratoMediumSlowest { get; }

        [DataMember(Name = "wiggleVibratoSmallFast")]
        BoundingBox WiggleVibratoSmallFast { get; }

        [DataMember(Name = "wiggleVibratoSmallFaster")]
        BoundingBox WiggleVibratoSmallFaster { get; }

        [DataMember(Name = "wiggleVibratoSmallFasterStill")]
        BoundingBox WiggleVibratoSmallFasterStill { get; }

        [DataMember(Name = "wiggleVibratoSmallFastest")]
        BoundingBox WiggleVibratoSmallFastest { get; }

        [DataMember(Name = "wiggleVibratoSmallSlow")]
        BoundingBox WiggleVibratoSmallSlow { get; }

        [DataMember(Name = "wiggleVibratoSmallSlower")]
        BoundingBox WiggleVibratoSmallSlower { get; }

        [DataMember(Name = "wiggleVibratoSmallSlowest")]
        BoundingBox WiggleVibratoSmallSlowest { get; }

        [DataMember(Name = "wiggleVibratoSmallestFast")]
        BoundingBox WiggleVibratoSmallestFast { get; }

        [DataMember(Name = "wiggleVibratoSmallestFaster")]
        BoundingBox WiggleVibratoSmallestFaster { get; }

        [DataMember(Name = "wiggleVibratoSmallestFasterStill")]
        BoundingBox WiggleVibratoSmallestFasterStill { get; }

        [DataMember(Name = "wiggleVibratoSmallestFastest")]
        BoundingBox WiggleVibratoSmallestFastest { get; }

        [DataMember(Name = "wiggleVibratoSmallestSlow")]
        BoundingBox WiggleVibratoSmallestSlow { get; }

        [DataMember(Name = "wiggleVibratoSmallestSlower")]
        BoundingBox WiggleVibratoSmallestSlower { get; }

        [DataMember(Name = "wiggleVibratoSmallestSlowest")]
        BoundingBox WiggleVibratoSmallestSlowest { get; }

        [DataMember(Name = "wiggleVibratoStart")]
        BoundingBox WiggleVibratoStart { get; }

        [DataMember(Name = "wiggleVibratoWide")]
        BoundingBox WiggleVibratoWide { get; }

        [DataMember(Name = "wiggleWavy")]
        BoundingBox WiggleWavy { get; }

        [DataMember(Name = "wiggleWavyNarrow")]
        BoundingBox WiggleWavyNarrow { get; }

        [DataMember(Name = "wiggleWavyWide")]
        BoundingBox WiggleWavyWide { get; }

        [DataMember(Name = "windClosedHole")]
        BoundingBox WindClosedHole { get; }

        [DataMember(Name = "windFlatEmbouchure")]
        BoundingBox WindFlatEmbouchure { get; }

        [DataMember(Name = "windHalfClosedHole1")]
        BoundingBox WindHalfClosedHole1 { get; }

        [DataMember(Name = "windHalfClosedHole2")]
        BoundingBox WindHalfClosedHole2 { get; }

        [DataMember(Name = "windHalfClosedHole3")]
        BoundingBox WindHalfClosedHole3 { get; }

        [DataMember(Name = "windLessRelaxedEmbouchure")]
        BoundingBox WindLessRelaxedEmbouchure { get; }

        [DataMember(Name = "windLessTightEmbouchure")]
        BoundingBox WindLessTightEmbouchure { get; }

        [DataMember(Name = "windMouthpiecePop")]
        BoundingBox WindMouthpiecePop { get; }

        [DataMember(Name = "windMultiphonicsBlackStem")]
        BoundingBox WindMultiphonicsBlackStem { get; }

        [DataMember(Name = "windMultiphonicsBlackWhiteStem")]
        BoundingBox WindMultiphonicsBlackWhiteStem { get; }

        [DataMember(Name = "windMultiphonicsWhiteStem")]
        BoundingBox WindMultiphonicsWhiteStem { get; }

        [DataMember(Name = "windOpenHole")]
        BoundingBox WindOpenHole { get; }

        [DataMember(Name = "windReedPositionIn")]
        BoundingBox WindReedPositionIn { get; }

        [DataMember(Name = "windReedPositionNormal")]
        BoundingBox WindReedPositionNormal { get; }

        [DataMember(Name = "windReedPositionOut")]
        BoundingBox WindReedPositionOut { get; }

        [DataMember(Name = "windRelaxedEmbouchure")]
        BoundingBox WindRelaxedEmbouchure { get; }

        [DataMember(Name = "windRimOnly")]
        BoundingBox WindRimOnly { get; }

        [DataMember(Name = "windSharpEmbouchure")]
        BoundingBox WindSharpEmbouchure { get; }

        [DataMember(Name = "windStrongAirPressure")]
        BoundingBox WindStrongAirPressure { get; }

        [DataMember(Name = "windThreeQuartersClosedHole")]
        BoundingBox WindThreeQuartersClosedHole { get; }

        [DataMember(Name = "windTightEmbouchure")]
        BoundingBox WindTightEmbouchure { get; }

        [DataMember(Name = "windTrillKey")]
        BoundingBox WindTrillKey { get; }

        [DataMember(Name = "windVeryTightEmbouchure")]
        BoundingBox WindVeryTightEmbouchure { get; }

        [DataMember(Name = "windWeakAirPressure")]
        BoundingBox WindWeakAirPressure { get; }
    }
}