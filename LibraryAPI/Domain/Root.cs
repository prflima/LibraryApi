namespace LibraryAPI.Domain
{
    public abstract class Root 
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
