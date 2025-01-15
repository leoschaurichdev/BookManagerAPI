using BookManager.API.Models.InputModel;
using BookManager.API.Persistence;
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

        [HttpPost]
        public IActionResult Post(CreateUserInputModel model)
        {
            return NoContent();
        }
    }
}
