using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekTarifiApp.Entity.Concrate
{
    internal class FoodComment
    {
        public int FoodId { get; set; } // Bir yorum bir yemekte olmak zorunda . bu yüzden id yi burada yazdım.
        public Foot Food { get; set; } //Bir yorum bir yemeğe ait olsun

    }
}
