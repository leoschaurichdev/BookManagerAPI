using BookManager.Core.Entities;
using BookManager.Core.Repositories;

namespace BookManager.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BookManagerDbContext _context;
        public UserRepository(BookManagerDbContext context)
        {
            _context = context;
        }
        public async Task<int> Add(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user.Id;
        }

        Task<User?> IUserRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
