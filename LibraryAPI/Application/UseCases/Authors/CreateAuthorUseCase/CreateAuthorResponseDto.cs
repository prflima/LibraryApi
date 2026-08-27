using LibraryAPI.Application.Dtos;

namespace LibraryAPI.Application.UseCases.Authors.CreateAuthorUseCase
{
    public record CreateAuthorResponseDto
    {
        public AuthorDto Author { get; init; }
    }
}
