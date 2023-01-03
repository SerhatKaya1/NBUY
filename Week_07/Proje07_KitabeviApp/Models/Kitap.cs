using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitabeviApp.Models
{
    public class Kitap
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int BasimYili { get; set; }
        public int SayfaSayisi { get; set; }
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; } //Birden fazla kitap aynı categorye sahip olabilir. Bir kitabın bir kategorisi olabilir.
        public int YazarId { get; set; }
        public Yazar Yazar { get; set; } //Bir yazar birden fazla kitabda yazarlık yapabilir. Fakat her kitabın 1 yazarı olabilir.
        public string Ozet { get; set; }
        public bool AnaSayfa { get; set; }
    }
}