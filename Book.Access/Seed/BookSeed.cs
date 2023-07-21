using Book.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Book.Access.Seed;

public class BookSeed : IEntityTypeConfiguration<Data.Entities.Book>
{
    public void Configure(EntityTypeBuilder<Data.Entities.Book> builder)
    {
        builder.HasData(new Data.Entities.Book
            {
                Name = "Cemile",
                CreatedDate = DateTime.Now,
                CategoryType = CategoryType.Story,
                IsDeleted = false
            },
            new Data.Entities.Book
            {
                Name = "Toprak Ana",
                CreatedDate = DateTime.Now,
                CategoryType = CategoryType.Story,
                IsDeleted = false
            },
            new Data.Entities.Book
            {
                Name = "Puslu Kıtalar Atlası",
                CreatedDate = DateTime.Now,
                CategoryType = CategoryType.Novel,
                IsDeleted = false
            },
            new Data.Entities.Book
            {
                Name = "Tahıla Karsı",
                CreatedDate = DateTime.Now,
                CategoryType = CategoryType.Sociology,
                IsDeleted = false
            }
            );
    }
}