namespace BookManager.API.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, string email, DateTime birthDate, bool active)
        {

            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            Active = true;

        }

        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; private set; }
        public bool Active { get; private set; }
    }
}
