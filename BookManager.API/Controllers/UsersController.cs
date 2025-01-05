using BookManager.API.Models.InputModel;
using Microsoft.AspNetCore.Mvc;

namespace BookManager.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        //POST api/users

        [HttpPost]
        public IActionResult Post(CreateUserInputModel model)
        {
            return NoContent();
        }
    }
}
