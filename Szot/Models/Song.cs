using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Szot.Models
{
    public class Song
    {
        public int SongID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int AuthorID { get; set; }

        public int? BackingID { get; set; }

        public bool WithBacking { get; set; }

        public Enums.LanguageEnum TextLanguage { get; set; }


        public virtual ICollection<SongCategory> SongCategories { get; set; }
        public virtual Author Author { get; set; }
        public virtual Backing Backing { get; set; }
    }
}