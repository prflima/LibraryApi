namespace LibraryAPI.Application.Dtos
{
    public record AuthorDto
    {
        public string Id { get; init; }
        public string Name { get; init; }
        public DateTime CreatedAt { get; init; }
    }
}
