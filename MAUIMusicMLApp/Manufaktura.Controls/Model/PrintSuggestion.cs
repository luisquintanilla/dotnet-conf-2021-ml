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
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Model
{
    /// <summary>
    /// Represents a printing suggestion.
    /// </summary>
    public class PrintSuggestion : MusicalSymbol
    {
        /// <summary>
        /// Indicates a page break
        /// </summary>
        public bool IsPageBreak { get; set; }

        /// <summary>
        /// Indicates a system break
        /// </summary>
        public bool IsSystemBreak { get; set; }

        /// <summary>
        /// Distance between systems
        /// </summary>
        public double? SystemDistance { get; set; }

        /// <summary>
        /// Clones a PrintSuggestion object
        /// </summary>
        /// <returns></returns>
        public PrintSuggestion Clone()
        {
            return new PrintSuggestion
            {
                CustomColor = CustomColor,
                IsPageBreak = IsPageBreak,
                IsSystemBreak = IsSystemBreak,
                IsVisible = IsVisible,
                SystemDistance = SystemDistance
            };
        }

        /// <summary>
        /// Returns a string representation of this symbol for debugging purposes
        /// </summary>
        /// <returns>String representation of this symbol for debugging purposes</returns>
        public override string ToString()
        {
            var suggestions = new List<string>();
            if (IsSystemBreak) suggestions.Add("system break");
            if (IsPageBreak) suggestions.Add("page break");
            if (SystemDistance.HasValue) suggestions.Add("system distance " + SystemDistance.Value);
            return string.Format("{0}{1}{2}", base.ToString(), suggestions.Any() ? " of " : "", string.Join(", ", suggestions));
        }
    }
}