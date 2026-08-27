using LibraryAPI.Application.Dtos;

namespace LibraryAPI.Application.Category.GetCategoryByIdUseCase
{
    public record GetCategoryByIdResponseDto
    {
        public CategoryDto CategoryDto { get; init; }
    }
}
