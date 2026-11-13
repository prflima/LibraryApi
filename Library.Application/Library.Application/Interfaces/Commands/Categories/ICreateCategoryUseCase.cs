using Library.Application.UseCases.Commands.Categories.CreateCategory;

namespace Library.Application.Interfaces.Commands.Categories
{
    public interface ICreateCategoryUseCase
    {
        Task<CreateCategoryResponseDto> ExecuteAsync(CreateCategoryCommand command, CancellationToken ct);
    }
}
