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

using System;
using System.Linq;
using System.Text;

namespace Manufaktura.Music.Model
{
    /// <summary>
    /// Represents a step.
    /// </summary>
    public class Step
    {
        /// <summary>
        /// Step name.
        /// </summary>
        /// <remarks>Valid step names are: A, B, C, D, E, F, G</remarks>
        public string StepName { get; set; }

        /// <summary>
        /// Number of sharps (positive number) or flats (negative number)
        /// </summary>
        public int Alter { get; set; }

        protected Step()
        {
        }

        /// <summary>
        /// Creates a new instance of step from specified pitch
        /// </summary>
        /// <param name="pitch"></param>
        /// <returns></returns>
        public static Step FromPitch(Pitch pitch)
        {
            return new Step { StepName = pitch.StepName, Alter = pitch.Alter };
        }

        public Pitch ToPitch(int octaveNumber = 4)
        {
            return Pitch.FromStep(this, octaveNumber);
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", StepName, AlterToSigns(Alter));
        }

        protected static string AlterToSigns(int alter)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < Math.Abs(alter); i++)
            {
                sb.Append(alter < 0 ? "b" : "#");
            }
            return sb.ToString();
        }

        public int ToStepNumber()
        {
            if (StepName == "C") return 1;
            else if (StepName == "D") return 2;
            else if (StepName == "E") return 3;
            else if (StepName == "F") return 4;
            else if (StepName == "G") return 5;
            else if (StepName == "A") return 6;
            else if (StepName == "B") return 7;
            else return 0;
        }

        public static Step Cb
        {
            get { return new Step { StepName = "C", Alter = -1 }; }
        }

        public static Step C
        {
            get { return new Step { StepName = "C", Alter = 0 }; }
        }

        public static Step CSharp
        {
            get { return new Step { StepName = "C", Alter = 1 }; }
        }

        public static Step Db
        {
            get { return new Step { StepName = "D", Alter = -1 }; }
        }

        public static Step D
        {
            get { return new Step { StepName = "D", Alter = 0 }; }
        }

        public static Step DSharp
        {
            get { return new Step { StepName = "D", Alter = 1 }; }
        }

        public static Step Eb
        {
            get { return new Step { StepName = "E", Alter = -1 }; }
        }

        public static Step E
        {
            get { return new Step { StepName = "E", Alter = 0 }; }
        }

        public static Step ESharp
        {
            get { return new Step { StepName = "E", Alter = 1 }; }
        }

        public static Step Fb
        {
            get { return new Step { StepName = "F", Alter = -1 }; }
        }

        public static Step F
        {
            get { return new Step { StepName = "F", Alter = 0 }; }
        }

        public static Step FSharp
        {
            get { return new Step { StepName = "F", Alter = 1 }; }
        }

        public static Step Gb
        {
            get { return new Step { StepName = "G", Alter = -1 }; }
        }

        public static Step G
        {
            get { return new Step { StepName = "G", Alter = 0 }; }
        }

        public static Step GSharp
        {
            get { return new Step { StepName = "G", Alter = 1 }; }
        }

        public static Step Ab
        {
            get { return new Step { StepName = "A", Alter = -1 }; }
        }

        public static Step A
        {
            get { return new Step { StepName = "A", Alter = 0 }; }
        }

        public static Step ASharp
        {
            get { return new Step { StepName = "A", Alter = 1 }; }
        }

        public static Step Bb
        {
            get { return new Step { StepName = "B", Alter = -1 }; }
        }

        public static Step B
        {
            get { return new Step { StepName = "B", Alter = 0 }; }
        }

        public static Step BSharp
        {
            get { return new Step { StepName = "B", Alter = 1 }; }
        }

        public override bool Equals(object obj)
        {
            if (obj is Step) return this == (Step)obj;
            return base.Equals(obj);
        }

        public static bool operator ==(Step s1, Step s2)
        {
            return s1.StepName.Equals(s2.StepName, StringComparison.OrdinalIgnoreCase) && s1.Alter == s2.Alter;
        }

        public static bool operator !=(Step s1, Step s2)
        {
            return !s1.StepName.Equals(s2.StepName, StringComparison.OrdinalIgnoreCase) || !(s1.Alter == s2.Alter);
        }

        public static implicit operator Step(string s)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (!new[] { "A", "B", "C", "D", "E", "F", "G" }.Contains(s.ToUpper()))
                throw new InvalidCastException(string.Format("{0} is not a valid step name.", s));

            return new Step { StepName = s, Alter = 0 };
        }

        public static implicit operator string(Step s)
        {
            return s.StepName;
        }

        public override int GetHashCode() => ToStepNumber();
    }
}