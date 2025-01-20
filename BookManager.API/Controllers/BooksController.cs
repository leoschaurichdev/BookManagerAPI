using BookManager.Application.Models.InputModel;
using BookManager.Application.Services;
using BookManager.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace BookManager.API.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private readonly BookManagerDbContext _context;
        private readonly IBookService _service;
        public BooksController(BookManagerDbContext context, IBookService service)
        {
            _context = context;
            _service = service;
        }
        //GET api/books
       
        [HttpGet]
        public IActionResult GetAll()
        {
       
            var result = _service.GetAll();
            return Ok(result);

        }

        //GET api/books/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
         
            var result = _service.GetById(id);
            return Ok(result);

        }

        //POST api/books
        [HttpPost]
        public IActionResult Post(CreateBookInputModel model)
        {
            var result = _service.Insert(model);

            return CreatedAtAction(
                nameof(GetById),
                new { id = result.Data },
                result
            );
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateBookInputModel model)
        {
            var result = _service.Update(model);

            if (!result.IsSucess)
            {
                return BadRequest(result.Message);
            }

            return NoContent();
        }

        //DELETE api/books
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _service.Delete(id);

            if (!result.IsSucess)
            {
                return BadRequest(result.Message);
            }

            return NoContent();
        }



    }
}
