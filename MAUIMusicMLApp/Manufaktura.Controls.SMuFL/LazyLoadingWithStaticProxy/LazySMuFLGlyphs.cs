using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Core.Serialization;
using System;
using System.IO;
using System.Reflection;

namespace Manufaktura.Controls.SMuFL.LazyLoadingWithStaticProxy
{
    public class LazySMuFLGlyphs : LazyLoadJsonStaticProxy<ISMuFLGlyphs>, ISMuFLGlyphs
    {
        private static Lazy<ISMuFLGlyphs> instance = new Lazy<ISMuFLGlyphs>(() =>
        {
            var assembly = typeof(ISMuFLGlyphs).GetTypeInfo().Assembly;
            var resourceName = $"{typeof(ISMuFLGlyphs).Namespace}.glyphnames.json";

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                return new LazySMuFLGlyphs(result);
            }
        });

        internal static ISMuFLGlyphs Instance => instance.Value;

        private LazySMuFLGlyphs(string jsonString) : base(jsonString, new[] { typeof(LazySMuFLFontMetadata), typeof(LazySMuFLGlyphs), typeof(LazyGlyphBBoxes) })
        {
        }

        public GlyphDefinition The4StringTabClef => Load() as GlyphDefinition;

        public GlyphDefinition The6StringTabClef => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal11LargeDiesisDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal11LargeDiesisUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal11MediumDiesisDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal11MediumDiesisUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal11V19LargeDiesisDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal11V19LargeDiesisUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal11V19MediumDiesisDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal11V19MediumDiesisUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal11V49CommaDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal11V49CommaUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal143CommaDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal143CommaUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal17CommaDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal17CommaUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal17KleismaDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal17KleismaUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal19CommaDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal19CommaUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal19SchismaDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal19SchismaUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal23CommaDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal23CommaUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal23SmallDiesisDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal23SmallDiesisUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal25SmallDiesisDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal25SmallDiesisUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal35LargeDiesisDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal35LargeDiesisUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal35MediumDiesisDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal35MediumDiesisUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal49LargeDiesisDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal49LargeDiesisUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal49MediumDiesisDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal49MediumDiesisUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal49SmallDiesisDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal49SmallDiesisUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal55CommaDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal55CommaUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal5CommaDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal5CommaUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal5V11SmallDiesisDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal5V11SmallDiesisUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal5V13LargeDiesisDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal5V13LargeDiesisUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal5V13MediumDiesisDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal5V13MediumDiesisUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal5V19CommaDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal5V19CommaUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal5V23SmallDiesisDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal5V23SmallDiesisUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal5V49MediumDiesisDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal5V49MediumDiesisUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal5V7KleismaDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal5V7KleismaUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal7CommaDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal7CommaUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal7V11CommaDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal7V11CommaUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal7V11KleismaDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal7V11KleismaUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal7V19CommaDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittal7V19CommaUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalAcute => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleFlat11V49CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleFlat143CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleFlat17CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleFlat17KUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleFlat19CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleFlat19SUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleFlat23CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleFlat23SUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleFlat25SUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleFlat49SUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleFlat55CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleFlat5CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleFlat5V11SUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleFlat5V19CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleFlat5V23SUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleFlat5V7KUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleFlat7CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleFlat7V11CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleFlat7V11KUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleFlat7V19CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleSharp11V49CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleSharp143CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleSharp17CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleSharp17KDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleSharp19CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleSharp19SDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleSharp23CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleSharp23SDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleSharp25SDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleSharp49SDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleSharp55CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleSharp5CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleSharp5V11SDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleSharp5V19CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleSharp5V23SDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleSharp5V7KDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleSharp7CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleSharp7V11CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleSharp7V11KDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalDoubleSharp7V19CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat11LDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat11MDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat11V19LDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat11V19MDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat11V49CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat11V49CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat143CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat143CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat17CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat17CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat17KDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat17KUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat19CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat19CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat19SDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat19SUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat23CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat23CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat23SDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat23SUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat25SDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat25SUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat35LDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat35MDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat49LDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat49MDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat49SDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat49SUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat55CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat55CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat5CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat5CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat5V11SDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat5V11SUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat5V13LDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat5V13MDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat5V19CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat5V19CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat5V23SDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat5V23SUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat5V49MDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat5V7KDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat5V7KUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat7CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat7CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat7V11CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat7V11CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat7V11KDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat7V11KUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat7V19CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalFlat7V19CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalGrave => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalShaftDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalShaftUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp11LUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp11MUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp11V19LUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp11V19MUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp11V49CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp11V49CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp143CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp143CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp17CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp17CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp17KDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp17KUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp19CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp19CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp19SDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp19SUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp23CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp23CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp23SDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp23SUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp25SDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp25SUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp35LUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp35MUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp49LUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp49MUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp49SDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp49SUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp55CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp55CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp5CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp5CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp5V11SDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp5V11SUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp5V13LUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp5V13MUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp5V19CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp5V19CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp5V23SDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp5V23SUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp5V49MUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp5V7KDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp5V7KUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp7CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp7CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp7V11CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp7V11CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp7V11KDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp7V11KUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp7V19CDown => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalSharp7V19CUp => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalUnused1 => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalUnused2 => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalUnused3 => Load() as GlyphDefinition;

        public GlyphDefinition AccSagittalUnused4 => Load() as GlyphDefinition;

        public GlyphDefinition AccdnCombDot => Load() as GlyphDefinition;

        public GlyphDefinition AccdnCombLh2RanksEmpty => Load() as GlyphDefinition;

        public GlyphDefinition AccdnCombLh3RanksEmptySquare => Load() as GlyphDefinition;

        public GlyphDefinition AccdnCombRh3RanksEmpty => Load() as GlyphDefinition;

        public GlyphDefinition AccdnCombRh4RanksEmpty => Load() as GlyphDefinition;

        public GlyphDefinition AccdnDiatonicClef => Load() as GlyphDefinition;

        public GlyphDefinition AccdnLh2Ranks16Round => Load() as GlyphDefinition;

        public GlyphDefinition AccdnLh2Ranks8Plus16Round => Load() as GlyphDefinition;

        public GlyphDefinition AccdnLh2Ranks8Round => Load() as GlyphDefinition;

        public GlyphDefinition AccdnLh2RanksFullMasterRound => Load() as GlyphDefinition;

        public GlyphDefinition AccdnLh2RanksMasterPlus16Round => Load() as GlyphDefinition;

        public GlyphDefinition AccdnLh2RanksMasterRound => Load() as GlyphDefinition;

        public GlyphDefinition AccdnLh3Ranks2Plus8Square => Load() as GlyphDefinition;

        public GlyphDefinition AccdnLh3Ranks2Square => Load() as GlyphDefinition;

        public GlyphDefinition AccdnLh3Ranks8Square => Load() as GlyphDefinition;

        public GlyphDefinition AccdnLh3RanksDouble8Square => Load() as GlyphDefinition;

        public GlyphDefinition AccdnLh3RanksTuttiSquare => Load() as GlyphDefinition;

        public GlyphDefinition AccdnPull => Load() as GlyphDefinition;

        public GlyphDefinition AccdnPush => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh3RanksAccordion => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh3RanksAuthenticMusette => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh3RanksBandoneon => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh3RanksBassoon => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh3RanksClarinet => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh3RanksDoubleTremoloLower8Ve => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh3RanksDoubleTremoloUpper8Ve => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh3RanksFullFactory => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh3RanksHarmonium => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh3RanksImitationMusette => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh3RanksLowerTremolo8 => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh3RanksMaster => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh3RanksOboe => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh3RanksOrgan => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh3RanksPiccolo => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh3RanksTremoloLower8Ve => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh3RanksTremoloUpper8Ve => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh3RanksTwoChoirs => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh3RanksUpperTremolo8 => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh3RanksViolin => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh4RanksAlto => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh4RanksBassAlto => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh4RanksMaster => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh4RanksSoftBass => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh4RanksSoftTenor => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh4RanksSoprano => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRh4RanksTenor => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRicochet2 => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRicochet3 => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRicochet4 => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRicochet5 => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRicochet6 => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRicochetStem2 => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRicochetStem3 => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRicochetStem4 => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRicochetStem5 => Load() as GlyphDefinition;

        public GlyphDefinition AccdnRicochetStem6 => Load() as GlyphDefinition;

        public GlyphDefinition Accidental1CommaFlat => Load() as GlyphDefinition;

        public GlyphDefinition Accidental1CommaSharp => Load() as GlyphDefinition;

        public GlyphDefinition Accidental2CommaFlat => Load() as GlyphDefinition;

        public GlyphDefinition Accidental2CommaSharp => Load() as GlyphDefinition;

        public GlyphDefinition Accidental3CommaFlat => Load() as GlyphDefinition;

        public GlyphDefinition Accidental3CommaSharp => Load() as GlyphDefinition;

        public GlyphDefinition Accidental4CommaFlat => Load() as GlyphDefinition;

        public GlyphDefinition Accidental5CommaSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalArrowDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalArrowUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalBakiyeFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalBakiyeSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalBuyukMucennebFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalBuyukMucennebSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalCombiningCloseCurlyBrace => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalCombiningLower17Schisma => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalCombiningLower19Schisma => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalCombiningLower23Limit29LimitComma => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalCombiningLower31Schisma => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalCombiningOpenCurlyBrace => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalCombiningRaise17Schisma => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalCombiningRaise19Schisma => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalCombiningRaise23Limit29LimitComma => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalCombiningRaise31Schisma => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalCommaSlashDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalCommaSlashUp => Load() as GlyphDefinition;

        public GlyphDefinition GlyphDefinition => Load() as GlyphDefinition;

        public GlyphDefinition GlyphDefinitionEqualTempered => Load() as GlyphDefinition;

        public GlyphDefinition GlyphDefinitionOneArrowDown => Load() as GlyphDefinition;

        public GlyphDefinition GlyphDefinitionOneArrowUp => Load() as GlyphDefinition;

        public GlyphDefinition GlyphDefinitionReversed => Load() as GlyphDefinition;

        public GlyphDefinition GlyphDefinitionThreeArrowsDown => Load() as GlyphDefinition;

        public GlyphDefinition GlyphDefinitionThreeArrowsUp => Load() as GlyphDefinition;

        public GlyphDefinition GlyphDefinitionTurned => Load() as GlyphDefinition;

        public GlyphDefinition GlyphDefinitionTwoArrowsDown => Load() as GlyphDefinition;

        public GlyphDefinition GlyphDefinitionTwoArrowsUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalDoubleSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalDoubleSharpEqualTempered => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalDoubleSharpOneArrowDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalDoubleSharpOneArrowUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalDoubleSharpThreeArrowsDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalDoubleSharpThreeArrowsUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalDoubleSharpTwoArrowsDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalDoubleSharpTwoArrowsUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalFilledReversedFlatAndFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalFilledReversedFlatAndFlatArrowDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalFilledReversedFlatAndFlatArrowUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalFilledReversedFlatArrowDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalFilledReversedFlatArrowUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalFiveQuarterTonesFlatArrowDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalFiveQuarterTonesSharpArrowUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalFlatEqualTempered => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalFlatOneArrowDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalFlatOneArrowUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalFlatThreeArrowsDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalFlatThreeArrowsUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalFlatTurned => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalFlatTwoArrowsDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalFlatTwoArrowsUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalHalfSharpArrowDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalHalfSharpArrowUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalJohnston13 => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalJohnston31 => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalJohnstonDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalJohnstonEl => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalJohnstonMinus => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalJohnstonPlus => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalJohnstonSeven => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalJohnstonUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalKomaFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalKomaSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalKoron => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalKucukMucennebFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalKucukMucennebSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalLargeDoubleSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalLowerOneSeptimalComma => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalLowerOneTridecimalQuartertone => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalLowerOneUndecimalQuartertone => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalLowerTwoSeptimalCommas => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalNarrowReversedFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalNarrowReversedFlatAndFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalNatural => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalNaturalEqualTempered => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalNaturalFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalNaturalOneArrowDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalNaturalOneArrowUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalNaturalReversed => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalNaturalSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalNaturalThreeArrowsDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalNaturalThreeArrowsUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalNaturalTwoArrowsDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalNaturalTwoArrowsUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalOneAndAHalfSharpsArrowDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalOneAndAHalfSharpsArrowUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalOneThirdToneFlatFerneyhough => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalOneThirdToneSharpFerneyhough => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalParensLeft => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalParensRight => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalQuarterToneFlat4 => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalQuarterToneFlatArrowUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalQuarterToneFlatFilledReversed => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalQuarterToneFlatNaturalArrowDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalQuarterToneFlatPenderecki => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalQuarterToneFlatStein => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalQuarterToneFlatVanBlankenburg => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalQuarterToneSharp4 => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalQuarterToneSharpArrowDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalQuarterToneSharpBusotti => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalQuarterToneSharpNaturalArrowUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalQuarterToneSharpStein => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalQuarterToneSharpWiggle => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalRaiseOneSeptimalComma => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalRaiseOneTridecimalQuartertone => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalRaiseOneUndecimalQuartertone => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalRaiseTwoSeptimalCommas => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalReversedFlatAndFlatArrowDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalReversedFlatAndFlatArrowUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalReversedFlatArrowDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalReversedFlatArrowUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalSharpEqualTempered => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalSharpOneArrowDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalSharpOneArrowUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalSharpOneHorizontalStroke => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalSharpReversed => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalSharpSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalSharpThreeArrowsDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalSharpThreeArrowsUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalSharpTwoArrowsDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalSharpTwoArrowsUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalSims12Down => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalSims12Up => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalSims4Down => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalSims4Up => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalSims6Down => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalSims6Up => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalSori => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalTavenerFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalTavenerSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalThreeQuarterTonesFlatArrowDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalThreeQuarterTonesFlatArrowUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalThreeQuarterTonesFlatCouper => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalThreeQuarterTonesFlatGrisey => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalThreeQuarterTonesFlatTartini => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalThreeQuarterTonesFlatZimmermann => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalThreeQuarterTonesSharpArrowDown => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalThreeQuarterTonesSharpArrowUp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalThreeQuarterTonesSharpBusotti => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalThreeQuarterTonesSharpStein => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalTripleFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalTripleSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalTwoThirdTonesFlatFerneyhough => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalTwoThirdTonesSharpFerneyhough => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWilsonMinus => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWilsonPlus => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWyschnegradsky10TwelfthsFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWyschnegradsky10TwelfthsSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWyschnegradsky11TwelfthsFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWyschnegradsky11TwelfthsSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWyschnegradsky1TwelfthsFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWyschnegradsky1TwelfthsSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWyschnegradsky2TwelfthsFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWyschnegradsky2TwelfthsSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWyschnegradsky3TwelfthsFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWyschnegradsky3TwelfthsSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWyschnegradsky4TwelfthsFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWyschnegradsky4TwelfthsSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWyschnegradsky5TwelfthsFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWyschnegradsky5TwelfthsSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWyschnegradsky6TwelfthsFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWyschnegradsky6TwelfthsSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWyschnegradsky7TwelfthsFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWyschnegradsky7TwelfthsSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWyschnegradsky8TwelfthsFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWyschnegradsky8TwelfthsSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWyschnegradsky9TwelfthsFlat => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalWyschnegradsky9TwelfthsSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalXenakisOneThirdToneSharp => Load() as GlyphDefinition;

        public GlyphDefinition AccidentalXenakisTwoThirdTonesSharp => Load() as GlyphDefinition;

        public GlyphDefinition AnalyticsChoralmelodie => Load() as GlyphDefinition;

        public GlyphDefinition AnalyticsEndStimme => Load() as GlyphDefinition;

        public GlyphDefinition AnalyticsHauptrhythmus => Load() as GlyphDefinition;

        public GlyphDefinition AnalyticsHauptstimme => Load() as GlyphDefinition;

        public GlyphDefinition AnalyticsInversion1 => Load() as GlyphDefinition;

        public GlyphDefinition AnalyticsNebenstimme => Load() as GlyphDefinition;

        public GlyphDefinition AnalyticsStartStimme => Load() as GlyphDefinition;

        public GlyphDefinition AnalyticsTheme => Load() as GlyphDefinition;

        public GlyphDefinition AnalyticsTheme1 => Load() as GlyphDefinition;

        public GlyphDefinition AnalyticsThemeInversion => Load() as GlyphDefinition;

        public GlyphDefinition AnalyticsThemeRetrograde => Load() as GlyphDefinition;

        public GlyphDefinition AnalyticsThemeRetrogradeInversion => Load() as GlyphDefinition;

        public GlyphDefinition ArpeggiatoDown => Load() as GlyphDefinition;

        public GlyphDefinition ArpeggiatoUp => Load() as GlyphDefinition;

        public GlyphDefinition ArrowBlackDown => Load() as GlyphDefinition;

        public GlyphDefinition ArrowBlackDownLeft => Load() as GlyphDefinition;

