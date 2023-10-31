using Algebra_seminarski_rad__Pokemon_webshop_CMS.Models;
using Microsoft.EntityFrameworkCore;

namespace Algebra_seminarski_rad__Pokemon_webshop_CMS.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category {Id = 1, Name = "Fire", DisplayOrder = 1 },
                new Category {Id = 2, Name = "Water", DisplayOrder = 2 },
                new Category {Id = 3, Name = "Psychic", DisplayOrder = 3 }
                );
        }
    }
}
