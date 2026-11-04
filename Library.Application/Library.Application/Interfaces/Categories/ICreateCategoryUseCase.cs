using LibraryAPI.Application.UseCases.Categories.CreateCategory;

namespace Library.Application.Interfaces.Categories
{
    public interface ICreateCategoryUseCase
    {
        Task<CreateCategoryResponseDto> ExecuteAsync(CreateCategoryCommand command, CancellationToken ct);
    }
}
