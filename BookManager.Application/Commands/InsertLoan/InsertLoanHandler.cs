using BookManager.Application.Models.ViewModel;
using BookManager.Core.Entities;
using BookManager.Core.Repositories;
using MediatR;

namespace BookManager.Application.Commands.InsertLoan
{
    public class InsertLoanHandler : IRequestHandler<InsertLoanCommand, ResultViewModel<int>>
    {
        private readonly ILoanRepository _loanRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IUserRepository _userRepository;

        public InsertLoanHandler(ILoanRepository loanRepository, IBookRepository bookRepository, IUserRepository userRepository)
        {
            _loanRepository = loanRepository;
            _bookRepository = bookRepository;
            _userRepository = userRepository;
        }

        public async Task<ResultViewModel<int>> Handle(InsertLoanCommand request, CancellationToken cancellationToken)
        {
            
            var book = await _bookRepository.GetById(request.IdBook);
            var user = await _userRepository.GetById(request.IdUser);
           

            if (book == null || user == null)
            {
                return ResultViewModel<int>.Error("Book or User not found");
            }

            Loan loan = new Loan(user, book, request.LoanDate);

            await _loanRepository.Add(loan);

            return ResultViewModel<int>.Success(loan.Id);
        }
    }
}
