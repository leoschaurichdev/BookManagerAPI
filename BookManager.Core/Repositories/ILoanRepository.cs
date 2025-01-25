
using BookManager.Core.Entities;

namespace BookManager.Core.Repositories
{
    public interface ILoanRepository
    {
        Task<Loan?> GetById(int id);
        Task<int> Add(Loan loan);
        Task StartLoan(Loan loan);
        Task FinishLoan(Loan loan);


    }
}
