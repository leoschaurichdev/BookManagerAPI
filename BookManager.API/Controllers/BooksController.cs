using BookManager.API.Models.InputModel;
using BookManager.API.Models.ViewModel;
using BookManager.API.Persistence;
using BookManager.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookManager.API.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private readonly BookManagerDbContext _context;
        public BooksController(BookManagerDbContext context)
        {
            _context = context;
        }
        //GET api/books
        [HttpGet]
        public IActionResult GetAll()
        {
            var books = _context.Books.Where(b => !b.IsDeleted).ToList();
            var model = books.Select(b => new ResultViewModel());
            return Ok();
        }

        //GET api/books/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var book = _context.Books
                .Include(b => b.Author)
                .Include(b=>b.Id)
                .Include(b=>b.Title)
                .Include(b=>b.ISBN)
                .Include(b=>b.YearPublication)
                .SingleOrDefault(b => b.Id == id);

            var model = BookViewModel.FromEntity(book);

            return CreatedAtAction(nameof(GetById),new { id = 1 }, model);
        }

        //POST api/books
        [HttpPost]
        public IActionResult Post(CreateBookInputModel model)
        {
            var book =model.ToEntity();

            _context.Books.Add(book);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateBookInputModel model)
        {
            var book = _context.Books.SingleOrDefault(b => b.Id == id);
            
            if(book is null)
            {
                return NotFound();
            }

            book.Update(model.Cover, model.Localization);

            _context.Books.Update(book);
            _context.SaveChanges();

            return NoContent();
        }

        //DELETE api/books
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = _context.Books.SingleOrDefault(b => b.Id == id);

            if (book is null)
            {
                return NotFound();
            }
            book.SetAsDeleted();
            _context.SaveChanges();
            return NoContent();
        }



    }
}
