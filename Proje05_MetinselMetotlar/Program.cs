namespace Proje05_MetinselMetotlar;
class Program
{
    private static object siraNo;

    static void Main(string[] args)
    {
        /* //Bu projede metinsel ilemlere dair bazı metotlar öğreneceğiz
         string metin = "Wissen Akademie";
         int uzunluk = metin.Length;
         //Console.WriteLine($"Uzunluk: {}");
         Console.WriteLine($"{metin} metni {uzunluk} karekterdir");
        */

        /* 
       string metin = "wissen";
       string kucukmetin = metin.tolower();
       console.writeline(kucukmetin);
       string buyukmetin = kucukmetin.tolower();
       console.writeline(buyukmetin);
        */


        /*  string m1 = "Wissen";
         string m2 = "Wissen";
         int sonuc= String.Compare(m1, m2);
         Console.WriteLine(m1);
         Console.WriteLine(m2);
         Console.WriteLine(sonuc);
        */

        /* Console.Write("1.mETNİ GİRİNİZ:");
         string m1 = Console.ReadLine();
         Console.Write("2.mETNİ GİRİNİZ:");
         string m2 = Console.ReadLine();
         int sonuc = string.Compare(m1, m2);
         if (sonuc == 0)
         {
             Console.WriteLine("Girilen iki metin birbirine eittir!");

         }
           else
         {
             Console.WriteLine("Girilen iki metin birbirinden Farklıdır!");
        */

        /*
        string m1 = "İşkur";
        string m2 = "Eğitimeri";
        string m3 = "Wissen";
        //string sonuc = m1 + m2                    //hatalı sonuçu bulamadım.
        string sonuc = String.Concat(m1, m2, m3);
        Console.WriteLine(sonuc);
        */
        /*
                string ad = "Serhat";
                int yas = 26;
                string okul = "BAU";

                */


        //Benim adım serhat. 47 yaşındayım . Okuduğum okulun adı BAU.
        // 1) + OPERATÖRÜ İLE
        // 2-) Concat le
        // 3-) $"" ile

        //ÇÖZÜM-1
        //  string sonuc1 = "Benim adım " + ad + ". " yas + "yaşındayım. Okuduğum okulun adı " + okul;
        // Console.WriteLine(sonuc1);  

        //çözüm 2
        //çözüm 3

        /*
        string metin = "Merhaba. Bu hafta eğitime başladık";
        bool sonuc = metin.Contains("e");  //contains parantez içinde yazdığım metni döndürüyor doğru ise true yanlı ise false yazıyor.
        Console.WriteLine(sonuc);
        */

        string adres = "Selami Ali mh. Can sk. No:5 Kadıköy/İstanbul";
        //  bool sonuc = adres.EndsWith("İstanbul");
        //  Console.WriteLine(sonuc);

        //adres içindeki c harfi kaçıncı sıradadır ?

        /*
        string aranacakifade = "Ş";
        
        int siraNO = adres.T().IndexOf(aranacakifade.ToLower());
        Console.WriteLine($"C harfi {adres} içinde , {siraNo} .sıradadır.");
        */

        //string metin = "Wissen Akademie";
        //Console.WriteLine($"Metnin ilk hali: {metin}");
        //Console.WriteLine($"Akademie ifadesi silindikten sonraki hali: {metin.Remove(7)}");
        //Console.WriteLine($"Aka ifadesi silindikten sonraki hali: {metin.Remove(7, 3)}");

        string urunAd = "Iphone 13 Pro";
        //iphne-13pro
        //string sonuc = (urunAd.Replace(" ", "-").ToLower();
        string sonuc = urunAd.ToLower().Replace(" ", "-");
        Console.WriteLine(sonuc);

        string sonuc2 = urunAd.Replace("Iphone", "Samsung");
        Console.WriteLine(sonuc2);













    }
    
    
}
