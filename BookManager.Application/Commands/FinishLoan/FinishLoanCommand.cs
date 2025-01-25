using BookManager.Application.Models.ViewModel;
using BookManager.Core.Enums;
using MediatR;

namespace BookManager.Application.Commands.FinishLoan
{
    public class FinishLoanCommand : IRequest<ResultViewModel>
    {
        public FinishLoanCommand(int id, LoanSituation situation, LoanStatus status)
        {
            Id = id;
            Situation = situation;
            Status = status;
        }

        public int Id { get; set; }
        public LoanSituation Situation { get; set; }
        public LoanStatus Status { get; set; }
    }
}
