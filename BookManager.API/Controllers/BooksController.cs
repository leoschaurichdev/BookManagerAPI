using BookManager.Application.Commands.DeleteBook;
using BookManager.Application.Commands.InsertBook;
using BookManager.Application.Commands.UpdateBook;
using BookManager.Application.Queries.GetAllBook;
using BookManager.Application.Queries.GetByIdBook;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookManager.API.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        
        private readonly IMediator _mediator;
        public BooksController(IMediator mediator)
        {
            
            _mediator = mediator;
        }
        //GET api/books
       
        [HttpGet]
        public async Task<IActionResult> Get()
        {
       
            //var result = _service.GetAll();

            var query = new GetAllBookQuery();

            var result = await _mediator.Send(query);

            return Ok(result);

        }

        //GET api/books/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            
            var result = await _mediator.Send(new GetBookByIdQuery(id));

            if(!result.IsSucess)
            {
                return BadRequest(result.Message);
            }

            return Ok(result);

        }

        //POST api/books
        [HttpPost]
        public async Task<IActionResult>  Post(InsertBookCommand command)
        {
            var result = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = result.Data}, result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UpdateBookCommand command)
        {
            var result = await _mediator.Send(command);

            if (!result.IsSucess)
            {
                return BadRequest(result.Message);
            }

            return NoContent();
        }

        //DELETE api/books
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteBookCommand(id));

            if (!result.IsSucess)
            {
                return BadRequest(result.Message);
            }

            return NoContent();
        }



    }
}
