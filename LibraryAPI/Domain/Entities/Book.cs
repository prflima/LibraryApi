namespace LibraryAPI.Domain.Entities
{
    public class Book : Root
    {
        public string Title { get; private set; }
        public string ISBN { get; private set; }
        public DateTime PublishedAt { get; private set; }
        public Guid? CategoryId { get; set; }
        public Category Category { get; private set; }
        public Guid? AuthorId { get; set; }
        public Author Author { get; private set; }
        public int TotalQuantity { get; private set; }
        public int AvailableQuantity { get; private set; }
        public IReadOnlyCollection<BookLoan> Loans { get; set; }

        public Book(string title, string ISBN, DateTime publishedAt, Guid? categoryId,
                        Guid? authorId, int totalQuantity)
        {
            Title = title;
            this.ISBN = ISBN;
            CategoryId = categoryId;
            AuthorId = authorId;
            PublishedAt = publishedAt;
            TotalQuantity = totalQuantity;
            AvailableQuantity = totalQuantity;
        }

        public BookLoan Borrow(User user, DateTime loanDate, DateTime dueDate)
        {
            if (AvailableQuantity <= 0 ||
                AvailableQuantity > TotalQuantity)
                throw new InvalidOperationException
                    ("This book is not available");

            BookLoan result = new BookLoan
                                    (this,
                                    user,
                                    loanDate, 
                                    dueDate);

            AvailableQuantity--;

            return result;
        }

        public void BookReturned()
        {
            AvailableQuantity++;
        }
    }
}
