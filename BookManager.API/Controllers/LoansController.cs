using BookManager.API.Models.InputModel;
using Microsoft.AspNetCore.Mvc;

namespace BookManager.API.Controllers
{
    [ApiController]
    [Route("api/loans")]
    public class LoansController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LoansController(IMediator _mediator)
        {
            _mediator = _mediator;
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
