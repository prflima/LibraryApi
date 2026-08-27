using FluentValidation;
using LibraryAPI.Application.Interfaces.Category;
using LibraryAPI.Application.Mapping;
using LibraryAPI.Infrastructure;

namespace LibraryAPI.Application.UseCases.Categories.CreateCategoryUseCase
{
    public class CreateCategoryUseCase : ICreateCategoryUseCase
    {
        private readonly LibraryDbContext _context;
        private readonly IValidator<CreateCategoryCommand> _validator;

        public CreateCategoryUseCase(
            LibraryDbContext context,
            IValidator<CreateCategoryCommand> validator)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
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

            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync(ct);

            return new CreateCategoryResponseDto { CategoryDto = category.ToDto() };
        }
    }
}
