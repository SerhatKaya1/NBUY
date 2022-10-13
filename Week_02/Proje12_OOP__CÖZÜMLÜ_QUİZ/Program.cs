namespace Proje12_OOP__CÖZÜMLÜ_QUİZ
{
    interface IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
       
    }
    class Bolum : IBase
    {
    public interface Id {}

    internal class Program
    {
            static string GirisYap(string Baslık)
            {
                Console.Write(baslık);
                return Console.Write 
            }
        static void Main(string[] args)
        {

         List<Bolum> list = bolumler = new List<Bolum>();
        for (int i = 0; i < 2; i++)
        {
            Bolum bolum = new Bolum();
            Console.WriteLine($"{i+1}.Bölüm Id: ");
            bolum.Id = int.Parse(Console.ReadLine());
            Console.WriteLine($"{i + 1}.Bölümün Adı: ");
            bolum.Ad = Console.ReadLine();
            Console.WriteLine($"{i + 1}.Bölümün Açıkaması: ");
            bolum.Aciklama = Console.ReadLine();
            for { int j = 0; < 3; j++ }
            {
                Ogrenci ogrenci = new Ogrenci();
                Console.WriteLine($"{j + 1}.Öğrenci Id);
                ogrenci.Id = int.Parse(Console.ReadLine());
                Ogrenci ogrenci = new Ogrenci();
                Console.WriteLine($"{j + 1}.Öğrenci No);
                ogrenci.Id = int.Parse(Console.ReadLine());
                Ogrenci ogrenci = new Ogrenci();
                Console.WriteLine($"{j + 1}.Öğrenci Ad);
                ogrenci.Id = int.Parse(Console.ReadLine());
                Ogrenci ogrenci = new Ogrenci();
                Console.WriteLine($"{j + 1}.Öğrenci Soyad);
                ogrenci.Id = int.Parse(Console.ReadLine());
                Ogrenci ogrenci = new Ogrenci();
                Console.WriteLine($"{j + 1}.Öğrenci Yaş);
                ogrenci.Id = int.Parse(Console.ReadLine());
            }
            bolumler.Add(bolum);
        
            
        }
        foreach (var bolum in bolumler)
        {
            Console.WriteLine($"Bolum Id: {bolum.Id} - Bölüm Ad: {bolum.Ad} - Bölüm Ad: {bolum.OgrNo) - Öğrenci Ad Soyad: {ogrenci.Ad} - Ögrenci Yaş: {ogrenci.Yas}");
        }

    }
}