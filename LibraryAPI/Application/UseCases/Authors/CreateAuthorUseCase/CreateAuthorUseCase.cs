using FluentValidation;
using LibraryAPI.Application.Interfaces.Author;
using LibraryAPI.Application.Mapping;
using LibraryAPI.Infrastructure;

namespace LibraryAPI.Application.UseCases.Authors.CreateAuthorUseCase
{
    public class CreateAuthorUseCase : ICreateAuthorUseCase
    {
        private readonly LibraryDbContext _context;
        private readonly IValidator<CreateAuthorCommand> _validator;
        public CreateAuthorUseCase(
            LibraryDbContext context,
            IValidator<CreateAuthorCommand> validator)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _validator = validator ?? throw new ArgumentNullException(nameof(validator));
        }
        public async Task<CreateAuthorResponseDto> ExecuteAsync(CreateAuthorCommand command, CancellationToken ct)
        {
            var validationResult = await _validator.ValidateAsync(command, ct);
            if(!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var author = command.ToEntity();

            await _context.Authors.AddAsync(author);
            await _context.SaveChangesAsync(ct);

            return new CreateAuthorResponseDto { Author = author.ToDto() };
        }
    }
}
