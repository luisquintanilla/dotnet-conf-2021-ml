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
using Manufaktura.Music.Model;
using Manufaktura.Core.Xml;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    internal class DirectionParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "direction"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            var directionTypeNode = element.Elements().FirstOrDefault(e => e.Name.LocalName == "direction-type");
            if (directionTypeNode == null) return;
            DirectionPlaybackEffect playbackEffect = new DirectionPlaybackEffect();
            var soundNode = element.Elements().FirstOrDefault(e => e.Name.LocalName == "sound");
            if (soundNode != null)
            {
                soundNode.IfAttribute("tempo").HasValue<int>().Then(v => playbackEffect.Tempo = new Tempo(RhythmicDuration.Quarter, v));
                soundNode.IfAttribute("fine").HasAnyValue().Then(v => playbackEffect.IsFine = v == "yes");
                soundNode.IfAttribute("dalsegno").HasAnyValue().Then(v => playbackEffect.DalSegno = v);
            }

            foreach (var directionDefinitionNode in directionTypeNode.Elements())
            {
                Direction dir = new Direction();
                dir.PlaybackEffect = playbackEffect;
                dir.DefaultYPosition = 0;
                dir.Placement = DirectionPlacementType.Above;

                directionDefinitionNode.IfAttribute("default-y").HasValue<int>().Then(v =>
                {
                    dir.DefaultYPosition = v;
                    dir.Placement = DirectionPlacementType.Custom;
                });

                //Placement can suposedly be set both on direction-type node and it's subnodes:
                directionTypeNode.IfAttribute("placement")
                    .HasValue<DirectionPlacementType>(d =>
                    {
                        d.Add("above", DirectionPlacementType.Above);
                        d.Add("below", DirectionPlacementType.Below);
                        return d;
                    })
                  .Then(v => dir.Placement = v);

                directionDefinitionNode.IfAttribute("placement")
                    .HasValue<DirectionPlacementType>(d =>
                    {
                        d.Add("above", DirectionPlacementType.Above);
                        d.Add("below", DirectionPlacementType.Below);
                        return d;
                    })
                  .Then(v => dir.Placement = v);

                switch (directionDefinitionNode.Name.LocalName)
                {
                    case "dynamics":
                        dir.Text = directionTypeNode.Elements().FirstOrDefault()?.Name.LocalName;
                        break;

                    case "words":
                        dir.Text = directionTypeNode.Value;
                        break;
                }

                staff.Elements.Add(dir);
            }
        }
    }
}