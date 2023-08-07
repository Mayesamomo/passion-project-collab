using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.ComponentModel.DataAnnotations.Schema;
>>>>>>> 929618d4d90f676b22cb334fb68b2c6ae61cb84d
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnimeMusic.Models
{
    public class Genre
    {
        [Key]
<<<<<<< HEAD
        public int GenreId { get; set; }

        [Required(ErrorMessage = "The Genre Name is required.")]
        [StringLength(50, ErrorMessage = "The Genre Name must be between 1 and 50 characters.", MinimumLength = 1)]
        public string GenreTitle { get; set; }

        //one-to-many relationship between Genre and Song
        //genre has many songs 
        public ICollection<Song> Songs { get; set; }
    }


    public class GenreDto
    {
        public int GenreId { get; set; }
        public string GenreTitle { get; set; }
    }

=======
        public int GenreID { get; set; }
        public string GenreName { get; set; }

        [ForeignKey("Anime")]
        public int AnimeID { get; set; }
        public virtual Anime Anime { get; set; }

        //Game
    }
    public class GenreDto
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }
        public int AnimeID { get; set; }
        public string AnimeName { get; set; }
    }
>>>>>>> 929618d4d90f676b22cb334fb68b2c6ae61cb84d
}