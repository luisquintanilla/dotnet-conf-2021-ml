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
using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Music.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering.Implementations
{
    /// <summary>
    /// Score renderer that renders scores to HTML
    /// </summary>
    /// <typeparam name="TCanvas"></typeparam>
	public abstract class HtmlScoreRenderer<TCanvas> : ScoreRenderer<TCanvas>
    {
        protected TimelineElement<IHasDuration>[] currentPlaybackTimeline;

        protected HtmlScoreRenderer(TCanvas canvas)
            : base(canvas)
        {
        }

        public double ClippedAreaY { get; protected set; }

        /// <summary>
        /// Height of rendered score
        /// </summary>
		public double ActualHeight { get; protected set; } = 0;

        /// <summary>
        /// Width of rendered score
        /// </summary>
        public double ActualWidth { get; protected set; } = 0;

        public string ScoreElementName { get; set; }

        /// <summary>
        /// Settings cast to HtmlScoreRendererSettings
        /// </summary>
		public HtmlScoreRendererSettings TypedSettings { get { return Settings as HtmlScoreRendererSettings; } }

        protected override void BeforeRenderScore(Score score)
        {
            base.BeforeRenderScore(score);
            currentPlaybackTimeline = new VirtualScorePlayer(score, new Tempo(RhythmicDuration.Quarter, TypedSettings.PlaybackTempo)).CreateTimeline();
        }

        /// <summary>
        /// Creates DOM id for a specific MusicalSymbol
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
		protected string BuildElementId(MusicalSymbol element)
        {
            var sb = new StringBuilder();
            sb.Append($"scoreElement_{element.LongId}");
            return sb.ToString();
        }

        /// <summary>
        /// Builds playback information for JS based MIDI players for a specific MusicalSymbol
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
		protected Dictionary<string, string> BuildPlaybackAttributes(MusicalSymbol element)
        {
            var dict = new Dictionary<string, string>();

            var durationElement = element as IHasDuration;
            if (durationElement != null)
            {
                var timelineElements = currentPlaybackTimeline.Where(p => p.What == durationElement).ToArray();
                if (timelineElements.Any())
                {
                    //In most cases there will be one start point for one element. The next ones are for repetitions.
                    var playbackStartPoints = string.Join(" ", timelineElements.Select(te => (long)te.When.TotalMilliseconds));

                    var duration = new RhythmicDuration(durationElement.BaseDuration.DenominatorAsPowerOfTwo, durationElement.NumberOfDots).ToTimeSpan(new Tempo(RhythmicDuration.Quarter, TypedSettings.PlaybackTempo));
                    dict.Add("data-playback-start", playbackStartPoints);
                    dict.Add("data-playback-duration", ((long)duration.TotalMilliseconds).ToString());
                }
            }

            var midiPitchElement = element as IHasPitch;
            if (midiPitchElement != null)
            {
                dict.Add("data-midi-pitch", midiPitchElement.Pitch.MidiPitch.ToString());
            }

            return dict;
        }

        protected Primitives.Point TranslateTextLocation(Primitives.Point location, MusicFontStyles fontStyle)
        {
            double locationX = location.X + TypedSettings.MusicalFontShiftX;
            double locationY = location.Y + TypedSettings.MusicalFontShiftY;
            return new Primitives.Point(locationX, locationY);
        }
    }
}