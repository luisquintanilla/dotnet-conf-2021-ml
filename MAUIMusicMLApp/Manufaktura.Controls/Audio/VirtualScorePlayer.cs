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
using System;
using System.Linq;

namespace Manufaktura.Controls.Audio
{
	/// <summary>
	/// Score player used only for generating timeline as an array which can be used for various purposes.
    /// Currently it's only used by HtmlScoreRenderer to generate HTML attributes that guide playback performed by JS-based client-side MIDI player.
    /// VirtualScorePlayer can't perform playback by itself so Play, Pause and Stop methods throw an exception.
	/// </summary>
	public class VirtualScorePlayer : ScorePlayer
	{
        /// <summary>
        /// Initializes a new instance of VirtualScorePlayer for specific playback tempo
        /// </summary>
        /// <param name="score"></param>
        /// <param name="tempo"></param>
		public VirtualScorePlayer(Score score, Tempo tempo) : base(score)
		{
			Tempo = tempo;
		}

        /// <summary>
        /// Creates a timeline array
        /// </summary>
        /// <returns></returns>
		public TimelineElement<IHasDuration>[] CreateTimeline()
		{
			return EnumerateTimeline().ToArray();
		}

        /// <summary>
        /// This method is not relevant for this type of player. It always throws NotImplementedException.
        /// </summary>
		public override void Pause()
		{
			throw new NotImplementedException();
		}

        /// <summary>
        /// This method is not relevant for this type of player. It always throws NotImplementedException.
        /// </summary>
        public override void Play()
		{
			throw new NotImplementedException();
		}

        /// <summary>
        /// This method is not relevant for this type of player. It always throws NotImplementedException.
        /// </summary>
        public override void PlayElement(MusicalSymbol element)
		{
			throw new NotImplementedException();
		}

        /// <summary>
        /// This method is not relevant for this type of player. It always throws NotImplementedException.
        /// </summary>
        public override void Stop()
		{
			throw new NotImplementedException();
		}
	}
}