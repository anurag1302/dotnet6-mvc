using FirstMVCProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstMVCProject.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var model = new UserViewModel
            {
                Genders = PopulateGenders()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Genders = PopulateGenders();
                return View(model);
            }

            //Once the model is validated properly, we can write code to save/update it to the DB.
            //For simplicity purposes, just a content has been returned.
            return Content("Validation checks have passed");
        }

        private List<SelectListItem> PopulateGenders()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{Text="Male",Value="1"},
                new SelectListItem{Text="Female",Value="2"},
                new SelectListItem{Text="Others",Value="3"}
            };
        }
    }
}