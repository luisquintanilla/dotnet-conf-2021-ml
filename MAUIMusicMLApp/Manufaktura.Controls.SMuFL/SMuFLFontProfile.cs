using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Core;
using Polenter.Serialization;
using System;
using System.IO;

namespace Manufaktura.Controls.SMuFL
{
    public class SMuFLFontProfile : FontProfile
    {
        private readonly IMusicFont musicFont;
        private readonly ISMuFLGlyphs glyphsInstance;

        private ISMuFLFontMetadata metadata;

        internal SMuFLFontProfile(ISMuFLFontMetadata metadata, ISMuFLGlyphs glyphsInstance)
        {
            this.metadata = metadata;
            this.glyphsInstance = glyphsInstance;
            musicFont = new SMuFLMusicFont(glyphsInstance);
        }

        public override TimeSpan Performance => (metadata as IMeasureDeserializationPerformance)?.GetTotalDeserializationTimeWithChildElements() ?? TimeSpan.FromSeconds(0) +
            (glyphsInstance as IMeasureDeserializationPerformance)?.GetTotalDeserializationTimeWithChildElements() ?? TimeSpan.FromSeconds(0);

        public override IMusicFont MusicFont => musicFont;
        public override ISMuFLFontMetadata SMuFLMetadata => metadata;

        public void SerializeMetadataAsBinary(Stream outputStream)
        {
            var settings = new SharpSerializerBinarySettings(BinarySerializationMode.SizeOptimized);
            var serializer = new SharpSerializer(settings);
            serializer.Serialize(SMuFLMetadata, outputStream);
        }
    }
}