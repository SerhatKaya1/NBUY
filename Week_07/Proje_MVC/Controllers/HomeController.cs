using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
namespace Proje_MVC.Controllers;
public class HomeController : Controller
{
    

    public IActionResult Index() 
    {
        return View();  /*adı index olan bir wiev dosyası çağırılıyor*/
    }

    public IActionResult Privacy()   
    {
        return View();
    }
    public IActionResult About()
    {
        return View();
    }
    public  IActionResult Contack()
    {
        return View();
    }
   
}
