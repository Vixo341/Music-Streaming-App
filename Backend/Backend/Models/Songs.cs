using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class Songs
    {
        [Key]
        public int SongId { get; set; }

        [Required(ErrorMessage = "Song Name Requires")]
        [StringLength(maximumLength:100, ErrorMessage ="Song Name must not exceed 100 characters")]
        public string SongName { get; set; }

        [Required(ErrorMessage = "Song File Cover Requires")]
        [StringLength(maximumLength: 500, ErrorMessage = "Song File Cover must not exceed 500 characters")]
        public string SongFileCover { get; set; }

        [Required(ErrorMessage = "Song Url Requires")]
        [StringLength(maximumLength: 800, ErrorMessage = "Song Url must not exceed 800 characters")]
        public string SongUrl { get; set; }

        [Required(ErrorMessage = "Song Duration Requires")]
        [StringLength(maximumLength: 10, ErrorMessage = "Song Duration must not exceed 10 characters")]
        public string SongDuration { get; set; }

        [Required(ErrorMessage = "Singer Name Requires")]
        [StringLength(maximumLength: 500, ErrorMessage = "Singer Name must not exceed 500 characters")]
        public string SingerName { get; set; }
    }
}