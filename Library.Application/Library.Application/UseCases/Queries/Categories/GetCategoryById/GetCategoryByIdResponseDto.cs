using LibraryAPI.Application.Dtos;

namespace Library.Application.UseCases.Queries.Categories.GetCategoryById
{
    public record GetCategoryByIdResponseDto
    {
        public CategoryDto CategoryDto { get; init; }
    }
}
