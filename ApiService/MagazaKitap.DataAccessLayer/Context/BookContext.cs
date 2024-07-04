using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitapMagaza.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace MagazaKitap.DataAccessLayer.Context
{
    public class BookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1434;initial Catalog = BookDb;User=sa;Password=123456aA.");
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<BasketTotal> BasketTotals { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<CashBox> CashBoxes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Selling> Sellings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Author varlığını anahtarsız olarak yapılandırın
            modelBuilder.Entity<BasketItem>()
                .HasNoKey();
            modelBuilder.Entity<BasketTotal>()
                .HasNoKey();
        }
    }
}
