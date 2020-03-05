using Apolo.Models;
using Microsoft.EntityFrameworkCore;

namespace Apolo.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Songs> Songs { get; set; }
    }
}
