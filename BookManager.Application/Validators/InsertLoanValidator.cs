using BookManager.Application.Commands.InsertLoan;
using FluentValidation;

namespace BookManager.Application.Validators
{
    public class InsertLoanValidator : AbstractValidator<InsertLoanCommand>
    {
        public InsertLoanValidator()
        {
            RuleFor(x => x.IdBook)
                .NotEmpty()
                .WithMessage("BookId is required");
            RuleFor(x => x.IdUser)
                .NotEmpty()
                .WithMessage("UserId is required");
            RuleFor(x => x.LoanDate)
                .NotEmpty()
                .WithMessage("LoanDate is required")
                .Must((command, loanDate) => IsValidLoanDate(command.LoanDate))
                .WithMessage("LoanDate must be in the future");
            RuleFor(x => x.LoanDate)
                .NotEmpty()
                .WithMessage("LoanDate is required");

            RuleFor(x => x.LoanDate)
                .NotEmpty()
                .WithMessage("ReturnDate is required")
                .Must(loanDate => loanDate <= DateTime.Now.AddDays(1))
                .WithMessage("LoanDate cannot be in the future");

        }
        private bool IsValidLoanDate(DateTime loanDate)
        {
            return loanDate > DateTime.Now;
        }
        private bool IsValidReturnDate(DateTime loanDate, DateTime returnDate)
        {
            return returnDate > loanDate;
        }
    }
}
