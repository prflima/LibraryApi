using FluentValidation;

namespace LibraryAPI.Application.UseCases.Authors.CreateAuthor
{
    public class CreateAuthorCommandValidator : AbstractValidator<CreateAuthorCommand>
    {
        public CreateAuthorCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name is required.")
                .MaximumLength(80)
                .WithMessage("Name cannot exceed 80 characters.");
        }
    }
}
