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


        public bool WithBacking { get; set; }

        public string Info { get; set; }

        public Enums.LanguageEnum TextLanguage { get; set; }


        public virtual ICollection<SongCategory> SongCategories { get; set; }
        public virtual ICollection<SongAuthor> SongAuthors { get; set; }
        public virtual ICollection<Backing> Backings { get; set; }
    }
}