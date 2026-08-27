using LibraryAPI.Application.UseCases.Users.CreateUser;

namespace LibraryAPI.Application.Interfaces.Users
{
    public interface ICreateUserUseCase
    {
        Task<CreateUserResponseDto> ExecuteAsync(CreateUserCommand command, CancellationToken ct);
    }
}
