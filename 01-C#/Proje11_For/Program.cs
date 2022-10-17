namespace Proje11_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 0; i < 5; i++)
            //{ 
            //  Console.WriteLine($"{i+1}.Hello, World!");
            //}
            // }

            //Alt alta 11 kere 1 yazan program 
            //int toplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    // topam = toplam + i;
            //    toplam = toplam + 1;
            //}
            //Console.WriteLine($"Topam: {toplam}");


            //1-10 Arasındaki çift sayıların toplamını buldurun.
            //int toplam = 0;
            //for (int i = 0; i <=10;  i=i+2)  //i++= i değerini 1 arttır
            //    if (toplam == 0) ;
            //{
            //    toplam += i;     
            //}
            //Console.WriteLine(toplam);

            //int toplam = 0;
            //for (int i = 0; i <=10;  i++)
            //{                            //i++= i değerini 1 arttır
            //    if (i % 2 == 0) toplam += i;
            //{
            //        Console.WriteLine(toplam);
            //    }

            //int ciftToplam = 0;
            //int tekToplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0) toplam += i;
            //    {
            //        tekToplam += i;
            //    }
            //    else
            //    {
            //        ciftToplam += i;

            //    }

            //SORU: KAVYEDEN 2 SAYI GİRİLSİN BU SAYILARIN TOPLAMNI EKRANA YAZDIRALIM

            //Console.Write("1.Sayıyı Giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2.Sayıyı Giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //for (int i = sayi1; i <= sayi2; i++) 
            //{
            //    toplam += i;
            //}
            //Console.WriteLine($"Topam: {toplam}");

            //Console.Write("1.Sayıyı Giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2.Sayıyı Giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //if (sayi2 > sayi1)
            //    for (int i = sayi1; i <= sayi2; i++)
            //    {
            //        toplam += i;
            //    }



            //Console.WriteLine($"Topam: {toplam}");

            // Console.Write("1.Sayıyı Giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2.Sayıyı Giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //int min = Math.Min(sayi1, sayi2);
            //int min = Math.Max(sayi1, sayi2);
            //for (int i = min; i <= max; i++) 
            //{
            //    toplam += i;
            //}
            //Console.WriteLine($"Topam: {toplam}");



            //program kulanıcıdan bir sayı girmesini istesin. Ancak kullanıcı sayı girmeye devam ettikçe girien sayıların toplanmasını sağlayaım.Sayı adedi Belirsizdir! Uyguamanın bitip , ekrana topamı yazdırabilmesi için kuanıcının sayı yerine exit yazmasını kontro edeceğiz .

            //int toplam = 0;
            //string girilenDeger = "";
            //string sonucMetin = "";
            //for (int i = 1; i < 100000; i++)

            //{
            //    Console.WriteLine("Toplamak istediğimz sıradaki sayıyı giriniz(çıkış için exit)[Geçerli Toplam] ");
            //    girilenDeger = Console.ReadLine();
            //    if (girilenDeger == "exit") //if  küçük büyük harf duyarlıdır!

            //    {
            //        break;     // İçinde bulununan döngünün , tamamanmasını beklemeden istenilen bir anda              durduruması için kullanılır.
            //    }

            //    sonucMetin = sonucMetin + girilenDeger + " + "; // burada"+" olsaydı -3 yazmayız .azalır.
            //    toplam  += Convert.ToInt32(girilenDeger);


            //}
            //int alinacakKısmınuzunlugu = sonucMetin.Length - 3;
            //       sonucMetin = sonucMetin.Substring(0, alinacakKısmınuzunlugu);
            //Console.WriteLine($"{sonucMetin} = {toplam}");   

            //SORU : 5*5'LİK BİR KARE BİÇİMİ * İŞARETERİYE OLUŞAN UYGUAMAYI YAZINIZ .

            //int satir = 5;
            //int sutun = 5;
            //for (int i = 0; i < satir; i++)
            //{

            //    //A
            //    for (int j = 0; j < sutun; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();


            //NEW SORU : İçi bo oan 5*5lik kare uygulamasını yapalım .
            int satir = 5;
            int sutun = 5;
            for (int i = 0; i < satir; i++)
            {

                //A
                for (int j = 1; j <= sutun; j++)
                {
                   if (i == )


                    Console.Write("*");
                }
                Console.WriteLine();







            }
    }
        }
}
