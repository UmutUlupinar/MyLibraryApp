using Book.Service.Book;
using Book.Service.Checkouts;

namespace Book.API.Extensions;

public static class ServicesExtension
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IBookService,BookService>();
        services.AddScoped<ICheckoutsService, CheckoutsService>();
    }
}