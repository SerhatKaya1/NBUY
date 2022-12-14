using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifiApp.Data.Abstract;
using YemekTarifiApp.Data.Concrete.EfCore.Contexts;
using YemekTarifiApp.Data.Migrations;
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
        public Task<Food> GetFoodDetailsByUrlAsync(string foodUrl)
        {
            return YemekTarifiAppContext
                .Foods
                .Where(p => p.Url == foodUrl)
                .Include(p => p.FoodCategories)
                .ThenInclude(pc => pc.Category)
                .Include(p => p.FoodRecipes)
                .ThenInclude(fr => fr.Recipe)
                .FirstOrDefaultAsync();
                
        }

        public async Task<List<Food>> GetFoodsByCategoryAsync(string category)
        {
            var foods = YemekTarifiAppContext.Foods.AsQueryable();
            if (category != null)
            {
                foods = foods
                    .Where(p => p.IsApproved)
                    .Include(p => p.FoodCategories)
                    .ThenInclude(pc => pc.Category)
                    .Where(p => p.FoodCategories.Any(pc => pc.Category.Url == category));
            }
            return await foods.ToListAsync();
        }

        public List<Food> GetFoodsByCategory()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Food>> GetFoodsWithCategories()
        {
            return await YemekTarifiAppContext
                .Foods
                .Include(f => f.FoodCategories)
                .ThenInclude(fc => fc.Category)
                .ToListAsync();
        }

        public async Task CreateFoodAsync(Food food, int[] selectedCategoryIds)
        {
            await YemekTarifiAppContext.Foods.AddAsync(food);
            await YemekTarifiAppContext.SaveChangesAsync();
            food.FoodCategories = selectedCategoryIds
                .Select(catId => new FoodCategory
                {
                    FoodId = food.Id,
                    CategoryId = catId
                }).ToList();
            await YemekTarifiAppContext.SaveChangesAsync();
        }

        public async Task<Food> GetFoodWithCategories(int id)
        {
            return await YemekTarifiAppContext
               .Foods
               .Where(f => false.Id == id)
               .Include(p => p.FoodCategories)
               .ThenInclude(pc => pc.Category)
               .FirstOrDefaultAsync();
        }

        public async Task UpdateFoodAsync(Food food, int[] selectedCategoryIds)
        {
            Food newFood = await YemekTarifiAppContext
                .Foods
                .Include(p => p.FoodCategories)
                .FirstOrDefaultAsync(p => p.Id == food.Id);
            newFood.FoodCategories = selectedCategoryIds
                .Select(catId => new FoodCategory
                {
                    FoodId = newFood.Id,
                    CategoryId = catId
                }).ToList();
            YemekTarifiAppContext.Update(newFood);
            await YemekTarifiAppContext.SaveChangesAsync();

        }
    }
}
