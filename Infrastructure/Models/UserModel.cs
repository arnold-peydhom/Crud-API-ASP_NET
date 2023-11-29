namespace Infrastructure.Models
{
    public class UserModel
    {
        public int UserId { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Profession { get; set; } = default!;
        public string Email { get; set; } = default!;
    }
}
