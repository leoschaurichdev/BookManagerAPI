using BookManager.Infrastructure.Persistence;

namespace BookManager.Application.Commands.StartLoan
{
    public class StartLoanHandler
    {
        private readonly BookManagerDbContext _context;

        public StartLoanHandler(BookManagerDbContext context)
        {
            _context = context;
        }
    }
}
