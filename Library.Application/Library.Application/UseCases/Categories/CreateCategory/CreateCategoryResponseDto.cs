using LibraryAPI.Application.Dtos;

namespace LibraryAPI.Application.UseCases.Categories.CreateCategory
{
    public record CreateCategoryResponseDto
    {
        public CategoryDto CategoryDto { get; init; }
    }
}
