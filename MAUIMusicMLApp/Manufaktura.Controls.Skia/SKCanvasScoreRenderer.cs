using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Skia
{
    public class SKCanvasScoreRenderer : ScoreRenderer<SKCanvas>, IDisposable
    {
        private readonly Dictionary<Pen, SKPaint> penCache = new Dictionary<Pen, SKPaint>();
        private readonly Dictionary<Color, Dictionary<MusicFontStyles, SKPaint>> textPaintCache = new Dictionary<Color, Dictionary<MusicFontStyles, SKPaint>>();

        public SKCanvasScoreRenderer(SKCanvas canvas) : base(canvas, new SKScoreRendererSettings())
        {
        }

        public SKCanvasScoreRenderer(SKCanvas canvas, SKScoreRendererSettings settings) : base(canvas, settings)
        {
        }

        public override bool CanDrawCharacterInBounds => throw new NotImplementedException();
        public Dictionary<SKObject, MusicalSymbol> OwnershipDictionary { get; private set; }

        public SKScoreRendererSettings TypedSettings => Settings as SKScoreRendererSettings;

        public void Dispose()
        {
            foreach (var penEntry in penCache) penEntry.Value.Dispose();
            foreach (var textPaintEntry in textPaintCache.SelectMany(c => c.Value)) textPaintEntry.Value.Dispose();
        }

        public override void DrawArc(Rectangle rect, double startAngle, double sweepAngle, Pen pen, MusicalSymbol owner)
        {
            var path = new SKPath();
            path.AddArc(Convert(rect), (float)startAngle, (float)sweepAngle);
            Canvas.DrawPath(path, Convert(pen));
            OwnershipDictionary.Add(path, owner);
        }

        public override void DrawBezier(Point p1, Point p2, Point p3, Point p4, Pen pen, MusicalSymbol owner)
        {
            Canvas.Save();
            Canvas.Translate(Convert(p1));
            var path = new SKPath();
            path.CubicTo(Convert(p2), Convert(p3), Convert(p4));
            Canvas.DrawPath(path, Convert(pen));
            Canvas.Restore();
            OwnershipDictionary.Add(path, owner);
        }

        public override void DrawCharacterInBounds(char character, MusicFontStyles fontStyle, Point location, Size size, Color color, MusicalSymbol owner)
        {
        }

        public override void DrawLine(Point startPoint, Point endPoint, Pen pen, MusicalSymbol owner)
        {
            Canvas.DrawLine(Convert(startPoint), Convert(endPoint), Convert(pen));
        }

        public override void DrawString(string text, MusicFontStyles fontStyle, Point location, Color color, MusicalSymbol owner)
        {
            var paint = GetTextPaint(fontStyle, color);
            Canvas.DrawText(text, Convert(location), paint);
        }

        protected override void DrawPlaybackCursor(PlaybackCursorPosition position, Point start, Point end)
        {
        }

        private SKRect Convert(Rectangle rect) => new SKRect((float)rect.Location.X, (float)rect.Location.Y, (float)rect.Location.X + (float)rect.Width, (float)rect.Location.Y + (float)rect.Height);

        private SKColor Convert(Color color) => new SKColor(color.R, color.G, color.B, color.A);

        private SKPaint Convert(Pen pen)
        {
            if (penCache.ContainsKey(pen)) return penCache[pen];
            var paint = new SKPaint { Color = Convert(pen.Color), StrokeWidth = (float)pen.Thickness };
            penCache.Add(pen, paint);
            return paint;
        }

        private SKPoint Convert(Point point) => new SKPoint((float)point.X, (float)point.Y);

        private SKPaint GetTextPaint(MusicFontStyles fontStyle, Color color)
        {
            if (!textPaintCache.ContainsKey(color)) textPaintCache.Add(color, new Dictionary<MusicFontStyles, SKPaint>());
            var paintsForThisColor = textPaintCache[color];
            if (!paintsForThisColor.ContainsKey(fontStyle))
            {
                var paint = new SKPaint
                {
                    Typeface = TypedSettings.GetFont(fontStyle),
                    TextSize = TypedSettings.GetFontSize(fontStyle),
                    Color = Convert(color)
                };
                paintsForThisColor.Add(fontStyle, paint);
            }
            return paintsForThisColor[fontStyle];
        }
    }
}