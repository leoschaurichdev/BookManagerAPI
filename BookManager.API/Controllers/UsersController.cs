using BookManager.Application.Models.InputModel;
using BookManager.Core.Entities;
using BookManager.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace BookManager.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly BookManagerDbContext _context;
        public UsersController(BookManagerDbContext context)
        {
            _context = context;
        }


        //POST api/users
        [HttpPost]
        public IActionResult Post(CreateUserInputModel model)
        {
            var user = new User(model.Name, model.Email, model.BirthDate);
            
            _context.Users.Add(user);
            _context.SaveChanges();
            
            return NoContent();

        }
    }
}