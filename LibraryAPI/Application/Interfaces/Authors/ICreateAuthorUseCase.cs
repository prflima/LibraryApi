using LibraryAPI.Application.UseCases.Authors.CreateAuthor;

namespace LibraryAPI.Application.Interfaces.Author
{
    public interface ICreateAuthorUseCase 
    {
        Task<CreateAuthorResponseDto> ExecuteAsync(CreateAuthorCommand command, CancellationToken ct);
    }
}
