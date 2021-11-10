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
using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Formatting
{
    /// <summary>
    /// Beaming strategy that performs rebeaming according to time signature
    /// </summary>
	public class BeatRebeamStrategy : IRebeamStrategy
	{
		public RebeamMode Mode => RebeamMode.ToBeats;

        /// <summary>
        /// Performs rebeaming with respect to time signature
        /// </summary>
        /// <param name="notes">Notes to rebeam</param>
        /// <param name="hookDirectionAlgorithm">Algorithm for determining hook direction in beams</param>
        /// <returns>Rebeamed notes</returns>
        public IEnumerable<NoteOrRest> Rebeam(IEnumerable<NoteOrRest> notes, HookDirectionAlgorithm hookDirectionAlgorithm = HookDirectionAlgorithm.ProductionCandidate)
		{
			var staff = notes.FirstOrDefault(n => n.Staff != null)?.Staff;
			if (staff == null) throw new Exception($"Staff property is null. Notes must be added to staff before using {nameof(BeatRebeamStrategy)}.");

			var timeSignature = staff.Peek<TimeSignature>(notes.First(), Model.PeekStrategies.PeekType.PreviousElement);
			if (timeSignature == null) throw new Exception($"Could not determine time signature. Check if time signature is added to the staff before first note to rebeam.");

			var splittedNotes = notes.SplitByBeats(timeSignature);
			foreach (var noteGroup in splittedNotes)
			{
				noteGroup.Rebeam(RebeamMode.Simple, hookDirectionAlgorithm);
			}
			return notes;
		}
	}
}