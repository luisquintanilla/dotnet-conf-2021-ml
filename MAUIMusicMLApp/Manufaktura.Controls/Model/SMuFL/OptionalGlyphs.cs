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

using System.Runtime.Serialization;

namespace Manufaktura.Controls.Model.SMuFL
{
    public partial class OptionalGlyphs
    {
        [DataMember(Name="4stringTabClefSerif")]
        public The4StringTabClefSerif The4StringTabClefSerif { get; set; }

        [DataMember(Name="4stringTabClefTall")]
        public The4StringTabClefSerif The4StringTabClefTall { get; set; }

        [DataMember(Name="6stringTabClefSerif")]
        public The4StringTabClefSerif The6StringTabClefSerif { get; set; }

        [DataMember(Name="6stringTabClefTall")]
        public The4StringTabClefSerif The6StringTabClefTall { get; set; }

        [DataMember(Name="accdnPushAlt")]
        public The4StringTabClefSerif AccdnPushAlt { get; set; }

        [DataMember(Name="accidentalDoubleFlatJoinedStems")]
        public The4StringTabClefSerif AccidentalDoubleFlatJoinedStems { get; set; }

        [DataMember(Name="accidentalDoubleFlatParens")]
        public AccidentalDoubleFlatParens AccidentalDoubleFlatParens { get; set; }

        [DataMember(Name="accidentalDoubleSharpParens")]
        public AccidentalDoubleFlatParens AccidentalDoubleSharpParens { get; set; }

        [DataMember(Name="accidentalFlatJohnstonDown")]
        public AccidentalDoubleFlatParens AccidentalFlatJohnstonDown { get; set; }

        [DataMember(Name="accidentalFlatJohnstonEl")]
        public AccidentalDoubleFlatParens AccidentalFlatJohnstonEl { get; set; }

        [DataMember(Name="accidentalFlatJohnstonElDown")]
        public AccidentalDoubleFlatParens AccidentalFlatJohnstonElDown { get; set; }

        [DataMember(Name="accidentalFlatJohnstonUp")]
        public AccidentalDoubleFlatParens AccidentalFlatJohnstonUp { get; set; }

        [DataMember(Name="accidentalFlatJohnstonUpEl")]
        public AccidentalDoubleFlatParens AccidentalFlatJohnstonUpEl { get; set; }

        [DataMember(Name="accidentalFlatParens")]
        public AccidentalDoubleFlatParens AccidentalFlatParens { get; set; }

        [DataMember(Name="accidentalFlatSmall")]
        public The4StringTabClefSerif AccidentalFlatSmall { get; set; }

        [DataMember(Name="accidentalJohnstonDownEl")]
        public AccidentalDoubleFlatParens AccidentalJohnstonDownEl { get; set; }

        [DataMember(Name="accidentalJohnstonSevenDown")]
        public AccidentalDoubleFlatParens AccidentalJohnstonSevenDown { get; set; }

        [DataMember(Name="accidentalJohnstonSevenFlat")]
        public AccidentalDoubleFlatParens AccidentalJohnstonSevenFlat { get; set; }

        [DataMember(Name="accidentalJohnstonSevenFlatDown")]
        public AccidentalDoubleFlatParens AccidentalJohnstonSevenFlatDown { get; set; }

        [DataMember(Name="accidentalJohnstonSevenFlatUp")]
        public AccidentalDoubleFlatParens AccidentalJohnstonSevenFlatUp { get; set; }

        [DataMember(Name="accidentalJohnstonSevenSharp")]
        public AccidentalDoubleFlatParens AccidentalJohnstonSevenSharp { get; set; }

        [DataMember(Name="accidentalJohnstonSevenSharpDown")]
        public AccidentalDoubleFlatParens AccidentalJohnstonSevenSharpDown { get; set; }

        [DataMember(Name="accidentalJohnstonSevenSharpUp")]
        public AccidentalDoubleFlatParens AccidentalJohnstonSevenSharpUp { get; set; }

        [DataMember(Name="accidentalJohnstonSevenUp")]
        public AccidentalDoubleFlatParens AccidentalJohnstonSevenUp { get; set; }

        [DataMember(Name="accidentalJohnstonUpEl")]
        public AccidentalDoubleFlatParens AccidentalJohnstonUpEl { get; set; }

        [DataMember(Name="accidentalNaturalParens")]
        public AccidentalDoubleFlatParens AccidentalNaturalParens { get; set; }

        [DataMember(Name="accidentalNaturalSmall")]
        public The4StringTabClefSerif AccidentalNaturalSmall { get; set; }

        [DataMember(Name="accidentalSharpJohnstonDown")]
        public AccidentalDoubleFlatParens AccidentalSharpJohnstonDown { get; set; }

        [DataMember(Name="accidentalSharpJohnstonDownEl")]
        public AccidentalDoubleFlatParens AccidentalSharpJohnstonDownEl { get; set; }

        [DataMember(Name="accidentalSharpJohnstonEl")]
        public AccidentalDoubleFlatParens AccidentalSharpJohnstonEl { get; set; }

        [DataMember(Name="accidentalSharpJohnstonUp")]
        public AccidentalDoubleFlatParens AccidentalSharpJohnstonUp { get; set; }

        [DataMember(Name="accidentalSharpJohnstonUpEl")]
        public AccidentalDoubleFlatParens AccidentalSharpJohnstonUpEl { get; set; }

        [DataMember(Name="accidentalSharpParens")]
        public AccidentalDoubleFlatParens AccidentalSharpParens { get; set; }

        [DataMember(Name="accidentalSharpSmall")]
        public The4StringTabClefSerif AccidentalSharpSmall { get; set; }

        [DataMember(Name="accidentalTripleFlatJoinedStems")]
        public The4StringTabClefSerif AccidentalTripleFlatJoinedStems { get; set; }

        [DataMember(Name="analyticsHauptrhythmusR")]
        public The4StringTabClefSerif AnalyticsHauptrhythmusR { get; set; }

        [DataMember(Name="articAccentAboveLarge")]
        public The4StringTabClefSerif ArticAccentAboveLarge { get; set; }

        [DataMember(Name="articAccentAboveSmall")]
        public The4StringTabClefSerif ArticAccentAboveSmall { get; set; }

        [DataMember(Name="articAccentBelowLarge")]
        public The4StringTabClefSerif ArticAccentBelowLarge { get; set; }

        [DataMember(Name="articAccentBelowSmall")]
        public The4StringTabClefSerif ArticAccentBelowSmall { get; set; }

        [DataMember(Name="articAccentStaccatoAboveSmall")]
        public The4StringTabClefSerif ArticAccentStaccatoAboveSmall { get; set; }

        [DataMember(Name="articAccentStaccatoBelowSmall")]
        public The4StringTabClefSerif ArticAccentStaccatoBelowSmall { get; set; }

        [DataMember(Name="articMarcatoAboveSmall")]
        public The4StringTabClefSerif ArticMarcatoAboveSmall { get; set; }

        [DataMember(Name="articMarcatoBelowSmall")]
        public The4StringTabClefSerif ArticMarcatoBelowSmall { get; set; }

