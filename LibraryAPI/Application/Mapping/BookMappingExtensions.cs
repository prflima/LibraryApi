using LibraryAPI.Application.Dtos;
using LibraryAPI.Application.UseCases.Books.CreateBook;
using LibraryAPI.Domain.Entities;

namespace LibraryAPI.Application.Mapping
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
                ISBN = book.ISBN, 
                Author = book.Author?.ToDto(),
                Category = book.Category?.ToDto(),
                CreatedAt = book.CreatedAt
            };
        }
    }
}
