using BookManager.Application.Models.ViewModel;
using BookManager.Core.Enums;
using MediatR;


namespace BookManager.Application.Commands.UpdateLateLoan
{
    public class UpdateLateLoanCommand : IRequest<ResultViewModel>
    {
        public UpdateLateLoanCommand(int id)
        {
           Id = id;
        }

        public int Id{ get; set; }

    }
}
