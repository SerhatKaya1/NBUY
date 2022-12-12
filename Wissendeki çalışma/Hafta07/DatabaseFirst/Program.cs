using Proje01_DatabaseFirst.efcore;

namespace Proje01_DatabaseFirst;
class Program
{
    static void Main(string[] args)
    {
        NorthwindContext context = new NorthwindContext();
        List<Customer> customers = context.Customers.ToList(); //veritabanı içindeki Customersleri listele demektir.
        foreach (var c in customers) //listelenen customersleri forech döngüsü içine al diyoruz.
        {
            Console.WriteLine(c.CompanyName);
        }
    }
}
//context veritabanı ilişkilerini yönetir. 
//
