using BookManager.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
