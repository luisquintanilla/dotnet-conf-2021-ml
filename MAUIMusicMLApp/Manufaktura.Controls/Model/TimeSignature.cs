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
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Music.Model;

namespace Manufaktura.Controls.Model
{
    public class TimeSignature : MusicalSymbol, IRenderedAsTextBlock
    {
        protected Proportion numberValue;
        protected TimeSignatureType signatureType;

        public TimeSignature(TimeSignatureType sType, int beats, int beatType)
        {
            numberValue = new Proportion(beats, beatType);
            signatureType = sType;
        }

        public static TimeSignature CommonTime => new TimeSignature(TimeSignatureType.Common, 4, 4);

        public static TimeSignature CutTime => new TimeSignature(TimeSignatureType.Cut, 2, 2);

        public int NumberOfBeats { get { return numberValue.Numerator; } }

        public Proportion NumberValue { get { return numberValue; } set { numberValue = value; OnPropertyChanged(); } }

        public TimeSignatureType SignatureType { get { return signatureType; } set { signatureType = value; } }

        public Point TextBlockLocation { get; internal set; }
        public int TypeOfBeats { get { return numberValue.Denominator; } }

        /// <summary>
        /// Returns how many whole notes can be fitted into one measure.
        /// </summary>
        public double WholeNoteCapacity => numberValue.DoubleValue;

        public char GetCharacter(IMusicFont font)
        {
            if (SignatureType == TimeSignatureType.Common) return font.CommonTime;
            else if (SignatureType == TimeSignatureType.Cut) return font.CutTime;
            else return '\0';
        }
    }
}