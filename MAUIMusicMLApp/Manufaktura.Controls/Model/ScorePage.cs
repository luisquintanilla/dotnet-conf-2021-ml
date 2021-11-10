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
using Manufaktura.Controls.Model.Collections;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Stores information about a score page
    /// </summary>
	public class ScorePage
    {
        internal ScorePage(Score score)
        {
            Score = score;
            Systems = new SystemCollection(this);
        }

        /// <summary>
        /// Default distance between staves. Corresponds to staff-distance MusicXml element
        /// </summary>
		public double? DefaultStaffDistance { get; set; }

        /// <summary>
        /// Default distance between systems. Corresponds to system-distance MusicXml element
        /// </summary>
		public double? DefaultSystemDistance { get; set; }

        /// <summary>
        /// Page height. Corresponds to page-height MusicXml element
        /// </summary>
		public double? Height { get; set; }

        /// <summary>
        /// Bottom margin. Corresponds to bottom-margin MusicXml element
        /// </summary>
		public double? MarginBottom { get; set; }

        /// <summary>
        /// Left margin. Corresponds to left-margin MusicXml element
        /// </summary>
		public double? MarginLeft { get; set; }

        /// <summary>
        /// right margin. Corresponds to right-margin MusicXml element
        /// </summary>
        public double? MarginRight { get; set; }

        /// <summary>
        /// Top margin. Corresponds to top-margin MusicXml element
        /// </summary>
        public double? MarginTop { get; set; }

        /// <summary>
        /// Score that contains this score page
        /// </summary>
        public Score Score { get; set; }

        /// <summary>
        /// Staff systems on this page
        /// </summary>
		public SystemCollection Systems { get; private set; }

        /// <summary>
        /// Page width. Corresponds to page-width MusicXml element
        /// </summary>
        public double? Width { get; set; }
    }
}