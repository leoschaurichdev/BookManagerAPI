using BookManager.Core.Entities;
using BookManager.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BookManager.Infrastructure.Persistence.Repositories
{

    public class LoanRepository : ILoanRepository
    {
        private readonly BookManagerDbContext _context;
        public LoanRepository(BookManagerDbContext context)
        {
            _context = context;
        }
        public async Task<int> Add(Loan loan)
        {
            await _context.Loans.AddAsync(loan);
            await _context.SaveChangesAsync();
            return loan.LoanId;
        }

        public Task FinishLoan(Loan loan)
        {
            throw new NotImplementedException();
        }

        public Task StartLoan(Loan loan)
        {
            throw new NotImplementedException();
        }

        public async Task<Loan?> GetById(int id)
        {
           return await _context.Loans.SingleOrDefaultAsync(x => x.LoanId == id);
        }
    }
}
