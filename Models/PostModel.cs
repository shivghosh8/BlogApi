namespace BlogApi.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Category { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsPublished { get; set; }
        public string CreatedByName { get; set; } = null!;
    }
}
