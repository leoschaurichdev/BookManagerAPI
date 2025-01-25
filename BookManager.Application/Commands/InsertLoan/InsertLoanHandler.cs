using BookManager.Application.Models.ViewModel;
using BookManager.Core.Entities;
using BookManager.Core.Repositories;
using BookManager.Infrastructure.Persistence;
using MediatR;

namespace BookManager.Application.Commands.InsertLoan
{
    public class InsertLoanHandler : IRequestHandler<InsertLoanCommand, ResultViewModel<int>>
    {
        private readonly ILoanRepository _repository;

        public InsertLoanHandler(ILoanRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<int>> Handle(InsertLoanCommand request, CancellationToken cancellationToken)
        {
            var loan = new Loan
            {


            };

            await _repository.Add(loan);

            return ResultViewModel<int>.Success(loan.LoanId);
        }
    }
}
