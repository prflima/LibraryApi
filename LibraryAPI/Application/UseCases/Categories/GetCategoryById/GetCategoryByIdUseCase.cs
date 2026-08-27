using FluentValidation;
using LibraryAPI.Application.Interfaces.Category;
using LibraryAPI.Application.Mapping;
using LibraryAPI.Domain.Interfaces.Repositories;

namespace LibraryAPI.Application.UseCases.Categories.GetCategoryById
{
    public class GetCategoryByIdUseCase : IGetCategoryByIdUseCase
    {
        private readonly ICategoryRepository _repository;
        private readonly IValidator<GetCategoryByIdQuery> _validator;

        public GetCategoryByIdUseCase(
            ICategoryRepository repository,
            IValidator<GetCategoryByIdQuery> validator)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _validator = validator ?? throw new ArgumentNullException(nameof(validator));
        }

        public async Task<GetCategoryByIdResponseDto> ExecuteAsync(GetCategoryByIdQuery command, CancellationToken ct)
        {
            var validationResult = await _validator.ValidateAsync(command, ct);
            if(!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var category = await _repository.GetByIdAsync(command.Id, ct);

            if(category is null)
                throw new KeyNotFoundException($"Author with ID {command.Id} not found.");

            return new GetCategoryByIdResponseDto { CategoryDto = category.ToDto() };
        }
    }
}
