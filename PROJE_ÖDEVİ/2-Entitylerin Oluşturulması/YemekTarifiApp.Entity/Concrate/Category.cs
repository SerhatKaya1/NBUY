using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifiApp.Entity.Abstract;
using YemekTarifiApp.Entity.Concrate;

namespace YemekTarifiApp.Entity
{
    public class Category : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public string Image { get; set; }
        public List<Food> Foods { get; set;} //Bir category'de birden fazla yemek olabilir.
    }
}
