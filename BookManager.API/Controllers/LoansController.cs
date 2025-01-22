using BookManager.Application.Models.InputModel;
using BookManager.Application.Services;
using BookManager.Core.Entities;
using BookManager.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace BookManager.API.Controllers
{
    [ApiController]
    [Route("api/loans")]
    public class LoansController : ControllerBase
    {
        private readonly BookManagerDbContext _context;
        private readonly ILoanService _service;
        public LoansController(BookManagerDbContext context, ILoanService service) 
        {
            _context = context;
            _service = service;
        }

        //POST api/loans
        [HttpPost]
        public IActionResult Post(CreateLoanInputModel model)
        {
            var user = _context.Users.Find(model.IdUser);
            var book = _context.Books.Find(model.IdBook);
            var LoanDay = model.LoanDate;


            if (user == null || book == null)
            {
                return BadRequest("User or Book not found.");
            }

            var loan = new Loan(user, book, LoanDay);

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
