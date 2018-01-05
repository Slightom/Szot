using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Szot.Models
{
    public class SongAuthor
    {
        [Key]
        [Column(Order = 0)]
        public int SongID { get; set; }

        [Key]
        [Column(Order = 1)]
        public int AuthorID { get; set; }

        public virtual Song Song { get; set; }
        public virtual Author Author { get; set; }
    }
}