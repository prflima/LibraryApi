using LibraryAPI.Application.Dtos;

namespace LibraryAPI.Application.Author.GetAuthorByIdUseCase
{
    public record GetAuthorByIdResponseDto
    {
        public AuthorDto Author { get; init; }
    }
}
