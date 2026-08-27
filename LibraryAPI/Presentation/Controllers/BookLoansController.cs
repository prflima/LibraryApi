using LibraryAPI.Application.Interfaces.BookLoans;
using LibraryAPI.Application.UseCases.BookLoans.CreateBookLoan;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Presentation.Controllers
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
