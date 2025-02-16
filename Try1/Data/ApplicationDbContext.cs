using Microsoft.EntityFrameworkCore;
using Try1.Entities;

namespace Try1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<News> Newses { get; set; }


    }
}
