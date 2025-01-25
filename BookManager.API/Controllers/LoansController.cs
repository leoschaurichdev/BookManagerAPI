using BookManager.Application.Commands.InsertLoan;
using BookManager.Application.Models.InputModel;
using BookManager.Infrastructure.Persistence;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookManager.API.Controllers
{
    [ApiController]
    [Route("api/loans")]
    public class LoansController : ControllerBase
    {
        private readonly IMediator _mediator;
        
        public LoansController(IMediator mediator) 
        {
            _mediator = mediator;
            
        }

        //POST api/loans
        [HttpPost]
        public async Task<IActionResult> Post(InsertLoanCommand command)
        {
            var result = await _mediator.Send(command);
            return CreatedAtAction("Post", new { id = result.Data }, result);
        }

        //PUT api/loans/1/startloan
        [HttpPut("{id}/startloan")]
        public IActionResult StartLoan(int id)
        {
            return Ok();
        }



        //PUT api/loans/1/loancomplete
        [HttpPut("{id}/finishloan")]
        public IActionResult FinishLoan(int id)
        {
            return Ok();
        }
    }
}
