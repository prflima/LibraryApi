namespace LibraryAPI.Application.Author.GetAuthorByIdUseCase
{
    public class GetAuthorByIdResponseDto
    {
        public string Guid { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
