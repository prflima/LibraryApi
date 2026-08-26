using LibraryAPI.Enums;

namespace LibraryAPI.Domain.Entities
{
    public class BookLoan : Root
    {
        public Guid? BookId { get; set; }
        public Book Book { get; private set; }
        public Guid? UserId { get; set; }
        public User User { get; private set; }
        public DateTime LoanDate { get; private set; }
        public DateTime DueDate { get; private set; }
        public DateTime? ReturnDate { get; private set; }
        public LoanStatus Status { get; private set; }

        public BookLoan(Guid? bookId, Guid? userId, DateTime loanDate, DateTime dueDate)
        {
            BookId = bookId;
            UserId = userId;
            LoanDate = loanDate;
            DueDate = dueDate;
            Status = LoanStatus.Active;
        }

        // Auxiliar constructor to create a BookLoan with Book and User objects
        public BookLoan(Book book, User user, DateTime loanDate, DateTime dueDate)
            : this(book?.Id, user?.Id, loanDate, dueDate)
        {
            Book = book;
            User = user;
        }

        public void ReturnLoan()
        {
            if (!ReturnDate.HasValue &&
                (Status == LoanStatus.Active ||
                 Status == LoanStatus.Overdue))
            {
                ReturnDate = DateTime.Now;
                Status = LoanStatus.Returned;

                Book.BookReturned();
            }                
        }

        public LoanStatus VerifyStatusAndMarkAsOverdue()
        {
            if (DateTime.Now > DueDate &&
                !ReturnDate.HasValue)
                Status = LoanStatus.Overdue;

            return Status;
        }
    }
}
