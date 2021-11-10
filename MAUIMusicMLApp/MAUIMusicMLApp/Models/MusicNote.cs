using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIMusicMLApp.Models
{
    // Each note has a variety of properties which are used to display in the UI and play back as a song
    public class MusicNote
    {
        public byte Note { get; set; }
        public byte Velocity { get; set; }
        public byte Position { get; set; }
        public byte Duration { get; set; }
        public bool IsRepaired { get; set; }
    }
}
