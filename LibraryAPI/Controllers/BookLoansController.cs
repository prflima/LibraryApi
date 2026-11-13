using Library.Application.Interfaces.Commands.BookLoans;
using Library.Application.UseCases.Commands.BookLoans.CreateBookLoan;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("api/loans")]
    public class BookLoansController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(
            [FromBody] CreateBookLoanCommand command,
            [FromServices] ICreateBookLoanUseCase _useCase,
            CancellationToken ct = default)
        {
            var response = await _useCase.ExecuteAsync(command, ct);
            return Ok(response);
        }
    }
}
