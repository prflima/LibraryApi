using LibraryAPI.Application.Dtos;

namespace LibraryAPI.Application.UseCases.Books.CreateBook
{
    public record CreateBookResponseDto
    {
        public BookDto Book { get; init; }
    }
}
