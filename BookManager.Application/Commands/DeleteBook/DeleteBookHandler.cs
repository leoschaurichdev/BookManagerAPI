using BookManager.Application.Models.ViewModel;
using BookManager.Core.Repositories;
using MediatR;


namespace BookManager.Application.Commands.DeleteBook
{
    public class DeleteBookHandler : IRequestHandler<DeleteBookCommand, ResultViewModel>
    {
        private readonly IBookRepository _repository;

        public DeleteBookHandler(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var book = await _repository.GetById(request.Id);

            if (book is null)
            {
                return ResultViewModel.Error("Livro não encontrado");
            }

            await _repository.Delete(book.Id);
            return ResultViewModel.Sucess();
        }
    }
}
