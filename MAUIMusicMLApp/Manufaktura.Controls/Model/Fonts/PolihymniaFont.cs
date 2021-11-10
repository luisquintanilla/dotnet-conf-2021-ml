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

using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Controls.Rendering;
using System;

namespace Manufaktura.Controls.Model.Fonts
{
    /// <summary>
    /// Character mapping for font Polihymnia
    /// </summary>
    public class PolihymniaFont : IMusicFont
    {
        public bool IsSMuFLFont => false;

        public static PolihymniaFontProfile CreateProfile() => new PolihymniaFontProfile();

        public char AugmentationDot => '.';
        public char BraceLeft => '{';
        public char BraceRight => '}';
        public char CClef => 'K';
        public char CClef15ma => CClef;
        public char CClef15mb => CClef;
        public char CClef8va => CClef;
        public char CClef8vb => CClef;
        public char CommonTime => 'c';
        public char CutTime => 'C';
        public char DoubleFlat => 'B';
        public char DoubleSharp => 'x';
        public char FClef => '?';
        public char FClef15ma => FClef;
        public char FClef15mb => FClef;
        public char FClef8va => FClef;
        public char FClef8vb => FClef;
        public char FermataDown => 'Z';
        public char FermataUp => 'Y';
        public char Flat => 'b';
        public char GClef => 'G';
        public char GClef15ma => GClef;
        public char GClef15mb => GClef;
        public char GClef8va => GClef;
        public char GClef8vb => GClef;
        public char Mordent => 'm';
        public char MordentInverted => 'm';
        public char MordentShort => 'n';
        public char Natural => 'k';
        public char NoteDoubleWhole => 'w';
        public char NoteDoubleWholeCue => 'w';
        public char NoteDoubleWholeLarge => 'w';
        public char NoteEighth => 'e';
        public char NoteFlag128th => '5';
        public char NoteFlag128thRev => '%';
        public char NoteFlag32nd => '3';
        public char NoteFlag32ndRev => '#';
        public char NoteFlag64th => '4';
        public char NoteFlag64thRev => '$';
        public char NoteFlagEighth => '1';
        public char NoteFlagEighthRev => '!';
        public char NoteFlagSixteenth => '2';
        public char NoteFlagSixteenthRev => '@';
        public char NoteHalf => 'h';
        public char NoteheadBlack => '0';
        public char NoteheadBlackCue => '0';
        public char NoteheadBlackLarge => '0';
        public char NoteheadHalf => '9';
        public char NoteheadHalfCue => 'h';
        public char NoteheadHalfLarge => 'h';
        public char NoteQuarter => 'q';
        public char NoteSixteenth => 's';
        public char NoteWhole => 'w';
        public char NoteWholeCue => 'w';
        public char NoteWholeLarge => 'w';
        public char PercussionClef => '\0';
        public char RepeatBackward => 'l';
        public char RepeatForward => '\\';
        public char Rest32nd => 'T';
        public char RestEighth => 'E';
        public char RestHalf => 'H';
        public char RestQuarter => 'Q';
        public char RestSixteenth => 'S';
        public char RestWhole => 'W';
        public char RestMultimeasure => 'W';
        public char Sharp => 'X';
        public char SquareBracketLeft => '[';
        public char Staff4Lines => '_';

        public char Staff5Lines => '=';

        public char Trill => 'r';

        public string BuildTimeSignature(int number) => Convert.ToString(number);

        public string BuildTupletNumber(int number) => Convert.ToString(number);

        public double GetTupletNumberWidthLs(ISMuFLFontMetadata metadata, int number)
        {
            throw new NotImplementedException();
        }

        public double GetTupletNumberWidthPx(ScoreRendererBase renderer, int number)
        {
            throw new NotImplementedException();
        }

        public double GetTimeSignatureNumberWidthLs(ISMuFLFontMetadata metadata, int number)
        {
            throw new NotImplementedException();
        }

        public double GetTimeSignatureNumberWidthPx(ScoreRendererBase renderer, int number)
        {
            throw new NotImplementedException();
        }
    }
}