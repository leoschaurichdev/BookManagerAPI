using BookManager.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Application.Commands.FinishLoan
{
    public class FinishLoanHandler 
    {
        private readonly BookManagerDbContext _context;

        public FinishLoanHandler(BookManagerDbContext context)
        {
            _context = context;
        }
    }
}
