using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Szot.Models
{
    public class PlacePhoto
    {
        [Key]
        public int PlaceID { get; set; }
        
        [Key]
        public int PhotoID { get; set; }


        public virtual Place Place { get; set; }
        public virtual Photo Photo { get; set; }
    }
}