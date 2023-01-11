using Microsoft.AspNetCore.Mvc;
using YemekTarifiApp.Business.Abstract;
using YemekTarifiApp.Web.Areas.Admin.Models.Dtos;

namespace YemekTarifiApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FoodController : Controller
    {
        private readonly IFoodService _foodService;
        private readonly ICategoryService _categoryService;

        public FoodController(IFoodService foodService, ICategoryService categoryService)
        {
            _foodService = foodService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var foods = await _foodService.GetFoodsWithCategories();
            var foodListDto = foods
                .Select(p => new FoodListDto
                {
                    Food = p
                }).ToList();

            return View(foodListDto);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categories = await _categoryService.GetAllAsync();
            var foodAddDto = new FoodAddDto
            {
                Categories = categories
            };
            return View(foodAddDto);
        }

    }
}
