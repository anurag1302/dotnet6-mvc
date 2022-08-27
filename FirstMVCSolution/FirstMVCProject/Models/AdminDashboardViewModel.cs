namespace FirstMVCProject.Models
{
    public class AdminDashboardViewModel
    {
        public int NoOfPages { get; set; }
        public int NoOfPosts { get; set; }
        public int TotalViews { get; set; }
        public IReadOnlyList<CommentViewModel> Comments { get; set; }
    }
}