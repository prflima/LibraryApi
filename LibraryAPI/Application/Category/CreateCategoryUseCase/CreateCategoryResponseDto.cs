namespace LibraryAPI.Application.Category.CreateCategoryUseCase
{
    public record CreateCategoryResponseDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
