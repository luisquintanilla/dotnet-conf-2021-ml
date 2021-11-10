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

namespace Manufaktura.Controls.Interactivity
{
	/// <summary>
	/// Strategy of dragging notes
	/// </summary>
	public class NoteDraggingStrategy : DraggingStrategy<Note>
	{
		protected override void DragInternal(ScoreRendererBase renderer, Note draggedElement, DraggingState draggingState, double delta, double smallDelta)
		{
			int midiPitch = draggingState.MidiPitchOnStartDragging + (int)(delta / 2);
			draggedElement.SuppressEvents = true;
			draggedElement.ApplyMidiPitch(midiPitch);     //TODO: Wstawianie kasownika, jeśli jest znak przykluczowy, a obniżyliśmy o pół tonu
														  //TODO: Ustalanie kierunku ogonka. Sprawdzić czy gdzieś to nie jest już zrobione, np. w PSAMie

			DetermineStemDirection(draggedElement);

			draggedElement.SuppressEvents = false;
			draggedElement.InvalidateMeasure();
		}

		public static void DetermineStemDirection (Note draggedElement)
		{
			if (draggedElement.TextBlockLocation.Y < draggedElement.StemStartLocation.Y)
				draggedElement.StemDirection = VerticalDirection.Down;
			else
				draggedElement.StemDirection = VerticalDirection.Up;
		}
	}
}