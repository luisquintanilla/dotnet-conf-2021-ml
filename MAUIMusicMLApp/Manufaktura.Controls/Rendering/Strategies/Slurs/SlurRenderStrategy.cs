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
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Services;

namespace Manufaktura.Controls.Rendering.Strategies.Slurs
{
    /// <summary>
    /// Strategy of rendering slurs.
    /// </summary>
    public abstract class SlurRenderStrategy
    {
        protected IMeasurementService measurementService;
        protected IScoreService scoreService;

        /// <summary>
        /// Initializes a new instance of SlurRenderStrategy with specific services.
        /// </summary>
        /// <param name="measurementService">Measurement service</param>
        /// <param name="scoreService">Score service</param>
        protected SlurRenderStrategy(IMeasurementService measurementService, IScoreService scoreService)
        {
            this.measurementService = measurementService;
            this.scoreService = scoreService;
        }

        /// <summary>
        /// Draws a slur
        /// </summary>
        /// <param name="renderer"></param>
        /// <param name="slur"></param>
        /// <param name="element"></param>
        /// <param name="notePositionY"></param>
        public void Draw(ScoreRendererBase renderer, Slur slur, Note element, double notePositionY)
        {
            VerticalPlacement slurPlacement;
            if (slur.Placement.HasValue) slurPlacement = slur.Placement.Value;
            else slurPlacement = element.StemDirection == VerticalDirection.Up ? VerticalPlacement.Below : VerticalPlacement.Above;

            if (slur.Type == NoteSlurType.Start) ProcessSlurStart(renderer, slur, element, notePositionY, GetSlurInfoForWriting(slur.Number), slurPlacement);
            if (slur.Type == NoteSlurType.Stop)
            {
                var slurInfo = GetSlurInfoForReading(slur.Number);
                if (slurInfo == null) return;   //There is no slur with that number. MusicXml file might be malformed (like in DWOK tom 1, s. 315, nr 24.xml)
                ProcessSlurEnd(renderer, slur, element, notePositionY, slurInfo, slurPlacement);
                measurementService.Slurs.Remove(slur.Number);
            }
        }

        /// <summary>
        /// Returns true if this strategy type is relevant for drawing a specific slur
        /// </summary>
        /// <param name="element">Element with a slur</param>
        /// <param name="slur">Slur</param>
        /// <returns>True if this strategy is relevant for rendering a specific slur</returns>
        public abstract bool IsRelevant(Note element, Slur slur);

        /// <summary>
        /// Draws of performs additional logic at slur end
        /// </summary>
        /// <param name="renderer">Score renderer</param>
        /// <param name="slur">Slur</param>
        /// <param name="element">Element with a slur</param>
        /// <param name="notePositionY">Y position of element with a slur</param>
        /// <param name="slurStartInfo">Information about slur start point</param>
        /// <param name="slurPlacement">Information about slur placement</param>
        protected abstract void ProcessSlurEnd(ScoreRendererBase renderer, Slur slur, Note element, double notePositionY, SlurInfo slurStartInfo, VerticalPlacement slurPlacement);

        /// <summary>
        /// Draws or performs additional logic at slur start
        /// </summary>
        /// <param name="renderer">Score renderer</param>
        /// <param name="slur">Slur</param>
        /// <param name="element">Element with a slur</param>
        /// <param name="notePositionY"></param>
        /// <param name="slurStartInfo">Information about slur start point</param>
        /// <param name="slurPlacement">Information about slur placement</param>
        protected abstract void ProcessSlurStart(ScoreRendererBase renderer, Slur slur, Note element, double notePositionY, SlurInfo slurStartInfo, VerticalPlacement slurPlacement);

        protected Point RelativeToAbsolute(ScoreRendererBase renderer, Point relative, double notePositionY)
        {
            return new Point(relative.X * renderer.Settings.CustomElementPositionRatio + 7, relative.Y) + new Point(measurementService.LastNotePositionX, scoreService.CurrentLinePositions[0]);
        }

        private SlurInfo GetSlurInfoForReading(int number)
        {
            if (!measurementService.Slurs.ContainsKey(number)) return null;
            return measurementService.Slurs[number];
        }

        private SlurInfo GetSlurInfoForWriting(int number)
        {
            if (!measurementService.Slurs.ContainsKey(number)) measurementService.Slurs.Add(number, new SlurInfo());
            return measurementService.Slurs[number];
        }
    }
}