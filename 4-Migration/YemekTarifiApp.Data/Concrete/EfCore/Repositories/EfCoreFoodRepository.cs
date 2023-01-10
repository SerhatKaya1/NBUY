using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifiApp.Data.Abstract;
using YemekTarifiApp.Data.Concrete.EfCore.Contexts;
using YemekTarifiApp.Entity.Concrate;

namespace YemekTarifiApp.Data.Concrete.EfCore.Repositories
{
    public class EfCoreFoodRepository : EfCoreGenericRepository<Food>, IFoodRepository
    {
        public EfCoreFoodRepository(DbContext context) : base(context)
        {

        }
        private YemekTarifiAppContext YemekTarifiAppContext
        {
            get { return _context as YemekTarifiAppContext; }
        }

        public async Task<List<Food>> GetHomePageFoodsAsync()
        {
           return await YemekTarifiAppContext
                .Foods
                .Where(p => p.IsHome && p.IsApproved) 
                .ToListAsync();
                
        }

        public List<Food> GetFoodsByCategory()
        {
            throw new NotImplementedException();
        }

    }
}
