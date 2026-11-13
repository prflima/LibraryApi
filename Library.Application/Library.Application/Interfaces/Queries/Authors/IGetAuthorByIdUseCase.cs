using Library.Application.UseCases.Queries.Authors.GetAuthorById;

namespace Library.Application.Interfaces.Queries.Authors
{
    public interface IGetAuthorByIdUseCase
    {
        Task<GetAuthorByIdResponseDto> ExecuteAsync(GetAuthorByIdQuery command, CancellationToken ct);
    }
}
