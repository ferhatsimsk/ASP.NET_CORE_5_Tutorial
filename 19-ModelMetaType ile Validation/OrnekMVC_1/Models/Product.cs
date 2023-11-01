using Microsoft.AspNetCore.Mvc;
using OrnekMVC_1.Models.ModelMetadataTypes;
using System.ComponentModel.DataAnnotations;

namespace OrnekMVC_1.Models
{
    [ModelMetadataType(typeof(ProductMetadata))]
    public class Product
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Email { get; set; }
    }
}
