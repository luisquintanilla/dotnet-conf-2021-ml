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
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering;
using System.Collections.Generic;

namespace Manufaktura.Controls.Services
{
    /// <summary>
    /// Service that stores temporary information during score rendering
    /// </summary>
	public interface IScoreService
	{
        /// <summary>
        /// Current clef
        /// </summary>
		Clef CurrentClef { get; set; }

        /// <summary>
        /// Current key
        /// </summary>
		Key CurrentKey { get; set; }

        /// <summary>
        /// Current line positions
        /// </summary>
		double[] CurrentLinePositions { get; }

        /// <summary>
        /// Current measure
        /// </summary>
		Measure CurrentMeasure { get; }

        /// <summary>
        /// Current measure number
        /// </summary>
		int CurrentMeasureNo { get; }

        /// <summary>
        /// Current page
        /// </summary>
		ScorePage CurrentPage { get; set; }

        /// <summary>
        /// Current score
        /// </summary>
		Score CurrentScore { get; }

        /// <summary>
        /// Current staff
        /// </summary>
		Staff CurrentStaff { get; }

        /// <summary>
        /// Current staff height
        /// </summary>
		double CurrentStaffHeight { get; }

        /// <summary>
        /// Current staff number
        /// </summary>
		int CurrentStaffNo { get; }

        /// <summary>
        /// Current staff Y position
        /// </summary>
        double CurrentStaffTop { get; }
        /// <summary>
        /// Current system
        /// </summary>
		StaffSystem CurrentSystem { get; }

        /// <summary>
        /// Current system number
        /// </summary>
		int CurrentSystemNo { get; }

        /// <summary>
        /// Current voice number
        /// </summary>
		int CurrentVoice { get; set; }

        /// <summary>
        /// Current cursor position X - position where the next note will be rendered
        /// </summary>
		double CursorPositionX { get; set; }

        /// <summary>
        /// Staff line positions
        /// </summary>
		LineDictionary LinePositions { get; }

        /// <summary>
        /// All systems in the score.
        /// </summary>
        IList<StaffSystem> Systems { get; }

        /// <summary>
        /// Begins a new measure. Performs specific logic connected with beginning a new measure.
        /// </summary>
		void BeginNewMeasure();

        /// <summary>
        /// Begins a new score.
        /// </summary>
        /// <param name="score"></param>
		void BeginNewScore(Score score);

        /// <summary>
        /// Begins a new staff.
        /// </summary>
		void BeginNewStaff();

		void BeginNewSystem();

		Measure GetCorrespondingMeasure(Measure measure, Staff otherStaff);

        void MoveTo(Measure measure, ScoreRendererSettings rendererSettings);
        void MoveToContent(Measure measure, ScoreRendererSettings rendererSettings);

        void ReturnToFirstSystem();
	}
}