using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Business.Abstract
{
    public interface IProductService
    {
        Task<Product> GetByIdAsync(int id);
        Task<List<Product>> GetByNameAsync();
        Task CreateAsync(Product product);
        void Update(Product product);
        void Delete(Product category);
        List<Product> GetProductByCategory();
        List<Product> GetHomeByCategory();

    }
}
}
