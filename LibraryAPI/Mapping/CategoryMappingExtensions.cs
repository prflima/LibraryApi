using LibraryAPI.Application.Category.CreateCategoryUseCase;
using LibraryAPI.Application.Category.GetCategoryByIdUseCase;
using LibraryAPI.Domain.Entities;

namespace LibraryAPI.Mapping
{
    public static class CategoryMappingExtensions
    {
        public static Category ToEntity(this CreateCategoryCommand command)
        {
            return new Category(command.Name);
        }

        public static CreateCategoryResponseDto ToDto(this Category category)
        {
            return new CreateCategoryResponseDto
            {
                Id = category.Id.ToString(),
                Name = category.Name,
                CreatedAt = category.CreatedAt
            };
        }

        public static GetCategoryByIdResponseDto ToGetByIdDto(this Category category)
        {
            return new GetCategoryByIdResponseDto
            {
                Id = category.Id.ToString(),
                Name = category.Name,
                CreatedAt = category.CreatedAt,
                Books = category.Books
            };
        }
    }
}
