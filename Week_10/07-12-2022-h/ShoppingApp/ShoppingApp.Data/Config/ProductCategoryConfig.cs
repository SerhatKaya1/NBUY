using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1 nolu product 1 nolu categoriden gibi işlemleri yapıyouz.
namespace ShoppingApp.Data.Config
{
    public class ProductCategoryConfig : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(pc=> new { pc.ProductId, pc.CategoryId });
            //Burada ProductId ve CategoriId'den oluşan her bir satırın bir kez daha tekrar etmemesi için 
            //bir Conposite Primary key tanımlaması yaprık.
            builder.HasData(
                new ProductCategory { ProductId=1, CategoryId=1}, //hem 1id hem 2 id ye ata
                new ProductCategory { ProductId = 1, CategoryId = 2 }, //hem telefon hem categoriden old sçöyler
                new ProductCategory { ProductId = 2, CategoryId = 2 },
                new ProductCategory { ProductId = 2, CategoryId = 1 }, //hem tel hem elektronik categorisinden old söyledi
                new ProductCategory { ProductId = 3, CategoryId = 2 },
                new ProductCategory { ProductId = 3, CategoryId = 1 },
                new ProductCategory { ProductId = 4, CategoryId = 2 },
                new ProductCategory { ProductId = 4, CategoryId = 1 },

                 new ProductCategory { ProductId = 5, CategoryId = 2 },

                 new ProductCategory { ProductId = 6, CategoryId = 2 }, //kablo ve ipad kategoriye soktuk

                 new ProductCategory { ProductId = 7, CategoryId = 2 },
                 new ProductCategory { ProductId = 7, CategoryId = 4 },
                 new ProductCategory { ProductId = 12, CategoryId = 2 },
                 new ProductCategory { ProductId = 12, CategoryId = 4 },


                  new ProductCategory { ProductId = 8, CategoryId = 2 },

                  new ProductCategory { ProductId = 9, CategoryId = 2 },
                  new ProductCategory { ProductId = 9, CategoryId = 3 },
                  new ProductCategory { ProductId = 10, CategoryId = 2 },
                  new ProductCategory { ProductId = 10, CategoryId = 3 },
                  new ProductCategory { ProductId = 11, CategoryId = 2 },
                  new ProductCategory { ProductId = 11, CategoryId = 3 }
                  //her productları atamış olduk.
                );
        }
    }
}
