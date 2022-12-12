using Microsoft.EntityFrameworkCore;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd(); //değerler birden başlayarak artar
           
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Description)
               .IsRequired()
               .HasMaxLength(250);

            builder.Property(p => p.ImageUrl)
               .IsRequired()
               .HasMaxLength(250);

            builder.Property(p => p.Url)
               .IsRequired()
               .HasMaxLength(250);

            builder.Property(p => p.DateAdded)
                .HasDefaultValueSql("date('now')"); //Buda sqlite için .
            /*.HasDefauldValueSql("getdate()");*/ //sql ile çalışırken o anki saati veriyor.şuanki çalışmakta olan sqlite böyle oluyor.
            builder.ToTable("Products");

            builder.HasData(
                new Product 
                { 
                    Id = 1,
                    Name = "Samsung S20",
                    Price = 24500,
                    Description = "Kamerası son teknoloji!",
                    ImageUrl = "1.png",
                    Url = "samsung-s20",
                    IsHome = true, 
                    IsApproved = true,
                },
                
                new Product
                {
                    Id = 2,
                    Name = "Samsung S21",
                    Price = 34500,
                    Description = "Kamerası son teknoloji!, 5G",
                    ImageUrl = "2.png",
                    Url = "samsung-s20",
                    IsHome = true,
                    IsApproved = true
                },
                new Product
                {
                    Id = 3,
                    Name = "I Phone 13",
                    Price = 34500,
                    Description = "Güzel telefon!",
                    ImageUrl = "3.png",
                    Url = "iphone-13",
                    IsHome = false,
                    IsApproved = true
                },
                new Product
                {
                    Id = 4,
                    Name = "I Phone 14 Pro",
                    Price = 34500,
                    Description = "Kamerası son teknoloji!",
                    ImageUrl = "4.png",
                    Url = "I Phone14 - Pro",
                    IsHome = false,
                    IsApproved = true
                },
                new Product
                {
                    Id = 5,
                    Name = "IPad 12",
                    Price = 4500,
                    Description = "Kamerası son teknoloji!",
                    ImageUrl = "5.png",
                    Url = "ipad-12",
                    IsHome = true,
                    IsApproved = false
                },
                new Product
                {
                    Id = 6,
                    Name = "Type C Usb Bağlantı Kablosu",
                    Price = 400,
                    Description = "1.5 metre",
                    ImageUrl = "6.png",
                    Url = "type-c-usb-baglantı-kablosu",
                    IsHome = false,
                    IsApproved = true
                },
                new Product
                {
                    Id = 7,
                    Name = "Vestel Cm123",
                    Price = 9500,
                    Description = "Tam otomatik çamaşır makinası",
                    ImageUrl = "7.png",
                    Url = "vestel-cm123",
                    IsHome = true,
                    IsApproved = true
                },
                new Product
                {
                    Id = 8,
                    Name = "Arçelik Türk Kahvesi Makinası TK8",
                    Price = 24500,
                    Description = "Köpüklü Türk kahvesi keyfi",
                    ImageUrl = "8.png",
                    Url = "samsung-s20",
                    IsHome = true,
                    IsApproved = true
                },
                new Product
                {
                    Id = 9,
                    Name = "Macbook",
                    Price = 2450,
                    Description = "Kamerası son teknoloji!",
                    ImageUrl = "9.png",
                    Url = "samsung-s20",
                    IsHome = true,
                    IsApproved = true
                },
                new Product
                {
                    Id = 10,
                    Name = "Asus Tulpar G45",
                    Price = 26500,
                    Description = "I9 İşlemci",
                    ImageUrl = "10.png",
                    Url = "asus-tulpar-g45",
                    IsHome = false,
                    IsApproved = true
                },
                new Product
                {
                    Id = 11,
                    Name = "Lenovo K234",
                    Price = 19000,
                    Description = "İş için ideal",
                    ImageUrl = "11.png",
                    Url = "lenova-k234",
                    IsHome = false,
                    IsApproved = true
                },
                new Product
                {
                    Id = 12,
                    Name = "Samsung NF34 Buzdolabı",
                    Price = 13000,
                    Description = "Derin dondurucu",
                    ImageUrl = "12.png",
                    Url = "samsung-nf34-buzdolabı",
                    IsHome = false,
                    IsApproved = false
                }
                );
        }
    }
}
