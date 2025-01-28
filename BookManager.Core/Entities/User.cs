namespace BookManager.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Loans = new List<Loan>();
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