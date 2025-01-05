namespace BookManager.API.Entities
{
    public class User
    {
        public User(int userId, string name, string email)
        {
            UserId = userId;
            Name = name;
            Email = email;
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
