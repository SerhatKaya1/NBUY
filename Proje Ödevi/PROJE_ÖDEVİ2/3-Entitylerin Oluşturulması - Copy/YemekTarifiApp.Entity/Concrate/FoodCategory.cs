using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekTarifiApp.Entity.Concrate
{
    internal class FoodCategory
    {
        public Category Category { get; set; } //Bir yemek bir kategoride olsun diye tasarım yapıyorum.
        public int CategoryId { get; set; } //Her bir yemek bir categoride olmak zorunda bu yüzden C.Id yi burada tanımladım.
        public int FoodId { get; set; } // Bir yorum bir yemekte olmak zorunda . bu yüzden id yi burada yazdım.
        public Foot Food { get; set; } //Bir yorum bir yemeğe ait olsun
    }
}
