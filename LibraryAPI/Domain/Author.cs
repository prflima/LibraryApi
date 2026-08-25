namespace LibraryAPI.Domain
{
    public class Author : Root
    {
        public string Name { get; private set; }

        public Author(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            CreatedAt = DateTime.Now;
        }
    }
}
