using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Entity.Concrete
{ //hangi ürün hangi kategodriden diyoruz bu sayfada . Primarykey olmak zorundadır.
    public class ProductCategory 
    {
        public int ProductId { get; set; } //ilgili productın bilgisi. 
        public Product Product { get; set; } //product tipinde Product isminde değişken oluşturduk.
        public int  CategoryId { get; set; }
        public Category  Category { get; set; }

    }
}
