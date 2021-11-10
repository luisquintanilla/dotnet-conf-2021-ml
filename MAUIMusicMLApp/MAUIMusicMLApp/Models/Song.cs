using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using Manufaktura.Music.Model.MajorAndMinor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MAUIMusicMLApp.Services;

namespace MAUIMusicMLApp.Models
{
    // Each song is grouped into measures
    public class Song
    {
        public string Name { get; set; }
        public List<MusicMeasure> Measures { get; set; }
        public Stream Audio { get; set; }

        // This method reads in the music file which can then be displayed in the UI and played as a song
        public static List<MusicMeasure> ReadMusicFile(string fileName)
        {
            var measures = new List<MusicMeasure>();
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly;
            var resourceName = $"{typeof(MainPage).Namespace}.{fileName}";
            Stream stream = assembly.GetManifestResourceStream(resourceName);
            using (var reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                measures = JsonSerializer.Deserialize<List<MusicMeasure>>(json);
            }
            return measures;
        }

        // This method gets the "score" of music to be able to display in the UI
        public static List<Score> GetScores(List<MusicMeasure> measures)
        {
            // Split measures into pairs of 2 to have 2 measures per line/row in UI
            var pairs = measures.Chunk(2);

            var scores =
                pairs
                    .SelectMany(pair =>
                    {
                        // Create one staff score
                        var score = Score.CreateOneStaffScore(Clef.Treble, new MajorScale(Step.C, false));

                        // Iterate through each element in a pair of measures
                        return pair.Select(el =>
                        {
                            // Convert to Manufaktura notes to be able to display in the UI
                            var manufakturaNotes = NoteConverter.Convert(el).Zip(el.Notes);

                            // Make the repaird notes red in the UI
                            foreach (var (note, metadata) in manufakturaNotes)
                            {
                                if (metadata.IsRepaired)
                                    note.CustomColor = Manufaktura.Controls.Primitives.Color.Red;

                                // Add notes to score
                                score.FirstStaff.Elements.Add(note);
                            }

                            // Add barline to divide measures of the song
                            score.FirstStaff.AddBarline(BarlineStyle.Regular);

                            return score;
                        });
                    })
                    .ToList();

            return scores;
        }

    }
}
