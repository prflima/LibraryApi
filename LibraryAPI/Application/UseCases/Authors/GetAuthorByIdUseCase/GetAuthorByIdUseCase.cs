using FluentValidation;
using LibraryAPI.Application.Interfaces.Author;
using LibraryAPI.Application.Mapping;
using LibraryAPI.Domain.Interfaces.Repositories;

namespace LibraryAPI.Application.UseCases.Authors.GetAuthorByIdUseCase
{
    public class GetAuthorByIdUseCase : IGetAuthorByIdUseCase
    {
        private readonly IAuthorRepository _repository;
        private readonly IValidator<GetAuthorByIdQuery> _validator;

        public GetAuthorByIdUseCase(
            IAuthorRepository repository,
            IValidator<GetAuthorByIdQuery> validator)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _validator = validator ?? throw new ArgumentNullException(nameof(validator));
        }

        public async Task<GetAuthorByIdResponseDto> ExecuteAsync(GetAuthorByIdQuery command, CancellationToken ct)
        {
            var validationResult = await _validator.ValidateAsync(command, ct);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var author = await _repository.GetByIdAsync(command.Id, ct);

            if (author == null)
            {
                throw new KeyNotFoundException($"Author with ID {command.Id} not found.");
            }

            return new GetAuthorByIdResponseDto { Author = author.ToDto() };
        }
    }
}