        [DataMember(Name="articMarcatoStaccatoAboveSmall")]
        public The4StringTabClefSerif ArticMarcatoStaccatoAboveSmall { get; set; }

        [DataMember(Name="articMarcatoStaccatoBelowSmall")]
        public The4StringTabClefSerif ArticMarcatoStaccatoBelowSmall { get; set; }

        [DataMember(Name="articStaccatissimoAboveSmall")]
        public The4StringTabClefSerif ArticStaccatissimoAboveSmall { get; set; }

        [DataMember(Name="articStaccatissimoBelowSmall")]
        public The4StringTabClefSerif ArticStaccatissimoBelowSmall { get; set; }

        [DataMember(Name="articStaccatissimoStrokeAboveSmall")]
        public The4StringTabClefSerif ArticStaccatissimoStrokeAboveSmall { get; set; }

        [DataMember(Name="articStaccatissimoStrokeBelowSmall")]
        public The4StringTabClefSerif ArticStaccatissimoStrokeBelowSmall { get; set; }

        [DataMember(Name="articStaccatissimoWedgeAboveSmall")]
        public The4StringTabClefSerif ArticStaccatissimoWedgeAboveSmall { get; set; }

        [DataMember(Name="articStaccatissimoWedgeBelowSmall")]
        public The4StringTabClefSerif ArticStaccatissimoWedgeBelowSmall { get; set; }

        [DataMember(Name="articStaccatoAboveSmall")]
        public The4StringTabClefSerif ArticStaccatoAboveSmall { get; set; }

        [DataMember(Name="articStaccatoBelowSmall")]
        public The4StringTabClefSerif ArticStaccatoBelowSmall { get; set; }

        [DataMember(Name="articTenutoAboveSmall")]
        public The4StringTabClefSerif ArticTenutoAboveSmall { get; set; }

        [DataMember(Name="articTenutoAccentAboveSmall")]
        public The4StringTabClefSerif ArticTenutoAccentAboveSmall { get; set; }

        [DataMember(Name="articTenutoAccentBelowSmall")]
        public The4StringTabClefSerif ArticTenutoAccentBelowSmall { get; set; }

        [DataMember(Name="articTenutoBelowSmall")]
        public The4StringTabClefSerif ArticTenutoBelowSmall { get; set; }

        [DataMember(Name="articTenutoStaccatoAboveSmall")]
        public The4StringTabClefSerif ArticTenutoStaccatoAboveSmall { get; set; }

        [DataMember(Name="articTenutoStaccatoBelowSmall")]
        public The4StringTabClefSerif ArticTenutoStaccatoBelowSmall { get; set; }

        [DataMember(Name="braceFlat")]
        public The4StringTabClefSerif BraceFlat { get; set; }

        [DataMember(Name="braceLarge")]
        public The4StringTabClefSerif BraceLarge { get; set; }

        [DataMember(Name="braceLarger")]
        public The4StringTabClefSerif BraceLarger { get; set; }

        [DataMember(Name="braceSmall")]
        public The4StringTabClefSerif BraceSmall { get; set; }

        [DataMember(Name="cClefFrench")]
        public The4StringTabClefSerif CClefFrench { get; set; }

        [DataMember(Name="cClefFrench20C")]
        public The4StringTabClefSerif CClefFrench20C { get; set; }

        [DataMember(Name="cClefFrench20CChange")]
        public The4StringTabClefSerif CClefFrench20CChange { get; set; }

        [DataMember(Name="cClefSmall")]
        public The4StringTabClefSerif CClefSmall { get; set; }

        [DataMember(Name="caesuraSingleStroke")]
        public The4StringTabClefSerif CaesuraSingleStroke { get; set; }

        [DataMember(Name="chantCclefHufnagel")]
        public The4StringTabClefSerif ChantCclefHufnagel { get; set; }

        [DataMember(Name="chantFclefHufnagel")]
        public The4StringTabClefSerif ChantFclefHufnagel { get; set; }

        [DataMember(Name="codaJapanese")]
        public The4StringTabClefSerif CodaJapanese { get; set; }

        [DataMember(Name="doubleTongueAboveNoSlur")]
        public The4StringTabClefSerif DoubleTongueAboveNoSlur { get; set; }

        [DataMember(Name="doubleTongueBelowNoSlur")]
        public The4StringTabClefSerif DoubleTongueBelowNoSlur { get; set; }

        [DataMember(Name="dynamicForteSmall")]
        public The4StringTabClefSerif DynamicForteSmall { get; set; }

        [DataMember(Name="dynamicMezzoSmall")]
        public The4StringTabClefSerif DynamicMezzoSmall { get; set; }

        [DataMember(Name="dynamicNienteSmall")]
        public The4StringTabClefSerif DynamicNienteSmall { get; set; }

        [DataMember(Name="dynamicPianoSmall")]
        public The4StringTabClefSerif DynamicPianoSmall { get; set; }

        [DataMember(Name="dynamicRinforzandoSmall")]
        public The4StringTabClefSerif DynamicRinforzandoSmall { get; set; }

        [DataMember(Name="dynamicSforzandoSmall")]
        public The4StringTabClefSerif DynamicSforzandoSmall { get; set; }

        [DataMember(Name="dynamicZSmall")]
        public The4StringTabClefSerif DynamicZSmall { get; set; }

        [DataMember(Name="fClef19thCentury")]
        public The4StringTabClefSerif FClef19ThCentury { get; set; }

        [DataMember(Name="fClef5Below")]
        public AccidentalDoubleFlatParens FClef5Below { get; set; }

        [DataMember(Name="fClefFrench")]
        public The4StringTabClefSerif FClefFrench { get; set; }

        [DataMember(Name="fClefSmall")]
        public The4StringTabClefSerif FClefSmall { get; set; }

        [DataMember(Name="flag1024thDownSmall")]
        public The4StringTabClefSerif Flag1024ThDownSmall { get; set; }

        [DataMember(Name="flag1024thDownStraight")]
        public The4StringTabClefSerif Flag1024ThDownStraight { get; set; }

        [DataMember(Name="flag1024thUpShort")]
        public The4StringTabClefSerif Flag1024ThUpShort { get; set; }

        [DataMember(Name="flag1024thUpSmall")]
        public The4StringTabClefSerif Flag1024ThUpSmall { get; set; }

        [DataMember(Name="flag1024thUpStraight")]
        public The4StringTabClefSerif Flag1024ThUpStraight { get; set; }

        [DataMember(Name="flag128thDownSmall")]
        public The4StringTabClefSerif Flag128ThDownSmall { get; set; }

        [DataMember(Name="flag128thDownStraight")]
        public The4StringTabClefSerif Flag128ThDownStraight { get; set; }

        [DataMember(Name="flag128thUpShort")]
        public The4StringTabClefSerif Flag128ThUpShort { get; set; }

        [DataMember(Name="flag128thUpSmall")]
        public The4StringTabClefSerif Flag128ThUpSmall { get; set; }

