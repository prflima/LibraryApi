using LibraryAPI.Domain.Entities;

namespace LibraryAPI.Domain.Interfaces.Repositories
{
    public interface IBookRepository
    {
        Task CreateAsync(Book book, CancellationToken ct);
        Task SaveChangesAsync(CancellationToken ct);
    }
}
