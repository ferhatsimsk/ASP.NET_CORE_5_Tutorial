using Microsoft.AspNetCore.Mvc;
using OrnekMVC_1.Models;

namespace OrnekMVC_1.Controllers
{

    
    public class ProductController : Controller
    {

        //public ViewResult GetProducts()
        //{
        //    ViewResult result= View();
        //    return result;
        //}

        //public PartialViewResult GetProducts()
        //{
        //   PartialViewResult result = PartialView();
        //    return result;
        //}

        //public JsonResult GetProducts()
        //{
        //    JsonResult result = Json(new Product
        //    {
        //        Id = 5,
        //        ProductName = "Terlik",
        //        Quantity = 15,

        //    });
        //    return result;
        //}

        //Response var ama boş.
        //public EmptyResult GetProducts()
        //{ 
        //    return new EmptyResult();
        //}

        //public ContentResult GetProducts()
        //{
        //    ContentResult result = Content("sebepsiz boş yere ayrılacaksannn");
        //    return result;
        //}

        //public ActionResult GetProducts()
        //{
        //    if (true)
        //    {
        //        return Json(new object());
        //    }
        //    else if (true)
        //    {
        //        return Content("ksnclksnkn");
        //    }
        //    return View();
        //}

        //public IActionResult GetProducts()
        //{

        //}


        //public IActionResult GetProducts()
        // {
        //Product product = new Product(); //Conroller'dan model'a gitmen anlamına gelir. new leme işlemi. Model'a gidip oradan veriyi alıp getirmesi.

        //Veri retildi...
        //View fonksiyonu bu actiona ait view (.cshtml) dosyasını tetikleyecek olan fonksiyondur.

        //ViewResult result=View(); ==> ilgili action ismiyle aynı olan viewi tetikler.
        //ViewResult result = View("Ahmet"); //==> belirtilen view ismindeki view dosyasını rander eder. Model'a giderse eğer ordan aldığı veriyi geri döndürmesi. Ama model'a illaki gidecek diye bir kural yok.

        //return View();
        //return result;



        //}

    }
}
