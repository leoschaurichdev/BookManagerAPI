using BookManager.Application.Models.ViewModel;
using MediatR;

namespace BookManager.Application.Queries.GetByIdBook
{
    public class GetBookByIdQuery :IRequest<ResultViewModel<BookViewModel>>
    {
        public GetBookByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}