namespace LibraryAPI.Domain.Entities
{
    public class Author : Root
    {
        public string Name { get; private set; }

        public IReadOnlyCollection<Book> Books { get; set; }

        public Author(string name)
        {
            Name = name;
        }
    }
}
