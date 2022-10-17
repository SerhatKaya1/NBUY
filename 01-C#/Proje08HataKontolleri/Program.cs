namespace Proje08HataKontolleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Buraya normade çalımasını istediğimiz odları yazıyoruz.
                //Try boğu herhangi bir hata varmı yokmu kontrol ediliyor .herhangi bir hata oluursa catch bloğuna ynlendiriyor
                Console.Write("1.Sayiyi giriniz");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.Sayiyi giriniz: ");
                int sayi2 = Convert.ToByte(Console.ReadLine());
                int sonuc = sayi1 / sayi2;
                Console.WriteLine(sonuc);


            }
            catch (DivideByZeroException ex);
            {
                Console.WriteLine("0'a bölünme hatası var!");
               // Console.WriteLine("ex.Message");
            }

                  catch (OverflowException ex)

            {
                Console.WriteLine("Haddinden faza büyük bir sayı giriniz!");
            }
                 catch (Exception ex)
            {
                Console.WriteLine("Bilinmeyen bir hata oluştu!");
            }
               

        }

    }
}
