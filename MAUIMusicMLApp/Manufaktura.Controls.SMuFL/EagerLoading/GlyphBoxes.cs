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

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Manufaktura.Controls.Model.SMuFL;

namespace Manufaktura.Controls.SMuFL.EagerLoading
{
    public class GlyphBBoxes : IGlyphBBoxes
    {
        [DataMember(Name="4stringTabClef")]
        public BoundingBox The4StringTabClef { get; set; }

        [DataMember(Name="4stringTabClefSerif")]
        public BoundingBox The4StringTabClefSerif { get; set; }

        [DataMember(Name="4stringTabClefTall")]
        public BoundingBox The4StringTabClefTall { get; set; }

        [DataMember(Name="6stringTabClef")]
        public BoundingBox The6StringTabClef { get; set; }

        [DataMember(Name="6stringTabClefSerif")]
        public BoundingBox The6StringTabClefSerif { get; set; }

        [DataMember(Name="6stringTabClefTall")]
        public BoundingBox The6StringTabClefTall { get; set; }

        [DataMember(Name="accSagittal11LargeDiesisDown")]
        public BoundingBox AccSagittal11LargeDiesisDown { get; set; }

        [DataMember(Name="accSagittal11LargeDiesisUp")]
        public BoundingBox AccSagittal11LargeDiesisUp { get; set; }

        [DataMember(Name="accSagittal11MediumDiesisDown")]
        public BoundingBox AccSagittal11MediumDiesisDown { get; set; }

        [DataMember(Name="accSagittal11MediumDiesisUp")]
        public BoundingBox AccSagittal11MediumDiesisUp { get; set; }

        [DataMember(Name="accSagittal11v19LargeDiesisDown")]
        public BoundingBox AccSagittal11V19LargeDiesisDown { get; set; }

        [DataMember(Name="accSagittal11v19LargeDiesisUp")]
        public BoundingBox AccSagittal11V19LargeDiesisUp { get; set; }

        [DataMember(Name="accSagittal11v19MediumDiesisDown")]
        public BoundingBox AccSagittal11V19MediumDiesisDown { get; set; }

        [DataMember(Name="accSagittal11v19MediumDiesisUp")]
        public BoundingBox AccSagittal11V19MediumDiesisUp { get; set; }

        [DataMember(Name="accSagittal11v49CommaDown")]
        public BoundingBox AccSagittal11V49CommaDown { get; set; }

        [DataMember(Name="accSagittal11v49CommaUp")]
        public BoundingBox AccSagittal11V49CommaUp { get; set; }

        [DataMember(Name="accSagittal143CommaDown")]
        public BoundingBox AccSagittal143CommaDown { get; set; }

        [DataMember(Name="accSagittal143CommaUp")]
        public BoundingBox AccSagittal143CommaUp { get; set; }

        [DataMember(Name="accSagittal17CommaDown")]
        public BoundingBox AccSagittal17CommaDown { get; set; }

        [DataMember(Name="accSagittal17CommaUp")]
        public BoundingBox AccSagittal17CommaUp { get; set; }

        [DataMember(Name="accSagittal17KleismaDown")]
        public BoundingBox AccSagittal17KleismaDown { get; set; }

        [DataMember(Name="accSagittal17KleismaUp")]
        public BoundingBox AccSagittal17KleismaUp { get; set; }

        [DataMember(Name="accSagittal19CommaDown")]
        public BoundingBox AccSagittal19CommaDown { get; set; }

        [DataMember(Name="accSagittal19CommaUp")]
        public BoundingBox AccSagittal19CommaUp { get; set; }

        [DataMember(Name="accSagittal19SchismaDown")]
        public BoundingBox AccSagittal19SchismaDown { get; set; }

        [DataMember(Name="accSagittal19SchismaUp")]
        public BoundingBox AccSagittal19SchismaUp { get; set; }

        [DataMember(Name="accSagittal23CommaDown")]
        public BoundingBox AccSagittal23CommaDown { get; set; }

        [DataMember(Name="accSagittal23CommaUp")]
        public BoundingBox AccSagittal23CommaUp { get; set; }

        [DataMember(Name="accSagittal23SmallDiesisDown")]
        public BoundingBox AccSagittal23SmallDiesisDown { get; set; }

        [DataMember(Name="accSagittal23SmallDiesisUp")]
        public BoundingBox AccSagittal23SmallDiesisUp { get; set; }

        [DataMember(Name="accSagittal25SmallDiesisDown")]
        public BoundingBox AccSagittal25SmallDiesisDown { get; set; }

        [DataMember(Name="accSagittal25SmallDiesisUp")]
        public BoundingBox AccSagittal25SmallDiesisUp { get; set; }

        [DataMember(Name="accSagittal35LargeDiesisDown")]
        public BoundingBox AccSagittal35LargeDiesisDown { get; set; }

        [DataMember(Name="accSagittal35LargeDiesisUp")]
        public BoundingBox AccSagittal35LargeDiesisUp { get; set; }

        [DataMember(Name="accSagittal35MediumDiesisDown")]
        public BoundingBox AccSagittal35MediumDiesisDown { get; set; }

        [DataMember(Name="accSagittal35MediumDiesisUp")]
        public BoundingBox AccSagittal35MediumDiesisUp { get; set; }

        [DataMember(Name="accSagittal49LargeDiesisDown")]
        public BoundingBox AccSagittal49LargeDiesisDown { get; set; }

        [DataMember(Name="accSagittal49LargeDiesisUp")]
        public BoundingBox AccSagittal49LargeDiesisUp { get; set; }

        [DataMember(Name="accSagittal49MediumDiesisDown")]
        public BoundingBox AccSagittal49MediumDiesisDown { get; set; }

        [DataMember(Name="accSagittal49MediumDiesisUp")]
        public BoundingBox AccSagittal49MediumDiesisUp { get; set; }

        [DataMember(Name="accSagittal49SmallDiesisDown")]
        public BoundingBox AccSagittal49SmallDiesisDown { get; set; }

        [DataMember(Name="accSagittal49SmallDiesisUp")]
        public BoundingBox AccSagittal49SmallDiesisUp { get; set; }

        [DataMember(Name="accSagittal55CommaDown")]
        public BoundingBox AccSagittal55CommaDown { get; set; }

        [DataMember(Name="accSagittal55CommaUp")]
        public BoundingBox AccSagittal55CommaUp { get; set; }

        [DataMember(Name="accSagittal5CommaDown")]
        public BoundingBox AccSagittal5CommaDown { get; set; }

        [DataMember(Name="accSagittal5CommaUp")]
        public BoundingBox AccSagittal5CommaUp { get; set; }

        [DataMember(Name="accSagittal5v11SmallDiesisDown")]
        public BoundingBox AccSagittal5V11SmallDiesisDown { get; set; }

        [DataMember(Name="accSagittal5v11SmallDiesisUp")]
        public BoundingBox AccSagittal5V11SmallDiesisUp { get; set; }

        [DataMember(Name="accSagittal5v13LargeDiesisDown")]
        public BoundingBox AccSagittal5V13LargeDiesisDown { get; set; }

        [DataMember(Name="accSagittal5v13LargeDiesisUp")]
        public BoundingBox AccSagittal5V13LargeDiesisUp { get; set; }

        [DataMember(Name="accSagittal5v13MediumDiesisDown")]
        public BoundingBox AccSagittal5V13MediumDiesisDown { get; set; }

        [DataMember(Name="accSagittal5v13MediumDiesisUp")]
        public BoundingBox AccSagittal5V13MediumDiesisUp { get; set; }

        [DataMember(Name="accSagittal5v19CommaDown")]
        public BoundingBox AccSagittal5V19CommaDown { get; set; }

        [DataMember(Name="accSagittal5v19CommaUp")]
        public BoundingBox AccSagittal5V19CommaUp { get; set; }

        [DataMember(Name="accSagittal5v23SmallDiesisDown")]
        public BoundingBox AccSagittal5V23SmallDiesisDown { get; set; }

        [DataMember(Name="accSagittal5v23SmallDiesisUp")]
        public BoundingBox AccSagittal5V23SmallDiesisUp { get; set; }

        [DataMember(Name="accSagittal5v49MediumDiesisDown")]
        public BoundingBox AccSagittal5V49MediumDiesisDown { get; set; }

        [DataMember(Name="accSagittal5v49MediumDiesisUp")]
        public BoundingBox AccSagittal5V49MediumDiesisUp { get; set; }

        [DataMember(Name="accSagittal5v7KleismaDown")]
        public BoundingBox AccSagittal5V7KleismaDown { get; set; }

        [DataMember(Name="accSagittal5v7KleismaUp")]
        public BoundingBox AccSagittal5V7KleismaUp { get; set; }

        [DataMember(Name="accSagittal7CommaDown")]
        public BoundingBox AccSagittal7CommaDown { get; set; }

        [DataMember(Name="accSagittal7CommaUp")]
        public BoundingBox AccSagittal7CommaUp { get; set; }

        [DataMember(Name="accSagittal7v11CommaDown")]
        public BoundingBox AccSagittal7V11CommaDown { get; set; }

        [DataMember(Name="accSagittal7v11CommaUp")]
        public BoundingBox AccSagittal7V11CommaUp { get; set; }

        [DataMember(Name="accSagittal7v11KleismaDown")]
        public BoundingBox AccSagittal7V11KleismaDown { get; set; }

        [DataMember(Name="accSagittal7v11KleismaUp")]
        public BoundingBox AccSagittal7V11KleismaUp { get; set; }

        [DataMember(Name="accSagittal7v19CommaDown")]
        public BoundingBox AccSagittal7V19CommaDown { get; set; }

        [DataMember(Name="accSagittal7v19CommaUp")]
        public BoundingBox AccSagittal7V19CommaUp { get; set; }

        [DataMember(Name="accSagittalAcute")]
        public BoundingBox AccSagittalAcute { get; set; }

        [DataMember(Name="accSagittalDoubleFlat")]
        public BoundingBox AccSagittalDoubleFlat { get; set; }

        [DataMember(Name="accSagittalDoubleFlat11v49CUp")]
        public BoundingBox AccSagittalDoubleFlat11V49CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat143CUp")]
        public BoundingBox AccSagittalDoubleFlat143CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat17CUp")]
        public BoundingBox AccSagittalDoubleFlat17CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat17kUp")]
        public BoundingBox AccSagittalDoubleFlat17KUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat19CUp")]
        public BoundingBox AccSagittalDoubleFlat19CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat19sUp")]
        public BoundingBox AccSagittalDoubleFlat19SUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat23CUp")]
        public BoundingBox AccSagittalDoubleFlat23CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat23SUp")]
        public BoundingBox AccSagittalDoubleFlat23SUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat25SUp")]
        public BoundingBox AccSagittalDoubleFlat25SUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat49SUp")]
        public BoundingBox AccSagittalDoubleFlat49SUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat55CUp")]
        public BoundingBox AccSagittalDoubleFlat55CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat5CUp")]
        public BoundingBox AccSagittalDoubleFlat5CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat5v11SUp")]
        public BoundingBox AccSagittalDoubleFlat5V11SUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat5v19CUp")]
        public BoundingBox AccSagittalDoubleFlat5V19CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat5v23SUp")]
        public BoundingBox AccSagittalDoubleFlat5V23SUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat5v7kUp")]
        public BoundingBox AccSagittalDoubleFlat5V7KUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat7CUp")]
        public BoundingBox AccSagittalDoubleFlat7CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat7v11CUp")]
        public BoundingBox AccSagittalDoubleFlat7V11CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat7v11kUp")]
        public BoundingBox AccSagittalDoubleFlat7V11KUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat7v19CUp")]
        public BoundingBox AccSagittalDoubleFlat7V19CUp { get; set; }

        [DataMember(Name="accSagittalDoubleSharp")]
        public BoundingBox AccSagittalDoubleSharp { get; set; }

        [DataMember(Name="accSagittalDoubleSharp11v49CDown")]
        public BoundingBox AccSagittalDoubleSharp11V49CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp143CDown")]
        public BoundingBox AccSagittalDoubleSharp143CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp17CDown")]
        public BoundingBox AccSagittalDoubleSharp17CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp17kDown")]
        public BoundingBox AccSagittalDoubleSharp17KDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp19CDown")]
        public BoundingBox AccSagittalDoubleSharp19CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp19sDown")]
        public BoundingBox AccSagittalDoubleSharp19SDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp23CDown")]
        public BoundingBox AccSagittalDoubleSharp23CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp23SDown")]
        public BoundingBox AccSagittalDoubleSharp23SDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp25SDown")]
        public BoundingBox AccSagittalDoubleSharp25SDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp49SDown")]
        public BoundingBox AccSagittalDoubleSharp49SDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp55CDown")]
        public BoundingBox AccSagittalDoubleSharp55CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp5CDown")]
        public BoundingBox AccSagittalDoubleSharp5CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp5v11SDown")]
        public BoundingBox AccSagittalDoubleSharp5V11SDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp5v19CDown")]
        public BoundingBox AccSagittalDoubleSharp5V19CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp5v23SDown")]
        public BoundingBox AccSagittalDoubleSharp5V23SDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp5v7kDown")]
        public BoundingBox AccSagittalDoubleSharp5V7KDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp7CDown")]
        public BoundingBox AccSagittalDoubleSharp7CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp7v11CDown")]
        public BoundingBox AccSagittalDoubleSharp7V11CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp7v11kDown")]
        public BoundingBox AccSagittalDoubleSharp7V11KDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp7v19CDown")]
        public BoundingBox AccSagittalDoubleSharp7V19CDown { get; set; }

        [DataMember(Name="accSagittalFlat")]
        public BoundingBox AccSagittalFlat { get; set; }

        [DataMember(Name="accSagittalFlat11LDown")]
        public BoundingBox AccSagittalFlat11LDown { get; set; }

        [DataMember(Name="accSagittalFlat11MDown")]
        public BoundingBox AccSagittalFlat11MDown { get; set; }

        [DataMember(Name="accSagittalFlat11v19LDown")]
        public BoundingBox AccSagittalFlat11V19LDown { get; set; }

        [DataMember(Name="accSagittalFlat11v19MDown")]
        public BoundingBox AccSagittalFlat11V19MDown { get; set; }

        [DataMember(Name="accSagittalFlat11v49CDown")]
        public BoundingBox AccSagittalFlat11V49CDown { get; set; }

        [DataMember(Name="accSagittalFlat11v49CUp")]
        public BoundingBox AccSagittalFlat11V49CUp { get; set; }

        [DataMember(Name="accSagittalFlat143CDown")]
        public BoundingBox AccSagittalFlat143CDown { get; set; }

        [DataMember(Name="accSagittalFlat143CUp")]
        public BoundingBox AccSagittalFlat143CUp { get; set; }

        [DataMember(Name="accSagittalFlat17CDown")]
        public BoundingBox AccSagittalFlat17CDown { get; set; }

        [DataMember(Name="accSagittalFlat17CUp")]
        public BoundingBox AccSagittalFlat17CUp { get; set; }

        [DataMember(Name="accSagittalFlat17kDown")]
        public BoundingBox AccSagittalFlat17KDown { get; set; }

        [DataMember(Name="accSagittalFlat17kUp")]
        public BoundingBox AccSagittalFlat17KUp { get; set; }

        [DataMember(Name="accSagittalFlat19CDown")]
        public BoundingBox AccSagittalFlat19CDown { get; set; }

        [DataMember(Name="accSagittalFlat19CUp")]
        public BoundingBox AccSagittalFlat19CUp { get; set; }

        [DataMember(Name="accSagittalFlat19sDown")]
        public BoundingBox AccSagittalFlat19SDown { get; set; }

        [DataMember(Name="accSagittalFlat19sUp")]
        public BoundingBox AccSagittalFlat19SUp { get; set; }

        [DataMember(Name="accSagittalFlat23CDown")]
        public BoundingBox AccSagittalFlat23CDown { get; set; }

        [DataMember(Name="accSagittalFlat23CUp")]
        public BoundingBox AccSagittalFlat23CUp { get; set; }

        [DataMember(Name="accSagittalFlat23SDown")]
        public BoundingBox AccSagittalFlat23SDown { get; set; }

        [DataMember(Name="accSagittalFlat23SUp")]
        public BoundingBox AccSagittalFlat23SUp { get; set; }

        [DataMember(Name="accSagittalFlat25SDown")]
        public BoundingBox AccSagittalFlat25SDown { get; set; }

        [DataMember(Name="accSagittalFlat25SUp")]
        public BoundingBox AccSagittalFlat25SUp { get; set; }

        [DataMember(Name="accSagittalFlat35LDown")]
        public BoundingBox AccSagittalFlat35LDown { get; set; }

        [DataMember(Name="accSagittalFlat35MDown")]
        public BoundingBox AccSagittalFlat35MDown { get; set; }

        [DataMember(Name="accSagittalFlat49LDown")]
        public BoundingBox AccSagittalFlat49LDown { get; set; }

        [DataMember(Name="accSagittalFlat49MDown")]
        public BoundingBox AccSagittalFlat49MDown { get; set; }

        [DataMember(Name="accSagittalFlat49SDown")]
        public BoundingBox AccSagittalFlat49SDown { get; set; }

        [DataMember(Name="accSagittalFlat49SUp")]
        public BoundingBox AccSagittalFlat49SUp { get; set; }

        [DataMember(Name="accSagittalFlat55CDown")]
        public BoundingBox AccSagittalFlat55CDown { get; set; }

        [DataMember(Name="accSagittalFlat55CUp")]
        public BoundingBox AccSagittalFlat55CUp { get; set; }

        [DataMember(Name="accSagittalFlat5CDown")]
        public BoundingBox AccSagittalFlat5CDown { get; set; }

        [DataMember(Name="accSagittalFlat5CUp")]
        public BoundingBox AccSagittalFlat5CUp { get; set; }

        [DataMember(Name="accSagittalFlat5v11SDown")]
        public BoundingBox AccSagittalFlat5V11SDown { get; set; }

        [DataMember(Name="accSagittalFlat5v11SUp")]
        public BoundingBox AccSagittalFlat5V11SUp { get; set; }

        [DataMember(Name="accSagittalFlat5v13LDown")]
        public BoundingBox AccSagittalFlat5V13LDown { get; set; }

        [DataMember(Name="accSagittalFlat5v13MDown")]
        public BoundingBox AccSagittalFlat5V13MDown { get; set; }

        [DataMember(Name="accSagittalFlat5v19CDown")]
        public BoundingBox AccSagittalFlat5V19CDown { get; set; }

        [DataMember(Name="accSagittalFlat5v19CUp")]
        public BoundingBox AccSagittalFlat5V19CUp { get; set; }

        [DataMember(Name="accSagittalFlat5v23SDown")]
        public BoundingBox AccSagittalFlat5V23SDown { get; set; }

        [DataMember(Name="accSagittalFlat5v23SUp")]
        public BoundingBox AccSagittalFlat5V23SUp { get; set; }

        [DataMember(Name="accSagittalFlat5v49MDown")]
        public BoundingBox AccSagittalFlat5V49MDown { get; set; }

        [DataMember(Name="accSagittalFlat5v7kDown")]
        public BoundingBox AccSagittalFlat5V7KDown { get; set; }

        [DataMember(Name="accSagittalFlat5v7kUp")]
        public BoundingBox AccSagittalFlat5V7KUp { get; set; }

        [DataMember(Name="accSagittalFlat7CDown")]
        public BoundingBox AccSagittalFlat7CDown { get; set; }

        [DataMember(Name="accSagittalFlat7CUp")]
        public BoundingBox AccSagittalFlat7CUp { get; set; }

        [DataMember(Name="accSagittalFlat7v11CDown")]
        public BoundingBox AccSagittalFlat7V11CDown { get; set; }

        [DataMember(Name="accSagittalFlat7v11CUp")]
        public BoundingBox AccSagittalFlat7V11CUp { get; set; }

        [DataMember(Name="accSagittalFlat7v11kDown")]
        public BoundingBox AccSagittalFlat7V11KDown { get; set; }

        [DataMember(Name="accSagittalFlat7v11kUp")]
        public BoundingBox AccSagittalFlat7V11KUp { get; set; }

        [DataMember(Name="accSagittalFlat7v19CDown")]
        public BoundingBox AccSagittalFlat7V19CDown { get; set; }

        [DataMember(Name="accSagittalFlat7v19CUp")]
        public BoundingBox AccSagittalFlat7V19CUp { get; set; }

        [DataMember(Name="accSagittalGrave")]
        public BoundingBox AccSagittalGrave { get; set; }

        [DataMember(Name="accSagittalShaftDown")]
        public BoundingBox AccSagittalShaftDown { get; set; }

        [DataMember(Name="accSagittalShaftUp")]
        public BoundingBox AccSagittalShaftUp { get; set; }

        [DataMember(Name="accSagittalSharp")]
        public BoundingBox AccSagittalSharp { get; set; }

        [DataMember(Name="accSagittalSharp11LUp")]
        public BoundingBox AccSagittalSharp11LUp { get; set; }

        [DataMember(Name="accSagittalSharp11MUp")]
        public BoundingBox AccSagittalSharp11MUp { get; set; }

        [DataMember(Name="accSagittalSharp11v19LUp")]
        public BoundingBox AccSagittalSharp11V19LUp { get; set; }

        [DataMember(Name="accSagittalSharp11v19MUp")]
        public BoundingBox AccSagittalSharp11V19MUp { get; set; }

        [DataMember(Name="accSagittalSharp11v49CDown")]
        public BoundingBox AccSagittalSharp11V49CDown { get; set; }

        [DataMember(Name="accSagittalSharp11v49CUp")]
        public BoundingBox AccSagittalSharp11V49CUp { get; set; }

        [DataMember(Name="accSagittalSharp143CDown")]
        public BoundingBox AccSagittalSharp143CDown { get; set; }

        [DataMember(Name="accSagittalSharp143CUp")]
        public BoundingBox AccSagittalSharp143CUp { get; set; }

        [DataMember(Name="accSagittalSharp17CDown")]
        public BoundingBox AccSagittalSharp17CDown { get; set; }

        [DataMember(Name="accSagittalSharp17CUp")]
        public BoundingBox AccSagittalSharp17CUp { get; set; }

        [DataMember(Name="accSagittalSharp17kDown")]
        public BoundingBox AccSagittalSharp17KDown { get; set; }

        [DataMember(Name="accSagittalSharp17kUp")]
        public BoundingBox AccSagittalSharp17KUp { get; set; }

        [DataMember(Name="accSagittalSharp19CDown")]
        public BoundingBox AccSagittalSharp19CDown { get; set; }

        [DataMember(Name="accSagittalSharp19CUp")]
        public BoundingBox AccSagittalSharp19CUp { get; set; }

        [DataMember(Name="accSagittalSharp19sDown")]
        public BoundingBox AccSagittalSharp19SDown { get; set; }

        [DataMember(Name="accSagittalSharp19sUp")]
        public BoundingBox AccSagittalSharp19SUp { get; set; }

        [DataMember(Name="accSagittalSharp23CDown")]
        public BoundingBox AccSagittalSharp23CDown { get; set; }

        [DataMember(Name="accSagittalSharp23CUp")]
        public BoundingBox AccSagittalSharp23CUp { get; set; }

        [DataMember(Name="accSagittalSharp23SDown")]
        public BoundingBox AccSagittalSharp23SDown { get; set; }

        [DataMember(Name="accSagittalSharp23SUp")]
        public BoundingBox AccSagittalSharp23SUp { get; set; }

        [DataMember(Name="accSagittalSharp25SDown")]
        public BoundingBox AccSagittalSharp25SDown { get; set; }

        [DataMember(Name="accSagittalSharp25SUp")]
        public BoundingBox AccSagittalSharp25SUp { get; set; }

        [DataMember(Name="accSagittalSharp35LUp")]
        public BoundingBox AccSagittalSharp35LUp { get; set; }

        [DataMember(Name="accSagittalSharp35MUp")]
        public BoundingBox AccSagittalSharp35MUp { get; set; }

        [DataMember(Name="accSagittalSharp49LUp")]
        public BoundingBox AccSagittalSharp49LUp { get; set; }

        [DataMember(Name="accSagittalSharp49MUp")]
        public BoundingBox AccSagittalSharp49MUp { get; set; }

        [DataMember(Name="accSagittalSharp49SDown")]
        public BoundingBox AccSagittalSharp49SDown { get; set; }

        [DataMember(Name="accSagittalSharp49SUp")]
        public BoundingBox AccSagittalSharp49SUp { get; set; }

        [DataMember(Name="accSagittalSharp55CDown")]
        public BoundingBox AccSagittalSharp55CDown { get; set; }

        [DataMember(Name="accSagittalSharp55CUp")]
        public BoundingBox AccSagittalSharp55CUp { get; set; }

        [DataMember(Name="accSagittalSharp5CDown")]
        public BoundingBox AccSagittalSharp5CDown { get; set; }

        [DataMember(Name="accSagittalSharp5CUp")]
        public BoundingBox AccSagittalSharp5CUp { get; set; }

        [DataMember(Name="accSagittalSharp5v11SDown")]
        public BoundingBox AccSagittalSharp5V11SDown { get; set; }

        [DataMember(Name="accSagittalSharp5v11SUp")]
        public BoundingBox AccSagittalSharp5V11SUp { get; set; }

        [DataMember(Name="accSagittalSharp5v13LUp")]
        public BoundingBox AccSagittalSharp5V13LUp { get; set; }

        [DataMember(Name="accSagittalSharp5v13MUp")]
        public BoundingBox AccSagittalSharp5V13MUp { get; set; }

        [DataMember(Name="accSagittalSharp5v19CDown")]
        public BoundingBox AccSagittalSharp5V19CDown { get; set; }

        [DataMember(Name="accSagittalSharp5v19CUp")]
        public BoundingBox AccSagittalSharp5V19CUp { get; set; }

        [DataMember(Name="accSagittalSharp5v23SDown")]
        public BoundingBox AccSagittalSharp5V23SDown { get; set; }

        [DataMember(Name="accSagittalSharp5v23SUp")]
        public BoundingBox AccSagittalSharp5V23SUp { get; set; }

        [DataMember(Name="accSagittalSharp5v49MUp")]
        public BoundingBox AccSagittalSharp5V49MUp { get; set; }

        [DataMember(Name="accSagittalSharp5v7kDown")]
        public BoundingBox AccSagittalSharp5V7KDown { get; set; }

        [DataMember(Name="accSagittalSharp5v7kUp")]
        public BoundingBox AccSagittalSharp5V7KUp { get; set; }

        [DataMember(Name="accSagittalSharp7CDown")]
        public BoundingBox AccSagittalSharp7CDown { get; set; }

        [DataMember(Name="accSagittalSharp7CUp")]
        public BoundingBox AccSagittalSharp7CUp { get; set; }

        [DataMember(Name="accSagittalSharp7v11CDown")]
        public BoundingBox AccSagittalSharp7V11CDown { get; set; }

        [DataMember(Name="accSagittalSharp7v11CUp")]
        public BoundingBox AccSagittalSharp7V11CUp { get; set; }

        [DataMember(Name="accSagittalSharp7v11kDown")]
        public BoundingBox AccSagittalSharp7V11KDown { get; set; }

        [DataMember(Name="accSagittalSharp7v11kUp")]
        public BoundingBox AccSagittalSharp7V11KUp { get; set; }

        [DataMember(Name="accSagittalSharp7v19CDown")]
        public BoundingBox AccSagittalSharp7V19CDown { get; set; }

        [DataMember(Name="accSagittalSharp7v19CUp")]
        public BoundingBox AccSagittalSharp7V19CUp { get; set; }

        [DataMember(Name="accdnCombDot")]
        public BoundingBox AccdnCombDot { get; set; }

        [DataMember(Name="accdnCombLH2RanksEmpty")]
        public BoundingBox AccdnCombLh2RanksEmpty { get; set; }

        [DataMember(Name="accdnCombLH3RanksEmptySquare")]
        public BoundingBox AccdnCombLh3RanksEmptySquare { get; set; }

        [DataMember(Name="accdnCombRH3RanksEmpty")]
        public BoundingBox AccdnCombRh3RanksEmpty { get; set; }

        [DataMember(Name="accdnCombRH4RanksEmpty")]
        public BoundingBox AccdnCombRh4RanksEmpty { get; set; }

        [DataMember(Name="accdnDiatonicClef")]
        public BoundingBox AccdnDiatonicClef { get; set; }

        [DataMember(Name="accdnLH2Ranks16Round")]
        public BoundingBox AccdnLh2Ranks16Round { get; set; }

        [DataMember(Name="accdnLH2Ranks8Plus16Round")]
        public BoundingBox AccdnLh2Ranks8Plus16Round { get; set; }

        [DataMember(Name="accdnLH2Ranks8Round")]
        public BoundingBox AccdnLh2Ranks8Round { get; set; }

        [DataMember(Name="accdnLH2RanksFullMasterRound")]
        public BoundingBox AccdnLh2RanksFullMasterRound { get; set; }

        [DataMember(Name="accdnLH2RanksMasterPlus16Round")]
        public BoundingBox AccdnLh2RanksMasterPlus16Round { get; set; }

        [DataMember(Name="accdnLH2RanksMasterRound")]
        public BoundingBox AccdnLh2RanksMasterRound { get; set; }

        [DataMember(Name="accdnLH3Ranks2Plus8Square")]
        public BoundingBox AccdnLh3Ranks2Plus8Square { get; set; }

        [DataMember(Name="accdnLH3Ranks2Square")]
        public BoundingBox AccdnLh3Ranks2Square { get; set; }

        [DataMember(Name="accdnLH3Ranks8Square")]
        public BoundingBox AccdnLh3Ranks8Square { get; set; }

        [DataMember(Name="accdnLH3RanksDouble8Square")]
        public BoundingBox AccdnLh3RanksDouble8Square { get; set; }

        [DataMember(Name="accdnLH3RanksTuttiSquare")]
        public BoundingBox AccdnLh3RanksTuttiSquare { get; set; }

        [DataMember(Name="accdnPull")]
        public BoundingBox AccdnPull { get; set; }

        [DataMember(Name="accdnPush")]
        public BoundingBox AccdnPush { get; set; }

        [DataMember(Name="accdnPushAlt")]
        public BoundingBox AccdnPushAlt { get; set; }

        [DataMember(Name="accdnRH3RanksAccordion")]
        public BoundingBox AccdnRh3RanksAccordion { get; set; }

        [DataMember(Name="accdnRH3RanksAuthenticMusette")]
        public BoundingBox AccdnRh3RanksAuthenticMusette { get; set; }

        [DataMember(Name="accdnRH3RanksBandoneon")]
        public BoundingBox AccdnRh3RanksBandoneon { get; set; }

        [DataMember(Name="accdnRH3RanksBassoon")]
        public BoundingBox AccdnRh3RanksBassoon { get; set; }

        [DataMember(Name="accdnRH3RanksClarinet")]
        public BoundingBox AccdnRh3RanksClarinet { get; set; }

        [DataMember(Name="accdnRH3RanksDoubleTremoloLower8ve")]
        public BoundingBox AccdnRh3RanksDoubleTremoloLower8Ve { get; set; }

        [DataMember(Name="accdnRH3RanksDoubleTremoloUpper8ve")]
        public BoundingBox AccdnRh3RanksDoubleTremoloUpper8Ve { get; set; }

        [DataMember(Name="accdnRH3RanksFullFactory")]
        public BoundingBox AccdnRh3RanksFullFactory { get; set; }

        [DataMember(Name="accdnRH3RanksHarmonium")]
        public BoundingBox AccdnRh3RanksHarmonium { get; set; }

        [DataMember(Name="accdnRH3RanksImitationMusette")]
        public BoundingBox AccdnRh3RanksImitationMusette { get; set; }

        [DataMember(Name="accdnRH3RanksLowerTremolo8")]
        public BoundingBox AccdnRh3RanksLowerTremolo8 { get; set; }

        [DataMember(Name="accdnRH3RanksMaster")]
        public BoundingBox AccdnRh3RanksMaster { get; set; }

        [DataMember(Name="accdnRH3RanksOboe")]
        public BoundingBox AccdnRh3RanksOboe { get; set; }

        [DataMember(Name="accdnRH3RanksOrgan")]
        public BoundingBox AccdnRh3RanksOrgan { get; set; }

        [DataMember(Name="accdnRH3RanksPiccolo")]
        public BoundingBox AccdnRh3RanksPiccolo { get; set; }

        [DataMember(Name="accdnRH3RanksTremoloLower8ve")]
        public BoundingBox AccdnRh3RanksTremoloLower8Ve { get; set; }

        [DataMember(Name="accdnRH3RanksTremoloUpper8ve")]
        public BoundingBox AccdnRh3RanksTremoloUpper8Ve { get; set; }

        [DataMember(Name="accdnRH3RanksTwoChoirs")]
        public BoundingBox AccdnRh3RanksTwoChoirs { get; set; }

        [DataMember(Name="accdnRH3RanksUpperTremolo8")]
        public BoundingBox AccdnRh3RanksUpperTremolo8 { get; set; }

        [DataMember(Name="accdnRH3RanksViolin")]
        public BoundingBox AccdnRh3RanksViolin { get; set; }

        [DataMember(Name="accdnRH4RanksAlto")]
        public BoundingBox AccdnRh4RanksAlto { get; set; }

        [DataMember(Name="accdnRH4RanksBassAlto")]
        public BoundingBox AccdnRh4RanksBassAlto { get; set; }

        [DataMember(Name="accdnRH4RanksMaster")]
        public BoundingBox AccdnRh4RanksMaster { get; set; }

        [DataMember(Name="accdnRH4RanksSoftBass")]
        public BoundingBox AccdnRh4RanksSoftBass { get; set; }

        [DataMember(Name="accdnRH4RanksSoftTenor")]
        public BoundingBox AccdnRh4RanksSoftTenor { get; set; }

        [DataMember(Name="accdnRH4RanksSoprano")]
        public BoundingBox AccdnRh4RanksSoprano { get; set; }

        [DataMember(Name="accdnRH4RanksTenor")]
        public BoundingBox AccdnRh4RanksTenor { get; set; }

        [DataMember(Name="accdnRicochet2")]
        public BoundingBox AccdnRicochet2 { get; set; }

        [DataMember(Name="accdnRicochet3")]
        public BoundingBox AccdnRicochet3 { get; set; }

        [DataMember(Name="accdnRicochet4")]
        public BoundingBox AccdnRicochet4 { get; set; }

        [DataMember(Name="accdnRicochet5")]
        public BoundingBox AccdnRicochet5 { get; set; }

        [DataMember(Name="accdnRicochet6")]
        public BoundingBox AccdnRicochet6 { get; set; }

        [DataMember(Name="accdnRicochetStem2")]
        public BoundingBox AccdnRicochetStem2 { get; set; }

        [DataMember(Name="accdnRicochetStem3")]
        public BoundingBox AccdnRicochetStem3 { get; set; }

        [DataMember(Name="accdnRicochetStem4")]
        public BoundingBox AccdnRicochetStem4 { get; set; }

        [DataMember(Name="accdnRicochetStem5")]
        public BoundingBox AccdnRicochetStem5 { get; set; }

        [DataMember(Name="accdnRicochetStem6")]
        public BoundingBox AccdnRicochetStem6 { get; set; }

        [DataMember(Name="accidental1CommaFlat")]
        public BoundingBox Accidental1CommaFlat { get; set; }

        [DataMember(Name="accidental1CommaSharp")]
        public BoundingBox Accidental1CommaSharp { get; set; }

        [DataMember(Name="accidental2CommaFlat")]
        public BoundingBox Accidental2CommaFlat { get; set; }

        [DataMember(Name="accidental2CommaSharp")]
        public BoundingBox Accidental2CommaSharp { get; set; }

        [DataMember(Name="accidental3CommaFlat")]
        public BoundingBox Accidental3CommaFlat { get; set; }

        [DataMember(Name="accidental3CommaSharp")]
        public BoundingBox Accidental3CommaSharp { get; set; }

        [DataMember(Name="accidental4CommaFlat")]
        public BoundingBox Accidental4CommaFlat { get; set; }

        [DataMember(Name="accidental5CommaSharp")]
        public BoundingBox Accidental5CommaSharp { get; set; }

        [DataMember(Name="accidentalArrowDown")]
        public BoundingBox AccidentalArrowDown { get; set; }

        [DataMember(Name="accidentalArrowUp")]
        public BoundingBox AccidentalArrowUp { get; set; }

        [DataMember(Name="accidentalBakiyeFlat")]
        public BoundingBox AccidentalBakiyeFlat { get; set; }

        [DataMember(Name="accidentalBakiyeSharp")]
        public BoundingBox AccidentalBakiyeSharp { get; set; }

        [DataMember(Name="accidentalBracketLeft")]
        public BoundingBox AccidentalBracketLeft { get; set; }

        [DataMember(Name="accidentalBracketRight")]
        public BoundingBox AccidentalBracketRight { get; set; }

        [DataMember(Name="accidentalBuyukMucennebFlat")]
        public BoundingBox AccidentalBuyukMucennebFlat { get; set; }

        [DataMember(Name="accidentalBuyukMucennebSharp")]
        public BoundingBox AccidentalBuyukMucennebSharp { get; set; }

        [DataMember(Name="accidentalCombiningCloseCurlyBrace")]
        public BoundingBox AccidentalCombiningCloseCurlyBrace { get; set; }

        [DataMember(Name="accidentalCombiningLower17Schisma")]
        public BoundingBox AccidentalCombiningLower17Schisma { get; set; }

        [DataMember(Name="accidentalCombiningLower19Schisma")]
        public BoundingBox AccidentalCombiningLower19Schisma { get; set; }

        [DataMember(Name="accidentalCombiningLower23Limit29LimitComma")]
        public BoundingBox AccidentalCombiningLower23Limit29LimitComma { get; set; }

        [DataMember(Name="accidentalCombiningLower31Schisma")]
        public BoundingBox AccidentalCombiningLower31Schisma { get; set; }

        [DataMember(Name="accidentalCombiningLower53LimitComma")]
        public BoundingBox AccidentalCombiningLower53LimitComma { get; set; }

        [DataMember(Name="accidentalCombiningOpenCurlyBrace")]
        public BoundingBox AccidentalCombiningOpenCurlyBrace { get; set; }

        [DataMember(Name="accidentalCombiningRaise17Schisma")]
        public BoundingBox AccidentalCombiningRaise17Schisma { get; set; }

        [DataMember(Name="accidentalCombiningRaise19Schisma")]
        public BoundingBox AccidentalCombiningRaise19Schisma { get; set; }

        [DataMember(Name="accidentalCombiningRaise23Limit29LimitComma")]
        public BoundingBox AccidentalCombiningRaise23Limit29LimitComma { get; set; }

        [DataMember(Name="accidentalCombiningRaise31Schisma")]
        public BoundingBox AccidentalCombiningRaise31Schisma { get; set; }

        [DataMember(Name="accidentalCombiningRaise53LimitComma")]
        public BoundingBox AccidentalCombiningRaise53LimitComma { get; set; }

        [DataMember(Name="accidentalCommaSlashDown")]
        public BoundingBox AccidentalCommaSlashDown { get; set; }

        [DataMember(Name="accidentalCommaSlashUp")]
        public BoundingBox AccidentalCommaSlashUp { get; set; }

        [DataMember(Name="accidentalDoubleFlat")]
        public BoundingBox AccidentalDoubleFlat { get; set; }

        [DataMember(Name="accidentalDoubleFlatArabic")]
        public BoundingBox AccidentalDoubleFlatArabic { get; set; }

        [DataMember(Name="accidentalDoubleFlatEqualTempered")]
        public BoundingBox AccidentalDoubleFlatEqualTempered { get; set; }

        [DataMember(Name="accidentalDoubleFlatJoinedStems")]
        public BoundingBox AccidentalDoubleFlatJoinedStems { get; set; }

        [DataMember(Name="accidentalDoubleFlatOneArrowDown")]
        public BoundingBox AccidentalDoubleFlatOneArrowDown { get; set; }

        [DataMember(Name="accidentalDoubleFlatOneArrowUp")]
        public BoundingBox AccidentalDoubleFlatOneArrowUp { get; set; }

        [DataMember(Name="accidentalDoubleFlatParens")]
        public BoundingBox AccidentalDoubleFlatParens { get; set; }

        [DataMember(Name="accidentalDoubleFlatReversed")]
        public BoundingBox AccidentalDoubleFlatReversed { get; set; }

        [DataMember(Name="accidentalDoubleFlatThreeArrowsDown")]
        public BoundingBox AccidentalDoubleFlatThreeArrowsDown { get; set; }

        [DataMember(Name="accidentalDoubleFlatThreeArrowsUp")]
        public BoundingBox AccidentalDoubleFlatThreeArrowsUp { get; set; }

        [DataMember(Name="accidentalDoubleFlatTurned")]
        public BoundingBox AccidentalDoubleFlatTurned { get; set; }

        [DataMember(Name="accidentalDoubleFlatTwoArrowsDown")]
        public BoundingBox AccidentalDoubleFlatTwoArrowsDown { get; set; }

        [DataMember(Name="accidentalDoubleFlatTwoArrowsUp")]
        public BoundingBox AccidentalDoubleFlatTwoArrowsUp { get; set; }

        [DataMember(Name="accidentalDoubleSharp")]
        public BoundingBox AccidentalDoubleSharp { get; set; }

        [DataMember(Name="accidentalDoubleSharpArabic")]
        public BoundingBox AccidentalDoubleSharpArabic { get; set; }

        [DataMember(Name="accidentalDoubleSharpEqualTempered")]
        public BoundingBox AccidentalDoubleSharpEqualTempered { get; set; }

        [DataMember(Name="accidentalDoubleSharpOneArrowDown")]
        public BoundingBox AccidentalDoubleSharpOneArrowDown { get; set; }

        [DataMember(Name="accidentalDoubleSharpOneArrowUp")]
        public BoundingBox AccidentalDoubleSharpOneArrowUp { get; set; }

        [DataMember(Name="accidentalDoubleSharpParens")]
        public BoundingBox AccidentalDoubleSharpParens { get; set; }

        [DataMember(Name="accidentalDoubleSharpThreeArrowsDown")]
        public BoundingBox AccidentalDoubleSharpThreeArrowsDown { get; set; }

        [DataMember(Name="accidentalDoubleSharpThreeArrowsUp")]
        public BoundingBox AccidentalDoubleSharpThreeArrowsUp { get; set; }

        [DataMember(Name="accidentalDoubleSharpTwoArrowsDown")]
        public BoundingBox AccidentalDoubleSharpTwoArrowsDown { get; set; }

        [DataMember(Name="accidentalDoubleSharpTwoArrowsUp")]
        public BoundingBox AccidentalDoubleSharpTwoArrowsUp { get; set; }

        [DataMember(Name="accidentalEnharmonicAlmostEqualTo")]
        public BoundingBox AccidentalEnharmonicAlmostEqualTo { get; set; }

        [DataMember(Name="accidentalEnharmonicEquals")]
        public BoundingBox AccidentalEnharmonicEquals { get; set; }

        [DataMember(Name="accidentalEnharmonicTilde")]
        public BoundingBox AccidentalEnharmonicTilde { get; set; }

        [DataMember(Name="accidentalFilledReversedFlatAndFlat")]
        public BoundingBox AccidentalFilledReversedFlatAndFlat { get; set; }

        [DataMember(Name="accidentalFilledReversedFlatAndFlatArrowDown")]
        public BoundingBox AccidentalFilledReversedFlatAndFlatArrowDown { get; set; }

        [DataMember(Name="accidentalFilledReversedFlatAndFlatArrowUp")]
        public BoundingBox AccidentalFilledReversedFlatAndFlatArrowUp { get; set; }

        [DataMember(Name="accidentalFilledReversedFlatArrowDown")]
        public BoundingBox AccidentalFilledReversedFlatArrowDown { get; set; }

        [DataMember(Name="accidentalFilledReversedFlatArrowUp")]
        public BoundingBox AccidentalFilledReversedFlatArrowUp { get; set; }

        [DataMember(Name="accidentalFiveQuarterTonesFlatArrowDown")]
        public BoundingBox AccidentalFiveQuarterTonesFlatArrowDown { get; set; }

        [DataMember(Name="accidentalFiveQuarterTonesSharpArrowUp")]
        public BoundingBox AccidentalFiveQuarterTonesSharpArrowUp { get; set; }

        [DataMember(Name="accidentalFlat")]
        public BoundingBox AccidentalFlat { get; set; }

        [DataMember(Name="accidentalFlatArabic")]
        public BoundingBox AccidentalFlatArabic { get; set; }

        [DataMember(Name="accidentalFlatEqualTempered")]
        public BoundingBox AccidentalFlatEqualTempered { get; set; }

        [DataMember(Name="accidentalFlatJohnstonDown")]
        public BoundingBox AccidentalFlatJohnstonDown { get; set; }

        [DataMember(Name="accidentalFlatJohnstonEl")]
        public BoundingBox AccidentalFlatJohnstonEl { get; set; }

        [DataMember(Name="accidentalFlatJohnstonElDown")]
        public BoundingBox AccidentalFlatJohnstonElDown { get; set; }

        [DataMember(Name="accidentalFlatJohnstonUp")]
        public BoundingBox AccidentalFlatJohnstonUp { get; set; }

        [DataMember(Name="accidentalFlatJohnstonUpEl")]
        public BoundingBox AccidentalFlatJohnstonUpEl { get; set; }

        [DataMember(Name="accidentalFlatLoweredStockhausen")]
        public BoundingBox AccidentalFlatLoweredStockhausen { get; set; }

        [DataMember(Name="accidentalFlatOneArrowDown")]
        public BoundingBox AccidentalFlatOneArrowDown { get; set; }

        [DataMember(Name="accidentalFlatOneArrowUp")]
        public BoundingBox AccidentalFlatOneArrowUp { get; set; }

        [DataMember(Name="accidentalFlatParens")]
        public BoundingBox AccidentalFlatParens { get; set; }

        [DataMember(Name="accidentalFlatRaisedStockhausen")]
        public BoundingBox AccidentalFlatRaisedStockhausen { get; set; }

        [DataMember(Name="accidentalFlatRepeatedLineStockhausen")]
        public BoundingBox AccidentalFlatRepeatedLineStockhausen { get; set; }

        [DataMember(Name="accidentalFlatRepeatedSpaceStockhausen")]
        public BoundingBox AccidentalFlatRepeatedSpaceStockhausen { get; set; }

        [DataMember(Name="accidentalFlatSmall")]
        public BoundingBox AccidentalFlatSmall { get; set; }

        [DataMember(Name="accidentalFlatThreeArrowsDown")]
        public BoundingBox AccidentalFlatThreeArrowsDown { get; set; }

        [DataMember(Name="accidentalFlatThreeArrowsUp")]
        public BoundingBox AccidentalFlatThreeArrowsUp { get; set; }

        [DataMember(Name="accidentalFlatTurned")]
        public BoundingBox AccidentalFlatTurned { get; set; }

        [DataMember(Name="accidentalFlatTwoArrowsDown")]
        public BoundingBox AccidentalFlatTwoArrowsDown { get; set; }

        [DataMember(Name="accidentalFlatTwoArrowsUp")]
        public BoundingBox AccidentalFlatTwoArrowsUp { get; set; }

        [DataMember(Name="accidentalHalfSharpArrowDown")]
        public BoundingBox AccidentalHalfSharpArrowDown { get; set; }

        [DataMember(Name="accidentalHalfSharpArrowUp")]
        public BoundingBox AccidentalHalfSharpArrowUp { get; set; }

        [DataMember(Name="accidentalJohnston13")]
        public BoundingBox AccidentalJohnston13 { get; set; }

        [DataMember(Name="accidentalJohnston31")]
        public BoundingBox AccidentalJohnston31 { get; set; }

        [DataMember(Name="accidentalJohnstonDown")]
        public BoundingBox AccidentalJohnstonDown { get; set; }

        [DataMember(Name="accidentalJohnstonDownEl")]
        public BoundingBox AccidentalJohnstonDownEl { get; set; }

        [DataMember(Name="accidentalJohnstonEl")]
        public BoundingBox AccidentalJohnstonEl { get; set; }

        [DataMember(Name="accidentalJohnstonMinus")]
        public BoundingBox AccidentalJohnstonMinus { get; set; }

        [DataMember(Name="accidentalJohnstonPlus")]
        public BoundingBox AccidentalJohnstonPlus { get; set; }

        [DataMember(Name="accidentalJohnstonSeven")]
        public BoundingBox AccidentalJohnstonSeven { get; set; }

        [DataMember(Name="accidentalJohnstonSevenDown")]
        public BoundingBox AccidentalJohnstonSevenDown { get; set; }

        [DataMember(Name="accidentalJohnstonSevenFlat")]
        public BoundingBox AccidentalJohnstonSevenFlat { get; set; }

        [DataMember(Name="accidentalJohnstonSevenFlatDown")]
        public BoundingBox AccidentalJohnstonSevenFlatDown { get; set; }

        [DataMember(Name="accidentalJohnstonSevenFlatUp")]
        public BoundingBox AccidentalJohnstonSevenFlatUp { get; set; }

        [DataMember(Name="accidentalJohnstonSevenSharp")]
        public BoundingBox AccidentalJohnstonSevenSharp { get; set; }

        [DataMember(Name="accidentalJohnstonSevenSharpDown")]
        public BoundingBox AccidentalJohnstonSevenSharpDown { get; set; }

        [DataMember(Name="accidentalJohnstonSevenSharpUp")]
        public BoundingBox AccidentalJohnstonSevenSharpUp { get; set; }

        [DataMember(Name="accidentalJohnstonSevenUp")]
        public BoundingBox AccidentalJohnstonSevenUp { get; set; }

        [DataMember(Name="accidentalJohnstonUp")]
        public BoundingBox AccidentalJohnstonUp { get; set; }

        [DataMember(Name="accidentalJohnstonUpEl")]
        public BoundingBox AccidentalJohnstonUpEl { get; set; }

        [DataMember(Name="accidentalKomaFlat")]
        public BoundingBox AccidentalKomaFlat { get; set; }

        [DataMember(Name="accidentalKomaSharp")]
        public BoundingBox AccidentalKomaSharp { get; set; }

        [DataMember(Name="accidentalKoron")]
        public BoundingBox AccidentalKoron { get; set; }

        [DataMember(Name="accidentalKucukMucennebFlat")]
        public BoundingBox AccidentalKucukMucennebFlat { get; set; }

        [DataMember(Name="accidentalKucukMucennebSharp")]
        public BoundingBox AccidentalKucukMucennebSharp { get; set; }

        [DataMember(Name="accidentalLargeDoubleSharp")]
        public BoundingBox AccidentalLargeDoubleSharp { get; set; }

        [DataMember(Name="accidentalLowerOneSeptimalComma")]
        public BoundingBox AccidentalLowerOneSeptimalComma { get; set; }

        [DataMember(Name="accidentalLowerOneTridecimalQuartertone")]
        public BoundingBox AccidentalLowerOneTridecimalQuartertone { get; set; }

        [DataMember(Name="accidentalLowerOneUndecimalQuartertone")]
        public BoundingBox AccidentalLowerOneUndecimalQuartertone { get; set; }

        [DataMember(Name="accidentalLowerTwoSeptimalCommas")]
        public BoundingBox AccidentalLowerTwoSeptimalCommas { get; set; }

        [DataMember(Name="accidentalLoweredStockhausen")]
        public BoundingBox AccidentalLoweredStockhausen { get; set; }

        [DataMember(Name="accidentalNarrowReversedFlat")]
        public BoundingBox AccidentalNarrowReversedFlat { get; set; }

        [DataMember(Name="accidentalNarrowReversedFlatAndFlat")]
        public BoundingBox AccidentalNarrowReversedFlatAndFlat { get; set; }

        [DataMember(Name="accidentalNatural")]
        public BoundingBox AccidentalNatural { get; set; }

        [DataMember(Name="accidentalNaturalArabic")]
        public BoundingBox AccidentalNaturalArabic { get; set; }

        [DataMember(Name="accidentalNaturalEqualTempered")]
        public BoundingBox AccidentalNaturalEqualTempered { get; set; }

        [DataMember(Name="accidentalNaturalFlat")]
        public BoundingBox AccidentalNaturalFlat { get; set; }

        [DataMember(Name="accidentalNaturalLoweredStockhausen")]
        public BoundingBox AccidentalNaturalLoweredStockhausen { get; set; }

        [DataMember(Name="accidentalNaturalOneArrowDown")]
        public BoundingBox AccidentalNaturalOneArrowDown { get; set; }

        [DataMember(Name="accidentalNaturalOneArrowUp")]
        public BoundingBox AccidentalNaturalOneArrowUp { get; set; }

        [DataMember(Name="accidentalNaturalParens")]
        public BoundingBox AccidentalNaturalParens { get; set; }

        [DataMember(Name="accidentalNaturalRaisedStockhausen")]
        public BoundingBox AccidentalNaturalRaisedStockhausen { get; set; }

        [DataMember(Name="accidentalNaturalReversed")]
        public BoundingBox AccidentalNaturalReversed { get; set; }

        [DataMember(Name="accidentalNaturalSharp")]
        public BoundingBox AccidentalNaturalSharp { get; set; }

        [DataMember(Name="accidentalNaturalSmall")]
        public BoundingBox AccidentalNaturalSmall { get; set; }

        [DataMember(Name="accidentalNaturalThreeArrowsDown")]
        public BoundingBox AccidentalNaturalThreeArrowsDown { get; set; }

        [DataMember(Name="accidentalNaturalThreeArrowsUp")]
        public BoundingBox AccidentalNaturalThreeArrowsUp { get; set; }

        [DataMember(Name="accidentalNaturalTwoArrowsDown")]
        public BoundingBox AccidentalNaturalTwoArrowsDown { get; set; }

        [DataMember(Name="accidentalNaturalTwoArrowsUp")]
        public BoundingBox AccidentalNaturalTwoArrowsUp { get; set; }

        [DataMember(Name="accidentalOneAndAHalfSharpsArrowDown")]
        public BoundingBox AccidentalOneAndAHalfSharpsArrowDown { get; set; }

        [DataMember(Name="accidentalOneAndAHalfSharpsArrowUp")]
        public BoundingBox AccidentalOneAndAHalfSharpsArrowUp { get; set; }

        [DataMember(Name="accidentalOneQuarterToneFlatFerneyhough")]
        public BoundingBox AccidentalOneQuarterToneFlatFerneyhough { get; set; }

        [DataMember(Name="accidentalOneQuarterToneFlatStockhausen")]
        public BoundingBox AccidentalOneQuarterToneFlatStockhausen { get; set; }

        [DataMember(Name="accidentalOneQuarterToneSharpFerneyhough")]
        public BoundingBox AccidentalOneQuarterToneSharpFerneyhough { get; set; }

        [DataMember(Name="accidentalOneQuarterToneSharpStockhausen")]
        public BoundingBox AccidentalOneQuarterToneSharpStockhausen { get; set; }

        [DataMember(Name="accidentalOneThirdToneFlatFerneyhough")]
        public BoundingBox AccidentalOneThirdToneFlatFerneyhough { get; set; }

        [DataMember(Name="accidentalOneThirdToneSharpFerneyhough")]
        public BoundingBox AccidentalOneThirdToneSharpFerneyhough { get; set; }

        [DataMember(Name="accidentalParensLeft")]
        public BoundingBox AccidentalParensLeft { get; set; }

        [DataMember(Name="accidentalParensRight")]
        public BoundingBox AccidentalParensRight { get; set; }

        [DataMember(Name="accidentalQuarterFlatEqualTempered")]
        public BoundingBox AccidentalQuarterFlatEqualTempered { get; set; }

        [DataMember(Name="accidentalQuarterSharpEqualTempered")]
        public BoundingBox AccidentalQuarterSharpEqualTempered { get; set; }

        [DataMember(Name="accidentalQuarterToneFlat4")]
        public BoundingBox AccidentalQuarterToneFlat4 { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatArabic")]
        public BoundingBox AccidentalQuarterToneFlatArabic { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatArrowUp")]
        public BoundingBox AccidentalQuarterToneFlatArrowUp { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatFilledReversed")]
        public BoundingBox AccidentalQuarterToneFlatFilledReversed { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatNaturalArrowDown")]
        public BoundingBox AccidentalQuarterToneFlatNaturalArrowDown { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatPenderecki")]
        public BoundingBox AccidentalQuarterToneFlatPenderecki { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatStein")]
        public BoundingBox AccidentalQuarterToneFlatStein { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatVanBlankenburg")]
        public BoundingBox AccidentalQuarterToneFlatVanBlankenburg { get; set; }

        [DataMember(Name="accidentalQuarterToneSharp4")]
        public BoundingBox AccidentalQuarterToneSharp4 { get; set; }

        [DataMember(Name="accidentalQuarterToneSharpArabic")]
        public BoundingBox AccidentalQuarterToneSharpArabic { get; set; }

        [DataMember(Name="accidentalQuarterToneSharpArrowDown")]
        public BoundingBox AccidentalQuarterToneSharpArrowDown { get; set; }

        [DataMember(Name="accidentalQuarterToneSharpBusotti")]
        public BoundingBox AccidentalQuarterToneSharpBusotti { get; set; }

        [DataMember(Name="accidentalQuarterToneSharpNaturalArrowUp")]
        public BoundingBox AccidentalQuarterToneSharpNaturalArrowUp { get; set; }

        [DataMember(Name="accidentalQuarterToneSharpStein")]
        public BoundingBox AccidentalQuarterToneSharpStein { get; set; }

        [DataMember(Name="accidentalQuarterToneSharpWiggle")]
        public BoundingBox AccidentalQuarterToneSharpWiggle { get; set; }

        [DataMember(Name="accidentalRaiseOneSeptimalComma")]
        public BoundingBox AccidentalRaiseOneSeptimalComma { get; set; }

        [DataMember(Name="accidentalRaiseOneTridecimalQuartertone")]
        public BoundingBox AccidentalRaiseOneTridecimalQuartertone { get; set; }

        [DataMember(Name="accidentalRaiseOneUndecimalQuartertone")]
        public BoundingBox AccidentalRaiseOneUndecimalQuartertone { get; set; }

        [DataMember(Name="accidentalRaiseTwoSeptimalCommas")]
        public BoundingBox AccidentalRaiseTwoSeptimalCommas { get; set; }

        [DataMember(Name="accidentalRaisedStockhausen")]
        public BoundingBox AccidentalRaisedStockhausen { get; set; }

        [DataMember(Name="accidentalReversedFlatAndFlatArrowDown")]
        public BoundingBox AccidentalReversedFlatAndFlatArrowDown { get; set; }

        [DataMember(Name="accidentalReversedFlatAndFlatArrowUp")]
        public BoundingBox AccidentalReversedFlatAndFlatArrowUp { get; set; }

        [DataMember(Name="accidentalReversedFlatArrowDown")]
        public BoundingBox AccidentalReversedFlatArrowDown { get; set; }

        [DataMember(Name="accidentalReversedFlatArrowUp")]
        public BoundingBox AccidentalReversedFlatArrowUp { get; set; }

        [DataMember(Name="accidentalSharp")]
        public BoundingBox AccidentalSharp { get; set; }

        [DataMember(Name="accidentalSharpArabic")]
        public BoundingBox AccidentalSharpArabic { get; set; }

        [DataMember(Name="accidentalSharpEqualTempered")]
        public BoundingBox AccidentalSharpEqualTempered { get; set; }

        [DataMember(Name="accidentalSharpJohnstonDown")]
        public BoundingBox AccidentalSharpJohnstonDown { get; set; }

        [DataMember(Name="accidentalSharpJohnstonDownEl")]
        public BoundingBox AccidentalSharpJohnstonDownEl { get; set; }

        [DataMember(Name="accidentalSharpJohnstonEl")]
        public BoundingBox AccidentalSharpJohnstonEl { get; set; }

        [DataMember(Name="accidentalSharpJohnstonUp")]
        public BoundingBox AccidentalSharpJohnstonUp { get; set; }

        [DataMember(Name="accidentalSharpJohnstonUpEl")]
        public BoundingBox AccidentalSharpJohnstonUpEl { get; set; }

        [DataMember(Name="accidentalSharpLoweredStockhausen")]
        public BoundingBox AccidentalSharpLoweredStockhausen { get; set; }

        [DataMember(Name="accidentalSharpOneArrowDown")]
        public BoundingBox AccidentalSharpOneArrowDown { get; set; }

        [DataMember(Name="accidentalSharpOneArrowUp")]
        public BoundingBox AccidentalSharpOneArrowUp { get; set; }

        [DataMember(Name="accidentalSharpOneHorizontalStroke")]
        public BoundingBox AccidentalSharpOneHorizontalStroke { get; set; }

        [DataMember(Name="accidentalSharpParens")]
        public BoundingBox AccidentalSharpParens { get; set; }

        [DataMember(Name="accidentalSharpRaisedStockhausen")]
        public BoundingBox AccidentalSharpRaisedStockhausen { get; set; }

        [DataMember(Name="accidentalSharpRepeatedLineStockhausen")]
        public BoundingBox AccidentalSharpRepeatedLineStockhausen { get; set; }

        [DataMember(Name="accidentalSharpRepeatedSpaceStockhausen")]
        public BoundingBox AccidentalSharpRepeatedSpaceStockhausen { get; set; }

        [DataMember(Name="accidentalSharpReversed")]
        public BoundingBox AccidentalSharpReversed { get; set; }

        [DataMember(Name="accidentalSharpSharp")]
        public BoundingBox AccidentalSharpSharp { get; set; }

        [DataMember(Name="accidentalSharpSmall")]
        public BoundingBox AccidentalSharpSmall { get; set; }

        [DataMember(Name="accidentalSharpThreeArrowsDown")]
        public BoundingBox AccidentalSharpThreeArrowsDown { get; set; }

        [DataMember(Name="accidentalSharpThreeArrowsUp")]
        public BoundingBox AccidentalSharpThreeArrowsUp { get; set; }

        [DataMember(Name="accidentalSharpTwoArrowsDown")]
        public BoundingBox AccidentalSharpTwoArrowsDown { get; set; }

        [DataMember(Name="accidentalSharpTwoArrowsUp")]
        public BoundingBox AccidentalSharpTwoArrowsUp { get; set; }

        [DataMember(Name="accidentalSims12Down")]
        public BoundingBox AccidentalSims12Down { get; set; }

        [DataMember(Name="accidentalSims12Up")]
        public BoundingBox AccidentalSims12Up { get; set; }

        [DataMember(Name="accidentalSims4Down")]
        public BoundingBox AccidentalSims4Down { get; set; }

        [DataMember(Name="accidentalSims4Up")]
        public BoundingBox AccidentalSims4Up { get; set; }

        [DataMember(Name="accidentalSims6Down")]
        public BoundingBox AccidentalSims6Down { get; set; }

        [DataMember(Name="accidentalSims6Up")]
        public BoundingBox AccidentalSims6Up { get; set; }

        [DataMember(Name="accidentalSori")]
        public BoundingBox AccidentalSori { get; set; }

        [DataMember(Name="accidentalTavenerFlat")]
        public BoundingBox AccidentalTavenerFlat { get; set; }

        [DataMember(Name="accidentalTavenerSharp")]
        public BoundingBox AccidentalTavenerSharp { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatArabic")]
        public BoundingBox AccidentalThreeQuarterTonesFlatArabic { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatArrowDown")]
        public BoundingBox AccidentalThreeQuarterTonesFlatArrowDown { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatArrowUp")]
        public BoundingBox AccidentalThreeQuarterTonesFlatArrowUp { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatCouper")]
        public BoundingBox AccidentalThreeQuarterTonesFlatCouper { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatGrisey")]
        public BoundingBox AccidentalThreeQuarterTonesFlatGrisey { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatTartini")]
        public BoundingBox AccidentalThreeQuarterTonesFlatTartini { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatZimmermann")]
        public BoundingBox AccidentalThreeQuarterTonesFlatZimmermann { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesSharpArabic")]
        public BoundingBox AccidentalThreeQuarterTonesSharpArabic { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesSharpArrowDown")]
        public BoundingBox AccidentalThreeQuarterTonesSharpArrowDown { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesSharpArrowUp")]
        public BoundingBox AccidentalThreeQuarterTonesSharpArrowUp { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesSharpBusotti")]
        public BoundingBox AccidentalThreeQuarterTonesSharpBusotti { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesSharpStein")]
        public BoundingBox AccidentalThreeQuarterTonesSharpStein { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesSharpStockhausen")]
        public BoundingBox AccidentalThreeQuarterTonesSharpStockhausen { get; set; }

        [DataMember(Name="accidentalTripleFlat")]
        public BoundingBox AccidentalTripleFlat { get; set; }

        [DataMember(Name="accidentalTripleFlatJoinedStems")]
        public BoundingBox AccidentalTripleFlatJoinedStems { get; set; }

        [DataMember(Name="accidentalTripleSharp")]
        public BoundingBox AccidentalTripleSharp { get; set; }

        [DataMember(Name="accidentalTwoThirdTonesFlatFerneyhough")]
        public BoundingBox AccidentalTwoThirdTonesFlatFerneyhough { get; set; }

        [DataMember(Name="accidentalTwoThirdTonesSharpFerneyhough")]
        public BoundingBox AccidentalTwoThirdTonesSharpFerneyhough { get; set; }

        [DataMember(Name="accidentalWilsonMinus")]
        public BoundingBox AccidentalWilsonMinus { get; set; }

        [DataMember(Name="accidentalWilsonPlus")]
        public BoundingBox AccidentalWilsonPlus { get; set; }

        [DataMember(Name="accidentalWyschnegradsky10TwelfthsFlat")]
        public BoundingBox AccidentalWyschnegradsky10TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky10TwelfthsSharp")]
        public BoundingBox AccidentalWyschnegradsky10TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky11TwelfthsFlat")]
        public BoundingBox AccidentalWyschnegradsky11TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky11TwelfthsSharp")]
        public BoundingBox AccidentalWyschnegradsky11TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky1TwelfthsFlat")]
        public BoundingBox AccidentalWyschnegradsky1TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky1TwelfthsSharp")]
        public BoundingBox AccidentalWyschnegradsky1TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky2TwelfthsFlat")]
        public BoundingBox AccidentalWyschnegradsky2TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky2TwelfthsSharp")]
        public BoundingBox AccidentalWyschnegradsky2TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky3TwelfthsFlat")]
        public BoundingBox AccidentalWyschnegradsky3TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky3TwelfthsSharp")]
        public BoundingBox AccidentalWyschnegradsky3TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky4TwelfthsFlat")]
        public BoundingBox AccidentalWyschnegradsky4TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky4TwelfthsSharp")]
        public BoundingBox AccidentalWyschnegradsky4TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky5TwelfthsFlat")]
        public BoundingBox AccidentalWyschnegradsky5TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky5TwelfthsSharp")]
        public BoundingBox AccidentalWyschnegradsky5TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky6TwelfthsFlat")]
        public BoundingBox AccidentalWyschnegradsky6TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky6TwelfthsSharp")]
        public BoundingBox AccidentalWyschnegradsky6TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky7TwelfthsFlat")]
        public BoundingBox AccidentalWyschnegradsky7TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky7TwelfthsSharp")]
        public BoundingBox AccidentalWyschnegradsky7TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky8TwelfthsFlat")]
        public BoundingBox AccidentalWyschnegradsky8TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky8TwelfthsSharp")]
        public BoundingBox AccidentalWyschnegradsky8TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky9TwelfthsFlat")]
        public BoundingBox AccidentalWyschnegradsky9TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky9TwelfthsSharp")]
        public BoundingBox AccidentalWyschnegradsky9TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalXenakisOneThirdToneSharp")]
        public BoundingBox AccidentalXenakisOneThirdToneSharp { get; set; }

        [DataMember(Name="accidentalXenakisTwoThirdTonesSharp")]
        public BoundingBox AccidentalXenakisTwoThirdTonesSharp { get; set; }

        [DataMember(Name="analyticsChoralmelodie")]
        public BoundingBox AnalyticsChoralmelodie { get; set; }

        [DataMember(Name="analyticsEndStimme")]
        public BoundingBox AnalyticsEndStimme { get; set; }

        [DataMember(Name="analyticsHauptrhythmus")]
        public BoundingBox AnalyticsHauptrhythmus { get; set; }

        [DataMember(Name="analyticsHauptrhythmusR")]
        public BoundingBox AnalyticsHauptrhythmusR { get; set; }

        [DataMember(Name="analyticsHauptstimme")]
        public BoundingBox AnalyticsHauptstimme { get; set; }

        [DataMember(Name="analyticsInversion1")]
        public BoundingBox AnalyticsInversion1 { get; set; }

        [DataMember(Name="analyticsNebenstimme")]
        public BoundingBox AnalyticsNebenstimme { get; set; }

        [DataMember(Name="analyticsStartStimme")]
        public BoundingBox AnalyticsStartStimme { get; set; }

        [DataMember(Name="analyticsTheme")]
        public BoundingBox AnalyticsTheme { get; set; }

        [DataMember(Name="analyticsTheme1")]
        public BoundingBox AnalyticsTheme1 { get; set; }

        [DataMember(Name="analyticsThemeInversion")]
        public BoundingBox AnalyticsThemeInversion { get; set; }

        [DataMember(Name="analyticsThemeRetrograde")]
        public BoundingBox AnalyticsThemeRetrograde { get; set; }

        [DataMember(Name="analyticsThemeRetrogradeInversion")]
        public BoundingBox AnalyticsThemeRetrogradeInversion { get; set; }

        [DataMember(Name="arpeggiatoDown")]
        public BoundingBox ArpeggiatoDown { get; set; }

        [DataMember(Name="arpeggiatoUp")]
        public BoundingBox ArpeggiatoUp { get; set; }

        [DataMember(Name="arrowBlackDown")]
        public BoundingBox ArrowBlackDown { get; set; }

        [DataMember(Name="arrowBlackDownLeft")]
        public BoundingBox ArrowBlackDownLeft { get; set; }

        [DataMember(Name="arrowBlackDownRight")]
        public BoundingBox ArrowBlackDownRight { get; set; }

        [DataMember(Name="arrowBlackLeft")]
        public BoundingBox ArrowBlackLeft { get; set; }

        [DataMember(Name="arrowBlackRight")]
        public BoundingBox ArrowBlackRight { get; set; }

        [DataMember(Name="arrowBlackUp")]
        public BoundingBox ArrowBlackUp { get; set; }

        [DataMember(Name="arrowBlackUpLeft")]
        public BoundingBox ArrowBlackUpLeft { get; set; }

        [DataMember(Name="arrowBlackUpRight")]
        public BoundingBox ArrowBlackUpRight { get; set; }

        [DataMember(Name="arrowOpenDown")]
        public BoundingBox ArrowOpenDown { get; set; }

        [DataMember(Name="arrowOpenDownLeft")]
        public BoundingBox ArrowOpenDownLeft { get; set; }

        [DataMember(Name="arrowOpenDownRight")]
        public BoundingBox ArrowOpenDownRight { get; set; }

        [DataMember(Name="arrowOpenLeft")]
        public BoundingBox ArrowOpenLeft { get; set; }

        [DataMember(Name="arrowOpenRight")]
        public BoundingBox ArrowOpenRight { get; set; }

        [DataMember(Name="arrowOpenUp")]
        public BoundingBox ArrowOpenUp { get; set; }

        [DataMember(Name="arrowOpenUpLeft")]
        public BoundingBox ArrowOpenUpLeft { get; set; }

        [DataMember(Name="arrowOpenUpRight")]
        public BoundingBox ArrowOpenUpRight { get; set; }

        [DataMember(Name="arrowWhiteDown")]
        public BoundingBox ArrowWhiteDown { get; set; }

        [DataMember(Name="arrowWhiteDownLeft")]
        public BoundingBox ArrowWhiteDownLeft { get; set; }

        [DataMember(Name="arrowWhiteDownRight")]
        public BoundingBox ArrowWhiteDownRight { get; set; }

        [DataMember(Name="arrowWhiteLeft")]
        public BoundingBox ArrowWhiteLeft { get; set; }

        [DataMember(Name="arrowWhiteRight")]
        public BoundingBox ArrowWhiteRight { get; set; }

        [DataMember(Name="arrowWhiteUp")]
        public BoundingBox ArrowWhiteUp { get; set; }

        [DataMember(Name="arrowWhiteUpLeft")]
        public BoundingBox ArrowWhiteUpLeft { get; set; }

        [DataMember(Name="arrowWhiteUpRight")]
        public BoundingBox ArrowWhiteUpRight { get; set; }

        [DataMember(Name="arrowheadBlackDown")]
        public BoundingBox ArrowheadBlackDown { get; set; }

        [DataMember(Name="arrowheadBlackDownLeft")]
        public BoundingBox ArrowheadBlackDownLeft { get; set; }

        [DataMember(Name="arrowheadBlackDownRight")]
        public BoundingBox ArrowheadBlackDownRight { get; set; }

        [DataMember(Name="arrowheadBlackLeft")]
        public BoundingBox ArrowheadBlackLeft { get; set; }

        [DataMember(Name="arrowheadBlackRight")]
        public BoundingBox ArrowheadBlackRight { get; set; }

        [DataMember(Name="arrowheadBlackUp")]
        public BoundingBox ArrowheadBlackUp { get; set; }

        [DataMember(Name="arrowheadBlackUpLeft")]
        public BoundingBox ArrowheadBlackUpLeft { get; set; }

        [DataMember(Name="arrowheadBlackUpRight")]
        public BoundingBox ArrowheadBlackUpRight { get; set; }

        [DataMember(Name="arrowheadOpenDown")]
        public BoundingBox ArrowheadOpenDown { get; set; }

        [DataMember(Name="arrowheadOpenDownLeft")]
        public BoundingBox ArrowheadOpenDownLeft { get; set; }

        [DataMember(Name="arrowheadOpenDownRight")]
        public BoundingBox ArrowheadOpenDownRight { get; set; }

        [DataMember(Name="arrowheadOpenLeft")]
        public BoundingBox ArrowheadOpenLeft { get; set; }

        [DataMember(Name="arrowheadOpenRight")]
        public BoundingBox ArrowheadOpenRight { get; set; }

        [DataMember(Name="arrowheadOpenUp")]
        public BoundingBox ArrowheadOpenUp { get; set; }

        [DataMember(Name="arrowheadOpenUpLeft")]
        public BoundingBox ArrowheadOpenUpLeft { get; set; }

        [DataMember(Name="arrowheadOpenUpRight")]
        public BoundingBox ArrowheadOpenUpRight { get; set; }

        [DataMember(Name="arrowheadWhiteDown")]
        public BoundingBox ArrowheadWhiteDown { get; set; }

        [DataMember(Name="arrowheadWhiteDownLeft")]
        public BoundingBox ArrowheadWhiteDownLeft { get; set; }

        [DataMember(Name="arrowheadWhiteDownRight")]
        public BoundingBox ArrowheadWhiteDownRight { get; set; }

        [DataMember(Name="arrowheadWhiteLeft")]
        public BoundingBox ArrowheadWhiteLeft { get; set; }

        [DataMember(Name="arrowheadWhiteRight")]
        public BoundingBox ArrowheadWhiteRight { get; set; }

        [DataMember(Name="arrowheadWhiteUp")]
        public BoundingBox ArrowheadWhiteUp { get; set; }

        [DataMember(Name="arrowheadWhiteUpLeft")]
        public BoundingBox ArrowheadWhiteUpLeft { get; set; }

        [DataMember(Name="arrowheadWhiteUpRight")]
        public BoundingBox ArrowheadWhiteUpRight { get; set; }

        [DataMember(Name="articAccentAbove")]
        public BoundingBox ArticAccentAbove { get; set; }

        [DataMember(Name="articAccentAboveLarge")]
        public BoundingBox ArticAccentAboveLarge { get; set; }

        [DataMember(Name="articAccentAboveSmall")]
        public BoundingBox ArticAccentAboveSmall { get; set; }

        [DataMember(Name="articAccentBelow")]
        public BoundingBox ArticAccentBelow { get; set; }

        [DataMember(Name="articAccentBelowLarge")]
        public BoundingBox ArticAccentBelowLarge { get; set; }

        [DataMember(Name="articAccentBelowSmall")]
        public BoundingBox ArticAccentBelowSmall { get; set; }

        [DataMember(Name="articAccentStaccatoAbove")]
        public BoundingBox ArticAccentStaccatoAbove { get; set; }

        [DataMember(Name="articAccentStaccatoAboveSmall")]
        public BoundingBox ArticAccentStaccatoAboveSmall { get; set; }

        [DataMember(Name="articAccentStaccatoBelow")]
        public BoundingBox ArticAccentStaccatoBelow { get; set; }

        [DataMember(Name="articAccentStaccatoBelowSmall")]
        public BoundingBox ArticAccentStaccatoBelowSmall { get; set; }

        [DataMember(Name="articLaissezVibrerAbove")]
        public BoundingBox ArticLaissezVibrerAbove { get; set; }

        [DataMember(Name="articLaissezVibrerBelow")]
        public BoundingBox ArticLaissezVibrerBelow { get; set; }

        [DataMember(Name="articMarcatoAbove")]
        public BoundingBox ArticMarcatoAbove { get; set; }

        [DataMember(Name="articMarcatoAboveSmall")]
        public BoundingBox ArticMarcatoAboveSmall { get; set; }

        [DataMember(Name="articMarcatoBelow")]
        public BoundingBox ArticMarcatoBelow { get; set; }

        [DataMember(Name="articMarcatoBelowSmall")]
        public BoundingBox ArticMarcatoBelowSmall { get; set; }

        [DataMember(Name="articMarcatoStaccatoAbove")]
        public BoundingBox ArticMarcatoStaccatoAbove { get; set; }

        [DataMember(Name="articMarcatoStaccatoAboveSmall")]
        public BoundingBox ArticMarcatoStaccatoAboveSmall { get; set; }

        [DataMember(Name="articMarcatoStaccatoBelow")]
        public BoundingBox ArticMarcatoStaccatoBelow { get; set; }

        [DataMember(Name="articMarcatoStaccatoBelowSmall")]
        public BoundingBox ArticMarcatoStaccatoBelowSmall { get; set; }

        [DataMember(Name="articMarcatoTenutoAbove")]
        public BoundingBox ArticMarcatoTenutoAbove { get; set; }

        [DataMember(Name="articMarcatoTenutoBelow")]
        public BoundingBox ArticMarcatoTenutoBelow { get; set; }

        [DataMember(Name="articSoftAccentAbove")]
        public BoundingBox ArticSoftAccentAbove { get; set; }

        [DataMember(Name="articSoftAccentBelow")]
        public BoundingBox ArticSoftAccentBelow { get; set; }

        [DataMember(Name="articSoftAccentStaccatoAbove")]
        public BoundingBox ArticSoftAccentStaccatoAbove { get; set; }

        [DataMember(Name="articSoftAccentStaccatoBelow")]
        public BoundingBox ArticSoftAccentStaccatoBelow { get; set; }

        [DataMember(Name="articSoftAccentTenutoAbove")]
        public BoundingBox ArticSoftAccentTenutoAbove { get; set; }

        [DataMember(Name="articSoftAccentTenutoBelow")]
        public BoundingBox ArticSoftAccentTenutoBelow { get; set; }

        [DataMember(Name="articSoftAccentTenutoStaccatoAbove")]
        public BoundingBox ArticSoftAccentTenutoStaccatoAbove { get; set; }

        [DataMember(Name="articSoftAccentTenutoStaccatoBelow")]
        public BoundingBox ArticSoftAccentTenutoStaccatoBelow { get; set; }

        [DataMember(Name="articStaccatissimoAbove")]
        public BoundingBox ArticStaccatissimoAbove { get; set; }

        [DataMember(Name="articStaccatissimoAboveSmall")]
        public BoundingBox ArticStaccatissimoAboveSmall { get; set; }

        [DataMember(Name="articStaccatissimoBelow")]
        public BoundingBox ArticStaccatissimoBelow { get; set; }

        [DataMember(Name="articStaccatissimoBelowSmall")]
        public BoundingBox ArticStaccatissimoBelowSmall { get; set; }

        [DataMember(Name="articStaccatissimoStrokeAbove")]
        public BoundingBox ArticStaccatissimoStrokeAbove { get; set; }

        [DataMember(Name="articStaccatissimoStrokeAboveSmall")]
        public BoundingBox ArticStaccatissimoStrokeAboveSmall { get; set; }

        [DataMember(Name="articStaccatissimoStrokeBelow")]
        public BoundingBox ArticStaccatissimoStrokeBelow { get; set; }

        [DataMember(Name="articStaccatissimoStrokeBelowSmall")]
        public BoundingBox ArticStaccatissimoStrokeBelowSmall { get; set; }

        [DataMember(Name="articStaccatissimoWedgeAbove")]
        public BoundingBox ArticStaccatissimoWedgeAbove { get; set; }

        [DataMember(Name="articStaccatissimoWedgeAboveSmall")]
        public BoundingBox ArticStaccatissimoWedgeAboveSmall { get; set; }

        [DataMember(Name="articStaccatissimoWedgeBelow")]
        public BoundingBox ArticStaccatissimoWedgeBelow { get; set; }

        [DataMember(Name="articStaccatissimoWedgeBelowSmall")]
        public BoundingBox ArticStaccatissimoWedgeBelowSmall { get; set; }

        [DataMember(Name="articStaccatoAbove")]
        public BoundingBox ArticStaccatoAbove { get; set; }

        [DataMember(Name="articStaccatoAboveSmall")]
        public BoundingBox ArticStaccatoAboveSmall { get; set; }

        [DataMember(Name="articStaccatoBelow")]
        public BoundingBox ArticStaccatoBelow { get; set; }

        [DataMember(Name="articStaccatoBelowSmall")]
        public BoundingBox ArticStaccatoBelowSmall { get; set; }

        [DataMember(Name="articStressAbove")]
        public BoundingBox ArticStressAbove { get; set; }

        [DataMember(Name="articStressBelow")]
        public BoundingBox ArticStressBelow { get; set; }

        [DataMember(Name="articTenutoAbove")]
        public BoundingBox ArticTenutoAbove { get; set; }

        [DataMember(Name="articTenutoAboveSmall")]
        public BoundingBox ArticTenutoAboveSmall { get; set; }

        [DataMember(Name="articTenutoAccentAbove")]
        public BoundingBox ArticTenutoAccentAbove { get; set; }

        [DataMember(Name="articTenutoAccentAboveSmall")]
        public BoundingBox ArticTenutoAccentAboveSmall { get; set; }

        [DataMember(Name="articTenutoAccentBelow")]
        public BoundingBox ArticTenutoAccentBelow { get; set; }

        [DataMember(Name="articTenutoAccentBelowSmall")]
        public BoundingBox ArticTenutoAccentBelowSmall { get; set; }

        [DataMember(Name="articTenutoBelow")]
        public BoundingBox ArticTenutoBelow { get; set; }

        [DataMember(Name="articTenutoBelowSmall")]
        public BoundingBox ArticTenutoBelowSmall { get; set; }

        [DataMember(Name="articTenutoStaccatoAbove")]
        public BoundingBox ArticTenutoStaccatoAbove { get; set; }

        [DataMember(Name="articTenutoStaccatoAboveSmall")]
        public BoundingBox ArticTenutoStaccatoAboveSmall { get; set; }

        [DataMember(Name="articTenutoStaccatoBelow")]
        public BoundingBox ArticTenutoStaccatoBelow { get; set; }

        [DataMember(Name="articTenutoStaccatoBelowSmall")]
        public BoundingBox ArticTenutoStaccatoBelowSmall { get; set; }

        [DataMember(Name="articUnstressAbove")]
        public BoundingBox ArticUnstressAbove { get; set; }

        [DataMember(Name="articUnstressBelow")]
        public BoundingBox ArticUnstressBelow { get; set; }

        [DataMember(Name="augmentationDot")]
        public BoundingBox AugmentationDot { get; set; }

        [DataMember(Name="barlineDashed")]
        public BoundingBox BarlineDashed { get; set; }

        [DataMember(Name="barlineDotted")]
        public BoundingBox BarlineDotted { get; set; }

        [DataMember(Name="barlineDouble")]
        public BoundingBox BarlineDouble { get; set; }

        [DataMember(Name="barlineFinal")]
        public BoundingBox BarlineFinal { get; set; }

        [DataMember(Name="barlineHeavy")]
        public BoundingBox BarlineHeavy { get; set; }

        [DataMember(Name="barlineHeavyHeavy")]
        public BoundingBox BarlineHeavyHeavy { get; set; }

        [DataMember(Name="barlineReverseFinal")]
        public BoundingBox BarlineReverseFinal { get; set; }

        [DataMember(Name="barlineShort")]
        public BoundingBox BarlineShort { get; set; }

        [DataMember(Name="barlineSingle")]
        public BoundingBox BarlineSingle { get; set; }

        [DataMember(Name="barlineTick")]
        public BoundingBox BarlineTick { get; set; }

        [DataMember(Name="beamAccelRit1")]
        public BoundingBox BeamAccelRit1 { get; set; }

        [DataMember(Name="beamAccelRit10")]
        public BoundingBox BeamAccelRit10 { get; set; }

        [DataMember(Name="beamAccelRit11")]
        public BoundingBox BeamAccelRit11 { get; set; }

        [DataMember(Name="beamAccelRit12")]
        public BoundingBox BeamAccelRit12 { get; set; }

        [DataMember(Name="beamAccelRit13")]
        public BoundingBox BeamAccelRit13 { get; set; }

        [DataMember(Name="beamAccelRit14")]
        public BoundingBox BeamAccelRit14 { get; set; }

        [DataMember(Name="beamAccelRit15")]
        public BoundingBox BeamAccelRit15 { get; set; }

        [DataMember(Name="beamAccelRit2")]
        public BoundingBox BeamAccelRit2 { get; set; }

        [DataMember(Name="beamAccelRit3")]
        public BoundingBox BeamAccelRit3 { get; set; }

        [DataMember(Name="beamAccelRit4")]
        public BoundingBox BeamAccelRit4 { get; set; }

        [DataMember(Name="beamAccelRit5")]
        public BoundingBox BeamAccelRit5 { get; set; }

        [DataMember(Name="beamAccelRit6")]
        public BoundingBox BeamAccelRit6 { get; set; }

        [DataMember(Name="beamAccelRit7")]
        public BoundingBox BeamAccelRit7 { get; set; }

        [DataMember(Name="beamAccelRit8")]
        public BoundingBox BeamAccelRit8 { get; set; }

        [DataMember(Name="beamAccelRit9")]
        public BoundingBox BeamAccelRit9 { get; set; }

        [DataMember(Name="beamAccelRitFinal")]
        public BoundingBox BeamAccelRitFinal { get; set; }

        [DataMember(Name="brace")]
        public BoundingBox Brace { get; set; }

        [DataMember(Name="braceFlat")]
        public BoundingBox BraceFlat { get; set; }

        [DataMember(Name="braceLarge")]
        public BoundingBox BraceLarge { get; set; }

        [DataMember(Name="braceLarger")]
        public BoundingBox BraceLarger { get; set; }

        [DataMember(Name="braceSmall")]
        public BoundingBox BraceSmall { get; set; }

        [DataMember(Name="bracket")]
        public BoundingBox Bracket { get; set; }

        [DataMember(Name="bracketBottom")]
        public BoundingBox BracketBottom { get; set; }

        [DataMember(Name="bracketTop")]
        public BoundingBox BracketTop { get; set; }

        [DataMember(Name="brassBend")]
        public BoundingBox BrassBend { get; set; }

        [DataMember(Name="brassDoitLong")]
        public BoundingBox BrassDoitLong { get; set; }

        [DataMember(Name="brassDoitMedium")]
        public BoundingBox BrassDoitMedium { get; set; }

        [DataMember(Name="brassDoitShort")]
        public BoundingBox BrassDoitShort { get; set; }

        [DataMember(Name="brassFallLipLong")]
        public BoundingBox BrassFallLipLong { get; set; }

        [DataMember(Name="brassFallLipMedium")]
        public BoundingBox BrassFallLipMedium { get; set; }

        [DataMember(Name="brassFallLipShort")]
        public BoundingBox BrassFallLipShort { get; set; }

        [DataMember(Name="brassFallRoughLong")]
        public BoundingBox BrassFallRoughLong { get; set; }

        [DataMember(Name="brassFallRoughMedium")]
        public BoundingBox BrassFallRoughMedium { get; set; }

        [DataMember(Name="brassFallRoughShort")]
        public BoundingBox BrassFallRoughShort { get; set; }

        [DataMember(Name="brassFallSmoothLong")]
        public BoundingBox BrassFallSmoothLong { get; set; }

        [DataMember(Name="brassFallSmoothMedium")]
        public BoundingBox BrassFallSmoothMedium { get; set; }

        [DataMember(Name="brassFallSmoothShort")]
        public BoundingBox BrassFallSmoothShort { get; set; }

        [DataMember(Name="brassFlip")]
        public BoundingBox BrassFlip { get; set; }

        [DataMember(Name="brassHarmonMuteClosed")]
        public BoundingBox BrassHarmonMuteClosed { get; set; }

        [DataMember(Name="brassHarmonMuteStemHalfLeft")]
        public BoundingBox BrassHarmonMuteStemHalfLeft { get; set; }

        [DataMember(Name="brassHarmonMuteStemHalfRight")]
        public BoundingBox BrassHarmonMuteStemHalfRight { get; set; }

        [DataMember(Name="brassHarmonMuteStemOpen")]
        public BoundingBox BrassHarmonMuteStemOpen { get; set; }

        [DataMember(Name="brassJazzTurn")]
        public BoundingBox BrassJazzTurn { get; set; }

        [DataMember(Name="brassLiftLong")]
        public BoundingBox BrassLiftLong { get; set; }

        [DataMember(Name="brassLiftMedium")]
        public BoundingBox BrassLiftMedium { get; set; }

        [DataMember(Name="brassLiftShort")]
        public BoundingBox BrassLiftShort { get; set; }

        [DataMember(Name="brassLiftSmoothLong")]
        public BoundingBox BrassLiftSmoothLong { get; set; }

        [DataMember(Name="brassLiftSmoothMedium")]
        public BoundingBox BrassLiftSmoothMedium { get; set; }

        [DataMember(Name="brassLiftSmoothShort")]
        public BoundingBox BrassLiftSmoothShort { get; set; }

        [DataMember(Name="brassMuteClosed")]
        public BoundingBox BrassMuteClosed { get; set; }

        [DataMember(Name="brassMuteHalfClosed")]
        public BoundingBox BrassMuteHalfClosed { get; set; }

        [DataMember(Name="brassMuteOpen")]
        public BoundingBox BrassMuteOpen { get; set; }

        [DataMember(Name="brassPlop")]
        public BoundingBox BrassPlop { get; set; }

        [DataMember(Name="brassScoop")]
        public BoundingBox BrassScoop { get; set; }

        [DataMember(Name="brassSmear")]
        public BoundingBox BrassSmear { get; set; }

        [DataMember(Name="brassValveTrill")]
        public BoundingBox BrassValveTrill { get; set; }

        [DataMember(Name="breathMarkComma")]
        public BoundingBox BreathMarkComma { get; set; }

        [DataMember(Name="breathMarkSalzedo")]
        public BoundingBox BreathMarkSalzedo { get; set; }

        [DataMember(Name="breathMarkTick")]
        public BoundingBox BreathMarkTick { get; set; }

        [DataMember(Name="breathMarkUpbow")]
        public BoundingBox BreathMarkUpbow { get; set; }

        [DataMember(Name="bridgeClef")]
        public BoundingBox BridgeClef { get; set; }

        [DataMember(Name="buzzRoll")]
        public BoundingBox BuzzRoll { get; set; }

        [DataMember(Name="cClef")]
        public BoundingBox CClef { get; set; }

        [DataMember(Name="cClef8vb")]
        public BoundingBox CClef8Vb { get; set; }

        [DataMember(Name="cClefArrowDown")]
        public BoundingBox CClefArrowDown { get; set; }

        [DataMember(Name="cClefArrowUp")]
        public BoundingBox CClefArrowUp { get; set; }

        [DataMember(Name="cClefChange")]
        public BoundingBox CClefChange { get; set; }

        [DataMember(Name="cClefCombining")]
        public BoundingBox CClefCombining { get; set; }

        [DataMember(Name="cClefFrench")]
        public BoundingBox CClefFrench { get; set; }

        [DataMember(Name="cClefFrench20C")]
        public BoundingBox CClefFrench20C { get; set; }

        [DataMember(Name="cClefFrench20CChange")]
        public BoundingBox CClefFrench20CChange { get; set; }

        [DataMember(Name="cClefReversed")]
        public BoundingBox CClefReversed { get; set; }

        [DataMember(Name="cClefSmall")]
        public BoundingBox CClefSmall { get; set; }

        [DataMember(Name="cClefSquare")]
        public BoundingBox CClefSquare { get; set; }

        [DataMember(Name="caesura")]
        public BoundingBox Caesura { get; set; }

        [DataMember(Name="caesuraCurved")]
        public BoundingBox CaesuraCurved { get; set; }

        [DataMember(Name="caesuraShort")]
        public BoundingBox CaesuraShort { get; set; }

        [DataMember(Name="caesuraSingleStroke")]
        public BoundingBox CaesuraSingleStroke { get; set; }

        [DataMember(Name="caesuraThick")]
        public BoundingBox CaesuraThick { get; set; }

        [DataMember(Name="chantAccentusAbove")]
        public BoundingBox ChantAccentusAbove { get; set; }

        [DataMember(Name="chantAccentusBelow")]
        public BoundingBox ChantAccentusBelow { get; set; }

        [DataMember(Name="chantAuctumAsc")]
        public BoundingBox ChantAuctumAsc { get; set; }

        [DataMember(Name="chantAuctumDesc")]
        public BoundingBox ChantAuctumDesc { get; set; }

        [DataMember(Name="chantAugmentum")]
        public BoundingBox ChantAugmentum { get; set; }

        [DataMember(Name="chantCaesura")]
        public BoundingBox ChantCaesura { get; set; }

        [DataMember(Name="chantCclef")]
        public BoundingBox ChantCclef { get; set; }

        [DataMember(Name="chantCclefHufnagel")]
        public BoundingBox ChantCclefHufnagel { get; set; }

        [DataMember(Name="chantCirculusAbove")]
        public BoundingBox ChantCirculusAbove { get; set; }

        [DataMember(Name="chantCirculusBelow")]
        public BoundingBox ChantCirculusBelow { get; set; }

        [DataMember(Name="chantConnectingLineAsc2nd")]
        public BoundingBox ChantConnectingLineAsc2Nd { get; set; }

        [DataMember(Name="chantConnectingLineAsc3rd")]
        public BoundingBox ChantConnectingLineAsc3Rd { get; set; }

        [DataMember(Name="chantConnectingLineAsc4th")]
        public BoundingBox ChantConnectingLineAsc4Th { get; set; }

        [DataMember(Name="chantConnectingLineAsc5th")]
        public BoundingBox ChantConnectingLineAsc5Th { get; set; }

        [DataMember(Name="chantConnectingLineAsc6th")]
        public BoundingBox ChantConnectingLineAsc6Th { get; set; }

        [DataMember(Name="chantCustosStemDownPosHigh")]
        public BoundingBox ChantCustosStemDownPosHigh { get; set; }

        [DataMember(Name="chantCustosStemDownPosHighest")]
        public BoundingBox ChantCustosStemDownPosHighest { get; set; }

        [DataMember(Name="chantCustosStemDownPosMiddle")]
        public BoundingBox ChantCustosStemDownPosMiddle { get; set; }

        [DataMember(Name="chantCustosStemUpPosLow")]
        public BoundingBox ChantCustosStemUpPosLow { get; set; }

        [DataMember(Name="chantCustosStemUpPosLowest")]
        public BoundingBox ChantCustosStemUpPosLowest { get; set; }

        [DataMember(Name="chantCustosStemUpPosMiddle")]
        public BoundingBox ChantCustosStemUpPosMiddle { get; set; }

        [DataMember(Name="chantDeminutumLower")]
        public BoundingBox ChantDeminutumLower { get; set; }

        [DataMember(Name="chantDeminutumUpper")]
        public BoundingBox ChantDeminutumUpper { get; set; }

        [DataMember(Name="chantDivisioFinalis")]
        public BoundingBox ChantDivisioFinalis { get; set; }

        [DataMember(Name="chantDivisioMaior")]
        public BoundingBox ChantDivisioMaior { get; set; }

        [DataMember(Name="chantDivisioMaxima")]
        public BoundingBox ChantDivisioMaxima { get; set; }

        [DataMember(Name="chantDivisioMinima")]
        public BoundingBox ChantDivisioMinima { get; set; }

        [DataMember(Name="chantEntryLineAsc2nd")]
        public BoundingBox ChantEntryLineAsc2Nd { get; set; }

        [DataMember(Name="chantEntryLineAsc3rd")]
        public BoundingBox ChantEntryLineAsc3Rd { get; set; }

        [DataMember(Name="chantEntryLineAsc4th")]
        public BoundingBox ChantEntryLineAsc4Th { get; set; }

        [DataMember(Name="chantEntryLineAsc5th")]
        public BoundingBox ChantEntryLineAsc5Th { get; set; }

        [DataMember(Name="chantEntryLineAsc6th")]
        public BoundingBox ChantEntryLineAsc6Th { get; set; }

        [DataMember(Name="chantEpisema")]
        public BoundingBox ChantEpisema { get; set; }

        [DataMember(Name="chantFclef")]
        public BoundingBox ChantFclef { get; set; }

        [DataMember(Name="chantFclefHufnagel")]
        public BoundingBox ChantFclefHufnagel { get; set; }

        [DataMember(Name="chantIctusAbove")]
        public BoundingBox ChantIctusAbove { get; set; }

        [DataMember(Name="chantIctusBelow")]
        public BoundingBox ChantIctusBelow { get; set; }

        [DataMember(Name="chantLigaturaDesc2nd")]
        public BoundingBox ChantLigaturaDesc2Nd { get; set; }

        [DataMember(Name="chantLigaturaDesc3rd")]
        public BoundingBox ChantLigaturaDesc3Rd { get; set; }

        [DataMember(Name="chantLigaturaDesc4th")]
        public BoundingBox ChantLigaturaDesc4Th { get; set; }

        [DataMember(Name="chantLigaturaDesc5th")]
        public BoundingBox ChantLigaturaDesc5Th { get; set; }

        [DataMember(Name="chantOriscusAscending")]
        public BoundingBox ChantOriscusAscending { get; set; }

        [DataMember(Name="chantOriscusDescending")]
        public BoundingBox ChantOriscusDescending { get; set; }

        [DataMember(Name="chantOriscusLiquescens")]
        public BoundingBox ChantOriscusLiquescens { get; set; }

        [DataMember(Name="chantPodatusLower")]
        public BoundingBox ChantPodatusLower { get; set; }

        [DataMember(Name="chantPodatusUpper")]
        public BoundingBox ChantPodatusUpper { get; set; }

        [DataMember(Name="chantPunctum")]
        public BoundingBox ChantPunctum { get; set; }

        [DataMember(Name="chantPunctumCavum")]
        public BoundingBox ChantPunctumCavum { get; set; }

        [DataMember(Name="chantPunctumDeminutum")]
        public BoundingBox ChantPunctumDeminutum { get; set; }

        [DataMember(Name="chantPunctumInclinatum")]
        public BoundingBox ChantPunctumInclinatum { get; set; }

        [DataMember(Name="chantPunctumInclinatumAuctum")]
        public BoundingBox ChantPunctumInclinatumAuctum { get; set; }

        [DataMember(Name="chantPunctumInclinatumDeminutum")]
        public BoundingBox ChantPunctumInclinatumDeminutum { get; set; }

        [DataMember(Name="chantPunctumLinea")]
        public BoundingBox ChantPunctumLinea { get; set; }

        [DataMember(Name="chantPunctumLineaCavum")]
        public BoundingBox ChantPunctumLineaCavum { get; set; }

        [DataMember(Name="chantPunctumVirga")]
        public BoundingBox ChantPunctumVirga { get; set; }

        [DataMember(Name="chantPunctumVirgaReversed")]
        public BoundingBox ChantPunctumVirgaReversed { get; set; }

        [DataMember(Name="chantQuilisma")]
        public BoundingBox ChantQuilisma { get; set; }

        [DataMember(Name="chantSemicirculusAbove")]
        public BoundingBox ChantSemicirculusAbove { get; set; }

        [DataMember(Name="chantSemicirculusBelow")]
        public BoundingBox ChantSemicirculusBelow { get; set; }

        [DataMember(Name="chantStaff")]
        public BoundingBox ChantStaff { get; set; }

        [DataMember(Name="chantStaffNarrow")]
        public BoundingBox ChantStaffNarrow { get; set; }

        [DataMember(Name="chantStaffWide")]
        public BoundingBox ChantStaffWide { get; set; }

        [DataMember(Name="chantStrophicus")]
        public BoundingBox ChantStrophicus { get; set; }

        [DataMember(Name="chantStrophicusAuctus")]
        public BoundingBox ChantStrophicusAuctus { get; set; }

        [DataMember(Name="chantStrophicusLiquescens2nd")]
        public BoundingBox ChantStrophicusLiquescens2Nd { get; set; }

        [DataMember(Name="chantStrophicusLiquescens3rd")]
        public BoundingBox ChantStrophicusLiquescens3Rd { get; set; }

        [DataMember(Name="chantStrophicusLiquescens4th")]
        public BoundingBox ChantStrophicusLiquescens4Th { get; set; }

        [DataMember(Name="chantStrophicusLiquescens5th")]
        public BoundingBox ChantStrophicusLiquescens5Th { get; set; }

        [DataMember(Name="chantVirgula")]
        public BoundingBox ChantVirgula { get; set; }

        [DataMember(Name="clef15")]
        public BoundingBox Clef15 { get; set; }

        [DataMember(Name="clef8")]
        public BoundingBox Clef8 { get; set; }

        [DataMember(Name="coda")]
        public BoundingBox Coda { get; set; }

        [DataMember(Name="codaJapanese")]
        public BoundingBox CodaJapanese { get; set; }

        [DataMember(Name="codaSquare")]
        public BoundingBox CodaSquare { get; set; }

        [DataMember(Name="conductorBeat2Compound")]
        public BoundingBox ConductorBeat2Compound { get; set; }

        [DataMember(Name="conductorBeat2Simple")]
        public BoundingBox ConductorBeat2Simple { get; set; }

        [DataMember(Name="conductorBeat3Compound")]
        public BoundingBox ConductorBeat3Compound { get; set; }

        [DataMember(Name="conductorBeat3Simple")]
        public BoundingBox ConductorBeat3Simple { get; set; }

        [DataMember(Name="conductorBeat4Compound")]
        public BoundingBox ConductorBeat4Compound { get; set; }

        [DataMember(Name="conductorBeat4Simple")]
        public BoundingBox ConductorBeat4Simple { get; set; }

        [DataMember(Name="conductorLeftBeat")]
        public BoundingBox ConductorLeftBeat { get; set; }

        [DataMember(Name="conductorRightBeat")]
        public BoundingBox ConductorRightBeat { get; set; }

        [DataMember(Name="conductorStrongBeat")]
        public BoundingBox ConductorStrongBeat { get; set; }

        [DataMember(Name="conductorUnconducted")]
        public BoundingBox ConductorUnconducted { get; set; }

        [DataMember(Name="conductorWeakBeat")]
        public BoundingBox ConductorWeakBeat { get; set; }

        [DataMember(Name="csymAugmented")]
        public BoundingBox CsymAugmented { get; set; }

        [DataMember(Name="csymBracketLeftTall")]
        public BoundingBox CsymBracketLeftTall { get; set; }

        [DataMember(Name="csymBracketRightTall")]
        public BoundingBox CsymBracketRightTall { get; set; }

        [DataMember(Name="csymDiminished")]
        public BoundingBox CsymDiminished { get; set; }

        [DataMember(Name="csymHalfDiminished")]
        public BoundingBox CsymHalfDiminished { get; set; }

        [DataMember(Name="csymMajorSeventh")]
        public BoundingBox CsymMajorSeventh { get; set; }

        [DataMember(Name="csymMinor")]
        public BoundingBox CsymMinor { get; set; }

        [DataMember(Name="csymParensLeftTall")]
        public BoundingBox CsymParensLeftTall { get; set; }

        [DataMember(Name="csymParensRightTall")]
        public BoundingBox CsymParensRightTall { get; set; }

        [DataMember(Name="curlewSign")]
        public BoundingBox CurlewSign { get; set; }

        [DataMember(Name="daCapo")]
        public BoundingBox DaCapo { get; set; }

        [DataMember(Name="dalSegno")]
        public BoundingBox DalSegno { get; set; }

        [DataMember(Name="daseianExcellentes1")]
        public BoundingBox DaseianExcellentes1 { get; set; }

        [DataMember(Name="daseianExcellentes2")]
        public BoundingBox DaseianExcellentes2 { get; set; }

        [DataMember(Name="daseianExcellentes3")]
        public BoundingBox DaseianExcellentes3 { get; set; }

        [DataMember(Name="daseianExcellentes4")]
        public BoundingBox DaseianExcellentes4 { get; set; }

        [DataMember(Name="daseianFinales1")]
        public BoundingBox DaseianFinales1 { get; set; }

        [DataMember(Name="daseianFinales2")]
        public BoundingBox DaseianFinales2 { get; set; }

        [DataMember(Name="daseianFinales3")]
        public BoundingBox DaseianFinales3 { get; set; }

        [DataMember(Name="daseianFinales4")]
        public BoundingBox DaseianFinales4 { get; set; }

        [DataMember(Name="daseianGraves1")]
        public BoundingBox DaseianGraves1 { get; set; }

        [DataMember(Name="daseianGraves2")]
        public BoundingBox DaseianGraves2 { get; set; }

        [DataMember(Name="daseianGraves3")]
        public BoundingBox DaseianGraves3 { get; set; }

        [DataMember(Name="daseianGraves4")]
        public BoundingBox DaseianGraves4 { get; set; }

        [DataMember(Name="daseianResidua1")]
        public BoundingBox DaseianResidua1 { get; set; }

        [DataMember(Name="daseianResidua2")]
        public BoundingBox DaseianResidua2 { get; set; }

        [DataMember(Name="daseianSuperiores1")]
        public BoundingBox DaseianSuperiores1 { get; set; }

        [DataMember(Name="daseianSuperiores2")]
        public BoundingBox DaseianSuperiores2 { get; set; }

        [DataMember(Name="daseianSuperiores3")]
        public BoundingBox DaseianSuperiores3 { get; set; }

        [DataMember(Name="daseianSuperiores4")]
        public BoundingBox DaseianSuperiores4 { get; set; }

        [DataMember(Name="doubleTongueAbove")]
        public BoundingBox DoubleTongueAbove { get; set; }

        [DataMember(Name="doubleTongueAboveNoSlur")]
        public BoundingBox DoubleTongueAboveNoSlur { get; set; }

        [DataMember(Name="doubleTongueBelow")]
        public BoundingBox DoubleTongueBelow { get; set; }

        [DataMember(Name="doubleTongueBelowNoSlur")]
        public BoundingBox DoubleTongueBelowNoSlur { get; set; }

        [DataMember(Name="dynamicCombinedSeparatorColon")]
        public BoundingBox DynamicCombinedSeparatorColon { get; set; }

        [DataMember(Name="dynamicCombinedSeparatorHyphen")]
        public BoundingBox DynamicCombinedSeparatorHyphen { get; set; }

        [DataMember(Name="dynamicCrescendoHairpin")]
        public BoundingBox DynamicCrescendoHairpin { get; set; }

        [DataMember(Name="dynamicDiminuendoHairpin")]
        public BoundingBox DynamicDiminuendoHairpin { get; set; }

        [DataMember(Name="dynamicFF")]
        public BoundingBox DynamicFf { get; set; }

        [DataMember(Name="dynamicFFF")]
        public BoundingBox DynamicFff { get; set; }

        [DataMember(Name="dynamicFFFF")]
        public BoundingBox DynamicFfff { get; set; }

        [DataMember(Name="dynamicFFFFF")]
        public BoundingBox DynamicFffff { get; set; }

        [DataMember(Name="dynamicFFFFFF")]
        public BoundingBox DynamicFfffff { get; set; }

        [DataMember(Name="dynamicForte")]
        public BoundingBox DynamicForte { get; set; }

        [DataMember(Name="dynamicFortePiano")]
        public BoundingBox DynamicFortePiano { get; set; }

        [DataMember(Name="dynamicForteSmall")]
        public BoundingBox DynamicForteSmall { get; set; }

        [DataMember(Name="dynamicForzando")]
        public BoundingBox DynamicForzando { get; set; }

        [DataMember(Name="dynamicHairpinBracketLeft")]
        public BoundingBox DynamicHairpinBracketLeft { get; set; }

        [DataMember(Name="dynamicHairpinBracketRight")]
        public BoundingBox DynamicHairpinBracketRight { get; set; }

        [DataMember(Name="dynamicHairpinParenthesisLeft")]
        public BoundingBox DynamicHairpinParenthesisLeft { get; set; }

        [DataMember(Name="dynamicHairpinParenthesisRight")]
        public BoundingBox DynamicHairpinParenthesisRight { get; set; }

        [DataMember(Name="dynamicMF")]
        public BoundingBox DynamicMf { get; set; }

        [DataMember(Name="dynamicMP")]
        public BoundingBox DynamicMp { get; set; }

        [DataMember(Name="dynamicMessaDiVoce")]
        public BoundingBox DynamicMessaDiVoce { get; set; }

        [DataMember(Name="dynamicMezzo")]
        public BoundingBox DynamicMezzo { get; set; }

        [DataMember(Name="dynamicMezzoSmall")]
        public BoundingBox DynamicMezzoSmall { get; set; }

        [DataMember(Name="dynamicNiente")]
        public BoundingBox DynamicNiente { get; set; }

        [DataMember(Name="dynamicNienteForHairpin")]
        public BoundingBox DynamicNienteForHairpin { get; set; }

        [DataMember(Name="dynamicNienteSmall")]
        public BoundingBox DynamicNienteSmall { get; set; }

        [DataMember(Name="dynamicPF")]
        public BoundingBox DynamicPf { get; set; }

        [DataMember(Name="dynamicPP")]
        public BoundingBox DynamicPp { get; set; }

        [DataMember(Name="dynamicPPP")]
        public BoundingBox DynamicPpp { get; set; }

        [DataMember(Name="dynamicPPPP")]
        public BoundingBox DynamicPppp { get; set; }

        [DataMember(Name="dynamicPPPPP")]
        public BoundingBox DynamicPpppp { get; set; }

        [DataMember(Name="dynamicPPPPPP")]
        public BoundingBox DynamicPppppp { get; set; }

        [DataMember(Name="dynamicPiano")]
        public BoundingBox DynamicPiano { get; set; }

        [DataMember(Name="dynamicPianoSmall")]
        public BoundingBox DynamicPianoSmall { get; set; }

        [DataMember(Name="dynamicRinforzando")]
        public BoundingBox DynamicRinforzando { get; set; }

        [DataMember(Name="dynamicRinforzando1")]
        public BoundingBox DynamicRinforzando1 { get; set; }

        [DataMember(Name="dynamicRinforzando2")]
        public BoundingBox DynamicRinforzando2 { get; set; }

        [DataMember(Name="dynamicRinforzandoSmall")]
        public BoundingBox DynamicRinforzandoSmall { get; set; }

        [DataMember(Name="dynamicSforzando")]
        public BoundingBox DynamicSforzando { get; set; }

        [DataMember(Name="dynamicSforzando1")]
        public BoundingBox DynamicSforzando1 { get; set; }

        [DataMember(Name="dynamicSforzandoPianissimo")]
        public BoundingBox DynamicSforzandoPianissimo { get; set; }

        [DataMember(Name="dynamicSforzandoPiano")]
        public BoundingBox DynamicSforzandoPiano { get; set; }

        [DataMember(Name="dynamicSforzandoSmall")]
        public BoundingBox DynamicSforzandoSmall { get; set; }

        [DataMember(Name="dynamicSforzato")]
        public BoundingBox DynamicSforzato { get; set; }

        [DataMember(Name="dynamicSforzatoFF")]
        public BoundingBox DynamicSforzatoFf { get; set; }

        [DataMember(Name="dynamicSforzatoPiano")]
        public BoundingBox DynamicSforzatoPiano { get; set; }

        [DataMember(Name="dynamicZ")]
        public BoundingBox DynamicZ { get; set; }

        [DataMember(Name="dynamicZSmall")]
        public BoundingBox DynamicZSmall { get; set; }

        [DataMember(Name="elecAudioChannelsEight")]
        public BoundingBox ElecAudioChannelsEight { get; set; }

        [DataMember(Name="elecAudioChannelsFive")]
        public BoundingBox ElecAudioChannelsFive { get; set; }

        [DataMember(Name="elecAudioChannelsFour")]
        public BoundingBox ElecAudioChannelsFour { get; set; }

        [DataMember(Name="elecAudioChannelsOne")]
        public BoundingBox ElecAudioChannelsOne { get; set; }

        [DataMember(Name="elecAudioChannelsSeven")]
        public BoundingBox ElecAudioChannelsSeven { get; set; }

        [DataMember(Name="elecAudioChannelsSix")]
        public BoundingBox ElecAudioChannelsSix { get; set; }

        [DataMember(Name="elecAudioChannelsThreeFrontal")]
        public BoundingBox ElecAudioChannelsThreeFrontal { get; set; }

        [DataMember(Name="elecAudioChannelsThreeSurround")]
        public BoundingBox ElecAudioChannelsThreeSurround { get; set; }

        [DataMember(Name="elecAudioChannelsTwo")]
        public BoundingBox ElecAudioChannelsTwo { get; set; }

        [DataMember(Name="elecAudioIn")]
        public BoundingBox ElecAudioIn { get; set; }

        [DataMember(Name="elecAudioMono")]
        public BoundingBox ElecAudioMono { get; set; }

        [DataMember(Name="elecAudioOut")]
        public BoundingBox ElecAudioOut { get; set; }

        [DataMember(Name="elecAudioStereo")]
        public BoundingBox ElecAudioStereo { get; set; }

        [DataMember(Name="elecCamera")]
        public BoundingBox ElecCamera { get; set; }

        [DataMember(Name="elecDataIn")]
        public BoundingBox ElecDataIn { get; set; }

        [DataMember(Name="elecDataOut")]
        public BoundingBox ElecDataOut { get; set; }

        [DataMember(Name="elecDisc")]
        public Dictionary<string, long[]> ElecDisc { get; set; }

        [DataMember(Name="elecDownload")]
        public BoundingBox ElecDownload { get; set; }

        [DataMember(Name="elecEject")]
        public BoundingBox ElecEject { get; set; }

        [DataMember(Name="elecFastForward")]
        public BoundingBox ElecFastForward { get; set; }

        [DataMember(Name="elecHeadphones")]
        public BoundingBox ElecHeadphones { get; set; }

        [DataMember(Name="elecHeadset")]
        public BoundingBox ElecHeadset { get; set; }

        [DataMember(Name="elecLineIn")]
        public BoundingBox ElecLineIn { get; set; }

        [DataMember(Name="elecLineOut")]
        public BoundingBox ElecLineOut { get; set; }

        [DataMember(Name="elecLoop")]
        public BoundingBox ElecLoop { get; set; }

        [DataMember(Name="elecLoudspeaker")]
        public BoundingBox ElecLoudspeaker { get; set; }

        [DataMember(Name="elecMIDIController0")]
        public BoundingBox ElecMidiController0 { get; set; }

        [DataMember(Name="elecMIDIController100")]
        public BoundingBox ElecMidiController100 { get; set; }

        [DataMember(Name="elecMIDIController20")]
        public BoundingBox ElecMidiController20 { get; set; }

        [DataMember(Name="elecMIDIController40")]
        public BoundingBox ElecMidiController40 { get; set; }

        [DataMember(Name="elecMIDIController60")]
        public BoundingBox ElecMidiController60 { get; set; }

        [DataMember(Name="elecMIDIController80")]
        public BoundingBox ElecMidiController80 { get; set; }

        [DataMember(Name="elecMIDIIn")]
        public BoundingBox ElecMidiIn { get; set; }

        [DataMember(Name="elecMIDIOut")]
        public BoundingBox ElecMidiOut { get; set; }

        [DataMember(Name="elecMicrophone")]
        public BoundingBox ElecMicrophone { get; set; }

        [DataMember(Name="elecMicrophoneMute")]
        public BoundingBox ElecMicrophoneMute { get; set; }

        [DataMember(Name="elecMicrophoneUnmute")]
        public BoundingBox ElecMicrophoneUnmute { get; set; }

        [DataMember(Name="elecMixingConsole")]
        public BoundingBox ElecMixingConsole { get; set; }

        [DataMember(Name="elecMonitor")]
        public BoundingBox ElecMonitor { get; set; }

        [DataMember(Name="elecMute")]
        public BoundingBox ElecMute { get; set; }

        [DataMember(Name="elecPause")]
        public BoundingBox ElecPause { get; set; }

        [DataMember(Name="elecPlay")]
        public BoundingBox ElecPlay { get; set; }

        [DataMember(Name="elecPowerOnOff")]
        public BoundingBox ElecPowerOnOff { get; set; }

        [DataMember(Name="elecProjector")]
        public BoundingBox ElecProjector { get; set; }

        [DataMember(Name="elecReplay")]
        public BoundingBox ElecReplay { get; set; }

        [DataMember(Name="elecRewind")]
        public BoundingBox ElecRewind { get; set; }

        [DataMember(Name="elecShuffle")]
        public BoundingBox ElecShuffle { get; set; }

        [DataMember(Name="elecSkipBackwards")]
        public BoundingBox ElecSkipBackwards { get; set; }

        [DataMember(Name="elecSkipForwards")]
        public BoundingBox ElecSkipForwards { get; set; }

        [DataMember(Name="elecStop")]
        public BoundingBox ElecStop { get; set; }

        [DataMember(Name="elecTape")]
        public BoundingBox ElecTape { get; set; }

        [DataMember(Name="elecUSB")]
        public BoundingBox ElecUsb { get; set; }

        [DataMember(Name="elecUnmute")]
        public BoundingBox ElecUnmute { get; set; }

        [DataMember(Name="elecUpload")]
        public BoundingBox ElecUpload { get; set; }

        [DataMember(Name="elecVideoCamera")]
        public BoundingBox ElecVideoCamera { get; set; }

        [DataMember(Name="elecVideoIn")]
        public BoundingBox ElecVideoIn { get; set; }

        [DataMember(Name="elecVideoOut")]
        public BoundingBox ElecVideoOut { get; set; }

        [DataMember(Name="elecVolumeFader")]
        public BoundingBox ElecVolumeFader { get; set; }

        [DataMember(Name="elecVolumeFaderThumb")]
        public BoundingBox ElecVolumeFaderThumb { get; set; }

        [DataMember(Name="elecVolumeLevel0")]
        public BoundingBox ElecVolumeLevel0 { get; set; }

        [DataMember(Name="elecVolumeLevel100")]
        public BoundingBox ElecVolumeLevel100 { get; set; }

        [DataMember(Name="elecVolumeLevel20")]
        public BoundingBox ElecVolumeLevel20 { get; set; }

        [DataMember(Name="elecVolumeLevel40")]
        public BoundingBox ElecVolumeLevel40 { get; set; }

        [DataMember(Name="elecVolumeLevel60")]
        public BoundingBox ElecVolumeLevel60 { get; set; }

        [DataMember(Name="elecVolumeLevel80")]
        public BoundingBox ElecVolumeLevel80 { get; set; }

        [DataMember(Name="fClef")]
        public BoundingBox FClef { get; set; }

        [DataMember(Name="fClef15ma")]
        public BoundingBox FClef15Ma { get; set; }

        [DataMember(Name="fClef15mb")]
        public BoundingBox FClef15Mb { get; set; }

        [DataMember(Name="fClef19thCentury")]
        public BoundingBox FClef19ThCentury { get; set; }

        [DataMember(Name="fClef5Below")]
        public BoundingBox FClef5Below { get; set; }

        [DataMember(Name="fClef8va")]
        public BoundingBox FClef8Va { get; set; }

        [DataMember(Name="fClef8vb")]
        public BoundingBox FClef8Vb { get; set; }

        [DataMember(Name="fClefArrowDown")]
        public BoundingBox FClefArrowDown { get; set; }

        [DataMember(Name="fClefArrowUp")]
        public BoundingBox FClefArrowUp { get; set; }

        [DataMember(Name="fClefChange")]
        public BoundingBox FClefChange { get; set; }

        [DataMember(Name="fClefFrench")]
        public BoundingBox FClefFrench { get; set; }

        [DataMember(Name="fClefReversed")]
        public BoundingBox FClefReversed { get; set; }

        [DataMember(Name="fClefSmall")]
        public BoundingBox FClefSmall { get; set; }

        [DataMember(Name="fClefTurned")]
        public BoundingBox FClefTurned { get; set; }

        [DataMember(Name="fermataAbove")]
        public BoundingBox FermataAbove { get; set; }

        [DataMember(Name="fermataBelow")]
        public BoundingBox FermataBelow { get; set; }

        [DataMember(Name="fermataLongAbove")]
        public BoundingBox FermataLongAbove { get; set; }

        [DataMember(Name="fermataLongBelow")]
        public BoundingBox FermataLongBelow { get; set; }

        [DataMember(Name="fermataLongHenzeAbove")]
        public BoundingBox FermataLongHenzeAbove { get; set; }

        [DataMember(Name="fermataLongHenzeBelow")]
        public BoundingBox FermataLongHenzeBelow { get; set; }

        [DataMember(Name="fermataShortAbove")]
        public BoundingBox FermataShortAbove { get; set; }

        [DataMember(Name="fermataShortBelow")]
        public BoundingBox FermataShortBelow { get; set; }

        [DataMember(Name="fermataShortHenzeAbove")]
        public BoundingBox FermataShortHenzeAbove { get; set; }

        [DataMember(Name="fermataShortHenzeBelow")]
        public BoundingBox FermataShortHenzeBelow { get; set; }

        [DataMember(Name="fermataVeryLongAbove")]
        public BoundingBox FermataVeryLongAbove { get; set; }

        [DataMember(Name="fermataVeryLongBelow")]
        public BoundingBox FermataVeryLongBelow { get; set; }

        [DataMember(Name="fermataVeryShortAbove")]
        public BoundingBox FermataVeryShortAbove { get; set; }

        [DataMember(Name="fermataVeryShortBelow")]
        public BoundingBox FermataVeryShortBelow { get; set; }

        [DataMember(Name="figbass0")]
        public BoundingBox Figbass0 { get; set; }

        [DataMember(Name="figbass1")]
        public BoundingBox Figbass1 { get; set; }

        [DataMember(Name="figbass2")]
        public BoundingBox Figbass2 { get; set; }

        [DataMember(Name="figbass2Raised")]
        public BoundingBox Figbass2Raised { get; set; }

        [DataMember(Name="figbass3")]
        public BoundingBox Figbass3 { get; set; }

        [DataMember(Name="figbass4")]
        public BoundingBox Figbass4 { get; set; }

        [DataMember(Name="figbass4Raised")]
        public BoundingBox Figbass4Raised { get; set; }

        [DataMember(Name="figbass5")]
        public BoundingBox Figbass5 { get; set; }

        [DataMember(Name="figbass5Raised1")]
        public BoundingBox Figbass5Raised1 { get; set; }

        [DataMember(Name="figbass5Raised2")]
        public BoundingBox Figbass5Raised2 { get; set; }

        [DataMember(Name="figbass5Raised3")]
        public BoundingBox Figbass5Raised3 { get; set; }

        [DataMember(Name="figbass6")]
        public BoundingBox Figbass6 { get; set; }

        [DataMember(Name="figbass6Raised")]
        public BoundingBox Figbass6Raised { get; set; }

        [DataMember(Name="figbass6Raised2")]
        public BoundingBox Figbass6Raised2 { get; set; }

        [DataMember(Name="figbass7")]
        public BoundingBox Figbass7 { get; set; }

        [DataMember(Name="figbass7Diminished")]
        public BoundingBox Figbass7Diminished { get; set; }

        [DataMember(Name="figbass7Raised1")]
        public BoundingBox Figbass7Raised1 { get; set; }

        [DataMember(Name="figbass7Raised2")]
        public BoundingBox Figbass7Raised2 { get; set; }

        [DataMember(Name="figbass8")]
        public BoundingBox Figbass8 { get; set; }

        [DataMember(Name="figbass9")]
        public BoundingBox Figbass9 { get; set; }

        [DataMember(Name="figbass9Raised")]
        public BoundingBox Figbass9Raised { get; set; }

        [DataMember(Name="figbassBracketLeft")]
        public BoundingBox FigbassBracketLeft { get; set; }

        [DataMember(Name="figbassBracketRight")]
        public BoundingBox FigbassBracketRight { get; set; }

        [DataMember(Name="figbassCombiningLowering")]
        public BoundingBox FigbassCombiningLowering { get; set; }

        [DataMember(Name="figbassCombiningRaising")]
        public BoundingBox FigbassCombiningRaising { get; set; }

        [DataMember(Name="figbassDoubleFlat")]
        public BoundingBox FigbassDoubleFlat { get; set; }

        [DataMember(Name="figbassDoubleSharp")]
        public BoundingBox FigbassDoubleSharp { get; set; }

        [DataMember(Name="figbassFlat")]
        public BoundingBox FigbassFlat { get; set; }

        [DataMember(Name="figbassNatural")]
        public BoundingBox FigbassNatural { get; set; }

        [DataMember(Name="figbassParensLeft")]
        public BoundingBox FigbassParensLeft { get; set; }

        [DataMember(Name="figbassParensRight")]
        public BoundingBox FigbassParensRight { get; set; }

        [DataMember(Name="figbassPlus")]
        public BoundingBox FigbassPlus { get; set; }

        [DataMember(Name="figbassSharp")]
        public BoundingBox FigbassSharp { get; set; }

        [DataMember(Name="fingering0")]
        public BoundingBox Fingering0 { get; set; }

        [DataMember(Name="fingering1")]
        public BoundingBox Fingering1 { get; set; }

        [DataMember(Name="fingering2")]
        public BoundingBox Fingering2 { get; set; }

        [DataMember(Name="fingering3")]
        public BoundingBox Fingering3 { get; set; }

        [DataMember(Name="fingering4")]
        public BoundingBox Fingering4 { get; set; }

        [DataMember(Name="fingering5")]
        public BoundingBox Fingering5 { get; set; }

        [DataMember(Name="fingeringALower")]
        public BoundingBox FingeringALower { get; set; }

        [DataMember(Name="fingeringCLower")]
        public BoundingBox FingeringCLower { get; set; }

        [DataMember(Name="fingeringELower")]
        public BoundingBox FingeringELower { get; set; }

        [DataMember(Name="fingeringILower")]
        public BoundingBox FingeringILower { get; set; }

        [DataMember(Name="fingeringMLower")]
        public BoundingBox FingeringMLower { get; set; }

        [DataMember(Name="fingeringMultipleNotes")]
        public BoundingBox FingeringMultipleNotes { get; set; }

        [DataMember(Name="fingeringOLower")]
        public BoundingBox FingeringOLower { get; set; }

        [DataMember(Name="fingeringPLower")]
        public BoundingBox FingeringPLower { get; set; }

        [DataMember(Name="fingeringSubstitutionAbove")]
        public BoundingBox FingeringSubstitutionAbove { get; set; }

        [DataMember(Name="fingeringSubstitutionBelow")]
        public BoundingBox FingeringSubstitutionBelow { get; set; }

        [DataMember(Name="fingeringSubstitutionDash")]
        public BoundingBox FingeringSubstitutionDash { get; set; }

        [DataMember(Name="fingeringTLower")]
        public BoundingBox FingeringTLower { get; set; }

        [DataMember(Name="fingeringTUpper")]
        public BoundingBox FingeringTUpper { get; set; }

        [DataMember(Name="fingeringXLower")]
        public BoundingBox FingeringXLower { get; set; }

        [DataMember(Name="flag1024thDown")]
        public BoundingBox Flag1024ThDown { get; set; }

        [DataMember(Name="flag1024thDownSmall")]
        public BoundingBox Flag1024ThDownSmall { get; set; }

        [DataMember(Name="flag1024thDownStraight")]
        public BoundingBox Flag1024ThDownStraight { get; set; }

        [DataMember(Name="flag1024thUp")]
        public BoundingBox Flag1024ThUp { get; set; }

        [DataMember(Name="flag1024thUpShort")]
        public BoundingBox Flag1024ThUpShort { get; set; }

        [DataMember(Name="flag1024thUpSmall")]
        public BoundingBox Flag1024ThUpSmall { get; set; }

        [DataMember(Name="flag1024thUpStraight")]
        public BoundingBox Flag1024ThUpStraight { get; set; }

        [DataMember(Name="flag128thDown")]
        public BoundingBox Flag128ThDown { get; set; }

        [DataMember(Name="flag128thDownSmall")]
        public BoundingBox Flag128ThDownSmall { get; set; }

        [DataMember(Name="flag128thDownStraight")]
        public BoundingBox Flag128ThDownStraight { get; set; }

        [DataMember(Name="flag128thUp")]
        public BoundingBox Flag128ThUp { get; set; }

        [DataMember(Name="flag128thUpShort")]
        public BoundingBox Flag128ThUpShort { get; set; }

        [DataMember(Name="flag128thUpSmall")]
        public BoundingBox Flag128ThUpSmall { get; set; }

        [DataMember(Name="flag128thUpStraight")]
        public BoundingBox Flag128ThUpStraight { get; set; }

        [DataMember(Name="flag16thDown")]
        public BoundingBox Flag16ThDown { get; set; }

        [DataMember(Name="flag16thDownSmall")]
        public BoundingBox Flag16ThDownSmall { get; set; }

        [DataMember(Name="flag16thDownStraight")]
        public BoundingBox Flag16ThDownStraight { get; set; }

        [DataMember(Name="flag16thUp")]
        public BoundingBox Flag16ThUp { get; set; }

        [DataMember(Name="flag16thUpShort")]
        public BoundingBox Flag16ThUpShort { get; set; }

        [DataMember(Name="flag16thUpSmall")]
        public BoundingBox Flag16ThUpSmall { get; set; }

        [DataMember(Name="flag16thUpStraight")]
        public BoundingBox Flag16ThUpStraight { get; set; }

        [DataMember(Name="flag256thDown")]
        public BoundingBox Flag256ThDown { get; set; }

        [DataMember(Name="flag256thDownSmall")]
        public BoundingBox Flag256ThDownSmall { get; set; }

        [DataMember(Name="flag256thDownStraight")]
        public BoundingBox Flag256ThDownStraight { get; set; }

        [DataMember(Name="flag256thUp")]
        public BoundingBox Flag256ThUp { get; set; }

        [DataMember(Name="flag256thUpShort")]
        public BoundingBox Flag256ThUpShort { get; set; }

        [DataMember(Name="flag256thUpSmall")]
        public BoundingBox Flag256ThUpSmall { get; set; }

        [DataMember(Name="flag256thUpStraight")]
        public BoundingBox Flag256ThUpStraight { get; set; }

        [DataMember(Name="flag32ndDown")]
        public BoundingBox Flag32NdDown { get; set; }

        [DataMember(Name="flag32ndDownSmall")]
        public BoundingBox Flag32NdDownSmall { get; set; }

        [DataMember(Name="flag32ndDownStraight")]
        public BoundingBox Flag32NdDownStraight { get; set; }

        [DataMember(Name="flag32ndUp")]
        public BoundingBox Flag32NdUp { get; set; }

        [DataMember(Name="flag32ndUpShort")]
        public BoundingBox Flag32NdUpShort { get; set; }

        [DataMember(Name="flag32ndUpSmall")]
        public BoundingBox Flag32NdUpSmall { get; set; }

        [DataMember(Name="flag32ndUpStraight")]
        public BoundingBox Flag32NdUpStraight { get; set; }

        [DataMember(Name="flag512thDown")]
        public BoundingBox Flag512ThDown { get; set; }

        [DataMember(Name="flag512thDownSmall")]
        public BoundingBox Flag512ThDownSmall { get; set; }

        [DataMember(Name="flag512thDownStraight")]
        public BoundingBox Flag512ThDownStraight { get; set; }

        [DataMember(Name="flag512thUp")]
        public BoundingBox Flag512ThUp { get; set; }

        [DataMember(Name="flag512thUpShort")]
        public BoundingBox Flag512ThUpShort { get; set; }

        [DataMember(Name="flag512thUpSmall")]
        public BoundingBox Flag512ThUpSmall { get; set; }

        [DataMember(Name="flag512thUpStraight")]
        public BoundingBox Flag512ThUpStraight { get; set; }

        [DataMember(Name="flag64thDown")]
        public BoundingBox Flag64ThDown { get; set; }

        [DataMember(Name="flag64thDownSmall")]
        public BoundingBox Flag64ThDownSmall { get; set; }

        [DataMember(Name="flag64thDownStraight")]
        public BoundingBox Flag64ThDownStraight { get; set; }

        [DataMember(Name="flag64thUp")]
        public BoundingBox Flag64ThUp { get; set; }

        [DataMember(Name="flag64thUpShort")]
        public BoundingBox Flag64ThUpShort { get; set; }

        [DataMember(Name="flag64thUpSmall")]
        public BoundingBox Flag64ThUpSmall { get; set; }

        [DataMember(Name="flag64thUpStraight")]
        public BoundingBox Flag64ThUpStraight { get; set; }

        [DataMember(Name="flag8thDown")]
        public BoundingBox Flag8ThDown { get; set; }

        [DataMember(Name="flag8thDownSmall")]
        public BoundingBox Flag8ThDownSmall { get; set; }

        [DataMember(Name="flag8thDownStraight")]
        public BoundingBox Flag8ThDownStraight { get; set; }

        [DataMember(Name="flag8thUp")]
        public BoundingBox Flag8ThUp { get; set; }

        [DataMember(Name="flag8thUpShort")]
        public BoundingBox Flag8ThUpShort { get; set; }

        [DataMember(Name="flag8thUpSmall")]
        public BoundingBox Flag8ThUpSmall { get; set; }

        [DataMember(Name="flag8thUpStraight")]
        public BoundingBox Flag8ThUpStraight { get; set; }

        [DataMember(Name="flagInternalDown")]
        public BoundingBox FlagInternalDown { get; set; }

        [DataMember(Name="flagInternalUp")]
        public BoundingBox FlagInternalUp { get; set; }

        [DataMember(Name="fretboard3String")]
        public BoundingBox Fretboard3String { get; set; }

        [DataMember(Name="fretboard3StringNut")]
        public BoundingBox Fretboard3StringNut { get; set; }

        [DataMember(Name="fretboard4String")]
        public BoundingBox Fretboard4String { get; set; }

        [DataMember(Name="fretboard4StringNut")]
        public BoundingBox Fretboard4StringNut { get; set; }

        [DataMember(Name="fretboard5String")]
        public BoundingBox Fretboard5String { get; set; }

        [DataMember(Name="fretboard5StringNut")]
        public BoundingBox Fretboard5StringNut { get; set; }

        [DataMember(Name="fretboard6String")]
        public BoundingBox Fretboard6String { get; set; }

        [DataMember(Name="fretboard6StringNut")]
        public BoundingBox Fretboard6StringNut { get; set; }

        [DataMember(Name="fretboardFilledCircle")]
        public BoundingBox FretboardFilledCircle { get; set; }

        [DataMember(Name="fretboardO")]
        public BoundingBox FretboardO { get; set; }

        [DataMember(Name="fretboardX")]
        public BoundingBox FretboardX { get; set; }

        [DataMember(Name="functionAngleLeft")]
        public BoundingBox FunctionAngleLeft { get; set; }

        [DataMember(Name="functionAngleRight")]
        public BoundingBox FunctionAngleRight { get; set; }

        [DataMember(Name="functionBracketLeft")]
        public BoundingBox FunctionBracketLeft { get; set; }

        [DataMember(Name="functionBracketRight")]
        public BoundingBox FunctionBracketRight { get; set; }

        [DataMember(Name="functionDD")]
        public BoundingBox FunctionDd { get; set; }

        [DataMember(Name="functionDLower")]
        public BoundingBox FunctionDLower { get; set; }

        [DataMember(Name="functionDUpper")]
        public BoundingBox FunctionDUpper { get; set; }

        [DataMember(Name="functionEight")]
        public BoundingBox FunctionEight { get; set; }

        [DataMember(Name="functionFUpper")]
        public BoundingBox FunctionFUpper { get; set; }

        [DataMember(Name="functionFive")]
        public BoundingBox FunctionFive { get; set; }

        [DataMember(Name="functionFour")]
        public BoundingBox FunctionFour { get; set; }

        [DataMember(Name="functionGLower")]
        public BoundingBox FunctionGLower { get; set; }

        [DataMember(Name="functionGUpper")]
        public BoundingBox FunctionGUpper { get; set; }

        [DataMember(Name="functionGreaterThan")]
        public BoundingBox FunctionGreaterThan { get; set; }

        [DataMember(Name="functionILower")]
        public BoundingBox FunctionILower { get; set; }

        [DataMember(Name="functionIUpper")]
        public BoundingBox FunctionIUpper { get; set; }

        [DataMember(Name="functionKLower")]
        public BoundingBox FunctionKLower { get; set; }

        [DataMember(Name="functionKUpper")]
        public BoundingBox FunctionKUpper { get; set; }

        [DataMember(Name="functionLLower")]
        public BoundingBox FunctionLLower { get; set; }

        [DataMember(Name="functionLUpper")]
        public BoundingBox FunctionLUpper { get; set; }

        [DataMember(Name="functionLessThan")]
        public BoundingBox FunctionLessThan { get; set; }

        [DataMember(Name="functionMLower")]
        public BoundingBox FunctionMLower { get; set; }

        [DataMember(Name="functionMUpper")]
        public BoundingBox FunctionMUpper { get; set; }

        [DataMember(Name="functionMinus")]
        public BoundingBox FunctionMinus { get; set; }

        [DataMember(Name="functionNLower")]
        public BoundingBox FunctionNLower { get; set; }

        [DataMember(Name="functionNUpper")]
        public BoundingBox FunctionNUpper { get; set; }

        [DataMember(Name="functionNUpperSuperscript")]
        public BoundingBox FunctionNUpperSuperscript { get; set; }

        [DataMember(Name="functionNine")]
        public BoundingBox FunctionNine { get; set; }

        [DataMember(Name="functionOne")]
        public BoundingBox FunctionOne { get; set; }

        [DataMember(Name="functionPLower")]
        public BoundingBox FunctionPLower { get; set; }

        [DataMember(Name="functionPUpper")]
        public BoundingBox FunctionPUpper { get; set; }

        [DataMember(Name="functionParensLeft")]
        public BoundingBox FunctionParensLeft { get; set; }

        [DataMember(Name="functionParensRight")]
        public BoundingBox FunctionParensRight { get; set; }

        [DataMember(Name="functionPlus")]
        public BoundingBox FunctionPlus { get; set; }

        [DataMember(Name="functionRLower")]
        public BoundingBox FunctionRLower { get; set; }

        [DataMember(Name="functionRepetition1")]
        public BoundingBox FunctionRepetition1 { get; set; }

        [DataMember(Name="functionRepetition2")]
        public BoundingBox FunctionRepetition2 { get; set; }

        [DataMember(Name="functionRing")]
        public BoundingBox FunctionRing { get; set; }

        [DataMember(Name="functionSLower")]
        public BoundingBox FunctionSLower { get; set; }

        [DataMember(Name="functionSSLower")]
        public BoundingBox FunctionSsLower { get; set; }

        [DataMember(Name="functionSSUpper")]
        public BoundingBox FunctionSsUpper { get; set; }

        [DataMember(Name="functionSUpper")]
        public BoundingBox FunctionSUpper { get; set; }

        [DataMember(Name="functionSeven")]
        public BoundingBox FunctionSeven { get; set; }

        [DataMember(Name="functionSix")]
        public BoundingBox FunctionSix { get; set; }

        [DataMember(Name="functionSlashedDD")]
        public BoundingBox FunctionSlashedDd { get; set; }

        [DataMember(Name="functionTLower")]
        public BoundingBox FunctionTLower { get; set; }

        [DataMember(Name="functionTUpper")]
        public BoundingBox FunctionTUpper { get; set; }

        [DataMember(Name="functionThree")]
        public BoundingBox FunctionThree { get; set; }

        [DataMember(Name="functionTwo")]
        public BoundingBox FunctionTwo { get; set; }

        [DataMember(Name="functionVLower")]
        public BoundingBox FunctionVLower { get; set; }

        [DataMember(Name="functionVUpper")]
        public BoundingBox FunctionVUpper { get; set; }

        [DataMember(Name="functionZero")]
        public BoundingBox FunctionZero { get; set; }

        [DataMember(Name="gClef")]
        public BoundingBox GClef { get; set; }

        [DataMember(Name="gClef0Below")]
        public BoundingBox GClef0Below { get; set; }

        [DataMember(Name="gClef10Below")]
        public BoundingBox GClef10Below { get; set; }

        [DataMember(Name="gClef11Below")]
        public BoundingBox GClef11Below { get; set; }

        [DataMember(Name="gClef12Below")]
        public BoundingBox GClef12Below { get; set; }

        [DataMember(Name="gClef13Below")]
        public BoundingBox GClef13Below { get; set; }

        [DataMember(Name="gClef14Below")]
        public BoundingBox GClef14Below { get; set; }

        [DataMember(Name="gClef15Below")]
        public BoundingBox GClef15Below { get; set; }

        [DataMember(Name="gClef15ma")]
        public BoundingBox GClef15Ma { get; set; }

        [DataMember(Name="gClef15mb")]
        public BoundingBox GClef15Mb { get; set; }

        [DataMember(Name="gClef16Below")]
        public BoundingBox GClef16Below { get; set; }

        [DataMember(Name="gClef17Below")]
        public BoundingBox GClef17Below { get; set; }

        [DataMember(Name="gClef2Above")]
        public BoundingBox GClef2Above { get; set; }

        [DataMember(Name="gClef2Below")]
        public BoundingBox GClef2Below { get; set; }

        [DataMember(Name="gClef3Above")]
        public BoundingBox GClef3Above { get; set; }

        [DataMember(Name="gClef3Below")]
        public BoundingBox GClef3Below { get; set; }

        [DataMember(Name="gClef4Above")]
        public BoundingBox GClef4Above { get; set; }

        [DataMember(Name="gClef4Below")]
        public BoundingBox GClef4Below { get; set; }

        [DataMember(Name="gClef5Above")]
        public BoundingBox GClef5Above { get; set; }

        [DataMember(Name="gClef5Below")]
        public BoundingBox GClef5Below { get; set; }

        [DataMember(Name="gClef6Above")]
        public BoundingBox GClef6Above { get; set; }

        [DataMember(Name="gClef6Below")]
        public BoundingBox GClef6Below { get; set; }

        [DataMember(Name="gClef7Above")]
        public BoundingBox GClef7Above { get; set; }

        [DataMember(Name="gClef7Below")]
        public BoundingBox GClef7Below { get; set; }

        [DataMember(Name="gClef8Above")]
        public BoundingBox GClef8Above { get; set; }

        [DataMember(Name="gClef8Below")]
        public BoundingBox GClef8Below { get; set; }

        [DataMember(Name="gClef8va")]
        public BoundingBox GClef8Va { get; set; }

        [DataMember(Name="gClef8vb")]
        public BoundingBox GClef8Vb { get; set; }

        [DataMember(Name="gClef8vbCClef")]
        public BoundingBox GClef8VbCClef { get; set; }

        [DataMember(Name="gClef8vbOld")]
        public BoundingBox GClef8VbOld { get; set; }

        [DataMember(Name="gClef8vbParens")]
        public BoundingBox GClef8VbParens { get; set; }

        [DataMember(Name="gClef9Above")]
        public BoundingBox GClef9Above { get; set; }

        [DataMember(Name="gClef9Below")]
        public BoundingBox GClef9Below { get; set; }

        [DataMember(Name="gClefArrowDown")]
        public BoundingBox GClefArrowDown { get; set; }

        [DataMember(Name="gClefArrowUp")]
        public BoundingBox GClefArrowUp { get; set; }

        [DataMember(Name="gClefChange")]
        public BoundingBox GClefChange { get; set; }

        [DataMember(Name="gClefFlat10Below")]
        public BoundingBox GClefFlat10Below { get; set; }

        [DataMember(Name="gClefFlat11Below")]
        public BoundingBox GClefFlat11Below { get; set; }

        [DataMember(Name="gClefFlat13Below")]
        public BoundingBox GClefFlat13Below { get; set; }

        [DataMember(Name="gClefFlat14Below")]
        public BoundingBox GClefFlat14Below { get; set; }

        [DataMember(Name="gClefFlat15Below")]
        public BoundingBox GClefFlat15Below { get; set; }

        [DataMember(Name="gClefFlat16Below")]
        public BoundingBox GClefFlat16Below { get; set; }

        [DataMember(Name="gClefFlat1Below")]
        public BoundingBox GClefFlat1Below { get; set; }

        [DataMember(Name="gClefFlat2Above")]
        public BoundingBox GClefFlat2Above { get; set; }

        [DataMember(Name="gClefFlat2Below")]
        public BoundingBox GClefFlat2Below { get; set; }

        [DataMember(Name="gClefFlat3Above")]
        public BoundingBox GClefFlat3Above { get; set; }

        [DataMember(Name="gClefFlat3Below")]
        public BoundingBox GClefFlat3Below { get; set; }

        [DataMember(Name="gClefFlat4Below")]
        public BoundingBox GClefFlat4Below { get; set; }

        [DataMember(Name="gClefFlat5Above")]
        public BoundingBox GClefFlat5Above { get; set; }

        [DataMember(Name="gClefFlat6Above")]
        public BoundingBox GClefFlat6Above { get; set; }

        [DataMember(Name="gClefFlat6Below")]
        public BoundingBox GClefFlat6Below { get; set; }

        [DataMember(Name="gClefFlat7Above")]
        public BoundingBox GClefFlat7Above { get; set; }

        [DataMember(Name="gClefFlat7Below")]
        public BoundingBox GClefFlat7Below { get; set; }

        [DataMember(Name="gClefFlat8Above")]
        public BoundingBox GClefFlat8Above { get; set; }

        [DataMember(Name="gClefFlat9Above")]
        public BoundingBox GClefFlat9Above { get; set; }

        [DataMember(Name="gClefFlat9Below")]
        public BoundingBox GClefFlat9Below { get; set; }

        [DataMember(Name="gClefLigatedNumberAbove")]
        public BoundingBox GClefLigatedNumberAbove { get; set; }

        [DataMember(Name="gClefLigatedNumberBelow")]
        public BoundingBox GClefLigatedNumberBelow { get; set; }

        [DataMember(Name="gClefNat2Below")]
        public BoundingBox GClefNat2Below { get; set; }

        [DataMember(Name="gClefNatural10Below")]
        public BoundingBox GClefNatural10Below { get; set; }

        [DataMember(Name="gClefNatural13Below")]
        public BoundingBox GClefNatural13Below { get; set; }

        [DataMember(Name="gClefNatural17Below")]
        public BoundingBox GClefNatural17Below { get; set; }

        [DataMember(Name="gClefNatural2Above")]
        public BoundingBox GClefNatural2Above { get; set; }

        [DataMember(Name="gClefNatural3Above")]
        public BoundingBox GClefNatural3Above { get; set; }

        [DataMember(Name="gClefNatural3Below")]
        public BoundingBox GClefNatural3Below { get; set; }

        [DataMember(Name="gClefNatural6Above")]
        public BoundingBox GClefNatural6Above { get; set; }

        [DataMember(Name="gClefNatural6Below")]
        public BoundingBox GClefNatural6Below { get; set; }

        [DataMember(Name="gClefNatural7Above")]
        public BoundingBox GClefNatural7Above { get; set; }

        [DataMember(Name="gClefNatural9Above")]
        public BoundingBox GClefNatural9Above { get; set; }

        [DataMember(Name="gClefNatural9Below")]
        public BoundingBox GClefNatural9Below { get; set; }

        [DataMember(Name="gClefReversed")]
        public BoundingBox GClefReversed { get; set; }

        [DataMember(Name="gClefSharp12Below")]
        public BoundingBox GClefSharp12Below { get; set; }

        [DataMember(Name="gClefSharp1Above")]
        public BoundingBox GClefSharp1Above { get; set; }

        [DataMember(Name="gClefSharp4Above")]
        public BoundingBox GClefSharp4Above { get; set; }

        [DataMember(Name="gClefSharp5Below")]
        public BoundingBox GClefSharp5Below { get; set; }

        [DataMember(Name="gClefSmall")]
        public BoundingBox GClefSmall { get; set; }

        [DataMember(Name="gClefTurned")]
        public BoundingBox GClefTurned { get; set; }

        [DataMember(Name="glissandoDown")]
        public BoundingBox GlissandoDown { get; set; }

        [DataMember(Name="glissandoUp")]
        public BoundingBox GlissandoUp { get; set; }

        [DataMember(Name="graceNoteAcciaccaturaStemDown")]
        public BoundingBox GraceNoteAcciaccaturaStemDown { get; set; }

        [DataMember(Name="graceNoteAcciaccaturaStemUp")]
        public BoundingBox GraceNoteAcciaccaturaStemUp { get; set; }

        [DataMember(Name="graceNoteAppoggiaturaStemDown")]
        public BoundingBox GraceNoteAppoggiaturaStemDown { get; set; }

        [DataMember(Name="graceNoteAppoggiaturaStemUp")]
        public BoundingBox GraceNoteAppoggiaturaStemUp { get; set; }

        [DataMember(Name="graceNoteSlashStemDown")]
        public BoundingBox GraceNoteSlashStemDown { get; set; }

        [DataMember(Name="graceNoteSlashStemUp")]
        public BoundingBox GraceNoteSlashStemUp { get; set; }

        [DataMember(Name="guitarBarreFull")]
        public BoundingBox GuitarBarreFull { get; set; }

        [DataMember(Name="guitarBarreHalf")]
        public BoundingBox GuitarBarreHalf { get; set; }

        [DataMember(Name="guitarBarreHalfHorizontalFractionSlash")]
        public BoundingBox GuitarBarreHalfHorizontalFractionSlash { get; set; }

        [DataMember(Name="guitarClosePedal")]
        public BoundingBox GuitarClosePedal { get; set; }

        [DataMember(Name="guitarFadeIn")]
        public BoundingBox GuitarFadeIn { get; set; }

        [DataMember(Name="guitarFadeOut")]
        public BoundingBox GuitarFadeOut { get; set; }

        [DataMember(Name="guitarGolpe")]
        public BoundingBox GuitarGolpe { get; set; }

        [DataMember(Name="guitarGolpeFlamenco")]
        public BoundingBox GuitarGolpeFlamenco { get; set; }

        [DataMember(Name="guitarHalfOpenPedal")]
        public BoundingBox GuitarHalfOpenPedal { get; set; }

        [DataMember(Name="guitarLeftHandTapping")]
        public BoundingBox GuitarLeftHandTapping { get; set; }

        [DataMember(Name="guitarOpenPedal")]
        public BoundingBox GuitarOpenPedal { get; set; }

        [DataMember(Name="guitarRightHandTapping")]
        public BoundingBox GuitarRightHandTapping { get; set; }

        [DataMember(Name="guitarShake")]
        public BoundingBox GuitarShake { get; set; }

        [DataMember(Name="guitarString0")]
        public BoundingBox GuitarString0 { get; set; }

        [DataMember(Name="guitarString1")]
        public BoundingBox GuitarString1 { get; set; }

        [DataMember(Name="guitarString2")]
        public BoundingBox GuitarString2 { get; set; }

        [DataMember(Name="guitarString3")]
        public BoundingBox GuitarString3 { get; set; }

        [DataMember(Name="guitarString4")]
        public BoundingBox GuitarString4 { get; set; }

        [DataMember(Name="guitarString5")]
        public BoundingBox GuitarString5 { get; set; }

        [DataMember(Name="guitarString6")]
        public BoundingBox GuitarString6 { get; set; }

        [DataMember(Name="guitarString7")]
        public BoundingBox GuitarString7 { get; set; }

        [DataMember(Name="guitarString8")]
        public BoundingBox GuitarString8 { get; set; }

        [DataMember(Name="guitarString9")]
        public BoundingBox GuitarString9 { get; set; }

        [DataMember(Name="guitarStrumDown")]
        public BoundingBox GuitarStrumDown { get; set; }

        [DataMember(Name="guitarStrumUp")]
        public BoundingBox GuitarStrumUp { get; set; }

        [DataMember(Name="guitarVibratoBarDip")]
        public BoundingBox GuitarVibratoBarDip { get; set; }

        [DataMember(Name="guitarVibratoBarScoop")]
        public BoundingBox GuitarVibratoBarScoop { get; set; }

        [DataMember(Name="guitarVibratoStroke")]
        public BoundingBox GuitarVibratoStroke { get; set; }

        [DataMember(Name="guitarVolumeSwell")]
        public BoundingBox GuitarVolumeSwell { get; set; }

        [DataMember(Name="guitarWideVibratoStroke")]
        public BoundingBox GuitarWideVibratoStroke { get; set; }

        [DataMember(Name="handbellsBelltree")]
        public BoundingBox HandbellsBelltree { get; set; }

        [DataMember(Name="handbellsDamp3")]
        public BoundingBox HandbellsDamp3 { get; set; }

        [DataMember(Name="handbellsEcho1")]
        public BoundingBox HandbellsEcho1 { get; set; }

        [DataMember(Name="handbellsEcho2")]
        public BoundingBox HandbellsEcho2 { get; set; }

        [DataMember(Name="handbellsGyro")]
        public BoundingBox HandbellsGyro { get; set; }

        [DataMember(Name="handbellsHandMartellato")]
        public BoundingBox HandbellsHandMartellato { get; set; }

        [DataMember(Name="handbellsMalletBellOnTable")]
        public BoundingBox HandbellsMalletBellOnTable { get; set; }

        [DataMember(Name="handbellsMalletBellSuspended")]
        public BoundingBox HandbellsMalletBellSuspended { get; set; }

        [DataMember(Name="handbellsMalletLft")]
        public BoundingBox HandbellsMalletLft { get; set; }

        [DataMember(Name="handbellsMartellato")]
        public BoundingBox HandbellsMartellato { get; set; }

        [DataMember(Name="handbellsMartellatoLift")]
        public BoundingBox HandbellsMartellatoLift { get; set; }

        [DataMember(Name="handbellsMutedMartellato")]
        public BoundingBox HandbellsMutedMartellato { get; set; }

        [DataMember(Name="handbellsPluckLift")]
        public BoundingBox HandbellsPluckLift { get; set; }

        [DataMember(Name="handbellsSwing")]
        public BoundingBox HandbellsSwing { get; set; }

        [DataMember(Name="handbellsSwingDown")]
        public BoundingBox HandbellsSwingDown { get; set; }

        [DataMember(Name="handbellsSwingUp")]
        public BoundingBox HandbellsSwingUp { get; set; }

        [DataMember(Name="handbellsTablePairBells")]
        public BoundingBox HandbellsTablePairBells { get; set; }

        [DataMember(Name="handbellsTableSingleBell")]
        public BoundingBox HandbellsTableSingleBell { get; set; }

        [DataMember(Name="harpMetalRod")]
        public BoundingBox HarpMetalRod { get; set; }

        [DataMember(Name="harpMetalRodAlt")]
        public BoundingBox HarpMetalRodAlt { get; set; }

        [DataMember(Name="harpPedalCentered")]
        public BoundingBox HarpPedalCentered { get; set; }

        [DataMember(Name="harpPedalDivider")]
        public Dictionary<string, long[]> HarpPedalDivider { get; set; }

        [DataMember(Name="harpPedalLowered")]
        public BoundingBox HarpPedalLowered { get; set; }

        [DataMember(Name="harpPedalRaised")]
        public BoundingBox HarpPedalRaised { get; set; }

        [DataMember(Name="harpSalzedoAeolianAscending")]
        public BoundingBox HarpSalzedoAeolianAscending { get; set; }

        [DataMember(Name="harpSalzedoAeolianDescending")]
        public BoundingBox HarpSalzedoAeolianDescending { get; set; }

        [DataMember(Name="harpSalzedoDampAbove")]
        public BoundingBox HarpSalzedoDampAbove { get; set; }

        [DataMember(Name="harpSalzedoDampBelow")]
        public BoundingBox HarpSalzedoDampBelow { get; set; }

        [DataMember(Name="harpSalzedoDampBothHands")]
        public BoundingBox HarpSalzedoDampBothHands { get; set; }

        [DataMember(Name="harpSalzedoDampLowStrings")]
        public BoundingBox HarpSalzedoDampLowStrings { get; set; }

        [DataMember(Name="harpSalzedoFluidicSoundsLeft")]
        public BoundingBox HarpSalzedoFluidicSoundsLeft { get; set; }

        [DataMember(Name="harpSalzedoFluidicSoundsRight")]
        public BoundingBox HarpSalzedoFluidicSoundsRight { get; set; }

        [DataMember(Name="harpSalzedoIsolatedSounds")]
        public BoundingBox HarpSalzedoIsolatedSounds { get; set; }

        [DataMember(Name="harpSalzedoMetallicSounds")]
        public BoundingBox HarpSalzedoMetallicSounds { get; set; }

        [DataMember(Name="harpSalzedoMetallicSoundsOneString")]
        public BoundingBox HarpSalzedoMetallicSoundsOneString { get; set; }

        [DataMember(Name="harpSalzedoMuffleTotally")]
        public BoundingBox HarpSalzedoMuffleTotally { get; set; }

        [DataMember(Name="harpSalzedoOboicFlux")]
        public BoundingBox HarpSalzedoOboicFlux { get; set; }

        [DataMember(Name="harpSalzedoPlayUpperEnd")]
        public BoundingBox HarpSalzedoPlayUpperEnd { get; set; }

        [DataMember(Name="harpSalzedoSlideWithSuppleness")]
        public BoundingBox HarpSalzedoSlideWithSuppleness { get; set; }

        [DataMember(Name="harpSalzedoSnareDrum")]
        public Dictionary<string, long[]> HarpSalzedoSnareDrum { get; set; }

        [DataMember(Name="harpSalzedoTamTamSounds")]
        public BoundingBox HarpSalzedoTamTamSounds { get; set; }

        [DataMember(Name="harpSalzedoThunderEffect")]
        public BoundingBox HarpSalzedoThunderEffect { get; set; }

        [DataMember(Name="harpSalzedoTimpanicSounds")]
        public BoundingBox HarpSalzedoTimpanicSounds { get; set; }

        [DataMember(Name="harpSalzedoWhistlingSounds")]
        public BoundingBox HarpSalzedoWhistlingSounds { get; set; }

        [DataMember(Name="harpStringNoiseStem")]
        public BoundingBox HarpStringNoiseStem { get; set; }

        [DataMember(Name="harpTuningKey")]
        public BoundingBox HarpTuningKey { get; set; }

        [DataMember(Name="harpTuningKeyAlt")]
        public BoundingBox HarpTuningKeyAlt { get; set; }

        [DataMember(Name="harpTuningKeyGlissando")]
        public BoundingBox HarpTuningKeyGlissando { get; set; }

        [DataMember(Name="harpTuningKeyHandle")]
        public BoundingBox HarpTuningKeyHandle { get; set; }

        [DataMember(Name="harpTuningKeyShank")]
        public BoundingBox HarpTuningKeyShank { get; set; }

        [DataMember(Name="keyboardBebung2DotsAbove")]
        public BoundingBox KeyboardBebung2DotsAbove { get; set; }

        [DataMember(Name="keyboardBebung2DotsBelow")]
        public BoundingBox KeyboardBebung2DotsBelow { get; set; }

        [DataMember(Name="keyboardBebung3DotsAbove")]
        public BoundingBox KeyboardBebung3DotsAbove { get; set; }

        [DataMember(Name="keyboardBebung3DotsBelow")]
        public BoundingBox KeyboardBebung3DotsBelow { get; set; }

        [DataMember(Name="keyboardBebung4DotsAbove")]
        public BoundingBox KeyboardBebung4DotsAbove { get; set; }

        [DataMember(Name="keyboardBebung4DotsBelow")]
        public BoundingBox KeyboardBebung4DotsBelow { get; set; }

        [DataMember(Name="keyboardLeftPedalPictogram")]
        public BoundingBox KeyboardLeftPedalPictogram { get; set; }

        [DataMember(Name="keyboardMiddlePedalPictogram")]
        public BoundingBox KeyboardMiddlePedalPictogram { get; set; }

        [DataMember(Name="keyboardPedalD")]
        public BoundingBox KeyboardPedalD { get; set; }

        [DataMember(Name="keyboardPedalDot")]
        public BoundingBox KeyboardPedalDot { get; set; }

        [DataMember(Name="keyboardPedalE")]
        public BoundingBox KeyboardPedalE { get; set; }

        [DataMember(Name="keyboardPedalHalf")]
        public BoundingBox KeyboardPedalHalf { get; set; }

        [DataMember(Name="keyboardPedalHalf2")]
        public BoundingBox KeyboardPedalHalf2 { get; set; }

        [DataMember(Name="keyboardPedalHalf3")]
        public BoundingBox KeyboardPedalHalf3 { get; set; }

        [DataMember(Name="keyboardPedalHeel1")]
        public BoundingBox KeyboardPedalHeel1 { get; set; }

        [DataMember(Name="keyboardPedalHeel2")]
        public BoundingBox KeyboardPedalHeel2 { get; set; }

        [DataMember(Name="keyboardPedalHeel3")]
        public Dictionary<string, long[]> KeyboardPedalHeel3 { get; set; }

        [DataMember(Name="keyboardPedalHeelToToe")]
        public BoundingBox KeyboardPedalHeelToToe { get; set; }

        [DataMember(Name="keyboardPedalHeelToe")]
        public BoundingBox KeyboardPedalHeelToe { get; set; }

        [DataMember(Name="keyboardPedalHookEnd")]
        public BoundingBox KeyboardPedalHookEnd { get; set; }

        [DataMember(Name="keyboardPedalHookStart")]
        public BoundingBox KeyboardPedalHookStart { get; set; }

        [DataMember(Name="keyboardPedalHyphen")]
        public BoundingBox KeyboardPedalHyphen { get; set; }

        [DataMember(Name="keyboardPedalP")]
        public BoundingBox KeyboardPedalP { get; set; }

        [DataMember(Name="keyboardPedalPed")]
        public BoundingBox KeyboardPedalPed { get; set; }

        [DataMember(Name="keyboardPedalPedNoDot")]
        public BoundingBox KeyboardPedalPedNoDot { get; set; }

        [DataMember(Name="keyboardPedalS")]
        public BoundingBox KeyboardPedalS { get; set; }

        [DataMember(Name="keyboardPedalSost")]
        public BoundingBox KeyboardPedalSost { get; set; }

        [DataMember(Name="keyboardPedalSostNoDot")]
        public BoundingBox KeyboardPedalSostNoDot { get; set; }

        [DataMember(Name="keyboardPedalToe1")]
        public BoundingBox KeyboardPedalToe1 { get; set; }

        [DataMember(Name="keyboardPedalToe2")]
        public BoundingBox KeyboardPedalToe2 { get; set; }

        [DataMember(Name="keyboardPedalToeToHeel")]
        public BoundingBox KeyboardPedalToeToHeel { get; set; }

        [DataMember(Name="keyboardPedalUp")]
        public BoundingBox KeyboardPedalUp { get; set; }

        [DataMember(Name="keyboardPedalUpNotch")]
        public BoundingBox KeyboardPedalUpNotch { get; set; }

        [DataMember(Name="keyboardPedalUpSpecial")]
        public BoundingBox KeyboardPedalUpSpecial { get; set; }

        [DataMember(Name="keyboardPlayWithLH")]
        public BoundingBox KeyboardPlayWithLh { get; set; }

        [DataMember(Name="keyboardPlayWithLHEnd")]
        public BoundingBox KeyboardPlayWithLhEnd { get; set; }

        [DataMember(Name="keyboardPlayWithRH")]
        public BoundingBox KeyboardPlayWithRh { get; set; }

        [DataMember(Name="keyboardPlayWithRHEnd")]
        public BoundingBox KeyboardPlayWithRhEnd { get; set; }

        [DataMember(Name="keyboardPluckInside")]
        public BoundingBox KeyboardPluckInside { get; set; }

        [DataMember(Name="keyboardRightPedalPictogram")]
        public BoundingBox KeyboardRightPedalPictogram { get; set; }

        [DataMember(Name="kievanAccidentalFlat")]
        public BoundingBox KievanAccidentalFlat { get; set; }

        [DataMember(Name="kievanAccidentalSharp")]
        public BoundingBox KievanAccidentalSharp { get; set; }

        [DataMember(Name="kievanAugmentationDot")]
        public BoundingBox KievanAugmentationDot { get; set; }

        [DataMember(Name="kievanCClef")]
        public BoundingBox KievanCClef { get; set; }

        [DataMember(Name="kievanEndingSymbol")]
        public BoundingBox KievanEndingSymbol { get; set; }

        [DataMember(Name="kievanNote8thStemDown")]
        public BoundingBox KievanNote8ThStemDown { get; set; }

        [DataMember(Name="kievanNote8thStemUp")]
        public BoundingBox KievanNote8ThStemUp { get; set; }

        [DataMember(Name="kievanNoteBeam")]
        public BoundingBox KievanNoteBeam { get; set; }

        [DataMember(Name="kievanNoteHalfStaffLine")]
        public BoundingBox KievanNoteHalfStaffLine { get; set; }

        [DataMember(Name="kievanNoteHalfStaffSpace")]
        public BoundingBox KievanNoteHalfStaffSpace { get; set; }

        [DataMember(Name="kievanNoteQuarterStemDown")]
        public BoundingBox KievanNoteQuarterStemDown { get; set; }

        [DataMember(Name="kievanNoteQuarterStemUp")]
        public BoundingBox KievanNoteQuarterStemUp { get; set; }

        [DataMember(Name="kievanNoteReciting")]
        public BoundingBox KievanNoteReciting { get; set; }

        [DataMember(Name="kievanNoteWhole")]
        public BoundingBox KievanNoteWhole { get; set; }

        [DataMember(Name="kievanNoteWholeFinal")]
        public BoundingBox KievanNoteWholeFinal { get; set; }

        [DataMember(Name="kodalyHandDo")]
        public BoundingBox KodalyHandDo { get; set; }

        [DataMember(Name="kodalyHandFa")]
        public BoundingBox KodalyHandFa { get; set; }

        [DataMember(Name="kodalyHandLa")]
        public BoundingBox KodalyHandLa { get; set; }

        [DataMember(Name="kodalyHandMi")]
        public BoundingBox KodalyHandMi { get; set; }

        [DataMember(Name="kodalyHandRe")]
        public BoundingBox KodalyHandRe { get; set; }

        [DataMember(Name="kodalyHandSo")]
        public BoundingBox KodalyHandSo { get; set; }

        [DataMember(Name="kodalyHandTi")]
        public BoundingBox KodalyHandTi { get; set; }

        [DataMember(Name="leftRepeatSmall")]
        public BoundingBox LeftRepeatSmall { get; set; }

        [DataMember(Name="legerLine")]
        public BoundingBox LegerLine { get; set; }

        [DataMember(Name="legerLineNarrow")]
        public BoundingBox LegerLineNarrow { get; set; }

        [DataMember(Name="legerLineWide")]
        public BoundingBox LegerLineWide { get; set; }

        [DataMember(Name="luteBarlineEndRepeat")]
        public BoundingBox LuteBarlineEndRepeat { get; set; }

        [DataMember(Name="luteBarlineFinal")]
        public BoundingBox LuteBarlineFinal { get; set; }

        [DataMember(Name="luteBarlineStartRepeat")]
        public BoundingBox LuteBarlineStartRepeat { get; set; }

        [DataMember(Name="luteDuration16th")]
        public BoundingBox LuteDuration16Th { get; set; }

        [DataMember(Name="luteDuration32nd")]
        public BoundingBox LuteDuration32Nd { get; set; }

        [DataMember(Name="luteDuration8th")]
        public BoundingBox LuteDuration8Th { get; set; }

        [DataMember(Name="luteDurationDoubleWhole")]
        public BoundingBox LuteDurationDoubleWhole { get; set; }

        [DataMember(Name="luteDurationHalf")]
        public BoundingBox LuteDurationHalf { get; set; }

        [DataMember(Name="luteDurationQuarter")]
        public BoundingBox LuteDurationQuarter { get; set; }

        [DataMember(Name="luteDurationWhole")]
        public BoundingBox LuteDurationWhole { get; set; }

        [DataMember(Name="luteFingeringRHFirst")]
        public BoundingBox LuteFingeringRhFirst { get; set; }

        [DataMember(Name="luteFingeringRHSecond")]
        public BoundingBox LuteFingeringRhSecond { get; set; }

        [DataMember(Name="luteFingeringRHThird")]
        public BoundingBox LuteFingeringRhThird { get; set; }

        [DataMember(Name="luteFingeringRHThirdAlt")]
        public BoundingBox LuteFingeringRhThirdAlt { get; set; }

        [DataMember(Name="luteFingeringRHThumb")]
        public BoundingBox LuteFingeringRhThumb { get; set; }

        [DataMember(Name="luteFrench10thCourse")]
        public BoundingBox LuteFrench10ThCourse { get; set; }

        [DataMember(Name="luteFrench10thCourseRight")]
        public BoundingBox LuteFrench10ThCourseRight { get; set; }

        [DataMember(Name="luteFrench10thCourseStrikethru")]
        public BoundingBox LuteFrench10ThCourseStrikethru { get; set; }

        [DataMember(Name="luteFrench10thCourseUnderline")]
        public BoundingBox LuteFrench10ThCourseUnderline { get; set; }

        [DataMember(Name="luteFrench7thCourse")]
        public BoundingBox LuteFrench7ThCourse { get; set; }

        [DataMember(Name="luteFrench7thCourseRight")]
        public BoundingBox LuteFrench7ThCourseRight { get; set; }

        [DataMember(Name="luteFrench7thCourseStrikethru")]
        public BoundingBox LuteFrench7ThCourseStrikethru { get; set; }

        [DataMember(Name="luteFrench7thCourseUnderline")]
        public BoundingBox LuteFrench7ThCourseUnderline { get; set; }

        [DataMember(Name="luteFrench8thCourse")]
        public BoundingBox LuteFrench8ThCourse { get; set; }

        [DataMember(Name="luteFrench8thCourseRight")]
        public BoundingBox LuteFrench8ThCourseRight { get; set; }

        [DataMember(Name="luteFrench8thCourseStrikethru")]
        public BoundingBox LuteFrench8ThCourseStrikethru { get; set; }

        [DataMember(Name="luteFrench8thCourseUnderline")]
        public BoundingBox LuteFrench8ThCourseUnderline { get; set; }

        [DataMember(Name="luteFrench9thCourse")]
        public BoundingBox LuteFrench9ThCourse { get; set; }

        [DataMember(Name="luteFrench9thCourseRight")]
        public BoundingBox LuteFrench9ThCourseRight { get; set; }

        [DataMember(Name="luteFrench9thCourseStrikethru")]
        public BoundingBox LuteFrench9ThCourseStrikethru { get; set; }

        [DataMember(Name="luteFrench9thCourseUnderline")]
        public BoundingBox LuteFrench9ThCourseUnderline { get; set; }

        [DataMember(Name="luteFrenchAppoggiaturaAbove")]
        public BoundingBox LuteFrenchAppoggiaturaAbove { get; set; }

        [DataMember(Name="luteFrenchAppoggiaturaBelow")]
        public BoundingBox LuteFrenchAppoggiaturaBelow { get; set; }

        [DataMember(Name="luteFrenchFretA")]
        public BoundingBox LuteFrenchFretA { get; set; }

        [DataMember(Name="luteFrenchFretB")]
        public BoundingBox LuteFrenchFretB { get; set; }

        [DataMember(Name="luteFrenchFretC")]
        public BoundingBox LuteFrenchFretC { get; set; }

        [DataMember(Name="luteFrenchFretCAlt")]
        public BoundingBox LuteFrenchFretCAlt { get; set; }

        [DataMember(Name="luteFrenchFretD")]
        public BoundingBox LuteFrenchFretD { get; set; }

        [DataMember(Name="luteFrenchFretE")]
        public BoundingBox LuteFrenchFretE { get; set; }

        [DataMember(Name="luteFrenchFretF")]
        public BoundingBox LuteFrenchFretF { get; set; }

        [DataMember(Name="luteFrenchFretG")]
        public BoundingBox LuteFrenchFretG { get; set; }

        [DataMember(Name="luteFrenchFretH")]
        public BoundingBox LuteFrenchFretH { get; set; }

        [DataMember(Name="luteFrenchFretI")]
        public BoundingBox LuteFrenchFretI { get; set; }

        [DataMember(Name="luteFrenchFretK")]
        public BoundingBox LuteFrenchFretK { get; set; }

        [DataMember(Name="luteFrenchFretL")]
        public BoundingBox LuteFrenchFretL { get; set; }

        [DataMember(Name="luteFrenchFretM")]
        public BoundingBox LuteFrenchFretM { get; set; }

        [DataMember(Name="luteFrenchFretN")]
        public BoundingBox LuteFrenchFretN { get; set; }

        [DataMember(Name="luteFrenchMordentInverted")]
        public BoundingBox LuteFrenchMordentInverted { get; set; }

        [DataMember(Name="luteFrenchMordentLower")]
        public BoundingBox LuteFrenchMordentLower { get; set; }

        [DataMember(Name="luteFrenchMordentUpper")]
        public BoundingBox LuteFrenchMordentUpper { get; set; }

        [DataMember(Name="luteGermanALower")]
        public BoundingBox LuteGermanALower { get; set; }

        [DataMember(Name="luteGermanAUpper")]
        public BoundingBox LuteGermanAUpper { get; set; }

        [DataMember(Name="luteGermanBLower")]
        public BoundingBox LuteGermanBLower { get; set; }

        [DataMember(Name="luteGermanBUpper")]
        public BoundingBox LuteGermanBUpper { get; set; }

        [DataMember(Name="luteGermanCLower")]
        public BoundingBox LuteGermanCLower { get; set; }

        [DataMember(Name="luteGermanCUpper")]
        public BoundingBox LuteGermanCUpper { get; set; }

        [DataMember(Name="luteGermanDLower")]
        public BoundingBox LuteGermanDLower { get; set; }

        [DataMember(Name="luteGermanDUpper")]
        public BoundingBox LuteGermanDUpper { get; set; }

        [DataMember(Name="luteGermanELower")]
        public BoundingBox LuteGermanELower { get; set; }

        [DataMember(Name="luteGermanEUpper")]
        public BoundingBox LuteGermanEUpper { get; set; }

        [DataMember(Name="luteGermanFLower")]
        public BoundingBox LuteGermanFLower { get; set; }

        [DataMember(Name="luteGermanFUpper")]
        public BoundingBox LuteGermanFUpper { get; set; }

        [DataMember(Name="luteGermanGLower")]
        public BoundingBox LuteGermanGLower { get; set; }

        [DataMember(Name="luteGermanGUpper")]
        public BoundingBox LuteGermanGUpper { get; set; }

        [DataMember(Name="luteGermanHLower")]
        public BoundingBox LuteGermanHLower { get; set; }

        [DataMember(Name="luteGermanHUpper")]
        public BoundingBox LuteGermanHUpper { get; set; }

        [DataMember(Name="luteGermanILower")]
        public BoundingBox LuteGermanILower { get; set; }

        [DataMember(Name="luteGermanIUpper")]
        public BoundingBox LuteGermanIUpper { get; set; }

        [DataMember(Name="luteGermanKLower")]
        public BoundingBox LuteGermanKLower { get; set; }

        [DataMember(Name="luteGermanKUpper")]
        public BoundingBox LuteGermanKUpper { get; set; }

        [DataMember(Name="luteGermanLLower")]
        public BoundingBox LuteGermanLLower { get; set; }

        [DataMember(Name="luteGermanLUpper")]
        public BoundingBox LuteGermanLUpper { get; set; }

        [DataMember(Name="luteGermanMLower")]
        public BoundingBox LuteGermanMLower { get; set; }

        [DataMember(Name="luteGermanMUpper")]
        public BoundingBox LuteGermanMUpper { get; set; }

        [DataMember(Name="luteGermanNLower")]
        public BoundingBox LuteGermanNLower { get; set; }

        [DataMember(Name="luteGermanNUpper")]
        public BoundingBox LuteGermanNUpper { get; set; }

        [DataMember(Name="luteGermanOLower")]
        public BoundingBox LuteGermanOLower { get; set; }

        [DataMember(Name="luteGermanPLower")]
        public BoundingBox LuteGermanPLower { get; set; }

        [DataMember(Name="luteGermanQLower")]
        public BoundingBox LuteGermanQLower { get; set; }

        [DataMember(Name="luteGermanRLower")]
        public BoundingBox LuteGermanRLower { get; set; }

        [DataMember(Name="luteGermanSLower")]
        public BoundingBox LuteGermanSLower { get; set; }

        [DataMember(Name="luteGermanTLower")]
        public BoundingBox LuteGermanTLower { get; set; }

        [DataMember(Name="luteGermanVLower")]
        public BoundingBox LuteGermanVLower { get; set; }

        [DataMember(Name="luteGermanXLower")]
        public BoundingBox LuteGermanXLower { get; set; }

        [DataMember(Name="luteGermanYLower")]
        public BoundingBox LuteGermanYLower { get; set; }

        [DataMember(Name="luteGermanZLower")]
        public BoundingBox LuteGermanZLower { get; set; }

        [DataMember(Name="luteItalianClefCSolFaUt")]
        public BoundingBox LuteItalianClefCSolFaUt { get; set; }

        [DataMember(Name="luteItalianClefFFaUt")]
        public BoundingBox LuteItalianClefFFaUt { get; set; }

        [DataMember(Name="luteItalianFret0")]
        public BoundingBox LuteItalianFret0 { get; set; }

        [DataMember(Name="luteItalianFret1")]
        public BoundingBox LuteItalianFret1 { get; set; }

        [DataMember(Name="luteItalianFret2")]
        public BoundingBox LuteItalianFret2 { get; set; }

        [DataMember(Name="luteItalianFret3")]
        public BoundingBox LuteItalianFret3 { get; set; }

        [DataMember(Name="luteItalianFret4")]
        public BoundingBox LuteItalianFret4 { get; set; }

        [DataMember(Name="luteItalianFret5")]
        public BoundingBox LuteItalianFret5 { get; set; }

        [DataMember(Name="luteItalianFret6")]
        public BoundingBox LuteItalianFret6 { get; set; }

        [DataMember(Name="luteItalianFret7")]
        public BoundingBox LuteItalianFret7 { get; set; }

        [DataMember(Name="luteItalianFret8")]
        public BoundingBox LuteItalianFret8 { get; set; }

        [DataMember(Name="luteItalianFret9")]
        public BoundingBox LuteItalianFret9 { get; set; }

        [DataMember(Name="luteItalianHoldFinger")]
        public BoundingBox LuteItalianHoldFinger { get; set; }

        [DataMember(Name="luteItalianHoldNote")]
        public BoundingBox LuteItalianHoldNote { get; set; }

        [DataMember(Name="luteItalianReleaseFinger")]
        public BoundingBox LuteItalianReleaseFinger { get; set; }

        [DataMember(Name="luteItalianTempoFast")]
        public BoundingBox LuteItalianTempoFast { get; set; }

        [DataMember(Name="luteItalianTempoNeitherFastNorSlow")]
        public BoundingBox LuteItalianTempoNeitherFastNorSlow { get; set; }

        [DataMember(Name="luteItalianTempoSlow")]
        public BoundingBox LuteItalianTempoSlow { get; set; }

        [DataMember(Name="luteItalianTempoSomewhatFast")]
        public BoundingBox LuteItalianTempoSomewhatFast { get; set; }

        [DataMember(Name="luteItalianTempoVerySlow")]
        public BoundingBox LuteItalianTempoVerySlow { get; set; }

        [DataMember(Name="luteItalianTimeTriple")]
        public BoundingBox LuteItalianTimeTriple { get; set; }

        [DataMember(Name="luteItalianTremolo")]
        public BoundingBox LuteItalianTremolo { get; set; }

        [DataMember(Name="luteItalianVibrato")]
        public BoundingBox LuteItalianVibrato { get; set; }

        [DataMember(Name="luteStaff6Lines")]
        public BoundingBox LuteStaff6Lines { get; set; }

        [DataMember(Name="luteStaff6LinesNarrow")]
        public BoundingBox LuteStaff6LinesNarrow { get; set; }

        [DataMember(Name="luteStaff6LinesWide")]
        public BoundingBox LuteStaff6LinesWide { get; set; }

        [DataMember(Name="lyricsElision")]
        public BoundingBox LyricsElision { get; set; }

        [DataMember(Name="lyricsElisionNarrow")]
        public BoundingBox LyricsElisionNarrow { get; set; }

        [DataMember(Name="lyricsElisionWide")]
        public BoundingBox LyricsElisionWide { get; set; }

        [DataMember(Name="lyricsHyphenBaseline")]
        public BoundingBox LyricsHyphenBaseline { get; set; }

        [DataMember(Name="lyricsHyphenBaselineNonBreaking")]
        public BoundingBox LyricsHyphenBaselineNonBreaking { get; set; }

        [DataMember(Name="medRenFlatHardB")]
        public BoundingBox MedRenFlatHardB { get; set; }

        [DataMember(Name="medRenFlatSoftB")]
        public BoundingBox MedRenFlatSoftB { get; set; }

        [DataMember(Name="medRenFlatSoftBHufnagel")]
        public BoundingBox MedRenFlatSoftBHufnagel { get; set; }

        [DataMember(Name="medRenFlatSoftBOld")]
        public BoundingBox MedRenFlatSoftBOld { get; set; }

        [DataMember(Name="medRenFlatWithDot")]
        public BoundingBox MedRenFlatWithDot { get; set; }

        [DataMember(Name="medRenGClefCMN")]
        public BoundingBox MedRenGClefCmn { get; set; }

        [DataMember(Name="medRenLiquescenceCMN")]
        public BoundingBox MedRenLiquescenceCmn { get; set; }

        [DataMember(Name="medRenLiquescentAscCMN")]
        public BoundingBox MedRenLiquescentAscCmn { get; set; }

        [DataMember(Name="medRenLiquescentDescCMN")]
        public BoundingBox MedRenLiquescentDescCmn { get; set; }

        [DataMember(Name="medRenNatural")]
        public BoundingBox MedRenNatural { get; set; }

        [DataMember(Name="medRenNaturalWithCross")]
        public BoundingBox MedRenNaturalWithCross { get; set; }

        [DataMember(Name="medRenOriscusCMN")]
        public BoundingBox MedRenOriscusCmn { get; set; }

        [DataMember(Name="medRenPlicaCMN")]
        public BoundingBox MedRenPlicaCmn { get; set; }

        [DataMember(Name="medRenPunctumCMN")]
        public BoundingBox MedRenPunctumCmn { get; set; }

        [DataMember(Name="medRenQuilismaCMN")]
        public BoundingBox MedRenQuilismaCmn { get; set; }

        [DataMember(Name="medRenSharpCroix")]
        public BoundingBox MedRenSharpCroix { get; set; }

        [DataMember(Name="medRenStrophicusCMN")]
        public BoundingBox MedRenStrophicusCmn { get; set; }

        [DataMember(Name="mensuralAlterationSign")]
        public BoundingBox MensuralAlterationSign { get; set; }

        [DataMember(Name="mensuralBlackBrevis")]
        public BoundingBox MensuralBlackBrevis { get; set; }

        [DataMember(Name="mensuralBlackBrevisVoid")]
        public BoundingBox MensuralBlackBrevisVoid { get; set; }

        [DataMember(Name="mensuralBlackDragma")]
        public BoundingBox MensuralBlackDragma { get; set; }

        [DataMember(Name="mensuralBlackLonga")]
        public BoundingBox MensuralBlackLonga { get; set; }

        [DataMember(Name="mensuralBlackMaxima")]
        public BoundingBox MensuralBlackMaxima { get; set; }

        [DataMember(Name="mensuralBlackMinima")]
        public BoundingBox MensuralBlackMinima { get; set; }

        [DataMember(Name="mensuralBlackMinimaVoid")]
        public BoundingBox MensuralBlackMinimaVoid { get; set; }

        [DataMember(Name="mensuralBlackSemibrevis")]
        public BoundingBox MensuralBlackSemibrevis { get; set; }

        [DataMember(Name="mensuralBlackSemibrevisCaudata")]
        public BoundingBox MensuralBlackSemibrevisCaudata { get; set; }

        [DataMember(Name="mensuralBlackSemibrevisOblique")]
        public BoundingBox MensuralBlackSemibrevisOblique { get; set; }

        [DataMember(Name="mensuralBlackSemibrevisVoid")]
        public BoundingBox MensuralBlackSemibrevisVoid { get; set; }

        [DataMember(Name="mensuralBlackSemiminima")]
        public BoundingBox MensuralBlackSemiminima { get; set; }

        [DataMember(Name="mensuralCclef")]
        public BoundingBox MensuralCclef { get; set; }

        [DataMember(Name="mensuralCclefBlack")]
        public BoundingBox MensuralCclefBlack { get; set; }

        [DataMember(Name="mensuralCclefPetrucciPosHigh")]
        public BoundingBox MensuralCclefPetrucciPosHigh { get; set; }

        [DataMember(Name="mensuralCclefPetrucciPosHighest")]
        public BoundingBox MensuralCclefPetrucciPosHighest { get; set; }

        [DataMember(Name="mensuralCclefPetrucciPosLow")]
        public BoundingBox MensuralCclefPetrucciPosLow { get; set; }

        [DataMember(Name="mensuralCclefPetrucciPosLowest")]
        public BoundingBox MensuralCclefPetrucciPosLowest { get; set; }

        [DataMember(Name="mensuralCclefPetrucciPosMiddle")]
        public BoundingBox MensuralCclefPetrucciPosMiddle { get; set; }

        [DataMember(Name="mensuralCclefVoid")]
        public BoundingBox MensuralCclefVoid { get; set; }

        [DataMember(Name="mensuralColorationEndRound")]
        public BoundingBox MensuralColorationEndRound { get; set; }

        [DataMember(Name="mensuralColorationEndSquare")]
        public BoundingBox MensuralColorationEndSquare { get; set; }

        [DataMember(Name="mensuralColorationStartRound")]
        public BoundingBox MensuralColorationStartRound { get; set; }

        [DataMember(Name="mensuralColorationStartSquare")]
        public BoundingBox MensuralColorationStartSquare { get; set; }

        [DataMember(Name="mensuralCombStemDiagonal")]
        public BoundingBox MensuralCombStemDiagonal { get; set; }

        [DataMember(Name="mensuralCombStemDown")]
        public BoundingBox MensuralCombStemDown { get; set; }

        [DataMember(Name="mensuralCombStemDownFlagExtended")]
        public BoundingBox MensuralCombStemDownFlagExtended { get; set; }

        [DataMember(Name="mensuralCombStemDownFlagFlared")]
        public BoundingBox MensuralCombStemDownFlagFlared { get; set; }

        [DataMember(Name="mensuralCombStemDownFlagFusa")]
        public BoundingBox MensuralCombStemDownFlagFusa { get; set; }

        [DataMember(Name="mensuralCombStemDownFlagLeft")]
        public BoundingBox MensuralCombStemDownFlagLeft { get; set; }

        [DataMember(Name="mensuralCombStemDownFlagRight")]
        public BoundingBox MensuralCombStemDownFlagRight { get; set; }

        [DataMember(Name="mensuralCombStemDownFlagSemiminima")]
        public BoundingBox MensuralCombStemDownFlagSemiminima { get; set; }

        [DataMember(Name="mensuralCombStemUp")]
        public BoundingBox MensuralCombStemUp { get; set; }

        [DataMember(Name="mensuralCombStemUpFlagExtended")]
        public BoundingBox MensuralCombStemUpFlagExtended { get; set; }

        [DataMember(Name="mensuralCombStemUpFlagFlared")]
        public BoundingBox MensuralCombStemUpFlagFlared { get; set; }

        [DataMember(Name="mensuralCombStemUpFlagFusa")]
        public BoundingBox MensuralCombStemUpFlagFusa { get; set; }

        [DataMember(Name="mensuralCombStemUpFlagLeft")]
        public BoundingBox MensuralCombStemUpFlagLeft { get; set; }

        [DataMember(Name="mensuralCombStemUpFlagRight")]
        public BoundingBox MensuralCombStemUpFlagRight { get; set; }

        [DataMember(Name="mensuralCombStemUpFlagSemiminima")]
        public BoundingBox MensuralCombStemUpFlagSemiminima { get; set; }

        [DataMember(Name="mensuralCustosCheckmark")]
        public BoundingBox MensuralCustosCheckmark { get; set; }

        [DataMember(Name="mensuralCustosDown")]
        public BoundingBox MensuralCustosDown { get; set; }

        [DataMember(Name="mensuralCustosTurn")]
        public BoundingBox MensuralCustosTurn { get; set; }

        [DataMember(Name="mensuralCustosUp")]
        public BoundingBox MensuralCustosUp { get; set; }

        [DataMember(Name="mensuralFclef")]
        public BoundingBox MensuralFclef { get; set; }

        [DataMember(Name="mensuralFclefPetrucci")]
        public BoundingBox MensuralFclefPetrucci { get; set; }

        [DataMember(Name="mensuralFusaBlackStemDown")]
        public BoundingBox MensuralFusaBlackStemDown { get; set; }

        [DataMember(Name="mensuralFusaBlackStemUp")]
        public BoundingBox MensuralFusaBlackStemUp { get; set; }

        [DataMember(Name="mensuralFusaBlackVoidStemDown")]
        public BoundingBox MensuralFusaBlackVoidStemDown { get; set; }

        [DataMember(Name="mensuralFusaBlackVoidStemUp")]
        public BoundingBox MensuralFusaBlackVoidStemUp { get; set; }

        [DataMember(Name="mensuralFusaVoidStemDown")]
        public BoundingBox MensuralFusaVoidStemDown { get; set; }

        [DataMember(Name="mensuralFusaVoidStemUp")]
        public BoundingBox MensuralFusaVoidStemUp { get; set; }

        [DataMember(Name="mensuralGclef")]
        public BoundingBox MensuralGclef { get; set; }

        [DataMember(Name="mensuralGclefPetrucci")]
        public BoundingBox MensuralGclefPetrucci { get; set; }

        [DataMember(Name="mensuralLongaBlackStemDownLeft")]
        public BoundingBox MensuralLongaBlackStemDownLeft { get; set; }

        [DataMember(Name="mensuralLongaBlackStemDownRight")]
        public BoundingBox MensuralLongaBlackStemDownRight { get; set; }

        [DataMember(Name="mensuralLongaBlackStemUpLeft")]
        public BoundingBox MensuralLongaBlackStemUpLeft { get; set; }

        [DataMember(Name="mensuralLongaBlackStemUpRight")]
        public BoundingBox MensuralLongaBlackStemUpRight { get; set; }

        [DataMember(Name="mensuralLongaBlackVoidStemDownLeft")]
        public BoundingBox MensuralLongaBlackVoidStemDownLeft { get; set; }

        [DataMember(Name="mensuralLongaBlackVoidStemDownRight")]
        public BoundingBox MensuralLongaBlackVoidStemDownRight { get; set; }

        [DataMember(Name="mensuralLongaBlackVoidStemUpLeft")]
        public BoundingBox MensuralLongaBlackVoidStemUpLeft { get; set; }

        [DataMember(Name="mensuralLongaBlackVoidStemUpRight")]
        public BoundingBox MensuralLongaBlackVoidStemUpRight { get; set; }

        [DataMember(Name="mensuralLongaVoidStemDownLeft")]
        public BoundingBox MensuralLongaVoidStemDownLeft { get; set; }

        [DataMember(Name="mensuralLongaVoidStemDownRight")]
        public BoundingBox MensuralLongaVoidStemDownRight { get; set; }

        [DataMember(Name="mensuralLongaVoidStemUpLeft")]
        public BoundingBox MensuralLongaVoidStemUpLeft { get; set; }

        [DataMember(Name="mensuralLongaVoidStemUpRight")]
        public BoundingBox MensuralLongaVoidStemUpRight { get; set; }

        [DataMember(Name="mensuralMaximaBlackStemDownLeft")]
        public BoundingBox MensuralMaximaBlackStemDownLeft { get; set; }

        [DataMember(Name="mensuralMaximaBlackStemDownRight")]
        public BoundingBox MensuralMaximaBlackStemDownRight { get; set; }

        [DataMember(Name="mensuralMaximaBlackStemUpLeft")]
        public BoundingBox MensuralMaximaBlackStemUpLeft { get; set; }

        [DataMember(Name="mensuralMaximaBlackStemUpRight")]
        public BoundingBox MensuralMaximaBlackStemUpRight { get; set; }

        [DataMember(Name="mensuralMaximaBlackVoidStemDownLeft")]
        public BoundingBox MensuralMaximaBlackVoidStemDownLeft { get; set; }

        [DataMember(Name="mensuralMaximaBlackVoidStemDownRight")]
        public BoundingBox MensuralMaximaBlackVoidStemDownRight { get; set; }

        [DataMember(Name="mensuralMaximaBlackVoidStemUpLeft")]
        public BoundingBox MensuralMaximaBlackVoidStemUpLeft { get; set; }

        [DataMember(Name="mensuralMaximaBlackVoidStemUpRight")]
        public BoundingBox MensuralMaximaBlackVoidStemUpRight { get; set; }

        [DataMember(Name="mensuralMaximaVoidStemDownLeft")]
        public BoundingBox MensuralMaximaVoidStemDownLeft { get; set; }

        [DataMember(Name="mensuralMaximaVoidStemDownRight")]
        public BoundingBox MensuralMaximaVoidStemDownRight { get; set; }

        [DataMember(Name="mensuralMaximaVoidStemUpLeft")]
        public BoundingBox MensuralMaximaVoidStemUpLeft { get; set; }

        [DataMember(Name="mensuralMaximaVoidStemUpRight")]
        public BoundingBox MensuralMaximaVoidStemUpRight { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemDown")]
        public BoundingBox MensuralMinimaBlackStemDown { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemDownExtendedFlag")]
        public BoundingBox MensuralMinimaBlackStemDownExtendedFlag { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemDownFlagLeft")]
        public BoundingBox MensuralMinimaBlackStemDownFlagLeft { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemDownFlagRight")]
        public BoundingBox MensuralMinimaBlackStemDownFlagRight { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemDownFlaredFlag")]
        public BoundingBox MensuralMinimaBlackStemDownFlaredFlag { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemUp")]
        public BoundingBox MensuralMinimaBlackStemUp { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemUpExtendedFlag")]
        public BoundingBox MensuralMinimaBlackStemUpExtendedFlag { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemUpFlagLeft")]
        public BoundingBox MensuralMinimaBlackStemUpFlagLeft { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemUpFlagRight")]
        public BoundingBox MensuralMinimaBlackStemUpFlagRight { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemUpFlaredFlag")]
        public BoundingBox MensuralMinimaBlackStemUpFlaredFlag { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemDown")]
        public BoundingBox MensuralMinimaBlackVoidStemDown { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemDownExtendedFlag")]
        public BoundingBox MensuralMinimaBlackVoidStemDownExtendedFlag { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemDownFlagLeft")]
        public BoundingBox MensuralMinimaBlackVoidStemDownFlagLeft { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemDownFlagRight")]
        public BoundingBox MensuralMinimaBlackVoidStemDownFlagRight { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemDownFlaredFlag")]
        public BoundingBox MensuralMinimaBlackVoidStemDownFlaredFlag { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemUp")]
        public BoundingBox MensuralMinimaBlackVoidStemUp { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemUpExtendedFlag")]
        public BoundingBox MensuralMinimaBlackVoidStemUpExtendedFlag { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemUpFlagLeft")]
        public BoundingBox MensuralMinimaBlackVoidStemUpFlagLeft { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemUpFlagRight")]
        public BoundingBox MensuralMinimaBlackVoidStemUpFlagRight { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemUpFlaredFlag")]
        public BoundingBox MensuralMinimaBlackVoidStemUpFlaredFlag { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemDown")]
        public BoundingBox MensuralMinimaVoidStemDown { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemDownExtendedFlag")]
        public BoundingBox MensuralMinimaVoidStemDownExtendedFlag { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemDownFlagLeft")]
        public BoundingBox MensuralMinimaVoidStemDownFlagLeft { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemDownFlagRight")]
        public BoundingBox MensuralMinimaVoidStemDownFlagRight { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemDownFlaredFlag")]
        public BoundingBox MensuralMinimaVoidStemDownFlaredFlag { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemUp")]
        public BoundingBox MensuralMinimaVoidStemUp { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemUpExtendedFlag")]
        public BoundingBox MensuralMinimaVoidStemUpExtendedFlag { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemUpFlagLeft")]
        public BoundingBox MensuralMinimaVoidStemUpFlagLeft { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemUpFlagRight")]
        public BoundingBox MensuralMinimaVoidStemUpFlagRight { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemUpFlaredFlag")]
        public BoundingBox MensuralMinimaVoidStemUpFlaredFlag { get; set; }

        [DataMember(Name="mensuralModusImperfectumVert")]
        public BoundingBox MensuralModusImperfectumVert { get; set; }

        [DataMember(Name="mensuralModusPerfectumVert")]
        public BoundingBox MensuralModusPerfectumVert { get; set; }

        [DataMember(Name="mensuralNoteheadLongaBlack")]
        public BoundingBox MensuralNoteheadLongaBlack { get; set; }

        [DataMember(Name="mensuralNoteheadLongaBlackVoid")]
        public BoundingBox MensuralNoteheadLongaBlackVoid { get; set; }

        [DataMember(Name="mensuralNoteheadLongaVoid")]
        public BoundingBox MensuralNoteheadLongaVoid { get; set; }

        [DataMember(Name="mensuralNoteheadLongaWhite")]
        public BoundingBox MensuralNoteheadLongaWhite { get; set; }

        [DataMember(Name="mensuralNoteheadMaximaBlack")]
        public BoundingBox MensuralNoteheadMaximaBlack { get; set; }

        [DataMember(Name="mensuralNoteheadMaximaBlackVoid")]
        public BoundingBox MensuralNoteheadMaximaBlackVoid { get; set; }

        [DataMember(Name="mensuralNoteheadMaximaVoid")]
        public BoundingBox MensuralNoteheadMaximaVoid { get; set; }

        [DataMember(Name="mensuralNoteheadMaximaWhite")]
        public BoundingBox MensuralNoteheadMaximaWhite { get; set; }

        [DataMember(Name="mensuralNoteheadMinimaWhite")]
        public BoundingBox MensuralNoteheadMinimaWhite { get; set; }

        [DataMember(Name="mensuralNoteheadSemibrevisBlack")]
        public BoundingBox MensuralNoteheadSemibrevisBlack { get; set; }

        [DataMember(Name="mensuralNoteheadSemibrevisBlackVoid")]
        public BoundingBox MensuralNoteheadSemibrevisBlackVoid { get; set; }

        [DataMember(Name="mensuralNoteheadSemibrevisBlackVoidTurned")]
        public BoundingBox MensuralNoteheadSemibrevisBlackVoidTurned { get; set; }

        [DataMember(Name="mensuralNoteheadSemibrevisVoid")]
        public BoundingBox MensuralNoteheadSemibrevisVoid { get; set; }

        [DataMember(Name="mensuralNoteheadSemiminimaWhite")]
        public BoundingBox MensuralNoteheadSemiminimaWhite { get; set; }

        [DataMember(Name="mensuralObliqueAsc2ndBlack")]
        public BoundingBox MensuralObliqueAsc2NdBlack { get; set; }

        [DataMember(Name="mensuralObliqueAsc2ndBlackVoid")]
        public BoundingBox MensuralObliqueAsc2NdBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc2ndVoid")]
        public BoundingBox MensuralObliqueAsc2NdVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc2ndWhite")]
        public BoundingBox MensuralObliqueAsc2NdWhite { get; set; }

        [DataMember(Name="mensuralObliqueAsc3rdBlack")]
        public BoundingBox MensuralObliqueAsc3RdBlack { get; set; }

        [DataMember(Name="mensuralObliqueAsc3rdBlackVoid")]
        public BoundingBox MensuralObliqueAsc3RdBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc3rdVoid")]
        public BoundingBox MensuralObliqueAsc3RdVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc3rdWhite")]
        public BoundingBox MensuralObliqueAsc3RdWhite { get; set; }

        [DataMember(Name="mensuralObliqueAsc4thBlack")]
        public BoundingBox MensuralObliqueAsc4ThBlack { get; set; }

        [DataMember(Name="mensuralObliqueAsc4thBlackVoid")]
        public BoundingBox MensuralObliqueAsc4ThBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc4thVoid")]
        public BoundingBox MensuralObliqueAsc4ThVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc4thWhite")]
        public BoundingBox MensuralObliqueAsc4ThWhite { get; set; }

        [DataMember(Name="mensuralObliqueAsc5thBlack")]
        public BoundingBox MensuralObliqueAsc5ThBlack { get; set; }

        [DataMember(Name="mensuralObliqueAsc5thBlackVoid")]
        public BoundingBox MensuralObliqueAsc5ThBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc5thVoid")]
        public BoundingBox MensuralObliqueAsc5ThVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc5thWhite")]
        public BoundingBox MensuralObliqueAsc5ThWhite { get; set; }

        [DataMember(Name="mensuralObliqueDesc2ndBlack")]
        public BoundingBox MensuralObliqueDesc2NdBlack { get; set; }

        [DataMember(Name="mensuralObliqueDesc2ndBlackVoid")]
        public BoundingBox MensuralObliqueDesc2NdBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc2ndVoid")]
        public BoundingBox MensuralObliqueDesc2NdVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc2ndWhite")]
        public BoundingBox MensuralObliqueDesc2NdWhite { get; set; }

        [DataMember(Name="mensuralObliqueDesc3rdBlack")]
        public BoundingBox MensuralObliqueDesc3RdBlack { get; set; }

        [DataMember(Name="mensuralObliqueDesc3rdBlackVoid")]
        public BoundingBox MensuralObliqueDesc3RdBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc3rdVoid")]
        public BoundingBox MensuralObliqueDesc3RdVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc3rdWhite")]
        public BoundingBox MensuralObliqueDesc3RdWhite { get; set; }

        [DataMember(Name="mensuralObliqueDesc4thBlack")]
        public BoundingBox MensuralObliqueDesc4ThBlack { get; set; }

        [DataMember(Name="mensuralObliqueDesc4thBlackVoid")]
        public BoundingBox MensuralObliqueDesc4ThBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc4thVoid")]
        public BoundingBox MensuralObliqueDesc4ThVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc4thWhite")]
        public BoundingBox MensuralObliqueDesc4ThWhite { get; set; }

        [DataMember(Name="mensuralObliqueDesc5thBlack")]
        public BoundingBox MensuralObliqueDesc5ThBlack { get; set; }

        [DataMember(Name="mensuralObliqueDesc5thBlackVoid")]
        public BoundingBox MensuralObliqueDesc5ThBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc5thVoid")]
        public BoundingBox MensuralObliqueDesc5ThVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc5thWhite")]
        public BoundingBox MensuralObliqueDesc5ThWhite { get; set; }

        [DataMember(Name="mensuralProlation1")]
        public BoundingBox MensuralProlation1 { get; set; }

        [DataMember(Name="mensuralProlation10")]
        public BoundingBox MensuralProlation10 { get; set; }

        [DataMember(Name="mensuralProlation11")]
        public BoundingBox MensuralProlation11 { get; set; }

        [DataMember(Name="mensuralProlation2")]
        public BoundingBox MensuralProlation2 { get; set; }

        [DataMember(Name="mensuralProlation3")]
        public BoundingBox MensuralProlation3 { get; set; }

        [DataMember(Name="mensuralProlation4")]
        public BoundingBox MensuralProlation4 { get; set; }

        [DataMember(Name="mensuralProlation5")]
        public BoundingBox MensuralProlation5 { get; set; }

        [DataMember(Name="mensuralProlation6")]
        public BoundingBox MensuralProlation6 { get; set; }

        [DataMember(Name="mensuralProlation7")]
        public BoundingBox MensuralProlation7 { get; set; }

        [DataMember(Name="mensuralProlation8")]
        public BoundingBox MensuralProlation8 { get; set; }

        [DataMember(Name="mensuralProlation9")]
        public BoundingBox MensuralProlation9 { get; set; }

        [DataMember(Name="mensuralProlationCombiningDot")]
        public BoundingBox MensuralProlationCombiningDot { get; set; }

        [DataMember(Name="mensuralProlationCombiningDotVoid")]
        public BoundingBox MensuralProlationCombiningDotVoid { get; set; }

        [DataMember(Name="mensuralProlationCombiningStroke")]
        public BoundingBox MensuralProlationCombiningStroke { get; set; }

        [DataMember(Name="mensuralProlationCombiningThreeDots")]
        public BoundingBox MensuralProlationCombiningThreeDots { get; set; }

        [DataMember(Name="mensuralProlationCombiningThreeDotsTri")]
        public BoundingBox MensuralProlationCombiningThreeDotsTri { get; set; }

        [DataMember(Name="mensuralProlationCombiningTwoDots")]
        public BoundingBox MensuralProlationCombiningTwoDots { get; set; }

        [DataMember(Name="mensuralProportion1")]
        public BoundingBox MensuralProportion1 { get; set; }

        [DataMember(Name="mensuralProportion2")]
        public BoundingBox MensuralProportion2 { get; set; }

        [DataMember(Name="mensuralProportion3")]
        public BoundingBox MensuralProportion3 { get; set; }

        [DataMember(Name="mensuralProportion4")]
        public BoundingBox MensuralProportion4 { get; set; }

        [DataMember(Name="mensuralProportion4Old")]
        public BoundingBox MensuralProportion4Old { get; set; }

        [DataMember(Name="mensuralProportionMajor")]
        public BoundingBox MensuralProportionMajor { get; set; }

        [DataMember(Name="mensuralProportionMinor")]
        public BoundingBox MensuralProportionMinor { get; set; }

        [DataMember(Name="mensuralProportionProportioDupla1")]
        public BoundingBox MensuralProportionProportioDupla1 { get; set; }

        [DataMember(Name="mensuralProportionProportioDupla2")]
        public BoundingBox MensuralProportionProportioDupla2 { get; set; }

        [DataMember(Name="mensuralProportionProportioQuadrupla")]
        public BoundingBox MensuralProportionProportioQuadrupla { get; set; }

        [DataMember(Name="mensuralProportionProportioTripla")]
        public BoundingBox MensuralProportionProportioTripla { get; set; }

        [DataMember(Name="mensuralProportionTempusPerfectum")]
        public BoundingBox MensuralProportionTempusPerfectum { get; set; }

        [DataMember(Name="mensuralRestBrevis")]
        public BoundingBox MensuralRestBrevis { get; set; }

        [DataMember(Name="mensuralRestFusa")]
        public BoundingBox MensuralRestFusa { get; set; }

        [DataMember(Name="mensuralRestLongaImperfecta")]
        public BoundingBox MensuralRestLongaImperfecta { get; set; }

        [DataMember(Name="mensuralRestLongaPerfecta")]
        public BoundingBox MensuralRestLongaPerfecta { get; set; }

        [DataMember(Name="mensuralRestMaxima")]
        public BoundingBox MensuralRestMaxima { get; set; }

        [DataMember(Name="mensuralRestMinima")]
        public BoundingBox MensuralRestMinima { get; set; }

        [DataMember(Name="mensuralRestSemibrevis")]
        public BoundingBox MensuralRestSemibrevis { get; set; }

        [DataMember(Name="mensuralRestSemifusa")]
        public BoundingBox MensuralRestSemifusa { get; set; }

        [DataMember(Name="mensuralRestSemiminima")]
        public BoundingBox MensuralRestSemiminima { get; set; }

        [DataMember(Name="mensuralSemiminimaBlackStemDown")]
        public BoundingBox MensuralSemiminimaBlackStemDown { get; set; }

        [DataMember(Name="mensuralSemiminimaBlackStemUp")]
        public BoundingBox MensuralSemiminimaBlackStemUp { get; set; }

        [DataMember(Name="mensuralSemiminimaBlackVoidStemDown")]
        public BoundingBox MensuralSemiminimaBlackVoidStemDown { get; set; }

        [DataMember(Name="mensuralSemiminimaBlackVoidStemUp")]
        public BoundingBox MensuralSemiminimaBlackVoidStemUp { get; set; }

        [DataMember(Name="mensuralSemiminimaVoidStemDown")]
        public BoundingBox MensuralSemiminimaVoidStemDown { get; set; }

        [DataMember(Name="mensuralSemiminimaVoidStemUp")]
        public BoundingBox MensuralSemiminimaVoidStemUp { get; set; }

        [DataMember(Name="mensuralSignumDown")]
        public BoundingBox MensuralSignumDown { get; set; }

        [DataMember(Name="mensuralSignumUp")]
        public BoundingBox MensuralSignumUp { get; set; }

        [DataMember(Name="mensuralTempusImperfectumHoriz")]
        public BoundingBox MensuralTempusImperfectumHoriz { get; set; }

        [DataMember(Name="mensuralTempusPerfectumHoriz")]
        public BoundingBox MensuralTempusPerfectumHoriz { get; set; }

        [DataMember(Name="mensuralWhiteBrevis")]
        public BoundingBox MensuralWhiteBrevis { get; set; }

        [DataMember(Name="mensuralWhiteFusa")]
        public BoundingBox MensuralWhiteFusa { get; set; }

        [DataMember(Name="mensuralWhiteLonga")]
        public BoundingBox MensuralWhiteLonga { get; set; }

        [DataMember(Name="mensuralWhiteMaxima")]
        public BoundingBox MensuralWhiteMaxima { get; set; }

        [DataMember(Name="mensuralWhiteMinima")]
        public BoundingBox MensuralWhiteMinima { get; set; }

        [DataMember(Name="mensuralWhiteSemiminima")]
        public BoundingBox MensuralWhiteSemiminima { get; set; }

        [DataMember(Name="metAugmentationDot")]
        public BoundingBox MetAugmentationDot { get; set; }

        [DataMember(Name="metNote1024thDown")]
        public BoundingBox MetNote1024ThDown { get; set; }

        [DataMember(Name="metNote1024thUp")]
        public BoundingBox MetNote1024ThUp { get; set; }

        [DataMember(Name="metNote128thDown")]
        public BoundingBox MetNote128ThDown { get; set; }

        [DataMember(Name="metNote128thUp")]
        public BoundingBox MetNote128ThUp { get; set; }

        [DataMember(Name="metNote16thDown")]
        public BoundingBox MetNote16ThDown { get; set; }

        [DataMember(Name="metNote16thUp")]
        public BoundingBox MetNote16ThUp { get; set; }

        [DataMember(Name="metNote256thDown")]
        public BoundingBox MetNote256ThDown { get; set; }

        [DataMember(Name="metNote256thUp")]
        public BoundingBox MetNote256ThUp { get; set; }

        [DataMember(Name="metNote32ndDown")]
        public BoundingBox MetNote32NdDown { get; set; }

        [DataMember(Name="metNote32ndUp")]
        public BoundingBox MetNote32NdUp { get; set; }

        [DataMember(Name="metNote512thDown")]
        public BoundingBox MetNote512ThDown { get; set; }

        [DataMember(Name="metNote512thUp")]
        public BoundingBox MetNote512ThUp { get; set; }

        [DataMember(Name="metNote64thDown")]
        public BoundingBox MetNote64ThDown { get; set; }

        [DataMember(Name="metNote64thUp")]
        public BoundingBox MetNote64ThUp { get; set; }

        [DataMember(Name="metNote8thDown")]
        public BoundingBox MetNote8ThDown { get; set; }

        [DataMember(Name="metNote8thUp")]
        public BoundingBox MetNote8ThUp { get; set; }

        [DataMember(Name="metNoteDoubleWhole")]
        public BoundingBox MetNoteDoubleWhole { get; set; }

        [DataMember(Name="metNoteDoubleWholeSquare")]
        public BoundingBox MetNoteDoubleWholeSquare { get; set; }

        [DataMember(Name="metNoteHalfDown")]
        public BoundingBox MetNoteHalfDown { get; set; }

        [DataMember(Name="metNoteHalfUp")]
        public BoundingBox MetNoteHalfUp { get; set; }

        [DataMember(Name="metNoteQuarterDown")]
        public BoundingBox MetNoteQuarterDown { get; set; }

        [DataMember(Name="metNoteQuarterUp")]
        public BoundingBox MetNoteQuarterUp { get; set; }

        [DataMember(Name="metNoteWhole")]
        public BoundingBox MetNoteWhole { get; set; }

        [DataMember(Name="metricModulationArrowLeft")]
        public BoundingBox MetricModulationArrowLeft { get; set; }

        [DataMember(Name="metricModulationArrowRight")]
        public BoundingBox MetricModulationArrowRight { get; set; }

        [DataMember(Name="miscDoNotCopy")]
        public BoundingBox MiscDoNotCopy { get; set; }

        [DataMember(Name="miscDoNotPhotocopy")]
        public BoundingBox MiscDoNotPhotocopy { get; set; }

        [DataMember(Name="miscEyeglasses")]
        public BoundingBox MiscEyeglasses { get; set; }

        [DataMember(Name="note1024thDown")]
        public BoundingBox Note1024ThDown { get; set; }

        [DataMember(Name="note1024thUp")]
        public BoundingBox Note1024ThUp { get; set; }

        [DataMember(Name="note128thDown")]
        public BoundingBox Note128ThDown { get; set; }

        [DataMember(Name="note128thUp")]
        public BoundingBox Note128ThUp { get; set; }

        [DataMember(Name="note16thDown")]
        public BoundingBox Note16ThDown { get; set; }

        [DataMember(Name="note16thUp")]
        public BoundingBox Note16ThUp { get; set; }

        [DataMember(Name="note256thDown")]
        public BoundingBox Note256ThDown { get; set; }

        [DataMember(Name="note256thUp")]
        public BoundingBox Note256ThUp { get; set; }

        [DataMember(Name="note32ndDown")]
        public BoundingBox Note32NdDown { get; set; }

        [DataMember(Name="note32ndUp")]
        public BoundingBox Note32NdUp { get; set; }

        [DataMember(Name="note512thDown")]
        public BoundingBox Note512ThDown { get; set; }

        [DataMember(Name="note512thUp")]
        public BoundingBox Note512ThUp { get; set; }

        [DataMember(Name="note64thDown")]
        public BoundingBox Note64ThDown { get; set; }

        [DataMember(Name="note64thUp")]
        public BoundingBox Note64ThUp { get; set; }

        [DataMember(Name="note8thDown")]
        public BoundingBox Note8ThDown { get; set; }

        [DataMember(Name="note8thUp")]
        public BoundingBox Note8ThUp { get; set; }

        [DataMember(Name="noteABlack")]
        public BoundingBox NoteABlack { get; set; }

        [DataMember(Name="noteAFlatBlack")]
        public BoundingBox NoteAFlatBlack { get; set; }

        [DataMember(Name="noteAFlatHalf")]
        public BoundingBox NoteAFlatHalf { get; set; }

        [DataMember(Name="noteAFlatWhole")]
        public BoundingBox NoteAFlatWhole { get; set; }

        [DataMember(Name="noteAHalf")]
        public BoundingBox NoteAHalf { get; set; }

        [DataMember(Name="noteASharpBlack")]
        public BoundingBox NoteASharpBlack { get; set; }

        [DataMember(Name="noteASharpHalf")]
        public BoundingBox NoteASharpHalf { get; set; }

        [DataMember(Name="noteASharpWhole")]
        public BoundingBox NoteASharpWhole { get; set; }

        [DataMember(Name="noteAWhole")]
        public BoundingBox NoteAWhole { get; set; }

        [DataMember(Name="noteBBlack")]
        public BoundingBox NoteBBlack { get; set; }

        [DataMember(Name="noteBFlatBlack")]
        public BoundingBox NoteBFlatBlack { get; set; }

        [DataMember(Name="noteBFlatHalf")]
        public BoundingBox NoteBFlatHalf { get; set; }

        [DataMember(Name="noteBFlatWhole")]
        public BoundingBox NoteBFlatWhole { get; set; }

        [DataMember(Name="noteBHalf")]
        public BoundingBox NoteBHalf { get; set; }

        [DataMember(Name="noteBSharpBlack")]
        public BoundingBox NoteBSharpBlack { get; set; }

        [DataMember(Name="noteBSharpHalf")]
        public BoundingBox NoteBSharpHalf { get; set; }

        [DataMember(Name="noteBSharpWhole")]
        public BoundingBox NoteBSharpWhole { get; set; }

        [DataMember(Name="noteBWhole")]
        public BoundingBox NoteBWhole { get; set; }

        [DataMember(Name="noteCBlack")]
        public BoundingBox NoteCBlack { get; set; }

        [DataMember(Name="noteCFlatBlack")]
        public BoundingBox NoteCFlatBlack { get; set; }

        [DataMember(Name="noteCFlatHalf")]
        public BoundingBox NoteCFlatHalf { get; set; }

        [DataMember(Name="noteCFlatWhole")]
        public BoundingBox NoteCFlatWhole { get; set; }

        [DataMember(Name="noteCHalf")]
        public BoundingBox NoteCHalf { get; set; }

        [DataMember(Name="noteCSharpBlack")]
        public BoundingBox NoteCSharpBlack { get; set; }

        [DataMember(Name="noteCSharpHalf")]
        public BoundingBox NoteCSharpHalf { get; set; }

        [DataMember(Name="noteCSharpWhole")]
        public BoundingBox NoteCSharpWhole { get; set; }

        [DataMember(Name="noteCWhole")]
        public BoundingBox NoteCWhole { get; set; }

        [DataMember(Name="noteDBlack")]
        public BoundingBox NoteDBlack { get; set; }

        [DataMember(Name="noteDFlatBlack")]
        public BoundingBox NoteDFlatBlack { get; set; }

        [DataMember(Name="noteDFlatHalf")]
        public BoundingBox NoteDFlatHalf { get; set; }

        [DataMember(Name="noteDFlatWhole")]
        public BoundingBox NoteDFlatWhole { get; set; }

        [DataMember(Name="noteDHalf")]
        public BoundingBox NoteDHalf { get; set; }

        [DataMember(Name="noteDSharpBlack")]
        public BoundingBox NoteDSharpBlack { get; set; }

        [DataMember(Name="noteDSharpHalf")]
        public BoundingBox NoteDSharpHalf { get; set; }

        [DataMember(Name="noteDSharpWhole")]
        public BoundingBox NoteDSharpWhole { get; set; }

        [DataMember(Name="noteDWhole")]
        public BoundingBox NoteDWhole { get; set; }

        [DataMember(Name="noteDoBlack")]
        public BoundingBox NoteDoBlack { get; set; }

        [DataMember(Name="noteDoHalf")]
        public BoundingBox NoteDoHalf { get; set; }

        [DataMember(Name="noteDoWhole")]
        public BoundingBox NoteDoWhole { get; set; }

        [DataMember(Name="noteDoubleWhole")]
        public BoundingBox NoteDoubleWhole { get; set; }

        [DataMember(Name="noteDoubleWholeAlt")]
        public BoundingBox NoteDoubleWholeAlt { get; set; }

        [DataMember(Name="noteDoubleWholeSquare")]
        public BoundingBox NoteDoubleWholeSquare { get; set; }

        [DataMember(Name="noteEBlack")]
        public BoundingBox NoteEBlack { get; set; }

        [DataMember(Name="noteEFlatBlack")]
        public BoundingBox NoteEFlatBlack { get; set; }

        [DataMember(Name="noteEFlatHalf")]
        public BoundingBox NoteEFlatHalf { get; set; }

        [DataMember(Name="noteEFlatWhole")]
        public BoundingBox NoteEFlatWhole { get; set; }

        [DataMember(Name="noteEHalf")]
        public BoundingBox NoteEHalf { get; set; }

        [DataMember(Name="noteESharpBlack")]
        public BoundingBox NoteESharpBlack { get; set; }

        [DataMember(Name="noteESharpHalf")]
        public BoundingBox NoteESharpHalf { get; set; }

        [DataMember(Name="noteESharpWhole")]
        public BoundingBox NoteESharpWhole { get; set; }

        [DataMember(Name="noteEWhole")]
        public BoundingBox NoteEWhole { get; set; }

        [DataMember(Name="noteEmptyBlack")]
        public BoundingBox NoteEmptyBlack { get; set; }

        [DataMember(Name="noteEmptyHalf")]
        public BoundingBox NoteEmptyHalf { get; set; }

        [DataMember(Name="noteEmptyWhole")]
        public BoundingBox NoteEmptyWhole { get; set; }

        [DataMember(Name="noteFBlack")]
        public BoundingBox NoteFBlack { get; set; }

        [DataMember(Name="noteFFlatBlack")]
        public BoundingBox NoteFFlatBlack { get; set; }

        [DataMember(Name="noteFFlatHalf")]
        public BoundingBox NoteFFlatHalf { get; set; }

        [DataMember(Name="noteFFlatWhole")]
        public BoundingBox NoteFFlatWhole { get; set; }

        [DataMember(Name="noteFHalf")]
        public BoundingBox NoteFHalf { get; set; }

        [DataMember(Name="noteFSharpBlack")]
        public BoundingBox NoteFSharpBlack { get; set; }

        [DataMember(Name="noteFSharpHalf")]
        public BoundingBox NoteFSharpHalf { get; set; }

        [DataMember(Name="noteFSharpWhole")]
        public BoundingBox NoteFSharpWhole { get; set; }

        [DataMember(Name="noteFWhole")]
        public BoundingBox NoteFWhole { get; set; }

        [DataMember(Name="noteFaBlack")]
        public BoundingBox NoteFaBlack { get; set; }

        [DataMember(Name="noteFaHalf")]
        public BoundingBox NoteFaHalf { get; set; }

        [DataMember(Name="noteFaWhole")]
        public BoundingBox NoteFaWhole { get; set; }

        [DataMember(Name="noteGBlack")]
        public BoundingBox NoteGBlack { get; set; }

        [DataMember(Name="noteGFlatBlack")]
        public BoundingBox NoteGFlatBlack { get; set; }

        [DataMember(Name="noteGFlatHalf")]
        public BoundingBox NoteGFlatHalf { get; set; }

        [DataMember(Name="noteGFlatWhole")]
        public BoundingBox NoteGFlatWhole { get; set; }

        [DataMember(Name="noteGHalf")]
        public BoundingBox NoteGHalf { get; set; }

        [DataMember(Name="noteGSharpBlack")]
        public BoundingBox NoteGSharpBlack { get; set; }

        [DataMember(Name="noteGSharpHalf")]
        public BoundingBox NoteGSharpHalf { get; set; }

        [DataMember(Name="noteGSharpWhole")]
        public BoundingBox NoteGSharpWhole { get; set; }

        [DataMember(Name="noteGWhole")]
        public BoundingBox NoteGWhole { get; set; }

        [DataMember(Name="noteHBlack")]
        public BoundingBox NoteHBlack { get; set; }

        [DataMember(Name="noteHHalf")]
        public BoundingBox NoteHHalf { get; set; }

        [DataMember(Name="noteHSharpBlack")]
        public BoundingBox NoteHSharpBlack { get; set; }

        [DataMember(Name="noteHSharpHalf")]
        public BoundingBox NoteHSharpHalf { get; set; }

        [DataMember(Name="noteHSharpWhole")]
        public BoundingBox NoteHSharpWhole { get; set; }

        [DataMember(Name="noteHWhole")]
        public BoundingBox NoteHWhole { get; set; }

        [DataMember(Name="noteHalfDown")]
        public BoundingBox NoteHalfDown { get; set; }

        [DataMember(Name="noteHalfUp")]
        public BoundingBox NoteHalfUp { get; set; }

        [DataMember(Name="noteLaBlack")]
        public BoundingBox NoteLaBlack { get; set; }

        [DataMember(Name="noteLaHalf")]
        public BoundingBox NoteLaHalf { get; set; }

        [DataMember(Name="noteLaWhole")]
        public BoundingBox NoteLaWhole { get; set; }

        [DataMember(Name="noteMiBlack")]
        public BoundingBox NoteMiBlack { get; set; }

        [DataMember(Name="noteMiHalf")]
        public BoundingBox NoteMiHalf { get; set; }

        [DataMember(Name="noteMiWhole")]
        public BoundingBox NoteMiWhole { get; set; }

        [DataMember(Name="noteQuarterDown")]
        public BoundingBox NoteQuarterDown { get; set; }

        [DataMember(Name="noteQuarterUp")]
        public BoundingBox NoteQuarterUp { get; set; }

        [DataMember(Name="noteReBlack")]
        public BoundingBox NoteReBlack { get; set; }

        [DataMember(Name="noteReHalf")]
        public BoundingBox NoteReHalf { get; set; }

        [DataMember(Name="noteReWhole")]
        public BoundingBox NoteReWhole { get; set; }

        [DataMember(Name="noteShapeArrowheadLeftBlack")]
        public BoundingBox NoteShapeArrowheadLeftBlack { get; set; }

        [DataMember(Name="noteShapeArrowheadLeftDoubleWhole")]
        public BoundingBox NoteShapeArrowheadLeftDoubleWhole { get; set; }

        [DataMember(Name="noteShapeArrowheadLeftWhite")]
        public BoundingBox NoteShapeArrowheadLeftWhite { get; set; }

        [DataMember(Name="noteShapeDiamondBlack")]
        public BoundingBox NoteShapeDiamondBlack { get; set; }

        [DataMember(Name="noteShapeDiamondDoubleWhole")]
        public BoundingBox NoteShapeDiamondDoubleWhole { get; set; }

        [DataMember(Name="noteShapeDiamondWhite")]
        public BoundingBox NoteShapeDiamondWhite { get; set; }

        [DataMember(Name="noteShapeIsoscelesTriangleBlack")]
        public BoundingBox NoteShapeIsoscelesTriangleBlack { get; set; }

        [DataMember(Name="noteShapeIsoscelesTriangleDoubleWhole")]
        public BoundingBox NoteShapeIsoscelesTriangleDoubleWhole { get; set; }

        [DataMember(Name="noteShapeIsoscelesTriangleWhite")]
        public BoundingBox NoteShapeIsoscelesTriangleWhite { get; set; }

        [DataMember(Name="noteShapeKeystoneBlack")]
        public BoundingBox NoteShapeKeystoneBlack { get; set; }

        [DataMember(Name="noteShapeKeystoneDoubleWhole")]
        public BoundingBox NoteShapeKeystoneDoubleWhole { get; set; }

        [DataMember(Name="noteShapeKeystoneWhite")]
        public BoundingBox NoteShapeKeystoneWhite { get; set; }

        [DataMember(Name="noteShapeMoonBlack")]
        public BoundingBox NoteShapeMoonBlack { get; set; }

        [DataMember(Name="noteShapeMoonDoubleWhole")]
        public BoundingBox NoteShapeMoonDoubleWhole { get; set; }

        [DataMember(Name="noteShapeMoonLeftBlack")]
        public BoundingBox NoteShapeMoonLeftBlack { get; set; }

        [DataMember(Name="noteShapeMoonLeftDoubleWhole")]
        public BoundingBox NoteShapeMoonLeftDoubleWhole { get; set; }

        [DataMember(Name="noteShapeMoonLeftWhite")]
        public BoundingBox NoteShapeMoonLeftWhite { get; set; }

        [DataMember(Name="noteShapeMoonWhite")]
        public BoundingBox NoteShapeMoonWhite { get; set; }

        [DataMember(Name="noteShapeQuarterMoonBlack")]
        public BoundingBox NoteShapeQuarterMoonBlack { get; set; }

        [DataMember(Name="noteShapeQuarterMoonDoubleWhole")]
        public BoundingBox NoteShapeQuarterMoonDoubleWhole { get; set; }

        [DataMember(Name="noteShapeQuarterMoonWhite")]
        public BoundingBox NoteShapeQuarterMoonWhite { get; set; }

        [DataMember(Name="noteShapeRoundBlack")]
        public BoundingBox NoteShapeRoundBlack { get; set; }

        [DataMember(Name="noteShapeRoundDoubleWhole")]
        public BoundingBox NoteShapeRoundDoubleWhole { get; set; }

        [DataMember(Name="noteShapeRoundWhite")]
        public BoundingBox NoteShapeRoundWhite { get; set; }

        [DataMember(Name="noteShapeSquareBlack")]
        public BoundingBox NoteShapeSquareBlack { get; set; }

        [DataMember(Name="noteShapeSquareDoubleWhole")]
        public BoundingBox NoteShapeSquareDoubleWhole { get; set; }

        [DataMember(Name="noteShapeSquareWhite")]
        public BoundingBox NoteShapeSquareWhite { get; set; }

        [DataMember(Name="noteShapeTriangleLeftBlack")]
        public BoundingBox NoteShapeTriangleLeftBlack { get; set; }

        [DataMember(Name="noteShapeTriangleLeftDoubleWhole")]
        public BoundingBox NoteShapeTriangleLeftDoubleWhole { get; set; }

        [DataMember(Name="noteShapeTriangleLeftWhite")]
        public BoundingBox NoteShapeTriangleLeftWhite { get; set; }

        [DataMember(Name="noteShapeTriangleRightBlack")]
        public BoundingBox NoteShapeTriangleRightBlack { get; set; }

        [DataMember(Name="noteShapeTriangleRightDoubleWhole")]
        public BoundingBox NoteShapeTriangleRightDoubleWhole { get; set; }

        [DataMember(Name="noteShapeTriangleRightWhite")]
        public BoundingBox NoteShapeTriangleRightWhite { get; set; }

        [DataMember(Name="noteShapeTriangleRoundBlack")]
        public BoundingBox NoteShapeTriangleRoundBlack { get; set; }

        [DataMember(Name="noteShapeTriangleRoundDoubleWhole")]
        public BoundingBox NoteShapeTriangleRoundDoubleWhole { get; set; }

        [DataMember(Name="noteShapeTriangleRoundLeftBlack")]
        public BoundingBox NoteShapeTriangleRoundLeftBlack { get; set; }

        [DataMember(Name="noteShapeTriangleRoundLeftDoubleWhole")]
        public BoundingBox NoteShapeTriangleRoundLeftDoubleWhole { get; set; }

        [DataMember(Name="noteShapeTriangleRoundLeftWhite")]
        public BoundingBox NoteShapeTriangleRoundLeftWhite { get; set; }

        [DataMember(Name="noteShapeTriangleRoundWhite")]
        public BoundingBox NoteShapeTriangleRoundWhite { get; set; }

        [DataMember(Name="noteShapeTriangleUpBlack")]
        public BoundingBox NoteShapeTriangleUpBlack { get; set; }

        [DataMember(Name="noteShapeTriangleUpDoubleWhole")]
        public BoundingBox NoteShapeTriangleUpDoubleWhole { get; set; }

        [DataMember(Name="noteShapeTriangleUpWhite")]
        public BoundingBox NoteShapeTriangleUpWhite { get; set; }

        [DataMember(Name="noteSiBlack")]
        public BoundingBox NoteSiBlack { get; set; }

        [DataMember(Name="noteSiHalf")]
        public BoundingBox NoteSiHalf { get; set; }

        [DataMember(Name="noteSiWhole")]
        public BoundingBox NoteSiWhole { get; set; }

        [DataMember(Name="noteSoBlack")]
        public BoundingBox NoteSoBlack { get; set; }

        [DataMember(Name="noteSoHalf")]
        public BoundingBox NoteSoHalf { get; set; }

        [DataMember(Name="noteSoWhole")]
        public BoundingBox NoteSoWhole { get; set; }

        [DataMember(Name="noteTiBlack")]
        public BoundingBox NoteTiBlack { get; set; }

        [DataMember(Name="noteTiHalf")]
        public BoundingBox NoteTiHalf { get; set; }

        [DataMember(Name="noteTiWhole")]
        public BoundingBox NoteTiWhole { get; set; }

        [DataMember(Name="noteWhole")]
        public BoundingBox NoteWhole { get; set; }

        [DataMember(Name="noteheadBlack")]
        public BoundingBox NoteheadBlack { get; set; }

        [DataMember(Name="noteheadBlackOversized")]
        public BoundingBox NoteheadBlackOversized { get; set; }

        [DataMember(Name="noteheadBlackParens")]
        public BoundingBox NoteheadBlackParens { get; set; }

        [DataMember(Name="noteheadBlackSmall")]
        public BoundingBox NoteheadBlackSmall { get; set; }

        [DataMember(Name="noteheadCircleSlash")]
        public BoundingBox NoteheadCircleSlash { get; set; }

        [DataMember(Name="noteheadCircleX")]
        public BoundingBox NoteheadCircleX { get; set; }

        [DataMember(Name="noteheadCircleXDoubleWhole")]
        public BoundingBox NoteheadCircleXDoubleWhole { get; set; }

        [DataMember(Name="noteheadCircleXHalf")]
        public BoundingBox NoteheadCircleXHalf { get; set; }

        [DataMember(Name="noteheadCircleXWhole")]
        public BoundingBox NoteheadCircleXWhole { get; set; }

        [DataMember(Name="noteheadCircledBlack")]
        public BoundingBox NoteheadCircledBlack { get; set; }

        [DataMember(Name="noteheadCircledBlackLarge")]
        public BoundingBox NoteheadCircledBlackLarge { get; set; }

        [DataMember(Name="noteheadCircledDoubleWhole")]
        public BoundingBox NoteheadCircledDoubleWhole { get; set; }

        [DataMember(Name="noteheadCircledDoubleWholeLarge")]
        public BoundingBox NoteheadCircledDoubleWholeLarge { get; set; }

        [DataMember(Name="noteheadCircledHalf")]
        public BoundingBox NoteheadCircledHalf { get; set; }

        [DataMember(Name="noteheadCircledHalfLarge")]
        public BoundingBox NoteheadCircledHalfLarge { get; set; }

        [DataMember(Name="noteheadCircledWhole")]
        public BoundingBox NoteheadCircledWhole { get; set; }

        [DataMember(Name="noteheadCircledWholeLarge")]
        public BoundingBox NoteheadCircledWholeLarge { get; set; }

        [DataMember(Name="noteheadCircledXLarge")]
        public BoundingBox NoteheadCircledXLarge { get; set; }

        [DataMember(Name="noteheadClusterDoubleWhole2nd")]
        public BoundingBox NoteheadClusterDoubleWhole2Nd { get; set; }

        [DataMember(Name="noteheadClusterDoubleWhole3rd")]
        public BoundingBox NoteheadClusterDoubleWhole3Rd { get; set; }

        [DataMember(Name="noteheadClusterDoubleWholeBottom")]
        public BoundingBox NoteheadClusterDoubleWholeBottom { get; set; }

        [DataMember(Name="noteheadClusterDoubleWholeMiddle")]
        public BoundingBox NoteheadClusterDoubleWholeMiddle { get; set; }

        [DataMember(Name="noteheadClusterDoubleWholeTop")]
        public BoundingBox NoteheadClusterDoubleWholeTop { get; set; }

        [DataMember(Name="noteheadClusterHalf2nd")]
        public BoundingBox NoteheadClusterHalf2Nd { get; set; }

        [DataMember(Name="noteheadClusterHalf3rd")]
        public BoundingBox NoteheadClusterHalf3Rd { get; set; }

        [DataMember(Name="noteheadClusterHalfBottom")]
        public BoundingBox NoteheadClusterHalfBottom { get; set; }

        [DataMember(Name="noteheadClusterHalfMiddle")]
        public BoundingBox NoteheadClusterHalfMiddle { get; set; }

        [DataMember(Name="noteheadClusterHalfTop")]
        public BoundingBox NoteheadClusterHalfTop { get; set; }

        [DataMember(Name="noteheadClusterQuarter2nd")]
        public BoundingBox NoteheadClusterQuarter2Nd { get; set; }

        [DataMember(Name="noteheadClusterQuarter3rd")]
        public BoundingBox NoteheadClusterQuarter3Rd { get; set; }

        [DataMember(Name="noteheadClusterQuarterBottom")]
        public BoundingBox NoteheadClusterQuarterBottom { get; set; }

        [DataMember(Name="noteheadClusterQuarterMiddle")]
        public BoundingBox NoteheadClusterQuarterMiddle { get; set; }

        [DataMember(Name="noteheadClusterQuarterTop")]
        public BoundingBox NoteheadClusterQuarterTop { get; set; }

        [DataMember(Name="noteheadClusterRoundBlack")]
        public BoundingBox NoteheadClusterRoundBlack { get; set; }

        [DataMember(Name="noteheadClusterRoundWhite")]
        public BoundingBox NoteheadClusterRoundWhite { get; set; }

        [DataMember(Name="noteheadClusterSquareBlack")]
        public BoundingBox NoteheadClusterSquareBlack { get; set; }

        [DataMember(Name="noteheadClusterSquareWhite")]
        public BoundingBox NoteheadClusterSquareWhite { get; set; }

        [DataMember(Name="noteheadClusterWhole2nd")]
        public BoundingBox NoteheadClusterWhole2Nd { get; set; }

        [DataMember(Name="noteheadClusterWhole3rd")]
        public BoundingBox NoteheadClusterWhole3Rd { get; set; }

        [DataMember(Name="noteheadClusterWholeBottom")]
        public BoundingBox NoteheadClusterWholeBottom { get; set; }

        [DataMember(Name="noteheadClusterWholeMiddle")]
        public BoundingBox NoteheadClusterWholeMiddle { get; set; }

        [DataMember(Name="noteheadClusterWholeTop")]
        public BoundingBox NoteheadClusterWholeTop { get; set; }

        [DataMember(Name="noteheadDiamondBlack")]
        public BoundingBox NoteheadDiamondBlack { get; set; }

        [DataMember(Name="noteheadDiamondBlackOld")]
        public BoundingBox NoteheadDiamondBlackOld { get; set; }

        [DataMember(Name="noteheadDiamondBlackWide")]
        public BoundingBox NoteheadDiamondBlackWide { get; set; }

        [DataMember(Name="noteheadDiamondClusterBlack2nd")]
        public BoundingBox NoteheadDiamondClusterBlack2Nd { get; set; }

        [DataMember(Name="noteheadDiamondClusterBlack3rd")]
        public BoundingBox NoteheadDiamondClusterBlack3Rd { get; set; }

        [DataMember(Name="noteheadDiamondClusterBlackBottom")]
        public BoundingBox NoteheadDiamondClusterBlackBottom { get; set; }

        [DataMember(Name="noteheadDiamondClusterBlackMiddle")]
        public BoundingBox NoteheadDiamondClusterBlackMiddle { get; set; }

        [DataMember(Name="noteheadDiamondClusterBlackTop")]
        public BoundingBox NoteheadDiamondClusterBlackTop { get; set; }

        [DataMember(Name="noteheadDiamondClusterWhite2nd")]
        public BoundingBox NoteheadDiamondClusterWhite2Nd { get; set; }

        [DataMember(Name="noteheadDiamondClusterWhite3rd")]
        public BoundingBox NoteheadDiamondClusterWhite3Rd { get; set; }

        [DataMember(Name="noteheadDiamondClusterWhiteBottom")]
        public BoundingBox NoteheadDiamondClusterWhiteBottom { get; set; }

        [DataMember(Name="noteheadDiamondClusterWhiteMiddle")]
        public BoundingBox NoteheadDiamondClusterWhiteMiddle { get; set; }

        [DataMember(Name="noteheadDiamondClusterWhiteTop")]
        public BoundingBox NoteheadDiamondClusterWhiteTop { get; set; }

        [DataMember(Name="noteheadDiamondDoubleWhole")]
        public BoundingBox NoteheadDiamondDoubleWhole { get; set; }

        [DataMember(Name="noteheadDiamondDoubleWholeOld")]
        public BoundingBox NoteheadDiamondDoubleWholeOld { get; set; }

        [DataMember(Name="noteheadDiamondHalf")]
        public BoundingBox NoteheadDiamondHalf { get; set; }

        [DataMember(Name="noteheadDiamondHalfFilled")]
        public BoundingBox NoteheadDiamondHalfFilled { get; set; }

        [DataMember(Name="noteheadDiamondHalfOld")]
        public BoundingBox NoteheadDiamondHalfOld { get; set; }

        [DataMember(Name="noteheadDiamondHalfWide")]
        public BoundingBox NoteheadDiamondHalfWide { get; set; }

        [DataMember(Name="noteheadDiamondOpen")]
        public BoundingBox NoteheadDiamondOpen { get; set; }

        [DataMember(Name="noteheadDiamondWhite")]
        public BoundingBox NoteheadDiamondWhite { get; set; }

        [DataMember(Name="noteheadDiamondWhiteWide")]
        public BoundingBox NoteheadDiamondWhiteWide { get; set; }

        [DataMember(Name="noteheadDiamondWhole")]
        public BoundingBox NoteheadDiamondWhole { get; set; }

        [DataMember(Name="noteheadDiamondWholeOld")]
        public BoundingBox NoteheadDiamondWholeOld { get; set; }

        [DataMember(Name="noteheadDoubleWhole")]
        public BoundingBox NoteheadDoubleWhole { get; set; }

        [DataMember(Name="noteheadDoubleWholeAlt")]
        public BoundingBox NoteheadDoubleWholeAlt { get; set; }

        [DataMember(Name="noteheadDoubleWholeOversized")]
        public BoundingBox NoteheadDoubleWholeOversized { get; set; }

        [DataMember(Name="noteheadDoubleWholeParens")]
        public BoundingBox NoteheadDoubleWholeParens { get; set; }

        [DataMember(Name="noteheadDoubleWholeSmall")]
        public BoundingBox NoteheadDoubleWholeSmall { get; set; }

        [DataMember(Name="noteheadDoubleWholeSquare")]
        public BoundingBox NoteheadDoubleWholeSquare { get; set; }

        [DataMember(Name="noteheadDoubleWholeSquareOversized")]
        public BoundingBox NoteheadDoubleWholeSquareOversized { get; set; }

        [DataMember(Name="noteheadDoubleWholeWithX")]
        public BoundingBox NoteheadDoubleWholeWithX { get; set; }

        [DataMember(Name="noteheadHalf")]
        public BoundingBox NoteheadHalf { get; set; }

        [DataMember(Name="noteheadHalfFilled")]
        public BoundingBox NoteheadHalfFilled { get; set; }

        [DataMember(Name="noteheadHalfOversized")]
        public BoundingBox NoteheadHalfOversized { get; set; }

        [DataMember(Name="noteheadHalfParens")]
        public BoundingBox NoteheadHalfParens { get; set; }

        [DataMember(Name="noteheadHalfSmall")]
        public BoundingBox NoteheadHalfSmall { get; set; }

        [DataMember(Name="noteheadHalfWithX")]
        public BoundingBox NoteheadHalfWithX { get; set; }

        [DataMember(Name="noteheadHeavyX")]
        public BoundingBox NoteheadHeavyX { get; set; }

        [DataMember(Name="noteheadHeavyXHat")]
        public BoundingBox NoteheadHeavyXHat { get; set; }

        [DataMember(Name="noteheadLargeArrowDownBlack")]
        public BoundingBox NoteheadLargeArrowDownBlack { get; set; }

        [DataMember(Name="noteheadLargeArrowDownDoubleWhole")]
        public BoundingBox NoteheadLargeArrowDownDoubleWhole { get; set; }

        [DataMember(Name="noteheadLargeArrowDownHalf")]
        public BoundingBox NoteheadLargeArrowDownHalf { get; set; }

        [DataMember(Name="noteheadLargeArrowDownWhole")]
        public BoundingBox NoteheadLargeArrowDownWhole { get; set; }

        [DataMember(Name="noteheadLargeArrowUpBlack")]
        public BoundingBox NoteheadLargeArrowUpBlack { get; set; }

        [DataMember(Name="noteheadLargeArrowUpDoubleWhole")]
        public BoundingBox NoteheadLargeArrowUpDoubleWhole { get; set; }

        [DataMember(Name="noteheadLargeArrowUpHalf")]
        public BoundingBox NoteheadLargeArrowUpHalf { get; set; }

        [DataMember(Name="noteheadLargeArrowUpWhole")]
        public BoundingBox NoteheadLargeArrowUpWhole { get; set; }

        [DataMember(Name="noteheadMoonBlack")]
        public BoundingBox NoteheadMoonBlack { get; set; }

        [DataMember(Name="noteheadMoonWhite")]
        public BoundingBox NoteheadMoonWhite { get; set; }

        [DataMember(Name="noteheadParenthesis")]
        public BoundingBox NoteheadParenthesis { get; set; }

        [DataMember(Name="noteheadParenthesisLeft")]
        public BoundingBox NoteheadParenthesisLeft { get; set; }

        [DataMember(Name="noteheadParenthesisRight")]
        public BoundingBox NoteheadParenthesisRight { get; set; }

        [DataMember(Name="noteheadPlusBlack")]
        public BoundingBox NoteheadPlusBlack { get; set; }

        [DataMember(Name="noteheadPlusDoubleWhole")]
        public BoundingBox NoteheadPlusDoubleWhole { get; set; }

        [DataMember(Name="noteheadPlusHalf")]
        public BoundingBox NoteheadPlusHalf { get; set; }

        [DataMember(Name="noteheadPlusWhole")]
        public BoundingBox NoteheadPlusWhole { get; set; }

        [DataMember(Name="noteheadRectangularClusterBlackBottom")]
        public BoundingBox NoteheadRectangularClusterBlackBottom { get; set; }

        [DataMember(Name="noteheadRectangularClusterBlackMiddle")]
        public BoundingBox NoteheadRectangularClusterBlackMiddle { get; set; }

        [DataMember(Name="noteheadRectangularClusterBlackTop")]
        public BoundingBox NoteheadRectangularClusterBlackTop { get; set; }

        [DataMember(Name="noteheadRectangularClusterWhiteBottom")]
        public BoundingBox NoteheadRectangularClusterWhiteBottom { get; set; }

        [DataMember(Name="noteheadRectangularClusterWhiteMiddle")]
        public BoundingBox NoteheadRectangularClusterWhiteMiddle { get; set; }

        [DataMember(Name="noteheadRectangularClusterWhiteTop")]
        public BoundingBox NoteheadRectangularClusterWhiteTop { get; set; }

        [DataMember(Name="noteheadRoundBlack")]
        public BoundingBox NoteheadRoundBlack { get; set; }

        [DataMember(Name="noteheadRoundBlackDoubleSlashed")]
        public BoundingBox NoteheadRoundBlackDoubleSlashed { get; set; }

        [DataMember(Name="noteheadRoundBlackLarge")]
        public Dictionary<string, long[]> NoteheadRoundBlackLarge { get; set; }

        [DataMember(Name="noteheadRoundBlackSlashed")]
        public BoundingBox NoteheadRoundBlackSlashed { get; set; }

        [DataMember(Name="noteheadRoundBlackSlashedLarge")]
        public BoundingBox NoteheadRoundBlackSlashedLarge { get; set; }

        [DataMember(Name="noteheadRoundWhite")]
        public BoundingBox NoteheadRoundWhite { get; set; }

        [DataMember(Name="noteheadRoundWhiteDoubleSlashed")]
        public BoundingBox NoteheadRoundWhiteDoubleSlashed { get; set; }

        [DataMember(Name="noteheadRoundWhiteLarge")]
        public Dictionary<string, long[]> NoteheadRoundWhiteLarge { get; set; }

        [DataMember(Name="noteheadRoundWhiteSlashed")]
        public BoundingBox NoteheadRoundWhiteSlashed { get; set; }

        [DataMember(Name="noteheadRoundWhiteSlashedLarge")]
        public BoundingBox NoteheadRoundWhiteSlashedLarge { get; set; }

        [DataMember(Name="noteheadRoundWhiteWithDot")]
        public BoundingBox NoteheadRoundWhiteWithDot { get; set; }

        [DataMember(Name="noteheadRoundWhiteWithDotLarge")]
        public BoundingBox NoteheadRoundWhiteWithDotLarge { get; set; }

        [DataMember(Name="noteheadSlashDiamondWhite")]
        public Dictionary<string, long[]> NoteheadSlashDiamondWhite { get; set; }

        [DataMember(Name="noteheadSlashHorizontalEnds")]
        public BoundingBox NoteheadSlashHorizontalEnds { get; set; }

        [DataMember(Name="noteheadSlashHorizontalEndsMuted")]
        public BoundingBox NoteheadSlashHorizontalEndsMuted { get; set; }

        [DataMember(Name="noteheadSlashVerticalEnds")]
        public BoundingBox NoteheadSlashVerticalEnds { get; set; }

        [DataMember(Name="noteheadSlashVerticalEndsMuted")]
        public BoundingBox NoteheadSlashVerticalEndsMuted { get; set; }

        [DataMember(Name="noteheadSlashVerticalEndsSmall")]
        public BoundingBox NoteheadSlashVerticalEndsSmall { get; set; }

        [DataMember(Name="noteheadSlashWhiteDoubleWhole")]
        public BoundingBox NoteheadSlashWhiteDoubleWhole { get; set; }

        [DataMember(Name="noteheadSlashWhiteHalf")]
        public BoundingBox NoteheadSlashWhiteHalf { get; set; }

        [DataMember(Name="noteheadSlashWhiteMuted")]
        public BoundingBox NoteheadSlashWhiteMuted { get; set; }

        [DataMember(Name="noteheadSlashWhiteWhole")]
        public BoundingBox NoteheadSlashWhiteWhole { get; set; }

        [DataMember(Name="noteheadSlashX")]
        public BoundingBox NoteheadSlashX { get; set; }

        [DataMember(Name="noteheadSlashedBlack1")]
        public BoundingBox NoteheadSlashedBlack1 { get; set; }

        [DataMember(Name="noteheadSlashedBlack2")]
        public BoundingBox NoteheadSlashedBlack2 { get; set; }

        [DataMember(Name="noteheadSlashedDoubleWhole1")]
        public BoundingBox NoteheadSlashedDoubleWhole1 { get; set; }

        [DataMember(Name="noteheadSlashedDoubleWhole2")]
        public BoundingBox NoteheadSlashedDoubleWhole2 { get; set; }

        [DataMember(Name="noteheadSlashedHalf1")]
        public BoundingBox NoteheadSlashedHalf1 { get; set; }

        [DataMember(Name="noteheadSlashedHalf2")]
        public BoundingBox NoteheadSlashedHalf2 { get; set; }

        [DataMember(Name="noteheadSlashedWhole1")]
        public BoundingBox NoteheadSlashedWhole1 { get; set; }

        [DataMember(Name="noteheadSlashedWhole2")]
        public BoundingBox NoteheadSlashedWhole2 { get; set; }

        [DataMember(Name="noteheadSquareBlack")]
        public BoundingBox NoteheadSquareBlack { get; set; }

        [DataMember(Name="noteheadSquareBlackLarge")]
        public Dictionary<string, long[]> NoteheadSquareBlackLarge { get; set; }

        [DataMember(Name="noteheadSquareBlackWhite")]
        public Dictionary<string, long[]> NoteheadSquareBlackWhite { get; set; }

        [DataMember(Name="noteheadSquareWhite")]
        public BoundingBox NoteheadSquareWhite { get; set; }

        [DataMember(Name="noteheadTriangleDownBlack")]
        public BoundingBox NoteheadTriangleDownBlack { get; set; }

        [DataMember(Name="noteheadTriangleDownDoubleWhole")]
        public BoundingBox NoteheadTriangleDownDoubleWhole { get; set; }

        [DataMember(Name="noteheadTriangleDownHalf")]
        public BoundingBox NoteheadTriangleDownHalf { get; set; }

        [DataMember(Name="noteheadTriangleDownWhite")]
        public BoundingBox NoteheadTriangleDownWhite { get; set; }

        [DataMember(Name="noteheadTriangleDownWhole")]
        public BoundingBox NoteheadTriangleDownWhole { get; set; }

        [DataMember(Name="noteheadTriangleLeftBlack")]
        public BoundingBox NoteheadTriangleLeftBlack { get; set; }

        [DataMember(Name="noteheadTriangleLeftWhite")]
        public BoundingBox NoteheadTriangleLeftWhite { get; set; }

        [DataMember(Name="noteheadTriangleRightBlack")]
        public BoundingBox NoteheadTriangleRightBlack { get; set; }

        [DataMember(Name="noteheadTriangleRightWhite")]
        public BoundingBox NoteheadTriangleRightWhite { get; set; }

        [DataMember(Name="noteheadTriangleRoundDownBlack")]
        public BoundingBox NoteheadTriangleRoundDownBlack { get; set; }

        [DataMember(Name="noteheadTriangleRoundDownWhite")]
        public BoundingBox NoteheadTriangleRoundDownWhite { get; set; }

        [DataMember(Name="noteheadTriangleUpBlack")]
        public BoundingBox NoteheadTriangleUpBlack { get; set; }

        [DataMember(Name="noteheadTriangleUpDoubleWhole")]
        public BoundingBox NoteheadTriangleUpDoubleWhole { get; set; }

        [DataMember(Name="noteheadTriangleUpHalf")]
        public BoundingBox NoteheadTriangleUpHalf { get; set; }

        [DataMember(Name="noteheadTriangleUpRightBlack")]
        public BoundingBox NoteheadTriangleUpRightBlack { get; set; }

        [DataMember(Name="noteheadTriangleUpRightWhite")]
        public BoundingBox NoteheadTriangleUpRightWhite { get; set; }

        [DataMember(Name="noteheadTriangleUpWhite")]
        public BoundingBox NoteheadTriangleUpWhite { get; set; }

        [DataMember(Name="noteheadTriangleUpWhole")]
        public BoundingBox NoteheadTriangleUpWhole { get; set; }

        [DataMember(Name="noteheadVoidWithX")]
        public BoundingBox NoteheadVoidWithX { get; set; }

        [DataMember(Name="noteheadWhole")]
        public BoundingBox NoteheadWhole { get; set; }

        [DataMember(Name="noteheadWholeFilled")]
        public BoundingBox NoteheadWholeFilled { get; set; }

        [DataMember(Name="noteheadWholeOversized")]
        public BoundingBox NoteheadWholeOversized { get; set; }

        [DataMember(Name="noteheadWholeParens")]
        public BoundingBox NoteheadWholeParens { get; set; }

        [DataMember(Name="noteheadWholeSmall")]
        public BoundingBox NoteheadWholeSmall { get; set; }

        [DataMember(Name="noteheadWholeWithX")]
        public BoundingBox NoteheadWholeWithX { get; set; }

        [DataMember(Name="noteheadXBlack")]
        public BoundingBox NoteheadXBlack { get; set; }

        [DataMember(Name="noteheadXDoubleWhole")]
        public BoundingBox NoteheadXDoubleWhole { get; set; }

        [DataMember(Name="noteheadXHalf")]
        public BoundingBox NoteheadXHalf { get; set; }

        [DataMember(Name="noteheadXOrnate")]
        public BoundingBox NoteheadXOrnate { get; set; }

        [DataMember(Name="noteheadXOrnateEllipse")]
        public BoundingBox NoteheadXOrnateEllipse { get; set; }

        [DataMember(Name="noteheadXWhole")]
        public BoundingBox NoteheadXWhole { get; set; }

        [DataMember(Name="octaveBaselineA")]
        public BoundingBox OctaveBaselineA { get; set; }

        [DataMember(Name="octaveBaselineB")]
        public BoundingBox OctaveBaselineB { get; set; }

        [DataMember(Name="octaveBaselineM")]
        public BoundingBox OctaveBaselineM { get; set; }

        [DataMember(Name="octaveBaselineV")]
        public BoundingBox OctaveBaselineV { get; set; }

        [DataMember(Name="octaveBassa")]
        public BoundingBox OctaveBassa { get; set; }

        [DataMember(Name="octaveLoco")]
        public BoundingBox OctaveLoco { get; set; }

        [DataMember(Name="octaveParensLeft")]
        public BoundingBox OctaveParensLeft { get; set; }

        [DataMember(Name="octaveParensRight")]
        public BoundingBox OctaveParensRight { get; set; }

        [DataMember(Name="octaveSuperscriptA")]
        public BoundingBox OctaveSuperscriptA { get; set; }

        [DataMember(Name="octaveSuperscriptB")]
        public BoundingBox OctaveSuperscriptB { get; set; }

        [DataMember(Name="octaveSuperscriptM")]
        public BoundingBox OctaveSuperscriptM { get; set; }

        [DataMember(Name="octaveSuperscriptV")]
        public BoundingBox OctaveSuperscriptV { get; set; }

        [DataMember(Name="ornamentBottomLeftConcaveStroke")]
        public BoundingBox OrnamentBottomLeftConcaveStroke { get; set; }

        [DataMember(Name="ornamentBottomLeftConcaveStrokeLarge")]
        public BoundingBox OrnamentBottomLeftConcaveStrokeLarge { get; set; }

        [DataMember(Name="ornamentBottomLeftConvexStroke")]
        public BoundingBox OrnamentBottomLeftConvexStroke { get; set; }

        [DataMember(Name="ornamentBottomRightConcaveStroke")]
        public BoundingBox OrnamentBottomRightConcaveStroke { get; set; }

        [DataMember(Name="ornamentBottomRightConvexStroke")]
        public BoundingBox OrnamentBottomRightConvexStroke { get; set; }

        [DataMember(Name="ornamentComma")]
        public BoundingBox OrnamentComma { get; set; }

        [DataMember(Name="ornamentDoubleObliqueLinesAfterNote")]
        public BoundingBox OrnamentDoubleObliqueLinesAfterNote { get; set; }

        [DataMember(Name="ornamentDoubleObliqueLinesBeforeNote")]
        public BoundingBox OrnamentDoubleObliqueLinesBeforeNote { get; set; }

        [DataMember(Name="ornamentDownCurve")]
        public BoundingBox OrnamentDownCurve { get; set; }

        [DataMember(Name="ornamentHaydn")]
        public BoundingBox OrnamentHaydn { get; set; }

        [DataMember(Name="ornamentHighLeftConcaveStroke")]
        public BoundingBox OrnamentHighLeftConcaveStroke { get; set; }

        [DataMember(Name="ornamentHighLeftConvexStroke")]
        public BoundingBox OrnamentHighLeftConvexStroke { get; set; }

        [DataMember(Name="ornamentHighRightConcaveStroke")]
        public BoundingBox OrnamentHighRightConcaveStroke { get; set; }

        [DataMember(Name="ornamentHighRightConvexStroke")]
        public BoundingBox OrnamentHighRightConvexStroke { get; set; }

        [DataMember(Name="ornamentHookAfterNote")]
        public BoundingBox OrnamentHookAfterNote { get; set; }

        [DataMember(Name="ornamentHookBeforeNote")]
        public BoundingBox OrnamentHookBeforeNote { get; set; }

        [DataMember(Name="ornamentLeftFacingHalfCircle")]
        public BoundingBox OrnamentLeftFacingHalfCircle { get; set; }

        [DataMember(Name="ornamentLeftFacingHook")]
        public BoundingBox OrnamentLeftFacingHook { get; set; }

        [DataMember(Name="ornamentLeftPlus")]
        public BoundingBox OrnamentLeftPlus { get; set; }

        [DataMember(Name="ornamentLeftShakeT")]
        public BoundingBox OrnamentLeftShakeT { get; set; }

        [DataMember(Name="ornamentLeftVerticalStroke")]
        public BoundingBox OrnamentLeftVerticalStroke { get; set; }

        [DataMember(Name="ornamentLeftVerticalStrokeWithCross")]
        public BoundingBox OrnamentLeftVerticalStrokeWithCross { get; set; }

        [DataMember(Name="ornamentLowLeftConcaveStroke")]
        public BoundingBox OrnamentLowLeftConcaveStroke { get; set; }

        [DataMember(Name="ornamentLowLeftConvexStroke")]
        public BoundingBox OrnamentLowLeftConvexStroke { get; set; }

        [DataMember(Name="ornamentLowRightConcaveStroke")]
        public BoundingBox OrnamentLowRightConcaveStroke { get; set; }

        [DataMember(Name="ornamentLowRightConvexStroke")]
        public BoundingBox OrnamentLowRightConvexStroke { get; set; }

        [DataMember(Name="ornamentMiddleVerticalStroke")]
        public BoundingBox OrnamentMiddleVerticalStroke { get; set; }

        [DataMember(Name="ornamentMordent")]
        public BoundingBox OrnamentMordent { get; set; }

        [DataMember(Name="ornamentMordentInverted")]
        public BoundingBox OrnamentMordentInverted { get; set; }

        [DataMember(Name="ornamentObliqueLineAfterNote")]
        public BoundingBox OrnamentObliqueLineAfterNote { get; set; }

        [DataMember(Name="ornamentObliqueLineBeforeNote")]
        public BoundingBox OrnamentObliqueLineBeforeNote { get; set; }

        [DataMember(Name="ornamentObliqueLineHorizAfterNote")]
        public BoundingBox OrnamentObliqueLineHorizAfterNote { get; set; }

        [DataMember(Name="ornamentObliqueLineHorizBeforeNote")]
        public BoundingBox OrnamentObliqueLineHorizBeforeNote { get; set; }

        [DataMember(Name="ornamentOriscus")]
        public BoundingBox OrnamentOriscus { get; set; }

        [DataMember(Name="ornamentPinceCouperin")]
        public BoundingBox OrnamentPinceCouperin { get; set; }

        [DataMember(Name="ornamentPortDeVoixV")]
        public BoundingBox OrnamentPortDeVoixV { get; set; }

        [DataMember(Name="ornamentPrecompAppoggTrill")]
        public BoundingBox OrnamentPrecompAppoggTrill { get; set; }

        [DataMember(Name="ornamentPrecompAppoggTrillSuffix")]
        public BoundingBox OrnamentPrecompAppoggTrillSuffix { get; set; }

        [DataMember(Name="ornamentPrecompCadence")]
        public BoundingBox OrnamentPrecompCadence { get; set; }

        [DataMember(Name="ornamentPrecompCadenceUpperPrefix")]
        public BoundingBox OrnamentPrecompCadenceUpperPrefix { get; set; }

        [DataMember(Name="ornamentPrecompCadenceUpperPrefixTurn")]
        public BoundingBox OrnamentPrecompCadenceUpperPrefixTurn { get; set; }

        [DataMember(Name="ornamentPrecompCadenceWithTurn")]
        public BoundingBox OrnamentPrecompCadenceWithTurn { get; set; }

        [DataMember(Name="ornamentPrecompDescendingSlide")]
        public BoundingBox OrnamentPrecompDescendingSlide { get; set; }

        [DataMember(Name="ornamentPrecompDoubleCadenceLowerPrefix")]
        public BoundingBox OrnamentPrecompDoubleCadenceLowerPrefix { get; set; }

        [DataMember(Name="ornamentPrecompDoubleCadenceUpperPrefix")]
        public BoundingBox OrnamentPrecompDoubleCadenceUpperPrefix { get; set; }

        [DataMember(Name="ornamentPrecompDoubleCadenceUpperPrefixTurn")]
        public BoundingBox OrnamentPrecompDoubleCadenceUpperPrefixTurn { get; set; }

        [DataMember(Name="ornamentPrecompInvertedMordentUpperPrefix")]
        public BoundingBox OrnamentPrecompInvertedMordentUpperPrefix { get; set; }

        [DataMember(Name="ornamentPrecompMordentRelease")]
        public BoundingBox OrnamentPrecompMordentRelease { get; set; }

        [DataMember(Name="ornamentPrecompMordentUpperPrefix")]
        public BoundingBox OrnamentPrecompMordentUpperPrefix { get; set; }

        [DataMember(Name="ornamentPrecompPortDeVoixMordent")]
        public BoundingBox OrnamentPrecompPortDeVoixMordent { get; set; }

        [DataMember(Name="ornamentPrecompSlide")]
        public BoundingBox OrnamentPrecompSlide { get; set; }

        [DataMember(Name="ornamentPrecompSlideTrillBach")]
        public BoundingBox OrnamentPrecompSlideTrillBach { get; set; }

        [DataMember(Name="ornamentPrecompSlideTrillDAnglebert")]
        public BoundingBox OrnamentPrecompSlideTrillDAnglebert { get; set; }

        [DataMember(Name="ornamentPrecompSlideTrillMarpurg")]
        public BoundingBox OrnamentPrecompSlideTrillMarpurg { get; set; }

        [DataMember(Name="ornamentPrecompSlideTrillMuffat")]
        public BoundingBox OrnamentPrecompSlideTrillMuffat { get; set; }

        [DataMember(Name="ornamentPrecompSlideTrillSuffixMuffat")]
        public BoundingBox OrnamentPrecompSlideTrillSuffixMuffat { get; set; }

        [DataMember(Name="ornamentPrecompTrillLowerSuffix")]
        public BoundingBox OrnamentPrecompTrillLowerSuffix { get; set; }

        [DataMember(Name="ornamentPrecompTrillSuffixDandrieu")]
        public BoundingBox OrnamentPrecompTrillSuffixDandrieu { get; set; }

        [DataMember(Name="ornamentPrecompTrillWithMordent")]
        public BoundingBox OrnamentPrecompTrillWithMordent { get; set; }

        [DataMember(Name="ornamentPrecompTurnTrillBach")]
        public BoundingBox OrnamentPrecompTurnTrillBach { get; set; }

        [DataMember(Name="ornamentPrecompTurnTrillDAnglebert")]
        public BoundingBox OrnamentPrecompTurnTrillDAnglebert { get; set; }

        [DataMember(Name="ornamentQuilisma")]
        public BoundingBox OrnamentQuilisma { get; set; }

        [DataMember(Name="ornamentRightFacingHalfCircle")]
        public BoundingBox OrnamentRightFacingHalfCircle { get; set; }

        [DataMember(Name="ornamentRightFacingHook")]
        public BoundingBox OrnamentRightFacingHook { get; set; }

        [DataMember(Name="ornamentRightVerticalStroke")]
        public BoundingBox OrnamentRightVerticalStroke { get; set; }

        [DataMember(Name="ornamentSchleifer")]
        public BoundingBox OrnamentSchleifer { get; set; }

        [DataMember(Name="ornamentShake3")]
        public BoundingBox OrnamentShake3 { get; set; }

        [DataMember(Name="ornamentShakeMuffat1")]
        public BoundingBox OrnamentShakeMuffat1 { get; set; }

        [DataMember(Name="ornamentShortObliqueLineAfterNote")]
        public BoundingBox OrnamentShortObliqueLineAfterNote { get; set; }

        [DataMember(Name="ornamentShortObliqueLineBeforeNote")]
        public BoundingBox OrnamentShortObliqueLineBeforeNote { get; set; }

        [DataMember(Name="ornamentTopLeftConcaveStroke")]
        public BoundingBox OrnamentTopLeftConcaveStroke { get; set; }

        [DataMember(Name="ornamentTopLeftConvexStroke")]
        public BoundingBox OrnamentTopLeftConvexStroke { get; set; }

        [DataMember(Name="ornamentTopRightConcaveStroke")]
        public BoundingBox OrnamentTopRightConcaveStroke { get; set; }

        [DataMember(Name="ornamentTopRightConvexStroke")]
        public BoundingBox OrnamentTopRightConvexStroke { get; set; }

        [DataMember(Name="ornamentTremblement")]
        public BoundingBox OrnamentTremblement { get; set; }

        [DataMember(Name="ornamentTremblementCouperin")]
        public BoundingBox OrnamentTremblementCouperin { get; set; }

        [DataMember(Name="ornamentTrill")]
        public BoundingBox OrnamentTrill { get; set; }

        [DataMember(Name="ornamentTrillFlatAbove")]
        public BoundingBox OrnamentTrillFlatAbove { get; set; }

        [DataMember(Name="ornamentTrillNaturalAbove")]
        public BoundingBox OrnamentTrillNaturalAbove { get; set; }

        [DataMember(Name="ornamentTrillSharpAbove")]
        public BoundingBox OrnamentTrillSharpAbove { get; set; }

        [DataMember(Name="ornamentTurn")]
        public BoundingBox OrnamentTurn { get; set; }

        [DataMember(Name="ornamentTurnFlatAbove")]
        public BoundingBox OrnamentTurnFlatAbove { get; set; }

        [DataMember(Name="ornamentTurnFlatAboveSharpBelow")]
        public BoundingBox OrnamentTurnFlatAboveSharpBelow { get; set; }

        [DataMember(Name="ornamentTurnFlatBelow")]
        public BoundingBox OrnamentTurnFlatBelow { get; set; }

        [DataMember(Name="ornamentTurnInverted")]
        public BoundingBox OrnamentTurnInverted { get; set; }

        [DataMember(Name="ornamentTurnNaturalAbove")]
        public BoundingBox OrnamentTurnNaturalAbove { get; set; }

        [DataMember(Name="ornamentTurnNaturalBelow")]
        public BoundingBox OrnamentTurnNaturalBelow { get; set; }

        [DataMember(Name="ornamentTurnSharpAbove")]
        public BoundingBox OrnamentTurnSharpAbove { get; set; }

        [DataMember(Name="ornamentTurnSharpAboveFlatBelow")]
        public BoundingBox OrnamentTurnSharpAboveFlatBelow { get; set; }

        [DataMember(Name="ornamentTurnSharpBelow")]
        public BoundingBox OrnamentTurnSharpBelow { get; set; }

        [DataMember(Name="ornamentTurnSlash")]
        public BoundingBox OrnamentTurnSlash { get; set; }

        [DataMember(Name="ornamentTurnUp")]
        public BoundingBox OrnamentTurnUp { get; set; }

        [DataMember(Name="ornamentTurnUpS")]
        public BoundingBox OrnamentTurnUpS { get; set; }

        [DataMember(Name="ornamentUpCurve")]
        public BoundingBox OrnamentUpCurve { get; set; }

        [DataMember(Name="ornamentVerticalLine")]
        public BoundingBox OrnamentVerticalLine { get; set; }

        [DataMember(Name="ornamentZigZagLineNoRightEnd")]
        public BoundingBox OrnamentZigZagLineNoRightEnd { get; set; }

        [DataMember(Name="ornamentZigZagLineWithRightEnd")]
        public BoundingBox OrnamentZigZagLineWithRightEnd { get; set; }

        [DataMember(Name="ottava")]
        public BoundingBox Ottava { get; set; }

        [DataMember(Name="ottavaAlta")]
        public BoundingBox OttavaAlta { get; set; }

        [DataMember(Name="ottavaBassa")]
        public BoundingBox OttavaBassa { get; set; }

        [DataMember(Name="ottavaBassaBa")]
        public BoundingBox OttavaBassaBa { get; set; }

        [DataMember(Name="ottavaBassaVb")]
        public BoundingBox OttavaBassaVb { get; set; }

        [DataMember(Name="pendereckiTremolo")]
        public BoundingBox PendereckiTremolo { get; set; }

        [DataMember(Name="pictAgogo")]
        public BoundingBox PictAgogo { get; set; }

        [DataMember(Name="pictAlmglocken")]
        public BoundingBox PictAlmglocken { get; set; }

        [DataMember(Name="pictAnvil")]
        public BoundingBox PictAnvil { get; set; }

        [DataMember(Name="pictBambooChimes")]
        public BoundingBox PictBambooChimes { get; set; }

        [DataMember(Name="pictBambooScraper")]
        public BoundingBox PictBambooScraper { get; set; }

        [DataMember(Name="pictBassDrum")]
        public BoundingBox PictBassDrum { get; set; }

        [DataMember(Name="pictBassDrumOnSide")]
        public BoundingBox PictBassDrumOnSide { get; set; }

        [DataMember(Name="pictBassDrumPeinkofer")]
        public BoundingBox PictBassDrumPeinkofer { get; set; }

        [DataMember(Name="pictBeaterBow")]
        public BoundingBox PictBeaterBow { get; set; }

        [DataMember(Name="pictBeaterBox")]
        public BoundingBox PictBeaterBox { get; set; }

        [DataMember(Name="pictBeaterBrassMalletsDown")]
        public BoundingBox PictBeaterBrassMalletsDown { get; set; }

        [DataMember(Name="pictBeaterBrassMalletsUp")]
        public BoundingBox PictBeaterBrassMalletsUp { get; set; }

        [DataMember(Name="pictBeaterCombiningDashedCircle")]
        public BoundingBox PictBeaterCombiningDashedCircle { get; set; }

        [DataMember(Name="pictBeaterCombiningParentheses")]
        public BoundingBox PictBeaterCombiningParentheses { get; set; }

        [DataMember(Name="pictBeaterDoubleBassDrumDown")]
        public BoundingBox PictBeaterDoubleBassDrumDown { get; set; }

        [DataMember(Name="pictBeaterDoubleBassDrumUp")]
        public BoundingBox PictBeaterDoubleBassDrumUp { get; set; }

        [DataMember(Name="pictBeaterFinger")]
        public BoundingBox PictBeaterFinger { get; set; }

        [DataMember(Name="pictBeaterFingernails")]
        public BoundingBox PictBeaterFingernails { get; set; }

        [DataMember(Name="pictBeaterFist")]
        public BoundingBox PictBeaterFist { get; set; }

        [DataMember(Name="pictBeaterGuiroScraper")]
        public BoundingBox PictBeaterGuiroScraper { get; set; }

        [DataMember(Name="pictBeaterHammer")]
        public BoundingBox PictBeaterHammer { get; set; }

        [DataMember(Name="pictBeaterHammerMetalDown")]
        public BoundingBox PictBeaterHammerMetalDown { get; set; }

        [DataMember(Name="pictBeaterHammerMetalUp")]
        public BoundingBox PictBeaterHammerMetalUp { get; set; }

        [DataMember(Name="pictBeaterHammerPlasticDown")]
        public BoundingBox PictBeaterHammerPlasticDown { get; set; }

        [DataMember(Name="pictBeaterHammerPlasticUp")]
        public BoundingBox PictBeaterHammerPlasticUp { get; set; }

        [DataMember(Name="pictBeaterHammerWoodDown")]
        public BoundingBox PictBeaterHammerWoodDown { get; set; }

        [DataMember(Name="pictBeaterHammerWoodUp")]
        public BoundingBox PictBeaterHammerWoodUp { get; set; }

        [DataMember(Name="pictBeaterHand")]
        public BoundingBox PictBeaterHand { get; set; }

        [DataMember(Name="pictBeaterHardBassDrumDown")]
        public BoundingBox PictBeaterHardBassDrumDown { get; set; }

        [DataMember(Name="pictBeaterHardBassDrumUp")]
        public BoundingBox PictBeaterHardBassDrumUp { get; set; }

        [DataMember(Name="pictBeaterHardGlockenspielDown")]
        public BoundingBox PictBeaterHardGlockenspielDown { get; set; }

        [DataMember(Name="pictBeaterHardGlockenspielLeft")]
        public BoundingBox PictBeaterHardGlockenspielLeft { get; set; }

        [DataMember(Name="pictBeaterHardGlockenspielRight")]
        public BoundingBox PictBeaterHardGlockenspielRight { get; set; }

        [DataMember(Name="pictBeaterHardGlockenspielUp")]
        public BoundingBox PictBeaterHardGlockenspielUp { get; set; }

        [DataMember(Name="pictBeaterHardTimpaniDown")]
        public BoundingBox PictBeaterHardTimpaniDown { get; set; }

        [DataMember(Name="pictBeaterHardTimpaniLeft")]
        public BoundingBox PictBeaterHardTimpaniLeft { get; set; }

        [DataMember(Name="pictBeaterHardTimpaniRight")]
        public BoundingBox PictBeaterHardTimpaniRight { get; set; }

        [DataMember(Name="pictBeaterHardTimpaniUp")]
        public BoundingBox PictBeaterHardTimpaniUp { get; set; }

        [DataMember(Name="pictBeaterHardXylophoneDown")]
        public BoundingBox PictBeaterHardXylophoneDown { get; set; }

        [DataMember(Name="pictBeaterHardXylophoneLeft")]
        public BoundingBox PictBeaterHardXylophoneLeft { get; set; }

        [DataMember(Name="pictBeaterHardXylophoneRight")]
        public BoundingBox PictBeaterHardXylophoneRight { get; set; }

        [DataMember(Name="pictBeaterHardXylophoneUp")]
        public BoundingBox PictBeaterHardXylophoneUp { get; set; }

        [DataMember(Name="pictBeaterHardYarnDown")]
        public BoundingBox PictBeaterHardYarnDown { get; set; }

        [DataMember(Name="pictBeaterHardYarnLeft")]
        public BoundingBox PictBeaterHardYarnLeft { get; set; }

        [DataMember(Name="pictBeaterHardYarnRight")]
        public BoundingBox PictBeaterHardYarnRight { get; set; }

        [DataMember(Name="pictBeaterHardYarnUp")]
        public BoundingBox PictBeaterHardYarnUp { get; set; }

        [DataMember(Name="pictBeaterJazzSticksDown")]
        public BoundingBox PictBeaterJazzSticksDown { get; set; }

        [DataMember(Name="pictBeaterJazzSticksUp")]
        public BoundingBox PictBeaterJazzSticksUp { get; set; }

        [DataMember(Name="pictBeaterKnittingNeedle")]
        public BoundingBox PictBeaterKnittingNeedle { get; set; }

        [DataMember(Name="pictBeaterMallet")]
        public BoundingBox PictBeaterMallet { get; set; }

        [DataMember(Name="pictBeaterMediumBassDrumDown")]
        public BoundingBox PictBeaterMediumBassDrumDown { get; set; }

        [DataMember(Name="pictBeaterMediumBassDrumUp")]
        public BoundingBox PictBeaterMediumBassDrumUp { get; set; }

        [DataMember(Name="pictBeaterMediumTimpaniDown")]
        public BoundingBox PictBeaterMediumTimpaniDown { get; set; }

        [DataMember(Name="pictBeaterMediumTimpaniLeft")]
        public BoundingBox PictBeaterMediumTimpaniLeft { get; set; }

        [DataMember(Name="pictBeaterMediumTimpaniRight")]
        public BoundingBox PictBeaterMediumTimpaniRight { get; set; }

        [DataMember(Name="pictBeaterMediumTimpaniUp")]
        public BoundingBox PictBeaterMediumTimpaniUp { get; set; }

        [DataMember(Name="pictBeaterMediumXylophoneDown")]
        public BoundingBox PictBeaterMediumXylophoneDown { get; set; }

        [DataMember(Name="pictBeaterMediumXylophoneLeft")]
        public BoundingBox PictBeaterMediumXylophoneLeft { get; set; }

        [DataMember(Name="pictBeaterMediumXylophoneRight")]
        public BoundingBox PictBeaterMediumXylophoneRight { get; set; }

        [DataMember(Name="pictBeaterMediumXylophoneUp")]
        public BoundingBox PictBeaterMediumXylophoneUp { get; set; }

        [DataMember(Name="pictBeaterMediumYarnDown")]
        public BoundingBox PictBeaterMediumYarnDown { get; set; }

        [DataMember(Name="pictBeaterMediumYarnLeft")]
        public BoundingBox PictBeaterMediumYarnLeft { get; set; }

        [DataMember(Name="pictBeaterMediumYarnRight")]
        public BoundingBox PictBeaterMediumYarnRight { get; set; }

        [DataMember(Name="pictBeaterMediumYarnUp")]
        public BoundingBox PictBeaterMediumYarnUp { get; set; }

        [DataMember(Name="pictBeaterMetalBassDrumDown")]
        public BoundingBox PictBeaterMetalBassDrumDown { get; set; }

        [DataMember(Name="pictBeaterMetalBassDrumUp")]
        public BoundingBox PictBeaterMetalBassDrumUp { get; set; }

        [DataMember(Name="pictBeaterMetalDown")]
        public BoundingBox PictBeaterMetalDown { get; set; }

        [DataMember(Name="pictBeaterMetalHammer")]
        public BoundingBox PictBeaterMetalHammer { get; set; }

        [DataMember(Name="pictBeaterMetalLeft")]
        public BoundingBox PictBeaterMetalLeft { get; set; }

        [DataMember(Name="pictBeaterMetalRight")]
        public BoundingBox PictBeaterMetalRight { get; set; }

        [DataMember(Name="pictBeaterMetalUp")]
        public BoundingBox PictBeaterMetalUp { get; set; }

        [DataMember(Name="pictBeaterSnareSticksDown")]
        public BoundingBox PictBeaterSnareSticksDown { get; set; }

        [DataMember(Name="pictBeaterSnareSticksUp")]
        public BoundingBox PictBeaterSnareSticksUp { get; set; }

        [DataMember(Name="pictBeaterSoftBassDrumDown")]
        public BoundingBox PictBeaterSoftBassDrumDown { get; set; }

        [DataMember(Name="pictBeaterSoftBassDrumUp")]
        public BoundingBox PictBeaterSoftBassDrumUp { get; set; }

        [DataMember(Name="pictBeaterSoftGlockenspielDown")]
        public BoundingBox PictBeaterSoftGlockenspielDown { get; set; }

        [DataMember(Name="pictBeaterSoftGlockenspielLeft")]
        public BoundingBox PictBeaterSoftGlockenspielLeft { get; set; }

        [DataMember(Name="pictBeaterSoftGlockenspielRight")]
        public BoundingBox PictBeaterSoftGlockenspielRight { get; set; }

        [DataMember(Name="pictBeaterSoftGlockenspielUp")]
        public BoundingBox PictBeaterSoftGlockenspielUp { get; set; }

        [DataMember(Name="pictBeaterSoftTimpaniDown")]
        public BoundingBox PictBeaterSoftTimpaniDown { get; set; }

        [DataMember(Name="pictBeaterSoftTimpaniLeft")]
        public BoundingBox PictBeaterSoftTimpaniLeft { get; set; }

        [DataMember(Name="pictBeaterSoftTimpaniRight")]
        public BoundingBox PictBeaterSoftTimpaniRight { get; set; }

        [DataMember(Name="pictBeaterSoftTimpaniUp")]
        public BoundingBox PictBeaterSoftTimpaniUp { get; set; }

        [DataMember(Name="pictBeaterSoftXylophone")]
        public BoundingBox PictBeaterSoftXylophone { get; set; }

        [DataMember(Name="pictBeaterSoftXylophoneDown")]
        public BoundingBox PictBeaterSoftXylophoneDown { get; set; }

        [DataMember(Name="pictBeaterSoftXylophoneLeft")]
        public BoundingBox PictBeaterSoftXylophoneLeft { get; set; }

        [DataMember(Name="pictBeaterSoftXylophoneRight")]
        public BoundingBox PictBeaterSoftXylophoneRight { get; set; }

        [DataMember(Name="pictBeaterSoftXylophoneUp")]
        public BoundingBox PictBeaterSoftXylophoneUp { get; set; }

        [DataMember(Name="pictBeaterSoftYarnDown")]
        public BoundingBox PictBeaterSoftYarnDown { get; set; }

        [DataMember(Name="pictBeaterSoftYarnLeft")]
        public BoundingBox PictBeaterSoftYarnLeft { get; set; }

        [DataMember(Name="pictBeaterSoftYarnRight")]
        public BoundingBox PictBeaterSoftYarnRight { get; set; }

        [DataMember(Name="pictBeaterSoftYarnUp")]
        public BoundingBox PictBeaterSoftYarnUp { get; set; }

        [DataMember(Name="pictBeaterSpoonWoodenMallet")]
        public BoundingBox PictBeaterSpoonWoodenMallet { get; set; }

        [DataMember(Name="pictBeaterSuperballDown")]
        public BoundingBox PictBeaterSuperballDown { get; set; }

        [DataMember(Name="pictBeaterSuperballLeft")]
        public BoundingBox PictBeaterSuperballLeft { get; set; }

        [DataMember(Name="pictBeaterSuperballRight")]
        public BoundingBox PictBeaterSuperballRight { get; set; }

        [DataMember(Name="pictBeaterSuperballUp")]
        public BoundingBox PictBeaterSuperballUp { get; set; }

        [DataMember(Name="pictBeaterTriangleDown")]
        public BoundingBox PictBeaterTriangleDown { get; set; }

        [DataMember(Name="pictBeaterTriangleUp")]
        public BoundingBox PictBeaterTriangleUp { get; set; }

        [DataMember(Name="pictBeaterWireBrushesDown")]
        public BoundingBox PictBeaterWireBrushesDown { get; set; }

        [DataMember(Name="pictBeaterWireBrushesUp")]
        public BoundingBox PictBeaterWireBrushesUp { get; set; }

        [DataMember(Name="pictBeaterWoodTimpaniDown")]
        public BoundingBox PictBeaterWoodTimpaniDown { get; set; }

        [DataMember(Name="pictBeaterWoodTimpaniLeft")]
        public BoundingBox PictBeaterWoodTimpaniLeft { get; set; }

        [DataMember(Name="pictBeaterWoodTimpaniRight")]
        public BoundingBox PictBeaterWoodTimpaniRight { get; set; }

        [DataMember(Name="pictBeaterWoodTimpaniUp")]
        public BoundingBox PictBeaterWoodTimpaniUp { get; set; }

        [DataMember(Name="pictBeaterWoodXylophoneDown")]
        public BoundingBox PictBeaterWoodXylophoneDown { get; set; }

        [DataMember(Name="pictBeaterWoodXylophoneLeft")]
        public BoundingBox PictBeaterWoodXylophoneLeft { get; set; }

        [DataMember(Name="pictBeaterWoodXylophoneRight")]
        public BoundingBox PictBeaterWoodXylophoneRight { get; set; }

        [DataMember(Name="pictBeaterWoodXylophoneUp")]
        public BoundingBox PictBeaterWoodXylophoneUp { get; set; }

        [DataMember(Name="pictBell")]
        public BoundingBox PictBell { get; set; }

        [DataMember(Name="pictBellOfCymbal")]
        public BoundingBox PictBellOfCymbal { get; set; }

        [DataMember(Name="pictBellPlate")]
        public BoundingBox PictBellPlate { get; set; }

        [DataMember(Name="pictBellTree")]
        public BoundingBox PictBellTree { get; set; }

        [DataMember(Name="pictBirdWhistle")]
        public BoundingBox PictBirdWhistle { get; set; }

        [DataMember(Name="pictBoardClapper")]
        public BoundingBox PictBoardClapper { get; set; }

        [DataMember(Name="pictBongos")]
        public BoundingBox PictBongos { get; set; }

        [DataMember(Name="pictBongosPeinkofer")]
        public BoundingBox PictBongosPeinkofer { get; set; }

        [DataMember(Name="pictBrakeDrum")]
        public BoundingBox PictBrakeDrum { get; set; }

        [DataMember(Name="pictCabasa")]
        public BoundingBox PictCabasa { get; set; }

        [DataMember(Name="pictCannon")]
        public BoundingBox PictCannon { get; set; }

        [DataMember(Name="pictCarHorn")]
        public BoundingBox PictCarHorn { get; set; }

        [DataMember(Name="pictCastanets")]
        public BoundingBox PictCastanets { get; set; }

        [DataMember(Name="pictCastanetsSmithBrindle")]
        public BoundingBox PictCastanetsSmithBrindle { get; set; }

        [DataMember(Name="pictCastanetsWithHandle")]
        public BoundingBox PictCastanetsWithHandle { get; set; }

        [DataMember(Name="pictCelesta")]
        public BoundingBox PictCelesta { get; set; }

        [DataMember(Name="pictCencerro")]
        public BoundingBox PictCencerro { get; set; }

        [DataMember(Name="pictCenter1")]
        public BoundingBox PictCenter1 { get; set; }

        [DataMember(Name="pictCenter2")]
        public BoundingBox PictCenter2 { get; set; }

        [DataMember(Name="pictCenter3")]
        public BoundingBox PictCenter3 { get; set; }

        [DataMember(Name="pictChainRattle")]
        public BoundingBox PictChainRattle { get; set; }

        [DataMember(Name="pictChimes")]
        public BoundingBox PictChimes { get; set; }

        [DataMember(Name="pictChineseCymbal")]
        public BoundingBox PictChineseCymbal { get; set; }

        [DataMember(Name="pictChokeCymbal")]
        public BoundingBox PictChokeCymbal { get; set; }

        [DataMember(Name="pictClaves")]
        public BoundingBox PictClaves { get; set; }

        [DataMember(Name="pictCoins")]
        public BoundingBox PictCoins { get; set; }

        [DataMember(Name="pictConga")]
        public BoundingBox PictConga { get; set; }

        [DataMember(Name="pictCongaPeinkofer")]
        public BoundingBox PictCongaPeinkofer { get; set; }

        [DataMember(Name="pictCowBell")]
        public BoundingBox PictCowBell { get; set; }

        [DataMember(Name="pictCowBellBerio")]
        public BoundingBox PictCowBellBerio { get; set; }

        [DataMember(Name="pictCrashCymbals")]
        public BoundingBox PictCrashCymbals { get; set; }

        [DataMember(Name="pictCrotales")]
        public BoundingBox PictCrotales { get; set; }

        [DataMember(Name="pictCrushStem")]
        public BoundingBox PictCrushStem { get; set; }

        [DataMember(Name="pictCuica")]
        public BoundingBox PictCuica { get; set; }

        [DataMember(Name="pictCymbalTongs")]
        public BoundingBox PictCymbalTongs { get; set; }

        [DataMember(Name="pictDamp1")]
        public BoundingBox PictDamp1 { get; set; }

        [DataMember(Name="pictDamp2")]
        public BoundingBox PictDamp2 { get; set; }

        [DataMember(Name="pictDamp3")]
        public BoundingBox PictDamp3 { get; set; }

        [DataMember(Name="pictDamp4")]
        public BoundingBox PictDamp4 { get; set; }

        [DataMember(Name="pictDeadNoteStem")]
        public BoundingBox PictDeadNoteStem { get; set; }

        [DataMember(Name="pictDrumStick")]
        public BoundingBox PictDrumStick { get; set; }

        [DataMember(Name="pictDuckCall")]
        public BoundingBox PictDuckCall { get; set; }

        [DataMember(Name="pictEdgeOfCymbal")]
        public BoundingBox PictEdgeOfCymbal { get; set; }

        [DataMember(Name="pictEmptyTrap")]
        public BoundingBox PictEmptyTrap { get; set; }

        [DataMember(Name="pictFingerCymbals")]
        public BoundingBox PictFingerCymbals { get; set; }

        [DataMember(Name="pictFlexatone")]
        public BoundingBox PictFlexatone { get; set; }

        [DataMember(Name="pictFlexatonePeinkofer")]
        public BoundingBox PictFlexatonePeinkofer { get; set; }

        [DataMember(Name="pictFootballRatchet")]
        public BoundingBox PictFootballRatchet { get; set; }

        [DataMember(Name="pictGlassHarmonica")]
        public BoundingBox PictGlassHarmonica { get; set; }

        [DataMember(Name="pictGlassHarp")]
        public BoundingBox PictGlassHarp { get; set; }

        [DataMember(Name="pictGlassPlateChimes")]
        public BoundingBox PictGlassPlateChimes { get; set; }

        [DataMember(Name="pictGlassTubeChimes")]
        public BoundingBox PictGlassTubeChimes { get; set; }

        [DataMember(Name="pictGlsp")]
        public BoundingBox PictGlsp { get; set; }

        [DataMember(Name="pictGlspPeinkofer")]
        public BoundingBox PictGlspPeinkofer { get; set; }

        [DataMember(Name="pictGlspSmithBrindle")]
        public BoundingBox PictGlspSmithBrindle { get; set; }

        [DataMember(Name="pictGobletDrum")]
        public BoundingBox PictGobletDrum { get; set; }

        [DataMember(Name="pictGong")]
        public BoundingBox PictGong { get; set; }

        [DataMember(Name="pictGongWithButton")]
        public BoundingBox PictGongWithButton { get; set; }

        [DataMember(Name="pictGuiro")]
        public BoundingBox PictGuiro { get; set; }

        [DataMember(Name="pictGuiroPeinkofer")]
        public BoundingBox PictGuiroPeinkofer { get; set; }

        [DataMember(Name="pictGuiroSevsay")]
        public BoundingBox PictGuiroSevsay { get; set; }

        [DataMember(Name="pictGumHardDown")]
        public BoundingBox PictGumHardDown { get; set; }

        [DataMember(Name="pictGumHardLeft")]
        public BoundingBox PictGumHardLeft { get; set; }

        [DataMember(Name="pictGumHardRight")]
        public BoundingBox PictGumHardRight { get; set; }

        [DataMember(Name="pictGumHardUp")]
        public BoundingBox PictGumHardUp { get; set; }

        [DataMember(Name="pictGumMediumDown")]
        public BoundingBox PictGumMediumDown { get; set; }

        [DataMember(Name="pictGumMediumLeft")]
        public BoundingBox PictGumMediumLeft { get; set; }

        [DataMember(Name="pictGumMediumRight")]
        public BoundingBox PictGumMediumRight { get; set; }

        [DataMember(Name="pictGumMediumUp")]
        public BoundingBox PictGumMediumUp { get; set; }

        [DataMember(Name="pictGumSoftDown")]
        public BoundingBox PictGumSoftDown { get; set; }

        [DataMember(Name="pictGumSoftLeft")]
        public BoundingBox PictGumSoftLeft { get; set; }

        [DataMember(Name="pictGumSoftRight")]
        public BoundingBox PictGumSoftRight { get; set; }

        [DataMember(Name="pictGumSoftUp")]
        public BoundingBox PictGumSoftUp { get; set; }

        [DataMember(Name="pictHalfOpen1")]
        public BoundingBox PictHalfOpen1 { get; set; }

        [DataMember(Name="pictHalfOpen2")]
        public BoundingBox PictHalfOpen2 { get; set; }

        [DataMember(Name="pictHandbell")]
        public BoundingBox PictHandbell { get; set; }

        [DataMember(Name="pictHiHat")]
        public BoundingBox PictHiHat { get; set; }

        [DataMember(Name="pictHiHatOnStand")]
        public BoundingBox PictHiHatOnStand { get; set; }

        [DataMember(Name="pictJawHarp")]
        public Dictionary<string, long[]> PictJawHarp { get; set; }

        [DataMember(Name="pictJingleBells")]
        public BoundingBox PictJingleBells { get; set; }

        [DataMember(Name="pictKlaxonHorn")]
        public BoundingBox PictKlaxonHorn { get; set; }

        [DataMember(Name="pictLeftHandCircle")]
        public BoundingBox PictLeftHandCircle { get; set; }

        [DataMember(Name="pictLionsRoar")]
        public BoundingBox PictLionsRoar { get; set; }

        [DataMember(Name="pictLithophone")]
        public BoundingBox PictLithophone { get; set; }

        [DataMember(Name="pictLithophonePeinkofer")]
        public BoundingBox PictLithophonePeinkofer { get; set; }

        [DataMember(Name="pictLogDrum")]
        public BoundingBox PictLogDrum { get; set; }

        [DataMember(Name="pictLotusFlute")]
        public BoundingBox PictLotusFlute { get; set; }

        [DataMember(Name="pictLotusFlutePeinkofer")]
        public BoundingBox PictLotusFlutePeinkofer { get; set; }

        [DataMember(Name="pictMar")]
        public BoundingBox PictMar { get; set; }

        [DataMember(Name="pictMarPeinkofer")]
        public BoundingBox PictMarPeinkofer { get; set; }

        [DataMember(Name="pictMarSmithBrindle")]
        public BoundingBox PictMarSmithBrindle { get; set; }

        [DataMember(Name="pictMaraca")]
        public BoundingBox PictMaraca { get; set; }

        [DataMember(Name="pictMaracaSmithBrindle")]
        public BoundingBox PictMaracaSmithBrindle { get; set; }

        [DataMember(Name="pictMaracas")]
        public BoundingBox PictMaracas { get; set; }

        [DataMember(Name="pictMegaphone")]
        public BoundingBox PictMegaphone { get; set; }

        [DataMember(Name="pictMetalPlateChimes")]
        public BoundingBox PictMetalPlateChimes { get; set; }

        [DataMember(Name="pictMetalTubeChimes")]
        public BoundingBox PictMetalTubeChimes { get; set; }

        [DataMember(Name="pictMusicalSaw")]
        public BoundingBox PictMusicalSaw { get; set; }

        [DataMember(Name="pictMusicalSawPeinkofer")]
        public BoundingBox PictMusicalSawPeinkofer { get; set; }

        [DataMember(Name="pictNormalPosition")]
        public BoundingBox PictNormalPosition { get; set; }

        [DataMember(Name="pictOnRim")]
        public BoundingBox PictOnRim { get; set; }

        [DataMember(Name="pictOpen")]
        public BoundingBox PictOpen { get; set; }

        [DataMember(Name="pictOpenRimShot")]
        public BoundingBox PictOpenRimShot { get; set; }

        [DataMember(Name="pictPistolShot")]
        public BoundingBox PictPistolShot { get; set; }

        [DataMember(Name="pictPoliceWhistle")]
        public BoundingBox PictPoliceWhistle { get; set; }

        [DataMember(Name="pictQuijada")]
        public BoundingBox PictQuijada { get; set; }

        [DataMember(Name="pictRainstick")]
        public BoundingBox PictRainstick { get; set; }

        [DataMember(Name="pictRatchet")]
        public BoundingBox PictRatchet { get; set; }

        [DataMember(Name="pictRecoReco")]
        public BoundingBox PictRecoReco { get; set; }

        [DataMember(Name="pictRightHandSquare")]
        public BoundingBox PictRightHandSquare { get; set; }

        [DataMember(Name="pictRim1")]
        public BoundingBox PictRim1 { get; set; }

        [DataMember(Name="pictRim2")]
        public BoundingBox PictRim2 { get; set; }

        [DataMember(Name="pictRim3")]
        public BoundingBox PictRim3 { get; set; }

        [DataMember(Name="pictRimShotOnStem")]
        public BoundingBox PictRimShotOnStem { get; set; }

        [DataMember(Name="pictSandpaperBlocks")]
        public BoundingBox PictSandpaperBlocks { get; set; }

        [DataMember(Name="pictScrapeAroundRim")]
        public BoundingBox PictScrapeAroundRim { get; set; }

        [DataMember(Name="pictScrapeAroundRimClockwise")]
        public BoundingBox PictScrapeAroundRimClockwise { get; set; }

        [DataMember(Name="pictScrapeCenterToEdge")]
        public BoundingBox PictScrapeCenterToEdge { get; set; }

        [DataMember(Name="pictScrapeEdgeToCenter")]
        public BoundingBox PictScrapeEdgeToCenter { get; set; }

        [DataMember(Name="pictShellBells")]
        public Dictionary<string, long[]> PictShellBells { get; set; }

        [DataMember(Name="pictShellChimes")]
        public BoundingBox PictShellChimes { get; set; }

        [DataMember(Name="pictSiren")]
        public BoundingBox PictSiren { get; set; }

        [DataMember(Name="pictSistrum")]
        public BoundingBox PictSistrum { get; set; }

        [DataMember(Name="pictSizzleCymbal")]
        public BoundingBox PictSizzleCymbal { get; set; }

        [DataMember(Name="pictSleighBell")]
        public BoundingBox PictSleighBell { get; set; }

        [DataMember(Name="pictSleighBellSmithBrindle")]
        public BoundingBox PictSleighBellSmithBrindle { get; set; }

        [DataMember(Name="pictSlideBrushOnGong")]
        public BoundingBox PictSlideBrushOnGong { get; set; }

        [DataMember(Name="pictSlideWhistle")]
        public BoundingBox PictSlideWhistle { get; set; }

        [DataMember(Name="pictSlitDrum")]
        public BoundingBox PictSlitDrum { get; set; }

        [DataMember(Name="pictSnareDrum")]
        public BoundingBox PictSnareDrum { get; set; }

        [DataMember(Name="pictSnareDrumMilitary")]
        public BoundingBox PictSnareDrumMilitary { get; set; }

        [DataMember(Name="pictSnareDrumSnaresOff")]
        public BoundingBox PictSnareDrumSnaresOff { get; set; }

        [DataMember(Name="pictSteelDrums")]
        public BoundingBox PictSteelDrums { get; set; }

        [DataMember(Name="pictStickShot")]
        public BoundingBox PictStickShot { get; set; }

        [DataMember(Name="pictSuperball")]
        public BoundingBox PictSuperball { get; set; }

        [DataMember(Name="pictSuspendedCymbal")]
        public BoundingBox PictSuspendedCymbal { get; set; }

        [DataMember(Name="pictSwishStem")]
        public BoundingBox PictSwishStem { get; set; }

        [DataMember(Name="pictTabla")]
        public BoundingBox PictTabla { get; set; }

        [DataMember(Name="pictTamTam")]
        public BoundingBox PictTamTam { get; set; }

        [DataMember(Name="pictTamTamWithBeater")]
        public BoundingBox PictTamTamWithBeater { get; set; }

        [DataMember(Name="pictTambourine")]
        public BoundingBox PictTambourine { get; set; }

        [DataMember(Name="pictTambourineStockhausen")]
        public BoundingBox PictTambourineStockhausen { get; set; }

        [DataMember(Name="pictTempleBlocks")]
        public BoundingBox PictTempleBlocks { get; set; }

        [DataMember(Name="pictTenorDrum")]
        public BoundingBox PictTenorDrum { get; set; }

        [DataMember(Name="pictThundersheet")]
        public BoundingBox PictThundersheet { get; set; }

        [DataMember(Name="pictTimbales")]
        public BoundingBox PictTimbales { get; set; }

        [DataMember(Name="pictTimbalesPeinkofer")]
        public BoundingBox PictTimbalesPeinkofer { get; set; }

        [DataMember(Name="pictTimpani")]
        public BoundingBox PictTimpani { get; set; }

        [DataMember(Name="pictTimpaniPeinkofer")]
        public BoundingBox PictTimpaniPeinkofer { get; set; }

        [DataMember(Name="pictTomTom")]
        public BoundingBox PictTomTom { get; set; }

        [DataMember(Name="pictTomTomChinese")]
        public BoundingBox PictTomTomChinese { get; set; }

        [DataMember(Name="pictTomTomChinesePeinkofer")]
        public BoundingBox PictTomTomChinesePeinkofer { get; set; }

        [DataMember(Name="pictTomTomIndoAmerican")]
        public BoundingBox PictTomTomIndoAmerican { get; set; }

        [DataMember(Name="pictTomTomJapanese")]
        public BoundingBox PictTomTomJapanese { get; set; }

        [DataMember(Name="pictTomTomPeinkofer")]
        public BoundingBox PictTomTomPeinkofer { get; set; }

        [DataMember(Name="pictTriangle")]
        public BoundingBox PictTriangle { get; set; }

        [DataMember(Name="pictTubaphone")]
        public BoundingBox PictTubaphone { get; set; }

        [DataMember(Name="pictTubaphonePeinkofer")]
        public BoundingBox PictTubaphonePeinkofer { get; set; }

        [DataMember(Name="pictTubularBells")]
        public BoundingBox PictTubularBells { get; set; }

        [DataMember(Name="pictTurnLeftStem")]
        public BoundingBox PictTurnLeftStem { get; set; }

        [DataMember(Name="pictTurnRightLeftStem")]
        public BoundingBox PictTurnRightLeftStem { get; set; }

        [DataMember(Name="pictTurnRightStem")]
        public BoundingBox PictTurnRightStem { get; set; }

        [DataMember(Name="pictVib")]
        public BoundingBox PictVib { get; set; }

        [DataMember(Name="pictVibMotorOff")]
        public BoundingBox PictVibMotorOff { get; set; }

        [DataMember(Name="pictVibMotorOffPeinkofer")]
        public BoundingBox PictVibMotorOffPeinkofer { get; set; }

        [DataMember(Name="pictVibPeinkofer")]
        public BoundingBox PictVibPeinkofer { get; set; }

        [DataMember(Name="pictVibSmithBrindle")]
        public BoundingBox PictVibSmithBrindle { get; set; }

        [DataMember(Name="pictVibraslap")]
        public BoundingBox PictVibraslap { get; set; }

        [DataMember(Name="pictVietnameseHat")]
        public BoundingBox PictVietnameseHat { get; set; }

        [DataMember(Name="pictWhip")]
        public BoundingBox PictWhip { get; set; }

        [DataMember(Name="pictWindChimesGlass")]
        public BoundingBox PictWindChimesGlass { get; set; }

        [DataMember(Name="pictWindMachine")]
        public BoundingBox PictWindMachine { get; set; }

        [DataMember(Name="pictWindWhistle")]
        public BoundingBox PictWindWhistle { get; set; }

        [DataMember(Name="pictWoodBlock")]
        public BoundingBox PictWoodBlock { get; set; }

        [DataMember(Name="pictWoundHardDown")]
        public BoundingBox PictWoundHardDown { get; set; }

        [DataMember(Name="pictWoundHardLeft")]
        public BoundingBox PictWoundHardLeft { get; set; }

        [DataMember(Name="pictWoundHardRight")]
        public BoundingBox PictWoundHardRight { get; set; }

        [DataMember(Name="pictWoundHardUp")]
        public BoundingBox PictWoundHardUp { get; set; }

        [DataMember(Name="pictWoundSoftDown")]
        public BoundingBox PictWoundSoftDown { get; set; }

        [DataMember(Name="pictWoundSoftLeft")]
        public BoundingBox PictWoundSoftLeft { get; set; }

        [DataMember(Name="pictWoundSoftRight")]
        public BoundingBox PictWoundSoftRight { get; set; }

        [DataMember(Name="pictWoundSoftUp")]
        public BoundingBox PictWoundSoftUp { get; set; }

        [DataMember(Name="pictXyl")]
        public BoundingBox PictXyl { get; set; }

        [DataMember(Name="pictXylBass")]
        public BoundingBox PictXylBass { get; set; }

        [DataMember(Name="pictXylBassPeinkofer")]
        public BoundingBox PictXylBassPeinkofer { get; set; }

        [DataMember(Name="pictXylPeinkofer")]
        public BoundingBox PictXylPeinkofer { get; set; }

        [DataMember(Name="pictXylSmithBrindle")]
        public BoundingBox PictXylSmithBrindle { get; set; }

        [DataMember(Name="pictXylTenor")]
        public BoundingBox PictXylTenor { get; set; }

        [DataMember(Name="pictXylTenorPeinkofer")]
        public BoundingBox PictXylTenorPeinkofer { get; set; }

        [DataMember(Name="pictXylTenorTrough")]
        public BoundingBox PictXylTenorTrough { get; set; }

        [DataMember(Name="pictXylTrough")]
        public BoundingBox PictXylTrough { get; set; }

        [DataMember(Name="pluckedBuzzPizzicato")]
        public BoundingBox PluckedBuzzPizzicato { get; set; }

        [DataMember(Name="pluckedDamp")]
        public BoundingBox PluckedDamp { get; set; }

        [DataMember(Name="pluckedDampAll")]
        public BoundingBox PluckedDampAll { get; set; }

        [DataMember(Name="pluckedDampOnStem")]
        public BoundingBox PluckedDampOnStem { get; set; }

        [DataMember(Name="pluckedFingernailFlick")]
        public BoundingBox PluckedFingernailFlick { get; set; }

        [DataMember(Name="pluckedLeftHandPizzicato")]
        public BoundingBox PluckedLeftHandPizzicato { get; set; }

        [DataMember(Name="pluckedPlectrum")]
        public BoundingBox PluckedPlectrum { get; set; }

        [DataMember(Name="pluckedSnapPizzicatoAbove")]
        public BoundingBox PluckedSnapPizzicatoAbove { get; set; }

        [DataMember(Name="pluckedSnapPizzicatoAboveGerman")]
        public BoundingBox PluckedSnapPizzicatoAboveGerman { get; set; }

        [DataMember(Name="pluckedSnapPizzicatoBelow")]
        public BoundingBox PluckedSnapPizzicatoBelow { get; set; }

        [DataMember(Name="pluckedSnapPizzicatoBelowGerman")]
        public BoundingBox PluckedSnapPizzicatoBelowGerman { get; set; }

        [DataMember(Name="pluckedWithFingernails")]
        public BoundingBox PluckedWithFingernails { get; set; }

        [DataMember(Name="quindicesima")]
        public BoundingBox Quindicesima { get; set; }

        [DataMember(Name="quindicesimaAlta")]
        public BoundingBox QuindicesimaAlta { get; set; }

        [DataMember(Name="quindicesimaBassa")]
        public BoundingBox QuindicesimaBassa { get; set; }

        [DataMember(Name="quindicesimaBassaMb")]
        public BoundingBox QuindicesimaBassaMb { get; set; }

        [DataMember(Name="repeat1Bar")]
        public BoundingBox Repeat1Bar { get; set; }

        [DataMember(Name="repeat2Bars")]
        public BoundingBox Repeat2Bars { get; set; }

        [DataMember(Name="repeat4Bars")]
        public BoundingBox Repeat4Bars { get; set; }

        [DataMember(Name="repeatDot")]
        public BoundingBox RepeatDot { get; set; }

        [DataMember(Name="repeatDots")]
        public BoundingBox RepeatDots { get; set; }

        [DataMember(Name="repeatLeft")]
        public BoundingBox RepeatLeft { get; set; }

        [DataMember(Name="repeatRight")]
        public BoundingBox RepeatRight { get; set; }

        [DataMember(Name="repeatRightLeft")]
        public BoundingBox RepeatRightLeft { get; set; }

        [DataMember(Name="repeatRightLeftThick")]
        public BoundingBox RepeatRightLeftThick { get; set; }

        [DataMember(Name="rest1024th")]
        public BoundingBox Rest1024Th { get; set; }

        [DataMember(Name="rest128th")]
        public BoundingBox Rest128Th { get; set; }

        [DataMember(Name="rest16th")]
        public BoundingBox Rest16Th { get; set; }

        [DataMember(Name="rest256th")]
        public BoundingBox Rest256Th { get; set; }

        [DataMember(Name="rest32nd")]
        public BoundingBox Rest32Nd { get; set; }

        [DataMember(Name="rest512th")]
        public BoundingBox Rest512Th { get; set; }

        [DataMember(Name="rest64th")]
        public BoundingBox Rest64Th { get; set; }

        [DataMember(Name="rest8th")]
        public BoundingBox Rest8Th { get; set; }

        [DataMember(Name="restDoubleWhole")]
        public BoundingBox RestDoubleWhole { get; set; }

        [DataMember(Name="restDoubleWholeLegerLine")]
        public BoundingBox RestDoubleWholeLegerLine { get; set; }

        [DataMember(Name="restHBar")]
        public BoundingBox RestHBar { get; set; }

        [DataMember(Name="restHBarLeft")]
        public BoundingBox RestHBarLeft { get; set; }

        [DataMember(Name="restHBarMiddle")]
        public BoundingBox RestHBarMiddle { get; set; }

        [DataMember(Name="restHBarRight")]
        public BoundingBox RestHBarRight { get; set; }

        [DataMember(Name="restHalf")]
        public BoundingBox RestHalf { get; set; }

        [DataMember(Name="restHalfLegerLine")]
        public BoundingBox RestHalfLegerLine { get; set; }

        [DataMember(Name="restLonga")]
        public BoundingBox RestLonga { get; set; }

        [DataMember(Name="restMaxima")]
        public BoundingBox RestMaxima { get; set; }

        [DataMember(Name="restQuarter")]
        public BoundingBox RestQuarter { get; set; }

        [DataMember(Name="restQuarterOld")]
        public BoundingBox RestQuarterOld { get; set; }

        [DataMember(Name="restQuarterZ")]
        public BoundingBox RestQuarterZ { get; set; }

        [DataMember(Name="restWhole")]
        public BoundingBox RestWhole { get; set; }

        [DataMember(Name="restWholeLegerLine")]
        public BoundingBox RestWholeLegerLine { get; set; }

        [DataMember(Name="reversedBrace")]
        public BoundingBox ReversedBrace { get; set; }

        [DataMember(Name="reversedBracketBottom")]
        public BoundingBox ReversedBracketBottom { get; set; }

        [DataMember(Name="reversedBracketTop")]
        public BoundingBox ReversedBracketTop { get; set; }

        [DataMember(Name="rightRepeatSmall")]
        public BoundingBox RightRepeatSmall { get; set; }

        [DataMember(Name="schaefferClef")]
        public BoundingBox SchaefferClef { get; set; }

        [DataMember(Name="schaefferFClefToGClef")]
        public BoundingBox SchaefferFClefToGClef { get; set; }

        [DataMember(Name="schaefferGClefToFClef")]
        public BoundingBox SchaefferGClefToFClef { get; set; }

        [DataMember(Name="schaefferPreviousClef")]
        public BoundingBox SchaefferPreviousClef { get; set; }

        [DataMember(Name="sedicesima")]
        public BoundingBox Sedicesima { get; set; }

        [DataMember(Name="sedicesimaAlta")]
        public BoundingBox SedicesimaAlta { get; set; }

        [DataMember(Name="sedicesimaBassa")]
        public BoundingBox SedicesimaBassa { get; set; }

        [DataMember(Name="sedicesimaBassaMb")]
        public BoundingBox SedicesimaBassaMb { get; set; }

        [DataMember(Name="segno")]
        public BoundingBox Segno { get; set; }

        [DataMember(Name="segnoJapanese")]
        public BoundingBox SegnoJapanese { get; set; }

        [DataMember(Name="segnoSerpent1")]
        public BoundingBox SegnoSerpent1 { get; set; }

        [DataMember(Name="segnoSerpent2")]
        public BoundingBox SegnoSerpent2 { get; set; }

        [DataMember(Name="semipitchedPercussionClef1")]
        public BoundingBox SemipitchedPercussionClef1 { get; set; }

        [DataMember(Name="semipitchedPercussionClef2")]
        public BoundingBox SemipitchedPercussionClef2 { get; set; }

        [DataMember(Name="smnFlat")]
        public BoundingBox SmnFlat { get; set; }

        [DataMember(Name="smnFlatWhite")]
        public BoundingBox SmnFlatWhite { get; set; }

        [DataMember(Name="smnHistoryDoubleFlat")]
        public BoundingBox SmnHistoryDoubleFlat { get; set; }

        [DataMember(Name="smnHistoryDoubleSharp")]
        public BoundingBox SmnHistoryDoubleSharp { get; set; }

        [DataMember(Name="smnHistoryFlat")]
        public BoundingBox SmnHistoryFlat { get; set; }

        [DataMember(Name="smnHistorySharp")]
        public BoundingBox SmnHistorySharp { get; set; }

        [DataMember(Name="smnNatural")]
        public BoundingBox SmnNatural { get; set; }

        [DataMember(Name="smnSharp")]
        public BoundingBox SmnSharp { get; set; }

        [DataMember(Name="smnSharpDown")]
        public BoundingBox SmnSharpDown { get; set; }

        [DataMember(Name="smnSharpWhite")]
        public BoundingBox SmnSharpWhite { get; set; }

        [DataMember(Name="smnSharpWhiteDown")]
        public BoundingBox SmnSharpWhiteDown { get; set; }

        [DataMember(Name="splitBarDivider")]
        public BoundingBox SplitBarDivider { get; set; }

        [DataMember(Name="staff1Line")]
        public BoundingBox Staff1Line { get; set; }

        [DataMember(Name="staff1LineNarrow")]
        public BoundingBox Staff1LineNarrow { get; set; }

        [DataMember(Name="staff1LineWide")]
        public BoundingBox Staff1LineWide { get; set; }

        [DataMember(Name="staff2Lines")]
        public BoundingBox Staff2Lines { get; set; }

        [DataMember(Name="staff2LinesNarrow")]
        public BoundingBox Staff2LinesNarrow { get; set; }

        [DataMember(Name="staff2LinesWide")]
        public BoundingBox Staff2LinesWide { get; set; }

        [DataMember(Name="staff3Lines")]
        public BoundingBox Staff3Lines { get; set; }

        [DataMember(Name="staff3LinesNarrow")]
        public BoundingBox Staff3LinesNarrow { get; set; }

        [DataMember(Name="staff3LinesWide")]
        public BoundingBox Staff3LinesWide { get; set; }

        [DataMember(Name="staff4Lines")]
        public BoundingBox Staff4Lines { get; set; }

        [DataMember(Name="staff4LinesNarrow")]
        public BoundingBox Staff4LinesNarrow { get; set; }

        [DataMember(Name="staff4LinesWide")]
        public BoundingBox Staff4LinesWide { get; set; }

        [DataMember(Name="staff5Lines")]
        public BoundingBox Staff5Lines { get; set; }

        [DataMember(Name="staff5LinesNarrow")]
        public BoundingBox Staff5LinesNarrow { get; set; }

        [DataMember(Name="staff5LinesWide")]
        public BoundingBox Staff5LinesWide { get; set; }

        [DataMember(Name="staff6Lines")]
        public BoundingBox Staff6Lines { get; set; }

        [DataMember(Name="staff6LinesNarrow")]
        public BoundingBox Staff6LinesNarrow { get; set; }

        [DataMember(Name="staff6LinesWide")]
        public BoundingBox Staff6LinesWide { get; set; }

        [DataMember(Name="staffDivideArrowDown")]
        public BoundingBox StaffDivideArrowDown { get; set; }

        [DataMember(Name="staffDivideArrowUp")]
        public BoundingBox StaffDivideArrowUp { get; set; }

        [DataMember(Name="staffDivideArrowUpDown")]
        public BoundingBox StaffDivideArrowUpDown { get; set; }

        [DataMember(Name="stem")]
        public BoundingBox Stem { get; set; }

        [DataMember(Name="stemBowOnBridge")]
        public BoundingBox StemBowOnBridge { get; set; }

        [DataMember(Name="stemBowOnTailpiece")]
        public BoundingBox StemBowOnTailpiece { get; set; }

        [DataMember(Name="stemBuzzRoll")]
        public BoundingBox StemBuzzRoll { get; set; }

        [DataMember(Name="stemDamp")]
        public BoundingBox StemDamp { get; set; }

        [DataMember(Name="stemHarpStringNoise")]
        public BoundingBox StemHarpStringNoise { get; set; }

        [DataMember(Name="stemMultiphonicsBlack")]
        public BoundingBox StemMultiphonicsBlack { get; set; }

        [DataMember(Name="stemMultiphonicsBlackWhite")]
        public BoundingBox StemMultiphonicsBlackWhite { get; set; }

        [DataMember(Name="stemMultiphonicsWhite")]
        public BoundingBox StemMultiphonicsWhite { get; set; }

        [DataMember(Name="stemPendereckiTremolo")]
        public BoundingBox StemPendereckiTremolo { get; set; }

        [DataMember(Name="stemRimShot")]
        public BoundingBox StemRimShot { get; set; }

        [DataMember(Name="stemSprechgesang")]
        public BoundingBox StemSprechgesang { get; set; }

        [DataMember(Name="stemSulPonticello")]
        public BoundingBox StemSulPonticello { get; set; }

        [DataMember(Name="stemSussurando")]
        public BoundingBox StemSussurando { get; set; }

        [DataMember(Name="stemSwished")]
        public BoundingBox StemSwished { get; set; }

        [DataMember(Name="stemVibratoPulse")]
        public BoundingBox StemVibratoPulse { get; set; }

        [DataMember(Name="stockhausenTremolo")]
        public BoundingBox StockhausenTremolo { get; set; }

        [DataMember(Name="stringsBowBehindBridge")]
        public BoundingBox StringsBowBehindBridge { get; set; }

        [DataMember(Name="stringsBowBehindBridgeFourStrings")]
        public BoundingBox StringsBowBehindBridgeFourStrings { get; set; }

        [DataMember(Name="stringsBowBehindBridgeOneString")]
        public BoundingBox StringsBowBehindBridgeOneString { get; set; }

        [DataMember(Name="stringsBowBehindBridgeThreeStrings")]
        public BoundingBox StringsBowBehindBridgeThreeStrings { get; set; }

        [DataMember(Name="stringsBowBehindBridgeTwoStrings")]
        public BoundingBox StringsBowBehindBridgeTwoStrings { get; set; }

        [DataMember(Name="stringsBowOnBridge")]
        public BoundingBox StringsBowOnBridge { get; set; }

        [DataMember(Name="stringsBowOnTailpiece")]
        public BoundingBox StringsBowOnTailpiece { get; set; }

        [DataMember(Name="stringsChangeBowDirection")]
        public BoundingBox StringsChangeBowDirection { get; set; }

        [DataMember(Name="stringsChangeBowDirectionImposed")]
        public BoundingBox StringsChangeBowDirectionImposed { get; set; }

        [DataMember(Name="stringsChangeBowDirectionLiga")]
        public BoundingBox StringsChangeBowDirectionLiga { get; set; }

        [DataMember(Name="stringsDownBow")]
        public BoundingBox StringsDownBow { get; set; }

        [DataMember(Name="stringsDownBowTurned")]
        public BoundingBox StringsDownBowTurned { get; set; }

        [DataMember(Name="stringsFouette")]
        public BoundingBox StringsFouette { get; set; }

        [DataMember(Name="stringsHalfHarmonic")]
        public BoundingBox StringsHalfHarmonic { get; set; }

        [DataMember(Name="stringsHarmonic")]
        public BoundingBox StringsHarmonic { get; set; }

        [DataMember(Name="stringsJeteAbove")]
        public BoundingBox StringsJeteAbove { get; set; }

        [DataMember(Name="stringsJeteBelow")]
        public BoundingBox StringsJeteBelow { get; set; }

        [DataMember(Name="stringsMuteOff")]
        public BoundingBox StringsMuteOff { get; set; }

        [DataMember(Name="stringsMuteOn")]
        public BoundingBox StringsMuteOn { get; set; }

        [DataMember(Name="stringsOverpressureDownBow")]
        public BoundingBox StringsOverpressureDownBow { get; set; }

        [DataMember(Name="stringsOverpressureNoDirection")]
        public BoundingBox StringsOverpressureNoDirection { get; set; }

        [DataMember(Name="stringsOverpressurePossibileDownBow")]
        public BoundingBox StringsOverpressurePossibileDownBow { get; set; }

        [DataMember(Name="stringsOverpressurePossibileUpBow")]
        public BoundingBox StringsOverpressurePossibileUpBow { get; set; }

        [DataMember(Name="stringsOverpressureUpBow")]
        public BoundingBox StringsOverpressureUpBow { get; set; }

        [DataMember(Name="stringsThumbPosition")]
        public BoundingBox StringsThumbPosition { get; set; }

        [DataMember(Name="stringsThumbPositionTurned")]
        public BoundingBox StringsThumbPositionTurned { get; set; }

        [DataMember(Name="stringsUpBow")]
        public BoundingBox StringsUpBow { get; set; }

        [DataMember(Name="stringsUpBowTurned")]
        public BoundingBox StringsUpBowTurned { get; set; }

        [DataMember(Name="stringsVibratoPulse")]
        public BoundingBox StringsVibratoPulse { get; set; }

        [DataMember(Name="systemDivider")]
        public BoundingBox SystemDivider { get; set; }

        [DataMember(Name="systemDividerExtraLong")]
        public BoundingBox SystemDividerExtraLong { get; set; }

        [DataMember(Name="systemDividerLong")]
        public BoundingBox SystemDividerLong { get; set; }

        [DataMember(Name="textAugmentationDot")]
        public BoundingBox TextAugmentationDot { get; set; }

        [DataMember(Name="textBlackNoteFrac16thLongStem")]
        public BoundingBox TextBlackNoteFrac16ThLongStem { get; set; }

        [DataMember(Name="textBlackNoteFrac16thShortStem")]
        public BoundingBox TextBlackNoteFrac16ThShortStem { get; set; }

        [DataMember(Name="textBlackNoteFrac32ndLongStem")]
        public BoundingBox TextBlackNoteFrac32NdLongStem { get; set; }

        [DataMember(Name="textBlackNoteFrac8thLongStem")]
        public BoundingBox TextBlackNoteFrac8ThLongStem { get; set; }

        [DataMember(Name="textBlackNoteFrac8thShortStem")]
        public BoundingBox TextBlackNoteFrac8ThShortStem { get; set; }

        [DataMember(Name="textBlackNoteLongStem")]
        public BoundingBox TextBlackNoteLongStem { get; set; }

        [DataMember(Name="textBlackNoteShortStem")]
        public BoundingBox TextBlackNoteShortStem { get; set; }

        [DataMember(Name="textCont16thBeamLongStem")]
        public BoundingBox TextCont16ThBeamLongStem { get; set; }

        [DataMember(Name="textCont16thBeamShortStem")]
        public BoundingBox TextCont16ThBeamShortStem { get; set; }

        [DataMember(Name="textCont32ndBeamLongStem")]
        public BoundingBox TextCont32NdBeamLongStem { get; set; }

        [DataMember(Name="textCont8thBeamLongStem")]
        public BoundingBox TextCont8ThBeamLongStem { get; set; }

        [DataMember(Name="textCont8thBeamShortStem")]
        public BoundingBox TextCont8ThBeamShortStem { get; set; }

        [DataMember(Name="textTie")]
        public BoundingBox TextTie { get; set; }

        [DataMember(Name="textTuplet3LongStem")]
        public BoundingBox TextTuplet3LongStem { get; set; }

        [DataMember(Name="textTuplet3ShortStem")]
        public BoundingBox TextTuplet3ShortStem { get; set; }

        [DataMember(Name="textTupletBracketEndLongStem")]
        public BoundingBox TextTupletBracketEndLongStem { get; set; }

        [DataMember(Name="textTupletBracketEndShortStem")]
        public BoundingBox TextTupletBracketEndShortStem { get; set; }

        [DataMember(Name="textTupletBracketStartLongStem")]
        public BoundingBox TextTupletBracketStartLongStem { get; set; }

        [DataMember(Name="textTupletBracketStartShortStem")]
        public BoundingBox TextTupletBracketStartShortStem { get; set; }

        [DataMember(Name="timeSig0")]
        public BoundingBox TimeSig0 { get; set; }

        [DataMember(Name="timeSig0Denominator")]
        public BoundingBox TimeSig0Denominator { get; set; }

        [DataMember(Name="timeSig0Large")]
        public BoundingBox TimeSig0Large { get; set; }

        [DataMember(Name="timeSig0Numerator")]
        public BoundingBox TimeSig0Numerator { get; set; }

        [DataMember(Name="timeSig0Reversed")]
        public BoundingBox TimeSig0Reversed { get; set; }

        [DataMember(Name="timeSig0Small")]
        public BoundingBox TimeSig0Small { get; set; }

        [DataMember(Name="timeSig0Turned")]
        public BoundingBox TimeSig0Turned { get; set; }

        [DataMember(Name="timeSig1")]
        public BoundingBox TimeSig1 { get; set; }

        [DataMember(Name="timeSig12over8")]
        public BoundingBox TimeSig12Over8 { get; set; }

        [DataMember(Name="timeSig1Denominator")]
        public BoundingBox TimeSig1Denominator { get; set; }

        [DataMember(Name="timeSig1Large")]
        public BoundingBox TimeSig1Large { get; set; }

        [DataMember(Name="timeSig1Numerator")]
        public BoundingBox TimeSig1Numerator { get; set; }

        [DataMember(Name="timeSig1Reversed")]
        public BoundingBox TimeSig1Reversed { get; set; }

        [DataMember(Name="timeSig1Small")]
        public BoundingBox TimeSig1Small { get; set; }

        [DataMember(Name="timeSig1Turned")]
        public BoundingBox TimeSig1Turned { get; set; }

        [DataMember(Name="timeSig2")]
        public BoundingBox TimeSig2 { get; set; }

        [DataMember(Name="timeSig2Denominator")]
        public BoundingBox TimeSig2Denominator { get; set; }

        [DataMember(Name="timeSig2Large")]
        public BoundingBox TimeSig2Large { get; set; }

        [DataMember(Name="timeSig2Numerator")]
        public BoundingBox TimeSig2Numerator { get; set; }

        [DataMember(Name="timeSig2Reversed")]
        public BoundingBox TimeSig2Reversed { get; set; }

        [DataMember(Name="timeSig2Small")]
        public BoundingBox TimeSig2Small { get; set; }

        [DataMember(Name="timeSig2Turned")]
        public BoundingBox TimeSig2Turned { get; set; }

        [DataMember(Name="timeSig2over2")]
        public BoundingBox TimeSig2Over2 { get; set; }

        [DataMember(Name="timeSig2over4")]
        public BoundingBox TimeSig2Over4 { get; set; }

        [DataMember(Name="timeSig3")]
        public BoundingBox TimeSig3 { get; set; }

        [DataMember(Name="timeSig3Denominator")]
        public BoundingBox TimeSig3Denominator { get; set; }

        [DataMember(Name="timeSig3Large")]
        public BoundingBox TimeSig3Large { get; set; }

        [DataMember(Name="timeSig3Numerator")]
        public BoundingBox TimeSig3Numerator { get; set; }

        [DataMember(Name="timeSig3Reversed")]
        public BoundingBox TimeSig3Reversed { get; set; }

        [DataMember(Name="timeSig3Small")]
        public BoundingBox TimeSig3Small { get; set; }

        [DataMember(Name="timeSig3Turned")]
        public BoundingBox TimeSig3Turned { get; set; }

        [DataMember(Name="timeSig3over2")]
        public BoundingBox TimeSig3Over2 { get; set; }

        [DataMember(Name="timeSig3over4")]
        public BoundingBox TimeSig3Over4 { get; set; }

        [DataMember(Name="timeSig3over8")]
        public BoundingBox TimeSig3Over8 { get; set; }

        [DataMember(Name="timeSig4")]
        public BoundingBox TimeSig4 { get; set; }

        [DataMember(Name="timeSig4Denominator")]
        public BoundingBox TimeSig4Denominator { get; set; }

        [DataMember(Name="timeSig4Large")]
        public BoundingBox TimeSig4Large { get; set; }

        [DataMember(Name="timeSig4Numerator")]
        public BoundingBox TimeSig4Numerator { get; set; }

        [DataMember(Name="timeSig4Reversed")]
        public BoundingBox TimeSig4Reversed { get; set; }

        [DataMember(Name="timeSig4Small")]
        public BoundingBox TimeSig4Small { get; set; }

        [DataMember(Name="timeSig4Turned")]
        public BoundingBox TimeSig4Turned { get; set; }

        [DataMember(Name="timeSig4over4")]
        public BoundingBox TimeSig4Over4 { get; set; }

        [DataMember(Name="timeSig5")]
        public BoundingBox TimeSig5 { get; set; }

        [DataMember(Name="timeSig5Denominator")]
        public BoundingBox TimeSig5Denominator { get; set; }

        [DataMember(Name="timeSig5Large")]
        public BoundingBox TimeSig5Large { get; set; }

        [DataMember(Name="timeSig5Numerator")]
        public BoundingBox TimeSig5Numerator { get; set; }

        [DataMember(Name="timeSig5Reversed")]
        public BoundingBox TimeSig5Reversed { get; set; }

        [DataMember(Name="timeSig5Small")]
        public BoundingBox TimeSig5Small { get; set; }

        [DataMember(Name="timeSig5Turned")]
        public BoundingBox TimeSig5Turned { get; set; }

        [DataMember(Name="timeSig5over4")]
        public BoundingBox TimeSig5Over4 { get; set; }

        [DataMember(Name="timeSig5over8")]
        public BoundingBox TimeSig5Over8 { get; set; }

        [DataMember(Name="timeSig6")]
        public BoundingBox TimeSig6 { get; set; }

        [DataMember(Name="timeSig6Denominator")]
        public BoundingBox TimeSig6Denominator { get; set; }

        [DataMember(Name="timeSig6Large")]
        public BoundingBox TimeSig6Large { get; set; }

        [DataMember(Name="timeSig6Numerator")]
        public BoundingBox TimeSig6Numerator { get; set; }

        [DataMember(Name="timeSig6Reversed")]
        public BoundingBox TimeSig6Reversed { get; set; }

        [DataMember(Name="timeSig6Small")]
        public BoundingBox TimeSig6Small { get; set; }

        [DataMember(Name="timeSig6Turned")]
        public BoundingBox TimeSig6Turned { get; set; }

        [DataMember(Name="timeSig6over4")]
        public BoundingBox TimeSig6Over4 { get; set; }

        [DataMember(Name="timeSig6over8")]
        public BoundingBox TimeSig6Over8 { get; set; }

        [DataMember(Name="timeSig7")]
        public BoundingBox TimeSig7 { get; set; }

        [DataMember(Name="timeSig7Denominator")]
        public BoundingBox TimeSig7Denominator { get; set; }

        [DataMember(Name="timeSig7Large")]
        public BoundingBox TimeSig7Large { get; set; }

        [DataMember(Name="timeSig7Numerator")]
        public BoundingBox TimeSig7Numerator { get; set; }

        [DataMember(Name="timeSig7Reversed")]
        public BoundingBox TimeSig7Reversed { get; set; }

        [DataMember(Name="timeSig7Small")]
        public BoundingBox TimeSig7Small { get; set; }

        [DataMember(Name="timeSig7Turned")]
        public BoundingBox TimeSig7Turned { get; set; }

        [DataMember(Name="timeSig7over8")]
        public BoundingBox TimeSig7Over8 { get; set; }

        [DataMember(Name="timeSig8")]
        public BoundingBox TimeSig8 { get; set; }

        [DataMember(Name="timeSig8Denominator")]
        public BoundingBox TimeSig8Denominator { get; set; }

        [DataMember(Name="timeSig8Large")]
        public BoundingBox TimeSig8Large { get; set; }

        [DataMember(Name="timeSig8Numerator")]
        public BoundingBox TimeSig8Numerator { get; set; }

        [DataMember(Name="timeSig8Reversed")]
        public BoundingBox TimeSig8Reversed { get; set; }

        [DataMember(Name="timeSig8Small")]
        public BoundingBox TimeSig8Small { get; set; }

        [DataMember(Name="timeSig8Turned")]
        public BoundingBox TimeSig8Turned { get; set; }

        [DataMember(Name="timeSig9")]
        public BoundingBox TimeSig9 { get; set; }

        [DataMember(Name="timeSig9Large")]
        public BoundingBox TimeSig9Large { get; set; }

        [DataMember(Name="timeSig9Reversed")]
        public BoundingBox TimeSig9Reversed { get; set; }

        [DataMember(Name="timeSig9Small")]
        public BoundingBox TimeSig9Small { get; set; }

        [DataMember(Name="timeSig9Turned")]
        public BoundingBox TimeSig9Turned { get; set; }

        [DataMember(Name="timeSig9over8")]
        public BoundingBox TimeSig9Over8 { get; set; }

        [DataMember(Name="timeSigBracketLeft")]
        public BoundingBox TimeSigBracketLeft { get; set; }

        [DataMember(Name="timeSigBracketLeftSmall")]
        public BoundingBox TimeSigBracketLeftSmall { get; set; }

        [DataMember(Name="timeSigBracketRight")]
        public BoundingBox TimeSigBracketRight { get; set; }

        [DataMember(Name="timeSigBracketRightSmall")]
        public BoundingBox TimeSigBracketRightSmall { get; set; }

        [DataMember(Name="timeSigComma")]
        public BoundingBox TimeSigComma { get; set; }

        [DataMember(Name="timeSigCommon")]
        public BoundingBox TimeSigCommon { get; set; }

        [DataMember(Name="timeSigCommonLarge")]
        public BoundingBox TimeSigCommonLarge { get; set; }

        [DataMember(Name="timeSigCommonReversed")]
        public BoundingBox TimeSigCommonReversed { get; set; }

        [DataMember(Name="timeSigCommonTurned")]
        public BoundingBox TimeSigCommonTurned { get; set; }

        [DataMember(Name="timeSigCut2")]
        public BoundingBox TimeSigCut2 { get; set; }

        [DataMember(Name="timeSigCut3")]
        public BoundingBox TimeSigCut3 { get; set; }

        [DataMember(Name="timeSigCutCommon")]
        public BoundingBox TimeSigCutCommon { get; set; }

        [DataMember(Name="timeSigCutCommonLarge")]
        public BoundingBox TimeSigCutCommonLarge { get; set; }

        [DataMember(Name="timeSigCutCommonReversed")]
        public BoundingBox TimeSigCutCommonReversed { get; set; }

        [DataMember(Name="timeSigCutCommonTurned")]
        public BoundingBox TimeSigCutCommonTurned { get; set; }

        [DataMember(Name="timeSigEquals")]
        public BoundingBox TimeSigEquals { get; set; }

        [DataMember(Name="timeSigFractionHalf")]
        public BoundingBox TimeSigFractionHalf { get; set; }

        [DataMember(Name="timeSigFractionOneThird")]
        public BoundingBox TimeSigFractionOneThird { get; set; }

        [DataMember(Name="timeSigFractionQuarter")]
        public BoundingBox TimeSigFractionQuarter { get; set; }

        [DataMember(Name="timeSigFractionThreeQuarters")]
        public BoundingBox TimeSigFractionThreeQuarters { get; set; }

        [DataMember(Name="timeSigFractionTwoThirds")]
        public BoundingBox TimeSigFractionTwoThirds { get; set; }

        [DataMember(Name="timeSigFractionalSlash")]
        public BoundingBox TimeSigFractionalSlash { get; set; }

        [DataMember(Name="timeSigMinus")]
        public BoundingBox TimeSigMinus { get; set; }

        [DataMember(Name="timeSigMultiply")]
        public BoundingBox TimeSigMultiply { get; set; }

        [DataMember(Name="timeSigOpenPenderecki")]
        public BoundingBox TimeSigOpenPenderecki { get; set; }

        [DataMember(Name="timeSigParensLeft")]
        public BoundingBox TimeSigParensLeft { get; set; }

        [DataMember(Name="timeSigParensLeftSmall")]
        public BoundingBox TimeSigParensLeftSmall { get; set; }

        [DataMember(Name="timeSigParensRight")]
        public BoundingBox TimeSigParensRight { get; set; }

        [DataMember(Name="timeSigParensRightSmall")]
        public BoundingBox TimeSigParensRightSmall { get; set; }

        [DataMember(Name="timeSigPlus")]
        public BoundingBox TimeSigPlus { get; set; }

        [DataMember(Name="timeSigPlusLarge")]
        public BoundingBox TimeSigPlusLarge { get; set; }

        [DataMember(Name="timeSigPlusSmall")]
        public BoundingBox TimeSigPlusSmall { get; set; }

        [DataMember(Name="timeSigSlash")]
        public BoundingBox TimeSigSlash { get; set; }

        [DataMember(Name="timeSigX")]
        public BoundingBox TimeSigX { get; set; }

        [DataMember(Name="tremolo1")]
        public BoundingBox Tremolo1 { get; set; }

        [DataMember(Name="tremolo2")]
        public BoundingBox Tremolo2 { get; set; }

        [DataMember(Name="tremolo3")]
        public BoundingBox Tremolo3 { get; set; }

        [DataMember(Name="tremolo4")]
        public BoundingBox Tremolo4 { get; set; }

        [DataMember(Name="tremolo5")]
        public BoundingBox Tremolo5 { get; set; }

        [DataMember(Name="tremoloDivisiDots2")]
        public BoundingBox TremoloDivisiDots2 { get; set; }

        [DataMember(Name="tremoloDivisiDots3")]
        public BoundingBox TremoloDivisiDots3 { get; set; }

        [DataMember(Name="tremoloDivisiDots4")]
        public BoundingBox TremoloDivisiDots4 { get; set; }

        [DataMember(Name="tremoloDivisiDots6")]
        public BoundingBox TremoloDivisiDots6 { get; set; }

        [DataMember(Name="tremoloFingered1")]
        public BoundingBox TremoloFingered1 { get; set; }

        [DataMember(Name="tremoloFingered2")]
        public BoundingBox TremoloFingered2 { get; set; }

        [DataMember(Name="tremoloFingered3")]
        public BoundingBox TremoloFingered3 { get; set; }

        [DataMember(Name="tremoloFingered4")]
        public BoundingBox TremoloFingered4 { get; set; }

        [DataMember(Name="tremoloFingered5")]
        public BoundingBox TremoloFingered5 { get; set; }

        [DataMember(Name="tripleTongueAbove")]
        public BoundingBox TripleTongueAbove { get; set; }

        [DataMember(Name="tripleTongueAboveNoSlur")]
        public BoundingBox TripleTongueAboveNoSlur { get; set; }

        [DataMember(Name="tripleTongueBelow")]
        public BoundingBox TripleTongueBelow { get; set; }

        [DataMember(Name="tripleTongueBelowNoSlur")]
        public BoundingBox TripleTongueBelowNoSlur { get; set; }

        [DataMember(Name="tuplet0")]
        public BoundingBox Tuplet0 { get; set; }

        [DataMember(Name="tuplet1")]
        public BoundingBox Tuplet1 { get; set; }

        [DataMember(Name="tuplet2")]
        public BoundingBox Tuplet2 { get; set; }

        [DataMember(Name="tuplet3")]
        public BoundingBox Tuplet3 { get; set; }

        [DataMember(Name="tuplet4")]
        public BoundingBox Tuplet4 { get; set; }

        [DataMember(Name="tuplet5")]
        public BoundingBox Tuplet5 { get; set; }

        [DataMember(Name="tuplet6")]
        public BoundingBox Tuplet6 { get; set; }

        [DataMember(Name="tuplet7")]
        public BoundingBox Tuplet7 { get; set; }

        [DataMember(Name="tuplet8")]
        public BoundingBox Tuplet8 { get; set; }

        [DataMember(Name="tuplet9")]
        public BoundingBox Tuplet9 { get; set; }

        [DataMember(Name="tupletColon")]
        public BoundingBox TupletColon { get; set; }

        [DataMember(Name="unmeasuredTremolo")]
        public BoundingBox UnmeasuredTremolo { get; set; }

        [DataMember(Name="unmeasuredTremoloSimple")]
        public BoundingBox UnmeasuredTremoloSimple { get; set; }

        [DataMember(Name="unpitchedPercussionClef1")]
        public BoundingBox UnpitchedPercussionClef1 { get; set; }

        [DataMember(Name="unpitchedPercussionClef1Alt")]
        public BoundingBox UnpitchedPercussionClef1Alt { get; set; }

        [DataMember(Name="unpitchedPercussionClef2")]
        public BoundingBox UnpitchedPercussionClef2 { get; set; }

        [DataMember(Name="ventiduesima")]
        public BoundingBox Ventiduesima { get; set; }

        [DataMember(Name="ventiduesimaAlta")]
        public BoundingBox VentiduesimaAlta { get; set; }

        [DataMember(Name="ventiduesimaBassa")]
        public BoundingBox VentiduesimaBassa { get; set; }

        [DataMember(Name="ventiduesimaBassaMb")]
        public BoundingBox VentiduesimaBassaMb { get; set; }

        [DataMember(Name="ventiquattresima")]
        public BoundingBox Ventiquattresima { get; set; }

        [DataMember(Name="ventiquattresimaAlta")]
        public BoundingBox VentiquattresimaAlta { get; set; }

        [DataMember(Name="ventiquattresimaBassa")]
        public BoundingBox VentiquattresimaBassa { get; set; }

        [DataMember(Name="ventiquattresimaBassaMb")]
        public BoundingBox VentiquattresimaBassaMb { get; set; }

        [DataMember(Name="vocalFingerClickStockhausen")]
        public BoundingBox VocalFingerClickStockhausen { get; set; }

        [DataMember(Name="vocalMouthClosed")]
        public BoundingBox VocalMouthClosed { get; set; }

        [DataMember(Name="vocalMouthOpen")]
        public BoundingBox VocalMouthOpen { get; set; }

        [DataMember(Name="vocalMouthPursed")]
        public BoundingBox VocalMouthPursed { get; set; }

        [DataMember(Name="vocalMouthSlightlyOpen")]
        public BoundingBox VocalMouthSlightlyOpen { get; set; }

        [DataMember(Name="vocalMouthWideOpen")]
        public BoundingBox VocalMouthWideOpen { get; set; }

        [DataMember(Name="vocalNasalVoice")]
        public BoundingBox VocalNasalVoice { get; set; }

        [DataMember(Name="vocalSprechgesang")]
        public BoundingBox VocalSprechgesang { get; set; }

        [DataMember(Name="vocalTongueClickStockhausen")]
        public BoundingBox VocalTongueClickStockhausen { get; set; }

        [DataMember(Name="vocalTongueFingerClickStockhausen")]
        public BoundingBox VocalTongueFingerClickStockhausen { get; set; }

        [DataMember(Name="vocalsSussurando")]
        public BoundingBox VocalsSussurando { get; set; }

        [DataMember(Name="wiggleArpeggiatoDown")]
        public BoundingBox WiggleArpeggiatoDown { get; set; }

        [DataMember(Name="wiggleArpeggiatoDownArrow")]
        public BoundingBox WiggleArpeggiatoDownArrow { get; set; }

        [DataMember(Name="wiggleArpeggiatoDownSwash")]
        public BoundingBox WiggleArpeggiatoDownSwash { get; set; }

        [DataMember(Name="wiggleArpeggiatoDownSwashCouperin")]
        public BoundingBox WiggleArpeggiatoDownSwashCouperin { get; set; }

        [DataMember(Name="wiggleArpeggiatoUp")]
        public BoundingBox WiggleArpeggiatoUp { get; set; }

        [DataMember(Name="wiggleArpeggiatoUpArrow")]
        public BoundingBox WiggleArpeggiatoUpArrow { get; set; }

        [DataMember(Name="wiggleArpeggiatoUpSwash")]
        public BoundingBox WiggleArpeggiatoUpSwash { get; set; }

        [DataMember(Name="wiggleArpeggiatoUpSwashCouperin")]
        public BoundingBox WiggleArpeggiatoUpSwashCouperin { get; set; }

        [DataMember(Name="wiggleCircular")]
        public BoundingBox WiggleCircular { get; set; }

        [DataMember(Name="wiggleCircularConstant")]
        public BoundingBox WiggleCircularConstant { get; set; }

        [DataMember(Name="wiggleCircularConstantFlipped")]
        public BoundingBox WiggleCircularConstantFlipped { get; set; }

        [DataMember(Name="wiggleCircularConstantFlippedLarge")]
        public BoundingBox WiggleCircularConstantFlippedLarge { get; set; }

        [DataMember(Name="wiggleCircularConstantLarge")]
        public BoundingBox WiggleCircularConstantLarge { get; set; }

        [DataMember(Name="wiggleCircularEnd")]
        public BoundingBox WiggleCircularEnd { get; set; }

        [DataMember(Name="wiggleCircularLarge")]
        public BoundingBox WiggleCircularLarge { get; set; }

        [DataMember(Name="wiggleCircularLarger")]
        public BoundingBox WiggleCircularLarger { get; set; }

        [DataMember(Name="wiggleCircularLargerStill")]
        public BoundingBox WiggleCircularLargerStill { get; set; }

        [DataMember(Name="wiggleCircularLargest")]
        public BoundingBox WiggleCircularLargest { get; set; }

        [DataMember(Name="wiggleCircularSmall")]
        public BoundingBox WiggleCircularSmall { get; set; }

        [DataMember(Name="wiggleCircularStart")]
        public BoundingBox WiggleCircularStart { get; set; }

        [DataMember(Name="wiggleGlissando")]
        public BoundingBox WiggleGlissando { get; set; }

        [DataMember(Name="wiggleGlissandoGroup1")]
        public BoundingBox WiggleGlissandoGroup1 { get; set; }

        [DataMember(Name="wiggleGlissandoGroup2")]
        public BoundingBox WiggleGlissandoGroup2 { get; set; }

        [DataMember(Name="wiggleGlissandoGroup3")]
        public BoundingBox WiggleGlissandoGroup3 { get; set; }

        [DataMember(Name="wiggleRandom1")]
        public BoundingBox WiggleRandom1 { get; set; }

        [DataMember(Name="wiggleRandom2")]
        public BoundingBox WiggleRandom2 { get; set; }

        [DataMember(Name="wiggleRandom3")]
        public BoundingBox WiggleRandom3 { get; set; }

        [DataMember(Name="wiggleRandom4")]
        public BoundingBox WiggleRandom4 { get; set; }

        [DataMember(Name="wiggleSawtooth")]
        public BoundingBox WiggleSawtooth { get; set; }

        [DataMember(Name="wiggleSawtoothNarrow")]
        public BoundingBox WiggleSawtoothNarrow { get; set; }

        [DataMember(Name="wiggleSawtoothWide")]
        public BoundingBox WiggleSawtoothWide { get; set; }

        [DataMember(Name="wiggleSquareWave")]
        public BoundingBox WiggleSquareWave { get; set; }

        [DataMember(Name="wiggleSquareWaveNarrow")]
        public BoundingBox WiggleSquareWaveNarrow { get; set; }

        [DataMember(Name="wiggleSquareWaveWide")]
        public BoundingBox WiggleSquareWaveWide { get; set; }

        [DataMember(Name="wiggleTrill")]
        public BoundingBox WiggleTrill { get; set; }

        [DataMember(Name="wiggleTrillFast")]
        public BoundingBox WiggleTrillFast { get; set; }

        [DataMember(Name="wiggleTrillFaster")]
        public BoundingBox WiggleTrillFaster { get; set; }

        [DataMember(Name="wiggleTrillFasterStill")]
        public BoundingBox WiggleTrillFasterStill { get; set; }

        [DataMember(Name="wiggleTrillFastest")]
        public BoundingBox WiggleTrillFastest { get; set; }

        [DataMember(Name="wiggleTrillSlow")]
        public BoundingBox WiggleTrillSlow { get; set; }

        [DataMember(Name="wiggleTrillSlower")]
        public BoundingBox WiggleTrillSlower { get; set; }

        [DataMember(Name="wiggleTrillSlowerStill")]
        public BoundingBox WiggleTrillSlowerStill { get; set; }

        [DataMember(Name="wiggleTrillSlowest")]
        public BoundingBox WiggleTrillSlowest { get; set; }

        [DataMember(Name="wiggleVIbratoLargestSlower")]
        public BoundingBox WiggleVIbratoLargestSlower { get; set; }

        [DataMember(Name="wiggleVIbratoMediumSlower")]
        public BoundingBox WiggleVIbratoMediumSlower { get; set; }

        [DataMember(Name="wiggleVibrato")]
        public BoundingBox WiggleVibrato { get; set; }

        [DataMember(Name="wiggleVibratoLargeFast")]
        public BoundingBox WiggleVibratoLargeFast { get; set; }

        [DataMember(Name="wiggleVibratoLargeFaster")]
        public BoundingBox WiggleVibratoLargeFaster { get; set; }

        [DataMember(Name="wiggleVibratoLargeFasterStill")]
        public BoundingBox WiggleVibratoLargeFasterStill { get; set; }

        [DataMember(Name="wiggleVibratoLargeFastest")]
        public BoundingBox WiggleVibratoLargeFastest { get; set; }

        [DataMember(Name="wiggleVibratoLargeSlow")]
        public BoundingBox WiggleVibratoLargeSlow { get; set; }

        [DataMember(Name="wiggleVibratoLargeSlower")]
        public BoundingBox WiggleVibratoLargeSlower { get; set; }

        [DataMember(Name="wiggleVibratoLargeSlowest")]
        public BoundingBox WiggleVibratoLargeSlowest { get; set; }

        [DataMember(Name="wiggleVibratoLargestFast")]
        public BoundingBox WiggleVibratoLargestFast { get; set; }

        [DataMember(Name="wiggleVibratoLargestFaster")]
        public BoundingBox WiggleVibratoLargestFaster { get; set; }

        [DataMember(Name="wiggleVibratoLargestFasterStill")]
        public BoundingBox WiggleVibratoLargestFasterStill { get; set; }

        [DataMember(Name="wiggleVibratoLargestFastest")]
        public BoundingBox WiggleVibratoLargestFastest { get; set; }

        [DataMember(Name="wiggleVibratoLargestSlow")]
        public BoundingBox WiggleVibratoLargestSlow { get; set; }

        [DataMember(Name="wiggleVibratoLargestSlowest")]
        public BoundingBox WiggleVibratoLargestSlowest { get; set; }

        [DataMember(Name="wiggleVibratoMediumFast")]
        public BoundingBox WiggleVibratoMediumFast { get; set; }

        [DataMember(Name="wiggleVibratoMediumFaster")]
        public BoundingBox WiggleVibratoMediumFaster { get; set; }

        [DataMember(Name="wiggleVibratoMediumFasterStill")]
        public BoundingBox WiggleVibratoMediumFasterStill { get; set; }

        [DataMember(Name="wiggleVibratoMediumFastest")]
        public BoundingBox WiggleVibratoMediumFastest { get; set; }

        [DataMember(Name="wiggleVibratoMediumSlow")]
        public BoundingBox WiggleVibratoMediumSlow { get; set; }

        [DataMember(Name="wiggleVibratoMediumSlowest")]
        public BoundingBox WiggleVibratoMediumSlowest { get; set; }

        [DataMember(Name="wiggleVibratoSmallFast")]
        public BoundingBox WiggleVibratoSmallFast { get; set; }

        [DataMember(Name="wiggleVibratoSmallFaster")]
        public BoundingBox WiggleVibratoSmallFaster { get; set; }

        [DataMember(Name="wiggleVibratoSmallFasterStill")]
        public BoundingBox WiggleVibratoSmallFasterStill { get; set; }

        [DataMember(Name="wiggleVibratoSmallFastest")]
        public BoundingBox WiggleVibratoSmallFastest { get; set; }

        [DataMember(Name="wiggleVibratoSmallSlow")]
        public BoundingBox WiggleVibratoSmallSlow { get; set; }

        [DataMember(Name="wiggleVibratoSmallSlower")]
        public BoundingBox WiggleVibratoSmallSlower { get; set; }

        [DataMember(Name="wiggleVibratoSmallSlowest")]
        public BoundingBox WiggleVibratoSmallSlowest { get; set; }

        [DataMember(Name="wiggleVibratoSmallestFast")]
        public BoundingBox WiggleVibratoSmallestFast { get; set; }

        [DataMember(Name="wiggleVibratoSmallestFaster")]
        public BoundingBox WiggleVibratoSmallestFaster { get; set; }

        [DataMember(Name="wiggleVibratoSmallestFasterStill")]
        public BoundingBox WiggleVibratoSmallestFasterStill { get; set; }

        [DataMember(Name="wiggleVibratoSmallestFastest")]
        public BoundingBox WiggleVibratoSmallestFastest { get; set; }

        [DataMember(Name="wiggleVibratoSmallestSlow")]
        public BoundingBox WiggleVibratoSmallestSlow { get; set; }

        [DataMember(Name="wiggleVibratoSmallestSlower")]
        public BoundingBox WiggleVibratoSmallestSlower { get; set; }

        [DataMember(Name="wiggleVibratoSmallestSlowest")]
        public BoundingBox WiggleVibratoSmallestSlowest { get; set; }

        [DataMember(Name="wiggleVibratoStart")]
        public BoundingBox WiggleVibratoStart { get; set; }

        [DataMember(Name="wiggleVibratoWide")]
        public BoundingBox WiggleVibratoWide { get; set; }

        [DataMember(Name="wiggleWavy")]
        public BoundingBox WiggleWavy { get; set; }

        [DataMember(Name="wiggleWavyNarrow")]
        public BoundingBox WiggleWavyNarrow { get; set; }

        [DataMember(Name="wiggleWavyWide")]
        public BoundingBox WiggleWavyWide { get; set; }

        [DataMember(Name="windClosedHole")]
        public BoundingBox WindClosedHole { get; set; }

        [DataMember(Name="windFlatEmbouchure")]
        public BoundingBox WindFlatEmbouchure { get; set; }

        [DataMember(Name="windHalfClosedHole1")]
        public BoundingBox WindHalfClosedHole1 { get; set; }

        [DataMember(Name="windHalfClosedHole2")]
        public BoundingBox WindHalfClosedHole2 { get; set; }

        [DataMember(Name="windHalfClosedHole3")]
        public BoundingBox WindHalfClosedHole3 { get; set; }

        [DataMember(Name="windLessRelaxedEmbouchure")]
        public BoundingBox WindLessRelaxedEmbouchure { get; set; }

        [DataMember(Name="windLessTightEmbouchure")]
        public BoundingBox WindLessTightEmbouchure { get; set; }

        [DataMember(Name="windMouthpiecePop")]
        public BoundingBox WindMouthpiecePop { get; set; }

        [DataMember(Name="windMultiphonicsBlackStem")]
        public BoundingBox WindMultiphonicsBlackStem { get; set; }

        [DataMember(Name="windMultiphonicsBlackWhiteStem")]
        public BoundingBox WindMultiphonicsBlackWhiteStem { get; set; }

        [DataMember(Name="windMultiphonicsWhiteStem")]
        public BoundingBox WindMultiphonicsWhiteStem { get; set; }

        [DataMember(Name="windOpenHole")]
        public BoundingBox WindOpenHole { get; set; }

        [DataMember(Name="windReedPositionIn")]
        public BoundingBox WindReedPositionIn { get; set; }

        [DataMember(Name="windReedPositionNormal")]
        public BoundingBox WindReedPositionNormal { get; set; }

        [DataMember(Name="windReedPositionOut")]
        public BoundingBox WindReedPositionOut { get; set; }

        [DataMember(Name="windRelaxedEmbouchure")]
        public BoundingBox WindRelaxedEmbouchure { get; set; }

        [DataMember(Name="windRimOnly")]
        public BoundingBox WindRimOnly { get; set; }

        [DataMember(Name="windSharpEmbouchure")]
        public BoundingBox WindSharpEmbouchure { get; set; }

        [DataMember(Name="windStrongAirPressure")]
        public BoundingBox WindStrongAirPressure { get; set; }

        [DataMember(Name="windThreeQuartersClosedHole")]
        public BoundingBox WindThreeQuartersClosedHole { get; set; }

        [DataMember(Name="windTightEmbouchure")]
        public BoundingBox WindTightEmbouchure { get; set; }

        [DataMember(Name="windTrillKey")]
        public BoundingBox WindTrillKey { get; set; }

        [DataMember(Name="windVeryTightEmbouchure")]
        public BoundingBox WindVeryTightEmbouchure { get; set; }

        [DataMember(Name="windWeakAirPressure")]
        public BoundingBox WindWeakAirPressure { get; set; }
    }
}
