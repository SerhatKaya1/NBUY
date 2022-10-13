namespace Proje11_Collections_GeneralList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            ////List<int> sayilar = new List<int>();    // General yapıda <> olduğu anlamına gelir.
            //// sayilar.Add(12);
            //// sayilar.Add(120);
            //// sayilar.Add(69);
            //// sayilar.Add(28);
            //// sayilar.Add(316);
            //// List<string> isimler = new List<string>();
            //// isimler.Add("Ali");
            //// isimler.Add("Begüm");
            //// isimler.Add("Kemal");

            //// foreach (var sayi in sayilar)

            //// {
            ////     Console.WriteLine(sayi);
            //// }
            //// foreach (var isim in isimler)
            //// {
            ////     Console.WriteLine(isim);
            //// }
            //// sayilar.Add

            ////Product product1 = new Product() { Id = 1, Name = "Bilgisayar", Price = 28000 };
            ////Product product1 = new Product() { Id = 1, Name = "Telefon", Price = 28000 };
            ////Product product1 = new Product() { Id = 1, Name = "Masa", Price = 28000 };


            ////List<Product> prdoducts = new List<Product>;
            ////products.Add(prdoduct1)
            ////products.Add(prdoduct2)
            ////products.Add(prdoduct3)

            ////Console.ReadLine();



            //List<Product> products = new List<Product>()
            //{
            //    new Product() {Id=1, name ="Telefon", Price=19000},
            //    new Product() {Id=2, name ="Bilgisayar", Price=39000},
            //    new Product() {Id=3, name ="Sandalye", Price=9000}
            //};

            ////Yeni bir liste yaratın . Adı da newProducts osun . İçine tıpkı yukaridaki gibi 3 yeni ürün bilgisi girin.

            ////newProducts içindeki productları, products içine ekleyeceğiz

            //products.AddRange(newProducts);
            //products.ForEach(p => {
            //    Console.WriteLine($"{p.Name} - {p.Price}");
            //});

            //int elemanSayisi = products.Count();

            //products.Insert(0, new Product() { Id = 21, Name = "Gözlük", Price = 1200 });

            //products.InsertRange(3, newProducts);
            //foreach (var prdouct in newProducts)
            //{
            //    Console.WriteLine($");

            //}
            ////foreach (var product in products)
            ////{
            ////    Console.WriteLine($"{product.name} - {product.Price}");
            ////}





            //List<Product> newProducts = new List<Product>()
            //{
            //    new Product() {Id=4, Name="Mause", Price=175},
            //    new Product() {Id=5, Name="Mause", Price=1750},
            //    new Product() {Id=6, Name="Buzdolabı", Price=17500},
            //};
            //ProductModel productModel = new ProductModel();
            //{
            //    Id = 1;
            //    CategoryName="First Category",
            //    Prodcts=products
            //};
            //Console.WriteLine(productModel.CategoryName);
            //foreach (var product in productModel.Products)
            //{
            //    Console.WriteLine($"\t{product.Name});
            //}
            //Console.WriteLine();


            //İçinde 3 adet ProductMode tipinde veri barındıran bir List ouşturun.
            //Her bir productModel içinde ise. Products özelliğinde 3'er adet Product koyun.
            #endregion
            

            List<ProductModel> productModels = new List<ProductModel>()
            {
            new ProductModel() {Id=1,CategoryName="Bigisayarlar",      Products= new List<Product>()
            {
                new Product() {Id=21,Name="Ürün31",Price=35000},
                new Product() {Id=22,Name="Ürün32",Price=35000},
                new Product() {Id=23,Name="Ürün33",Price=35000},
            }

            Console.WriteLine($"Id: {ProductModel.Id} - Category Name: {productModel.CategoryName}");
            foreach (var productModel in productModels)
            {
                Console.WriteLine($"\tProduct Id: {Product.Id} - Category Name: {productModel.CategoryName}");
                foreach (var product in productModel)
                {

                }
            }


            }          
            Console.ReadLine();
        }
    }
}