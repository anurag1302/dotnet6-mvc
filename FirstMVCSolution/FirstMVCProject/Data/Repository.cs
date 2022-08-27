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

        public static IReadOnlyList<CommentViewModel> GetComments()
        {
            return new List<CommentViewModel>
            {
                new CommentViewModel
                {
                    Id=101,
                    Name="John Simmons",
                    Email="john@test.com",
                    IpAddress="192.23.45.89",
                    Comment="The post is good, got a lot to learn!!!",
                    CommentedDateTime=DateTime.UtcNow.AddYears(-2)
                },
                new CommentViewModel
                {
                    Id=102,
                    Name="Mary Jane",
                    Email="mary@gmail.com",
                    IpAddress="104.23.11.102",
                    Comment="Learnt partial views, thanks !!!",
                    CommentedDateTime=DateTime.UtcNow.AddMonths(-5)
                },
                new CommentViewModel
                {
                    Id=103,
                    Name="Dev Singh",
                    Email="dev@aol.com",
                    IpAddress="112.12.00.67",
                    Comment="This post needs more code snippets, Thanks !!!",
                    CommentedDateTime=DateTime.UtcNow.AddDays(-14)
                }
            };
        }
    }
}