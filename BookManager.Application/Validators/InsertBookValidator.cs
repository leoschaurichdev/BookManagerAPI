using BookManager.Application.Commands.InsertBook;
using FluentValidation;

namespace BookManager.Application.Validators
{
    public class InsertBookValidator : AbstractValidator<InsertBookCommand>
    {
        public InsertBookValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("Title is required");

            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("Description is required");

            RuleFor(x => x.Author)
                .NotEmpty()
                .WithMessage("Author is required");

            RuleFor(x => x.ISBN)
                .NotEmpty()
                .WithMessage("ISBN is required")
                .Must((command, isbn) => IsValidISBN(command.YearPublication, isbn))
                .WithMessage("ISBN must be 10 digits if published before 2008, otherwise 13 digits");

        }

        private bool IsValidISBN(int yearPublication, string isbn)
        {
            if (yearPublication < 2008)
            {
                return isbn.Length == 10;
            }
            else
            {
                return isbn.Length == 13;
            }
        }
    }
}
