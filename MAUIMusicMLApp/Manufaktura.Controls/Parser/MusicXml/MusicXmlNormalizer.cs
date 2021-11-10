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
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    public class MusicXmlNormalizer : XTransformerParser
    {
        public bool NormalizeSpaceBeforeFirstNotesOfMeasures { get; set; }

        public override XDocument Parse(XDocument source)   //TODO: Przetestować dokładnie i zrefaktorować
        {
#if CSHTML5
            throw new NotImplementedException("This method is not yet implemented for CSHTML5.");
#else

            if (!NormalizeSpaceBeforeFirstNotesOfMeasures) return source;
            if (source.Descendants(XName.Get("repeat")).Any()) return source; //Workaround - pomiń na razie te ze znakiem repetycji, bo się źle rysują
            if (source.Descendants(XName.Get("time")).Count() > 1) return source; //Workaround - pomiń na razie te ze zmianami metrum, bo się źle rysują

            foreach (XElement staffNode in source.Descendants(XName.Get("part")))
            {
                //
                // FIRST PASS: Determine median note default-x
                //
                List<double> measureWidths = new List<double>();
                List<double> spacesBeforeFirstNoteOfMeasure = new List<double>();
                foreach (XElement measureNode in staffNode.Descendants(XName.Get("measure")).Skip(1)) //Don't remove space in first measure
                {
                    //if (measureNode.Elements(XName.Get("barline")).Any()) continue; //Nie bierz pod uwagi tych ze znakami repetycji, itp.
                    //TODO: Nie uwzględniać taktu, który następuje zaraz po zmianie metrum/klucza/znaków przykluczowych

                    //Read widths of all measures:
                    double? measureWidth = null;
                    var widthAttribute = measureNode.Attributes().FirstOrDefault(a => a.Name == "width");
                    if (widthAttribute != null) measureWidth = UsefulMath.TryParse(widthAttribute.Value);
                    if (measureWidth.HasValue) measureWidths.Add(measureWidth.Value);

                    XElement firstNoteNode = measureNode.Descendants(XName.Get("note")).FirstOrDefault();
                    if (firstNoteNode != null)
                    {
                        double? noteDefaultX = null;
                        var defaultXAttribute = firstNoteNode.Attributes().FirstOrDefault(a => a.Name == "default-x");
                        if (defaultXAttribute != null) noteDefaultX = UsefulMath.TryParse(defaultXAttribute.Value);
                        if (noteDefaultX.HasValue) spacesBeforeFirstNoteOfMeasure.Add(noteDefaultX.Value);
                    }
                }
                double medianNoteDefaultX = UsefulMath.Median(spacesBeforeFirstNoteOfMeasure.ToArray());
                double averageNoteDefaultX = UsefulMath.Mean(spacesBeforeFirstNoteOfMeasure.ToArray());

                //
                // SECOND PASS: Apply calculated median note default-x to all measures
                //
                //TODO: Nie uwzględniać taktu, który następuje zaraz po zmianie metrum/klucza/znaków przykluczowych
                foreach (XElement measureNode in staffNode.Descendants(XName.Get("measure")).Skip(1))   //Don't remove space in first measure
                {
                    //if (measureNode.Elements(XName.Get("barline")).Any()) continue; //Nie bierz pod uwagi tych ze znakami repetycji, itp.

                    double? currentValue = null;
                    XElement firstNoteNode = measureNode.Descendants(XName.Get("note")).FirstOrDefault();
                    if (firstNoteNode == null) continue;

                    var defaultXAttribute = firstNoteNode.Attributes().FirstOrDefault(a => a.Name == "default-x");
                    if (defaultXAttribute == null) continue;

                    currentValue = UsefulMath.TryParse(defaultXAttribute.Value);
                    if (!currentValue.HasValue) continue;
                    double difference = currentValue.Value - medianNoteDefaultX;

                    if (currentValue > averageNoteDefaultX)
                    {
                        foreach (var noteNode in measureNode.Descendants(XName.Get("note")))
                        {
                            defaultXAttribute = noteNode.Attributes().FirstOrDefault(a => a.Name == "default-x");
                            if (defaultXAttribute == null) continue;

                            currentValue = UsefulMath.TryParse(defaultXAttribute.Value);
                            if (!currentValue.HasValue) continue;

                            defaultXAttribute.Value = (currentValue.Value - difference).ToString(CultureInfo.InvariantCulture);
                        }
                        var widthAttribute = measureNode.Attributes().FirstOrDefault(a => a.Name == "width");
                        currentValue = UsefulMath.TryParse(widthAttribute.Value);
                        if (!currentValue.HasValue) continue;
                        if (widthAttribute != null) widthAttribute.Value = (currentValue.Value - difference).ToString(CultureInfo.InvariantCulture);
                    }
                }
            }
            return source;
#endif
        }

        public override XDocument ParseBack(XDocument score)
        {
            throw new NotImplementedException();
        }
    }
}