namespace LibraryAPI.Application.Category.GetCategoryByIdUseCase
{
    public record GetCategoryByIdCommand
    {
        public Guid Id { get; set; }

        public GetCategoryByIdCommand(Guid id)
        {
            Id = id;
        }
    }
}
