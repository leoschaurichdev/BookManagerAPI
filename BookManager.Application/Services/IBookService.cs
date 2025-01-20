using BookManager.Application.Models.InputModel;
using BookManager.Application.Models.ViewModel;
using BookManager.Infrastructure.Persistence;

namespace BookManager.Application.Services
{
    public interface IBookService
    {
        ResultViewModel<List<BookViewModel>> GetAll(string search = "");
        ResultViewModel<BookViewModel> GetById(int id);
        ResultViewModel<int> Insert(CreateBookInputModel model);
        ResultViewModel Update(UpdateBookInputModel model);
        ResultViewModel Delete(int id);
    }

   
}
