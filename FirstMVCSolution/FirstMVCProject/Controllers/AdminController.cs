using FirstMVCProject.Data;
using FirstMVCProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCProject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            var model = new AdminDashboardViewModel
            {
                NoOfPages = 5,
                NoOfPosts = 20,
                TotalViews = 585,
                Comments = Repository.GetComments()
            };
            return View(model);
        }

        public IActionResult Moderation()
        {
            var model = new AdminModerationViewModel
            {
                NoOfPageUpdates = 167,
                LastUpdatedOn = DateTime.UtcNow,
                Comments = Repository.GetComments()
            };
            return View(model);
        }

        public IActionResult CommentsPartial()
        {
            var comments = Repository.GetComments();
            return PartialView("_CommentsDetailsPartial", comments);
        }
    }
}