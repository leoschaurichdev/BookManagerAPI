using BookManager.Application.Models.InputModel;
using BookManager.Application.Models.ViewModel;
using BookManager.Infrastructure.Persistence;

namespace BookManager.Application.Services
{
    public class UserService : IUserService
    {
        private readonly BookManagerDbContext _context;
        public UserService(BookManagerDbContext context)
        {
            _context = context;
        }
        public ResultViewModel<int> Insert(CreateUserInputModel model)
        {
            var user = model.ToEntity();

            _context.Users.Add(user);
            _context.SaveChanges();

            return ResultViewModel<int>.Success(user.Id);

        }

    }
}
