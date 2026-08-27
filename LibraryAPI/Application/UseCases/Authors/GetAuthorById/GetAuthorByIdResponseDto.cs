using LibraryAPI.Application.Dtos;

namespace LibraryAPI.Application.UseCases.Authors.GetAuthorById
{
    public record GetAuthorByIdResponseDto
    {
        public AuthorDto Author { get; init; }
    }
}
