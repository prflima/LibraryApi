using LibraryAPI.Application.UseCases.BookLoans.CreateBookLoan;

namespace Library.Application.Interfaces.BookLoans
{
    public interface ICreateBookLoanUseCase
    {
        Task<CreateBookLoanResponseDto> ExecuteAsync(CreateBookLoanCommand command, CancellationToken ct);
    }
}
