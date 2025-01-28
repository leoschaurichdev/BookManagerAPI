using BookManager.Application.Models.ViewModel;
using BookManager.Core.Repositories;
using MediatR;

namespace BookManager.Application.Commands.FinishLoan
{
    public class FinishLoanHandler : IRequestHandler<FinishLoanCommand, ResultViewModel>
    {
        private readonly ILoanRepository _loanRepository;

        public FinishLoanHandler(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public async Task<ResultViewModel> Handle(FinishLoanCommand request, CancellationToken cancellationToken)
        {
            var loan = await _loanRepository.GetById(request.Id);

            if (loan == null)
            {
                return ResultViewModel.Error("Loan not found");
            }

            loan.FinishLoan();
            await _loanRepository.FinishLoan(loan);

            return ResultViewModel.Success();
        }
    }
}