        public GlyphDefinition ArrowBlackDownRight => Load() as GlyphDefinition;

        public GlyphDefinition ArrowBlackLeft => Load() as GlyphDefinition;

        public GlyphDefinition ArrowBlackRight => Load() as GlyphDefinition;

        public GlyphDefinition ArrowBlackUp => Load() as GlyphDefinition;

        public GlyphDefinition ArrowBlackUpLeft => Load() as GlyphDefinition;

        public GlyphDefinition ArrowBlackUpRight => Load() as GlyphDefinition;

        public GlyphDefinition ArrowOpenDown => Load() as GlyphDefinition;

        public GlyphDefinition ArrowOpenDownLeft => Load() as GlyphDefinition;

        public GlyphDefinition ArrowOpenDownRight => Load() as GlyphDefinition;

        public GlyphDefinition ArrowOpenLeft => Load() as GlyphDefinition;

        public GlyphDefinition ArrowOpenRight => Load() as GlyphDefinition;

        public GlyphDefinition ArrowOpenUp => Load() as GlyphDefinition;

        public GlyphDefinition ArrowOpenUpLeft => Load() as GlyphDefinition;

        public GlyphDefinition ArrowOpenUpRight => Load() as GlyphDefinition;

        public GlyphDefinition ArrowWhiteDown => Load() as GlyphDefinition;

        public GlyphDefinition ArrowWhiteDownLeft => Load() as GlyphDefinition;

        public GlyphDefinition ArrowWhiteDownRight => Load() as GlyphDefinition;

        public GlyphDefinition ArrowWhiteLeft => Load() as GlyphDefinition;

        public GlyphDefinition ArrowWhiteRight => Load() as GlyphDefinition;

        public GlyphDefinition ArrowWhiteUp => Load() as GlyphDefinition;

        public GlyphDefinition ArrowWhiteUpLeft => Load() as GlyphDefinition;

        public GlyphDefinition ArrowWhiteUpRight => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadBlackDown => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadBlackDownLeft => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadBlackDownRight => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadBlackLeft => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadBlackRight => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadBlackUp => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadBlackUpLeft => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadBlackUpRight => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadOpenDown => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadOpenDownLeft => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadOpenDownRight => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadOpenLeft => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadOpenRight => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadOpenUp => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadOpenUpLeft => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadOpenUpRight => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadWhiteDown => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadWhiteDownLeft => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadWhiteDownRight => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadWhiteLeft => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadWhiteRight => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadWhiteUp => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadWhiteUpLeft => Load() as GlyphDefinition;

        public GlyphDefinition ArrowheadWhiteUpRight => Load() as GlyphDefinition;

        public GlyphDefinition ArticAccentAbove => Load() as GlyphDefinition;

        public GlyphDefinition ArticAccentBelow => Load() as GlyphDefinition;

        public GlyphDefinition ArticAccentStaccatoAbove => Load() as GlyphDefinition;

        public GlyphDefinition ArticAccentStaccatoBelow => Load() as GlyphDefinition;

        public GlyphDefinition ArticLaissezVibrerAbove => Load() as GlyphDefinition;

        public GlyphDefinition ArticLaissezVibrerBelow => Load() as GlyphDefinition;

        public GlyphDefinition ArticMarcatoAbove => Load() as GlyphDefinition;

        public GlyphDefinition ArticMarcatoBelow => Load() as GlyphDefinition;

        public GlyphDefinition ArticMarcatoStaccatoAbove => Load() as GlyphDefinition;

        public GlyphDefinition ArticMarcatoStaccatoBelow => Load() as GlyphDefinition;

        public GlyphDefinition ArticStaccatissimoAbove => Load() as GlyphDefinition;

        public GlyphDefinition ArticStaccatissimoBelow => Load() as GlyphDefinition;

        public GlyphDefinition ArticStaccatissimoStrokeAbove => Load() as GlyphDefinition;

        public GlyphDefinition ArticStaccatissimoStrokeBelow => Load() as GlyphDefinition;

        public GlyphDefinition ArticStaccatissimoWedgeAbove => Load() as GlyphDefinition;

        public GlyphDefinition ArticStaccatissimoWedgeBelow => Load() as GlyphDefinition;

        public GlyphDefinition ArticStaccatoAbove => Load() as GlyphDefinition;

        public GlyphDefinition ArticStaccatoBelow => Load() as GlyphDefinition;

        public GlyphDefinition ArticStressAbove => Load() as GlyphDefinition;

        public GlyphDefinition ArticStressBelow => Load() as GlyphDefinition;

        public GlyphDefinition ArticTenutoAbove => Load() as GlyphDefinition;

        public GlyphDefinition ArticTenutoAccentAbove => Load() as GlyphDefinition;

        public GlyphDefinition ArticTenutoAccentBelow => Load() as GlyphDefinition;

        public GlyphDefinition ArticTenutoBelow => Load() as GlyphDefinition;

        public GlyphDefinition ArticTenutoStaccatoAbove => Load() as GlyphDefinition;

        public GlyphDefinition ArticTenutoStaccatoBelow => Load() as GlyphDefinition;

        public GlyphDefinition ArticUnstressAbove => Load() as GlyphDefinition;

        public GlyphDefinition ArticUnstressBelow => Load() as GlyphDefinition;

        public GlyphDefinition AugmentationDot => Load() as GlyphDefinition;

        public GlyphDefinition BarlineDashed => Load() as GlyphDefinition;

        public GlyphDefinition BarlineDotted => Load() as GlyphDefinition;

        public GlyphDefinition BarlineDouble => Load() as GlyphDefinition;

        public GlyphDefinition BarlineFinal => Load() as GlyphDefinition;

        public GlyphDefinition BarlineHeavy => Load() as GlyphDefinition;

        public GlyphDefinition BarlineHeavyHeavy => Load() as GlyphDefinition;

        public GlyphDefinition BarlineReverseFinal => Load() as GlyphDefinition;

        public GlyphDefinition BarlineShort => Load() as GlyphDefinition;

        public GlyphDefinition BarlineSingle => Load() as GlyphDefinition;

        public GlyphDefinition BarlineTick => Load() as GlyphDefinition;

        public GlyphDefinition BeamAccelRit1 => Load() as GlyphDefinition;

        public GlyphDefinition BeamAccelRit10 => Load() as GlyphDefinition;

        public GlyphDefinition BeamAccelRit11 => Load() as GlyphDefinition;

        public GlyphDefinition BeamAccelRit12 => Load() as GlyphDefinition;

        public GlyphDefinition BeamAccelRit13 => Load() as GlyphDefinition;

        public GlyphDefinition BeamAccelRit14 => Load() as GlyphDefinition;

        public GlyphDefinition BeamAccelRit15 => Load() as GlyphDefinition;

        public GlyphDefinition BeamAccelRit2 => Load() as GlyphDefinition;

        public GlyphDefinition BeamAccelRit3 => Load() as GlyphDefinition;

        public GlyphDefinition BeamAccelRit4 => Load() as GlyphDefinition;

        public GlyphDefinition BeamAccelRit5 => Load() as GlyphDefinition;

        public GlyphDefinition BeamAccelRit6 => Load() as GlyphDefinition;

        public GlyphDefinition BeamAccelRit7 => Load() as GlyphDefinition;

        public GlyphDefinition BeamAccelRit8 => Load() as GlyphDefinition;

        public GlyphDefinition BeamAccelRit9 => Load() as GlyphDefinition;

        public GlyphDefinition BeamAccelRitFinal => Load() as GlyphDefinition;

        public GlyphDefinition Brace => Load() as GlyphDefinition;

        public GlyphDefinition Bracket => Load() as GlyphDefinition;

        public GlyphDefinition BracketBottom => Load() as GlyphDefinition;

        public GlyphDefinition BracketTop => Load() as GlyphDefinition;

        public GlyphDefinition BrassBend => Load() as GlyphDefinition;

        public GlyphDefinition BrassDoitLong => Load() as GlyphDefinition;

        public GlyphDefinition BrassDoitMedium => Load() as GlyphDefinition;

        public GlyphDefinition BrassDoitShort => Load() as GlyphDefinition;

        public GlyphDefinition BrassFallLipLong => Load() as GlyphDefinition;

        public GlyphDefinition BrassFallLipMedium => Load() as GlyphDefinition;

        public GlyphDefinition BrassFallLipShort => Load() as GlyphDefinition;

        public GlyphDefinition BrassFallRoughLong => Load() as GlyphDefinition;

        public GlyphDefinition BrassFallRoughMedium => Load() as GlyphDefinition;

        public GlyphDefinition BrassFallRoughShort => Load() as GlyphDefinition;

        public GlyphDefinition BrassFallSmoothLong => Load() as GlyphDefinition;

        public GlyphDefinition BrassFallSmoothMedium => Load() as GlyphDefinition;

        public GlyphDefinition BrassFallSmoothShort => Load() as GlyphDefinition;

        public GlyphDefinition BrassFlip => Load() as GlyphDefinition;

        public GlyphDefinition BrassHarmonMuteClosed => Load() as GlyphDefinition;

        public GlyphDefinition BrassHarmonMuteStemHalfLeft => Load() as GlyphDefinition;

        public GlyphDefinition BrassHarmonMuteStemHalfRight => Load() as GlyphDefinition;

        public GlyphDefinition BrassHarmonMuteStemOpen => Load() as GlyphDefinition;

        public GlyphDefinition BrassJazzTurn => Load() as GlyphDefinition;

        public GlyphDefinition BrassLiftLong => Load() as GlyphDefinition;

        public GlyphDefinition BrassLiftMedium => Load() as GlyphDefinition;

        public GlyphDefinition BrassLiftShort => Load() as GlyphDefinition;

        public GlyphDefinition BrassLiftSmoothLong => Load() as GlyphDefinition;

        public GlyphDefinition BrassLiftSmoothMedium => Load() as GlyphDefinition;

        public GlyphDefinition BrassLiftSmoothShort => Load() as GlyphDefinition;

        public GlyphDefinition BrassMuteClosed => Load() as GlyphDefinition;

        public GlyphDefinition BrassMuteHalfClosed => Load() as GlyphDefinition;

        public GlyphDefinition BrassMuteOpen => Load() as GlyphDefinition;

        public GlyphDefinition BrassPlop => Load() as GlyphDefinition;

        public GlyphDefinition BrassScoop => Load() as GlyphDefinition;

        public GlyphDefinition BrassSmear => Load() as GlyphDefinition;

        public GlyphDefinition BreathMarkComma => Load() as GlyphDefinition;

        public GlyphDefinition BreathMarkSalzedo => Load() as GlyphDefinition;

        public GlyphDefinition BreathMarkTick => Load() as GlyphDefinition;

        public GlyphDefinition BreathMarkUpbow => Load() as GlyphDefinition;

        public GlyphDefinition BridgeClef => Load() as GlyphDefinition;

        public GlyphDefinition BuzzRoll => Load() as GlyphDefinition;

        public GlyphDefinition CClef => Load() as GlyphDefinition;

        public GlyphDefinition CClef8Vb => Load() as GlyphDefinition;

        public GlyphDefinition CClefArrowDown => Load() as GlyphDefinition;

        public GlyphDefinition CClefArrowUp => Load() as GlyphDefinition;

        public GlyphDefinition CClefChange => Load() as GlyphDefinition;

        public GlyphDefinition CClefCombining => Load() as GlyphDefinition;

        public GlyphDefinition CClefReversed => Load() as GlyphDefinition;

        public GlyphDefinition CClefSquare => Load() as GlyphDefinition;

        public GlyphDefinition CClefTriangular => Load() as GlyphDefinition;

        public GlyphDefinition CClefTriangularToFClef => Load() as GlyphDefinition;

        public GlyphDefinition Caesura => Load() as GlyphDefinition;

        public GlyphDefinition CaesuraCurved => Load() as GlyphDefinition;

        public GlyphDefinition CaesuraShort => Load() as GlyphDefinition;

        public GlyphDefinition CaesuraThick => Load() as GlyphDefinition;

        public GlyphDefinition ChantAccentusAbove => Load() as GlyphDefinition;

        public GlyphDefinition ChantAccentusBelow => Load() as GlyphDefinition;

        public GlyphDefinition ChantAuctumAsc => Load() as GlyphDefinition;

        public GlyphDefinition ChantAuctumDesc => Load() as GlyphDefinition;

        public GlyphDefinition ChantAugmentum => Load() as GlyphDefinition;

        public GlyphDefinition ChantCaesura => Load() as GlyphDefinition;

        public GlyphDefinition ChantCclef => Load() as GlyphDefinition;

        public GlyphDefinition ChantCirculusAbove => Load() as GlyphDefinition;

        public GlyphDefinition ChantCirculusBelow => Load() as GlyphDefinition;

        public GlyphDefinition ChantConnectingLineAsc2Nd => Load() as GlyphDefinition;

        public GlyphDefinition ChantConnectingLineAsc3Rd => Load() as GlyphDefinition;

        public GlyphDefinition ChantConnectingLineAsc4Th => Load() as GlyphDefinition;

        public GlyphDefinition ChantConnectingLineAsc5Th => Load() as GlyphDefinition;

        public GlyphDefinition ChantConnectingLineAsc6Th => Load() as GlyphDefinition;

        public GlyphDefinition ChantCustosStemDownPosHigh => Load() as GlyphDefinition;

        public GlyphDefinition ChantCustosStemDownPosHighest => Load() as GlyphDefinition;

        public GlyphDefinition ChantCustosStemDownPosMiddle => Load() as GlyphDefinition;

        public GlyphDefinition ChantCustosStemUpPosLow => Load() as GlyphDefinition;

        public GlyphDefinition ChantCustosStemUpPosLowest => Load() as GlyphDefinition;

        public GlyphDefinition ChantCustosStemUpPosMiddle => Load() as GlyphDefinition;

        public GlyphDefinition ChantDeminutumLower => Load() as GlyphDefinition;

        public GlyphDefinition ChantDeminutumUpper => Load() as GlyphDefinition;

        public GlyphDefinition ChantDivisioFinalis => Load() as GlyphDefinition;

        public GlyphDefinition ChantDivisioMaior => Load() as GlyphDefinition;

        public GlyphDefinition ChantDivisioMaxima => Load() as GlyphDefinition;

        public GlyphDefinition ChantDivisioMinima => Load() as GlyphDefinition;

        public GlyphDefinition ChantEntryLineAsc2Nd => Load() as GlyphDefinition;

        public GlyphDefinition ChantEntryLineAsc3Rd => Load() as GlyphDefinition;

        public GlyphDefinition ChantEntryLineAsc4Th => Load() as GlyphDefinition;

        public GlyphDefinition ChantEntryLineAsc5Th => Load() as GlyphDefinition;

        public GlyphDefinition ChantEntryLineAsc6Th => Load() as GlyphDefinition;

        public GlyphDefinition ChantEpisema => Load() as GlyphDefinition;

        public GlyphDefinition ChantFclef => Load() as GlyphDefinition;

        public GlyphDefinition ChantIctusAbove => Load() as GlyphDefinition;

        public GlyphDefinition ChantIctusBelow => Load() as GlyphDefinition;

        public GlyphDefinition ChantLigaturaDesc2Nd => Load() as GlyphDefinition;

        public GlyphDefinition ChantLigaturaDesc3Rd => Load() as GlyphDefinition;

        public GlyphDefinition ChantLigaturaDesc4Th => Load() as GlyphDefinition;

        public GlyphDefinition ChantLigaturaDesc5Th => Load() as GlyphDefinition;

        public GlyphDefinition ChantOriscusAscending => Load() as GlyphDefinition;

        public GlyphDefinition ChantOriscusDescending => Load() as GlyphDefinition;

        public GlyphDefinition ChantOriscusLiquescens => Load() as GlyphDefinition;

        public GlyphDefinition ChantPodatusLower => Load() as GlyphDefinition;

        public GlyphDefinition ChantPodatusUpper => Load() as GlyphDefinition;

        public GlyphDefinition ChantPunctum => Load() as GlyphDefinition;

        public GlyphDefinition ChantPunctumCavum => Load() as GlyphDefinition;

        public GlyphDefinition ChantPunctumDeminutum => Load() as GlyphDefinition;

        public GlyphDefinition ChantPunctumInclinatum => Load() as GlyphDefinition;

        public GlyphDefinition ChantPunctumInclinatumAuctum => Load() as GlyphDefinition;

        public GlyphDefinition ChantPunctumInclinatumDeminutum => Load() as GlyphDefinition;

        public GlyphDefinition ChantPunctumLinea => Load() as GlyphDefinition;

        public GlyphDefinition ChantPunctumLineaCavum => Load() as GlyphDefinition;

        public GlyphDefinition ChantPunctumVirga => Load() as GlyphDefinition;

        public GlyphDefinition ChantPunctumVirgaReversed => Load() as GlyphDefinition;

        public GlyphDefinition ChantQuilisma => Load() as GlyphDefinition;

        public GlyphDefinition ChantSemicirculusAbove => Load() as GlyphDefinition;

        public GlyphDefinition ChantSemicirculusBelow => Load() as GlyphDefinition;

        public GlyphDefinition ChantStaff => Load() as GlyphDefinition;

        public GlyphDefinition ChantStaffNarrow => Load() as GlyphDefinition;

