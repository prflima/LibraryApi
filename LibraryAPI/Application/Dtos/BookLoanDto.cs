using LibraryAPI.Domain.Enums;

namespace LibraryAPI.Application.Dtos
{
    public record BookLoanDto
    {
        public string Id { get; init; }
        public BookDto Book { get; init; }
        public UserDto User { get; init; }
        public DateTime LoanDate { get; init; }
        public DateTime DueDate { get; init; }
        public DateTime? ReturnDate { get; init; }
        public LoanStatus Status { get; init; }
    }
}
