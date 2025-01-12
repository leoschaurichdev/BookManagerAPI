using BookManager.API.Entities;

namespace BookManager.API.Models.ViewModel
{
    public class UserViewModel
    {
        public UserViewModel(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; set; }

        public static UserViewModel FromEntity(User entity)
            => new(entity.Name, entity.Email, entity.BirthDate);
    }
}
