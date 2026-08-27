using LibraryAPI.Domain.Entities;

namespace LibraryAPI.Domain.Interfaces.Repositories
{
    public interface IAuthorRepository
    {
        Task CreateAsync(Author author, CancellationToken ct);
        Task<Author> GetById(Guid Id,  CancellationToken ct);
        Task SaveChangesAsync(CancellationToken ct);
    }
}
