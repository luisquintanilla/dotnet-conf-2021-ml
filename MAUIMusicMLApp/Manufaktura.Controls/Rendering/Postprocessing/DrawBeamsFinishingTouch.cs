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
using Manufaktura.Controls.Model.Exceptions;
using Manufaktura.Controls.Primitives;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Rendering.Postprocessing
{
    /// <summary>
    /// Draws proper note beams.
    /// </summary>
	public class DrawBeamsFinishingTouch : IFinishingTouch
	{
        /// <summary>
        /// Applies DrawBeamsFinishingTouch to a measure.
        /// </summary>
        /// <param name="measure">Measure</param>
        /// <param name="renderer">Score renderer</param>
        public void PerformOnMeasure(Measure measure, ScoreRendererBase renderer)
		{
			var beamGroupsForThisMeasure = measure.Staff.BeamGroups.Where(bg => bg.Members.Any(m => m.Measure == measure));
			foreach (var beamGroup in beamGroupsForThisMeasure)
			{
				beamGroup.Start = beamGroup.Members.OfType<Note>().First().StemEndLocation;
				beamGroup.End = beamGroup.Members.OfType<Note>().Last().StemEndLocation;
			}
			PerformOnBeamGroups(beamGroupsForThisMeasure, renderer);
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
        /// Applies DrawBeamsFinishingTouch to a staff.
        /// </summary>
        /// <param name="staff">Staff</param>
        /// <param name="renderer">Score renderer</param>
        public void PerformOnStaff(Staff staff, ScoreRendererBase renderer)
		{
			DiscoverBeamGroups(staff, renderer);
			PerformOnBeamGroups(staff.BeamGroups, renderer);
		}

		private void DiscoverBeamGroups(Staff staff, ScoreRendererBase renderer)
		{
			staff.BeamGroups.Clear();
			BeamGroup beamGroup = null;
			foreach (var nr in staff.Elements.OfType<NoteOrRest>())
			{
				var note = nr as Note;
				if (note != null && note.BeamList.Any())
				{
                    if (note.BeamList.Count == 1 && note.BeamList[0] == NoteBeamType.Single) continue; //Problem with beams in chords

					if (note.BeamList.First() == NoteBeamType.Start)
					{
						beamGroup = new BeamGroup(staff);
						beamGroup.Start = note.StemEndLocation;
						staff.BeamGroups.Add(beamGroup);
					}
					if (beamGroup != null) beamGroup.Members.Add(nr);
					if (note.BeamList.First() == NoteBeamType.End)
					{
						if (beamGroup == null) renderer.Exceptions.Add(new ScoreException(note, $"Encountered beam group end without corresponding beam group start."));
						else
						{
							beamGroup.End = note.StemEndLocation;
							beamGroup = null;
						}
					}
				}
			}
		}

		private void PerformOnBeamGroups(IEnumerable<BeamGroup> beamGroups, ScoreRendererBase renderer)
		{


            foreach (var beamGroup in beamGroups)
			{
				Note previousNote = null;
				foreach (var member in beamGroup.Members)
				{
					var currentNote = member as Note;
					if (currentNote == null) continue;

                    var beamPen = renderer.CreatePenFromDefaults(currentNote, "beamThickness", s => s.DefaultBeamThickness);
                    beamPen.Color = currentNote.CoalesceColor(renderer);
                    var beamSpacing = renderer.GetEngravingDefault("beamSpacing") ?? beamPen.Thickness * 0.6;

                    var beamNumber = 1;
					foreach (var beamType in currentNote.BeamList)
					{
                        var beamOffset = (beamPen.Thickness + beamSpacing) * (beamNumber - 1) * (currentNote.StemDirection == VerticalDirection.Up ? 1 : -1);

                        var stemEnd = beamGroup.Start.TranslateHorizontallyAndMaintainAngle(beamGroup.Angle, currentNote.StemEndLocation.X - beamGroup.Start.X);
						currentNote.StemStartLocation = stemEnd;
						if (beamType == NoteBeamType.ForwardHook || beamType == NoteBeamType.BackwardHook)
						{
							var hookLength = beamType == NoteBeamType.ForwardHook ? 6 : -6;
							var hookEnd = stemEnd.TranslateByAngleOld(beamGroup.Angle, hookLength);
							renderer.DrawLine(stemEnd.Translate(0, beamOffset), hookEnd.Translate(0, beamOffset),
                                beamPen, beamGroup);
						}
						else if (previousNote != null && beamType != NoteBeamType.Single && previousNote.BeamList.Count >= beamNumber)
						{
							var stemEnd1 = beamGroup.Start.TranslateHorizontallyAndMaintainAngle(beamGroup.Angle, previousNote.StemEndLocation.X - beamGroup.Start.X);
							renderer.DrawLine(stemEnd1.Translate(0, beamOffset), stemEnd.Translate(0, beamOffset),
                                beamPen, beamGroup);
						}
						beamNumber++;
					}

					previousNote = currentNote;
				}
			}
		}
	}
}