using FluentValidation;

namespace LibraryAPI.Application.UseCases.Authors.GetAuthorById
{
    public class GetAuthorByIdQueryValidator : AbstractValidator<GetAuthorByIdQuery>
    {
        public GetAuthorByIdQueryValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Id is required.")
                .Must(id => id != Guid.Empty)
                .WithMessage("Id cannot be an empty GUID.");
        }
    }
}
