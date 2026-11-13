using LibraryAPI.Application.Dtos;

namespace Library.Application.UseCases.Commands.BookLoans.CreateBookLoan
{
    public record CreateBookLoanResponseDto
    {
        public BookLoanDto Loan { get; init; }
    }
}
