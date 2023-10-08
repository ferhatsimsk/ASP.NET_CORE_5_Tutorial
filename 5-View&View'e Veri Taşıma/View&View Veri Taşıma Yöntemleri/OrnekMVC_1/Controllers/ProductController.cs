using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OrnekMVC_1.Models;
using System.Collections.Generic;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace OrnekMVC_1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product{ Id = 1, ProductName="A Product", Quantity= 10},
                new Product{ Id = 2, ProductName="B Product", Quantity= 15},
                new Product{ Id = 3, ProductName="C Product", Quantity= 20},
            };
            #region Model Bazlı Veri Gönderimi
            //Bir veriyi View'e model bazlı göndereceksek View fonksiyonunu kullanmamız yeterli gelecektir.return View();
            //return View(products);

            #endregion
            #region Veri Taşıma Kontrolleri
            #region ViewBag
            //View' gönderilecek/taşınacak datayı dynamic şekilde tanımlanan bir değişkenle taşımamızı sağlayan bir veri taşıma kontrolüdür.

            //ViewBag.Products = products;

            #endregion
            #region ViewData
            //ViewBag de olduğu action daki datayı view'e taşımamızı sağlayan bir kontroldür.
            //ViewBag den farkı boxing ederek taşır.
            //ViewData["products"] = products;

            #endregion
            #region TempData
            //ViewData'da  olduğu action daki datayı view'e taşımamızı sağlayan bir kontroldür.

            
            var data = JsonSerializer.Serialize(products);

            TempData["products"] = data;

            //TempData["x"] = 5;
            //ViewBag.x = 5;
            //ViewData["x"] = 5;

            


            #endregion
            #endregion


            //Index2 isimli controllera yönlendirme yapar.(RedirectToAction("Index2"))
            return RedirectToAction("Index2","Product");
        }
        public IActionResult Index2()
        {
            //var v1 = ViewBag.x;
            //var v2 = ViewData["x"];
            //var v3 = TempData["x"];

            var data = TempData["products"].ToString();
            JsonSerializer.Deserialize<List<Product>>(data);

            return View();
        }
    }
}
