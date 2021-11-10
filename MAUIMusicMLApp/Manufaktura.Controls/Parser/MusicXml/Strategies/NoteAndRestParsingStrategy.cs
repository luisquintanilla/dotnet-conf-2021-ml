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
using Manufaktura.Controls.Model.Builders;
using Manufaktura.Controls.Model.Exceptions;
using Manufaktura.Music.Model;
using Manufaktura.Core.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    internal class NoteAndRestParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName => "note";

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            var builder = new NoteOrRestBuilder(state);

            element.IfAttribute("default-x").HasValue<double>().Then(m => builder.DefaultX = m);
            element.IfAttribute("measure").HasValue("yes").Then(m => builder.FullMeasure = true);
            element.IfAttribute("print-object").HasValue(new Dictionary<string, bool> {
                {"yes", true}, {"no", false}}).Then(m => builder.IsVisible = m);
            element.IfAttribute("size").HasValue(new Dictionary<string, NoteOrRestSize>
            {
                { "cue", NoteOrRestSize.Cue },
                { "full", NoteOrRestSize.Full },
                { "large", NoteOrRestSize.Large },
            }).Then(s => builder.Size = s);
            element.IfElement("staff").HasValue<int>().Then(m => builder.Staff = staff.Part.Staves.ElementAt(m - 1));
            element.IfElement("type").HasValue(new Dictionary<string, RhythmicDuration> {
                 { "breve", RhythmicDuration.DoubleWhole },
                 { "whole", RhythmicDuration.Whole },
                 { "half", RhythmicDuration.Half },
                 { "quarter",  RhythmicDuration.Quarter },
                 { "eighth", RhythmicDuration.Eighth },
                 { "16th",  RhythmicDuration.Sixteenth },
                 { "32nd",  RhythmicDuration.D32nd },
                 { "64th",  RhythmicDuration.D64th },
                 { "128th",  RhythmicDuration.D128th }}).Then(m => builder.BaseDuration = m);
            var typeElement = element.GetElement("type");
            if (typeElement != null)
            {
                typeElement.IfAttribute("size").HasValue(new Dictionary<string, NoteOrRestSize>
                {
                    { "cue", NoteOrRestSize.Cue },
                    { "full", NoteOrRestSize.Full },
                    { "large", NoteOrRestSize.Large },
                }).Then(s => builder.Size = s);   //"size" attribute apparently can be added to element "type" too
            }

            element.IfElement("voice").HasValue<int>().Then(m => builder.Voice = m);
            var graceElement = element.GetElement("grace");
            if (graceElement != null)
            {
                graceElement.IfAttribute("slash").HasValue("yes")
                    .Then(v => builder.GraceNoteType = GraceNoteType.Slashed)
                    .Otherwise(v => builder.GraceNoteType = GraceNoteType.Simple);
            }
            element.IfElement("chord").Exists().Then(() => builder.IsChordElement = true);
            element.IfElement("accidental").HasValue("natural").Then(() => builder.HasNatural = true);
            element.IfElement("rest").Exists().Then(() => builder.IsRest = true);
            element.ForEachDescendant("dot", f => f.Exists().Then(() => builder.NumberOfDots++));

            var pitchElement = element.IfElement("pitch").Exists().ThenReturnResult();
            pitchElement.IfElement("step").HasAnyValue().Then(v => builder.Step = v);
            pitchElement.IfElement("octave").HasValue<int>().Then(v => builder.Octave = v);
            pitchElement.IfElement("alter").HasValue<int>().Then(v => builder.Alter = v);

            var unpitchedElement = element.IfElement("unpitched").Exists().Then(x => builder.IsUnpitched = true).AndReturnResult();
            unpitchedElement.IfElement("display-step").HasAnyValue().Then(v => builder.Step = v);
            unpitchedElement.IfElement("display-octave").HasValue<int>().Then(v => builder.Octave = v);
            unpitchedElement.IfElement("display-alter").HasValue<int>().Then(v => builder.Alter = v);

            var tieElements = element.Elements().Where(e => e.Name == "tie");
            foreach (var tieElement in tieElements)
            {
                tieElement.IfAttribute("type").HasValue("start").Then(v =>
                {
                    if (builder.TieType == NoteTieType.Stop) builder.TieType = NoteTieType.StopAndStartAnother;
                    else builder.TieType = NoteTieType.Start;
                }).Otherwise(r => builder.TieType = NoteTieType.Stop);
            }

            element.IfElement("stem").HasValue("down")
                .Then(() => builder.StemDirection = VerticalDirection.Down)
                .Otherwise(r => builder.StemDirection = VerticalDirection.Up);
            element.GetElement("stem").IfAttribute("default-y").HasValue<float>().Then(v =>
                {
                    builder.StemDefaultY = v;
                    builder.CustomStemEndPosition = true;
                });

            element.ForEachDescendant("beam", h => h.HasValue(new Dictionary<string, NoteBeamType> {
                {"begin", NoteBeamType.Start},
                {"end", NoteBeamType.End},
                {"continue", NoteBeamType.Continue},
                {"forward hook", NoteBeamType.ForwardHook},
                {"backward hook", NoteBeamType.BackwardHook}
            }).Then(v => builder.BeamList.Add(v))
              .Otherwise(r => { if (r.ToLowerInvariant() != "single") throw new ScoreException(builder, $"Unsupported beam type \"{r}\"."); }));

            var notationsNode = element.GetElement("notations");
            var tupletNode = notationsNode.GetElement("tuplet");
            tupletNode.IfAttribute("type").HasValue(new Dictionary<string, TupletType> {
                        {"start", TupletType.Start},
                        {"stop", TupletType.Stop},
                    }).Then(v => builder.Tuplet = v);
            tupletNode.IfAttribute("placement").HasValue(new Dictionary<string, VerticalPlacement> {
                        {"above", VerticalPlacement.Above},
                        {"below", VerticalPlacement.Below},
                    }).Then(v => builder.TupletPlacement = v);

            notationsNode.IfElement("fermata").Exists().Then(() => builder.HasFermataSign = true);
            notationsNode.IfElement("sound").Exists().Then(e => e.IfAttribute("dynamics").HasValue<int>().Then(v => state.CurrentDynamics = v));

            notationsNode.IfHasElement("dynamics").Then(d =>
            {
                var dir = new Direction();
                d.IfAttribute("default-y").HasValue<int>().Then(v =>
                {
                    dir.DefaultYPosition = v;
                    dir.Placement = DirectionPlacementType.Custom;
                });
                d.IfAttribute("placement").HasValue(new Dictionary<string, DirectionPlacementType>
                {
                    {"above", DirectionPlacementType.Above},
                    {"below", DirectionPlacementType.Below}
                }).Then(v =>
                {
                    if (dir.Placement != DirectionPlacementType.Custom) dir.Placement = v;
                });
                foreach (XElement dynamicsType in d.Elements())
                {
                    dir.Text = dynamicsType.Name.LocalName;
                }
                staff.Elements.Add(dir);
            });

            notationsNode.IfHasElement("articulations").Then(d =>
            {
                d.IfElement("staccato").HasAnyValue().Then(() => builder.Articulation = ArticulationType.Staccato);
                d.IfElement("accent").HasAnyValue().Then(() => builder.Articulation = ArticulationType.Accent);
                d.IfAttribute("placement").HasValue(new Dictionary<string, VerticalPlacement> {
                        {"above", VerticalPlacement.Above},
                        {"below", VerticalPlacement.Below},
                    }).Then(v => builder.ArticulationPlacement = v);
            });

            var ornamentsNode = notationsNode.GetElement("ornaments");
            ornamentsNode.GetElement("trill-mark").IfAttribute("placement").HasValue(new Dictionary<string, NoteTrillMark> {
                {"above", NoteTrillMark.Above},
                {"below", NoteTrillMark.Below}
            }).Then(v => builder.TrillMark = v);
            ornamentsNode.IfElement("tremolo").HasValue<int>().Then(v => builder.TremoloLevel = v);

            var invMordentNode = ornamentsNode
                .IfElement("inverted-mordent")
                .Exists()
                .Then(e => builder.Mordent = new Mordent() { IsInverted = true })
                .AndReturnResult();
            invMordentNode.IfAttribute("placement").HasValue(new Dictionary<string, VerticalPlacement> {
                {"above", VerticalPlacement.Above},
                {"below", VerticalPlacement.Below}
            }).Then(v => builder.Mordent.Placement = v);
            invMordentNode.IfAttribute("default-x").HasValue<double>().Then(v => builder.Mordent.DefaultXPosition = v);
            invMordentNode.IfAttribute("default-y").HasValue<double>().Then(v => builder.Mordent.DefaultYPosition = v);

            foreach (var slurNode in notationsNode?.Elements().Where(e => e.Name == "slur") ?? new XElement[] { })
            {
                var slur = new Slur();
                builder.Slurs.Add(slur);
                slurNode.IfAttribute("number").HasValue<int>().Then(v => slur.Number = v);
                slurNode.IfAttribute("type").HasValue(new Dictionary<string, NoteSlurType> {
                    {"start", NoteSlurType.Start},
                    {"stop", NoteSlurType.Stop}
                }).Then(v => slur.Type = v);
                slurNode.IfAttribute("placement").HasValue(new Dictionary<string, VerticalPlacement> {
                    {"above", VerticalPlacement.Above},
                    {"below", VerticalPlacement.Below}
                }).Then(v => slur.Placement = v);
                slurNode.IfAttribute("default-x").HasValue<double>().Then(v => slur.DefaultXPosition = v);
                slurNode.IfAttribute("default-y").HasValue<double>().Then(v => slur.DefaultYPosition = v);
                slurNode.IfAttribute("bezier-x").HasValue<double>().Then(v => slur.BezierX = v);
                slurNode.IfAttribute("bezier-y").HasValue<double>().Then(v => slur.BezierY = v);
            }

            foreach (var lNode in element.Elements().Where(n => n.Name == "lyric"))
            {
                //There can be more than one lyrics in one <lyrics> tag. Add lyrics to list once syllable type and text is set.
                //Then reset these tags so the next <syllabic> tag starts another lyric.
                Lyrics lyricsInstance = new Lyrics();
                Lyrics.Syllable syllable = new Lyrics.Syllable();
                bool isSylabicSet = false;
                bool isTextSet = false;
                var defaultYattribute = lNode.Attributes().FirstOrDefault(a => a.Name == "default-y");
                if (defaultYattribute != null) lyricsInstance.DefaultYPosition = UsefulMath.TryParse(defaultYattribute.Value);

                foreach (XElement lyricAttribute in lNode.Elements())
                {
                    if (lyricAttribute.Name == "syllabic")
                    {
                        if (lyricAttribute.Value == "begin") syllable.Type = SyllableType.Begin;
                        else if (lyricAttribute.Value == "middle") syllable.Type = SyllableType.Middle;
                        else if (lyricAttribute.Value == "end") syllable.Type = SyllableType.End;
                        else if (lyricAttribute.Value == "single") syllable.Type = SyllableType.Single;
                        isSylabicSet = true;
                    }
                    else if (lyricAttribute.Name == "text")
                    {
                        syllable.Text = lyricAttribute.Value;
                        isTextSet = true;
                    }
                    else if (lyricAttribute.Name == "elision")
                    {
                        syllable.ElisionMark = lyricAttribute.Value;
                    }

                    if (isSylabicSet && isTextSet)
                    {
                        lyricsInstance.Syllables.Add(syllable);
                        syllable = new Lyrics.Syllable();
                        isSylabicSet = false;
                        isTextSet = false;
                    }
                }

                builder.Lyrics.Add(lyricsInstance);
            }

            if (builder.BeamList.Count == 0) builder.BeamList.Add(NoteBeamType.Single);

            var noteOrRest = builder.Build();

            var correctStaff = noteOrRest.Staff ?? staff;
            correctStaff.Elements.Add(noteOrRest);
        }
    }
}