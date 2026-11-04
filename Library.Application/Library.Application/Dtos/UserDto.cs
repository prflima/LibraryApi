using LibraryAPI.Domain.Enums;

namespace LibraryAPI.Application.Dtos
{
    public record UserDto
    {
        public string Id { get; init; }
        public string Name { get; init; }
        public string Email { get; init; }
        public UserType UserType { get; init; }
        public DateTime CreatedAt { get; init; }
    }
}
