using System.ComponentModel.DataAnnotations;

namespace OrnekMVC_1.Models
{
    public class Product
    {
        [Required(ErrorMessage ="Lütfen Product name'i giriniz.")]
        public string ProductName { get; set; }
        [StringLength(100, ErrorMessage ="Lütfen product name'i en fazla 100 karakter giriniz.")]
        public int Quantity { get; set; }
        [EmailAddress(ErrorMessage ="Lütfen doğru bir email adresi giriniz.")]
        public string Email { get; set; }
    }
}
