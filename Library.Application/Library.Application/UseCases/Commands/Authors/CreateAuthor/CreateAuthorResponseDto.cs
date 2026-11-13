using LibraryAPI.Application.Dtos;

namespace Library.Application.UseCases.Commands.Authors.CreateAuthor
{
    public record CreateAuthorResponseDto
    {
        public AuthorDto Author { get; init; }
    }
}
