using Microsoft.AspNetCore.Mvc;
using OrnekMVC_1.Models;

namespace OrnekMVC_1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            Product product = new Product(); //Conroller'dan model'a gitmen anlamına gelir. new leme işlemi. Model'a gidip oradan veriyi alıp getirmesi.

            //Veri retildi...
            //View fonksiyonu bu actiona ait view (.cshtml) dosyasını tetikleyecek olan fonksiyondur.
            
            //ViewResult result=View(); ==> ilgili action ismiyle aynı olan viewi tetikler.
            ViewResult result = View("Ahmet"); //==> belirtilen view ismindeki view dosyasını rander eder. Model'a giderse eğer ordan aldığı veriyi geri döndürmesi. Ama model'a illaki gidecek diye bir kural yok.

            //return View();
            return result;
        }

    }
}
