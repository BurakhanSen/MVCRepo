using System.ComponentModel.DataAnnotations;

namespace MVCTest.Models.ModelMetadataTypes
{
    public class ProductMetada
    {
        [Required(ErrorMessage = "Please enter a product name.")]
        [StringLength(100,ErrorMessage = "The length of the product name cannot be longer than 100 characters.")]
        public string Name { get; set; }
    }
}