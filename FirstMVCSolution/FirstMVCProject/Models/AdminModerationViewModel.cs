namespace FirstMVCProject.Models
{
    public class AdminModerationViewModel
    {
        public int NoOfPageUpdates { get; set; }
        public DateTime LastUpdatedOn { get; set; }
        public IReadOnlyList<CommentViewModel> Comments { get; set; }
    }
}