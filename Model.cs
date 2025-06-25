using PersonalAgendaAPI.Data;
using PersonalAgendaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace PersonalAgendaAPI
{
    public class AppDbContext : DbContext
    {
        public DbSet<PostCategory> postCategories { get; set; }
        public DbSet<PostCategoryDisplaySettings> postCategoryDisplaySettings { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new DbInitializer(modelBuilder).Seed();
        }

    }
}
