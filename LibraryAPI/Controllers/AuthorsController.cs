using Library.Application.Interfaces.Commands.Authors;
using Library.Application.Interfaces.Queries.Authors;
using Library.Application.UseCases.Commands.Authors.CreateAuthor;
using Library.Application.UseCases.Queries.Authors.GetAuthorById;
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
            [FromServices] ICreateAuthorUseCase _useCase,
            CancellationToken ct)
        {
            var response = await _useCase.ExecuteAsync(command, ct);
            return CreatedAtAction(nameof(GetById), new { id = response.Author.Id }, response);
        }

        [HttpGet("{guid}")]
        public async Task<IActionResult> GetById(
            [FromRoute] Guid guid,
            [FromServices] IGetAuthorByIdUseCase _useCase,
            CancellationToken ct)
        {
            var command = new GetAuthorByIdQuery(guid);
            var response = await _useCase.ExecuteAsync(command, ct);
            return Ok(response);
        }

        //[HttpPut("{guid}")]
        //public async Task<IActionResult> Update(
        //    [FromRoute] Guid guid,
        //    [FromBody] UpdateAuthorCommand command,
        //    [FromServices] IUpdateAuthorUseCase _useCase,
        //    CancellationToken ct)
        //{
        //    command.Id = guid;
        //    var response = await _useCase.ExecuteAsync(command, ct);
        //    return Ok(response);
        //}
    }
}
