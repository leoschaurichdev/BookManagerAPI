using BookManager.Core.Entities;

namespace BookManager.Core.Repositories
{
    public interface ILoanRepository
    {
        Task<IEnumerable<Loan>> GetAll();
        Task<Loan?> GetById(int id);
        Task<int> Add(Loan loan);
        Task FinishLoan(Loan loan);
        Task UpdateLateLoan(Loan loan);


    }
}
