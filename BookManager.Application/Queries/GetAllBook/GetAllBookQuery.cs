using BookManager.Application.Models.ViewModel;
using MediatR;

namespace BookManager.Application.Queries.GetAllBook
{
    public class GetAllBookQuery : IRequest<ResultViewModel<List<BookViewModel>>>
    {

    }
}
