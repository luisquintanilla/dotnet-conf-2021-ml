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
using Manufaktura.Controls.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Services
{
    public class ScoreService : IScoreService
    {
        private Staff currentStaff;

        private StaffSystem currentSystem;

        public ScoreService()
        {
            LinePositions = new LineDictionary();
            CurrentClef = new Clef(ClefType.CClef, 2);
            CurrentKey = new Key(0);
            CurrentVoice = 1;
        }

        /// <summary>
        /// Current clef.
        /// </summary>
        public Clef CurrentClef { get; set; }

        /// <summary>
        /// Current key.
        /// </summary>
        public Key CurrentKey { get; set; }

        public double[] CurrentLinePositions
        {
            get { return LinePositions[CurrentSystemNo, CurrentStaffNo]; }
        }

        /// <summary>
        /// Current measure.
        /// </summary>
        public Measure CurrentMeasure { get; private set; }

        /// <summary>
        /// Current measure number.
        /// </summary>
        public int CurrentMeasureNo
        {
            get { return CurrentStaff.Measures.IndexOf(CurrentMeasure) + 1; }
        }

        public ScorePage CurrentPage
        {
            get;
            set;
        }

        /// <summary>
        /// Current score.
        /// </summary>
        public Score CurrentScore { get; private set; }

        /// <summary>
        /// Current staff.
        /// </summary>
        public Staff CurrentStaff { get { return currentStaff; } set { currentStaff = value; CurrentStaffNo = CurrentScore.Staves.IndexOf(value) + 1; } }

        /// <summary>
        /// Current staff height. Computed by line positions.
        /// </summary>
        public double CurrentStaffHeight
        {
            get
            {
                return LinePositions[CurrentSystemNo, CurrentStaffNo].Max() - LinePositions[CurrentSystemNo, CurrentStaffNo].Min();
            }
        }

        /// <summary>
        /// Current staff number.
        /// </summary>
        public int CurrentStaffNo
        {
            get; private set;
        }

        public double CurrentStaffTop => LinePositions[CurrentSystemNo, CurrentStaffNo][0];

        /// <summary>
        /// Current system.
        /// </summary>
        public StaffSystem CurrentSystem { get { return currentSystem; } set { currentSystem = value; CurrentSystemNo = Systems.IndexOf(value) + 1; } }

        /// <summary>
        /// Current system number.
        /// </summary>
        public int CurrentSystemNo { get; private set; }

        /// <summary>
        /// Current voice.
        /// </summary>
        public int CurrentVoice { get; set; }

        /// <summary>
        /// Current horizontal cursor position.
        /// </summary>
        public double CursorPositionX
        {
            get;
            set;
        }

        /// <summary>
        /// Dictionary of line positions in the score.
        /// </summary>
        public LineDictionary LinePositions { get; private set; }

        /// <summary>
        /// All systems in the score.
        /// </summary>
        public IList<StaffSystem> Systems
        {
            get { return CurrentScore.Systems; }
        }

        /// <summary>
        /// Begins new measure.
        /// </summary>
        public void BeginNewMeasure()
        {
            if (CurrentMeasure == null) CurrentMeasure = CurrentStaff.Measures.First();
            else if (CurrentStaff.Measures.IndexOf(CurrentMeasure) + 1 >= CurrentStaff.Measures.Count) return;
            else CurrentMeasure = CurrentStaff.Measures[CurrentStaff.Measures.IndexOf(CurrentMeasure) + 1];

            if (CurrentMeasureNo <= CurrentStaff.Measures.Count && CurrentStaff.Measures[CurrentMeasureNo - 1].Width.HasValue)
            {
                CurrentMeasure.Width = CurrentStaff.Measures[CurrentMeasureNo - 1].Width.Value;
            }
        }

        /// <summary>
        /// Resets settings to begin a new score.
        /// </summary>
        /// <param name="score">Score</param>
        public void BeginNewScore(Score score)
        {
            CurrentScore = score;
            CurrentPage = score.DefaultPageSettings;
            CurrentStaff = null;
            CurrentMeasure = null;
            CurrentClef = null;
            CurrentKey = null;
            LinePositions.Clear();
        }

        /// <summary>
        /// Begins a new staff.
        /// </summary>
        public void BeginNewStaff()
        {
            if (!Systems.Any()) BeginNewSystem();
            CurrentSystem = Systems.First();

            if (CurrentStaff == null)
            {
                CurrentStaff = CurrentScore.Staves.FirstOrDefault();
                BeginNewMeasure();
                return;
            }

            var currentStaffIndex = CurrentScore.Staves.IndexOf(CurrentStaff);
            if (currentStaffIndex == CurrentScore.Staves.Count - 1)
            {
                CurrentStaff = null;
                return;
            }
            CurrentStaff = CurrentScore.Staves[currentStaffIndex + 1];
            BeginNewMeasure();
        }

        /// <summary>
        /// Begins a new system.
        /// </summary>
        public void BeginNewSystem()
        {
            var currentSystemIndex = Systems.ToList().IndexOf(CurrentSystem);
            if (currentSystemIndex == Systems.Count - 1)
            {
                var newSystem = new StaffSystem(CurrentScore);
                CurrentScore.Pages.Last().Systems.Add(newSystem);
                CurrentSystem = newSystem;
                return;
            }
            CurrentSystem = Systems[currentSystemIndex + 1];
        }

        /// <summary>
        /// Searches for the corresponding measure (a measure with the same measure number) in other staff.
        /// </summary>
        /// <param name="measure">Examined measure</param>
        /// <param name="otherStaff">Searched staff</param>
        /// <returns>Corresponding measure</returns>
        public Measure GetCorrespondingMeasure(Measure measure, Staff otherStaff)
        {
            var measureIndex = measure.Staff.Measures.IndexOf(measure);
            var measuresInOthersStaff = otherStaff.Measures;
            if (measuresInOthersStaff.Count <= measureIndex) return null;
            return measuresInOthersStaff[measureIndex];
        }

        public void MoveToContent(Measure measure, ScoreRendererSettings rendererSettings)
        {
            var firstElement = measure.Elements.FirstOrDefault();
            if (firstElement is PrintSuggestion || firstElement is NoteOrRest)
                CursorPositionX = measure.FirstNoteInMeasureXPosition;
        }

        public void MoveTo(Measure measure, ScoreRendererSettings rendererSettings)
        {
            var measureIndex = measure.Staff.Measures.IndexOf(measure);
            var previousMeasure = measureIndex < 1 ? null : measure.Staff.Measures[measureIndex - 1];
            if (rendererSettings.RenderingMode != ScoreRenderingModes.Panorama && previousMeasure != null && previousMeasure.System != measure.System) CursorPositionX = 0; //Issue #40 - jeśli takt był w innym systemie, to wyzeruj karetkę
            else CursorPositionX = previousMeasure?.BarlineLocationX ?? 0;

            CurrentStaff = measure.Staff;
            CurrentSystem = measure.System;
            var firstNoteOrRest = measure.Elements.OfType<NoteOrRest>().FirstOrDefault();
            if (firstNoteOrRest != null)
            {
                CurrentClef = measure.Staff.Peek<Clef>(firstNoteOrRest, Model.PeekStrategies.PeekType.PreviousElement);
                CurrentClef.TextBlockLocation = new Primitives.Point(CursorPositionX, CurrentLinePositions[4] - (CurrentClef.Line - 1) * rendererSettings.LineSpacing);
                CurrentKey = measure.Staff.Peek<Key>(firstNoteOrRest, Model.PeekStrategies.PeekType.PreviousElement);
            }
        }

        /// <summary>
        /// Resets CurrentSystem to first system.
        /// </summary>
        public void ReturnToFirstSystem()
        {
            CurrentSystem = Systems.FirstOrDefault();
        }
    }
}