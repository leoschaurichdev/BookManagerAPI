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
            return NoContent();
        }

        //PUT api/loans/1/startloan
        [HttpPut("{id}/startloan")]
        public IActionResult StartLoan(int id)
        {
            return NoContent();
        }

        //PUT api/loans/1/loancomplete
        [HttpPut("{id}/finishloan")]
        public IActionResult FinishLoan(int id)
        {
            return NoContent();
        }
    }
}
