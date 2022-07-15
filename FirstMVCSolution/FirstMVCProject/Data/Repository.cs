using FirstMVCProject.Models;

namespace FirstMVCProject.Data
{
    public class Repository
    {
        public static IReadOnlyList<ProductViewModel> GetProducts()
        {
            return new List<ProductViewModel>
            {
                new ProductViewModel
                {
                    Id = 100198,
                    ProductName = "Intel Core i9-12900K",
                    ProductCategory = "CPU",
                    Price = 250000,
                    ImportedDate = DateTime.Now.AddMonths(-24)
                },
                new ProductViewModel
                {
                    Id = 110199,
                    ProductName = "AMD Ryzen 9 5950x",
                    ProductCategory = "CPU",
                    Price = 280000,
                    ImportedDate = DateTime.Now.AddMonths(-32)
                },
                new ProductViewModel
                {
                    Id = 102192,
                    ProductName = "MK LowKey70 Black RGB LED",
                    ProductCategory = "Mechanical Keyboard",
                    Price = 8000,
                    ImportedDate = DateTime.Now.AddMonths(-10)
                }
            };
        }
    }
}