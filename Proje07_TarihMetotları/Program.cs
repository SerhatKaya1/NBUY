namespace Proje07_TarihMetotları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);   //Tarih ve saati birlikte alır
            Console.WriteLine(DateTime.Today);

            DateTime dogumTarihi = new DateTime(1996, 6, 5);  //16.05.1996
            DateTime bugun = DateTime.Now;
            TimeSpan = bugun.Subtract(dogumTarihi);
            Console.WriteLine(Span);

        }
    }
}