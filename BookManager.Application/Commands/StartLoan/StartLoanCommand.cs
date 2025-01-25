using BookManager.Application.Models.ViewModel;
using BookManager.Core.Enums;
using MediatR;


namespace BookManager.Application.Commands.StartLoan
{
    public class StartLoanCommand : IRequest<ResultViewModel>
    {
        public StartLoanCommand(int id, LoanSituation situation, LoanStatus status)
        {
            Id = id;
            this.situation = situation;
            this.status = status;
        }

        public int Id { get; set; }
        public LoanSituation situation { get; set; }
        public LoanStatus status { get; set; }  

    }
}
