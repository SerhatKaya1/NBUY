using Microsoft.EntityFrameworkCore;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Burada konfigürasyon işlemleri gereçkleştirilecektir.
namespace ShoppingApp.Data.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category> //bu generic bir yapı 
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);  //
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired(); //oluşacak veritabanımızda bu bilgiler olacak.
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50); //kaç karakter olacak

            builder.Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(500); //kaç karakter olacak

            builder.Property(c => c.Url)
              .IsRequired()
              .HasMaxLength(250); //kaç karakter olacak

            builder.ToTable("Categories"); //Veri tabanımızdaki veritabı ismini yazıyoruz.

            builder.HasData( //kullanıcı bilgileri girelim
                new Category
                {
                    Id = 1,
                    Name = "Telefon",
                    Description = "Telefonlar bu kategoride bulunmaktadır.",
                    Url="telefon"
                },


            new Category
            {
                Id = 2,
                Name = "Elektronik",
                Description = "Elektronik bu kategoride bulunmaktadır.",
                Url="elektronik"
            },

            new Category
            {
                Id = 3,
                Name = "Bilgisayar",
                Description = "Bilgisayarlar bu kategoride bulunmaktadır.",
                Url="bilgisayar"
            },

            new Category
            {
                Id = 4,
                Name = "Beyaz Eşya",
                Description = "Beyaz eşyalar bu kategoride bulunmaktadır.",
                Url="beyaz-esya"
            });
                

        }
    }
}
