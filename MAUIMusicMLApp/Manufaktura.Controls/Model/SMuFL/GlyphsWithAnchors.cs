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
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Manufaktura.Controls.Model.SMuFL
{
    public partial class GlyphsWithAnchors
    {
        [DataMember(Name="accidental1CommaFlat")]
        public CutOut Accidental1CommaFlat { get; set; }

        [DataMember(Name="accidental1CommaSharp")]
        public CutOut Accidental1CommaSharp { get; set; }

        [DataMember(Name="accidental2CommaFlat")]
        public CutOut Accidental2CommaFlat { get; set; }

        [DataMember(Name="accidental2CommaSharp")]
        public CutOut Accidental2CommaSharp { get; set; }

        [DataMember(Name="accidental3CommaFlat")]
        public CutOut Accidental3CommaFlat { get; set; }

        [DataMember(Name="accidental3CommaSharp")]
        public CutOut Accidental3CommaSharp { get; set; }

        [DataMember(Name="accidental4CommaFlat")]
        public CutOut Accidental4CommaFlat { get; set; }

        [DataMember(Name="accidental5CommaSharp")]
        public CutOut Accidental5CommaSharp { get; set; }

        [DataMember(Name="accidentalArrowDown")]
        public CutOut AccidentalArrowDown { get; set; }

        [DataMember(Name="accidentalArrowUp")]
        public CutOut AccidentalArrowUp { get; set; }

        [DataMember(Name="accidentalBakiyeFlat")]
        public CutOut AccidentalBakiyeFlat { get; set; }

        [DataMember(Name="accidentalBakiyeSharp")]
        public CutOut AccidentalBakiyeSharp { get; set; }

        [DataMember(Name="accidentalBuyukMucennebFlat")]
        public CutOut AccidentalBuyukMucennebFlat { get; set; }

        [DataMember(Name="accidentalBuyukMucennebSharp")]
        public CutOut AccidentalBuyukMucennebSharp { get; set; }

        [DataMember(Name="accidentalDoubleFlat")]
        public CutOut AccidentalDoubleFlat { get; set; }

        [DataMember(Name="accidentalDoubleFlatEqualTempered")]
        public CutOut AccidentalDoubleFlatEqualTempered { get; set; }

        [DataMember(Name="accidentalDoubleFlatOneArrowDown")]
        public CutOut AccidentalDoubleFlatOneArrowDown { get; set; }

        [DataMember(Name="accidentalDoubleFlatOneArrowUp")]
        public CutOut AccidentalDoubleFlatOneArrowUp { get; set; }

        [DataMember(Name="accidentalDoubleFlatReversed")]
        public CutOut AccidentalDoubleFlatReversed { get; set; }

        [DataMember(Name="accidentalDoubleFlatThreeArrowsDown")]
        public CutOut AccidentalDoubleFlatThreeArrowsDown { get; set; }

        [DataMember(Name="accidentalDoubleFlatThreeArrowsUp")]
        public CutOut AccidentalDoubleFlatThreeArrowsUp { get; set; }

        [DataMember(Name="accidentalDoubleFlatTurned")]
        public CutOut AccidentalDoubleFlatTurned { get; set; }

        [DataMember(Name="accidentalDoubleFlatTwoArrowsDown")]
        public CutOut AccidentalDoubleFlatTwoArrowsDown { get; set; }

        [DataMember(Name="accidentalDoubleFlatTwoArrowsUp")]
        public CutOut AccidentalDoubleFlatTwoArrowsUp { get; set; }

        [DataMember(Name="accidentalFilledReversedFlatAndFlat")]
        public CutOut AccidentalFilledReversedFlatAndFlat { get; set; }

        [DataMember(Name="accidentalFilledReversedFlatAndFlatArrowDown")]
        public CutOut AccidentalFilledReversedFlatAndFlatArrowDown { get; set; }

        [DataMember(Name="accidentalFilledReversedFlatAndFlatArrowUp")]
        public CutOut AccidentalFilledReversedFlatAndFlatArrowUp { get; set; }

        [DataMember(Name="accidentalFilledReversedFlatArrowDown")]
        public CutOut AccidentalFilledReversedFlatArrowDown { get; set; }

        [DataMember(Name="accidentalFilledReversedFlatArrowUp")]
        public CutOut AccidentalFilledReversedFlatArrowUp { get; set; }

        [DataMember(Name="accidentalFiveQuarterTonesFlatArrowDown")]
        public CutOut AccidentalFiveQuarterTonesFlatArrowDown { get; set; }

        [DataMember(Name="CutOut")]
        public CutOut CutOut { get; set; }

        [DataMember(Name="accidentalFlat")]
        public CutOut AccidentalFlat { get; set; }

        [DataMember(Name="accidentalFlatEqualTempered")]
        public CutOut AccidentalFlatEqualTempered { get; set; }

        [DataMember(Name="accidentalFlatOneArrowDown")]
        public CutOut AccidentalFlatOneArrowDown { get; set; }

        [DataMember(Name="accidentalFlatOneArrowUp")]
        public CutOut AccidentalFlatOneArrowUp { get; set; }

        [DataMember(Name="accidentalFlatThreeArrowsDown")]
        public CutOut AccidentalFlatThreeArrowsDown { get; set; }

        [DataMember(Name="accidentalFlatThreeArrowsUp")]
        public CutOut AccidentalFlatThreeArrowsUp { get; set; }

        [DataMember(Name="accidentalFlatTurned")]
        public CutOut AccidentalFlatTurned { get; set; }

        [DataMember(Name="accidentalFlatTwoArrowsDown")]
        public CutOut AccidentalFlatTwoArrowsDown { get; set; }

        [DataMember(Name="accidentalFlatTwoArrowsUp")]
        public CutOut AccidentalFlatTwoArrowsUp { get; set; }

        [DataMember(Name="accidentalHalfSharpArrowDown")]
        public CutOut AccidentalHalfSharpArrowDown { get; set; }

        [DataMember(Name="accidentalHalfSharpArrowUp")]
        public CutOut AccidentalHalfSharpArrowUp { get; set; }

        [DataMember(Name="accidentalKomaFlat")]
        public CutOut AccidentalKomaFlat { get; set; }

        [DataMember(Name="accidentalKomaSharp")]
        public CutOut AccidentalKomaSharp { get; set; }

        [DataMember(Name="accidentalKoron")]
        public CutOut AccidentalKoron { get; set; }

        [DataMember(Name="accidentalKucukMucennebFlat")]
        public CutOut AccidentalKucukMucennebFlat { get; set; }

        [DataMember(Name="accidentalKucukMucennebSharp")]
        public CutOut AccidentalKucukMucennebSharp { get; set; }

        [DataMember(Name="accidentalLowerOneSeptimalComma")]
        public CutOut AccidentalLowerOneSeptimalComma { get; set; }

        [DataMember(Name="accidentalLowerOneTridecimalQuartertone")]
        public CutOut AccidentalLowerOneTridecimalQuartertone { get; set; }

        [DataMember(Name="accidentalLowerOneUndecimalQuartertone")]
        public CutOut AccidentalLowerOneUndecimalQuartertone { get; set; }

        [DataMember(Name="accidentalLowerTwoSeptimalCommas")]
        public CutOut AccidentalLowerTwoSeptimalCommas { get; set; }

        [DataMember(Name="accidentalNarrowReversedFlat")]
        public CutOut AccidentalNarrowReversedFlat { get; set; }

        [DataMember(Name="accidentalNarrowReversedFlatAndFlat")]
        public CutOut AccidentalNarrowReversedFlatAndFlat { get; set; }

        [DataMember(Name="accidentalNatural")]
        public CutOut AccidentalNatural { get; set; }

        [DataMember(Name="accidentalNaturalEqualTempered")]
        public CutOut AccidentalNaturalEqualTempered { get; set; }

        [DataMember(Name="accidentalNaturalFlat")]
        public CutOut AccidentalNaturalFlat { get; set; }

        [DataMember(Name="accidentalNaturalOneArrowDown")]
        public CutOut AccidentalNaturalOneArrowDown { get; set; }

        [DataMember(Name="accidentalNaturalOneArrowUp")]
        public CutOut AccidentalNaturalOneArrowUp { get; set; }

        [DataMember(Name="accidentalNaturalReversed")]
        public CutOut AccidentalNaturalReversed { get; set; }

        [DataMember(Name="accidentalNaturalSharp")]
        public CutOut AccidentalNaturalSharp { get; set; }

        [DataMember(Name="accidentalNaturalThreeArrowsDown")]
        public CutOut AccidentalNaturalThreeArrowsDown { get; set; }

        [DataMember(Name="accidentalNaturalThreeArrowsUp")]
        public CutOut AccidentalNaturalThreeArrowsUp { get; set; }

        [DataMember(Name="accidentalNaturalTwoArrowsDown")]
        public CutOut AccidentalNaturalTwoArrowsDown { get; set; }

        [DataMember(Name="accidentalNaturalTwoArrowsUp")]
        public CutOut AccidentalNaturalTwoArrowsUp { get; set; }

        [DataMember(Name="accidentalOneAndAHalfSharpsArrowDown")]
        public CutOut AccidentalOneAndAHalfSharpsArrowDown { get; set; }

        [DataMember(Name="accidentalOneAndAHalfSharpsArrowUp")]
        public CutOut AccidentalOneAndAHalfSharpsArrowUp { get; set; }

        [DataMember(Name="accidentalQuarterFlatEqualTempered")]
        public CutOut AccidentalQuarterFlatEqualTempered { get; set; }

        [DataMember(Name="accidentalQuarterSharpEqualTempered")]
        public CutOut AccidentalQuarterSharpEqualTempered { get; set; }

        [DataMember(Name="accidentalQuarterToneFlat4")]
        public CutOut AccidentalQuarterToneFlat4 { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatArrowUp")]
        public CutOut AccidentalQuarterToneFlatArrowUp { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatFilledReversed")]
        public CutOut AccidentalQuarterToneFlatFilledReversed { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatNaturalArrowDown")]
        public CutOut AccidentalQuarterToneFlatNaturalArrowDown { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatPenderecki")]
        public CutOut AccidentalQuarterToneFlatPenderecki { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatStein")]
        public CutOut AccidentalQuarterToneFlatStein { get; set; }

        [DataMember(Name="accidentalQuarterToneFlatVanBlankenburg")]
        public CutOut AccidentalQuarterToneFlatVanBlankenburg { get; set; }

        [DataMember(Name="accidentalQuarterToneSharp4")]
        public CutOut AccidentalQuarterToneSharp4 { get; set; }

        [DataMember(Name="accidentalQuarterToneSharpArrowDown")]
        public CutOut AccidentalQuarterToneSharpArrowDown { get; set; }

        [DataMember(Name="accidentalQuarterToneSharpBusotti")]
        public CutOut AccidentalQuarterToneSharpBusotti { get; set; }

        [DataMember(Name="accidentalQuarterToneSharpNaturalArrowUp")]
        public CutOut AccidentalQuarterToneSharpNaturalArrowUp { get; set; }

        [DataMember(Name="accidentalQuarterToneSharpStein")]
        public CutOut AccidentalQuarterToneSharpStein { get; set; }

        [DataMember(Name="accidentalQuarterToneSharpWiggle")]
        public CutOut AccidentalQuarterToneSharpWiggle { get; set; }

        [DataMember(Name="accidentalRaiseOneSeptimalComma")]
        public CutOut AccidentalRaiseOneSeptimalComma { get; set; }

        [DataMember(Name="accidentalRaiseOneTridecimalQuartertone")]
        public CutOut AccidentalRaiseOneTridecimalQuartertone { get; set; }

        [DataMember(Name="accidentalRaiseOneUndecimalQuartertone")]
        public CutOut AccidentalRaiseOneUndecimalQuartertone { get; set; }

        [DataMember(Name="accidentalRaiseTwoSeptimalCommas")]
        public CutOut AccidentalRaiseTwoSeptimalCommas { get; set; }

        [DataMember(Name="accidentalReversedFlatAndFlatArrowDown")]
        public CutOut AccidentalReversedFlatAndFlatArrowDown { get; set; }

        [DataMember(Name="accidentalReversedFlatAndFlatArrowUp")]
        public CutOut AccidentalReversedFlatAndFlatArrowUp { get; set; }

        [DataMember(Name="accidentalReversedFlatArrowDown")]
        public CutOut AccidentalReversedFlatArrowDown { get; set; }

        [DataMember(Name="accidentalReversedFlatArrowUp")]
        public CutOut AccidentalReversedFlatArrowUp { get; set; }

        [DataMember(Name="accidentalSharp")]
        public CutOut AccidentalSharp { get; set; }

        [DataMember(Name="accidentalSharpOneArrowDown")]
        public CutOut AccidentalSharpOneArrowDown { get; set; }

        [DataMember(Name="accidentalSharpOneArrowUp")]
        public CutOut AccidentalSharpOneArrowUp { get; set; }

        [DataMember(Name="accidentalSharpOneHorizontalStroke")]
        public CutOut AccidentalSharpOneHorizontalStroke { get; set; }

        [DataMember(Name="accidentalSharpReversed")]
        public CutOut AccidentalSharpReversed { get; set; }

        [DataMember(Name="accidentalSharpSharp")]
        public CutOut AccidentalSharpSharp { get; set; }

        [DataMember(Name="accidentalSharpThreeArrowsDown")]
        public CutOut AccidentalSharpThreeArrowsDown { get; set; }

        [DataMember(Name="accidentalSharpThreeArrowsUp")]
        public CutOut AccidentalSharpThreeArrowsUp { get; set; }

        [DataMember(Name="accidentalSharpTwoArrowsDown")]
        public CutOut AccidentalSharpTwoArrowsDown { get; set; }

        [DataMember(Name="accidentalSharpTwoArrowsUp")]
        public CutOut AccidentalSharpTwoArrowsUp { get; set; }

        [DataMember(Name="accidentalSims12Down")]
        public CutOut AccidentalSims12Down { get; set; }

        [DataMember(Name="accidentalSims12Up")]
        public CutOut AccidentalSims12Up { get; set; }

        [DataMember(Name="accidentalSims4Down")]
        public CutOut AccidentalSims4Down { get; set; }

        [DataMember(Name="accidentalSims6Down")]
        public CutOut AccidentalSims6Down { get; set; }

        [DataMember(Name="accidentalSims6Up")]
        public CutOut AccidentalSims6Up { get; set; }

        [DataMember(Name="accidentalSori")]
        public CutOut AccidentalSori { get; set; }

        [DataMember(Name="accidentalTavenerFlat")]
        public CutOut AccidentalTavenerFlat { get; set; }

        [DataMember(Name="accidentalTavenerSharp")]
        public CutOut AccidentalTavenerSharp { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatArrowDown")]
        public CutOut AccidentalThreeQuarterTonesFlatArrowDown { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatArrowUp")]
        public CutOut AccidentalThreeQuarterTonesFlatArrowUp { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatCouper")]
        public CutOut AccidentalThreeQuarterTonesFlatCouper { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatGrisey")]
        public CutOut AccidentalThreeQuarterTonesFlatGrisey { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatTartini")]
        public CutOut AccidentalThreeQuarterTonesFlatTartini { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesFlatZimmermann")]
        public CutOut AccidentalThreeQuarterTonesFlatZimmermann { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesSharpArrowDown")]
        public CutOut AccidentalThreeQuarterTonesSharpArrowDown { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesSharpArrowUp")]
        public CutOut AccidentalThreeQuarterTonesSharpArrowUp { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesSharpBusotti")]
        public CutOut AccidentalThreeQuarterTonesSharpBusotti { get; set; }

        [DataMember(Name="accidentalThreeQuarterTonesSharpStein")]
        public CutOut AccidentalThreeQuarterTonesSharpStein { get; set; }

        [DataMember(Name="accidentalTripleFlat")]
        public CutOut AccidentalTripleFlat { get; set; }

        [DataMember(Name="accidentalTripleSharp")]
        public CutOut AccidentalTripleSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky10TwelfthsFlat")]
        public CutOut AccidentalWyschnegradsky10TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky10TwelfthsSharp")]
        public CutOut AccidentalWyschnegradsky10TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky11TwelfthsFlat")]
        public CutOut AccidentalWyschnegradsky11TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky11TwelfthsSharp")]
        public CutOut AccidentalWyschnegradsky11TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky1TwelfthsFlat")]
        public CutOut AccidentalWyschnegradsky1TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky1TwelfthsSharp")]
        public CutOut AccidentalWyschnegradsky1TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky2TwelfthsFlat")]
        public CutOut AccidentalWyschnegradsky2TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky2TwelfthsSharp")]
        public CutOut AccidentalWyschnegradsky2TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky3TwelfthsFlat")]
        public CutOut AccidentalWyschnegradsky3TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky3TwelfthsSharp")]
        public CutOut AccidentalWyschnegradsky3TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky4TwelfthsFlat")]
        public CutOut AccidentalWyschnegradsky4TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky4TwelfthsSharp")]
        public CutOut AccidentalWyschnegradsky4TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky5TwelfthsFlat")]
        public CutOut AccidentalWyschnegradsky5TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky5TwelfthsSharp")]
        public CutOut AccidentalWyschnegradsky5TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky6TwelfthsFlat")]
        public CutOut AccidentalWyschnegradsky6TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky6TwelfthsSharp")]
        public CutOut AccidentalWyschnegradsky6TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky7TwelfthsFlat")]
        public CutOut AccidentalWyschnegradsky7TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky7TwelfthsSharp")]
        public CutOut AccidentalWyschnegradsky7TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky8TwelfthsFlat")]
        public CutOut AccidentalWyschnegradsky8TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky8TwelfthsSharp")]
        public CutOut AccidentalWyschnegradsky8TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalWyschnegradsky9TwelfthsFlat")]
        public CutOut AccidentalWyschnegradsky9TwelfthsFlat { get; set; }

        [DataMember(Name="accidentalWyschnegradsky9TwelfthsSharp")]
        public CutOut AccidentalWyschnegradsky9TwelfthsSharp { get; set; }

        [DataMember(Name="accidentalXenakisOneThirdToneSharp")]
        public CutOut AccidentalXenakisOneThirdToneSharp { get; set; }

        [DataMember(Name="accidentalXenakisTwoThirdTonesSharp")]
        public CutOut AccidentalXenakisTwoThirdTonesSharp { get; set; }

        [DataMember(Name="beamAccelRit1")]
        public RepeatDefinition BeamAccelRit1 { get; set; }

        [DataMember(Name="beamAccelRit10")]
        public RepeatDefinition BeamAccelRit10 { get; set; }

        [DataMember(Name="beamAccelRit11")]
        public RepeatDefinition BeamAccelRit11 { get; set; }

        [DataMember(Name="beamAccelRit12")]
        public RepeatDefinition BeamAccelRit12 { get; set; }

        [DataMember(Name="beamAccelRit13")]
        public RepeatDefinition BeamAccelRit13 { get; set; }

        [DataMember(Name="beamAccelRit14")]
        public RepeatDefinition BeamAccelRit14 { get; set; }

        [DataMember(Name="beamAccelRit15")]
        public RepeatDefinition BeamAccelRit15 { get; set; }

        [DataMember(Name="beamAccelRit2")]
        public RepeatDefinition BeamAccelRit2 { get; set; }

        [DataMember(Name="beamAccelRit3")]
        public RepeatDefinition BeamAccelRit3 { get; set; }

        [DataMember(Name="beamAccelRit4")]
        public RepeatDefinition BeamAccelRit4 { get; set; }

        [DataMember(Name="beamAccelRit5")]
        public RepeatDefinition BeamAccelRit5 { get; set; }

        [DataMember(Name="beamAccelRit6")]
        public RepeatDefinition BeamAccelRit6 { get; set; }

        [DataMember(Name="beamAccelRit7")]
        public RepeatDefinition BeamAccelRit7 { get; set; }

        [DataMember(Name="beamAccelRit8")]
        public RepeatDefinition BeamAccelRit8 { get; set; }

        [DataMember(Name="beamAccelRit9")]
        public RepeatDefinition BeamAccelRit9 { get; set; }

        [DataMember(Name="dynamicFF")]
        public Dynamic DynamicFf { get; set; }

        [DataMember(Name="dynamicFFF")]
        public Dynamic DynamicFff { get; set; }

        [DataMember(Name="dynamicFFFF")]
        public Dynamic DynamicFfff { get; set; }

        [DataMember(Name="dynamicFFFFF")]
        public Dynamic DynamicFffff { get; set; }

        [DataMember(Name="dynamicFFFFFF")]
        public Dynamic DynamicFfffff { get; set; }

        [DataMember(Name="dynamicForte")]
        public Dynamic DynamicForte { get; set; }

        [DataMember(Name="dynamicFortePiano")]
        public Dynamic DynamicFortePiano { get; set; }

        [DataMember(Name="dynamicForzando")]
        public Dynamic DynamicForzando { get; set; }

        [DataMember(Name="dynamicMF")]
        public Dynamic DynamicMf { get; set; }

        [DataMember(Name="dynamicMP")]
        public Dynamic DynamicMp { get; set; }

        [DataMember(Name="dynamicMezzo")]
        public Dynamic DynamicMezzo { get; set; }

        [DataMember(Name="dynamicNiente")]
        public Dynamic DynamicNiente { get; set; }

        [DataMember(Name="dynamicPF")]
        public Dynamic DynamicPf { get; set; }

        [DataMember(Name="dynamicPP")]
        public Dynamic DynamicPp { get; set; }

        [DataMember(Name="dynamicPPP")]
        public Dynamic DynamicPpp { get; set; }

        [DataMember(Name="dynamicPPPP")]
        public Dynamic DynamicPppp { get; set; }

        [DataMember(Name="dynamicPPPPP")]
        public Dynamic DynamicPpppp { get; set; }

        [DataMember(Name="dynamicPPPPPP")]
        public Dynamic DynamicPppppp { get; set; }

        [DataMember(Name="dynamicPiano")]
        public Dynamic DynamicPiano { get; set; }

        [DataMember(Name="dynamicRinforzando")]
        public Dynamic DynamicRinforzando { get; set; }

        [DataMember(Name="dynamicRinforzando1")]
        public Dynamic DynamicRinforzando1 { get; set; }

        [DataMember(Name="dynamicRinforzando2")]
        public Dynamic DynamicRinforzando2 { get; set; }

        [DataMember(Name="dynamicSforzando")]
        public Dynamic DynamicSforzando { get; set; }

        [DataMember(Name="dynamicSforzando1")]
        public Dynamic DynamicSforzando1 { get; set; }

        [DataMember(Name="dynamicSforzandoPianissimo")]
        public Dynamic DynamicSforzandoPianissimo { get; set; }

        [DataMember(Name="dynamicSforzandoPiano")]
        public Dynamic DynamicSforzandoPiano { get; set; }

        [DataMember(Name="dynamicSforzato")]
        public Dynamic DynamicSforzato { get; set; }

        [DataMember(Name="dynamicSforzatoFF")]
        public Dynamic DynamicSforzatoFf { get; set; }

        [DataMember(Name="dynamicSforzatoPiano")]
        public Dynamic DynamicSforzatoPiano { get; set; }

        [DataMember(Name="dynamicZ")]
        public Dynamic DynamicZ { get; set; }

        [DataMember(Name="flag1024thDown")]
        public StemBoundaries Flag1024ThDown { get; set; }

        [DataMember(Name="flag1024thDownSmall")]
        public StemBoundaries Flag1024ThDownSmall { get; set; }

        [DataMember(Name="flag1024thDownStraight")]
        public StemBoundaries Flag1024ThDownStraight { get; set; }

        [DataMember(Name="flag1024thUp")]
        public StemBoundaries Flag1024ThUp { get; set; }

        [DataMember(Name="flag1024thUpShort")]
        public StemBoundaries Flag1024ThUpShort { get; set; }

        [DataMember(Name="flag1024thUpSmall")]
        public StemBoundaries Flag1024ThUpSmall { get; set; }

        [DataMember(Name="flag1024thUpStraight")]
        public StemBoundaries Flag1024ThUpStraight { get; set; }

        [DataMember(Name="flag128thDown")]
        public StemBoundaries Flag128ThDown { get; set; }

        [DataMember(Name="flag128thDownSmall")]
        public StemBoundaries Flag128ThDownSmall { get; set; }

        [DataMember(Name="flag128thDownStraight")]
        public StemBoundaries Flag128ThDownStraight { get; set; }

        [DataMember(Name="flag128thUp")]
        public StemBoundaries Flag128ThUp { get; set; }

        [DataMember(Name="flag128thUpShort")]
        public StemBoundaries Flag128ThUpShort { get; set; }

        [DataMember(Name="flag128thUpSmall")]
        public StemBoundaries Flag128ThUpSmall { get; set; }

        [DataMember(Name="flag128thUpStraight")]
        public StemBoundaries Flag128ThUpStraight { get; set; }

        [DataMember(Name="flag16thDown")]
        public StemBoundaries Flag16ThDown { get; set; }

        [DataMember(Name="flag16thDownSmall")]
        public StemBoundaries Flag16ThDownSmall { get; set; }

        [DataMember(Name="flag16thDownStraight")]
        public StemBoundaries Flag16ThDownStraight { get; set; }

        [DataMember(Name="flag16thUp")]
        public StemBoundaries Flag16ThUp { get; set; }

        [DataMember(Name="flag16thUpShort")]
        public StemBoundaries Flag16ThUpShort { get; set; }

        [DataMember(Name="flag16thUpSmall")]
        public StemBoundaries Flag16ThUpSmall { get; set; }

        [DataMember(Name="flag16thUpStraight")]
        public StemBoundaries Flag16ThUpStraight { get; set; }

        [DataMember(Name="flag256thDown")]
        public StemBoundaries Flag256ThDown { get; set; }

        [DataMember(Name="flag256thDownSmall")]
        public StemBoundaries Flag256ThDownSmall { get; set; }

        [DataMember(Name="flag256thDownStraight")]
        public StemBoundaries Flag256ThDownStraight { get; set; }

        [DataMember(Name="flag256thUp")]
        public StemBoundaries Flag256ThUp { get; set; }

        [DataMember(Name="flag256thUpShort")]
        public StemBoundaries Flag256ThUpShort { get; set; }

        [DataMember(Name="flag256thUpSmall")]
        public StemBoundaries Flag256ThUpSmall { get; set; }

        [DataMember(Name="flag256thUpStraight")]
        public StemBoundaries Flag256ThUpStraight { get; set; }

        [DataMember(Name="flag32ndDown")]
        public StemBoundaries Flag32NdDown { get; set; }

        [DataMember(Name="flag32ndDownSmall")]
        public StemBoundaries Flag32NdDownSmall { get; set; }

        [DataMember(Name="flag32ndDownStraight")]
        public StemBoundaries Flag32NdDownStraight { get; set; }

        [DataMember(Name="flag32ndUp")]
        public StemBoundaries Flag32NdUp { get; set; }

        [DataMember(Name="flag32ndUpShort")]
        public StemBoundaries Flag32NdUpShort { get; set; }

        [DataMember(Name="flag32ndUpSmall")]
        public StemBoundaries Flag32NdUpSmall { get; set; }

        [DataMember(Name="flag32ndUpStraight")]
        public StemBoundaries Flag32NdUpStraight { get; set; }

        [DataMember(Name="flag512thDown")]
        public StemBoundaries Flag512ThDown { get; set; }

        [DataMember(Name="flag512thDownSmall")]
        public StemBoundaries Flag512ThDownSmall { get; set; }

        [DataMember(Name="flag512thDownStraight")]
        public StemBoundaries Flag512ThDownStraight { get; set; }

        [DataMember(Name="flag512thUp")]
        public StemBoundaries Flag512ThUp { get; set; }

        [DataMember(Name="flag512thUpShort")]
        public StemBoundaries Flag512ThUpShort { get; set; }

        [DataMember(Name="flag512thUpSmall")]
        public StemBoundaries Flag512ThUpSmall { get; set; }

        [DataMember(Name="flag512thUpStraight")]
        public StemBoundaries Flag512ThUpStraight { get; set; }

        [DataMember(Name="flag64thDown")]
        public StemBoundaries Flag64ThDown { get; set; }

        [DataMember(Name="flag64thDownSmall")]
        public StemBoundaries Flag64ThDownSmall { get; set; }

        [DataMember(Name="flag64thDownStraight")]
        public StemBoundaries Flag64ThDownStraight { get; set; }

        [DataMember(Name="flag64thUp")]
        public StemBoundaries Flag64ThUp { get; set; }

        [DataMember(Name="flag64thUpShort")]
        public StemBoundaries Flag64ThUpShort { get; set; }

        [DataMember(Name="flag64thUpSmall")]
        public StemBoundaries Flag64ThUpSmall { get; set; }

        [DataMember(Name="flag64thUpStraight")]
        public StemBoundaries Flag64ThUpStraight { get; set; }

        [DataMember(Name="flag8thDown")]
        public GraceNoteStemBoundaries Flag8ThDown { get; set; }

        [DataMember(Name="StemBoundaries")]
        public StemBoundaries StemBoundaries { get; set; }

        [DataMember(Name="flag8thDownStraight")]
        public StemBoundaries Flag8ThDownStraight { get; set; }

        [DataMember(Name="flag8thUp")]
        public GraceNoteStemBoundaries Flag8ThUp { get; set; }

        [DataMember(Name="flag8thUpShort")]
        public StemBoundaries Flag8ThUpShort { get; set; }

        [DataMember(Name="flag8thUpSmall")]
        public StemBoundaries Flag8thUpSmall { get; set; }

        [DataMember(Name="flag8thUpStraight")]
        public StemBoundaries Flag8ThUpStraight { get; set; }

        [DataMember(Name="gClefLigatedNumberAbove")]
        public GClefLigatedNumber GClefLigatedNumberAbove { get; set; }

        [DataMember(Name="gClefLigatedNumberBelow")]
        public GClefLigatedNumber GClefLigatedNumberBelow { get; set; }

        [DataMember(Name="guitarVibratoStroke")]
        public RepeatDefinition GuitarVibratoStroke { get; set; }

        [DataMember(Name="guitarWideVibratoStroke")]
        public RepeatDefinition GuitarWideVibratoStroke { get; set; }

        [DataMember(Name="noteABlack")]
        public StemBoundaries NoteABlack { get; set; }

        [DataMember(Name="noteAFlatBlack")]
        public StemBoundaries NoteAFlatBlack { get; set; }

        [DataMember(Name="noteAFlatHalf")]
        public StemBoundaries NoteAFlatHalf { get; set; }

        [DataMember(Name="noteAHalf")]
        public StemBoundaries NoteAHalf { get; set; }

        [DataMember(Name="noteASharpBlack")]
        public StemBoundaries NoteASharpBlack { get; set; }

        [DataMember(Name="noteASharpHalf")]
        public StemBoundaries NoteASharpHalf { get; set; }

        [DataMember(Name="noteBBlack")]
        public StemBoundaries NoteBBlack { get; set; }

        [DataMember(Name="noteBFlatBlack")]
        public StemBoundaries NoteBFlatBlack { get; set; }

        [DataMember(Name="noteBFlatHalf")]
        public StemBoundaries NoteBFlatHalf { get; set; }

        [DataMember(Name="noteBHalf")]
        public StemBoundaries NoteBHalf { get; set; }

        [DataMember(Name="noteBSharpBlack")]
        public StemBoundaries NoteBSharpBlack { get; set; }

        [DataMember(Name="noteBSharpHalf")]
        public StemBoundaries NoteBSharpHalf { get; set; }

        [DataMember(Name="noteCBlack")]
        public StemBoundaries NoteCBlack { get; set; }

        [DataMember(Name="noteCFlatBlack")]
        public StemBoundaries NoteCFlatBlack { get; set; }

        [DataMember(Name="noteCFlatHalf")]
        public StemBoundaries NoteCFlatHalf { get; set; }

        [DataMember(Name="noteCHalf")]
        public StemBoundaries NoteCHalf { get; set; }

        [DataMember(Name="noteCSharpBlack")]
        public StemBoundaries NoteCSharpBlack { get; set; }

        [DataMember(Name="noteCSharpHalf")]
        public StemBoundaries NoteCSharpHalf { get; set; }

        [DataMember(Name="noteDBlack")]
        public StemBoundaries NoteDBlack { get; set; }

        [DataMember(Name="noteDFlatBlack")]
        public StemBoundaries NoteDFlatBlack { get; set; }

        [DataMember(Name="noteDFlatHalf")]
        public StemBoundaries NoteDFlatHalf { get; set; }

        [DataMember(Name="noteDHalf")]
        public StemBoundaries NoteDHalf { get; set; }

        [DataMember(Name="noteDSharpBlack")]
        public StemBoundaries NoteDSharpBlack { get; set; }

        [DataMember(Name="noteDSharpHalf")]
        public StemBoundaries NoteDSharpHalf { get; set; }

        [DataMember(Name="noteDoBlack")]
        public StemBoundaries NoteDoBlack { get; set; }

        [DataMember(Name="noteDoHalf")]
        public StemBoundaries NoteDoHalf { get; set; }

        [DataMember(Name="noteEBlack")]
        public StemBoundaries NoteEBlack { get; set; }

        [DataMember(Name="noteEFlatBlack")]
        public StemBoundaries NoteEFlatBlack { get; set; }

        [DataMember(Name="noteEFlatHalf")]
        public StemBoundaries NoteEFlatHalf { get; set; }

        [DataMember(Name="noteEHalf")]
        public StemBoundaries NoteEHalf { get; set; }

        [DataMember(Name="noteESharpBlack")]
        public StemBoundaries NoteESharpBlack { get; set; }

        [DataMember(Name="noteESharpHalf")]
        public StemBoundaries NoteESharpHalf { get; set; }

        [DataMember(Name="noteEmptyBlack")]
        public StemBoundaries NoteEmptyBlack { get; set; }

        [DataMember(Name="noteEmptyHalf")]
        public StemBoundaries NoteEmptyHalf { get; set; }

        [DataMember(Name="noteFBlack")]
        public StemBoundaries NoteFBlack { get; set; }

        [DataMember(Name="noteFFlatBlack")]
        public StemBoundaries NoteFFlatBlack { get; set; }

        [DataMember(Name="noteFFlatHalf")]
        public StemBoundaries NoteFFlatHalf { get; set; }

        [DataMember(Name="noteFHalf")]
        public StemBoundaries NoteFHalf { get; set; }

        [DataMember(Name="noteFSharpBlack")]
        public StemBoundaries NoteFSharpBlack { get; set; }

        [DataMember(Name="noteFSharpHalf")]
        public StemBoundaries NoteFSharpHalf { get; set; }

        [DataMember(Name="noteFaBlack")]
        public StemBoundaries NoteFaBlack { get; set; }

        [DataMember(Name="noteFaHalf")]
        public StemBoundaries NoteFaHalf { get; set; }

        [DataMember(Name="noteGBlack")]
        public StemBoundaries NoteGBlack { get; set; }

        [DataMember(Name="noteGFlatBlack")]
        public StemBoundaries NoteGFlatBlack { get; set; }

        [DataMember(Name="noteGFlatHalf")]
        public StemBoundaries NoteGFlatHalf { get; set; }

        [DataMember(Name="noteGHalf")]
        public StemBoundaries NoteGHalf { get; set; }

        [DataMember(Name="noteGSharpBlack")]
        public StemBoundaries NoteGSharpBlack { get; set; }

        [DataMember(Name="noteGSharpHalf")]
        public StemBoundaries NoteGSharpHalf { get; set; }

        [DataMember(Name="noteHBlack")]
        public StemBoundaries NoteHBlack { get; set; }

        [DataMember(Name="noteHHalf")]
        public StemBoundaries NoteHHalf { get; set; }

        [DataMember(Name="noteHSharpBlack")]
        public StemBoundaries NoteHSharpBlack { get; set; }

        [DataMember(Name="noteHSharpHalf")]
        public StemBoundaries NoteHSharpHalf { get; set; }

        [DataMember(Name="noteLaBlack")]
        public StemBoundaries NoteLaBlack { get; set; }

        [DataMember(Name="noteLaHalf")]
        public StemBoundaries NoteLaHalf { get; set; }

        [DataMember(Name="noteMiBlack")]
        public StemBoundaries NoteMiBlack { get; set; }

        [DataMember(Name="noteMiHalf")]
        public StemBoundaries NoteMiHalf { get; set; }

        [DataMember(Name="noteReBlack")]
        public StemBoundaries NoteReBlack { get; set; }

        [DataMember(Name="noteReHalf")]
        public StemBoundaries NoteReHalf { get; set; }

        [DataMember(Name="noteShapeDiamondBlack")]
        public StemBoundaries NoteShapeDiamondBlack { get; set; }

        [DataMember(Name="noteShapeDiamondWhite")]
        public StemBoundaries NoteShapeDiamondWhite { get; set; }

        [DataMember(Name="noteShapeMoonBlack")]
        public StemBoundaries NoteShapeMoonBlack { get; set; }

        [DataMember(Name="noteShapeMoonWhite")]
        public StemBoundaries NoteShapeMoonWhite { get; set; }

        [DataMember(Name="noteShapeRoundBlack")]
        public StemBoundaries NoteShapeRoundBlack { get; set; }

        [DataMember(Name="noteShapeRoundWhite")]
        public StemBoundaries NoteShapeRoundWhite { get; set; }

        [DataMember(Name="noteShapeSquareBlack")]
        public StemBoundaries NoteShapeSquareBlack { get; set; }

        [DataMember(Name="noteShapeSquareWhite")]
        public StemBoundaries NoteShapeSquareWhite { get; set; }

        [DataMember(Name="noteShapeTriangleLeftBlack")]
        public StemBoundaries NoteShapeTriangleLeftBlack { get; set; }

        [DataMember(Name="noteShapeTriangleLeftWhite")]
        public StemBoundaries NoteShapeTriangleLeftWhite { get; set; }

        [DataMember(Name="noteShapeTriangleRightBlack")]
        public StemBoundaries NoteShapeTriangleRightBlack { get; set; }

        [DataMember(Name="noteShapeTriangleRightWhite")]
        public StemBoundaries NoteShapeTriangleRightWhite { get; set; }

        [DataMember(Name="noteShapeTriangleRoundBlack")]
        public StemBoundaries NoteShapeTriangleRoundBlack { get; set; }

        [DataMember(Name="noteShapeTriangleRoundWhite")]
        public StemBoundaries NoteShapeTriangleRoundWhite { get; set; }

        [DataMember(Name="noteShapeTriangleUpBlack")]
        public StemBoundaries NoteShapeTriangleUpBlack { get; set; }

        [DataMember(Name="noteShapeTriangleUpWhite")]
        public StemBoundaries NoteShapeTriangleUpWhite { get; set; }

        [DataMember(Name="noteSiBlack")]
        public StemBoundaries NoteSiBlack { get; set; }

        [DataMember(Name="noteSiHalf")]
        public StemBoundaries NoteSiHalf { get; set; }

        [DataMember(Name="noteSoBlack")]
        public StemBoundaries NoteSoBlack { get; set; }

        [DataMember(Name="noteSoHalf")]
        public StemBoundaries NoteSoHalf { get; set; }

        [DataMember(Name="noteTiBlack")]
        public StemBoundaries NoteTiBlack { get; set; }

        [DataMember(Name="noteTiHalf")]
        public StemBoundaries NoteTiHalf { get; set; }

        [DataMember(Name="noteheadBlack")]
        public Dictionary<string, double[]> NoteheadBlack { get; set; }

        [DataMember(Name="noteheadBlackOversized")]
        public Dictionary<string, double[]> NoteheadBlackOversized { get; set; }

        [DataMember(Name="noteheadBlackSmall")]
        public StemBoundaries NoteheadBlackSmall { get; set; }

        [DataMember(Name="noteheadCircleSlash")]
        public StemBoundaries NoteheadCircleSlash { get; set; }

        [DataMember(Name="noteheadCircleX")]
        public StemBoundaries NoteheadCircleX { get; set; }

        [DataMember(Name="noteheadCircleXDoubleWhole")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadCircleXDoubleWhole { get; set; }

        [DataMember(Name="noteheadCircleXHalf")]
        public StemBoundaries NoteheadCircleXHalf { get; set; }

        [DataMember(Name="noteheadCircledBlack")]
        public StemBoundaries NoteheadCircledBlack { get; set; }

        [DataMember(Name="noteheadCircledBlackLarge")]
        public StemBoundaries NoteheadCircledBlackLarge { get; set; }

        [DataMember(Name="noteheadCircledDoubleWhole")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadCircledDoubleWhole { get; set; }

        [DataMember(Name="noteheadCircledDoubleWholeLarge")]
        public StemBoundaries NoteheadCircledDoubleWholeLarge { get; set; }

        [DataMember(Name="noteheadCircledHalf")]
        public StemBoundaries NoteheadCircledHalf { get; set; }

        [DataMember(Name="noteheadCircledHalfLarge")]
        public StemBoundaries NoteheadCircledHalfLarge { get; set; }

        [DataMember(Name="noteheadCircledWholeLarge")]
        public StemBoundaries NoteheadCircledWholeLarge { get; set; }

        [DataMember(Name="noteheadCircledXLarge")]
        public StemBoundaries NoteheadCircledXLarge { get; set; }

        [DataMember(Name="noteheadClusterDoubleWhole2nd")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadClusterDoubleWhole2Nd { get; set; }

        [DataMember(Name="noteheadClusterDoubleWhole3rd")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadClusterDoubleWhole3Rd { get; set; }

        [DataMember(Name="noteheadClusterHalf2nd")]
        public StemBoundaries NoteheadClusterHalf2Nd { get; set; }

        [DataMember(Name="noteheadClusterHalf3rd")]
        public StemBoundaries NoteheadClusterHalf3Rd { get; set; }

        [DataMember(Name="noteheadClusterHalfBottom")]
        public StemBoundaries NoteheadClusterHalfBottom { get; set; }

        [DataMember(Name="noteheadClusterHalfTop")]
        public StemBoundaries NoteheadClusterHalfTop { get; set; }

        [DataMember(Name="noteheadClusterQuarter2nd")]
        public StemBoundaries NoteheadClusterQuarter2Nd { get; set; }

        [DataMember(Name="noteheadClusterQuarter3rd")]
        public StemBoundaries NoteheadClusterQuarter3Rd { get; set; }

        [DataMember(Name="noteheadClusterQuarterBottom")]
        public StemBoundaries NoteheadClusterQuarterBottom { get; set; }

        [DataMember(Name="noteheadClusterQuarterTop")]
        public StemBoundaries NoteheadClusterQuarterTop { get; set; }

        [DataMember(Name="noteheadClusterRoundBlack")]
        public StemBoundaries NoteheadClusterRoundBlack { get; set; }

        [DataMember(Name="noteheadClusterRoundWhite")]
        public StemBoundaries NoteheadClusterRoundWhite { get; set; }

        [DataMember(Name="noteheadClusterSquareBlack")]
        public StemBoundaries NoteheadClusterSquareBlack { get; set; }

        [DataMember(Name="noteheadClusterSquareWhite")]
        public StemBoundaries NoteheadClusterSquareWhite { get; set; }

        [DataMember(Name="noteheadDiamondBlack")]
        public StemBoundaries NoteheadDiamondBlack { get; set; }

        [DataMember(Name="noteheadDiamondBlackOld")]
        public StemBoundaries NoteheadDiamondBlackOld { get; set; }

        [DataMember(Name="noteheadDiamondBlackWide")]
        public StemBoundaries NoteheadDiamondBlackWide { get; set; }

        [DataMember(Name="noteheadDiamondClusterBlack2nd")]
        public StemBoundaries NoteheadDiamondClusterBlack2Nd { get; set; }

        [DataMember(Name="noteheadDiamondClusterBlack3rd")]
        public StemBoundaries NoteheadDiamondClusterBlack3Rd { get; set; }

        [DataMember(Name="noteheadDiamondClusterBlackBottom")]
        public StemBoundaries NoteheadDiamondClusterBlackBottom { get; set; }

        [DataMember(Name="noteheadDiamondClusterBlackTop")]
        public StemBoundaries NoteheadDiamondClusterBlackTop { get; set; }

        [DataMember(Name="noteheadDiamondClusterWhite2nd")]
        public StemBoundaries NoteheadDiamondClusterWhite2Nd { get; set; }

        [DataMember(Name="noteheadDiamondClusterWhite3rd")]
        public StemBoundaries NoteheadDiamondClusterWhite3Rd { get; set; }

        [DataMember(Name="noteheadDiamondClusterWhiteBottom")]
        public StemBoundaries NoteheadDiamondClusterWhiteBottom { get; set; }

        [DataMember(Name="noteheadDiamondClusterWhiteTop")]
        public StemBoundaries NoteheadDiamondClusterWhiteTop { get; set; }

        [DataMember(Name="noteheadDiamondDoubleWhole")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadDiamondDoubleWhole { get; set; }

        [DataMember(Name="noteheadDiamondDoubleWholeOld")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadDiamondDoubleWholeOld { get; set; }

        [DataMember(Name="noteheadDiamondHalf")]
        public StemBoundaries NoteheadDiamondHalf { get; set; }

        [DataMember(Name="noteheadDiamondHalfFilled")]
        public StemBoundaries NoteheadDiamondHalfFilled { get; set; }

        [DataMember(Name="noteheadDiamondHalfOld")]
        public StemBoundaries NoteheadDiamondHalfOld { get; set; }

        [DataMember(Name="noteheadDiamondHalfWide")]
        public StemBoundaries NoteheadDiamondHalfWide { get; set; }

        [DataMember(Name="noteheadDiamondOpen")]
        public StemBoundaries NoteheadDiamondOpen { get; set; }

        [DataMember(Name="noteheadDiamondWhite")]
        public StemBoundaries NoteheadDiamondWhite { get; set; }

        [DataMember(Name="noteheadDiamondWhiteWide")]
        public StemBoundaries NoteheadDiamondWhiteWide { get; set; }

        [DataMember(Name="noteheadDoubleWhole")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadDoubleWhole { get; set; }

        [DataMember(Name="noteheadDoubleWholeOversized")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadDoubleWholeOversized { get; set; }

        [DataMember(Name="noteheadDoubleWholeWithX")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadDoubleWholeWithX { get; set; }

        [DataMember(Name="noteheadHalf")]
        public Dictionary<string, double[]> NoteheadHalf { get; set; }

        [DataMember(Name="noteheadHalfOversized")]
        public Dictionary<string, double[]> NoteheadHalfOversized { get; set; }

        [DataMember(Name="noteheadHalfSmall")]
        public StemBoundaries NoteheadHalfSmall { get; set; }

        [DataMember(Name="noteheadHalfWithX")]
        public StemBoundaries NoteheadHalfWithX { get; set; }

        [DataMember(Name="noteheadHeavyX")]
        public StemBoundaries NoteheadHeavyX { get; set; }

        [DataMember(Name="noteheadHeavyXHat")]
        public StemBoundaries NoteheadHeavyXHat { get; set; }

        [DataMember(Name="noteheadLargeArrowDownBlack")]
        public StemBoundaries NoteheadLargeArrowDownBlack { get; set; }

        [DataMember(Name="noteheadLargeArrowDownDoubleWhole")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadLargeArrowDownDoubleWhole { get; set; }

        [DataMember(Name="noteheadLargeArrowDownHalf")]
        public StemBoundaries NoteheadLargeArrowDownHalf { get; set; }

        [DataMember(Name="noteheadLargeArrowUpBlack")]
        public StemBoundaries NoteheadLargeArrowUpBlack { get; set; }

        [DataMember(Name="noteheadLargeArrowUpDoubleWhole")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadLargeArrowUpDoubleWhole { get; set; }

        [DataMember(Name="noteheadLargeArrowUpHalf")]
        public StemBoundaries NoteheadLargeArrowUpHalf { get; set; }

        [DataMember(Name="noteheadMoonBlack")]
        public StemBoundaries NoteheadMoonBlack { get; set; }

        [DataMember(Name="noteheadMoonWhite")]
        public StemBoundaries NoteheadMoonWhite { get; set; }

        [DataMember(Name="noteheadPlusBlack")]
        public StemBoundaries NoteheadPlusBlack { get; set; }

        [DataMember(Name="noteheadPlusDoubleWhole")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadPlusDoubleWhole { get; set; }

        [DataMember(Name="noteheadPlusHalf")]
        public StemBoundaries NoteheadPlusHalf { get; set; }

        [DataMember(Name="noteheadRoundBlack")]
        public StemBoundaries NoteheadRoundBlack { get; set; }

        [DataMember(Name="noteheadRoundBlackDoubleSlashed")]
        public StemBoundaries NoteheadRoundBlackDoubleSlashed { get; set; }

        [DataMember(Name="noteheadRoundBlackLarge")]
        public StemBoundaries NoteheadRoundBlackLarge { get; set; }

        [DataMember(Name="noteheadRoundBlackSlashed")]
        public StemBoundaries NoteheadRoundBlackSlashed { get; set; }

        [DataMember(Name="noteheadRoundBlackSlashedLarge")]
        public StemBoundaries NoteheadRoundBlackSlashedLarge { get; set; }

        [DataMember(Name="noteheadRoundWhite")]
        public StemBoundaries NoteheadRoundWhite { get; set; }

        [DataMember(Name="noteheadRoundWhiteDoubleSlashed")]
        public StemBoundaries NoteheadRoundWhiteDoubleSlashed { get; set; }

        [DataMember(Name="noteheadRoundWhiteLarge")]
        public StemBoundaries NoteheadRoundWhiteLarge { get; set; }

        [DataMember(Name="noteheadRoundWhiteSlashed")]
        public StemBoundaries NoteheadRoundWhiteSlashed { get; set; }

        [DataMember(Name="noteheadRoundWhiteSlashedLarge")]
        public StemBoundaries NoteheadRoundWhiteSlashedLarge { get; set; }

        [DataMember(Name="noteheadRoundWhiteWithDot")]
        public StemBoundaries NoteheadRoundWhiteWithDot { get; set; }

        [DataMember(Name="noteheadRoundWhiteWithDotLarge")]
        public StemBoundaries NoteheadRoundWhiteWithDotLarge { get; set; }

        [DataMember(Name="noteheadSlashDiamondWhite")]
        public StemBoundaries NoteheadSlashDiamondWhite { get; set; }

        [DataMember(Name="noteheadSlashHorizontalEnds")]
        public StemBoundaries NoteheadSlashHorizontalEnds { get; set; }

        [DataMember(Name="noteheadSlashHorizontalEndsMuted")]
        public StemBoundaries NoteheadSlashHorizontalEndsMuted { get; set; }

        [DataMember(Name="noteheadSlashVerticalEnds")]
        public StemBoundaries NoteheadSlashVerticalEnds { get; set; }

        [DataMember(Name="noteheadSlashVerticalEndsMuted")]
        public StemBoundaries NoteheadSlashVerticalEndsMuted { get; set; }

        [DataMember(Name="noteheadSlashVerticalEndsSmall")]
        public StemBoundaries NoteheadSlashVerticalEndsSmall { get; set; }

        [DataMember(Name="noteheadSlashWhiteHalf")]
        public StemBoundaries NoteheadSlashWhiteHalf { get; set; }

        [DataMember(Name="noteheadSlashWhiteMuted")]
        public StemBoundaries NoteheadSlashWhiteMuted { get; set; }

        [DataMember(Name="noteheadSlashX")]
        public StemBoundaries NoteheadSlashX { get; set; }

        [DataMember(Name="noteheadSlashedBlack1")]
        public StemBoundaries NoteheadSlashedBlack1 { get; set; }

        [DataMember(Name="noteheadSlashedBlack2")]
        public StemBoundaries NoteheadSlashedBlack2 { get; set; }

        [DataMember(Name="noteheadSlashedDoubleWhole1")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadSlashedDoubleWhole1 { get; set; }

        [DataMember(Name="noteheadSlashedDoubleWhole2")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadSlashedDoubleWhole2 { get; set; }

        [DataMember(Name="noteheadSlashedHalf1")]
        public StemBoundaries NoteheadSlashedHalf1 { get; set; }

        [DataMember(Name="noteheadSlashedHalf2")]
        public StemBoundaries NoteheadSlashedHalf2 { get; set; }

        [DataMember(Name="noteheadSquareBlack")]
        public StemBoundaries NoteheadSquareBlack { get; set; }

        [DataMember(Name="noteheadSquareBlackLarge")]
        public StemBoundaries NoteheadSquareBlackLarge { get; set; }

        [DataMember(Name="noteheadSquareBlackWhite")]
        public StemBoundaries NoteheadSquareBlackWhite { get; set; }

        [DataMember(Name="noteheadSquareWhite")]
        public StemBoundaries NoteheadSquareWhite { get; set; }

        [DataMember(Name="noteheadTriangleDownBlack")]
        public StemBoundaries NoteheadTriangleDownBlack { get; set; }

        [DataMember(Name="noteheadTriangleDownDoubleWhole")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadTriangleDownDoubleWhole { get; set; }

        [DataMember(Name="noteheadTriangleDownHalf")]
        public StemBoundaries NoteheadTriangleDownHalf { get; set; }

        [DataMember(Name="noteheadTriangleDownWhite")]
        public StemBoundaries NoteheadTriangleDownWhite { get; set; }

        [DataMember(Name="noteheadTriangleLeftBlack")]
        public StemBoundaries NoteheadTriangleLeftBlack { get; set; }

        [DataMember(Name="noteheadTriangleLeftWhite")]
        public StemBoundaries NoteheadTriangleLeftWhite { get; set; }

        [DataMember(Name="noteheadTriangleRightBlack")]
        public StemBoundaries NoteheadTriangleRightBlack { get; set; }

        [DataMember(Name="noteheadTriangleRightWhite")]
        public StemBoundaries NoteheadTriangleRightWhite { get; set; }

        [DataMember(Name="noteheadTriangleRoundDownBlack")]
        public StemBoundaries NoteheadTriangleRoundDownBlack { get; set; }

        [DataMember(Name="noteheadTriangleRoundDownWhite")]
        public StemBoundaries NoteheadTriangleRoundDownWhite { get; set; }

        [DataMember(Name="noteheadTriangleUpBlack")]
        public StemBoundaries NoteheadTriangleUpBlack { get; set; }

        [DataMember(Name="noteheadTriangleUpDoubleWhole")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadTriangleUpDoubleWhole { get; set; }

        [DataMember(Name="noteheadTriangleUpHalf")]
        public StemBoundaries NoteheadTriangleUpHalf { get; set; }

        [DataMember(Name="noteheadTriangleUpRightBlack")]
        public StemBoundaries NoteheadTriangleUpRightBlack { get; set; }

        [DataMember(Name="noteheadTriangleUpRightWhite")]
        public StemBoundaries NoteheadTriangleUpRightWhite { get; set; }

        [DataMember(Name="noteheadTriangleUpWhite")]
        public StemBoundaries NoteheadTriangleUpWhite { get; set; }

        [DataMember(Name="noteheadVoidWithX")]
        public StemBoundaries NoteheadVoidWithX { get; set; }

        [DataMember(Name="noteheadWhole")]
        public CutOut NoteheadWhole { get; set; }

        [DataMember(Name="noteheadXBlack")]
        public StemBoundaries NoteheadXBlack { get; set; }

        [DataMember(Name="noteheadXDoubleWhole")]
        public GlyphsWithAnchorsNoteheadCircleXDoubleWhole NoteheadXDoubleWhole { get; set; }

        [DataMember(Name="noteheadXHalf")]
        public StemBoundaries NoteheadXHalf { get; set; }

        [DataMember(Name="noteheadXOrnate")]
        public StemBoundaries NoteheadXOrnate { get; set; }

        [DataMember(Name="noteheadXOrnateEllipse")]
        public StemBoundaries NoteheadXOrnateEllipse { get; set; }

        [DataMember(Name="ornamentBottomLeftConcaveStroke")]
        public RepeatDefinition OrnamentBottomLeftConcaveStroke { get; set; }

        [DataMember(Name="ornamentBottomLeftConcaveStrokeLarge")]
        public RepeatDefinition OrnamentBottomLeftConcaveStrokeLarge { get; set; }

        [DataMember(Name="ornamentBottomLeftConvexStroke")]
        public RepeatDefinition OrnamentBottomLeftConvexStroke { get; set; }

        [DataMember(Name="ornamentHighLeftConcaveStroke")]
        public RepeatDefinition OrnamentHighLeftConcaveStroke { get; set; }

        [DataMember(Name="ornamentHighLeftConvexStroke")]
        public RepeatDefinition OrnamentHighLeftConvexStroke { get; set; }

        [DataMember(Name="ornamentLeftPlus")]
        public RepeatDefinition OrnamentLeftPlus { get; set; }

        [DataMember(Name="ornamentLeftShakeT")]
        public RepeatDefinition OrnamentLeftShakeT { get; set; }

        [DataMember(Name="ornamentLeftVerticalStroke")]
        public RepeatDefinition OrnamentLeftVerticalStroke { get; set; }

        [DataMember(Name="ornamentLeftVerticalStrokeWithCross")]
        public RepeatDefinition OrnamentLeftVerticalStrokeWithCross { get; set; }

        [DataMember(Name="ornamentLowLeftConcaveStroke")]
        public RepeatDefinition OrnamentLowLeftConcaveStroke { get; set; }

        [DataMember(Name="ornamentLowLeftConvexStroke")]
        public RepeatDefinition OrnamentLowLeftConvexStroke { get; set; }

        [DataMember(Name="ornamentMiddleVerticalStroke")]
        public RepeatDefinition OrnamentMiddleVerticalStroke { get; set; }

        [DataMember(Name="ornamentTopLeftConcaveStroke")]
        public RepeatDefinition OrnamentTopLeftConcaveStroke { get; set; }

        [DataMember(Name="ornamentTopLeftConvexStroke")]
        public RepeatDefinition OrnamentTopLeftConvexStroke { get; set; }

        [DataMember(Name="ornamentZigZagLineNoRightEnd")]
        public RepeatDefinition OrnamentZigZagLineNoRightEnd { get; set; }

        [DataMember(Name="ornamentZigZagLineWithRightEnd")]
        public RepeatDefinition OrnamentZigZagLineWithRightEnd { get; set; }

        [DataMember(Name="wiggleArpeggiatoDown")]
        public RepeatDefinition WiggleArpeggiatoDown { get; set; }

        [DataMember(Name="wiggleArpeggiatoDownArrow")]
        public RepeatDefinition WiggleArpeggiatoDownArrow { get; set; }

        [DataMember(Name="wiggleArpeggiatoDownSwash")]
        public RepeatDefinition WiggleArpeggiatoDownSwash { get; set; }

        [DataMember(Name="wiggleArpeggiatoUp")]
        public RepeatDefinition WiggleArpeggiatoUp { get; set; }

        [DataMember(Name="wiggleArpeggiatoUpArrow")]
        public RepeatDefinition WiggleArpeggiatoUpArrow { get; set; }

        [DataMember(Name="wiggleArpeggiatoUpSwash")]
        public RepeatDefinition WiggleArpeggiatoUpSwash { get; set; }

        [DataMember(Name="wiggleCircular")]
        public RepeatDefinition WiggleCircular { get; set; }

        [DataMember(Name="wiggleCircularConstant")]
        public RepeatDefinition WiggleCircularConstant { get; set; }

        [DataMember(Name="wiggleCircularConstantFlipped")]
        public RepeatDefinition WiggleCircularConstantFlipped { get; set; }

        [DataMember(Name="wiggleCircularConstantFlippedLarge")]
        public RepeatDefinition WiggleCircularConstantFlippedLarge { get; set; }

        [DataMember(Name="wiggleCircularConstantLarge")]
        public RepeatDefinition WiggleCircularConstantLarge { get; set; }

        [DataMember(Name="wiggleCircularEnd")]
        public RepeatDefinition WiggleCircularEnd { get; set; }

        [DataMember(Name="wiggleCircularLarge")]
        public RepeatDefinition WiggleCircularLarge { get; set; }

        [DataMember(Name="wiggleCircularLarger")]
        public RepeatDefinition WiggleCircularLarger { get; set; }

        [DataMember(Name="wiggleCircularLargerStill")]
        public RepeatDefinition WiggleCircularLargerStill { get; set; }

        [DataMember(Name="wiggleCircularLargest")]
        public RepeatDefinition WiggleCircularLargest { get; set; }

        [DataMember(Name="wiggleCircularSmall")]
        public RepeatDefinition WiggleCircularSmall { get; set; }

        [DataMember(Name="wiggleCircularStart")]
        public RepeatDefinition WiggleCircularStart { get; set; }

        [DataMember(Name="wiggleGlissando")]
        public RepeatDefinition WiggleGlissando { get; set; }

        [DataMember(Name="wiggleGlissandoGroup1")]
        public RepeatDefinition WiggleGlissandoGroup1 { get; set; }

        [DataMember(Name="wiggleGlissandoGroup2")]
        public RepeatDefinition WiggleGlissandoGroup2 { get; set; }

        [DataMember(Name="wiggleGlissandoGroup3")]
        public RepeatDefinition WiggleGlissandoGroup3 { get; set; }

        [DataMember(Name="wiggleRandom1")]
        public RepeatDefinition WiggleRandom1 { get; set; }

        [DataMember(Name="wiggleRandom2")]
        public RepeatDefinition WiggleRandom2 { get; set; }

        [DataMember(Name="wiggleRandom3")]
        public RepeatDefinition WiggleRandom3 { get; set; }

        [DataMember(Name="wiggleRandom4")]
        public RepeatDefinition WiggleRandom4 { get; set; }

        [DataMember(Name="wiggleSawtooth")]
        public RepeatDefinition WiggleSawtooth { get; set; }

        [DataMember(Name="wiggleSawtoothNarrow")]
        public RepeatDefinition WiggleSawtoothNarrow { get; set; }

        [DataMember(Name="wiggleSawtoothWide")]
        public Wiggle WiggleSawtoothWide { get; set; }

        [DataMember(Name="wiggleSquareWave")]
        public Wiggle WiggleSquareWave { get; set; }

        [DataMember(Name="wiggleSquareWaveNarrow")]
        public Wiggle WiggleSquareWaveNarrow { get; set; }

        [DataMember(Name="wiggleSquareWaveWide")]
        public Wiggle WiggleSquareWaveWide { get; set; }

        [DataMember(Name="wiggleTrill")]
        public RepeatDefinition WiggleTrill { get; set; }

        [DataMember(Name="wiggleTrillFast")]
        public RepeatDefinition WiggleTrillFast { get; set; }

        [DataMember(Name="wiggleTrillFaster")]
        public RepeatDefinition WiggleTrillFaster { get; set; }

        [DataMember(Name="wiggleTrillFasterStill")]
        public RepeatDefinition WiggleTrillFasterStill { get; set; }

        [DataMember(Name="wiggleTrillFastest")]
        public RepeatDefinition WiggleTrillFastest { get; set; }

        [DataMember(Name="wiggleTrillSlow")]
        public RepeatDefinition WiggleTrillSlow { get; set; }

        [DataMember(Name="wiggleTrillSlower")]
        public RepeatDefinition WiggleTrillSlower { get; set; }

        [DataMember(Name="wiggleTrillSlowerStill")]
        public RepeatDefinition WiggleTrillSlowerStill { get; set; }

        [DataMember(Name="wiggleTrillSlowest")]
        public RepeatDefinition WiggleTrillSlowest { get; set; }

        [DataMember(Name="wiggleVIbratoLargestSlower")]
        public RepeatDefinition WiggleVIbratoLargestSlower { get; set; }

        [DataMember(Name="wiggleVIbratoMediumSlower")]
        public RepeatDefinition WiggleVIbratoMediumSlower { get; set; }

        [DataMember(Name="wiggleVibrato")]
        public RepeatDefinition WiggleVibrato { get; set; }

        [DataMember(Name="wiggleVibratoLargeFast")]
        public RepeatDefinition WiggleVibratoLargeFast { get; set; }

        [DataMember(Name="wiggleVibratoLargeFaster")]
        public RepeatDefinition WiggleVibratoLargeFaster { get; set; }

        [DataMember(Name="wiggleVibratoLargeFasterStill")]
        public RepeatDefinition WiggleVibratoLargeFasterStill { get; set; }

        [DataMember(Name="wiggleVibratoLargeFastest")]
        public RepeatDefinition WiggleVibratoLargeFastest { get; set; }

        [DataMember(Name="wiggleVibratoLargeSlow")]
        public RepeatDefinition WiggleVibratoLargeSlow { get; set; }

        [DataMember(Name="wiggleVibratoLargeSlower")]
        public RepeatDefinition WiggleVibratoLargeSlower { get; set; }

        [DataMember(Name="wiggleVibratoLargeSlowest")]
        public RepeatDefinition WiggleVibratoLargeSlowest { get; set; }

        [DataMember(Name="wiggleVibratoLargestFast")]
        public RepeatDefinition WiggleVibratoLargestFast { get; set; }

        [DataMember(Name="wiggleVibratoLargestFaster")]
        public RepeatDefinition WiggleVibratoLargestFaster { get; set; }

        [DataMember(Name="wiggleVibratoLargestFasterStill")]
        public RepeatDefinition WiggleVibratoLargestFasterStill { get; set; }

        [DataMember(Name="wiggleVibratoLargestFastest")]
        public RepeatDefinition WiggleVibratoLargestFastest { get; set; }

        [DataMember(Name="wiggleVibratoLargestSlow")]
        public RepeatDefinition WiggleVibratoLargestSlow { get; set; }

        [DataMember(Name="wiggleVibratoLargestSlowest")]
        public RepeatDefinition WiggleVibratoLargestSlowest { get; set; }

        [DataMember(Name="wiggleVibratoMediumFast")]
        public RepeatDefinition WiggleVibratoMediumFast { get; set; }

        [DataMember(Name="wiggleVibratoMediumFaster")]
        public RepeatDefinition WiggleVibratoMediumFaster { get; set; }

        [DataMember(Name="wiggleVibratoMediumFasterStill")]
        public RepeatDefinition WiggleVibratoMediumFasterStill { get; set; }

        [DataMember(Name="wiggleVibratoMediumFastest")]
        public RepeatDefinition WiggleVibratoMediumFastest { get; set; }

        [DataMember(Name="wiggleVibratoMediumSlow")]
        public RepeatDefinition WiggleVibratoMediumSlow { get; set; }

        [DataMember(Name="wiggleVibratoMediumSlowest")]
        public Wiggle WiggleVibratoMediumSlowest { get; set; }

        [DataMember(Name="wiggleVibratoSmallFast")]
        public RepeatDefinition WiggleVibratoSmallFast { get; set; }

        [DataMember(Name="wiggleVibratoSmallFaster")]
        public RepeatDefinition WiggleVibratoSmallFaster { get; set; }

        [DataMember(Name="wiggleVibratoSmallFasterStill")]
        public RepeatDefinition WiggleVibratoSmallFasterStill { get; set; }

        [DataMember(Name="wiggleVibratoSmallFastest")]
        public RepeatDefinition WiggleVibratoSmallFastest { get; set; }

        [DataMember(Name="wiggleVibratoSmallSlow")]
        public RepeatDefinition WiggleVibratoSmallSlow { get; set; }

        [DataMember(Name="wiggleVibratoSmallSlower")]
        public RepeatDefinition WiggleVibratoSmallSlower { get; set; }

        [DataMember(Name="wiggleVibratoSmallSlowest")]
        public RepeatDefinition WiggleVibratoSmallSlowest { get; set; }

        [DataMember(Name="wiggleVibratoSmallestFast")]
        public RepeatDefinition WiggleVibratoSmallestFast { get; set; }

        [DataMember(Name="wiggleVibratoSmallestFaster")]
        public RepeatDefinition WiggleVibratoSmallestFaster { get; set; }

        [DataMember(Name="wiggleVibratoSmallestFasterStill")]
        public RepeatDefinition WiggleVibratoSmallestFasterStill { get; set; }

        [DataMember(Name="wiggleVibratoSmallestFastest")]
        public RepeatDefinition WiggleVibratoSmallestFastest { get; set; }

        [DataMember(Name="wiggleVibratoSmallestSlow")]
        public RepeatDefinition WiggleVibratoSmallestSlow { get; set; }

        [DataMember(Name="wiggleVibratoSmallestSlower")]
        public RepeatDefinition WiggleVibratoSmallestSlower { get; set; }

        [DataMember(Name="wiggleVibratoSmallestSlowest")]
        public RepeatDefinition WiggleVibratoSmallestSlowest { get; set; }

        [DataMember(Name="wiggleVibratoStart")]
        public RepeatDefinition WiggleVibratoStart { get; set; }

        [DataMember(Name="wiggleVibratoWide")]
        public RepeatDefinition WiggleVibratoWide { get; set; }

        [DataMember(Name="wiggleWavy")]
        public Wiggle WiggleWavy { get; set; }

        [DataMember(Name="wiggleWavyNarrow")]
        public Wiggle WiggleWavyNarrow { get; set; }

        [DataMember(Name="wiggleWavyWide")]
        public Wiggle WiggleWavyWide { get; set; }
    }
}