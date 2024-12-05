using Microsoft.EntityFrameworkCore;
namespace devmindfusion.Models
{
    public class DevMindFusionDbContext : DbContext
    {
        public DevMindFusionDbContext(DbContextOptions<DevMindFusionDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
