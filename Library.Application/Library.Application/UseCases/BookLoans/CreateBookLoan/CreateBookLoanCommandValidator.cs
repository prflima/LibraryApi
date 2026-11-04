using FluentValidation;

namespace LibraryAPI.Application.UseCases.BookLoans.CreateBookLoan
{
    public class CreateBookLoanCommandValidator : AbstractValidator<CreateBookLoanCommand>
    {
        public CreateBookLoanCommandValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .WithMessage("The UserId is required")
                .Must(id => id != Guid.Empty)
                .WithMessage("The userId cannot be an empty GUID");

            RuleFor(x => x.BookId)
                .NotEmpty()
                .WithMessage("The BookId is required")
                .Must(id => id != Guid.Empty)
                .WithMessage("The BookId cannot be an empty GUID");

            RuleFor(x => x.LoanDate)
                .NotEmpty()
                .WithMessage("LoanDate is required")
                .GreaterThanOrEqualTo(DateTime.Now)
                .WithMessage("LoanDate cannot be in the past");
        }
    }
}
