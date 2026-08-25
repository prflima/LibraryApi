using LibraryAPI.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAPI.Data.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("books");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.Title)
                   .HasMaxLength(80)
                   .IsRequired();

            builder.Property(b => b.ISBN)
                   .HasMaxLength(13)
                   .IsRequired();

            builder.Property(b => b.PublishedAt)
                   .HasColumnType("datetime2");

            builder.Property(b => b.TotalQuantity)
                   .HasDefaultValue(0)
                   .IsRequired();

            builder.Property(b => b.AvailableQuantity)
                   .IsRequired();

            builder.HasOne(b => b.Author)
                   .WithMany(a => a.Books)
                   .HasForeignKey(a => a.AuthorId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(b => b.Category)
                   .WithMany(a => a.Books)
                   .HasForeignKey(b => b.CategoryId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(b => b.ISBN).HasDatabaseName("idx_isbn_book");
        }
    }
}
