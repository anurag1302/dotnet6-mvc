namespace FirstMVCProject.Models
{
    public class BaseProductViewModel
    {
        public IReadOnlyList<ProductViewModel> Products { get; set; }
        public int Count { get; set; }
        public string ConsolidatedStatus { get; set; }
    }
}