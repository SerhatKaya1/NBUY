using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
namespace Proj04_mvc.Controllers;

public class HomeController : Controller
{
    
    public IActionResult Index()
    {
        string ad = "Serhat";
        ViewBag.KisiAd=ad;
        string dil="Tr";
        string selamlama;
        if (dil=="Tr")
        {
            selamlama = "Hoş Geldiniz";
        }
        else
        {
            selamlama="";
        }
        ViewBag.Selam=selamlama;
        return View();
    }

}
