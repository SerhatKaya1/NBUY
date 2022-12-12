using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Entity.Concrete;
using ShoppingApp.Web.Models.Dtos;
//Entity burada table ile çalışırken sql de sadece dizayn ettiğimizi düşünürüz burada da öyle düşün.
namespace ShoppingApp.Web.Controllers;

public class HomeController : Controller
{
    private readonly IProductService _productManager;

    public HomeController(IProductService productManager)
    {
        _productManager = productManager; 
    }

    public async Task<IActionResult>Index()
    {
       List <Product> products = await _productManager.GetAllAsync();
        List<ProductsDto> productsDto = new List<ProductsDto>(); // içinde hiçbirşey olmayan bir liste yarattık.
        foreach (var product in products)
        {
            new ProductsDto
            {
               products.Add(new ProductsDto
               {
                    Id = product.Id,
                Name = product.Name,
                Price=product.Price,
                DateAdded= product.DateAdded,
               });

            }
        }
        return View(products); 
    }
}
