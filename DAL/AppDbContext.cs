

using WebAppStories.Models;

namespace WebAppStories.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Stories> Stories { get; set; }
        public DbSet<Recipes> Recipes { get; set; }
    }
}
