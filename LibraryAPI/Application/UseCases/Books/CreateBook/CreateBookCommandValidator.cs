using FluentValidation;

namespace LibraryAPI.Application.UseCases.Books.CreateBook
{
    public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
    {
        public CreateBookCommandValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("Title is required.")
                .MaximumLength(80)
                .WithMessage("Title cannot exceed 80 characters.");

            RuleFor(x => x.ISBN)
                .NotEmpty()
                .WithMessage("ISBN is required.")
                .MaximumLength(13)
                .WithMessage("ISBN cannot exceed 13 characters.");

            RuleFor(x => x.CategoryId)
                .NotEmpty()
                .WithMessage("CategoryId is required.")
                .Must(id => id != Guid.Empty)
                .WithMessage("CategoryId cannot be an empty GUID.");

            RuleFor(x => x.AuthorId)
                .NotEmpty()
                .WithMessage("AuthorId is required.")
                .Must(id => id != Guid.Empty)
                .WithMessage("AuthorId cannot be an empty GUID.");

            RuleFor(x => x.TotalQuantity)
                .GreaterThan(0)
                .WithMessage("TotalQuantity must be greater than 0.");
        }
    }
}
