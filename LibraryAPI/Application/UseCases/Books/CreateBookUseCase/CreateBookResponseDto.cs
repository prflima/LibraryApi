using LibraryAPI.Application.Dtos;

namespace LibraryAPI.Application.UseCases.Books.CreateBookUseCase
{
    public record CreateBookResponseDto
    {
        public BookDto Book { get; init; }
    }
}