        [DataMember(Name="flag128thUpStraight")]
        public The4StringTabClefSerif Flag128ThUpStraight { get; set; }

        [DataMember(Name="flag16thDownSmall")]
        public The4StringTabClefSerif Flag16ThDownSmall { get; set; }

        [DataMember(Name="flag16thDownStraight")]
        public The4StringTabClefSerif Flag16ThDownStraight { get; set; }

        [DataMember(Name="flag16thUpShort")]
        public The4StringTabClefSerif Flag16ThUpShort { get; set; }

        [DataMember(Name="flag16thUpSmall")]
        public The4StringTabClefSerif Flag16ThUpSmall { get; set; }

        [DataMember(Name="flag16thUpStraight")]
        public The4StringTabClefSerif Flag16ThUpStraight { get; set; }

        [DataMember(Name="flag256thDownSmall")]
        public The4StringTabClefSerif Flag256ThDownSmall { get; set; }

        [DataMember(Name="flag256thDownStraight")]
        public The4StringTabClefSerif Flag256ThDownStraight { get; set; }

        [DataMember(Name="flag256thUpShort")]
        public The4StringTabClefSerif Flag256ThUpShort { get; set; }

        [DataMember(Name="flag256thUpSmall")]
        public The4StringTabClefSerif Flag256ThUpSmall { get; set; }

        [DataMember(Name="flag256thUpStraight")]
        public The4StringTabClefSerif Flag256ThUpStraight { get; set; }

        [DataMember(Name="flag32ndDownSmall")]
        public The4StringTabClefSerif Flag32NdDownSmall { get; set; }

        [DataMember(Name="flag32ndDownStraight")]
        public The4StringTabClefSerif Flag32NdDownStraight { get; set; }

        [DataMember(Name="flag32ndUpShort")]
        public The4StringTabClefSerif Flag32NdUpShort { get; set; }

        [DataMember(Name="flag32ndUpSmall")]
        public The4StringTabClefSerif Flag32NdUpSmall { get; set; }

        [DataMember(Name="flag32ndUpStraight")]
        public The4StringTabClefSerif Flag32NdUpStraight { get; set; }

        [DataMember(Name="flag512thDownSmall")]
        public The4StringTabClefSerif Flag512ThDownSmall { get; set; }

        [DataMember(Name="flag512thDownStraight")]
        public The4StringTabClefSerif Flag512ThDownStraight { get; set; }

        [DataMember(Name="flag512thUpShort")]
        public The4StringTabClefSerif Flag512ThUpShort { get; set; }

        [DataMember(Name="flag512thUpSmall")]
        public The4StringTabClefSerif Flag512ThUpSmall { get; set; }

        [DataMember(Name="flag512thUpStraight")]
        public The4StringTabClefSerif Flag512ThUpStraight { get; set; }

        [DataMember(Name="flag64thDownSmall")]
        public The4StringTabClefSerif Flag64ThDownSmall { get; set; }

        [DataMember(Name="flag64thDownStraight")]
        public The4StringTabClefSerif Flag64ThDownStraight { get; set; }

        [DataMember(Name="flag64thUpShort")]
        public The4StringTabClefSerif Flag64ThUpShort { get; set; }

        [DataMember(Name="flag64thUpSmall")]
        public The4StringTabClefSerif Flag64ThUpSmall { get; set; }

        [DataMember(Name="flag64thUpStraight")]
        public The4StringTabClefSerif Flag64ThUpStraight { get; set; }

        [DataMember(Name="flag8thDownSmall")]
        public The4StringTabClefSerif Flag8ThDownSmall { get; set; }

        [DataMember(Name="flag8thDownStraight")]
        public The4StringTabClefSerif Flag8ThDownStraight { get; set; }

        [DataMember(Name="flag8thUpShort")]
        public The4StringTabClefSerif Flag8ThUpShort { get; set; }

        [DataMember(Name="flag8thUpSmall")]
        public The4StringTabClefSerif Flag8ThUpSmall { get; set; }

        [DataMember(Name="flag8thUpStraight")]
        public The4StringTabClefSerif Flag8ThUpStraight { get; set; }

        [DataMember(Name="gClef0Below")]
        public AccidentalDoubleFlatParens GClef0Below { get; set; }

        [DataMember(Name="gClef10Below")]
        public AccidentalDoubleFlatParens GClef10Below { get; set; }

        [DataMember(Name="gClef11Below")]
        public AccidentalDoubleFlatParens GClef11Below { get; set; }

        [DataMember(Name="gClef12Below")]
        public AccidentalDoubleFlatParens GClef12Below { get; set; }

        [DataMember(Name="gClef13Below")]
        public AccidentalDoubleFlatParens GClef13Below { get; set; }

        [DataMember(Name="gClef14Below")]
        public AccidentalDoubleFlatParens GClef14Below { get; set; }

        [DataMember(Name="gClef15Below")]
        public AccidentalDoubleFlatParens GClef15Below { get; set; }

        [DataMember(Name="gClef16Below")]
        public AccidentalDoubleFlatParens GClef16Below { get; set; }

        [DataMember(Name="gClef17Below")]
        public AccidentalDoubleFlatParens GClef17Below { get; set; }

        [DataMember(Name="gClef2Above")]
        public AccidentalDoubleFlatParens GClef2Above { get; set; }

        [DataMember(Name="gClef2Below")]
        public AccidentalDoubleFlatParens GClef2Below { get; set; }

        [DataMember(Name="gClef3Above")]
        public AccidentalDoubleFlatParens GClef3Above { get; set; }

        [DataMember(Name="gClef3Below")]
        public AccidentalDoubleFlatParens GClef3Below { get; set; }

        [DataMember(Name="gClef4Above")]
        public AccidentalDoubleFlatParens GClef4Above { get; set; }

        [DataMember(Name="gClef4Below")]
        public AccidentalDoubleFlatParens GClef4Below { get; set; }

        [DataMember(Name="gClef5Above")]
        public AccidentalDoubleFlatParens GClef5Above { get; set; }

        [DataMember(Name="gClef5Below")]
        public AccidentalDoubleFlatParens GClef5Below { get; set; }

        [DataMember(Name="gClef6Above")]
        public AccidentalDoubleFlatParens GClef6Above { get; set; }

        [DataMember(Name="gClef6Below")]
        public AccidentalDoubleFlatParens GClef6Below { get; set; }

        [DataMember(Name="gClef7Above")]
        public AccidentalDoubleFlatParens GClef7Above { get; set; }

        [DataMember(Name="gClef7Below")]
        public AccidentalDoubleFlatParens GClef7Below { get; set; }

        [DataMember(Name="gClef8Above")]
        public AccidentalDoubleFlatParens GClef8Above { get; set; }

        [DataMember(Name="gClef8Below")]
        public AccidentalDoubleFlatParens GClef8Below { get; set; }

        [DataMember(Name="gClef9Above")]
        public AccidentalDoubleFlatParens GClef9Above { get; set; }

        [DataMember(Name="gClef9Below")]
        public AccidentalDoubleFlatParens GClef9Below { get; set; }

