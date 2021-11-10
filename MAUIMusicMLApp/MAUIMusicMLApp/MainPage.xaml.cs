using System;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Skia;
using Manufaktura.Controls.SMuFL;
using Manufaktura.Controls.XamarinFormsSkia;
using Manufaktura.Music.Model;
using Manufaktura.Music.Model.MajorAndMinor;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using MAUIMusicMLApp.Models;
using MAUIMusicMLApp.Services;
using System.Reflection;
using System.Linq;

using Microsoft.ML;
using System.Threading.Tasks;
using Plugin.SimpleAudioPlayer;

namespace MAUIMusicMLApp
{
	public partial class MainPage : ContentPage
	{
        public List<Score> Data { get; set; }
        private ITransformer _model;
        private MusicRepairer _repairer;
        private IList<Song> _songs;
        private ISimpleAudioPlayer _audioPlayer;

        public IList<Song> Songs
        {
            get {return _songs;}
            set { if (_songs != value) { _songs = value; OnPropertyChanged(); } }
        }
        public Song SelectedSong { get; set; }

        public MainPage()
        {
            InitializeComponent();

            // Initialize song list and UI components
            InitSongs();

            // Initialize UI Manufaktura NoteViewer UI components
            InitNoteViewer();

            // Initialize music repairer with the given ML model
            _repairer = new MusicRepairer("Resources.NotePredictor.zip");
        }

        // Initialize UI Manufaktura NoteViewer UI components
        private void InitSongs()
        {
            // Initialize Songs
            _songs = new List<Song>();

            // Add the "damaged" song with missing notes
            _songs.Add(new Song
            {
                Name = "Damaged",
                Measures = Song.ReadMusicFile("Resources.melody-damaged.json"),
                Audio = GetStreamFromFile("Resources.melody-damaged.mid")
            });
            // Add the "very damaged" songs with even more missing notes
            _songs.Add(new Song
            {
                Name = "Very Damaged",
                Measures = Song.ReadMusicFile("Resources.melody-very-damaged.json"),
                Audio = GetStreamFromFile("Resources.melody-very-damaged.mid")
            });

            // Add a drop-down to be able to pick the song to Play / Repair in the UI
            foreach (var song in _songs)
            {
                SongPicker.Items.Add(song.Name);
            }

            SelectedSong = _songs[0];

            Data = Song.GetScores(SelectedSong.Measures);

            SongPicker.SelectedIndexChanged += (o, e) =>
            {
                if (SongPicker.SelectedItem == null)
                {
                    SelectedSong = _songs[0];
                }

                SelectedSong = _songs[SongPicker.SelectedIndex];

                Data = Song.GetScores(SelectedSong.Measures);
                BindableLayout.SetItemsSource(MusicScore, Data);
            };
        }

        // Initialize song list and UI components
        private void InitNoteViewer()
        {
            // Set font profile for displaying music in the UI
            var fontProfile = SMuFLMusicFont.CreateFromJsonResource<MainPage>("Resources.bravura_metadata.json", SMuFLMusicFont.JSONLoadingModes.LazyWithStaticProxy);

            // Create Manufaktura display elements
            DataTemplate template = new DataTemplate(() =>
            {
                NoteViewer viewer = new NoteViewer()
                {
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    HeightRequest = 100,
                    WidthRequest = 280
                };

                viewer.SetBinding(NoteViewer.ScoreSourceProperty, ".");

                viewer.SetFontFromResource<MainPage>("Resources.Bravura.otf", fontProfile);

                return viewer;
            });

            BindableLayout.SetItemsSource(MusicScore, Data);
            BindableLayout.SetItemTemplate(MusicScore, template);
        }

        // Get a stream to be able to play the "damaged" MIDI files
        Stream GetStreamFromFile(string fileName)
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream($"{typeof(MainPage).Namespace}.{fileName}");
            return stream;
        }

        // Play the music when "Play" button is clicked
        private void PlayButton_Clicked(object sender, EventArgs args)
        {
            _audioPlayer = 
                CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

            _audioPlayer.Load(SelectedSong.Audio);
            _audioPlayer.Play();
        }

        // Stop the music when "Stop" button is clicked
        private void StopButton_Clicked(object sender, EventArgs args)
        {
            if(_audioPlayer != null)
            {
                if(_audioPlayer.IsPlaying)
                {
                    _audioPlayer?.Stop();
                }
                _audioPlayer.Dispose();
            }
        }

        // Take a dataset with missing notes and "repair" the dataset to get a new song with the missing notes filled in using Machine Learning
        private async void RepairButton_Clicked(object sender, EventArgs args)
        {
            _audioPlayer.Dispose();

            // Make sure player is stopped
            _audioPlayer =
                CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

            //  Use ML model to predict missing notes in "damaged" song
            var repairedMeasures = _repairer.Repair(SelectedSong.Measures) as List<MusicMeasure>;
            
            // Update UI with the repaired song data
            Data = Song.GetScores(repairedMeasures);
            BindableLayout.SetItemsSource(MusicScore, Data);

            // Load repaired song
            if(SelectedSong.Name == "Damaged")
            {
                _audioPlayer.Load(GetStreamFromFile("Resources.melody-damaged-repaired.mid"));
            } else if (SelectedSong.Name == "Very Damaged")
            {
                _audioPlayer.Load(GetStreamFromFile("Resources.melody-very-damaged-repaired.mid"));
            }

            // Hack to give time for the player to start
            await Task.Delay(100);

            // Play repaired song
            _audioPlayer.Play();
        }
	}
}
