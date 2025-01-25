

using BookManager.Core.Entities;

namespace BookManager.Core.Repositories
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAll();
        Task<Book?> GetById(int id);
        Task<int> Add(Book book);
        Task Update(Book book);
        Task Delete(int id);
    }
}
