using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekTarifiApp.Entity.Concrate
{
    public class Recipe //Yemek tarifi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Material { get; set; } //Malzemeler
        public string RecipeMaking { get; set; } //Tarif Yapılışı
        public string Image { get; set; } //Resimler
        public string Owner { get; set; } //Yemek Sahibi
        public string OwnerMail { get; set; } //Yemek Sahibi Maili
        public int FoodId { get; set; } // Bir tarif bir yemekte olmak zorunda .
        public Foot Food { get; set; } //Bir tarif bir yemeğe ait olsun .

    }
}
