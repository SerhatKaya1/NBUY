using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Concrete.EfCore.Repositories
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product>, IProductRepository
    {
        public EfCoreProductRepository(DbContext context) : base(context)
        {
        }

        public List<Product> GetHomePageProducts()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategory()
        {
            throw new NotImplementedException();
        }
    }
}
