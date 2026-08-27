using LibraryAPI.Application.Interfaces.Author;
using LibraryAPI.Application.UseCases.Authors.CreateAuthorUseCase;
using LibraryAPI.Application.UseCases.Authors.GetAuthorByIdUseCase;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Presentation.Controllers
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
            return CreatedAtAction(nameof(GetById), new { id = response.Author.Id }, response);
        }

        [HttpGet("{guid}")]
        public async Task<IActionResult> GetById(
            [FromRoute] Guid guid,
            [FromServices] IGetAuthorByIdUseCase useCase,
            CancellationToken ct)
        {
            var command = new GetAuthorByIdQuery(guid);
            var response = await useCase.ExecuteAsync(command, ct);
            return Ok(response);
        }
    }
}
