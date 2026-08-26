using LibraryAPI.Application.Author.CreateAuthorUseCase;
using LibraryAPI.Domain.Entities;

namespace LibraryAPI.Mapping
{
    public static class AuthorMappingExtensions
    {
        public static Author ToEntity(this CreateAuthorCommand command)
        {
            return new Author(command.Name);
        }

        public static CreateAuthorResponseDto ToDto(this Author author)
        {
            return new CreateAuthorResponseDto
            {
                Id = author.Id.ToString(),
                Name = author.Name,
                CreatedAt = author.CreatedAt
            };
        }
    }
}
