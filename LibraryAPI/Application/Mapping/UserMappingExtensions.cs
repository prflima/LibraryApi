using LibraryAPI.Application.Dtos;
using LibraryAPI.Application.UseCases.Users.CreateUserUseCase;
using LibraryAPI.Domain.Entities;

namespace LibraryAPI.Application.Mapping
{
    public static class UserMappingExtensions
    {
        public static User ToEntity(this CreateUserCommand command)
        {
            return new User(command.Name, command.Email, command.UserType);
        }

        public static UserDto ToDto(this User user)
        {
            return new UserDto
            {
                Id = user.Id.ToString(),
                Name = user.Name,
                Email = user.Email,
                UserType = user.UserType,
                CreatedAt = user.CreatedAt,
            };
        }
    }
}
