using BookManager.Application.Models.ViewModel;
using BookManager.Core.Repositories;
using MediatR;

namespace BookManager.Application.Queries.GetByIdBook
{
    public class GetBookByIdHandler : IRequestHandler<GetBookByIdQuery, ResultViewModel<BookViewModel>>
    {
        private readonly IBookRepository _repository;
        public GetBookByIdHandler(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<BookViewModel>> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var book = await _repository.GetById(request.Id);
            var model = BookViewModel.FromEntity(book);

            if (book == null)
            {
                return ResultViewModel<BookViewModel>.Error("Book not found");
            }

            return ResultViewModel<BookViewModel>.Success(model);
        }
    }
}
