namespace Proje09_Interface
{
    /* Interface'ler için belirtilmediğinde default erişim belirleyici pubic'dir.
     * Interface'ler procted, private ya da static olarak işaretlenemezler.
     * Interface'ler içinde çaışabilir kodlar olamaz! Yani metotların sadece imzası bulunur.
     * Bir interface, bir ya da daha çok interfaceden miras alabilir.
     * Bir interface classtan miras alamaz.
     * *Eğer bir class, bir interface'den miras alıyorsa, miras aldığı interface'deki tüm metotları implemente etmek zorundadır.(Implemente: miras alınan interfacede imzası bulunan tüm metotar , içi dolu haleri)
     */

     Product 
    interface IPersonel
    {
        public string Departman { get; set; }
    }
    interface IKisi
    {
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public string Maas { get; set; }
        public void Bilgi(); //Interfaceler içindeki metotlarda sadece İMZA bulunur, metodun gövdesi olmaz!
        //Metodun gövdesi, bu interfacei miras alan CLASS içinde doldurulur.
        //Interface new yapılamaz!
    }
    class Yonetici : IKisi, IPersonel
    {
        /// <summary>
        /// Bu metot, herhangi bir Yonetici bilgisi girmeden, Yonetici oluşturur.
        /// </summary>
        public Yonetici()
        {
            //Kimi zaman AdSoyad, Adres, Maas ve Departman bilgisini vermeden de Yonetici oluşturmak istediğimiz zaman bu constructor çalışır.
        }
        /// <summary>
        /// Bu metot, AdSoyad, Adres, Maas ve Departman bilgileri girilerek Yonetici oluşturur.
        /// </summary>
        /// <param name="adSoyad">Buraya Ad Soyadı girin</param>
        /// <param name="adres">Buraya adresi girin</param>
        /// <param name="maas">Buraya maaşı girin, ama yanlışlıkla string tanımlamışım, affedin</param>
        /// <param name="departman">Buraya departmanı girin</param>
        public Yonetici(string adSoyad, string adres, string maas, string departman)
        {
            AdSoyad = adSoyad;
            Adres = adres;
            Maas = maas;
            Departman = departman;
        }

        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public string Maas { get; set; }
        public string Departman { get; set; }

        public void Bilgi()
        {
            Console.WriteLine($"Ad Soyad: {AdSoyad} Departman: {Departman}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir abstract classtan, miras alan classta
             * Eğer base classta abstract methodlar varsa, mutlaka override edilmeli
             * Eğer base classta abstract olmayan methodlar varsa, onlar aynen kullanılabilir
             * Ancak bazen, miras alınan classtaki her metodun, içinin dolu hallerini yazmak zorunlu olsun isteriz.
             * Yani bir nevi hepsi abstract olsun isteriz. Bunu yapmak yerine, miras alınan classı, class değil
             * Interface şeklinde tanımlarız!
             */
            //IPersonel personel = new IPersonel(); //Hatalı kullanım!
            //Yonetici yonetici1 = new Yonetici();
            //Yonetici yonetici2 = new Yonetici("Alex de Souza", "Rio de Jenario", "5000", "Futbol");

            Product product1 = new Product();
            {
                Id = 1;
                Name = "Iphone 13";
                Price = 5900,
                Properties = " gb ram",
                Ratio = 0.5m,
                CreatedDate = DateTime.Now


            };
            Console.WriteLine($"Product Name: {product1.Name} (Büyük harf: {product1.NameUpper(product1.Name)}) Properties 

        }
    }
}