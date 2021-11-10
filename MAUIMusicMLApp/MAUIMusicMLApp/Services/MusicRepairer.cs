using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUIMusicMLApp.Models;
using Microsoft.ML;
using Microsoft.ML.Data;
using System.Reflection;
using System.IO;

// Service to "repair" songs with missing notes using ML with ML.NET
namespace MAUIMusicMLApp.Services
{
    internal class MusicRepairer
    {
        private MLContext _mlContext;
        private ITransformer _model;

        public MusicRepairer(string modelPath)
        {
            _mlContext = new MLContext();
            _model = LoadModel(modelPath);
        }

        // Load the ML model which will be used to predict the missing notes

        private ITransformer LoadModel(string modelPath)
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly;
            var resourceName = $"{typeof(MainPage).Namespace}.{modelPath}";
            Stream stream = assembly.GetManifestResourceStream(resourceName);

            return _mlContext.Model.Load(stream, out var inputSchema);
        }

        public IEnumerable<MusicMeasure> Repair(IEnumerable<MusicMeasure> measures)
        {
            // Create a PredictionEngine based on the trained model
            // PredictionEngine = convenience API for making single predictions with ML.NET
            var predictionEngine = GetPredictionEngine(_model);

            // Iterate through each note in each measure
            foreach (var measure in measures)
            {
                foreach (var note in measure.Notes.Where(n => n.Note == 0))
                {
                    // For each known (non-missing note), add the note as a byte to knownNotes
                    IEnumerable<byte> knownNotes = measure.Notes.Where(n => n.Note != 0).Select(n => n.Note);

                    // Use the known notes to create the model input
                    ModelInput feature = BuildFeature(knownNotes);

                    // Use the prediction engine and model input to predict the missing note
                    ModelOutput predictedNote = predictionEngine.Predict(feature);

                    // Convert the missing note from a letter to a number
                    var newNote = ConvertToNoteNumber(predictedNote.Prediction, knownNotes);
                    note.Note = newNote;

                    note.IsRepaired = true;
                }
            }

            return measures;
        }

        private PredictionEngine<ModelInput,ModelOutput> GetPredictionEngine(ITransformer model)
        {
            return _mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(model);
        }

        private ModelInput BuildFeature(IEnumerable<byte> knownNotes)
        {
            return new ModelInput
            {
                Chorale = 1,
                Key = 0,
                _60 = knownNotes.Contains((byte)60) ? 1 : 0,
                _61 = knownNotes.Contains((byte)61) ? 1 : 0,
                _62 = knownNotes.Contains((byte)62) ? 1 : 0,
                _63 = knownNotes.Contains((byte)63) ? 1 : 0,
                _64 = knownNotes.Contains((byte)64) ? 1 : 0,
                _65 = knownNotes.Contains((byte)65) ? 1 : 0,
                _66 = knownNotes.Contains((byte)66) ? 1 : 0,
                _67 = knownNotes.Contains((byte)67) ? 1 : 0,
                _68 = knownNotes.Contains((byte)68) ? 1 : 0,
                _69 = knownNotes.Contains((byte)69) ? 1 : 0,
                _70 = knownNotes.Contains((byte)70) ? 1 : 0,
                _71 = knownNotes.Contains((byte)71) ? 1 : 0,
                _72 = knownNotes.Contains((byte)72) ? 1 : 0,
                _73 = knownNotes.Contains((byte)73) ? 1 : 0,
                _74 = knownNotes.Contains((byte)74) ? 1 : 0,
                _75 = knownNotes.Contains((byte)75) ? 1 : 0,
                _76 = knownNotes.Contains((byte)76) ? 1 : 0,
                _77 = knownNotes.Contains((byte)77) ? 1 : 0,
                _78 = knownNotes.Contains((byte)78) ? 1 : 0,
                _79 = knownNotes.Contains((byte)79) ? 1 : 0
            };
        }

