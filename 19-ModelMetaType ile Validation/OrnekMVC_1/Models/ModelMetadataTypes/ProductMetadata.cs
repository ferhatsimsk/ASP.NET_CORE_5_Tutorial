using System.ComponentModel.DataAnnotations;

namespace OrnekMVC_1.Models.ModelMetadataTypes
{
    public class ProductMetadata
    {
        [Required (ErrorMessage ="Lütfen product name'i giriniz")] 
        [StringLength(100, ErrorMessage = "Lütfen Product name'i en fazla 100 karakter olarak giriniz.")]
        public string ProductName { get; set; }

        [EmailAddress(ErrorMessage = "Lütfen doğru bir email adresi giriniz.")]
        public string Email { get; set; }


    }
}
