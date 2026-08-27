using LibraryAPI.Application.Interfaces.Category;
using LibraryAPI.Application.UseCases.Categories.CreateCategoryUseCase;
using LibraryAPI.Application.UseCases.Categories.GetCategoryByIdUseCase;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Presentation.Controllers
{
    [ApiController]
    [Route("api/category")]
    public class CategoryController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(
            [FromBody] CreateCategoryCommand command,
            [FromServices] ICreateCategoryUseCase useCase,
            CancellationToken ct)
        {
            var response = await useCase.ExecuteAsync(command, ct);
            return CreatedAtAction(nameof(GetById), new { id = response.CategoryDto.Id }, response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(
            [FromRoute] Guid id,
            [FromServices] IGetCategoryByIdUseCase useCase,
            CancellationToken ct)
        {
            var command = new GetCategoryByIdQuery(id);
            var response = await useCase.ExecuteAsync(command, ct);
            return Ok(response);
        }
    }
}
