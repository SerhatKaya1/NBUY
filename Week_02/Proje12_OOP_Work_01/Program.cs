namespace Proje12_OOP_Work_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "id giriniz: ");
            int id = int.Parse( Console.ReadLine() );
            Console.WriteLine("Ad Giriniz");
        }
            List<Ogrenci> ogrencis = new List<Ogrenci>()
            { 
                new Bolum()
                {
                    Id = 15,
                    Ad = "Kaya",
                    Ogrenci=  new List<Ogrenci>() { new Ogrenci() { Ad = "Serhat", Id = 200, OgrNo: 201, Soyad = "Kaya", Yas = 26 } }
                }
                

            };

        public List<Ogrenci> Ogrencis { get => ogrencis; set => ogrencis = value; }
    }  
            
    
         



}