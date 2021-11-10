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

namespace Manufaktura.Music.Model
{
    /// <summary>
    /// Represents a fraction with integer numerator and denominator.
    /// </summary>
    public struct Proportion
    {
        /// <summary>
        /// Proportion of 2:1.
        /// </summary>
        public static Proportion Dupla { get { return new Proportion(2, 1); } }

        /// <summary>
        /// Proportion of 4:1.
        /// </summary>
        public static Proportion Quadrupla { get { return new Proportion(4, 1); } }

        /// <summary>
        /// Proportion of 5:1.
        /// </summary>
        public static Proportion Quintupla { get { return new Proportion(5, 1); } }

        /// <summary>
        /// Proportion of 3:2.
        /// </summary>
        public static Proportion Sesquialtera { get { return new Proportion(3, 2); } }

        /// <summary>
        /// Proportion of 9:8.
        /// </summary>
        public static Proportion Sesquioctava { get { return new Proportion(9, 8); } }

        /// <summary>
        /// Proportion of 5:4.
        /// </summary>
        public static Proportion Sesquiquarta { get { return new Proportion(5, 4); } }

        /// <summary>
        /// Proportion of 6:5.
        /// </summary>
        public static Proportion Sesquiquinta { get { return new Proportion(6, 5); } }

        /// <summary>
        /// Proportion of 8:7.
        /// </summary>
        public static Proportion Sesquiseptima { get { return new Proportion(8, 7); } }

        /// <summary>
        /// Proportion of 7:6.
        /// </summary>
        public static Proportion Sesquisexta { get { return new Proportion(7, 6); } }

        /// <summary>
        /// Proportion of 4:3.
        /// </summary>
        public static Proportion Sesquitertia { get { return new Proportion(4, 3); } }

        /// <summary>
        /// Proportion of 3:1.
        /// </summary>
        public static Proportion Tripla { get { return new Proportion(3, 1); } }

        /// <summary>
        /// Double value of the fraction in cents
        /// </summary>
        public double Cents
        {
            get
            {
                return 1200 * Math.Log(DoubleValue, 2);
            }
        }


#if !CSHTML5
        /// <summary>
        /// Decimal value of the fraction
        /// </summary>
        public decimal DecimalValue
        {
            get
            {
                return (decimal)Numerator / (decimal)Denominator;
            }
        }

#endif

        /// <summary>
        /// Denominator
        /// </summary>
        public int Denominator { get; set; }

        /// <summary>
        /// Double value of the fraction
        /// </summary>
        public double DoubleValue
        {
            get
            {
                return (double)Numerator / (double)Denominator;
            }
        }

        /// <summary>
        /// Returns a fractional part (without whole part)
        /// </summary>
        public Proportion FractionalPart
        {
            get
            {
                var prop = new Proportion(Numerator, Denominator);
                while (prop.Numerator > prop.Denominator)
                {
                    prop.Numerator -= prop.Denominator;
                }
                return prop;
            }
        }

        /// <summary>
        /// Numerator
        /// </summary>
        public int Numerator { get; set; }

        /// <summary>
        /// Initializes a new instance od Proportion with specific numerator and denominator.
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        public Proportion(int numerator, int denominator)
            : this()
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        /// <summary>
        /// Converts cents value to approximated proportion.
        /// </summary>
        /// <param name="cents"></param>
        /// <param name="precision"></param>
        /// <returns></returns>
        public static Proportion GetApproximatedProportionFromCents(double cents, int precision = 6)
        {
            if (precision < 1 || precision > 20)
                throw new ArgumentException("Precision must be between 1 and 20.", "precision");

            var decimalValue = UsefulMath.CentsToLinear(cents);
            var normalizedValue = decimalValue;
            var denominator = 1;
            var maxDenominator = Math.Pow(10, precision);
            while (normalizedValue % 10 != 0 && denominator <= maxDenominator)
            {
                denominator *= 10;
                normalizedValue *= 10;
            }
            return new Proportion((int)normalizedValue, denominator).Normalize();
        }

        public static Proportion operator -(Proportion d1, Proportion d2)
        {
            if (d1.Denominator == d2.Denominator) return new Proportion(d1.Numerator - d2.Numerator, d1.Denominator);
            var commonDenominator = GetCommonDenominator(d1, d2);
            var numeratorSum = d1.Numerator * d2.Denominator - d2.Numerator * d1.Denominator;
            return new Proportion(numeratorSum, commonDenominator).Normalize();
        }


#if !CSHTML5
        public static bool operator !=(Proportion p1, Proportion p2)
        {
            return p1.DecimalValue != p2.DecimalValue;
        }

