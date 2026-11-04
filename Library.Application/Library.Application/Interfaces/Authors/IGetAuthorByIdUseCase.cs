using LibraryAPI.Application.UseCases.Authors.GetAuthorById;

namespace Library.Application.Interfaces.Authors
{
    public interface IGetAuthorByIdUseCase
    {
        Task<GetAuthorByIdResponseDto> ExecuteAsync(GetAuthorByIdQuery command, CancellationToken ct);
    }
}
