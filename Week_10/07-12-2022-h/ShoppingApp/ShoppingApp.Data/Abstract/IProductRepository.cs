using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface IProductRepository : IRepository<Product>     //product için miras alacak. interface olduğu için implemenet etmemize gerek yok.
    {
        //Product a özgü memberlar burada olacak.(property,metot, field...member)
        //Örneğin aşağıdakiler gibidir.
        List<Product> GetProductsByCategory();
        List<Product> GetHomePageProducts();

    }
}
