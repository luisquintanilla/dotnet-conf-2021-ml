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
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Manufaktura.Controls.Rendering
{
    /// <summary>
    /// Base class for rendering scores on specific canvas.
    /// </summary>
    /// <typeparam name="TCanvas">Canvas object</typeparam>
    public abstract class ScoreRenderer<TCanvas> : ScoreRendererBase
    {
        /// <summary>
        /// Initializes a new ScoreRendere with specific canvas object.
        /// </summary>
        /// <param name="canvas"></param>
        public ScoreRenderer(TCanvas canvas)
        {
            Canvas = canvas;
        }

        public ScoreRenderer(TCanvas canvas, ScoreRendererSettings settings) : base(settings)
        {
            Canvas = canvas;
        }

        public TCanvas Canvas { get; internal set; }

        public TimeSpan DeserializationTime => Settings.MusicFontProfile.Performance;

        public TimeSpan TotalRenderingTime { get; private set; }

        public sealed override void Render(Measure measure)
        {
            scoreService.ReturnToFirstSystem();
            scoreService.MoveTo(measure, Settings);
            if (Settings.RenderingMode == ScoreRenderingModes.Panorama && scoreService.CurrentSystemNo != 1)
            {
                scoreService.ReturnToFirstSystem(); //W trybie panoramy system zawsze jest pierwszy
                scoreService.CurrentClef.TextBlockLocation = new Primitives.Point(scoreService.CursorPositionX, scoreService.CurrentLinePositions[4] - (scoreService.CurrentClef.Line - 1) * Settings.LineSpacing);
            }
            measurementService.LastMeasurePositionX = scoreService.CursorPositionX;
            measurementService.LastNoteEndXPosition = scoreService.CursorPositionX;
            measurementService.LastNotePositionX = scoreService.CursorPositionX;
            measurementService.LastNoteInMeasureEndXPosition = scoreService.CursorPositionX;
            alterationService.Reset();
            scoreService.MoveToContent(measure, Settings);

            foreach (MusicalSymbol symbol in measure.Elements.Where(e => !(e is Barline) && !(e is PrintSuggestion)))
            {
                try
                {
                    var noteOrRest = symbol as NoteOrRest;
                    if (noteOrRest != null) scoreService.CurrentVoice = noteOrRest.Voice;
                    var renderStrategy = GetProperRenderStrategy(symbol);
                    var clefRenderStrategy = renderStrategy as ClefRenderStrategy;
                    if (clefRenderStrategy != null)
                        clefRenderStrategy.WasSystemChanged = measure.Staff.Elements.OfType<Clef>().Any();
                    if (renderStrategy != null) renderStrategy.Render(symbol, this);
                }
                catch (Exception ex)
                {
                    Exceptions.Add(ex);
                }
            }
            foreach (var finishingTouch in FinishingTouches)
            {
                try
                {
                    finishingTouch.PerformOnMeasure(measure, this);
                }
                catch (Exception ex)
                {
                    Exceptions.Add(ex);
                }
            }
        }

        /// <summary>
        /// Renders score on canvas.
        /// </summary>
        /// <param name="score">Score</param>
        public override sealed void Render(Score score)
        {
            var sw = Debugger.IsAttached ? new Stopwatch() : null;
            sw?.Start();
            try
            {
                CurrentScore = score;
                BeforeRenderScore(score);

                scoreService.BeginNewScore(score);
                foreach (Staff staff in score.Staves)
                {
                    try
                    {
                        RenderStaff(staff);
                    }
                    catch (Exception ex)
                    {
                        Exceptions.Add(ex);
                    }
                }

                //Set height of current system in Panorama mode. This is used for determining the size of the control:
                if (Settings.RenderingMode == ScoreRenderingModes.Panorama && scoreService.CurrentSystem != null && scoreService.CurrentSystem.Height == 0)
                {
                    scoreService.CurrentSystem.Height = (scoreService.CurrentStaffHeight + Settings.LineSpacing) * scoreService.CurrentScore.Staves.Count;
                }

                foreach (var finishingTouch in FinishingTouches)
                {
                    try
                    {
                        finishingTouch.PerformOnScore(score, this);
                    }
                    catch (Exception ex)
                    {
                        Exceptions.Add(ex);
                    }
                }
            }
            finally
            {
                sw?.Stop();
                TotalRenderingTime = sw.Elapsed;
            }
        }

        public async Task RenderAsync(Score score)
        {
            await Task.Factory.StartNew(() => Render(score));
        }

        /// <summary>
        /// Additional actions before the Score is rendered
        /// </summary>
        /// <param name="score">Score to render</param>
        protected virtual void BeforeRenderScore(Score score) { }

        protected bool EnsureProperPage(MusicalSymbol owner)
        {
            return Settings.RenderingMode != ScoreRenderingModes.SinglePage || owner == null || !owner.PageNumber.HasValue || owner.PageNumber == Settings.CurrentPage;
        }
    }
}