using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Core.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manufaktura.Controls.SMuFL.LazyLoadingWithStaticProxy
{
    public class LazyGlyphBBoxes : LazyLoadJsonStaticProxy<IGlyphBBoxes>, IGlyphBBoxes
    {
        public LazyGlyphBBoxes(string jsonString) : base(jsonString,  new[] {typeof(LazySMuFLFontMetadata), typeof(LazySMuFLGlyphs), typeof(LazyGlyphBBoxes) })
        {
        }

        public BoundingBox The4StringTabClef => Load() as BoundingBox;

        public BoundingBox The4StringTabClefSerif => Load() as BoundingBox;

        public BoundingBox The4StringTabClefTall => Load() as BoundingBox;

        public BoundingBox The6StringTabClef => Load() as BoundingBox;

        public BoundingBox The6StringTabClefSerif => Load() as BoundingBox;

        public BoundingBox The6StringTabClefTall => Load() as BoundingBox;

        public BoundingBox AccSagittal11LargeDiesisDown => Load() as BoundingBox;

        public BoundingBox AccSagittal11LargeDiesisUp => Load() as BoundingBox;

        public BoundingBox AccSagittal11MediumDiesisDown => Load() as BoundingBox;

        public BoundingBox AccSagittal11MediumDiesisUp => Load() as BoundingBox;

        public BoundingBox AccSagittal11V19LargeDiesisDown => Load() as BoundingBox;

        public BoundingBox AccSagittal11V19LargeDiesisUp => Load() as BoundingBox;

        public BoundingBox AccSagittal11V19MediumDiesisDown => Load() as BoundingBox;

        public BoundingBox AccSagittal11V19MediumDiesisUp => Load() as BoundingBox;

        public BoundingBox AccSagittal11V49CommaDown => Load() as BoundingBox;

        public BoundingBox AccSagittal11V49CommaUp => Load() as BoundingBox;

        public BoundingBox AccSagittal143CommaDown => Load() as BoundingBox;

        public BoundingBox AccSagittal143CommaUp => Load() as BoundingBox;

        public BoundingBox AccSagittal17CommaDown => Load() as BoundingBox;

        public BoundingBox AccSagittal17CommaUp => Load() as BoundingBox;

        public BoundingBox AccSagittal17KleismaDown => Load() as BoundingBox;

        public BoundingBox AccSagittal17KleismaUp => Load() as BoundingBox;

        public BoundingBox AccSagittal19CommaDown => Load() as BoundingBox;

        public BoundingBox AccSagittal19CommaUp => Load() as BoundingBox;

        public BoundingBox AccSagittal19SchismaDown => Load() as BoundingBox;

        public BoundingBox AccSagittal19SchismaUp => Load() as BoundingBox;

        public BoundingBox AccSagittal23CommaDown => Load() as BoundingBox;

        public BoundingBox AccSagittal23CommaUp => Load() as BoundingBox;

        public BoundingBox AccSagittal23SmallDiesisDown => Load() as BoundingBox;

        public BoundingBox AccSagittal23SmallDiesisUp => Load() as BoundingBox;

        public BoundingBox AccSagittal25SmallDiesisDown => Load() as BoundingBox;

        public BoundingBox AccSagittal25SmallDiesisUp => Load() as BoundingBox;

        public BoundingBox AccSagittal35LargeDiesisDown => Load() as BoundingBox;

        public BoundingBox AccSagittal35LargeDiesisUp => Load() as BoundingBox;

        public BoundingBox AccSagittal35MediumDiesisDown => Load() as BoundingBox;

        public BoundingBox AccSagittal35MediumDiesisUp => Load() as BoundingBox;

        public BoundingBox AccSagittal49LargeDiesisDown => Load() as BoundingBox;

        public BoundingBox AccSagittal49LargeDiesisUp => Load() as BoundingBox;

        public BoundingBox AccSagittal49MediumDiesisDown => Load() as BoundingBox;

        public BoundingBox AccSagittal49MediumDiesisUp => Load() as BoundingBox;

        public BoundingBox AccSagittal49SmallDiesisDown => Load() as BoundingBox;

        public BoundingBox AccSagittal49SmallDiesisUp => Load() as BoundingBox;

        public BoundingBox AccSagittal55CommaDown => Load() as BoundingBox;

        public BoundingBox AccSagittal55CommaUp => Load() as BoundingBox;

        public BoundingBox AccSagittal5CommaDown => Load() as BoundingBox;

        public BoundingBox AccSagittal5CommaUp => Load() as BoundingBox;

        public BoundingBox AccSagittal5V11SmallDiesisDown => Load() as BoundingBox;

        public BoundingBox AccSagittal5V11SmallDiesisUp => Load() as BoundingBox;

        public BoundingBox AccSagittal5V13LargeDiesisDown => Load() as BoundingBox;

        public BoundingBox AccSagittal5V13LargeDiesisUp => Load() as BoundingBox;

        public BoundingBox AccSagittal5V13MediumDiesisDown => Load() as BoundingBox;

        public BoundingBox AccSagittal5V13MediumDiesisUp => Load() as BoundingBox;

        public BoundingBox AccSagittal5V19CommaDown => Load() as BoundingBox;

        public BoundingBox AccSagittal5V19CommaUp => Load() as BoundingBox;

        public BoundingBox AccSagittal5V23SmallDiesisDown => Load() as BoundingBox;

        public BoundingBox AccSagittal5V23SmallDiesisUp => Load() as BoundingBox;

        public BoundingBox AccSagittal5V49MediumDiesisDown => Load() as BoundingBox;

        public BoundingBox AccSagittal5V49MediumDiesisUp => Load() as BoundingBox;

        public BoundingBox AccSagittal5V7KleismaDown => Load() as BoundingBox;

        public BoundingBox AccSagittal5V7KleismaUp => Load() as BoundingBox;

        public BoundingBox AccSagittal7CommaDown => Load() as BoundingBox;

        public BoundingBox AccSagittal7CommaUp => Load() as BoundingBox;

        public BoundingBox AccSagittal7V11CommaDown => Load() as BoundingBox;

        public BoundingBox AccSagittal7V11CommaUp => Load() as BoundingBox;

        public BoundingBox AccSagittal7V11KleismaDown => Load() as BoundingBox;

        public BoundingBox AccSagittal7V11KleismaUp => Load() as BoundingBox;

        public BoundingBox AccSagittal7V19CommaDown => Load() as BoundingBox;

        public BoundingBox AccSagittal7V19CommaUp => Load() as BoundingBox;

        public BoundingBox AccSagittalAcute => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleFlat => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleFlat11V49CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleFlat143CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleFlat17CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleFlat17KUp => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleFlat19CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleFlat19SUp => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleFlat23CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleFlat23SUp => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleFlat25SUp => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleFlat49SUp => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleFlat55CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleFlat5CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleFlat5V11SUp => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleFlat5V19CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleFlat5V23SUp => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleFlat5V7KUp => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleFlat7CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleFlat7V11CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleFlat7V11KUp => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleFlat7V19CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleSharp => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleSharp11V49CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleSharp143CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleSharp17CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleSharp17KDown => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleSharp19CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleSharp19SDown => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleSharp23CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleSharp23SDown => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleSharp25SDown => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleSharp49SDown => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleSharp55CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleSharp5CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleSharp5V11SDown => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleSharp5V19CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleSharp5V23SDown => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleSharp5V7KDown => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleSharp7CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleSharp7V11CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleSharp7V11KDown => Load() as BoundingBox;

        public BoundingBox AccSagittalDoubleSharp7V19CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat11LDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat11MDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat11V19LDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat11V19MDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat11V49CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat11V49CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat143CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat143CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat17CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat17CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat17KDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat17KUp => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat19CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat19CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat19SDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat19SUp => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat23CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat23CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat23SDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat23SUp => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat25SDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat25SUp => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat35LDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat35MDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat49LDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat49MDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat49SDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat49SUp => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat55CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat55CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat5CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat5CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat5V11SDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat5V11SUp => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat5V13LDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat5V13MDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat5V19CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat5V19CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat5V23SDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat5V23SUp => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat5V49MDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat5V7KDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat5V7KUp => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat7CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat7CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat7V11CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat7V11CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat7V11KDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat7V11KUp => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat7V19CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalFlat7V19CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalGrave => Load() as BoundingBox;

        public BoundingBox AccSagittalShaftDown => Load() as BoundingBox;

        public BoundingBox AccSagittalShaftUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp11LUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp11MUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp11V19LUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp11V19MUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp11V49CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp11V49CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp143CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp143CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp17CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp17CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp17KDown => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp17KUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp19CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp19CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp19SDown => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp19SUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp23CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp23CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp23SDown => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp23SUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp25SDown => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp25SUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp35LUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp35MUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp49LUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp49MUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp49SDown => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp49SUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp55CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp55CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp5CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp5CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp5V11SDown => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp5V11SUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp5V13LUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp5V13MUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp5V19CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp5V19CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp5V23SDown => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp5V23SUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp5V49MUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp5V7KDown => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp5V7KUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp7CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp7CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp7V11CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp7V11CUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp7V11KDown => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp7V11KUp => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp7V19CDown => Load() as BoundingBox;

        public BoundingBox AccSagittalSharp7V19CUp => Load() as BoundingBox;

        public BoundingBox AccdnCombDot => Load() as BoundingBox;

        public BoundingBox AccdnCombLh2RanksEmpty => Load() as BoundingBox;

        public BoundingBox AccdnCombLh3RanksEmptySquare => Load() as BoundingBox;

        public BoundingBox AccdnCombRh3RanksEmpty => Load() as BoundingBox;

        public BoundingBox AccdnCombRh4RanksEmpty => Load() as BoundingBox;

        public BoundingBox AccdnDiatonicClef => Load() as BoundingBox;

        public BoundingBox AccdnLh2Ranks16Round => Load() as BoundingBox;

        public BoundingBox AccdnLh2Ranks8Plus16Round => Load() as BoundingBox;

        public BoundingBox AccdnLh2Ranks8Round => Load() as BoundingBox;

        public BoundingBox AccdnLh2RanksFullMasterRound => Load() as BoundingBox;

        public BoundingBox AccdnLh2RanksMasterPlus16Round => Load() as BoundingBox;

        public BoundingBox AccdnLh2RanksMasterRound => Load() as BoundingBox;

        public BoundingBox AccdnLh3Ranks2Plus8Square => Load() as BoundingBox;

        public BoundingBox AccdnLh3Ranks2Square => Load() as BoundingBox;

        public BoundingBox AccdnLh3Ranks8Square => Load() as BoundingBox;

        public BoundingBox AccdnLh3RanksDouble8Square => Load() as BoundingBox;

        public BoundingBox AccdnLh3RanksTuttiSquare => Load() as BoundingBox;

        public BoundingBox AccdnPull => Load() as BoundingBox;

        public BoundingBox AccdnPush => Load() as BoundingBox;

        public BoundingBox AccdnPushAlt => Load() as BoundingBox;

        public BoundingBox AccdnRh3RanksAccordion => Load() as BoundingBox;

        public BoundingBox AccdnRh3RanksAuthenticMusette => Load() as BoundingBox;

        public BoundingBox AccdnRh3RanksBandoneon => Load() as BoundingBox;

        public BoundingBox AccdnRh3RanksBassoon => Load() as BoundingBox;

        public BoundingBox AccdnRh3RanksClarinet => Load() as BoundingBox;

        public BoundingBox AccdnRh3RanksDoubleTremoloLower8Ve => Load() as BoundingBox;

        public BoundingBox AccdnRh3RanksDoubleTremoloUpper8Ve => Load() as BoundingBox;

        public BoundingBox AccdnRh3RanksFullFactory => Load() as BoundingBox;

        public BoundingBox AccdnRh3RanksHarmonium => Load() as BoundingBox;

        public BoundingBox AccdnRh3RanksImitationMusette => Load() as BoundingBox;

        public BoundingBox AccdnRh3RanksLowerTremolo8 => Load() as BoundingBox;

        public BoundingBox AccdnRh3RanksMaster => Load() as BoundingBox;

        public BoundingBox AccdnRh3RanksOboe => Load() as BoundingBox;

        public BoundingBox AccdnRh3RanksOrgan => Load() as BoundingBox;

        public BoundingBox AccdnRh3RanksPiccolo => Load() as BoundingBox;

        public BoundingBox AccdnRh3RanksTremoloLower8Ve => Load() as BoundingBox;

        public BoundingBox AccdnRh3RanksTremoloUpper8Ve => Load() as BoundingBox;

        public BoundingBox AccdnRh3RanksTwoChoirs => Load() as BoundingBox;

        public BoundingBox AccdnRh3RanksUpperTremolo8 => Load() as BoundingBox;

        public BoundingBox AccdnRh3RanksViolin => Load() as BoundingBox;

        public BoundingBox AccdnRh4RanksAlto => Load() as BoundingBox;

        public BoundingBox AccdnRh4RanksBassAlto => Load() as BoundingBox;

        public BoundingBox AccdnRh4RanksMaster => Load() as BoundingBox;

        public BoundingBox AccdnRh4RanksSoftBass => Load() as BoundingBox;

        public BoundingBox AccdnRh4RanksSoftTenor => Load() as BoundingBox;

        public BoundingBox AccdnRh4RanksSoprano => Load() as BoundingBox;

        public BoundingBox AccdnRh4RanksTenor => Load() as BoundingBox;

        public BoundingBox AccdnRicochet2 => Load() as BoundingBox;

        public BoundingBox AccdnRicochet3 => Load() as BoundingBox;

        public BoundingBox AccdnRicochet4 => Load() as BoundingBox;

        public BoundingBox AccdnRicochet5 => Load() as BoundingBox;

        public BoundingBox AccdnRicochet6 => Load() as BoundingBox;

        public BoundingBox AccdnRicochetStem2 => Load() as BoundingBox;

        public BoundingBox AccdnRicochetStem3 => Load() as BoundingBox;

        public BoundingBox AccdnRicochetStem4 => Load() as BoundingBox;

        public BoundingBox AccdnRicochetStem5 => Load() as BoundingBox;

        public BoundingBox AccdnRicochetStem6 => Load() as BoundingBox;

        public BoundingBox Accidental1CommaFlat => Load() as BoundingBox;

        public BoundingBox Accidental1CommaSharp => Load() as BoundingBox;

        public BoundingBox Accidental2CommaFlat => Load() as BoundingBox;

        public BoundingBox Accidental2CommaSharp => Load() as BoundingBox;

        public BoundingBox Accidental3CommaFlat => Load() as BoundingBox;

        public BoundingBox Accidental3CommaSharp => Load() as BoundingBox;

        public BoundingBox Accidental4CommaFlat => Load() as BoundingBox;

        public BoundingBox Accidental5CommaSharp => Load() as BoundingBox;

        public BoundingBox AccidentalArrowDown => Load() as BoundingBox;

        public BoundingBox AccidentalArrowUp => Load() as BoundingBox;

        public BoundingBox AccidentalBakiyeFlat => Load() as BoundingBox;

        public BoundingBox AccidentalBakiyeSharp => Load() as BoundingBox;

        public BoundingBox AccidentalBracketLeft => Load() as BoundingBox;

        public BoundingBox AccidentalBracketRight => Load() as BoundingBox;

        public BoundingBox AccidentalBuyukMucennebFlat => Load() as BoundingBox;

        public BoundingBox AccidentalBuyukMucennebSharp => Load() as BoundingBox;

        public BoundingBox AccidentalCombiningCloseCurlyBrace => Load() as BoundingBox;

        public BoundingBox AccidentalCombiningLower17Schisma => Load() as BoundingBox;

        public BoundingBox AccidentalCombiningLower19Schisma => Load() as BoundingBox;

        public BoundingBox AccidentalCombiningLower23Limit29LimitComma => Load() as BoundingBox;

        public BoundingBox AccidentalCombiningLower31Schisma => Load() as BoundingBox;

        public BoundingBox AccidentalCombiningLower53LimitComma => Load() as BoundingBox;

        public BoundingBox AccidentalCombiningOpenCurlyBrace => Load() as BoundingBox;

        public BoundingBox AccidentalCombiningRaise17Schisma => Load() as BoundingBox;

        public BoundingBox AccidentalCombiningRaise19Schisma => Load() as BoundingBox;

        public BoundingBox AccidentalCombiningRaise23Limit29LimitComma => Load() as BoundingBox;

        public BoundingBox AccidentalCombiningRaise31Schisma => Load() as BoundingBox;

        public BoundingBox AccidentalCombiningRaise53LimitComma => Load() as BoundingBox;

        public BoundingBox AccidentalCommaSlashDown => Load() as BoundingBox;

        public BoundingBox AccidentalCommaSlashUp => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleFlat => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleFlatArabic => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleFlatEqualTempered => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleFlatJoinedStems => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleFlatOneArrowDown => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleFlatOneArrowUp => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleFlatParens => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleFlatReversed => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleFlatThreeArrowsDown => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleFlatThreeArrowsUp => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleFlatTurned => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleFlatTwoArrowsDown => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleFlatTwoArrowsUp => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleSharp => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleSharpArabic => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleSharpEqualTempered => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleSharpOneArrowDown => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleSharpOneArrowUp => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleSharpParens => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleSharpThreeArrowsDown => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleSharpThreeArrowsUp => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleSharpTwoArrowsDown => Load() as BoundingBox;

        public BoundingBox AccidentalDoubleSharpTwoArrowsUp => Load() as BoundingBox;

        public BoundingBox AccidentalEnharmonicAlmostEqualTo => Load() as BoundingBox;

        public BoundingBox AccidentalEnharmonicEquals => Load() as BoundingBox;

        public BoundingBox AccidentalEnharmonicTilde => Load() as BoundingBox;

        public BoundingBox AccidentalFilledReversedFlatAndFlat => Load() as BoundingBox;

        public BoundingBox AccidentalFilledReversedFlatAndFlatArrowDown => Load() as BoundingBox;

        public BoundingBox AccidentalFilledReversedFlatAndFlatArrowUp => Load() as BoundingBox;

        public BoundingBox AccidentalFilledReversedFlatArrowDown => Load() as BoundingBox;

        public BoundingBox AccidentalFilledReversedFlatArrowUp => Load() as BoundingBox;

        public BoundingBox AccidentalFiveQuarterTonesFlatArrowDown => Load() as BoundingBox;

        public BoundingBox AccidentalFiveQuarterTonesSharpArrowUp => Load() as BoundingBox;

        public BoundingBox AccidentalFlat => Load() as BoundingBox;

        public BoundingBox AccidentalFlatArabic => Load() as BoundingBox;

        public BoundingBox AccidentalFlatEqualTempered => Load() as BoundingBox;

        public BoundingBox AccidentalFlatJohnstonDown => Load() as BoundingBox;

        public BoundingBox AccidentalFlatJohnstonEl => Load() as BoundingBox;

        public BoundingBox AccidentalFlatJohnstonElDown => Load() as BoundingBox;

        public BoundingBox AccidentalFlatJohnstonUp => Load() as BoundingBox;

        public BoundingBox AccidentalFlatJohnstonUpEl => Load() as BoundingBox;

        public BoundingBox AccidentalFlatLoweredStockhausen => Load() as BoundingBox;

        public BoundingBox AccidentalFlatOneArrowDown => Load() as BoundingBox;

        public BoundingBox AccidentalFlatOneArrowUp => Load() as BoundingBox;

        public BoundingBox AccidentalFlatParens => Load() as BoundingBox;

        public BoundingBox AccidentalFlatRaisedStockhausen => Load() as BoundingBox;

        public BoundingBox AccidentalFlatRepeatedLineStockhausen => Load() as BoundingBox;

        public BoundingBox AccidentalFlatRepeatedSpaceStockhausen => Load() as BoundingBox;

        public BoundingBox AccidentalFlatSmall => Load() as BoundingBox;

        public BoundingBox AccidentalFlatThreeArrowsDown => Load() as BoundingBox;

        public BoundingBox AccidentalFlatThreeArrowsUp => Load() as BoundingBox;

        public BoundingBox AccidentalFlatTurned => Load() as BoundingBox;

        public BoundingBox AccidentalFlatTwoArrowsDown => Load() as BoundingBox;

        public BoundingBox AccidentalFlatTwoArrowsUp => Load() as BoundingBox;

        public BoundingBox AccidentalHalfSharpArrowDown => Load() as BoundingBox;

        public BoundingBox AccidentalHalfSharpArrowUp => Load() as BoundingBox;

        public BoundingBox AccidentalJohnston13 => Load() as BoundingBox;

        public BoundingBox AccidentalJohnston31 => Load() as BoundingBox;

        public BoundingBox AccidentalJohnstonDown => Load() as BoundingBox;

        public BoundingBox AccidentalJohnstonDownEl => Load() as BoundingBox;

        public BoundingBox AccidentalJohnstonEl => Load() as BoundingBox;

        public BoundingBox AccidentalJohnstonMinus => Load() as BoundingBox;

        public BoundingBox AccidentalJohnstonPlus => Load() as BoundingBox;

        public BoundingBox AccidentalJohnstonSeven => Load() as BoundingBox;

        public BoundingBox AccidentalJohnstonSevenDown => Load() as BoundingBox;

        public BoundingBox AccidentalJohnstonSevenFlat => Load() as BoundingBox;

        public BoundingBox AccidentalJohnstonSevenFlatDown => Load() as BoundingBox;

        public BoundingBox AccidentalJohnstonSevenFlatUp => Load() as BoundingBox;

        public BoundingBox AccidentalJohnstonSevenSharp => Load() as BoundingBox;

        public BoundingBox AccidentalJohnstonSevenSharpDown => Load() as BoundingBox;

        public BoundingBox AccidentalJohnstonSevenSharpUp => Load() as BoundingBox;

        public BoundingBox AccidentalJohnstonSevenUp => Load() as BoundingBox;

        public BoundingBox AccidentalJohnstonUp => Load() as BoundingBox;

        public BoundingBox AccidentalJohnstonUpEl => Load() as BoundingBox;

        public BoundingBox AccidentalKomaFlat => Load() as BoundingBox;

        public BoundingBox AccidentalKomaSharp => Load() as BoundingBox;

        public BoundingBox AccidentalKoron => Load() as BoundingBox;

        public BoundingBox AccidentalKucukMucennebFlat => Load() as BoundingBox;

        public BoundingBox AccidentalKucukMucennebSharp => Load() as BoundingBox;

        public BoundingBox AccidentalLargeDoubleSharp => Load() as BoundingBox;

        public BoundingBox AccidentalLowerOneSeptimalComma => Load() as BoundingBox;

        public BoundingBox AccidentalLowerOneTridecimalQuartertone => Load() as BoundingBox;

        public BoundingBox AccidentalLowerOneUndecimalQuartertone => Load() as BoundingBox;

        public BoundingBox AccidentalLowerTwoSeptimalCommas => Load() as BoundingBox;

        public BoundingBox AccidentalLoweredStockhausen => Load() as BoundingBox;

        public BoundingBox AccidentalNarrowReversedFlat => Load() as BoundingBox;

        public BoundingBox AccidentalNarrowReversedFlatAndFlat => Load() as BoundingBox;

        public BoundingBox AccidentalNatural => Load() as BoundingBox;

        public BoundingBox AccidentalNaturalArabic => Load() as BoundingBox;

        public BoundingBox AccidentalNaturalEqualTempered => Load() as BoundingBox;

        public BoundingBox AccidentalNaturalFlat => Load() as BoundingBox;

        public BoundingBox AccidentalNaturalLoweredStockhausen => Load() as BoundingBox;

        public BoundingBox AccidentalNaturalOneArrowDown => Load() as BoundingBox;

        public BoundingBox AccidentalNaturalOneArrowUp => Load() as BoundingBox;

        public BoundingBox AccidentalNaturalParens => Load() as BoundingBox;

        public BoundingBox AccidentalNaturalRaisedStockhausen => Load() as BoundingBox;

        public BoundingBox AccidentalNaturalReversed => Load() as BoundingBox;

        public BoundingBox AccidentalNaturalSharp => Load() as BoundingBox;

        public BoundingBox AccidentalNaturalSmall => Load() as BoundingBox;

        public BoundingBox AccidentalNaturalThreeArrowsDown => Load() as BoundingBox;

        public BoundingBox AccidentalNaturalThreeArrowsUp => Load() as BoundingBox;

        public BoundingBox AccidentalNaturalTwoArrowsDown => Load() as BoundingBox;

        public BoundingBox AccidentalNaturalTwoArrowsUp => Load() as BoundingBox;

        public BoundingBox AccidentalOneAndAHalfSharpsArrowDown => Load() as BoundingBox;

        public BoundingBox AccidentalOneAndAHalfSharpsArrowUp => Load() as BoundingBox;

        public BoundingBox AccidentalOneQuarterToneFlatFerneyhough => Load() as BoundingBox;

        public BoundingBox AccidentalOneQuarterToneFlatStockhausen => Load() as BoundingBox;

        public BoundingBox AccidentalOneQuarterToneSharpFerneyhough => Load() as BoundingBox;

        public BoundingBox AccidentalOneQuarterToneSharpStockhausen => Load() as BoundingBox;

        public BoundingBox AccidentalOneThirdToneFlatFerneyhough => Load() as BoundingBox;

        public BoundingBox AccidentalOneThirdToneSharpFerneyhough => Load() as BoundingBox;

        public BoundingBox AccidentalParensLeft => Load() as BoundingBox;

        public BoundingBox AccidentalParensRight => Load() as BoundingBox;

        public BoundingBox AccidentalQuarterFlatEqualTempered => Load() as BoundingBox;

        public BoundingBox AccidentalQuarterSharpEqualTempered => Load() as BoundingBox;

        public BoundingBox AccidentalQuarterToneFlat4 => Load() as BoundingBox;

        public BoundingBox AccidentalQuarterToneFlatArabic => Load() as BoundingBox;

        public BoundingBox AccidentalQuarterToneFlatArrowUp => Load() as BoundingBox;

        public BoundingBox AccidentalQuarterToneFlatFilledReversed => Load() as BoundingBox;

        public BoundingBox AccidentalQuarterToneFlatNaturalArrowDown => Load() as BoundingBox;

        public BoundingBox AccidentalQuarterToneFlatPenderecki => Load() as BoundingBox;

        public BoundingBox AccidentalQuarterToneFlatStein => Load() as BoundingBox;

        public BoundingBox AccidentalQuarterToneFlatVanBlankenburg => Load() as BoundingBox;

        public BoundingBox AccidentalQuarterToneSharp4 => Load() as BoundingBox;

        public BoundingBox AccidentalQuarterToneSharpArabic => Load() as BoundingBox;

        public BoundingBox AccidentalQuarterToneSharpArrowDown => Load() as BoundingBox;

        public BoundingBox AccidentalQuarterToneSharpBusotti => Load() as BoundingBox;

        public BoundingBox AccidentalQuarterToneSharpNaturalArrowUp => Load() as BoundingBox;

        public BoundingBox AccidentalQuarterToneSharpStein => Load() as BoundingBox;

        public BoundingBox AccidentalQuarterToneSharpWiggle => Load() as BoundingBox;

        public BoundingBox AccidentalRaiseOneSeptimalComma => Load() as BoundingBox;

        public BoundingBox AccidentalRaiseOneTridecimalQuartertone => Load() as BoundingBox;

        public BoundingBox AccidentalRaiseOneUndecimalQuartertone => Load() as BoundingBox;

        public BoundingBox AccidentalRaiseTwoSeptimalCommas => Load() as BoundingBox;

        public BoundingBox AccidentalRaisedStockhausen => Load() as BoundingBox;

        public BoundingBox AccidentalReversedFlatAndFlatArrowDown => Load() as BoundingBox;

        public BoundingBox AccidentalReversedFlatAndFlatArrowUp => Load() as BoundingBox;

        public BoundingBox AccidentalReversedFlatArrowDown => Load() as BoundingBox;

        public BoundingBox AccidentalReversedFlatArrowUp => Load() as BoundingBox;

        public BoundingBox AccidentalSharp => Load() as BoundingBox;

        public BoundingBox AccidentalSharpArabic => Load() as BoundingBox;

        public BoundingBox AccidentalSharpEqualTempered => Load() as BoundingBox;

        public BoundingBox AccidentalSharpJohnstonDown => Load() as BoundingBox;

        public BoundingBox AccidentalSharpJohnstonDownEl => Load() as BoundingBox;

        public BoundingBox AccidentalSharpJohnstonEl => Load() as BoundingBox;

        public BoundingBox AccidentalSharpJohnstonUp => Load() as BoundingBox;

        public BoundingBox AccidentalSharpJohnstonUpEl => Load() as BoundingBox;

        public BoundingBox AccidentalSharpLoweredStockhausen => Load() as BoundingBox;

        public BoundingBox AccidentalSharpOneArrowDown => Load() as BoundingBox;

        public BoundingBox AccidentalSharpOneArrowUp => Load() as BoundingBox;

        public BoundingBox AccidentalSharpOneHorizontalStroke => Load() as BoundingBox;

        public BoundingBox AccidentalSharpParens => Load() as BoundingBox;

        public BoundingBox AccidentalSharpRaisedStockhausen => Load() as BoundingBox;

        public BoundingBox AccidentalSharpRepeatedLineStockhausen => Load() as BoundingBox;

        public BoundingBox AccidentalSharpRepeatedSpaceStockhausen => Load() as BoundingBox;

        public BoundingBox AccidentalSharpReversed => Load() as BoundingBox;

        public BoundingBox AccidentalSharpSharp => Load() as BoundingBox;

        public BoundingBox AccidentalSharpSmall => Load() as BoundingBox;

        public BoundingBox AccidentalSharpThreeArrowsDown => Load() as BoundingBox;

        public BoundingBox AccidentalSharpThreeArrowsUp => Load() as BoundingBox;

        public BoundingBox AccidentalSharpTwoArrowsDown => Load() as BoundingBox;

        public BoundingBox AccidentalSharpTwoArrowsUp => Load() as BoundingBox;

        public BoundingBox AccidentalSims12Down => Load() as BoundingBox;

        public BoundingBox AccidentalSims12Up => Load() as BoundingBox;

        public BoundingBox AccidentalSims4Down => Load() as BoundingBox;

        public BoundingBox AccidentalSims4Up => Load() as BoundingBox;

        public BoundingBox AccidentalSims6Down => Load() as BoundingBox;

        public BoundingBox AccidentalSims6Up => Load() as BoundingBox;

        public BoundingBox AccidentalSori => Load() as BoundingBox;

        public BoundingBox AccidentalTavenerFlat => Load() as BoundingBox;

        public BoundingBox AccidentalTavenerSharp => Load() as BoundingBox;

        public BoundingBox AccidentalThreeQuarterTonesFlatArabic => Load() as BoundingBox;

        public BoundingBox AccidentalThreeQuarterTonesFlatArrowDown => Load() as BoundingBox;

        public BoundingBox AccidentalThreeQuarterTonesFlatArrowUp => Load() as BoundingBox;

        public BoundingBox AccidentalThreeQuarterTonesFlatCouper => Load() as BoundingBox;

        public BoundingBox AccidentalThreeQuarterTonesFlatGrisey => Load() as BoundingBox;

        public BoundingBox AccidentalThreeQuarterTonesFlatTartini => Load() as BoundingBox;

        public BoundingBox AccidentalThreeQuarterTonesFlatZimmermann => Load() as BoundingBox;

        public BoundingBox AccidentalThreeQuarterTonesSharpArabic => Load() as BoundingBox;

        public BoundingBox AccidentalThreeQuarterTonesSharpArrowDown => Load() as BoundingBox;

        public BoundingBox AccidentalThreeQuarterTonesSharpArrowUp => Load() as BoundingBox;

        public BoundingBox AccidentalThreeQuarterTonesSharpBusotti => Load() as BoundingBox;

        public BoundingBox AccidentalThreeQuarterTonesSharpStein => Load() as BoundingBox;

        public BoundingBox AccidentalThreeQuarterTonesSharpStockhausen => Load() as BoundingBox;

        public BoundingBox AccidentalTripleFlat => Load() as BoundingBox;

        public BoundingBox AccidentalTripleFlatJoinedStems => Load() as BoundingBox;

        public BoundingBox AccidentalTripleSharp => Load() as BoundingBox;

        public BoundingBox AccidentalTwoThirdTonesFlatFerneyhough => Load() as BoundingBox;

        public BoundingBox AccidentalTwoThirdTonesSharpFerneyhough => Load() as BoundingBox;

        public BoundingBox AccidentalWilsonMinus => Load() as BoundingBox;

        public BoundingBox AccidentalWilsonPlus => Load() as BoundingBox;

        public BoundingBox AccidentalWyschnegradsky10TwelfthsFlat => Load() as BoundingBox;

        public BoundingBox AccidentalWyschnegradsky10TwelfthsSharp => Load() as BoundingBox;

        public BoundingBox AccidentalWyschnegradsky11TwelfthsFlat => Load() as BoundingBox;

        public BoundingBox AccidentalWyschnegradsky11TwelfthsSharp => Load() as BoundingBox;

        public BoundingBox AccidentalWyschnegradsky1TwelfthsFlat => Load() as BoundingBox;

        public BoundingBox AccidentalWyschnegradsky1TwelfthsSharp => Load() as BoundingBox;

        public BoundingBox AccidentalWyschnegradsky2TwelfthsFlat => Load() as BoundingBox;

        public BoundingBox AccidentalWyschnegradsky2TwelfthsSharp => Load() as BoundingBox;

        public BoundingBox AccidentalWyschnegradsky3TwelfthsFlat => Load() as BoundingBox;

        public BoundingBox AccidentalWyschnegradsky3TwelfthsSharp => Load() as BoundingBox;

        public BoundingBox AccidentalWyschnegradsky4TwelfthsFlat => Load() as BoundingBox;

        public BoundingBox AccidentalWyschnegradsky4TwelfthsSharp => Load() as BoundingBox;

        public BoundingBox AccidentalWyschnegradsky5TwelfthsFlat => Load() as BoundingBox;

        public BoundingBox AccidentalWyschnegradsky5TwelfthsSharp => Load() as BoundingBox;

        public BoundingBox AccidentalWyschnegradsky6TwelfthsFlat => Load() as BoundingBox;

        public BoundingBox AccidentalWyschnegradsky6TwelfthsSharp => Load() as BoundingBox;

        public BoundingBox AccidentalWyschnegradsky7TwelfthsFlat => Load() as BoundingBox;

        public BoundingBox AccidentalWyschnegradsky7TwelfthsSharp => Load() as BoundingBox;

        public BoundingBox AccidentalWyschnegradsky8TwelfthsFlat => Load() as BoundingBox;

        public BoundingBox AccidentalWyschnegradsky8TwelfthsSharp => Load() as BoundingBox;

        public BoundingBox AccidentalWyschnegradsky9TwelfthsFlat => Load() as BoundingBox;

        public BoundingBox AccidentalWyschnegradsky9TwelfthsSharp => Load() as BoundingBox;

        public BoundingBox AccidentalXenakisOneThirdToneSharp => Load() as BoundingBox;

        public BoundingBox AccidentalXenakisTwoThirdTonesSharp => Load() as BoundingBox;

        public BoundingBox AnalyticsChoralmelodie => Load() as BoundingBox;

        public BoundingBox AnalyticsEndStimme => Load() as BoundingBox;

        public BoundingBox AnalyticsHauptrhythmus => Load() as BoundingBox;

        public BoundingBox AnalyticsHauptrhythmusR => Load() as BoundingBox;

        public BoundingBox AnalyticsHauptstimme => Load() as BoundingBox;

        public BoundingBox AnalyticsInversion1 => Load() as BoundingBox;

        public BoundingBox AnalyticsNebenstimme => Load() as BoundingBox;

        public BoundingBox AnalyticsStartStimme => Load() as BoundingBox;

        public BoundingBox AnalyticsTheme => Load() as BoundingBox;

        public BoundingBox AnalyticsTheme1 => Load() as BoundingBox;

        public BoundingBox AnalyticsThemeInversion => Load() as BoundingBox;

        public BoundingBox AnalyticsThemeRetrograde => Load() as BoundingBox;

        public BoundingBox AnalyticsThemeRetrogradeInversion => Load() as BoundingBox;

        public BoundingBox ArpeggiatoDown => Load() as BoundingBox;

        public BoundingBox ArpeggiatoUp => Load() as BoundingBox;

        public BoundingBox ArrowBlackDown => Load() as BoundingBox;

        public BoundingBox ArrowBlackDownLeft => Load() as BoundingBox;

        public BoundingBox ArrowBlackDownRight => Load() as BoundingBox;

        public BoundingBox ArrowBlackLeft => Load() as BoundingBox;

        public BoundingBox ArrowBlackRight => Load() as BoundingBox;

        public BoundingBox ArrowBlackUp => Load() as BoundingBox;

        public BoundingBox ArrowBlackUpLeft => Load() as BoundingBox;

        public BoundingBox ArrowBlackUpRight => Load() as BoundingBox;

        public BoundingBox ArrowOpenDown => Load() as BoundingBox;

        public BoundingBox ArrowOpenDownLeft => Load() as BoundingBox;

        public BoundingBox ArrowOpenDownRight => Load() as BoundingBox;

        public BoundingBox ArrowOpenLeft => Load() as BoundingBox;

        public BoundingBox ArrowOpenRight => Load() as BoundingBox;

        public BoundingBox ArrowOpenUp => Load() as BoundingBox;

        public BoundingBox ArrowOpenUpLeft => Load() as BoundingBox;

        public BoundingBox ArrowOpenUpRight => Load() as BoundingBox;

        public BoundingBox ArrowWhiteDown => Load() as BoundingBox;

        public BoundingBox ArrowWhiteDownLeft => Load() as BoundingBox;

        public BoundingBox ArrowWhiteDownRight => Load() as BoundingBox;

        public BoundingBox ArrowWhiteLeft => Load() as BoundingBox;

        public BoundingBox ArrowWhiteRight => Load() as BoundingBox;

        public BoundingBox ArrowWhiteUp => Load() as BoundingBox;

        public BoundingBox ArrowWhiteUpLeft => Load() as BoundingBox;

        public BoundingBox ArrowWhiteUpRight => Load() as BoundingBox;

        public BoundingBox ArrowheadBlackDown => Load() as BoundingBox;

        public BoundingBox ArrowheadBlackDownLeft => Load() as BoundingBox;

        public BoundingBox ArrowheadBlackDownRight => Load() as BoundingBox;

        public BoundingBox ArrowheadBlackLeft => Load() as BoundingBox;

        public BoundingBox ArrowheadBlackRight => Load() as BoundingBox;

        public BoundingBox ArrowheadBlackUp => Load() as BoundingBox;

        public BoundingBox ArrowheadBlackUpLeft => Load() as BoundingBox;

        public BoundingBox ArrowheadBlackUpRight => Load() as BoundingBox;

        public BoundingBox ArrowheadOpenDown => Load() as BoundingBox;

        public BoundingBox ArrowheadOpenDownLeft => Load() as BoundingBox;

        public BoundingBox ArrowheadOpenDownRight => Load() as BoundingBox;

        public BoundingBox ArrowheadOpenLeft => Load() as BoundingBox;

        public BoundingBox ArrowheadOpenRight => Load() as BoundingBox;

        public BoundingBox ArrowheadOpenUp => Load() as BoundingBox;

        public BoundingBox ArrowheadOpenUpLeft => Load() as BoundingBox;

        public BoundingBox ArrowheadOpenUpRight => Load() as BoundingBox;

        public BoundingBox ArrowheadWhiteDown => Load() as BoundingBox;

        public BoundingBox ArrowheadWhiteDownLeft => Load() as BoundingBox;

        public BoundingBox ArrowheadWhiteDownRight => Load() as BoundingBox;

        public BoundingBox ArrowheadWhiteLeft => Load() as BoundingBox;

        public BoundingBox ArrowheadWhiteRight => Load() as BoundingBox;

        public BoundingBox ArrowheadWhiteUp => Load() as BoundingBox;

        public BoundingBox ArrowheadWhiteUpLeft => Load() as BoundingBox;

        public BoundingBox ArrowheadWhiteUpRight => Load() as BoundingBox;

        public BoundingBox ArticAccentAbove => Load() as BoundingBox;

        public BoundingBox ArticAccentAboveLarge => Load() as BoundingBox;

        public BoundingBox ArticAccentAboveSmall => Load() as BoundingBox;

        public BoundingBox ArticAccentBelow => Load() as BoundingBox;

        public BoundingBox ArticAccentBelowLarge => Load() as BoundingBox;

        public BoundingBox ArticAccentBelowSmall => Load() as BoundingBox;

        public BoundingBox ArticAccentStaccatoAbove => Load() as BoundingBox;

        public BoundingBox ArticAccentStaccatoAboveSmall => Load() as BoundingBox;

        public BoundingBox ArticAccentStaccatoBelow => Load() as BoundingBox;

        public BoundingBox ArticAccentStaccatoBelowSmall => Load() as BoundingBox;

        public BoundingBox ArticLaissezVibrerAbove => Load() as BoundingBox;

        public BoundingBox ArticLaissezVibrerBelow => Load() as BoundingBox;

        public BoundingBox ArticMarcatoAbove => Load() as BoundingBox;

        public BoundingBox ArticMarcatoAboveSmall => Load() as BoundingBox;

        public BoundingBox ArticMarcatoBelow => Load() as BoundingBox;

        public BoundingBox ArticMarcatoBelowSmall => Load() as BoundingBox;

        public BoundingBox ArticMarcatoStaccatoAbove => Load() as BoundingBox;

        public BoundingBox ArticMarcatoStaccatoAboveSmall => Load() as BoundingBox;

        public BoundingBox ArticMarcatoStaccatoBelow => Load() as BoundingBox;

        public BoundingBox ArticMarcatoStaccatoBelowSmall => Load() as BoundingBox;

        public BoundingBox ArticMarcatoTenutoAbove => Load() as BoundingBox;

        public BoundingBox ArticMarcatoTenutoBelow => Load() as BoundingBox;

        public BoundingBox ArticSoftAccentAbove => Load() as BoundingBox;

        public BoundingBox ArticSoftAccentBelow => Load() as BoundingBox;

        public BoundingBox ArticSoftAccentStaccatoAbove => Load() as BoundingBox;

        public BoundingBox ArticSoftAccentStaccatoBelow => Load() as BoundingBox;

        public BoundingBox ArticSoftAccentTenutoAbove => Load() as BoundingBox;

        public BoundingBox ArticSoftAccentTenutoBelow => Load() as BoundingBox;

        public BoundingBox ArticSoftAccentTenutoStaccatoAbove => Load() as BoundingBox;

        public BoundingBox ArticSoftAccentTenutoStaccatoBelow => Load() as BoundingBox;

        public BoundingBox ArticStaccatissimoAbove => Load() as BoundingBox;

        public BoundingBox ArticStaccatissimoAboveSmall => Load() as BoundingBox;

        public BoundingBox ArticStaccatissimoBelow => Load() as BoundingBox;

        public BoundingBox ArticStaccatissimoBelowSmall => Load() as BoundingBox;

        public BoundingBox ArticStaccatissimoStrokeAbove => Load() as BoundingBox;

        public BoundingBox ArticStaccatissimoStrokeAboveSmall => Load() as BoundingBox;

        public BoundingBox ArticStaccatissimoStrokeBelow => Load() as BoundingBox;

        public BoundingBox ArticStaccatissimoStrokeBelowSmall => Load() as BoundingBox;

        public BoundingBox ArticStaccatissimoWedgeAbove => Load() as BoundingBox;

        public BoundingBox ArticStaccatissimoWedgeAboveSmall => Load() as BoundingBox;

        public BoundingBox ArticStaccatissimoWedgeBelow => Load() as BoundingBox;

        public BoundingBox ArticStaccatissimoWedgeBelowSmall => Load() as BoundingBox;

        public BoundingBox ArticStaccatoAbove => Load() as BoundingBox;

        public BoundingBox ArticStaccatoAboveSmall => Load() as BoundingBox;

        public BoundingBox ArticStaccatoBelow => Load() as BoundingBox;

        public BoundingBox ArticStaccatoBelowSmall => Load() as BoundingBox;

        public BoundingBox ArticStressAbove => Load() as BoundingBox;

        public BoundingBox ArticStressBelow => Load() as BoundingBox;

        public BoundingBox ArticTenutoAbove => Load() as BoundingBox;

        public BoundingBox ArticTenutoAboveSmall => Load() as BoundingBox;

        public BoundingBox ArticTenutoAccentAbove => Load() as BoundingBox;

        public BoundingBox ArticTenutoAccentAboveSmall => Load() as BoundingBox;

        public BoundingBox ArticTenutoAccentBelow => Load() as BoundingBox;

        public BoundingBox ArticTenutoAccentBelowSmall => Load() as BoundingBox;

        public BoundingBox ArticTenutoBelow => Load() as BoundingBox;

        public BoundingBox ArticTenutoBelowSmall => Load() as BoundingBox;

        public BoundingBox ArticTenutoStaccatoAbove => Load() as BoundingBox;

        public BoundingBox ArticTenutoStaccatoAboveSmall => Load() as BoundingBox;

        public BoundingBox ArticTenutoStaccatoBelow => Load() as BoundingBox;

        public BoundingBox ArticTenutoStaccatoBelowSmall => Load() as BoundingBox;

        public BoundingBox ArticUnstressAbove => Load() as BoundingBox;

        public BoundingBox ArticUnstressBelow => Load() as BoundingBox;

        public BoundingBox AugmentationDot => Load() as BoundingBox;

        public BoundingBox BarlineDashed => Load() as BoundingBox;

        public BoundingBox BarlineDotted => Load() as BoundingBox;

        public BoundingBox BarlineDouble => Load() as BoundingBox;

        public BoundingBox BarlineFinal => Load() as BoundingBox;

        public BoundingBox BarlineHeavy => Load() as BoundingBox;

        public BoundingBox BarlineHeavyHeavy => Load() as BoundingBox;

        public BoundingBox BarlineReverseFinal => Load() as BoundingBox;

        public BoundingBox BarlineShort => Load() as BoundingBox;

        public BoundingBox BarlineSingle => Load() as BoundingBox;

        public BoundingBox BarlineTick => Load() as BoundingBox;

        public BoundingBox BeamAccelRit1 => Load() as BoundingBox;

        public BoundingBox BeamAccelRit10 => Load() as BoundingBox;

        public BoundingBox BeamAccelRit11 => Load() as BoundingBox;

        public BoundingBox BeamAccelRit12 => Load() as BoundingBox;

        public BoundingBox BeamAccelRit13 => Load() as BoundingBox;

        public BoundingBox BeamAccelRit14 => Load() as BoundingBox;

        public BoundingBox BeamAccelRit15 => Load() as BoundingBox;

        public BoundingBox BeamAccelRit2 => Load() as BoundingBox;

        public BoundingBox BeamAccelRit3 => Load() as BoundingBox;

        public BoundingBox BeamAccelRit4 => Load() as BoundingBox;

        public BoundingBox BeamAccelRit5 => Load() as BoundingBox;

        public BoundingBox BeamAccelRit6 => Load() as BoundingBox;

        public BoundingBox BeamAccelRit7 => Load() as BoundingBox;

        public BoundingBox BeamAccelRit8 => Load() as BoundingBox;

        public BoundingBox BeamAccelRit9 => Load() as BoundingBox;

        public BoundingBox BeamAccelRitFinal => Load() as BoundingBox;

        public BoundingBox Brace => Load() as BoundingBox;

        public BoundingBox BraceFlat => Load() as BoundingBox;

        public BoundingBox BraceLarge => Load() as BoundingBox;

        public BoundingBox BraceLarger => Load() as BoundingBox;

        public BoundingBox BraceSmall => Load() as BoundingBox;

        public BoundingBox Bracket => Load() as BoundingBox;

        public BoundingBox BracketBottom => Load() as BoundingBox;

        public BoundingBox BracketTop => Load() as BoundingBox;

        public BoundingBox BrassBend => Load() as BoundingBox;

        public BoundingBox BrassDoitLong => Load() as BoundingBox;

        public BoundingBox BrassDoitMedium => Load() as BoundingBox;

        public BoundingBox BrassDoitShort => Load() as BoundingBox;

        public BoundingBox BrassFallLipLong => Load() as BoundingBox;

        public BoundingBox BrassFallLipMedium => Load() as BoundingBox;

        public BoundingBox BrassFallLipShort => Load() as BoundingBox;

        public BoundingBox BrassFallRoughLong => Load() as BoundingBox;

        public BoundingBox BrassFallRoughMedium => Load() as BoundingBox;

        public BoundingBox BrassFallRoughShort => Load() as BoundingBox;

        public BoundingBox BrassFallSmoothLong => Load() as BoundingBox;

        public BoundingBox BrassFallSmoothMedium => Load() as BoundingBox;

        public BoundingBox BrassFallSmoothShort => Load() as BoundingBox;

        public BoundingBox BrassFlip => Load() as BoundingBox;

        public BoundingBox BrassHarmonMuteClosed => Load() as BoundingBox;

        public BoundingBox BrassHarmonMuteStemHalfLeft => Load() as BoundingBox;

        public BoundingBox BrassHarmonMuteStemHalfRight => Load() as BoundingBox;

        public BoundingBox BrassHarmonMuteStemOpen => Load() as BoundingBox;

        public BoundingBox BrassJazzTurn => Load() as BoundingBox;

        public BoundingBox BrassLiftLong => Load() as BoundingBox;

        public BoundingBox BrassLiftMedium => Load() as BoundingBox;

        public BoundingBox BrassLiftShort => Load() as BoundingBox;

        public BoundingBox BrassLiftSmoothLong => Load() as BoundingBox;

        public BoundingBox BrassLiftSmoothMedium => Load() as BoundingBox;

        public BoundingBox BrassLiftSmoothShort => Load() as BoundingBox;

        public BoundingBox BrassMuteClosed => Load() as BoundingBox;

        public BoundingBox BrassMuteHalfClosed => Load() as BoundingBox;

        public BoundingBox BrassMuteOpen => Load() as BoundingBox;

        public BoundingBox BrassPlop => Load() as BoundingBox;

        public BoundingBox BrassScoop => Load() as BoundingBox;

        public BoundingBox BrassSmear => Load() as BoundingBox;

        public BoundingBox BrassValveTrill => Load() as BoundingBox;

        public BoundingBox BreathMarkComma => Load() as BoundingBox;

        public BoundingBox BreathMarkSalzedo => Load() as BoundingBox;

        public BoundingBox BreathMarkTick => Load() as BoundingBox;

        public BoundingBox BreathMarkUpbow => Load() as BoundingBox;

        public BoundingBox BridgeClef => Load() as BoundingBox;

        public BoundingBox BuzzRoll => Load() as BoundingBox;

        public BoundingBox CClef => Load() as BoundingBox;

        public BoundingBox CClef8Vb => Load() as BoundingBox;

        public BoundingBox CClefArrowDown => Load() as BoundingBox;

        public BoundingBox CClefArrowUp => Load() as BoundingBox;

        public BoundingBox CClefChange => Load() as BoundingBox;

        public BoundingBox CClefCombining => Load() as BoundingBox;

        public BoundingBox CClefFrench => Load() as BoundingBox;

        public BoundingBox CClefFrench20C => Load() as BoundingBox;

        public BoundingBox CClefFrench20CChange => Load() as BoundingBox;

        public BoundingBox CClefReversed => Load() as BoundingBox;

        public BoundingBox CClefSmall => Load() as BoundingBox;

        public BoundingBox CClefSquare => Load() as BoundingBox;

        public BoundingBox Caesura => Load() as BoundingBox;

        public BoundingBox CaesuraCurved => Load() as BoundingBox;

        public BoundingBox CaesuraShort => Load() as BoundingBox;

        public BoundingBox CaesuraSingleStroke => Load() as BoundingBox;

        public BoundingBox CaesuraThick => Load() as BoundingBox;

        public BoundingBox ChantAccentusAbove => Load() as BoundingBox;

        public BoundingBox ChantAccentusBelow => Load() as BoundingBox;

        public BoundingBox ChantAuctumAsc => Load() as BoundingBox;

        public BoundingBox ChantAuctumDesc => Load() as BoundingBox;

        public BoundingBox ChantAugmentum => Load() as BoundingBox;

        public BoundingBox ChantCaesura => Load() as BoundingBox;

        public BoundingBox ChantCclef => Load() as BoundingBox;

        public BoundingBox ChantCclefHufnagel => Load() as BoundingBox;

        public BoundingBox ChantCirculusAbove => Load() as BoundingBox;

        public BoundingBox ChantCirculusBelow => Load() as BoundingBox;

        public BoundingBox ChantConnectingLineAsc2Nd => Load() as BoundingBox;

        public BoundingBox ChantConnectingLineAsc3Rd => Load() as BoundingBox;

        public BoundingBox ChantConnectingLineAsc4Th => Load() as BoundingBox;

        public BoundingBox ChantConnectingLineAsc5Th => Load() as BoundingBox;

        public BoundingBox ChantConnectingLineAsc6Th => Load() as BoundingBox;

        public BoundingBox ChantCustosStemDownPosHigh => Load() as BoundingBox;

        public BoundingBox ChantCustosStemDownPosHighest => Load() as BoundingBox;

        public BoundingBox ChantCustosStemDownPosMiddle => Load() as BoundingBox;

        public BoundingBox ChantCustosStemUpPosLow => Load() as BoundingBox;

        public BoundingBox ChantCustosStemUpPosLowest => Load() as BoundingBox;

        public BoundingBox ChantCustosStemUpPosMiddle => Load() as BoundingBox;

        public BoundingBox ChantDeminutumLower => Load() as BoundingBox;

        public BoundingBox ChantDeminutumUpper => Load() as BoundingBox;

        public BoundingBox ChantDivisioFinalis => Load() as BoundingBox;

        public BoundingBox ChantDivisioMaior => Load() as BoundingBox;

        public BoundingBox ChantDivisioMaxima => Load() as BoundingBox;

        public BoundingBox ChantDivisioMinima => Load() as BoundingBox;

        public BoundingBox ChantEntryLineAsc2Nd => Load() as BoundingBox;

        public BoundingBox ChantEntryLineAsc3Rd => Load() as BoundingBox;

        public BoundingBox ChantEntryLineAsc4Th => Load() as BoundingBox;

        public BoundingBox ChantEntryLineAsc5Th => Load() as BoundingBox;

        public BoundingBox ChantEntryLineAsc6Th => Load() as BoundingBox;

        public BoundingBox ChantEpisema => Load() as BoundingBox;

        public BoundingBox ChantFclef => Load() as BoundingBox;

        public BoundingBox ChantFclefHufnagel => Load() as BoundingBox;

        public BoundingBox ChantIctusAbove => Load() as BoundingBox;

        public BoundingBox ChantIctusBelow => Load() as BoundingBox;

        public BoundingBox ChantLigaturaDesc2Nd => Load() as BoundingBox;

        public BoundingBox ChantLigaturaDesc3Rd => Load() as BoundingBox;

        public BoundingBox ChantLigaturaDesc4Th => Load() as BoundingBox;

        public BoundingBox ChantLigaturaDesc5Th => Load() as BoundingBox;

        public BoundingBox ChantOriscusAscending => Load() as BoundingBox;

        public BoundingBox ChantOriscusDescending => Load() as BoundingBox;

        public BoundingBox ChantOriscusLiquescens => Load() as BoundingBox;

        public BoundingBox ChantPodatusLower => Load() as BoundingBox;

        public BoundingBox ChantPodatusUpper => Load() as BoundingBox;

        public BoundingBox ChantPunctum => Load() as BoundingBox;

        public BoundingBox ChantPunctumCavum => Load() as BoundingBox;

        public BoundingBox ChantPunctumDeminutum => Load() as BoundingBox;

        public BoundingBox ChantPunctumInclinatum => Load() as BoundingBox;

        public BoundingBox ChantPunctumInclinatumAuctum => Load() as BoundingBox;

        public BoundingBox ChantPunctumInclinatumDeminutum => Load() as BoundingBox;

        public BoundingBox ChantPunctumLinea => Load() as BoundingBox;

        public BoundingBox ChantPunctumLineaCavum => Load() as BoundingBox;

        public BoundingBox ChantPunctumVirga => Load() as BoundingBox;

        public BoundingBox ChantPunctumVirgaReversed => Load() as BoundingBox;

        public BoundingBox ChantQuilisma => Load() as BoundingBox;

        public BoundingBox ChantSemicirculusAbove => Load() as BoundingBox;

        public BoundingBox ChantSemicirculusBelow => Load() as BoundingBox;

        public BoundingBox ChantStaff => Load() as BoundingBox;

        public BoundingBox ChantStaffNarrow => Load() as BoundingBox;

        public BoundingBox ChantStaffWide => Load() as BoundingBox;

        public BoundingBox ChantStrophicus => Load() as BoundingBox;

        public BoundingBox ChantStrophicusAuctus => Load() as BoundingBox;

        public BoundingBox ChantStrophicusLiquescens2Nd => Load() as BoundingBox;

        public BoundingBox ChantStrophicusLiquescens3Rd => Load() as BoundingBox;

        public BoundingBox ChantStrophicusLiquescens4Th => Load() as BoundingBox;

        public BoundingBox ChantStrophicusLiquescens5Th => Load() as BoundingBox;

        public BoundingBox ChantVirgula => Load() as BoundingBox;

        public BoundingBox Clef15 => Load() as BoundingBox;

        public BoundingBox Clef8 => Load() as BoundingBox;

        public BoundingBox Coda => Load() as BoundingBox;

        public BoundingBox CodaJapanese => Load() as BoundingBox;

        public BoundingBox CodaSquare => Load() as BoundingBox;

        public BoundingBox ConductorBeat2Compound => Load() as BoundingBox;

        public BoundingBox ConductorBeat2Simple => Load() as BoundingBox;

        public BoundingBox ConductorBeat3Compound => Load() as BoundingBox;

        public BoundingBox ConductorBeat3Simple => Load() as BoundingBox;

        public BoundingBox ConductorBeat4Compound => Load() as BoundingBox;

        public BoundingBox ConductorBeat4Simple => Load() as BoundingBox;

        public BoundingBox ConductorLeftBeat => Load() as BoundingBox;

        public BoundingBox ConductorRightBeat => Load() as BoundingBox;

        public BoundingBox ConductorStrongBeat => Load() as BoundingBox;

        public BoundingBox ConductorUnconducted => Load() as BoundingBox;

        public BoundingBox ConductorWeakBeat => Load() as BoundingBox;

        public BoundingBox CsymAugmented => Load() as BoundingBox;

        public BoundingBox CsymBracketLeftTall => Load() as BoundingBox;

        public BoundingBox CsymBracketRightTall => Load() as BoundingBox;

        public BoundingBox CsymDiminished => Load() as BoundingBox;

        public BoundingBox CsymHalfDiminished => Load() as BoundingBox;

        public BoundingBox CsymMajorSeventh => Load() as BoundingBox;

        public BoundingBox CsymMinor => Load() as BoundingBox;

        public BoundingBox CsymParensLeftTall => Load() as BoundingBox;

        public BoundingBox CsymParensRightTall => Load() as BoundingBox;

        public BoundingBox CurlewSign => Load() as BoundingBox;

        public BoundingBox DaCapo => Load() as BoundingBox;

        public BoundingBox DalSegno => Load() as BoundingBox;

        public BoundingBox DaseianExcellentes1 => Load() as BoundingBox;

        public BoundingBox DaseianExcellentes2 => Load() as BoundingBox;

        public BoundingBox DaseianExcellentes3 => Load() as BoundingBox;

        public BoundingBox DaseianExcellentes4 => Load() as BoundingBox;

        public BoundingBox DaseianFinales1 => Load() as BoundingBox;

        public BoundingBox DaseianFinales2 => Load() as BoundingBox;

        public BoundingBox DaseianFinales3 => Load() as BoundingBox;

        public BoundingBox DaseianFinales4 => Load() as BoundingBox;

        public BoundingBox DaseianGraves1 => Load() as BoundingBox;

        public BoundingBox DaseianGraves2 => Load() as BoundingBox;

        public BoundingBox DaseianGraves3 => Load() as BoundingBox;

        public BoundingBox DaseianGraves4 => Load() as BoundingBox;

        public BoundingBox DaseianResidua1 => Load() as BoundingBox;

        public BoundingBox DaseianResidua2 => Load() as BoundingBox;

        public BoundingBox DaseianSuperiores1 => Load() as BoundingBox;

        public BoundingBox DaseianSuperiores2 => Load() as BoundingBox;

        public BoundingBox DaseianSuperiores3 => Load() as BoundingBox;

        public BoundingBox DaseianSuperiores4 => Load() as BoundingBox;

        public BoundingBox DoubleTongueAbove => Load() as BoundingBox;

        public BoundingBox DoubleTongueAboveNoSlur => Load() as BoundingBox;

        public BoundingBox DoubleTongueBelow => Load() as BoundingBox;

        public BoundingBox DoubleTongueBelowNoSlur => Load() as BoundingBox;

        public BoundingBox DynamicCombinedSeparatorColon => Load() as BoundingBox;

        public BoundingBox DynamicCombinedSeparatorHyphen => Load() as BoundingBox;

        public BoundingBox DynamicCrescendoHairpin => Load() as BoundingBox;

        public BoundingBox DynamicDiminuendoHairpin => Load() as BoundingBox;

        public BoundingBox DynamicFf => Load() as BoundingBox;

        public BoundingBox DynamicFff => Load() as BoundingBox;

        public BoundingBox DynamicFfff => Load() as BoundingBox;

        public BoundingBox DynamicFffff => Load() as BoundingBox;

        public BoundingBox DynamicFfffff => Load() as BoundingBox;

        public BoundingBox DynamicForte => Load() as BoundingBox;

        public BoundingBox DynamicFortePiano => Load() as BoundingBox;

        public BoundingBox DynamicForteSmall => Load() as BoundingBox;

        public BoundingBox DynamicForzando => Load() as BoundingBox;

        public BoundingBox DynamicHairpinBracketLeft => Load() as BoundingBox;

        public BoundingBox DynamicHairpinBracketRight => Load() as BoundingBox;

        public BoundingBox DynamicHairpinParenthesisLeft => Load() as BoundingBox;

        public BoundingBox DynamicHairpinParenthesisRight => Load() as BoundingBox;

        public BoundingBox DynamicMf => Load() as BoundingBox;

        public BoundingBox DynamicMp => Load() as BoundingBox;

        public BoundingBox DynamicMessaDiVoce => Load() as BoundingBox;

        public BoundingBox DynamicMezzo => Load() as BoundingBox;

        public BoundingBox DynamicMezzoSmall => Load() as BoundingBox;

        public BoundingBox DynamicNiente => Load() as BoundingBox;

        public BoundingBox DynamicNienteForHairpin => Load() as BoundingBox;

        public BoundingBox DynamicNienteSmall => Load() as BoundingBox;

        public BoundingBox DynamicPf => Load() as BoundingBox;

        public BoundingBox DynamicPp => Load() as BoundingBox;

        public BoundingBox DynamicPpp => Load() as BoundingBox;

        public BoundingBox DynamicPppp => Load() as BoundingBox;

        public BoundingBox DynamicPpppp => Load() as BoundingBox;

        public BoundingBox DynamicPppppp => Load() as BoundingBox;

        public BoundingBox DynamicPiano => Load() as BoundingBox;

        public BoundingBox DynamicPianoSmall => Load() as BoundingBox;

        public BoundingBox DynamicRinforzando => Load() as BoundingBox;

        public BoundingBox DynamicRinforzando1 => Load() as BoundingBox;

        public BoundingBox DynamicRinforzando2 => Load() as BoundingBox;

        public BoundingBox DynamicRinforzandoSmall => Load() as BoundingBox;

        public BoundingBox DynamicSforzando => Load() as BoundingBox;

        public BoundingBox DynamicSforzando1 => Load() as BoundingBox;

        public BoundingBox DynamicSforzandoPianissimo => Load() as BoundingBox;

        public BoundingBox DynamicSforzandoPiano => Load() as BoundingBox;

        public BoundingBox DynamicSforzandoSmall => Load() as BoundingBox;

        public BoundingBox DynamicSforzato => Load() as BoundingBox;

        public BoundingBox DynamicSforzatoFf => Load() as BoundingBox;

        public BoundingBox DynamicSforzatoPiano => Load() as BoundingBox;

        public BoundingBox DynamicZ => Load() as BoundingBox;

        public BoundingBox DynamicZSmall => Load() as BoundingBox;

        public BoundingBox ElecAudioChannelsEight => Load() as BoundingBox;

        public BoundingBox ElecAudioChannelsFive => Load() as BoundingBox;

        public BoundingBox ElecAudioChannelsFour => Load() as BoundingBox;

        public BoundingBox ElecAudioChannelsOne => Load() as BoundingBox;

        public BoundingBox ElecAudioChannelsSeven => Load() as BoundingBox;

        public BoundingBox ElecAudioChannelsSix => Load() as BoundingBox;

        public BoundingBox ElecAudioChannelsThreeFrontal => Load() as BoundingBox;

        public BoundingBox ElecAudioChannelsThreeSurround => Load() as BoundingBox;

        public BoundingBox ElecAudioChannelsTwo => Load() as BoundingBox;

        public BoundingBox ElecAudioIn => Load() as BoundingBox;

        public BoundingBox ElecAudioMono => Load() as BoundingBox;

        public BoundingBox ElecAudioOut => Load() as BoundingBox;

        public BoundingBox ElecAudioStereo => Load() as BoundingBox;

        public BoundingBox ElecCamera => Load() as BoundingBox;

        public BoundingBox ElecDataIn => Load() as BoundingBox;

        public BoundingBox ElecDataOut => Load() as BoundingBox;

        public Dictionary<string, long[]> ElecDisc => Load() as Dictionary<string, long[]>;

        public BoundingBox ElecDownload => Load() as BoundingBox;

        public BoundingBox ElecEject => Load() as BoundingBox;

        public BoundingBox ElecFastForward => Load() as BoundingBox;

        public BoundingBox ElecHeadphones => Load() as BoundingBox;

        public BoundingBox ElecHeadset => Load() as BoundingBox;

        public BoundingBox ElecLineIn => Load() as BoundingBox;

        public BoundingBox ElecLineOut => Load() as BoundingBox;

        public BoundingBox ElecLoop => Load() as BoundingBox;

        public BoundingBox ElecLoudspeaker => Load() as BoundingBox;

        public BoundingBox ElecMidiController0 => Load() as BoundingBox;

        public BoundingBox ElecMidiController100 => Load() as BoundingBox;

        public BoundingBox ElecMidiController20 => Load() as BoundingBox;

        public BoundingBox ElecMidiController40 => Load() as BoundingBox;

        public BoundingBox ElecMidiController60 => Load() as BoundingBox;

        public BoundingBox ElecMidiController80 => Load() as BoundingBox;

        public BoundingBox ElecMidiIn => Load() as BoundingBox;

        public BoundingBox ElecMidiOut => Load() as BoundingBox;

        public BoundingBox ElecMicrophone => Load() as BoundingBox;

        public BoundingBox ElecMicrophoneMute => Load() as BoundingBox;

        public BoundingBox ElecMicrophoneUnmute => Load() as BoundingBox;

        public BoundingBox ElecMixingConsole => Load() as BoundingBox;

        public BoundingBox ElecMonitor => Load() as BoundingBox;

        public BoundingBox ElecMute => Load() as BoundingBox;

        public BoundingBox ElecPause => Load() as BoundingBox;

        public BoundingBox ElecPlay => Load() as BoundingBox;

        public BoundingBox ElecPowerOnOff => Load() as BoundingBox;

        public BoundingBox ElecProjector => Load() as BoundingBox;

        public BoundingBox ElecReplay => Load() as BoundingBox;

        public BoundingBox ElecRewind => Load() as BoundingBox;

        public BoundingBox ElecShuffle => Load() as BoundingBox;

        public BoundingBox ElecSkipBackwards => Load() as BoundingBox;

        public BoundingBox ElecSkipForwards => Load() as BoundingBox;

        public BoundingBox ElecStop => Load() as BoundingBox;

        public BoundingBox ElecTape => Load() as BoundingBox;

        public BoundingBox ElecUsb => Load() as BoundingBox;

        public BoundingBox ElecUnmute => Load() as BoundingBox;

        public BoundingBox ElecUpload => Load() as BoundingBox;

        public BoundingBox ElecVideoCamera => Load() as BoundingBox;

        public BoundingBox ElecVideoIn => Load() as BoundingBox;

        public BoundingBox ElecVideoOut => Load() as BoundingBox;

        public BoundingBox ElecVolumeFader => Load() as BoundingBox;

        public BoundingBox ElecVolumeFaderThumb => Load() as BoundingBox;

        public BoundingBox ElecVolumeLevel0 => Load() as BoundingBox;

        public BoundingBox ElecVolumeLevel100 => Load() as BoundingBox;

        public BoundingBox ElecVolumeLevel20 => Load() as BoundingBox;

        public BoundingBox ElecVolumeLevel40 => Load() as BoundingBox;

        public BoundingBox ElecVolumeLevel60 => Load() as BoundingBox;

        public BoundingBox ElecVolumeLevel80 => Load() as BoundingBox;

        public BoundingBox FClef => Load() as BoundingBox;

        public BoundingBox FClef15Ma => Load() as BoundingBox;

        public BoundingBox FClef15Mb => Load() as BoundingBox;

        public BoundingBox FClef19ThCentury => Load() as BoundingBox;

        public BoundingBox FClef5Below => Load() as BoundingBox;

        public BoundingBox FClef8Va => Load() as BoundingBox;

        public BoundingBox FClef8Vb => Load() as BoundingBox;

        public BoundingBox FClefArrowDown => Load() as BoundingBox;

        public BoundingBox FClefArrowUp => Load() as BoundingBox;

        public BoundingBox FClefChange => Load() as BoundingBox;

        public BoundingBox FClefFrench => Load() as BoundingBox;

        public BoundingBox FClefReversed => Load() as BoundingBox;

        public BoundingBox FClefSmall => Load() as BoundingBox;

        public BoundingBox FClefTurned => Load() as BoundingBox;

        public BoundingBox FermataAbove => Load() as BoundingBox;

        public BoundingBox FermataBelow => Load() as BoundingBox;

        public BoundingBox FermataLongAbove => Load() as BoundingBox;

        public BoundingBox FermataLongBelow => Load() as BoundingBox;

        public BoundingBox FermataLongHenzeAbove => Load() as BoundingBox;

        public BoundingBox FermataLongHenzeBelow => Load() as BoundingBox;

        public BoundingBox FermataShortAbove => Load() as BoundingBox;

        public BoundingBox FermataShortBelow => Load() as BoundingBox;

        public BoundingBox FermataShortHenzeAbove => Load() as BoundingBox;

        public BoundingBox FermataShortHenzeBelow => Load() as BoundingBox;

        public BoundingBox FermataVeryLongAbove => Load() as BoundingBox;

        public BoundingBox FermataVeryLongBelow => Load() as BoundingBox;

        public BoundingBox FermataVeryShortAbove => Load() as BoundingBox;

        public BoundingBox FermataVeryShortBelow => Load() as BoundingBox;

        public BoundingBox Figbass0 => Load() as BoundingBox;

        public BoundingBox Figbass1 => Load() as BoundingBox;

        public BoundingBox Figbass2 => Load() as BoundingBox;

        public BoundingBox Figbass2Raised => Load() as BoundingBox;

        public BoundingBox Figbass3 => Load() as BoundingBox;

        public BoundingBox Figbass4 => Load() as BoundingBox;

        public BoundingBox Figbass4Raised => Load() as BoundingBox;

        public BoundingBox Figbass5 => Load() as BoundingBox;

        public BoundingBox Figbass5Raised1 => Load() as BoundingBox;

        public BoundingBox Figbass5Raised2 => Load() as BoundingBox;

        public BoundingBox Figbass5Raised3 => Load() as BoundingBox;

        public BoundingBox Figbass6 => Load() as BoundingBox;

        public BoundingBox Figbass6Raised => Load() as BoundingBox;

        public BoundingBox Figbass6Raised2 => Load() as BoundingBox;

        public BoundingBox Figbass7 => Load() as BoundingBox;

        public BoundingBox Figbass7Diminished => Load() as BoundingBox;

        public BoundingBox Figbass7Raised1 => Load() as BoundingBox;

        public BoundingBox Figbass7Raised2 => Load() as BoundingBox;

        public BoundingBox Figbass8 => Load() as BoundingBox;

        public BoundingBox Figbass9 => Load() as BoundingBox;

        public BoundingBox Figbass9Raised => Load() as BoundingBox;

        public BoundingBox FigbassBracketLeft => Load() as BoundingBox;

        public BoundingBox FigbassBracketRight => Load() as BoundingBox;

        public BoundingBox FigbassCombiningLowering => Load() as BoundingBox;

        public BoundingBox FigbassCombiningRaising => Load() as BoundingBox;

        public BoundingBox FigbassDoubleFlat => Load() as BoundingBox;

        public BoundingBox FigbassDoubleSharp => Load() as BoundingBox;

        public BoundingBox FigbassFlat => Load() as BoundingBox;

        public BoundingBox FigbassNatural => Load() as BoundingBox;

        public BoundingBox FigbassParensLeft => Load() as BoundingBox;

        public BoundingBox FigbassParensRight => Load() as BoundingBox;

        public BoundingBox FigbassPlus => Load() as BoundingBox;

        public BoundingBox FigbassSharp => Load() as BoundingBox;

        public BoundingBox Fingering0 => Load() as BoundingBox;

        public BoundingBox Fingering1 => Load() as BoundingBox;

        public BoundingBox Fingering2 => Load() as BoundingBox;

        public BoundingBox Fingering3 => Load() as BoundingBox;

        public BoundingBox Fingering4 => Load() as BoundingBox;

        public BoundingBox Fingering5 => Load() as BoundingBox;

        public BoundingBox FingeringALower => Load() as BoundingBox;

        public BoundingBox FingeringCLower => Load() as BoundingBox;

        public BoundingBox FingeringELower => Load() as BoundingBox;

        public BoundingBox FingeringILower => Load() as BoundingBox;

        public BoundingBox FingeringMLower => Load() as BoundingBox;

        public BoundingBox FingeringMultipleNotes => Load() as BoundingBox;

        public BoundingBox FingeringOLower => Load() as BoundingBox;

        public BoundingBox FingeringPLower => Load() as BoundingBox;

        public BoundingBox FingeringSubstitutionAbove => Load() as BoundingBox;

        public BoundingBox FingeringSubstitutionBelow => Load() as BoundingBox;

        public BoundingBox FingeringSubstitutionDash => Load() as BoundingBox;

        public BoundingBox FingeringTLower => Load() as BoundingBox;

        public BoundingBox FingeringTUpper => Load() as BoundingBox;

        public BoundingBox FingeringXLower => Load() as BoundingBox;

        public BoundingBox Flag1024ThDown => Load() as BoundingBox;

        public BoundingBox Flag1024ThDownSmall => Load() as BoundingBox;

        public BoundingBox Flag1024ThDownStraight => Load() as BoundingBox;

        public BoundingBox Flag1024ThUp => Load() as BoundingBox;

        public BoundingBox Flag1024ThUpShort => Load() as BoundingBox;

        public BoundingBox Flag1024ThUpSmall => Load() as BoundingBox;

        public BoundingBox Flag1024ThUpStraight => Load() as BoundingBox;

        public BoundingBox Flag128ThDown => Load() as BoundingBox;

        public BoundingBox Flag128ThDownSmall => Load() as BoundingBox;

        public BoundingBox Flag128ThDownStraight => Load() as BoundingBox;

        public BoundingBox Flag128ThUp => Load() as BoundingBox;

        public BoundingBox Flag128ThUpShort => Load() as BoundingBox;

        public BoundingBox Flag128ThUpSmall => Load() as BoundingBox;

        public BoundingBox Flag128ThUpStraight => Load() as BoundingBox;

        public BoundingBox Flag16ThDown => Load() as BoundingBox;

        public BoundingBox Flag16ThDownSmall => Load() as BoundingBox;

        public BoundingBox Flag16ThDownStraight => Load() as BoundingBox;

        public BoundingBox Flag16ThUp => Load() as BoundingBox;

        public BoundingBox Flag16ThUpShort => Load() as BoundingBox;

        public BoundingBox Flag16ThUpSmall => Load() as BoundingBox;

        public BoundingBox Flag16ThUpStraight => Load() as BoundingBox;

        public BoundingBox Flag256ThDown => Load() as BoundingBox;

        public BoundingBox Flag256ThDownSmall => Load() as BoundingBox;

        public BoundingBox Flag256ThDownStraight => Load() as BoundingBox;

        public BoundingBox Flag256ThUp => Load() as BoundingBox;

        public BoundingBox Flag256ThUpShort => Load() as BoundingBox;

        public BoundingBox Flag256ThUpSmall => Load() as BoundingBox;

        public BoundingBox Flag256ThUpStraight => Load() as BoundingBox;

        public BoundingBox Flag32NdDown => Load() as BoundingBox;

        public BoundingBox Flag32NdDownSmall => Load() as BoundingBox;

        public BoundingBox Flag32NdDownStraight => Load() as BoundingBox;

        public BoundingBox Flag32NdUp => Load() as BoundingBox;

        public BoundingBox Flag32NdUpShort => Load() as BoundingBox;

        public BoundingBox Flag32NdUpSmall => Load() as BoundingBox;

        public BoundingBox Flag32NdUpStraight => Load() as BoundingBox;

        public BoundingBox Flag512ThDown => Load() as BoundingBox;

        public BoundingBox Flag512ThDownSmall => Load() as BoundingBox;

        public BoundingBox Flag512ThDownStraight => Load() as BoundingBox;

        public BoundingBox Flag512ThUp => Load() as BoundingBox;

        public BoundingBox Flag512ThUpShort => Load() as BoundingBox;

        public BoundingBox Flag512ThUpSmall => Load() as BoundingBox;

        public BoundingBox Flag512ThUpStraight => Load() as BoundingBox;

        public BoundingBox Flag64ThDown => Load() as BoundingBox;

        public BoundingBox Flag64ThDownSmall => Load() as BoundingBox;

        public BoundingBox Flag64ThDownStraight => Load() as BoundingBox;

        public BoundingBox Flag64ThUp => Load() as BoundingBox;

        public BoundingBox Flag64ThUpShort => Load() as BoundingBox;

        public BoundingBox Flag64ThUpSmall => Load() as BoundingBox;

        public BoundingBox Flag64ThUpStraight => Load() as BoundingBox;

        public BoundingBox Flag8ThDown => Load() as BoundingBox;

        public BoundingBox Flag8ThDownSmall => Load() as BoundingBox;

        public BoundingBox Flag8ThDownStraight => Load() as BoundingBox;

        public BoundingBox Flag8ThUp => Load() as BoundingBox;

        public BoundingBox Flag8ThUpShort => Load() as BoundingBox;

        public BoundingBox Flag8ThUpSmall => Load() as BoundingBox;

        public BoundingBox Flag8ThUpStraight => Load() as BoundingBox;

        public BoundingBox FlagInternalDown => Load() as BoundingBox;

        public BoundingBox FlagInternalUp => Load() as BoundingBox;

        public BoundingBox Fretboard3String => Load() as BoundingBox;

        public BoundingBox Fretboard3StringNut => Load() as BoundingBox;

        public BoundingBox Fretboard4String => Load() as BoundingBox;

        public BoundingBox Fretboard4StringNut => Load() as BoundingBox;

        public BoundingBox Fretboard5String => Load() as BoundingBox;

        public BoundingBox Fretboard5StringNut => Load() as BoundingBox;

        public BoundingBox Fretboard6String => Load() as BoundingBox;

        public BoundingBox Fretboard6StringNut => Load() as BoundingBox;

        public BoundingBox FretboardFilledCircle => Load() as BoundingBox;

        public BoundingBox FretboardO => Load() as BoundingBox;

        public BoundingBox FretboardX => Load() as BoundingBox;

        public BoundingBox FunctionAngleLeft => Load() as BoundingBox;

        public BoundingBox FunctionAngleRight => Load() as BoundingBox;

        public BoundingBox FunctionBracketLeft => Load() as BoundingBox;

        public BoundingBox FunctionBracketRight => Load() as BoundingBox;

        public BoundingBox FunctionDd => Load() as BoundingBox;

        public BoundingBox FunctionDLower => Load() as BoundingBox;

        public BoundingBox FunctionDUpper => Load() as BoundingBox;

        public BoundingBox FunctionEight => Load() as BoundingBox;

        public BoundingBox FunctionFUpper => Load() as BoundingBox;

        public BoundingBox FunctionFive => Load() as BoundingBox;

        public BoundingBox FunctionFour => Load() as BoundingBox;

        public BoundingBox FunctionGLower => Load() as BoundingBox;

        public BoundingBox FunctionGUpper => Load() as BoundingBox;

        public BoundingBox FunctionGreaterThan => Load() as BoundingBox;

        public BoundingBox FunctionILower => Load() as BoundingBox;

        public BoundingBox FunctionIUpper => Load() as BoundingBox;

        public BoundingBox FunctionKLower => Load() as BoundingBox;

        public BoundingBox FunctionKUpper => Load() as BoundingBox;

        public BoundingBox FunctionLLower => Load() as BoundingBox;

        public BoundingBox FunctionLUpper => Load() as BoundingBox;

        public BoundingBox FunctionLessThan => Load() as BoundingBox;

        public BoundingBox FunctionMLower => Load() as BoundingBox;

        public BoundingBox FunctionMUpper => Load() as BoundingBox;

        public BoundingBox FunctionMinus => Load() as BoundingBox;

        public BoundingBox FunctionNLower => Load() as BoundingBox;

        public BoundingBox FunctionNUpper => Load() as BoundingBox;

        public BoundingBox FunctionNUpperSuperscript => Load() as BoundingBox;

        public BoundingBox FunctionNine => Load() as BoundingBox;

        public BoundingBox FunctionOne => Load() as BoundingBox;

        public BoundingBox FunctionPLower => Load() as BoundingBox;

        public BoundingBox FunctionPUpper => Load() as BoundingBox;

        public BoundingBox FunctionParensLeft => Load() as BoundingBox;

        public BoundingBox FunctionParensRight => Load() as BoundingBox;

        public BoundingBox FunctionPlus => Load() as BoundingBox;

        public BoundingBox FunctionRLower => Load() as BoundingBox;

        public BoundingBox FunctionRepetition1 => Load() as BoundingBox;

        public BoundingBox FunctionRepetition2 => Load() as BoundingBox;

        public BoundingBox FunctionRing => Load() as BoundingBox;

        public BoundingBox FunctionSLower => Load() as BoundingBox;

        public BoundingBox FunctionSsLower => Load() as BoundingBox;

        public BoundingBox FunctionSsUpper => Load() as BoundingBox;

        public BoundingBox FunctionSUpper => Load() as BoundingBox;

        public BoundingBox FunctionSeven => Load() as BoundingBox;

        public BoundingBox FunctionSix => Load() as BoundingBox;

        public BoundingBox FunctionSlashedDd => Load() as BoundingBox;

        public BoundingBox FunctionTLower => Load() as BoundingBox;

        public BoundingBox FunctionTUpper => Load() as BoundingBox;

        public BoundingBox FunctionThree => Load() as BoundingBox;

        public BoundingBox FunctionTwo => Load() as BoundingBox;

        public BoundingBox FunctionVLower => Load() as BoundingBox;

        public BoundingBox FunctionVUpper => Load() as BoundingBox;

        public BoundingBox FunctionZero => Load() as BoundingBox;

        public BoundingBox GClef => Load() as BoundingBox;

        public BoundingBox GClef0Below => Load() as BoundingBox;

        public BoundingBox GClef10Below => Load() as BoundingBox;

        public BoundingBox GClef11Below => Load() as BoundingBox;

        public BoundingBox GClef12Below => Load() as BoundingBox;

        public BoundingBox GClef13Below => Load() as BoundingBox;

        public BoundingBox GClef14Below => Load() as BoundingBox;

        public BoundingBox GClef15Below => Load() as BoundingBox;

        public BoundingBox GClef15Ma => Load() as BoundingBox;

        public BoundingBox GClef15Mb => Load() as BoundingBox;

        public BoundingBox GClef16Below => Load() as BoundingBox;

        public BoundingBox GClef17Below => Load() as BoundingBox;

        public BoundingBox GClef2Above => Load() as BoundingBox;

        public BoundingBox GClef2Below => Load() as BoundingBox;

        public BoundingBox GClef3Above => Load() as BoundingBox;

        public BoundingBox GClef3Below => Load() as BoundingBox;

        public BoundingBox GClef4Above => Load() as BoundingBox;

        public BoundingBox GClef4Below => Load() as BoundingBox;

        public BoundingBox GClef5Above => Load() as BoundingBox;

        public BoundingBox GClef5Below => Load() as BoundingBox;

        public BoundingBox GClef6Above => Load() as BoundingBox;

        public BoundingBox GClef6Below => Load() as BoundingBox;

        public BoundingBox GClef7Above => Load() as BoundingBox;

        public BoundingBox GClef7Below => Load() as BoundingBox;

        public BoundingBox GClef8Above => Load() as BoundingBox;

        public BoundingBox GClef8Below => Load() as BoundingBox;

        public BoundingBox GClef8Va => Load() as BoundingBox;

        public BoundingBox GClef8Vb => Load() as BoundingBox;

        public BoundingBox GClef8VbCClef => Load() as BoundingBox;

        public BoundingBox GClef8VbOld => Load() as BoundingBox;

        public BoundingBox GClef8VbParens => Load() as BoundingBox;

        public BoundingBox GClef9Above => Load() as BoundingBox;

        public BoundingBox GClef9Below => Load() as BoundingBox;

        public BoundingBox GClefArrowDown => Load() as BoundingBox;

        public BoundingBox GClefArrowUp => Load() as BoundingBox;

        public BoundingBox GClefChange => Load() as BoundingBox;

        public BoundingBox GClefFlat10Below => Load() as BoundingBox;

        public BoundingBox GClefFlat11Below => Load() as BoundingBox;

        public BoundingBox GClefFlat13Below => Load() as BoundingBox;

        public BoundingBox GClefFlat14Below => Load() as BoundingBox;

        public BoundingBox GClefFlat15Below => Load() as BoundingBox;

        public BoundingBox GClefFlat16Below => Load() as BoundingBox;

        public BoundingBox GClefFlat1Below => Load() as BoundingBox;

        public BoundingBox GClefFlat2Above => Load() as BoundingBox;

        public BoundingBox GClefFlat2Below => Load() as BoundingBox;

        public BoundingBox GClefFlat3Above => Load() as BoundingBox;

        public BoundingBox GClefFlat3Below => Load() as BoundingBox;

        public BoundingBox GClefFlat4Below => Load() as BoundingBox;

        public BoundingBox GClefFlat5Above => Load() as BoundingBox;

        public BoundingBox GClefFlat6Above => Load() as BoundingBox;

        public BoundingBox GClefFlat6Below => Load() as BoundingBox;

        public BoundingBox GClefFlat7Above => Load() as BoundingBox;

        public BoundingBox GClefFlat7Below => Load() as BoundingBox;

        public BoundingBox GClefFlat8Above => Load() as BoundingBox;

        public BoundingBox GClefFlat9Above => Load() as BoundingBox;

        public BoundingBox GClefFlat9Below => Load() as BoundingBox;

        public BoundingBox GClefLigatedNumberAbove => Load() as BoundingBox;

        public BoundingBox GClefLigatedNumberBelow => Load() as BoundingBox;

        public BoundingBox GClefNat2Below => Load() as BoundingBox;

        public BoundingBox GClefNatural10Below => Load() as BoundingBox;

        public BoundingBox GClefNatural13Below => Load() as BoundingBox;

        public BoundingBox GClefNatural17Below => Load() as BoundingBox;

        public BoundingBox GClefNatural2Above => Load() as BoundingBox;

        public BoundingBox GClefNatural3Above => Load() as BoundingBox;

        public BoundingBox GClefNatural3Below => Load() as BoundingBox;

        public BoundingBox GClefNatural6Above => Load() as BoundingBox;

        public BoundingBox GClefNatural6Below => Load() as BoundingBox;

        public BoundingBox GClefNatural7Above => Load() as BoundingBox;

        public BoundingBox GClefNatural9Above => Load() as BoundingBox;

        public BoundingBox GClefNatural9Below => Load() as BoundingBox;

        public BoundingBox GClefReversed => Load() as BoundingBox;

        public BoundingBox GClefSharp12Below => Load() as BoundingBox;

        public BoundingBox GClefSharp1Above => Load() as BoundingBox;

        public BoundingBox GClefSharp4Above => Load() as BoundingBox;

        public BoundingBox GClefSharp5Below => Load() as BoundingBox;

        public BoundingBox GClefSmall => Load() as BoundingBox;

        public BoundingBox GClefTurned => Load() as BoundingBox;

        public BoundingBox GlissandoDown => Load() as BoundingBox;

        public BoundingBox GlissandoUp => Load() as BoundingBox;

        public BoundingBox GraceNoteAcciaccaturaStemDown => Load() as BoundingBox;

        public BoundingBox GraceNoteAcciaccaturaStemUp => Load() as BoundingBox;

        public BoundingBox GraceNoteAppoggiaturaStemDown => Load() as BoundingBox;

        public BoundingBox GraceNoteAppoggiaturaStemUp => Load() as BoundingBox;

        public BoundingBox GraceNoteSlashStemDown => Load() as BoundingBox;

        public BoundingBox GraceNoteSlashStemUp => Load() as BoundingBox;

        public BoundingBox GuitarBarreFull => Load() as BoundingBox;

        public BoundingBox GuitarBarreHalf => Load() as BoundingBox;

        public BoundingBox GuitarBarreHalfHorizontalFractionSlash => Load() as BoundingBox;

        public BoundingBox GuitarClosePedal => Load() as BoundingBox;

        public BoundingBox GuitarFadeIn => Load() as BoundingBox;

        public BoundingBox GuitarFadeOut => Load() as BoundingBox;

        public BoundingBox GuitarGolpe => Load() as BoundingBox;

        public BoundingBox GuitarGolpeFlamenco => Load() as BoundingBox;

        public BoundingBox GuitarHalfOpenPedal => Load() as BoundingBox;

        public BoundingBox GuitarLeftHandTapping => Load() as BoundingBox;

        public BoundingBox GuitarOpenPedal => Load() as BoundingBox;

        public BoundingBox GuitarRightHandTapping => Load() as BoundingBox;

        public BoundingBox GuitarShake => Load() as BoundingBox;

        public BoundingBox GuitarString0 => Load() as BoundingBox;

        public BoundingBox GuitarString1 => Load() as BoundingBox;

        public BoundingBox GuitarString2 => Load() as BoundingBox;

        public BoundingBox GuitarString3 => Load() as BoundingBox;

        public BoundingBox GuitarString4 => Load() as BoundingBox;

        public BoundingBox GuitarString5 => Load() as BoundingBox;

        public BoundingBox GuitarString6 => Load() as BoundingBox;

        public BoundingBox GuitarString7 => Load() as BoundingBox;

        public BoundingBox GuitarString8 => Load() as BoundingBox;

        public BoundingBox GuitarString9 => Load() as BoundingBox;

        public BoundingBox GuitarStrumDown => Load() as BoundingBox;

        public BoundingBox GuitarStrumUp => Load() as BoundingBox;

        public BoundingBox GuitarVibratoBarDip => Load() as BoundingBox;

        public BoundingBox GuitarVibratoBarScoop => Load() as BoundingBox;

        public BoundingBox GuitarVibratoStroke => Load() as BoundingBox;

        public BoundingBox GuitarVolumeSwell => Load() as BoundingBox;

        public BoundingBox GuitarWideVibratoStroke => Load() as BoundingBox;

        public BoundingBox HandbellsBelltree => Load() as BoundingBox;

        public BoundingBox HandbellsDamp3 => Load() as BoundingBox;

        public BoundingBox HandbellsEcho1 => Load() as BoundingBox;

        public BoundingBox HandbellsEcho2 => Load() as BoundingBox;

        public BoundingBox HandbellsGyro => Load() as BoundingBox;

        public BoundingBox HandbellsHandMartellato => Load() as BoundingBox;

        public BoundingBox HandbellsMalletBellOnTable => Load() as BoundingBox;

        public BoundingBox HandbellsMalletBellSuspended => Load() as BoundingBox;

        public BoundingBox HandbellsMalletLft => Load() as BoundingBox;

        public BoundingBox HandbellsMartellato => Load() as BoundingBox;

        public BoundingBox HandbellsMartellatoLift => Load() as BoundingBox;

        public BoundingBox HandbellsMutedMartellato => Load() as BoundingBox;

        public BoundingBox HandbellsPluckLift => Load() as BoundingBox;

        public BoundingBox HandbellsSwing => Load() as BoundingBox;

        public BoundingBox HandbellsSwingDown => Load() as BoundingBox;

        public BoundingBox HandbellsSwingUp => Load() as BoundingBox;

        public BoundingBox HandbellsTablePairBells => Load() as BoundingBox;

        public BoundingBox HandbellsTableSingleBell => Load() as BoundingBox;

        public BoundingBox HarpMetalRod => Load() as BoundingBox;

        public BoundingBox HarpMetalRodAlt => Load() as BoundingBox;

        public BoundingBox HarpPedalCentered => Load() as BoundingBox;

        public Dictionary<string, long[]> HarpPedalDivider => Load() as Dictionary<string, long[]>;

        public BoundingBox HarpPedalLowered => Load() as BoundingBox;

        public BoundingBox HarpPedalRaised => Load() as BoundingBox;

        public BoundingBox HarpSalzedoAeolianAscending => Load() as BoundingBox;

        public BoundingBox HarpSalzedoAeolianDescending => Load() as BoundingBox;

        public BoundingBox HarpSalzedoDampAbove => Load() as BoundingBox;

        public BoundingBox HarpSalzedoDampBelow => Load() as BoundingBox;

        public BoundingBox HarpSalzedoDampBothHands => Load() as BoundingBox;

        public BoundingBox HarpSalzedoDampLowStrings => Load() as BoundingBox;

        public BoundingBox HarpSalzedoFluidicSoundsLeft => Load() as BoundingBox;

        public BoundingBox HarpSalzedoFluidicSoundsRight => Load() as BoundingBox;

        public BoundingBox HarpSalzedoIsolatedSounds => Load() as BoundingBox;

        public BoundingBox HarpSalzedoMetallicSounds => Load() as BoundingBox;

        public BoundingBox HarpSalzedoMetallicSoundsOneString => Load() as BoundingBox;

        public BoundingBox HarpSalzedoMuffleTotally => Load() as BoundingBox;

        public BoundingBox HarpSalzedoOboicFlux => Load() as BoundingBox;

        public BoundingBox HarpSalzedoPlayUpperEnd => Load() as BoundingBox;

        public BoundingBox HarpSalzedoSlideWithSuppleness => Load() as BoundingBox;

        public Dictionary<string, long[]> HarpSalzedoSnareDrum => Load() as Dictionary<string, long[]>;

        public BoundingBox HarpSalzedoTamTamSounds => Load() as BoundingBox;

        public BoundingBox HarpSalzedoThunderEffect => Load() as BoundingBox;

        public BoundingBox HarpSalzedoTimpanicSounds => Load() as BoundingBox;

        public BoundingBox HarpSalzedoWhistlingSounds => Load() as BoundingBox;

        public BoundingBox HarpStringNoiseStem => Load() as BoundingBox;

        public BoundingBox HarpTuningKey => Load() as BoundingBox;

        public BoundingBox HarpTuningKeyAlt => Load() as BoundingBox;

        public BoundingBox HarpTuningKeyGlissando => Load() as BoundingBox;

        public BoundingBox HarpTuningKeyHandle => Load() as BoundingBox;

        public BoundingBox HarpTuningKeyShank => Load() as BoundingBox;

        public BoundingBox KeyboardBebung2DotsAbove => Load() as BoundingBox;

        public BoundingBox KeyboardBebung2DotsBelow => Load() as BoundingBox;

        public BoundingBox KeyboardBebung3DotsAbove => Load() as BoundingBox;

        public BoundingBox KeyboardBebung3DotsBelow => Load() as BoundingBox;

        public BoundingBox KeyboardBebung4DotsAbove => Load() as BoundingBox;

        public BoundingBox KeyboardBebung4DotsBelow => Load() as BoundingBox;

        public BoundingBox KeyboardLeftPedalPictogram => Load() as BoundingBox;

        public BoundingBox KeyboardMiddlePedalPictogram => Load() as BoundingBox;

        public BoundingBox KeyboardPedalD => Load() as BoundingBox;

        public BoundingBox KeyboardPedalDot => Load() as BoundingBox;

        public BoundingBox KeyboardPedalE => Load() as BoundingBox;

        public BoundingBox KeyboardPedalHalf => Load() as BoundingBox;

        public BoundingBox KeyboardPedalHalf2 => Load() as BoundingBox;

        public BoundingBox KeyboardPedalHalf3 => Load() as BoundingBox;

        public BoundingBox KeyboardPedalHeel1 => Load() as BoundingBox;

        public BoundingBox KeyboardPedalHeel2 => Load() as BoundingBox;

        public Dictionary<string, long[]> KeyboardPedalHeel3 => Load() as Dictionary<string, long[]>;

        public BoundingBox KeyboardPedalHeelToToe => Load() as BoundingBox;

        public BoundingBox KeyboardPedalHeelToe => Load() as BoundingBox;

        public BoundingBox KeyboardPedalHookEnd => Load() as BoundingBox;

        public BoundingBox KeyboardPedalHookStart => Load() as BoundingBox;

        public BoundingBox KeyboardPedalHyphen => Load() as BoundingBox;

        public BoundingBox KeyboardPedalP => Load() as BoundingBox;

        public BoundingBox KeyboardPedalPed => Load() as BoundingBox;

        public BoundingBox KeyboardPedalPedNoDot => Load() as BoundingBox;

        public BoundingBox KeyboardPedalS => Load() as BoundingBox;

        public BoundingBox KeyboardPedalSost => Load() as BoundingBox;

        public BoundingBox KeyboardPedalSostNoDot => Load() as BoundingBox;

        public BoundingBox KeyboardPedalToe1 => Load() as BoundingBox;

        public BoundingBox KeyboardPedalToe2 => Load() as BoundingBox;

        public BoundingBox KeyboardPedalToeToHeel => Load() as BoundingBox;

        public BoundingBox KeyboardPedalUp => Load() as BoundingBox;

        public BoundingBox KeyboardPedalUpNotch => Load() as BoundingBox;

        public BoundingBox KeyboardPedalUpSpecial => Load() as BoundingBox;

        public BoundingBox KeyboardPlayWithLh => Load() as BoundingBox;

        public BoundingBox KeyboardPlayWithLhEnd => Load() as BoundingBox;

        public BoundingBox KeyboardPlayWithRh => Load() as BoundingBox;

        public BoundingBox KeyboardPlayWithRhEnd => Load() as BoundingBox;

        public BoundingBox KeyboardPluckInside => Load() as BoundingBox;

        public BoundingBox KeyboardRightPedalPictogram => Load() as BoundingBox;

        public BoundingBox KievanAccidentalFlat => Load() as BoundingBox;

        public BoundingBox KievanAccidentalSharp => Load() as BoundingBox;

        public BoundingBox KievanAugmentationDot => Load() as BoundingBox;

        public BoundingBox KievanCClef => Load() as BoundingBox;

        public BoundingBox KievanEndingSymbol => Load() as BoundingBox;

        public BoundingBox KievanNote8ThStemDown => Load() as BoundingBox;

        public BoundingBox KievanNote8ThStemUp => Load() as BoundingBox;

        public BoundingBox KievanNoteBeam => Load() as BoundingBox;

        public BoundingBox KievanNoteHalfStaffLine => Load() as BoundingBox;

        public BoundingBox KievanNoteHalfStaffSpace => Load() as BoundingBox;

        public BoundingBox KievanNoteQuarterStemDown => Load() as BoundingBox;

        public BoundingBox KievanNoteQuarterStemUp => Load() as BoundingBox;

        public BoundingBox KievanNoteReciting => Load() as BoundingBox;

        public BoundingBox KievanNoteWhole => Load() as BoundingBox;

        public BoundingBox KievanNoteWholeFinal => Load() as BoundingBox;

        public BoundingBox KodalyHandDo => Load() as BoundingBox;

        public BoundingBox KodalyHandFa => Load() as BoundingBox;

        public BoundingBox KodalyHandLa => Load() as BoundingBox;

        public BoundingBox KodalyHandMi => Load() as BoundingBox;

        public BoundingBox KodalyHandRe => Load() as BoundingBox;

        public BoundingBox KodalyHandSo => Load() as BoundingBox;

        public BoundingBox KodalyHandTi => Load() as BoundingBox;

        public BoundingBox LeftRepeatSmall => Load() as BoundingBox;

        public BoundingBox LegerLine => Load() as BoundingBox;

        public BoundingBox LegerLineNarrow => Load() as BoundingBox;

        public BoundingBox LegerLineWide => Load() as BoundingBox;

        public BoundingBox LuteBarlineEndRepeat => Load() as BoundingBox;

        public BoundingBox LuteBarlineFinal => Load() as BoundingBox;

        public BoundingBox LuteBarlineStartRepeat => Load() as BoundingBox;

        public BoundingBox LuteDuration16Th => Load() as BoundingBox;

        public BoundingBox LuteDuration32Nd => Load() as BoundingBox;

        public BoundingBox LuteDuration8Th => Load() as BoundingBox;

        public BoundingBox LuteDurationDoubleWhole => Load() as BoundingBox;

        public BoundingBox LuteDurationHalf => Load() as BoundingBox;

        public BoundingBox LuteDurationQuarter => Load() as BoundingBox;

        public BoundingBox LuteDurationWhole => Load() as BoundingBox;

        public BoundingBox LuteFingeringRhFirst => Load() as BoundingBox;

        public BoundingBox LuteFingeringRhSecond => Load() as BoundingBox;

        public BoundingBox LuteFingeringRhThird => Load() as BoundingBox;

        public BoundingBox LuteFingeringRhThirdAlt => Load() as BoundingBox;

        public BoundingBox LuteFingeringRhThumb => Load() as BoundingBox;

        public BoundingBox LuteFrench10ThCourse => Load() as BoundingBox;

        public BoundingBox LuteFrench10ThCourseRight => Load() as BoundingBox;

        public BoundingBox LuteFrench10ThCourseStrikethru => Load() as BoundingBox;

        public BoundingBox LuteFrench10ThCourseUnderline => Load() as BoundingBox;

        public BoundingBox LuteFrench7ThCourse => Load() as BoundingBox;

        public BoundingBox LuteFrench7ThCourseRight => Load() as BoundingBox;

        public BoundingBox LuteFrench7ThCourseStrikethru => Load() as BoundingBox;

        public BoundingBox LuteFrench7ThCourseUnderline => Load() as BoundingBox;

        public BoundingBox LuteFrench8ThCourse => Load() as BoundingBox;

        public BoundingBox LuteFrench8ThCourseRight => Load() as BoundingBox;

        public BoundingBox LuteFrench8ThCourseStrikethru => Load() as BoundingBox;

        public BoundingBox LuteFrench8ThCourseUnderline => Load() as BoundingBox;

        public BoundingBox LuteFrench9ThCourse => Load() as BoundingBox;

        public BoundingBox LuteFrench9ThCourseRight => Load() as BoundingBox;

        public BoundingBox LuteFrench9ThCourseStrikethru => Load() as BoundingBox;

        public BoundingBox LuteFrench9ThCourseUnderline => Load() as BoundingBox;

        public BoundingBox LuteFrenchAppoggiaturaAbove => Load() as BoundingBox;

        public BoundingBox LuteFrenchAppoggiaturaBelow => Load() as BoundingBox;

        public BoundingBox LuteFrenchFretA => Load() as BoundingBox;

        public BoundingBox LuteFrenchFretB => Load() as BoundingBox;

        public BoundingBox LuteFrenchFretC => Load() as BoundingBox;

        public BoundingBox LuteFrenchFretCAlt => Load() as BoundingBox;

        public BoundingBox LuteFrenchFretD => Load() as BoundingBox;

        public BoundingBox LuteFrenchFretE => Load() as BoundingBox;

        public BoundingBox LuteFrenchFretF => Load() as BoundingBox;

        public BoundingBox LuteFrenchFretG => Load() as BoundingBox;

        public BoundingBox LuteFrenchFretH => Load() as BoundingBox;

        public BoundingBox LuteFrenchFretI => Load() as BoundingBox;

        public BoundingBox LuteFrenchFretK => Load() as BoundingBox;

        public BoundingBox LuteFrenchFretL => Load() as BoundingBox;

        public BoundingBox LuteFrenchFretM => Load() as BoundingBox;

        public BoundingBox LuteFrenchFretN => Load() as BoundingBox;

        public BoundingBox LuteFrenchMordentInverted => Load() as BoundingBox;

        public BoundingBox LuteFrenchMordentLower => Load() as BoundingBox;

        public BoundingBox LuteFrenchMordentUpper => Load() as BoundingBox;

        public BoundingBox LuteGermanALower => Load() as BoundingBox;

        public BoundingBox LuteGermanAUpper => Load() as BoundingBox;

        public BoundingBox LuteGermanBLower => Load() as BoundingBox;

        public BoundingBox LuteGermanBUpper => Load() as BoundingBox;

        public BoundingBox LuteGermanCLower => Load() as BoundingBox;

        public BoundingBox LuteGermanCUpper => Load() as BoundingBox;

        public BoundingBox LuteGermanDLower => Load() as BoundingBox;

        public BoundingBox LuteGermanDUpper => Load() as BoundingBox;

        public BoundingBox LuteGermanELower => Load() as BoundingBox;

        public BoundingBox LuteGermanEUpper => Load() as BoundingBox;

        public BoundingBox LuteGermanFLower => Load() as BoundingBox;

        public BoundingBox LuteGermanFUpper => Load() as BoundingBox;

        public BoundingBox LuteGermanGLower => Load() as BoundingBox;

        public BoundingBox LuteGermanGUpper => Load() as BoundingBox;

        public BoundingBox LuteGermanHLower => Load() as BoundingBox;

        public BoundingBox LuteGermanHUpper => Load() as BoundingBox;

        public BoundingBox LuteGermanILower => Load() as BoundingBox;

        public BoundingBox LuteGermanIUpper => Load() as BoundingBox;

        public BoundingBox LuteGermanKLower => Load() as BoundingBox;

        public BoundingBox LuteGermanKUpper => Load() as BoundingBox;

        public BoundingBox LuteGermanLLower => Load() as BoundingBox;

        public BoundingBox LuteGermanLUpper => Load() as BoundingBox;

        public BoundingBox LuteGermanMLower => Load() as BoundingBox;

        public BoundingBox LuteGermanMUpper => Load() as BoundingBox;

        public BoundingBox LuteGermanNLower => Load() as BoundingBox;

        public BoundingBox LuteGermanNUpper => Load() as BoundingBox;

        public BoundingBox LuteGermanOLower => Load() as BoundingBox;

        public BoundingBox LuteGermanPLower => Load() as BoundingBox;

        public BoundingBox LuteGermanQLower => Load() as BoundingBox;

        public BoundingBox LuteGermanRLower => Load() as BoundingBox;

        public BoundingBox LuteGermanSLower => Load() as BoundingBox;

        public BoundingBox LuteGermanTLower => Load() as BoundingBox;

        public BoundingBox LuteGermanVLower => Load() as BoundingBox;

        public BoundingBox LuteGermanXLower => Load() as BoundingBox;

        public BoundingBox LuteGermanYLower => Load() as BoundingBox;

        public BoundingBox LuteGermanZLower => Load() as BoundingBox;

        public BoundingBox LuteItalianClefCSolFaUt => Load() as BoundingBox;

        public BoundingBox LuteItalianClefFFaUt => Load() as BoundingBox;

        public BoundingBox LuteItalianFret0 => Load() as BoundingBox;

        public BoundingBox LuteItalianFret1 => Load() as BoundingBox;

        public BoundingBox LuteItalianFret2 => Load() as BoundingBox;

        public BoundingBox LuteItalianFret3 => Load() as BoundingBox;

        public BoundingBox LuteItalianFret4 => Load() as BoundingBox;

        public BoundingBox LuteItalianFret5 => Load() as BoundingBox;

        public BoundingBox LuteItalianFret6 => Load() as BoundingBox;

        public BoundingBox LuteItalianFret7 => Load() as BoundingBox;

        public BoundingBox LuteItalianFret8 => Load() as BoundingBox;

        public BoundingBox LuteItalianFret9 => Load() as BoundingBox;

        public BoundingBox LuteItalianHoldFinger => Load() as BoundingBox;

        public BoundingBox LuteItalianHoldNote => Load() as BoundingBox;

        public BoundingBox LuteItalianReleaseFinger => Load() as BoundingBox;

        public BoundingBox LuteItalianTempoFast => Load() as BoundingBox;

        public BoundingBox LuteItalianTempoNeitherFastNorSlow => Load() as BoundingBox;

        public BoundingBox LuteItalianTempoSlow => Load() as BoundingBox;

        public BoundingBox LuteItalianTempoSomewhatFast => Load() as BoundingBox;

        public BoundingBox LuteItalianTempoVerySlow => Load() as BoundingBox;

        public BoundingBox LuteItalianTimeTriple => Load() as BoundingBox;

        public BoundingBox LuteItalianTremolo => Load() as BoundingBox;

        public BoundingBox LuteItalianVibrato => Load() as BoundingBox;

        public BoundingBox LuteStaff6Lines => Load() as BoundingBox;

        public BoundingBox LuteStaff6LinesNarrow => Load() as BoundingBox;

        public BoundingBox LuteStaff6LinesWide => Load() as BoundingBox;

        public BoundingBox LyricsElision => Load() as BoundingBox;

        public BoundingBox LyricsElisionNarrow => Load() as BoundingBox;

        public BoundingBox LyricsElisionWide => Load() as BoundingBox;

        public BoundingBox LyricsHyphenBaseline => Load() as BoundingBox;

        public BoundingBox LyricsHyphenBaselineNonBreaking => Load() as BoundingBox;

        public BoundingBox MedRenFlatHardB => Load() as BoundingBox;

        public BoundingBox MedRenFlatSoftB => Load() as BoundingBox;

        public BoundingBox MedRenFlatSoftBHufnagel => Load() as BoundingBox;

        public BoundingBox MedRenFlatSoftBOld => Load() as BoundingBox;

        public BoundingBox MedRenFlatWithDot => Load() as BoundingBox;

        public BoundingBox MedRenGClefCmn => Load() as BoundingBox;

        public BoundingBox MedRenLiquescenceCmn => Load() as BoundingBox;

        public BoundingBox MedRenLiquescentAscCmn => Load() as BoundingBox;

        public BoundingBox MedRenLiquescentDescCmn => Load() as BoundingBox;

        public BoundingBox MedRenNatural => Load() as BoundingBox;

        public BoundingBox MedRenNaturalWithCross => Load() as BoundingBox;

        public BoundingBox MedRenOriscusCmn => Load() as BoundingBox;

        public BoundingBox MedRenPlicaCmn => Load() as BoundingBox;

        public BoundingBox MedRenPunctumCmn => Load() as BoundingBox;

        public BoundingBox MedRenQuilismaCmn => Load() as BoundingBox;

        public BoundingBox MedRenSharpCroix => Load() as BoundingBox;

        public BoundingBox MedRenStrophicusCmn => Load() as BoundingBox;

        public BoundingBox MensuralAlterationSign => Load() as BoundingBox;

        public BoundingBox MensuralBlackBrevis => Load() as BoundingBox;

        public BoundingBox MensuralBlackBrevisVoid => Load() as BoundingBox;

        public BoundingBox MensuralBlackDragma => Load() as BoundingBox;

        public BoundingBox MensuralBlackLonga => Load() as BoundingBox;

        public BoundingBox MensuralBlackMaxima => Load() as BoundingBox;

        public BoundingBox MensuralBlackMinima => Load() as BoundingBox;

        public BoundingBox MensuralBlackMinimaVoid => Load() as BoundingBox;

        public BoundingBox MensuralBlackSemibrevis => Load() as BoundingBox;

        public BoundingBox MensuralBlackSemibrevisCaudata => Load() as BoundingBox;

        public BoundingBox MensuralBlackSemibrevisOblique => Load() as BoundingBox;

        public BoundingBox MensuralBlackSemibrevisVoid => Load() as BoundingBox;

        public BoundingBox MensuralBlackSemiminima => Load() as BoundingBox;

        public BoundingBox MensuralCclef => Load() as BoundingBox;

        public BoundingBox MensuralCclefBlack => Load() as BoundingBox;

        public BoundingBox MensuralCclefPetrucciPosHigh => Load() as BoundingBox;

        public BoundingBox MensuralCclefPetrucciPosHighest => Load() as BoundingBox;

        public BoundingBox MensuralCclefPetrucciPosLow => Load() as BoundingBox;

        public BoundingBox MensuralCclefPetrucciPosLowest => Load() as BoundingBox;

        public BoundingBox MensuralCclefPetrucciPosMiddle => Load() as BoundingBox;

        public BoundingBox MensuralCclefVoid => Load() as BoundingBox;

        public BoundingBox MensuralColorationEndRound => Load() as BoundingBox;

        public BoundingBox MensuralColorationEndSquare => Load() as BoundingBox;

        public BoundingBox MensuralColorationStartRound => Load() as BoundingBox;

        public BoundingBox MensuralColorationStartSquare => Load() as BoundingBox;

        public BoundingBox MensuralCombStemDiagonal => Load() as BoundingBox;

        public BoundingBox MensuralCombStemDown => Load() as BoundingBox;

        public BoundingBox MensuralCombStemDownFlagExtended => Load() as BoundingBox;

        public BoundingBox MensuralCombStemDownFlagFlared => Load() as BoundingBox;

        public BoundingBox MensuralCombStemDownFlagFusa => Load() as BoundingBox;

        public BoundingBox MensuralCombStemDownFlagLeft => Load() as BoundingBox;

        public BoundingBox MensuralCombStemDownFlagRight => Load() as BoundingBox;

        public BoundingBox MensuralCombStemDownFlagSemiminima => Load() as BoundingBox;

        public BoundingBox MensuralCombStemUp => Load() as BoundingBox;

        public BoundingBox MensuralCombStemUpFlagExtended => Load() as BoundingBox;

        public BoundingBox MensuralCombStemUpFlagFlared => Load() as BoundingBox;

        public BoundingBox MensuralCombStemUpFlagFusa => Load() as BoundingBox;

        public BoundingBox MensuralCombStemUpFlagLeft => Load() as BoundingBox;

        public BoundingBox MensuralCombStemUpFlagRight => Load() as BoundingBox;

        public BoundingBox MensuralCombStemUpFlagSemiminima => Load() as BoundingBox;

        public BoundingBox MensuralCustosCheckmark => Load() as BoundingBox;

        public BoundingBox MensuralCustosDown => Load() as BoundingBox;

        public BoundingBox MensuralCustosTurn => Load() as BoundingBox;

        public BoundingBox MensuralCustosUp => Load() as BoundingBox;

        public BoundingBox MensuralFclef => Load() as BoundingBox;

        public BoundingBox MensuralFclefPetrucci => Load() as BoundingBox;

        public BoundingBox MensuralFusaBlackStemDown => Load() as BoundingBox;

        public BoundingBox MensuralFusaBlackStemUp => Load() as BoundingBox;

        public BoundingBox MensuralFusaBlackVoidStemDown => Load() as BoundingBox;

        public BoundingBox MensuralFusaBlackVoidStemUp => Load() as BoundingBox;

        public BoundingBox MensuralFusaVoidStemDown => Load() as BoundingBox;

        public BoundingBox MensuralFusaVoidStemUp => Load() as BoundingBox;

        public BoundingBox MensuralGclef => Load() as BoundingBox;

        public BoundingBox MensuralGclefPetrucci => Load() as BoundingBox;

        public BoundingBox MensuralLongaBlackStemDownLeft => Load() as BoundingBox;

        public BoundingBox MensuralLongaBlackStemDownRight => Load() as BoundingBox;

        public BoundingBox MensuralLongaBlackStemUpLeft => Load() as BoundingBox;

        public BoundingBox MensuralLongaBlackStemUpRight => Load() as BoundingBox;

        public BoundingBox MensuralLongaBlackVoidStemDownLeft => Load() as BoundingBox;

        public BoundingBox MensuralLongaBlackVoidStemDownRight => Load() as BoundingBox;

        public BoundingBox MensuralLongaBlackVoidStemUpLeft => Load() as BoundingBox;

        public BoundingBox MensuralLongaBlackVoidStemUpRight => Load() as BoundingBox;

        public BoundingBox MensuralLongaVoidStemDownLeft => Load() as BoundingBox;

        public BoundingBox MensuralLongaVoidStemDownRight => Load() as BoundingBox;

        public BoundingBox MensuralLongaVoidStemUpLeft => Load() as BoundingBox;

        public BoundingBox MensuralLongaVoidStemUpRight => Load() as BoundingBox;

        public BoundingBox MensuralMaximaBlackStemDownLeft => Load() as BoundingBox;

        public BoundingBox MensuralMaximaBlackStemDownRight => Load() as BoundingBox;

        public BoundingBox MensuralMaximaBlackStemUpLeft => Load() as BoundingBox;

        public BoundingBox MensuralMaximaBlackStemUpRight => Load() as BoundingBox;

        public BoundingBox MensuralMaximaBlackVoidStemDownLeft => Load() as BoundingBox;

        public BoundingBox MensuralMaximaBlackVoidStemDownRight => Load() as BoundingBox;

        public BoundingBox MensuralMaximaBlackVoidStemUpLeft => Load() as BoundingBox;

        public BoundingBox MensuralMaximaBlackVoidStemUpRight => Load() as BoundingBox;

        public BoundingBox MensuralMaximaVoidStemDownLeft => Load() as BoundingBox;

        public BoundingBox MensuralMaximaVoidStemDownRight => Load() as BoundingBox;

        public BoundingBox MensuralMaximaVoidStemUpLeft => Load() as BoundingBox;

        public BoundingBox MensuralMaximaVoidStemUpRight => Load() as BoundingBox;

        public BoundingBox MensuralMinimaBlackStemDown => Load() as BoundingBox;

        public BoundingBox MensuralMinimaBlackStemDownExtendedFlag => Load() as BoundingBox;

        public BoundingBox MensuralMinimaBlackStemDownFlagLeft => Load() as BoundingBox;

        public BoundingBox MensuralMinimaBlackStemDownFlagRight => Load() as BoundingBox;

        public BoundingBox MensuralMinimaBlackStemDownFlaredFlag => Load() as BoundingBox;

        public BoundingBox MensuralMinimaBlackStemUp => Load() as BoundingBox;

        public BoundingBox MensuralMinimaBlackStemUpExtendedFlag => Load() as BoundingBox;

        public BoundingBox MensuralMinimaBlackStemUpFlagLeft => Load() as BoundingBox;

        public BoundingBox MensuralMinimaBlackStemUpFlagRight => Load() as BoundingBox;

        public BoundingBox MensuralMinimaBlackStemUpFlaredFlag => Load() as BoundingBox;

        public BoundingBox MensuralMinimaBlackVoidStemDown => Load() as BoundingBox;

        public BoundingBox MensuralMinimaBlackVoidStemDownExtendedFlag => Load() as BoundingBox;

        public BoundingBox MensuralMinimaBlackVoidStemDownFlagLeft => Load() as BoundingBox;

        public BoundingBox MensuralMinimaBlackVoidStemDownFlagRight => Load() as BoundingBox;

        public BoundingBox MensuralMinimaBlackVoidStemDownFlaredFlag => Load() as BoundingBox;

        public BoundingBox MensuralMinimaBlackVoidStemUp => Load() as BoundingBox;

        public BoundingBox MensuralMinimaBlackVoidStemUpExtendedFlag => Load() as BoundingBox;

        public BoundingBox MensuralMinimaBlackVoidStemUpFlagLeft => Load() as BoundingBox;

        public BoundingBox MensuralMinimaBlackVoidStemUpFlagRight => Load() as BoundingBox;

        public BoundingBox MensuralMinimaBlackVoidStemUpFlaredFlag => Load() as BoundingBox;

        public BoundingBox MensuralMinimaVoidStemDown => Load() as BoundingBox;

        public BoundingBox MensuralMinimaVoidStemDownExtendedFlag => Load() as BoundingBox;

        public BoundingBox MensuralMinimaVoidStemDownFlagLeft => Load() as BoundingBox;

        public BoundingBox MensuralMinimaVoidStemDownFlagRight => Load() as BoundingBox;

        public BoundingBox MensuralMinimaVoidStemDownFlaredFlag => Load() as BoundingBox;

        public BoundingBox MensuralMinimaVoidStemUp => Load() as BoundingBox;

        public BoundingBox MensuralMinimaVoidStemUpExtendedFlag => Load() as BoundingBox;

        public BoundingBox MensuralMinimaVoidStemUpFlagLeft => Load() as BoundingBox;

        public BoundingBox MensuralMinimaVoidStemUpFlagRight => Load() as BoundingBox;

        public BoundingBox MensuralMinimaVoidStemUpFlaredFlag => Load() as BoundingBox;

        public BoundingBox MensuralModusImperfectumVert => Load() as BoundingBox;

        public BoundingBox MensuralModusPerfectumVert => Load() as BoundingBox;

        public BoundingBox MensuralNoteheadLongaBlack => Load() as BoundingBox;

        public BoundingBox MensuralNoteheadLongaBlackVoid => Load() as BoundingBox;

        public BoundingBox MensuralNoteheadLongaVoid => Load() as BoundingBox;

        public BoundingBox MensuralNoteheadLongaWhite => Load() as BoundingBox;

        public BoundingBox MensuralNoteheadMaximaBlack => Load() as BoundingBox;

        public BoundingBox MensuralNoteheadMaximaBlackVoid => Load() as BoundingBox;

        public BoundingBox MensuralNoteheadMaximaVoid => Load() as BoundingBox;

        public BoundingBox MensuralNoteheadMaximaWhite => Load() as BoundingBox;

        public BoundingBox MensuralNoteheadMinimaWhite => Load() as BoundingBox;

        public BoundingBox MensuralNoteheadSemibrevisBlack => Load() as BoundingBox;

        public BoundingBox MensuralNoteheadSemibrevisBlackVoid => Load() as BoundingBox;

        public BoundingBox MensuralNoteheadSemibrevisBlackVoidTurned => Load() as BoundingBox;

        public BoundingBox MensuralNoteheadSemibrevisVoid => Load() as BoundingBox;

        public BoundingBox MensuralNoteheadSemiminimaWhite => Load() as BoundingBox;

        public BoundingBox MensuralObliqueAsc2NdBlack => Load() as BoundingBox;

        public BoundingBox MensuralObliqueAsc2NdBlackVoid => Load() as BoundingBox;

        public BoundingBox MensuralObliqueAsc2NdVoid => Load() as BoundingBox;

        public BoundingBox MensuralObliqueAsc2NdWhite => Load() as BoundingBox;

        public BoundingBox MensuralObliqueAsc3RdBlack => Load() as BoundingBox;

        public BoundingBox MensuralObliqueAsc3RdBlackVoid => Load() as BoundingBox;

        public BoundingBox MensuralObliqueAsc3RdVoid => Load() as BoundingBox;

        public BoundingBox MensuralObliqueAsc3RdWhite => Load() as BoundingBox;

        public BoundingBox MensuralObliqueAsc4ThBlack => Load() as BoundingBox;

        public BoundingBox MensuralObliqueAsc4ThBlackVoid => Load() as BoundingBox;

        public BoundingBox MensuralObliqueAsc4ThVoid => Load() as BoundingBox;

        public BoundingBox MensuralObliqueAsc4ThWhite => Load() as BoundingBox;

        public BoundingBox MensuralObliqueAsc5ThBlack => Load() as BoundingBox;

        public BoundingBox MensuralObliqueAsc5ThBlackVoid => Load() as BoundingBox;

        public BoundingBox MensuralObliqueAsc5ThVoid => Load() as BoundingBox;

        public BoundingBox MensuralObliqueAsc5ThWhite => Load() as BoundingBox;

        public BoundingBox MensuralObliqueDesc2NdBlack => Load() as BoundingBox;

        public BoundingBox MensuralObliqueDesc2NdBlackVoid => Load() as BoundingBox;

        public BoundingBox MensuralObliqueDesc2NdVoid => Load() as BoundingBox;

        public BoundingBox MensuralObliqueDesc2NdWhite => Load() as BoundingBox;

        public BoundingBox MensuralObliqueDesc3RdBlack => Load() as BoundingBox;

        public BoundingBox MensuralObliqueDesc3RdBlackVoid => Load() as BoundingBox;

        public BoundingBox MensuralObliqueDesc3RdVoid => Load() as BoundingBox;

        public BoundingBox MensuralObliqueDesc3RdWhite => Load() as BoundingBox;

        public BoundingBox MensuralObliqueDesc4ThBlack => Load() as BoundingBox;

        public BoundingBox MensuralObliqueDesc4ThBlackVoid => Load() as BoundingBox;

        public BoundingBox MensuralObliqueDesc4ThVoid => Load() as BoundingBox;

        public BoundingBox MensuralObliqueDesc4ThWhite => Load() as BoundingBox;

        public BoundingBox MensuralObliqueDesc5ThBlack => Load() as BoundingBox;

        public BoundingBox MensuralObliqueDesc5ThBlackVoid => Load() as BoundingBox;

        public BoundingBox MensuralObliqueDesc5ThVoid => Load() as BoundingBox;

        public BoundingBox MensuralObliqueDesc5ThWhite => Load() as BoundingBox;

        public BoundingBox MensuralProlation1 => Load() as BoundingBox;

        public BoundingBox MensuralProlation10 => Load() as BoundingBox;

        public BoundingBox MensuralProlation11 => Load() as BoundingBox;

        public BoundingBox MensuralProlation2 => Load() as BoundingBox;

        public BoundingBox MensuralProlation3 => Load() as BoundingBox;

        public BoundingBox MensuralProlation4 => Load() as BoundingBox;

        public BoundingBox MensuralProlation5 => Load() as BoundingBox;

        public BoundingBox MensuralProlation6 => Load() as BoundingBox;

        public BoundingBox MensuralProlation7 => Load() as BoundingBox;

        public BoundingBox MensuralProlation8 => Load() as BoundingBox;

        public BoundingBox MensuralProlation9 => Load() as BoundingBox;

        public BoundingBox MensuralProlationCombiningDot => Load() as BoundingBox;

        public BoundingBox MensuralProlationCombiningDotVoid => Load() as BoundingBox;

        public BoundingBox MensuralProlationCombiningStroke => Load() as BoundingBox;

        public BoundingBox MensuralProlationCombiningThreeDots => Load() as BoundingBox;

        public BoundingBox MensuralProlationCombiningThreeDotsTri => Load() as BoundingBox;

        public BoundingBox MensuralProlationCombiningTwoDots => Load() as BoundingBox;

        public BoundingBox MensuralProportion1 => Load() as BoundingBox;

        public BoundingBox MensuralProportion2 => Load() as BoundingBox;

        public BoundingBox MensuralProportion3 => Load() as BoundingBox;

        public BoundingBox MensuralProportion4 => Load() as BoundingBox;

        public BoundingBox MensuralProportion4Old => Load() as BoundingBox;

        public BoundingBox MensuralProportionMajor => Load() as BoundingBox;

        public BoundingBox MensuralProportionMinor => Load() as BoundingBox;

        public BoundingBox MensuralProportionProportioDupla1 => Load() as BoundingBox;

        public BoundingBox MensuralProportionProportioDupla2 => Load() as BoundingBox;

        public BoundingBox MensuralProportionProportioQuadrupla => Load() as BoundingBox;

        public BoundingBox MensuralProportionProportioTripla => Load() as BoundingBox;

        public BoundingBox MensuralProportionTempusPerfectum => Load() as BoundingBox;

        public BoundingBox MensuralRestBrevis => Load() as BoundingBox;

        public BoundingBox MensuralRestFusa => Load() as BoundingBox;

        public BoundingBox MensuralRestLongaImperfecta => Load() as BoundingBox;

        public BoundingBox MensuralRestLongaPerfecta => Load() as BoundingBox;

        public BoundingBox MensuralRestMaxima => Load() as BoundingBox;

        public BoundingBox MensuralRestMinima => Load() as BoundingBox;

        public BoundingBox MensuralRestSemibrevis => Load() as BoundingBox;

        public BoundingBox MensuralRestSemifusa => Load() as BoundingBox;

        public BoundingBox MensuralRestSemiminima => Load() as BoundingBox;

        public BoundingBox MensuralSemiminimaBlackStemDown => Load() as BoundingBox;

        public BoundingBox MensuralSemiminimaBlackStemUp => Load() as BoundingBox;

        public BoundingBox MensuralSemiminimaBlackVoidStemDown => Load() as BoundingBox;

        public BoundingBox MensuralSemiminimaBlackVoidStemUp => Load() as BoundingBox;

        public BoundingBox MensuralSemiminimaVoidStemDown => Load() as BoundingBox;

        public BoundingBox MensuralSemiminimaVoidStemUp => Load() as BoundingBox;

        public BoundingBox MensuralSignumDown => Load() as BoundingBox;

        public BoundingBox MensuralSignumUp => Load() as BoundingBox;

        public BoundingBox MensuralTempusImperfectumHoriz => Load() as BoundingBox;

        public BoundingBox MensuralTempusPerfectumHoriz => Load() as BoundingBox;

        public BoundingBox MensuralWhiteBrevis => Load() as BoundingBox;

        public BoundingBox MensuralWhiteFusa => Load() as BoundingBox;

        public BoundingBox MensuralWhiteLonga => Load() as BoundingBox;

        public BoundingBox MensuralWhiteMaxima => Load() as BoundingBox;

        public BoundingBox MensuralWhiteMinima => Load() as BoundingBox;

        public BoundingBox MensuralWhiteSemiminima => Load() as BoundingBox;

        public BoundingBox MetAugmentationDot => Load() as BoundingBox;

        public BoundingBox MetNote1024ThDown => Load() as BoundingBox;

        public BoundingBox MetNote1024ThUp => Load() as BoundingBox;

        public BoundingBox MetNote128ThDown => Load() as BoundingBox;

        public BoundingBox MetNote128ThUp => Load() as BoundingBox;

        public BoundingBox MetNote16ThDown => Load() as BoundingBox;

        public BoundingBox MetNote16ThUp => Load() as BoundingBox;

        public BoundingBox MetNote256ThDown => Load() as BoundingBox;

        public BoundingBox MetNote256ThUp => Load() as BoundingBox;

        public BoundingBox MetNote32NdDown => Load() as BoundingBox;

        public BoundingBox MetNote32NdUp => Load() as BoundingBox;

        public BoundingBox MetNote512ThDown => Load() as BoundingBox;

        public BoundingBox MetNote512ThUp => Load() as BoundingBox;

        public BoundingBox MetNote64ThDown => Load() as BoundingBox;

        public BoundingBox MetNote64ThUp => Load() as BoundingBox;

        public BoundingBox MetNote8ThDown => Load() as BoundingBox;

        public BoundingBox MetNote8ThUp => Load() as BoundingBox;

        public BoundingBox MetNoteDoubleWhole => Load() as BoundingBox;

        public BoundingBox MetNoteDoubleWholeSquare => Load() as BoundingBox;

        public BoundingBox MetNoteHalfDown => Load() as BoundingBox;

        public BoundingBox MetNoteHalfUp => Load() as BoundingBox;

        public BoundingBox MetNoteQuarterDown => Load() as BoundingBox;

        public BoundingBox MetNoteQuarterUp => Load() as BoundingBox;

        public BoundingBox MetNoteWhole => Load() as BoundingBox;

        public BoundingBox MetricModulationArrowLeft => Load() as BoundingBox;

        public BoundingBox MetricModulationArrowRight => Load() as BoundingBox;

        public BoundingBox MiscDoNotCopy => Load() as BoundingBox;

        public BoundingBox MiscDoNotPhotocopy => Load() as BoundingBox;

        public BoundingBox MiscEyeglasses => Load() as BoundingBox;

        public BoundingBox Note1024ThDown => Load() as BoundingBox;

        public BoundingBox Note1024ThUp => Load() as BoundingBox;

        public BoundingBox Note128ThDown => Load() as BoundingBox;

        public BoundingBox Note128ThUp => Load() as BoundingBox;

        public BoundingBox Note16ThDown => Load() as BoundingBox;

        public BoundingBox Note16ThUp => Load() as BoundingBox;

        public BoundingBox Note256ThDown => Load() as BoundingBox;

        public BoundingBox Note256ThUp => Load() as BoundingBox;

        public BoundingBox Note32NdDown => Load() as BoundingBox;

        public BoundingBox Note32NdUp => Load() as BoundingBox;

        public BoundingBox Note512ThDown => Load() as BoundingBox;

        public BoundingBox Note512ThUp => Load() as BoundingBox;

        public BoundingBox Note64ThDown => Load() as BoundingBox;

        public BoundingBox Note64ThUp => Load() as BoundingBox;

        public BoundingBox Note8ThDown => Load() as BoundingBox;

        public BoundingBox Note8ThUp => Load() as BoundingBox;

        public BoundingBox NoteABlack => Load() as BoundingBox;

        public BoundingBox NoteAFlatBlack => Load() as BoundingBox;

        public BoundingBox NoteAFlatHalf => Load() as BoundingBox;

        public BoundingBox NoteAFlatWhole => Load() as BoundingBox;

        public BoundingBox NoteAHalf => Load() as BoundingBox;

        public BoundingBox NoteASharpBlack => Load() as BoundingBox;

        public BoundingBox NoteASharpHalf => Load() as BoundingBox;

        public BoundingBox NoteASharpWhole => Load() as BoundingBox;

        public BoundingBox NoteAWhole => Load() as BoundingBox;

        public BoundingBox NoteBBlack => Load() as BoundingBox;

        public BoundingBox NoteBFlatBlack => Load() as BoundingBox;

        public BoundingBox NoteBFlatHalf => Load() as BoundingBox;

        public BoundingBox NoteBFlatWhole => Load() as BoundingBox;

        public BoundingBox NoteBHalf => Load() as BoundingBox;

        public BoundingBox NoteBSharpBlack => Load() as BoundingBox;

        public BoundingBox NoteBSharpHalf => Load() as BoundingBox;

        public BoundingBox NoteBSharpWhole => Load() as BoundingBox;

        public BoundingBox NoteBWhole => Load() as BoundingBox;

        public BoundingBox NoteCBlack => Load() as BoundingBox;

        public BoundingBox NoteCFlatBlack => Load() as BoundingBox;

        public BoundingBox NoteCFlatHalf => Load() as BoundingBox;

        public BoundingBox NoteCFlatWhole => Load() as BoundingBox;

        public BoundingBox NoteCHalf => Load() as BoundingBox;

        public BoundingBox NoteCSharpBlack => Load() as BoundingBox;

        public BoundingBox NoteCSharpHalf => Load() as BoundingBox;

        public BoundingBox NoteCSharpWhole => Load() as BoundingBox;

        public BoundingBox NoteCWhole => Load() as BoundingBox;

        public BoundingBox NoteDBlack => Load() as BoundingBox;

        public BoundingBox NoteDFlatBlack => Load() as BoundingBox;

        public BoundingBox NoteDFlatHalf => Load() as BoundingBox;

        public BoundingBox NoteDFlatWhole => Load() as BoundingBox;

        public BoundingBox NoteDHalf => Load() as BoundingBox;

        public BoundingBox NoteDSharpBlack => Load() as BoundingBox;

        public BoundingBox NoteDSharpHalf => Load() as BoundingBox;

        public BoundingBox NoteDSharpWhole => Load() as BoundingBox;

        public BoundingBox NoteDWhole => Load() as BoundingBox;

        public BoundingBox NoteDoBlack => Load() as BoundingBox;

        public BoundingBox NoteDoHalf => Load() as BoundingBox;

        public BoundingBox NoteDoWhole => Load() as BoundingBox;

        public BoundingBox NoteDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteDoubleWholeAlt => Load() as BoundingBox;

        public BoundingBox NoteDoubleWholeSquare => Load() as BoundingBox;

        public BoundingBox NoteEBlack => Load() as BoundingBox;

        public BoundingBox NoteEFlatBlack => Load() as BoundingBox;

        public BoundingBox NoteEFlatHalf => Load() as BoundingBox;

        public BoundingBox NoteEFlatWhole => Load() as BoundingBox;

        public BoundingBox NoteEHalf => Load() as BoundingBox;

        public BoundingBox NoteESharpBlack => Load() as BoundingBox;

        public BoundingBox NoteESharpHalf => Load() as BoundingBox;

        public BoundingBox NoteESharpWhole => Load() as BoundingBox;

        public BoundingBox NoteEWhole => Load() as BoundingBox;

        public BoundingBox NoteEmptyBlack => Load() as BoundingBox;

        public BoundingBox NoteEmptyHalf => Load() as BoundingBox;

        public BoundingBox NoteEmptyWhole => Load() as BoundingBox;

        public BoundingBox NoteFBlack => Load() as BoundingBox;

        public BoundingBox NoteFFlatBlack => Load() as BoundingBox;

        public BoundingBox NoteFFlatHalf => Load() as BoundingBox;

        public BoundingBox NoteFFlatWhole => Load() as BoundingBox;

        public BoundingBox NoteFHalf => Load() as BoundingBox;

        public BoundingBox NoteFSharpBlack => Load() as BoundingBox;

        public BoundingBox NoteFSharpHalf => Load() as BoundingBox;

        public BoundingBox NoteFSharpWhole => Load() as BoundingBox;

        public BoundingBox NoteFWhole => Load() as BoundingBox;

        public BoundingBox NoteFaBlack => Load() as BoundingBox;

        public BoundingBox NoteFaHalf => Load() as BoundingBox;

        public BoundingBox NoteFaWhole => Load() as BoundingBox;

        public BoundingBox NoteGBlack => Load() as BoundingBox;

        public BoundingBox NoteGFlatBlack => Load() as BoundingBox;

        public BoundingBox NoteGFlatHalf => Load() as BoundingBox;

        public BoundingBox NoteGFlatWhole => Load() as BoundingBox;

        public BoundingBox NoteGHalf => Load() as BoundingBox;

        public BoundingBox NoteGSharpBlack => Load() as BoundingBox;

        public BoundingBox NoteGSharpHalf => Load() as BoundingBox;

        public BoundingBox NoteGSharpWhole => Load() as BoundingBox;

        public BoundingBox NoteGWhole => Load() as BoundingBox;

        public BoundingBox NoteHBlack => Load() as BoundingBox;

        public BoundingBox NoteHHalf => Load() as BoundingBox;

        public BoundingBox NoteHSharpBlack => Load() as BoundingBox;

        public BoundingBox NoteHSharpHalf => Load() as BoundingBox;

        public BoundingBox NoteHSharpWhole => Load() as BoundingBox;

        public BoundingBox NoteHWhole => Load() as BoundingBox;

        public BoundingBox NoteHalfDown => Load() as BoundingBox;

        public BoundingBox NoteHalfUp => Load() as BoundingBox;

        public BoundingBox NoteLaBlack => Load() as BoundingBox;

        public BoundingBox NoteLaHalf => Load() as BoundingBox;

        public BoundingBox NoteLaWhole => Load() as BoundingBox;

        public BoundingBox NoteMiBlack => Load() as BoundingBox;

        public BoundingBox NoteMiHalf => Load() as BoundingBox;

        public BoundingBox NoteMiWhole => Load() as BoundingBox;

        public BoundingBox NoteQuarterDown => Load() as BoundingBox;

        public BoundingBox NoteQuarterUp => Load() as BoundingBox;

        public BoundingBox NoteReBlack => Load() as BoundingBox;

        public BoundingBox NoteReHalf => Load() as BoundingBox;

        public BoundingBox NoteReWhole => Load() as BoundingBox;

        public BoundingBox NoteShapeArrowheadLeftBlack => Load() as BoundingBox;

        public BoundingBox NoteShapeArrowheadLeftDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteShapeArrowheadLeftWhite => Load() as BoundingBox;

        public BoundingBox NoteShapeDiamondBlack => Load() as BoundingBox;

        public BoundingBox NoteShapeDiamondDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteShapeDiamondWhite => Load() as BoundingBox;

        public BoundingBox NoteShapeIsoscelesTriangleBlack => Load() as BoundingBox;

        public BoundingBox NoteShapeIsoscelesTriangleDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteShapeIsoscelesTriangleWhite => Load() as BoundingBox;

        public BoundingBox NoteShapeKeystoneBlack => Load() as BoundingBox;

        public BoundingBox NoteShapeKeystoneDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteShapeKeystoneWhite => Load() as BoundingBox;

        public BoundingBox NoteShapeMoonBlack => Load() as BoundingBox;

        public BoundingBox NoteShapeMoonDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteShapeMoonLeftBlack => Load() as BoundingBox;

        public BoundingBox NoteShapeMoonLeftDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteShapeMoonLeftWhite => Load() as BoundingBox;

        public BoundingBox NoteShapeMoonWhite => Load() as BoundingBox;

        public BoundingBox NoteShapeQuarterMoonBlack => Load() as BoundingBox;

        public BoundingBox NoteShapeQuarterMoonDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteShapeQuarterMoonWhite => Load() as BoundingBox;

        public BoundingBox NoteShapeRoundBlack => Load() as BoundingBox;

        public BoundingBox NoteShapeRoundDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteShapeRoundWhite => Load() as BoundingBox;

        public BoundingBox NoteShapeSquareBlack => Load() as BoundingBox;

        public BoundingBox NoteShapeSquareDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteShapeSquareWhite => Load() as BoundingBox;

        public BoundingBox NoteShapeTriangleLeftBlack => Load() as BoundingBox;

        public BoundingBox NoteShapeTriangleLeftDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteShapeTriangleLeftWhite => Load() as BoundingBox;

        public BoundingBox NoteShapeTriangleRightBlack => Load() as BoundingBox;

        public BoundingBox NoteShapeTriangleRightDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteShapeTriangleRightWhite => Load() as BoundingBox;

        public BoundingBox NoteShapeTriangleRoundBlack => Load() as BoundingBox;

        public BoundingBox NoteShapeTriangleRoundDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteShapeTriangleRoundLeftBlack => Load() as BoundingBox;

        public BoundingBox NoteShapeTriangleRoundLeftDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteShapeTriangleRoundLeftWhite => Load() as BoundingBox;

        public BoundingBox NoteShapeTriangleRoundWhite => Load() as BoundingBox;

        public BoundingBox NoteShapeTriangleUpBlack => Load() as BoundingBox;

        public BoundingBox NoteShapeTriangleUpDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteShapeTriangleUpWhite => Load() as BoundingBox;

        public BoundingBox NoteSiBlack => Load() as BoundingBox;

        public BoundingBox NoteSiHalf => Load() as BoundingBox;

        public BoundingBox NoteSiWhole => Load() as BoundingBox;

        public BoundingBox NoteSoBlack => Load() as BoundingBox;

        public BoundingBox NoteSoHalf => Load() as BoundingBox;

        public BoundingBox NoteSoWhole => Load() as BoundingBox;

        public BoundingBox NoteTiBlack => Load() as BoundingBox;

        public BoundingBox NoteTiHalf => Load() as BoundingBox;

        public BoundingBox NoteTiWhole => Load() as BoundingBox;

        public BoundingBox NoteWhole => Load() as BoundingBox;

        public BoundingBox NoteheadBlack => Load() as BoundingBox;

        public BoundingBox NoteheadBlackOversized => Load() as BoundingBox;

        public BoundingBox NoteheadBlackParens => Load() as BoundingBox;

        public BoundingBox NoteheadBlackSmall => Load() as BoundingBox;

        public BoundingBox NoteheadCircleSlash => Load() as BoundingBox;

        public BoundingBox NoteheadCircleX => Load() as BoundingBox;

        public BoundingBox NoteheadCircleXDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteheadCircleXHalf => Load() as BoundingBox;

        public BoundingBox NoteheadCircleXWhole => Load() as BoundingBox;

        public BoundingBox NoteheadCircledBlack => Load() as BoundingBox;

        public BoundingBox NoteheadCircledBlackLarge => Load() as BoundingBox;

        public BoundingBox NoteheadCircledDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteheadCircledDoubleWholeLarge => Load() as BoundingBox;

        public BoundingBox NoteheadCircledHalf => Load() as BoundingBox;

        public BoundingBox NoteheadCircledHalfLarge => Load() as BoundingBox;

        public BoundingBox NoteheadCircledWhole => Load() as BoundingBox;

        public BoundingBox NoteheadCircledWholeLarge => Load() as BoundingBox;

        public BoundingBox NoteheadCircledXLarge => Load() as BoundingBox;

        public BoundingBox NoteheadClusterDoubleWhole2Nd => Load() as BoundingBox;

        public BoundingBox NoteheadClusterDoubleWhole3Rd => Load() as BoundingBox;

        public BoundingBox NoteheadClusterDoubleWholeBottom => Load() as BoundingBox;

        public BoundingBox NoteheadClusterDoubleWholeMiddle => Load() as BoundingBox;

        public BoundingBox NoteheadClusterDoubleWholeTop => Load() as BoundingBox;

        public BoundingBox NoteheadClusterHalf2Nd => Load() as BoundingBox;

        public BoundingBox NoteheadClusterHalf3Rd => Load() as BoundingBox;

        public BoundingBox NoteheadClusterHalfBottom => Load() as BoundingBox;

        public BoundingBox NoteheadClusterHalfMiddle => Load() as BoundingBox;

        public BoundingBox NoteheadClusterHalfTop => Load() as BoundingBox;

        public BoundingBox NoteheadClusterQuarter2Nd => Load() as BoundingBox;

        public BoundingBox NoteheadClusterQuarter3Rd => Load() as BoundingBox;

        public BoundingBox NoteheadClusterQuarterBottom => Load() as BoundingBox;

        public BoundingBox NoteheadClusterQuarterMiddle => Load() as BoundingBox;

        public BoundingBox NoteheadClusterQuarterTop => Load() as BoundingBox;

        public BoundingBox NoteheadClusterRoundBlack => Load() as BoundingBox;

        public BoundingBox NoteheadClusterRoundWhite => Load() as BoundingBox;

        public BoundingBox NoteheadClusterSquareBlack => Load() as BoundingBox;

        public BoundingBox NoteheadClusterSquareWhite => Load() as BoundingBox;

        public BoundingBox NoteheadClusterWhole2Nd => Load() as BoundingBox;

        public BoundingBox NoteheadClusterWhole3Rd => Load() as BoundingBox;

        public BoundingBox NoteheadClusterWholeBottom => Load() as BoundingBox;

        public BoundingBox NoteheadClusterWholeMiddle => Load() as BoundingBox;

        public BoundingBox NoteheadClusterWholeTop => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondBlack => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondBlackOld => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondBlackWide => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondClusterBlack2Nd => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondClusterBlack3Rd => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondClusterBlackBottom => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondClusterBlackMiddle => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondClusterBlackTop => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondClusterWhite2Nd => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondClusterWhite3Rd => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondClusterWhiteBottom => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondClusterWhiteMiddle => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondClusterWhiteTop => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondDoubleWholeOld => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondHalf => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondHalfFilled => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondHalfOld => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondHalfWide => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondOpen => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondWhite => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondWhiteWide => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondWhole => Load() as BoundingBox;

        public BoundingBox NoteheadDiamondWholeOld => Load() as BoundingBox;

        public BoundingBox NoteheadDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteheadDoubleWholeAlt => Load() as BoundingBox;

        public BoundingBox NoteheadDoubleWholeOversized => Load() as BoundingBox;

        public BoundingBox NoteheadDoubleWholeParens => Load() as BoundingBox;

        public BoundingBox NoteheadDoubleWholeSmall => Load() as BoundingBox;

        public BoundingBox NoteheadDoubleWholeSquare => Load() as BoundingBox;

        public BoundingBox NoteheadDoubleWholeSquareOversized => Load() as BoundingBox;

        public BoundingBox NoteheadDoubleWholeWithX => Load() as BoundingBox;

        public BoundingBox NoteheadHalf => Load() as BoundingBox;

        public BoundingBox NoteheadHalfFilled => Load() as BoundingBox;

        public BoundingBox NoteheadHalfOversized => Load() as BoundingBox;

        public BoundingBox NoteheadHalfParens => Load() as BoundingBox;

        public BoundingBox NoteheadHalfSmall => Load() as BoundingBox;

        public BoundingBox NoteheadHalfWithX => Load() as BoundingBox;

        public BoundingBox NoteheadHeavyX => Load() as BoundingBox;

        public BoundingBox NoteheadHeavyXHat => Load() as BoundingBox;

        public BoundingBox NoteheadLargeArrowDownBlack => Load() as BoundingBox;

        public BoundingBox NoteheadLargeArrowDownDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteheadLargeArrowDownHalf => Load() as BoundingBox;

        public BoundingBox NoteheadLargeArrowDownWhole => Load() as BoundingBox;

        public BoundingBox NoteheadLargeArrowUpBlack => Load() as BoundingBox;

        public BoundingBox NoteheadLargeArrowUpDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteheadLargeArrowUpHalf => Load() as BoundingBox;

        public BoundingBox NoteheadLargeArrowUpWhole => Load() as BoundingBox;

        public BoundingBox NoteheadMoonBlack => Load() as BoundingBox;

        public BoundingBox NoteheadMoonWhite => Load() as BoundingBox;

        public BoundingBox NoteheadParenthesis => Load() as BoundingBox;

        public BoundingBox NoteheadParenthesisLeft => Load() as BoundingBox;

        public BoundingBox NoteheadParenthesisRight => Load() as BoundingBox;

        public BoundingBox NoteheadPlusBlack => Load() as BoundingBox;

        public BoundingBox NoteheadPlusDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteheadPlusHalf => Load() as BoundingBox;

        public BoundingBox NoteheadPlusWhole => Load() as BoundingBox;

        public BoundingBox NoteheadRectangularClusterBlackBottom => Load() as BoundingBox;

        public BoundingBox NoteheadRectangularClusterBlackMiddle => Load() as BoundingBox;

        public BoundingBox NoteheadRectangularClusterBlackTop => Load() as BoundingBox;

        public BoundingBox NoteheadRectangularClusterWhiteBottom => Load() as BoundingBox;

        public BoundingBox NoteheadRectangularClusterWhiteMiddle => Load() as BoundingBox;

        public BoundingBox NoteheadRectangularClusterWhiteTop => Load() as BoundingBox;

        public BoundingBox NoteheadRoundBlack => Load() as BoundingBox;

        public BoundingBox NoteheadRoundBlackDoubleSlashed => Load() as BoundingBox;

        public Dictionary<string, long[]> NoteheadRoundBlackLarge => Load() as Dictionary<string, long[]>;

        public BoundingBox NoteheadRoundBlackSlashed => Load() as BoundingBox;

        public BoundingBox NoteheadRoundBlackSlashedLarge => Load() as BoundingBox;

        public BoundingBox NoteheadRoundWhite => Load() as BoundingBox;

        public BoundingBox NoteheadRoundWhiteDoubleSlashed => Load() as BoundingBox;

        public Dictionary<string, long[]> NoteheadRoundWhiteLarge => Load() as Dictionary<string, long[]>;

        public BoundingBox NoteheadRoundWhiteSlashed => Load() as BoundingBox;

        public BoundingBox NoteheadRoundWhiteSlashedLarge => Load() as BoundingBox;

        public BoundingBox NoteheadRoundWhiteWithDot => Load() as BoundingBox;

        public BoundingBox NoteheadRoundWhiteWithDotLarge => Load() as BoundingBox;

        public Dictionary<string, long[]> NoteheadSlashDiamondWhite => Load() as Dictionary<string, long[]>;

        public BoundingBox NoteheadSlashHorizontalEnds => Load() as BoundingBox;

        public BoundingBox NoteheadSlashHorizontalEndsMuted => Load() as BoundingBox;

        public BoundingBox NoteheadSlashVerticalEnds => Load() as BoundingBox;

        public BoundingBox NoteheadSlashVerticalEndsMuted => Load() as BoundingBox;

        public BoundingBox NoteheadSlashVerticalEndsSmall => Load() as BoundingBox;

        public BoundingBox NoteheadSlashWhiteDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteheadSlashWhiteHalf => Load() as BoundingBox;

        public BoundingBox NoteheadSlashWhiteMuted => Load() as BoundingBox;

        public BoundingBox NoteheadSlashWhiteWhole => Load() as BoundingBox;

        public BoundingBox NoteheadSlashX => Load() as BoundingBox;

        public BoundingBox NoteheadSlashedBlack1 => Load() as BoundingBox;

        public BoundingBox NoteheadSlashedBlack2 => Load() as BoundingBox;

        public BoundingBox NoteheadSlashedDoubleWhole1 => Load() as BoundingBox;

        public BoundingBox NoteheadSlashedDoubleWhole2 => Load() as BoundingBox;

        public BoundingBox NoteheadSlashedHalf1 => Load() as BoundingBox;

        public BoundingBox NoteheadSlashedHalf2 => Load() as BoundingBox;

        public BoundingBox NoteheadSlashedWhole1 => Load() as BoundingBox;

        public BoundingBox NoteheadSlashedWhole2 => Load() as BoundingBox;

        public BoundingBox NoteheadSquareBlack => Load() as BoundingBox;

        public Dictionary<string, long[]> NoteheadSquareBlackLarge => Load() as Dictionary<string, long[]>;

        public Dictionary<string, long[]> NoteheadSquareBlackWhite => Load() as Dictionary<string, long[]>;

        public BoundingBox NoteheadSquareWhite => Load() as BoundingBox;

        public BoundingBox NoteheadTriangleDownBlack => Load() as BoundingBox;

        public BoundingBox NoteheadTriangleDownDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteheadTriangleDownHalf => Load() as BoundingBox;

        public BoundingBox NoteheadTriangleDownWhite => Load() as BoundingBox;

        public BoundingBox NoteheadTriangleDownWhole => Load() as BoundingBox;

        public BoundingBox NoteheadTriangleLeftBlack => Load() as BoundingBox;

        public BoundingBox NoteheadTriangleLeftWhite => Load() as BoundingBox;

        public BoundingBox NoteheadTriangleRightBlack => Load() as BoundingBox;

        public BoundingBox NoteheadTriangleRightWhite => Load() as BoundingBox;

        public BoundingBox NoteheadTriangleRoundDownBlack => Load() as BoundingBox;

        public BoundingBox NoteheadTriangleRoundDownWhite => Load() as BoundingBox;

        public BoundingBox NoteheadTriangleUpBlack => Load() as BoundingBox;

        public BoundingBox NoteheadTriangleUpDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteheadTriangleUpHalf => Load() as BoundingBox;

        public BoundingBox NoteheadTriangleUpRightBlack => Load() as BoundingBox;

        public BoundingBox NoteheadTriangleUpRightWhite => Load() as BoundingBox;

        public BoundingBox NoteheadTriangleUpWhite => Load() as BoundingBox;

        public BoundingBox NoteheadTriangleUpWhole => Load() as BoundingBox;

        public BoundingBox NoteheadVoidWithX => Load() as BoundingBox;

        public BoundingBox NoteheadWhole => Load() as BoundingBox;

        public BoundingBox NoteheadWholeFilled => Load() as BoundingBox;

        public BoundingBox NoteheadWholeOversized => Load() as BoundingBox;

        public BoundingBox NoteheadWholeParens => Load() as BoundingBox;

        public BoundingBox NoteheadWholeSmall => Load() as BoundingBox;

        public BoundingBox NoteheadWholeWithX => Load() as BoundingBox;

        public BoundingBox NoteheadXBlack => Load() as BoundingBox;

        public BoundingBox NoteheadXDoubleWhole => Load() as BoundingBox;

        public BoundingBox NoteheadXHalf => Load() as BoundingBox;

        public BoundingBox NoteheadXOrnate => Load() as BoundingBox;

        public BoundingBox NoteheadXOrnateEllipse => Load() as BoundingBox;

        public BoundingBox NoteheadXWhole => Load() as BoundingBox;

        public BoundingBox OctaveBaselineA => Load() as BoundingBox;

        public BoundingBox OctaveBaselineB => Load() as BoundingBox;

        public BoundingBox OctaveBaselineM => Load() as BoundingBox;

        public BoundingBox OctaveBaselineV => Load() as BoundingBox;

        public BoundingBox OctaveBassa => Load() as BoundingBox;

        public BoundingBox OctaveLoco => Load() as BoundingBox;

        public BoundingBox OctaveParensLeft => Load() as BoundingBox;

        public BoundingBox OctaveParensRight => Load() as BoundingBox;

        public BoundingBox OctaveSuperscriptA => Load() as BoundingBox;

        public BoundingBox OctaveSuperscriptB => Load() as BoundingBox;

        public BoundingBox OctaveSuperscriptM => Load() as BoundingBox;

        public BoundingBox OctaveSuperscriptV => Load() as BoundingBox;

        public BoundingBox OrnamentBottomLeftConcaveStroke => Load() as BoundingBox;

        public BoundingBox OrnamentBottomLeftConcaveStrokeLarge => Load() as BoundingBox;

        public BoundingBox OrnamentBottomLeftConvexStroke => Load() as BoundingBox;

        public BoundingBox OrnamentBottomRightConcaveStroke => Load() as BoundingBox;

        public BoundingBox OrnamentBottomRightConvexStroke => Load() as BoundingBox;

        public BoundingBox OrnamentComma => Load() as BoundingBox;

        public BoundingBox OrnamentDoubleObliqueLinesAfterNote => Load() as BoundingBox;

        public BoundingBox OrnamentDoubleObliqueLinesBeforeNote => Load() as BoundingBox;

        public BoundingBox OrnamentDownCurve => Load() as BoundingBox;

        public BoundingBox OrnamentHaydn => Load() as BoundingBox;

        public BoundingBox OrnamentHighLeftConcaveStroke => Load() as BoundingBox;

        public BoundingBox OrnamentHighLeftConvexStroke => Load() as BoundingBox;

        public BoundingBox OrnamentHighRightConcaveStroke => Load() as BoundingBox;

        public BoundingBox OrnamentHighRightConvexStroke => Load() as BoundingBox;

        public BoundingBox OrnamentHookAfterNote => Load() as BoundingBox;

        public BoundingBox OrnamentHookBeforeNote => Load() as BoundingBox;

        public BoundingBox OrnamentLeftFacingHalfCircle => Load() as BoundingBox;

        public BoundingBox OrnamentLeftFacingHook => Load() as BoundingBox;

        public BoundingBox OrnamentLeftPlus => Load() as BoundingBox;

        public BoundingBox OrnamentLeftShakeT => Load() as BoundingBox;

        public BoundingBox OrnamentLeftVerticalStroke => Load() as BoundingBox;

        public BoundingBox OrnamentLeftVerticalStrokeWithCross => Load() as BoundingBox;

        public BoundingBox OrnamentLowLeftConcaveStroke => Load() as BoundingBox;

        public BoundingBox OrnamentLowLeftConvexStroke => Load() as BoundingBox;

        public BoundingBox OrnamentLowRightConcaveStroke => Load() as BoundingBox;

        public BoundingBox OrnamentLowRightConvexStroke => Load() as BoundingBox;

        public BoundingBox OrnamentMiddleVerticalStroke => Load() as BoundingBox;

        public BoundingBox OrnamentMordent => Load() as BoundingBox;

        public BoundingBox OrnamentMordentInverted => Load() as BoundingBox;

        public BoundingBox OrnamentObliqueLineAfterNote => Load() as BoundingBox;

        public BoundingBox OrnamentObliqueLineBeforeNote => Load() as BoundingBox;

        public BoundingBox OrnamentObliqueLineHorizAfterNote => Load() as BoundingBox;

        public BoundingBox OrnamentObliqueLineHorizBeforeNote => Load() as BoundingBox;

        public BoundingBox OrnamentOriscus => Load() as BoundingBox;

        public BoundingBox OrnamentPinceCouperin => Load() as BoundingBox;

        public BoundingBox OrnamentPortDeVoixV => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompAppoggTrill => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompAppoggTrillSuffix => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompCadence => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompCadenceUpperPrefix => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompCadenceUpperPrefixTurn => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompCadenceWithTurn => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompDescendingSlide => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompDoubleCadenceLowerPrefix => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompDoubleCadenceUpperPrefix => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompDoubleCadenceUpperPrefixTurn => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompInvertedMordentUpperPrefix => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompMordentRelease => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompMordentUpperPrefix => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompPortDeVoixMordent => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompSlide => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompSlideTrillBach => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompSlideTrillDAnglebert => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompSlideTrillMarpurg => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompSlideTrillMuffat => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompSlideTrillSuffixMuffat => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompTrillLowerSuffix => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompTrillSuffixDandrieu => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompTrillWithMordent => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompTurnTrillBach => Load() as BoundingBox;

        public BoundingBox OrnamentPrecompTurnTrillDAnglebert => Load() as BoundingBox;

        public BoundingBox OrnamentQuilisma => Load() as BoundingBox;

        public BoundingBox OrnamentRightFacingHalfCircle => Load() as BoundingBox;

        public BoundingBox OrnamentRightFacingHook => Load() as BoundingBox;

        public BoundingBox OrnamentRightVerticalStroke => Load() as BoundingBox;

        public BoundingBox OrnamentSchleifer => Load() as BoundingBox;

        public BoundingBox OrnamentShake3 => Load() as BoundingBox;

        public BoundingBox OrnamentShakeMuffat1 => Load() as BoundingBox;

        public BoundingBox OrnamentShortObliqueLineAfterNote => Load() as BoundingBox;

        public BoundingBox OrnamentShortObliqueLineBeforeNote => Load() as BoundingBox;

        public BoundingBox OrnamentTopLeftConcaveStroke => Load() as BoundingBox;

        public BoundingBox OrnamentTopLeftConvexStroke => Load() as BoundingBox;

        public BoundingBox OrnamentTopRightConcaveStroke => Load() as BoundingBox;

        public BoundingBox OrnamentTopRightConvexStroke => Load() as BoundingBox;

        public BoundingBox OrnamentTremblement => Load() as BoundingBox;

        public BoundingBox OrnamentTremblementCouperin => Load() as BoundingBox;

        public BoundingBox OrnamentTrill => Load() as BoundingBox;

        public BoundingBox OrnamentTrillFlatAbove => Load() as BoundingBox;

        public BoundingBox OrnamentTrillNaturalAbove => Load() as BoundingBox;

        public BoundingBox OrnamentTrillSharpAbove => Load() as BoundingBox;

        public BoundingBox OrnamentTurn => Load() as BoundingBox;

        public BoundingBox OrnamentTurnFlatAbove => Load() as BoundingBox;

        public BoundingBox OrnamentTurnFlatAboveSharpBelow => Load() as BoundingBox;

        public BoundingBox OrnamentTurnFlatBelow => Load() as BoundingBox;

        public BoundingBox OrnamentTurnInverted => Load() as BoundingBox;

        public BoundingBox OrnamentTurnNaturalAbove => Load() as BoundingBox;

        public BoundingBox OrnamentTurnNaturalBelow => Load() as BoundingBox;

        public BoundingBox OrnamentTurnSharpAbove => Load() as BoundingBox;

        public BoundingBox OrnamentTurnSharpAboveFlatBelow => Load() as BoundingBox;

        public BoundingBox OrnamentTurnSharpBelow => Load() as BoundingBox;

        public BoundingBox OrnamentTurnSlash => Load() as BoundingBox;

        public BoundingBox OrnamentTurnUp => Load() as BoundingBox;

        public BoundingBox OrnamentTurnUpS => Load() as BoundingBox;

        public BoundingBox OrnamentUpCurve => Load() as BoundingBox;

        public BoundingBox OrnamentVerticalLine => Load() as BoundingBox;

        public BoundingBox OrnamentZigZagLineNoRightEnd => Load() as BoundingBox;

        public BoundingBox OrnamentZigZagLineWithRightEnd => Load() as BoundingBox;

        public BoundingBox Ottava => Load() as BoundingBox;

        public BoundingBox OttavaAlta => Load() as BoundingBox;

        public BoundingBox OttavaBassa => Load() as BoundingBox;

        public BoundingBox OttavaBassaBa => Load() as BoundingBox;

        public BoundingBox OttavaBassaVb => Load() as BoundingBox;

        public BoundingBox PendereckiTremolo => Load() as BoundingBox;

        public BoundingBox PictAgogo => Load() as BoundingBox;

        public BoundingBox PictAlmglocken => Load() as BoundingBox;

        public BoundingBox PictAnvil => Load() as BoundingBox;

        public BoundingBox PictBambooChimes => Load() as BoundingBox;

        public BoundingBox PictBambooScraper => Load() as BoundingBox;

        public BoundingBox PictBassDrum => Load() as BoundingBox;

        public BoundingBox PictBassDrumOnSide => Load() as BoundingBox;

        public BoundingBox PictBassDrumPeinkofer => Load() as BoundingBox;

        public BoundingBox PictBeaterBow => Load() as BoundingBox;

        public BoundingBox PictBeaterBox => Load() as BoundingBox;

        public BoundingBox PictBeaterBrassMalletsDown => Load() as BoundingBox;

        public BoundingBox PictBeaterBrassMalletsUp => Load() as BoundingBox;

        public BoundingBox PictBeaterCombiningDashedCircle => Load() as BoundingBox;

        public BoundingBox PictBeaterCombiningParentheses => Load() as BoundingBox;

        public BoundingBox PictBeaterDoubleBassDrumDown => Load() as BoundingBox;

        public BoundingBox PictBeaterDoubleBassDrumUp => Load() as BoundingBox;

        public BoundingBox PictBeaterFinger => Load() as BoundingBox;

        public BoundingBox PictBeaterFingernails => Load() as BoundingBox;

        public BoundingBox PictBeaterFist => Load() as BoundingBox;

        public BoundingBox PictBeaterGuiroScraper => Load() as BoundingBox;

        public BoundingBox PictBeaterHammer => Load() as BoundingBox;

        public BoundingBox PictBeaterHammerMetalDown => Load() as BoundingBox;

        public BoundingBox PictBeaterHammerMetalUp => Load() as BoundingBox;

        public BoundingBox PictBeaterHammerPlasticDown => Load() as BoundingBox;

        public BoundingBox PictBeaterHammerPlasticUp => Load() as BoundingBox;

        public BoundingBox PictBeaterHammerWoodDown => Load() as BoundingBox;

        public BoundingBox PictBeaterHammerWoodUp => Load() as BoundingBox;

        public BoundingBox PictBeaterHand => Load() as BoundingBox;

        public BoundingBox PictBeaterHardBassDrumDown => Load() as BoundingBox;

        public BoundingBox PictBeaterHardBassDrumUp => Load() as BoundingBox;

        public BoundingBox PictBeaterHardGlockenspielDown => Load() as BoundingBox;

        public BoundingBox PictBeaterHardGlockenspielLeft => Load() as BoundingBox;

        public BoundingBox PictBeaterHardGlockenspielRight => Load() as BoundingBox;

        public BoundingBox PictBeaterHardGlockenspielUp => Load() as BoundingBox;

        public BoundingBox PictBeaterHardTimpaniDown => Load() as BoundingBox;

        public BoundingBox PictBeaterHardTimpaniLeft => Load() as BoundingBox;

        public BoundingBox PictBeaterHardTimpaniRight => Load() as BoundingBox;

        public BoundingBox PictBeaterHardTimpaniUp => Load() as BoundingBox;

        public BoundingBox PictBeaterHardXylophoneDown => Load() as BoundingBox;

        public BoundingBox PictBeaterHardXylophoneLeft => Load() as BoundingBox;

        public BoundingBox PictBeaterHardXylophoneRight => Load() as BoundingBox;

        public BoundingBox PictBeaterHardXylophoneUp => Load() as BoundingBox;

        public BoundingBox PictBeaterHardYarnDown => Load() as BoundingBox;

        public BoundingBox PictBeaterHardYarnLeft => Load() as BoundingBox;

        public BoundingBox PictBeaterHardYarnRight => Load() as BoundingBox;

        public BoundingBox PictBeaterHardYarnUp => Load() as BoundingBox;

        public BoundingBox PictBeaterJazzSticksDown => Load() as BoundingBox;

        public BoundingBox PictBeaterJazzSticksUp => Load() as BoundingBox;

        public BoundingBox PictBeaterKnittingNeedle => Load() as BoundingBox;

        public BoundingBox PictBeaterMallet => Load() as BoundingBox;

        public BoundingBox PictBeaterMediumBassDrumDown => Load() as BoundingBox;

        public BoundingBox PictBeaterMediumBassDrumUp => Load() as BoundingBox;

        public BoundingBox PictBeaterMediumTimpaniDown => Load() as BoundingBox;

        public BoundingBox PictBeaterMediumTimpaniLeft => Load() as BoundingBox;

        public BoundingBox PictBeaterMediumTimpaniRight => Load() as BoundingBox;

        public BoundingBox PictBeaterMediumTimpaniUp => Load() as BoundingBox;

        public BoundingBox PictBeaterMediumXylophoneDown => Load() as BoundingBox;

        public BoundingBox PictBeaterMediumXylophoneLeft => Load() as BoundingBox;

        public BoundingBox PictBeaterMediumXylophoneRight => Load() as BoundingBox;

        public BoundingBox PictBeaterMediumXylophoneUp => Load() as BoundingBox;

        public BoundingBox PictBeaterMediumYarnDown => Load() as BoundingBox;

        public BoundingBox PictBeaterMediumYarnLeft => Load() as BoundingBox;

        public BoundingBox PictBeaterMediumYarnRight => Load() as BoundingBox;

        public BoundingBox PictBeaterMediumYarnUp => Load() as BoundingBox;

        public BoundingBox PictBeaterMetalBassDrumDown => Load() as BoundingBox;

        public BoundingBox PictBeaterMetalBassDrumUp => Load() as BoundingBox;

        public BoundingBox PictBeaterMetalDown => Load() as BoundingBox;

        public BoundingBox PictBeaterMetalHammer => Load() as BoundingBox;

        public BoundingBox PictBeaterMetalLeft => Load() as BoundingBox;

        public BoundingBox PictBeaterMetalRight => Load() as BoundingBox;

        public BoundingBox PictBeaterMetalUp => Load() as BoundingBox;

        public BoundingBox PictBeaterSnareSticksDown => Load() as BoundingBox;

        public BoundingBox PictBeaterSnareSticksUp => Load() as BoundingBox;

        public BoundingBox PictBeaterSoftBassDrumDown => Load() as BoundingBox;

        public BoundingBox PictBeaterSoftBassDrumUp => Load() as BoundingBox;

        public BoundingBox PictBeaterSoftGlockenspielDown => Load() as BoundingBox;

        public BoundingBox PictBeaterSoftGlockenspielLeft => Load() as BoundingBox;

        public BoundingBox PictBeaterSoftGlockenspielRight => Load() as BoundingBox;

        public BoundingBox PictBeaterSoftGlockenspielUp => Load() as BoundingBox;

        public BoundingBox PictBeaterSoftTimpaniDown => Load() as BoundingBox;

        public BoundingBox PictBeaterSoftTimpaniLeft => Load() as BoundingBox;

        public BoundingBox PictBeaterSoftTimpaniRight => Load() as BoundingBox;

        public BoundingBox PictBeaterSoftTimpaniUp => Load() as BoundingBox;

        public BoundingBox PictBeaterSoftXylophone => Load() as BoundingBox;

        public BoundingBox PictBeaterSoftXylophoneDown => Load() as BoundingBox;

        public BoundingBox PictBeaterSoftXylophoneLeft => Load() as BoundingBox;

        public BoundingBox PictBeaterSoftXylophoneRight => Load() as BoundingBox;

        public BoundingBox PictBeaterSoftXylophoneUp => Load() as BoundingBox;

        public BoundingBox PictBeaterSoftYarnDown => Load() as BoundingBox;

        public BoundingBox PictBeaterSoftYarnLeft => Load() as BoundingBox;

        public BoundingBox PictBeaterSoftYarnRight => Load() as BoundingBox;

        public BoundingBox PictBeaterSoftYarnUp => Load() as BoundingBox;

        public BoundingBox PictBeaterSpoonWoodenMallet => Load() as BoundingBox;

        public BoundingBox PictBeaterSuperballDown => Load() as BoundingBox;

        public BoundingBox PictBeaterSuperballLeft => Load() as BoundingBox;

        public BoundingBox PictBeaterSuperballRight => Load() as BoundingBox;

        public BoundingBox PictBeaterSuperballUp => Load() as BoundingBox;

        public BoundingBox PictBeaterTriangleDown => Load() as BoundingBox;

        public BoundingBox PictBeaterTriangleUp => Load() as BoundingBox;

        public BoundingBox PictBeaterWireBrushesDown => Load() as BoundingBox;

        public BoundingBox PictBeaterWireBrushesUp => Load() as BoundingBox;

        public BoundingBox PictBeaterWoodTimpaniDown => Load() as BoundingBox;

        public BoundingBox PictBeaterWoodTimpaniLeft => Load() as BoundingBox;

        public BoundingBox PictBeaterWoodTimpaniRight => Load() as BoundingBox;

        public BoundingBox PictBeaterWoodTimpaniUp => Load() as BoundingBox;

        public BoundingBox PictBeaterWoodXylophoneDown => Load() as BoundingBox;

        public BoundingBox PictBeaterWoodXylophoneLeft => Load() as BoundingBox;

        public BoundingBox PictBeaterWoodXylophoneRight => Load() as BoundingBox;

        public BoundingBox PictBeaterWoodXylophoneUp => Load() as BoundingBox;

        public BoundingBox PictBell => Load() as BoundingBox;

        public BoundingBox PictBellOfCymbal => Load() as BoundingBox;

        public BoundingBox PictBellPlate => Load() as BoundingBox;

        public BoundingBox PictBellTree => Load() as BoundingBox;

        public BoundingBox PictBirdWhistle => Load() as BoundingBox;

        public BoundingBox PictBoardClapper => Load() as BoundingBox;

        public BoundingBox PictBongos => Load() as BoundingBox;

        public BoundingBox PictBongosPeinkofer => Load() as BoundingBox;

        public BoundingBox PictBrakeDrum => Load() as BoundingBox;

        public BoundingBox PictCabasa => Load() as BoundingBox;

        public BoundingBox PictCannon => Load() as BoundingBox;

        public BoundingBox PictCarHorn => Load() as BoundingBox;

        public BoundingBox PictCastanets => Load() as BoundingBox;

        public BoundingBox PictCastanetsSmithBrindle => Load() as BoundingBox;

        public BoundingBox PictCastanetsWithHandle => Load() as BoundingBox;

        public BoundingBox PictCelesta => Load() as BoundingBox;

        public BoundingBox PictCencerro => Load() as BoundingBox;

        public BoundingBox PictCenter1 => Load() as BoundingBox;

        public BoundingBox PictCenter2 => Load() as BoundingBox;

        public BoundingBox PictCenter3 => Load() as BoundingBox;

        public BoundingBox PictChainRattle => Load() as BoundingBox;

        public BoundingBox PictChimes => Load() as BoundingBox;

        public BoundingBox PictChineseCymbal => Load() as BoundingBox;

        public BoundingBox PictChokeCymbal => Load() as BoundingBox;

        public BoundingBox PictClaves => Load() as BoundingBox;

        public BoundingBox PictCoins => Load() as BoundingBox;

        public BoundingBox PictConga => Load() as BoundingBox;

        public BoundingBox PictCongaPeinkofer => Load() as BoundingBox;

        public BoundingBox PictCowBell => Load() as BoundingBox;

        public BoundingBox PictCowBellBerio => Load() as BoundingBox;

        public BoundingBox PictCrashCymbals => Load() as BoundingBox;

        public BoundingBox PictCrotales => Load() as BoundingBox;

        public BoundingBox PictCrushStem => Load() as BoundingBox;

        public BoundingBox PictCuica => Load() as BoundingBox;

        public BoundingBox PictCymbalTongs => Load() as BoundingBox;

        public BoundingBox PictDamp1 => Load() as BoundingBox;

        public BoundingBox PictDamp2 => Load() as BoundingBox;

        public BoundingBox PictDamp3 => Load() as BoundingBox;

        public BoundingBox PictDamp4 => Load() as BoundingBox;

        public BoundingBox PictDeadNoteStem => Load() as BoundingBox;

        public BoundingBox PictDrumStick => Load() as BoundingBox;

        public BoundingBox PictDuckCall => Load() as BoundingBox;

        public BoundingBox PictEdgeOfCymbal => Load() as BoundingBox;

        public BoundingBox PictEmptyTrap => Load() as BoundingBox;

        public BoundingBox PictFingerCymbals => Load() as BoundingBox;

        public BoundingBox PictFlexatone => Load() as BoundingBox;

        public BoundingBox PictFlexatonePeinkofer => Load() as BoundingBox;

        public BoundingBox PictFootballRatchet => Load() as BoundingBox;

        public BoundingBox PictGlassHarmonica => Load() as BoundingBox;

        public BoundingBox PictGlassHarp => Load() as BoundingBox;

        public BoundingBox PictGlassPlateChimes => Load() as BoundingBox;

        public BoundingBox PictGlassTubeChimes => Load() as BoundingBox;

        public BoundingBox PictGlsp => Load() as BoundingBox;

        public BoundingBox PictGlspPeinkofer => Load() as BoundingBox;

        public BoundingBox PictGlspSmithBrindle => Load() as BoundingBox;

        public BoundingBox PictGobletDrum => Load() as BoundingBox;

        public BoundingBox PictGong => Load() as BoundingBox;

        public BoundingBox PictGongWithButton => Load() as BoundingBox;

        public BoundingBox PictGuiro => Load() as BoundingBox;

        public BoundingBox PictGuiroPeinkofer => Load() as BoundingBox;

        public BoundingBox PictGuiroSevsay => Load() as BoundingBox;

        public BoundingBox PictGumHardDown => Load() as BoundingBox;

        public BoundingBox PictGumHardLeft => Load() as BoundingBox;

        public BoundingBox PictGumHardRight => Load() as BoundingBox;

        public BoundingBox PictGumHardUp => Load() as BoundingBox;

        public BoundingBox PictGumMediumDown => Load() as BoundingBox;

        public BoundingBox PictGumMediumLeft => Load() as BoundingBox;

        public BoundingBox PictGumMediumRight => Load() as BoundingBox;

        public BoundingBox PictGumMediumUp => Load() as BoundingBox;

        public BoundingBox PictGumSoftDown => Load() as BoundingBox;

        public BoundingBox PictGumSoftLeft => Load() as BoundingBox;

        public BoundingBox PictGumSoftRight => Load() as BoundingBox;

        public BoundingBox PictGumSoftUp => Load() as BoundingBox;

        public BoundingBox PictHalfOpen1 => Load() as BoundingBox;

        public BoundingBox PictHalfOpen2 => Load() as BoundingBox;

        public BoundingBox PictHandbell => Load() as BoundingBox;

        public BoundingBox PictHiHat => Load() as BoundingBox;

        public BoundingBox PictHiHatOnStand => Load() as BoundingBox;

        public Dictionary<string, long[]> PictJawHarp => Load() as Dictionary<string, long[]>;

        public BoundingBox PictJingleBells => Load() as BoundingBox;

        public BoundingBox PictKlaxonHorn => Load() as BoundingBox;

        public BoundingBox PictLeftHandCircle => Load() as BoundingBox;

        public BoundingBox PictLionsRoar => Load() as BoundingBox;

        public BoundingBox PictLithophone => Load() as BoundingBox;

        public BoundingBox PictLithophonePeinkofer => Load() as BoundingBox;

        public BoundingBox PictLogDrum => Load() as BoundingBox;

        public BoundingBox PictLotusFlute => Load() as BoundingBox;

        public BoundingBox PictLotusFlutePeinkofer => Load() as BoundingBox;

        public BoundingBox PictMar => Load() as BoundingBox;

        public BoundingBox PictMarPeinkofer => Load() as BoundingBox;

        public BoundingBox PictMarSmithBrindle => Load() as BoundingBox;

        public BoundingBox PictMaraca => Load() as BoundingBox;

        public BoundingBox PictMaracaSmithBrindle => Load() as BoundingBox;

        public BoundingBox PictMaracas => Load() as BoundingBox;

        public BoundingBox PictMegaphone => Load() as BoundingBox;

        public BoundingBox PictMetalPlateChimes => Load() as BoundingBox;

        public BoundingBox PictMetalTubeChimes => Load() as BoundingBox;

        public BoundingBox PictMusicalSaw => Load() as BoundingBox;

        public BoundingBox PictMusicalSawPeinkofer => Load() as BoundingBox;

        public BoundingBox PictNormalPosition => Load() as BoundingBox;

        public BoundingBox PictOnRim => Load() as BoundingBox;

        public BoundingBox PictOpen => Load() as BoundingBox;

        public BoundingBox PictOpenRimShot => Load() as BoundingBox;

        public BoundingBox PictPistolShot => Load() as BoundingBox;

        public BoundingBox PictPoliceWhistle => Load() as BoundingBox;

        public BoundingBox PictQuijada => Load() as BoundingBox;

        public BoundingBox PictRainstick => Load() as BoundingBox;

        public BoundingBox PictRatchet => Load() as BoundingBox;

        public BoundingBox PictRecoReco => Load() as BoundingBox;

        public BoundingBox PictRightHandSquare => Load() as BoundingBox;

        public BoundingBox PictRim1 => Load() as BoundingBox;

        public BoundingBox PictRim2 => Load() as BoundingBox;

        public BoundingBox PictRim3 => Load() as BoundingBox;

        public BoundingBox PictRimShotOnStem => Load() as BoundingBox;

        public BoundingBox PictSandpaperBlocks => Load() as BoundingBox;

        public BoundingBox PictScrapeAroundRim => Load() as BoundingBox;

        public BoundingBox PictScrapeAroundRimClockwise => Load() as BoundingBox;

        public BoundingBox PictScrapeCenterToEdge => Load() as BoundingBox;

        public BoundingBox PictScrapeEdgeToCenter => Load() as BoundingBox;

        public Dictionary<string, long[]> PictShellBells => Load() as Dictionary<string, long[]>;

        public BoundingBox PictShellChimes => Load() as BoundingBox;

        public BoundingBox PictSiren => Load() as BoundingBox;

        public BoundingBox PictSistrum => Load() as BoundingBox;

        public BoundingBox PictSizzleCymbal => Load() as BoundingBox;

        public BoundingBox PictSleighBell => Load() as BoundingBox;

        public BoundingBox PictSleighBellSmithBrindle => Load() as BoundingBox;

        public BoundingBox PictSlideBrushOnGong => Load() as BoundingBox;

        public BoundingBox PictSlideWhistle => Load() as BoundingBox;

        public BoundingBox PictSlitDrum => Load() as BoundingBox;

        public BoundingBox PictSnareDrum => Load() as BoundingBox;

        public BoundingBox PictSnareDrumMilitary => Load() as BoundingBox;

        public BoundingBox PictSnareDrumSnaresOff => Load() as BoundingBox;

        public BoundingBox PictSteelDrums => Load() as BoundingBox;

        public BoundingBox PictStickShot => Load() as BoundingBox;

        public BoundingBox PictSuperball => Load() as BoundingBox;

        public BoundingBox PictSuspendedCymbal => Load() as BoundingBox;

        public BoundingBox PictSwishStem => Load() as BoundingBox;

        public BoundingBox PictTabla => Load() as BoundingBox;

        public BoundingBox PictTamTam => Load() as BoundingBox;

        public BoundingBox PictTamTamWithBeater => Load() as BoundingBox;

        public BoundingBox PictTambourine => Load() as BoundingBox;

        public BoundingBox PictTambourineStockhausen => Load() as BoundingBox;

        public BoundingBox PictTempleBlocks => Load() as BoundingBox;

        public BoundingBox PictTenorDrum => Load() as BoundingBox;

        public BoundingBox PictThundersheet => Load() as BoundingBox;

        public BoundingBox PictTimbales => Load() as BoundingBox;

        public BoundingBox PictTimbalesPeinkofer => Load() as BoundingBox;

        public BoundingBox PictTimpani => Load() as BoundingBox;

        public BoundingBox PictTimpaniPeinkofer => Load() as BoundingBox;

        public BoundingBox PictTomTom => Load() as BoundingBox;

        public BoundingBox PictTomTomChinese => Load() as BoundingBox;

        public BoundingBox PictTomTomChinesePeinkofer => Load() as BoundingBox;

        public BoundingBox PictTomTomIndoAmerican => Load() as BoundingBox;

        public BoundingBox PictTomTomJapanese => Load() as BoundingBox;

        public BoundingBox PictTomTomPeinkofer => Load() as BoundingBox;

        public BoundingBox PictTriangle => Load() as BoundingBox;

        public BoundingBox PictTubaphone => Load() as BoundingBox;

        public BoundingBox PictTubaphonePeinkofer => Load() as BoundingBox;

        public BoundingBox PictTubularBells => Load() as BoundingBox;

        public BoundingBox PictTurnLeftStem => Load() as BoundingBox;

        public BoundingBox PictTurnRightLeftStem => Load() as BoundingBox;

        public BoundingBox PictTurnRightStem => Load() as BoundingBox;

        public BoundingBox PictVib => Load() as BoundingBox;

        public BoundingBox PictVibMotorOff => Load() as BoundingBox;

        public BoundingBox PictVibMotorOffPeinkofer => Load() as BoundingBox;

        public BoundingBox PictVibPeinkofer => Load() as BoundingBox;

        public BoundingBox PictVibSmithBrindle => Load() as BoundingBox;

        public BoundingBox PictVibraslap => Load() as BoundingBox;

        public BoundingBox PictVietnameseHat => Load() as BoundingBox;

        public BoundingBox PictWhip => Load() as BoundingBox;

        public BoundingBox PictWindChimesGlass => Load() as BoundingBox;

        public BoundingBox PictWindMachine => Load() as BoundingBox;

        public BoundingBox PictWindWhistle => Load() as BoundingBox;

        public BoundingBox PictWoodBlock => Load() as BoundingBox;

        public BoundingBox PictWoundHardDown => Load() as BoundingBox;

        public BoundingBox PictWoundHardLeft => Load() as BoundingBox;

        public BoundingBox PictWoundHardRight => Load() as BoundingBox;

        public BoundingBox PictWoundHardUp => Load() as BoundingBox;

        public BoundingBox PictWoundSoftDown => Load() as BoundingBox;

        public BoundingBox PictWoundSoftLeft => Load() as BoundingBox;

        public BoundingBox PictWoundSoftRight => Load() as BoundingBox;

        public BoundingBox PictWoundSoftUp => Load() as BoundingBox;

        public BoundingBox PictXyl => Load() as BoundingBox;

        public BoundingBox PictXylBass => Load() as BoundingBox;

        public BoundingBox PictXylBassPeinkofer => Load() as BoundingBox;

        public BoundingBox PictXylPeinkofer => Load() as BoundingBox;

        public BoundingBox PictXylSmithBrindle => Load() as BoundingBox;

        public BoundingBox PictXylTenor => Load() as BoundingBox;

        public BoundingBox PictXylTenorPeinkofer => Load() as BoundingBox;

        public BoundingBox PictXylTenorTrough => Load() as BoundingBox;

        public BoundingBox PictXylTrough => Load() as BoundingBox;

        public BoundingBox PluckedBuzzPizzicato => Load() as BoundingBox;

        public BoundingBox PluckedDamp => Load() as BoundingBox;

        public BoundingBox PluckedDampAll => Load() as BoundingBox;

        public BoundingBox PluckedDampOnStem => Load() as BoundingBox;

        public BoundingBox PluckedFingernailFlick => Load() as BoundingBox;

        public BoundingBox PluckedLeftHandPizzicato => Load() as BoundingBox;

        public BoundingBox PluckedPlectrum => Load() as BoundingBox;

        public BoundingBox PluckedSnapPizzicatoAbove => Load() as BoundingBox;

        public BoundingBox PluckedSnapPizzicatoAboveGerman => Load() as BoundingBox;

        public BoundingBox PluckedSnapPizzicatoBelow => Load() as BoundingBox;

        public BoundingBox PluckedSnapPizzicatoBelowGerman => Load() as BoundingBox;

        public BoundingBox PluckedWithFingernails => Load() as BoundingBox;

        public BoundingBox Quindicesima => Load() as BoundingBox;

        public BoundingBox QuindicesimaAlta => Load() as BoundingBox;

        public BoundingBox QuindicesimaBassa => Load() as BoundingBox;

        public BoundingBox QuindicesimaBassaMb => Load() as BoundingBox;

        public BoundingBox Repeat1Bar => Load() as BoundingBox;

        public BoundingBox Repeat2Bars => Load() as BoundingBox;

        public BoundingBox Repeat4Bars => Load() as BoundingBox;

        public BoundingBox RepeatDot => Load() as BoundingBox;

        public BoundingBox RepeatDots => Load() as BoundingBox;

        public BoundingBox RepeatLeft => Load() as BoundingBox;

        public BoundingBox RepeatRight => Load() as BoundingBox;

        public BoundingBox RepeatRightLeft => Load() as BoundingBox;

        public BoundingBox RepeatRightLeftThick => Load() as BoundingBox;

        public BoundingBox Rest1024Th => Load() as BoundingBox;

        public BoundingBox Rest128Th => Load() as BoundingBox;

        public BoundingBox Rest16Th => Load() as BoundingBox;

        public BoundingBox Rest256Th => Load() as BoundingBox;

        public BoundingBox Rest32Nd => Load() as BoundingBox;

        public BoundingBox Rest512Th => Load() as BoundingBox;

        public BoundingBox Rest64Th => Load() as BoundingBox;

        public BoundingBox Rest8Th => Load() as BoundingBox;

        public BoundingBox RestDoubleWhole => Load() as BoundingBox;

        public BoundingBox RestDoubleWholeLegerLine => Load() as BoundingBox;

        public BoundingBox RestHBar => Load() as BoundingBox;

        public BoundingBox RestHBarLeft => Load() as BoundingBox;

        public BoundingBox RestHBarMiddle => Load() as BoundingBox;

        public BoundingBox RestHBarRight => Load() as BoundingBox;

        public BoundingBox RestHalf => Load() as BoundingBox;

        public BoundingBox RestHalfLegerLine => Load() as BoundingBox;

        public BoundingBox RestLonga => Load() as BoundingBox;

        public BoundingBox RestMaxima => Load() as BoundingBox;

        public BoundingBox RestQuarter => Load() as BoundingBox;

        public BoundingBox RestQuarterOld => Load() as BoundingBox;

        public BoundingBox RestQuarterZ => Load() as BoundingBox;

        public BoundingBox RestWhole => Load() as BoundingBox;

        public BoundingBox RestWholeLegerLine => Load() as BoundingBox;

        public BoundingBox ReversedBrace => Load() as BoundingBox;

        public BoundingBox ReversedBracketBottom => Load() as BoundingBox;

        public BoundingBox ReversedBracketTop => Load() as BoundingBox;

        public BoundingBox RightRepeatSmall => Load() as BoundingBox;

        public BoundingBox SchaefferClef => Load() as BoundingBox;

        public BoundingBox SchaefferFClefToGClef => Load() as BoundingBox;

        public BoundingBox SchaefferGClefToFClef => Load() as BoundingBox;

        public BoundingBox SchaefferPreviousClef => Load() as BoundingBox;

        public BoundingBox Sedicesima => Load() as BoundingBox;

        public BoundingBox SedicesimaAlta => Load() as BoundingBox;

        public BoundingBox SedicesimaBassa => Load() as BoundingBox;

        public BoundingBox SedicesimaBassaMb => Load() as BoundingBox;

        public BoundingBox Segno => Load() as BoundingBox;

        public BoundingBox SegnoJapanese => Load() as BoundingBox;

        public BoundingBox SegnoSerpent1 => Load() as BoundingBox;

        public BoundingBox SegnoSerpent2 => Load() as BoundingBox;

        public BoundingBox SemipitchedPercussionClef1 => Load() as BoundingBox;

        public BoundingBox SemipitchedPercussionClef2 => Load() as BoundingBox;

        public BoundingBox SmnFlat => Load() as BoundingBox;

        public BoundingBox SmnFlatWhite => Load() as BoundingBox;

        public BoundingBox SmnHistoryDoubleFlat => Load() as BoundingBox;

        public BoundingBox SmnHistoryDoubleSharp => Load() as BoundingBox;

        public BoundingBox SmnHistoryFlat => Load() as BoundingBox;

        public BoundingBox SmnHistorySharp => Load() as BoundingBox;

        public BoundingBox SmnNatural => Load() as BoundingBox;

        public BoundingBox SmnSharp => Load() as BoundingBox;

        public BoundingBox SmnSharpDown => Load() as BoundingBox;

        public BoundingBox SmnSharpWhite => Load() as BoundingBox;

        public BoundingBox SmnSharpWhiteDown => Load() as BoundingBox;

        public BoundingBox SplitBarDivider => Load() as BoundingBox;

        public BoundingBox Staff1Line => Load() as BoundingBox;

        public BoundingBox Staff1LineNarrow => Load() as BoundingBox;

        public BoundingBox Staff1LineWide => Load() as BoundingBox;

        public BoundingBox Staff2Lines => Load() as BoundingBox;

        public BoundingBox Staff2LinesNarrow => Load() as BoundingBox;

        public BoundingBox Staff2LinesWide => Load() as BoundingBox;

        public BoundingBox Staff3Lines => Load() as BoundingBox;

        public BoundingBox Staff3LinesNarrow => Load() as BoundingBox;

        public BoundingBox Staff3LinesWide => Load() as BoundingBox;

        public BoundingBox Staff4Lines => Load() as BoundingBox;

        public BoundingBox Staff4LinesNarrow => Load() as BoundingBox;

        public BoundingBox Staff4LinesWide => Load() as BoundingBox;

        public BoundingBox Staff5Lines => Load() as BoundingBox;

        public BoundingBox Staff5LinesNarrow => Load() as BoundingBox;

        public BoundingBox Staff5LinesWide => Load() as BoundingBox;

        public BoundingBox Staff6Lines => Load() as BoundingBox;

        public BoundingBox Staff6LinesNarrow => Load() as BoundingBox;

        public BoundingBox Staff6LinesWide => Load() as BoundingBox;

        public BoundingBox StaffDivideArrowDown => Load() as BoundingBox;

        public BoundingBox StaffDivideArrowUp => Load() as BoundingBox;

        public BoundingBox StaffDivideArrowUpDown => Load() as BoundingBox;

        public BoundingBox Stem => Load() as BoundingBox;

        public BoundingBox StemBowOnBridge => Load() as BoundingBox;

        public BoundingBox StemBowOnTailpiece => Load() as BoundingBox;

        public BoundingBox StemBuzzRoll => Load() as BoundingBox;

        public BoundingBox StemDamp => Load() as BoundingBox;

        public BoundingBox StemHarpStringNoise => Load() as BoundingBox;

        public BoundingBox StemMultiphonicsBlack => Load() as BoundingBox;

        public BoundingBox StemMultiphonicsBlackWhite => Load() as BoundingBox;

        public BoundingBox StemMultiphonicsWhite => Load() as BoundingBox;

        public BoundingBox StemPendereckiTremolo => Load() as BoundingBox;

        public BoundingBox StemRimShot => Load() as BoundingBox;

        public BoundingBox StemSprechgesang => Load() as BoundingBox;

        public BoundingBox StemSulPonticello => Load() as BoundingBox;

        public BoundingBox StemSussurando => Load() as BoundingBox;

        public BoundingBox StemSwished => Load() as BoundingBox;

        public BoundingBox StemVibratoPulse => Load() as BoundingBox;

        public BoundingBox StockhausenTremolo => Load() as BoundingBox;

        public BoundingBox StringsBowBehindBridge => Load() as BoundingBox;

        public BoundingBox StringsBowBehindBridgeFourStrings => Load() as BoundingBox;

        public BoundingBox StringsBowBehindBridgeOneString => Load() as BoundingBox;

        public BoundingBox StringsBowBehindBridgeThreeStrings => Load() as BoundingBox;

        public BoundingBox StringsBowBehindBridgeTwoStrings => Load() as BoundingBox;

        public BoundingBox StringsBowOnBridge => Load() as BoundingBox;

        public BoundingBox StringsBowOnTailpiece => Load() as BoundingBox;

        public BoundingBox StringsChangeBowDirection => Load() as BoundingBox;

        public BoundingBox StringsChangeBowDirectionImposed => Load() as BoundingBox;

        public BoundingBox StringsChangeBowDirectionLiga => Load() as BoundingBox;

        public BoundingBox StringsDownBow => Load() as BoundingBox;

        public BoundingBox StringsDownBowTurned => Load() as BoundingBox;

        public BoundingBox StringsFouette => Load() as BoundingBox;

        public BoundingBox StringsHalfHarmonic => Load() as BoundingBox;

        public BoundingBox StringsHarmonic => Load() as BoundingBox;

        public BoundingBox StringsJeteAbove => Load() as BoundingBox;

        public BoundingBox StringsJeteBelow => Load() as BoundingBox;

        public BoundingBox StringsMuteOff => Load() as BoundingBox;

        public BoundingBox StringsMuteOn => Load() as BoundingBox;

        public BoundingBox StringsOverpressureDownBow => Load() as BoundingBox;

        public BoundingBox StringsOverpressureNoDirection => Load() as BoundingBox;

        public BoundingBox StringsOverpressurePossibileDownBow => Load() as BoundingBox;

        public BoundingBox StringsOverpressurePossibileUpBow => Load() as BoundingBox;

        public BoundingBox StringsOverpressureUpBow => Load() as BoundingBox;

        public BoundingBox StringsThumbPosition => Load() as BoundingBox;

        public BoundingBox StringsThumbPositionTurned => Load() as BoundingBox;

        public BoundingBox StringsUpBow => Load() as BoundingBox;

        public BoundingBox StringsUpBowTurned => Load() as BoundingBox;

        public BoundingBox StringsVibratoPulse => Load() as BoundingBox;

        public BoundingBox SystemDivider => Load() as BoundingBox;

        public BoundingBox SystemDividerExtraLong => Load() as BoundingBox;

        public BoundingBox SystemDividerLong => Load() as BoundingBox;

        public BoundingBox TextAugmentationDot => Load() as BoundingBox;

        public BoundingBox TextBlackNoteFrac16ThLongStem => Load() as BoundingBox;

        public BoundingBox TextBlackNoteFrac16ThShortStem => Load() as BoundingBox;

        public BoundingBox TextBlackNoteFrac32NdLongStem => Load() as BoundingBox;

        public BoundingBox TextBlackNoteFrac8ThLongStem => Load() as BoundingBox;

        public BoundingBox TextBlackNoteFrac8ThShortStem => Load() as BoundingBox;

        public BoundingBox TextBlackNoteLongStem => Load() as BoundingBox;

        public BoundingBox TextBlackNoteShortStem => Load() as BoundingBox;

        public BoundingBox TextCont16ThBeamLongStem => Load() as BoundingBox;

        public BoundingBox TextCont16ThBeamShortStem => Load() as BoundingBox;

        public BoundingBox TextCont32NdBeamLongStem => Load() as BoundingBox;

        public BoundingBox TextCont8ThBeamLongStem => Load() as BoundingBox;

        public BoundingBox TextCont8ThBeamShortStem => Load() as BoundingBox;

        public BoundingBox TextTie => Load() as BoundingBox;

        public BoundingBox TextTuplet3LongStem => Load() as BoundingBox;

        public BoundingBox TextTuplet3ShortStem => Load() as BoundingBox;

        public BoundingBox TextTupletBracketEndLongStem => Load() as BoundingBox;

        public BoundingBox TextTupletBracketEndShortStem => Load() as BoundingBox;

        public BoundingBox TextTupletBracketStartLongStem => Load() as BoundingBox;

        public BoundingBox TextTupletBracketStartShortStem => Load() as BoundingBox;

        public BoundingBox TimeSig0 => Load() as BoundingBox;

        public BoundingBox TimeSig0Denominator => Load() as BoundingBox;

        public BoundingBox TimeSig0Large => Load() as BoundingBox;

        public BoundingBox TimeSig0Numerator => Load() as BoundingBox;

        public BoundingBox TimeSig0Reversed => Load() as BoundingBox;

        public BoundingBox TimeSig0Small => Load() as BoundingBox;

        public BoundingBox TimeSig0Turned => Load() as BoundingBox;

        public BoundingBox TimeSig1 => Load() as BoundingBox;

        public BoundingBox TimeSig12Over8 => Load() as BoundingBox;

        public BoundingBox TimeSig1Denominator => Load() as BoundingBox;

        public BoundingBox TimeSig1Large => Load() as BoundingBox;

        public BoundingBox TimeSig1Numerator => Load() as BoundingBox;

        public BoundingBox TimeSig1Reversed => Load() as BoundingBox;

        public BoundingBox TimeSig1Small => Load() as BoundingBox;

        public BoundingBox TimeSig1Turned => Load() as BoundingBox;

        public BoundingBox TimeSig2 => Load() as BoundingBox;

        public BoundingBox TimeSig2Denominator => Load() as BoundingBox;

        public BoundingBox TimeSig2Large => Load() as BoundingBox;

        public BoundingBox TimeSig2Numerator => Load() as BoundingBox;

        public BoundingBox TimeSig2Reversed => Load() as BoundingBox;

        public BoundingBox TimeSig2Small => Load() as BoundingBox;

        public BoundingBox TimeSig2Turned => Load() as BoundingBox;

        public BoundingBox TimeSig2Over2 => Load() as BoundingBox;

        public BoundingBox TimeSig2Over4 => Load() as BoundingBox;

        public BoundingBox TimeSig3 => Load() as BoundingBox;

        public BoundingBox TimeSig3Denominator => Load() as BoundingBox;

        public BoundingBox TimeSig3Large => Load() as BoundingBox;

        public BoundingBox TimeSig3Numerator => Load() as BoundingBox;

        public BoundingBox TimeSig3Reversed => Load() as BoundingBox;

        public BoundingBox TimeSig3Small => Load() as BoundingBox;

        public BoundingBox TimeSig3Turned => Load() as BoundingBox;

        public BoundingBox TimeSig3Over2 => Load() as BoundingBox;

        public BoundingBox TimeSig3Over4 => Load() as BoundingBox;

        public BoundingBox TimeSig3Over8 => Load() as BoundingBox;

        public BoundingBox TimeSig4 => Load() as BoundingBox;

        public BoundingBox TimeSig4Denominator => Load() as BoundingBox;

        public BoundingBox TimeSig4Large => Load() as BoundingBox;

        public BoundingBox TimeSig4Numerator => Load() as BoundingBox;

        public BoundingBox TimeSig4Reversed => Load() as BoundingBox;

        public BoundingBox TimeSig4Small => Load() as BoundingBox;

        public BoundingBox TimeSig4Turned => Load() as BoundingBox;

        public BoundingBox TimeSig4Over4 => Load() as BoundingBox;

        public BoundingBox TimeSig5 => Load() as BoundingBox;

        public BoundingBox TimeSig5Denominator => Load() as BoundingBox;

        public BoundingBox TimeSig5Large => Load() as BoundingBox;

        public BoundingBox TimeSig5Numerator => Load() as BoundingBox;

        public BoundingBox TimeSig5Reversed => Load() as BoundingBox;

        public BoundingBox TimeSig5Small => Load() as BoundingBox;

        public BoundingBox TimeSig5Turned => Load() as BoundingBox;

        public BoundingBox TimeSig5Over4 => Load() as BoundingBox;

        public BoundingBox TimeSig5Over8 => Load() as BoundingBox;

        public BoundingBox TimeSig6 => Load() as BoundingBox;

        public BoundingBox TimeSig6Denominator => Load() as BoundingBox;

        public BoundingBox TimeSig6Large => Load() as BoundingBox;

        public BoundingBox TimeSig6Numerator => Load() as BoundingBox;

        public BoundingBox TimeSig6Reversed => Load() as BoundingBox;

        public BoundingBox TimeSig6Small => Load() as BoundingBox;

        public BoundingBox TimeSig6Turned => Load() as BoundingBox;

        public BoundingBox TimeSig6Over4 => Load() as BoundingBox;

        public BoundingBox TimeSig6Over8 => Load() as BoundingBox;

        public BoundingBox TimeSig7 => Load() as BoundingBox;

        public BoundingBox TimeSig7Denominator => Load() as BoundingBox;

        public BoundingBox TimeSig7Large => Load() as BoundingBox;

        public BoundingBox TimeSig7Numerator => Load() as BoundingBox;

        public BoundingBox TimeSig7Reversed => Load() as BoundingBox;

        public BoundingBox TimeSig7Small => Load() as BoundingBox;

        public BoundingBox TimeSig7Turned => Load() as BoundingBox;

        public BoundingBox TimeSig7Over8 => Load() as BoundingBox;

        public BoundingBox TimeSig8 => Load() as BoundingBox;

        public BoundingBox TimeSig8Denominator => Load() as BoundingBox;

        public BoundingBox TimeSig8Large => Load() as BoundingBox;

        public BoundingBox TimeSig8Numerator => Load() as BoundingBox;

        public BoundingBox TimeSig8Reversed => Load() as BoundingBox;

        public BoundingBox TimeSig8Small => Load() as BoundingBox;

        public BoundingBox TimeSig8Turned => Load() as BoundingBox;

        public BoundingBox TimeSig9 => Load() as BoundingBox;

        public BoundingBox TimeSig9Large => Load() as BoundingBox;

        public BoundingBox TimeSig9Reversed => Load() as BoundingBox;

        public BoundingBox TimeSig9Small => Load() as BoundingBox;

        public BoundingBox TimeSig9Turned => Load() as BoundingBox;

        public BoundingBox TimeSig9Over8 => Load() as BoundingBox;

        public BoundingBox TimeSigBracketLeft => Load() as BoundingBox;

        public BoundingBox TimeSigBracketLeftSmall => Load() as BoundingBox;

        public BoundingBox TimeSigBracketRight => Load() as BoundingBox;

        public BoundingBox TimeSigBracketRightSmall => Load() as BoundingBox;

        public BoundingBox TimeSigComma => Load() as BoundingBox;

        public BoundingBox TimeSigCommon => Load() as BoundingBox;

        public BoundingBox TimeSigCommonLarge => Load() as BoundingBox;

        public BoundingBox TimeSigCommonReversed => Load() as BoundingBox;

        public BoundingBox TimeSigCommonTurned => Load() as BoundingBox;

        public BoundingBox TimeSigCut2 => Load() as BoundingBox;

        public BoundingBox TimeSigCut3 => Load() as BoundingBox;

        public BoundingBox TimeSigCutCommon => Load() as BoundingBox;

        public BoundingBox TimeSigCutCommonLarge => Load() as BoundingBox;

        public BoundingBox TimeSigCutCommonReversed => Load() as BoundingBox;

        public BoundingBox TimeSigCutCommonTurned => Load() as BoundingBox;

        public BoundingBox TimeSigEquals => Load() as BoundingBox;

        public BoundingBox TimeSigFractionHalf => Load() as BoundingBox;

        public BoundingBox TimeSigFractionOneThird => Load() as BoundingBox;

        public BoundingBox TimeSigFractionQuarter => Load() as BoundingBox;

        public BoundingBox TimeSigFractionThreeQuarters => Load() as BoundingBox;

        public BoundingBox TimeSigFractionTwoThirds => Load() as BoundingBox;

        public BoundingBox TimeSigFractionalSlash => Load() as BoundingBox;

        public BoundingBox TimeSigMinus => Load() as BoundingBox;

        public BoundingBox TimeSigMultiply => Load() as BoundingBox;

        public BoundingBox TimeSigOpenPenderecki => Load() as BoundingBox;

        public BoundingBox TimeSigParensLeft => Load() as BoundingBox;

        public BoundingBox TimeSigParensLeftSmall => Load() as BoundingBox;

        public BoundingBox TimeSigParensRight => Load() as BoundingBox;

        public BoundingBox TimeSigParensRightSmall => Load() as BoundingBox;

        public BoundingBox TimeSigPlus => Load() as BoundingBox;

        public BoundingBox TimeSigPlusLarge => Load() as BoundingBox;

        public BoundingBox TimeSigPlusSmall => Load() as BoundingBox;

        public BoundingBox TimeSigSlash => Load() as BoundingBox;

        public BoundingBox TimeSigX => Load() as BoundingBox;

        public BoundingBox Tremolo1 => Load() as BoundingBox;

        public BoundingBox Tremolo2 => Load() as BoundingBox;

        public BoundingBox Tremolo3 => Load() as BoundingBox;

        public BoundingBox Tremolo4 => Load() as BoundingBox;

        public BoundingBox Tremolo5 => Load() as BoundingBox;

        public BoundingBox TremoloDivisiDots2 => Load() as BoundingBox;

        public BoundingBox TremoloDivisiDots3 => Load() as BoundingBox;

        public BoundingBox TremoloDivisiDots4 => Load() as BoundingBox;

        public BoundingBox TremoloDivisiDots6 => Load() as BoundingBox;

        public BoundingBox TremoloFingered1 => Load() as BoundingBox;

        public BoundingBox TremoloFingered2 => Load() as BoundingBox;

        public BoundingBox TremoloFingered3 => Load() as BoundingBox;

        public BoundingBox TremoloFingered4 => Load() as BoundingBox;

        public BoundingBox TremoloFingered5 => Load() as BoundingBox;

        public BoundingBox TripleTongueAbove => Load() as BoundingBox;

        public BoundingBox TripleTongueAboveNoSlur => Load() as BoundingBox;

        public BoundingBox TripleTongueBelow => Load() as BoundingBox;

        public BoundingBox TripleTongueBelowNoSlur => Load() as BoundingBox;

        public BoundingBox Tuplet0 => Load() as BoundingBox;

        public BoundingBox Tuplet1 => Load() as BoundingBox;

        public BoundingBox Tuplet2 => Load() as BoundingBox;

        public BoundingBox Tuplet3 => Load() as BoundingBox;

        public BoundingBox Tuplet4 => Load() as BoundingBox;

        public BoundingBox Tuplet5 => Load() as BoundingBox;

        public BoundingBox Tuplet6 => Load() as BoundingBox;

        public BoundingBox Tuplet7 => Load() as BoundingBox;

        public BoundingBox Tuplet8 => Load() as BoundingBox;

        public BoundingBox Tuplet9 => Load() as BoundingBox;

        public BoundingBox TupletColon => Load() as BoundingBox;

        public BoundingBox UnmeasuredTremolo => Load() as BoundingBox;

        public BoundingBox UnmeasuredTremoloSimple => Load() as BoundingBox;

        public BoundingBox UnpitchedPercussionClef1 => Load() as BoundingBox;

        public BoundingBox UnpitchedPercussionClef1Alt => Load() as BoundingBox;

        public BoundingBox UnpitchedPercussionClef2 => Load() as BoundingBox;

        public BoundingBox Ventiduesima => Load() as BoundingBox;

        public BoundingBox VentiduesimaAlta => Load() as BoundingBox;

        public BoundingBox VentiduesimaBassa => Load() as BoundingBox;

        public BoundingBox VentiduesimaBassaMb => Load() as BoundingBox;

        public BoundingBox Ventiquattresima => Load() as BoundingBox;

        public BoundingBox VentiquattresimaAlta => Load() as BoundingBox;

        public BoundingBox VentiquattresimaBassa => Load() as BoundingBox;

        public BoundingBox VentiquattresimaBassaMb => Load() as BoundingBox;

        public BoundingBox VocalFingerClickStockhausen => Load() as BoundingBox;

        public BoundingBox VocalMouthClosed => Load() as BoundingBox;

        public BoundingBox VocalMouthOpen => Load() as BoundingBox;

        public BoundingBox VocalMouthPursed => Load() as BoundingBox;

        public BoundingBox VocalMouthSlightlyOpen => Load() as BoundingBox;

        public BoundingBox VocalMouthWideOpen => Load() as BoundingBox;

        public BoundingBox VocalNasalVoice => Load() as BoundingBox;

        public BoundingBox VocalSprechgesang => Load() as BoundingBox;

        public BoundingBox VocalTongueClickStockhausen => Load() as BoundingBox;

        public BoundingBox VocalTongueFingerClickStockhausen => Load() as BoundingBox;

        public BoundingBox VocalsSussurando => Load() as BoundingBox;

        public BoundingBox WiggleArpeggiatoDown => Load() as BoundingBox;

        public BoundingBox WiggleArpeggiatoDownArrow => Load() as BoundingBox;

        public BoundingBox WiggleArpeggiatoDownSwash => Load() as BoundingBox;

        public BoundingBox WiggleArpeggiatoDownSwashCouperin => Load() as BoundingBox;

        public BoundingBox WiggleArpeggiatoUp => Load() as BoundingBox;

        public BoundingBox WiggleArpeggiatoUpArrow => Load() as BoundingBox;

        public BoundingBox WiggleArpeggiatoUpSwash => Load() as BoundingBox;

        public BoundingBox WiggleArpeggiatoUpSwashCouperin => Load() as BoundingBox;

        public BoundingBox WiggleCircular => Load() as BoundingBox;

        public BoundingBox WiggleCircularConstant => Load() as BoundingBox;

        public BoundingBox WiggleCircularConstantFlipped => Load() as BoundingBox;

        public BoundingBox WiggleCircularConstantFlippedLarge => Load() as BoundingBox;

        public BoundingBox WiggleCircularConstantLarge => Load() as BoundingBox;

        public BoundingBox WiggleCircularEnd => Load() as BoundingBox;

        public BoundingBox WiggleCircularLarge => Load() as BoundingBox;

        public BoundingBox WiggleCircularLarger => Load() as BoundingBox;

        public BoundingBox WiggleCircularLargerStill => Load() as BoundingBox;

        public BoundingBox WiggleCircularLargest => Load() as BoundingBox;

        public BoundingBox WiggleCircularSmall => Load() as BoundingBox;

        public BoundingBox WiggleCircularStart => Load() as BoundingBox;

        public BoundingBox WiggleGlissando => Load() as BoundingBox;

        public BoundingBox WiggleGlissandoGroup1 => Load() as BoundingBox;

        public BoundingBox WiggleGlissandoGroup2 => Load() as BoundingBox;

        public BoundingBox WiggleGlissandoGroup3 => Load() as BoundingBox;

        public BoundingBox WiggleRandom1 => Load() as BoundingBox;

        public BoundingBox WiggleRandom2 => Load() as BoundingBox;

        public BoundingBox WiggleRandom3 => Load() as BoundingBox;

        public BoundingBox WiggleRandom4 => Load() as BoundingBox;

        public BoundingBox WiggleSawtooth => Load() as BoundingBox;

        public BoundingBox WiggleSawtoothNarrow => Load() as BoundingBox;

        public BoundingBox WiggleSawtoothWide => Load() as BoundingBox;

        public BoundingBox WiggleSquareWave => Load() as BoundingBox;

        public BoundingBox WiggleSquareWaveNarrow => Load() as BoundingBox;

        public BoundingBox WiggleSquareWaveWide => Load() as BoundingBox;

        public BoundingBox WiggleTrill => Load() as BoundingBox;

        public BoundingBox WiggleTrillFast => Load() as BoundingBox;

        public BoundingBox WiggleTrillFaster => Load() as BoundingBox;

        public BoundingBox WiggleTrillFasterStill => Load() as BoundingBox;

        public BoundingBox WiggleTrillFastest => Load() as BoundingBox;

        public BoundingBox WiggleTrillSlow => Load() as BoundingBox;

        public BoundingBox WiggleTrillSlower => Load() as BoundingBox;

        public BoundingBox WiggleTrillSlowerStill => Load() as BoundingBox;

        public BoundingBox WiggleTrillSlowest => Load() as BoundingBox;

        public BoundingBox WiggleVIbratoLargestSlower => Load() as BoundingBox;

        public BoundingBox WiggleVIbratoMediumSlower => Load() as BoundingBox;

        public BoundingBox WiggleVibrato => Load() as BoundingBox;

        public BoundingBox WiggleVibratoLargeFast => Load() as BoundingBox;

        public BoundingBox WiggleVibratoLargeFaster => Load() as BoundingBox;

        public BoundingBox WiggleVibratoLargeFasterStill => Load() as BoundingBox;

        public BoundingBox WiggleVibratoLargeFastest => Load() as BoundingBox;

        public BoundingBox WiggleVibratoLargeSlow => Load() as BoundingBox;

        public BoundingBox WiggleVibratoLargeSlower => Load() as BoundingBox;

        public BoundingBox WiggleVibratoLargeSlowest => Load() as BoundingBox;

        public BoundingBox WiggleVibratoLargestFast => Load() as BoundingBox;

        public BoundingBox WiggleVibratoLargestFaster => Load() as BoundingBox;

        public BoundingBox WiggleVibratoLargestFasterStill => Load() as BoundingBox;

        public BoundingBox WiggleVibratoLargestFastest => Load() as BoundingBox;

        public BoundingBox WiggleVibratoLargestSlow => Load() as BoundingBox;

        public BoundingBox WiggleVibratoLargestSlowest => Load() as BoundingBox;

        public BoundingBox WiggleVibratoMediumFast => Load() as BoundingBox;

        public BoundingBox WiggleVibratoMediumFaster => Load() as BoundingBox;

        public BoundingBox WiggleVibratoMediumFasterStill => Load() as BoundingBox;

        public BoundingBox WiggleVibratoMediumFastest => Load() as BoundingBox;

        public BoundingBox WiggleVibratoMediumSlow => Load() as BoundingBox;

        public BoundingBox WiggleVibratoMediumSlowest => Load() as BoundingBox;

        public BoundingBox WiggleVibratoSmallFast => Load() as BoundingBox;

        public BoundingBox WiggleVibratoSmallFaster => Load() as BoundingBox;

        public BoundingBox WiggleVibratoSmallFasterStill => Load() as BoundingBox;

        public BoundingBox WiggleVibratoSmallFastest => Load() as BoundingBox;

        public BoundingBox WiggleVibratoSmallSlow => Load() as BoundingBox;

        public BoundingBox WiggleVibratoSmallSlower => Load() as BoundingBox;

        public BoundingBox WiggleVibratoSmallSlowest => Load() as BoundingBox;

        public BoundingBox WiggleVibratoSmallestFast => Load() as BoundingBox;

        public BoundingBox WiggleVibratoSmallestFaster => Load() as BoundingBox;

        public BoundingBox WiggleVibratoSmallestFasterStill => Load() as BoundingBox;

        public BoundingBox WiggleVibratoSmallestFastest => Load() as BoundingBox;

        public BoundingBox WiggleVibratoSmallestSlow => Load() as BoundingBox;

        public BoundingBox WiggleVibratoSmallestSlower => Load() as BoundingBox;

        public BoundingBox WiggleVibratoSmallestSlowest => Load() as BoundingBox;

        public BoundingBox WiggleVibratoStart => Load() as BoundingBox;

        public BoundingBox WiggleVibratoWide => Load() as BoundingBox;

        public BoundingBox WiggleWavy => Load() as BoundingBox;

        public BoundingBox WiggleWavyNarrow => Load() as BoundingBox;

        public BoundingBox WiggleWavyWide => Load() as BoundingBox;

        public BoundingBox WindClosedHole => Load() as BoundingBox;

        public BoundingBox WindFlatEmbouchure => Load() as BoundingBox;

        public BoundingBox WindHalfClosedHole1 => Load() as BoundingBox;

        public BoundingBox WindHalfClosedHole2 => Load() as BoundingBox;

        public BoundingBox WindHalfClosedHole3 => Load() as BoundingBox;

        public BoundingBox WindLessRelaxedEmbouchure => Load() as BoundingBox;

        public BoundingBox WindLessTightEmbouchure => Load() as BoundingBox;

        public BoundingBox WindMouthpiecePop => Load() as BoundingBox;

        public BoundingBox WindMultiphonicsBlackStem => Load() as BoundingBox;

        public BoundingBox WindMultiphonicsBlackWhiteStem => Load() as BoundingBox;

        public BoundingBox WindMultiphonicsWhiteStem => Load() as BoundingBox;

        public BoundingBox WindOpenHole => Load() as BoundingBox;

        public BoundingBox WindReedPositionIn => Load() as BoundingBox;

        public BoundingBox WindReedPositionNormal => Load() as BoundingBox;

        public BoundingBox WindReedPositionOut => Load() as BoundingBox;

        public BoundingBox WindRelaxedEmbouchure => Load() as BoundingBox;

        public BoundingBox WindRimOnly => Load() as BoundingBox;

        public BoundingBox WindSharpEmbouchure => Load() as BoundingBox;

        public BoundingBox WindStrongAirPressure => Load() as BoundingBox;

        public BoundingBox WindThreeQuartersClosedHole => Load() as BoundingBox;

        public BoundingBox WindTightEmbouchure => Load() as BoundingBox;

        public BoundingBox WindTrillKey => Load() as BoundingBox;

        public BoundingBox WindVeryTightEmbouchure => Load() as BoundingBox;

        public BoundingBox WindWeakAirPressure => Load() as BoundingBox;
    }
}
