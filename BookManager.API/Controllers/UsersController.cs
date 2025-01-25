using BookManager.Application.Commands.InsertUser;
using BookManager.Application.Queries.GetUserById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookManager.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;

        }

        //GETById api/users/id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(new GetUserByIdQuery(id));

            if (!result.IsSucess)
            {
                return BadRequest(result.Message);
            }

            return Ok(result);
        }
            //POST api/users
        [HttpPost]
        public async Task<IActionResult> Post(InsertUserCommand command)
        {
        
         var result = await _mediator.Send(command);

         return CreatedAtAction(nameof(GetById), new { id = result.Data }, command);

        }
    }
}

