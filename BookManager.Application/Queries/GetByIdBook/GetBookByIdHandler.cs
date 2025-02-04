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
            try
            {
                var book = await _repository.GetById(request.Id);

                if (book == null)
                {
                    return ResultViewModel<BookViewModel>.Error("Book not found");
                }

                var model = BookViewModel.FromEntity(book);

                return ResultViewModel<BookViewModel>.Success(model);
            }
            catch (Exception ex)
            {
                return ResultViewModel<BookViewModel>.Error(ex.Message);

            }
        }
    }
}
