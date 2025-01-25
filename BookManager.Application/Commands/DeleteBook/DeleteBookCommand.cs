using BookManager.Application.Models.ViewModel;
using MediatR;

namespace BookManager.Application.Commands.DeleteBook
{
    public class DeleteBookCommand : IRequest<ResultViewModel>
    {
        public int Id { get; set; }

        public DeleteBookCommand(int id)
        {
            Id = id;
        }
    }
}
