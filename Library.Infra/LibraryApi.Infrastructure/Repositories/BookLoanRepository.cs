using LibraryAPI.Domain.Entities;
using LibraryAPI.Domain.Interfaces.Repositories;
using LibraryAPI.Infrastructure.Persistence;

namespace LibraryAPI.Infrastructure.Repositories
{
    public class BookLoanRepository : IBookLoanRepository
    {
        private readonly LibraryDbContext _context;

        public BookLoanRepository(
            LibraryDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task CreateAsync(BookLoan bookLoan, CancellationToken ct)
        {
            await _context.AddAsync(bookLoan, ct);
        }

        public async Task SaveChangesAsync(CancellationToken ct)
        {
            await _context.SaveChangesAsync(ct);
        }
    }
}
