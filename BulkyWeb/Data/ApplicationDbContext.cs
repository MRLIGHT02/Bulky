using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
    {
    public class ApplicationDbContext : DbContext
    {
        protected ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        }
    }
      
    }
