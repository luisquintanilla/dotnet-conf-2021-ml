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
using System.IO;
using System.Reflection;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Core.Serialization;

namespace Manufaktura.Controls.SMuFL.EagerLoading
{
    public class SMuFLGlyphs : ISMuFLGlyphs
    {
        private static Lazy<ISMuFLGlyphs> instance = new Lazy<ISMuFLGlyphs>(() =>
        {
            var assembly = typeof(ISMuFLGlyphs).GetTypeInfo().Assembly;
            var resourceName = $"{typeof(ISMuFLGlyphs).Namespace}.glyphnames.json";

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                return LazyLoadJsonProxy<ISMuFLGlyphs>.Create(result);
            }
        });


        internal static ISMuFLGlyphs Instance => instance.Value;

        [DataMember(Name="4stringTabClef")]
        public GlyphDefinition The4StringTabClef { get; set; }

        [DataMember(Name="6stringTabClef")]
        public GlyphDefinition The6StringTabClef { get; set; }

        [DataMember(Name="accSagittal11LargeDiesisDown")]
        public GlyphDefinition AccSagittal11LargeDiesisDown { get; set; }

        [DataMember(Name="accSagittal11LargeDiesisUp")]
        public GlyphDefinition AccSagittal11LargeDiesisUp { get; set; }

        [DataMember(Name="accSagittal11MediumDiesisDown")]
        public GlyphDefinition AccSagittal11MediumDiesisDown { get; set; }

        [DataMember(Name="accSagittal11MediumDiesisUp")]
        public GlyphDefinition AccSagittal11MediumDiesisUp { get; set; }

        [DataMember(Name="accSagittal11v19LargeDiesisDown")]
        public GlyphDefinition AccSagittal11V19LargeDiesisDown { get; set; }

        [DataMember(Name="accSagittal11v19LargeDiesisUp")]
        public GlyphDefinition AccSagittal11V19LargeDiesisUp { get; set; }

        [DataMember(Name="accSagittal11v19MediumDiesisDown")]
        public GlyphDefinition AccSagittal11V19MediumDiesisDown { get; set; }

        [DataMember(Name="accSagittal11v19MediumDiesisUp")]
        public GlyphDefinition AccSagittal11V19MediumDiesisUp { get; set; }

        [DataMember(Name="accSagittal11v49CommaDown")]
        public GlyphDefinition AccSagittal11V49CommaDown { get; set; }

        [DataMember(Name="accSagittal11v49CommaUp")]
        public GlyphDefinition AccSagittal11V49CommaUp { get; set; }

        [DataMember(Name="accSagittal143CommaDown")]
        public GlyphDefinition AccSagittal143CommaDown { get; set; }

        [DataMember(Name="accSagittal143CommaUp")]
        public GlyphDefinition AccSagittal143CommaUp { get; set; }

        [DataMember(Name="accSagittal17CommaDown")]
        public GlyphDefinition AccSagittal17CommaDown { get; set; }

        [DataMember(Name="accSagittal17CommaUp")]
        public GlyphDefinition AccSagittal17CommaUp { get; set; }

        [DataMember(Name="accSagittal17KleismaDown")]
        public GlyphDefinition AccSagittal17KleismaDown { get; set; }

        [DataMember(Name="accSagittal17KleismaUp")]
        public GlyphDefinition AccSagittal17KleismaUp { get; set; }

        [DataMember(Name="accSagittal19CommaDown")]
        public GlyphDefinition AccSagittal19CommaDown { get; set; }

        [DataMember(Name="accSagittal19CommaUp")]
        public GlyphDefinition AccSagittal19CommaUp { get; set; }

        [DataMember(Name="accSagittal19SchismaDown")]
        public GlyphDefinition AccSagittal19SchismaDown { get; set; }

        [DataMember(Name="accSagittal19SchismaUp")]
        public GlyphDefinition AccSagittal19SchismaUp { get; set; }

        [DataMember(Name="accSagittal23CommaDown")]
        public GlyphDefinition AccSagittal23CommaDown { get; set; }

        [DataMember(Name="accSagittal23CommaUp")]
        public GlyphDefinition AccSagittal23CommaUp { get; set; }

        [DataMember(Name="accSagittal23SmallDiesisDown")]
        public GlyphDefinition AccSagittal23SmallDiesisDown { get; set; }

        [DataMember(Name="accSagittal23SmallDiesisUp")]
        public GlyphDefinition AccSagittal23SmallDiesisUp { get; set; }

        [DataMember(Name="accSagittal25SmallDiesisDown")]
        public GlyphDefinition AccSagittal25SmallDiesisDown { get; set; }

        [DataMember(Name="accSagittal25SmallDiesisUp")]
        public GlyphDefinition AccSagittal25SmallDiesisUp { get; set; }

        [DataMember(Name="accSagittal35LargeDiesisDown")]
        public GlyphDefinition AccSagittal35LargeDiesisDown { get; set; }

        [DataMember(Name="accSagittal35LargeDiesisUp")]
        public GlyphDefinition AccSagittal35LargeDiesisUp { get; set; }

        [DataMember(Name="accSagittal35MediumDiesisDown")]
        public GlyphDefinition AccSagittal35MediumDiesisDown { get; set; }

        [DataMember(Name="accSagittal35MediumDiesisUp")]
        public GlyphDefinition AccSagittal35MediumDiesisUp { get; set; }

        [DataMember(Name="accSagittal49LargeDiesisDown")]
        public GlyphDefinition AccSagittal49LargeDiesisDown { get; set; }

        [DataMember(Name="accSagittal49LargeDiesisUp")]
        public GlyphDefinition AccSagittal49LargeDiesisUp { get; set; }

        [DataMember(Name="accSagittal49MediumDiesisDown")]
        public GlyphDefinition AccSagittal49MediumDiesisDown { get; set; }

        [DataMember(Name="accSagittal49MediumDiesisUp")]
        public GlyphDefinition AccSagittal49MediumDiesisUp { get; set; }

        [DataMember(Name="accSagittal49SmallDiesisDown")]
        public GlyphDefinition AccSagittal49SmallDiesisDown { get; set; }

        [DataMember(Name="accSagittal49SmallDiesisUp")]
        public GlyphDefinition AccSagittal49SmallDiesisUp { get; set; }

        [DataMember(Name="accSagittal55CommaDown")]
        public GlyphDefinition AccSagittal55CommaDown { get; set; }

        [DataMember(Name="accSagittal55CommaUp")]
        public GlyphDefinition AccSagittal55CommaUp { get; set; }

        [DataMember(Name="accSagittal5CommaDown")]
        public GlyphDefinition AccSagittal5CommaDown { get; set; }

        [DataMember(Name="accSagittal5CommaUp")]
        public GlyphDefinition AccSagittal5CommaUp { get; set; }

        [DataMember(Name="accSagittal5v11SmallDiesisDown")]
        public GlyphDefinition AccSagittal5V11SmallDiesisDown { get; set; }

        [DataMember(Name="accSagittal5v11SmallDiesisUp")]
        public GlyphDefinition AccSagittal5V11SmallDiesisUp { get; set; }

        [DataMember(Name="accSagittal5v13LargeDiesisDown")]
        public GlyphDefinition AccSagittal5V13LargeDiesisDown { get; set; }

        [DataMember(Name="accSagittal5v13LargeDiesisUp")]
        public GlyphDefinition AccSagittal5V13LargeDiesisUp { get; set; }

        [DataMember(Name="accSagittal5v13MediumDiesisDown")]
        public GlyphDefinition AccSagittal5V13MediumDiesisDown { get; set; }

        [DataMember(Name="accSagittal5v13MediumDiesisUp")]
        public GlyphDefinition AccSagittal5V13MediumDiesisUp { get; set; }

        [DataMember(Name="accSagittal5v19CommaDown")]
        public GlyphDefinition AccSagittal5V19CommaDown { get; set; }

        [DataMember(Name="accSagittal5v19CommaUp")]
        public GlyphDefinition AccSagittal5V19CommaUp { get; set; }

        [DataMember(Name="accSagittal5v23SmallDiesisDown")]
        public GlyphDefinition AccSagittal5V23SmallDiesisDown { get; set; }

        [DataMember(Name="accSagittal5v23SmallDiesisUp")]
        public GlyphDefinition AccSagittal5V23SmallDiesisUp { get; set; }

        [DataMember(Name="accSagittal5v49MediumDiesisDown")]
        public GlyphDefinition AccSagittal5V49MediumDiesisDown { get; set; }

        [DataMember(Name="accSagittal5v49MediumDiesisUp")]
        public GlyphDefinition AccSagittal5V49MediumDiesisUp { get; set; }

        [DataMember(Name="accSagittal5v7KleismaDown")]
        public GlyphDefinition AccSagittal5V7KleismaDown { get; set; }

        [DataMember(Name="accSagittal5v7KleismaUp")]
        public GlyphDefinition AccSagittal5V7KleismaUp { get; set; }

        [DataMember(Name="accSagittal7CommaDown")]
        public GlyphDefinition AccSagittal7CommaDown { get; set; }

        [DataMember(Name="accSagittal7CommaUp")]
        public GlyphDefinition AccSagittal7CommaUp { get; set; }

        [DataMember(Name="accSagittal7v11CommaDown")]
        public GlyphDefinition AccSagittal7V11CommaDown { get; set; }

        [DataMember(Name="accSagittal7v11CommaUp")]
        public GlyphDefinition AccSagittal7V11CommaUp { get; set; }

        [DataMember(Name="accSagittal7v11KleismaDown")]
        public GlyphDefinition AccSagittal7V11KleismaDown { get; set; }

        [DataMember(Name="accSagittal7v11KleismaUp")]
        public GlyphDefinition AccSagittal7V11KleismaUp { get; set; }

        [DataMember(Name="accSagittal7v19CommaDown")]
        public GlyphDefinition AccSagittal7V19CommaDown { get; set; }

        [DataMember(Name="accSagittal7v19CommaUp")]
        public GlyphDefinition AccSagittal7V19CommaUp { get; set; }

        [DataMember(Name="accSagittalAcute")]
        public GlyphDefinition AccSagittalAcute { get; set; }

        [DataMember(Name="accSagittalDoubleFlat")]
        public GlyphDefinition AccSagittalDoubleFlat { get; set; }

        [DataMember(Name="accSagittalDoubleFlat11v49CUp")]
        public GlyphDefinition AccSagittalDoubleFlat11V49CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat143CUp")]
        public GlyphDefinition AccSagittalDoubleFlat143CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat17CUp")]
        public GlyphDefinition AccSagittalDoubleFlat17CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat17kUp")]
        public GlyphDefinition AccSagittalDoubleFlat17KUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat19CUp")]
        public GlyphDefinition AccSagittalDoubleFlat19CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat19sUp")]
        public GlyphDefinition AccSagittalDoubleFlat19SUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat23CUp")]
        public GlyphDefinition AccSagittalDoubleFlat23CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat23SUp")]
        public GlyphDefinition AccSagittalDoubleFlat23SUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat25SUp")]
        public GlyphDefinition AccSagittalDoubleFlat25SUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat49SUp")]
        public GlyphDefinition AccSagittalDoubleFlat49SUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat55CUp")]
        public GlyphDefinition AccSagittalDoubleFlat55CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat5CUp")]
        public GlyphDefinition AccSagittalDoubleFlat5CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat5v11SUp")]
        public GlyphDefinition AccSagittalDoubleFlat5V11SUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat5v19CUp")]
        public GlyphDefinition AccSagittalDoubleFlat5V19CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat5v23SUp")]
        public GlyphDefinition AccSagittalDoubleFlat5V23SUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat5v7kUp")]
        public GlyphDefinition AccSagittalDoubleFlat5V7KUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat7CUp")]
        public GlyphDefinition AccSagittalDoubleFlat7CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat7v11CUp")]
        public GlyphDefinition AccSagittalDoubleFlat7V11CUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat7v11kUp")]
        public GlyphDefinition AccSagittalDoubleFlat7V11KUp { get; set; }

        [DataMember(Name="accSagittalDoubleFlat7v19CUp")]
        public GlyphDefinition AccSagittalDoubleFlat7V19CUp { get; set; }

        [DataMember(Name="accSagittalDoubleSharp")]
        public GlyphDefinition AccSagittalDoubleSharp { get; set; }

        [DataMember(Name="accSagittalDoubleSharp11v49CDown")]
        public GlyphDefinition AccSagittalDoubleSharp11V49CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp143CDown")]
        public GlyphDefinition AccSagittalDoubleSharp143CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp17CDown")]
        public GlyphDefinition AccSagittalDoubleSharp17CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp17kDown")]
        public GlyphDefinition AccSagittalDoubleSharp17KDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp19CDown")]
        public GlyphDefinition AccSagittalDoubleSharp19CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp19sDown")]
        public GlyphDefinition AccSagittalDoubleSharp19SDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp23CDown")]
        public GlyphDefinition AccSagittalDoubleSharp23CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp23SDown")]
        public GlyphDefinition AccSagittalDoubleSharp23SDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp25SDown")]
        public GlyphDefinition AccSagittalDoubleSharp25SDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp49SDown")]
        public GlyphDefinition AccSagittalDoubleSharp49SDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp55CDown")]
        public GlyphDefinition AccSagittalDoubleSharp55CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp5CDown")]
        public GlyphDefinition AccSagittalDoubleSharp5CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp5v11SDown")]
        public GlyphDefinition AccSagittalDoubleSharp5V11SDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp5v19CDown")]
        public GlyphDefinition AccSagittalDoubleSharp5V19CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp5v23SDown")]
        public GlyphDefinition AccSagittalDoubleSharp5V23SDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp5v7kDown")]
        public GlyphDefinition AccSagittalDoubleSharp5V7KDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp7CDown")]
        public GlyphDefinition AccSagittalDoubleSharp7CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp7v11CDown")]
        public GlyphDefinition AccSagittalDoubleSharp7V11CDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp7v11kDown")]
        public GlyphDefinition AccSagittalDoubleSharp7V11KDown { get; set; }

        [DataMember(Name="accSagittalDoubleSharp7v19CDown")]
        public GlyphDefinition AccSagittalDoubleSharp7V19CDown { get; set; }

        [DataMember(Name="accSagittalFlat")]
        public GlyphDefinition AccSagittalFlat { get; set; }

        [DataMember(Name="accSagittalFlat11LDown")]
        public GlyphDefinition AccSagittalFlat11LDown { get; set; }

        [DataMember(Name="accSagittalFlat11MDown")]
        public GlyphDefinition AccSagittalFlat11MDown { get; set; }

        [DataMember(Name="accSagittalFlat11v19LDown")]
        public GlyphDefinition AccSagittalFlat11V19LDown { get; set; }

        [DataMember(Name="accSagittalFlat11v19MDown")]
        public GlyphDefinition AccSagittalFlat11V19MDown { get; set; }

        [DataMember(Name="accSagittalFlat11v49CDown")]
        public GlyphDefinition AccSagittalFlat11V49CDown { get; set; }

        [DataMember(Name="accSagittalFlat11v49CUp")]
        public GlyphDefinition AccSagittalFlat11V49CUp { get; set; }

        [DataMember(Name="accSagittalFlat143CDown")]
        public GlyphDefinition AccSagittalFlat143CDown { get; set; }

        [DataMember(Name="accSagittalFlat143CUp")]
        public GlyphDefinition AccSagittalFlat143CUp { get; set; }

        [DataMember(Name="accSagittalFlat17CDown")]
        public GlyphDefinition AccSagittalFlat17CDown { get; set; }

        [DataMember(Name="accSagittalFlat17CUp")]
        public GlyphDefinition AccSagittalFlat17CUp { get; set; }

        [DataMember(Name="accSagittalFlat17kDown")]
        public GlyphDefinition AccSagittalFlat17KDown { get; set; }

        [DataMember(Name="accSagittalFlat17kUp")]
        public GlyphDefinition AccSagittalFlat17KUp { get; set; }

        [DataMember(Name="accSagittalFlat19CDown")]
        public GlyphDefinition AccSagittalFlat19CDown { get; set; }

        [DataMember(Name="accSagittalFlat19CUp")]
        public GlyphDefinition AccSagittalFlat19CUp { get; set; }

        [DataMember(Name="accSagittalFlat19sDown")]
        public GlyphDefinition AccSagittalFlat19SDown { get; set; }

        [DataMember(Name="accSagittalFlat19sUp")]
        public GlyphDefinition AccSagittalFlat19SUp { get; set; }

        [DataMember(Name="accSagittalFlat23CDown")]
        public GlyphDefinition AccSagittalFlat23CDown { get; set; }

        [DataMember(Name="accSagittalFlat23CUp")]
        public GlyphDefinition AccSagittalFlat23CUp { get; set; }

        [DataMember(Name="accSagittalFlat23SDown")]
        public GlyphDefinition AccSagittalFlat23SDown { get; set; }

        [DataMember(Name="accSagittalFlat23SUp")]
        public GlyphDefinition AccSagittalFlat23SUp { get; set; }

        [DataMember(Name="accSagittalFlat25SDown")]
        public GlyphDefinition AccSagittalFlat25SDown { get; set; }

        [DataMember(Name="accSagittalFlat25SUp")]
        public GlyphDefinition AccSagittalFlat25SUp { get; set; }

        [DataMember(Name="accSagittalFlat35LDown")]
        public GlyphDefinition AccSagittalFlat35LDown { get; set; }

        [DataMember(Name="accSagittalFlat35MDown")]
        public GlyphDefinition AccSagittalFlat35MDown { get; set; }

        [DataMember(Name="accSagittalFlat49LDown")]
        public GlyphDefinition AccSagittalFlat49LDown { get; set; }

        [DataMember(Name="accSagittalFlat49MDown")]
        public GlyphDefinition AccSagittalFlat49MDown { get; set; }

        [DataMember(Name="accSagittalFlat49SDown")]
        public GlyphDefinition AccSagittalFlat49SDown { get; set; }

        [DataMember(Name="accSagittalFlat49SUp")]
        public GlyphDefinition AccSagittalFlat49SUp { get; set; }

        [DataMember(Name="accSagittalFlat55CDown")]
        public GlyphDefinition AccSagittalFlat55CDown { get; set; }

        [DataMember(Name="accSagittalFlat55CUp")]
        public GlyphDefinition AccSagittalFlat55CUp { get; set; }

        [DataMember(Name="accSagittalFlat5CDown")]
        public GlyphDefinition AccSagittalFlat5CDown { get; set; }

        [DataMember(Name="accSagittalFlat5CUp")]
        public GlyphDefinition AccSagittalFlat5CUp { get; set; }

        [DataMember(Name="accSagittalFlat5v11SDown")]
        public GlyphDefinition AccSagittalFlat5V11SDown { get; set; }

        [DataMember(Name="accSagittalFlat5v11SUp")]
        public GlyphDefinition AccSagittalFlat5V11SUp { get; set; }

        [DataMember(Name="accSagittalFlat5v13LDown")]
        public GlyphDefinition AccSagittalFlat5V13LDown { get; set; }

        [DataMember(Name="accSagittalFlat5v13MDown")]
        public GlyphDefinition AccSagittalFlat5V13MDown { get; set; }

        [DataMember(Name="accSagittalFlat5v19CDown")]
        public GlyphDefinition AccSagittalFlat5V19CDown { get; set; }

        [DataMember(Name="accSagittalFlat5v19CUp")]
        public GlyphDefinition AccSagittalFlat5V19CUp { get; set; }

        [DataMember(Name="accSagittalFlat5v23SDown")]
        public GlyphDefinition AccSagittalFlat5V23SDown { get; set; }

        [DataMember(Name="accSagittalFlat5v23SUp")]
        public GlyphDefinition AccSagittalFlat5V23SUp { get; set; }

        [DataMember(Name="accSagittalFlat5v49MDown")]
        public GlyphDefinition AccSagittalFlat5V49MDown { get; set; }

        [DataMember(Name="accSagittalFlat5v7kDown")]
        public GlyphDefinition AccSagittalFlat5V7KDown { get; set; }

        [DataMember(Name="accSagittalFlat5v7kUp")]
        public GlyphDefinition AccSagittalFlat5V7KUp { get; set; }

        [DataMember(Name="accSagittalFlat7CDown")]
        public GlyphDefinition AccSagittalFlat7CDown { get; set; }

        [DataMember(Name="accSagittalFlat7CUp")]
        public GlyphDefinition AccSagittalFlat7CUp { get; set; }

        [DataMember(Name="accSagittalFlat7v11CDown")]
        public GlyphDefinition AccSagittalFlat7V11CDown { get; set; }

        [DataMember(Name="accSagittalFlat7v11CUp")]
        public GlyphDefinition AccSagittalFlat7V11CUp { get; set; }

        [DataMember(Name="accSagittalFlat7v11kDown")]
        public GlyphDefinition AccSagittalFlat7V11KDown { get; set; }

        [DataMember(Name="accSagittalFlat7v11kUp")]
        public GlyphDefinition AccSagittalFlat7V11KUp { get; set; }

        [DataMember(Name="accSagittalFlat7v19CDown")]
        public GlyphDefinition AccSagittalFlat7V19CDown { get; set; }

        [DataMember(Name="accSagittalFlat7v19CUp")]
        public GlyphDefinition AccSagittalFlat7V19CUp { get; set; }

        [DataMember(Name="accSagittalGrave")]
        public GlyphDefinition AccSagittalGrave { get; set; }

        [DataMember(Name="accSagittalShaftDown")]
        public GlyphDefinition AccSagittalShaftDown { get; set; }

        [DataMember(Name="accSagittalShaftUp")]
        public GlyphDefinition AccSagittalShaftUp { get; set; }

        [DataMember(Name="accSagittalSharp")]
        public GlyphDefinition AccSagittalSharp { get; set; }

        [DataMember(Name="accSagittalSharp11LUp")]
        public GlyphDefinition AccSagittalSharp11LUp { get; set; }

        [DataMember(Name="accSagittalSharp11MUp")]
        public GlyphDefinition AccSagittalSharp11MUp { get; set; }

        [DataMember(Name="accSagittalSharp11v19LUp")]
        public GlyphDefinition AccSagittalSharp11V19LUp { get; set; }

        [DataMember(Name="accSagittalSharp11v19MUp")]
        public GlyphDefinition AccSagittalSharp11V19MUp { get; set; }

        [DataMember(Name="accSagittalSharp11v49CDown")]
        public GlyphDefinition AccSagittalSharp11V49CDown { get; set; }

        [DataMember(Name="accSagittalSharp11v49CUp")]
        public GlyphDefinition AccSagittalSharp11V49CUp { get; set; }

        [DataMember(Name="accSagittalSharp143CDown")]
        public GlyphDefinition AccSagittalSharp143CDown { get; set; }

        [DataMember(Name="accSagittalSharp143CUp")]
        public GlyphDefinition AccSagittalSharp143CUp { get; set; }

        [DataMember(Name="accSagittalSharp17CDown")]
        public GlyphDefinition AccSagittalSharp17CDown { get; set; }

        [DataMember(Name="accSagittalSharp17CUp")]
        public GlyphDefinition AccSagittalSharp17CUp { get; set; }

        [DataMember(Name="accSagittalSharp17kDown")]
        public GlyphDefinition AccSagittalSharp17KDown { get; set; }

        [DataMember(Name="accSagittalSharp17kUp")]
        public GlyphDefinition AccSagittalSharp17KUp { get; set; }

        [DataMember(Name="accSagittalSharp19CDown")]
        public GlyphDefinition AccSagittalSharp19CDown { get; set; }

        [DataMember(Name="accSagittalSharp19CUp")]
        public GlyphDefinition AccSagittalSharp19CUp { get; set; }

        [DataMember(Name="accSagittalSharp19sDown")]
        public GlyphDefinition AccSagittalSharp19SDown { get; set; }

        [DataMember(Name="accSagittalSharp19sUp")]
        public GlyphDefinition AccSagittalSharp19SUp { get; set; }

        [DataMember(Name="accSagittalSharp23CDown")]
        public GlyphDefinition AccSagittalSharp23CDown { get; set; }

        [DataMember(Name="accSagittalSharp23CUp")]
        public GlyphDefinition AccSagittalSharp23CUp { get; set; }

        [DataMember(Name="accSagittalSharp23SDown")]
        public GlyphDefinition AccSagittalSharp23SDown { get; set; }

        [DataMember(Name="accSagittalSharp23SUp")]
        public GlyphDefinition AccSagittalSharp23SUp { get; set; }

        [DataMember(Name="accSagittalSharp25SDown")]
        public GlyphDefinition AccSagittalSharp25SDown { get; set; }

        [DataMember(Name="accSagittalSharp25SUp")]
        public GlyphDefinition AccSagittalSharp25SUp { get; set; }

        [DataMember(Name="accSagittalSharp35LUp")]
        public GlyphDefinition AccSagittalSharp35LUp { get; set; }

        [DataMember(Name="accSagittalSharp35MUp")]
        public GlyphDefinition AccSagittalSharp35MUp { get; set; }

        [DataMember(Name="accSagittalSharp49LUp")]
        public GlyphDefinition AccSagittalSharp49LUp { get; set; }

        [DataMember(Name="accSagittalSharp49MUp")]
        public GlyphDefinition AccSagittalSharp49MUp { get; set; }

        [DataMember(Name="accSagittalSharp49SDown")]
        public GlyphDefinition AccSagittalSharp49SDown { get; set; }

        [DataMember(Name="accSagittalSharp49SUp")]
        public GlyphDefinition AccSagittalSharp49SUp { get; set; }

        [DataMember(Name="accSagittalSharp55CDown")]
        public GlyphDefinition AccSagittalSharp55CDown { get; set; }

        [DataMember(Name="accSagittalSharp55CUp")]
        public GlyphDefinition AccSagittalSharp55CUp { get; set; }

        [DataMember(Name="accSagittalSharp5CDown")]
        public GlyphDefinition AccSagittalSharp5CDown { get; set; }

        [DataMember(Name="accSagittalSharp5CUp")]
        public GlyphDefinition AccSagittalSharp5CUp { get; set; }

        [DataMember(Name="accSagittalSharp5v11SDown")]
        public GlyphDefinition AccSagittalSharp5V11SDown { get; set; }

        [DataMember(Name="accSagittalSharp5v11SUp")]
        public GlyphDefinition AccSagittalSharp5V11SUp { get; set; }

        [DataMember(Name="accSagittalSharp5v13LUp")]
        public GlyphDefinition AccSagittalSharp5V13LUp { get; set; }

        [DataMember(Name="accSagittalSharp5v13MUp")]
        public GlyphDefinition AccSagittalSharp5V13MUp { get; set; }

        [DataMember(Name="accSagittalSharp5v19CDown")]
        public GlyphDefinition AccSagittalSharp5V19CDown { get; set; }

        [DataMember(Name="accSagittalSharp5v19CUp")]
        public GlyphDefinition AccSagittalSharp5V19CUp { get; set; }

        [DataMember(Name="accSagittalSharp5v23SDown")]
        public GlyphDefinition AccSagittalSharp5V23SDown { get; set; }

        [DataMember(Name="accSagittalSharp5v23SUp")]
        public GlyphDefinition AccSagittalSharp5V23SUp { get; set; }

        [DataMember(Name="accSagittalSharp5v49MUp")]
        public GlyphDefinition AccSagittalSharp5V49MUp { get; set; }

        [DataMember(Name="accSagittalSharp5v7kDown")]
        public GlyphDefinition AccSagittalSharp5V7KDown { get; set; }

        [DataMember(Name="accSagittalSharp5v7kUp")]
        public GlyphDefinition AccSagittalSharp5V7KUp { get; set; }

        [DataMember(Name="accSagittalSharp7CDown")]
        public GlyphDefinition AccSagittalSharp7CDown { get; set; }

        [DataMember(Name="accSagittalSharp7CUp")]
        public GlyphDefinition AccSagittalSharp7CUp { get; set; }

        [DataMember(Name="accSagittalSharp7v11CDown")]
        public GlyphDefinition AccSagittalSharp7V11CDown { get; set; }

        [DataMember(Name="accSagittalSharp7v11CUp")]
        public GlyphDefinition AccSagittalSharp7V11CUp { get; set; }

        [DataMember(Name="accSagittalSharp7v11kDown")]
        public GlyphDefinition AccSagittalSharp7V11KDown { get; set; }

        [DataMember(Name="accSagittalSharp7v11kUp")]
        public GlyphDefinition AccSagittalSharp7V11KUp { get; set; }

        [DataMember(Name="accSagittalSharp7v19CDown")]
        public GlyphDefinition AccSagittalSharp7V19CDown { get; set; }

        [DataMember(Name="accSagittalSharp7v19CUp")]
        public GlyphDefinition AccSagittalSharp7V19CUp { get; set; }

        [DataMember(Name="accSagittalUnused1")]
        public GlyphDefinition AccSagittalUnused1 { get; set; }

        [DataMember(Name="accSagittalUnused2")]
        public GlyphDefinition AccSagittalUnused2 { get; set; }

        [DataMember(Name="accSagittalUnused3")]
        public GlyphDefinition AccSagittalUnused3 { get; set; }

        [DataMember(Name="accSagittalUnused4")]
        public GlyphDefinition AccSagittalUnused4 { get; set; }

        [DataMember(Name="accdnCombDot")]
        public GlyphDefinition AccdnCombDot { get; set; }

        [DataMember(Name="accdnCombLH2RanksEmpty")]
        public GlyphDefinition AccdnCombLh2RanksEmpty { get; set; }

        [DataMember(Name="accdnCombLH3RanksEmptySquare")]
        public GlyphDefinition AccdnCombLh3RanksEmptySquare { get; set; }

        [DataMember(Name="accdnCombRH3RanksEmpty")]
        public GlyphDefinition AccdnCombRh3RanksEmpty { get; set; }

        [DataMember(Name="accdnCombRH4RanksEmpty")]
        public GlyphDefinition AccdnCombRh4RanksEmpty { get; set; }

        [DataMember(Name="accdnDiatonicClef")]
        public GlyphDefinition AccdnDiatonicClef { get; set; }

        [DataMember(Name="accdnLH2Ranks16Round")]
        public GlyphDefinition AccdnLh2Ranks16Round { get; set; }

        [DataMember(Name="accdnLH2Ranks8Plus16Round")]
        public GlyphDefinition AccdnLh2Ranks8Plus16Round { get; set; }

        [DataMember(Name="accdnLH2Ranks8Round")]
        public GlyphDefinition AccdnLh2Ranks8Round { get; set; }

        [DataMember(Name="accdnLH2RanksFullMasterRound")]
        public GlyphDefinition AccdnLh2RanksFullMasterRound { get; set; }

        [DataMember(Name="accdnLH2RanksMasterPlus16Round")]
        public GlyphDefinition AccdnLh2RanksMasterPlus16Round { get; set; }

        [DataMember(Name="accdnLH2RanksMasterRound")]
        public GlyphDefinition AccdnLh2RanksMasterRound { get; set; }

        [DataMember(Name="accdnLH3Ranks2Plus8Square")]
        public GlyphDefinition AccdnLh3Ranks2Plus8Square { get; set; }

        [DataMember(Name="accdnLH3Ranks2Square")]
        public GlyphDefinition AccdnLh3Ranks2Square { get; set; }

        [DataMember(Name="accdnLH3Ranks8Square")]
        public GlyphDefinition AccdnLh3Ranks8Square { get; set; }

        [DataMember(Name="accdnLH3RanksDouble8Square")]
        public GlyphDefinition AccdnLh3RanksDouble8Square { get; set; }

        [DataMember(Name="accdnLH3RanksTuttiSquare")]
        public GlyphDefinition AccdnLh3RanksTuttiSquare { get; set; }

        [DataMember(Name="accdnPull")]
        public GlyphDefinition AccdnPull { get; set; }

        [DataMember(Name="accdnPush")]
        public GlyphDefinition AccdnPush { get; set; }

        [DataMember(Name="accdnRH3RanksAccordion")]
        public GlyphDefinition AccdnRh3RanksAccordion { get; set; }

        [DataMember(Name="accdnRH3RanksAuthenticMusette")]
        public GlyphDefinition AccdnRh3RanksAuthenticMusette { get; set; }

        [DataMember(Name="accdnRH3RanksBandoneon")]
        public GlyphDefinition AccdnRh3RanksBandoneon { get; set; }

        [DataMember(Name="accdnRH3RanksBassoon")]
        public GlyphDefinition AccdnRh3RanksBassoon { get; set; }

        [DataMember(Name="accdnRH3RanksClarinet")]
        public GlyphDefinition AccdnRh3RanksClarinet { get; set; }

        [DataMember(Name="accdnRH3RanksDoubleTremoloLower8ve")]
        public GlyphDefinition AccdnRh3RanksDoubleTremoloLower8Ve { get; set; }

        [DataMember(Name="accdnRH3RanksDoubleTremoloUpper8ve")]
        public GlyphDefinition AccdnRh3RanksDoubleTremoloUpper8Ve { get; set; }

        [DataMember(Name="accdnRH3RanksFullFactory")]
        public GlyphDefinition AccdnRh3RanksFullFactory { get; set; }

        [DataMember(Name="accdnRH3RanksHarmonium")]
        public GlyphDefinition AccdnRh3RanksHarmonium { get; set; }

        [DataMember(Name="accdnRH3RanksImitationMusette")]
        public GlyphDefinition AccdnRh3RanksImitationMusette { get; set; }

        [DataMember(Name="accdnRH3RanksLowerTremolo8")]
        public GlyphDefinition AccdnRh3RanksLowerTremolo8 { get; set; }

        [DataMember(Name="accdnRH3RanksMaster")]
        public GlyphDefinition AccdnRh3RanksMaster { get; set; }

        [DataMember(Name="accdnRH3RanksOboe")]
        public GlyphDefinition AccdnRh3RanksOboe { get; set; }

        [DataMember(Name="accdnRH3RanksOrgan")]
        public GlyphDefinition AccdnRh3RanksOrgan { get; set; }

        [DataMember(Name="accdnRH3RanksPiccolo")]
        public GlyphDefinition AccdnRh3RanksPiccolo { get; set; }

        [DataMember(Name="accdnRH3RanksTremoloLower8ve")]
        public GlyphDefinition AccdnRh3RanksTremoloLower8Ve { get; set; }

        [DataMember(Name="accdnRH3RanksTremoloUpper8ve")]
        public GlyphDefinition AccdnRh3RanksTremoloUpper8Ve { get; set; }

        [DataMember(Name="accdnRH3RanksTwoChoirs")]
        public GlyphDefinition AccdnRh3RanksTwoChoirs { get; set; }

        [DataMember(Name="accdnRH3RanksUpperTremolo8")]
        public GlyphDefinition AccdnRh3RanksUpperTremolo8 { get; set; }

        [DataMember(Name="accdnRH3RanksViolin")]
        public GlyphDefinition AccdnRh3RanksViolin { get; set; }

        [DataMember(Name="accdnRH4RanksAlto")]
        public GlyphDefinition AccdnRh4RanksAlto { get; set; }

        [DataMember(Name="accdnRH4RanksBassAlto")]
        public GlyphDefinition AccdnRh4RanksBassAlto { get; set; }

        [DataMember(Name="accdnRH4RanksMaster")]
        public GlyphDefinition AccdnRh4RanksMaster { get; set; }

        [DataMember(Name="accdnRH4RanksSoftBass")]
        public GlyphDefinition AccdnRh4RanksSoftBass { get; set; }

        [DataMember(Name="accdnRH4RanksSoftTenor")]
        public GlyphDefinition AccdnRh4RanksSoftTenor { get; set; }

        [DataMember(Name="accdnRH4RanksSoprano")]
        public GlyphDefinition AccdnRh4RanksSoprano { get; set; }

        [DataMember(Name="accdnRH4RanksTenor")]
        public GlyphDefinition AccdnRh4RanksTenor { get; set; }

        [DataMember(Name="accdnRicochet2")]
        public GlyphDefinition AccdnRicochet2 { get; set; }

        [DataMember(Name="accdnRicochet3")]
        public GlyphDefinition AccdnRicochet3 { get; set; }

        [DataMember(Name="accdnRicochet4")]
        public GlyphDefinition AccdnRicochet4 { get; set; }

        [DataMember(Name="accdnRicochet5")]
        public GlyphDefinition AccdnRicochet5 { get; set; }

        [DataMember(Name="accdnRicochet6")]
        public GlyphDefinition AccdnRicochet6 { get; set; }

        [DataMember(Name="accdnRicochetStem2")]
        public GlyphDefinition AccdnRicochetStem2 { get; set; }

        [DataMember(Name="accdnRicochetStem3")]
        public GlyphDefinition AccdnRicochetStem3 { get; set; }

        [DataMember(Name="accdnRicochetStem4")]
        public GlyphDefinition AccdnRicochetStem4 { get; set; }

        [DataMember(Name="accdnRicochetStem5")]
        public GlyphDefinition AccdnRicochetStem5 { get; set; }

        [DataMember(Name="accdnRicochetStem6")]
        public GlyphDefinition AccdnRicochetStem6 { get; set; }

        [DataMember(Name="accidental1CommaFlat")]
        public GlyphDefinition Accidental1CommaFlat { get; set; }

        [DataMember(Name="accidental1CommaSharp")]
        public GlyphDefinition Accidental1CommaSharp { get; set; }

        [DataMember(Name="accidental2CommaFlat")]
        public GlyphDefinition Accidental2CommaFlat { get; set; }

        [DataMember(Name="accidental2CommaSharp")]
        public GlyphDefinition Accidental2CommaSharp { get; set; }

        [DataMember(Name="accidental3CommaFlat")]
        public GlyphDefinition Accidental3CommaFlat { get; set; }

        [DataMember(Name="accidental3CommaSharp")]
        public GlyphDefinition Accidental3CommaSharp { get; set; }

        [DataMember(Name="accidental4CommaFlat")]
        public GlyphDefinition Accidental4CommaFlat { get; set; }

