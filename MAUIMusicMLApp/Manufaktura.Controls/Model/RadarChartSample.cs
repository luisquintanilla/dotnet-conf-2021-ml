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

using Manufaktura.Core.Models;

namespace Manufaktura.Controls.Model
{
    public class RadarChartSample : ViewModel
    {
        private string axisDisplayName;
        private string axisShortName;
        private Compartment[] validationCompartments = new Compartment[0];
        private double validationMaxValue;
        private double validationMinValue;
        private double value;
        public RadarChartSample(string axisDisplayName, string axisShortName, double value)
        {
            this.axisDisplayName = axisDisplayName;
            this.axisShortName = axisShortName;
            this.value = value;
        }

        public string AxisDisplayName
        {
            get
            {
                return axisDisplayName;
            }

            set
            {
                axisDisplayName = value;
                OnPropertyChanged();
            }
        }

        public string AxisShortName
        {
            get
            {
                return axisShortName;
            }

            set
            {
                axisShortName = value;
                OnPropertyChanged();
            }
        }

        public double Scale { get; set; } = 1;
        public Compartment[] ValidationCompartments
        {
            get
            {
                return validationCompartments;
            }
            set
            {
                validationCompartments = value;
                OnPropertyChanged();
            }
        }

        public double ValidationMaxValue
        {
            get
            {
                return validationMaxValue;
            }

            set
            {
                validationMaxValue = value;
                OnPropertyChanged();
            }
        }

        public double ValidationMinValue
        {
            get
            {
                return validationMinValue;
            }

            set
            {
                validationMinValue = value;
                OnPropertyChanged();
            }
        }

        public double Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
                OnPropertyChanged();
            }
        }
    }
}