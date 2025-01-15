namespace BookManager.API.Entities
{
    public class User : BaseEntity
    {
        public User(int userId, string name, string email, DateTime birthDate)
        {

            Email = email;
            BirthDate = birthDate;
            Loans = [];
        }

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