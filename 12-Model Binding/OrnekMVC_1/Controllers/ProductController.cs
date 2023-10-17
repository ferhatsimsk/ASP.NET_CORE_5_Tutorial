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
        public IActionResult GetProducts()
        {
            return View();
        }
        public IActionResult CreateProduct() 
        {
            var product=new Product()
            { 
                ProductName="B Product",
                Quantity=25
            };  
            return View(product);
        }

        [HttpPost]
        //public IActionResult CreateProduct(string txtProductName, string txtQuantity)
        public IActionResult CreateProduct(Product product)
        {
            return View();
        }
    }
}
