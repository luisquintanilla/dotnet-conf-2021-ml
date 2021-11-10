using Manufaktura.Controls.Model.SMuFL;
using System;
using System.Collections.Generic;

namespace Manufaktura.Controls.Model.Fonts
{
    public abstract class FontProfile
    {
        public Dictionary<MusicFontStyles, double> FontSizes { get; } = new Dictionary<MusicFontStyles, double>
        {
            { MusicFontStyles.MusicFont, 25 },
            { MusicFontStyles.GraceNoteFont, 18 },
            { MusicFontStyles.StaffFont, 30.5 },
            { MusicFontStyles.LyricsFont, 11},
            { MusicFontStyles.DirectionFont, 11},
            { MusicFontStyles.TimeSignatureFont, 14.5}
        };

        public bool IsSMuFLFont => MusicFont.IsSMuFLFont && SMuFLMetadata != null;
        public abstract IMusicFont MusicFont { get; }
        public virtual TimeSpan Performance => TimeSpan.FromSeconds(0);
        public abstract ISMuFLFontMetadata SMuFLMetadata { get; }
        public FontProfile SetFontSize(MusicFontStyles style, double size)
        {
            FontSizes[style] = size;
            return this;
        }
    }
}