        public GlyphDefinition ChantStaffWide => Load() as GlyphDefinition;

        public GlyphDefinition ChantStrophicus => Load() as GlyphDefinition;

        public GlyphDefinition ChantStrophicusAuctus => Load() as GlyphDefinition;

        public GlyphDefinition ChantStrophicusLiquescens2Nd => Load() as GlyphDefinition;

        public GlyphDefinition ChantStrophicusLiquescens3Rd => Load() as GlyphDefinition;

        public GlyphDefinition ChantStrophicusLiquescens4Th => Load() as GlyphDefinition;

        public GlyphDefinition ChantStrophicusLiquescens5Th => Load() as GlyphDefinition;

        public GlyphDefinition ChantVirgula => Load() as GlyphDefinition;

        public GlyphDefinition Clef15 => Load() as GlyphDefinition;

        public GlyphDefinition Clef8 => Load() as GlyphDefinition;

        public GlyphDefinition ClefChangeCombining => Load() as GlyphDefinition;

        public GlyphDefinition Coda => Load() as GlyphDefinition;

        public GlyphDefinition CodaSquare => Load() as GlyphDefinition;

        public GlyphDefinition ConductorBeat2Compound => Load() as GlyphDefinition;

        public GlyphDefinition ConductorBeat2Simple => Load() as GlyphDefinition;

        public GlyphDefinition ConductorBeat3Compound => Load() as GlyphDefinition;

        public GlyphDefinition ConductorBeat3Simple => Load() as GlyphDefinition;

        public GlyphDefinition ConductorBeat4Compound => Load() as GlyphDefinition;

        public GlyphDefinition ConductorBeat4Simple => Load() as GlyphDefinition;

        public GlyphDefinition ConductorLeftBeat => Load() as GlyphDefinition;

        public GlyphDefinition ConductorRightBeat => Load() as GlyphDefinition;

        public GlyphDefinition ConductorStrongBeat => Load() as GlyphDefinition;

        public GlyphDefinition ConductorWeakBeat => Load() as GlyphDefinition;

        public GlyphDefinition ControlBeginBeam => Load() as GlyphDefinition;

        public GlyphDefinition ControlBeginPhrase => Load() as GlyphDefinition;

        public GlyphDefinition ControlBeginSlur => Load() as GlyphDefinition;

        public GlyphDefinition ControlBeginTie => Load() as GlyphDefinition;

        public GlyphDefinition ControlEndBeam => Load() as GlyphDefinition;

        public GlyphDefinition ControlEndPhrase => Load() as GlyphDefinition;

        public GlyphDefinition ControlEndSlur => Load() as GlyphDefinition;

        public GlyphDefinition ControlEndTie => Load() as GlyphDefinition;

        public GlyphDefinition CsymAugmented => Load() as GlyphDefinition;

        public GlyphDefinition CsymBracketLeftTall => Load() as GlyphDefinition;

        public GlyphDefinition CsymBracketRightTall => Load() as GlyphDefinition;

        public GlyphDefinition CsymDiminished => Load() as GlyphDefinition;

        public GlyphDefinition CsymHalfDiminished => Load() as GlyphDefinition;

        public GlyphDefinition CsymMajorSeventh => Load() as GlyphDefinition;

        public GlyphDefinition CsymMinor => Load() as GlyphDefinition;

        public GlyphDefinition CsymParensLeftTall => Load() as GlyphDefinition;

        public GlyphDefinition CsymParensRightTall => Load() as GlyphDefinition;

        public GlyphDefinition CurlewSign => Load() as GlyphDefinition;

        public GlyphDefinition DaCapo => Load() as GlyphDefinition;

        public GlyphDefinition DalSegno => Load() as GlyphDefinition;

        public GlyphDefinition DaseianExcellentes1 => Load() as GlyphDefinition;

        public GlyphDefinition DaseianExcellentes2 => Load() as GlyphDefinition;

        public GlyphDefinition DaseianExcellentes3 => Load() as GlyphDefinition;

        public GlyphDefinition DaseianExcellentes4 => Load() as GlyphDefinition;

        public GlyphDefinition DaseianFinales1 => Load() as GlyphDefinition;

        public GlyphDefinition DaseianFinales2 => Load() as GlyphDefinition;

        public GlyphDefinition DaseianFinales3 => Load() as GlyphDefinition;

        public GlyphDefinition DaseianFinales4 => Load() as GlyphDefinition;

        public GlyphDefinition DaseianGraves1 => Load() as GlyphDefinition;

        public GlyphDefinition DaseianGraves2 => Load() as GlyphDefinition;

        public GlyphDefinition DaseianGraves3 => Load() as GlyphDefinition;

        public GlyphDefinition DaseianGraves4 => Load() as GlyphDefinition;

        public GlyphDefinition DaseianResidua1 => Load() as GlyphDefinition;

        public GlyphDefinition DaseianResidua2 => Load() as GlyphDefinition;

        public GlyphDefinition DaseianSuperiores1 => Load() as GlyphDefinition;

        public GlyphDefinition DaseianSuperiores2 => Load() as GlyphDefinition;

        public GlyphDefinition DaseianSuperiores3 => Load() as GlyphDefinition;

        public GlyphDefinition DaseianSuperiores4 => Load() as GlyphDefinition;

        public GlyphDefinition DoubleTongueAbove => Load() as GlyphDefinition;

        public GlyphDefinition DoubleTongueBelow => Load() as GlyphDefinition;

        public GlyphDefinition DynamicCrescendoHairpin => Load() as GlyphDefinition;

        public GlyphDefinition DynamicDiminuendoHairpin => Load() as GlyphDefinition;

        public GlyphDefinition DynamicFf => Load() as GlyphDefinition;

        public GlyphDefinition DynamicFff => Load() as GlyphDefinition;

        public GlyphDefinition DynamicFfff => Load() as GlyphDefinition;

        public GlyphDefinition DynamicFffff => Load() as GlyphDefinition;

        public GlyphDefinition DynamicFfffff => Load() as GlyphDefinition;

        public GlyphDefinition DynamicForte => Load() as GlyphDefinition;

        public GlyphDefinition DynamicFortePiano => Load() as GlyphDefinition;

        public GlyphDefinition DynamicForzando => Load() as GlyphDefinition;

        public GlyphDefinition DynamicMf => Load() as GlyphDefinition;

        public GlyphDefinition DynamicMp => Load() as GlyphDefinition;

        public GlyphDefinition DynamicMessaDiVoce => Load() as GlyphDefinition;

        public GlyphDefinition DynamicMezzo => Load() as GlyphDefinition;

        public GlyphDefinition DynamicNiente => Load() as GlyphDefinition;

        public GlyphDefinition DynamicNienteForHairpin => Load() as GlyphDefinition;

        public GlyphDefinition DynamicPf => Load() as GlyphDefinition;

        public GlyphDefinition DynamicPp => Load() as GlyphDefinition;

        public GlyphDefinition DynamicPpp => Load() as GlyphDefinition;

        public GlyphDefinition DynamicPppp => Load() as GlyphDefinition;

        public GlyphDefinition DynamicPpppp => Load() as GlyphDefinition;

        public GlyphDefinition DynamicPppppp => Load() as GlyphDefinition;

        public GlyphDefinition DynamicPiano => Load() as GlyphDefinition;

        public GlyphDefinition DynamicRinforzando => Load() as GlyphDefinition;

        public GlyphDefinition DynamicRinforzando1 => Load() as GlyphDefinition;

        public GlyphDefinition DynamicRinforzando2 => Load() as GlyphDefinition;

        public GlyphDefinition DynamicSforzando => Load() as GlyphDefinition;

        public GlyphDefinition DynamicSforzando1 => Load() as GlyphDefinition;

        public GlyphDefinition DynamicSforzandoPianissimo => Load() as GlyphDefinition;

        public GlyphDefinition DynamicSforzandoPiano => Load() as GlyphDefinition;

        public GlyphDefinition DynamicSforzato => Load() as GlyphDefinition;

        public GlyphDefinition DynamicSforzatoFf => Load() as GlyphDefinition;

        public GlyphDefinition DynamicSforzatoPiano => Load() as GlyphDefinition;

        public GlyphDefinition DynamicZ => Load() as GlyphDefinition;

        public GlyphDefinition ElecAudioChannelsEight => Load() as GlyphDefinition;

        public GlyphDefinition ElecAudioChannelsFive => Load() as GlyphDefinition;

        public GlyphDefinition ElecAudioChannelsFour => Load() as GlyphDefinition;

        public GlyphDefinition ElecAudioChannelsOne => Load() as GlyphDefinition;

        public GlyphDefinition ElecAudioChannelsSeven => Load() as GlyphDefinition;

        public GlyphDefinition ElecAudioChannelsSix => Load() as GlyphDefinition;

        public GlyphDefinition ElecAudioChannelsThreeFrontal => Load() as GlyphDefinition;

        public GlyphDefinition ElecAudioChannelsThreeSurround => Load() as GlyphDefinition;

        public GlyphDefinition ElecAudioChannelsTwo => Load() as GlyphDefinition;

        public GlyphDefinition ElecAudioIn => Load() as GlyphDefinition;

        public GlyphDefinition ElecAudioMono => Load() as GlyphDefinition;

        public GlyphDefinition ElecAudioOut => Load() as GlyphDefinition;

        public GlyphDefinition ElecAudioStereo => Load() as GlyphDefinition;

        public GlyphDefinition ElecCamera => Load() as GlyphDefinition;

        public GlyphDefinition ElecDataIn => Load() as GlyphDefinition;

        public GlyphDefinition ElecDataOut => Load() as GlyphDefinition;

        public GlyphDefinition ElecDisc => Load() as GlyphDefinition;

        public GlyphDefinition ElecDownload => Load() as GlyphDefinition;

        public GlyphDefinition ElecEject => Load() as GlyphDefinition;

        public GlyphDefinition ElecFastForward => Load() as GlyphDefinition;

        public GlyphDefinition ElecHeadphones => Load() as GlyphDefinition;

        public GlyphDefinition ElecHeadset => Load() as GlyphDefinition;

        public GlyphDefinition ElecLineIn => Load() as GlyphDefinition;

        public GlyphDefinition ElecLineOut => Load() as GlyphDefinition;

        public GlyphDefinition ElecLoop => Load() as GlyphDefinition;

        public GlyphDefinition ElecLoudspeaker => Load() as GlyphDefinition;

        public GlyphDefinition ElecMidiController0 => Load() as GlyphDefinition;

        public GlyphDefinition ElecMidiController100 => Load() as GlyphDefinition;

        public GlyphDefinition ElecMidiController20 => Load() as GlyphDefinition;

        public GlyphDefinition ElecMidiController40 => Load() as GlyphDefinition;

        public GlyphDefinition ElecMidiController60 => Load() as GlyphDefinition;

        public GlyphDefinition ElecMidiController80 => Load() as GlyphDefinition;

        public GlyphDefinition ElecMidiIn => Load() as GlyphDefinition;

        public GlyphDefinition ElecMidiOut => Load() as GlyphDefinition;

        public GlyphDefinition ElecMicrophone => Load() as GlyphDefinition;

        public GlyphDefinition ElecMicrophoneMute => Load() as GlyphDefinition;

        public GlyphDefinition ElecMicrophoneUnmute => Load() as GlyphDefinition;

        public GlyphDefinition ElecMixingConsole => Load() as GlyphDefinition;

        public GlyphDefinition ElecMonitor => Load() as GlyphDefinition;

        public GlyphDefinition ElecMute => Load() as GlyphDefinition;

        public GlyphDefinition ElecPause => Load() as GlyphDefinition;

        public GlyphDefinition ElecPlay => Load() as GlyphDefinition;

        public GlyphDefinition ElecPowerOnOff => Load() as GlyphDefinition;

        public GlyphDefinition ElecProjector => Load() as GlyphDefinition;

        public GlyphDefinition ElecReplay => Load() as GlyphDefinition;

        public GlyphDefinition ElecRewind => Load() as GlyphDefinition;

        public GlyphDefinition ElecShuffle => Load() as GlyphDefinition;

        public GlyphDefinition ElecSkipBackwards => Load() as GlyphDefinition;

        public GlyphDefinition ElecSkipForwards => Load() as GlyphDefinition;

        public GlyphDefinition ElecStop => Load() as GlyphDefinition;

        public GlyphDefinition ElecTape => Load() as GlyphDefinition;

        public GlyphDefinition ElecUsb => Load() as GlyphDefinition;

        public GlyphDefinition ElecUnmute => Load() as GlyphDefinition;

        public GlyphDefinition ElecUpload => Load() as GlyphDefinition;

        public GlyphDefinition ElecVideoCamera => Load() as GlyphDefinition;

        public GlyphDefinition ElecVideoIn => Load() as GlyphDefinition;

        public GlyphDefinition ElecVideoOut => Load() as GlyphDefinition;

        public GlyphDefinition ElecVolumeFader => Load() as GlyphDefinition;

        public GlyphDefinition ElecVolumeFaderThumb => Load() as GlyphDefinition;

        public GlyphDefinition ElecVolumeLevel0 => Load() as GlyphDefinition;

        public GlyphDefinition ElecVolumeLevel100 => Load() as GlyphDefinition;

        public GlyphDefinition ElecVolumeLevel20 => Load() as GlyphDefinition;

        public GlyphDefinition ElecVolumeLevel40 => Load() as GlyphDefinition;

        public GlyphDefinition ElecVolumeLevel60 => Load() as GlyphDefinition;

        public GlyphDefinition ElecVolumeLevel80 => Load() as GlyphDefinition;

        public GlyphDefinition FClef => Load() as GlyphDefinition;

        public GlyphDefinition FClef15Ma => Load() as GlyphDefinition;

        public GlyphDefinition FClef15Mb => Load() as GlyphDefinition;

        public GlyphDefinition FClef8Va => Load() as GlyphDefinition;

        public GlyphDefinition FClef8Vb => Load() as GlyphDefinition;

        public GlyphDefinition FClefArrowDown => Load() as GlyphDefinition;

        public GlyphDefinition FClefArrowUp => Load() as GlyphDefinition;

        public GlyphDefinition FClefChange => Load() as GlyphDefinition;

        public GlyphDefinition FClefReversed => Load() as GlyphDefinition;

        public GlyphDefinition FClefTriangular => Load() as GlyphDefinition;

        public GlyphDefinition FClefTriangularToCClef => Load() as GlyphDefinition;

        public GlyphDefinition FClefTurned => Load() as GlyphDefinition;

        public GlyphDefinition FermataAbove => Load() as GlyphDefinition;

        public GlyphDefinition FermataBelow => Load() as GlyphDefinition;

        public GlyphDefinition FermataLongAbove => Load() as GlyphDefinition;

        public GlyphDefinition FermataLongBelow => Load() as GlyphDefinition;

        public GlyphDefinition FermataLongHenzeAbove => Load() as GlyphDefinition;

        public GlyphDefinition FermataLongHenzeBelow => Load() as GlyphDefinition;

        public GlyphDefinition FermataShortAbove => Load() as GlyphDefinition;

        public GlyphDefinition FermataShortBelow => Load() as GlyphDefinition;

        public GlyphDefinition FermataShortHenzeAbove => Load() as GlyphDefinition;

        public GlyphDefinition FermataShortHenzeBelow => Load() as GlyphDefinition;

        public GlyphDefinition FermataVeryLongAbove => Load() as GlyphDefinition;

        public GlyphDefinition FermataVeryLongBelow => Load() as GlyphDefinition;

        public GlyphDefinition FermataVeryShortAbove => Load() as GlyphDefinition;

        public GlyphDefinition FermataVeryShortBelow => Load() as GlyphDefinition;

        public GlyphDefinition Figbass0 => Load() as GlyphDefinition;

        public GlyphDefinition Figbass1 => Load() as GlyphDefinition;

        public GlyphDefinition Figbass2 => Load() as GlyphDefinition;

        public GlyphDefinition Figbass2Raised => Load() as GlyphDefinition;

        public GlyphDefinition Figbass3 => Load() as GlyphDefinition;

        public GlyphDefinition Figbass4 => Load() as GlyphDefinition;

        public GlyphDefinition Figbass4Raised => Load() as GlyphDefinition;

        public GlyphDefinition Figbass5 => Load() as GlyphDefinition;

        public GlyphDefinition Figbass5Raised1 => Load() as GlyphDefinition;

        public GlyphDefinition Figbass5Raised2 => Load() as GlyphDefinition;

        public GlyphDefinition Figbass5Raised3 => Load() as GlyphDefinition;

        public GlyphDefinition Figbass6 => Load() as GlyphDefinition;

        public GlyphDefinition Figbass6Raised => Load() as GlyphDefinition;

        public GlyphDefinition Figbass7 => Load() as GlyphDefinition;

        public GlyphDefinition Figbass7Raised1 => Load() as GlyphDefinition;

        public GlyphDefinition Figbass7Raised2 => Load() as GlyphDefinition;

        public GlyphDefinition Figbass8 => Load() as GlyphDefinition;

        public GlyphDefinition Figbass9 => Load() as GlyphDefinition;

        public GlyphDefinition Figbass9Raised => Load() as GlyphDefinition;

        public GlyphDefinition FigbassBracketLeft => Load() as GlyphDefinition;

