using FluentValidation;
using LibraryAPI.Application.Interfaces.Users;
using LibraryAPI.Application.Mapping;
using LibraryAPI.Domain.Interfaces.Repositories;

namespace LibraryAPI.Application.UseCases.Users.CreateUser
{
    public class CreateUserUseCase : ICreateUserUseCase
    {
        private readonly IUserRepository _userRepository;
        private readonly IValidator<CreateUserCommand> _validator;
        public CreateUserUseCase(
            IUserRepository userRepository,
            IValidator<CreateUserCommand> validator)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _validator = validator ?? throw new ArgumentNullException(nameof(validator));
        }

        public async Task<CreateUserResponseDto> ExecuteAsync(CreateUserCommand command, CancellationToken ct)
        {
            var validationResult = await _validator.ValidateAsync(command, ct);
            if(!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            if (_userRepository.GetByEmailAsync(command.Email, ct) is not null)
                throw new ArgumentException($"A user with this email: {command.Email}, already exists");

            var user = command.ToEntity();

            await _userRepository.CreateAsync(user, ct);
            await _userRepository.SaveChangesAsync(ct);

            return new CreateUserResponseDto { UserDto = user.ToDto() };
        }
    }
}
