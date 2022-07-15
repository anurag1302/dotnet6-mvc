using FirstMVCProject.Data;
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

        public IActionResult ViewDataExample()
        {
            ViewData["Country"] = "India";
            ViewData["City"] = "New Delhi";
            ViewData["PinCode"] = 110067;

            //ViewData[123] = 345;//compilation error

            return View();
        }

        public IActionResult ViewBagExample()
        {
            ViewBag.FirstName = "John";
            ViewBag.LastName = "Doe";
            ViewBag.CreatedDate = DateTime.Now;
            ViewBag.IsAContractualEmployee = true;

            return View();
        }

        public IActionResult PopulateAProduct()
        {
            var model = new ProductViewModel
            {
                Id = 100198,
                ProductName = "Intel Core i9-12900K",
                ProductCategory = "CPU",
                Price = 250000,
                ImportedDate = DateTime.Now.AddMonths(-24)
            };

            return View(model);
        }

        public IActionResult PopulateProducts()
        {
            var products = Repository.GetProducts();

            var model = new BaseProductViewModel
            {
                Products = products,
                Count = products.Count(),
                ConsolidatedStatus = "Delivered"
            };

            return View(model);
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