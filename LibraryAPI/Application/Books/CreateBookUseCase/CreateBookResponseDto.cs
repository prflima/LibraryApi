using LibraryAPI.Application.Dtos;

namespace LibraryAPI.Application.Books.CreateBookUseCase
{
    public record CreateBookResponseDto
    {
        public BookDto Book { get; init; }
    }
}
