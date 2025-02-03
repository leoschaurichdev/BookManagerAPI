using BookManager.Application.Models.ViewModel;
using MediatR;

namespace BookManager.Application.Queries.GetAllLoan
{
    public class GetAllLoanQuery : IRequest<ResultViewModel<List<LoanViewModel>>>
    {

    }
}
