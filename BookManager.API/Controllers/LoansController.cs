using BookManager.Application.Commands.FinishLoan;
using BookManager.Application.Commands.InsertLoan;
using BookManager.Application.Commands.UpdateLateLoan;
using BookManager.Application.Queries.GetAllLoan;
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
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllLoanQuery();
            var result = await _mediator.Send(query);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        //POST api/loans
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] InsertLoanCommand command)
        {
                var result = await _mediator.Send(command);

            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }

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
