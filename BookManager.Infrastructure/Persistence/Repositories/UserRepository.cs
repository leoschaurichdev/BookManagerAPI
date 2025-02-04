using BookManager.Core.Entities;
using BookManager.Core.Repositories;
using Microsoft.EntityFrameworkCore;

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

        public async Task<User?> GetById(int id)
        {
           var user = await _context.Users.SingleOrDefaultAsync(x => x.Id == id);

            if(user == null)
            {
                Console.WriteLine("User not found");
            }

            return user;
        }
    }
}
