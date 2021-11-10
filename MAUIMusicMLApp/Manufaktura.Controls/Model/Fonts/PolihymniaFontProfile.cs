using Manufaktura.Controls.Model.SMuFL;

namespace Manufaktura.Controls.Model.Fonts
{
    public class PolihymniaFontProfile : FontProfile
    {
        private readonly IMusicFont musicFont = new PolihymniaFont();
        public override IMusicFont MusicFont => musicFont;

        public override ISMuFLFontMetadata SMuFLMetadata => null;
    }
}