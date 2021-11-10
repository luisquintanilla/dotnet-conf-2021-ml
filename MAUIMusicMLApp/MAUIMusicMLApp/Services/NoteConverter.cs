using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using MAUIMusicMLApp.Models;
using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;

// Service to convert MIDI number notes to correct letter notes for UI and playback
namespace MAUIMusicMLApp.Services
{
    internal class NoteConverter
    {
        public static List<MusicalSymbol> Convert(MusicMeasure measure)
        {
            var notes =
                measure.Notes
                    .OrderBy(note => note.Position)
                    .Select((MusicNote note) =>
                    {
                        var (translatedNote, octave, alter) = TranslateNote(note);
                        var direction = note.Note > 71 ? VerticalDirection.Down : VerticalDirection.Up;

                        var (duration, dots) = TranslateDuration(note);

                        if(note.Note == 0)
                        {
                            var missingNote = new Barline(BarlineStyle.Dashed);
                            missingNote.CustomColor = Manufaktura.Controls.Primitives.Color.Red;
                            return missingNote as MusicalSymbol;
                        } else
                        {
                            return new Note(Pitch.FromMidiPitch(note.Note, Pitch.MidiPitchTranslationMode.Auto), duration, true);
                        }

                    })
                    .ToList();
            return notes;
         }

        private static (string Note,int Octave,int Alter) TranslateNote(MusicNote note)
        {
            var octave = note.Note / 12 - 1;
            switch (note.Note % 12)
            {
                case 0:
                    return ("C", 0, octave);
                case 1:
                    return ("C", 1, octave);
                case 2:
                    return ("D", 0, octave);
                case 3:
                    return ("D", 1, octave);
                case 4:
                    return ("E", 0, octave);
                case 5:
                    return ("F", 0, octave);
                case 6:
                    return ("F", 1, octave);
                case 7:
                    return ("G", 0, octave);
                case 8:
                    return ("G", 1, octave);
                case 9:
                    return ("A", 0, octave);
                case 10:
                    return ("A", 1, octave);
                case 11:
                    return ("B", 0, octave);
                default:
                    throw new Exception("Unreachable code!");
            }
        }

        private static (RhythmicDuration Duration, int Dots) TranslateDuration(MusicNote note)
        {
            switch (note.Duration)
            {
                case 1:
                    return (RhythmicDuration.Sixteenth, 0);
                case 2:
                    return (RhythmicDuration.Eighth, 0);
                case 4:
                    return (RhythmicDuration.Quarter, 0);
                case 6:
                    return (RhythmicDuration.Eighth, 1);
                case 8:
                    return (RhythmicDuration.Half, 0);
                case 16:
                    return (RhythmicDuration.Whole, 0);
                default:
                    throw new ArgumentException($"Don't know how to translate {note.Duration}/16ths of a note.");
            }
        }
    }
}
