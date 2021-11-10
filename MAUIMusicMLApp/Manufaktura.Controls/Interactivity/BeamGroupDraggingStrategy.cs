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
using System.Linq;

namespace Manufaktura.Controls.Interactivity
{
	/// <summary>
	/// Strategy of dragging beam groups
	/// </summary>
	public class BeamGroupDraggingStrategy : DraggingStrategy<BeamGroup>
	{
		protected override void DragInternal(ScoreRendererBase renderer, BeamGroup draggedElement, DraggingState draggingState, double delta, double smallDelta)
		{
			if (draggedElement.Members.OfType<Note>().Count() < 2) return;
			var firstElement = draggedElement.Members.OfType<Note>().First();
			var lastElement = draggedElement.Members.OfType<Note>().Last();

			firstElement.SuppressEvents = true;
			lastElement.SuppressEvents = true;

			if (!firstElement.HasCustomStemEndPosition)
			{
				firstElement.StemDefaultY = renderer.PixelsToTenths(firstElement.StemEndLocation.Y - firstElement.TextBlockLocation.Y);
				firstElement.HasCustomStemEndPosition = true;
			}
			if (!lastElement.HasCustomStemEndPosition)
			{
				lastElement.StemDefaultY = renderer.PixelsToTenths(lastElement.StemEndLocation.Y - firstElement.TextBlockLocation.Y);
				lastElement.HasCustomStemEndPosition = true;
			}

			firstElement.StemDefaultY -= smallDelta;
			lastElement.StemDefaultY -= smallDelta;

			foreach (var element in draggedElement.Members.OfType<Note>())
			{
				element.SuppressEvents = true;
				NoteDraggingStrategy.DetermineStemDirection(element);
				element.SuppressEvents = false;
			}

			firstElement.SuppressEvents = false;
			lastElement.SuppressEvents = false;
			draggedElement.InvalidateMeasure();
		}
	}
}