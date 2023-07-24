using Book.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Book.Access.EntityConfiguration;

public class CheckoutsEntityConfiguration : IEntityTypeConfiguration<Checkouts>
{
    public void Configure(EntityTypeBuilder<Checkouts> builder)
    {
        builder.HasKey(s => s.Id);
        builder.Property(s => s.BookId).IsRequired();
        builder.Property(s => s.UserId).IsRequired();
        builder.Property(s => s.IsActive).IsRequired();
        builder.ToTable("Checkouts");

        builder.HasOne(x => x.User)
            .WithMany(x => x.Checkouts)
            .HasForeignKey(x => x.UserId);
        
        builder.HasOne(x => x.Book)
            .WithMany(x => x.Checkouts)
            .HasForeignKey(x => x.BookId);
    }
}