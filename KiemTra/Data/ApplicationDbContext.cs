using Microsoft.EntityFrameworkCore;

namespace KiemTra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Add your DbSet properties here for your models
        // Example: public DbSet<YourModel> YourModels { get; set; }
    }
} 