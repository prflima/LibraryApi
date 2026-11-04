using LibraryAPI.Application.Dtos;
using LibraryAPI.Application.UseCases.Authors.CreateAuthor;

namespace LibraryAPI.Application.Mapping
{
    public static class AuthorMappingExtensions
    {
        public static Domain.Entities.Author ToEntity(this CreateAuthorCommand command)
        {
            return new Domain.Entities.Author(command.Name);
        }

        public static AuthorDto ToDto(this Domain.Entities.Author author)
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
