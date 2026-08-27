using FluentValidation;
using LibraryAPI.Application.Interfaces.Category;
using LibraryAPI.Application.Mapping;
using LibraryAPI.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Application.UseCases.Categories.GetCategoryByIdUseCase
{
    public class GetCategoryByIdUseCase : IGetCategoryByIdUseCase
    {
        private readonly LibraryDbContext _context;
        private readonly IValidator<GetCategoryByIdQuery> _validator;

        public GetCategoryByIdUseCase(
            LibraryDbContext context,
            IValidator<GetCategoryByIdQuery> validator)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _validator = validator ?? throw new ArgumentNullException(nameof(validator));
        }

        public async Task<GetCategoryByIdResponseDto> ExecuteAsync(GetCategoryByIdQuery command, CancellationToken ct)
        {
            var validationResult = await _validator.ValidateAsync(command, ct);
            if(!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var category = await _context.Categories
                                            .Include(c => c.Books)
                                            .FirstOrDefaultAsync(c => c.Id == command.Id);

            if(category is null)
                throw new KeyNotFoundException($"Author with ID {command.Id} not found.");

            return new GetCategoryByIdResponseDto { CategoryDto = category.ToDto() };
        }
    }
}
