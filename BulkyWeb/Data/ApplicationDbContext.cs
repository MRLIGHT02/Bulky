using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
    {
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { CatagoryId = 1 ,Name="mohan",DisplayOrder=10},
                new Category { CatagoryId = 2 ,Name="sohan",DisplayOrder=20},
                new Category { CatagoryId = 3 ,Name="rohan",DisplayOrder=30}
              
                );
        }

    }

}
