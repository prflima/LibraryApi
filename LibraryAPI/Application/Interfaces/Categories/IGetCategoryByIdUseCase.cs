using LibraryAPI.Application.UseCases.Categories.GetCategoryById;

namespace LibraryAPI.Application.Interfaces.Category
{
    public interface IGetCategoryByIdUseCase
    {
        Task<GetCategoryByIdResponseDto> ExecuteAsync(GetCategoryByIdQuery command, CancellationToken ct);
    }
}
