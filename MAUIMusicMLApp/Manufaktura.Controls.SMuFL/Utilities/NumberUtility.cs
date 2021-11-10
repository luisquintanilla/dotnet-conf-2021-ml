using Manufaktura.Controls.Model.Assertions;
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Controls.Rendering;

namespace Manufaktura.Controls.SMuFL.Utilities
{
    public abstract class NumberUtility
    {
        public abstract string BuildNumber(int number);

        public abstract BoundingBox GetBoundingBox(ISMuFLFontMetadata metadata, char digit);

        [Units(Units.Linespaces)]
        public double GetNumberWidthLs(ISMuFLFontMetadata metadata, int number)
        {
            if (metadata == null) return 0;

            double width = 0;
            var digits = number.ToString();
            foreach (var digit in digits)
            {
                var bounds = GetBoundingBox(metadata, digit);
                width += bounds.BBoxNe[0] - bounds.BBoxSw[0];
            }
            return width;
        }

        [Units(Units.Pixels)]
        public double GetNumberWidthPx(ScoreRendererBase renderer, int number) => renderer.LinespacesToPixels(GetNumberWidthLs(renderer.Settings.MusicFontProfile.SMuFLMetadata, number));
    }
}