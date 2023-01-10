using GetCountriesFromApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace GetCountriesFromApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public async Task<IActionResult> Index()
        {
            List<Country> countryList = new List<Country>();
            using (var httpClient = new HttpClient())
            {
                using (var responce = await httpClient.GetAsync("https://restcountries.com/v2/all"))
                {
                   var stringResponse = await responce.Content.ReadAsStringAsync();
                   countryList = JsonSerializer.Deserialize<List<Country>>(stringResponse);
                    foreach (var cl in countryList)
                    {
                        return View(cl);
                    }
                }
            }
            return View();
        }        
    }
}