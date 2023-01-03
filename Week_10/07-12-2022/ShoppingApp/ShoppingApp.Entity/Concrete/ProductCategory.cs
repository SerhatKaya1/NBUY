using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Entity.Concrete
{
    public class ProductCategory
    {
        public int ProductId { get; set; } //ForeignKey e karşılık geliyor. Bağımlı olan entityde görev alıyor. Bu 1-1 e ilişkidir.
        public Product Product { get; set; }  //Her bir ProductCategorinin bir tane Product ı yani ürünü vardır.
        public int CategoryId { get; set; } //ForeignKey e karşılık geliyor. Bağımlı olan entityde görev alıyor.
        public Category Category { get; set; } //Her bir  ProductCategory nin bir tane Categegory'si vardır . Bu 1-1 ilişkiyi temsil eder.
    }
}
//Product ile ProductCategory arasında bağlantıyı kurmak amacıyla ProductId yi tanımlıyoruz.
//ProductCategory Product a bağımlıdır . Bu yüzden burada tanımlama yapıyorum.