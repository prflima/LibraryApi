using LibraryAPI.Application.Author.CreateAuthorUseCase;
using LibraryAPI.Application.Dtos;
using LibraryAPI.Domain.Entities;

namespace LibraryAPI.Mapping
{
    public static class AuthorMappingExtensions
    {
        public static Author ToEntity(this CreateAuthorCommand command)
        {
            return new Author(command.Name);
        }

        public static AuthorDto ToDto(this Author author)
        {
            return new AuthorDto
            {
                Id = author.Id.ToString(),
                Name = author.Name,
                CreatedAt = author.CreatedAt
            };
        }
    }
}
