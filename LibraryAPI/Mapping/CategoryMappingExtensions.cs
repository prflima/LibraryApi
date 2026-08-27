using LibraryAPI.Application.Category.CreateCategoryUseCase;
using LibraryAPI.Application.Dtos;
using LibraryAPI.Domain.Entities;

namespace LibraryAPI.Mapping
{
    public static class CategoryMappingExtensions
    {
        public static Category ToEntity(this CreateCategoryCommand command)
        {
            return new Category(command.Name);
        }

        public static CategoryDto ToDto(this Category category)
        {
            return new CategoryDto
            {
                Id = category.Id.ToString(),
                Name = category.Name,
                CreatedAt = category.CreatedAt
            };
        }
    }
}
