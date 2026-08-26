using LibraryAPI.Application.Author.CreateAuthorUseCase;
using LibraryAPI.Domain.Interfaces.Author;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("api/author")]
    public class AuthorsController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(
            [FromBody] CreateAuthorCommand command,
            [FromServices] ICreateAuthorUseCase useCase,
            CancellationToken ct)
        {
            var response = await useCase.ExecuteAsync(command, ct);
            return CreatedAtAction(nameof(Create), new { id = response.Id }, response);
        }
    }
}
