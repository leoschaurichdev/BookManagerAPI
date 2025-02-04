using BookManager.Core.Entities;
using BookManager.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BookManager.Infrastructure.Persistence.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookManagerDbContext _context;
        public BookRepository(BookManagerDbContext context)
        {
            _context = context;
        }
        public async Task<int> Add(Book book)
        {
            await _context.Books.AddAsync(book);
            _context.SaveChanges();

            return book.Id;
        }

        public async Task Delete(int id)
        {
            var book = await _context.Books.SingleOrDefaultAsync(b => b.Id == id);
            if (book is null)
            {
                throw new Exception("Book not found");
            }

            await _context.SaveChangesAsync();
        }

        public async Task<List<Book>> GetAll()
        {
            var books = await _context.Books.ToListAsync();
            return books;
        }

        public async Task<Book?> GetById(int id)
        {
            if (id == 0)
            {
                throw new ArgumentException("Book ID cannot be null or zero.");
            }

            var book = await _context.Books.SingleOrDefaultAsync(b => b.Id == id);

            if (book is null)
            {
                throw new ArgumentException("Book not found");
            }

            return book;
        }

        public async Task Update(Book book)
        {
            
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
        }
    }
}
