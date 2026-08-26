using LibraryAPI.Domain.Entities;

namespace LibraryAPI.Application.Category.GetCategoryByIdUseCase
{
    public record GetCategoryByIdResponseDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public IReadOnlyCollection<Book> Books { get; set; }
    }
}
