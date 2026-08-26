using FluentValidation;

namespace LibraryAPI.Application.Author.GetAuthorByIdUseCase
{
    public class GetAuthorByIdCommandValidator : AbstractValidator<GetAuthorByIdCommand>
    {
        public GetAuthorByIdCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Id is required.")
                .Must(id => id != Guid.Empty)
                .WithMessage("Id cannot be an empty GUID.");
        }
    }
}
