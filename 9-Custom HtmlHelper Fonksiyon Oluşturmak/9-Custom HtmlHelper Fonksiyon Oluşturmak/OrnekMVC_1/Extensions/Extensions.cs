using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OrnekMVC_1.Extensions
{
    static public class Extensions
    {
        //Custom bir HtmlHelper oluşturma.
        //Diğer metotlarında custom halini extension fonksiyonuyla oluşturabiliriz.
        //Bir şeyin custom halini oluşturmak istiyorsak extension fonksiyonlarını kullanabiliriz.
        public static IHtmlContent CustomTextBox(this IHtmlHelper htmlHelper, string name, string value = "", string placeHolder = "")
        {
            return htmlHelper.TextBox(name, value, new
            {
                style="background-color:green;color:white;font-size:11px;",
                @class ="form-input",
                a="a",
                b="b",
                placehodler=placeHolder
            });
        }
    }
}
