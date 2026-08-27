using LibraryAPI.Application.Dtos;

namespace LibraryAPI.Application.UseCases.Authors.GetAuthorByIdUseCase
{
    public record GetAuthorByIdResponseDto
    {
        public AuthorDto Author { get; init; }
    }
}
