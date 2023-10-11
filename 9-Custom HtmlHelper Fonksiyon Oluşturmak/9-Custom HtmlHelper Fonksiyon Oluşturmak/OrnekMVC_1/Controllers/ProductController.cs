using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OrnekMVC_1.Models;
using OrnekMVC_1.Models.ViewModels;
using System.Collections.Generic;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;


namespace OrnekMVC_1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult GetProducts()
        {
            Product product = new Product
            {
                Id = 1,
                ProductName = "A Product",
                Quantity = 15,

            };

            User user = new User()
            {
                Id = 1,
                Name = "Gençay",
                LastName = "Yıldız",

            };

            //UserProduct userProduct = new UserProduct
            //{
            //    User = user,
            //    Product = product,
            //};

            var userProduct = (product, user);

            //return View(userProduct);
            return View(userProduct);
        }
    }
}