        [DataMember(Name="accidental5CommaSharp")]
        public GlyphDefinition Accidental5CommaSharp { get; set; }

        [DataMember(Name="accidentalArrowDown")]
        public GlyphDefinition AccidentalArrowDown { get; set; }

        [DataMember(Name="accidentalArrowUp")]
        public GlyphDefinition AccidentalArrowUp { get; set; }

        [DataMember(Name="accidentalBakiyeFlat")]
        public GlyphDefinition AccidentalBakiyeFlat { get; set; }

        [DataMember(Name="accidentalBakiyeSharp")]
        public GlyphDefinition AccidentalBakiyeSharp { get; set; }

        [DataMember(Name="accidentalBuyukMucennebFlat")]
        public GlyphDefinition AccidentalBuyukMucennebFlat { get; set; }

        [DataMember(Name="accidentalBuyukMucennebSharp")]
        public GlyphDefinition AccidentalBuyukMucennebSharp { get; set; }

        [DataMember(Name="accidentalCombiningCloseCurlyBrace")]
        public GlyphDefinition AccidentalCombiningCloseCurlyBrace { get; set; }

        [DataMember(Name="accidentalCombiningLower17Schisma")]
        public GlyphDefinition AccidentalCombiningLower17Schisma { get; set; }

        [DataMember(Name="accidentalCombiningLower19Schisma")]
        public GlyphDefinition AccidentalCombiningLower19Schisma { get; set; }

        [DataMember(Name="accidentalCombiningLower23Limit29LimitComma")]
        public GlyphDefinition AccidentalCombiningLower23Limit29LimitComma { get; set; }

        [DataMember(Name="accidentalCombiningLower31Schisma")]
        public GlyphDefinition AccidentalCombiningLower31Schisma { get; set; }

        [DataMember(Name="accidentalCombiningOpenCurlyBrace")]
        public GlyphDefinition AccidentalCombiningOpenCurlyBrace { get; set; }

        [DataMember(Name="accidentalCombiningRaise17Schisma")]
        public GlyphDefinition AccidentalCombiningRaise17Schisma { get; set; }

        [DataMember(Name="accidentalCombiningRaise19Schisma")]
        public GlyphDefinition AccidentalCombiningRaise19Schisma { get; set; }

        [DataMember(Name="accidentalCombiningRaise23Limit29LimitComma")]
        public GlyphDefinition AccidentalCombiningRaise23Limit29LimitComma { get; set; }

        [DataMember(Name="accidentalCombiningRaise31Schisma")]
        public GlyphDefinition AccidentalCombiningRaise31Schisma { get; set; }

        [DataMember(Name="accidentalCommaSlashDown")]
        public GlyphDefinition AccidentalCommaSlashDown { get; set; }

        [DataMember(Name="accidentalCommaSlashUp")]
        public GlyphDefinition AccidentalCommaSlashUp { get; set; }

        [DataMember(Name="GlyphDefinition")]
        public GlyphDefinition GlyphDefinition { get; set; }

        [DataMember(Name="GlyphDefinitionEqualTempered")]
        public GlyphDefinition GlyphDefinitionEqualTempered { get; set; }

        [DataMember(Name="GlyphDefinitionOneArrowDown")]
        public GlyphDefinition GlyphDefinitionOneArrowDown { get; set; }

        [DataMember(Name="GlyphDefinitionOneArrowUp")]
        public GlyphDefinition GlyphDefinitionOneArrowUp { get; set; }

        [DataMember(Name="GlyphDefinitionReversed")]
        public GlyphDefinition GlyphDefinitionReversed { get; set; }

        [DataMember(Name="GlyphDefinitionThreeArrowsDown")]
        public GlyphDefinition GlyphDefinitionThreeArrowsDown { get; set; }

        [DataMember(Name="GlyphDefinitionThreeArrowsUp")]
        public GlyphDefinition GlyphDefinitionThreeArrowsUp { get; set; }

        [DataMember(Name="GlyphDefinitionTurned")]
        public GlyphDefinition GlyphDefinitionTurned { get; set; }

        [DataMember(Name="GlyphDefinitionTwoArrowsDown")]
        public GlyphDefinition GlyphDefinitionTwoArrowsDown { get; set; }

        [DataMember(Name="GlyphDefinitionTwoArrowsUp")]
        public GlyphDefinition GlyphDefinitionTwoArrowsUp { get; set; }

        [DataMember(Name="accidentalDoubleSharp")]
        public GlyphDefinition AccidentalDoubleSharp { get; set; }

        [DataMember(Name="accidentalDoubleSharpEqualTempered")]
        public GlyphDefinition AccidentalDoubleSharpEqualTempered { get; set; }

        [DataMember(Name="accidentalDoubleSharpOneArrowDown")]
        public GlyphDefinition AccidentalDoubleSharpOneArrowDown { get; set; }

        [DataMember(Name="accidentalDoubleSharpOneArrowUp")]
        public GlyphDefinition AccidentalDoubleSharpOneArrowUp { get; set; }

        [DataMember(Name="accidentalDoubleSharpThreeArrowsDown")]
        public GlyphDefinition AccidentalDoubleSharpThreeArrowsDown { get; set; }

        [DataMember(Name="accidentalDoubleSharpThreeArrowsUp")]
        public GlyphDefinition AccidentalDoubleSharpThreeArrowsUp { get; set; }

        [DataMember(Name="accidentalDoubleSharpTwoArrowsDown")]
        public GlyphDefinition AccidentalDoubleSharpTwoArrowsDown { get; set; }

        [DataMember(Name="accidentalDoubleSharpTwoArrowsUp")]
        public GlyphDefinition AccidentalDoubleSharpTwoArrowsUp { get; set; }

        [DataMember(Name="accidentalFilledReversedFlatAndFlat")]
        public GlyphDefinition AccidentalFilledReversedFlatAndFlat { get; set; }

        [DataMember(Name="accidentalFilledReversedFlatAndFlatArrowDown")]
        public GlyphDefinition AccidentalFilledReversedFlatAndFlatArrowDown { get; set; }

        [DataMember(Name="accidentalFilledReversedFlatAndFlatArrowUp")]
        public GlyphDefinition AccidentalFilledReversedFlatAndFlatArrowUp { get; set; }

        [DataMember(Name="accidentalFilledReversedFlatArrowDown")]
        public GlyphDefinition AccidentalFilledReversedFlatArrowDown { get; set; }

        [DataMember(Name="accidentalFilledReversedFlatArrowUp")]
        public GlyphDefinition AccidentalFilledReversedFlatArrowUp { get; set; }

        [DataMember(Name="accidentalFiveQuarterTonesFlatArrowDown")]
        public GlyphDefinition AccidentalFiveQuarterTonesFlatArrowDown { get; set; }

        [DataMember(Name="accidentalFiveQuarterTonesSharpArrowUp")]
        public GlyphDefinition AccidentalFiveQuarterTonesSharpArrowUp { get; set; }

        [DataMember(Name="accidentalFlat")]
        public GlyphDefinition AccidentalFlat { get; set; }

        [DataMember(Name="accidentalFlatEqualTempered")]
        public GlyphDefinition AccidentalFlatEqualTempered { get; set; }

        [DataMember(Name="accidentalFlatOneArrowDown")]
        public GlyphDefinition AccidentalFlatOneArrowDown { get; set; }

        [DataMember(Name="accidentalFlatOneArrowUp")]
        public GlyphDefinition AccidentalFlatOneArrowUp { get; set; }

        [DataMember(Name="accidentalFlatThreeArrowsDown")]
        public GlyphDefinition AccidentalFlatThreeArrowsDown { get; set; }

        [DataMember(Name="accidentalFlatThreeArrowsUp")]
        public GlyphDefinition AccidentalFlatThreeArrowsUp { get; set; }

        [DataMember(Name="accidentalFlatTurned")]
        public GlyphDefinition AccidentalFlatTurned { get; set; }

        [DataMember(Name="accidentalFlatTwoArrowsDown")]
        public GlyphDefinition AccidentalFlatTwoArrowsDown { get; set; }

        [DataMember(Name="accidentalFlatTwoArrowsUp")]
        public GlyphDefinition AccidentalFlatTwoArrowsUp { get; set; }

        [DataMember(Name="accidentalHalfSharpArrowDown")]
        public GlyphDefinition AccidentalHalfSharpArrowDown { get; set; }

        [DataMember(Name="accidentalHalfSharpArrowUp")]
        public GlyphDefinition AccidentalHalfSharpArrowUp { get; set; }

        [DataMember(Name="accidentalJohnston13")]
        public GlyphDefinition AccidentalJohnston13 { get; set; }

        [DataMember(Name="accidentalJohnston31")]
        public GlyphDefinition AccidentalJohnston31 { get; set; }

        [DataMember(Name="accidentalJohnstonDown")]
        public GlyphDefinition AccidentalJohnstonDown { get; set; }

        [DataMember(Name="accidentalJohnstonEl")]
        public GlyphDefinition AccidentalJohnstonEl { get; set; }

        [DataMember(Name="accidentalJohnstonMinus")]
        public GlyphDefinition AccidentalJohnstonMinus { get; set; }

        [DataMember(Name="accidentalJohnstonPlus")]
        public GlyphDefinition AccidentalJohnstonPlus { get; set; }

        [DataMember(Name="accidentalJohnstonSeven")]
        public GlyphDefinition AccidentalJohnstonSeven { get; set; }

        [DataMember(Name="accidentalJohnstonUp")]
        public GlyphDefinition AccidentalJohnstonUp { get; set; }

        [DataMember(Name="accidentalKomaFlat")]
        public GlyphDefinition AccidentalKomaFlat { get; set; }

        [DataMember(Name="accidentalKomaSharp")]
        public GlyphDefinition AccidentalKomaSharp { get; set; }

        [DataMember(Name="accidentalKoron")]
        public GlyphDefinition AccidentalKoron { get; set; }

        [DataMember(Name="accidentalKucukMucennebFlat")]
        public GlyphDefinition AccidentalKucukMucennebFlat { get; set; }

        [DataMember(Name="accidentalKucukMucennebSharp")]
        public GlyphDefinition AccidentalKucukMucennebSharp { get; set; }

        [DataMember(Name="accidentalLargeDoubleSharp")]
        public GlyphDefinition AccidentalLargeDoubleSharp { get; set; }

        [DataMember(Name="accidentalLowerOneSeptimalComma")]
        public GlyphDefinition AccidentalLowerOneSeptimalComma { get; set; }

        [DataMember(Name="accidentalLowerOneTridecimalQuartertone")]
        public GlyphDefinition AccidentalLowerOneTridecimalQuartertone { get; set; }

        [DataMember(Name="accidentalLowerOneUndecimalQuartertone")]
        public GlyphDefinition AccidentalLowerOneUndecimalQuartertone { get; set; }

        [DataMember(Name="accidentalLowerTwoSeptimalCommas")]
        public GlyphDefinition AccidentalLowerTwoSeptimalCommas { get; set; }

        [DataMember(Name="accidentalNarrowReversedFlat")]
        public GlyphDefinition AccidentalNarrowReversedFlat { get; set; }

        [DataMember(Name="accidentalNarrowReversedFlatAndFlat")]
        public GlyphDefinition AccidentalNarrowReversedFlatAndFlat { get; set; }

        [DataMember(Name="accidentalNatural")]
        public GlyphDefinition AccidentalNatural { get; set; }

        [DataMember(Name="accidentalNaturalEqualTempered")]
        public GlyphDefinition AccidentalNaturalEqualTempered { get; set; }

        [DataMember(Name="accidentalNaturalFlat")]
        public GlyphDefinition AccidentalNaturalFlat { get; set; }

        [DataMember(Name="accidentalNaturalOneArrowDown")]
        public GlyphDefinition AccidentalNaturalOneArrowDown { get; set; }

        [DataMember(Name="accidentalNaturalOneArrowUp")]
        public GlyphDefinition AccidentalNaturalOneArrowUp { get; set; }

        [DataMember(Name="accidentalNaturalReversed")]
        public GlyphDefinition AccidentalNaturalReversed { get; set; }

        [DataMember(Name="accidentalNaturalSharp")]
        public GlyphDefinition AccidentalNaturalSharp { get; set; }

        [DataMember(Name="accidentalNaturalThreeArrowsDown")]
        public GlyphDefinition AccidentalNaturalThreeArrowsDown { get; set; }

        [DataMember(Name="accidentalNaturalThreeArrowsUp")]
        public GlyphDefinition AccidentalNaturalThreeArrowsUp { get; set; }

        [DataMember(Name="accidentalNaturalTwoArrowsDown")]
        public GlyphDefinition AccidentalNaturalTwoArrowsDown { get; set; }

        [DataMember(Name="accidentalNaturalTwoArrowsUp")]
        public GlyphDefinition AccidentalNaturalTwoArrowsUp { get; set; }

        [DataMember(Name="accidentalOneAndAHalfSharpsArrowDown")]
        public GlyphDefinition AccidentalOneAndAHalfSharpsArrowDown { get; set; }

        [DataMember(Name="accidentalOneAndAHalfSharpsArrowUp")]
        public GlyphDefinition AccidentalOneAndAHalfSharpsArrowUp { get; set; }

        [DataMember(Name="accidentalOneThirdToneFlatFerneyhough")]
        public GlyphDefinition AccidentalOneThirdToneFlatFerneyhough { get; set; }

        [DataMember(Name="accidentalOneThirdToneSharpFerneyhough")]
        public GlyphDefinition AccidentalOneThirdToneSharpFerneyhough { get; set; }

        [DataMember(Name="accidentalParensLeft")]
        public GlyphDefinition AccidentalParensLeft { get; set; }

        [DataMember(Name="accidentalParensRight")]
        public GlyphDefinition AccidentalParensRight { get; set; }

