using LibraryAPI.Enums;

namespace LibraryAPI.Domain
{
    public class User : Root
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public UserType UserType { get; private set; }

        public IReadOnlyCollection<BookLoan> BookLoans { get; set; }

        public User(string name, string email, UserType userType)
        {
            Name = name;
            Email = email;
            UserType = userType;
        }
    }
}
