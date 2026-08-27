using LibraryAPI.Application.Interfaces.Book;
using LibraryAPI.Application.UseCases.Books.CreateBook;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Presentation.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(
            [FromBody] CreateBookCommand command,
            [FromServices] ICreateBookUseCase useCase,
            CancellationToken ct)
        {
            var response = await useCase.ExecuteAsync(command, ct);
            //return CreatedAtAction(nameof(GetById), new { id = response.Book.Id }, response);
            return Ok(response);
        }
    }
}
