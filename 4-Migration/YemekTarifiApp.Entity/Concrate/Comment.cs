using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifiApp.Entity.Abstract;

namespace YemekTarifiApp.Entity.Concrate
{
    public class Comment : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; } //Yorum yazan kişinin maili
        public DateTime DateAdded { get; set; } //Mesajın yazılma tarihi
        public bool Confirmation { get; set; } //Yorum onay-Hakaret içerikli, yorumları engellemek isteriz.
        public string Details { get; set; }
        public List<FoodComment> FoodComments { get; set; } //Bir yemeğe birden fazla yorum yapılabilir.
    }
}
