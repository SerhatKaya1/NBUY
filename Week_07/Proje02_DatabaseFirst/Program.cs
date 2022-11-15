using Proje02_DatabaseFirst;
using Proje02_DatabaseFirst.efcore;


var mt = new MultiTable();
mt.MusteriSayisi();
mt.SatisYapilanMusteriler();
mt.SatisYapilmayanMusteriler();

// NorthwindContext context = new NorthwindContext();

//Customer listesi alıyor
// List<Customer> customers = context.Customers.ToList();

// foreach (var customer in customers)
// {
//     Console.WriteLine(customer.CompanyName + "-" + customer.ContactName);
// }

//London'da yaşayan Customerların listesi

// List<Customer> customers = context.Customers.Where(c=>c.City=="London").ToList();
// foreach (var customer in customers)
// {
//     Console.WriteLine($"Company Name: {customer.CompanyName} - City: {customer.City} - Phone: {customer.Phone}");
// }
// Console.WriteLine("Bitti...");

//London'da yaşayan Customerların sadece CompanyName ve ContactName'lerini getirelim
// var customers = context
//     .Customers
//     .Select(c=>new {c.CompanyName, c.ContactName, c.City})
//     .Where(c=>c.City=="London")
//     .ToList();

// foreach (var customer in customers)
// {
//     Console.WriteLine($"Company Name: {customer.CompanyName} - City: {customer.City} - Contact Name: {customer.ContactName}");
// }
// Console.WriteLine("Bitti...");

//London'da yaşayan Customerların sadece CompanyName ve ContactName'lerini getirelim
//Nesne kullanarak


// List<CustomerModel> customers = context
//     .Customers
//     .Select(c=>new CustomerModel() {
//         CompanyName=c.CompanyName,
//         ContactName=c.ContactName,
//         City=c.City
//         })
//     .Where(c=>c.City=="London")
//     .ToList();

// foreach (var customer in customers)
// {
//     Console.WriteLine($"Company Name: {customer.CompanyName} - City: {customer.City} - Contact Name: {customer.ContactName}");
// }
// Console.WriteLine("Bitti...");

//Beverages kategorisindeki ürünlerin listsi
// var bevaragesProducts = context
//     .Products
//     .Where(p=>p.Category.CategoryName=="Beverages")
//     .ToList();

// foreach (var p in bevaragesProducts)
// {
//     Console.WriteLine(p.ProductName);
// }

//Suppliers tablosundaki Germany'de yaşayanları listeleyin
// var suppliersInGermany = context
//     .Suppliers
//     .Where(s=>s.Country=="Germany")
//     .ToList();
// foreach (var s in suppliersInGermany)
// {
//     Console.WriteLine(s.CompanyName);
// }
//Nancy adlı çalışının yaptığı satışlar
// var ordersOfNancy = context
//     .Orders
//     .Where(o=>o.Employee.FirstName=="Nancy" && o.ShipCountry=="Brazil")
//     .ToList();

// foreach (var o in ordersOfNancy)
// {
//     Console.WriteLine(o.OrderId);
// }
// Console.WriteLine($"Toplam satış sayısı: {ordersOfNancy.Count()}");

//Productları ID'ye göre büyükten küçüğe doğru listeleyelim.
// var products = context
// .Products
// .OrderByDescending(p=>p.ProductId)   /*sırala demek (order by). her product ın ıd sine bakacak. Bu tablonun her satırındaki id ye bak
// p=>p.ProductId  her product için p ye bak demek. ıd si büyük olan en son kayıt olmuştur.
// */
// .ToList();

// foreach (var p in products)
// {
//     Console.WriteLine($"{p.ProductId} / {p.ProductName}");
// }


//En son satılan 5 ürünü getirelim

// var products = context
// .Products
// .OrderByDescending(p=>p.ProductId)
// .Take(5)  /*5 tane ürünü al demek sırayı çevirdikten sonra ilk 6*/
// .ToList();

// foreach (var p in products)
// {
//     Console.WriteLine($"{p.ProductId} / {p.ProductName}");
// }

