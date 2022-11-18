using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proje06_ModelBinding_Form.Models;

namespace Proje06_ModelBinding_Form.Controllers;

public class HomeController : Controller
{


    public IActionResult Index()
    {
        return View();
    }

    public IActionResult YasGrubu()
    {
        return View();
    }
    public IActionResult ad()
    {
        return View();
    }
    [HttpPost]
    public IActionResult YasGrubu(int yas, string ad)
    {
        return View();
    }
    if (yas<18)
    {
        ViewBag.YasGrubu="Reşit değilsiniz!";
    }else if (yas<40)
    {
        ViewBag.YasGrubu="Gençsiniz!";
    }else
    {
        //Burada veritabanı kayıtişlemi vb. yapılacak.
         ViewBag.YasGrubu="Gençlere Taş Çıkartırsınız!";
    }

    //  public IActionResult VerileriAl(string txtAd, int txtYas)
    // {
    //     return View();
    // }
    
}
/*ctrl p + gene yazıp oradan ilkini seç ve cs.code klasörünü oluştur.*/
/**/