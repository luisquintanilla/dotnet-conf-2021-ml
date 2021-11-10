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
namespace Manufaktura.Controls.Parser.MusicXml
{
	public class MusicXmlParserState
	{
		private int currentDynamics = 80;
		private int currentTempo = 120;
		private bool firstLoop = true;
		private string partID = "";
		private int skipMeasures = 0;

		public bool BarlineAlreadyAdded { get; set; }

		public int CurrentDynamics
		{
			get { return currentDynamics; }
			set { currentDynamics = value; }
		}

		public int CurrentSystemNo { get; set; }

		public int CurrentTempo
		{
			get { return currentTempo; }
			set { currentTempo = value; }
		}

		public bool FirstLoop
		{
			get { return firstLoop; }
			set { firstLoop = value; }
		}

		public string PartID
		{
			get { return partID; }
			set { partID = value; }
		}

		public int SkipMeasures
		{
			get { return skipMeasures; }
			set { skipMeasures = value; }
		}
	}
}