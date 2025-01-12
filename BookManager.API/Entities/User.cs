namespace BookManager.API.Entities
{
    public class User : BaseEntity
    {
        public User(int userId, string name, string email, DateTime birthDate)
        {

            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            Loans = [];
        }

        public string FullName { get; set; }
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