//Fiyarı 10 ile 20 arasında olan ürünlerin adını ve fiyatını getirip listeleyelim, Fiyata göre küçükten büyüğe sıralayınız.

// var products = context
// .Products
// .OrderBy(p=>p.UnitPrice)
// .Where(p=>p.UnitPrice>=10 && p.UnitPrice<=20)
// .Select(p=> new {
//     p.ProductName,
//     p.UnitPrice
// })
// .ToList();

/*order by her satırda kullanılabilir.*/

// foreach (var p in products)
// {
//     Console.WriteLine($"{p.ProductName} --> {p.UnitPrice}");
// }

/*sintx lar farklı olduğu için esnek yazım formatlarına sahiptir.ToList e çevirmeden önce kullanırız genelde.Veririmlilik artar.
To list execute görevi görür . To list den sonra yapılması sorunlar meydana getirebilir.*/

//Baverages kategorisindeki ürünlerin ortalama fiyatını yazdıralım.

// var ortalama = context
// .Products
// .Where(p=>p.Category.CategoryName=="Baverages")
// .Average(p=>p.UnitPrice);

// Console.WriteLine($"Baverages Fiyat Ortalaması: {ortalama}");

//Beverages kategorisindek ürün adedi

// var adet = context
// .Products
// .Where(p=>p.Category.CategoryName=="Baverages")
// .Count();
// .Count(p=>p.Category.CategoryName=="Baverages");
// Console.WriteLine($"Baverages Ürün Adeti: {adet}");

//Baverages ve Condiment kategorilerinde kaç adet ürün vardır.

// var adet= context  
// .Products
// .Count(p=>p.Category.CategoryName=="Baverages" || p.Category.CategoryName== Condiment);

// Console.WriteLine($"Baverages Ürün Adeti: {adet}");


//adının içinde tofu geçen ürünleri listeleyelim
// var products = context
// .Products
// .Where(p=>p.ProductName.Contains("tofu"))
// .ToList(); 
// foreach (var p in products)
// {
//     Console.WriteLine($"{p.ProductName}");
// }


//en ucuz ve en pahalı ürünler hangileridir?
// var minPrice = context.Products.Min(p=>p.UnitPrice);
// var maxPrice = context.Products.Max(p=>p.UnitPrice);

// var minProduct = context
// .Products
// .Where(p=>p.UnitPrice==minPrice)
// .Select(p=>new{
//      p.ProductName,
//      p.UnitPrice
//  }).FirstOrDefault();

// Console.WriteLine($"minPrice {minPrice} --> Product: {minProduct.ProductName}-{minProduct.UnitPrice}");


// var maxProduct = context
// .Products
// .Where(alex=>alex.UnitPrice==minPrice)
// .Select(hoijdoonk => new{
//      hoijdoonk.ProductName,
//      hoijdoonk.UnitPrice,
     
//  }).FirstOrDefault();

// Console.WriteLine($"MinPrice {minPrice} --> Product: {minProduct.ProductName}-{minProduct.UnitPrice}");
// Console.WriteLine($"MaxPrice {minPrice} --> Product: {minProduct.ProductName}-{minProduct.UnitPrice}");


// class CustomerModel
// {
//     public string? CompanyName { get; set; }
//     public string? ContactName { get; set; }
//     public string? City { get; set; }
// }


// var minProducts = context
// .Products
// .Where(p=>p.UnitPrice==minPrice)
// .Select(p=>new{
//      p.ProductNamae
//  }).ToList();
// Console.WriteLine($"{minPrice} fiyatlı ürünlerin listesi");
// foreach (var p in minProducts)
// {
//     Console.WriteLine(p.ProductName);
// }


// var maxProducts = context
// .Products
// .Where(p=>p.UnitPrice==maxPrice)
// .Select(p=>new{
//      p.ProductNamae
//  }).ToList();
// Console.WriteLine($"{maxPrice} fiyatlı ürünlerin listesi");
// foreach (var p in minProducts)
// {
//     Console.WriteLine(p.ProductName);
// }
/*
NOTLAR : 
listeleri tanımlarken forech yapısını kullanıyoruz.
*/
