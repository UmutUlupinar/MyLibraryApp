using Book.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Book.Access.Seed;

public class CheckoutsSeed : IEntityTypeConfiguration<Checkouts>
{
    public void Configure(EntityTypeBuilder<Checkouts> builder) 
    {
    }
}