using LibraryAPI.Application.Dtos;

namespace LibraryAPI.Application.Author.CreateAuthorUseCase
{
    public record CreateAuthorResponseDto
    {
        public AuthorDto Author { get; init; }
    }
}
