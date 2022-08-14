namespace FirstMVCProject.Models
{
    public class AddProductViewModel
    {
        public string ProductName { get; set; }
        public int? ProductCategory { get; set; }
        public double? Price { get; set; }
        public DateTime? ImportedDate { get; set; }
    }
}