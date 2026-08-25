using LibraryAPI.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAPI.Data.Configuration
{
    public class BookLoanConfiguration : IEntityTypeConfiguration<BookLoan>
    {
        public void Configure(EntityTypeBuilder<BookLoan> builder)
        {
            builder.ToTable("book_loans");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.LoanDate)
                   .HasDefaultValue(DateTime.Now)
                   .IsRequired();

            builder.Property(b => b.DueDate)
                   .HasDefaultValue(DateTime.Now.AddDays(5))
                   .IsRequired();

            builder.Property(b => b.Status)
                   .HasConversion<string>()
                   .IsRequired();

            builder.HasOne(b => b.User)
                   .WithMany(u => u.BookLoans)
                   .HasForeignKey(b => b.UserId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(b => b.Book)
                   .WithMany(b => b.Loans)
                   .HasForeignKey(b => b.BookId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
