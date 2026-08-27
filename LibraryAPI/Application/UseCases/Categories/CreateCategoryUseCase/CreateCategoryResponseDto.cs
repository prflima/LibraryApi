using LibraryAPI.Application.Dtos;

namespace LibraryAPI.Application.UseCases.Categories.CreateCategoryUseCase
{
    public record CreateCategoryResponseDto
    {
        public CategoryDto CategoryDto { get; init; }
    }
}
