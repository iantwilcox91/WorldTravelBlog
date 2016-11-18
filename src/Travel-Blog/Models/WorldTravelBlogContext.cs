using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travel_Blog.Models
{
    public class WorldTravelBlogContext : DbContext
    {

        public DbSet<Location> Locations { get; set; }

        public DbSet<Experience> Experiences { get; set; }
        public WorldTravelBlogContext(DbContextOptions<WorldTravelBlogContext> options)
            : base(options)
        {
        }

        public WorldTravelBlogContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}