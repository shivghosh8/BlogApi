namespace BlogApi.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool? IsActive { get; set; }
    }
}
