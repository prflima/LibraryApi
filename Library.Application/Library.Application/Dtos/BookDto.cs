namespace LibraryAPI.Application.Dtos
{
    public record BookDto
    {
        public string Id { get; init; }
        public string Title { get; init; }
        public string ISBN { get; init; }
        public CategoryDto Category { get; init; }
        public AuthorDto Author { get; init; }
        public int TotalQuantity { get; init; }
        public int AvailableQuantity { get; init; }
        public DateTime CreatedAt { get; init; }
    }
}
