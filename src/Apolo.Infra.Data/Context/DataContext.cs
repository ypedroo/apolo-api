using Microsoft.EntityFrameworkCore;

namespace Apolo.Infra.Data.Context
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source='C:\database\ApoloDB.db'");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .Property(p => p.Id)
                .IsRequired();
            modelBuilder.Entity<Songs>();

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Songs> Songs { get; set; }
    }
    }
}