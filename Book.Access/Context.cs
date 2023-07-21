using Book.Access.EntityConfiguration;
using Book.Access.Seed;
using Microsoft.EntityFrameworkCore;

namespace Book.Access;

public class Context :DbContext
{
    public Context(DbContextOptions<Context> options):base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BookEntityConfiguration());
        modelBuilder.ApplyConfiguration(new CheckoutsEntityConfiguration());
        modelBuilder.ApplyConfiguration(new BookSeed());
        modelBuilder.ApplyConfiguration(new UserSeed());
    }
    
    
}