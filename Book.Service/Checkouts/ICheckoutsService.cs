using Book.API.Models.Book;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Book.Service.Checkouts;

public interface ICheckoutsService
{
    Task<List<Data.Entities.Checkouts>> GetAllCheckouts();
    Task<List<Data.Entities.Checkouts>> GetUserCheckouts(Guid UserId);
    Task<EntityEntry<Data.Entities.Checkouts>> AddCheckout(AddCheckoutRequestModel model);
    void DeleteCheckout(Guid Id);
    EntityEntry<Data.Entities.Checkouts> UpdateCheckout(UpdateCheckoutRequestModel checkoutModel);
}