using LibraryAPI.Enums;

namespace LibraryAPI.Domain
{
    public class BookLoan : Root
    {
        public Book Book { get; private set; }
        public User User { get; private set; }
        public DateTime LoanDate { get; private set; }
        public DateTime DueDate { get; private set; }
        public DateTime? ReturnDate { get; private set; }
        public LoanStatus Status { get; private set; }

        public BookLoan(Book book, User user, DateTime loanDate, DateTime dueDate)
        {
            Id = Guid.NewGuid();
            Book = book;
            User = user;
            CreatedAt = DateTime.Now;
            LoanDate = loanDate;
            DueDate = dueDate;
            Status = LoanStatus.Active;
        }

        public void ReturnLoan()
        {
            ReturnDate = DateTime.Now;
            Status = LoanStatus.Returned;


            Book.BookReturned();
        }

        public LoanStatus VerifyStatusLoan()
        {
            if (DateTime.Now > DueDate &&
                !ReturnDate.HasValue)
                Status = LoanStatus.Overdue;

            return Status;
        }
    }
}
