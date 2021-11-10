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
using System.Text;

namespace Manufaktura.Controls.Model
{
	/// <summary>
	/// Represents a single word
	/// </summary>
	public class Lyrics : MusicalSymbol, IHasCustomYPosition
	{
		private double? defaultYPosition;

		/// <summary>
		/// Initializes a new insance of Lyrics.
		/// </summary>
		public Lyrics()
		{
		}

		public Lyrics(SyllableType type, string text, double? defaultY)
		{
			Syllables.Add(new Syllable(type, text));
			defaultYPosition = defaultY;
		}

		public Lyrics(SyllableType type, string text)
			: this(type, text, null)
		{
		}

		public double? DefaultYPosition
		{
			get
			{
				return defaultYPosition;
			}
			set
			{
				defaultYPosition = value;
				OnPropertyChanged();
			}
		}

		public override Measure Measure
		{
			get
			{
				return Note?.Measure;
			}

			internal set
			{
			}
		}

		public Note Note { get; internal set; }

		public int Number { get; set; }

		public override Staff Staff
		{
			get
			{
				return Note?.Staff;
			}

			internal set
			{
			}
		}

		/// <summary>
		/// Syllables that form a single word
		/// </summary>
		public List<Syllable> Syllables { get; set; } = new List<Syllable>();

		/// <summary>
		/// String value of word
		/// </summary>
		public string Text
		{
			get
			{
				StringBuilder sb = new StringBuilder();
				foreach (Syllable syllable in Syllables)
				{
					sb.Append(syllable.ElisionMark);
					sb.Append(syllable.Text);
				}
				return sb.ToString();
			}
		}

		/// <summary>
		/// Type of last (or only) syllable in word.
		/// </summary>
		public SyllableType Type
		{
			get
			{
				Syllable lastSyllable = Syllables.LastOrDefault();
				if (lastSyllable == null) return SyllableType.Single;
				return lastSyllable.Type;
			}
		}

		public override string ToString()
		{
			return $"Lyrics \"{Text}\"";
		}

		public class Syllable
		{
			public Syllable()
			{
			}

			public Syllable(SyllableType type, string text)
			{
				Type = type;
				Text = text;
			}

			public string ElisionMark { get; set; }

			public string Text { get; set; }

			public SyllableType Type { get; set; }
		}
	}
}