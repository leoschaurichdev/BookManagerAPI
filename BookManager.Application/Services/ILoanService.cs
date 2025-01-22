using BookManager.Application.Models.InputModel;
using BookManager.Application.Models.ViewModel;
using BookManager.Infrastructure.Persistence;

namespace BookManager.Application.Services
{

    public interface ILoanService
    {
        ResultViewModel<int> Insert(CreateBookInputModel model);
        ResultViewModel StartLoan(UpdateBookInputModel model);
        ResultViewModel FinishLoan(UpdateBookInputModel model);
    }
}
