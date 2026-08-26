namespace LibraryAPI.Domain.Entities
{
    public abstract class Root 
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }

        protected Root()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
        }
    }
}
