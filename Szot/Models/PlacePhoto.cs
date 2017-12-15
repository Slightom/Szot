using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Szot.Models
{
    public class PlacePhoto
    {
        [Key]
        [Column(Order = 0)]
        public int PlaceID { get; set; }
        
        [Key]
        [Column(Order = 1)]
        public int PhotoID { get; set; }


        public virtual Place Place { get; set; }
        public virtual Photo Photo { get; set; }
    }
}