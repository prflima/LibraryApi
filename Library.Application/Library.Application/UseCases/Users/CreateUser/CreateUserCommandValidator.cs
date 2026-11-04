using FluentValidation;

namespace LibraryAPI.Application.UseCases.Users.CreateUser
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(u => u.Name)
                .NotEmpty()
                .WithMessage("The name is required")
                .MaximumLength(100)
                .WithMessage("The name must not exceed 100 characters");

            RuleFor(u => u.Email)
                .NotEmpty()
                .WithMessage("Email is required")
                .EmailAddress()
                .WithMessage("A valid email address is required");

            RuleFor(u => u.UserType)
                .NotEmpty()
                .WithMessage("User type is required");
        }
    }
}
