namespace Proje07_TarihMetotları
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine(DateTime.Now);   //Tarih ve saati birlikte alır
            //Console.WriteLine(DateTime.Today);

            //DateTime dogumTarihi = new DateTime(1996, 6, 5);  //16.05.1996
            //DateTime bugun = DateTime.Now;
            //TimeSpan span = bugun.Subtract(dogumTarihi);
            //Console.WriteLine($"Toplam {Math.Ceiling(span.TotalDays)}) gündür yaıyorsunuz! ");

            //DateTime bugun = DateTime.Now;
            //Console.WriteLine(bugun.ToLongDateString()); //5 ekim 2022 çaramba 
            //Console.WriteLine(bugun.ToLongTimeString));   //13:35:30
            //Console.WriteLine(bugun.ToShortDateString));   //5.10.2022
            //Console.WriteLine(bugun.ToShortDateString));   //13:35

            //Bir sonraki yılın ik günün tarihini bulduralım 

            DateTime bugun = DateTime.Now;
            int yil = bugün.Year + 1;
            DateTime sonuc = new  DateTime(yil, 1, 1);

            Console.WriteLine(sonuc.ToLongDateString());

            //Bir sonraki ayın ilk gününün tarihini bulduralım.
            DateTime bugun = DateTime.Now;
            int yil = bugün.Year;
            int ay = bugun.Month + 1;
            DateTime sonuc = new DataTime(yil, ay, 1);
            Console.WriteLine(sonuc);

            DateTime bugun = DateTime.Now
                //Console.WriteLine(bugun + 1);



            ÖDEV 1 : ERTESİ GÜNÜN TARİHİNİ BULUP EKRANA YAZDIRAN PROGRAMI YAZINIZ.



        }
    }
}