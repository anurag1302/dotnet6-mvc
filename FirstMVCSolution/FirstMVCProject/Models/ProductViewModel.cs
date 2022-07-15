namespace FirstMVCProject.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public double Price { get; set; }
        public DateTime ImportedDate { get; set; }
    }
}