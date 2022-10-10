namespace Proje01_Class_Field_property_Uygulama
{
    class Product
    {
        public string  Name { get; set; }
        public decimal Price { get; set; }
        public string  Description { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir product classımız olacak. Name, Price , Description
            //İstenildiği kadar product bilgisinin girilmesini sağlayacağız.
            //Ka adet Product bilgisi girileceğini kullanıcı belirsin.
            //Product ekeme işi bitince , eklenmi Productar listelensin.

            //Console.Write("Kaç adet ürün gireceksiniz?: ");
            //int adet = int.Parse(Console.ReadLine());
            //Product[] products = new Product[adet];
            //Product product;
            //for (int i = 0; i < adet; i++)
            //{
            //    product = new Product();

            //    Console.Write("Product Name");
            //    product.Name = Console.ReadLine();

            //    Console.Write("Price: ");
            //    product.Price = decimal.Parse(Console.ReadLine());

            //    Console.Write("Description: ");
            //    product.Description= Console.ReadLine();

            //    products[i] = product;

            //}
            //Console.WriteLine("Prodact Name\tPrice\tDescription ");
            //foreach (var prd in products)
            //{
            //    Console.WriteLine($"{prd.Name} \t{prd.Price}\t{prd.Description}");
            //}

            #region RastgeleDegerUreterek

            Product[] products = new Product[5];
            Product product;
            string[] nameArray = { "Gaaxy A50", "HP Notebook", "MacBook Air M2", "Iphone 14 Plus", "LG 27 inç Monitor" };
            string[] descArray = { "İyidir", "Şaşırtıcıdır", "Heyecan vericidir", "Souğunuzu keser", "Tırttır" };
            decimal[] oldPrices = new decimal[5];
            
            Random rondom = new Product();
            Console.WriteLine("Yapılacak zam oranını giriniz: ");
            decimal oran = decimal.Parse(Console.ReadLine());          
            for  (int i = 0; i < 5; i++)
            {
                product = new Product();
                {
                    Name = nameArray[Random.Next(0, 5)];
                    Description = descArray[Random.Next(0, 5)];
                    Price = Random.Next(100, 1001)
                };
                oldPrices[i] = product.Price;
                product.Price *= (1 + (oran / 100));
                products[i] = product;
                
            }

            //product.Name = nameArray[Random.Next(0, 5)];
            //product.Description = nameArray[Random.Next(0, 5)];
            //product.Price = Random.Next(100, 1001);

            products[i] = product; 
        
             Console.WriteLine("Product Name".PadRight(30) + "Price".PadRight(10) + "Description");
            forech (var prd in products)
        
            Console.WriteLine($"{prd.Name.Padright(30)}{};
        
            #endregion


        }
    }
}