using BookManager.Application.Models.ViewModel;
using BookManager.Core.Repositories;
using MediatR;

namespace BookManager.Application.Queries.GetAllBook
{

    public class GetAllBookHandler : IRequestHandler<GetAllBookQuery, ResultViewModel<List<BookViewModel>>>
    {
        private readonly IBookRepository _repository;
        public GetAllBookHandler(IBookRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResultViewModel<List<BookViewModel>>> Handle(GetAllBookQuery request, CancellationToken cancellationToken)
        {
            var books = await _repository.GetAll();
            var nonDeletedBooks = books.Where(book => !book.IsDeleted).ToList();
            var model = nonDeletedBooks.Select(BookViewModel.FromEntity).ToList();
            return ResultViewModel<List<BookViewModel>>.Success(model);
        }
    }
}
