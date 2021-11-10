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
using Manufaktura.Controls.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Score auxiliary information.
    /// </summary>
    public class ScoreInfo
    {
        /// <summary>
        /// All measures in the score (from every staff and system).
        /// </summary>
        public IEnumerable<Measure> AllMeasures { get; private set; }

        public IEnumerable<Part> AllParts { get; private set; }

        /// <summary>
        /// All systems in the score.
        /// </summary>
        public IEnumerable<StaffSystem> Systems { get; private set; }

        public ScoreInfo(IScoreService scoreService)
        {
            AllMeasures = new ReadOnlyCollection<Measure>(scoreService.CurrentScore.Staves.SelectMany(s => s.Measures).ToList());
            Systems = new ReadOnlyCollection<StaffSystem>(scoreService.Systems.ToList());
        }
    }
}