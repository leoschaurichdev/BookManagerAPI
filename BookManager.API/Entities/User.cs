namespace BookManager.API.Entities
{
    public class User
    {
        public User(int userId, string name, string email, DateTime birthDate)
        {
            UserId = userId;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Loans = [];
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public List<Loan> Loans { get; set; }

        public void Update (string name, string email, DateTime birthDay)
        {
            Name = name;
            Email = email;
            BirthDate = birthDay;

        }
    }
}
