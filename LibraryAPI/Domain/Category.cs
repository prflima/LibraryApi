namespace LibraryAPI.Domain
{
    public class Category : Root
    {
        public string Name { get; private set; }

        public Category()
        {
            Id = Guid.NewGuid();
            Name = Name;
            CreatedAt = DateTime.Now;
        }
    }
}
