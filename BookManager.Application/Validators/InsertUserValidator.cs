using BookManager.Application.Commands.InsertUser;
using FluentValidation;

namespace BookManager.Application.Validators
{
    public class InsertUserValidator : AbstractValidator<InsertUserCommand>
    {
        public InsertUserValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name is required");
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email is required")
                .EmailAddress()
                .WithMessage("Email is invalid");
            
        }
    }
}
