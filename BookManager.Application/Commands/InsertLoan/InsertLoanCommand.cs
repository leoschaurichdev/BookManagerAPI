using BookManager.Application.Models.ViewModel;
using BookManager.Core.Entities;
using MediatR;

namespace BookManager.Application.Commands.InsertLoan
{
    public class InsertLoanCommand : IRequest<ResultViewModel<int>>
    {
        public int IdBook { get; set; }
        public int IdUser { get; set; }
        public DateTime LoanDate { get; set; }

       
    }
}
