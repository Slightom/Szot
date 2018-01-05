using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Szot.Models
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext() : base("SzotDB", throwIfV1Schema: false) { }


        public DbSet<Author> Authors { get; set; }
        public DbSet<Backing> Backings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<PlacePhoto> PlacePhotos { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<SongAuthor> SongAuthors { get; set; }
        public DbSet<SongCategory> SongCategories { get; set; }



        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}