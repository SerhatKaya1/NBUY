using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Entity.Concrete;

namespace ShoppingApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        private object _productService;

        public async IActionResult Index()
        {
            var products = await _productService.GetAllProduct();

            var productListDto = products
                .Select(pc => new Category
                {
                    .Select(pc => pc.Category)

                })


            return View();
        }
    }
}
