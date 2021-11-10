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
using Manufaktura.Controls.Model.Fonts;
using System;

namespace Manufaktura.Controls.Rendering
{
    /// <summary>
    /// Base class for implementing render strategies
    /// </summary>
    public abstract class MusicalSymbolRenderStrategyBase
    {
        /// <summary>
        /// Type of musical symbol whose rendering is supported by this strategy
        /// </summary>
        public abstract Type SymbolType { get; }

        /// <summary>
        /// Renders musical symbol with specific score renderer
        /// </summary>
        /// <param name="element">Musical symbol to render</param>
        /// <param name="renderer">Score renderer</param>
        public abstract void Render(MusicalSymbol element, ScoreRendererBase renderer);
    }
}