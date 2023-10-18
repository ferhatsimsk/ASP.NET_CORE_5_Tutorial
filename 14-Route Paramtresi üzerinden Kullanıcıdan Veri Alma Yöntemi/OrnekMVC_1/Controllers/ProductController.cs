using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OrnekMVC_1.Models;
using OrnekMVC_1.Models.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;


namespace OrnekMVC_1.Controllers
{

    //2.Yöntemin 
    public class RouteData
    {
        public int A { get; set; }
        public string B { get; set; }
        public string Id { get; set; }

    }
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            return View();
        }
        public IActionResult CreateProduct()
        {

            return View();
        }

        //1.Yöntem
        //public IActionResult VeriAl(string id, string a, string b)

        //2.Yöntem
        public IActionResult VeriAl(RouteData data)
        {
            var values = Request.RouteValues;
            return View();
        }
    }
}
