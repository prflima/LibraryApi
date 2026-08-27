using LibraryAPI.Domain.Entities;
using LibraryAPI.Domain.Interfaces.Repositories;
using LibraryAPI.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly LibraryDbContext _context;
        public UserRepository(
            LibraryDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task CreateAsync(User user, CancellationToken ct)
        {
            await _context.Users.AddAsync(user, ct);
        }

        public async Task<User> GetByEmailAsync(string email, CancellationToken ct)
        {
            return await _context.Users
                                 .FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User> GetByIdAsync(Guid userId, CancellationToken ct)
        {
            return await _context.Users
                                 .FirstOrDefaultAsync(u => u.Id == userId);
        }

        public async Task SaveChangesAsync(CancellationToken ct)
        {
            await _context.SaveChangesAsync(ct);
        }
    }
}
