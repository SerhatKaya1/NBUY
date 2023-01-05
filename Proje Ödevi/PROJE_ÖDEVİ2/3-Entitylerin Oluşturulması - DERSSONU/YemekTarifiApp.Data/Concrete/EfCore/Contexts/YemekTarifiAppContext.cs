using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifiApp.Entity;
using YemekTarifiApp.Entity.Concrate;


namespace YemekTarifiApp.Data.Concrete.EfCore.Contexts
{
    internal class YemekTarifiAppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=YemekTarifiApp.db");
        }
       
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<FoodOfTheDay> FoodOfTheDays { get; set; }
        public DbSet<Food> Foots { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new AdminConfig());
        }
    }
}
