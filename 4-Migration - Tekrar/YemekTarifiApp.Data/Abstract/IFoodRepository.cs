using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifiApp.Entity.Concrate;

namespace YemekTarifiApp.Data.Abstract
{
    public interface IFoodRepository : IRepository<Food>
    {
        List<Food> GetFoodsByCategory();
        Task<List<Food>> GetHomePageFoodsAsync();
    }
}
