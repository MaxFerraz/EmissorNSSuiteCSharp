using EmissorNSSuiteCSharp.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmissorNSSuiteCSharp.DAO
{
    public partial class NSSuiteContext : DbContext
    {
        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ICMS>().Property<int>("ProductId");
            modelBuilder.Entity<PIS>().Property<int>("ProductId");
            modelBuilder.Entity<COFINS>().Property<int>("ProductId");
            modelBuilder.Entity<IPI>().Property<int>("ProductId");
            modelBuilder.Entity<ISSQN>().Property<int>("ProductId");
            modelBuilder.Entity<ICMS>().HasKey("ProductId");
            modelBuilder.Entity<PIS>().HasKey("ProductId");
            modelBuilder.Entity<COFINS>().HasKey("ProductId");
            modelBuilder.Entity<IPI>().HasKey("ProductId");
            modelBuilder.Entity<ISSQN>().HasKey("ProductId");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=.\NSSuiteDB.db;");       
        } 
    }
}