        [DataMember(Name="gClefFlat10Below")]
        public AccidentalDoubleFlatParens GClefFlat10Below { get; set; }

        [DataMember(Name="gClefFlat11Below")]
        public AccidentalDoubleFlatParens GClefFlat11Below { get; set; }

        [DataMember(Name="gClefFlat13Below")]
        public AccidentalDoubleFlatParens GClefFlat13Below { get; set; }

        [DataMember(Name="gClefFlat14Below")]
        public AccidentalDoubleFlatParens GClefFlat14Below { get; set; }

        [DataMember(Name="gClefFlat15Below")]
        public AccidentalDoubleFlatParens GClefFlat15Below { get; set; }

        [DataMember(Name="gClefFlat16Below")]
        public AccidentalDoubleFlatParens GClefFlat16Below { get; set; }

        [DataMember(Name="gClefFlat1Below")]
        public AccidentalDoubleFlatParens GClefFlat1Below { get; set; }

        [DataMember(Name="gClefFlat2Above")]
        public AccidentalDoubleFlatParens GClefFlat2Above { get; set; }

        [DataMember(Name="gClefFlat2Below")]
        public AccidentalDoubleFlatParens GClefFlat2Below { get; set; }

        [DataMember(Name="gClefFlat3Above")]
        public AccidentalDoubleFlatParens GClefFlat3Above { get; set; }

        [DataMember(Name="gClefFlat3Below")]
        public AccidentalDoubleFlatParens GClefFlat3Below { get; set; }

        [DataMember(Name="gClefFlat4Below")]
        public AccidentalDoubleFlatParens GClefFlat4Below { get; set; }

        [DataMember(Name="gClefFlat5Above")]
        public AccidentalDoubleFlatParens GClefFlat5Above { get; set; }

        [DataMember(Name="gClefFlat6Above")]
        public AccidentalDoubleFlatParens GClefFlat6Above { get; set; }

        [DataMember(Name="gClefFlat6Below")]
        public AccidentalDoubleFlatParens GClefFlat6Below { get; set; }

        [DataMember(Name="gClefFlat7Above")]
        public AccidentalDoubleFlatParens GClefFlat7Above { get; set; }

        [DataMember(Name="gClefFlat7Below")]
        public AccidentalDoubleFlatParens GClefFlat7Below { get; set; }

        [DataMember(Name="gClefFlat8Above")]
        public AccidentalDoubleFlatParens GClefFlat8Above { get; set; }

        [DataMember(Name="gClefFlat9Above")]
        public AccidentalDoubleFlatParens GClefFlat9Above { get; set; }

        [DataMember(Name="gClefFlat9Below")]
        public AccidentalDoubleFlatParens GClefFlat9Below { get; set; }

        [DataMember(Name="gClefNat2Below")]
        public AccidentalDoubleFlatParens GClefNat2Below { get; set; }

        [DataMember(Name="gClefNatural10Below")]
        public AccidentalDoubleFlatParens GClefNatural10Below { get; set; }

        [DataMember(Name="gClefNatural13Below")]
        public AccidentalDoubleFlatParens GClefNatural13Below { get; set; }

        [DataMember(Name="gClefNatural17Below")]
        public AccidentalDoubleFlatParens GClefNatural17Below { get; set; }

        [DataMember(Name="gClefNatural2Above")]
        public AccidentalDoubleFlatParens GClefNatural2Above { get; set; }

        [DataMember(Name="gClefNatural3Above")]
        public AccidentalDoubleFlatParens GClefNatural3Above { get; set; }

        [DataMember(Name="gClefNatural3Below")]
        public AccidentalDoubleFlatParens GClefNatural3Below { get; set; }

        [DataMember(Name="gClefNatural6Above")]
        public AccidentalDoubleFlatParens GClefNatural6Above { get; set; }

        [DataMember(Name="gClefNatural6Below")]
        public AccidentalDoubleFlatParens GClefNatural6Below { get; set; }

        [DataMember(Name="gClefNatural7Above")]
        public AccidentalDoubleFlatParens GClefNatural7Above { get; set; }

        [DataMember(Name="gClefNatural9Above")]
        public AccidentalDoubleFlatParens GClefNatural9Above { get; set; }

        [DataMember(Name="gClefNatural9Below")]
        public AccidentalDoubleFlatParens GClefNatural9Below { get; set; }

        [DataMember(Name="gClefSharp12Below")]
        public AccidentalDoubleFlatParens GClefSharp12Below { get; set; }

        [DataMember(Name="gClefSharp1Above")]
        public AccidentalDoubleFlatParens GClefSharp1Above { get; set; }

        [DataMember(Name="gClefSharp4Above")]
        public AccidentalDoubleFlatParens GClefSharp4Above { get; set; }

        [DataMember(Name="gClefSharp5Below")]
        public AccidentalDoubleFlatParens GClefSharp5Below { get; set; }

        [DataMember(Name="gClefSmall")]
        public The4StringTabClefSerif GClefSmall { get; set; }

        [DataMember(Name="guitarBarreHalfHorizontalFractionSlash")]
        public The4StringTabClefSerif GuitarBarreHalfHorizontalFractionSlash { get; set; }

        [DataMember(Name="guitarGolpeFlamenco")]
        public The4StringTabClefSerif GuitarGolpeFlamenco { get; set; }

        [DataMember(Name="harpMetalRodAlt")]
        public The4StringTabClefSerif HarpMetalRodAlt { get; set; }

        [DataMember(Name="harpTuningKeyAlt")]
        public The4StringTabClefSerif HarpTuningKeyAlt { get; set; }

        [DataMember(Name="keyboardPedalPedNoDot")]
        public The4StringTabClefSerif KeyboardPedalPedNoDot { get; set; }

        [DataMember(Name="keyboardPedalSostNoDot")]
        public The4StringTabClefSerif KeyboardPedalSostNoDot { get; set; }

        [DataMember(Name="luteFingeringRHThirdAlt")]
        public The4StringTabClefSerif LuteFingeringRhThirdAlt { get; set; }

        [DataMember(Name="luteFrench10thCourseRight")]
        public The4StringTabClefSerif LuteFrench10ThCourseRight { get; set; }

        [DataMember(Name="luteFrench10thCourseStrikethru")]
        public The4StringTabClefSerif LuteFrench10ThCourseStrikethru { get; set; }

        [DataMember(Name="luteFrench10thCourseUnderline")]
        public The4StringTabClefSerif LuteFrench10ThCourseUnderline { get; set; }

        [DataMember(Name="luteFrench7thCourseRight")]
        public The4StringTabClefSerif LuteFrench7ThCourseRight { get; set; }

        [DataMember(Name="luteFrench7thCourseStrikethru")]
        public The4StringTabClefSerif LuteFrench7ThCourseStrikethru { get; set; }

        [DataMember(Name="luteFrench7thCourseUnderline")]
        public The4StringTabClefSerif LuteFrench7ThCourseUnderline { get; set; }

        [DataMember(Name="luteFrench8thCourseRight")]
        public The4StringTabClefSerif LuteFrench8ThCourseRight { get; set; }

