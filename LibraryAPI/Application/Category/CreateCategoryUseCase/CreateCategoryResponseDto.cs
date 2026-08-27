using LibraryAPI.Application.Dtos;

namespace LibraryAPI.Application.Category.CreateCategoryUseCase
{
    public record CreateCategoryResponseDto
    {
        public CategoryDto CategoryDto { get; init; }
    }
}
