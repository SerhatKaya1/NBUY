using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekTarifiApp.Entity.Concrate
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public DateTime AddDate { get; set; }
        public int Point { get; set; }
        public int CategoryId { get; set; } //Her bir yemek bir categoride olmak zorunda bu yüzden C.Id yi burada tanımladım.
        public Category Category { get; set; } //Bir yemek bir kategoride olsun diye tasarım yapıyorum.
        public List<Comment> Comment { get; set; } //Bir yemeğe birden fazla yorum yapılabilir.
        public List<Recipe> Recipe { get; set; } //Bir yemeğe birden fazla yorum yazılabilir.
    }
}
