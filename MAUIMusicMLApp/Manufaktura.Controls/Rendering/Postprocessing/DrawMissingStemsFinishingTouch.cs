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
using Manufaktura.Controls.Primitives;
using System;
using System.Linq;

namespace Manufaktura.Controls.Rendering.Postprocessing
{
    internal class DrawMissingStemsFinishingTouch : IFinishingTouch
    {
        /// <summary>
        /// Applies DrawMissingStemsFinishingTouch to a measure.
        /// </summary>
        /// <param name="measure">Measure</param>
        /// <param name="renderer">Score renderer</param>
		public void PerformOnMeasure(Measure measure, ScoreRendererBase renderer)
        {
            Perform(measure.Staff, measure, renderer);
        }

        /// <summary>
        /// This method does nothing in this implementation of IFinishingTouch.
        /// </summary>
        /// <param name="score">Score</param>
        /// <param name="renderer">Score renderer</param>
        public void PerformOnScore(Score score, ScoreRendererBase renderer)
        {
        }

        /// <summary>
        /// Applies DrawMissingStemsFinishingTouch to a staff.
        /// </summary>
        /// <param name="staff">Staff</param>
        /// <param name="renderer">Score renderer</param>
        public void PerformOnStaff(Staff staff, ScoreRendererBase renderer)
        {
            Perform(staff, null, renderer);
        }

        private Note GetLastNoteInBeam(Note note, Staff staff)
        {
            for (int i = staff.Elements.IndexOf(note) + 1; i < staff.Elements.Count; i++)
            {
                Note note2 = staff.Elements[i] as Note;
                if (note2 == null) continue;
                if (note2.BeamList.Count > 0)
                {
                    if (note2.BeamList[0] == NoteBeamType.End)
                    {
                        return note2;
                    }
                }
            }
            return null;
        }

        private void Perform(Staff staff, Measure measure, ScoreRendererBase renderer)
        {
            //Draw missing stems / Dorysuj brakujące ogonki:
            Note lastNoteInBeam = null;
            Note firstNoteInBeam = null;
            foreach (Note note in staff.Elements.OfType<Note>())
            {
                //Search for the end of the beam / Przeszukaj i znajdź koniec belki:
                if (note.BeamList.Count == 0) continue;
                if (note.BeamList[0] == NoteBeamType.End) continue;
                if (note.BeamList[0] == NoteBeamType.Start)
                {
                    firstNoteInBeam = note;
                    continue;
                }
                if (note.BeamList[0] != NoteBeamType.Continue) continue;
                if (note.HasCustomStemEndPosition) continue;

                lastNoteInBeam = GetLastNoteInBeam(note, staff);

                double newStemEndPosition = Math.Abs(note.StemEndLocation.X -
                    firstNoteInBeam.StemEndLocation.X) *
                    ((Math.Abs(lastNoteInBeam.StemEndLocation.Y - firstNoteInBeam.StemEndLocation.Y)) /
                    (Math.Abs(lastNoteInBeam.StemEndLocation.X - firstNoteInBeam.StemEndLocation.X)));

                //Jeśli ostatnia nuta jest wyżej, to odejmij y zamiast dodać
                //If the last note is higher, subtract y instead of adding
                if (lastNoteInBeam.StemEndLocation.Y < firstNoteInBeam.StemEndLocation.Y)
                    newStemEndPosition *= -1;

                Point newStemEndPoint = new Point(note.StemEndLocation.X, firstNoteInBeam.StemEndLocation.Y + newStemEndPosition);

                if (measure != null && note.Measure != measure) continue;   //Odśwież tylko stemy z wybranego taktu w trybie odświeżania jednego taktu

                if (note.StemDirection == VerticalDirection.Down)
                {
                    var chord = NoteRenderStrategy.GetChord(note, staff);
                    var highestNoteInChord = chord.Last();
                    renderer.DrawLine(new Point(note.StemEndLocation.X, highestNoteInChord.TextBlockLocation.Y), new Point(newStemEndPoint.X, newStemEndPoint.Y), new Pen(renderer.CoalesceColor(note), renderer.Settings.DefaultStemThickness), note);
                }
                else
                    renderer.DrawLine(new Point(note.StemEndLocation.X, note.TextBlockLocation.Y), new Point(newStemEndPoint.X, newStemEndPoint.Y), new Pen(renderer.CoalesceColor(note), renderer.Settings.DefaultStemThickness), note);

                if (lastNoteInBeam == null) continue;
            }
        }
    }
}