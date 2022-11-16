using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
namespace Proj04_mvc.Controllers;
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

}

public class Category{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class HomeController : Controller
{
    public IActionResult Index()
    {
        string ad = "Serhat";
        ViewBag.KisiAd = ad;
        string dil = "Tr";
        string selamlama;
        if (dil == "Tr")
        {
            selamlama = "Hoş Geldiniz";
        }
        else
        {
            selamlama = "";
        }
        ViewBag.Selam = selamlama;
        return View();
    }


    public IActionResult GetProducts()
    {
        List<Product> products = new List<Product>(){
        new Product() {Id=1, Name="Iphone 13", Price=24000},
        new Product() {Id=2, Name="Iphone 14", Price=34000},
        new Product() {Id=3, Name="Iphone 15", Price=44000},
        new Product() {Id=4, Name="Iphone 16", Price=54000},
        new Product() {Id=5, Name="Iphone 17", Price=64000}
        };

        // ViewBag.Hata = false;
        // ViewData["Not"]=75;

        //    List<string> adlar =new List<string>(){"Sema","Harun","Sefa","Tuğçe"};
        // ViewData["Adlar"]= adlar;

        // List<string> bolumler = new List<string>(){"İnsan Kaynakları","Müdürler","Maliye"}

        return View();
    }
    /* Controllerden wiev'e bilgi göndermeye yarar. */

    public IActionResult GetCategories()
    {
        List<Category> categories = new List<Category>() {

        new Category() {Id=1, Name="Telefon"},
        new Category() {Id=2, Name="Bilgisayar"},
        new Category() {Id=3, Name="Elektronik"}
        };

        return View(categories);
    }



}
