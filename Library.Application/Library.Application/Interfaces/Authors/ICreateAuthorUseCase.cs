using LibraryAPI.Application.UseCases.Authors.CreateAuthor;

namespace Library.Application.Interfaces.Authors
{
    public interface ICreateAuthorUseCase 
    {
        Task<CreateAuthorResponseDto> ExecuteAsync(CreateAuthorCommand command, CancellationToken ct);
    }
}
