using FluentValidation;
using LibraryAPI.Application.Interfaces.Category;
using LibraryAPI.Application.Mapping;
using LibraryAPI.Domain.Interfaces.Repositories;

namespace LibraryAPI.Application.UseCases.Categories.CreateCategoryUseCase
{
    public class CreateCategoryUseCase : ICreateCategoryUseCase
    {
        private readonly ICategoryRepository _repository;
        private readonly IValidator<CreateCategoryCommand> _validator;

        public CreateCategoryUseCase(
            ICategoryRepository repository,
            IValidator<CreateCategoryCommand> validator)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _validator = validator ?? throw new ArgumentNullException(nameof(validator));
        }

        public async Task<CreateCategoryResponseDto> ExecuteAsync(CreateCategoryCommand command, CancellationToken ct)
        {
            var validationResult = await _validator.ValidateAsync(command, ct);
            if(!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var category = command.ToEntity();

            await _repository.CreateAsync(category, ct);
            await _repository.SaveChangesAsync(ct);

            return new CreateCategoryResponseDto { CategoryDto = category.ToDto() };
        }
    }
}
