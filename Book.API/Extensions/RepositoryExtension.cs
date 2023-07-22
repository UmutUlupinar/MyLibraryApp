using Book.Access.Repository.Abstract;
using Book.Access.Repository.Concrete;

namespace Book.API.Extensions;

public static class RepositoryExtension
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(IBookRepository),typeof(BookRepository));
        services.AddScoped(typeof(ICheckoutsRepository),typeof(CheckoutsRepository));
        services.AddScoped(typeof(IUserRepository),typeof(UserRepository));
    }
}