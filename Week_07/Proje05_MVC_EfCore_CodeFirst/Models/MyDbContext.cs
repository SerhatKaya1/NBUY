using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Proje05_MVC_EfCore_CodeFirst.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<City> Citys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=First.db");
        }
    
       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
            .HasData(
               new Category() {Id=1, Name="Phone", Desc="Phones"},
               new Category() {Id=2, Name="Computer", Desc="Computers"},
               new Category() {Id=3, Name="Electronic", Desc="Electronics"}
            );
            modelBuilder.Entity<Product>()
            .HasData(
             new Product() {Id=1, Name="IPhone 13", Desc="Güzelbir telefon", Price=19000, CategoryId=1},       
             new Product() {Id=2, Name="Dell Xs", Desc="Güzel PC", Price=29000, CategoryId=2},       
             new Product() {Id=3, Name="Samsung Xs", Desc="Güzel camera", Price=39000, CategoryId=1},       
             new Product() {Id=4, Name="Piranha X13", Desc="Güzel ses", Price=49000, CategoryId=3}     
            );

           modelBuilder.Entity<City>()
           .HasData( 
            new City{Id=34, Name="Istanbul"},
            new City{Id=35, Name="Izmir"},
            new City{Id=36, Name="Canakkale"}
           
           );
        }
    }
}