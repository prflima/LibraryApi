using LibraryAPI.Domain.Entities;

namespace LibraryAPI.Domain.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        Task CreateAsync(Category category, CancellationToken ct);
        Task<Category> GetByIdAsync(Guid Id,  CancellationToken ct);
        Task SaveChangesAsync(CancellationToken ct);
    }
}
