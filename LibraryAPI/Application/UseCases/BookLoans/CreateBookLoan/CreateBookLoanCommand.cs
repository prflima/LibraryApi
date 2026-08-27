namespace LibraryAPI.Application.UseCases.BookLoans.CreateBookLoan
{
    public record CreateBookLoanCommand
    {
        public Guid UserId { get; init; }
        public Guid BookId { get; init; }
        public DateTime LoanDate { get; init; }
        public DateTime? DueDate { get; init; }
    }
}
