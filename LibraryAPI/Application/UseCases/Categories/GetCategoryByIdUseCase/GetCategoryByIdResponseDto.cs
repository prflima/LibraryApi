using LibraryAPI.Application.Dtos;

namespace LibraryAPI.Application.UseCases.Categories.GetCategoryByIdUseCase
{
    public record GetCategoryByIdResponseDto
    {
        public CategoryDto CategoryDto { get; init; }
    }
}
