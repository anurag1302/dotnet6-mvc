using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using static FirstMVCProject.Enums.Enumerations;

namespace FirstMVCProject.Models
{
    public class SelectElementViewModel
    {
        public IEnumerable<SelectListItem> Countries { get; set; }

        [Required(ErrorMessage = "Please select a country.")]
        public string SelectedCountry { get; set; }

        [Required(ErrorMessage = "Please select a category.")]
        public ProductCategory? Category { get; set; }
    }
}