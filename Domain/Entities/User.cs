namespace Domain.Entities
{
    public class User
    {
        public int UserId { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Profession { get; set; } = default!;
        public string Email { get; set; } = default!;
    }
}
