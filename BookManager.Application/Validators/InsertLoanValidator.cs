using BookManager.Application.Commands.InsertLoan;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                .WithMessage("LoanDate is required")
                .Must((command, returnDate) => IsValidReturnDate(command.LoanDate, command.LoanDate))
                .WithMessage("ReturnDate must be after LoanDate");
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
