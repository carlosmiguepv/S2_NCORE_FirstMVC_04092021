using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using S2_NCORE_FirstMVC.Web.Areas.Marketing.Models;

namespace S2_NCORE_FirstMVC.Web.Areas.Marketing.Controllers
{
    [Area("Marketing")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ProductsViewModel()
        {
            var products = GetProductsJsonLocal();
            return View(products);
        }


        public IEnumerable<Product> GetProductsJsonLocal()
        {
            var folder = Path.Combine(Directory.GetCurrentDirectory(), "Areas\\Marketing\\Data\\products.json");
            var json = System.IO.File.ReadAllText(folder);

            var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(json);
            return products;
        }
    }
}
