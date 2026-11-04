using LibraryAPI.Application.UseCases.Books.CreateBook;

namespace Library.Application.Interfaces.Books
{
    public interface ICreateBookUseCase
    {
        Task<CreateBookResponseDto> ExecuteAsync(CreateBookCommand command, CancellationToken ct);
    }
}
