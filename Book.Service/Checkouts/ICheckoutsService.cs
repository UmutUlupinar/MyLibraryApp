using Book.API.Models.Book;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Book.Service.Checkouts;

public interface ICheckoutsService
{
    Task<List<Data.Entities.Checkouts>> GetAllCheckouts();
    Task<List<Data.Entities.Checkouts>> GetUserCheckouts();
    Task<EntityEntry<Data.Entities.Checkouts>> AddCheckout(Data.Entities.Book book);
    void DeleteCheckout(Guid Id);
    Task<Data.Entities.Checkouts> UpdateCheckout(UpdateBookRequestModel book);
}