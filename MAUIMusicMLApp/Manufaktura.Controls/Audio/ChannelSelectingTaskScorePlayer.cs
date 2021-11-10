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
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Audio
{
    /// <summary>
    /// TaskScorePlayer that automatically selects MIDI channels
    /// </summary>
    public abstract class ChannelSelectingTaskScorePlayer : TaskScorePlayer
    {
        protected Dictionary<int, List<int>> pitchesPlaying;

        public ChannelSelectingTaskScorePlayer(Score score) : base(score)
        {
            pitchesPlaying = Enumerable.Range(0, ChannelsCount).ToDictionary(i => i, i => new List<int>());
        }

        private int ChannelsCount => Score.Staves.Count < 5 ? Score.Staves.Count * 2 : Score.Staves.Count * 2 + 2;
        protected int GetChannelNumber(int staffIndex)
        {
            var channelIndex = staffIndex * 2;
            if (channelIndex > 7) channelIndex += 2;
            return channelIndex;
        }
    }
}