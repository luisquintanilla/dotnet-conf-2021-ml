using System.Collections.Generic;

namespace MAUIMusicMLApp.Models
{
    // Each measure has notes
    public class MusicMeasure
    {
        public IEnumerable<MusicNote> Notes { get; set; }
    }
}
