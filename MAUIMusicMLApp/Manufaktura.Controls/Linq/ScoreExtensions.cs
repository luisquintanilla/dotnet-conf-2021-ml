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
using Manufaktura.Controls.Parser;
using Manufaktura.Controls.Parser.Digest;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Linq
{
    /// <summary>
    /// Extensions methods for operations on Scores
    /// </summary>
	public static class ScoreExtensions
    {
        public static Quadrangle GetBounds(this IEnumerable<Note> notes, ScoreRendererBase renderer)
        {
            if (!notes.Any()) return default(Quadrangle);

            var boundsCollection = notes.Select(n => n.GetBounds(renderer)).ToArray();
            var bounds = new Quadrangle(
                boundsCollection.Last().NE,
                boundsCollection.First().NW,
                boundsCollection.Last().SE,
                boundsCollection.First().SW);
            var lowestB = bounds.SW.Y > bounds.SE.Y ? bounds.SW.Y : bounds.SE.Y;
            var highestB = bounds.NW.Y < bounds.NE.Y ? bounds.NW.Y : bounds.NE.Y;

            var lowest = boundsCollection.Max(b => b.SW.Y);
            var highest = boundsCollection.Min(b => b.NW.Y);

            var deltaYL = lowest - lowestB;
            var deltaYH = highest - highestB;

            return new Quadrangle(
                new Point(bounds.NE.X, bounds.NE.Y + deltaYH),
                new Point(bounds.NW.X, bounds.NW.Y + deltaYH),
                new Point(bounds.SE.X, bounds.SE.Y + deltaYL),
                new Point(bounds.SW.X, bounds.SW.Y + deltaYL));
        }

        /// <summary>
        /// Returns the largest denominator (pulse) of note collection
        /// </summary>
        /// <param name="noteOrRests"></param>
        /// <returns></returns>
        public static double Pulse(this IEnumerable<NoteOrRest> noteOrRests)
        {
            return noteOrRests.Max(n => n.BaseDuration.Denominator);
        }

        /// <summary>
        /// Creates a Score from stream.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static Score ReadMusicXmlScoreToEnd(this StreamReader reader)
        {
            return ToScore(reader.ReadToEnd());
        }

        /// <summary>
        /// Returns interval array obtained from MelodicContourDigestParser
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
		public static int[] ToIntervals(this Score score)
        {
            MelodicContourDigestParser parser = new MelodicContourDigestParser();
            return parser.ParseBack(score);
        }

        /// <summary>
        /// Returns lyrics digest obtained by LyricsDigestParser
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
		public static string ToLyricsDigest(this Score score)
        {
            LyricsDigestParser parser = new LyricsDigestParser();
            return parser.ParseBack(score);
        }

        /// <summary>
        /// Calculates rhythmic digest of specified score.
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public static string ToRhythmDigest(this Score score)
        {
            RhythmDigestParser parser = new RhythmDigestParser();
            return parser.ParseBack(score);
        }

        /// <summary>
        /// Returns rhythm digest obtained with RhythmDigestParser
        /// </summary>
        /// <param name="score"></param>
        /// <param name="markRests"></param>
        /// <param name="includeBarlines"></param>
        /// <returns></returns>
		public static string ToRhythmDigest(this Score score, bool markRests, bool includeBarlines)
        {
            RhythmDigestParser parser = new RhythmDigestParser { MarkRests = markRests, IncludeBarlines = includeBarlines };
            return parser.ParseBack(score);
        }

        /// <summary>
        /// Converts MusicXml string to Score.
        /// </summary>
        /// <param name="document">MuicXml document as string</param>
        /// <returns>Score</returns>
        public static Score ToScore(this string document)
        {
            return ToScore(XDocument.Parse(document));
        }

        /// <summary>
        /// Converts MusicXML string to Score
        /// </summary>
        /// <param name="document"></param>
        /// <param name="transformer"></param>
        /// <returns></returns>
		public static Score ToScore(this string document, XTransformerParser transformer)
        {
            return ToScore(XDocument.Parse(document), transformer);
        }

        /// <summary>
        /// Converts MusicXml XDocument to Score
        /// </summary>
        /// <param name="document"></param>
        /// <returns></returns>
		public static Score ToScore(this XDocument document)
        {
            return ToScore(document, null);
        }

        /// <summary>
        /// Reads a score from MusicXml document with specific XTransformerParser.
        /// </summary>
        /// <param name="document"></param>
        /// <param name="transformer"></param>
        /// <returns></returns>
        public static Score ToScore(this XDocument document, XTransformerParser transformer)
        {
            MusicXmlParser parser = new MusicXmlParser();
            if (transformer != null)
            {
                document = transformer.Parse(document);
            }
            return parser.Parse(document);
        }
    }
}