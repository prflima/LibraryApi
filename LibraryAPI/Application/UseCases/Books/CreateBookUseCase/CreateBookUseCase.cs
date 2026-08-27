using FluentValidation;
using LibraryAPI.Application.Interfaces.Book;
using LibraryAPI.Application.Mapping;
using LibraryAPI.Domain.Interfaces.Repositories;

namespace LibraryAPI.Application.UseCases.Books.CreateBookUseCase
{
    public class CreateBookUseCase : ICreateBookUseCase
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IValidator<CreateBookCommand> _validator;
        public CreateBookUseCase(
            IAuthorRepository authorRepository,
            ICategoryRepository categoryRepository,
            IBookRepository bookRepository,
            IValidator<CreateBookCommand> validator)
        {
            _authorRepository = authorRepository ?? throw new ArgumentNullException(nameof(authorRepository));
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
            _bookRepository = bookRepository ?? throw new ArgumentNullException(nameof(bookRepository));
            _validator = validator ?? throw new ArgumentNullException(nameof(validator));
        }

        public async Task<CreateBookResponseDto> ExecuteAsync(CreateBookCommand command, CancellationToken ct)
        {
            var validationResult = await _validator.ValidateAsync(command, ct);
            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            if (await _authorRepository.GetByIdAsync(command.AuthorId, ct) is null)
                throw new ArgumentException($"The authorID {command.AuthorId} dont exist");

            if (await _categoryRepository.GetByIdAsync(command.CategoryId, ct) is null)
                throw new ArgumentException($"The categoryID`{command.CategoryId} dont exist");

            var book = command.ToEntity();

            await _bookRepository.CreateAsync(book, ct);
            await _bookRepository.SaveChangesAsync(ct);

            return new CreateBookResponseDto { Book = book.ToDto() };
        }
    }
}
