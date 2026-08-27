using FluentValidation;
using LibraryAPI.Application.Interfaces.Author;
using LibraryAPI.Data;
using LibraryAPI.Mapping;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Application.Author.GetAuthorByIdUseCase
{
    public class GetAuthorByIdUseCase : IGetAuthorByIdUseCase
    {
        private readonly LibraryDbContext _context;
        private readonly IValidator<GetAuthorByIdCommand> _validator;

        public GetAuthorByIdUseCase(
            LibraryDbContext context,
            IValidator<GetAuthorByIdCommand> validator)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _validator = validator ?? throw new ArgumentNullException(nameof(validator));
        }

        public async Task<GetAuthorByIdResponseDto> ExecuteAsync(GetAuthorByIdCommand command, CancellationToken ct)
        {
            var validationResult = await _validator.ValidateAsync(command, ct);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }


            var author = await _context
                                    .Authors
                                    .FirstOrDefaultAsync(a => a.Id == command.Id);

            if (author == null)
            {
                throw new KeyNotFoundException($"Author with ID {command.Id} not found.");
            }

            return new GetAuthorByIdResponseDto { Author = author.ToDto() };
        }
    }
}
