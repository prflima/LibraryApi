using LibraryAPI.Application.Category.CreateCategoryUseCase;

namespace LibraryAPI.Application.Interfaces.Category
{
    public interface ICreateCategoryUseCase
    {
        Task<CreateCategoryResponseDto> ExecuteAsync(CreateCategoryCommand command, CancellationToken ct);
    }
}
