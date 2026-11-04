using LibraryAPI.Application.UseCases.Users.CreateUser;

namespace Library.Application.Interfaces.Users
{
    public interface ICreateUserUseCase
    {
        Task<CreateUserResponseDto> ExecuteAsync(CreateUserCommand command, CancellationToken ct);
    }
}
