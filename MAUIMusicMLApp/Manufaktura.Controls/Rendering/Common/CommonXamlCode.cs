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
using Manufaktura.Controls.Parser;
using System.Xml.Linq;

namespace Manufaktura.Controls.Rendering.Common
{
	public class CommonXamlCode
	{
		public static void ScoreSourceChanged(IXamlNoteViewer viewer, Score oldValue, Score newValue)
		{
			if (oldValue != null) oldValue.Safety.BoundControl = null;
			Score.SanityCheck(newValue, viewer);

			newValue.MeasureInvalidated -= viewer.Score_MeasureInvalidated;
			viewer.RenderOnCanvas(newValue);
			newValue.MeasureInvalidated += viewer.Score_MeasureInvalidated;
		}

		public static void XmlSourceChanged(IXamlNoteViewer viewer, string oldValue, string newValue)
		{
			XDocument xmlDocument = XDocument.Parse(newValue);
			//Apply transformations:
			if (viewer.XmlTransformations != null)
			{
				foreach (var transformation in viewer.XmlTransformations) xmlDocument = transformation.Parse(xmlDocument);
			}

			MusicXmlParser parser = new MusicXmlParser();
			var score = parser.Parse(xmlDocument);
			score.MeasureInvalidated -= viewer.Score_MeasureInvalidated;
			viewer.RenderOnCanvas(score);
			score.MeasureInvalidated += viewer.Score_MeasureInvalidated;
		}
	}
}