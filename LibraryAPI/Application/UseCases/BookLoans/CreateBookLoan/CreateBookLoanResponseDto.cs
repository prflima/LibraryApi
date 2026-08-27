using LibraryAPI.Application.Dtos;

namespace LibraryAPI.Application.UseCases.BookLoans.CreateBookLoan
{
    public record CreateBookLoanResponseDto
    {
        public BookLoanDto Loan { get; init; }
    }
}
