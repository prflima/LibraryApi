using LibraryAPI.Domain.Entities;

namespace LibraryAPI.Domain.Interfaces.Repositories
{
    public interface IBookLoanRepository
    {
        Task CreateAsync(BookLoan bookLoan, CancellationToken ct);
        Task SaveChangesAsync(CancellationToken ct);
    }
}
