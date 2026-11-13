using LibraryAPI.Application.Dtos;

namespace Library.Application.UseCases.Commands.Categories.CreateCategory
{
    public record CreateCategoryResponseDto
    {
        public CategoryDto CategoryDto { get; init; }
    }
}
