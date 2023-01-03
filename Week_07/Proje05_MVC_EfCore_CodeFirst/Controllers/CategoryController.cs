using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proje05_MVC_EfCore_CodeFirst.Models;

namespace Proje05_MVC_EfCore_CodeFirst.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            MyDbContext context = new MyDbContext(); //MyDbContext benim modelimi tutuyor. Modelde ise tablolar var . Tablolara ulaşmak için context nesnesine ihtiyacım var.
                                                     //Ben context ile Categories tablomu çağırıp bunu return ediyorum.
            List<Category> categories = context.Categories.ToList(); 
            return View(categories);
        }
    }
}