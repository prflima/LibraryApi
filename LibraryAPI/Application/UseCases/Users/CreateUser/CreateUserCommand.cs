using LibraryAPI.Domain.Enums;

namespace LibraryAPI.Application.UseCases.Users.CreateUser
{
    public record CreateUserCommand
    {
        public string Name { get; init; }
        public string Email { get; init; }
        public UserType UserType { get; init; }
    }
}
