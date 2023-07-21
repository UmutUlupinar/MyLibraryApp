using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Book.Access.EntityConfiguration;

public class BookEntityConfiguration : IEntityTypeConfiguration<Data.Entities.Book>
{
    public void Configure(EntityTypeBuilder<Data.Entities.Book> builder)
    {
        builder.HasKey(s => s.Id);
        builder.ToTable("Books");
    }
}