using LilStoriesAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LilStoriesAPI.Context
{
    public class LilStoriesApiContext : DbContext
    {
        public LilStoriesApiContext(DbContextOptions<LilStoriesApiContext> options) : base(options)
        {
        }

        public DbSet<Story> Stories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);            
        }
    }
}