        [DataMember(Name="luteFrench8thCourseStrikethru")]
        public The4StringTabClefSerif LuteFrench8ThCourseStrikethru { get; set; }

        [DataMember(Name="luteFrench8thCourseUnderline")]
        public The4StringTabClefSerif LuteFrench8ThCourseUnderline { get; set; }

        [DataMember(Name="luteFrench9thCourseRight")]
        public The4StringTabClefSerif LuteFrench9ThCourseRight { get; set; }

        [DataMember(Name="luteFrench9thCourseStrikethru")]
        public The4StringTabClefSerif LuteFrench9ThCourseStrikethru { get; set; }

        [DataMember(Name="luteFrench9thCourseUnderline")]
        public The4StringTabClefSerif LuteFrench9ThCourseUnderline { get; set; }

        [DataMember(Name="luteFrenchFretCAlt")]
        public The4StringTabClefSerif LuteFrenchFretCAlt { get; set; }

        [DataMember(Name="medRenFlatSoftBHufnagel")]
        public The4StringTabClefSerif MedRenFlatSoftBHufnagel { get; set; }

        [DataMember(Name="medRenFlatSoftBOld")]
        public The4StringTabClefSerif MedRenFlatSoftBOld { get; set; }

        [DataMember(Name="mensuralCclefBlack")]
        public The4StringTabClefSerif MensuralCclefBlack { get; set; }

        [DataMember(Name="mensuralCclefVoid")]
        public The4StringTabClefSerif MensuralCclefVoid { get; set; }

        [DataMember(Name="mensuralFusaBlackStemDown")]
        public AccidentalDoubleFlatParens MensuralFusaBlackStemDown { get; set; }

        [DataMember(Name="mensuralFusaBlackStemUp")]
        public AccidentalDoubleFlatParens MensuralFusaBlackStemUp { get; set; }

        [DataMember(Name="mensuralFusaBlackVoidStemDown")]
        public AccidentalDoubleFlatParens MensuralFusaBlackVoidStemDown { get; set; }

        [DataMember(Name="mensuralFusaBlackVoidStemUp")]
        public AccidentalDoubleFlatParens MensuralFusaBlackVoidStemUp { get; set; }

        [DataMember(Name="mensuralFusaVoidStemDown")]
        public AccidentalDoubleFlatParens MensuralFusaVoidStemDown { get; set; }

        [DataMember(Name="mensuralFusaVoidStemUp")]
        public AccidentalDoubleFlatParens MensuralFusaVoidStemUp { get; set; }

        [DataMember(Name="mensuralLongaBlackStemDownLeft")]
        public AccidentalDoubleFlatParens MensuralLongaBlackStemDownLeft { get; set; }

        [DataMember(Name="mensuralLongaBlackStemDownRight")]
        public AccidentalDoubleFlatParens MensuralLongaBlackStemDownRight { get; set; }

        [DataMember(Name="mensuralLongaBlackStemUpLeft")]
        public AccidentalDoubleFlatParens MensuralLongaBlackStemUpLeft { get; set; }

        [DataMember(Name="mensuralLongaBlackStemUpRight")]
        public AccidentalDoubleFlatParens MensuralLongaBlackStemUpRight { get; set; }

        [DataMember(Name="mensuralLongaBlackVoidStemDownLeft")]
        public AccidentalDoubleFlatParens MensuralLongaBlackVoidStemDownLeft { get; set; }

        [DataMember(Name="mensuralLongaBlackVoidStemDownRight")]
        public AccidentalDoubleFlatParens MensuralLongaBlackVoidStemDownRight { get; set; }

        [DataMember(Name="mensuralLongaBlackVoidStemUpLeft")]
        public AccidentalDoubleFlatParens MensuralLongaBlackVoidStemUpLeft { get; set; }

        [DataMember(Name="mensuralLongaBlackVoidStemUpRight")]
        public AccidentalDoubleFlatParens MensuralLongaBlackVoidStemUpRight { get; set; }

        [DataMember(Name="mensuralLongaVoidStemDownLeft")]
        public AccidentalDoubleFlatParens MensuralLongaVoidStemDownLeft { get; set; }

        [DataMember(Name="mensuralLongaVoidStemDownRight")]
        public AccidentalDoubleFlatParens MensuralLongaVoidStemDownRight { get; set; }

        [DataMember(Name="mensuralLongaVoidStemUpLeft")]
        public AccidentalDoubleFlatParens MensuralLongaVoidStemUpLeft { get; set; }

        [DataMember(Name="mensuralLongaVoidStemUpRight")]
        public AccidentalDoubleFlatParens MensuralLongaVoidStemUpRight { get; set; }

        [DataMember(Name="mensuralMaximaBlackStemDownLeft")]
        public AccidentalDoubleFlatParens MensuralMaximaBlackStemDownLeft { get; set; }

        [DataMember(Name="mensuralMaximaBlackStemDownRight")]
        public AccidentalDoubleFlatParens MensuralMaximaBlackStemDownRight { get; set; }

        [DataMember(Name="mensuralMaximaBlackStemUpLeft")]
        public AccidentalDoubleFlatParens MensuralMaximaBlackStemUpLeft { get; set; }

        [DataMember(Name="mensuralMaximaBlackStemUpRight")]
        public AccidentalDoubleFlatParens MensuralMaximaBlackStemUpRight { get; set; }

        [DataMember(Name="mensuralMaximaBlackVoidStemDownLeft")]
        public AccidentalDoubleFlatParens MensuralMaximaBlackVoidStemDownLeft { get; set; }

        [DataMember(Name="mensuralMaximaBlackVoidStemDownRight")]
        public AccidentalDoubleFlatParens MensuralMaximaBlackVoidStemDownRight { get; set; }

        [DataMember(Name="mensuralMaximaBlackVoidStemUpLeft")]
        public AccidentalDoubleFlatParens MensuralMaximaBlackVoidStemUpLeft { get; set; }

        [DataMember(Name="mensuralMaximaBlackVoidStemUpRight")]
        public AccidentalDoubleFlatParens MensuralMaximaBlackVoidStemUpRight { get; set; }

        [DataMember(Name="mensuralMaximaVoidStemDownLeft")]
        public AccidentalDoubleFlatParens MensuralMaximaVoidStemDownLeft { get; set; }

        [DataMember(Name="mensuralMaximaVoidStemDownRight")]
        public AccidentalDoubleFlatParens MensuralMaximaVoidStemDownRight { get; set; }

        [DataMember(Name="mensuralMaximaVoidStemUpLeft")]
        public AccidentalDoubleFlatParens MensuralMaximaVoidStemUpLeft { get; set; }

