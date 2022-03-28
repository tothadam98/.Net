using Algorithmics.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Algorithmics.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected AppDbContext()
        {
        }

        public DbSet<Algorithm> Algorithms { set; get; }
    }
}