        // This method converts the note letter (ex: C, D, E, ...) to a number
        // The note number can then be used to display the notes in the UI and to create the playable MIDI
        private byte ConvertToNoteNumber(string note, IEnumerable<byte> knownNotes)
        {
            var noteNumber = ConvertNoteNameToNumber(note);
            var adjusted = AdjustToMeasureOctave(noteNumber, knownNotes);
            return (byte)adjusted;
        }

        private int ConvertNoteNameToNumber(string note)
        {
            switch (note)
            {
                case "C":
                    return 0;
                case "C#":
                    return 1;
                case "D":
                    return 2;
                case "D#":
                    return 3;
                case "E":
                    return 4;
                case "F":
                    return 5;
                case "F#":
                    return 6;
                case "G":
                    return 7;
                case "G#":
                    return 8;
                case "A":
                    return 9;
                case "A#":
                    return 10;
                case "B":
                    return 11;
                default:
                    throw new ArgumentException();
            }
        }

        private byte AdjustToMeasureOctave(int note, IEnumerable<byte> knownNotes)
        {
            // Find note within octave that average is in
            var avg = (int)knownNotes.Select(n => Convert.ToInt32(n)).Average();
            var octave = avg / 12;
            var result = octave * 12 + note;

            // Check if the corresponding note in the octave above/below
            // is closer to the average
            if (result - avg > 6)
            {
                result -= 12;
            }
            else if (avg - result > 6)
            {
                result += 12;
            }

            return (byte)result;
        }

        // Data schema for input to model:
            // Chorale =  song (1 is song #1, 2 is song #2, ...)
            // Key = indicates if there are any sharps or flats
            // Measure = section of the song/chorale (1 is first block, 2 is second block, ...)
            // Note = the note (letter); this is the Label since we want to predict missing notes
            // 60, 61, ... 79 = indicates whether the note (number) is present in the same measure as the indicated note (letter); 0 = not present, 1 = present
        class ModelInput
        {
            [ColumnName(@"Chorale")]
            public float Chorale { get; set; }

            [ColumnName(@"Key")]
            public float Key { get; set; }

            [ColumnName(@"Measure")]
            public float Measure { get; set; }

            [ColumnName(@"Note")]
            public string Note { get; set; }

            [ColumnName(@"60")]
            public float _60 { get; set; }

            [ColumnName(@"61")]
            public float _61 { get; set; }

            [ColumnName(@"62")]
            public float _62 { get; set; }

            [ColumnName(@"63")]
            public float _63 { get; set; }

            [ColumnName(@"64")]
            public float _64 { get; set; }

            [ColumnName(@"65")]
            public float _65 { get; set; }

            [ColumnName(@"66")]
            public float _66 { get; set; }

            [ColumnName(@"67")]
            public float _67 { get; set; }

            [ColumnName(@"68")]
            public float _68 { get; set; }

            [ColumnName(@"69")]
            public float _69 { get; set; }

            [ColumnName(@"70")]
            public float _70 { get; set; }

            [ColumnName(@"71")]
            public float _71 { get; set; }

            [ColumnName(@"72")]
            public float _72 { get; set; }

            [ColumnName(@"73")]
            public float _73 { get; set; }

            [ColumnName(@"74")]
            public float _74 { get; set; }

            [ColumnName(@"75")]
            public float _75 { get; set; }

            [ColumnName(@"76")]
            public float _76 { get; set; }

            [ColumnName(@"77")]
            public float _77 { get; set; }

            [ColumnName(@"78")]
            public float _78 { get; set; }

            [ColumnName(@"79")]
            public float _79 { get; set; }

    }

        // Data schema for output of model
            // Prediction = the predicted missing note (letter)
            // Score = float array of confidence Scores
        public class ModelOutput
        {
            [ColumnName("PredictedLabel")]
            public string Prediction { get; set; }

            public float[] Score { get; set; }
        }
    }
}
