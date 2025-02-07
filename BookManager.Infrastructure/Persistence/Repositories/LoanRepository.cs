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
            return loan.Id;
        }

        public async Task FinishLoan(Loan loan)
        {
            loan.FinishLoan();
            _context.Loans.Update(loan);

            await _context.SaveChangesAsync();
        }

        public async Task<List<Loan>> GetAll()
        {
            return await _context.Loans
                .Include(x => x.User)
                .Include(x => x.Book)
                .ToListAsync();
        }

        public async Task<Loan?> GetById(int id)
        {
           return await _context.Loans.SingleOrDefaultAsync(x => x.Id == id);

        }

        public async Task UpdateLateLoan(Loan loan)
        {
            var existingLoan = await _context.Loans.SingleOrDefaultAsync(x => x.Id == loan.Id);
            
            if (existingLoan is null)
            {
               Console.WriteLine("Loan not found");
            }

            await _context.SaveChangesAsync();
        }
    }
}

