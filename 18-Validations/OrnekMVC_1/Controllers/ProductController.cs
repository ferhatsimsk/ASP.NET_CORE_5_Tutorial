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
           
            return View();
        }


        [HttpPost]
        public IActionResult CreateProduct(Product model)
        {
            //ModelState : MVC'de bir type'ın data annotionslarının durumunu kontrol eden ve geriye sonuç dönen bir property.
            if (!ModelState.IsValid)
            {
                //Loglama
                //Kullanıcı bilgilendirme
                
                //ViewBag.HataMesaj = ModelState.Values.FirstOrDefault(x => x.ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid).Errors[0].ErrorMessage;

                var messages = ModelState.ToList();

                return View(model);
            }
            else 
            { 
            

            }


            return View();
        }
      
    }
}
