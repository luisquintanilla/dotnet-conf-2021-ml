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
using Manufaktura.Controls.Audio;
using Manufaktura.Controls.IoC;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering.Postprocessing;
using Manufaktura.Controls.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Manufaktura.Controls.Rendering
{
    public abstract class ScoreRendererBase
    {
        protected IAlterationService alterationService = new AlterationService();
        protected IBeamingService beamingService = new BeamingService();
        protected IMeasurementService measurementService = new MeasurementService();
        protected IScoreService scoreService = new ScoreService();
        private ManufakturaResolver resolver = new ManufakturaResolver();
        public abstract bool CanDrawCharacterInBounds { get; }
        public virtual bool CanMeasureString => false;

        protected ScoreRendererBase() : this(new ScoreRendererSettings())
        {
        }

        protected ScoreRendererBase(ScoreRendererSettings settings)
        {
            Settings = settings;
            resolver.AddServices(measurementService, alterationService, scoreService, beamingService);
            Strategies = resolver.ResolveAll<MusicalSymbolRenderStrategyBase>().ToArray();
            FinishingTouches = resolver.ResolveAll<IFinishingTouch>().ToArray();
            Exceptions = new List<Exception>();
        }

        public Rectangle GetSMuFLBoundingBox(BoundingBox box)
        {
            var bottomLine = scoreService.CurrentLinePositions.Last();
            var origin = new Point(scoreService.CursorPositionX - box.BBoxSw[0] * Settings.LineSpacing,
                bottomLine + box.BBoxSw[1] * Settings.LineSpacing);
            var end = new Point(scoreService.CursorPositionX + box.BBoxNe[0] * Settings.LineSpacing,
                bottomLine - box.BBoxNe[1] * Settings.LineSpacing);
            return new Rectangle(origin.X, origin.Y, end.X - origin.X, origin.Y - end.Y);
        }

        public virtual Score CurrentScore { get; internal set; }
        public virtual List<Exception> Exceptions { get; protected set; }
        public virtual IFinishingTouch[] FinishingTouches { get; private set; }
        public ManufakturaResolver Resolver => resolver;
        public virtual ScoreInfo ScoreInformation { get { return new ScoreInfo(scoreService); } }

        public virtual ScoreRendererSettings Settings { get; set; }

        public bool IsSMuFLFont => Settings.MusicFontProfile.IsSMuFLFont;

        internal virtual MusicalSymbolRenderStrategyBase[] Strategies { get; private set; }

        /// <summary>
        /// Return musical symbol's color if musical symbol is not null and has custom color set. Otherwise returns renderer's default color.
        /// </summary>
        /// <param name="symbol">Musical symbol</param>
        /// <returns></returns>
        public Color CoalesceColor(MusicalSymbol symbol)
        {
            return symbol?.CustomColor ?? Settings.DefaultColor;
        }

        public void DrawArc(Rectangle rect, double startAngle, double sweepAngle, MusicalSymbol owner)
        {
            DrawArc(rect, startAngle, sweepAngle, new Pen(CoalesceColor(owner), 1), owner);
        }

        /// <summary>
        /// Draws arc.
        /// </summary>
        /// <remarks>
        /// Be aware of owner.IsVisible property. You should decide how to implement invisibility, for example
        /// not draw anything at all, draw in transparent color, etc.
        /// </remarks>
        /// <param name="rect">Rectangle within which arc should be drawn</param>
        /// <param name="startAngle">Start angle</param>
        /// <param name="sweepAngle">Sweep angle</param>
        /// <param name="pen">Pen settings</param>
        /// <param name="owner">Owning symbol</param>
        public abstract void DrawArc(Rectangle rect, double startAngle, double sweepAngle, Pen pen, MusicalSymbol owner);

        /// <summary>
        /// Draws Bezier curve.
        /// </summary>
        /// <param name="x1">Start point X</param>
        /// <param name="y1">Start point Y</param>
        /// <param name="x2">Control point 1 X</param>
        /// <param name="y2">Control point 1 Y</param>
        /// <param name="x3">Control point 2 X</param>
        /// <param name="y3">Control point 2 Y</param>
        /// <param name="x4">End point X</param>
        /// <param name="y4">End point Y</param>
        /// <param name="owner">Owning symbol</param>
        public void DrawBezier(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, MusicalSymbol owner)
        {
            DrawBezier(new Point(x1, y1), new Point(x2, y2), new Point(x3, y3), new Point(x4, y4), new Pen(CoalesceColor(owner), 1), owner);
        }

        /// <summary>
        /// Draws Bezier curve.
        /// </summary>
        /// <remarks>
        /// Be aware of owner.IsVisible property. You should decide how to implement invisibility, for example
        /// not draw anything at all, draw in transparent color, etc.
        /// </remarks>
        /// <param name="x1">Start point X</param>
        /// <param name="y1">Start point Y</param>
        /// <param name="x2">Control point 1 X</param>
        /// <param name="y2">Control point 1 Y</param>
        /// <param name="x3">Control point 2 X</param>
        /// <param name="y3">Control point 2 Y</param>
        /// <param name="x4">End point X</param>
        /// <param name="y4">End point Y</param>
        /// <param name="pen">Pen settings</param>
        /// <param name="owner">Owning symbol</param>
        public void DrawBezier(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, Pen pen, MusicalSymbol owner)
        {
            DrawBezier(new Point(x1, y1), new Point(x2, y2), new Point(x3, y3), new Point(x4, y4), pen, owner);
        }

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Be aware of owner.IsVisible property. You should decide how to implement invisibility, for example
        /// not draw anything at all, draw in transparent color, etc.
        /// </remarks>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <param name="p4"></param>
        /// <param name="pen"></param>
        /// <param name="owner"></param>
        public abstract void DrawBezier(Point p1, Point p2, Point p3, Point p4, Pen pen, MusicalSymbol owner);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Be aware of owner.IsVisible property. You should decide how to implement invisibility, for example
        /// not draw anything at all, draw in transparent color, etc.
        /// </remarks>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <param name="p4"></param>
        /// <param name="pen"></param>
        /// <param name="owner"></param>
        public void DrawBezier(Point p1, Point p2, Point p3, Point p4, MusicalSymbol owner)
        {
            DrawBezier(p1, p2, p3, p4, new Pen(CoalesceColor(owner), 1), owner);
        }

        /// <summary>
        /// Draws line from startPoint to endPoint.
        /// </summary>
        /// <param name="startX">Start point X coordinate.</param>
        /// <param name="startY">Start point Y coordinate.</param>
        /// <param name="endX">End point Y coordinate.</param>
        /// <param name="endY">End point Y coordinate.</param>
        /// <param name="owner">Owner element</param>
        public void DrawLine(double startX, double startY, double endX, double endY, MusicalSymbol owner)
        {
            DrawLine(new Point(startX, startY), new Point(endX, endY), new Pen(CoalesceColor(owner), 1), owner);
        }

        public void DrawLine(double startX, double startY, double endX, double endY, Pen pen, MusicalSymbol owner)
        {
            DrawLine(new Point(startX, startY), new Point(endX, endY), pen, owner);
        }

        /// <summary>
        /// Draws line from startPoint to endPoint.
        /// </summary>
        /// <param name="startPoint">Start point</param>
        /// <param name="endPoint">End point</param>
        /// <param name="owner">Owner element</param>
        public void DrawLine(Point startPoint, Point endPoint, MusicalSymbol owner)
        {
            DrawLine(startPoint, endPoint, new Pen(CoalesceColor(owner), 1), owner);
        }

        /// <summary>
        /// Draws line from startPoint to endPoint with specific pen.
        /// </summary>
        /// <remarks>
        /// Be aware of owner.IsVisible property. You should decide how to implement invisibility, for example
        /// not draw anything at all, draw in transparent color, etc.
        /// </remarks>
        /// <param name="startPoint">Start point</param>
        /// <param name="endPoint">End point</param>
        /// <param name="pen">Pen</param>
        /// <param name="owner">Owner element</param>
        public abstract void DrawLine(Point startPoint, Point endPoint, Pen pen, MusicalSymbol owner);

        /// <summary>
        /// Draws playback cursor
        /// </summary>
        /// <param name="position"></param>
        public void DrawPlaybackCursor(PlaybackCursorPosition position)
        {
#if CSHTML5
            if (position.Timestamp.AddTicks(position.Duration.Ticks) < DateTime.Now) return;
#else
            if (position.Timestamp + position.Duration < DateTime.Now) return;
#endif
            var system = CurrentScore.Systems.ElementAt(position.SystemNumber - 1);
            if (system == null) return;
            DrawPlaybackCursor(position, new Point(position.PositionX, system.Staves.First().LinePositions.First()),
                new Point(position.PositionX, system.Staves.Last().LinePositions.Last()));
        }

        /// <summary>
        /// Draws text (i.e. note heads, lyrics, articulation symbols) in default color in proper location with proper fontStyle.
        /// </summary>
        /// <remarks>
        /// Be aware of owner.IsVisible property. You should decide how to implement invisibility, for example
        /// not draw anything at all, draw in transparent color, etc.
        /// </remarks>
        /// <param name="text">Text to draw</param>
        /// <param name="fontStyle">Fontstyle of text</param>
        /// <param name="owner">Owning MusicalSymbol</param>
        public void DrawString(string text, MusicFontStyles fontStyle, double x, double y, MusicalSymbol owner)
        {
            DrawString(text, fontStyle, new Point(x, y), CoalesceColor(owner), owner);
        }

        public void DrawCharacter(char character, MusicFontStyles fontStyle, double x, double y, MusicalSymbol owner)
        {
            DrawString(character == '\0' ? "" : character.ToString(), fontStyle, x, y, owner);
        }

        public void DrawCharacter(char character, MusicFontStyles fontStyle, Point location, MusicalSymbol owner)
        {
            DrawString(character == '\0' ? "" : character.ToString(), fontStyle, location, owner);
        }

        /// <summary>
        /// Draws text (i.e. note heads, lyrics, articulation symbols) in default color in proper location with proper fontStyle.
        /// </summary>
        /// <remarks>
        /// Be aware of owner.IsVisible property. You should decide how to implement invisibility, for example
        /// not draw anything at all, draw in transparent color, etc.
        /// </remarks>
        /// <param name="text">Text to draw</param>
        /// <param name="fontStyle">Fontstyle of text</param>
        /// <param name="location">Location of text block</param>
        /// <param name="owner">Owning MusicalSymbol</param>
        public void DrawString(string text, MusicFontStyles fontStyle, Point location, MusicalSymbol owner)
        {
            DrawString(text, fontStyle, location, CoalesceColor(owner), owner);
        }

        /// <summary>
        /// Draws text (i.e. note heads, lyrics, articulation symbols) in given color in proper location with proper fontStyle.
        /// </summary>
        /// <remarks>
        /// Be aware of owner.IsVisible property. You should decide how to implement invisibility, for example
        /// not draw anything at all, draw in transparent color, etc.
        /// </remarks>
        /// <param name="text">Text to draw</param>
        /// <param name="fontStyle">Fontstyle of text</param>
        /// <param name="location">Location of text block</param>
        /// <param name="color">Color of text</param>
        /// <param name="owner">Owning MusicalSymbol</param>
        public abstract void DrawString(string text, MusicFontStyles fontStyle, Point location, Color color, MusicalSymbol owner);

        public abstract void DrawCharacterInBounds(char character, MusicFontStyles fontStyle, Point location, Size size, Color color, MusicalSymbol owner);

        public void DrawCharacterInBounds(char character, MusicFontStyles fontStyle, Point location, Size size, MusicalSymbol owner)
        {
            DrawCharacterInBounds(character, fontStyle, location, size, CoalesceColor(owner), owner);
        }

        public double PixelsToTenths(double pixels)
        {
            return 10d * (pixels / Settings.LineSpacing);
        }

        public abstract void Render(Score score);

        public abstract void Render(Measure measure);

        public double TenthsToPixels(double tenths)
        {
            return Settings.LineSpacing * (tenths / 10d);
        }

        public Point TenthsToPixels(Point point)
        {
            return new Point(TenthsToPixels(point.X), TenthsToPixels(point.Y));
        }

        public Pen CreatePen(MusicalSymbol element, Func<ISMuFLFontMetadata, double> smuflProperty, double defaultProperty)
        {
            var thickness = IsSMuFLFont && Settings.MusicFontProfile.SMuFLMetadata != null ? LinespacesToPixels(smuflProperty(Settings.MusicFontProfile.SMuFLMetadata)) : defaultProperty;
            return new Pen(CoalesceColor(element), thickness);
        }

        public Pen CreatePenFromDefaults(MusicalSymbol element, string engravingDefaultsKey, Func<ScoreRendererSettings, double> defaultPropertySelector)
        {
            var thickness = IsSMuFLFont && (Settings.MusicFontProfile.SMuFLMetadata?.EngravingDefaults?.ContainsKey(engravingDefaultsKey) ?? false) ?
                LinespacesToPixels(Settings.MusicFontProfile.SMuFLMetadata.EngravingDefaults[engravingDefaultsKey]) : defaultPropertySelector(Settings);
            return new Pen(CoalesceColor(element), thickness);
        }

        public double? GetEngravingDefault(string engravingDefaultsKey)
        {
            return IsSMuFLFont && (Settings.MusicFontProfile.SMuFLMetadata?.EngravingDefaults?.ContainsKey(engravingDefaultsKey) ?? false) ?
                LinespacesToPixels(Settings.MusicFontProfile.SMuFLMetadata.EngravingDefaults[engravingDefaultsKey]) : (double?)null;
        }

        public virtual Size MeasureString(MusicFontStyles style, string s) => default(Size);

        internal void BreakSystem(double distance = 0, bool breakPage = false)
        {
            scoreService.CurrentSystem.Width = scoreService.CursorPositionX;
            ReturnCarriage();

            var staffDistance = TenthsToPixels(scoreService.CurrentPage.DefaultStaffDistance ?? scoreService.CurrentScore.DefaultPageSettings.DefaultStaffDistance ?? 0);
            var averageSystemHeight = (staffDistance * scoreService.CurrentScore.Staves.Count - 1) +
                Settings.LineSpacing * 4 * scoreService.CurrentScore.Staves.Count;
            if (scoreService.CurrentSystem.Height == 0) scoreService.CurrentSystem.Height = averageSystemHeight;

            //Algorytm jest dobry. Wszystkiemu winny jest system-distance - prawdopodobnie źle to obsługuję, dlatego w Consort 3.0.xml druga pięciolinia klawesynu jest za wysoko
            var newLinePositions = CalculateLinePositions(breakPage, distance, scoreService.CurrentStaffNo, scoreService.CurrentLinePositions);
            scoreService.LinePositions[scoreService.CurrentSystemNo + 1, scoreService.CurrentStaffNo] = newLinePositions.ToArray();

            scoreService.BeginNewSystem();
            scoreService.CurrentSystem.BuildStaffFragments(scoreService.LinePositions[scoreService.CurrentSystemNo].ToDictionary(lp => scoreService.CurrentScore.Staves[lp.Key - 1], lp => lp.Value));
            measurementService.LastMeasurePositionX = 0;
        }

        private double[] CalculateLinePositions(bool breakPage, double distance, int staffNo, double[] initialPositions)
        {
            List<double> newLinePositions = new List<double>();
            if (breakPage && Settings.RenderingMode == ScoreRenderingModes.SinglePage)
            {
                newLinePositions = scoreService.LinePositions[1, staffNo].ToList(); //Reset line positions because we started a new page
            }
            else
            {
                foreach (var position in initialPositions) newLinePositions.Add(position + scoreService.CurrentSystem.Height + distance);
            }
            return newLinePositions.ToArray();
        }

        internal void BreakToNextStaff(double distance = 0)
        {
            if (scoreService.CurrentStaff == null)
            {
                scoreService.BeginNewStaff();
                double sharpLineModifier = 0.5; //TODO: To trzeba uwzględniać w lineSpacing albo coś, bo zepsuje położenie nut

                for (int i = 0; i < 5; i++)
                {
                    scoreService.CurrentLinePositions[i] = Settings.PaddingTop + i * Settings.LineSpacing + sharpLineModifier;
                }
                scoreService.CurrentSystem.BuildStaffFragments(scoreService.LinePositions[scoreService.CurrentSystemNo].ToDictionary(lp => scoreService.CurrentScore.Staves[lp.Key - 1], lp => lp.Value));
                return;
            }
            if (scoreService.CurrentScore.Staves.Count < 2)
            {
                return;
            }

            ReturnCarriage();
            scoreService.CurrentStaff.Height = scoreService.CurrentStaffHeight + distance;

            List<double> newLinePositions = new List<double>();
            scoreService.ReturnToFirstSystem();
            foreach (var position in scoreService.CurrentLinePositions) newLinePositions.Add(position + scoreService.CurrentStaff.Height);
            scoreService.BeginNewStaff();

            scoreService.LinePositions[scoreService.CurrentSystemNo, scoreService.CurrentStaffNo] = newLinePositions.ToArray();
            scoreService.CurrentSystem.BuildStaffFragments(scoreService.LinePositions[scoreService.CurrentSystemNo].ToDictionary(lp => scoreService.CurrentScore.Staves[lp.Key - 1], lp => lp.Value));
            measurementService.LastMeasurePositionX = 0;
        }

        internal void ReturnCarriage()
        {
            scoreService.CursorPositionX = 3;
        }

        public double LinespacesToPixels(double linespaces) => linespaces * Settings.LineSpacing;

        protected void DetermineClef(Staff staff)
        {
            var clef = staff.Elements.OfType<Clef>().FirstOrDefault();
            if (clef == null) return;

            scoreService.CurrentClef = clef;
            var clefPositionY = scoreService.CurrentLinePositions[4] - ((clef.Line - 1) * Settings.LineSpacing);
            //if (Settings.CurrentFont is SMuFLMusicFont) clefPositionY -= 31;
            clef.TextBlockLocation = new Point(scoreService.CursorPositionX, clefPositionY);

            if (clef.TypeOfClef == ClefType.Percussion)
                new ClefRenderStrategy(scoreService).DrawPercussionClef(clef, this);
            else
                DrawCharacter(clef.GetCharacter(Settings.MusicFontProfile.MusicFont), MusicFontStyles.MusicFont, clef.TextBlockLocation.X, clef.TextBlockLocation.Y, clef);
            scoreService.CursorPositionX += 20;
        }

        protected abstract void DrawPlaybackCursor(PlaybackCursorPosition position, Point start, Point end);

        protected MusicalSymbolRenderStrategyBase GetProperRenderStrategy(MusicalSymbol element)
        {
#if CSHTML5
            return Strategies.FirstOrDefault(s => s.SymbolType == element.GetType()) ?? Strategies.FirstOrDefault(s => s.SymbolType.IsAssignableFrom(element.GetType()));
#else
            return Strategies.FirstOrDefault(s => s.SymbolType == element.GetType()) ?? Strategies.FirstOrDefault(s => s.SymbolType.GetTypeInfo().IsAssignableFrom(element.GetType().GetTypeInfo()));
#endif
        }

        protected void RenderStaff(Staff staff)
        {
            scoreService.CursorPositionX += 3;  //Zgodność z poprzednią implementacją

            if (!staff.Score.DefaultPageSettings.DefaultStaffDistance.HasValue) staff.Score.DefaultPageSettings.DefaultStaffDistance = PixelsToTenths(Settings.LineSpacing * 6); //TODO: Zastanowić się gdzie ustawiać tę domyślną wartość
            var staffDistance = scoreService.CurrentPage.DefaultStaffDistance ?? staff.Score.DefaultPageSettings.DefaultStaffDistance.Value;    //TODO: Bez sensu jest sprawdzanie tu Currentpage.DefaultStaffDistance, bo strony zmieniają się kawałek dalej. Tu jest pierwsza strona

            BreakToNextStaff(TenthsToPixels(staffDistance));
            if (!Settings.IgnoreCustomElementPositions && Settings.RenderingMode == ScoreRenderingModes.Panorama)
            {
                double newPageWidth = staff.Measures.Where(m => m.Width.HasValue).Sum(m => m.Width.Value * Settings.CustomElementPositionRatio);
                if (newPageWidth > Settings.PageWidth) Settings.PageWidth = newPageWidth;
            }

            DetermineClef(staff);
            alterationService.Reset();

            foreach (MusicalSymbol symbol in staff.Elements)
            {
                try
                {
                    var renderStrategy = GetProperRenderStrategy(symbol);
                    if (renderStrategy != null) renderStrategy.Render(symbol, this);
                }
                catch (Exception ex)
                {
                    Exceptions.Add(ex);
                }
            }

            scoreService.CurrentSystem.Width = scoreService.CursorPositionX;

            foreach (var finishingTouch in FinishingTouches) finishingTouch.PerformOnStaff(staff, this);
        }
    }
}