        [DataMember(Name="mensuralMaximaVoidStemUpRight")]
        public AccidentalDoubleFlatParens MensuralMaximaVoidStemUpRight { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemDown")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackStemDown { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemDownExtendedFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackStemDownExtendedFlag { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemDownFlagLeft")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackStemDownFlagLeft { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemDownFlagRight")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackStemDownFlagRight { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemDownFlaredFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackStemDownFlaredFlag { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemUp")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackStemUp { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemUpExtendedFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackStemUpExtendedFlag { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemUpFlagLeft")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackStemUpFlagLeft { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemUpFlagRight")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackStemUpFlagRight { get; set; }

        [DataMember(Name="mensuralMinimaBlackStemUpFlaredFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackStemUpFlaredFlag { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemDown")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackVoidStemDown { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemDownExtendedFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackVoidStemDownExtendedFlag { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemDownFlagLeft")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackVoidStemDownFlagLeft { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemDownFlagRight")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackVoidStemDownFlagRight { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemDownFlaredFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackVoidStemDownFlaredFlag { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemUp")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackVoidStemUp { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemUpExtendedFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackVoidStemUpExtendedFlag { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemUpFlagLeft")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackVoidStemUpFlagLeft { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemUpFlagRight")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackVoidStemUpFlagRight { get; set; }

        [DataMember(Name="mensuralMinimaBlackVoidStemUpFlaredFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaBlackVoidStemUpFlaredFlag { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemDown")]
        public AccidentalDoubleFlatParens MensuralMinimaVoidStemDown { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemDownExtendedFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaVoidStemDownExtendedFlag { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemDownFlagLeft")]
        public AccidentalDoubleFlatParens MensuralMinimaVoidStemDownFlagLeft { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemDownFlagRight")]
        public AccidentalDoubleFlatParens MensuralMinimaVoidStemDownFlagRight { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemDownFlaredFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaVoidStemDownFlaredFlag { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemUp")]
        public AccidentalDoubleFlatParens MensuralMinimaVoidStemUp { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemUpExtendedFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaVoidStemUpExtendedFlag { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemUpFlagLeft")]
        public AccidentalDoubleFlatParens MensuralMinimaVoidStemUpFlagLeft { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemUpFlagRight")]
        public AccidentalDoubleFlatParens MensuralMinimaVoidStemUpFlagRight { get; set; }

        [DataMember(Name="mensuralMinimaVoidStemUpFlaredFlag")]
        public AccidentalDoubleFlatParens MensuralMinimaVoidStemUpFlaredFlag { get; set; }

        [DataMember(Name="mensuralProportion4Old")]
        public The4StringTabClefSerif MensuralProportion4Old { get; set; }

        [DataMember(Name="mensuralSemiminimaBlackStemDown")]
        public AccidentalDoubleFlatParens MensuralSemiminimaBlackStemDown { get; set; }

        [DataMember(Name="mensuralSemiminimaBlackStemUp")]
        public AccidentalDoubleFlatParens MensuralSemiminimaBlackStemUp { get; set; }

        [DataMember(Name="mensuralSemiminimaBlackVoidStemDown")]
        public AccidentalDoubleFlatParens MensuralSemiminimaBlackVoidStemDown { get; set; }

        [DataMember(Name="mensuralSemiminimaBlackVoidStemUp")]
        public AccidentalDoubleFlatParens MensuralSemiminimaBlackVoidStemUp { get; set; }

        [DataMember(Name="mensuralSemiminimaVoidStemDown")]
        public AccidentalDoubleFlatParens MensuralSemiminimaVoidStemDown { get; set; }

        [DataMember(Name="mensuralSemiminimaVoidStemUp")]
        public AccidentalDoubleFlatParens MensuralSemiminimaVoidStemUp { get; set; }

        [DataMember(Name="noteDoubleWholeAlt")]
        public The4StringTabClefSerif NoteDoubleWholeAlt { get; set; }

        [DataMember(Name="noteheadBlackOversized")]
        public The4StringTabClefSerif NoteheadBlackOversized { get; set; }

        [DataMember(Name="noteheadBlackParens")]
        public AccidentalDoubleFlatParens NoteheadBlackParens { get; set; }

        [DataMember(Name="noteheadBlackSmall")]
        public The4StringTabClefSerif NoteheadBlackSmall { get; set; }

        [DataMember(Name="noteheadDoubleWholeAlt")]
        public The4StringTabClefSerif NoteheadDoubleWholeAlt { get; set; }

        [DataMember(Name="noteheadDoubleWholeOversized")]
        public The4StringTabClefSerif NoteheadDoubleWholeOversized { get; set; }

        [DataMember(Name="noteheadDoubleWholeParens")]
        public AccidentalDoubleFlatParens NoteheadDoubleWholeParens { get; set; }

        [DataMember(Name="noteheadDoubleWholeSmall")]
        public The4StringTabClefSerif NoteheadDoubleWholeSmall { get; set; }

        [DataMember(Name="noteheadDoubleWholeSquareOversized")]
        public The4StringTabClefSerif NoteheadDoubleWholeSquareOversized { get; set; }

        [DataMember(Name="noteheadHalfOversized")]
        public The4StringTabClefSerif NoteheadHalfOversized { get; set; }

        [DataMember(Name="noteheadHalfParens")]
        public AccidentalDoubleFlatParens NoteheadHalfParens { get; set; }

        [DataMember(Name="noteheadHalfSmall")]
        public The4StringTabClefSerif NoteheadHalfSmall { get; set; }

        [DataMember(Name="noteheadWholeOversized")]
        public The4StringTabClefSerif NoteheadWholeOversized { get; set; }

        [DataMember(Name="noteheadWholeParens")]
        public AccidentalDoubleFlatParens NoteheadWholeParens { get; set; }

        [DataMember(Name="noteheadWholeSmall")]
        public The4StringTabClefSerif NoteheadWholeSmall { get; set; }

        [DataMember(Name="ornamentTrillFlatAbove")]
        public AccidentalDoubleFlatParens OrnamentTrillFlatAbove { get; set; }

        [DataMember(Name="ornamentTrillNaturalAbove")]
        public AccidentalDoubleFlatParens OrnamentTrillNaturalAbove { get; set; }

        [DataMember(Name="ornamentTrillSharpAbove")]
        public AccidentalDoubleFlatParens OrnamentTrillSharpAbove { get; set; }

        [DataMember(Name="ornamentTurnFlatAbove")]
        public AccidentalDoubleFlatParens OrnamentTurnFlatAbove { get; set; }

        [DataMember(Name="ornamentTurnFlatAboveSharpBelow")]
        public AccidentalDoubleFlatParens OrnamentTurnFlatAboveSharpBelow { get; set; }

        [DataMember(Name="ornamentTurnFlatBelow")]
        public AccidentalDoubleFlatParens OrnamentTurnFlatBelow { get; set; }

        [DataMember(Name="ornamentTurnNaturalAbove")]
        public AccidentalDoubleFlatParens OrnamentTurnNaturalAbove { get; set; }

        [DataMember(Name="ornamentTurnNaturalBelow")]
        public AccidentalDoubleFlatParens OrnamentTurnNaturalBelow { get; set; }

        [DataMember(Name="ornamentTurnSharpAbove")]
        public AccidentalDoubleFlatParens OrnamentTurnSharpAbove { get; set; }

        [DataMember(Name="ornamentTurnSharpAboveFlatBelow")]
        public AccidentalDoubleFlatParens OrnamentTurnSharpAboveFlatBelow { get; set; }

        [DataMember(Name="ornamentTurnSharpBelow")]
        public AccidentalDoubleFlatParens OrnamentTurnSharpBelow { get; set; }

        [DataMember(Name="pictBassDrumPeinkofer")]
        public The4StringTabClefSerif PictBassDrumPeinkofer { get; set; }

        [DataMember(Name="pictBongosPeinkofer")]
        public The4StringTabClefSerif PictBongosPeinkofer { get; set; }

        [DataMember(Name="pictCastanetsSmithBrindle")]
        public The4StringTabClefSerif PictCastanetsSmithBrindle { get; set; }

        [DataMember(Name="pictCongaPeinkofer")]
        public The4StringTabClefSerif PictCongaPeinkofer { get; set; }

        [DataMember(Name="pictCowBellBerio")]
        public The4StringTabClefSerif PictCowBellBerio { get; set; }

        [DataMember(Name="pictFlexatonePeinkofer")]
        public The4StringTabClefSerif PictFlexatonePeinkofer { get; set; }

        [DataMember(Name="pictGlspPeinkofer")]
        public The4StringTabClefSerif PictGlspPeinkofer { get; set; }

        [DataMember(Name="pictGuiroPeinkofer")]
        public The4StringTabClefSerif PictGuiroPeinkofer { get; set; }

        [DataMember(Name="pictGuiroSevsay")]
        public The4StringTabClefSerif PictGuiroSevsay { get; set; }

        [DataMember(Name="pictLithophonePeinkofer")]
        public The4StringTabClefSerif PictLithophonePeinkofer { get; set; }

        [DataMember(Name="pictLotusFlutePeinkofer")]
        public The4StringTabClefSerif PictLotusFlutePeinkofer { get; set; }

        [DataMember(Name="pictMarPeinkofer")]
        public The4StringTabClefSerif PictMarPeinkofer { get; set; }

        [DataMember(Name="pictMaracaSmithBrindle")]
        public The4StringTabClefSerif PictMaracaSmithBrindle { get; set; }

        [DataMember(Name="pictMusicalSawPeinkofer")]
        public The4StringTabClefSerif PictMusicalSawPeinkofer { get; set; }

        [DataMember(Name="pictSleighBellSmithBrindle")]
        public The4StringTabClefSerif PictSleighBellSmithBrindle { get; set; }

        [DataMember(Name="pictTambourineStockhausen")]
        public The4StringTabClefSerif PictTambourineStockhausen { get; set; }

        [DataMember(Name="pictTimbalesPeinkofer")]
        public The4StringTabClefSerif PictTimbalesPeinkofer { get; set; }

        [DataMember(Name="pictTimpaniPeinkofer")]
        public The4StringTabClefSerif PictTimpaniPeinkofer { get; set; }

        [DataMember(Name="pictTomTomChinesePeinkofer")]
        public The4StringTabClefSerif PictTomTomChinesePeinkofer { get; set; }

        [DataMember(Name="pictTomTomPeinkofer")]
        public The4StringTabClefSerif PictTomTomPeinkofer { get; set; }

        [DataMember(Name="pictTubaphonePeinkofer")]
        public The4StringTabClefSerif PictTubaphonePeinkofer { get; set; }

        [DataMember(Name="pictVibMotorOffPeinkofer")]
        public The4StringTabClefSerif PictVibMotorOffPeinkofer { get; set; }

        [DataMember(Name="pictVibPeinkofer")]
        public The4StringTabClefSerif PictVibPeinkofer { get; set; }

        [DataMember(Name="pictXylBassPeinkofer")]
        public The4StringTabClefSerif PictXylBassPeinkofer { get; set; }

        [DataMember(Name="pictXylPeinkofer")]
        public The4StringTabClefSerif PictXylPeinkofer { get; set; }

        [DataMember(Name="pictXylTenorPeinkofer")]
        public The4StringTabClefSerif PictXylTenorPeinkofer { get; set; }

        [DataMember(Name="pluckedSnapPizzicatoAboveGerman")]
        public The4StringTabClefSerif PluckedSnapPizzicatoAboveGerman { get; set; }

        [DataMember(Name="pluckedSnapPizzicatoBelowGerman")]
        public The4StringTabClefSerif PluckedSnapPizzicatoBelowGerman { get; set; }

        [DataMember(Name="repeatRightLeftThick")]
        public The4StringTabClefSerif RepeatRightLeftThick { get; set; }

        [DataMember(Name="sedicesima")]
        public The4StringTabClefSerif Sedicesima { get; set; }

        [DataMember(Name="sedicesimaAlta")]
        public The4StringTabClefSerif SedicesimaAlta { get; set; }

        [DataMember(Name="sedicesimaBassa")]
        public The4StringTabClefSerif SedicesimaBassa { get; set; }

        [DataMember(Name="sedicesimaBassaMb")]
        public The4StringTabClefSerif SedicesimaBassaMb { get; set; }

        [DataMember(Name="segnoJapanese")]
        public The4StringTabClefSerif SegnoJapanese { get; set; }

        [DataMember(Name="stringsChangeBowDirectionImposed")]
        public The4StringTabClefSerif StringsChangeBowDirectionImposed { get; set; }

        [DataMember(Name="stringsChangeBowDirectionLiga")]
        public The4StringTabClefSerif StringsChangeBowDirectionLiga { get; set; }

        [DataMember(Name="timeSig0Denominator")]
        public AccidentalDoubleFlatParens TimeSig0Denominator { get; set; }

        [DataMember(Name="timeSig0Large")]
        public The4StringTabClefSerif TimeSig0Large { get; set; }

        [DataMember(Name="timeSig0Numerator")]
        public AccidentalDoubleFlatParens TimeSig0Numerator { get; set; }

        [DataMember(Name="timeSig0Small")]
        public The4StringTabClefSerif TimeSig0Small { get; set; }

        [DataMember(Name="timeSig12over8")]
        public AccidentalDoubleFlatParens TimeSig12Over8 { get; set; }

        [DataMember(Name="timeSig1Denominator")]
        public AccidentalDoubleFlatParens TimeSig1Denominator { get; set; }

        [DataMember(Name="timeSig1Large")]
        public The4StringTabClefSerif TimeSig1Large { get; set; }

        [DataMember(Name="timeSig1Numerator")]
        public AccidentalDoubleFlatParens TimeSig1Numerator { get; set; }

        [DataMember(Name="timeSig1Small")]
        public The4StringTabClefSerif TimeSig1Small { get; set; }

        [DataMember(Name="timeSig2Denominator")]
        public AccidentalDoubleFlatParens TimeSig2Denominator { get; set; }

        [DataMember(Name="timeSig2Large")]
        public The4StringTabClefSerif TimeSig2Large { get; set; }

        [DataMember(Name="timeSig2Numerator")]
        public AccidentalDoubleFlatParens TimeSig2Numerator { get; set; }

        [DataMember(Name="timeSig2Small")]
        public The4StringTabClefSerif TimeSig2Small { get; set; }

        [DataMember(Name="timeSig2over2")]
        public AccidentalDoubleFlatParens TimeSig2Over2 { get; set; }

        [DataMember(Name="timeSig2over4")]
        public AccidentalDoubleFlatParens TimeSig2Over4 { get; set; }

        [DataMember(Name="timeSig3Denominator")]
        public AccidentalDoubleFlatParens TimeSig3Denominator { get; set; }

        [DataMember(Name="timeSig3Large")]
        public The4StringTabClefSerif TimeSig3Large { get; set; }

        [DataMember(Name="timeSig3Numerator")]
        public AccidentalDoubleFlatParens TimeSig3Numerator { get; set; }

        [DataMember(Name="timeSig3Small")]
        public The4StringTabClefSerif TimeSig3Small { get; set; }

        [DataMember(Name="timeSig3over2")]
        public AccidentalDoubleFlatParens TimeSig3Over2 { get; set; }

        [DataMember(Name="timeSig3over4")]
        public AccidentalDoubleFlatParens TimeSig3Over4 { get; set; }

        [DataMember(Name="timeSig3over8")]
        public AccidentalDoubleFlatParens TimeSig3Over8 { get; set; }

        [DataMember(Name="timeSig4Denominator")]
        public AccidentalDoubleFlatParens TimeSig4Denominator { get; set; }

        [DataMember(Name="timeSig4Large")]
        public The4StringTabClefSerif TimeSig4Large { get; set; }

        [DataMember(Name="timeSig4Numerator")]
        public AccidentalDoubleFlatParens TimeSig4Numerator { get; set; }

        [DataMember(Name="timeSig4Small")]
        public The4StringTabClefSerif TimeSig4Small { get; set; }

        [DataMember(Name="timeSig4over4")]
        public AccidentalDoubleFlatParens TimeSig4Over4 { get; set; }

        [DataMember(Name="timeSig5Denominator")]
        public AccidentalDoubleFlatParens TimeSig5Denominator { get; set; }

        [DataMember(Name="timeSig5Large")]
        public The4StringTabClefSerif TimeSig5Large { get; set; }

        [DataMember(Name="timeSig5Numerator")]
        public AccidentalDoubleFlatParens TimeSig5Numerator { get; set; }

        [DataMember(Name="timeSig5Small")]
        public The4StringTabClefSerif TimeSig5Small { get; set; }

        [DataMember(Name="timeSig5over4")]
        public AccidentalDoubleFlatParens TimeSig5Over4 { get; set; }

        [DataMember(Name="timeSig5over8")]
        public AccidentalDoubleFlatParens TimeSig5Over8 { get; set; }

        [DataMember(Name="timeSig6Denominator")]
        public AccidentalDoubleFlatParens TimeSig6Denominator { get; set; }

        [DataMember(Name="timeSig6Large")]
        public The4StringTabClefSerif TimeSig6Large { get; set; }

        [DataMember(Name="timeSig6Numerator")]
        public AccidentalDoubleFlatParens TimeSig6Numerator { get; set; }

        [DataMember(Name="timeSig6Small")]
        public The4StringTabClefSerif TimeSig6Small { get; set; }

        [DataMember(Name="timeSig6over4")]
        public AccidentalDoubleFlatParens TimeSig6Over4 { get; set; }

        [DataMember(Name="timeSig6over8")]
        public AccidentalDoubleFlatParens TimeSig6Over8 { get; set; }

        [DataMember(Name="timeSig7Denominator")]
        public AccidentalDoubleFlatParens TimeSig7Denominator { get; set; }

        [DataMember(Name="timeSig7Large")]
        public The4StringTabClefSerif TimeSig7Large { get; set; }

        [DataMember(Name="timeSig7Numerator")]
        public AccidentalDoubleFlatParens TimeSig7Numerator { get; set; }

        [DataMember(Name="timeSig7Small")]
        public The4StringTabClefSerif TimeSig7Small { get; set; }

        [DataMember(Name="timeSig7over8")]
        public AccidentalDoubleFlatParens TimeSig7Over8 { get; set; }

        [DataMember(Name="timeSig8Denominator")]
        public AccidentalDoubleFlatParens TimeSig8Denominator { get; set; }

        [DataMember(Name="timeSig8Large")]
        public The4StringTabClefSerif TimeSig8Large { get; set; }

        [DataMember(Name="timeSig8Numerator")]
        public AccidentalDoubleFlatParens TimeSig8Numerator { get; set; }

        [DataMember(Name="timeSig8Small")]
        public The4StringTabClefSerif TimeSig8Small { get; set; }

        [DataMember(Name="timeSig9Denominator")]
        public AccidentalDoubleFlatParens TimeSig9Denominator { get; set; }

        [DataMember(Name="timeSig9Large")]
        public The4StringTabClefSerif TimeSig9Large { get; set; }

        [DataMember(Name="timeSig9Numerator")]
        public AccidentalDoubleFlatParens TimeSig9Numerator { get; set; }

        [DataMember(Name="timeSig9Small")]
        public The4StringTabClefSerif TimeSig9Small { get; set; }

        [DataMember(Name="timeSig9over8")]
        public AccidentalDoubleFlatParens TimeSig9Over8 { get; set; }

        [DataMember(Name="timeSigCommonLarge")]
        public The4StringTabClefSerif TimeSigCommonLarge { get; set; }

        [DataMember(Name="timeSigCutCommonLarge")]
        public The4StringTabClefSerif TimeSigCutCommonLarge { get; set; }

        [DataMember(Name="timeSigPlusLarge")]
        public The4StringTabClefSerif TimeSigPlusLarge { get; set; }

        [DataMember(Name="tripleTongueAboveNoSlur")]
        public The4StringTabClefSerif TripleTongueAboveNoSlur { get; set; }

        [DataMember(Name="tripleTongueBelowNoSlur")]
        public The4StringTabClefSerif TripleTongueBelowNoSlur { get; set; }

        [DataMember(Name="unpitchedPercussionClef1Alt")]
        public The4StringTabClefSerif UnpitchedPercussionClef1Alt { get; set; }

        [DataMember(Name="ventiquattresima")]
        public The4StringTabClefSerif Ventiquattresima { get; set; }

        [DataMember(Name="ventiquattresimaAlta")]
        public The4StringTabClefSerif VentiquattresimaAlta { get; set; }

        [DataMember(Name="ventiquattresimaBassa")]
        public The4StringTabClefSerif VentiquattresimaBassa { get; set; }

        [DataMember(Name="ventiquattresimaBassaMb")]
        public The4StringTabClefSerif VentiquattresimaBassaMb { get; set; }

        [DataMember(Name="wiggleArpeggiatoDownSwashCouperin")]
        public The4StringTabClefSerif WiggleArpeggiatoDownSwashCouperin { get; set; }

        [DataMember(Name="wiggleArpeggiatoUpSwashCouperin")]
        public The4StringTabClefSerif WiggleArpeggiatoUpSwashCouperin { get; set; }
    }
}