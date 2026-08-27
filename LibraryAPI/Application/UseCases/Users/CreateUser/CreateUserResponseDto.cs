using LibraryAPI.Application.Dtos;

namespace LibraryAPI.Application.UseCases.Users.CreateUser
{
    public record CreateUserResponseDto
    {
        public UserDto UserDto { get; init; }
    }
}