        public GlyphDefinition FigbassBracketRight => Load() as GlyphDefinition;

        public GlyphDefinition FigbassCombiningLowering => Load() as GlyphDefinition;

        public GlyphDefinition FigbassCombiningRaising => Load() as GlyphDefinition;

        public GlyphDefinition FigbassDoubleFlat => Load() as GlyphDefinition;

        public GlyphDefinition FigbassDoubleSharp => Load() as GlyphDefinition;

        public GlyphDefinition FigbassFlat => Load() as GlyphDefinition;

        public GlyphDefinition FigbassNatural => Load() as GlyphDefinition;

        public GlyphDefinition FigbassParensLeft => Load() as GlyphDefinition;

        public GlyphDefinition FigbassParensRight => Load() as GlyphDefinition;

        public GlyphDefinition FigbassPlus => Load() as GlyphDefinition;

        public GlyphDefinition FigbassSharp => Load() as GlyphDefinition;

        public GlyphDefinition Flag1024ThDown => Load() as GlyphDefinition;

        public GlyphDefinition Flag1024ThUp => Load() as GlyphDefinition;

        public GlyphDefinition Flag128ThDown => Load() as GlyphDefinition;

        public GlyphDefinition Flag128ThUp => Load() as GlyphDefinition;

        public GlyphDefinition Flag16ThDown => Load() as GlyphDefinition;

        public GlyphDefinition Flag16ThUp => Load() as GlyphDefinition;

        public GlyphDefinition Flag256ThDown => Load() as GlyphDefinition;

        public GlyphDefinition Flag256ThUp => Load() as GlyphDefinition;

        public GlyphDefinition Flag32NdDown => Load() as GlyphDefinition;

        public GlyphDefinition Flag32NdUp => Load() as GlyphDefinition;

        public GlyphDefinition Flag512ThDown => Load() as GlyphDefinition;

        public GlyphDefinition Flag512ThUp => Load() as GlyphDefinition;

        public GlyphDefinition Flag64ThDown => Load() as GlyphDefinition;

        public GlyphDefinition Flag64ThUp => Load() as GlyphDefinition;

        public GlyphDefinition Flag8ThDown => Load() as GlyphDefinition;

        public GlyphDefinition Flag8ThUp => Load() as GlyphDefinition;

        public GlyphDefinition FlagInternalDown => Load() as GlyphDefinition;

        public GlyphDefinition FlagInternalUp => Load() as GlyphDefinition;

        public GlyphDefinition Fretboard3String => Load() as GlyphDefinition;

        public GlyphDefinition Fretboard3StringNut => Load() as GlyphDefinition;

        public GlyphDefinition Fretboard4String => Load() as GlyphDefinition;

        public GlyphDefinition Fretboard4StringNut => Load() as GlyphDefinition;

        public GlyphDefinition Fretboard5String => Load() as GlyphDefinition;

        public GlyphDefinition Fretboard5StringNut => Load() as GlyphDefinition;

        public GlyphDefinition Fretboard6String => Load() as GlyphDefinition;

        public GlyphDefinition Fretboard6StringNut => Load() as GlyphDefinition;

        public GlyphDefinition FretboardFilledCircle => Load() as GlyphDefinition;

        public GlyphDefinition FretboardO => Load() as GlyphDefinition;

        public GlyphDefinition FretboardX => Load() as GlyphDefinition;

        public GlyphDefinition FunctionAngleLeft => Load() as GlyphDefinition;

        public GlyphDefinition FunctionAngleRight => Load() as GlyphDefinition;

        public GlyphDefinition FunctionBracketLeft => Load() as GlyphDefinition;

        public GlyphDefinition FunctionBracketRight => Load() as GlyphDefinition;

        public GlyphDefinition FunctionDd => Load() as GlyphDefinition;

        public GlyphDefinition FunctionDLower => Load() as GlyphDefinition;

        public GlyphDefinition FunctionDUpper => Load() as GlyphDefinition;

        public GlyphDefinition FunctionEight => Load() as GlyphDefinition;

        public GlyphDefinition FunctionFive => Load() as GlyphDefinition;

        public GlyphDefinition FunctionFour => Load() as GlyphDefinition;

        public GlyphDefinition FunctionGLower => Load() as GlyphDefinition;

        public GlyphDefinition FunctionGUpper => Load() as GlyphDefinition;

        public GlyphDefinition FunctionGreaterThan => Load() as GlyphDefinition;

        public GlyphDefinition FunctionLessThan => Load() as GlyphDefinition;

        public GlyphDefinition FunctionMinus => Load() as GlyphDefinition;

        public GlyphDefinition FunctionNLower => Load() as GlyphDefinition;

        public GlyphDefinition FunctionNUpper => Load() as GlyphDefinition;

        public GlyphDefinition FunctionNine => Load() as GlyphDefinition;

        public GlyphDefinition FunctionOne => Load() as GlyphDefinition;

        public GlyphDefinition FunctionPLower => Load() as GlyphDefinition;

        public GlyphDefinition FunctionPUpper => Load() as GlyphDefinition;

        public GlyphDefinition FunctionParensLeft => Load() as GlyphDefinition;

        public GlyphDefinition FunctionParensRight => Load() as GlyphDefinition;

        public GlyphDefinition FunctionPlus => Load() as GlyphDefinition;

        public GlyphDefinition FunctionRepetition1 => Load() as GlyphDefinition;

        public GlyphDefinition FunctionRepetition2 => Load() as GlyphDefinition;

        public GlyphDefinition FunctionRing => Load() as GlyphDefinition;

        public GlyphDefinition FunctionSLower => Load() as GlyphDefinition;

        public GlyphDefinition FunctionSsLower => Load() as GlyphDefinition;

        public GlyphDefinition FunctionSsUpper => Load() as GlyphDefinition;

        public GlyphDefinition FunctionSUpper => Load() as GlyphDefinition;

        public GlyphDefinition FunctionSeven => Load() as GlyphDefinition;

        public GlyphDefinition FunctionSix => Load() as GlyphDefinition;

        public GlyphDefinition FunctionSlashedDd => Load() as GlyphDefinition;

        public GlyphDefinition FunctionTLower => Load() as GlyphDefinition;

        public GlyphDefinition FunctionTUpper => Load() as GlyphDefinition;

        public GlyphDefinition FunctionThree => Load() as GlyphDefinition;

        public GlyphDefinition FunctionTwo => Load() as GlyphDefinition;

        public GlyphDefinition FunctionVLower => Load() as GlyphDefinition;

        public GlyphDefinition FunctionVUpper => Load() as GlyphDefinition;

        public GlyphDefinition FunctionZero => Load() as GlyphDefinition;

        public GlyphDefinition GClef => Load() as GlyphDefinition;

        public GlyphDefinition GClef15Ma => Load() as GlyphDefinition;

        public GlyphDefinition GClef15Mb => Load() as GlyphDefinition;

        public GlyphDefinition GClef8Va => Load() as GlyphDefinition;

        public GlyphDefinition GClef8Vb => Load() as GlyphDefinition;

        public GlyphDefinition GClef8VbCClef => Load() as GlyphDefinition;

        public GlyphDefinition GClef8VbOld => Load() as GlyphDefinition;

        public GlyphDefinition GClef8VbParens => Load() as GlyphDefinition;

        public GlyphDefinition GClefArrowDown => Load() as GlyphDefinition;

        public GlyphDefinition GClefArrowUp => Load() as GlyphDefinition;

        public GlyphDefinition GClefChange => Load() as GlyphDefinition;

        public GlyphDefinition GClefLigatedNumberAbove => Load() as GlyphDefinition;

        public GlyphDefinition GClefLigatedNumberBelow => Load() as GlyphDefinition;

        public GlyphDefinition GClefReversed => Load() as GlyphDefinition;

        public GlyphDefinition GClefTurned => Load() as GlyphDefinition;

        public GlyphDefinition GlissandoDown => Load() as GlyphDefinition;

        public GlyphDefinition GlissandoUp => Load() as GlyphDefinition;

        public GlyphDefinition GraceNoteAcciaccaturaStemDown => Load() as GlyphDefinition;

        public GlyphDefinition GraceNoteAcciaccaturaStemUp => Load() as GlyphDefinition;

        public GlyphDefinition GraceNoteAppoggiaturaStemDown => Load() as GlyphDefinition;

        public GlyphDefinition GraceNoteAppoggiaturaStemUp => Load() as GlyphDefinition;

        public GlyphDefinition GraceNoteSlashStemDown => Load() as GlyphDefinition;

        public GlyphDefinition GraceNoteSlashStemUp => Load() as GlyphDefinition;

        public GlyphDefinition GuitarClosePedal => Load() as GlyphDefinition;

        public GlyphDefinition GuitarFadeIn => Load() as GlyphDefinition;

        public GlyphDefinition GuitarFadeOut => Load() as GlyphDefinition;

        public GlyphDefinition GuitarGolpe => Load() as GlyphDefinition;

        public GlyphDefinition GuitarHalfOpenPedal => Load() as GlyphDefinition;

        public GlyphDefinition GuitarLeftHandTapping => Load() as GlyphDefinition;

        public GlyphDefinition GuitarOpenPedal => Load() as GlyphDefinition;

        public GlyphDefinition GuitarRightHandTapping => Load() as GlyphDefinition;

        public GlyphDefinition GuitarShake => Load() as GlyphDefinition;

        public GlyphDefinition GuitarString0 => Load() as GlyphDefinition;

        public GlyphDefinition GuitarString1 => Load() as GlyphDefinition;

        public GlyphDefinition GuitarString2 => Load() as GlyphDefinition;

        public GlyphDefinition GuitarString3 => Load() as GlyphDefinition;

        public GlyphDefinition GuitarString4 => Load() as GlyphDefinition;

        public GlyphDefinition GuitarString5 => Load() as GlyphDefinition;

        public GlyphDefinition GuitarString6 => Load() as GlyphDefinition;

        public GlyphDefinition GuitarString7 => Load() as GlyphDefinition;

        public GlyphDefinition GuitarString8 => Load() as GlyphDefinition;

        public GlyphDefinition GuitarString9 => Load() as GlyphDefinition;

        public GlyphDefinition GuitarStrumDown => Load() as GlyphDefinition;

        public GlyphDefinition GuitarStrumUp => Load() as GlyphDefinition;

        public GlyphDefinition GuitarVibratoBarDip => Load() as GlyphDefinition;

        public GlyphDefinition GuitarVibratoBarScoop => Load() as GlyphDefinition;

        public GlyphDefinition GuitarVibratoStroke => Load() as GlyphDefinition;

        public GlyphDefinition GuitarVolumeSwell => Load() as GlyphDefinition;

        public GlyphDefinition GuitarWideVibratoStroke => Load() as GlyphDefinition;

        public GlyphDefinition HandbellsBelltree => Load() as GlyphDefinition;

        public GlyphDefinition HandbellsDamp3 => Load() as GlyphDefinition;

        public GlyphDefinition HandbellsEcho1 => Load() as GlyphDefinition;

        public GlyphDefinition HandbellsEcho2 => Load() as GlyphDefinition;

        public GlyphDefinition HandbellsGyro => Load() as GlyphDefinition;

        public GlyphDefinition HandbellsHandMartellato => Load() as GlyphDefinition;

        public GlyphDefinition HandbellsMalletBellOnTable => Load() as GlyphDefinition;

        public GlyphDefinition HandbellsMalletBellSuspended => Load() as GlyphDefinition;

        public GlyphDefinition HandbellsMalletLft => Load() as GlyphDefinition;

        public GlyphDefinition HandbellsMartellato => Load() as GlyphDefinition;

        public GlyphDefinition HandbellsMartellatoLift => Load() as GlyphDefinition;

        public GlyphDefinition HandbellsMutedMartellato => Load() as GlyphDefinition;

        public GlyphDefinition HandbellsPluckLift => Load() as GlyphDefinition;

        public GlyphDefinition HandbellsSwing => Load() as GlyphDefinition;

        public GlyphDefinition HandbellsSwingDown => Load() as GlyphDefinition;

        public GlyphDefinition HandbellsSwingUp => Load() as GlyphDefinition;

        public GlyphDefinition HandbellsTablePairBells => Load() as GlyphDefinition;

        public GlyphDefinition HandbellsTableSingleBell => Load() as GlyphDefinition;

        public GlyphDefinition HarpMetalRod => Load() as GlyphDefinition;

        public GlyphDefinition HarpPedalCentered => Load() as GlyphDefinition;

        public GlyphDefinition HarpPedalDivider => Load() as GlyphDefinition;

        public GlyphDefinition HarpPedalLowered => Load() as GlyphDefinition;

        public GlyphDefinition HarpPedalRaised => Load() as GlyphDefinition;

        public GlyphDefinition HarpSalzedoAeolianAscending => Load() as GlyphDefinition;

        public GlyphDefinition HarpSalzedoAeolianDescending => Load() as GlyphDefinition;

        public GlyphDefinition HarpSalzedoFluidicSoundsLeft => Load() as GlyphDefinition;

        public GlyphDefinition HarpSalzedoFluidicSoundsRight => Load() as GlyphDefinition;

        public GlyphDefinition HarpSalzedoMetallicSounds => Load() as GlyphDefinition;

        public GlyphDefinition HarpSalzedoMuffleTotally => Load() as GlyphDefinition;

        public GlyphDefinition HarpSalzedoOboicFlux => Load() as GlyphDefinition;

        public GlyphDefinition HarpSalzedoPlayUpperEnd => Load() as GlyphDefinition;

        public GlyphDefinition HarpSalzedoSlideWithSuppleness => Load() as GlyphDefinition;

        public GlyphDefinition HarpSalzedoTamTamSounds => Load() as GlyphDefinition;

        public GlyphDefinition HarpSalzedoThunderEffect => Load() as GlyphDefinition;

        public GlyphDefinition HarpSalzedoTimpanicSounds => Load() as GlyphDefinition;

        public GlyphDefinition HarpSalzedoWhistlingSounds => Load() as GlyphDefinition;

        public GlyphDefinition HarpStringNoiseStem => Load() as GlyphDefinition;

        public GlyphDefinition HarpTuningKey => Load() as GlyphDefinition;

        public GlyphDefinition HarpTuningKeyGlissando => Load() as GlyphDefinition;

        public GlyphDefinition HarpTuningKeyHandle => Load() as GlyphDefinition;

        public GlyphDefinition HarpTuningKeyShank => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardBebung2DotsAbove => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardBebung2DotsBelow => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardBebung3DotsAbove => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardBebung3DotsBelow => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardBebung4DotsAbove => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardBebung4DotsBelow => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardLeftPedalPictogram => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardMiddlePedalPictogram => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPedalD => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPedalDot => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPedalE => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPedalHalf => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPedalHalf2 => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPedalHalf3 => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPedalHeel1 => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPedalHeel2 => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPedalHeel3 => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPedalHeelToe => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPedalHyphen => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPedalP => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPedalPed => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPedalS => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPedalSost => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPedalToe1 => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPedalToe2 => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPedalUp => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPedalUpNotch => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPedalUpSpecial => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPlayWithLh => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPlayWithLhEnd => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPlayWithRh => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPlayWithRhEnd => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardPluckInside => Load() as GlyphDefinition;

        public GlyphDefinition KeyboardRightPedalPictogram => Load() as GlyphDefinition;

        public GlyphDefinition KievanAccidentalFlat => Load() as GlyphDefinition;

        public GlyphDefinition KievanAccidentalSharp => Load() as GlyphDefinition;

        public GlyphDefinition KievanAugmentationDot => Load() as GlyphDefinition;

        public GlyphDefinition KievanCClef => Load() as GlyphDefinition;

        public GlyphDefinition KievanEndingSymbol => Load() as GlyphDefinition;

        public GlyphDefinition KievanNote8ThStemDown => Load() as GlyphDefinition;

        public GlyphDefinition KievanNote8ThStemUp => Load() as GlyphDefinition;

        public GlyphDefinition KievanNoteBeam => Load() as GlyphDefinition;

        public GlyphDefinition KievanNoteHalfStaffLine => Load() as GlyphDefinition;

        public GlyphDefinition KievanNoteHalfStaffSpace => Load() as GlyphDefinition;

        public GlyphDefinition KievanNoteQuarterStemDown => Load() as GlyphDefinition;

        public GlyphDefinition KievanNoteQuarterStemUp => Load() as GlyphDefinition;

        public GlyphDefinition KievanNoteReciting => Load() as GlyphDefinition;

        public GlyphDefinition KievanNoteWhole => Load() as GlyphDefinition;

        public GlyphDefinition KievanNoteWholeFinal => Load() as GlyphDefinition;

        public GlyphDefinition KodalyHandDo => Load() as GlyphDefinition;

        public GlyphDefinition KodalyHandFa => Load() as GlyphDefinition;

        public GlyphDefinition KodalyHandLa => Load() as GlyphDefinition;

        public GlyphDefinition KodalyHandMi => Load() as GlyphDefinition;

        public GlyphDefinition KodalyHandRe => Load() as GlyphDefinition;

        public GlyphDefinition KodalyHandSo => Load() as GlyphDefinition;

