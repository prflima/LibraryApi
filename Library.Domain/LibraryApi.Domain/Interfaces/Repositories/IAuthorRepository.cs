using LibraryAPI.Domain.Entities;

namespace LibraryAPI.Domain.Interfaces.Repositories
{
    public interface IAuthorRepository
    {
        Task CreateAsync(Author author, CancellationToken ct);
        Task<Author> GetByIdAsync(Guid Id,  CancellationToken ct);
        Task SaveChangesAsync(CancellationToken ct);
    }
}
