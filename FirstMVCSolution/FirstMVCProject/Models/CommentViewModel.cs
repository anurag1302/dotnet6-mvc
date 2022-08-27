namespace FirstMVCProject.Models
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string IpAddress { get; set; }
        public string Comment { get; set; }
        public DateTime? CommentedDateTime { get; set; }
    }
}