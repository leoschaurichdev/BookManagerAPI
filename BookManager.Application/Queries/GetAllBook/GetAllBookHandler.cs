using BookManager.Application.Models.ViewModel;
using BookManager.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookManager.Application.Queries.GetAllBook
{

    public class GetAllBookHandler : IRequestHandler<GetAllBookQuery, ResultViewModel<List<BookViewModel>>>
    {
        private readonly BookManagerDbContext _context;
        public GetAllBookHandler(BookManagerDbContext context)
        {
            _context = context;
        }
        public async Task<ResultViewModel<List<BookViewModel>>> Handle(GetAllBookQuery request, CancellationToken cancellationToken)
        {
            var books = await _context.Books.Where(b => !b.IsDeleted).ToListAsync();
            var model = books.Select(BookViewModel.FromEntity).ToList();
            return ResultViewModel<List<BookViewModel>>.Success(model);
        }
    }
}
