using LibraryAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Data
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookLoan> BookLoans { get; set; }

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LibraryDbContext).Assembly);
        }
    }
}
