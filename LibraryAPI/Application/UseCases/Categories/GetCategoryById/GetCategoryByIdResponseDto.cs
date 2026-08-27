using LibraryAPI.Application.Dtos;

namespace LibraryAPI.Application.UseCases.Categories.GetCategoryById
{
    public record GetCategoryByIdResponseDto
    {
        public CategoryDto CategoryDto { get; init; }
    }
}
