using System.ComponentModel.DataAnnotations;

namespace FirstMVCProject.Models
{
    public class AddProductViewModel
    {
        [Required(ErrorMessage = "Product Name can not be empty.")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Please select a Product Category.")]
        public int? ProductCategory { get; set; }

        [Required(ErrorMessage = "Product Price can not be empty.")]
        public double? Price { get; set; }

        [Required(ErrorMessage = "Product Imported Date can not be empty.")]
        public DateTime? ImportedDate { get; set; }
    }
}