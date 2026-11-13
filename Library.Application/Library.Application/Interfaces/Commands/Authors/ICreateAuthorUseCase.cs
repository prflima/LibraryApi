using Library.Application.UseCases.Commands.Authors.CreateAuthor;

namespace Library.Application.Interfaces.Commands.Authors
{
    public interface ICreateAuthorUseCase 
    {
        Task<CreateAuthorResponseDto> ExecuteAsync(CreateAuthorCommand command, CancellationToken ct);
    }
}
