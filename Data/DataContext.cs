using Apolo.Models;
using Microsoft.EntityFrameworkCore;

namespace Apolo.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source='C:\Databases\ApoloDB.db'");
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Songs> Songs { get; set; }
    }
}
