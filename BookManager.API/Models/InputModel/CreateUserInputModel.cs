using BookManager.API.Entities;

namespace BookManager.API.Models.InputModel
{
    public class CreateUserInputModel
    {
        public CreateUserInputModel(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public User ToEntity() => new(Name, Email, BirthDate);
    }
}
