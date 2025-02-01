using BookManager.Application.Commands.FinishLoan;
using BookManager.Application.Commands.InsertLoan;
using BookManager.Application.Commands.UpdateLateLoan;
using BookManager.Core.Enums;
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

        //TODO
        //GETALL LOANS

        //POST api/loans
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] InsertLoanCommand command)
        {
                await _mediator.Send(command);
                return NoContent();
        }

        //PUT api/loans/1/loancomplete
        [HttpPut("{id}/finishloan")]
        public async Task<IActionResult> FinishLoan(int id)
        {
            var command = new FinishLoanCommand (id);
            var result = await _mediator.Send(command);

            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }

            return NoContent();
        }



        //VERIFICA SE O LOAN ESTÁ ATRASADO
        [HttpPut("{id}/lateloan")]
        public async Task<IActionResult> UpdateLateLoan(int id)
        {
            var command = new UpdateLateLoanCommand(id);
            var result = await _mediator.Send(command);

            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }

            return NoContent();
        }
    }
}
