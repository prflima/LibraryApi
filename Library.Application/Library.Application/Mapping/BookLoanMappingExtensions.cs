using LibraryAPI.Application.Dtos;
using LibraryAPI.Domain.Entities;

namespace LibraryAPI.Application.Mapping
{
    public static class BookLoanMappingExtensions
    {
        public static BookLoanDto ToDto(this BookLoan bookLoan)
        {
            return new BookLoanDto
            {
                Id = bookLoan.Id.ToString(),
                Book = bookLoan.Book.ToDto(),
                User = bookLoan.User.ToDto(),
                LoanDate = bookLoan.LoanDate,
                DueDate = bookLoan.LoanDate,
                ReturnDate = bookLoan.LoanDate,
                Status = bookLoan.Status,
            };
        }
    }
}
