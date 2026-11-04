using LibraryAPI.Domain.Entities;

namespace LibraryAPI.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task CreateAsync(User user, CancellationToken ct);
        Task<User> GetByEmailAsync(string email, CancellationToken ct);
        Task<User> GetByIdAsync(Guid userId, CancellationToken ct);
        Task SaveChangesAsync(CancellationToken ct);
    }
}
