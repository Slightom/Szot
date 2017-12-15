using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Szot.Models
{
    public class Backing
    {
        public int BackingID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Enums.BackingStatusEnum BackingStatus { get; set; }

        [Required]
        public string path { get; set; }



        public virtual ICollection<Song> Songs { get; set; }
    }
}