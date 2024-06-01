using Microsoft.EntityFrameworkCore;

namespace newproject.TestEntityFrameWork.entity
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}