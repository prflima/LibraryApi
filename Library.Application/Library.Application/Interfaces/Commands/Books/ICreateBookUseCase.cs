using Library.Application.UseCases.Commands.Books.CreateBook;

namespace Library.Application.Interfaces.Commands.Books
{
    public interface ICreateBookUseCase
    {
        Task<CreateBookResponseDto> ExecuteAsync(CreateBookCommand command, CancellationToken ct);
    }
}
