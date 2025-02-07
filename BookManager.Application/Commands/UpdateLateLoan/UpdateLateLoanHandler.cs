using BookManager.Application.Models.ViewModel;
using BookManager.Core.Repositories;
using MediatR;

namespace BookManager.Application.Commands.UpdateLateLoan
{
    public class UpdateLateLoanHandler : IRequestHandler<UpdateLateLoanCommand, ResultViewModel>
    {
        private readonly ILoanRepository _repository;

        public UpdateLateLoanHandler(ILoanRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel> Handle(UpdateLateLoanCommand request, CancellationToken cancellationToken)
        {
            var loan = await _repository.GetById(request.Id);

            if (loan is null)
            {
                return ResultViewModel.Error("Loan not found");
            }

            if (DateTime.Now > loan.DevolutionDay)
            {
                loan.LateLoan();
            }
              
            loan.UpdateAt = DateTime.Now;
            await _repository.UpdateLateLoan(loan);

            return ResultViewModel.Success();
        }

        
    }
}
