using LibraryAPI.Application.Interfaces.Users;
using LibraryAPI.Application.UseCases.Users.CreateUserUseCase;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Presentation.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(
            [FromBody] CreateUserCommand command,
            [FromServices] ICreateUserUseCase _useCase,
            CancellationToken ct)
        {
            var response = await _useCase.ExecuteAsync(command, ct);
            return Ok(response);
        }
    }
}
