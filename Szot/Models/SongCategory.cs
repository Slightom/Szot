using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Szot.Models
{
    public class SongCategory
    {
        [Key]
        public int  SongID { get; set; }

        [Key]
        public int CategoryID { get; set; }


        public virtual Category Category { get; set; }
        public virtual Song Song { get; set; } 
    }
}