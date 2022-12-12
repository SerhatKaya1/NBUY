using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data.Config;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Concrete.EfCore.Context
{
    public class ShopAppContext : DbContext //dbcontext üstüne gel ve atama yap.

    {
        public DbSet<Category> Categories { get; set; } //categories tablosunu oluşturur.
        public DbSet<Product> Products { get; set; } //bir tabloda bir sürü productlar olur.tablo isimleri çoğul olamlı
        public DbSet<ProductCategory> ProductCategories { get; set; } //Bunu buraya yazmasakda veri tabanında da yapacaktır.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ShoppingApp.db"); //.db dememizdeki amaç tıkladığımızda hemen ilişki kursun diye
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Configuration'larımızı uygulayacağız.
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfig());
            
        }

    }
}
