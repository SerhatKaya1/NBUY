namespace Proje_14_Value_Reference_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 45;
            int b = a * 2;

            Random rnd = new Random();

            Kisi kisi1 = new Kisi();   //kişi referance time, kişi1 value time
            kisi1.Ad = "Serhat";
            kisi1.Yas = "26";
            kisi1.Meslek = "Software Deveoper";

            Kisi kişi2 = new Kisi();
            kişi2.Ad = "Saliha";
            kişi2.yas yas = 40;
            kişi2.Meslek = "Ogrenci";

            Kisi kişi3 = new Kisi ();
            kişi3.Ad = "Saliha";
            kişi3.yas yas = 40;
            kişi3.Meslek = "Ogrenci";

            Araba araba1 = new Araba();
            araba1.Marka = "Opel";
            araba1.Renk = "KIrmızı";

            DateTime bugun = DateTime.Now;
            Random rnd2 = new Random();



        }
        class Kisi
        {
            public string? Ad { get; set; }
            public int Yas { get; set; }
            public string? Meslek { get; set; }


        }
        class Araba
        {
            public string Marka { get; set; }    //dışarıdan erişiebilir
            public string Renk { get; set; }
            private string VitesTuru { get; set; } //Erişim belirleyici: Bir property'nin dışarıdan yani içinde bulunduğu classın dışından erişim seviyesinin beirleyen anahtar sözcüklere denir.Herhangi bir erişim blirleyici kullanılmamışsa ,default eriim beirleyici olarak kabul edilir .
            //Erişim Belireyicier :
            //1- public
            //2- private
            //3- internal
            //4- protected

        }

    }
}