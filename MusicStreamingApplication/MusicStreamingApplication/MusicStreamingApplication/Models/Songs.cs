using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStreamingApplication.Models
{
    class Songs
    {
        public int SongId { get; set; }
        public string SongName { get; set; }
        public string SongFileCover { get; set; }
        public string SongUrl { get; set; }
        public string SongDuration { get; set; }
        public string SingerName { get; set; }
    }
}
