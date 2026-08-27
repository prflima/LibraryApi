using FluentValidation;
using LibraryAPI.Application.Interfaces.BookLoans;
using LibraryAPI.Application.Mapping;
using LibraryAPI.Domain.Interfaces.Repositories;

namespace LibraryAPI.Application.UseCases.BookLoans.CreateBookLoan
{
    public class CreateBookLoanUseCase : ICreateBookLoanUseCase
    {
        private readonly IUserRepository _userRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IBookLoanRepository _bookLoanRepository;
        private readonly IValidator<CreateBookLoanCommand> _validator;

        public CreateBookLoanUseCase(
            IUserRepository userRepository,
            IBookRepository bookRepository,
            IBookLoanRepository bookLoanRepository,
            IValidator<CreateBookLoanCommand> validator)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _bookRepository = bookRepository ?? throw new ArgumentNullException(nameof(_bookRepository));
            _bookLoanRepository = bookLoanRepository ?? throw new ArgumentNullException(nameof(bookLoanRepository));
            _validator = validator ?? throw new ArgumentNullException(nameof(validator));
        }

        public async Task<CreateBookLoanResponseDto> ExecuteAsync(CreateBookLoanCommand command, CancellationToken ct)
        {
            var validationResult = await _validator.ValidateAsync(command, ct);
            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var user = await _userRepository.GetByIdAsync(command.UserId, ct);
            if (user is null)
                throw new ArgumentException($"The UserId {command.UserId} is not found");

            var book = await _bookRepository.GetBookAndCategoryByIdAsync(command.BookId, ct);
            if (book is null)
                throw new ArgumentException($"The BookId {command.BookId} is not found");

            var bookLoan = book.Borrow
                                    (user,
                                    command.LoanDate,
                                    command.DueDate.HasValue
                                    ? command.DueDate.Value
                                    : DateTime.Now.AddDays(7));

            await _bookLoanRepository.CreateAsync(bookLoan, ct);
            await _bookLoanRepository.SaveChangesAsync(ct);

            return new CreateBookLoanResponseDto { Loan = bookLoan.ToDto() };
        }
    }
}
