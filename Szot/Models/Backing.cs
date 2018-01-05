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

        public int SongID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Enums.BackingStatusEnum BackingStatus { get; set; }

        [Required]
        public string path { get; set; }

        public bool MainBacking { get; set; }

        public virtual Song Song { get; set; }
    }
}