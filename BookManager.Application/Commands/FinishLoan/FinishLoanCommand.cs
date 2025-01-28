using BookManager.Application.Models.ViewModel;
using MediatR;

namespace BookManager.Application.Commands.FinishLoan
{
    public class FinishLoanCommand : IRequest<ResultViewModel>
    {
        public FinishLoanCommand(int id)
        {
            Id = id;

        }

        public int Id { get; set; }
    }
}
