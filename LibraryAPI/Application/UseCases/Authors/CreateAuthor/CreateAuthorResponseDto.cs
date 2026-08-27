using LibraryAPI.Application.Dtos;

namespace LibraryAPI.Application.UseCases.Authors.CreateAuthor
{
    public record CreateAuthorResponseDto
    {
        public AuthorDto Author { get; init; }
    }
}
