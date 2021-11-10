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
namespace Manufaktura.Music.Model.Harmony
{
    /// <summary>
    /// Interface for implementing rules of creating chords for specific scale type
    /// </summary>
    /// <typeparam name="TScale"></typeparam>
    public interface IHarmony<TScale> where TScale : Scale
    {
        /// <summary>
        /// Creates a chord from base pitch, inversion and number of generator intervals for a specific scale.
        /// </summary>
        /// <param name="basePitch">Base pitch, for example C in C Major</param>
        /// <param name="inversion">Inversion of a chord</param>
        /// <param name="generatorIntervals">Number of chord members, for example 4 in C7 Major, 5 in C9 Major, etc.</param>
        /// <param name="scale">Scale for which a chord will be created</param>
        /// <returns>Chord</returns>
        Chord CreateChord(Pitch basePitch, int inversion, int generatorIntervals, TScale scale);
    }
}