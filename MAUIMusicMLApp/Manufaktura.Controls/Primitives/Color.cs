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
using Manufaktura.Music.Extensions;

namespace Manufaktura.Controls.Primitives
{
	/// <summary>
	/// Represents a color in RGB color space.
	/// </summary>
	public struct Color
	{
		public Color(byte r, byte g, byte b, byte a) : this()
		{
			A = a;
			R = r;
			G = g;
			B = b;
		}

		public static Color Black { get { return new Color(0, 0, 0, 255); } }
		public static Color Red { get { return new Color(255, 0, 0, 255); } }

		/// <summary>
		/// Alpha value
		/// </summary>
		public byte A { get; set; }

		/// <summary>
		/// Blue value
		/// </summary>
		public byte B { get; set; }

		/// <summary>
		/// Green value
		/// </summary>
		public byte G { get; set; }

		/// <summary>
		/// Red value
		/// </summary>
		public byte R { get; set; }

		/// <summary>
		/// Converts color to CSS format
		/// </summary>
		/// <returns></returns>
		public string ToCss()
		{
			return string.Format("rgb({0},{1},{2})",
				R.ToStringInvariant(),
				G.ToStringInvariant(),
				B.ToStringInvariant());
		}
	}
}