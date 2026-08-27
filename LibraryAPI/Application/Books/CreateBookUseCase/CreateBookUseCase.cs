using FluentValidation;
using LibraryAPI.Application.Interfaces.Book;
using LibraryAPI.Data;
using LibraryAPI.Mapping;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Application.Books.CreateBookUseCase
{
    public class CreateBookUseCase : ICreateBookUseCase
    {
        private readonly LibraryDbContext _context;
        private readonly IValidator<CreateBookCommand> _validator;
        public CreateBookUseCase(
            LibraryDbContext context,
            IValidator<CreateBookCommand> validator)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _validator = validator ?? throw new ArgumentNullException(nameof(validator));
        }

        public async Task<CreateBookResponseDto> ExecuteAsync(CreateBookCommand command, CancellationToken ct)
        {
            var validationResult = await _validator.ValidateAsync(command, ct);
            if(!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var author = await _context.Authors
                                            .FirstOrDefaultAsync(a => a.Id == command.AuthorId, ct);

            if(author is null)
                throw new ArgumentException($"Author with Id {command.AuthorId} does not exist.");

            var category = await _context.Categories
                                            .FirstOrDefaultAsync(c => c.Id == command.CategoryId, ct);

            if(category is null)
                throw new ArgumentException($"Category with Id {command.CategoryId} does not exist.");

            var book = command.ToEntity();

            await _context.Books.AddAsync(book, ct);
            await _context.SaveChangesAsync(ct);

            return new CreateBookResponseDto { Book = book.ToDto() };
        }
    }
}
