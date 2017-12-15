using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Szot.Models
{
    public class Post
    {
        public int PostID { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public Enums.PostStatusEnum Status { get; set; }


        public virtual User User { get; set; }
    }
}