using Library.Application.UseCases.Commands.BookLoans.CreateBookLoan;

namespace Library.Application.Interfaces.Commands.BookLoans
{
    public interface ICreateBookLoanUseCase
    {
        Task<CreateBookLoanResponseDto> ExecuteAsync(CreateBookLoanCommand command, CancellationToken ct);
    }
}
