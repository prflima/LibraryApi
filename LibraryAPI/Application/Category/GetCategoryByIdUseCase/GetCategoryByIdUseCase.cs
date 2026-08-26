using FluentValidation;
using LibraryAPI.Application.Interfaces.Category;
using LibraryAPI.Data;
using LibraryAPI.Mapping;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Application.Category.GetCategoryByIdUseCase
{
    public class GetCategoryByIdUseCase : IGetCategoryByIdUseCase
    {
        private readonly LibraryDbContext _context;
        private readonly IValidator<GetCategoryByIdCommand> _validator;

        public GetCategoryByIdUseCase(
            LibraryDbContext context,
            IValidator<GetCategoryByIdCommand> validator)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _validator = validator ?? throw new ArgumentNullException(nameof(validator));
        }

        public async Task<GetCategoryByIdResponseDto> ExecuteAsync(GetCategoryByIdCommand command, CancellationToken ct)
        {
            var validationResult = await _validator.ValidateAsync(command, ct);
            if(!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var category = await _context.Categories
                                            .Include(c => c.Books)
                                            .FirstOrDefaultAsync(c => c.Id == command.Id);

            if(category is null)
                throw new KeyNotFoundException($"Author with ID {command.Id} not found.");

            return category.ToGetByIdDto();
        }
    }
}
