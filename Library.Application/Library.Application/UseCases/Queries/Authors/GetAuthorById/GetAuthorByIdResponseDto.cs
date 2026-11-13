using LibraryAPI.Application.Dtos;

namespace Library.Application.UseCases.Queries.Authors.GetAuthorById
{
    public record GetAuthorByIdResponseDto
    {
        public AuthorDto Author { get; init; }
    }
}
