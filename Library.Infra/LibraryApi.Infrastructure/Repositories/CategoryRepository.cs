using LibraryAPI.Domain.Entities;
using LibraryAPI.Domain.Interfaces.Repositories;
using LibraryAPI.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly LibraryDbContext _context;
        public CategoryRepository(
            LibraryDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task CreateAsync(Category category, CancellationToken ct)
        {
            await _context.Categories.AddAsync(category, ct);
        }

        public async Task<Category> GetByIdAsync(Guid Id, CancellationToken ct)
        {
            return await _context.Categories
                                 .FirstOrDefaultAsync(c => c.Id == Id, ct);
        }

        public async Task SaveChangesAsync(CancellationToken ct)
        {
            await _context.SaveChangesAsync(ct);
        }
    }
}
