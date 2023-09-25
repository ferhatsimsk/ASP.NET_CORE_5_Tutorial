using Microsoft.AspNetCore.Mvc;

namespace OrnekMVC_1.Controllers
{

    //Bir sınıfı request alabilir ve response döndürebilir yani controller yapabilmek için o sınıfı controller class'ından türetmemiz gerekmektedir.
    //Controller sınıfları içerisinde istekleri karşılayan metotlara action metot denir.
    //Controller sınıfları içerisinde tanımlanan tüm metotlar artık action metot olarak nitelendirilecektir.
    
    
    public class HomeController : Controller //Buradaki controller action metot yapar.Eğer bu olmazsa normal metot olur.
    {
        //Action metot : Controllera gelen isteği karşılayan ve gerekli operasyonları gerçekleştien metotlardır.
        public IActionResult Index()
        {
            return View();
        }
    }
}
