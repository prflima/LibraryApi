namespace LibraryAPI.Application.Author.GetAuthorByIdUseCase
{
    public record GetAuthorByIdCommand
    {
        public Guid Id { get; set; }

        public GetAuthorByIdCommand(Guid id)
        {
            Id = id;
        }
    }
}
