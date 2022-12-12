using ShoppingApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bir product birden fazla categordide olabilir diyoruz.
namespace ShoppingApp.Entity.Concrete
{
    public class Product : IEntityBase //IEntityBaseden miras alıyoruz.
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int? Price { get; set; } //sayısaldeğerde olsa boş bırakılabilir olsun.? ile yapıyoruz
        public string Description { get; set; }
        public string ImageUrl { get; set; } 
        public string Url { get; set; }
        public bool IsHome { get; set; } //Bu anasayfa ürünümü değil mi ?
        public bool IsApproved { get; set; }
        public  DateTime DateAdded { get; set; }
        public List<ProductCategory> ProductCategories { get; set; } //product categori tipinde içinde değerler tanıyan
    }
}
