using BookManager.Application.Models.InputModel;
using BookManager.Application.Models.ViewModel;
using BookManager.Core.Enums;
using BookManager.Infrastructure.Persistence;

namespace BookManager.Application.Services
{

    public class LoanService : ILoanService
    {
        private readonly BookManagerDbContext _context;
        public LoanService(BookManagerDbContext context)
        {
            _context = context;
        }

        public ResultViewModel FinishLoan(UpdateLoanInputModel model)
        {
            var loan = _context.Loans.SingleOrDefault(b => b.Id == model.LoanId);

            if (loan is null)
            {
                return ResultViewModel<LoanViewModel>.Error("Livro não encontrado");
            }

            loan.FinishLoan();

            _context.Loans.Update(loan);
            _context.SaveChanges();

            return ResultViewModel.Sucess();
        }

        public ResultViewModel<int> Insert(CreateLoanInputModel model)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id == model.IdUser);
            var book = _context.Books.SingleOrDefault(b => b.Id == model.IdBook);

            if (user == null || book == null)
            {
                return ResultViewModel<int>.Error("Usuário ou livro não encontrado");
            }

            var loan = model.ToEntity(user, book);

            _context.Loans.Add(loan);
            _context.SaveChanges();

            return ResultViewModel<int>.Success(loan.Id);
        }

        public ResultViewModel StartLoan(UpdateLoanInputModel model)
        {
            var loan = _context.Loans.SingleOrDefault(b => b.Id == model.LoanId);

            if (loan is null)
            {
                return ResultViewModel<LoanViewModel>.Error("Livro não encontrado");
            }

            loan.StartLoan();

            _context.Loans.Update(loan);
            _context.SaveChanges();

            return ResultViewModel.Sucess();
        }

        ResultViewModel<int> ILoanService.Insert(CreateBookInputModel model)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id == model.IdUser);
            var book = _context.Books.SingleOrDefault(b => b.Id == model.IdBook);

            if (user == null || book == null)
            {
                return ResultViewModel<int>.Error("Usuário ou livro não encontrado");
            }

            var loan = model.ToEntity(user, book);

            _context.Loans.Add(loan);
            _context.SaveChanges();

            return ResultViewModel<int>.Success(loan.Id);
        }

        ResultViewModel ILoanService.StartLoan(UpdateBookInputModel model)
        {
            throw new NotImplementedException();
        }

        ResultViewModel ILoanService.FinishLoan(UpdateBookInputModel model)
        {
            throw new NotImplementedException();
        }
    }
}
