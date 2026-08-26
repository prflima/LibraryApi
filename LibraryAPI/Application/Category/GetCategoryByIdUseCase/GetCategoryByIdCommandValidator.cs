using FluentValidation;

namespace LibraryAPI.Application.Category.GetCategoryByIdUseCase
{
    public class GetCategoryByIdCommandValidator : AbstractValidator<GetCategoryByIdCommand>
    {
        public GetCategoryByIdCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Id is required.")
                .Must(id => id != Guid.Empty)
                .WithMessage("Id cannot be an empty GUID.");
        }
    }
}
