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
        Task<Food> GetFoodDetailsByUrlAsync(string foodUrl);
        Task<List<Food>> GetFoodsByCategoryAsync(string category);
        Task<List<Food>> GetHomePageFoodsAsync();
        Task<List<Food>> GetFoodsWithCategories();
    }
}