        public GlyphDefinition KodalyHandTi => Load() as GlyphDefinition;

        public GlyphDefinition LeftRepeatSmall => Load() as GlyphDefinition;

        public GlyphDefinition LegerLine => Load() as GlyphDefinition;

        public GlyphDefinition LegerLineNarrow => Load() as GlyphDefinition;

        public GlyphDefinition LegerLineWide => Load() as GlyphDefinition;

        public GlyphDefinition LuteBarlineEndRepeat => Load() as GlyphDefinition;

        public GlyphDefinition LuteBarlineFinal => Load() as GlyphDefinition;

        public GlyphDefinition LuteBarlineStartRepeat => Load() as GlyphDefinition;

        public GlyphDefinition LuteDuration16Th => Load() as GlyphDefinition;

        public GlyphDefinition LuteDuration32Nd => Load() as GlyphDefinition;

        public GlyphDefinition LuteDuration8Th => Load() as GlyphDefinition;

        public GlyphDefinition LuteDurationDoubleWhole => Load() as GlyphDefinition;

        public GlyphDefinition LuteDurationHalf => Load() as GlyphDefinition;

        public GlyphDefinition LuteDurationQuarter => Load() as GlyphDefinition;

        public GlyphDefinition LuteDurationWhole => Load() as GlyphDefinition;

        public GlyphDefinition LuteFingeringRhFirst => Load() as GlyphDefinition;

        public GlyphDefinition LuteFingeringRhSecond => Load() as GlyphDefinition;

        public GlyphDefinition LuteFingeringRhThird => Load() as GlyphDefinition;

        public GlyphDefinition LuteFingeringRhThumb => Load() as GlyphDefinition;

        public GlyphDefinition LuteFrench10ThCourse => Load() as GlyphDefinition;

        public GlyphDefinition LuteFrench7ThCourse => Load() as GlyphDefinition;

        public GlyphDefinition LuteFrench8ThCourse => Load() as GlyphDefinition;

        public GlyphDefinition LuteFrench9ThCourse => Load() as GlyphDefinition;

        public GlyphDefinition LuteFrenchAppoggiaturaAbove => Load() as GlyphDefinition;

        public GlyphDefinition LuteFrenchAppoggiaturaBelow => Load() as GlyphDefinition;

        public GlyphDefinition LuteFrenchFretA => Load() as GlyphDefinition;

        public GlyphDefinition LuteFrenchFretB => Load() as GlyphDefinition;

        public GlyphDefinition LuteFrenchFretC => Load() as GlyphDefinition;

        public GlyphDefinition LuteFrenchFretD => Load() as GlyphDefinition;

        public GlyphDefinition LuteFrenchFretE => Load() as GlyphDefinition;

        public GlyphDefinition LuteFrenchFretF => Load() as GlyphDefinition;

        public GlyphDefinition LuteFrenchFretG => Load() as GlyphDefinition;

        public GlyphDefinition LuteFrenchFretH => Load() as GlyphDefinition;

        public GlyphDefinition LuteFrenchFretI => Load() as GlyphDefinition;

        public GlyphDefinition LuteFrenchFretK => Load() as GlyphDefinition;

        public GlyphDefinition LuteFrenchFretL => Load() as GlyphDefinition;

        public GlyphDefinition LuteFrenchFretM => Load() as GlyphDefinition;

        public GlyphDefinition LuteFrenchFretN => Load() as GlyphDefinition;

        public GlyphDefinition LuteFrenchMordentInverted => Load() as GlyphDefinition;

        public GlyphDefinition LuteFrenchMordentLower => Load() as GlyphDefinition;

        public GlyphDefinition LuteFrenchMordentUpper => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanALower => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanAUpper => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanBLower => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanBUpper => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanCLower => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanCUpper => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanDLower => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanDUpper => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanELower => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanEUpper => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanFLower => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanFUpper => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanGLower => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanGUpper => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanHLower => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanHUpper => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanILower => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanIUpper => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanKLower => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanKUpper => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanLLower => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanLUpper => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanMLower => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanMUpper => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanNLower => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanNUpper => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanOLower => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanPLower => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanQLower => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanRLower => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanSLower => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanTLower => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanVLower => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanXLower => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanYLower => Load() as GlyphDefinition;

        public GlyphDefinition LuteGermanZLower => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianClefCSolFaUt => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianClefFFaUt => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianFret0 => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianFret1 => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianFret2 => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianFret3 => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianFret4 => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianFret5 => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianFret6 => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianFret7 => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianFret8 => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianFret9 => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianHoldFinger => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianHoldNote => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianReleaseFinger => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianTempoFast => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianTempoNeitherFastNorSlow => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianTempoSlow => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianTempoSomewhatFast => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianTempoVerySlow => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianTimeTriple => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianTremolo => Load() as GlyphDefinition;

        public GlyphDefinition LuteItalianVibrato => Load() as GlyphDefinition;

        public GlyphDefinition LuteStaff6Lines => Load() as GlyphDefinition;

        public GlyphDefinition LuteStaff6LinesNarrow => Load() as GlyphDefinition;

        public GlyphDefinition LuteStaff6LinesWide => Load() as GlyphDefinition;

        public GlyphDefinition LyricsElision => Load() as GlyphDefinition;

        public GlyphDefinition LyricsElisionNarrow => Load() as GlyphDefinition;

        public GlyphDefinition LyricsElisionWide => Load() as GlyphDefinition;

        public GlyphDefinition LyricsHyphenBaseline => Load() as GlyphDefinition;

        public GlyphDefinition LyricsHyphenBaselineNonBreaking => Load() as GlyphDefinition;

        public GlyphDefinition MedRenFlatHardB => Load() as GlyphDefinition;

        public GlyphDefinition MedRenFlatSoftB => Load() as GlyphDefinition;

        public GlyphDefinition MedRenFlatWithDot => Load() as GlyphDefinition;

        public GlyphDefinition MedRenGClefCmn => Load() as GlyphDefinition;

        public GlyphDefinition MedRenLiquescenceCmn => Load() as GlyphDefinition;

        public GlyphDefinition MedRenLiquescentAscCmn => Load() as GlyphDefinition;

        public GlyphDefinition MedRenLiquescentDescCmn => Load() as GlyphDefinition;

        public GlyphDefinition MedRenNatural => Load() as GlyphDefinition;

        public GlyphDefinition MedRenNaturalWithCross => Load() as GlyphDefinition;

        public GlyphDefinition MedRenOriscusCmn => Load() as GlyphDefinition;

        public GlyphDefinition MedRenPlicaCmn => Load() as GlyphDefinition;

        public GlyphDefinition MedRenPunctumCmn => Load() as GlyphDefinition;

        public GlyphDefinition MedRenQuilismaCmn => Load() as GlyphDefinition;

        public GlyphDefinition MedRenSharpCroix => Load() as GlyphDefinition;

        public GlyphDefinition MedRenStrophicusCmn => Load() as GlyphDefinition;

        public GlyphDefinition MensuralAlterationSign => Load() as GlyphDefinition;

        public GlyphDefinition MensuralBlackBrevis => Load() as GlyphDefinition;

        public GlyphDefinition MensuralBlackBrevisVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralBlackDragma => Load() as GlyphDefinition;

        public GlyphDefinition MensuralBlackLonga => Load() as GlyphDefinition;

        public GlyphDefinition MensuralBlackMaxima => Load() as GlyphDefinition;

        public GlyphDefinition MensuralBlackMinima => Load() as GlyphDefinition;

        public GlyphDefinition MensuralBlackMinimaVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralBlackSemibrevis => Load() as GlyphDefinition;

        public GlyphDefinition MensuralBlackSemibrevisCaudata => Load() as GlyphDefinition;

        public GlyphDefinition MensuralBlackSemibrevisOblique => Load() as GlyphDefinition;

        public GlyphDefinition MensuralBlackSemibrevisVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralBlackSemiminima => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCclef => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCclefPetrucciPosHigh => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCclefPetrucciPosHighest => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCclefPetrucciPosLow => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCclefPetrucciPosLowest => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCclefPetrucciPosMiddle => Load() as GlyphDefinition;

        public GlyphDefinition MensuralColorationEndRound => Load() as GlyphDefinition;

        public GlyphDefinition MensuralColorationEndSquare => Load() as GlyphDefinition;

        public GlyphDefinition MensuralColorationStartRound => Load() as GlyphDefinition;

        public GlyphDefinition MensuralColorationStartSquare => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCombStemDiagonal => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCombStemDown => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCombStemDownFlagExtended => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCombStemDownFlagFlared => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCombStemDownFlagFusa => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCombStemDownFlagLeft => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCombStemDownFlagRight => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCombStemDownFlagSemiminima => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCombStemUp => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCombStemUpFlagExtended => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCombStemUpFlagFlared => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCombStemUpFlagFusa => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCombStemUpFlagLeft => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCombStemUpFlagRight => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCombStemUpFlagSemiminima => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCustosCheckmark => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCustosDown => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCustosTurn => Load() as GlyphDefinition;

        public GlyphDefinition MensuralCustosUp => Load() as GlyphDefinition;

        public GlyphDefinition MensuralFclef => Load() as GlyphDefinition;

        public GlyphDefinition MensuralFclefPetrucci => Load() as GlyphDefinition;

        public GlyphDefinition MensuralGclef => Load() as GlyphDefinition;

        public GlyphDefinition MensuralGclefPetrucci => Load() as GlyphDefinition;

        public GlyphDefinition MensuralModusImperfectumVert => Load() as GlyphDefinition;

        public GlyphDefinition MensuralModusPerfectumVert => Load() as GlyphDefinition;

        public GlyphDefinition MensuralNoteheadLongaBlack => Load() as GlyphDefinition;

        public GlyphDefinition MensuralNoteheadLongaBlackVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralNoteheadLongaVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralNoteheadLongaWhite => Load() as GlyphDefinition;

        public GlyphDefinition MensuralNoteheadMaximaBlack => Load() as GlyphDefinition;

        public GlyphDefinition MensuralNoteheadMaximaBlackVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralNoteheadMaximaVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralNoteheadMaximaWhite => Load() as GlyphDefinition;

        public GlyphDefinition MensuralNoteheadMinimaWhite => Load() as GlyphDefinition;

        public GlyphDefinition MensuralNoteheadSemibrevisBlack => Load() as GlyphDefinition;

        public GlyphDefinition MensuralNoteheadSemibrevisBlackVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralNoteheadSemibrevisBlackVoidTurned => Load() as GlyphDefinition;

        public GlyphDefinition MensuralNoteheadSemibrevisVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralNoteheadSemiminimaWhite => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueAsc2NdBlack => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueAsc2NdBlackVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueAsc2NdVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueAsc2NdWhite => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueAsc3RdBlack => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueAsc3RdBlackVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueAsc3RdVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueAsc3RdWhite => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueAsc4ThBlack => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueAsc4ThBlackVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueAsc4ThVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueAsc4ThWhite => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueAsc5ThBlack => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueAsc5ThBlackVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueAsc5ThVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueAsc5ThWhite => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueDesc2NdBlack => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueDesc2NdBlackVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueDesc2NdVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueDesc2NdWhite => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueDesc3RdBlack => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueDesc3RdBlackVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueDesc3RdVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueDesc3RdWhite => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueDesc4ThBlack => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueDesc4ThBlackVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueDesc4ThVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueDesc4ThWhite => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueDesc5ThBlack => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueDesc5ThBlackVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueDesc5ThVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralObliqueDesc5ThWhite => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProlation1 => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProlation10 => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProlation11 => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProlation2 => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProlation3 => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProlation4 => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProlation5 => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProlation6 => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProlation7 => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProlation8 => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProlation9 => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProlationCombiningDot => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProlationCombiningDotVoid => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProlationCombiningStroke => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProlationCombiningThreeDots => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProlationCombiningThreeDotsTri => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProlationCombiningTwoDots => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProportion1 => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProportion2 => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProportion3 => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProportion4 => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProportionMajor => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProportionMinor => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProportionProportioDupla1 => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProportionProportioDupla2 => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProportionProportioQuadrupla => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProportionProportioTripla => Load() as GlyphDefinition;

        public GlyphDefinition MensuralProportionTempusPerfectum => Load() as GlyphDefinition;

        public GlyphDefinition MensuralRestBrevis => Load() as GlyphDefinition;

        public GlyphDefinition MensuralRestFusa => Load() as GlyphDefinition;

        public GlyphDefinition MensuralRestLongaImperfecta => Load() as GlyphDefinition;

        public GlyphDefinition MensuralRestLongaPerfecta => Load() as GlyphDefinition;

        public GlyphDefinition MensuralRestMaxima => Load() as GlyphDefinition;

        public GlyphDefinition MensuralRestMinima => Load() as GlyphDefinition;

        public GlyphDefinition MensuralRestSemibrevis => Load() as GlyphDefinition;

        public GlyphDefinition MensuralRestSemifusa => Load() as GlyphDefinition;

        public GlyphDefinition MensuralRestSemiminima => Load() as GlyphDefinition;

        public GlyphDefinition MensuralSignumDown => Load() as GlyphDefinition;

        public GlyphDefinition MensuralSignumUp => Load() as GlyphDefinition;

        public GlyphDefinition MensuralTempusImperfectumHoriz => Load() as GlyphDefinition;

        public GlyphDefinition MensuralTempusPerfectumHoriz => Load() as GlyphDefinition;

        public GlyphDefinition MensuralWhiteBrevis => Load() as GlyphDefinition;

        public GlyphDefinition MensuralWhiteFusa => Load() as GlyphDefinition;

        public GlyphDefinition MensuralWhiteLonga => Load() as GlyphDefinition;

        public GlyphDefinition MensuralWhiteMaxima => Load() as GlyphDefinition;

        public GlyphDefinition MensuralWhiteMinima => Load() as GlyphDefinition;

        public GlyphDefinition MensuralWhiteSemiminima => Load() as GlyphDefinition;

        public GlyphDefinition MetricModulationArrowLeft => Load() as GlyphDefinition;

        public GlyphDefinition MetricModulationArrowRight => Load() as GlyphDefinition;

        public GlyphDefinition MiscDoNotCopy => Load() as GlyphDefinition;

        public GlyphDefinition MiscDoNotPhotocopy => Load() as GlyphDefinition;

        public GlyphDefinition MiscEyeglasses => Load() as GlyphDefinition;

        public GlyphDefinition Note1024ThDown => Load() as GlyphDefinition;

        public GlyphDefinition Note1024ThUp => Load() as GlyphDefinition;

        public GlyphDefinition Note128ThDown => Load() as GlyphDefinition;

        public GlyphDefinition Note128ThUp => Load() as GlyphDefinition;

        public GlyphDefinition Note16ThDown => Load() as GlyphDefinition;

        public GlyphDefinition Note16ThUp => Load() as GlyphDefinition;

        public GlyphDefinition Note256ThDown => Load() as GlyphDefinition;

        public GlyphDefinition Note256ThUp => Load() as GlyphDefinition;

        public GlyphDefinition Note32NdDown => Load() as GlyphDefinition;

        public GlyphDefinition Note32NdUp => Load() as GlyphDefinition;

        public GlyphDefinition Note512ThDown => Load() as GlyphDefinition;

        public GlyphDefinition Note512ThUp => Load() as GlyphDefinition;

        public GlyphDefinition Note64ThDown => Load() as GlyphDefinition;

        public GlyphDefinition Note64ThUp => Load() as GlyphDefinition;

        public GlyphDefinition Note8ThDown => Load() as GlyphDefinition;

        public GlyphDefinition Note8ThUp => Load() as GlyphDefinition;

        public GlyphDefinition NoteABlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteAFlatBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteAFlatHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteAFlatWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteAHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteASharpBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteASharpHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteASharpWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteAWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteBBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteBFlatBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteBFlatHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteBFlatWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteBHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteBSharpBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteBSharpHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteBSharpWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteBWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteCBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteCFlatBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteCFlatHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteCFlatWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteCHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteCSharpBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteCSharpHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteCSharpWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteCWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteDBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteDFlatBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteDFlatHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteDFlatWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteDHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteDSharpBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteDSharpHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteDSharpWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteDWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteDoBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteDoHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteDoWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteDoubleWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteDoubleWholeSquare => Load() as GlyphDefinition;

        public GlyphDefinition NoteEBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteEFlatBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteEFlatHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteEFlatWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteEHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteESharpBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteESharpHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteESharpWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteEWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteEmptyBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteEmptyHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteEmptyWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteFBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteFFlatBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteFFlatHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteFFlatWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteFHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteFSharpBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteFSharpHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteFSharpWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteFWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteFaBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteFaHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteFaWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteGBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteGFlatBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteGFlatHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteGFlatWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteGHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteGSharpBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteGSharpHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteGSharpWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteGWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteHBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteHHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteHSharpBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteHSharpHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteHSharpWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteHWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteHalfDown => Load() as GlyphDefinition;

