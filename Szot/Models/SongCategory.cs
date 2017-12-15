using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Szot.Models
{
    public class SongCategory
    {
        [Key]
        [Column(Order = 0)]
        public int  SongID { get; set; }

        [Key]
        [Column(Order = 1)]
        public int CategoryID { get; set; }


        public virtual Category Category { get; set; }
        public virtual Song Song { get; set; } 
    }
}