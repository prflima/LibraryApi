using LibraryAPI.Application.Dtos;
using LibraryAPI.Application.UseCases.Categories.CreateCategory;

namespace LibraryAPI.Application.Mapping
{
    public static class CategoryMappingExtensions
    {
        public static Domain.Entities.Category ToEntity(this CreateCategoryCommand command)
        {
            return new Domain.Entities.Category(command.Name);
        }

        public static CategoryDto ToDto(this Domain.Entities.Category category)
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
