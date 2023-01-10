using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifiApp.Entity.Concrate;

namespace YemekTarifiApp.Business.Abstract
{
    public interface IFoodService
    {
        Task<Food> GetByIdAsync(int id);
        Task<List<Food>> GetAllAsync();
        Task CreateAsync(Food product);
        void Update(Food product);
        void Delete(Food product);
        List<Food> GetFoodsByCategory();
        Task<List<Food>> GetHomePageFoodsAsync();
    }
}
