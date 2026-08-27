using LibraryAPI.Application.UseCases.Authors.GetAuthorByIdUseCase;

namespace LibraryAPI.Application.Interfaces.Author
{
    public interface IGetAuthorByIdUseCase
    {
        Task<GetAuthorByIdResponseDto> ExecuteAsync(GetAuthorByIdQuery command, CancellationToken ct);
    }
}
