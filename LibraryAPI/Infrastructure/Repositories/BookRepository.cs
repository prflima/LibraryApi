using LibraryAPI.Domain.Entities;
using LibraryAPI.Domain.Interfaces.Repositories;
using LibraryAPI.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDbContext _context;
        public BookRepository(
            LibraryDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task CreateAsync(Book book, CancellationToken ct)
        {
            await _context.Books.AddAsync(book, ct);
        }

        public async Task<Book> GetBookAndCategoryByIdAsync(Guid id, CancellationToken ct)
        {
            return await _context.Books
                                 .Include(b => b.Category)
                                 .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Book> GetByIdAsync(Guid id, CancellationToken ct)
        {
            return await _context.Books
                                 .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task SaveChangesAsync(CancellationToken ct)
        {
            await _context.SaveChangesAsync(ct);
        }
    }
}
