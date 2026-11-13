using LibraryAPI.Application.Dtos;

namespace Library.Application.UseCases.Commands.Books.CreateBook
{
    public record CreateBookResponseDto
    {
        public BookDto Book { get; init; }
    }
}