        public GlyphDefinition NoteHalfUp => Load() as GlyphDefinition;

        public GlyphDefinition NoteLaBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteLaHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteLaWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteMiBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteMiHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteMiWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteQuarterDown => Load() as GlyphDefinition;

        public GlyphDefinition NoteQuarterUp => Load() as GlyphDefinition;

        public GlyphDefinition NoteReBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteReHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteReWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeArrowheadLeftBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeArrowheadLeftWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeDiamondBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeDiamondWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeIsoscelesTriangleBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeIsoscelesTriangleWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeKeystoneBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeKeystoneWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeMoonBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeMoonLeftBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeMoonLeftWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeMoonWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeQuarterMoonBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeQuarterMoonWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeRoundBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeRoundWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeSquareBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeSquareWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeTriangleLeftBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeTriangleLeftWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeTriangleRightBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeTriangleRightWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeTriangleRoundBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeTriangleRoundLeftBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeTriangleRoundLeftWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeTriangleRoundWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeTriangleUpBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteShapeTriangleUpWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteSiBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteSiHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteSiWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteSoBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteSoHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteSoWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteTiBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteTiHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteTiWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadCircleSlash => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadCircleX => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadCircleXDoubleWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadCircleXHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadCircleXWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadCircledBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadCircledBlackLarge => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadCircledDoubleWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadCircledDoubleWholeLarge => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadCircledHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadCircledHalfLarge => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadCircledWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadCircledWholeLarge => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadCircledXLarge => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterDoubleWhole2Nd => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterDoubleWhole3Rd => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterDoubleWholeBottom => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterDoubleWholeMiddle => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterDoubleWholeTop => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterHalf2Nd => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterHalf3Rd => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterHalfBottom => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterHalfMiddle => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterHalfTop => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterQuarter2Nd => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterQuarter3Rd => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterQuarterBottom => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterQuarterMiddle => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterQuarterTop => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterRoundBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterRoundWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterSquareBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterSquareWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterWhole2Nd => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterWhole3Rd => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterWholeBottom => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterWholeMiddle => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadClusterWholeTop => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondBlackOld => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondBlackWide => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondClusterBlack2Nd => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondClusterBlack3Rd => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondClusterBlackBottom => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondClusterBlackMiddle => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondClusterBlackTop => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondClusterWhite2Nd => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondClusterWhite3Rd => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondClusterWhiteBottom => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondClusterWhiteMiddle => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondClusterWhiteTop => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondDoubleWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondDoubleWholeOld => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondHalfFilled => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondHalfOld => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondHalfWide => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondOpen => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondWhiteWide => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDiamondWholeOld => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDoubleWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDoubleWholeSquare => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadDoubleWholeWithX => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadHalfFilled => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadHalfWithX => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadHeavyX => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadHeavyXHat => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadLargeArrowDownBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadLargeArrowDownDoubleWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadLargeArrowDownHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadLargeArrowDownWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadLargeArrowUpBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadLargeArrowUpDoubleWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadLargeArrowUpHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadLargeArrowUpWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadMoonBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadMoonWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadNull => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadParenthesis => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadParenthesisLeft => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadParenthesisRight => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadPlusBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadPlusDoubleWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadPlusHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadPlusWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadRectangularClusterBlackBottom => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadRectangularClusterBlackMiddle => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadRectangularClusterBlackTop => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadRectangularClusterWhiteBottom => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadRectangularClusterWhiteMiddle => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadRectangularClusterWhiteTop => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadRoundBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadRoundBlackLarge => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadRoundBlackSlashed => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadRoundBlackSlashedLarge => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadRoundWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadRoundWhiteLarge => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadRoundWhiteSlashed => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadRoundWhiteSlashedLarge => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadRoundWhiteWithDot => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadRoundWhiteWithDotLarge => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadSlashDiamondWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadSlashHorizontalEnds => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadSlashHorizontalEndsMuted => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadSlashVerticalEnds => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadSlashVerticalEndsMuted => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadSlashVerticalEndsSmall => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadSlashWhiteHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadSlashWhiteMuted => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadSlashWhiteWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadSlashX => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadSlashedBlack1 => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadSlashedBlack2 => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadSlashedDoubleWhole1 => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadSlashedDoubleWhole2 => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadSlashedHalf1 => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadSlashedHalf2 => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadSlashedWhole1 => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadSlashedWhole2 => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadSquareBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadSquareBlackLarge => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadSquareBlackWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadSquareWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadTriangleDownBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadTriangleDownDoubleWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadTriangleDownHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadTriangleDownWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadTriangleDownWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadTriangleLeftBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadTriangleLeftWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadTriangleRightBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadTriangleRightWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadTriangleRoundDownBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadTriangleRoundDownWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadTriangleUpBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadTriangleUpDoubleWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadTriangleUpHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadTriangleUpRightBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadTriangleUpRightWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadTriangleUpWhite => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadTriangleUpWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadVoidWithX => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadWholeFilled => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadWholeWithX => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadXBlack => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadXDoubleWhole => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadXHalf => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadXOrnate => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadXOrnateEllipse => Load() as GlyphDefinition;

        public GlyphDefinition NoteheadXWhole => Load() as GlyphDefinition;

        public GlyphDefinition OctaveBassa => Load() as GlyphDefinition;

        public GlyphDefinition OctaveLoco => Load() as GlyphDefinition;

        public GlyphDefinition OctaveParensLeft => Load() as GlyphDefinition;

        public GlyphDefinition OctaveParensRight => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentBottomLeftConcaveStroke => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentBottomLeftConcaveStrokeLarge => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentBottomLeftConvexStroke => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentBottomRightConcaveStroke => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentBottomRightConvexStroke => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentComma => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentDoubleObliqueLinesAfterNote => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentDoubleObliqueLinesBeforeNote => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentDownCurve => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentHaydn => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentHighLeftConcaveStroke => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentHighLeftConvexStroke => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentHighRightConcaveStroke => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentHighRightConvexStroke => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentHookAfterNote => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentHookBeforeNote => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentLeftFacingHalfCircle => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentLeftFacingHook => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentLeftPlus => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentLeftShakeT => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentLeftVerticalStroke => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentLeftVerticalStrokeWithCross => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentLowLeftConcaveStroke => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentLowLeftConvexStroke => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentLowRightConcaveStroke => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentLowRightConvexStroke => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentMiddleVerticalStroke => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentMordent => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentMordentInverted => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentObliqueLineAfterNote => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentObliqueLineBeforeNote => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentObliqueLineHorizAfterNote => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentObliqueLineHorizBeforeNote => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentOriscus => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPinceCouperin => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPortDeVoixV => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompAppoggTrill => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompAppoggTrillSuffix => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompCadence => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompCadenceUpperPrefix => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompCadenceUpperPrefixTurn => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompCadenceWithTurn => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompDescendingSlide => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompDoubleCadenceLowerPrefix => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompDoubleCadenceUpperPrefix => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompDoubleCadenceUpperPrefixTurn => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompInvertedMordentUpperPrefix => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompMordentRelease => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompMordentUpperPrefix => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompPortDeVoixMordent => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompSlide => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompSlideTrillBach => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompSlideTrillDAnglebert => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompSlideTrillMarpurg => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompSlideTrillMuffat => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompSlideTrillSuffixMuffat => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompTrillLowerSuffix => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompTrillSuffixDandrieu => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompTrillWithMordent => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompTurnTrillBach => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentPrecompTurnTrillDAnglebert => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentQuilisma => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentRightFacingHalfCircle => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentRightFacingHook => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentRightVerticalStroke => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentSchleifer => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentShake3 => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentShakeMuffat1 => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentShortObliqueLineAfterNote => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentShortObliqueLineBeforeNote => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentTopLeftConcaveStroke => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentTopLeftConvexStroke => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentTopRightConcaveStroke => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentTopRightConvexStroke => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentTremblement => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentTremblementCouperin => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentTrill => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentTurn => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentTurnInverted => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentTurnSlash => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentTurnUp => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentTurnUpS => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentUpCurve => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentVerticalLine => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentZigZagLineNoRightEnd => Load() as GlyphDefinition;

        public GlyphDefinition OrnamentZigZagLineWithRightEnd => Load() as GlyphDefinition;

        public GlyphDefinition Ottava => Load() as GlyphDefinition;

        public GlyphDefinition OttavaAlta => Load() as GlyphDefinition;

        public GlyphDefinition OttavaBassa => Load() as GlyphDefinition;

        public GlyphDefinition OttavaBassaBa => Load() as GlyphDefinition;

        public GlyphDefinition OttavaBassaVb => Load() as GlyphDefinition;

        public GlyphDefinition PendereckiTremolo => Load() as GlyphDefinition;

        public GlyphDefinition PictAgogo => Load() as GlyphDefinition;

        public GlyphDefinition PictAlmglocken => Load() as GlyphDefinition;

        public GlyphDefinition PictAnvil => Load() as GlyphDefinition;

        public GlyphDefinition PictBambooChimes => Load() as GlyphDefinition;

        public GlyphDefinition PictBambooScraper => Load() as GlyphDefinition;

        public GlyphDefinition PictBassDrum => Load() as GlyphDefinition;

        public GlyphDefinition PictBassDrumOnSide => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterBow => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterBox => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterBrassMalletsDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterBrassMalletsUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterCombiningDashedCircle => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterCombiningParentheses => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterDoubleBassDrumDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterDoubleBassDrumUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterFinger => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterFingernails => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterFist => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterGuiroScraper => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHammer => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHammerMetalDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHammerMetalUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHammerPlasticDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHammerPlasticUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHammerWoodDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHammerWoodUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHand => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHardBassDrumDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHardBassDrumUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHardGlockenspielDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHardGlockenspielLeft => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHardGlockenspielRight => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHardGlockenspielUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHardTimpaniDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHardTimpaniLeft => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHardTimpaniRight => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHardTimpaniUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHardXylophoneDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHardXylophoneLeft => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHardXylophoneRight => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHardXylophoneUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHardYarnDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHardYarnLeft => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHardYarnRight => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterHardYarnUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterJazzSticksDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterJazzSticksUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterKnittingNeedle => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterMallet => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterMediumBassDrumDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterMediumBassDrumUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterMediumTimpaniDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterMediumTimpaniLeft => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterMediumTimpaniRight => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterMediumTimpaniUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterMediumXylophoneDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterMediumXylophoneLeft => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterMediumXylophoneRight => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterMediumXylophoneUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterMediumYarnDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterMediumYarnLeft => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterMediumYarnRight => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterMediumYarnUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterMetalBassDrumDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterMetalBassDrumUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterMetalDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterMetalHammer => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterMetalLeft => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterMetalRight => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterMetalUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSnareSticksDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSnareSticksUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSoftBassDrumDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSoftBassDrumUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSoftGlockenspielDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSoftGlockenspielLeft => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSoftGlockenspielRight => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSoftGlockenspielUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSoftTimpaniDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSoftTimpaniLeft => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSoftTimpaniRight => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSoftTimpaniUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSoftXylophone => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSoftXylophoneDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSoftXylophoneLeft => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSoftXylophoneRight => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSoftXylophoneUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSoftYarnDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSoftYarnLeft => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSoftYarnRight => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSoftYarnUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSpoonWoodenMallet => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSuperballDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSuperballLeft => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSuperballRight => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterSuperballUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterTriangleDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterTriangleUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterWireBrushesDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterWireBrushesUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterWoodTimpaniDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterWoodTimpaniLeft => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterWoodTimpaniRight => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterWoodTimpaniUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterWoodXylophoneDown => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterWoodXylophoneLeft => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterWoodXylophoneRight => Load() as GlyphDefinition;

        public GlyphDefinition PictBeaterWoodXylophoneUp => Load() as GlyphDefinition;

        public GlyphDefinition PictBell => Load() as GlyphDefinition;

        public GlyphDefinition PictBellOfCymbal => Load() as GlyphDefinition;

        public GlyphDefinition PictBellPlate => Load() as GlyphDefinition;

        public GlyphDefinition PictBellTree => Load() as GlyphDefinition;

        public GlyphDefinition PictBirdWhistle => Load() as GlyphDefinition;

        public GlyphDefinition PictBoardClapper => Load() as GlyphDefinition;

        public GlyphDefinition PictBongos => Load() as GlyphDefinition;

        public GlyphDefinition PictBrakeDrum => Load() as GlyphDefinition;

        public GlyphDefinition PictCabasa => Load() as GlyphDefinition;

        public GlyphDefinition PictCannon => Load() as GlyphDefinition;

        public GlyphDefinition PictCarHorn => Load() as GlyphDefinition;

        public GlyphDefinition PictCastanets => Load() as GlyphDefinition;

        public GlyphDefinition PictCastanetsWithHandle => Load() as GlyphDefinition;

        public GlyphDefinition PictCelesta => Load() as GlyphDefinition;

        public GlyphDefinition PictCencerro => Load() as GlyphDefinition;

        public GlyphDefinition PictCenter1 => Load() as GlyphDefinition;

        public GlyphDefinition PictCenter2 => Load() as GlyphDefinition;

        public GlyphDefinition PictCenter3 => Load() as GlyphDefinition;

        public GlyphDefinition PictChainRattle => Load() as GlyphDefinition;

        public GlyphDefinition PictChimes => Load() as GlyphDefinition;

        public GlyphDefinition PictChineseCymbal => Load() as GlyphDefinition;

        public GlyphDefinition PictChokeCymbal => Load() as GlyphDefinition;

        public GlyphDefinition PictClaves => Load() as GlyphDefinition;

        public GlyphDefinition PictCoins => Load() as GlyphDefinition;

        public GlyphDefinition PictConga => Load() as GlyphDefinition;

        public GlyphDefinition PictCowBell => Load() as GlyphDefinition;

        public GlyphDefinition PictCrashCymbals => Load() as GlyphDefinition;

        public GlyphDefinition PictCrotales => Load() as GlyphDefinition;

        public GlyphDefinition PictCrushStem => Load() as GlyphDefinition;

        public GlyphDefinition PictCuica => Load() as GlyphDefinition;

        public GlyphDefinition PictCymbalTongs => Load() as GlyphDefinition;

        public GlyphDefinition PictDamp1 => Load() as GlyphDefinition;

        public GlyphDefinition PictDamp2 => Load() as GlyphDefinition;

        public GlyphDefinition PictDamp3 => Load() as GlyphDefinition;

        public GlyphDefinition PictDamp4 => Load() as GlyphDefinition;

        public GlyphDefinition PictDeadNoteStem => Load() as GlyphDefinition;

        public GlyphDefinition PictDrumStick => Load() as GlyphDefinition;

        public GlyphDefinition PictDuckCall => Load() as GlyphDefinition;

        public GlyphDefinition PictEdgeOfCymbal => Load() as GlyphDefinition;

        public GlyphDefinition PictEmptyTrap => Load() as GlyphDefinition;

        public GlyphDefinition PictFingerCymbals => Load() as GlyphDefinition;

        public GlyphDefinition PictFlexatone => Load() as GlyphDefinition;

        public GlyphDefinition PictFootballRatchet => Load() as GlyphDefinition;

        public GlyphDefinition PictGlassHarmonica => Load() as GlyphDefinition;

        public GlyphDefinition PictGlassHarp => Load() as GlyphDefinition;

        public GlyphDefinition PictGlassPlateChimes => Load() as GlyphDefinition;

        public GlyphDefinition PictGlassTubeChimes => Load() as GlyphDefinition;

        public GlyphDefinition PictGlsp => Load() as GlyphDefinition;

        public GlyphDefinition PictGlspSmithBrindle => Load() as GlyphDefinition;

        public GlyphDefinition PictGobletDrum => Load() as GlyphDefinition;

        public GlyphDefinition PictGong => Load() as GlyphDefinition;

        public GlyphDefinition PictGongWithButton => Load() as GlyphDefinition;

        public GlyphDefinition PictGuiro => Load() as GlyphDefinition;

        public GlyphDefinition PictGumHardDown => Load() as GlyphDefinition;

        public GlyphDefinition PictGumHardLeft => Load() as GlyphDefinition;

        public GlyphDefinition PictGumHardRight => Load() as GlyphDefinition;

        public GlyphDefinition PictGumHardUp => Load() as GlyphDefinition;

        public GlyphDefinition PictGumMediumDown => Load() as GlyphDefinition;

        public GlyphDefinition PictGumMediumLeft => Load() as GlyphDefinition;

