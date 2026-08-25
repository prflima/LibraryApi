using LibraryAPI.Enums;

namespace LibraryAPI.Domain
{
    public class User : Root
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public UserType UserType { get; private set; }

        public User(string name, string email, UserType userType)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            UserType = userType;
            CreatedAt = DateTime.Now;
        }
    }
}
