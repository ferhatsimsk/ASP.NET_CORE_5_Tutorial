using Microsoft.AspNetCore.Mvc;
using OrnekMVC_1.Models;

namespace OrnekMVC_1.Controllers
{
    //Eğer controller olarak değilde iş mantığıyla kullanılacaksa noncontroler yapılır
    //NonControllerla dışarıdan istek alamaz hale gelir.
    //Normal bir sınıf mantığıyla haraket eder.
    [NonController]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            X();
            return View();
        }
        
        //Controller içerisinde NonAction attribute'u ile işaretlenen fonksiyonlar dışarıdan request almazlar.Sadece operatif yani algoritma barındıran iş mantığı yürüten bir metottur. X dışarıdan gelen requestlerle tetikleme yapılamayacak. Sadece buradaki actionlar tarafından kullanılan bir business iş mantığıyla değerlendirilir.
        [NonAction]
        public void X()
        {

        }

    }
}
