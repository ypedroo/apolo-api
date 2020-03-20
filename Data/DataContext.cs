using Apolo.Models;
using Microsoft.EntityFrameworkCore;

namespace Apolo.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source='C:\Databases\ApoloDB.db'");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>();
            modelBuilder.Entity<Songs>();

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Songs> Songs { get; set; }
    }
}
