namespace LibraryAPI.Application.Books.CreateBookUseCase
{
    public record CreateBookCommand
    {
        public string Title { get; init; }
        public string ISBN { get; init; }
        public Guid CategoryId { get; init; }
        public Guid AuthorId { get; init; }
        public DateTime PublishedAt { get; init; }
        public int TotalQuantity { get; init; }
    }
}