        public static bool operator !=(Proportion p1, decimal d)
        {
            return p1.DecimalValue != d;
        }
#else
        public static bool operator !=(Proportion p1, Proportion p2)
        {
            return p1.DoubleValue != p2.DoubleValue;
        }

#endif

        public static bool operator !=(Proportion p1, double d)
        {
            return p1.DoubleValue != d;
        }

        public static bool operator !=(Proportion p1, int i)
        {
            return p1.DoubleValue != i;
        }

        public static Proportion operator *(Proportion p1, Proportion p2)
        {
            return new Proportion(p1.Numerator * p2.Numerator, p1.Denominator * p2.Denominator).Normalize();
        }

#if !CSHTML5

        public static decimal operator *(Proportion p1, decimal d2)
        {
            return p1.DecimalValue * d2;
        }

#endif

        public static double operator *(Proportion p1, double d2)
        {
            return p1.DoubleValue * d2;
        }

        public static Proportion operator *(Proportion p1, int d2)
        {
            return new Proportion(p1.Numerator * d2, p1.Denominator).Normalize();
        }

        public static Proportion operator /(Proportion p1, int d2)
        {
            return new Proportion(p1.Numerator, p1.Denominator * d2).Normalize();
        }

        public static Proportion operator +(Proportion d1, Proportion d2)
        {
            if (d1.Denominator == d2.Denominator) return new Proportion(d1.Numerator + d2.Numerator, d1.Denominator);
            var commonDenominator = GetCommonDenominator(d1, d2);
            var numeratorSum = d1.Numerator * d2.Denominator + d2.Numerator * d1.Denominator;
            return new Proportion(numeratorSum, commonDenominator).Normalize();
        }

        public static bool operator <(Proportion p1, Proportion p2)
        {
            if (p1.Denominator == p2.Denominator) return p1.Numerator < p2.Numerator;
            return p1.Numerator * p2.Denominator < p2.Numerator * p1.Denominator;
        }

        public static bool operator <=(Proportion p1, Proportion p2)
        {
            if (p1.Denominator == p2.Denominator) return p1.Numerator <= p2.Numerator;
            return p1.Numerator * p2.Denominator <= p2.Numerator * p1.Denominator;
        }

#if !CSHTML5
        public static bool operator ==(Proportion p1, Proportion p2)
        {
            return p1.DecimalValue == p2.DecimalValue;
        }
#else
        public static bool operator ==(Proportion p1, Proportion p2)
        {
            return p1.DoubleValue == p2.DoubleValue;
        }
#endif

#if !CSHTML5
        public static bool operator ==(Proportion p1, decimal d)
        {
            return p1.DecimalValue == d;
        }
#endif

        public static bool operator ==(Proportion p1, double d)
        {
            return p1.DoubleValue == d;
        }

        public static bool operator ==(Proportion p1, int i)
        {
            return p1.DoubleValue == i;
        }

        public static bool operator >(Proportion p1, Proportion p2)
        {
            if (p1.Denominator == p2.Denominator) return p1.Numerator > p2.Numerator;
            return p1.Numerator * p2.Denominator > p2.Numerator * p1.Denominator;
        }

        public static bool operator >=(Proportion p1, Proportion p2)
        {
            if (p1.Denominator == p2.Denominator) return p1.Numerator >= p2.Numerator;
            return p1.Numerator * p2.Denominator >= p2.Numerator * p1.Denominator;
        }

        /// <summary>
        /// Normalizes the fraction.
        /// </summary>
        /// <returns></returns>
        public Proportion Normalize()
        {
            for (int i = Denominator; i > 1; i--)
            {
                if (Numerator % i == 0 && Denominator % i == 0) return new Proportion(Numerator / i, Denominator / i).Normalize();
            }
            return this;
        }

        public override string ToString()
        {
            return string.Format("{0} / {1}", Numerator, Denominator);
        }

        /// <summary>
        /// Returns a common denominator of two proportions.
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        private static int GetCommonDenominator(Proportion d1, Proportion d2)
        {
            return d1.Denominator * d2.Denominator;
        }
    }
}