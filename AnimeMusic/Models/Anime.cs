using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnimeMusic.Models
{
    public class Anime
    {
        [Key]
        public int AnimeID { get; set; }
        public string AnimeName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public bool AnimeHasPic { get; set; }
        public string PicExtension { get; set; }
    }
}