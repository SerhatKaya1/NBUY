using Microsoft.AspNetCore.Mvc;
using YemekTarifiApp.Business.Abstract;
using YemekTarifiApp.Web.Areas.Admin.Models.Dtos;

namespace YemekTarifiApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IActionResult> Index()
        {
           var categories = await _categoryService.GetAllAsync();
            var categoryListDto = new CategoryListDto
            {
                Categories= categories
            };
            return View(categoryListDto);
        }
    }
}
