/*
 * Copyright 2019 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
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
using Manufaktura.Controls.Skia;
using Manufaktura.Music.Model;
using Manufaktura.Music.Model.MajorAndMinor;
//using Xamarin.Forms;
//using Xamarin.Forms.Xaml;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Graphics;

namespace Manufaktura.Controls.XamarinFormsSkia
{
    //[XamlCompilation(XamlCompilationOptions.Skip)]
    public partial class NoteViewer : ContentView
    {
        public static readonly BindableProperty ScoreSourceProperty = BindableProperty.Create(nameof(ScoreSource), typeof(Score), typeof(NoteViewer), null, propertyChanged: (bobj, newval, old) =>
        {
            var noteViewer = (NoteViewer)bobj;
            noteViewer.Canvas.InvalidateSurface();
        });

        public static readonly BindableProperty SettingsProperty = BindableProperty.Create(nameof(Settings), typeof(SKScoreRendererSettings), typeof(NoteViewer), new SKScoreRendererSettings(),propertyChanged: (bobj, newval, old) =>
        {
            var noteViewer = (NoteViewer)bobj;
            noteViewer.Canvas.InvalidateSurface();
        });

        public NoteViewer()
        {
            InitializeComponent();
        }

        public Score ScoreSource
        {
            get { return (Score)GetValue(ScoreSourceProperty); }
            set 
            {
                SetValue(ScoreSourceProperty, value); 
            }
        }

        public SKScoreRendererSettings Settings
        {
            get { return (SKScoreRendererSettings)GetValue(SettingsProperty); }
            set { SetValue(SettingsProperty, value); }
        }

        private void SKCanvasView_PaintSurface(object sender, SkiaSharp.Views.Maui.SKPaintSurfaceEventArgs e)
        {
            e.Surface.Canvas.Scale(3);
            using (var renderer = new SKCanvasScoreRenderer(e.Surface.Canvas, Settings))
            {
                renderer.Render(ScoreSource);
            }
        }

        public void SetFontFromResource<TSomeTypeInNamespace>(string resourceFileName, FontProfile musicFontProfile)
        {
            Settings.MusicFontProfile = musicFontProfile;
            var typeface = Settings.CreateTypefaceFromResource<TSomeTypeInNamespace>(resourceFileName);
            foreach (var size in musicFontProfile.FontSizes)
                Settings.SetFontFromTypeface(size.Key, typeface, (float)size.Value);
        }
    }
}