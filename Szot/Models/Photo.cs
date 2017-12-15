using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Szot.Models
{
    public class Photo
    {
        public int PhotoID { get; set; }

        [Required]
        public string Path { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }


        public virtual ICollection<PlacePhoto> PlacePhotos { get; set; }
    }
}