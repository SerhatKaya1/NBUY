using ShoppingApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Entity.Concrete
{
    public class Category : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public List<ProductCategory> ProductCategories { get; set; } //Bir kategoride birden fazla ProductCategory Olabilir.
        //Bu sayfada 1 e çokları yazdık.
    }
}