        [DataMember(Name="accidentalQuarterToneFlat4")]
        public GlyphDefinition AccidentalQuarterToneFlat4 { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatArrowUp")]
        public GlyphDefinition AccidentalQuarterToneFlatArrowUp { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatFilledReversed")]
        public GlyphDefinition AccidentalQuarterToneFlatFilledReversed { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatNaturalArrowDown")]
        public GlyphDefinition AccidentalQuarterToneFlatNaturalArrowDown { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatPenderecki")]
        public GlyphDefinition AccidentalQuarterToneFlatPenderecki { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatStein")]
        public GlyphDefinition AccidentalQuarterToneFlatStein { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatVanBlankenburg")]
        public GlyphDefinition AccidentalQuarterToneFlatVanBlankenburg { get; set; }

        [DataMember(Name="accidentalQuarterToneSharp4")]
        public GlyphDefinition AccidentalQuarterToneSharp4 { get; set; }

        [DataMember(Name="accidentalQuarterToneSharpArrowDown")]
        public GlyphDefinition AccidentalQuarterToneSharpArrowDown { get; set; }

        [DataMember(Name="accidentalQuarterToneSharpBusotti")]
        public GlyphDefinition AccidentalQuarterToneSharpBusotti { get; set; }

        [DataMember(Name="accidentalQuarterToneSharpNaturalArrowUp")]
        public GlyphDefinition AccidentalQuarterToneSharpNaturalArrowUp { get; set; }

        [DataMember(Name="accidentalQuarterToneSharpStein")]
        public GlyphDefinition AccidentalQuarterToneSharpStein { get; set; }

        [DataMember(Name="accidentalQuarterToneSharpWiggle")]
        public GlyphDefinition AccidentalQuarterToneSharpWiggle { get; set; }

        [DataMember(Name="accidentalRaiseOneSeptimalComma")]
        public GlyphDefinition AccidentalRaiseOneSeptimalComma { get; set; }

        [DataMember(Name="accidentalRaiseOneTridecimalQuartertone")]
        public GlyphDefinition AccidentalRaiseOneTridecimalQuartertone { get; set; }

        [DataMember(Name="accidentalRaiseOneUndecimalQuartertone")]
        public GlyphDefinition AccidentalRaiseOneUndecimalQuartertone { get; set; }

        [DataMember(Name="accidentalRaiseTwoSeptimalCommas")]
        public GlyphDefinition AccidentalRaiseTwoSeptimalCommas { get; set; }

        [DataMember(Name="accidentalReversedFlatAndFlatArrowDown")]
        public GlyphDefinition AccidentalReversedFlatAndFlatArrowDown { get; set; }

        [DataMember(Name="accidentalReversedFlatAndFlatArrowUp")]
        public GlyphDefinition AccidentalReversedFlatAndFlatArrowUp { get; set; }

        [DataMember(Name="accidentalReversedFlatArrowDown")]
        public GlyphDefinition AccidentalReversedFlatArrowDown { get; set; }

        [DataMember(Name="accidentalReversedFlatArrowUp")]
        public GlyphDefinition AccidentalReversedFlatArrowUp { get; set; }

        [DataMember(Name="accidentalSharp")]
        public GlyphDefinition AccidentalSharp { get; set; }

        [DataMember(Name="accidentalSharpEqualTempered")]
        public GlyphDefinition AccidentalSharpEqualTempered { get; set; }

        [DataMember(Name="accidentalSharpOneArrowDown")]
        public GlyphDefinition AccidentalSharpOneArrowDown { get; set; }

        [DataMember(Name="accidentalSharpOneArrowUp")]
        public GlyphDefinition AccidentalSharpOneArrowUp { get; set; }

        [DataMember(Name="accidentalSharpOneHorizontalStroke")]
        public GlyphDefinition AccidentalSharpOneHorizontalStroke { get; set; }

        [DataMember(Name="accidentalSharpReversed")]
        public GlyphDefinition AccidentalSharpReversed { get; set; }

        [DataMember(Name="accidentalSharpSharp")]
        public GlyphDefinition AccidentalSharpSharp { get; set; }

        [DataMember(Name="accidentalSharpThreeArrowsDown")]
        public GlyphDefinition AccidentalSharpThreeArrowsDown { get; set; }

        [DataMember(Name="accidentalSharpThreeArrowsUp")]
        public GlyphDefinition AccidentalSharpThreeArrowsUp { get; set; }

        [DataMember(Name="accidentalSharpTwoArrowsDown")]
        public GlyphDefinition AccidentalSharpTwoArrowsDown { get; set; }

        [DataMember(Name="accidentalSharpTwoArrowsUp")]
        public GlyphDefinition AccidentalSharpTwoArrowsUp { get; set; }

        [DataMember(Name="accidentalSims12Down")]
        public GlyphDefinition AccidentalSims12Down { get; set; }

        [DataMember(Name="accidentalSims12Up")]
        public GlyphDefinition AccidentalSims12Up { get; set; }

        [DataMember(Name="accidentalSims4Down")]
        public GlyphDefinition AccidentalSims4Down { get; set; }

        [DataMember(Name="accidentalSims4Up")]
        public GlyphDefinition AccidentalSims4Up { get; set; }

        [DataMember(Name="accidentalSims6Down")]
        public GlyphDefinition AccidentalSims6Down { get; set; }

        [DataMember(Name="accidentalSims6Up")]
        public GlyphDefinition AccidentalSims6Up { get; set; }

        [DataMember(Name="accidentalSori")]
        public GlyphDefinition AccidentalSori { get; set; }

        [DataMember(Name="accidentalTavenerFlat")]
        public GlyphDefinition AccidentalTavenerFlat { get; set; }

        [DataMember(Name="accidentalTavenerSharp")]
        public GlyphDefinition AccidentalTavenerSharp { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatArrowDown")]
        public GlyphDefinition AccidentalThreeQuarterTonesFlatArrowDown { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatArrowUp")]
        public GlyphDefinition AccidentalThreeQuarterTonesFlatArrowUp { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatCouper")]
        public GlyphDefinition AccidentalThreeQuarterTonesFlatCouper { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatGrisey")]
        public GlyphDefinition AccidentalThreeQuarterTonesFlatGrisey { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatTartini")]
        public GlyphDefinition AccidentalThreeQuarterTonesFlatTartini { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatZimmermann")]
        public GlyphDefinition AccidentalThreeQuarterTonesFlatZimmermann { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesSharpArrowDown")]
        public GlyphDefinition AccidentalThreeQuarterTonesSharpArrowDown { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesSharpArrowUp")]
        public GlyphDefinition AccidentalThreeQuarterTonesSharpArrowUp { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesSharpBusotti")]
        public GlyphDefinition AccidentalThreeQuarterTonesSharpBusotti { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesSharpStein")]
        public GlyphDefinition AccidentalThreeQuarterTonesSharpStein { get; set; }

        [DataMember(Name="accidentalTripleFlat")]
        public GlyphDefinition AccidentalTripleFlat { get; set; }

        [DataMember(Name="accidentalTripleSharp")]
        public GlyphDefinition AccidentalTripleSharp { get; set; }

        [DataMember(Name="accidentalTwoThirdTonesFlatFerneyhough")]
        public GlyphDefinition AccidentalTwoThirdTonesFlatFerneyhough { get; set; }

        [DataMember(Name="accidentalTwoThirdTonesSharpFerneyhough")]
        public GlyphDefinition AccidentalTwoThirdTonesSharpFerneyhough { get; set; }

        [DataMember(Name="accidentalWilsonMinus")]
        public GlyphDefinition AccidentalWilsonMinus { get; set; }

        [DataMember(Name="accidentalWilsonPlus")]
        public GlyphDefinition AccidentalWilsonPlus { get; set; }

        [DataMember(Name="accidentalWyschnegradsky10TwelfthsFlat")]
        public GlyphDefinition AccidentalWyschnegradsky10TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky10TwelfthsSharp")]
        public GlyphDefinition AccidentalWyschnegradsky10TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky11TwelfthsFlat")]
        public GlyphDefinition AccidentalWyschnegradsky11TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky11TwelfthsSharp")]
        public GlyphDefinition AccidentalWyschnegradsky11TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky1TwelfthsFlat")]
        public GlyphDefinition AccidentalWyschnegradsky1TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky1TwelfthsSharp")]
        public GlyphDefinition AccidentalWyschnegradsky1TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky2TwelfthsFlat")]
        public GlyphDefinition AccidentalWyschnegradsky2TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky2TwelfthsSharp")]
        public GlyphDefinition AccidentalWyschnegradsky2TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky3TwelfthsFlat")]
        public GlyphDefinition AccidentalWyschnegradsky3TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky3TwelfthsSharp")]
        public GlyphDefinition AccidentalWyschnegradsky3TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky4TwelfthsFlat")]
        public GlyphDefinition AccidentalWyschnegradsky4TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky4TwelfthsSharp")]
        public GlyphDefinition AccidentalWyschnegradsky4TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky5TwelfthsFlat")]
        public GlyphDefinition AccidentalWyschnegradsky5TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky5TwelfthsSharp")]
        public GlyphDefinition AccidentalWyschnegradsky5TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky6TwelfthsFlat")]
        public GlyphDefinition AccidentalWyschnegradsky6TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky6TwelfthsSharp")]
        public GlyphDefinition AccidentalWyschnegradsky6TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky7TwelfthsFlat")]
        public GlyphDefinition AccidentalWyschnegradsky7TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky7TwelfthsSharp")]
        public GlyphDefinition AccidentalWyschnegradsky7TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky8TwelfthsFlat")]
        public GlyphDefinition AccidentalWyschnegradsky8TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky8TwelfthsSharp")]
        public GlyphDefinition AccidentalWyschnegradsky8TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky9TwelfthsFlat")]
        public GlyphDefinition AccidentalWyschnegradsky9TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky9TwelfthsSharp")]
        public GlyphDefinition AccidentalWyschnegradsky9TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalXenakisOneThirdToneSharp")]
        public GlyphDefinition AccidentalXenakisOneThirdToneSharp { get; set; }

        [DataMember(Name="accidentalXenakisTwoThirdTonesSharp")]
        public GlyphDefinition AccidentalXenakisTwoThirdTonesSharp { get; set; }

        [DataMember(Name="analyticsChoralmelodie")]
        public GlyphDefinition AnalyticsChoralmelodie { get; set; }

        [DataMember(Name="analyticsEndStimme")]
        public GlyphDefinition AnalyticsEndStimme { get; set; }

        [DataMember(Name="analyticsHauptrhythmus")]
        public GlyphDefinition AnalyticsHauptrhythmus { get; set; }

        [DataMember(Name="analyticsHauptstimme")]
        public GlyphDefinition AnalyticsHauptstimme { get; set; }

        [DataMember(Name="analyticsInversion1")]
        public GlyphDefinition AnalyticsInversion1 { get; set; }

        [DataMember(Name="analyticsNebenstimme")]
        public GlyphDefinition AnalyticsNebenstimme { get; set; }

        [DataMember(Name="analyticsStartStimme")]
        public GlyphDefinition AnalyticsStartStimme { get; set; }

        [DataMember(Name="analyticsTheme")]
        public GlyphDefinition AnalyticsTheme { get; set; }

        [DataMember(Name="analyticsTheme1")]
        public GlyphDefinition AnalyticsTheme1 { get; set; }

        [DataMember(Name="analyticsThemeInversion")]
        public GlyphDefinition AnalyticsThemeInversion { get; set; }

        [DataMember(Name="analyticsThemeRetrograde")]
        public GlyphDefinition AnalyticsThemeRetrograde { get; set; }

        [DataMember(Name="analyticsThemeRetrogradeInversion")]
        public GlyphDefinition AnalyticsThemeRetrogradeInversion { get; set; }

        [DataMember(Name="arpeggiatoDown")]
        public GlyphDefinition ArpeggiatoDown { get; set; }

        [DataMember(Name="arpeggiatoUp")]
        public GlyphDefinition ArpeggiatoUp { get; set; }

        [DataMember(Name="arrowBlackDown")]
        public GlyphDefinition ArrowBlackDown { get; set; }

        [DataMember(Name="arrowBlackDownLeft")]
        public GlyphDefinition ArrowBlackDownLeft { get; set; }

        [DataMember(Name="arrowBlackDownRight")]
        public GlyphDefinition ArrowBlackDownRight { get; set; }

        [DataMember(Name="arrowBlackLeft")]
        public GlyphDefinition ArrowBlackLeft { get; set; }

        [DataMember(Name="arrowBlackRight")]
        public GlyphDefinition ArrowBlackRight { get; set; }

        [DataMember(Name="arrowBlackUp")]
        public GlyphDefinition ArrowBlackUp { get; set; }

        [DataMember(Name="arrowBlackUpLeft")]
        public GlyphDefinition ArrowBlackUpLeft { get; set; }

        [DataMember(Name="arrowBlackUpRight")]
        public GlyphDefinition ArrowBlackUpRight { get; set; }

        [DataMember(Name="arrowOpenDown")]
        public GlyphDefinition ArrowOpenDown { get; set; }

        [DataMember(Name="arrowOpenDownLeft")]
        public GlyphDefinition ArrowOpenDownLeft { get; set; }

        [DataMember(Name="arrowOpenDownRight")]
        public GlyphDefinition ArrowOpenDownRight { get; set; }

        [DataMember(Name="arrowOpenLeft")]
        public GlyphDefinition ArrowOpenLeft { get; set; }

        [DataMember(Name="arrowOpenRight")]
        public GlyphDefinition ArrowOpenRight { get; set; }

        [DataMember(Name="arrowOpenUp")]
        public GlyphDefinition ArrowOpenUp { get; set; }

        [DataMember(Name="arrowOpenUpLeft")]
        public GlyphDefinition ArrowOpenUpLeft { get; set; }

        [DataMember(Name="arrowOpenUpRight")]
        public GlyphDefinition ArrowOpenUpRight { get; set; }

        [DataMember(Name="arrowWhiteDown")]
        public GlyphDefinition ArrowWhiteDown { get; set; }

        [DataMember(Name="arrowWhiteDownLeft")]
        public GlyphDefinition ArrowWhiteDownLeft { get; set; }

        [DataMember(Name="arrowWhiteDownRight")]
        public GlyphDefinition ArrowWhiteDownRight { get; set; }

        [DataMember(Name="arrowWhiteLeft")]
        public GlyphDefinition ArrowWhiteLeft { get; set; }

        [DataMember(Name="arrowWhiteRight")]
        public GlyphDefinition ArrowWhiteRight { get; set; }

        [DataMember(Name="arrowWhiteUp")]
        public GlyphDefinition ArrowWhiteUp { get; set; }

        [DataMember(Name="arrowWhiteUpLeft")]
        public GlyphDefinition ArrowWhiteUpLeft { get; set; }

        [DataMember(Name="arrowWhiteUpRight")]
        public GlyphDefinition ArrowWhiteUpRight { get; set; }

        [DataMember(Name="arrowheadBlackDown")]
        public GlyphDefinition ArrowheadBlackDown { get; set; }

        [DataMember(Name="arrowheadBlackDownLeft")]
        public GlyphDefinition ArrowheadBlackDownLeft { get; set; }

        [DataMember(Name="arrowheadBlackDownRight")]
        public GlyphDefinition ArrowheadBlackDownRight { get; set; }

        [DataMember(Name="arrowheadBlackLeft")]
        public GlyphDefinition ArrowheadBlackLeft { get; set; }

        [DataMember(Name="arrowheadBlackRight")]
        public GlyphDefinition ArrowheadBlackRight { get; set; }

        [DataMember(Name="arrowheadBlackUp")]
        public GlyphDefinition ArrowheadBlackUp { get; set; }

        [DataMember(Name="arrowheadBlackUpLeft")]
        public GlyphDefinition ArrowheadBlackUpLeft { get; set; }

        [DataMember(Name="arrowheadBlackUpRight")]
        public GlyphDefinition ArrowheadBlackUpRight { get; set; }

        [DataMember(Name="arrowheadOpenDown")]
        public GlyphDefinition ArrowheadOpenDown { get; set; }

        [DataMember(Name="arrowheadOpenDownLeft")]
        public GlyphDefinition ArrowheadOpenDownLeft { get; set; }

        [DataMember(Name="arrowheadOpenDownRight")]
        public GlyphDefinition ArrowheadOpenDownRight { get; set; }

        [DataMember(Name="arrowheadOpenLeft")]
        public GlyphDefinition ArrowheadOpenLeft { get; set; }

        [DataMember(Name="arrowheadOpenRight")]
        public GlyphDefinition ArrowheadOpenRight { get; set; }

        [DataMember(Name="arrowheadOpenUp")]
        public GlyphDefinition ArrowheadOpenUp { get; set; }

        [DataMember(Name="arrowheadOpenUpLeft")]
        public GlyphDefinition ArrowheadOpenUpLeft { get; set; }

        [DataMember(Name="arrowheadOpenUpRight")]
        public GlyphDefinition ArrowheadOpenUpRight { get; set; }

        [DataMember(Name="arrowheadWhiteDown")]
        public GlyphDefinition ArrowheadWhiteDown { get; set; }

        [DataMember(Name="arrowheadWhiteDownLeft")]
        public GlyphDefinition ArrowheadWhiteDownLeft { get; set; }

        [DataMember(Name="arrowheadWhiteDownRight")]
        public GlyphDefinition ArrowheadWhiteDownRight { get; set; }

        [DataMember(Name="arrowheadWhiteLeft")]
        public GlyphDefinition ArrowheadWhiteLeft { get; set; }

        [DataMember(Name="arrowheadWhiteRight")]
        public GlyphDefinition ArrowheadWhiteRight { get; set; }

        [DataMember(Name="arrowheadWhiteUp")]
        public GlyphDefinition ArrowheadWhiteUp { get; set; }

        [DataMember(Name="arrowheadWhiteUpLeft")]
        public GlyphDefinition ArrowheadWhiteUpLeft { get; set; }

        [DataMember(Name="arrowheadWhiteUpRight")]
        public GlyphDefinition ArrowheadWhiteUpRight { get; set; }

        [DataMember(Name="articAccentAbove")]
        public GlyphDefinition ArticAccentAbove { get; set; }

        [DataMember(Name="articAccentBelow")]
        public GlyphDefinition ArticAccentBelow { get; set; }

        [DataMember(Name="articAccentStaccatoAbove")]
        public GlyphDefinition ArticAccentStaccatoAbove { get; set; }

        [DataMember(Name="articAccentStaccatoBelow")]
        public GlyphDefinition ArticAccentStaccatoBelow { get; set; }

        [DataMember(Name="articLaissezVibrerAbove")]
        public GlyphDefinition ArticLaissezVibrerAbove { get; set; }

        [DataMember(Name="articLaissezVibrerBelow")]
        public GlyphDefinition ArticLaissezVibrerBelow { get; set; }

        [DataMember(Name="articMarcatoAbove")]
        public GlyphDefinition ArticMarcatoAbove { get; set; }

        [DataMember(Name="articMarcatoBelow")]
        public GlyphDefinition ArticMarcatoBelow { get; set; }

        [DataMember(Name="articMarcatoStaccatoAbove")]
        public GlyphDefinition ArticMarcatoStaccatoAbove { get; set; }

        [DataMember(Name="articMarcatoStaccatoBelow")]
        public GlyphDefinition ArticMarcatoStaccatoBelow { get; set; }

        [DataMember(Name="articStaccatissimoAbove")]
        public GlyphDefinition ArticStaccatissimoAbove { get; set; }

        [DataMember(Name="articStaccatissimoBelow")]
        public GlyphDefinition ArticStaccatissimoBelow { get; set; }

        [DataMember(Name="articStaccatissimoStrokeAbove")]
        public GlyphDefinition ArticStaccatissimoStrokeAbove { get; set; }

        [DataMember(Name="articStaccatissimoStrokeBelow")]
        public GlyphDefinition ArticStaccatissimoStrokeBelow { get; set; }

        [DataMember(Name="articStaccatissimoWedgeAbove")]
        public GlyphDefinition ArticStaccatissimoWedgeAbove { get; set; }

        [DataMember(Name="articStaccatissimoWedgeBelow")]
        public GlyphDefinition ArticStaccatissimoWedgeBelow { get; set; }

        [DataMember(Name="articStaccatoAbove")]
        public GlyphDefinition ArticStaccatoAbove { get; set; }

        [DataMember(Name="articStaccatoBelow")]
        public GlyphDefinition ArticStaccatoBelow { get; set; }

        [DataMember(Name="articStressAbove")]
        public GlyphDefinition ArticStressAbove { get; set; }

        [DataMember(Name="articStressBelow")]
        public GlyphDefinition ArticStressBelow { get; set; }

        [DataMember(Name="articTenutoAbove")]
        public GlyphDefinition ArticTenutoAbove { get; set; }

        [DataMember(Name="articTenutoAccentAbove")]
        public GlyphDefinition ArticTenutoAccentAbove { get; set; }

        [DataMember(Name="articTenutoAccentBelow")]
        public GlyphDefinition ArticTenutoAccentBelow { get; set; }

        [DataMember(Name="articTenutoBelow")]
        public GlyphDefinition ArticTenutoBelow { get; set; }

        [DataMember(Name="articTenutoStaccatoAbove")]
        public GlyphDefinition ArticTenutoStaccatoAbove { get; set; }

        [DataMember(Name="articTenutoStaccatoBelow")]
        public GlyphDefinition ArticTenutoStaccatoBelow { get; set; }

        [DataMember(Name="articUnstressAbove")]
        public GlyphDefinition ArticUnstressAbove { get; set; }

        [DataMember(Name="articUnstressBelow")]
        public GlyphDefinition ArticUnstressBelow { get; set; }

        [DataMember(Name="augmentationDot")]
        public GlyphDefinition AugmentationDot { get; set; }

        [DataMember(Name="barlineDashed")]
        public GlyphDefinition BarlineDashed { get; set; }

        [DataMember(Name="barlineDotted")]
        public GlyphDefinition BarlineDotted { get; set; }

        [DataMember(Name="barlineDouble")]
        public GlyphDefinition BarlineDouble { get; set; }

        [DataMember(Name="barlineFinal")]
        public GlyphDefinition BarlineFinal { get; set; }

        [DataMember(Name="barlineHeavy")]
        public GlyphDefinition BarlineHeavy { get; set; }

        [DataMember(Name="barlineHeavyHeavy")]
        public GlyphDefinition BarlineHeavyHeavy { get; set; }

        [DataMember(Name="barlineReverseFinal")]
        public GlyphDefinition BarlineReverseFinal { get; set; }

        [DataMember(Name="barlineShort")]
        public GlyphDefinition BarlineShort { get; set; }

        [DataMember(Name="barlineSingle")]
        public GlyphDefinition BarlineSingle { get; set; }

        [DataMember(Name="barlineTick")]
        public GlyphDefinition BarlineTick { get; set; }

        [DataMember(Name="beamAccelRit1")]
        public GlyphDefinition BeamAccelRit1 { get; set; }

        [DataMember(Name="beamAccelRit10")]
        public GlyphDefinition BeamAccelRit10 { get; set; }

        [DataMember(Name="beamAccelRit11")]
        public GlyphDefinition BeamAccelRit11 { get; set; }

        [DataMember(Name="beamAccelRit12")]
        public GlyphDefinition BeamAccelRit12 { get; set; }

        [DataMember(Name="beamAccelRit13")]
        public GlyphDefinition BeamAccelRit13 { get; set; }

        [DataMember(Name="beamAccelRit14")]
        public GlyphDefinition BeamAccelRit14 { get; set; }

        [DataMember(Name="beamAccelRit15")]
        public GlyphDefinition BeamAccelRit15 { get; set; }

        [DataMember(Name="beamAccelRit2")]
        public GlyphDefinition BeamAccelRit2 { get; set; }

        [DataMember(Name="beamAccelRit3")]
        public GlyphDefinition BeamAccelRit3 { get; set; }

        [DataMember(Name="beamAccelRit4")]
        public GlyphDefinition BeamAccelRit4 { get; set; }

        [DataMember(Name="beamAccelRit5")]
        public GlyphDefinition BeamAccelRit5 { get; set; }

        [DataMember(Name="beamAccelRit6")]
        public GlyphDefinition BeamAccelRit6 { get; set; }

        [DataMember(Name="beamAccelRit7")]
        public GlyphDefinition BeamAccelRit7 { get; set; }

        [DataMember(Name="beamAccelRit8")]
        public GlyphDefinition BeamAccelRit8 { get; set; }

        [DataMember(Name="beamAccelRit9")]
        public GlyphDefinition BeamAccelRit9 { get; set; }

        [DataMember(Name="beamAccelRitFinal")]
        public GlyphDefinition BeamAccelRitFinal { get; set; }

        [DataMember(Name="brace")]
        public GlyphDefinition Brace { get; set; }

        [DataMember(Name="bracket")]
        public GlyphDefinition Bracket { get; set; }

        [DataMember(Name="bracketBottom")]
        public GlyphDefinition BracketBottom { get; set; }

        [DataMember(Name="bracketTop")]
        public GlyphDefinition BracketTop { get; set; }

        [DataMember(Name="brassBend")]
        public GlyphDefinition BrassBend { get; set; }

        [DataMember(Name="brassDoitLong")]
        public GlyphDefinition BrassDoitLong { get; set; }

        [DataMember(Name="brassDoitMedium")]
        public GlyphDefinition BrassDoitMedium { get; set; }

        [DataMember(Name="brassDoitShort")]
        public GlyphDefinition BrassDoitShort { get; set; }

        [DataMember(Name="brassFallLipLong")]
        public GlyphDefinition BrassFallLipLong { get; set; }

        [DataMember(Name="brassFallLipMedium")]
        public GlyphDefinition BrassFallLipMedium { get; set; }

        [DataMember(Name="brassFallLipShort")]
        public GlyphDefinition BrassFallLipShort { get; set; }

        [DataMember(Name="brassFallRoughLong")]
        public GlyphDefinition BrassFallRoughLong { get; set; }

        [DataMember(Name="brassFallRoughMedium")]
        public GlyphDefinition BrassFallRoughMedium { get; set; }

        [DataMember(Name="brassFallRoughShort")]
        public GlyphDefinition BrassFallRoughShort { get; set; }

        [DataMember(Name="brassFallSmoothLong")]
        public GlyphDefinition BrassFallSmoothLong { get; set; }

        [DataMember(Name="brassFallSmoothMedium")]
        public GlyphDefinition BrassFallSmoothMedium { get; set; }

        [DataMember(Name="brassFallSmoothShort")]
        public GlyphDefinition BrassFallSmoothShort { get; set; }

        [DataMember(Name="brassFlip")]
        public GlyphDefinition BrassFlip { get; set; }

        [DataMember(Name="brassHarmonMuteClosed")]
        public GlyphDefinition BrassHarmonMuteClosed { get; set; }

        [DataMember(Name="brassHarmonMuteStemHalfLeft")]
        public GlyphDefinition BrassHarmonMuteStemHalfLeft { get; set; }

        [DataMember(Name="brassHarmonMuteStemHalfRight")]
        public GlyphDefinition BrassHarmonMuteStemHalfRight { get; set; }

        [DataMember(Name="brassHarmonMuteStemOpen")]
        public GlyphDefinition BrassHarmonMuteStemOpen { get; set; }

        [DataMember(Name="brassJazzTurn")]
        public GlyphDefinition BrassJazzTurn { get; set; }

        [DataMember(Name="brassLiftLong")]
        public GlyphDefinition BrassLiftLong { get; set; }

        [DataMember(Name="brassLiftMedium")]
        public GlyphDefinition BrassLiftMedium { get; set; }

        [DataMember(Name="brassLiftShort")]
        public GlyphDefinition BrassLiftShort { get; set; }

        [DataMember(Name="brassLiftSmoothLong")]
        public GlyphDefinition BrassLiftSmoothLong { get; set; }

        [DataMember(Name="brassLiftSmoothMedium")]
        public GlyphDefinition BrassLiftSmoothMedium { get; set; }

        [DataMember(Name="brassLiftSmoothShort")]
        public GlyphDefinition BrassLiftSmoothShort { get; set; }

        [DataMember(Name="brassMuteClosed")]
        public GlyphDefinition BrassMuteClosed { get; set; }

        [DataMember(Name="brassMuteHalfClosed")]
        public GlyphDefinition BrassMuteHalfClosed { get; set; }

        [DataMember(Name="brassMuteOpen")]
        public GlyphDefinition BrassMuteOpen { get; set; }

        [DataMember(Name="brassPlop")]
        public GlyphDefinition BrassPlop { get; set; }

        [DataMember(Name="brassScoop")]
        public GlyphDefinition BrassScoop { get; set; }

        [DataMember(Name="brassSmear")]
        public GlyphDefinition BrassSmear { get; set; }

        [DataMember(Name="breathMarkComma")]
        public GlyphDefinition BreathMarkComma { get; set; }

        [DataMember(Name="breathMarkSalzedo")]
        public GlyphDefinition BreathMarkSalzedo { get; set; }

        [DataMember(Name="breathMarkTick")]
        public GlyphDefinition BreathMarkTick { get; set; }

        [DataMember(Name="breathMarkUpbow")]
        public GlyphDefinition BreathMarkUpbow { get; set; }

        [DataMember(Name="bridgeClef")]
        public GlyphDefinition BridgeClef { get; set; }

        [DataMember(Name="buzzRoll")]
        public GlyphDefinition BuzzRoll { get; set; }

        [DataMember(Name="cClef")]
        public GlyphDefinition CClef { get; set; }

        [DataMember(Name="cClef8vb")]
        public GlyphDefinition CClef8Vb { get; set; }

        [DataMember(Name="cClefArrowDown")]
        public GlyphDefinition CClefArrowDown { get; set; }

        [DataMember(Name="cClefArrowUp")]
        public GlyphDefinition CClefArrowUp { get; set; }

        [DataMember(Name="cClefChange")]
        public GlyphDefinition CClefChange { get; set; }

        [DataMember(Name="cClefCombining")]
        public GlyphDefinition CClefCombining { get; set; }

        [DataMember(Name="cClefReversed")]
        public GlyphDefinition CClefReversed { get; set; }

        [DataMember(Name="cClefSquare")]
        public GlyphDefinition CClefSquare { get; set; }

        [DataMember(Name="cClefTriangular")]
        public GlyphDefinition CClefTriangular { get; set; }

        [DataMember(Name="cClefTriangularToFClef")]
        public GlyphDefinition CClefTriangularToFClef { get; set; }

        [DataMember(Name="caesura")]
        public GlyphDefinition Caesura { get; set; }

        [DataMember(Name="caesuraCurved")]
        public GlyphDefinition CaesuraCurved { get; set; }

        [DataMember(Name="caesuraShort")]
        public GlyphDefinition CaesuraShort { get; set; }

        [DataMember(Name="caesuraThick")]
        public GlyphDefinition CaesuraThick { get; set; }

        [DataMember(Name="chantAccentusAbove")]
        public GlyphDefinition ChantAccentusAbove { get; set; }

        [DataMember(Name="chantAccentusBelow")]
        public GlyphDefinition ChantAccentusBelow { get; set; }

        [DataMember(Name="chantAuctumAsc")]
        public GlyphDefinition ChantAuctumAsc { get; set; }

        [DataMember(Name="chantAuctumDesc")]
        public GlyphDefinition ChantAuctumDesc { get; set; }

        [DataMember(Name="chantAugmentum")]
        public GlyphDefinition ChantAugmentum { get; set; }

        [DataMember(Name="chantCaesura")]
        public GlyphDefinition ChantCaesura { get; set; }

        [DataMember(Name="chantCclef")]
        public GlyphDefinition ChantCclef { get; set; }

        [DataMember(Name="chantCirculusAbove")]
        public GlyphDefinition ChantCirculusAbove { get; set; }

        [DataMember(Name="chantCirculusBelow")]
        public GlyphDefinition ChantCirculusBelow { get; set; }

        [DataMember(Name="chantConnectingLineAsc2nd")]
        public GlyphDefinition ChantConnectingLineAsc2Nd { get; set; }

        [DataMember(Name="chantConnectingLineAsc3rd")]
        public GlyphDefinition ChantConnectingLineAsc3Rd { get; set; }

        [DataMember(Name="chantConnectingLineAsc4th")]
        public GlyphDefinition ChantConnectingLineAsc4Th { get; set; }

        [DataMember(Name="chantConnectingLineAsc5th")]
        public GlyphDefinition ChantConnectingLineAsc5Th { get; set; }

        [DataMember(Name="chantConnectingLineAsc6th")]
        public GlyphDefinition ChantConnectingLineAsc6Th { get; set; }

        [DataMember(Name="chantCustosStemDownPosHigh")]
        public GlyphDefinition ChantCustosStemDownPosHigh { get; set; }

        [DataMember(Name="chantCustosStemDownPosHighest")]
        public GlyphDefinition ChantCustosStemDownPosHighest { get; set; }

        [DataMember(Name="chantCustosStemDownPosMiddle")]
        public GlyphDefinition ChantCustosStemDownPosMiddle { get; set; }

        [DataMember(Name="chantCustosStemUpPosLow")]
        public GlyphDefinition ChantCustosStemUpPosLow { get; set; }

        [DataMember(Name="chantCustosStemUpPosLowest")]
        public GlyphDefinition ChantCustosStemUpPosLowest { get; set; }

        [DataMember(Name="chantCustosStemUpPosMiddle")]
        public GlyphDefinition ChantCustosStemUpPosMiddle { get; set; }

        [DataMember(Name="chantDeminutumLower")]
        public GlyphDefinition ChantDeminutumLower { get; set; }

        [DataMember(Name="chantDeminutumUpper")]
        public GlyphDefinition ChantDeminutumUpper { get; set; }

        [DataMember(Name="chantDivisioFinalis")]
        public GlyphDefinition ChantDivisioFinalis { get; set; }

        [DataMember(Name="chantDivisioMaior")]
        public GlyphDefinition ChantDivisioMaior { get; set; }

        [DataMember(Name="chantDivisioMaxima")]
        public GlyphDefinition ChantDivisioMaxima { get; set; }

        [DataMember(Name="chantDivisioMinima")]
        public GlyphDefinition ChantDivisioMinima { get; set; }

        [DataMember(Name="chantEntryLineAsc2nd")]
        public GlyphDefinition ChantEntryLineAsc2Nd { get; set; }

        [DataMember(Name="chantEntryLineAsc3rd")]
        public GlyphDefinition ChantEntryLineAsc3Rd { get; set; }

        [DataMember(Name="chantEntryLineAsc4th")]
        public GlyphDefinition ChantEntryLineAsc4Th { get; set; }

        [DataMember(Name="chantEntryLineAsc5th")]
        public GlyphDefinition ChantEntryLineAsc5Th { get; set; }

        [DataMember(Name="chantEntryLineAsc6th")]
        public GlyphDefinition ChantEntryLineAsc6Th { get; set; }

        [DataMember(Name="chantEpisema")]
        public GlyphDefinition ChantEpisema { get; set; }

        [DataMember(Name="chantFclef")]
        public GlyphDefinition ChantFclef { get; set; }

        [DataMember(Name="chantIctusAbove")]
        public GlyphDefinition ChantIctusAbove { get; set; }

        [DataMember(Name="chantIctusBelow")]
        public GlyphDefinition ChantIctusBelow { get; set; }

        [DataMember(Name="chantLigaturaDesc2nd")]
        public GlyphDefinition ChantLigaturaDesc2Nd { get; set; }

        [DataMember(Name="chantLigaturaDesc3rd")]
        public GlyphDefinition ChantLigaturaDesc3Rd { get; set; }

        [DataMember(Name="chantLigaturaDesc4th")]
        public GlyphDefinition ChantLigaturaDesc4Th { get; set; }

        [DataMember(Name="chantLigaturaDesc5th")]
        public GlyphDefinition ChantLigaturaDesc5Th { get; set; }

        [DataMember(Name="chantOriscusAscending")]
        public GlyphDefinition ChantOriscusAscending { get; set; }

        [DataMember(Name="chantOriscusDescending")]
        public GlyphDefinition ChantOriscusDescending { get; set; }

        [DataMember(Name="chantOriscusLiquescens")]
        public GlyphDefinition ChantOriscusLiquescens { get; set; }

        [DataMember(Name="chantPodatusLower")]
        public GlyphDefinition ChantPodatusLower { get; set; }

        [DataMember(Name="chantPodatusUpper")]
        public GlyphDefinition ChantPodatusUpper { get; set; }

        [DataMember(Name="chantPunctum")]
        public GlyphDefinition ChantPunctum { get; set; }

        [DataMember(Name="chantPunctumCavum")]
        public GlyphDefinition ChantPunctumCavum { get; set; }

        [DataMember(Name="chantPunctumDeminutum")]
        public GlyphDefinition ChantPunctumDeminutum { get; set; }

        [DataMember(Name="chantPunctumInclinatum")]
        public GlyphDefinition ChantPunctumInclinatum { get; set; }

        [DataMember(Name="chantPunctumInclinatumAuctum")]
        public GlyphDefinition ChantPunctumInclinatumAuctum { get; set; }

        [DataMember(Name="chantPunctumInclinatumDeminutum")]
        public GlyphDefinition ChantPunctumInclinatumDeminutum { get; set; }

        [DataMember(Name="chantPunctumLinea")]
        public GlyphDefinition ChantPunctumLinea { get; set; }

        [DataMember(Name="chantPunctumLineaCavum")]
        public GlyphDefinition ChantPunctumLineaCavum { get; set; }

        [DataMember(Name="chantPunctumVirga")]
        public GlyphDefinition ChantPunctumVirga { get; set; }

        [DataMember(Name="chantPunctumVirgaReversed")]
        public GlyphDefinition ChantPunctumVirgaReversed { get; set; }

        [DataMember(Name="chantQuilisma")]
        public GlyphDefinition ChantQuilisma { get; set; }

        [DataMember(Name="chantSemicirculusAbove")]
        public GlyphDefinition ChantSemicirculusAbove { get; set; }

        [DataMember(Name="chantSemicirculusBelow")]
        public GlyphDefinition ChantSemicirculusBelow { get; set; }

        [DataMember(Name="chantStaff")]
        public GlyphDefinition ChantStaff { get; set; }

        [DataMember(Name="chantStaffNarrow")]
        public GlyphDefinition ChantStaffNarrow { get; set; }

        [DataMember(Name="chantStaffWide")]
        public GlyphDefinition ChantStaffWide { get; set; }

        [DataMember(Name="chantStrophicus")]
        public GlyphDefinition ChantStrophicus { get; set; }

        [DataMember(Name="chantStrophicusAuctus")]
        public GlyphDefinition ChantStrophicusAuctus { get; set; }

        [DataMember(Name="chantStrophicusLiquescens2nd")]
        public GlyphDefinition ChantStrophicusLiquescens2Nd { get; set; }

        [DataMember(Name="chantStrophicusLiquescens3rd")]
        public GlyphDefinition ChantStrophicusLiquescens3Rd { get; set; }

        [DataMember(Name="chantStrophicusLiquescens4th")]
        public GlyphDefinition ChantStrophicusLiquescens4Th { get; set; }

        [DataMember(Name="chantStrophicusLiquescens5th")]
        public GlyphDefinition ChantStrophicusLiquescens5Th { get; set; }

        [DataMember(Name="chantVirgula")]
        public GlyphDefinition ChantVirgula { get; set; }

        [DataMember(Name="clef15")]
        public GlyphDefinition Clef15 { get; set; }

        [DataMember(Name="clef8")]
        public GlyphDefinition Clef8 { get; set; }

        [DataMember(Name="clefChangeCombining")]
        public GlyphDefinition ClefChangeCombining { get; set; }

        [DataMember(Name="coda")]
        public GlyphDefinition Coda { get; set; }

        [DataMember(Name="codaSquare")]
        public GlyphDefinition CodaSquare { get; set; }

        [DataMember(Name="conductorBeat2Compound")]
        public GlyphDefinition ConductorBeat2Compound { get; set; }

        [DataMember(Name="conductorBeat2Simple")]
        public GlyphDefinition ConductorBeat2Simple { get; set; }

        [DataMember(Name="conductorBeat3Compound")]
        public GlyphDefinition ConductorBeat3Compound { get; set; }

        [DataMember(Name="conductorBeat3Simple")]
        public GlyphDefinition ConductorBeat3Simple { get; set; }

        [DataMember(Name="conductorBeat4Compound")]
        public GlyphDefinition ConductorBeat4Compound { get; set; }

        [DataMember(Name="conductorBeat4Simple")]
        public GlyphDefinition ConductorBeat4Simple { get; set; }

        [DataMember(Name="conductorLeftBeat")]
        public GlyphDefinition ConductorLeftBeat { get; set; }

        [DataMember(Name="conductorRightBeat")]
        public GlyphDefinition ConductorRightBeat { get; set; }

        [DataMember(Name="conductorStrongBeat")]
        public GlyphDefinition ConductorStrongBeat { get; set; }

        [DataMember(Name="conductorWeakBeat")]
        public GlyphDefinition ConductorWeakBeat { get; set; }

        [DataMember(Name="controlBeginBeam")]
        public GlyphDefinition ControlBeginBeam { get; set; }

        [DataMember(Name="controlBeginPhrase")]
        public GlyphDefinition ControlBeginPhrase { get; set; }

        [DataMember(Name="controlBeginSlur")]
        public GlyphDefinition ControlBeginSlur { get; set; }

        [DataMember(Name="controlBeginTie")]
        public GlyphDefinition ControlBeginTie { get; set; }

        [DataMember(Name="controlEndBeam")]
        public GlyphDefinition ControlEndBeam { get; set; }

        [DataMember(Name="controlEndPhrase")]
        public GlyphDefinition ControlEndPhrase { get; set; }

        [DataMember(Name="controlEndSlur")]
        public GlyphDefinition ControlEndSlur { get; set; }

        [DataMember(Name="controlEndTie")]
        public GlyphDefinition ControlEndTie { get; set; }

        [DataMember(Name="csymAugmented")]
        public GlyphDefinition CsymAugmented { get; set; }

        [DataMember(Name="csymBracketLeftTall")]
        public GlyphDefinition CsymBracketLeftTall { get; set; }

        [DataMember(Name="csymBracketRightTall")]
        public GlyphDefinition CsymBracketRightTall { get; set; }

        [DataMember(Name="csymDiminished")]
        public GlyphDefinition CsymDiminished { get; set; }

        [DataMember(Name="csymHalfDiminished")]
        public GlyphDefinition CsymHalfDiminished { get; set; }

        [DataMember(Name="csymMajorSeventh")]
        public GlyphDefinition CsymMajorSeventh { get; set; }

        [DataMember(Name="csymMinor")]
        public GlyphDefinition CsymMinor { get; set; }

        [DataMember(Name="csymParensLeftTall")]
        public GlyphDefinition CsymParensLeftTall { get; set; }

        [DataMember(Name="csymParensRightTall")]
        public GlyphDefinition CsymParensRightTall { get; set; }

        [DataMember(Name="curlewSign")]
        public GlyphDefinition CurlewSign { get; set; }

        [DataMember(Name="daCapo")]
        public GlyphDefinition DaCapo { get; set; }

        [DataMember(Name="dalSegno")]
        public GlyphDefinition DalSegno { get; set; }

        [DataMember(Name="daseianExcellentes1")]
        public GlyphDefinition DaseianExcellentes1 { get; set; }

        [DataMember(Name="daseianExcellentes2")]
        public GlyphDefinition DaseianExcellentes2 { get; set; }

        [DataMember(Name="daseianExcellentes3")]
        public GlyphDefinition DaseianExcellentes3 { get; set; }

        [DataMember(Name="daseianExcellentes4")]
        public GlyphDefinition DaseianExcellentes4 { get; set; }

        [DataMember(Name="daseianFinales1")]
        public GlyphDefinition DaseianFinales1 { get; set; }

        [DataMember(Name="daseianFinales2")]
        public GlyphDefinition DaseianFinales2 { get; set; }

        [DataMember(Name="daseianFinales3")]
        public GlyphDefinition DaseianFinales3 { get; set; }

        [DataMember(Name="daseianFinales4")]
        public GlyphDefinition DaseianFinales4 { get; set; }

        [DataMember(Name="daseianGraves1")]
        public GlyphDefinition DaseianGraves1 { get; set; }

        [DataMember(Name="daseianGraves2")]
        public GlyphDefinition DaseianGraves2 { get; set; }

        [DataMember(Name="daseianGraves3")]
        public GlyphDefinition DaseianGraves3 { get; set; }

        [DataMember(Name="daseianGraves4")]
        public GlyphDefinition DaseianGraves4 { get; set; }

        [DataMember(Name="daseianResidua1")]
        public GlyphDefinition DaseianResidua1 { get; set; }

        [DataMember(Name="daseianResidua2")]
        public GlyphDefinition DaseianResidua2 { get; set; }

        [DataMember(Name="daseianSuperiores1")]
        public GlyphDefinition DaseianSuperiores1 { get; set; }

        [DataMember(Name="daseianSuperiores2")]
        public GlyphDefinition DaseianSuperiores2 { get; set; }

        [DataMember(Name="daseianSuperiores3")]
        public GlyphDefinition DaseianSuperiores3 { get; set; }

        [DataMember(Name="daseianSuperiores4")]
        public GlyphDefinition DaseianSuperiores4 { get; set; }

        [DataMember(Name="doubleTongueAbove")]
        public GlyphDefinition DoubleTongueAbove { get; set; }

        [DataMember(Name="doubleTongueBelow")]
        public GlyphDefinition DoubleTongueBelow { get; set; }

        [DataMember(Name="dynamicCrescendoHairpin")]
        public GlyphDefinition DynamicCrescendoHairpin { get; set; }

        [DataMember(Name="dynamicDiminuendoHairpin")]
        public GlyphDefinition DynamicDiminuendoHairpin { get; set; }

        [DataMember(Name="dynamicFF")]
        public GlyphDefinition DynamicFf { get; set; }

        [DataMember(Name="dynamicFFF")]
        public GlyphDefinition DynamicFff { get; set; }

        [DataMember(Name="dynamicFFFF")]
        public GlyphDefinition DynamicFfff { get; set; }

        [DataMember(Name="dynamicFFFFF")]
        public GlyphDefinition DynamicFffff { get; set; }

        [DataMember(Name="dynamicFFFFFF")]
        public GlyphDefinition DynamicFfffff { get; set; }

        [DataMember(Name="dynamicForte")]
        public GlyphDefinition DynamicForte { get; set; }

        [DataMember(Name="dynamicFortePiano")]
        public GlyphDefinition DynamicFortePiano { get; set; }

        [DataMember(Name="dynamicForzando")]
        public GlyphDefinition DynamicForzando { get; set; }

        [DataMember(Name="dynamicMF")]
        public GlyphDefinition DynamicMf { get; set; }

        [DataMember(Name="dynamicMP")]
        public GlyphDefinition DynamicMp { get; set; }

        [DataMember(Name="dynamicMessaDiVoce")]
        public GlyphDefinition DynamicMessaDiVoce { get; set; }

        [DataMember(Name="dynamicMezzo")]
        public GlyphDefinition DynamicMezzo { get; set; }

        [DataMember(Name="dynamicNiente")]
        public GlyphDefinition DynamicNiente { get; set; }

        [DataMember(Name="dynamicNienteForHairpin")]
        public GlyphDefinition DynamicNienteForHairpin { get; set; }

        [DataMember(Name="dynamicPF")]
        public GlyphDefinition DynamicPf { get; set; }

        [DataMember(Name="dynamicPP")]
        public GlyphDefinition DynamicPp { get; set; }

        [DataMember(Name="dynamicPPP")]
        public GlyphDefinition DynamicPpp { get; set; }

        [DataMember(Name="dynamicPPPP")]
        public GlyphDefinition DynamicPppp { get; set; }

        [DataMember(Name="dynamicPPPPP")]
        public GlyphDefinition DynamicPpppp { get; set; }

        [DataMember(Name="dynamicPPPPPP")]
        public GlyphDefinition DynamicPppppp { get; set; }

        [DataMember(Name="dynamicPiano")]
        public GlyphDefinition DynamicPiano { get; set; }

        [DataMember(Name="dynamicRinforzando")]
        public GlyphDefinition DynamicRinforzando { get; set; }

        [DataMember(Name="dynamicRinforzando1")]
        public GlyphDefinition DynamicRinforzando1 { get; set; }

        [DataMember(Name="dynamicRinforzando2")]
        public GlyphDefinition DynamicRinforzando2 { get; set; }

        [DataMember(Name="dynamicSforzando")]
        public GlyphDefinition DynamicSforzando { get; set; }

        [DataMember(Name="dynamicSforzando1")]
        public GlyphDefinition DynamicSforzando1 { get; set; }

        [DataMember(Name="dynamicSforzandoPianissimo")]
        public GlyphDefinition DynamicSforzandoPianissimo { get; set; }

        [DataMember(Name="dynamicSforzandoPiano")]
        public GlyphDefinition DynamicSforzandoPiano { get; set; }

        [DataMember(Name="dynamicSforzato")]
        public GlyphDefinition DynamicSforzato { get; set; }

        [DataMember(Name="dynamicSforzatoFF")]
        public GlyphDefinition DynamicSforzatoFf { get; set; }

        [DataMember(Name="dynamicSforzatoPiano")]
        public GlyphDefinition DynamicSforzatoPiano { get; set; }

        [DataMember(Name="dynamicZ")]
        public GlyphDefinition DynamicZ { get; set; }

        [DataMember(Name="elecAudioChannelsEight")]
        public GlyphDefinition ElecAudioChannelsEight { get; set; }

        [DataMember(Name="elecAudioChannelsFive")]
        public GlyphDefinition ElecAudioChannelsFive { get; set; }

        [DataMember(Name="elecAudioChannelsFour")]
        public GlyphDefinition ElecAudioChannelsFour { get; set; }

        [DataMember(Name="elecAudioChannelsOne")]
        public GlyphDefinition ElecAudioChannelsOne { get; set; }

        [DataMember(Name="elecAudioChannelsSeven")]
        public GlyphDefinition ElecAudioChannelsSeven { get; set; }

        [DataMember(Name="elecAudioChannelsSix")]
        public GlyphDefinition ElecAudioChannelsSix { get; set; }

        [DataMember(Name="elecAudioChannelsThreeFrontal")]
        public GlyphDefinition ElecAudioChannelsThreeFrontal { get; set; }

        [DataMember(Name="elecAudioChannelsThreeSurround")]
        public GlyphDefinition ElecAudioChannelsThreeSurround { get; set; }

        [DataMember(Name="elecAudioChannelsTwo")]
        public GlyphDefinition ElecAudioChannelsTwo { get; set; }

        [DataMember(Name="elecAudioIn")]
        public GlyphDefinition ElecAudioIn { get; set; }

        [DataMember(Name="elecAudioMono")]
        public GlyphDefinition ElecAudioMono { get; set; }

        [DataMember(Name="elecAudioOut")]
        public GlyphDefinition ElecAudioOut { get; set; }

        [DataMember(Name="elecAudioStereo")]
        public GlyphDefinition ElecAudioStereo { get; set; }

        [DataMember(Name="elecCamera")]
        public GlyphDefinition ElecCamera { get; set; }

        [DataMember(Name="elecDataIn")]
        public GlyphDefinition ElecDataIn { get; set; }

        [DataMember(Name="elecDataOut")]
        public GlyphDefinition ElecDataOut { get; set; }

        [DataMember(Name="elecDisc")]
        public GlyphDefinition ElecDisc { get; set; }

        [DataMember(Name="elecDownload")]
        public GlyphDefinition ElecDownload { get; set; }

        [DataMember(Name="elecEject")]
        public GlyphDefinition ElecEject { get; set; }

        [DataMember(Name="elecFastForward")]
        public GlyphDefinition ElecFastForward { get; set; }

        [DataMember(Name="elecHeadphones")]
        public GlyphDefinition ElecHeadphones { get; set; }

        [DataMember(Name="elecHeadset")]
        public GlyphDefinition ElecHeadset { get; set; }

        [DataMember(Name="elecLineIn")]
        public GlyphDefinition ElecLineIn { get; set; }

        [DataMember(Name="elecLineOut")]
        public GlyphDefinition ElecLineOut { get; set; }

        [DataMember(Name="elecLoop")]
        public GlyphDefinition ElecLoop { get; set; }

        [DataMember(Name="elecLoudspeaker")]
        public GlyphDefinition ElecLoudspeaker { get; set; }

        [DataMember(Name="elecMIDIController0")]
        public GlyphDefinition ElecMidiController0 { get; set; }

        [DataMember(Name="elecMIDIController100")]
        public GlyphDefinition ElecMidiController100 { get; set; }

        [DataMember(Name="elecMIDIController20")]
        public GlyphDefinition ElecMidiController20 { get; set; }

        [DataMember(Name="elecMIDIController40")]
        public GlyphDefinition ElecMidiController40 { get; set; }

        [DataMember(Name="elecMIDIController60")]
        public GlyphDefinition ElecMidiController60 { get; set; }

        [DataMember(Name="elecMIDIController80")]
        public GlyphDefinition ElecMidiController80 { get; set; }

        [DataMember(Name="elecMIDIIn")]
        public GlyphDefinition ElecMidiIn { get; set; }

        [DataMember(Name="elecMIDIOut")]
        public GlyphDefinition ElecMidiOut { get; set; }

        [DataMember(Name="elecMicrophone")]
        public GlyphDefinition ElecMicrophone { get; set; }

        [DataMember(Name="elecMicrophoneMute")]
        public GlyphDefinition ElecMicrophoneMute { get; set; }

        [DataMember(Name="elecMicrophoneUnmute")]
        public GlyphDefinition ElecMicrophoneUnmute { get; set; }

        [DataMember(Name="elecMixingConsole")]
        public GlyphDefinition ElecMixingConsole { get; set; }

        [DataMember(Name="elecMonitor")]
        public GlyphDefinition ElecMonitor { get; set; }

        [DataMember(Name="elecMute")]
        public GlyphDefinition ElecMute { get; set; }

        [DataMember(Name="elecPause")]
        public GlyphDefinition ElecPause { get; set; }

        [DataMember(Name="elecPlay")]
        public GlyphDefinition ElecPlay { get; set; }

        [DataMember(Name="elecPowerOnOff")]
        public GlyphDefinition ElecPowerOnOff { get; set; }

        [DataMember(Name="elecProjector")]
        public GlyphDefinition ElecProjector { get; set; }

        [DataMember(Name="elecReplay")]
        public GlyphDefinition ElecReplay { get; set; }

        [DataMember(Name="elecRewind")]
        public GlyphDefinition ElecRewind { get; set; }

        [DataMember(Name="elecShuffle")]
        public GlyphDefinition ElecShuffle { get; set; }

        [DataMember(Name="elecSkipBackwards")]
        public GlyphDefinition ElecSkipBackwards { get; set; }

        [DataMember(Name="elecSkipForwards")]
        public GlyphDefinition ElecSkipForwards { get; set; }

        [DataMember(Name="elecStop")]
        public GlyphDefinition ElecStop { get; set; }

        [DataMember(Name="elecTape")]
        public GlyphDefinition ElecTape { get; set; }

        [DataMember(Name="elecUSB")]
        public GlyphDefinition ElecUsb { get; set; }

        [DataMember(Name="elecUnmute")]
        public GlyphDefinition ElecUnmute { get; set; }

        [DataMember(Name="elecUpload")]
        public GlyphDefinition ElecUpload { get; set; }

        [DataMember(Name="elecVideoCamera")]
        public GlyphDefinition ElecVideoCamera { get; set; }

        [DataMember(Name="elecVideoIn")]
        public GlyphDefinition ElecVideoIn { get; set; }

        [DataMember(Name="elecVideoOut")]
        public GlyphDefinition ElecVideoOut { get; set; }

        [DataMember(Name="elecVolumeFader")]
        public GlyphDefinition ElecVolumeFader { get; set; }

        [DataMember(Name="elecVolumeFaderThumb")]
        public GlyphDefinition ElecVolumeFaderThumb { get; set; }

        [DataMember(Name="elecVolumeLevel0")]
        public GlyphDefinition ElecVolumeLevel0 { get; set; }

        [DataMember(Name="elecVolumeLevel100")]
        public GlyphDefinition ElecVolumeLevel100 { get; set; }

        [DataMember(Name="elecVolumeLevel20")]
        public GlyphDefinition ElecVolumeLevel20 { get; set; }

        [DataMember(Name="elecVolumeLevel40")]
        public GlyphDefinition ElecVolumeLevel40 { get; set; }

        [DataMember(Name="elecVolumeLevel60")]
        public GlyphDefinition ElecVolumeLevel60 { get; set; }

        [DataMember(Name="elecVolumeLevel80")]
        public GlyphDefinition ElecVolumeLevel80 { get; set; }

        [DataMember(Name="fClef")]
        public GlyphDefinition FClef { get; set; }

        [DataMember(Name="fClef15ma")]
        public GlyphDefinition FClef15Ma { get; set; }

        [DataMember(Name="fClef15mb")]
        public GlyphDefinition FClef15Mb { get; set; }

        [DataMember(Name="fClef8va")]
        public GlyphDefinition FClef8Va { get; set; }

        [DataMember(Name="fClef8vb")]
        public GlyphDefinition FClef8Vb { get; set; }

        [DataMember(Name="fClefArrowDown")]
        public GlyphDefinition FClefArrowDown { get; set; }

        [DataMember(Name="fClefArrowUp")]
        public GlyphDefinition FClefArrowUp { get; set; }

        [DataMember(Name="fClefChange")]
        public GlyphDefinition FClefChange { get; set; }

        [DataMember(Name="fClefReversed")]
        public GlyphDefinition FClefReversed { get; set; }

        [DataMember(Name="fClefTriangular")]
        public GlyphDefinition FClefTriangular { get; set; }

        [DataMember(Name="fClefTriangularToCClef")]
        public GlyphDefinition FClefTriangularToCClef { get; set; }

        [DataMember(Name="fClefTurned")]
        public GlyphDefinition FClefTurned { get; set; }

        [DataMember(Name="fermataAbove")]
        public GlyphDefinition FermataAbove { get; set; }

        [DataMember(Name="fermataBelow")]
        public GlyphDefinition FermataBelow { get; set; }

        [DataMember(Name="fermataLongAbove")]
        public GlyphDefinition FermataLongAbove { get; set; }

        [DataMember(Name="fermataLongBelow")]
        public GlyphDefinition FermataLongBelow { get; set; }

        [DataMember(Name="fermataLongHenzeAbove")]
        public GlyphDefinition FermataLongHenzeAbove { get; set; }

        [DataMember(Name="fermataLongHenzeBelow")]
        public GlyphDefinition FermataLongHenzeBelow { get; set; }

        [DataMember(Name="fermataShortAbove")]
        public GlyphDefinition FermataShortAbove { get; set; }

        [DataMember(Name="fermataShortBelow")]
        public GlyphDefinition FermataShortBelow { get; set; }

        [DataMember(Name="fermataShortHenzeAbove")]
        public GlyphDefinition FermataShortHenzeAbove { get; set; }

        [DataMember(Name="fermataShortHenzeBelow")]
        public GlyphDefinition FermataShortHenzeBelow { get; set; }

        [DataMember(Name="fermataVeryLongAbove")]
        public GlyphDefinition FermataVeryLongAbove { get; set; }

        [DataMember(Name="fermataVeryLongBelow")]
        public GlyphDefinition FermataVeryLongBelow { get; set; }

        [DataMember(Name="fermataVeryShortAbove")]
        public GlyphDefinition FermataVeryShortAbove { get; set; }

        [DataMember(Name="fermataVeryShortBelow")]
        public GlyphDefinition FermataVeryShortBelow { get; set; }

        [DataMember(Name="figbass0")]
        public GlyphDefinition Figbass0 { get; set; }

        [DataMember(Name="figbass1")]
        public GlyphDefinition Figbass1 { get; set; }

        [DataMember(Name="figbass2")]
        public GlyphDefinition Figbass2 { get; set; }

        [DataMember(Name="figbass2Raised")]
        public GlyphDefinition Figbass2Raised { get; set; }

        [DataMember(Name="figbass3")]
        public GlyphDefinition Figbass3 { get; set; }

        [DataMember(Name="figbass4")]
        public GlyphDefinition Figbass4 { get; set; }

        [DataMember(Name="figbass4Raised")]
        public GlyphDefinition Figbass4Raised { get; set; }

        [DataMember(Name="figbass5")]
        public GlyphDefinition Figbass5 { get; set; }

        [DataMember(Name="figbass5Raised1")]
        public GlyphDefinition Figbass5Raised1 { get; set; }

        [DataMember(Name="figbass5Raised2")]
        public GlyphDefinition Figbass5Raised2 { get; set; }

        [DataMember(Name="figbass5Raised3")]
        public GlyphDefinition Figbass5Raised3 { get; set; }

        [DataMember(Name="figbass6")]
        public GlyphDefinition Figbass6 { get; set; }

        [DataMember(Name="figbass6Raised")]
        public GlyphDefinition Figbass6Raised { get; set; }

        [DataMember(Name="figbass7")]
        public GlyphDefinition Figbass7 { get; set; }

        [DataMember(Name="figbass7Raised1")]
        public GlyphDefinition Figbass7Raised1 { get; set; }

        [DataMember(Name="figbass7Raised2")]
        public GlyphDefinition Figbass7Raised2 { get; set; }

        [DataMember(Name="figbass8")]
        public GlyphDefinition Figbass8 { get; set; }

        [DataMember(Name="figbass9")]
        public GlyphDefinition Figbass9 { get; set; }

        [DataMember(Name="figbass9Raised")]
        public GlyphDefinition Figbass9Raised { get; set; }

        [DataMember(Name="figbassBracketLeft")]
        public GlyphDefinition FigbassBracketLeft { get; set; }

        [DataMember(Name="figbassBracketRight")]
        public GlyphDefinition FigbassBracketRight { get; set; }

        [DataMember(Name="figbassCombiningLowering")]
        public GlyphDefinition FigbassCombiningLowering { get; set; }

        [DataMember(Name="figbassCombiningRaising")]
        public GlyphDefinition FigbassCombiningRaising { get; set; }

        [DataMember(Name="figbassDoubleFlat")]
        public GlyphDefinition FigbassDoubleFlat { get; set; }

        [DataMember(Name="figbassDoubleSharp")]
        public GlyphDefinition FigbassDoubleSharp { get; set; }

        [DataMember(Name="figbassFlat")]
        public GlyphDefinition FigbassFlat { get; set; }

        [DataMember(Name="figbassNatural")]
        public GlyphDefinition FigbassNatural { get; set; }

        [DataMember(Name="figbassParensLeft")]
        public GlyphDefinition FigbassParensLeft { get; set; }

        [DataMember(Name="figbassParensRight")]
        public GlyphDefinition FigbassParensRight { get; set; }

        [DataMember(Name="figbassPlus")]
        public GlyphDefinition FigbassPlus { get; set; }

        [DataMember(Name="figbassSharp")]
        public GlyphDefinition FigbassSharp { get; set; }

        [DataMember(Name="flag1024thDown")]
        public GlyphDefinition Flag1024ThDown { get; set; }

        [DataMember(Name="flag1024thUp")]
        public GlyphDefinition Flag1024ThUp { get; set; }

        [DataMember(Name="flag128thDown")]
        public GlyphDefinition Flag128ThDown { get; set; }

        [DataMember(Name="flag128thUp")]
        public GlyphDefinition Flag128ThUp { get; set; }

        [DataMember(Name="flag16thDown")]
        public GlyphDefinition Flag16ThDown { get; set; }

        [DataMember(Name="flag16thUp")]
        public GlyphDefinition Flag16ThUp { get; set; }

        [DataMember(Name="flag256thDown")]
        public GlyphDefinition Flag256ThDown { get; set; }

        [DataMember(Name="flag256thUp")]
        public GlyphDefinition Flag256ThUp { get; set; }

        [DataMember(Name="flag32ndDown")]
        public GlyphDefinition Flag32NdDown { get; set; }

        [DataMember(Name="flag32ndUp")]
        public GlyphDefinition Flag32NdUp { get; set; }

        [DataMember(Name="flag512thDown")]
        public GlyphDefinition Flag512ThDown { get; set; }

        [DataMember(Name="flag512thUp")]
        public GlyphDefinition Flag512ThUp { get; set; }

        [DataMember(Name="flag64thDown")]
        public GlyphDefinition Flag64ThDown { get; set; }

        [DataMember(Name="flag64thUp")]
        public GlyphDefinition Flag64ThUp { get; set; }

        [DataMember(Name="flag8thDown")]
        public GlyphDefinition Flag8ThDown { get; set; }

        [DataMember(Name="flag8thUp")]
        public GlyphDefinition Flag8ThUp { get; set; }

        [DataMember(Name="flagInternalDown")]
        public GlyphDefinition FlagInternalDown { get; set; }

        [DataMember(Name="flagInternalUp")]
        public GlyphDefinition FlagInternalUp { get; set; }

        [DataMember(Name="fretboard3String")]
        public GlyphDefinition Fretboard3String { get; set; }

        [DataMember(Name="fretboard3StringNut")]
        public GlyphDefinition Fretboard3StringNut { get; set; }

        [DataMember(Name="fretboard4String")]
        public GlyphDefinition Fretboard4String { get; set; }

        [DataMember(Name="fretboard4StringNut")]
        public GlyphDefinition Fretboard4StringNut { get; set; }

        [DataMember(Name="fretboard5String")]
        public GlyphDefinition Fretboard5String { get; set; }

        [DataMember(Name="fretboard5StringNut")]
        public GlyphDefinition Fretboard5StringNut { get; set; }

        [DataMember(Name="fretboard6String")]
        public GlyphDefinition Fretboard6String { get; set; }

        [DataMember(Name="fretboard6StringNut")]
        public GlyphDefinition Fretboard6StringNut { get; set; }

        [DataMember(Name="fretboardFilledCircle")]
        public GlyphDefinition FretboardFilledCircle { get; set; }

        [DataMember(Name="fretboardO")]
        public GlyphDefinition FretboardO { get; set; }

        [DataMember(Name="fretboardX")]
        public GlyphDefinition FretboardX { get; set; }

        [DataMember(Name="functionAngleLeft")]
        public GlyphDefinition FunctionAngleLeft { get; set; }

        [DataMember(Name="functionAngleRight")]
        public GlyphDefinition FunctionAngleRight { get; set; }

        [DataMember(Name="functionBracketLeft")]
        public GlyphDefinition FunctionBracketLeft { get; set; }

        [DataMember(Name="functionBracketRight")]
        public GlyphDefinition FunctionBracketRight { get; set; }

        [DataMember(Name="functionDD")]
        public GlyphDefinition FunctionDd { get; set; }

        [DataMember(Name="functionDLower")]
        public GlyphDefinition FunctionDLower { get; set; }

        [DataMember(Name="functionDUpper")]
        public GlyphDefinition FunctionDUpper { get; set; }

        [DataMember(Name="functionEight")]
        public GlyphDefinition FunctionEight { get; set; }

        [DataMember(Name="functionFive")]
        public GlyphDefinition FunctionFive { get; set; }

        [DataMember(Name="functionFour")]
        public GlyphDefinition FunctionFour { get; set; }

        [DataMember(Name="functionGLower")]
        public GlyphDefinition FunctionGLower { get; set; }

        [DataMember(Name="functionGUpper")]
        public GlyphDefinition FunctionGUpper { get; set; }

        [DataMember(Name="functionGreaterThan")]
        public GlyphDefinition FunctionGreaterThan { get; set; }

        [DataMember(Name="functionLessThan")]
        public GlyphDefinition FunctionLessThan { get; set; }

        [DataMember(Name="functionMinus")]
        public GlyphDefinition FunctionMinus { get; set; }

        [DataMember(Name="functionNLower")]
        public GlyphDefinition FunctionNLower { get; set; }

        [DataMember(Name="functionNUpper")]
        public GlyphDefinition FunctionNUpper { get; set; }

        [DataMember(Name="functionNine")]
        public GlyphDefinition FunctionNine { get; set; }

        [DataMember(Name="functionOne")]
        public GlyphDefinition FunctionOne { get; set; }

        [DataMember(Name="functionPLower")]
        public GlyphDefinition FunctionPLower { get; set; }

        [DataMember(Name="functionPUpper")]
        public GlyphDefinition FunctionPUpper { get; set; }

        [DataMember(Name="functionParensLeft")]
        public GlyphDefinition FunctionParensLeft { get; set; }

        [DataMember(Name="functionParensRight")]
        public GlyphDefinition FunctionParensRight { get; set; }

        [DataMember(Name="functionPlus")]
        public GlyphDefinition FunctionPlus { get; set; }

        [DataMember(Name="functionRepetition1")]
        public GlyphDefinition FunctionRepetition1 { get; set; }

        [DataMember(Name="functionRepetition2")]
        public GlyphDefinition FunctionRepetition2 { get; set; }

        [DataMember(Name="functionRing")]
        public GlyphDefinition FunctionRing { get; set; }

        [DataMember(Name="functionSLower")]
        public GlyphDefinition FunctionSLower { get; set; }

        [DataMember(Name="functionSSLower")]
        public GlyphDefinition FunctionSsLower { get; set; }

        [DataMember(Name="functionSSUpper")]
        public GlyphDefinition FunctionSsUpper { get; set; }

        [DataMember(Name="functionSUpper")]
        public GlyphDefinition FunctionSUpper { get; set; }

        [DataMember(Name="functionSeven")]
        public GlyphDefinition FunctionSeven { get; set; }

        [DataMember(Name="functionSix")]
        public GlyphDefinition FunctionSix { get; set; }

        [DataMember(Name="functionSlashedDD")]
        public GlyphDefinition FunctionSlashedDd { get; set; }

        [DataMember(Name="functionTLower")]
        public GlyphDefinition FunctionTLower { get; set; }

        [DataMember(Name="functionTUpper")]
        public GlyphDefinition FunctionTUpper { get; set; }

        [DataMember(Name="functionThree")]
        public GlyphDefinition FunctionThree { get; set; }

        [DataMember(Name="functionTwo")]
        public GlyphDefinition FunctionTwo { get; set; }

        [DataMember(Name="functionVLower")]
        public GlyphDefinition FunctionVLower { get; set; }

        [DataMember(Name="functionVUpper")]
        public GlyphDefinition FunctionVUpper { get; set; }

        [DataMember(Name="functionZero")]
        public GlyphDefinition FunctionZero { get; set; }

        [DataMember(Name="gClef")]
        public GlyphDefinition GClef { get; set; }

        [DataMember(Name="gClef15ma")]
        public GlyphDefinition GClef15Ma { get; set; }

        [DataMember(Name="gClef15mb")]
        public GlyphDefinition GClef15Mb { get; set; }

        [DataMember(Name="gClef8va")]
        public GlyphDefinition GClef8Va { get; set; }

        [DataMember(Name="gClef8vb")]
        public GlyphDefinition GClef8Vb { get; set; }

        [DataMember(Name="gClef8vbCClef")]
        public GlyphDefinition GClef8VbCClef { get; set; }

        [DataMember(Name="gClef8vbOld")]
        public GlyphDefinition GClef8VbOld { get; set; }

        [DataMember(Name="gClef8vbParens")]
        public GlyphDefinition GClef8VbParens { get; set; }

        [DataMember(Name="gClefArrowDown")]
        public GlyphDefinition GClefArrowDown { get; set; }

        [DataMember(Name="gClefArrowUp")]
        public GlyphDefinition GClefArrowUp { get; set; }

        [DataMember(Name="gClefChange")]
        public GlyphDefinition GClefChange { get; set; }

        [DataMember(Name="gClefLigatedNumberAbove")]
        public GlyphDefinition GClefLigatedNumberAbove { get; set; }

        [DataMember(Name="gClefLigatedNumberBelow")]
        public GlyphDefinition GClefLigatedNumberBelow { get; set; }

        [DataMember(Name="gClefReversed")]
        public GlyphDefinition GClefReversed { get; set; }

        [DataMember(Name="gClefTurned")]
        public GlyphDefinition GClefTurned { get; set; }

        [DataMember(Name="glissandoDown")]
        public GlyphDefinition GlissandoDown { get; set; }

        [DataMember(Name="glissandoUp")]
        public GlyphDefinition GlissandoUp { get; set; }

        [DataMember(Name="graceNoteAcciaccaturaStemDown")]
        public GlyphDefinition GraceNoteAcciaccaturaStemDown { get; set; }

        [DataMember(Name="graceNoteAcciaccaturaStemUp")]
        public GlyphDefinition GraceNoteAcciaccaturaStemUp { get; set; }

        [DataMember(Name="graceNoteAppoggiaturaStemDown")]
        public GlyphDefinition GraceNoteAppoggiaturaStemDown { get; set; }

        [DataMember(Name="graceNoteAppoggiaturaStemUp")]
        public GlyphDefinition GraceNoteAppoggiaturaStemUp { get; set; }

        [DataMember(Name="graceNoteSlashStemDown")]
        public GlyphDefinition GraceNoteSlashStemDown { get; set; }

        [DataMember(Name="graceNoteSlashStemUp")]
        public GlyphDefinition GraceNoteSlashStemUp { get; set; }

        [DataMember(Name="guitarClosePedal")]
        public GlyphDefinition GuitarClosePedal { get; set; }

        [DataMember(Name="guitarFadeIn")]
        public GlyphDefinition GuitarFadeIn { get; set; }

        [DataMember(Name="guitarFadeOut")]
        public GlyphDefinition GuitarFadeOut { get; set; }

        [DataMember(Name="guitarGolpe")]
        public GlyphDefinition GuitarGolpe { get; set; }

        [DataMember(Name="guitarHalfOpenPedal")]
        public GlyphDefinition GuitarHalfOpenPedal { get; set; }

        [DataMember(Name="guitarLeftHandTapping")]
        public GlyphDefinition GuitarLeftHandTapping { get; set; }

        [DataMember(Name="guitarOpenPedal")]
        public GlyphDefinition GuitarOpenPedal { get; set; }

        [DataMember(Name="guitarRightHandTapping")]
        public GlyphDefinition GuitarRightHandTapping { get; set; }

        [DataMember(Name="guitarShake")]
        public GlyphDefinition GuitarShake { get; set; }

        [DataMember(Name="guitarString0")]
        public GlyphDefinition GuitarString0 { get; set; }

        [DataMember(Name="guitarString1")]
        public GlyphDefinition GuitarString1 { get; set; }

        [DataMember(Name="guitarString2")]
        public GlyphDefinition GuitarString2 { get; set; }

        [DataMember(Name="guitarString3")]
        public GlyphDefinition GuitarString3 { get; set; }

        [DataMember(Name="guitarString4")]
        public GlyphDefinition GuitarString4 { get; set; }

        [DataMember(Name="guitarString5")]
        public GlyphDefinition GuitarString5 { get; set; }

        [DataMember(Name="guitarString6")]
        public GlyphDefinition GuitarString6 { get; set; }

        [DataMember(Name="guitarString7")]
        public GlyphDefinition GuitarString7 { get; set; }

        [DataMember(Name="guitarString8")]
        public GlyphDefinition GuitarString8 { get; set; }

        [DataMember(Name="guitarString9")]
        public GlyphDefinition GuitarString9 { get; set; }

        [DataMember(Name="guitarStrumDown")]
        public GlyphDefinition GuitarStrumDown { get; set; }

        [DataMember(Name="guitarStrumUp")]
        public GlyphDefinition GuitarStrumUp { get; set; }

        [DataMember(Name="guitarVibratoBarDip")]
        public GlyphDefinition GuitarVibratoBarDip { get; set; }

        [DataMember(Name="guitarVibratoBarScoop")]
        public GlyphDefinition GuitarVibratoBarScoop { get; set; }

        [DataMember(Name="guitarVibratoStroke")]
        public GlyphDefinition GuitarVibratoStroke { get; set; }

        [DataMember(Name="guitarVolumeSwell")]
        public GlyphDefinition GuitarVolumeSwell { get; set; }

        [DataMember(Name="guitarWideVibratoStroke")]
        public GlyphDefinition GuitarWideVibratoStroke { get; set; }

        [DataMember(Name="handbellsBelltree")]
        public GlyphDefinition HandbellsBelltree { get; set; }

        [DataMember(Name="handbellsDamp3")]
        public GlyphDefinition HandbellsDamp3 { get; set; }

        [DataMember(Name="handbellsEcho1")]
        public GlyphDefinition HandbellsEcho1 { get; set; }

        [DataMember(Name="handbellsEcho2")]
        public GlyphDefinition HandbellsEcho2 { get; set; }

        [DataMember(Name="handbellsGyro")]
        public GlyphDefinition HandbellsGyro { get; set; }

        [DataMember(Name="handbellsHandMartellato")]
        public GlyphDefinition HandbellsHandMartellato { get; set; }

        [DataMember(Name="handbellsMalletBellOnTable")]
        public GlyphDefinition HandbellsMalletBellOnTable { get; set; }

        [DataMember(Name="handbellsMalletBellSuspended")]
        public GlyphDefinition HandbellsMalletBellSuspended { get; set; }

        [DataMember(Name="handbellsMalletLft")]
        public GlyphDefinition HandbellsMalletLft { get; set; }

        [DataMember(Name="handbellsMartellato")]
        public GlyphDefinition HandbellsMartellato { get; set; }

        [DataMember(Name="handbellsMartellatoLift")]
        public GlyphDefinition HandbellsMartellatoLift { get; set; }

        [DataMember(Name="handbellsMutedMartellato")]
        public GlyphDefinition HandbellsMutedMartellato { get; set; }

        [DataMember(Name="handbellsPluckLift")]
        public GlyphDefinition HandbellsPluckLift { get; set; }

        [DataMember(Name="handbellsSwing")]
        public GlyphDefinition HandbellsSwing { get; set; }

        [DataMember(Name="handbellsSwingDown")]
        public GlyphDefinition HandbellsSwingDown { get; set; }

        [DataMember(Name="handbellsSwingUp")]
        public GlyphDefinition HandbellsSwingUp { get; set; }

        [DataMember(Name="handbellsTablePairBells")]
        public GlyphDefinition HandbellsTablePairBells { get; set; }

        [DataMember(Name="handbellsTableSingleBell")]
        public GlyphDefinition HandbellsTableSingleBell { get; set; }

        [DataMember(Name="harpMetalRod")]
        public GlyphDefinition HarpMetalRod { get; set; }

        [DataMember(Name="harpPedalCentered")]
        public GlyphDefinition HarpPedalCentered { get; set; }

        [DataMember(Name="harpPedalDivider")]
        public GlyphDefinition HarpPedalDivider { get; set; }

        [DataMember(Name="harpPedalLowered")]
        public GlyphDefinition HarpPedalLowered { get; set; }

        [DataMember(Name="harpPedalRaised")]
        public GlyphDefinition HarpPedalRaised { get; set; }

        [DataMember(Name="harpSalzedoAeolianAscending")]
        public GlyphDefinition HarpSalzedoAeolianAscending { get; set; }

        [DataMember(Name="harpSalzedoAeolianDescending")]
        public GlyphDefinition HarpSalzedoAeolianDescending { get; set; }

        [DataMember(Name="harpSalzedoFluidicSoundsLeft")]
        public GlyphDefinition HarpSalzedoFluidicSoundsLeft { get; set; }

        [DataMember(Name="harpSalzedoFluidicSoundsRight")]
        public GlyphDefinition HarpSalzedoFluidicSoundsRight { get; set; }

        [DataMember(Name="harpSalzedoMetallicSounds")]
        public GlyphDefinition HarpSalzedoMetallicSounds { get; set; }

        [DataMember(Name="harpSalzedoMuffleTotally")]
        public GlyphDefinition HarpSalzedoMuffleTotally { get; set; }

        [DataMember(Name="harpSalzedoOboicFlux")]
        public GlyphDefinition HarpSalzedoOboicFlux { get; set; }

        [DataMember(Name="harpSalzedoPlayUpperEnd")]
        public GlyphDefinition HarpSalzedoPlayUpperEnd { get; set; }

        [DataMember(Name="harpSalzedoSlideWithSuppleness")]
        public GlyphDefinition HarpSalzedoSlideWithSuppleness { get; set; }

        [DataMember(Name="harpSalzedoTamTamSounds")]
        public GlyphDefinition HarpSalzedoTamTamSounds { get; set; }

        [DataMember(Name="harpSalzedoThunderEffect")]
        public GlyphDefinition HarpSalzedoThunderEffect { get; set; }

        [DataMember(Name="harpSalzedoTimpanicSounds")]
        public GlyphDefinition HarpSalzedoTimpanicSounds { get; set; }

        [DataMember(Name="harpSalzedoWhistlingSounds")]
        public GlyphDefinition HarpSalzedoWhistlingSounds { get; set; }

        [DataMember(Name="harpStringNoiseStem")]
        public GlyphDefinition HarpStringNoiseStem { get; set; }

        [DataMember(Name="harpTuningKey")]
        public GlyphDefinition HarpTuningKey { get; set; }

        [DataMember(Name="harpTuningKeyGlissando")]
        public GlyphDefinition HarpTuningKeyGlissando { get; set; }

        [DataMember(Name="harpTuningKeyHandle")]
        public GlyphDefinition HarpTuningKeyHandle { get; set; }

        [DataMember(Name="harpTuningKeyShank")]
        public GlyphDefinition HarpTuningKeyShank { get; set; }

        [DataMember(Name="keyboardBebung2DotsAbove")]
        public GlyphDefinition KeyboardBebung2DotsAbove { get; set; }

        [DataMember(Name="keyboardBebung2DotsBelow")]
        public GlyphDefinition KeyboardBebung2DotsBelow { get; set; }

        [DataMember(Name="keyboardBebung3DotsAbove")]
        public GlyphDefinition KeyboardBebung3DotsAbove { get; set; }

        [DataMember(Name="keyboardBebung3DotsBelow")]
        public GlyphDefinition KeyboardBebung3DotsBelow { get; set; }

        [DataMember(Name="keyboardBebung4DotsAbove")]
        public GlyphDefinition KeyboardBebung4DotsAbove { get; set; }

        [DataMember(Name="keyboardBebung4DotsBelow")]
        public GlyphDefinition KeyboardBebung4DotsBelow { get; set; }

        [DataMember(Name="keyboardLeftPedalPictogram")]
        public GlyphDefinition KeyboardLeftPedalPictogram { get; set; }

        [DataMember(Name="keyboardMiddlePedalPictogram")]
        public GlyphDefinition KeyboardMiddlePedalPictogram { get; set; }

        [DataMember(Name="keyboardPedalD")]
        public GlyphDefinition KeyboardPedalD { get; set; }

        [DataMember(Name="keyboardPedalDot")]
        public GlyphDefinition KeyboardPedalDot { get; set; }

        [DataMember(Name="keyboardPedalE")]
        public GlyphDefinition KeyboardPedalE { get; set; }

        [DataMember(Name="keyboardPedalHalf")]
        public GlyphDefinition KeyboardPedalHalf { get; set; }

        [DataMember(Name="keyboardPedalHalf2")]
        public GlyphDefinition KeyboardPedalHalf2 { get; set; }

        [DataMember(Name="keyboardPedalHalf3")]
        public GlyphDefinition KeyboardPedalHalf3 { get; set; }

        [DataMember(Name="keyboardPedalHeel1")]
        public GlyphDefinition KeyboardPedalHeel1 { get; set; }

        [DataMember(Name="keyboardPedalHeel2")]
        public GlyphDefinition KeyboardPedalHeel2 { get; set; }

        [DataMember(Name="keyboardPedalHeel3")]
        public GlyphDefinition KeyboardPedalHeel3 { get; set; }

        [DataMember(Name="keyboardPedalHeelToe")]
        public GlyphDefinition KeyboardPedalHeelToe { get; set; }

        [DataMember(Name="keyboardPedalHyphen")]
        public GlyphDefinition KeyboardPedalHyphen { get; set; }

        [DataMember(Name="keyboardPedalP")]
        public GlyphDefinition KeyboardPedalP { get; set; }

        [DataMember(Name="keyboardPedalPed")]
        public GlyphDefinition KeyboardPedalPed { get; set; }

        [DataMember(Name="keyboardPedalS")]
        public GlyphDefinition KeyboardPedalS { get; set; }

        [DataMember(Name="keyboardPedalSost")]
        public GlyphDefinition KeyboardPedalSost { get; set; }

        [DataMember(Name="keyboardPedalToe1")]
        public GlyphDefinition KeyboardPedalToe1 { get; set; }

        [DataMember(Name="keyboardPedalToe2")]
        public GlyphDefinition KeyboardPedalToe2 { get; set; }

        [DataMember(Name="keyboardPedalUp")]
        public GlyphDefinition KeyboardPedalUp { get; set; }

        [DataMember(Name="keyboardPedalUpNotch")]
        public GlyphDefinition KeyboardPedalUpNotch { get; set; }

        [DataMember(Name="keyboardPedalUpSpecial")]
        public GlyphDefinition KeyboardPedalUpSpecial { get; set; }

        [DataMember(Name="keyboardPlayWithLH")]
        public GlyphDefinition KeyboardPlayWithLh { get; set; }

        [DataMember(Name="keyboardPlayWithLHEnd")]
        public GlyphDefinition KeyboardPlayWithLhEnd { get; set; }

        [DataMember(Name="keyboardPlayWithRH")]
        public GlyphDefinition KeyboardPlayWithRh { get; set; }

        [DataMember(Name="keyboardPlayWithRHEnd")]
        public GlyphDefinition KeyboardPlayWithRhEnd { get; set; }

        [DataMember(Name="keyboardPluckInside")]
        public GlyphDefinition KeyboardPluckInside { get; set; }

        [DataMember(Name="keyboardRightPedalPictogram")]
        public GlyphDefinition KeyboardRightPedalPictogram { get; set; }

        [DataMember(Name="kievanAccidentalFlat")]
        public GlyphDefinition KievanAccidentalFlat { get; set; }

        [DataMember(Name="kievanAccidentalSharp")]
        public GlyphDefinition KievanAccidentalSharp { get; set; }

        [DataMember(Name="kievanAugmentationDot")]
        public GlyphDefinition KievanAugmentationDot { get; set; }

        [DataMember(Name="kievanCClef")]
        public GlyphDefinition KievanCClef { get; set; }

        [DataMember(Name="kievanEndingSymbol")]
        public GlyphDefinition KievanEndingSymbol { get; set; }

        [DataMember(Name="kievanNote8thStemDown")]
        public GlyphDefinition KievanNote8ThStemDown { get; set; }

        [DataMember(Name="kievanNote8thStemUp")]
        public GlyphDefinition KievanNote8ThStemUp { get; set; }

        [DataMember(Name="kievanNoteBeam")]
        public GlyphDefinition KievanNoteBeam { get; set; }

        [DataMember(Name="kievanNoteHalfStaffLine")]
        public GlyphDefinition KievanNoteHalfStaffLine { get; set; }

        [DataMember(Name="kievanNoteHalfStaffSpace")]
        public GlyphDefinition KievanNoteHalfStaffSpace { get; set; }

        [DataMember(Name="kievanNoteQuarterStemDown")]
        public GlyphDefinition KievanNoteQuarterStemDown { get; set; }

        [DataMember(Name="kievanNoteQuarterStemUp")]
        public GlyphDefinition KievanNoteQuarterStemUp { get; set; }

        [DataMember(Name="kievanNoteReciting")]
        public GlyphDefinition KievanNoteReciting { get; set; }

        [DataMember(Name="kievanNoteWhole")]
        public GlyphDefinition KievanNoteWhole { get; set; }

        [DataMember(Name="kievanNoteWholeFinal")]
        public GlyphDefinition KievanNoteWholeFinal { get; set; }

        [DataMember(Name="kodalyHandDo")]
        public GlyphDefinition KodalyHandDo { get; set; }

        [DataMember(Name="kodalyHandFa")]
        public GlyphDefinition KodalyHandFa { get; set; }

        [DataMember(Name="kodalyHandLa")]
        public GlyphDefinition KodalyHandLa { get; set; }

        [DataMember(Name="kodalyHandMi")]
        public GlyphDefinition KodalyHandMi { get; set; }

        [DataMember(Name="kodalyHandRe")]
        public GlyphDefinition KodalyHandRe { get; set; }

        [DataMember(Name="kodalyHandSo")]
        public GlyphDefinition KodalyHandSo { get; set; }

        [DataMember(Name="kodalyHandTi")]
        public GlyphDefinition KodalyHandTi { get; set; }

        [DataMember(Name="leftRepeatSmall")]
        public GlyphDefinition LeftRepeatSmall { get; set; }

        [DataMember(Name="legerLine")]
        public GlyphDefinition LegerLine { get; set; }

        [DataMember(Name="legerLineNarrow")]
        public GlyphDefinition LegerLineNarrow { get; set; }

        [DataMember(Name="legerLineWide")]
        public GlyphDefinition LegerLineWide { get; set; }

        [DataMember(Name="luteBarlineEndRepeat")]
        public GlyphDefinition LuteBarlineEndRepeat { get; set; }

        [DataMember(Name="luteBarlineFinal")]
        public GlyphDefinition LuteBarlineFinal { get; set; }

        [DataMember(Name="luteBarlineStartRepeat")]
        public GlyphDefinition LuteBarlineStartRepeat { get; set; }

        [DataMember(Name="luteDuration16th")]
        public GlyphDefinition LuteDuration16Th { get; set; }

        [DataMember(Name="luteDuration32nd")]
        public GlyphDefinition LuteDuration32Nd { get; set; }

        [DataMember(Name="luteDuration8th")]
        public GlyphDefinition LuteDuration8Th { get; set; }

        [DataMember(Name="luteDurationDoubleWhole")]
        public GlyphDefinition LuteDurationDoubleWhole { get; set; }

        [DataMember(Name="luteDurationHalf")]
        public GlyphDefinition LuteDurationHalf { get; set; }

        [DataMember(Name="luteDurationQuarter")]
        public GlyphDefinition LuteDurationQuarter { get; set; }

        [DataMember(Name="luteDurationWhole")]
        public GlyphDefinition LuteDurationWhole { get; set; }

        [DataMember(Name="luteFingeringRHFirst")]
        public GlyphDefinition LuteFingeringRhFirst { get; set; }

        [DataMember(Name="luteFingeringRHSecond")]
        public GlyphDefinition LuteFingeringRhSecond { get; set; }

        [DataMember(Name="luteFingeringRHThird")]
        public GlyphDefinition LuteFingeringRhThird { get; set; }

        [DataMember(Name="luteFingeringRHThumb")]
        public GlyphDefinition LuteFingeringRhThumb { get; set; }

        [DataMember(Name="luteFrench10thCourse")]
        public GlyphDefinition LuteFrench10ThCourse { get; set; }

        [DataMember(Name="luteFrench7thCourse")]
        public GlyphDefinition LuteFrench7ThCourse { get; set; }

        [DataMember(Name="luteFrench8thCourse")]
        public GlyphDefinition LuteFrench8ThCourse { get; set; }

        [DataMember(Name="luteFrench9thCourse")]
        public GlyphDefinition LuteFrench9ThCourse { get; set; }

        [DataMember(Name="luteFrenchAppoggiaturaAbove")]
        public GlyphDefinition LuteFrenchAppoggiaturaAbove { get; set; }

        [DataMember(Name="luteFrenchAppoggiaturaBelow")]
        public GlyphDefinition LuteFrenchAppoggiaturaBelow { get; set; }

        [DataMember(Name="luteFrenchFretA")]
        public GlyphDefinition LuteFrenchFretA { get; set; }

        [DataMember(Name="luteFrenchFretB")]
        public GlyphDefinition LuteFrenchFretB { get; set; }

        [DataMember(Name="luteFrenchFretC")]
        public GlyphDefinition LuteFrenchFretC { get; set; }

        [DataMember(Name="luteFrenchFretD")]
        public GlyphDefinition LuteFrenchFretD { get; set; }

        [DataMember(Name="luteFrenchFretE")]
        public GlyphDefinition LuteFrenchFretE { get; set; }

        [DataMember(Name="luteFrenchFretF")]
        public GlyphDefinition LuteFrenchFretF { get; set; }

        [DataMember(Name="luteFrenchFretG")]
        public GlyphDefinition LuteFrenchFretG { get; set; }

        [DataMember(Name="luteFrenchFretH")]
        public GlyphDefinition LuteFrenchFretH { get; set; }

        [DataMember(Name="luteFrenchFretI")]
        public GlyphDefinition LuteFrenchFretI { get; set; }

        [DataMember(Name="luteFrenchFretK")]
        public GlyphDefinition LuteFrenchFretK { get; set; }

        [DataMember(Name="luteFrenchFretL")]
        public GlyphDefinition LuteFrenchFretL { get; set; }

        [DataMember(Name="luteFrenchFretM")]
        public GlyphDefinition LuteFrenchFretM { get; set; }

        [DataMember(Name="luteFrenchFretN")]
        public GlyphDefinition LuteFrenchFretN { get; set; }

        [DataMember(Name="luteFrenchMordentInverted")]
        public GlyphDefinition LuteFrenchMordentInverted { get; set; }

        [DataMember(Name="luteFrenchMordentLower")]
        public GlyphDefinition LuteFrenchMordentLower { get; set; }

        [DataMember(Name="luteFrenchMordentUpper")]
        public GlyphDefinition LuteFrenchMordentUpper { get; set; }

        [DataMember(Name="luteGermanALower")]
        public GlyphDefinition LuteGermanALower { get; set; }

        [DataMember(Name="luteGermanAUpper")]
        public GlyphDefinition LuteGermanAUpper { get; set; }

        [DataMember(Name="luteGermanBLower")]
        public GlyphDefinition LuteGermanBLower { get; set; }

        [DataMember(Name="luteGermanBUpper")]
        public GlyphDefinition LuteGermanBUpper { get; set; }

        [DataMember(Name="luteGermanCLower")]
        public GlyphDefinition LuteGermanCLower { get; set; }

        [DataMember(Name="luteGermanCUpper")]
        public GlyphDefinition LuteGermanCUpper { get; set; }

        [DataMember(Name="luteGermanDLower")]
        public GlyphDefinition LuteGermanDLower { get; set; }

        [DataMember(Name="luteGermanDUpper")]
        public GlyphDefinition LuteGermanDUpper { get; set; }

        [DataMember(Name="luteGermanELower")]
        public GlyphDefinition LuteGermanELower { get; set; }

        [DataMember(Name="luteGermanEUpper")]
        public GlyphDefinition LuteGermanEUpper { get; set; }

        [DataMember(Name="luteGermanFLower")]
        public GlyphDefinition LuteGermanFLower { get; set; }

        [DataMember(Name="luteGermanFUpper")]
        public GlyphDefinition LuteGermanFUpper { get; set; }

        [DataMember(Name="luteGermanGLower")]
        public GlyphDefinition LuteGermanGLower { get; set; }

        [DataMember(Name="luteGermanGUpper")]
        public GlyphDefinition LuteGermanGUpper { get; set; }

        [DataMember(Name="luteGermanHLower")]
        public GlyphDefinition LuteGermanHLower { get; set; }

        [DataMember(Name="luteGermanHUpper")]
        public GlyphDefinition LuteGermanHUpper { get; set; }

        [DataMember(Name="luteGermanILower")]
        public GlyphDefinition LuteGermanILower { get; set; }

        [DataMember(Name="luteGermanIUpper")]
        public GlyphDefinition LuteGermanIUpper { get; set; }

        [DataMember(Name="luteGermanKLower")]
        public GlyphDefinition LuteGermanKLower { get; set; }

        [DataMember(Name="luteGermanKUpper")]
        public GlyphDefinition LuteGermanKUpper { get; set; }

        [DataMember(Name="luteGermanLLower")]
        public GlyphDefinition LuteGermanLLower { get; set; }

        [DataMember(Name="luteGermanLUpper")]
        public GlyphDefinition LuteGermanLUpper { get; set; }

        [DataMember(Name="luteGermanMLower")]
        public GlyphDefinition LuteGermanMLower { get; set; }

        [DataMember(Name="luteGermanMUpper")]
        public GlyphDefinition LuteGermanMUpper { get; set; }

        [DataMember(Name="luteGermanNLower")]
        public GlyphDefinition LuteGermanNLower { get; set; }

        [DataMember(Name="luteGermanNUpper")]
        public GlyphDefinition LuteGermanNUpper { get; set; }

        [DataMember(Name="luteGermanOLower")]
        public GlyphDefinition LuteGermanOLower { get; set; }

        [DataMember(Name="luteGermanPLower")]
        public GlyphDefinition LuteGermanPLower { get; set; }

        [DataMember(Name="luteGermanQLower")]
        public GlyphDefinition LuteGermanQLower { get; set; }

        [DataMember(Name="luteGermanRLower")]
        public GlyphDefinition LuteGermanRLower { get; set; }

        [DataMember(Name="luteGermanSLower")]
        public GlyphDefinition LuteGermanSLower { get; set; }

        [DataMember(Name="luteGermanTLower")]
        public GlyphDefinition LuteGermanTLower { get; set; }

        [DataMember(Name="luteGermanVLower")]
        public GlyphDefinition LuteGermanVLower { get; set; }

        [DataMember(Name="luteGermanXLower")]
        public GlyphDefinition LuteGermanXLower { get; set; }

        [DataMember(Name="luteGermanYLower")]
        public GlyphDefinition LuteGermanYLower { get; set; }

        [DataMember(Name="luteGermanZLower")]
        public GlyphDefinition LuteGermanZLower { get; set; }

        [DataMember(Name="luteItalianClefCSolFaUt")]
        public GlyphDefinition LuteItalianClefCSolFaUt { get; set; }

        [DataMember(Name="luteItalianClefFFaUt")]
        public GlyphDefinition LuteItalianClefFFaUt { get; set; }

        [DataMember(Name="luteItalianFret0")]
        public GlyphDefinition LuteItalianFret0 { get; set; }

        [DataMember(Name="luteItalianFret1")]
        public GlyphDefinition LuteItalianFret1 { get; set; }

        [DataMember(Name="luteItalianFret2")]
        public GlyphDefinition LuteItalianFret2 { get; set; }

        [DataMember(Name="luteItalianFret3")]
        public GlyphDefinition LuteItalianFret3 { get; set; }

        [DataMember(Name="luteItalianFret4")]
        public GlyphDefinition LuteItalianFret4 { get; set; }

        [DataMember(Name="luteItalianFret5")]
        public GlyphDefinition LuteItalianFret5 { get; set; }

        [DataMember(Name="luteItalianFret6")]
        public GlyphDefinition LuteItalianFret6 { get; set; }

        [DataMember(Name="luteItalianFret7")]
        public GlyphDefinition LuteItalianFret7 { get; set; }

        [DataMember(Name="luteItalianFret8")]
        public GlyphDefinition LuteItalianFret8 { get; set; }

        [DataMember(Name="luteItalianFret9")]
        public GlyphDefinition LuteItalianFret9 { get; set; }

        [DataMember(Name="luteItalianHoldFinger")]
        public GlyphDefinition LuteItalianHoldFinger { get; set; }

        [DataMember(Name="luteItalianHoldNote")]
        public GlyphDefinition LuteItalianHoldNote { get; set; }

        [DataMember(Name="luteItalianReleaseFinger")]
        public GlyphDefinition LuteItalianReleaseFinger { get; set; }

        [DataMember(Name="luteItalianTempoFast")]
        public GlyphDefinition LuteItalianTempoFast { get; set; }

        [DataMember(Name="luteItalianTempoNeitherFastNorSlow")]
        public GlyphDefinition LuteItalianTempoNeitherFastNorSlow { get; set; }

        [DataMember(Name="luteItalianTempoSlow")]
        public GlyphDefinition LuteItalianTempoSlow { get; set; }

        [DataMember(Name="luteItalianTempoSomewhatFast")]
        public GlyphDefinition LuteItalianTempoSomewhatFast { get; set; }

        [DataMember(Name="luteItalianTempoVerySlow")]
        public GlyphDefinition LuteItalianTempoVerySlow { get; set; }

        [DataMember(Name="luteItalianTimeTriple")]
        public GlyphDefinition LuteItalianTimeTriple { get; set; }

        [DataMember(Name="luteItalianTremolo")]
        public GlyphDefinition LuteItalianTremolo { get; set; }

        [DataMember(Name="luteItalianVibrato")]
        public GlyphDefinition LuteItalianVibrato { get; set; }

        [DataMember(Name="luteStaff6Lines")]
        public GlyphDefinition LuteStaff6Lines { get; set; }

        [DataMember(Name="luteStaff6LinesNarrow")]
        public GlyphDefinition LuteStaff6LinesNarrow { get; set; }

        [DataMember(Name="luteStaff6LinesWide")]
        public GlyphDefinition LuteStaff6LinesWide { get; set; }

        [DataMember(Name="lyricsElision")]
        public GlyphDefinition LyricsElision { get; set; }

        [DataMember(Name="lyricsElisionNarrow")]
        public GlyphDefinition LyricsElisionNarrow { get; set; }

        [DataMember(Name="lyricsElisionWide")]
        public GlyphDefinition LyricsElisionWide { get; set; }

        [DataMember(Name="lyricsHyphenBaseline")]
        public GlyphDefinition LyricsHyphenBaseline { get; set; }

        [DataMember(Name="lyricsHyphenBaselineNonBreaking")]
        public GlyphDefinition LyricsHyphenBaselineNonBreaking { get; set; }

        [DataMember(Name="medRenFlatHardB")]
        public GlyphDefinition MedRenFlatHardB { get; set; }

        [DataMember(Name="medRenFlatSoftB")]
        public GlyphDefinition MedRenFlatSoftB { get; set; }

        [DataMember(Name="medRenFlatWithDot")]
        public GlyphDefinition MedRenFlatWithDot { get; set; }

        [DataMember(Name="medRenGClefCMN")]
        public GlyphDefinition MedRenGClefCmn { get; set; }

        [DataMember(Name="medRenLiquescenceCMN")]
        public GlyphDefinition MedRenLiquescenceCmn { get; set; }

        [DataMember(Name="medRenLiquescentAscCMN")]
        public GlyphDefinition MedRenLiquescentAscCmn { get; set; }

        [DataMember(Name="medRenLiquescentDescCMN")]
        public GlyphDefinition MedRenLiquescentDescCmn { get; set; }

        [DataMember(Name="medRenNatural")]
        public GlyphDefinition MedRenNatural { get; set; }

        [DataMember(Name="medRenNaturalWithCross")]
        public GlyphDefinition MedRenNaturalWithCross { get; set; }

        [DataMember(Name="medRenOriscusCMN")]
        public GlyphDefinition MedRenOriscusCmn { get; set; }

        [DataMember(Name="medRenPlicaCMN")]
        public GlyphDefinition MedRenPlicaCmn { get; set; }

        [DataMember(Name="medRenPunctumCMN")]
        public GlyphDefinition MedRenPunctumCmn { get; set; }

        [DataMember(Name="medRenQuilismaCMN")]
        public GlyphDefinition MedRenQuilismaCmn { get; set; }

        [DataMember(Name="medRenSharpCroix")]
        public GlyphDefinition MedRenSharpCroix { get; set; }

        [DataMember(Name="medRenStrophicusCMN")]
        public GlyphDefinition MedRenStrophicusCmn { get; set; }

        [DataMember(Name="mensuralAlterationSign")]
        public GlyphDefinition MensuralAlterationSign { get; set; }

        [DataMember(Name="mensuralBlackBrevis")]
        public GlyphDefinition MensuralBlackBrevis { get; set; }

        [DataMember(Name="mensuralBlackBrevisVoid")]
        public GlyphDefinition MensuralBlackBrevisVoid { get; set; }

        [DataMember(Name="mensuralBlackDragma")]
        public GlyphDefinition MensuralBlackDragma { get; set; }

        [DataMember(Name="mensuralBlackLonga")]
        public GlyphDefinition MensuralBlackLonga { get; set; }

        [DataMember(Name="mensuralBlackMaxima")]
        public GlyphDefinition MensuralBlackMaxima { get; set; }

        [DataMember(Name="mensuralBlackMinima")]
        public GlyphDefinition MensuralBlackMinima { get; set; }

        [DataMember(Name="mensuralBlackMinimaVoid")]
        public GlyphDefinition MensuralBlackMinimaVoid { get; set; }

        [DataMember(Name="mensuralBlackSemibrevis")]
        public GlyphDefinition MensuralBlackSemibrevis { get; set; }

        [DataMember(Name="mensuralBlackSemibrevisCaudata")]
        public GlyphDefinition MensuralBlackSemibrevisCaudata { get; set; }

        [DataMember(Name="mensuralBlackSemibrevisOblique")]
        public GlyphDefinition MensuralBlackSemibrevisOblique { get; set; }

        [DataMember(Name="mensuralBlackSemibrevisVoid")]
        public GlyphDefinition MensuralBlackSemibrevisVoid { get; set; }

        [DataMember(Name="mensuralBlackSemiminima")]
        public GlyphDefinition MensuralBlackSemiminima { get; set; }

        [DataMember(Name="mensuralCclef")]
        public GlyphDefinition MensuralCclef { get; set; }

        [DataMember(Name="mensuralCclefPetrucciPosHigh")]
        public GlyphDefinition MensuralCclefPetrucciPosHigh { get; set; }

        [DataMember(Name="mensuralCclefPetrucciPosHighest")]
        public GlyphDefinition MensuralCclefPetrucciPosHighest { get; set; }

        [DataMember(Name="mensuralCclefPetrucciPosLow")]
        public GlyphDefinition MensuralCclefPetrucciPosLow { get; set; }

        [DataMember(Name="mensuralCclefPetrucciPosLowest")]
        public GlyphDefinition MensuralCclefPetrucciPosLowest { get; set; }

        [DataMember(Name="mensuralCclefPetrucciPosMiddle")]
        public GlyphDefinition MensuralCclefPetrucciPosMiddle { get; set; }

        [DataMember(Name="mensuralColorationEndRound")]
        public GlyphDefinition MensuralColorationEndRound { get; set; }

        [DataMember(Name="mensuralColorationEndSquare")]
        public GlyphDefinition MensuralColorationEndSquare { get; set; }

        [DataMember(Name="mensuralColorationStartRound")]
        public GlyphDefinition MensuralColorationStartRound { get; set; }

        [DataMember(Name="mensuralColorationStartSquare")]
        public GlyphDefinition MensuralColorationStartSquare { get; set; }

        [DataMember(Name="mensuralCombStemDiagonal")]
        public GlyphDefinition MensuralCombStemDiagonal { get; set; }

        [DataMember(Name="mensuralCombStemDown")]
        public GlyphDefinition MensuralCombStemDown { get; set; }

        [DataMember(Name="mensuralCombStemDownFlagExtended")]
        public GlyphDefinition MensuralCombStemDownFlagExtended { get; set; }

        [DataMember(Name="mensuralCombStemDownFlagFlared")]
        public GlyphDefinition MensuralCombStemDownFlagFlared { get; set; }

        [DataMember(Name="mensuralCombStemDownFlagFusa")]
        public GlyphDefinition MensuralCombStemDownFlagFusa { get; set; }

        [DataMember(Name="mensuralCombStemDownFlagLeft")]
        public GlyphDefinition MensuralCombStemDownFlagLeft { get; set; }

        [DataMember(Name="mensuralCombStemDownFlagRight")]
        public GlyphDefinition MensuralCombStemDownFlagRight { get; set; }

        [DataMember(Name="mensuralCombStemDownFlagSemiminima")]
        public GlyphDefinition MensuralCombStemDownFlagSemiminima { get; set; }

        [DataMember(Name="mensuralCombStemUp")]
        public GlyphDefinition MensuralCombStemUp { get; set; }

        [DataMember(Name="mensuralCombStemUpFlagExtended")]
        public GlyphDefinition MensuralCombStemUpFlagExtended { get; set; }

        [DataMember(Name="mensuralCombStemUpFlagFlared")]
        public GlyphDefinition MensuralCombStemUpFlagFlared { get; set; }

        [DataMember(Name="mensuralCombStemUpFlagFusa")]
        public GlyphDefinition MensuralCombStemUpFlagFusa { get; set; }

        [DataMember(Name="mensuralCombStemUpFlagLeft")]
        public GlyphDefinition MensuralCombStemUpFlagLeft { get; set; }

        [DataMember(Name="mensuralCombStemUpFlagRight")]
        public GlyphDefinition MensuralCombStemUpFlagRight { get; set; }

        [DataMember(Name="mensuralCombStemUpFlagSemiminima")]
        public GlyphDefinition MensuralCombStemUpFlagSemiminima { get; set; }

        [DataMember(Name="mensuralCustosCheckmark")]
        public GlyphDefinition MensuralCustosCheckmark { get; set; }

        [DataMember(Name="mensuralCustosDown")]
        public GlyphDefinition MensuralCustosDown { get; set; }

        [DataMember(Name="mensuralCustosTurn")]
        public GlyphDefinition MensuralCustosTurn { get; set; }

        [DataMember(Name="mensuralCustosUp")]
        public GlyphDefinition MensuralCustosUp { get; set; }

        [DataMember(Name="mensuralFclef")]
        public GlyphDefinition MensuralFclef { get; set; }

        [DataMember(Name="mensuralFclefPetrucci")]
        public GlyphDefinition MensuralFclefPetrucci { get; set; }

        [DataMember(Name="mensuralGclef")]
        public GlyphDefinition MensuralGclef { get; set; }

        [DataMember(Name="mensuralGclefPetrucci")]
        public GlyphDefinition MensuralGclefPetrucci { get; set; }

        [DataMember(Name="mensuralModusImperfectumVert")]
        public GlyphDefinition MensuralModusImperfectumVert { get; set; }

        [DataMember(Name="mensuralModusPerfectumVert")]
        public GlyphDefinition MensuralModusPerfectumVert { get; set; }

        [DataMember(Name="mensuralNoteheadLongaBlack")]
        public GlyphDefinition MensuralNoteheadLongaBlack { get; set; }

        [DataMember(Name="mensuralNoteheadLongaBlackVoid")]
        public GlyphDefinition MensuralNoteheadLongaBlackVoid { get; set; }

        [DataMember(Name="mensuralNoteheadLongaVoid")]
        public GlyphDefinition MensuralNoteheadLongaVoid { get; set; }

        [DataMember(Name="mensuralNoteheadLongaWhite")]
        public GlyphDefinition MensuralNoteheadLongaWhite { get; set; }

        [DataMember(Name="mensuralNoteheadMaximaBlack")]
        public GlyphDefinition MensuralNoteheadMaximaBlack { get; set; }

        [DataMember(Name="mensuralNoteheadMaximaBlackVoid")]
        public GlyphDefinition MensuralNoteheadMaximaBlackVoid { get; set; }

        [DataMember(Name="mensuralNoteheadMaximaVoid")]
        public GlyphDefinition MensuralNoteheadMaximaVoid { get; set; }

        [DataMember(Name="mensuralNoteheadMaximaWhite")]
        public GlyphDefinition MensuralNoteheadMaximaWhite { get; set; }

        [DataMember(Name="mensuralNoteheadMinimaWhite")]
        public GlyphDefinition MensuralNoteheadMinimaWhite { get; set; }

        [DataMember(Name="mensuralNoteheadSemibrevisBlack")]
        public GlyphDefinition MensuralNoteheadSemibrevisBlack { get; set; }

        [DataMember(Name="mensuralNoteheadSemibrevisBlackVoid")]
        public GlyphDefinition MensuralNoteheadSemibrevisBlackVoid { get; set; }

        [DataMember(Name="mensuralNoteheadSemibrevisBlackVoidTurned")]
        public GlyphDefinition MensuralNoteheadSemibrevisBlackVoidTurned { get; set; }

        [DataMember(Name="mensuralNoteheadSemibrevisVoid")]
        public GlyphDefinition MensuralNoteheadSemibrevisVoid { get; set; }

        [DataMember(Name="mensuralNoteheadSemiminimaWhite")]
        public GlyphDefinition MensuralNoteheadSemiminimaWhite { get; set; }

        [DataMember(Name="mensuralObliqueAsc2ndBlack")]
        public GlyphDefinition MensuralObliqueAsc2NdBlack { get; set; }

        [DataMember(Name="mensuralObliqueAsc2ndBlackVoid")]
        public GlyphDefinition MensuralObliqueAsc2NdBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc2ndVoid")]
        public GlyphDefinition MensuralObliqueAsc2NdVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc2ndWhite")]
        public GlyphDefinition MensuralObliqueAsc2NdWhite { get; set; }

        [DataMember(Name="mensuralObliqueAsc3rdBlack")]
        public GlyphDefinition MensuralObliqueAsc3RdBlack { get; set; }

        [DataMember(Name="mensuralObliqueAsc3rdBlackVoid")]
        public GlyphDefinition MensuralObliqueAsc3RdBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc3rdVoid")]
        public GlyphDefinition MensuralObliqueAsc3RdVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc3rdWhite")]
        public GlyphDefinition MensuralObliqueAsc3RdWhite { get; set; }

        [DataMember(Name="mensuralObliqueAsc4thBlack")]
        public GlyphDefinition MensuralObliqueAsc4ThBlack { get; set; }

        [DataMember(Name="mensuralObliqueAsc4thBlackVoid")]
        public GlyphDefinition MensuralObliqueAsc4ThBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc4thVoid")]
        public GlyphDefinition MensuralObliqueAsc4ThVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc4thWhite")]
        public GlyphDefinition MensuralObliqueAsc4ThWhite { get; set; }

        [DataMember(Name="mensuralObliqueAsc5thBlack")]
        public GlyphDefinition MensuralObliqueAsc5ThBlack { get; set; }

        [DataMember(Name="mensuralObliqueAsc5thBlackVoid")]
        public GlyphDefinition MensuralObliqueAsc5ThBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc5thVoid")]
        public GlyphDefinition MensuralObliqueAsc5ThVoid { get; set; }

        [DataMember(Name="mensuralObliqueAsc5thWhite")]
        public GlyphDefinition MensuralObliqueAsc5ThWhite { get; set; }

        [DataMember(Name="mensuralObliqueDesc2ndBlack")]
        public GlyphDefinition MensuralObliqueDesc2NdBlack { get; set; }

        [DataMember(Name="mensuralObliqueDesc2ndBlackVoid")]
        public GlyphDefinition MensuralObliqueDesc2NdBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc2ndVoid")]
        public GlyphDefinition MensuralObliqueDesc2NdVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc2ndWhite")]
        public GlyphDefinition MensuralObliqueDesc2NdWhite { get; set; }

        [DataMember(Name="mensuralObliqueDesc3rdBlack")]
        public GlyphDefinition MensuralObliqueDesc3RdBlack { get; set; }

        [DataMember(Name="mensuralObliqueDesc3rdBlackVoid")]
        public GlyphDefinition MensuralObliqueDesc3RdBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc3rdVoid")]
        public GlyphDefinition MensuralObliqueDesc3RdVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc3rdWhite")]
        public GlyphDefinition MensuralObliqueDesc3RdWhite { get; set; }

        [DataMember(Name="mensuralObliqueDesc4thBlack")]
        public GlyphDefinition MensuralObliqueDesc4ThBlack { get; set; }

        [DataMember(Name="mensuralObliqueDesc4thBlackVoid")]
        public GlyphDefinition MensuralObliqueDesc4ThBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc4thVoid")]
        public GlyphDefinition MensuralObliqueDesc4ThVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc4thWhite")]
        public GlyphDefinition MensuralObliqueDesc4ThWhite { get; set; }

        [DataMember(Name="mensuralObliqueDesc5thBlack")]
        public GlyphDefinition MensuralObliqueDesc5ThBlack { get; set; }

        [DataMember(Name="mensuralObliqueDesc5thBlackVoid")]
        public GlyphDefinition MensuralObliqueDesc5ThBlackVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc5thVoid")]
        public GlyphDefinition MensuralObliqueDesc5ThVoid { get; set; }

        [DataMember(Name="mensuralObliqueDesc5thWhite")]
        public GlyphDefinition MensuralObliqueDesc5ThWhite { get; set; }

        [DataMember(Name="mensuralProlation1")]
        public GlyphDefinition MensuralProlation1 { get; set; }

        [DataMember(Name="mensuralProlation10")]
        public GlyphDefinition MensuralProlation10 { get; set; }

        [DataMember(Name="mensuralProlation11")]
        public GlyphDefinition MensuralProlation11 { get; set; }

        [DataMember(Name="mensuralProlation2")]
        public GlyphDefinition MensuralProlation2 { get; set; }

        [DataMember(Name="mensuralProlation3")]
        public GlyphDefinition MensuralProlation3 { get; set; }

        [DataMember(Name="mensuralProlation4")]
        public GlyphDefinition MensuralProlation4 { get; set; }

        [DataMember(Name="mensuralProlation5")]
        public GlyphDefinition MensuralProlation5 { get; set; }

        [DataMember(Name="mensuralProlation6")]
        public GlyphDefinition MensuralProlation6 { get; set; }

        [DataMember(Name="mensuralProlation7")]
        public GlyphDefinition MensuralProlation7 { get; set; }

        [DataMember(Name="mensuralProlation8")]
        public GlyphDefinition MensuralProlation8 { get; set; }

        [DataMember(Name="mensuralProlation9")]
        public GlyphDefinition MensuralProlation9 { get; set; }

        [DataMember(Name="mensuralProlationCombiningDot")]
        public GlyphDefinition MensuralProlationCombiningDot { get; set; }

        [DataMember(Name="mensuralProlationCombiningDotVoid")]
        public GlyphDefinition MensuralProlationCombiningDotVoid { get; set; }

        [DataMember(Name="mensuralProlationCombiningStroke")]
        public GlyphDefinition MensuralProlationCombiningStroke { get; set; }

        [DataMember(Name="mensuralProlationCombiningThreeDots")]
        public GlyphDefinition MensuralProlationCombiningThreeDots { get; set; }

        [DataMember(Name="mensuralProlationCombiningThreeDotsTri")]
        public GlyphDefinition MensuralProlationCombiningThreeDotsTri { get; set; }

        [DataMember(Name="mensuralProlationCombiningTwoDots")]
        public GlyphDefinition MensuralProlationCombiningTwoDots { get; set; }

        [DataMember(Name="mensuralProportion1")]
        public GlyphDefinition MensuralProportion1 { get; set; }

        [DataMember(Name="mensuralProportion2")]
        public GlyphDefinition MensuralProportion2 { get; set; }

        [DataMember(Name="mensuralProportion3")]
        public GlyphDefinition MensuralProportion3 { get; set; }

        [DataMember(Name="mensuralProportion4")]
        public GlyphDefinition MensuralProportion4 { get; set; }

        [DataMember(Name="mensuralProportionMajor")]
        public GlyphDefinition MensuralProportionMajor { get; set; }

        [DataMember(Name="mensuralProportionMinor")]
        public GlyphDefinition MensuralProportionMinor { get; set; }

        [DataMember(Name="mensuralProportionProportioDupla1")]
        public GlyphDefinition MensuralProportionProportioDupla1 { get; set; }

        [DataMember(Name="mensuralProportionProportioDupla2")]
        public GlyphDefinition MensuralProportionProportioDupla2 { get; set; }

        [DataMember(Name="mensuralProportionProportioQuadrupla")]
        public GlyphDefinition MensuralProportionProportioQuadrupla { get; set; }

        [DataMember(Name="mensuralProportionProportioTripla")]
        public GlyphDefinition MensuralProportionProportioTripla { get; set; }

        [DataMember(Name="mensuralProportionTempusPerfectum")]
        public GlyphDefinition MensuralProportionTempusPerfectum { get; set; }

        [DataMember(Name="mensuralRestBrevis")]
        public GlyphDefinition MensuralRestBrevis { get; set; }

        [DataMember(Name="mensuralRestFusa")]
        public GlyphDefinition MensuralRestFusa { get; set; }

        [DataMember(Name="mensuralRestLongaImperfecta")]
        public GlyphDefinition MensuralRestLongaImperfecta { get; set; }

        [DataMember(Name="mensuralRestLongaPerfecta")]
        public GlyphDefinition MensuralRestLongaPerfecta { get; set; }

        [DataMember(Name="mensuralRestMaxima")]
        public GlyphDefinition MensuralRestMaxima { get; set; }

        [DataMember(Name="mensuralRestMinima")]
        public GlyphDefinition MensuralRestMinima { get; set; }

        [DataMember(Name="mensuralRestSemibrevis")]
        public GlyphDefinition MensuralRestSemibrevis { get; set; }

        [DataMember(Name="mensuralRestSemifusa")]
        public GlyphDefinition MensuralRestSemifusa { get; set; }

        [DataMember(Name="mensuralRestSemiminima")]
        public GlyphDefinition MensuralRestSemiminima { get; set; }

        [DataMember(Name="mensuralSignumDown")]
        public GlyphDefinition MensuralSignumDown { get; set; }

        [DataMember(Name="mensuralSignumUp")]
        public GlyphDefinition MensuralSignumUp { get; set; }

        [DataMember(Name="mensuralTempusImperfectumHoriz")]
        public GlyphDefinition MensuralTempusImperfectumHoriz { get; set; }

        [DataMember(Name="mensuralTempusPerfectumHoriz")]
        public GlyphDefinition MensuralTempusPerfectumHoriz { get; set; }

        [DataMember(Name="mensuralWhiteBrevis")]
        public GlyphDefinition MensuralWhiteBrevis { get; set; }

        [DataMember(Name="mensuralWhiteFusa")]
        public GlyphDefinition MensuralWhiteFusa { get; set; }

        [DataMember(Name="mensuralWhiteLonga")]
        public GlyphDefinition MensuralWhiteLonga { get; set; }

        [DataMember(Name="mensuralWhiteMaxima")]
        public GlyphDefinition MensuralWhiteMaxima { get; set; }

        [DataMember(Name="mensuralWhiteMinima")]
        public GlyphDefinition MensuralWhiteMinima { get; set; }

        [DataMember(Name="mensuralWhiteSemiminima")]
        public GlyphDefinition MensuralWhiteSemiminima { get; set; }

        [DataMember(Name="metricModulationArrowLeft")]
        public GlyphDefinition MetricModulationArrowLeft { get; set; }

        [DataMember(Name="metricModulationArrowRight")]
        public GlyphDefinition MetricModulationArrowRight { get; set; }

        [DataMember(Name="miscDoNotCopy")]
        public GlyphDefinition MiscDoNotCopy { get; set; }

        [DataMember(Name="miscDoNotPhotocopy")]
        public GlyphDefinition MiscDoNotPhotocopy { get; set; }

        [DataMember(Name="miscEyeglasses")]
        public GlyphDefinition MiscEyeglasses { get; set; }

        [DataMember(Name="note1024thDown")]
        public GlyphDefinition Note1024ThDown { get; set; }

        [DataMember(Name="note1024thUp")]
        public GlyphDefinition Note1024ThUp { get; set; }

        [DataMember(Name="note128thDown")]
        public GlyphDefinition Note128ThDown { get; set; }

        [DataMember(Name="note128thUp")]
        public GlyphDefinition Note128ThUp { get; set; }

        [DataMember(Name="note16thDown")]
        public GlyphDefinition Note16ThDown { get; set; }

        [DataMember(Name="note16thUp")]
        public GlyphDefinition Note16ThUp { get; set; }

        [DataMember(Name="note256thDown")]
        public GlyphDefinition Note256ThDown { get; set; }

        [DataMember(Name="note256thUp")]
        public GlyphDefinition Note256ThUp { get; set; }

        [DataMember(Name="note32ndDown")]
        public GlyphDefinition Note32NdDown { get; set; }

        [DataMember(Name="note32ndUp")]
        public GlyphDefinition Note32NdUp { get; set; }

        [DataMember(Name="note512thDown")]
        public GlyphDefinition Note512ThDown { get; set; }

        [DataMember(Name="note512thUp")]
        public GlyphDefinition Note512ThUp { get; set; }

        [DataMember(Name="note64thDown")]
        public GlyphDefinition Note64ThDown { get; set; }

        [DataMember(Name="note64thUp")]
        public GlyphDefinition Note64ThUp { get; set; }

        [DataMember(Name="note8thDown")]
        public GlyphDefinition Note8ThDown { get; set; }

        [DataMember(Name="note8thUp")]
        public GlyphDefinition Note8ThUp { get; set; }

        [DataMember(Name="noteABlack")]
        public GlyphDefinition NoteABlack { get; set; }

        [DataMember(Name="noteAFlatBlack")]
        public GlyphDefinition NoteAFlatBlack { get; set; }

        [DataMember(Name="noteAFlatHalf")]
        public GlyphDefinition NoteAFlatHalf { get; set; }

        [DataMember(Name="noteAFlatWhole")]
        public GlyphDefinition NoteAFlatWhole { get; set; }

        [DataMember(Name="noteAHalf")]
        public GlyphDefinition NoteAHalf { get; set; }

        [DataMember(Name="noteASharpBlack")]
        public GlyphDefinition NoteASharpBlack { get; set; }

        [DataMember(Name="noteASharpHalf")]
        public GlyphDefinition NoteASharpHalf { get; set; }

        [DataMember(Name="noteASharpWhole")]
        public GlyphDefinition NoteASharpWhole { get; set; }

        [DataMember(Name="noteAWhole")]
        public GlyphDefinition NoteAWhole { get; set; }

        [DataMember(Name="noteBBlack")]
        public GlyphDefinition NoteBBlack { get; set; }

        [DataMember(Name="noteBFlatBlack")]
        public GlyphDefinition NoteBFlatBlack { get; set; }

        [DataMember(Name="noteBFlatHalf")]
        public GlyphDefinition NoteBFlatHalf { get; set; }

        [DataMember(Name="noteBFlatWhole")]
        public GlyphDefinition NoteBFlatWhole { get; set; }

        [DataMember(Name="noteBHalf")]
        public GlyphDefinition NoteBHalf { get; set; }

        [DataMember(Name="noteBSharpBlack")]
        public GlyphDefinition NoteBSharpBlack { get; set; }

        [DataMember(Name="noteBSharpHalf")]
        public GlyphDefinition NoteBSharpHalf { get; set; }

        [DataMember(Name="noteBSharpWhole")]
        public GlyphDefinition NoteBSharpWhole { get; set; }

        [DataMember(Name="noteBWhole")]
        public GlyphDefinition NoteBWhole { get; set; }

        [DataMember(Name="noteCBlack")]
        public GlyphDefinition NoteCBlack { get; set; }

        [DataMember(Name="noteCFlatBlack")]
        public GlyphDefinition NoteCFlatBlack { get; set; }

        [DataMember(Name="noteCFlatHalf")]
        public GlyphDefinition NoteCFlatHalf { get; set; }

        [DataMember(Name="noteCFlatWhole")]
        public GlyphDefinition NoteCFlatWhole { get; set; }

        [DataMember(Name="noteCHalf")]
        public GlyphDefinition NoteCHalf { get; set; }

        [DataMember(Name="noteCSharpBlack")]
        public GlyphDefinition NoteCSharpBlack { get; set; }

        [DataMember(Name="noteCSharpHalf")]
        public GlyphDefinition NoteCSharpHalf { get; set; }

        [DataMember(Name="noteCSharpWhole")]
        public GlyphDefinition NoteCSharpWhole { get; set; }

        [DataMember(Name="noteCWhole")]
        public GlyphDefinition NoteCWhole { get; set; }

        [DataMember(Name="noteDBlack")]
        public GlyphDefinition NoteDBlack { get; set; }

        [DataMember(Name="noteDFlatBlack")]
        public GlyphDefinition NoteDFlatBlack { get; set; }

        [DataMember(Name="noteDFlatHalf")]
        public GlyphDefinition NoteDFlatHalf { get; set; }

        [DataMember(Name="noteDFlatWhole")]
        public GlyphDefinition NoteDFlatWhole { get; set; }

        [DataMember(Name="noteDHalf")]
        public GlyphDefinition NoteDHalf { get; set; }

        [DataMember(Name="noteDSharpBlack")]
        public GlyphDefinition NoteDSharpBlack { get; set; }

        [DataMember(Name="noteDSharpHalf")]
        public GlyphDefinition NoteDSharpHalf { get; set; }

        [DataMember(Name="noteDSharpWhole")]
        public GlyphDefinition NoteDSharpWhole { get; set; }

        [DataMember(Name="noteDWhole")]
        public GlyphDefinition NoteDWhole { get; set; }

        [DataMember(Name="noteDoBlack")]
        public GlyphDefinition NoteDoBlack { get; set; }

        [DataMember(Name="noteDoHalf")]
        public GlyphDefinition NoteDoHalf { get; set; }

        [DataMember(Name="noteDoWhole")]
        public GlyphDefinition NoteDoWhole { get; set; }

        [DataMember(Name="noteDoubleWhole")]
        public GlyphDefinition NoteDoubleWhole { get; set; }

        [DataMember(Name="noteDoubleWholeSquare")]
        public GlyphDefinition NoteDoubleWholeSquare { get; set; }

        [DataMember(Name="noteEBlack")]
        public GlyphDefinition NoteEBlack { get; set; }

        [DataMember(Name="noteEFlatBlack")]
        public GlyphDefinition NoteEFlatBlack { get; set; }

        [DataMember(Name="noteEFlatHalf")]
        public GlyphDefinition NoteEFlatHalf { get; set; }

        [DataMember(Name="noteEFlatWhole")]
        public GlyphDefinition NoteEFlatWhole { get; set; }

        [DataMember(Name="noteEHalf")]
        public GlyphDefinition NoteEHalf { get; set; }

        [DataMember(Name="noteESharpBlack")]
        public GlyphDefinition NoteESharpBlack { get; set; }

        [DataMember(Name="noteESharpHalf")]
        public GlyphDefinition NoteESharpHalf { get; set; }

        [DataMember(Name="noteESharpWhole")]
        public GlyphDefinition NoteESharpWhole { get; set; }

        [DataMember(Name="noteEWhole")]
        public GlyphDefinition NoteEWhole { get; set; }

        [DataMember(Name="noteEmptyBlack")]
        public GlyphDefinition NoteEmptyBlack { get; set; }

        [DataMember(Name="noteEmptyHalf")]
        public GlyphDefinition NoteEmptyHalf { get; set; }

        [DataMember(Name="noteEmptyWhole")]
        public GlyphDefinition NoteEmptyWhole { get; set; }

        [DataMember(Name="noteFBlack")]
        public GlyphDefinition NoteFBlack { get; set; }

        [DataMember(Name="noteFFlatBlack")]
        public GlyphDefinition NoteFFlatBlack { get; set; }

        [DataMember(Name="noteFFlatHalf")]
        public GlyphDefinition NoteFFlatHalf { get; set; }

        [DataMember(Name="noteFFlatWhole")]
        public GlyphDefinition NoteFFlatWhole { get; set; }

        [DataMember(Name="noteFHalf")]
        public GlyphDefinition NoteFHalf { get; set; }

        [DataMember(Name="noteFSharpBlack")]
        public GlyphDefinition NoteFSharpBlack { get; set; }

        [DataMember(Name="noteFSharpHalf")]
        public GlyphDefinition NoteFSharpHalf { get; set; }

        [DataMember(Name="noteFSharpWhole")]
        public GlyphDefinition NoteFSharpWhole { get; set; }

        [DataMember(Name="noteFWhole")]
        public GlyphDefinition NoteFWhole { get; set; }

        [DataMember(Name="noteFaBlack")]
        public GlyphDefinition NoteFaBlack { get; set; }

        [DataMember(Name="noteFaHalf")]
        public GlyphDefinition NoteFaHalf { get; set; }

        [DataMember(Name="noteFaWhole")]
        public GlyphDefinition NoteFaWhole { get; set; }

        [DataMember(Name="noteGBlack")]
        public GlyphDefinition NoteGBlack { get; set; }

        [DataMember(Name="noteGFlatBlack")]
        public GlyphDefinition NoteGFlatBlack { get; set; }

        [DataMember(Name="noteGFlatHalf")]
        public GlyphDefinition NoteGFlatHalf { get; set; }

        [DataMember(Name="noteGFlatWhole")]
        public GlyphDefinition NoteGFlatWhole { get; set; }

        [DataMember(Name="noteGHalf")]
        public GlyphDefinition NoteGHalf { get; set; }

        [DataMember(Name="noteGSharpBlack")]
        public GlyphDefinition NoteGSharpBlack { get; set; }

        [DataMember(Name="noteGSharpHalf")]
        public GlyphDefinition NoteGSharpHalf { get; set; }

        [DataMember(Name="noteGSharpWhole")]
        public GlyphDefinition NoteGSharpWhole { get; set; }

        [DataMember(Name="noteGWhole")]
        public GlyphDefinition NoteGWhole { get; set; }

        [DataMember(Name="noteHBlack")]
        public GlyphDefinition NoteHBlack { get; set; }

        [DataMember(Name="noteHHalf")]
        public GlyphDefinition NoteHHalf { get; set; }

        [DataMember(Name="noteHSharpBlack")]
        public GlyphDefinition NoteHSharpBlack { get; set; }

        [DataMember(Name="noteHSharpHalf")]
        public GlyphDefinition NoteHSharpHalf { get; set; }

        [DataMember(Name="noteHSharpWhole")]
        public GlyphDefinition NoteHSharpWhole { get; set; }

        [DataMember(Name="noteHWhole")]
        public GlyphDefinition NoteHWhole { get; set; }

        [DataMember(Name="noteHalfDown")]
        public GlyphDefinition NoteHalfDown { get; set; }

        [DataMember(Name="noteHalfUp")]
        public GlyphDefinition NoteHalfUp { get; set; }

        [DataMember(Name="noteLaBlack")]
        public GlyphDefinition NoteLaBlack { get; set; }

        [DataMember(Name="noteLaHalf")]
        public GlyphDefinition NoteLaHalf { get; set; }

        [DataMember(Name="noteLaWhole")]
        public GlyphDefinition NoteLaWhole { get; set; }

        [DataMember(Name="noteMiBlack")]
        public GlyphDefinition NoteMiBlack { get; set; }

        [DataMember(Name="noteMiHalf")]
        public GlyphDefinition NoteMiHalf { get; set; }

        [DataMember(Name="noteMiWhole")]
        public GlyphDefinition NoteMiWhole { get; set; }

        [DataMember(Name="noteQuarterDown")]
        public GlyphDefinition NoteQuarterDown { get; set; }

        [DataMember(Name="noteQuarterUp")]
        public GlyphDefinition NoteQuarterUp { get; set; }

        [DataMember(Name="noteReBlack")]
        public GlyphDefinition NoteReBlack { get; set; }

        [DataMember(Name="noteReHalf")]
        public GlyphDefinition NoteReHalf { get; set; }

        [DataMember(Name="noteReWhole")]
        public GlyphDefinition NoteReWhole { get; set; }

        [DataMember(Name="noteShapeArrowheadLeftBlack")]
        public GlyphDefinition NoteShapeArrowheadLeftBlack { get; set; }

        [DataMember(Name="noteShapeArrowheadLeftWhite")]
        public GlyphDefinition NoteShapeArrowheadLeftWhite { get; set; }

        [DataMember(Name="noteShapeDiamondBlack")]
        public GlyphDefinition NoteShapeDiamondBlack { get; set; }

        [DataMember(Name="noteShapeDiamondWhite")]
        public GlyphDefinition NoteShapeDiamondWhite { get; set; }

        [DataMember(Name="noteShapeIsoscelesTriangleBlack")]
        public GlyphDefinition NoteShapeIsoscelesTriangleBlack { get; set; }

        [DataMember(Name="noteShapeIsoscelesTriangleWhite")]
        public GlyphDefinition NoteShapeIsoscelesTriangleWhite { get; set; }

        [DataMember(Name="noteShapeKeystoneBlack")]
        public GlyphDefinition NoteShapeKeystoneBlack { get; set; }

        [DataMember(Name="noteShapeKeystoneWhite")]
        public GlyphDefinition NoteShapeKeystoneWhite { get; set; }

        [DataMember(Name="noteShapeMoonBlack")]
        public GlyphDefinition NoteShapeMoonBlack { get; set; }

        [DataMember(Name="noteShapeMoonLeftBlack")]
        public GlyphDefinition NoteShapeMoonLeftBlack { get; set; }

        [DataMember(Name="noteShapeMoonLeftWhite")]
        public GlyphDefinition NoteShapeMoonLeftWhite { get; set; }

        [DataMember(Name="noteShapeMoonWhite")]
        public GlyphDefinition NoteShapeMoonWhite { get; set; }

        [DataMember(Name="noteShapeQuarterMoonBlack")]
        public GlyphDefinition NoteShapeQuarterMoonBlack { get; set; }

        [DataMember(Name="noteShapeQuarterMoonWhite")]
        public GlyphDefinition NoteShapeQuarterMoonWhite { get; set; }

        [DataMember(Name="noteShapeRoundBlack")]
        public GlyphDefinition NoteShapeRoundBlack { get; set; }

        [DataMember(Name="noteShapeRoundWhite")]
        public GlyphDefinition NoteShapeRoundWhite { get; set; }

        [DataMember(Name="noteShapeSquareBlack")]
        public GlyphDefinition NoteShapeSquareBlack { get; set; }

        [DataMember(Name="noteShapeSquareWhite")]
        public GlyphDefinition NoteShapeSquareWhite { get; set; }

        [DataMember(Name="noteShapeTriangleLeftBlack")]
        public GlyphDefinition NoteShapeTriangleLeftBlack { get; set; }

        [DataMember(Name="noteShapeTriangleLeftWhite")]
        public GlyphDefinition NoteShapeTriangleLeftWhite { get; set; }

        [DataMember(Name="noteShapeTriangleRightBlack")]
        public GlyphDefinition NoteShapeTriangleRightBlack { get; set; }

        [DataMember(Name="noteShapeTriangleRightWhite")]
        public GlyphDefinition NoteShapeTriangleRightWhite { get; set; }

        [DataMember(Name="noteShapeTriangleRoundBlack")]
        public GlyphDefinition NoteShapeTriangleRoundBlack { get; set; }

        [DataMember(Name="noteShapeTriangleRoundLeftBlack")]
        public GlyphDefinition NoteShapeTriangleRoundLeftBlack { get; set; }

        [DataMember(Name="noteShapeTriangleRoundLeftWhite")]
        public GlyphDefinition NoteShapeTriangleRoundLeftWhite { get; set; }

        [DataMember(Name="noteShapeTriangleRoundWhite")]
        public GlyphDefinition NoteShapeTriangleRoundWhite { get; set; }

        [DataMember(Name="noteShapeTriangleUpBlack")]
        public GlyphDefinition NoteShapeTriangleUpBlack { get; set; }

        [DataMember(Name="noteShapeTriangleUpWhite")]
        public GlyphDefinition NoteShapeTriangleUpWhite { get; set; }

        [DataMember(Name="noteSiBlack")]
        public GlyphDefinition NoteSiBlack { get; set; }

        [DataMember(Name="noteSiHalf")]
        public GlyphDefinition NoteSiHalf { get; set; }

        [DataMember(Name="noteSiWhole")]
        public GlyphDefinition NoteSiWhole { get; set; }

        [DataMember(Name="noteSoBlack")]
        public GlyphDefinition NoteSoBlack { get; set; }

        [DataMember(Name="noteSoHalf")]
        public GlyphDefinition NoteSoHalf { get; set; }

        [DataMember(Name="noteSoWhole")]
        public GlyphDefinition NoteSoWhole { get; set; }

        [DataMember(Name="noteTiBlack")]
        public GlyphDefinition NoteTiBlack { get; set; }

        [DataMember(Name="noteTiHalf")]
        public GlyphDefinition NoteTiHalf { get; set; }

        [DataMember(Name="noteTiWhole")]
        public GlyphDefinition NoteTiWhole { get; set; }

        [DataMember(Name="noteWhole")]
        public GlyphDefinition NoteWhole { get; set; }

        [DataMember(Name="noteheadBlack")]
        public GlyphDefinition NoteheadBlack { get; set; }

        [DataMember(Name="noteheadCircleSlash")]
        public GlyphDefinition NoteheadCircleSlash { get; set; }

        [DataMember(Name="noteheadCircleX")]
        public GlyphDefinition NoteheadCircleX { get; set; }

        [DataMember(Name="noteheadCircleXDoubleWhole")]
        public GlyphDefinition NoteheadCircleXDoubleWhole { get; set; }

        [DataMember(Name="noteheadCircleXHalf")]
        public GlyphDefinition NoteheadCircleXHalf { get; set; }

        [DataMember(Name="noteheadCircleXWhole")]
        public GlyphDefinition NoteheadCircleXWhole { get; set; }

        [DataMember(Name="noteheadCircledBlack")]
        public GlyphDefinition NoteheadCircledBlack { get; set; }

        [DataMember(Name="noteheadCircledBlackLarge")]
        public GlyphDefinition NoteheadCircledBlackLarge { get; set; }

        [DataMember(Name="noteheadCircledDoubleWhole")]
        public GlyphDefinition NoteheadCircledDoubleWhole { get; set; }

        [DataMember(Name="noteheadCircledDoubleWholeLarge")]
        public GlyphDefinition NoteheadCircledDoubleWholeLarge { get; set; }

        [DataMember(Name="noteheadCircledHalf")]
        public GlyphDefinition NoteheadCircledHalf { get; set; }

        [DataMember(Name="noteheadCircledHalfLarge")]
        public GlyphDefinition NoteheadCircledHalfLarge { get; set; }

        [DataMember(Name="noteheadCircledWhole")]
        public GlyphDefinition NoteheadCircledWhole { get; set; }

        [DataMember(Name="noteheadCircledWholeLarge")]
        public GlyphDefinition NoteheadCircledWholeLarge { get; set; }

        [DataMember(Name="noteheadCircledXLarge")]
        public GlyphDefinition NoteheadCircledXLarge { get; set; }

        [DataMember(Name="noteheadClusterDoubleWhole2nd")]
        public GlyphDefinition NoteheadClusterDoubleWhole2Nd { get; set; }

        [DataMember(Name="noteheadClusterDoubleWhole3rd")]
        public GlyphDefinition NoteheadClusterDoubleWhole3Rd { get; set; }

        [DataMember(Name="noteheadClusterDoubleWholeBottom")]
        public GlyphDefinition NoteheadClusterDoubleWholeBottom { get; set; }

        [DataMember(Name="noteheadClusterDoubleWholeMiddle")]
        public GlyphDefinition NoteheadClusterDoubleWholeMiddle { get; set; }

        [DataMember(Name="noteheadClusterDoubleWholeTop")]
        public GlyphDefinition NoteheadClusterDoubleWholeTop { get; set; }

        [DataMember(Name="noteheadClusterHalf2nd")]
        public GlyphDefinition NoteheadClusterHalf2Nd { get; set; }

        [DataMember(Name="noteheadClusterHalf3rd")]
        public GlyphDefinition NoteheadClusterHalf3Rd { get; set; }

        [DataMember(Name="noteheadClusterHalfBottom")]
        public GlyphDefinition NoteheadClusterHalfBottom { get; set; }

        [DataMember(Name="noteheadClusterHalfMiddle")]
        public GlyphDefinition NoteheadClusterHalfMiddle { get; set; }

        [DataMember(Name="noteheadClusterHalfTop")]
        public GlyphDefinition NoteheadClusterHalfTop { get; set; }

        [DataMember(Name="noteheadClusterQuarter2nd")]
        public GlyphDefinition NoteheadClusterQuarter2Nd { get; set; }

        [DataMember(Name="noteheadClusterQuarter3rd")]
        public GlyphDefinition NoteheadClusterQuarter3Rd { get; set; }

        [DataMember(Name="noteheadClusterQuarterBottom")]
        public GlyphDefinition NoteheadClusterQuarterBottom { get; set; }

        [DataMember(Name="noteheadClusterQuarterMiddle")]
        public GlyphDefinition NoteheadClusterQuarterMiddle { get; set; }

        [DataMember(Name="noteheadClusterQuarterTop")]
        public GlyphDefinition NoteheadClusterQuarterTop { get; set; }

        [DataMember(Name="noteheadClusterRoundBlack")]
        public GlyphDefinition NoteheadClusterRoundBlack { get; set; }

        [DataMember(Name="noteheadClusterRoundWhite")]
        public GlyphDefinition NoteheadClusterRoundWhite { get; set; }

        [DataMember(Name="noteheadClusterSquareBlack")]
        public GlyphDefinition NoteheadClusterSquareBlack { get; set; }

        [DataMember(Name="noteheadClusterSquareWhite")]
        public GlyphDefinition NoteheadClusterSquareWhite { get; set; }

        [DataMember(Name="noteheadClusterWhole2nd")]
        public GlyphDefinition NoteheadClusterWhole2Nd { get; set; }

        [DataMember(Name="noteheadClusterWhole3rd")]
        public GlyphDefinition NoteheadClusterWhole3Rd { get; set; }

        [DataMember(Name="noteheadClusterWholeBottom")]
        public GlyphDefinition NoteheadClusterWholeBottom { get; set; }

        [DataMember(Name="noteheadClusterWholeMiddle")]
        public GlyphDefinition NoteheadClusterWholeMiddle { get; set; }

        [DataMember(Name="noteheadClusterWholeTop")]
        public GlyphDefinition NoteheadClusterWholeTop { get; set; }

        [DataMember(Name="noteheadDiamondBlack")]
        public GlyphDefinition NoteheadDiamondBlack { get; set; }

        [DataMember(Name="noteheadDiamondBlackOld")]
        public GlyphDefinition NoteheadDiamondBlackOld { get; set; }

        [DataMember(Name="noteheadDiamondBlackWide")]
        public GlyphDefinition NoteheadDiamondBlackWide { get; set; }

        [DataMember(Name="noteheadDiamondClusterBlack2nd")]
        public GlyphDefinition NoteheadDiamondClusterBlack2Nd { get; set; }

        [DataMember(Name="noteheadDiamondClusterBlack3rd")]
        public GlyphDefinition NoteheadDiamondClusterBlack3Rd { get; set; }

        [DataMember(Name="noteheadDiamondClusterBlackBottom")]
        public GlyphDefinition NoteheadDiamondClusterBlackBottom { get; set; }

        [DataMember(Name="noteheadDiamondClusterBlackMiddle")]
        public GlyphDefinition NoteheadDiamondClusterBlackMiddle { get; set; }

        [DataMember(Name="noteheadDiamondClusterBlackTop")]
        public GlyphDefinition NoteheadDiamondClusterBlackTop { get; set; }

        [DataMember(Name="noteheadDiamondClusterWhite2nd")]
        public GlyphDefinition NoteheadDiamondClusterWhite2Nd { get; set; }

        [DataMember(Name="noteheadDiamondClusterWhite3rd")]
        public GlyphDefinition NoteheadDiamondClusterWhite3Rd { get; set; }

        [DataMember(Name="noteheadDiamondClusterWhiteBottom")]
        public GlyphDefinition NoteheadDiamondClusterWhiteBottom { get; set; }

        [DataMember(Name="noteheadDiamondClusterWhiteMiddle")]
        public GlyphDefinition NoteheadDiamondClusterWhiteMiddle { get; set; }

        [DataMember(Name="noteheadDiamondClusterWhiteTop")]
        public GlyphDefinition NoteheadDiamondClusterWhiteTop { get; set; }

        [DataMember(Name="noteheadDiamondDoubleWhole")]
        public GlyphDefinition NoteheadDiamondDoubleWhole { get; set; }

        [DataMember(Name="noteheadDiamondDoubleWholeOld")]
        public GlyphDefinition NoteheadDiamondDoubleWholeOld { get; set; }

        [DataMember(Name="noteheadDiamondHalf")]
        public GlyphDefinition NoteheadDiamondHalf { get; set; }

        [DataMember(Name="noteheadDiamondHalfFilled")]
        public GlyphDefinition NoteheadDiamondHalfFilled { get; set; }

        [DataMember(Name="noteheadDiamondHalfOld")]
        public GlyphDefinition NoteheadDiamondHalfOld { get; set; }

        [DataMember(Name="noteheadDiamondHalfWide")]
        public GlyphDefinition NoteheadDiamondHalfWide { get; set; }

        [DataMember(Name="noteheadDiamondOpen")]
        public GlyphDefinition NoteheadDiamondOpen { get; set; }

        [DataMember(Name="noteheadDiamondWhite")]
        public GlyphDefinition NoteheadDiamondWhite { get; set; }

        [DataMember(Name="noteheadDiamondWhiteWide")]
        public GlyphDefinition NoteheadDiamondWhiteWide { get; set; }

        [DataMember(Name="noteheadDiamondWhole")]
        public GlyphDefinition NoteheadDiamondWhole { get; set; }

        [DataMember(Name="noteheadDiamondWholeOld")]
        public GlyphDefinition NoteheadDiamondWholeOld { get; set; }

        [DataMember(Name="noteheadDoubleWhole")]
        public GlyphDefinition NoteheadDoubleWhole { get; set; }

        [DataMember(Name="noteheadDoubleWholeSquare")]
        public GlyphDefinition NoteheadDoubleWholeSquare { get; set; }

        [DataMember(Name="noteheadDoubleWholeWithX")]
        public GlyphDefinition NoteheadDoubleWholeWithX { get; set; }

        [DataMember(Name="noteheadHalf")]
        public GlyphDefinition NoteheadHalf { get; set; }

        [DataMember(Name="noteheadHalfFilled")]
        public GlyphDefinition NoteheadHalfFilled { get; set; }

        [DataMember(Name="noteheadHalfWithX")]
        public GlyphDefinition NoteheadHalfWithX { get; set; }

        [DataMember(Name="noteheadHeavyX")]
        public GlyphDefinition NoteheadHeavyX { get; set; }

        [DataMember(Name="noteheadHeavyXHat")]
        public GlyphDefinition NoteheadHeavyXHat { get; set; }

        [DataMember(Name="noteheadLargeArrowDownBlack")]
        public GlyphDefinition NoteheadLargeArrowDownBlack { get; set; }

        [DataMember(Name="noteheadLargeArrowDownDoubleWhole")]
        public GlyphDefinition NoteheadLargeArrowDownDoubleWhole { get; set; }

        [DataMember(Name="noteheadLargeArrowDownHalf")]
        public GlyphDefinition NoteheadLargeArrowDownHalf { get; set; }

        [DataMember(Name="noteheadLargeArrowDownWhole")]
        public GlyphDefinition NoteheadLargeArrowDownWhole { get; set; }

        [DataMember(Name="noteheadLargeArrowUpBlack")]
        public GlyphDefinition NoteheadLargeArrowUpBlack { get; set; }

        [DataMember(Name="noteheadLargeArrowUpDoubleWhole")]
        public GlyphDefinition NoteheadLargeArrowUpDoubleWhole { get; set; }

        [DataMember(Name="noteheadLargeArrowUpHalf")]
        public GlyphDefinition NoteheadLargeArrowUpHalf { get; set; }

        [DataMember(Name="noteheadLargeArrowUpWhole")]
        public GlyphDefinition NoteheadLargeArrowUpWhole { get; set; }

        [DataMember(Name="noteheadMoonBlack")]
        public GlyphDefinition NoteheadMoonBlack { get; set; }

        [DataMember(Name="noteheadMoonWhite")]
        public GlyphDefinition NoteheadMoonWhite { get; set; }

        [DataMember(Name="noteheadNull")]
        public GlyphDefinition NoteheadNull { get; set; }

        [DataMember(Name="noteheadParenthesis")]
        public GlyphDefinition NoteheadParenthesis { get; set; }

        [DataMember(Name="noteheadParenthesisLeft")]
        public GlyphDefinition NoteheadParenthesisLeft { get; set; }

        [DataMember(Name="noteheadParenthesisRight")]
        public GlyphDefinition NoteheadParenthesisRight { get; set; }

        [DataMember(Name="noteheadPlusBlack")]
        public GlyphDefinition NoteheadPlusBlack { get; set; }

        [DataMember(Name="noteheadPlusDoubleWhole")]
        public GlyphDefinition NoteheadPlusDoubleWhole { get; set; }

        [DataMember(Name="noteheadPlusHalf")]
        public GlyphDefinition NoteheadPlusHalf { get; set; }

        [DataMember(Name="noteheadPlusWhole")]
        public GlyphDefinition NoteheadPlusWhole { get; set; }

        [DataMember(Name="noteheadRectangularClusterBlackBottom")]
        public GlyphDefinition NoteheadRectangularClusterBlackBottom { get; set; }

        [DataMember(Name="noteheadRectangularClusterBlackMiddle")]
        public GlyphDefinition NoteheadRectangularClusterBlackMiddle { get; set; }

        [DataMember(Name="noteheadRectangularClusterBlackTop")]
        public GlyphDefinition NoteheadRectangularClusterBlackTop { get; set; }

        [DataMember(Name="noteheadRectangularClusterWhiteBottom")]
        public GlyphDefinition NoteheadRectangularClusterWhiteBottom { get; set; }

        [DataMember(Name="noteheadRectangularClusterWhiteMiddle")]
        public GlyphDefinition NoteheadRectangularClusterWhiteMiddle { get; set; }

        [DataMember(Name="noteheadRectangularClusterWhiteTop")]
        public GlyphDefinition NoteheadRectangularClusterWhiteTop { get; set; }

        [DataMember(Name="noteheadRoundBlack")]
        public GlyphDefinition NoteheadRoundBlack { get; set; }

        [DataMember(Name="noteheadRoundBlackLarge")]
        public GlyphDefinition NoteheadRoundBlackLarge { get; set; }

        [DataMember(Name="noteheadRoundBlackSlashed")]
        public GlyphDefinition NoteheadRoundBlackSlashed { get; set; }

        [DataMember(Name="noteheadRoundBlackSlashedLarge")]
        public GlyphDefinition NoteheadRoundBlackSlashedLarge { get; set; }

        [DataMember(Name="noteheadRoundWhite")]
        public GlyphDefinition NoteheadRoundWhite { get; set; }

        [DataMember(Name="noteheadRoundWhiteLarge")]
        public GlyphDefinition NoteheadRoundWhiteLarge { get; set; }

        [DataMember(Name="noteheadRoundWhiteSlashed")]
        public GlyphDefinition NoteheadRoundWhiteSlashed { get; set; }

        [DataMember(Name="noteheadRoundWhiteSlashedLarge")]
        public GlyphDefinition NoteheadRoundWhiteSlashedLarge { get; set; }

        [DataMember(Name="noteheadRoundWhiteWithDot")]
        public GlyphDefinition NoteheadRoundWhiteWithDot { get; set; }

        [DataMember(Name="noteheadRoundWhiteWithDotLarge")]
        public GlyphDefinition NoteheadRoundWhiteWithDotLarge { get; set; }

        [DataMember(Name="noteheadSlashDiamondWhite")]
        public GlyphDefinition NoteheadSlashDiamondWhite { get; set; }

        [DataMember(Name="noteheadSlashHorizontalEnds")]
        public GlyphDefinition NoteheadSlashHorizontalEnds { get; set; }

        [DataMember(Name="noteheadSlashHorizontalEndsMuted")]
        public GlyphDefinition NoteheadSlashHorizontalEndsMuted { get; set; }

        [DataMember(Name="noteheadSlashVerticalEnds")]
        public GlyphDefinition NoteheadSlashVerticalEnds { get; set; }

        [DataMember(Name="noteheadSlashVerticalEndsMuted")]
        public GlyphDefinition NoteheadSlashVerticalEndsMuted { get; set; }

        [DataMember(Name="noteheadSlashVerticalEndsSmall")]
        public GlyphDefinition NoteheadSlashVerticalEndsSmall { get; set; }

        [DataMember(Name="noteheadSlashWhiteHalf")]
        public GlyphDefinition NoteheadSlashWhiteHalf { get; set; }

        [DataMember(Name="noteheadSlashWhiteMuted")]
        public GlyphDefinition NoteheadSlashWhiteMuted { get; set; }

        [DataMember(Name="noteheadSlashWhiteWhole")]
        public GlyphDefinition NoteheadSlashWhiteWhole { get; set; }

        [DataMember(Name="noteheadSlashX")]
        public GlyphDefinition NoteheadSlashX { get; set; }

        [DataMember(Name="noteheadSlashedBlack1")]
        public GlyphDefinition NoteheadSlashedBlack1 { get; set; }

        [DataMember(Name="noteheadSlashedBlack2")]
        public GlyphDefinition NoteheadSlashedBlack2 { get; set; }

        [DataMember(Name="noteheadSlashedDoubleWhole1")]
        public GlyphDefinition NoteheadSlashedDoubleWhole1 { get; set; }

        [DataMember(Name="noteheadSlashedDoubleWhole2")]
        public GlyphDefinition NoteheadSlashedDoubleWhole2 { get; set; }

        [DataMember(Name="noteheadSlashedHalf1")]
        public GlyphDefinition NoteheadSlashedHalf1 { get; set; }

        [DataMember(Name="noteheadSlashedHalf2")]
        public GlyphDefinition NoteheadSlashedHalf2 { get; set; }

        [DataMember(Name="noteheadSlashedWhole1")]
        public GlyphDefinition NoteheadSlashedWhole1 { get; set; }

        [DataMember(Name="noteheadSlashedWhole2")]
        public GlyphDefinition NoteheadSlashedWhole2 { get; set; }

        [DataMember(Name="noteheadSquareBlack")]
        public GlyphDefinition NoteheadSquareBlack { get; set; }

        [DataMember(Name="noteheadSquareBlackLarge")]
        public GlyphDefinition NoteheadSquareBlackLarge { get; set; }

        [DataMember(Name="noteheadSquareBlackWhite")]
        public GlyphDefinition NoteheadSquareBlackWhite { get; set; }

        [DataMember(Name="noteheadSquareWhite")]
        public GlyphDefinition NoteheadSquareWhite { get; set; }

        [DataMember(Name="noteheadTriangleDownBlack")]
        public GlyphDefinition NoteheadTriangleDownBlack { get; set; }

        [DataMember(Name="noteheadTriangleDownDoubleWhole")]
        public GlyphDefinition NoteheadTriangleDownDoubleWhole { get; set; }

        [DataMember(Name="noteheadTriangleDownHalf")]
        public GlyphDefinition NoteheadTriangleDownHalf { get; set; }

        [DataMember(Name="noteheadTriangleDownWhite")]
        public GlyphDefinition NoteheadTriangleDownWhite { get; set; }

        [DataMember(Name="noteheadTriangleDownWhole")]
        public GlyphDefinition NoteheadTriangleDownWhole { get; set; }

        [DataMember(Name="noteheadTriangleLeftBlack")]
        public GlyphDefinition NoteheadTriangleLeftBlack { get; set; }

        [DataMember(Name="noteheadTriangleLeftWhite")]
        public GlyphDefinition NoteheadTriangleLeftWhite { get; set; }

        [DataMember(Name="noteheadTriangleRightBlack")]
        public GlyphDefinition NoteheadTriangleRightBlack { get; set; }

        [DataMember(Name="noteheadTriangleRightWhite")]
        public GlyphDefinition NoteheadTriangleRightWhite { get; set; }

        [DataMember(Name="noteheadTriangleRoundDownBlack")]
        public GlyphDefinition NoteheadTriangleRoundDownBlack { get; set; }

        [DataMember(Name="noteheadTriangleRoundDownWhite")]
        public GlyphDefinition NoteheadTriangleRoundDownWhite { get; set; }

        [DataMember(Name="noteheadTriangleUpBlack")]
        public GlyphDefinition NoteheadTriangleUpBlack { get; set; }

        [DataMember(Name="noteheadTriangleUpDoubleWhole")]
        public GlyphDefinition NoteheadTriangleUpDoubleWhole { get; set; }

        [DataMember(Name="noteheadTriangleUpHalf")]
        public GlyphDefinition NoteheadTriangleUpHalf { get; set; }

        [DataMember(Name="noteheadTriangleUpRightBlack")]
        public GlyphDefinition NoteheadTriangleUpRightBlack { get; set; }

        [DataMember(Name="noteheadTriangleUpRightWhite")]
        public GlyphDefinition NoteheadTriangleUpRightWhite { get; set; }

        [DataMember(Name="noteheadTriangleUpWhite")]
        public GlyphDefinition NoteheadTriangleUpWhite { get; set; }

        [DataMember(Name="noteheadTriangleUpWhole")]
        public GlyphDefinition NoteheadTriangleUpWhole { get; set; }

        [DataMember(Name="noteheadVoidWithX")]
        public GlyphDefinition NoteheadVoidWithX { get; set; }

        [DataMember(Name="noteheadWhole")]
        public GlyphDefinition NoteheadWhole { get; set; }

        [DataMember(Name="noteheadWholeFilled")]
        public GlyphDefinition NoteheadWholeFilled { get; set; }

        [DataMember(Name="noteheadWholeWithX")]
        public GlyphDefinition NoteheadWholeWithX { get; set; }

        [DataMember(Name="noteheadXBlack")]
        public GlyphDefinition NoteheadXBlack { get; set; }

        [DataMember(Name="noteheadXDoubleWhole")]
        public GlyphDefinition NoteheadXDoubleWhole { get; set; }

        [DataMember(Name="noteheadXHalf")]
        public GlyphDefinition NoteheadXHalf { get; set; }

        [DataMember(Name="noteheadXOrnate")]
        public GlyphDefinition NoteheadXOrnate { get; set; }

        [DataMember(Name="noteheadXOrnateEllipse")]
        public GlyphDefinition NoteheadXOrnateEllipse { get; set; }

        [DataMember(Name="noteheadXWhole")]
        public GlyphDefinition NoteheadXWhole { get; set; }

        [DataMember(Name="octaveBassa")]
        public GlyphDefinition OctaveBassa { get; set; }

        [DataMember(Name="octaveLoco")]
        public GlyphDefinition OctaveLoco { get; set; }

        [DataMember(Name="octaveParensLeft")]
        public GlyphDefinition OctaveParensLeft { get; set; }

        [DataMember(Name="octaveParensRight")]
        public GlyphDefinition OctaveParensRight { get; set; }

        [DataMember(Name="ornamentBottomLeftConcaveStroke")]
        public GlyphDefinition OrnamentBottomLeftConcaveStroke { get; set; }

        [DataMember(Name="ornamentBottomLeftConcaveStrokeLarge")]
        public GlyphDefinition OrnamentBottomLeftConcaveStrokeLarge { get; set; }

        [DataMember(Name="ornamentBottomLeftConvexStroke")]
        public GlyphDefinition OrnamentBottomLeftConvexStroke { get; set; }

        [DataMember(Name="ornamentBottomRightConcaveStroke")]
        public GlyphDefinition OrnamentBottomRightConcaveStroke { get; set; }

        [DataMember(Name="ornamentBottomRightConvexStroke")]
        public GlyphDefinition OrnamentBottomRightConvexStroke { get; set; }

        [DataMember(Name="ornamentComma")]
        public GlyphDefinition OrnamentComma { get; set; }

        [DataMember(Name="ornamentDoubleObliqueLinesAfterNote")]
        public GlyphDefinition OrnamentDoubleObliqueLinesAfterNote { get; set; }

        [DataMember(Name="ornamentDoubleObliqueLinesBeforeNote")]
        public GlyphDefinition OrnamentDoubleObliqueLinesBeforeNote { get; set; }

        [DataMember(Name="ornamentDownCurve")]
        public GlyphDefinition OrnamentDownCurve { get; set; }

        [DataMember(Name="ornamentHaydn")]
        public GlyphDefinition OrnamentHaydn { get; set; }

        [DataMember(Name="ornamentHighLeftConcaveStroke")]
        public GlyphDefinition OrnamentHighLeftConcaveStroke { get; set; }

        [DataMember(Name="ornamentHighLeftConvexStroke")]
        public GlyphDefinition OrnamentHighLeftConvexStroke { get; set; }

        [DataMember(Name="ornamentHighRightConcaveStroke")]
        public GlyphDefinition OrnamentHighRightConcaveStroke { get; set; }

        [DataMember(Name="ornamentHighRightConvexStroke")]
        public GlyphDefinition OrnamentHighRightConvexStroke { get; set; }

        [DataMember(Name="ornamentHookAfterNote")]
        public GlyphDefinition OrnamentHookAfterNote { get; set; }

        [DataMember(Name="ornamentHookBeforeNote")]
        public GlyphDefinition OrnamentHookBeforeNote { get; set; }

        [DataMember(Name="ornamentLeftFacingHalfCircle")]
        public GlyphDefinition OrnamentLeftFacingHalfCircle { get; set; }

        [DataMember(Name="ornamentLeftFacingHook")]
        public GlyphDefinition OrnamentLeftFacingHook { get; set; }

        [DataMember(Name="ornamentLeftPlus")]
        public GlyphDefinition OrnamentLeftPlus { get; set; }

        [DataMember(Name="ornamentLeftShakeT")]
        public GlyphDefinition OrnamentLeftShakeT { get; set; }

        [DataMember(Name="ornamentLeftVerticalStroke")]
        public GlyphDefinition OrnamentLeftVerticalStroke { get; set; }

        [DataMember(Name="ornamentLeftVerticalStrokeWithCross")]
        public GlyphDefinition OrnamentLeftVerticalStrokeWithCross { get; set; }

        [DataMember(Name="ornamentLowLeftConcaveStroke")]
        public GlyphDefinition OrnamentLowLeftConcaveStroke { get; set; }

        [DataMember(Name="ornamentLowLeftConvexStroke")]
        public GlyphDefinition OrnamentLowLeftConvexStroke { get; set; }

        [DataMember(Name="ornamentLowRightConcaveStroke")]
        public GlyphDefinition OrnamentLowRightConcaveStroke { get; set; }

        [DataMember(Name="ornamentLowRightConvexStroke")]
        public GlyphDefinition OrnamentLowRightConvexStroke { get; set; }

        [DataMember(Name="ornamentMiddleVerticalStroke")]
        public GlyphDefinition OrnamentMiddleVerticalStroke { get; set; }

        [DataMember(Name="ornamentMordent")]
        public GlyphDefinition OrnamentMordent { get; set; }

        [DataMember(Name="ornamentMordentInverted")]
        public GlyphDefinition OrnamentMordentInverted { get; set; }

        [DataMember(Name="ornamentObliqueLineAfterNote")]
        public GlyphDefinition OrnamentObliqueLineAfterNote { get; set; }

        [DataMember(Name="ornamentObliqueLineBeforeNote")]
        public GlyphDefinition OrnamentObliqueLineBeforeNote { get; set; }

        [DataMember(Name="ornamentObliqueLineHorizAfterNote")]
        public GlyphDefinition OrnamentObliqueLineHorizAfterNote { get; set; }

        [DataMember(Name="ornamentObliqueLineHorizBeforeNote")]
        public GlyphDefinition OrnamentObliqueLineHorizBeforeNote { get; set; }

        [DataMember(Name="ornamentOriscus")]
        public GlyphDefinition OrnamentOriscus { get; set; }

        [DataMember(Name="ornamentPinceCouperin")]
        public GlyphDefinition OrnamentPinceCouperin { get; set; }

        [DataMember(Name="ornamentPortDeVoixV")]
        public GlyphDefinition OrnamentPortDeVoixV { get; set; }

        [DataMember(Name="ornamentPrecompAppoggTrill")]
        public GlyphDefinition OrnamentPrecompAppoggTrill { get; set; }

        [DataMember(Name="ornamentPrecompAppoggTrillSuffix")]
        public GlyphDefinition OrnamentPrecompAppoggTrillSuffix { get; set; }

        [DataMember(Name="ornamentPrecompCadence")]
        public GlyphDefinition OrnamentPrecompCadence { get; set; }

        [DataMember(Name="ornamentPrecompCadenceUpperPrefix ")]
        public GlyphDefinition OrnamentPrecompCadenceUpperPrefix { get; set; }

        [DataMember(Name="ornamentPrecompCadenceUpperPrefixTurn")]
        public GlyphDefinition OrnamentPrecompCadenceUpperPrefixTurn { get; set; }

        [DataMember(Name="ornamentPrecompCadenceWithTurn ")]
        public GlyphDefinition OrnamentPrecompCadenceWithTurn { get; set; }

        [DataMember(Name="ornamentPrecompDescendingSlide")]
        public GlyphDefinition OrnamentPrecompDescendingSlide { get; set; }

        [DataMember(Name="ornamentPrecompDoubleCadenceLowerPrefix")]
        public GlyphDefinition OrnamentPrecompDoubleCadenceLowerPrefix { get; set; }

        [DataMember(Name="ornamentPrecompDoubleCadenceUpperPrefix ")]
        public GlyphDefinition OrnamentPrecompDoubleCadenceUpperPrefix { get; set; }

        [DataMember(Name="ornamentPrecompDoubleCadenceUpperPrefixTurn")]
        public GlyphDefinition OrnamentPrecompDoubleCadenceUpperPrefixTurn { get; set; }

        [DataMember(Name="ornamentPrecompInvertedMordentUpperPrefix")]
        public GlyphDefinition OrnamentPrecompInvertedMordentUpperPrefix { get; set; }

        [DataMember(Name="ornamentPrecompMordentRelease")]
        public GlyphDefinition OrnamentPrecompMordentRelease { get; set; }

        [DataMember(Name="ornamentPrecompMordentUpperPrefix")]
        public GlyphDefinition OrnamentPrecompMordentUpperPrefix { get; set; }

        [DataMember(Name="ornamentPrecompPortDeVoixMordent")]
        public GlyphDefinition OrnamentPrecompPortDeVoixMordent { get; set; }

        [DataMember(Name="ornamentPrecompSlide")]
        public GlyphDefinition OrnamentPrecompSlide { get; set; }

        [DataMember(Name="ornamentPrecompSlideTrillBach")]
        public GlyphDefinition OrnamentPrecompSlideTrillBach { get; set; }

        [DataMember(Name="ornamentPrecompSlideTrillDAnglebert")]
        public GlyphDefinition OrnamentPrecompSlideTrillDAnglebert { get; set; }

        [DataMember(Name="ornamentPrecompSlideTrillMarpurg")]
        public GlyphDefinition OrnamentPrecompSlideTrillMarpurg { get; set; }

        [DataMember(Name="ornamentPrecompSlideTrillMuffat")]
        public GlyphDefinition OrnamentPrecompSlideTrillMuffat { get; set; }

        [DataMember(Name="ornamentPrecompSlideTrillSuffixMuffat")]
        public GlyphDefinition OrnamentPrecompSlideTrillSuffixMuffat { get; set; }

        [DataMember(Name="ornamentPrecompTrillLowerSuffix")]
        public GlyphDefinition OrnamentPrecompTrillLowerSuffix { get; set; }

        [DataMember(Name="ornamentPrecompTrillSuffixDandrieu")]
        public GlyphDefinition OrnamentPrecompTrillSuffixDandrieu { get; set; }

        [DataMember(Name="ornamentPrecompTrillWithMordent")]
        public GlyphDefinition OrnamentPrecompTrillWithMordent { get; set; }

        [DataMember(Name="ornamentPrecompTurnTrillBach")]
        public GlyphDefinition OrnamentPrecompTurnTrillBach { get; set; }

        [DataMember(Name="ornamentPrecompTurnTrillDAnglebert")]
        public GlyphDefinition OrnamentPrecompTurnTrillDAnglebert { get; set; }

        [DataMember(Name="ornamentQuilisma")]
        public GlyphDefinition OrnamentQuilisma { get; set; }

        [DataMember(Name="ornamentRightFacingHalfCircle")]
        public GlyphDefinition OrnamentRightFacingHalfCircle { get; set; }

        [DataMember(Name="ornamentRightFacingHook")]
        public GlyphDefinition OrnamentRightFacingHook { get; set; }

        [DataMember(Name="ornamentRightVerticalStroke")]
        public GlyphDefinition OrnamentRightVerticalStroke { get; set; }

        [DataMember(Name="ornamentSchleifer")]
        public GlyphDefinition OrnamentSchleifer { get; set; }

        [DataMember(Name="ornamentShake3")]
        public GlyphDefinition OrnamentShake3 { get; set; }

        [DataMember(Name="ornamentShakeMuffat1")]
        public GlyphDefinition OrnamentShakeMuffat1 { get; set; }

        [DataMember(Name="ornamentShortObliqueLineAfterNote")]
        public GlyphDefinition OrnamentShortObliqueLineAfterNote { get; set; }

        [DataMember(Name="ornamentShortObliqueLineBeforeNote")]
        public GlyphDefinition OrnamentShortObliqueLineBeforeNote { get; set; }

        [DataMember(Name="ornamentTopLeftConcaveStroke")]
        public GlyphDefinition OrnamentTopLeftConcaveStroke { get; set; }

        [DataMember(Name="ornamentTopLeftConvexStroke")]
        public GlyphDefinition OrnamentTopLeftConvexStroke { get; set; }

        [DataMember(Name="ornamentTopRightConcaveStroke")]
        public GlyphDefinition OrnamentTopRightConcaveStroke { get; set; }

        [DataMember(Name="ornamentTopRightConvexStroke")]
        public GlyphDefinition OrnamentTopRightConvexStroke { get; set; }

        [DataMember(Name="ornamentTremblement")]
        public GlyphDefinition OrnamentTremblement { get; set; }

        [DataMember(Name="ornamentTremblementCouperin")]
        public GlyphDefinition OrnamentTremblementCouperin { get; set; }

        [DataMember(Name="ornamentTrill")]
        public GlyphDefinition OrnamentTrill { get; set; }

        [DataMember(Name="ornamentTurn")]
        public GlyphDefinition OrnamentTurn { get; set; }

        [DataMember(Name="ornamentTurnInverted")]
        public GlyphDefinition OrnamentTurnInverted { get; set; }

        [DataMember(Name="ornamentTurnSlash")]
        public GlyphDefinition OrnamentTurnSlash { get; set; }

        [DataMember(Name="ornamentTurnUp")]
        public GlyphDefinition OrnamentTurnUp { get; set; }

        [DataMember(Name="ornamentTurnUpS")]
        public GlyphDefinition OrnamentTurnUpS { get; set; }

        [DataMember(Name="ornamentUpCurve")]
        public GlyphDefinition OrnamentUpCurve { get; set; }

        [DataMember(Name="ornamentVerticalLine")]
        public GlyphDefinition OrnamentVerticalLine { get; set; }

        [DataMember(Name="ornamentZigZagLineNoRightEnd")]
        public GlyphDefinition OrnamentZigZagLineNoRightEnd { get; set; }

        [DataMember(Name="ornamentZigZagLineWithRightEnd")]
        public GlyphDefinition OrnamentZigZagLineWithRightEnd { get; set; }

        [DataMember(Name="ottava")]
        public GlyphDefinition Ottava { get; set; }

        [DataMember(Name="ottavaAlta")]
        public GlyphDefinition OttavaAlta { get; set; }

        [DataMember(Name="ottavaBassa")]
        public GlyphDefinition OttavaBassa { get; set; }

        [DataMember(Name="ottavaBassaBa")]
        public GlyphDefinition OttavaBassaBa { get; set; }

        [DataMember(Name="ottavaBassaVb")]
        public GlyphDefinition OttavaBassaVb { get; set; }

        [DataMember(Name="pendereckiTremolo")]
        public GlyphDefinition PendereckiTremolo { get; set; }

        [DataMember(Name="pictAgogo")]
        public GlyphDefinition PictAgogo { get; set; }

        [DataMember(Name="pictAlmglocken")]
        public GlyphDefinition PictAlmglocken { get; set; }

        [DataMember(Name="pictAnvil")]
        public GlyphDefinition PictAnvil { get; set; }

        [DataMember(Name="pictBambooChimes")]
        public GlyphDefinition PictBambooChimes { get; set; }

        [DataMember(Name="pictBambooScraper")]
        public GlyphDefinition PictBambooScraper { get; set; }

        [DataMember(Name="pictBassDrum")]
        public GlyphDefinition PictBassDrum { get; set; }

        [DataMember(Name="pictBassDrumOnSide")]
        public GlyphDefinition PictBassDrumOnSide { get; set; }

        [DataMember(Name="pictBeaterBow")]
        public GlyphDefinition PictBeaterBow { get; set; }

        [DataMember(Name="pictBeaterBox")]
        public GlyphDefinition PictBeaterBox { get; set; }

        [DataMember(Name="pictBeaterBrassMalletsDown")]
        public GlyphDefinition PictBeaterBrassMalletsDown { get; set; }

        [DataMember(Name="pictBeaterBrassMalletsUp")]
        public GlyphDefinition PictBeaterBrassMalletsUp { get; set; }

        [DataMember(Name="pictBeaterCombiningDashedCircle")]
        public GlyphDefinition PictBeaterCombiningDashedCircle { get; set; }

        [DataMember(Name="pictBeaterCombiningParentheses")]
        public GlyphDefinition PictBeaterCombiningParentheses { get; set; }

        [DataMember(Name="pictBeaterDoubleBassDrumDown")]
        public GlyphDefinition PictBeaterDoubleBassDrumDown { get; set; }

        [DataMember(Name="pictBeaterDoubleBassDrumUp")]
        public GlyphDefinition PictBeaterDoubleBassDrumUp { get; set; }

        [DataMember(Name="pictBeaterFinger")]
        public GlyphDefinition PictBeaterFinger { get; set; }

        [DataMember(Name="pictBeaterFingernails")]
        public GlyphDefinition PictBeaterFingernails { get; set; }

        [DataMember(Name="pictBeaterFist")]
        public GlyphDefinition PictBeaterFist { get; set; }

        [DataMember(Name="pictBeaterGuiroScraper")]
        public GlyphDefinition PictBeaterGuiroScraper { get; set; }

        [DataMember(Name="pictBeaterHammer")]
        public GlyphDefinition PictBeaterHammer { get; set; }

        [DataMember(Name="pictBeaterHammerMetalDown")]
        public GlyphDefinition PictBeaterHammerMetalDown { get; set; }

        [DataMember(Name="pictBeaterHammerMetalUp")]
        public GlyphDefinition PictBeaterHammerMetalUp { get; set; }

        [DataMember(Name="pictBeaterHammerPlasticDown")]
        public GlyphDefinition PictBeaterHammerPlasticDown { get; set; }

        [DataMember(Name="pictBeaterHammerPlasticUp")]
        public GlyphDefinition PictBeaterHammerPlasticUp { get; set; }

        [DataMember(Name="pictBeaterHammerWoodDown")]
        public GlyphDefinition PictBeaterHammerWoodDown { get; set; }

        [DataMember(Name="pictBeaterHammerWoodUp")]
        public GlyphDefinition PictBeaterHammerWoodUp { get; set; }

        [DataMember(Name="pictBeaterHand")]
        public GlyphDefinition PictBeaterHand { get; set; }

        [DataMember(Name="pictBeaterHardBassDrumDown")]
        public GlyphDefinition PictBeaterHardBassDrumDown { get; set; }

        [DataMember(Name="pictBeaterHardBassDrumUp")]
        public GlyphDefinition PictBeaterHardBassDrumUp { get; set; }

        [DataMember(Name="pictBeaterHardGlockenspielDown")]
        public GlyphDefinition PictBeaterHardGlockenspielDown { get; set; }

        [DataMember(Name="pictBeaterHardGlockenspielLeft")]
        public GlyphDefinition PictBeaterHardGlockenspielLeft { get; set; }

        [DataMember(Name="pictBeaterHardGlockenspielRight")]
        public GlyphDefinition PictBeaterHardGlockenspielRight { get; set; }

        [DataMember(Name="pictBeaterHardGlockenspielUp")]
        public GlyphDefinition PictBeaterHardGlockenspielUp { get; set; }

        [DataMember(Name="pictBeaterHardTimpaniDown")]
        public GlyphDefinition PictBeaterHardTimpaniDown { get; set; }

        [DataMember(Name="pictBeaterHardTimpaniLeft")]
        public GlyphDefinition PictBeaterHardTimpaniLeft { get; set; }

        [DataMember(Name="pictBeaterHardTimpaniRight")]
        public GlyphDefinition PictBeaterHardTimpaniRight { get; set; }

        [DataMember(Name="pictBeaterHardTimpaniUp")]
        public GlyphDefinition PictBeaterHardTimpaniUp { get; set; }

        [DataMember(Name="pictBeaterHardXylophoneDown")]
        public GlyphDefinition PictBeaterHardXylophoneDown { get; set; }

        [DataMember(Name="pictBeaterHardXylophoneLeft")]
        public GlyphDefinition PictBeaterHardXylophoneLeft { get; set; }

        [DataMember(Name="pictBeaterHardXylophoneRight")]
        public GlyphDefinition PictBeaterHardXylophoneRight { get; set; }

        [DataMember(Name="pictBeaterHardXylophoneUp")]
        public GlyphDefinition PictBeaterHardXylophoneUp { get; set; }

        [DataMember(Name="pictBeaterHardYarnDown")]
        public GlyphDefinition PictBeaterHardYarnDown { get; set; }

        [DataMember(Name="pictBeaterHardYarnLeft")]
        public GlyphDefinition PictBeaterHardYarnLeft { get; set; }

        [DataMember(Name="pictBeaterHardYarnRight")]
        public GlyphDefinition PictBeaterHardYarnRight { get; set; }

        [DataMember(Name="pictBeaterHardYarnUp")]
        public GlyphDefinition PictBeaterHardYarnUp { get; set; }

        [DataMember(Name="pictBeaterJazzSticksDown")]
        public GlyphDefinition PictBeaterJazzSticksDown { get; set; }

        [DataMember(Name="pictBeaterJazzSticksUp")]
        public GlyphDefinition PictBeaterJazzSticksUp { get; set; }

        [DataMember(Name="pictBeaterKnittingNeedle")]
        public GlyphDefinition PictBeaterKnittingNeedle { get; set; }

        [DataMember(Name="pictBeaterMallet")]
        public GlyphDefinition PictBeaterMallet { get; set; }

        [DataMember(Name="pictBeaterMediumBassDrumDown")]
        public GlyphDefinition PictBeaterMediumBassDrumDown { get; set; }

        [DataMember(Name="pictBeaterMediumBassDrumUp")]
        public GlyphDefinition PictBeaterMediumBassDrumUp { get; set; }

        [DataMember(Name="pictBeaterMediumTimpaniDown")]
        public GlyphDefinition PictBeaterMediumTimpaniDown { get; set; }

        [DataMember(Name="pictBeaterMediumTimpaniLeft")]
        public GlyphDefinition PictBeaterMediumTimpaniLeft { get; set; }

        [DataMember(Name="pictBeaterMediumTimpaniRight")]
        public GlyphDefinition PictBeaterMediumTimpaniRight { get; set; }

        [DataMember(Name="pictBeaterMediumTimpaniUp")]
        public GlyphDefinition PictBeaterMediumTimpaniUp { get; set; }

        [DataMember(Name="pictBeaterMediumXylophoneDown")]
        public GlyphDefinition PictBeaterMediumXylophoneDown { get; set; }

        [DataMember(Name="pictBeaterMediumXylophoneLeft")]
        public GlyphDefinition PictBeaterMediumXylophoneLeft { get; set; }

        [DataMember(Name="pictBeaterMediumXylophoneRight")]
        public GlyphDefinition PictBeaterMediumXylophoneRight { get; set; }

        [DataMember(Name="pictBeaterMediumXylophoneUp")]
        public GlyphDefinition PictBeaterMediumXylophoneUp { get; set; }

        [DataMember(Name="pictBeaterMediumYarnDown")]
        public GlyphDefinition PictBeaterMediumYarnDown { get; set; }

        [DataMember(Name="pictBeaterMediumYarnLeft")]
        public GlyphDefinition PictBeaterMediumYarnLeft { get; set; }

        [DataMember(Name="pictBeaterMediumYarnRight")]
        public GlyphDefinition PictBeaterMediumYarnRight { get; set; }

        [DataMember(Name="pictBeaterMediumYarnUp")]
        public GlyphDefinition PictBeaterMediumYarnUp { get; set; }

        [DataMember(Name="pictBeaterMetalBassDrumDown")]
        public GlyphDefinition PictBeaterMetalBassDrumDown { get; set; }

        [DataMember(Name="pictBeaterMetalBassDrumUp")]
        public GlyphDefinition PictBeaterMetalBassDrumUp { get; set; }

        [DataMember(Name="pictBeaterMetalDown")]
        public GlyphDefinition PictBeaterMetalDown { get; set; }

        [DataMember(Name="pictBeaterMetalHammer")]
        public GlyphDefinition PictBeaterMetalHammer { get; set; }

        [DataMember(Name="pictBeaterMetalLeft")]
        public GlyphDefinition PictBeaterMetalLeft { get; set; }

        [DataMember(Name="pictBeaterMetalRight")]
        public GlyphDefinition PictBeaterMetalRight { get; set; }

        [DataMember(Name="pictBeaterMetalUp")]
        public GlyphDefinition PictBeaterMetalUp { get; set; }

        [DataMember(Name="pictBeaterSnareSticksDown")]
        public GlyphDefinition PictBeaterSnareSticksDown { get; set; }

        [DataMember(Name="pictBeaterSnareSticksUp")]
        public GlyphDefinition PictBeaterSnareSticksUp { get; set; }

        [DataMember(Name="pictBeaterSoftBassDrumDown")]
        public GlyphDefinition PictBeaterSoftBassDrumDown { get; set; }

        [DataMember(Name="pictBeaterSoftBassDrumUp")]
        public GlyphDefinition PictBeaterSoftBassDrumUp { get; set; }

        [DataMember(Name="pictBeaterSoftGlockenspielDown")]
        public GlyphDefinition PictBeaterSoftGlockenspielDown { get; set; }

        [DataMember(Name="pictBeaterSoftGlockenspielLeft")]
        public GlyphDefinition PictBeaterSoftGlockenspielLeft { get; set; }

        [DataMember(Name="pictBeaterSoftGlockenspielRight")]
        public GlyphDefinition PictBeaterSoftGlockenspielRight { get; set; }

        [DataMember(Name="pictBeaterSoftGlockenspielUp")]
        public GlyphDefinition PictBeaterSoftGlockenspielUp { get; set; }

        [DataMember(Name="pictBeaterSoftTimpaniDown")]
        public GlyphDefinition PictBeaterSoftTimpaniDown { get; set; }

        [DataMember(Name="pictBeaterSoftTimpaniLeft")]
        public GlyphDefinition PictBeaterSoftTimpaniLeft { get; set; }

        [DataMember(Name="pictBeaterSoftTimpaniRight")]
        public GlyphDefinition PictBeaterSoftTimpaniRight { get; set; }

        [DataMember(Name="pictBeaterSoftTimpaniUp")]
        public GlyphDefinition PictBeaterSoftTimpaniUp { get; set; }

        [DataMember(Name="pictBeaterSoftXylophone")]
        public GlyphDefinition PictBeaterSoftXylophone { get; set; }

        [DataMember(Name="pictBeaterSoftXylophoneDown")]
        public GlyphDefinition PictBeaterSoftXylophoneDown { get; set; }

        [DataMember(Name="pictBeaterSoftXylophoneLeft")]
        public GlyphDefinition PictBeaterSoftXylophoneLeft { get; set; }

        [DataMember(Name="pictBeaterSoftXylophoneRight")]
        public GlyphDefinition PictBeaterSoftXylophoneRight { get; set; }

        [DataMember(Name="pictBeaterSoftXylophoneUp")]
        public GlyphDefinition PictBeaterSoftXylophoneUp { get; set; }

        [DataMember(Name="pictBeaterSoftYarnDown")]
        public GlyphDefinition PictBeaterSoftYarnDown { get; set; }

        [DataMember(Name="pictBeaterSoftYarnLeft")]
        public GlyphDefinition PictBeaterSoftYarnLeft { get; set; }

        [DataMember(Name="pictBeaterSoftYarnRight")]
        public GlyphDefinition PictBeaterSoftYarnRight { get; set; }

        [DataMember(Name="pictBeaterSoftYarnUp")]
        public GlyphDefinition PictBeaterSoftYarnUp { get; set; }

        [DataMember(Name="pictBeaterSpoonWoodenMallet")]
        public GlyphDefinition PictBeaterSpoonWoodenMallet { get; set; }

        [DataMember(Name="pictBeaterSuperballDown")]
        public GlyphDefinition PictBeaterSuperballDown { get; set; }

        [DataMember(Name="pictBeaterSuperballLeft")]
        public GlyphDefinition PictBeaterSuperballLeft { get; set; }

        [DataMember(Name="pictBeaterSuperballRight")]
        public GlyphDefinition PictBeaterSuperballRight { get; set; }

        [DataMember(Name="pictBeaterSuperballUp")]
        public GlyphDefinition PictBeaterSuperballUp { get; set; }

        [DataMember(Name="pictBeaterTriangleDown")]
        public GlyphDefinition PictBeaterTriangleDown { get; set; }

        [DataMember(Name="pictBeaterTriangleUp")]
        public GlyphDefinition PictBeaterTriangleUp { get; set; }

        [DataMember(Name="pictBeaterWireBrushesDown")]
        public GlyphDefinition PictBeaterWireBrushesDown { get; set; }

        [DataMember(Name="pictBeaterWireBrushesUp")]
        public GlyphDefinition PictBeaterWireBrushesUp { get; set; }

        [DataMember(Name="pictBeaterWoodTimpaniDown")]
        public GlyphDefinition PictBeaterWoodTimpaniDown { get; set; }

        [DataMember(Name="pictBeaterWoodTimpaniLeft")]
        public GlyphDefinition PictBeaterWoodTimpaniLeft { get; set; }

        [DataMember(Name="pictBeaterWoodTimpaniRight")]
        public GlyphDefinition PictBeaterWoodTimpaniRight { get; set; }

        [DataMember(Name="pictBeaterWoodTimpaniUp")]
        public GlyphDefinition PictBeaterWoodTimpaniUp { get; set; }

        [DataMember(Name="pictBeaterWoodXylophoneDown")]
        public GlyphDefinition PictBeaterWoodXylophoneDown { get; set; }

        [DataMember(Name="pictBeaterWoodXylophoneLeft")]
        public GlyphDefinition PictBeaterWoodXylophoneLeft { get; set; }

        [DataMember(Name="pictBeaterWoodXylophoneRight")]
        public GlyphDefinition PictBeaterWoodXylophoneRight { get; set; }

        [DataMember(Name="pictBeaterWoodXylophoneUp")]
        public GlyphDefinition PictBeaterWoodXylophoneUp { get; set; }

        [DataMember(Name="pictBell")]
        public GlyphDefinition PictBell { get; set; }

        [DataMember(Name="pictBellOfCymbal")]
        public GlyphDefinition PictBellOfCymbal { get; set; }

        [DataMember(Name="pictBellPlate")]
        public GlyphDefinition PictBellPlate { get; set; }

        [DataMember(Name="pictBellTree")]
        public GlyphDefinition PictBellTree { get; set; }

        [DataMember(Name="pictBirdWhistle")]
        public GlyphDefinition PictBirdWhistle { get; set; }

        [DataMember(Name="pictBoardClapper")]
        public GlyphDefinition PictBoardClapper { get; set; }

        [DataMember(Name="pictBongos")]
        public GlyphDefinition PictBongos { get; set; }

        [DataMember(Name="pictBrakeDrum")]
        public GlyphDefinition PictBrakeDrum { get; set; }

        [DataMember(Name="pictCabasa")]
        public GlyphDefinition PictCabasa { get; set; }

        [DataMember(Name="pictCannon")]
        public GlyphDefinition PictCannon { get; set; }

        [DataMember(Name="pictCarHorn")]
        public GlyphDefinition PictCarHorn { get; set; }

        [DataMember(Name="pictCastanets")]
        public GlyphDefinition PictCastanets { get; set; }

        [DataMember(Name="pictCastanetsWithHandle")]
        public GlyphDefinition PictCastanetsWithHandle { get; set; }

        [DataMember(Name="pictCelesta")]
        public GlyphDefinition PictCelesta { get; set; }

        [DataMember(Name="pictCencerro")]
        public GlyphDefinition PictCencerro { get; set; }

        [DataMember(Name="pictCenter1")]
        public GlyphDefinition PictCenter1 { get; set; }

        [DataMember(Name="pictCenter2")]
        public GlyphDefinition PictCenter2 { get; set; }

        [DataMember(Name="pictCenter3")]
        public GlyphDefinition PictCenter3 { get; set; }

        [DataMember(Name="pictChainRattle")]
        public GlyphDefinition PictChainRattle { get; set; }

        [DataMember(Name="pictChimes")]
        public GlyphDefinition PictChimes { get; set; }

        [DataMember(Name="pictChineseCymbal")]
        public GlyphDefinition PictChineseCymbal { get; set; }

        [DataMember(Name="pictChokeCymbal")]
        public GlyphDefinition PictChokeCymbal { get; set; }

        [DataMember(Name="pictClaves")]
        public GlyphDefinition PictClaves { get; set; }

        [DataMember(Name="pictCoins")]
        public GlyphDefinition PictCoins { get; set; }

        [DataMember(Name="pictConga")]
        public GlyphDefinition PictConga { get; set; }

        [DataMember(Name="pictCowBell")]
        public GlyphDefinition PictCowBell { get; set; }

        [DataMember(Name="pictCrashCymbals")]
        public GlyphDefinition PictCrashCymbals { get; set; }

        [DataMember(Name="pictCrotales")]
        public GlyphDefinition PictCrotales { get; set; }

        [DataMember(Name="pictCrushStem")]
        public GlyphDefinition PictCrushStem { get; set; }

        [DataMember(Name="pictCuica")]
        public GlyphDefinition PictCuica { get; set; }

        [DataMember(Name="pictCymbalTongs")]
        public GlyphDefinition PictCymbalTongs { get; set; }

        [DataMember(Name="pictDamp1")]
        public GlyphDefinition PictDamp1 { get; set; }

        [DataMember(Name="pictDamp2")]
        public GlyphDefinition PictDamp2 { get; set; }

        [DataMember(Name="pictDamp3")]
        public GlyphDefinition PictDamp3 { get; set; }

        [DataMember(Name="pictDamp4")]
        public GlyphDefinition PictDamp4 { get; set; }

        [DataMember(Name="pictDeadNoteStem")]
        public GlyphDefinition PictDeadNoteStem { get; set; }

        [DataMember(Name="pictDrumStick")]
        public GlyphDefinition PictDrumStick { get; set; }

        [DataMember(Name="pictDuckCall")]
        public GlyphDefinition PictDuckCall { get; set; }

        [DataMember(Name="pictEdgeOfCymbal")]
        public GlyphDefinition PictEdgeOfCymbal { get; set; }

        [DataMember(Name="pictEmptyTrap")]
        public GlyphDefinition PictEmptyTrap { get; set; }

        [DataMember(Name="pictFingerCymbals")]
        public GlyphDefinition PictFingerCymbals { get; set; }

        [DataMember(Name="pictFlexatone")]
        public GlyphDefinition PictFlexatone { get; set; }

        [DataMember(Name="pictFootballRatchet")]
        public GlyphDefinition PictFootballRatchet { get; set; }

        [DataMember(Name="pictGlassHarmonica")]
        public GlyphDefinition PictGlassHarmonica { get; set; }

        [DataMember(Name="pictGlassHarp")]
        public GlyphDefinition PictGlassHarp { get; set; }

        [DataMember(Name="pictGlassPlateChimes")]
        public GlyphDefinition PictGlassPlateChimes { get; set; }

        [DataMember(Name="pictGlassTubeChimes")]
        public GlyphDefinition PictGlassTubeChimes { get; set; }

        [DataMember(Name="pictGlsp")]
        public GlyphDefinition PictGlsp { get; set; }

        [DataMember(Name="pictGlspSmithBrindle")]
        public GlyphDefinition PictGlspSmithBrindle { get; set; }

        [DataMember(Name="pictGobletDrum")]
        public GlyphDefinition PictGobletDrum { get; set; }

        [DataMember(Name="pictGong")]
        public GlyphDefinition PictGong { get; set; }

        [DataMember(Name="pictGongWithButton")]
        public GlyphDefinition PictGongWithButton { get; set; }

        [DataMember(Name="pictGuiro")]
        public GlyphDefinition PictGuiro { get; set; }

        [DataMember(Name="pictGumHardDown")]
        public GlyphDefinition PictGumHardDown { get; set; }

        [DataMember(Name="pictGumHardLeft")]
        public GlyphDefinition PictGumHardLeft { get; set; }

        [DataMember(Name="pictGumHardRight")]
        public GlyphDefinition PictGumHardRight { get; set; }

        [DataMember(Name="pictGumHardUp")]
        public GlyphDefinition PictGumHardUp { get; set; }

        [DataMember(Name="pictGumMediumDown")]
        public GlyphDefinition PictGumMediumDown { get; set; }

        [DataMember(Name="pictGumMediumLeft")]
        public GlyphDefinition PictGumMediumLeft { get; set; }

        [DataMember(Name="pictGumMediumRight")]
        public GlyphDefinition PictGumMediumRight { get; set; }

        [DataMember(Name="pictGumMediumUp")]
        public GlyphDefinition PictGumMediumUp { get; set; }

        [DataMember(Name="pictGumSoftDown")]
        public GlyphDefinition PictGumSoftDown { get; set; }

        [DataMember(Name="pictGumSoftLeft")]
        public GlyphDefinition PictGumSoftLeft { get; set; }

        [DataMember(Name="pictGumSoftRight")]
        public GlyphDefinition PictGumSoftRight { get; set; }

        [DataMember(Name="pictGumSoftUp")]
        public GlyphDefinition PictGumSoftUp { get; set; }

        [DataMember(Name="pictHalfOpen1")]
        public GlyphDefinition PictHalfOpen1 { get; set; }

        [DataMember(Name="pictHalfOpen2")]
        public GlyphDefinition PictHalfOpen2 { get; set; }

        [DataMember(Name="pictHandbell")]
        public GlyphDefinition PictHandbell { get; set; }

        [DataMember(Name="pictHiHat")]
        public GlyphDefinition PictHiHat { get; set; }

        [DataMember(Name="pictHiHatOnStand")]
        public GlyphDefinition PictHiHatOnStand { get; set; }

        [DataMember(Name="pictJawHarp")]
        public GlyphDefinition PictJawHarp { get; set; }

        [DataMember(Name="pictJingleBells")]
        public GlyphDefinition PictJingleBells { get; set; }

        [DataMember(Name="pictKlaxonHorn")]
        public GlyphDefinition PictKlaxonHorn { get; set; }

        [DataMember(Name="pictLeftHandCircle")]
        public GlyphDefinition PictLeftHandCircle { get; set; }

        [DataMember(Name="pictLionsRoar")]
        public GlyphDefinition PictLionsRoar { get; set; }

        [DataMember(Name="pictLithophone")]
        public GlyphDefinition PictLithophone { get; set; }

        [DataMember(Name="pictLogDrum")]
        public GlyphDefinition PictLogDrum { get; set; }

        [DataMember(Name="pictLotusFlute")]
        public GlyphDefinition PictLotusFlute { get; set; }

        [DataMember(Name="pictMar")]
        public GlyphDefinition PictMar { get; set; }

        [DataMember(Name="pictMarSmithBrindle")]
        public GlyphDefinition PictMarSmithBrindle { get; set; }

        [DataMember(Name="pictMaraca")]
        public GlyphDefinition PictMaraca { get; set; }

        [DataMember(Name="pictMaracas")]
        public GlyphDefinition PictMaracas { get; set; }

        [DataMember(Name="pictMegaphone")]
        public GlyphDefinition PictMegaphone { get; set; }

        [DataMember(Name="pictMetalPlateChimes")]
        public GlyphDefinition PictMetalPlateChimes { get; set; }

        [DataMember(Name="pictMetalTubeChimes")]
        public GlyphDefinition PictMetalTubeChimes { get; set; }

        [DataMember(Name="pictMusicalSaw")]
        public GlyphDefinition PictMusicalSaw { get; set; }

        [DataMember(Name="pictNormalPosition")]
        public GlyphDefinition PictNormalPosition { get; set; }

        [DataMember(Name="pictOnRim")]
        public GlyphDefinition PictOnRim { get; set; }

        [DataMember(Name="pictOpen")]
        public GlyphDefinition PictOpen { get; set; }

        [DataMember(Name="pictOpenRimShot")]
        public GlyphDefinition PictOpenRimShot { get; set; }

        [DataMember(Name="pictPistolShot")]
        public GlyphDefinition PictPistolShot { get; set; }

        [DataMember(Name="pictPoliceWhistle")]
        public GlyphDefinition PictPoliceWhistle { get; set; }

        [DataMember(Name="pictQuijada")]
        public GlyphDefinition PictQuijada { get; set; }

        [DataMember(Name="pictRainstick")]
        public GlyphDefinition PictRainstick { get; set; }

        [DataMember(Name="pictRatchet")]
        public GlyphDefinition PictRatchet { get; set; }

        [DataMember(Name="pictRecoReco")]
        public GlyphDefinition PictRecoReco { get; set; }

        [DataMember(Name="pictRightHandSquare")]
        public GlyphDefinition PictRightHandSquare { get; set; }

        [DataMember(Name="pictRim1")]
        public GlyphDefinition PictRim1 { get; set; }

        [DataMember(Name="pictRim2")]
        public GlyphDefinition PictRim2 { get; set; }

        [DataMember(Name="pictRim3")]
        public GlyphDefinition PictRim3 { get; set; }

        [DataMember(Name="pictRimShotOnStem")]
        public GlyphDefinition PictRimShotOnStem { get; set; }

        [DataMember(Name="pictSandpaperBlocks")]
        public GlyphDefinition PictSandpaperBlocks { get; set; }

        [DataMember(Name="pictScrapeAroundRim")]
        public GlyphDefinition PictScrapeAroundRim { get; set; }

        [DataMember(Name="pictScrapeCenterToEdge")]
        public GlyphDefinition PictScrapeCenterToEdge { get; set; }

        [DataMember(Name="pictScrapeEdgeToCenter")]
        public GlyphDefinition PictScrapeEdgeToCenter { get; set; }

        [DataMember(Name="pictShellBells")]
        public GlyphDefinition PictShellBells { get; set; }

        [DataMember(Name="pictShellChimes")]
        public GlyphDefinition PictShellChimes { get; set; }

        [DataMember(Name="pictSiren")]
        public GlyphDefinition PictSiren { get; set; }

        [DataMember(Name="pictSistrum")]
        public GlyphDefinition PictSistrum { get; set; }

        [DataMember(Name="pictSizzleCymbal")]
        public GlyphDefinition PictSizzleCymbal { get; set; }

        [DataMember(Name="pictSleighBell")]
        public GlyphDefinition PictSleighBell { get; set; }

        [DataMember(Name="pictSlideBrushOnGong")]
        public GlyphDefinition PictSlideBrushOnGong { get; set; }

        [DataMember(Name="pictSlideWhistle")]
        public GlyphDefinition PictSlideWhistle { get; set; }

        [DataMember(Name="pictSlitDrum")]
        public GlyphDefinition PictSlitDrum { get; set; }

        [DataMember(Name="pictSnareDrum")]
        public GlyphDefinition PictSnareDrum { get; set; }

        [DataMember(Name="pictSnareDrumMilitary")]
        public GlyphDefinition PictSnareDrumMilitary { get; set; }

        [DataMember(Name="pictSnareDrumSnaresOff")]
        public GlyphDefinition PictSnareDrumSnaresOff { get; set; }

        [DataMember(Name="pictSteelDrums")]
        public GlyphDefinition PictSteelDrums { get; set; }

        [DataMember(Name="pictStickShot")]
        public GlyphDefinition PictStickShot { get; set; }

        [DataMember(Name="pictSuperball")]
        public GlyphDefinition PictSuperball { get; set; }

        [DataMember(Name="pictSuspendedCymbal")]
        public GlyphDefinition PictSuspendedCymbal { get; set; }

        [DataMember(Name="pictSwishStem")]
        public GlyphDefinition PictSwishStem { get; set; }

        [DataMember(Name="pictTabla")]
        public GlyphDefinition PictTabla { get; set; }

        [DataMember(Name="pictTamTam")]
        public GlyphDefinition PictTamTam { get; set; }

        [DataMember(Name="pictTamTamWithBeater")]
        public GlyphDefinition PictTamTamWithBeater { get; set; }

        [DataMember(Name="pictTambourine")]
        public GlyphDefinition PictTambourine { get; set; }

        [DataMember(Name="pictTempleBlocks")]
        public GlyphDefinition PictTempleBlocks { get; set; }

        [DataMember(Name="pictTenorDrum")]
        public GlyphDefinition PictTenorDrum { get; set; }

        [DataMember(Name="pictThundersheet")]
        public GlyphDefinition PictThundersheet { get; set; }

        [DataMember(Name="pictTimbales")]
        public GlyphDefinition PictTimbales { get; set; }

        [DataMember(Name="pictTimpani")]
        public GlyphDefinition PictTimpani { get; set; }

        [DataMember(Name="pictTomTom")]
        public GlyphDefinition PictTomTom { get; set; }

        [DataMember(Name="pictTomTomChinese")]
        public GlyphDefinition PictTomTomChinese { get; set; }

        [DataMember(Name="pictTomTomIndoAmerican")]
        public GlyphDefinition PictTomTomIndoAmerican { get; set; }

        [DataMember(Name="pictTomTomJapanese")]
        public GlyphDefinition PictTomTomJapanese { get; set; }

        [DataMember(Name="pictTriangle")]
        public GlyphDefinition PictTriangle { get; set; }

        [DataMember(Name="pictTubaphone")]
        public GlyphDefinition PictTubaphone { get; set; }

        [DataMember(Name="pictTubularBells")]
        public GlyphDefinition PictTubularBells { get; set; }

        [DataMember(Name="pictTurnLeftStem")]
        public GlyphDefinition PictTurnLeftStem { get; set; }

        [DataMember(Name="pictTurnRightLeftStem")]
        public GlyphDefinition PictTurnRightLeftStem { get; set; }

        [DataMember(Name="pictTurnRightStem")]
        public GlyphDefinition PictTurnRightStem { get; set; }

        [DataMember(Name="pictVib")]
        public GlyphDefinition PictVib { get; set; }

        [DataMember(Name="pictVibMotorOff")]
        public GlyphDefinition PictVibMotorOff { get; set; }

        [DataMember(Name="pictVibSmithBrindle")]
        public GlyphDefinition PictVibSmithBrindle { get; set; }

        [DataMember(Name="pictVibraslap")]
        public GlyphDefinition PictVibraslap { get; set; }

        [DataMember(Name="pictVietnameseHat")]
        public GlyphDefinition PictVietnameseHat { get; set; }

        [DataMember(Name="pictWhip")]
        public GlyphDefinition PictWhip { get; set; }

        [DataMember(Name="pictWindChimesGlass")]
        public GlyphDefinition PictWindChimesGlass { get; set; }

        [DataMember(Name="pictWindMachine")]
        public GlyphDefinition PictWindMachine { get; set; }

        [DataMember(Name="pictWindWhistle")]
        public GlyphDefinition PictWindWhistle { get; set; }

        [DataMember(Name="pictWoodBlock")]
        public GlyphDefinition PictWoodBlock { get; set; }

        [DataMember(Name="pictWoundHardDown")]
        public GlyphDefinition PictWoundHardDown { get; set; }

        [DataMember(Name="pictWoundHardLeft")]
        public GlyphDefinition PictWoundHardLeft { get; set; }

        [DataMember(Name="pictWoundHardRight")]
        public GlyphDefinition PictWoundHardRight { get; set; }

        [DataMember(Name="pictWoundHardUp")]
        public GlyphDefinition PictWoundHardUp { get; set; }

        [DataMember(Name="pictWoundSoftDown")]
        public GlyphDefinition PictWoundSoftDown { get; set; }

        [DataMember(Name="pictWoundSoftLeft")]
        public GlyphDefinition PictWoundSoftLeft { get; set; }

        [DataMember(Name="pictWoundSoftRight")]
        public GlyphDefinition PictWoundSoftRight { get; set; }

        [DataMember(Name="pictWoundSoftUp")]
        public GlyphDefinition PictWoundSoftUp { get; set; }

        [DataMember(Name="pictXyl")]
        public GlyphDefinition PictXyl { get; set; }

        [DataMember(Name="pictXylBass")]
        public GlyphDefinition PictXylBass { get; set; }

        [DataMember(Name="pictXylSmithBrindle")]
        public GlyphDefinition PictXylSmithBrindle { get; set; }

        [DataMember(Name="pictXylTenor")]
        public GlyphDefinition PictXylTenor { get; set; }

        [DataMember(Name="pictXylTenorTrough")]
        public GlyphDefinition PictXylTenorTrough { get; set; }

        [DataMember(Name="pictXylTrough")]
        public GlyphDefinition PictXylTrough { get; set; }

        [DataMember(Name="pluckedBuzzPizzicato")]
        public GlyphDefinition PluckedBuzzPizzicato { get; set; }

        [DataMember(Name="pluckedDamp")]
        public GlyphDefinition PluckedDamp { get; set; }

        [DataMember(Name="pluckedDampAll")]
        public GlyphDefinition PluckedDampAll { get; set; }

        [DataMember(Name="pluckedDampOnStem")]
        public GlyphDefinition PluckedDampOnStem { get; set; }

        [DataMember(Name="pluckedFingernailFlick")]
        public GlyphDefinition PluckedFingernailFlick { get; set; }

        [DataMember(Name="pluckedLeftHandPizzicato")]
        public GlyphDefinition PluckedLeftHandPizzicato { get; set; }

        [DataMember(Name="pluckedPlectrum")]
        public GlyphDefinition PluckedPlectrum { get; set; }

        [DataMember(Name="pluckedSnapPizzicatoAbove")]
        public GlyphDefinition PluckedSnapPizzicatoAbove { get; set; }

        [DataMember(Name="pluckedSnapPizzicatoBelow")]
        public GlyphDefinition PluckedSnapPizzicatoBelow { get; set; }

        [DataMember(Name="pluckedWithFingernails")]
        public GlyphDefinition PluckedWithFingernails { get; set; }

        [DataMember(Name="quindicesima")]
        public GlyphDefinition Quindicesima { get; set; }

        [DataMember(Name="quindicesimaAlta")]
        public GlyphDefinition QuindicesimaAlta { get; set; }

        [DataMember(Name="quindicesimaBassa")]
        public GlyphDefinition QuindicesimaBassa { get; set; }

        [DataMember(Name="quindicesimaBassaMb")]
        public GlyphDefinition QuindicesimaBassaMb { get; set; }

        [DataMember(Name="repeat1Bar")]
        public GlyphDefinition Repeat1Bar { get; set; }

        [DataMember(Name="repeat2Bars")]
        public GlyphDefinition Repeat2Bars { get; set; }

        [DataMember(Name="repeat4Bars")]
        public GlyphDefinition Repeat4Bars { get; set; }

        [DataMember(Name="repeatDot")]
        public GlyphDefinition RepeatDot { get; set; }

        [DataMember(Name="repeatDots")]
        public GlyphDefinition RepeatDots { get; set; }

        [DataMember(Name="repeatLeft")]
        public GlyphDefinition RepeatLeft { get; set; }

        [DataMember(Name="repeatRight")]
        public GlyphDefinition RepeatRight { get; set; }

        [DataMember(Name="repeatRightLeft")]
        public GlyphDefinition RepeatRightLeft { get; set; }

        [DataMember(Name="rest1024th")]
        public GlyphDefinition Rest1024Th { get; set; }

        [DataMember(Name="rest128th")]
        public GlyphDefinition Rest128Th { get; set; }

        [DataMember(Name="rest16th")]
        public GlyphDefinition Rest16Th { get; set; }

        [DataMember(Name="rest256th")]
        public GlyphDefinition Rest256Th { get; set; }

        [DataMember(Name="rest32nd")]
        public GlyphDefinition Rest32Nd { get; set; }

        [DataMember(Name="rest512th")]
        public GlyphDefinition Rest512Th { get; set; }

        [DataMember(Name="rest64th")]
        public GlyphDefinition Rest64Th { get; set; }

        [DataMember(Name="rest8th")]
        public GlyphDefinition Rest8Th { get; set; }

        [DataMember(Name="restDoubleWhole")]
        public GlyphDefinition RestDoubleWhole { get; set; }

        [DataMember(Name="restDoubleWholeLegerLine")]
        public GlyphDefinition RestDoubleWholeLegerLine { get; set; }

        [DataMember(Name="restHBar")]
        public GlyphDefinition RestHBar { get; set; }

        [DataMember(Name="restHBarLeft")]
        public GlyphDefinition RestHBarLeft { get; set; }

        [DataMember(Name="restHBarMiddle")]
        public GlyphDefinition RestHBarMiddle { get; set; }

        [DataMember(Name="restHBarRight")]
        public GlyphDefinition RestHBarRight { get; set; }

        [DataMember(Name="restHalf")]
        public GlyphDefinition RestHalf { get; set; }

        [DataMember(Name="restHalfLegerLine")]
        public GlyphDefinition RestHalfLegerLine { get; set; }

        [DataMember(Name="restLonga")]
        public GlyphDefinition RestLonga { get; set; }

        [DataMember(Name="restMaxima")]
        public GlyphDefinition RestMaxima { get; set; }

        [DataMember(Name="restQuarter")]
        public GlyphDefinition RestQuarter { get; set; }

        [DataMember(Name="restQuarterOld")]
        public GlyphDefinition RestQuarterOld { get; set; }

        [DataMember(Name="restWhole")]
        public GlyphDefinition RestWhole { get; set; }

        [DataMember(Name="restWholeLegerLine")]
        public GlyphDefinition RestWholeLegerLine { get; set; }

        [DataMember(Name="reversedBrace")]
        public GlyphDefinition ReversedBrace { get; set; }

        [DataMember(Name="reversedBracketBottom")]
        public GlyphDefinition ReversedBracketBottom { get; set; }

        [DataMember(Name="reversedBracketTop")]
        public GlyphDefinition ReversedBracketTop { get; set; }

        [DataMember(Name="rightRepeatSmall")]
        public GlyphDefinition RightRepeatSmall { get; set; }

        [DataMember(Name="segno")]
        public GlyphDefinition Segno { get; set; }

        [DataMember(Name="segnoSerpent1")]
        public GlyphDefinition SegnoSerpent1 { get; set; }

        [DataMember(Name="segnoSerpent2")]
        public GlyphDefinition SegnoSerpent2 { get; set; }

        [DataMember(Name="semipitchedPercussionClef1")]
        public GlyphDefinition SemipitchedPercussionClef1 { get; set; }

        [DataMember(Name="semipitchedPercussionClef2")]
        public GlyphDefinition SemipitchedPercussionClef2 { get; set; }

        [DataMember(Name="smnFlat")]
        public GlyphDefinition SmnFlat { get; set; }

        [DataMember(Name="smnFlatWhite")]
        public GlyphDefinition SmnFlatWhite { get; set; }

        [DataMember(Name="smnHistoryDoubleFlat")]
        public GlyphDefinition SmnHistoryDoubleFlat { get; set; }

        [DataMember(Name="smnHistoryDoubleSharp")]
        public GlyphDefinition SmnHistoryDoubleSharp { get; set; }

        [DataMember(Name="smnHistoryFlat")]
        public GlyphDefinition SmnHistoryFlat { get; set; }

        [DataMember(Name="smnHistorySharp")]
        public GlyphDefinition SmnHistorySharp { get; set; }

        [DataMember(Name="smnNatural")]
        public GlyphDefinition SmnNatural { get; set; }

        [DataMember(Name="smnSharp")]
        public GlyphDefinition SmnSharp { get; set; }

        [DataMember(Name="smnSharpDown")]
        public GlyphDefinition SmnSharpDown { get; set; }

        [DataMember(Name="smnSharpWhite")]
        public GlyphDefinition SmnSharpWhite { get; set; }

        [DataMember(Name="smnSharpWhiteDown")]
        public GlyphDefinition SmnSharpWhiteDown { get; set; }

        [DataMember(Name="splitBarDivider")]
        public GlyphDefinition SplitBarDivider { get; set; }

        [DataMember(Name="staff1Line")]
        public GlyphDefinition Staff1Line { get; set; }

        [DataMember(Name="staff1LineNarrow")]
        public GlyphDefinition Staff1LineNarrow { get; set; }

        [DataMember(Name="staff1LineWide")]
        public GlyphDefinition Staff1LineWide { get; set; }

        [DataMember(Name="staff2Lines")]
        public GlyphDefinition Staff2Lines { get; set; }

        [DataMember(Name="staff2LinesNarrow")]
        public GlyphDefinition Staff2LinesNarrow { get; set; }

        [DataMember(Name="staff2LinesWide")]
        public GlyphDefinition Staff2LinesWide { get; set; }

        [DataMember(Name="staff3Lines")]
        public GlyphDefinition Staff3Lines { get; set; }

        [DataMember(Name="staff3LinesNarrow")]
        public GlyphDefinition Staff3LinesNarrow { get; set; }

        [DataMember(Name="staff3LinesWide")]
        public GlyphDefinition Staff3LinesWide { get; set; }

        [DataMember(Name="staff4Lines")]
        public GlyphDefinition Staff4Lines { get; set; }

        [DataMember(Name="staff4LinesNarrow")]
        public GlyphDefinition Staff4LinesNarrow { get; set; }

        [DataMember(Name="staff4LinesWide")]
        public GlyphDefinition Staff4LinesWide { get; set; }

        [DataMember(Name="staff5Lines")]
        public GlyphDefinition Staff5Lines { get; set; }

        [DataMember(Name="staff5LinesNarrow")]
        public GlyphDefinition Staff5LinesNarrow { get; set; }

        [DataMember(Name="staff5LinesWide")]
        public GlyphDefinition Staff5LinesWide { get; set; }

        [DataMember(Name="staff6Lines")]
        public GlyphDefinition Staff6Lines { get; set; }

        [DataMember(Name="staff6LinesNarrow")]
        public GlyphDefinition Staff6LinesNarrow { get; set; }

        [DataMember(Name="staff6LinesWide")]
        public GlyphDefinition Staff6LinesWide { get; set; }

        [DataMember(Name="staffDivideArrowDown")]
        public GlyphDefinition StaffDivideArrowDown { get; set; }

        [DataMember(Name="staffDivideArrowUp")]
        public GlyphDefinition StaffDivideArrowUp { get; set; }

        [DataMember(Name="staffDivideArrowUpDown")]
        public GlyphDefinition StaffDivideArrowUpDown { get; set; }

        [DataMember(Name="staffPosLower1")]
        public GlyphDefinition StaffPosLower1 { get; set; }

        [DataMember(Name="staffPosLower2")]
        public GlyphDefinition StaffPosLower2 { get; set; }

        [DataMember(Name="staffPosLower3")]
        public GlyphDefinition StaffPosLower3 { get; set; }

        [DataMember(Name="staffPosLower4")]
        public GlyphDefinition StaffPosLower4 { get; set; }

        [DataMember(Name="staffPosLower5")]
        public GlyphDefinition StaffPosLower5 { get; set; }

        [DataMember(Name="staffPosLower6")]
        public GlyphDefinition StaffPosLower6 { get; set; }

        [DataMember(Name="staffPosLower7")]
        public GlyphDefinition StaffPosLower7 { get; set; }

        [DataMember(Name="staffPosLower8")]
        public GlyphDefinition StaffPosLower8 { get; set; }

        [DataMember(Name="staffPosRaise1")]
        public GlyphDefinition StaffPosRaise1 { get; set; }

        [DataMember(Name="staffPosRaise2")]
        public GlyphDefinition StaffPosRaise2 { get; set; }

        [DataMember(Name="staffPosRaise3")]
        public GlyphDefinition StaffPosRaise3 { get; set; }

        [DataMember(Name="staffPosRaise4")]
        public GlyphDefinition StaffPosRaise4 { get; set; }

        [DataMember(Name="staffPosRaise5")]
        public GlyphDefinition StaffPosRaise5 { get; set; }

        [DataMember(Name="staffPosRaise6")]
        public GlyphDefinition StaffPosRaise6 { get; set; }

        [DataMember(Name="staffPosRaise7")]
        public GlyphDefinition StaffPosRaise7 { get; set; }

        [DataMember(Name="staffPosRaise8")]
        public GlyphDefinition StaffPosRaise8 { get; set; }

        [DataMember(Name="stem")]
        public GlyphDefinition Stem { get; set; }

        [DataMember(Name="stemBowOnBridge")]
        public GlyphDefinition StemBowOnBridge { get; set; }

        [DataMember(Name="stemBowOnTailpiece")]
        public GlyphDefinition StemBowOnTailpiece { get; set; }

        [DataMember(Name="stemBuzzRoll")]
        public GlyphDefinition StemBuzzRoll { get; set; }

        [DataMember(Name="stemDamp")]
        public GlyphDefinition StemDamp { get; set; }

        [DataMember(Name="stemHarpStringNoise")]
        public GlyphDefinition StemHarpStringNoise { get; set; }

        [DataMember(Name="stemMultiphonicsBlack")]
        public GlyphDefinition StemMultiphonicsBlack { get; set; }

        [DataMember(Name="stemMultiphonicsBlackWhite")]
        public GlyphDefinition StemMultiphonicsBlackWhite { get; set; }

        [DataMember(Name="stemMultiphonicsWhite")]
        public GlyphDefinition StemMultiphonicsWhite { get; set; }

        [DataMember(Name="stemPendereckiTremolo")]
        public GlyphDefinition StemPendereckiTremolo { get; set; }

        [DataMember(Name="stemRimShot")]
        public GlyphDefinition StemRimShot { get; set; }

        [DataMember(Name="stemSprechgesang")]
        public GlyphDefinition StemSprechgesang { get; set; }

        [DataMember(Name="stemSulPonticello")]
        public GlyphDefinition StemSulPonticello { get; set; }

        [DataMember(Name="stemSussurando")]
        public GlyphDefinition StemSussurando { get; set; }

        [DataMember(Name="stemSwished")]
        public GlyphDefinition StemSwished { get; set; }

        [DataMember(Name="stemVibratoPulse")]
        public GlyphDefinition StemVibratoPulse { get; set; }

        [DataMember(Name="stringsBowBehindBridge")]
        public GlyphDefinition StringsBowBehindBridge { get; set; }

        [DataMember(Name="stringsBowOnBridge")]
        public GlyphDefinition StringsBowOnBridge { get; set; }

        [DataMember(Name="stringsBowOnTailpiece")]
        public GlyphDefinition StringsBowOnTailpiece { get; set; }

        [DataMember(Name="stringsChangeBowDirection")]
        public GlyphDefinition StringsChangeBowDirection { get; set; }

        [DataMember(Name="stringsDownBow")]
        public GlyphDefinition StringsDownBow { get; set; }

        [DataMember(Name="stringsDownBowTurned")]
        public GlyphDefinition StringsDownBowTurned { get; set; }

        [DataMember(Name="stringsFouette")]
        public GlyphDefinition StringsFouette { get; set; }

        [DataMember(Name="stringsHalfHarmonic")]
        public GlyphDefinition StringsHalfHarmonic { get; set; }

        [DataMember(Name="stringsHarmonic")]
        public GlyphDefinition StringsHarmonic { get; set; }

        [DataMember(Name="stringsJeteAbove")]
        public GlyphDefinition StringsJeteAbove { get; set; }

        [DataMember(Name="stringsJeteBelow")]
        public GlyphDefinition StringsJeteBelow { get; set; }

        [DataMember(Name="stringsMuteOff")]
        public GlyphDefinition StringsMuteOff { get; set; }

        [DataMember(Name="stringsMuteOn")]
        public GlyphDefinition StringsMuteOn { get; set; }

        [DataMember(Name="stringsOverpressureDownBow")]
        public GlyphDefinition StringsOverpressureDownBow { get; set; }

        [DataMember(Name="stringsOverpressureNoDirection")]
        public GlyphDefinition StringsOverpressureNoDirection { get; set; }

        [DataMember(Name="stringsOverpressurePossibileDownBow")]
        public GlyphDefinition StringsOverpressurePossibileDownBow { get; set; }

        [DataMember(Name="stringsOverpressurePossibileUpBow")]
        public GlyphDefinition StringsOverpressurePossibileUpBow { get; set; }

        [DataMember(Name="stringsOverpressureUpBow")]
        public GlyphDefinition StringsOverpressureUpBow { get; set; }

        [DataMember(Name="stringsThumbPosition")]
        public GlyphDefinition StringsThumbPosition { get; set; }

        [DataMember(Name="stringsThumbPositionTurned")]
        public GlyphDefinition StringsThumbPositionTurned { get; set; }

        [DataMember(Name="stringsUpBow")]
        public GlyphDefinition StringsUpBow { get; set; }

        [DataMember(Name="stringsUpBowTurned")]
        public GlyphDefinition StringsUpBowTurned { get; set; }

        [DataMember(Name="stringsVibratoPulse")]
        public GlyphDefinition StringsVibratoPulse { get; set; }

        [DataMember(Name="systemDivider")]
        public GlyphDefinition SystemDivider { get; set; }

        [DataMember(Name="systemDividerExtraLong")]
        public GlyphDefinition SystemDividerExtraLong { get; set; }

        [DataMember(Name="systemDividerLong")]
        public GlyphDefinition SystemDividerLong { get; set; }

        [DataMember(Name="textAugmentationDot")]
        public GlyphDefinition TextAugmentationDot { get; set; }

        [DataMember(Name="textBlackNoteFrac16thLongStem")]
        public GlyphDefinition TextBlackNoteFrac16ThLongStem { get; set; }

        [DataMember(Name="textBlackNoteFrac16thShortStem")]
        public GlyphDefinition TextBlackNoteFrac16ThShortStem { get; set; }

        [DataMember(Name="textBlackNoteFrac32ndLongStem")]
        public GlyphDefinition TextBlackNoteFrac32NdLongStem { get; set; }

        [DataMember(Name="textBlackNoteFrac8thLongStem")]
        public GlyphDefinition TextBlackNoteFrac8ThLongStem { get; set; }

        [DataMember(Name="textBlackNoteFrac8thShortStem")]
        public GlyphDefinition TextBlackNoteFrac8ThShortStem { get; set; }

        [DataMember(Name="textBlackNoteLongStem")]
        public GlyphDefinition TextBlackNoteLongStem { get; set; }

        [DataMember(Name="textBlackNoteShortStem")]
        public GlyphDefinition TextBlackNoteShortStem { get; set; }

        [DataMember(Name="textCont16thBeamLongStem")]
        public GlyphDefinition TextCont16ThBeamLongStem { get; set; }

        [DataMember(Name="textCont16thBeamShortStem")]
        public GlyphDefinition TextCont16ThBeamShortStem { get; set; }

        [DataMember(Name="textCont32ndBeamLongStem")]
        public GlyphDefinition TextCont32NdBeamLongStem { get; set; }

        [DataMember(Name="textCont8thBeamLongStem")]
        public GlyphDefinition TextCont8ThBeamLongStem { get; set; }

        [DataMember(Name="textCont8thBeamShortStem")]
        public GlyphDefinition TextCont8ThBeamShortStem { get; set; }

        [DataMember(Name="textTie")]
        public GlyphDefinition TextTie { get; set; }

        [DataMember(Name="textTuplet3LongStem")]
        public GlyphDefinition TextTuplet3LongStem { get; set; }

        [DataMember(Name="textTuplet3ShortStem")]
        public GlyphDefinition TextTuplet3ShortStem { get; set; }

        [DataMember(Name="textTupletBracketEndLongStem")]
        public GlyphDefinition TextTupletBracketEndLongStem { get; set; }

        [DataMember(Name="textTupletBracketEndShortStem")]
        public GlyphDefinition TextTupletBracketEndShortStem { get; set; }

        [DataMember(Name="textTupletBracketStartLongStem")]
        public GlyphDefinition TextTupletBracketStartLongStem { get; set; }

        [DataMember(Name="textTupletBracketStartShortStem")]
        public GlyphDefinition TextTupletBracketStartShortStem { get; set; }

        [DataMember(Name="timeSig0")]
        public GlyphDefinition TimeSig0 { get; set; }

        [DataMember(Name="timeSig1")]
        public GlyphDefinition TimeSig1 { get; set; }

        [DataMember(Name="timeSig2")]
        public GlyphDefinition TimeSig2 { get; set; }

        [DataMember(Name="timeSig3")]
        public GlyphDefinition TimeSig3 { get; set; }

        [DataMember(Name="timeSig4")]
        public GlyphDefinition TimeSig4 { get; set; }

        [DataMember(Name="timeSig5")]
        public GlyphDefinition TimeSig5 { get; set; }

        [DataMember(Name="timeSig6")]
        public GlyphDefinition TimeSig6 { get; set; }

        [DataMember(Name="timeSig7")]
        public GlyphDefinition TimeSig7 { get; set; }

        [DataMember(Name="timeSig8")]
        public GlyphDefinition TimeSig8 { get; set; }

        [DataMember(Name="timeSig9")]
        public GlyphDefinition TimeSig9 { get; set; }

        [DataMember(Name="timeSigBracketLeft")]
        public GlyphDefinition TimeSigBracketLeft { get; set; }

        [DataMember(Name="timeSigBracketLeftSmall")]
        public GlyphDefinition TimeSigBracketLeftSmall { get; set; }

        [DataMember(Name="timeSigBracketRight")]
        public GlyphDefinition TimeSigBracketRight { get; set; }

        [DataMember(Name="timeSigBracketRightSmall")]
        public GlyphDefinition TimeSigBracketRightSmall { get; set; }

        [DataMember(Name="timeSigCombDenominator")]
        public GlyphDefinition TimeSigCombDenominator { get; set; }

        [DataMember(Name="timeSigCombNumerator")]
        public GlyphDefinition TimeSigCombNumerator { get; set; }

        [DataMember(Name="timeSigComma")]
        public GlyphDefinition TimeSigComma { get; set; }

        [DataMember(Name="timeSigCommon")]
        public GlyphDefinition TimeSigCommon { get; set; }

        [DataMember(Name="timeSigCut2")]
        public GlyphDefinition TimeSigCut2 { get; set; }

        [DataMember(Name="timeSigCutCommon")]
        public GlyphDefinition TimeSigCutCommon { get; set; }

        [DataMember(Name="timeSigEquals")]
        public GlyphDefinition TimeSigEquals { get; set; }

        [DataMember(Name="timeSigFractionHalf")]
        public GlyphDefinition TimeSigFractionHalf { get; set; }

        [DataMember(Name="timeSigFractionOneThird")]
        public GlyphDefinition TimeSigFractionOneThird { get; set; }

        [DataMember(Name="timeSigFractionQuarter")]
        public GlyphDefinition TimeSigFractionQuarter { get; set; }

        [DataMember(Name="timeSigFractionThreeQuarters")]
        public GlyphDefinition TimeSigFractionThreeQuarters { get; set; }

        [DataMember(Name="timeSigFractionTwoThirds")]
        public GlyphDefinition TimeSigFractionTwoThirds { get; set; }

        [DataMember(Name="timeSigFractionalSlash")]
        public GlyphDefinition TimeSigFractionalSlash { get; set; }

        [DataMember(Name="timeSigMinus")]
        public GlyphDefinition TimeSigMinus { get; set; }

        [DataMember(Name="timeSigMultiply")]
        public GlyphDefinition TimeSigMultiply { get; set; }

        [DataMember(Name="timeSigOpenPenderecki")]
        public GlyphDefinition TimeSigOpenPenderecki { get; set; }

        [DataMember(Name="timeSigParensLeft")]
        public GlyphDefinition TimeSigParensLeft { get; set; }

        [DataMember(Name="timeSigParensLeftSmall")]
        public GlyphDefinition TimeSigParensLeftSmall { get; set; }

        [DataMember(Name="timeSigParensRight")]
        public GlyphDefinition TimeSigParensRight { get; set; }

        [DataMember(Name="timeSigParensRightSmall")]
        public GlyphDefinition TimeSigParensRightSmall { get; set; }

        [DataMember(Name="timeSigPlus")]
        public GlyphDefinition TimeSigPlus { get; set; }

        [DataMember(Name="timeSigPlusSmall")]
        public GlyphDefinition TimeSigPlusSmall { get; set; }

        [DataMember(Name="timeSigSlash")]
        public GlyphDefinition TimeSigSlash { get; set; }

        [DataMember(Name="timeSigX")]
        public GlyphDefinition TimeSigX { get; set; }

        [DataMember(Name="tremolo1")]
        public GlyphDefinition Tremolo1 { get; set; }

        [DataMember(Name="tremolo2")]
        public GlyphDefinition Tremolo2 { get; set; }

        [DataMember(Name="tremolo3")]
        public GlyphDefinition Tremolo3 { get; set; }

        [DataMember(Name="tremolo4")]
        public GlyphDefinition Tremolo4 { get; set; }

        [DataMember(Name="tremolo5")]
        public GlyphDefinition Tremolo5 { get; set; }

        [DataMember(Name="tremoloDivisiDots2")]
        public GlyphDefinition TremoloDivisiDots2 { get; set; }

        [DataMember(Name="tremoloDivisiDots3")]
        public GlyphDefinition TremoloDivisiDots3 { get; set; }

        [DataMember(Name="tremoloDivisiDots4")]
        public GlyphDefinition TremoloDivisiDots4 { get; set; }

        [DataMember(Name="tremoloDivisiDots6")]
        public GlyphDefinition TremoloDivisiDots6 { get; set; }

        [DataMember(Name="tremoloFingered1")]
        public GlyphDefinition TremoloFingered1 { get; set; }

        [DataMember(Name="tremoloFingered2")]
        public GlyphDefinition TremoloFingered2 { get; set; }

        [DataMember(Name="tremoloFingered3")]
        public GlyphDefinition TremoloFingered3 { get; set; }

        [DataMember(Name="tremoloFingered4")]
        public GlyphDefinition TremoloFingered4 { get; set; }

        [DataMember(Name="tremoloFingered5")]
        public GlyphDefinition TremoloFingered5 { get; set; }

        [DataMember(Name="tripleTongueAbove")]
        public GlyphDefinition TripleTongueAbove { get; set; }

        [DataMember(Name="tripleTongueBelow")]
        public GlyphDefinition TripleTongueBelow { get; set; }

        [DataMember(Name="tuplet0")]
        public GlyphDefinition Tuplet0 { get; set; }

        [DataMember(Name="tuplet1")]
        public GlyphDefinition Tuplet1 { get; set; }

        [DataMember(Name="tuplet2")]
        public GlyphDefinition Tuplet2 { get; set; }

        [DataMember(Name="tuplet3")]
        public GlyphDefinition Tuplet3 { get; set; }

        [DataMember(Name="tuplet4")]
        public GlyphDefinition Tuplet4 { get; set; }

        [DataMember(Name="tuplet5")]
        public GlyphDefinition Tuplet5 { get; set; }

        [DataMember(Name="tuplet6")]
        public GlyphDefinition Tuplet6 { get; set; }

        [DataMember(Name="tuplet7")]
        public GlyphDefinition Tuplet7 { get; set; }

        [DataMember(Name="tuplet8")]
        public GlyphDefinition Tuplet8 { get; set; }

        [DataMember(Name="tuplet9")]
        public GlyphDefinition Tuplet9 { get; set; }

        [DataMember(Name="tupletColon")]
        public GlyphDefinition TupletColon { get; set; }

        [DataMember(Name="unmeasuredTremolo")]
        public GlyphDefinition UnmeasuredTremolo { get; set; }

        [DataMember(Name="unmeasuredTremoloSimple")]
        public GlyphDefinition UnmeasuredTremoloSimple { get; set; }

        [DataMember(Name="unpitchedPercussionClef1")]
        public GlyphDefinition UnpitchedPercussionClef1 { get; set; }

        [DataMember(Name="unpitchedPercussionClef2")]
        public GlyphDefinition UnpitchedPercussionClef2 { get; set; }

        [DataMember(Name="ventiduesima")]
        public GlyphDefinition Ventiduesima { get; set; }

        [DataMember(Name="ventiduesimaAlta")]
        public GlyphDefinition VentiduesimaAlta { get; set; }

        [DataMember(Name="ventiduesimaBassa")]
        public GlyphDefinition VentiduesimaBassa { get; set; }

        [DataMember(Name="ventiduesimaBassaMb")]
        public GlyphDefinition VentiduesimaBassaMb { get; set; }

        [DataMember(Name="vocalMouthClosed")]
        public GlyphDefinition VocalMouthClosed { get; set; }

        [DataMember(Name="vocalMouthOpen")]
        public GlyphDefinition VocalMouthOpen { get; set; }

        [DataMember(Name="vocalMouthPursed")]
        public GlyphDefinition VocalMouthPursed { get; set; }

        [DataMember(Name="vocalMouthSlightlyOpen")]
        public GlyphDefinition VocalMouthSlightlyOpen { get; set; }

        [DataMember(Name="vocalMouthWideOpen")]
        public GlyphDefinition VocalMouthWideOpen { get; set; }

        [DataMember(Name="vocalSprechgesang")]
        public GlyphDefinition VocalSprechgesang { get; set; }

        [DataMember(Name="vocalsSussurando")]
        public GlyphDefinition VocalsSussurando { get; set; }

        [DataMember(Name="wiggleArpeggiatoDown")]
        public GlyphDefinition WiggleArpeggiatoDown { get; set; }

        [DataMember(Name="wiggleArpeggiatoDownArrow")]
        public GlyphDefinition WiggleArpeggiatoDownArrow { get; set; }

        [DataMember(Name="wiggleArpeggiatoDownSwash")]
        public GlyphDefinition WiggleArpeggiatoDownSwash { get; set; }

        [DataMember(Name="wiggleArpeggiatoUp")]
        public GlyphDefinition WiggleArpeggiatoUp { get; set; }

        [DataMember(Name="wiggleArpeggiatoUpArrow")]
        public GlyphDefinition WiggleArpeggiatoUpArrow { get; set; }

        [DataMember(Name="wiggleArpeggiatoUpSwash")]
        public GlyphDefinition WiggleArpeggiatoUpSwash { get; set; }

        [DataMember(Name="wiggleCircular")]
        public GlyphDefinition WiggleCircular { get; set; }

        [DataMember(Name="wiggleCircularConstant")]
        public GlyphDefinition WiggleCircularConstant { get; set; }

        [DataMember(Name="wiggleCircularConstantFlipped")]
        public GlyphDefinition WiggleCircularConstantFlipped { get; set; }

        [DataMember(Name="wiggleCircularConstantFlippedLarge")]
        public GlyphDefinition WiggleCircularConstantFlippedLarge { get; set; }

        [DataMember(Name="wiggleCircularConstantLarge")]
        public GlyphDefinition WiggleCircularConstantLarge { get; set; }

        [DataMember(Name="wiggleCircularEnd")]
        public GlyphDefinition WiggleCircularEnd { get; set; }

        [DataMember(Name="wiggleCircularLarge")]
        public GlyphDefinition WiggleCircularLarge { get; set; }

        [DataMember(Name="wiggleCircularLarger")]
        public GlyphDefinition WiggleCircularLarger { get; set; }

        [DataMember(Name="wiggleCircularLargerStill")]
        public GlyphDefinition WiggleCircularLargerStill { get; set; }

        [DataMember(Name="wiggleCircularLargest")]
        public GlyphDefinition WiggleCircularLargest { get; set; }

        [DataMember(Name="wiggleCircularSmall")]
        public GlyphDefinition WiggleCircularSmall { get; set; }

        [DataMember(Name="wiggleCircularStart")]
        public GlyphDefinition WiggleCircularStart { get; set; }

        [DataMember(Name="wiggleGlissando")]
        public GlyphDefinition WiggleGlissando { get; set; }

        [DataMember(Name="wiggleGlissandoGroup1")]
        public GlyphDefinition WiggleGlissandoGroup1 { get; set; }

        [DataMember(Name="wiggleGlissandoGroup2")]
        public GlyphDefinition WiggleGlissandoGroup2 { get; set; }

        [DataMember(Name="wiggleGlissandoGroup3")]
        public GlyphDefinition WiggleGlissandoGroup3 { get; set; }

        [DataMember(Name="wiggleRandom1")]
        public GlyphDefinition WiggleRandom1 { get; set; }

        [DataMember(Name="wiggleRandom2")]
        public GlyphDefinition WiggleRandom2 { get; set; }

        [DataMember(Name="wiggleRandom3")]
        public GlyphDefinition WiggleRandom3 { get; set; }

        [DataMember(Name="wiggleRandom4")]
        public GlyphDefinition WiggleRandom4 { get; set; }

        [DataMember(Name="wiggleSawtooth")]
        public GlyphDefinition WiggleSawtooth { get; set; }

        [DataMember(Name="wiggleSawtoothNarrow")]
        public GlyphDefinition WiggleSawtoothNarrow { get; set; }

        [DataMember(Name="wiggleSawtoothWide")]
        public GlyphDefinition WiggleSawtoothWide { get; set; }

        [DataMember(Name="wiggleSquareWave")]
        public GlyphDefinition WiggleSquareWave { get; set; }

        [DataMember(Name="wiggleSquareWaveNarrow")]
        public GlyphDefinition WiggleSquareWaveNarrow { get; set; }

        [DataMember(Name="wiggleSquareWaveWide")]
        public GlyphDefinition WiggleSquareWaveWide { get; set; }

        [DataMember(Name="wiggleTrill")]
        public GlyphDefinition WiggleTrill { get; set; }

        [DataMember(Name="wiggleTrillFast")]
        public GlyphDefinition WiggleTrillFast { get; set; }

        [DataMember(Name="wiggleTrillFaster")]
        public GlyphDefinition WiggleTrillFaster { get; set; }

        [DataMember(Name="wiggleTrillFasterStill")]
        public GlyphDefinition WiggleTrillFasterStill { get; set; }

        [DataMember(Name="wiggleTrillFastest")]
        public GlyphDefinition WiggleTrillFastest { get; set; }

        [DataMember(Name="wiggleTrillSlow")]
        public GlyphDefinition WiggleTrillSlow { get; set; }

        [DataMember(Name="wiggleTrillSlower")]
        public GlyphDefinition WiggleTrillSlower { get; set; }

        [DataMember(Name="wiggleTrillSlowerStill")]
        public GlyphDefinition WiggleTrillSlowerStill { get; set; }

        [DataMember(Name="wiggleTrillSlowest")]
        public GlyphDefinition WiggleTrillSlowest { get; set; }

        [DataMember(Name="wiggleVIbratoLargestSlower")]
        public GlyphDefinition WiggleVIbratoLargestSlower { get; set; }

        [DataMember(Name="wiggleVIbratoMediumSlower")]
        public GlyphDefinition WiggleVIbratoMediumSlower { get; set; }

        [DataMember(Name="wiggleVibrato")]
        public GlyphDefinition WiggleVibrato { get; set; }

        [DataMember(Name="wiggleVibratoLargeFast")]
        public GlyphDefinition WiggleVibratoLargeFast { get; set; }

        [DataMember(Name="wiggleVibratoLargeFaster")]
        public GlyphDefinition WiggleVibratoLargeFaster { get; set; }

        [DataMember(Name="wiggleVibratoLargeFasterStill")]
        public GlyphDefinition WiggleVibratoLargeFasterStill { get; set; }

        [DataMember(Name="wiggleVibratoLargeFastest")]
        public GlyphDefinition WiggleVibratoLargeFastest { get; set; }

        [DataMember(Name="wiggleVibratoLargeSlow")]
        public GlyphDefinition WiggleVibratoLargeSlow { get; set; }

        [DataMember(Name="wiggleVibratoLargeSlower")]
        public GlyphDefinition WiggleVibratoLargeSlower { get; set; }

        [DataMember(Name="wiggleVibratoLargeSlowest")]
        public GlyphDefinition WiggleVibratoLargeSlowest { get; set; }

        [DataMember(Name="wiggleVibratoLargestFast")]
        public GlyphDefinition WiggleVibratoLargestFast { get; set; }

        [DataMember(Name="wiggleVibratoLargestFaster")]
        public GlyphDefinition WiggleVibratoLargestFaster { get; set; }

        [DataMember(Name="wiggleVibratoLargestFasterStill")]
        public GlyphDefinition WiggleVibratoLargestFasterStill { get; set; }

        [DataMember(Name="wiggleVibratoLargestFastest")]
        public GlyphDefinition WiggleVibratoLargestFastest { get; set; }

        [DataMember(Name="wiggleVibratoLargestSlow")]
        public GlyphDefinition WiggleVibratoLargestSlow { get; set; }

        [DataMember(Name="wiggleVibratoLargestSlowest")]
        public GlyphDefinition WiggleVibratoLargestSlowest { get; set; }

        [DataMember(Name="wiggleVibratoMediumFast")]
        public GlyphDefinition WiggleVibratoMediumFast { get; set; }

        [DataMember(Name="wiggleVibratoMediumFaster")]
        public GlyphDefinition WiggleVibratoMediumFaster { get; set; }

        [DataMember(Name="wiggleVibratoMediumFasterStill")]
        public GlyphDefinition WiggleVibratoMediumFasterStill { get; set; }

        [DataMember(Name="wiggleVibratoMediumFastest")]
        public GlyphDefinition WiggleVibratoMediumFastest { get; set; }

        [DataMember(Name="wiggleVibratoMediumSlow")]
        public GlyphDefinition WiggleVibratoMediumSlow { get; set; }

        [DataMember(Name="wiggleVibratoMediumSlowest")]
        public GlyphDefinition WiggleVibratoMediumSlowest { get; set; }

        [DataMember(Name="wiggleVibratoSmallFast")]
        public GlyphDefinition WiggleVibratoSmallFast { get; set; }

        [DataMember(Name="wiggleVibratoSmallFaster")]
        public GlyphDefinition WiggleVibratoSmallFaster { get; set; }

        [DataMember(Name="wiggleVibratoSmallFasterStill")]
        public GlyphDefinition WiggleVibratoSmallFasterStill { get; set; }

        [DataMember(Name="wiggleVibratoSmallFastest")]
        public GlyphDefinition WiggleVibratoSmallFastest { get; set; }

        [DataMember(Name="wiggleVibratoSmallSlow")]
        public GlyphDefinition WiggleVibratoSmallSlow { get; set; }

        [DataMember(Name="wiggleVibratoSmallSlower")]
        public GlyphDefinition WiggleVibratoSmallSlower { get; set; }

        [DataMember(Name="wiggleVibratoSmallSlowest")]
        public GlyphDefinition WiggleVibratoSmallSlowest { get; set; }

        [DataMember(Name="wiggleVibratoSmallestFast")]
        public GlyphDefinition WiggleVibratoSmallestFast { get; set; }

        [DataMember(Name="wiggleVibratoSmallestFaster")]
        public GlyphDefinition WiggleVibratoSmallestFaster { get; set; }

        [DataMember(Name="wiggleVibratoSmallestFasterStill")]
        public GlyphDefinition WiggleVibratoSmallestFasterStill { get; set; }

        [DataMember(Name="wiggleVibratoSmallestFastest")]
        public GlyphDefinition WiggleVibratoSmallestFastest { get; set; }

        [DataMember(Name="wiggleVibratoSmallestSlow")]
        public GlyphDefinition WiggleVibratoSmallestSlow { get; set; }

        [DataMember(Name="wiggleVibratoSmallestSlower")]
        public GlyphDefinition WiggleVibratoSmallestSlower { get; set; }

        [DataMember(Name="wiggleVibratoSmallestSlowest")]
        public GlyphDefinition WiggleVibratoSmallestSlowest { get; set; }

        [DataMember(Name="wiggleVibratoStart")]
        public GlyphDefinition WiggleVibratoStart { get; set; }

        [DataMember(Name="wiggleVibratoWide")]
        public GlyphDefinition WiggleVibratoWide { get; set; }

        [DataMember(Name="wiggleWavy")]
        public GlyphDefinition WiggleWavy { get; set; }

        [DataMember(Name="wiggleWavyNarrow")]
        public GlyphDefinition WiggleWavyNarrow { get; set; }

        [DataMember(Name="wiggleWavyWide")]
        public GlyphDefinition WiggleWavyWide { get; set; }

        [DataMember(Name="windClosedHole")]
        public GlyphDefinition WindClosedHole { get; set; }

        [DataMember(Name="windFlatEmbouchure")]
        public GlyphDefinition WindFlatEmbouchure { get; set; }

        [DataMember(Name="windHalfClosedHole1")]
        public GlyphDefinition WindHalfClosedHole1 { get; set; }

        [DataMember(Name="windHalfClosedHole2")]
        public GlyphDefinition WindHalfClosedHole2 { get; set; }

        [DataMember(Name="windHalfClosedHole3")]
        public GlyphDefinition WindHalfClosedHole3 { get; set; }

        [DataMember(Name="windLessRelaxedEmbouchure")]
        public GlyphDefinition WindLessRelaxedEmbouchure { get; set; }

        [DataMember(Name="windLessTightEmbouchure")]
        public GlyphDefinition WindLessTightEmbouchure { get; set; }

        [DataMember(Name="windMultiphonicsBlackStem")]
        public GlyphDefinition WindMultiphonicsBlackStem { get; set; }

        [DataMember(Name="windMultiphonicsBlackWhiteStem")]
        public GlyphDefinition WindMultiphonicsBlackWhiteStem { get; set; }

        [DataMember(Name="windMultiphonicsWhiteStem")]
        public GlyphDefinition WindMultiphonicsWhiteStem { get; set; }

        [DataMember(Name="windOpenHole")]
        public GlyphDefinition WindOpenHole { get; set; }

        [DataMember(Name="windReedPositionIn")]
        public GlyphDefinition WindReedPositionIn { get; set; }

        [DataMember(Name="windReedPositionNormal")]
        public GlyphDefinition WindReedPositionNormal { get; set; }

        [DataMember(Name="windReedPositionOut")]
        public GlyphDefinition WindReedPositionOut { get; set; }

        [DataMember(Name="windRelaxedEmbouchure")]
        public GlyphDefinition WindRelaxedEmbouchure { get; set; }

        [DataMember(Name="windSharpEmbouchure")]
        public GlyphDefinition WindSharpEmbouchure { get; set; }

        [DataMember(Name="windStrongAirPressure")]
        public GlyphDefinition WindStrongAirPressure { get; set; }

        [DataMember(Name="windThreeQuartersClosedHole")]
        public GlyphDefinition WindThreeQuartersClosedHole { get; set; }

        [DataMember(Name="windTightEmbouchure")]
        public GlyphDefinition WindTightEmbouchure { get; set; }

        [DataMember(Name="windTrillKey")]
        public GlyphDefinition WindTrillKey { get; set; }

        [DataMember(Name="windVeryTightEmbouchure")]
        public GlyphDefinition WindVeryTightEmbouchure { get; set; }

        [DataMember(Name="windWeakAirPressure")]
        public GlyphDefinition WindWeakAirPressure { get; set; }
    }
}