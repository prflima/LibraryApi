using LibraryAPI.Application.UseCases.Books.CreateBook;

namespace LibraryAPI.Application.Interfaces.Book
{
    public interface ICreateBookUseCase
    {
        Task<CreateBookResponseDto> ExecuteAsync(CreateBookCommand command, CancellationToken ct);
    }
}
