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
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Services
{
    public class AlterationService : IAlterationService
    {
        private int[] alterationsWithinOneBar;

        public void Reset()
        {
            alterationsWithinOneBar = new int[7];
        }

        public int Get(Step step)
        {
            return alterationsWithinOneBar[StepToIndex(step)];
        }

        public void Set(Step step, int value)
        {
            alterationsWithinOneBar[StepToIndex(step)] = value;
        }

        private int StepToIndex(Step step)
        {
            if (step == Step.C) return 0;
            else if (step == Step.D) return 1;
            else if (step == Step.E) return 2;
            else if (step == Step.F) return 3;
            else if (step == Step.G) return 4;
            else if (step == Step.A) return 5;
            else if (step == Step.B) return 6;
            else return 0;
        }

        public AlterationService()
        {
            alterationsWithinOneBar = new int[7];
        }
    }
}
