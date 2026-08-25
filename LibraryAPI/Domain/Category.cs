namespace LibraryAPI.Domain
{
    public class Category : Root
    {
        public string Name { get; private set; }
        public IReadOnlyCollection<Book> Books { get; set; }

        public Category(string name)
        {
            Name = name;
        }
    }
}
