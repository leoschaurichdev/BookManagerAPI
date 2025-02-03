using BookManager.Application.Models.ViewModel;
using BookManager.Core.Enums;
using BookManager.Core.Repositories;
using MediatR;

namespace BookManager.Application.Queries.GetAllLoan
{
    public class GetAllLoanHandler : IRequestHandler<GetAllLoanQuery, ResultViewModel<List<LoanViewModel>>>
    {
        private readonly ILoanRepository _repository;
        public GetAllLoanHandler(ILoanRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResultViewModel<List<LoanViewModel>>> Handle(GetAllLoanQuery request, CancellationToken cancellationToken)
        {
            var loans = await _repository.GetAll();
            var nonFinishLoans = loans.Where(loan => loan.LoanStatus == LoanStatus.Active);
            var model = nonFinishLoans.Select(LoanViewModel.FromEntity).ToList();
            return ResultViewModel<List<LoanViewModel>>.Success(model);
        }
    }
}
