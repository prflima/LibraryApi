using LibraryAPI.Application.Books.CreateBookUseCase;

namespace LibraryAPI.Application.Interfaces.Book
{
    public interface ICreateBookUseCase
    {
        Task<CreateBookResponseDto> ExecuteAsync(CreateBookCommand command, CancellationToken ct);
    }
}