        public GlyphDefinition PictGumMediumRight => Load() as GlyphDefinition;

        public GlyphDefinition PictGumMediumUp => Load() as GlyphDefinition;

        public GlyphDefinition PictGumSoftDown => Load() as GlyphDefinition;

        public GlyphDefinition PictGumSoftLeft => Load() as GlyphDefinition;

        public GlyphDefinition PictGumSoftRight => Load() as GlyphDefinition;

        public GlyphDefinition PictGumSoftUp => Load() as GlyphDefinition;

        public GlyphDefinition PictHalfOpen1 => Load() as GlyphDefinition;

        public GlyphDefinition PictHalfOpen2 => Load() as GlyphDefinition;

        public GlyphDefinition PictHandbell => Load() as GlyphDefinition;

        public GlyphDefinition PictHiHat => Load() as GlyphDefinition;

        public GlyphDefinition PictHiHatOnStand => Load() as GlyphDefinition;

        public GlyphDefinition PictJawHarp => Load() as GlyphDefinition;

        public GlyphDefinition PictJingleBells => Load() as GlyphDefinition;

        public GlyphDefinition PictKlaxonHorn => Load() as GlyphDefinition;

        public GlyphDefinition PictLeftHandCircle => Load() as GlyphDefinition;

        public GlyphDefinition PictLionsRoar => Load() as GlyphDefinition;

        public GlyphDefinition PictLithophone => Load() as GlyphDefinition;

        public GlyphDefinition PictLogDrum => Load() as GlyphDefinition;

        public GlyphDefinition PictLotusFlute => Load() as GlyphDefinition;

        public GlyphDefinition PictMar => Load() as GlyphDefinition;

        public GlyphDefinition PictMarSmithBrindle => Load() as GlyphDefinition;

        public GlyphDefinition PictMaraca => Load() as GlyphDefinition;

        public GlyphDefinition PictMaracas => Load() as GlyphDefinition;

        public GlyphDefinition PictMegaphone => Load() as GlyphDefinition;

        public GlyphDefinition PictMetalPlateChimes => Load() as GlyphDefinition;

        public GlyphDefinition PictMetalTubeChimes => Load() as GlyphDefinition;

        public GlyphDefinition PictMusicalSaw => Load() as GlyphDefinition;

        public GlyphDefinition PictNormalPosition => Load() as GlyphDefinition;

        public GlyphDefinition PictOnRim => Load() as GlyphDefinition;

        public GlyphDefinition PictOpen => Load() as GlyphDefinition;

        public GlyphDefinition PictOpenRimShot => Load() as GlyphDefinition;

        public GlyphDefinition PictPistolShot => Load() as GlyphDefinition;

        public GlyphDefinition PictPoliceWhistle => Load() as GlyphDefinition;

        public GlyphDefinition PictQuijada => Load() as GlyphDefinition;

        public GlyphDefinition PictRainstick => Load() as GlyphDefinition;

        public GlyphDefinition PictRatchet => Load() as GlyphDefinition;

        public GlyphDefinition PictRecoReco => Load() as GlyphDefinition;

        public GlyphDefinition PictRightHandSquare => Load() as GlyphDefinition;

        public GlyphDefinition PictRim1 => Load() as GlyphDefinition;

        public GlyphDefinition PictRim2 => Load() as GlyphDefinition;

        public GlyphDefinition PictRim3 => Load() as GlyphDefinition;

        public GlyphDefinition PictRimShotOnStem => Load() as GlyphDefinition;

        public GlyphDefinition PictSandpaperBlocks => Load() as GlyphDefinition;

        public GlyphDefinition PictScrapeAroundRim => Load() as GlyphDefinition;

        public GlyphDefinition PictScrapeCenterToEdge => Load() as GlyphDefinition;

        public GlyphDefinition PictScrapeEdgeToCenter => Load() as GlyphDefinition;

        public GlyphDefinition PictShellBells => Load() as GlyphDefinition;

        public GlyphDefinition PictShellChimes => Load() as GlyphDefinition;

        public GlyphDefinition PictSiren => Load() as GlyphDefinition;

        public GlyphDefinition PictSistrum => Load() as GlyphDefinition;

        public GlyphDefinition PictSizzleCymbal => Load() as GlyphDefinition;

        public GlyphDefinition PictSleighBell => Load() as GlyphDefinition;

        public GlyphDefinition PictSlideBrushOnGong => Load() as GlyphDefinition;

        public GlyphDefinition PictSlideWhistle => Load() as GlyphDefinition;

        public GlyphDefinition PictSlitDrum => Load() as GlyphDefinition;

        public GlyphDefinition PictSnareDrum => Load() as GlyphDefinition;

        public GlyphDefinition PictSnareDrumMilitary => Load() as GlyphDefinition;

        public GlyphDefinition PictSnareDrumSnaresOff => Load() as GlyphDefinition;

        public GlyphDefinition PictSteelDrums => Load() as GlyphDefinition;

        public GlyphDefinition PictStickShot => Load() as GlyphDefinition;

        public GlyphDefinition PictSuperball => Load() as GlyphDefinition;

        public GlyphDefinition PictSuspendedCymbal => Load() as GlyphDefinition;

        public GlyphDefinition PictSwishStem => Load() as GlyphDefinition;

        public GlyphDefinition PictTabla => Load() as GlyphDefinition;

        public GlyphDefinition PictTamTam => Load() as GlyphDefinition;

        public GlyphDefinition PictTamTamWithBeater => Load() as GlyphDefinition;

        public GlyphDefinition PictTambourine => Load() as GlyphDefinition;

        public GlyphDefinition PictTempleBlocks => Load() as GlyphDefinition;

        public GlyphDefinition PictTenorDrum => Load() as GlyphDefinition;

        public GlyphDefinition PictThundersheet => Load() as GlyphDefinition;

        public GlyphDefinition PictTimbales => Load() as GlyphDefinition;

        public GlyphDefinition PictTimpani => Load() as GlyphDefinition;

        public GlyphDefinition PictTomTom => Load() as GlyphDefinition;

        public GlyphDefinition PictTomTomChinese => Load() as GlyphDefinition;

        public GlyphDefinition PictTomTomIndoAmerican => Load() as GlyphDefinition;

        public GlyphDefinition PictTomTomJapanese => Load() as GlyphDefinition;

        public GlyphDefinition PictTriangle => Load() as GlyphDefinition;

        public GlyphDefinition PictTubaphone => Load() as GlyphDefinition;

        public GlyphDefinition PictTubularBells => Load() as GlyphDefinition;

        public GlyphDefinition PictTurnLeftStem => Load() as GlyphDefinition;

        public GlyphDefinition PictTurnRightLeftStem => Load() as GlyphDefinition;

        public GlyphDefinition PictTurnRightStem => Load() as GlyphDefinition;

        public GlyphDefinition PictVib => Load() as GlyphDefinition;

        public GlyphDefinition PictVibMotorOff => Load() as GlyphDefinition;

        public GlyphDefinition PictVibSmithBrindle => Load() as GlyphDefinition;

        public GlyphDefinition PictVibraslap => Load() as GlyphDefinition;

        public GlyphDefinition PictVietnameseHat => Load() as GlyphDefinition;

        public GlyphDefinition PictWhip => Load() as GlyphDefinition;

        public GlyphDefinition PictWindChimesGlass => Load() as GlyphDefinition;

        public GlyphDefinition PictWindMachine => Load() as GlyphDefinition;

        public GlyphDefinition PictWindWhistle => Load() as GlyphDefinition;

        public GlyphDefinition PictWoodBlock => Load() as GlyphDefinition;

        public GlyphDefinition PictWoundHardDown => Load() as GlyphDefinition;

        public GlyphDefinition PictWoundHardLeft => Load() as GlyphDefinition;

        public GlyphDefinition PictWoundHardRight => Load() as GlyphDefinition;

        public GlyphDefinition PictWoundHardUp => Load() as GlyphDefinition;

        public GlyphDefinition PictWoundSoftDown => Load() as GlyphDefinition;

        public GlyphDefinition PictWoundSoftLeft => Load() as GlyphDefinition;

        public GlyphDefinition PictWoundSoftRight => Load() as GlyphDefinition;

        public GlyphDefinition PictWoundSoftUp => Load() as GlyphDefinition;

        public GlyphDefinition PictXyl => Load() as GlyphDefinition;

        public GlyphDefinition PictXylBass => Load() as GlyphDefinition;

        public GlyphDefinition PictXylSmithBrindle => Load() as GlyphDefinition;

        public GlyphDefinition PictXylTenor => Load() as GlyphDefinition;

        public GlyphDefinition PictXylTenorTrough => Load() as GlyphDefinition;

        public GlyphDefinition PictXylTrough => Load() as GlyphDefinition;

        public GlyphDefinition PluckedBuzzPizzicato => Load() as GlyphDefinition;

        public GlyphDefinition PluckedDamp => Load() as GlyphDefinition;

        public GlyphDefinition PluckedDampAll => Load() as GlyphDefinition;

        public GlyphDefinition PluckedDampOnStem => Load() as GlyphDefinition;

        public GlyphDefinition PluckedFingernailFlick => Load() as GlyphDefinition;

        public GlyphDefinition PluckedLeftHandPizzicato => Load() as GlyphDefinition;

        public GlyphDefinition PluckedPlectrum => Load() as GlyphDefinition;

        public GlyphDefinition PluckedSnapPizzicatoAbove => Load() as GlyphDefinition;

        public GlyphDefinition PluckedSnapPizzicatoBelow => Load() as GlyphDefinition;

        public GlyphDefinition PluckedWithFingernails => Load() as GlyphDefinition;

        public GlyphDefinition Quindicesima => Load() as GlyphDefinition;

        public GlyphDefinition QuindicesimaAlta => Load() as GlyphDefinition;

        public GlyphDefinition QuindicesimaBassa => Load() as GlyphDefinition;

        public GlyphDefinition QuindicesimaBassaMb => Load() as GlyphDefinition;

        public GlyphDefinition Repeat1Bar => Load() as GlyphDefinition;

        public GlyphDefinition Repeat2Bars => Load() as GlyphDefinition;

        public GlyphDefinition Repeat4Bars => Load() as GlyphDefinition;

        public GlyphDefinition RepeatDot => Load() as GlyphDefinition;

        public GlyphDefinition RepeatDots => Load() as GlyphDefinition;

        public GlyphDefinition RepeatLeft => Load() as GlyphDefinition;

        public GlyphDefinition RepeatRight => Load() as GlyphDefinition;

        public GlyphDefinition RepeatRightLeft => Load() as GlyphDefinition;

        public GlyphDefinition Rest1024Th => Load() as GlyphDefinition;

        public GlyphDefinition Rest128Th => Load() as GlyphDefinition;

        public GlyphDefinition Rest16Th => Load() as GlyphDefinition;

        public GlyphDefinition Rest256Th => Load() as GlyphDefinition;

        public GlyphDefinition Rest32Nd => Load() as GlyphDefinition;

        public GlyphDefinition Rest512Th => Load() as GlyphDefinition;

        public GlyphDefinition Rest64Th => Load() as GlyphDefinition;

        public GlyphDefinition Rest8Th => Load() as GlyphDefinition;

        public GlyphDefinition RestDoubleWhole => Load() as GlyphDefinition;

        public GlyphDefinition RestDoubleWholeLegerLine => Load() as GlyphDefinition;

        public GlyphDefinition RestHBar => Load() as GlyphDefinition;

        public GlyphDefinition RestHBarLeft => Load() as GlyphDefinition;

        public GlyphDefinition RestHBarMiddle => Load() as GlyphDefinition;

        public GlyphDefinition RestHBarRight => Load() as GlyphDefinition;

        public GlyphDefinition RestHalf => Load() as GlyphDefinition;

        public GlyphDefinition RestHalfLegerLine => Load() as GlyphDefinition;

        public GlyphDefinition RestLonga => Load() as GlyphDefinition;

        public GlyphDefinition RestMaxima => Load() as GlyphDefinition;

        public GlyphDefinition RestQuarter => Load() as GlyphDefinition;

        public GlyphDefinition RestQuarterOld => Load() as GlyphDefinition;

        public GlyphDefinition RestWhole => Load() as GlyphDefinition;

        public GlyphDefinition RestWholeLegerLine => Load() as GlyphDefinition;

        public GlyphDefinition ReversedBrace => Load() as GlyphDefinition;

        public GlyphDefinition ReversedBracketBottom => Load() as GlyphDefinition;

        public GlyphDefinition ReversedBracketTop => Load() as GlyphDefinition;

        public GlyphDefinition RightRepeatSmall => Load() as GlyphDefinition;

        public GlyphDefinition Segno => Load() as GlyphDefinition;

        public GlyphDefinition SegnoSerpent1 => Load() as GlyphDefinition;

        public GlyphDefinition SegnoSerpent2 => Load() as GlyphDefinition;

        public GlyphDefinition SemipitchedPercussionClef1 => Load() as GlyphDefinition;

        public GlyphDefinition SemipitchedPercussionClef2 => Load() as GlyphDefinition;

        public GlyphDefinition SmnFlat => Load() as GlyphDefinition;

        public GlyphDefinition SmnFlatWhite => Load() as GlyphDefinition;

        public GlyphDefinition SmnHistoryDoubleFlat => Load() as GlyphDefinition;

        public GlyphDefinition SmnHistoryDoubleSharp => Load() as GlyphDefinition;

        public GlyphDefinition SmnHistoryFlat => Load() as GlyphDefinition;

        public GlyphDefinition SmnHistorySharp => Load() as GlyphDefinition;

        public GlyphDefinition SmnNatural => Load() as GlyphDefinition;

        public GlyphDefinition SmnSharp => Load() as GlyphDefinition;

        public GlyphDefinition SmnSharpDown => Load() as GlyphDefinition;

        public GlyphDefinition SmnSharpWhite => Load() as GlyphDefinition;

        public GlyphDefinition SmnSharpWhiteDown => Load() as GlyphDefinition;

        public GlyphDefinition SplitBarDivider => Load() as GlyphDefinition;

        public GlyphDefinition Staff1Line => Load() as GlyphDefinition;

        public GlyphDefinition Staff1LineNarrow => Load() as GlyphDefinition;

        public GlyphDefinition Staff1LineWide => Load() as GlyphDefinition;

        public GlyphDefinition Staff2Lines => Load() as GlyphDefinition;

        public GlyphDefinition Staff2LinesNarrow => Load() as GlyphDefinition;

        public GlyphDefinition Staff2LinesWide => Load() as GlyphDefinition;

        public GlyphDefinition Staff3Lines => Load() as GlyphDefinition;

        public GlyphDefinition Staff3LinesNarrow => Load() as GlyphDefinition;

        public GlyphDefinition Staff3LinesWide => Load() as GlyphDefinition;

        public GlyphDefinition Staff4Lines => Load() as GlyphDefinition;

        public GlyphDefinition Staff4LinesNarrow => Load() as GlyphDefinition;

        public GlyphDefinition Staff4LinesWide => Load() as GlyphDefinition;

        public GlyphDefinition Staff5Lines => Load() as GlyphDefinition;

        public GlyphDefinition Staff5LinesNarrow => Load() as GlyphDefinition;

        public GlyphDefinition Staff5LinesWide => Load() as GlyphDefinition;

        public GlyphDefinition Staff6Lines => Load() as GlyphDefinition;

        public GlyphDefinition Staff6LinesNarrow => Load() as GlyphDefinition;

        public GlyphDefinition Staff6LinesWide => Load() as GlyphDefinition;

        public GlyphDefinition StaffDivideArrowDown => Load() as GlyphDefinition;

        public GlyphDefinition StaffDivideArrowUp => Load() as GlyphDefinition;

        public GlyphDefinition StaffDivideArrowUpDown => Load() as GlyphDefinition;

        public GlyphDefinition StaffPosLower1 => Load() as GlyphDefinition;

        public GlyphDefinition StaffPosLower2 => Load() as GlyphDefinition;

        public GlyphDefinition StaffPosLower3 => Load() as GlyphDefinition;

        public GlyphDefinition StaffPosLower4 => Load() as GlyphDefinition;

        public GlyphDefinition StaffPosLower5 => Load() as GlyphDefinition;

        public GlyphDefinition StaffPosLower6 => Load() as GlyphDefinition;

        public GlyphDefinition StaffPosLower7 => Load() as GlyphDefinition;

        public GlyphDefinition StaffPosLower8 => Load() as GlyphDefinition;

        public GlyphDefinition StaffPosRaise1 => Load() as GlyphDefinition;

        public GlyphDefinition StaffPosRaise2 => Load() as GlyphDefinition;

        public GlyphDefinition StaffPosRaise3 => Load() as GlyphDefinition;

        public GlyphDefinition StaffPosRaise4 => Load() as GlyphDefinition;

        public GlyphDefinition StaffPosRaise5 => Load() as GlyphDefinition;

        public GlyphDefinition StaffPosRaise6 => Load() as GlyphDefinition;

        public GlyphDefinition StaffPosRaise7 => Load() as GlyphDefinition;

        public GlyphDefinition StaffPosRaise8 => Load() as GlyphDefinition;

        public GlyphDefinition Stem => Load() as GlyphDefinition;

        public GlyphDefinition StemBowOnBridge => Load() as GlyphDefinition;

