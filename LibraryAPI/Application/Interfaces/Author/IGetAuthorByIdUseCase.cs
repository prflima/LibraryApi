using LibraryAPI.Application.Author.GetAuthorByIdUseCase;

namespace LibraryAPI.Application.Interfaces.Author
{
    public interface IGetAuthorByIdUseCase
    {
        Task<GetAuthorByIdResponseDto> ExecuteAsync(GetAuthorByIdCommand command, CancellationToken ct);
    }
}
