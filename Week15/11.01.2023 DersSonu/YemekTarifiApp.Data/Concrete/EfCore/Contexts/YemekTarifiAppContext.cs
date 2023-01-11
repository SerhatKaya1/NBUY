using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifiApp.Data.Config;
using YemekTarifiApp.Entity;
using YemekTarifiApp.Entity.Concrate;


namespace YemekTarifiApp.Data.Concrete.EfCore.Contexts
{
    public class YemekTarifiAppContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<FoodComment> FoodComments { get; set; }
        public DbSet<FoodRecipe> FoodRecipes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=YemekTarifiApp.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new CommnetConfig());
            modelBuilder.ApplyConfiguration(new FoodConfig());
            modelBuilder.ApplyConfiguration(new RecipeConfig()); 
            modelBuilder.ApplyConfiguration(new FoodCategoryConfig());
            modelBuilder.ApplyConfiguration(new FoodComentConfig());
            modelBuilder.ApplyConfiguration(new FoodRecipeConfig());
        }
    }
}
