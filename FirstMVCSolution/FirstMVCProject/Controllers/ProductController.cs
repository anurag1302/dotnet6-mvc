using FirstMVCProject.Models;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult AddProductUsingJQuery(AddProductViewModel model)
        {
            var postedData = $"{model.ProductName} {model.ProductCategory} " +
                $"{model.ProductName} {model.ImportedDate}";
            return Content("Add Product Using jQuery Post Method");
        }

        //[HttpPost]
        //public IActionResult AddProduct(string productName,
        //    int productCategory,
        //    double price,
        //    DateTime importedDate)
        //{
        //    var postedData = $"{productName} {productCategory} {price} {importedDate}";
        //    return Content("Add Product Post Method");
        //}

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

        [HttpPost]
        public IActionResult AddProduct(AddProductViewModel model)
        {
            var postedData = $"{model.ProductName} {model.ProductCategory} " +
                $"{model.ProductName} {model.ImportedDate}";
            return Content("Add Product Post Method");
        }
    }
}