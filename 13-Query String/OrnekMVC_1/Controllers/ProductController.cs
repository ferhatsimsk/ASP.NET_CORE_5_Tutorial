using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OrnekMVC_1.Models;
using OrnekMVC_1.Models.ViewModels;
using System.Collections.Generic;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;


namespace OrnekMVC_1.Controllers
{
    //3.Yöntem(Query Strinle ilgili)
    public class QueryData
    {
        public int A { get; set; }
        public string B { get; set; }
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

        //Query string değerini buraya url de ?a=5 diyerek verebiliyoruz. Eğer iki tane olacaksa bu seferde string b deyip ikinci parametreyi vermemiz gerekir.
        //1.Yöntem
        //public IActionResult VeriAl(string a)
        public IActionResult VeriAl(QueryData data)
        {
            //2.Yöntem
            //var quryString = Request.QueryString; //Request yapılan endpoint'e query string parametresi eklemiş mi eklememiş mi bununla ilgili bilgi verir.
            //var a = Request.Query["a"].ToString();
            //var b = Request.Query["b"].ToString();
            return View();
        }
    }
}