        public GlyphDefinition StemBowOnTailpiece => Load() as GlyphDefinition;

        public GlyphDefinition StemBuzzRoll => Load() as GlyphDefinition;

        public GlyphDefinition StemDamp => Load() as GlyphDefinition;

        public GlyphDefinition StemHarpStringNoise => Load() as GlyphDefinition;

        public GlyphDefinition StemMultiphonicsBlack => Load() as GlyphDefinition;

        public GlyphDefinition StemMultiphonicsBlackWhite => Load() as GlyphDefinition;

        public GlyphDefinition StemMultiphonicsWhite => Load() as GlyphDefinition;

        public GlyphDefinition StemPendereckiTremolo => Load() as GlyphDefinition;

        public GlyphDefinition StemRimShot => Load() as GlyphDefinition;

        public GlyphDefinition StemSprechgesang => Load() as GlyphDefinition;

        public GlyphDefinition StemSulPonticello => Load() as GlyphDefinition;

        public GlyphDefinition StemSussurando => Load() as GlyphDefinition;

        public GlyphDefinition StemSwished => Load() as GlyphDefinition;

        public GlyphDefinition StemVibratoPulse => Load() as GlyphDefinition;

        public GlyphDefinition StringsBowBehindBridge => Load() as GlyphDefinition;

        public GlyphDefinition StringsBowOnBridge => Load() as GlyphDefinition;

        public GlyphDefinition StringsBowOnTailpiece => Load() as GlyphDefinition;

        public GlyphDefinition StringsChangeBowDirection => Load() as GlyphDefinition;

        public GlyphDefinition StringsDownBow => Load() as GlyphDefinition;

        public GlyphDefinition StringsDownBowTurned => Load() as GlyphDefinition;

        public GlyphDefinition StringsFouette => Load() as GlyphDefinition;

        public GlyphDefinition StringsHalfHarmonic => Load() as GlyphDefinition;

        public GlyphDefinition StringsHarmonic => Load() as GlyphDefinition;

        public GlyphDefinition StringsJeteAbove => Load() as GlyphDefinition;

        public GlyphDefinition StringsJeteBelow => Load() as GlyphDefinition;

        public GlyphDefinition StringsMuteOff => Load() as GlyphDefinition;

        public GlyphDefinition StringsMuteOn => Load() as GlyphDefinition;

        public GlyphDefinition StringsOverpressureDownBow => Load() as GlyphDefinition;

        public GlyphDefinition StringsOverpressureNoDirection => Load() as GlyphDefinition;

        public GlyphDefinition StringsOverpressurePossibileDownBow => Load() as GlyphDefinition;

        public GlyphDefinition StringsOverpressurePossibileUpBow => Load() as GlyphDefinition;

        public GlyphDefinition StringsOverpressureUpBow => Load() as GlyphDefinition;

        public GlyphDefinition StringsThumbPosition => Load() as GlyphDefinition;

        public GlyphDefinition StringsThumbPositionTurned => Load() as GlyphDefinition;

        public GlyphDefinition StringsUpBow => Load() as GlyphDefinition;

        public GlyphDefinition StringsUpBowTurned => Load() as GlyphDefinition;

        public GlyphDefinition StringsVibratoPulse => Load() as GlyphDefinition;

        public GlyphDefinition SystemDivider => Load() as GlyphDefinition;

        public GlyphDefinition SystemDividerExtraLong => Load() as GlyphDefinition;

        public GlyphDefinition SystemDividerLong => Load() as GlyphDefinition;

        public GlyphDefinition TextAugmentationDot => Load() as GlyphDefinition;

        public GlyphDefinition TextBlackNoteFrac16ThLongStem => Load() as GlyphDefinition;

        public GlyphDefinition TextBlackNoteFrac16ThShortStem => Load() as GlyphDefinition;

        public GlyphDefinition TextBlackNoteFrac32NdLongStem => Load() as GlyphDefinition;

        public GlyphDefinition TextBlackNoteFrac8ThLongStem => Load() as GlyphDefinition;

        public GlyphDefinition TextBlackNoteFrac8ThShortStem => Load() as GlyphDefinition;

        public GlyphDefinition TextBlackNoteLongStem => Load() as GlyphDefinition;

        public GlyphDefinition TextBlackNoteShortStem => Load() as GlyphDefinition;

        public GlyphDefinition TextCont16ThBeamLongStem => Load() as GlyphDefinition;

        public GlyphDefinition TextCont16ThBeamShortStem => Load() as GlyphDefinition;

        public GlyphDefinition TextCont32NdBeamLongStem => Load() as GlyphDefinition;

        public GlyphDefinition TextCont8ThBeamLongStem => Load() as GlyphDefinition;

        public GlyphDefinition TextCont8ThBeamShortStem => Load() as GlyphDefinition;

        public GlyphDefinition TextTie => Load() as GlyphDefinition;

        public GlyphDefinition TextTuplet3LongStem => Load() as GlyphDefinition;

        public GlyphDefinition TextTuplet3ShortStem => Load() as GlyphDefinition;

        public GlyphDefinition TextTupletBracketEndLongStem => Load() as GlyphDefinition;

        public GlyphDefinition TextTupletBracketEndShortStem => Load() as GlyphDefinition;

        public GlyphDefinition TextTupletBracketStartLongStem => Load() as GlyphDefinition;

        public GlyphDefinition TextTupletBracketStartShortStem => Load() as GlyphDefinition;

        public GlyphDefinition TimeSig0 => Load() as GlyphDefinition;

        public GlyphDefinition TimeSig1 => Load() as GlyphDefinition;

        public GlyphDefinition TimeSig2 => Load() as GlyphDefinition;

        public GlyphDefinition TimeSig3 => Load() as GlyphDefinition;

        public GlyphDefinition TimeSig4 => Load() as GlyphDefinition;

        public GlyphDefinition TimeSig5 => Load() as GlyphDefinition;

        public GlyphDefinition TimeSig6 => Load() as GlyphDefinition;

        public GlyphDefinition TimeSig7 => Load() as GlyphDefinition;

        public GlyphDefinition TimeSig8 => Load() as GlyphDefinition;

        public GlyphDefinition TimeSig9 => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigBracketLeft => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigBracketLeftSmall => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigBracketRight => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigBracketRightSmall => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigCombDenominator => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigCombNumerator => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigComma => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigCommon => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigCut2 => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigCutCommon => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigEquals => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigFractionHalf => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigFractionOneThird => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigFractionQuarter => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigFractionThreeQuarters => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigFractionTwoThirds => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigFractionalSlash => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigMinus => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigMultiply => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigOpenPenderecki => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigParensLeft => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigParensLeftSmall => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigParensRight => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigParensRightSmall => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigPlus => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigPlusSmall => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigSlash => Load() as GlyphDefinition;

        public GlyphDefinition TimeSigX => Load() as GlyphDefinition;

        public GlyphDefinition Tremolo1 => Load() as GlyphDefinition;

        public GlyphDefinition Tremolo2 => Load() as GlyphDefinition;

        public GlyphDefinition Tremolo3 => Load() as GlyphDefinition;

        public GlyphDefinition Tremolo4 => Load() as GlyphDefinition;

        public GlyphDefinition Tremolo5 => Load() as GlyphDefinition;

        public GlyphDefinition TremoloDivisiDots2 => Load() as GlyphDefinition;

        public GlyphDefinition TremoloDivisiDots3 => Load() as GlyphDefinition;

        public GlyphDefinition TremoloDivisiDots4 => Load() as GlyphDefinition;

        public GlyphDefinition TremoloDivisiDots6 => Load() as GlyphDefinition;

        public GlyphDefinition TremoloFingered1 => Load() as GlyphDefinition;

        public GlyphDefinition TremoloFingered2 => Load() as GlyphDefinition;

        public GlyphDefinition TremoloFingered3 => Load() as GlyphDefinition;

        public GlyphDefinition TremoloFingered4 => Load() as GlyphDefinition;

        public GlyphDefinition TremoloFingered5 => Load() as GlyphDefinition;

        public GlyphDefinition TripleTongueAbove => Load() as GlyphDefinition;

        public GlyphDefinition TripleTongueBelow => Load() as GlyphDefinition;

        public GlyphDefinition Tuplet0 => Load() as GlyphDefinition;

        public GlyphDefinition Tuplet1 => Load() as GlyphDefinition;

        public GlyphDefinition Tuplet2 => Load() as GlyphDefinition;

        public GlyphDefinition Tuplet3 => Load() as GlyphDefinition;

        public GlyphDefinition Tuplet4 => Load() as GlyphDefinition;

        public GlyphDefinition Tuplet5 => Load() as GlyphDefinition;

        public GlyphDefinition Tuplet6 => Load() as GlyphDefinition;

        public GlyphDefinition Tuplet7 => Load() as GlyphDefinition;

        public GlyphDefinition Tuplet8 => Load() as GlyphDefinition;

        public GlyphDefinition Tuplet9 => Load() as GlyphDefinition;

        public GlyphDefinition TupletColon => Load() as GlyphDefinition;

        public GlyphDefinition UnmeasuredTremolo => Load() as GlyphDefinition;

        public GlyphDefinition UnmeasuredTremoloSimple => Load() as GlyphDefinition;

        public GlyphDefinition UnpitchedPercussionClef1 => Load() as GlyphDefinition;

        public GlyphDefinition UnpitchedPercussionClef2 => Load() as GlyphDefinition;

        public GlyphDefinition Ventiduesima => Load() as GlyphDefinition;

        public GlyphDefinition VentiduesimaAlta => Load() as GlyphDefinition;

        public GlyphDefinition VentiduesimaBassa => Load() as GlyphDefinition;

        public GlyphDefinition VentiduesimaBassaMb => Load() as GlyphDefinition;

        public GlyphDefinition VocalMouthClosed => Load() as GlyphDefinition;

        public GlyphDefinition VocalMouthOpen => Load() as GlyphDefinition;

        public GlyphDefinition VocalMouthPursed => Load() as GlyphDefinition;

        public GlyphDefinition VocalMouthSlightlyOpen => Load() as GlyphDefinition;

        public GlyphDefinition VocalMouthWideOpen => Load() as GlyphDefinition;

        public GlyphDefinition VocalSprechgesang => Load() as GlyphDefinition;

        public GlyphDefinition VocalsSussurando => Load() as GlyphDefinition;

        public GlyphDefinition WiggleArpeggiatoDown => Load() as GlyphDefinition;

        public GlyphDefinition WiggleArpeggiatoDownArrow => Load() as GlyphDefinition;

        public GlyphDefinition WiggleArpeggiatoDownSwash => Load() as GlyphDefinition;

        public GlyphDefinition WiggleArpeggiatoUp => Load() as GlyphDefinition;

        public GlyphDefinition WiggleArpeggiatoUpArrow => Load() as GlyphDefinition;

        public GlyphDefinition WiggleArpeggiatoUpSwash => Load() as GlyphDefinition;

        public GlyphDefinition WiggleCircular => Load() as GlyphDefinition;

        public GlyphDefinition WiggleCircularConstant => Load() as GlyphDefinition;

        public GlyphDefinition WiggleCircularConstantFlipped => Load() as GlyphDefinition;

        public GlyphDefinition WiggleCircularConstantFlippedLarge => Load() as GlyphDefinition;

        public GlyphDefinition WiggleCircularConstantLarge => Load() as GlyphDefinition;

        public GlyphDefinition WiggleCircularEnd => Load() as GlyphDefinition;

        public GlyphDefinition WiggleCircularLarge => Load() as GlyphDefinition;

        public GlyphDefinition WiggleCircularLarger => Load() as GlyphDefinition;

        public GlyphDefinition WiggleCircularLargerStill => Load() as GlyphDefinition;

        public GlyphDefinition WiggleCircularLargest => Load() as GlyphDefinition;

        public GlyphDefinition WiggleCircularSmall => Load() as GlyphDefinition;

        public GlyphDefinition WiggleCircularStart => Load() as GlyphDefinition;

        public GlyphDefinition WiggleGlissando => Load() as GlyphDefinition;

        public GlyphDefinition WiggleGlissandoGroup1 => Load() as GlyphDefinition;

        public GlyphDefinition WiggleGlissandoGroup2 => Load() as GlyphDefinition;

        public GlyphDefinition WiggleGlissandoGroup3 => Load() as GlyphDefinition;

        public GlyphDefinition WiggleRandom1 => Load() as GlyphDefinition;

        public GlyphDefinition WiggleRandom2 => Load() as GlyphDefinition;

        public GlyphDefinition WiggleRandom3 => Load() as GlyphDefinition;

        public GlyphDefinition WiggleRandom4 => Load() as GlyphDefinition;

        public GlyphDefinition WiggleSawtooth => Load() as GlyphDefinition;

        public GlyphDefinition WiggleSawtoothNarrow => Load() as GlyphDefinition;

        public GlyphDefinition WiggleSawtoothWide => Load() as GlyphDefinition;

        public GlyphDefinition WiggleSquareWave => Load() as GlyphDefinition;

        public GlyphDefinition WiggleSquareWaveNarrow => Load() as GlyphDefinition;

        public GlyphDefinition WiggleSquareWaveWide => Load() as GlyphDefinition;

        public GlyphDefinition WiggleTrill => Load() as GlyphDefinition;

        public GlyphDefinition WiggleTrillFast => Load() as GlyphDefinition;

        public GlyphDefinition WiggleTrillFaster => Load() as GlyphDefinition;

        public GlyphDefinition WiggleTrillFasterStill => Load() as GlyphDefinition;

        public GlyphDefinition WiggleTrillFastest => Load() as GlyphDefinition;

        public GlyphDefinition WiggleTrillSlow => Load() as GlyphDefinition;

        public GlyphDefinition WiggleTrillSlower => Load() as GlyphDefinition;

        public GlyphDefinition WiggleTrillSlowerStill => Load() as GlyphDefinition;

        public GlyphDefinition WiggleTrillSlowest => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVIbratoLargestSlower => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVIbratoMediumSlower => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibrato => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoLargeFast => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoLargeFaster => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoLargeFasterStill => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoLargeFastest => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoLargeSlow => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoLargeSlower => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoLargeSlowest => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoLargestFast => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoLargestFaster => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoLargestFasterStill => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoLargestFastest => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoLargestSlow => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoLargestSlowest => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoMediumFast => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoMediumFaster => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoMediumFasterStill => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoMediumFastest => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoMediumSlow => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoMediumSlowest => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoSmallFast => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoSmallFaster => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoSmallFasterStill => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoSmallFastest => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoSmallSlow => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoSmallSlower => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoSmallSlowest => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoSmallestFast => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoSmallestFaster => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoSmallestFasterStill => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoSmallestFastest => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoSmallestSlow => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoSmallestSlower => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoSmallestSlowest => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoStart => Load() as GlyphDefinition;

        public GlyphDefinition WiggleVibratoWide => Load() as GlyphDefinition;

        public GlyphDefinition WiggleWavy => Load() as GlyphDefinition;

        public GlyphDefinition WiggleWavyNarrow => Load() as GlyphDefinition;

        public GlyphDefinition WiggleWavyWide => Load() as GlyphDefinition;

        public GlyphDefinition WindClosedHole => Load() as GlyphDefinition;

        public GlyphDefinition WindFlatEmbouchure => Load() as GlyphDefinition;

        public GlyphDefinition WindHalfClosedHole1 => Load() as GlyphDefinition;

        public GlyphDefinition WindHalfClosedHole2 => Load() as GlyphDefinition;

        public GlyphDefinition WindHalfClosedHole3 => Load() as GlyphDefinition;

        public GlyphDefinition WindLessRelaxedEmbouchure => Load() as GlyphDefinition;

        public GlyphDefinition WindLessTightEmbouchure => Load() as GlyphDefinition;

        public GlyphDefinition WindMultiphonicsBlackStem => Load() as GlyphDefinition;

        public GlyphDefinition WindMultiphonicsBlackWhiteStem => Load() as GlyphDefinition;

        public GlyphDefinition WindMultiphonicsWhiteStem => Load() as GlyphDefinition;

        public GlyphDefinition WindOpenHole => Load() as GlyphDefinition;

        public GlyphDefinition WindReedPositionIn => Load() as GlyphDefinition;

        public GlyphDefinition WindReedPositionNormal => Load() as GlyphDefinition;

        public GlyphDefinition WindReedPositionOut => Load() as GlyphDefinition;

        public GlyphDefinition WindRelaxedEmbouchure => Load() as GlyphDefinition;

        public GlyphDefinition WindSharpEmbouchure => Load() as GlyphDefinition;

        public GlyphDefinition WindStrongAirPressure => Load() as GlyphDefinition;

        public GlyphDefinition WindThreeQuartersClosedHole => Load() as GlyphDefinition;

        public GlyphDefinition WindTightEmbouchure => Load() as GlyphDefinition;

        public GlyphDefinition WindTrillKey => Load() as GlyphDefinition;

        public GlyphDefinition WindVeryTightEmbouchure => Load() as GlyphDefinition;

        public GlyphDefinition WindWeakAirPressure => Load() as GlyphDefinition;
    }
}