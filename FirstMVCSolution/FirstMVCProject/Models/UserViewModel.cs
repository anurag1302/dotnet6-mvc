using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace FirstMVCProject.Models
{
    public class UserViewModel : IValidatableObject
    {
        [Required(ErrorMessage = "Name can't be empty.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please select a gender.")]
        public int? Gender { get; set; }

        [Required(ErrorMessage = "City can't be empty.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter required orders.")]
        public int? Orders { get; set; }

        public List<SelectListItem> Genders { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var customValidations = new List<ValidationResult>();

            if (Orders.HasValue && (Orders.Value < 10 || Orders.Value > 100))
            {
                customValidations.Add(new ValidationResult("Orders are messed up.", new[] { "Orders" }));
            }

            if (!Name.Contains("an"))
            {
                customValidations.Add(new ValidationResult("Name is not proper.", new[] { "Name" }));
            }

            if (!Name.StartsWith("D") && !City.StartsWith("N"))
            {
                customValidations.Add(new ValidationResult("Name and City combination fails.", new[] { "Name", "City" }));
            }
            return customValidations;
        }
    }
}