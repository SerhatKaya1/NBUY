using Microsoft.AspNetCore.Mvc;

namespace YemekTarifiApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
