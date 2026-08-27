using LibraryAPI.Application.UseCases.Authors.CreateAuthorUseCase;

namespace LibraryAPI.Application.Interfaces.Author
{
    public interface ICreateAuthorUseCase 
    {
        Task<CreateAuthorResponseDto> ExecuteAsync(CreateAuthorCommand command, CancellationToken ct);
    }
}
