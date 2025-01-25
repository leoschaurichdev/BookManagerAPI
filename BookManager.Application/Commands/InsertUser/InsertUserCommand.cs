using BookManager.Application.Models.ViewModel;
using BookManager.Core.Entities;
using MediatR;

namespace BookManager.Application.Commands.InsertUser
{
    public class InsertUserCommand : IRequest<ResultViewModel<int>>
    {
        public InsertUserCommand(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public User ToEntity() => new User(Name, Email, BirthDate);
    }
}
