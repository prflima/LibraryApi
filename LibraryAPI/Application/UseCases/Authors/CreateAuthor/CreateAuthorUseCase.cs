using FluentValidation;
using LibraryAPI.Application.Interfaces.Author;
using LibraryAPI.Application.Mapping;
using LibraryAPI.Domain.Interfaces.Repositories;

namespace LibraryAPI.Application.UseCases.Authors.CreateAuthor
{
    public class CreateAuthorUseCase : ICreateAuthorUseCase
    {
        private readonly IAuthorRepository _repository;
        private readonly IValidator<CreateAuthorCommand> _validator;
        public CreateAuthorUseCase(
            IAuthorRepository repository,
            IValidator<CreateAuthorCommand> validator)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
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

            await _repository.CreateAsync(author, ct);
            await _repository.SaveChangesAsync(ct);

            return new CreateAuthorResponseDto { Author = author.ToDto() };
        }
    }
}
