using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekTarifiApp.Entity.Concrate
{
    public class FoodComment
    {
        public int FoodId { get; set; } // Bir yorum bir yemekte olmak zorunda . bu yüzden id yi burada yazdım.
        public Food Food { get; set; } //Bir yorum bir yemeğe ait olsun.
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
        

    }
}
