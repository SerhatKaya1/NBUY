using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekTarifiApp.Entity.Concrate
{
    public class FoodOfTheDay
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public string Specification { get; set; } //Tarif
        public int Point { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
