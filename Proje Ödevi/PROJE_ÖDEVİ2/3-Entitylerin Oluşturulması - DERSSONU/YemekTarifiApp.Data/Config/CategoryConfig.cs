using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifiApp.Entity;

namespace YemekTarifiApp.Data.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
               .IsRequired()
               .HasMaxLength(50);

            builder.HasKey(c => c.Qty);
            builder.Property(c => c.Qty).ValueGeneratedOnAdd();

            builder.Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(c => c.Url)
              .IsRequired()
              .HasMaxLength(250);


            builder.ToTable("Categories");
            builder.HasData(

               new Category { Id = 1 , Name= "Çorba" , Qty = 5 , Description="Çorbalar bu Categoride bulunmaktadır" , Url = "Çorbalar"  },
               new Category { Id = 2 , Name= "Et Yemkleri" , Qty = 5 , Description="Et Yemekleri bu Categoride bulunmaktadır" , Url = "Et Yemekleri"  },
               new Category { Id = 3 , Name= "Tavuk Yemekleri" , Qty = 5 , Description="Tavuk Yemekleri bu Categoride bulunmaktadır" , Url = "Tavuk Yemekleri"  },
               new Category { Id = 4, Name = "Balık Yemekleri", Qty = 5, Description = "Balık Yemekleri bu Categoride bulunmaktadır", Url = "Balık Yemekleri" },
               new Category { Id = 5, Name = "Zeytinyağlılar", Qty = 5, Description = "Zeytinyağlılar bu Categoride bulunmaktadır", Url = "Zeytinyağlı Yemekler" },
               new Category { Id = 6, Name = "Salatalar", Qty = 5, Description = "Salatalar bu Categoride bulunmaktadır", Url = "Tatlılar" },
               new Category { Id = 7, Name = "Tatlılar", Qty = 5, Description = "Tatlılar bu Categoride bulunmaktadır", Url = "Tatlılar" },
               new Category { Id = 8, Name = "İçecekler", Qty = 5, Description = "İçecekler bu Categoride bulunmaktadır", Url = "İçecekler" }


                );

        }
    }
}
