using LibraryAPI.Application.Books.CreateBookUseCase;
using LibraryAPI.Application.Dtos;
using LibraryAPI.Domain.Entities;

namespace LibraryAPI.Mapping
{
    public static  class BookMappingExtensions
    {
        public static Book ToEntity(this CreateBookCommand command)
        {
            return new Book(
                title: command.Title,
                ISBN: command.ISBN,
                categoryId: command.CategoryId,
                authorId: command.AuthorId,
                publishedAt: command.PublishedAt,
                totalQuantity: command.TotalQuantity
            );
        }

        public static BookDto ToDto(this Book book)
        {
            return new BookDto
            {
                Id = book.Id.ToString(),
                Title = book.Title,
                Author = book.Author?.ToDto(),
                Category = book.Category?.ToDto(),
                CreatedAt = book.CreatedAt
            };
        }
    }
}
