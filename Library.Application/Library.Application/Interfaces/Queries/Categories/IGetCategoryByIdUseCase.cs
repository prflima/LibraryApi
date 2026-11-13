using Library.Application.UseCases.Queries.Categories.GetCategoryById;

namespace Library.Application.Interfaces.Queries.Categories
{
    public interface IGetCategoryByIdUseCase
    {
        Task<GetCategoryByIdResponseDto> ExecuteAsync(GetCategoryByIdQuery command, CancellationToken ct);
    }
}
