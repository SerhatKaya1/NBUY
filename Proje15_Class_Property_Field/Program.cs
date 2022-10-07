namespace Proje15_Class_Property_Field
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.OgrNo = 11;
            ogrenci1.Ad = "Ahmet";
            ogrenci1.Sinif = "9A";

            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.OgrNo = 12;
            ogrenci2.Ad = "Selim";
            ogrenci2.Sinif = "10B";

            Ogrenci ogrenci3 = new Ogrenci()
            {
                OgrNo = 15,
                Ad = "Umay",
                Sinif = "10C"
            };
            int[] sayilar = { 32, 54, 33 };
            Ogrenci[] ogrenciler = { ogrenci1, ogrenci2, ogrenci3 };
            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine($"Ad: {ogrenciler[i].Ad}, Sinif: {ogrenciler[i].Sinif}");
            //}

            //foreach (var sıradakiOgrenci in ogrenciler)
            //{
            //    Console.WriteLine(sıradakiOgrenci.Ad + ", " + sıradakiOgrenci.Sinif);
            //}

             //foreach (var sıradakiSayi in sayilar)

             //{

             //}
        }     
        class Ogrenci
        {
            private int ogrNo;

            public int ogrNo
            {
                get { return ogrNo; }
                set { ogrNo = value; }
            }

            private string ad;

            public string Ad
            {
                get { return ad.ToUpper(); }
                set { ad = value; }
            }

            public string Sinif { get; set; }
        }
    }
}