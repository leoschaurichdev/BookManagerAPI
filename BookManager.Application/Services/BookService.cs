using BookManager.Application.Models.InputModel;
using BookManager.Application.Models.ViewModel;
using BookManager.Infrastructure.Persistence;

namespace BookManager.Application.Services
{
    public class BookService : IBookService
    {
        private readonly BookManagerDbContext _context;
        public BookService(BookManagerDbContext context)
        {
            _context = context;
        }

        public ResultViewModel<List<BookViewModel>> GetAll(string search = "")
        {
            var books = _context.Books
                .Where(b => string.IsNullOrEmpty(search) || b.Title.Contains(search) || b.Author.Contains(search))
                .Select(b => new BookViewModel(
                    b.Id,
                    b.Title,
                    b.Author,
                    b.ISBN,
                    b.YearPublication,
                    b.Localization
                )).ToList();

            return ResultViewModel<List<BookViewModel>>.Success(books);
        }
        public ResultViewModel<BookViewModel> GetById(int id)
        {
            var book = _context.Books
                    .SingleOrDefault(b => b.Id == id);

            if (book is null)
            {
                return ResultViewModel<BookViewModel>.Error("Livro não encontrado");
            }

            var bookViewModel = new BookViewModel(
                book.Id,
                book.Title,
                book.Author,
                book.ISBN,
                book.YearPublication,
                book.Localization
            );

            return ResultViewModel<BookViewModel>.Success(bookViewModel);
        }
        public ResultViewModel<int> Insert(CreateBookInputModel model)
        {
            var book = model.ToEntity();

            _context.Books.Add(book);
            _context.SaveChanges();

            return ResultViewModel<int>.Success(book.Id);
        }
        public ResultViewModel Update(UpdateBookInputModel model)
        {
            var book = _context.Books.SingleOrDefault(b=>b.Id == model.Id);

            if (book is null)
            {
                return ResultViewModel<BookViewModel>.Error("Livro não encontrado");
            }

            book.Update(model.Cover, model.Localization);

            _context.Books.Update(book);
            _context.SaveChanges();

            return ResultViewModel.Sucess();
        }
        public ResultViewModel Delete(int id)
        {
            var book = _context.Books.SingleOrDefault(b => b.Id == id);

            if (book is null)
            {
                return ResultViewModel.Error("Livro não encontrado");
            }
            book.SetAsDeleted();
            _context.Books.Update(book);
            _context.SaveChanges();
            return ResultViewModel.Sucess();
        }
    }
}