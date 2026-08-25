namespace LibraryAPI.Domain
{
    public class Book : Root
    {
        public string Title { get; private set; }
        public string ISBN { get; private set; }
        public DateTime PublishedAt { get; private set; }
        public Category Category { get; private set; }
        public Author Author { get; private set; }
        public int TotalQuantity { get; private set; }
        public int AvailableQuantity { get; private set; }

        public Book(string title, string isbn, DateTime publishedAt, Category category,
                        Author author, int totalQuantity, int availableQuantity)
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
            Title = title;
            ISBN = isbn;
            Category = category;
            Author = author;
            PublishedAt = publishedAt;
            TotalQuantity = totalQuantity;
            AvailableQuantity = availableQuantity;
        }

        public BookLoan Borrow(User user)
        {
            if (AvailableQuantity <= 0)
                throw new InvalidOperationException
                    ("This book is not available");

            BookLoan result = new BookLoan(this, user, DateTime.Now, DateTime.Now.AddDays(5));

            AvailableQuantity--;

            return result;
        }

        public void BookReturned()
        {
            AvailableQuantity++;
        }
    }
}
