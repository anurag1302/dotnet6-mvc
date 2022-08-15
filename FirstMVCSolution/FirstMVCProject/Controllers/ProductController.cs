using FirstMVCProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstMVCProject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult AddProduct()
        {
            var product = new AddProductViewModel
            {
                ProductName = string.Empty,
                ProductCategory = null,
                Price = null,
                ImportedDate = null
            };
            return View(product);
        }

        public IActionResult AddProductUsingJQuery()
        {
            var product = new AddProductViewModel
            {
                ProductName = string.Empty,
                ProductCategory = null,
                Price = null,
                ImportedDate = null
            };
            return View(product);
        }

        [HttpPost]
        [ValidateAJAX]
        public IActionResult AddProductUsingJQuery(AddProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var postedData = $"{model.ProductName} {model.ProductCategory} " +
                $"{model.ProductName} {model.ImportedDate}";
            return Content("Add Product Using jQuery Post Method");
        }

        //Using Property Names as arguments
        //[HttpPost]
        //public IActionResult AddProduct(string productName,
        //    int productCategory,
        //    double price,
        //    DateTime importedDate)
        //{
        //    var postedData = $"{productName} {productCategory} {price} {importedDate}";
        //    return Content("Add Product Post Method");
        //}

        //Using IFormCollection object
        //[HttpPost]
        //public IActionResult AddProduct(IFormCollection form)
        //{
        //    var productName = form["ProductName"];
        //    var productCategory = form["ProductCategory"];
        //    var productPrice = form["Price"];
        //    var importedDate = form["ImportedDate"];

        //    var postedData = $"{productName} {productCategory} {productPrice} {importedDate}";
        //    return Content("Add Product Post Method");
        //}

        //Using Models
        [HttpPost]
        public IActionResult AddProduct(AddProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var postedData = $"{model.ProductName} {model.ProductCategory} " +
                $"{model.ProductName} {model.ImportedDate}";

            return Content("Add Product Post Method");
        }

        public IActionResult RenderDropDowns()
        {
            var model = new SelectElementViewModel
            {
                Countries = GetCountries()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult RenderDropDowns(SelectElementViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Countries = GetCountries();
                return View(model);
            }
            var selectedCountry = model.SelectedCountry;
            var selectedCategory = model.Category;

            return Content("Form successfully posted!!!");
        }

        private IEnumerable<SelectListItem> GetCountries()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{Text="Please Select",Value=""},
                new SelectListItem{Text="India",Value="1"},
                new SelectListItem{Text="USA",Value="2"},
                new SelectListItem{Text="Germany",Value="3"},
                new SelectListItem{Text="China",Value="4"},
                new SelectListItem{Text="UK",Value="5"}
            };
        }
    }
}