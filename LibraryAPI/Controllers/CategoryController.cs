using Library.Application.Interfaces.Commands.Categories;
using Library.Application.Interfaces.Queries.Categories;
using Library.Application.UseCases.Commands.Categories.CreateCategory;
using Library.Application.UseCases.Queries.Categories.GetCategoryById;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
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
