using LibraryAPI.Domain.Entities;
using LibraryAPI.Domain.Interfaces.Repositories;
using LibraryAPI.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Infrastructure.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly LibraryDbContext _context;
        public AuthorRepository(
            LibraryDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task CreateAsync(Author author, CancellationToken ct)
        {
            await _context.Authors.AddAsync(author, ct);
        }

        public async Task<Author> GetById(Guid Id, CancellationToken ct)
        {
            return await _context.Authors
                                 .FirstOrDefaultAsync(author => author.Id == Id, ct);
        }

        public async Task SaveChangesAsync(CancellationToken ct)
        {
            await _context.SaveChangesAsync(ct);
        }
    }
}
