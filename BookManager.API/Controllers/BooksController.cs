using BookManager.API.Models.InputModel;
using BookManager.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookManager.API.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private readonly IConfigService _config;
        public BooksController(IConfigService config)
        {
            _config = config;
        }
        //GET api/books
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        //GET api/books/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        //POST api/books
        [HttpPost]
        public IActionResult Post(CreateBookInputModel model)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1}, model);
        }

        //DELETE api/books
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }



    }
}
