using Book.API.Models.Book;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Book.Service.Checkouts;

public class CheckoutsService:ICheckoutsService
{
    public Task<List<Data.Entities.Checkouts>> GetAllCheckouts()
    {
        throw new NotImplementedException();
    }

    public Task<List<Data.Entities.Checkouts>> GetUserCheckouts()
    {
        throw new NotImplementedException();
    }

    public Task<EntityEntry<Data.Entities.Checkouts>> AddCheckout(Data.Entities.Book book)
    {
        throw new NotImplementedException();
    }

    public void DeleteCheckout(Guid Id)
    {
        throw new NotImplementedException();
    }

    public Task<Data.Entities.Checkouts> UpdateCheckout(UpdateBookRequestModel book)
    {
        throw new NotImplementedException();
    }
}