using BookManager.API.Entities;
using BookManager.API.Enums;
using BookManager.API.Models.InputModel;
using BookManager.API.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace BookManager.API.Controllers
{
    [ApiController]
    [Route("api/loans")]
    public class LoansController : ControllerBase
    {
        private readonly BookManagerDbContext _context;
        public LoansController(BookManagerDbContext context) 
        {
            _context = context;
        }

        //POST api/loans
        [HttpPost]
        public IActionResult Post(CreateLoanInputModel model)
        {
            var user = _context.Users.Find(model.IdUser);
            var book = _context.Books.Find(model.IdBook);

            if (user == null || book == null)
            {
                return BadRequest("User or Book not found.");
            }

            var loan = new Loan(model.LoanDate, user, book);

            _context.Loans.Add(loan);
            _context.SaveChanges();

            return Ok(loan);
        }

        //PUT api/loans/1/startloan
        [HttpPut("{id}/startloan")]
        public IActionResult StartLoan(int id)
        {
            var loan = _context.Loans.Find(id);

            if (loan == null)
            {
                return NotFound();
            }

            loan.StartLoan();
            _context.SaveChanges();
            return NoContent();
        }



        //PUT api/loans/1/loancomplete
        [HttpPut("{id}/finishloan")]
        public IActionResult FinishLoan(int id)
        {

            var loan = _context.Loans.Find(id);
            loan.FinishLoan();
            _context.SaveChanges();
            return NoContent();
        }
    }
}
