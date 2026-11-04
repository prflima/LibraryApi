using LibraryAPI.Application.UseCases.Categories.GetCategoryById;

namespace Library.Application.Interfaces.Categories
{
    public interface IGetCategoryByIdUseCase
    {
        Task<GetCategoryByIdResponseDto> ExecuteAsync(GetCategoryByIdQuery command, CancellationToken ct);
    }
}
