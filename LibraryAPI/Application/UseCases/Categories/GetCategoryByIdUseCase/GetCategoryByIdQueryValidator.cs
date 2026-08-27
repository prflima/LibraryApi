using FluentValidation;

namespace LibraryAPI.Application.UseCases.Categories.GetCategoryByIdUseCase
{
    public class GetCategoryByIdQueryValidator : AbstractValidator<GetCategoryByIdQuery>
    {
        public GetCategoryByIdQueryValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Id is required.")
                .Must(id => id != Guid.Empty)
                .WithMessage("Id cannot be an empty GUID.");
        }
    }
}
