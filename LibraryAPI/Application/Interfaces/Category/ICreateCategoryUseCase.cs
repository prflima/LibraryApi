using LibraryAPI.Application.UseCases.Categories.CreateCategoryUseCase;

namespace LibraryAPI.Application.Interfaces.Category
{
    public interface ICreateCategoryUseCase
    {
        Task<CreateCategoryResponseDto> ExecuteAsync(CreateCategoryCommand command, CancellationToken ct);
    }
}
