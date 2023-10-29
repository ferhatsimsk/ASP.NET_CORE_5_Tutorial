using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OrnekMVC_1.Models;
using OrnekMVC_1.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;


namespace OrnekMVC_1.Controllers
{

    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            return View();
        }

        public IActionResult CreateProduct()
        {
            var tuple = (new Product(), new User());
            return View(tuple);
        }


        [HttpPost]
        public IActionResult CreateProduct([Bind(Prefix ="Item1")]Product product, [Bind(Prefix = "Item2")] User user)
        {

            return View();
        }
      
    }
}
