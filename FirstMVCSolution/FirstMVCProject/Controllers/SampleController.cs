using FirstMVCProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCProject.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            return Content("Sample Controller - Index View");
        }

        public IActionResult Details()
        {
            return Content("Sample Controller - Details View");
        }

        public IActionResult RenderTable()
        {
            return View();
        }

        public IActionResult RenderTableUsingModels()
        {
            var persons = new List<PersonViewModel>
            {
                new PersonViewModel
                {
                    Id=1,
                    Name="John",
                    City="Chicago"
                },
                new PersonViewModel
                {
                    Id=2,
                    Name="Mary",
                    City="NY"
                },
                new PersonViewModel
                {
                    Id=3,
                    Name="Dave",
                    City="Jersey"
                },
                new PersonViewModel
                {
                    Id=4,
                    Name="Mark",
                    City="DC"
                },
            };
            return View(persons);
        }
    }
}