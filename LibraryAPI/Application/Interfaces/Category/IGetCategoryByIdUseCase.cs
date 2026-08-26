using LibraryAPI.Application.Category.GetCategoryByIdUseCase;

namespace LibraryAPI.Application.Interfaces.Category
{
    public interface IGetCategoryByIdUseCase
    {
        Task<GetCategoryByIdResponseDto> ExecuteAsync(GetCategoryByIdCommand command, CancellationToken ct);
    }
}
