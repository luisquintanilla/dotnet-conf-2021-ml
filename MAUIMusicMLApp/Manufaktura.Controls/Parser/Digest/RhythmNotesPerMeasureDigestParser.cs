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
using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Parser.Digest
{
    class RhythmNotesPerMeasureDigestParser : ScoreParser<double[]>
    {
        public override Model.Score Parse(double[] source)
        {
            throw new NotImplementedException();
        }

        public override double[] ParseBack(Score score) //TODO: Dokończyć
        {
            List<double> digest = new List<double>();
            int timeSignatureBase = 4;
            double remainingRhythmicPart = 0;
            foreach (Staff staff in score.Staves)
            {
                foreach (var element in staff.Elements)
                {
                    TimeSignature timeSignature = element as TimeSignature;
                    if (timeSignature != null)
                    {
                        timeSignatureBase = (int)timeSignature.TypeOfBeats;
                        continue;
                    }
                    IHasDuration rhythmicElement = element as IHasDuration;
                    if (rhythmicElement == null) continue;

                    double fractionOfMeasure = timeSignatureBase / (double)rhythmicElement.BaseDuration.Denominator;
                    if (rhythmicElement.NumberOfDots > 0)
                    {
                        fractionOfMeasure += fractionOfMeasure * (1 / Math.Pow(2, rhythmicElement.NumberOfDots));
                    }
                    //TODO: Obsłużyć też wiązanie nut łukami

                    int numberOfPartsOccupied = (int)Math.Ceiling(fractionOfMeasure);
                    while (fractionOfMeasure > 0)
                    {
                        remainingRhythmicPart = 1 / fractionOfMeasure;
                        digest.Add(remainingRhythmicPart);
                        fractionOfMeasure -= 1;
                    }
                }
            }
            return digest.ToArray();
        }
    }
}
