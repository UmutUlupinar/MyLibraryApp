using Book.Access.Repository.Abstract;
using Book.API.Models.Book;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Book.Service.Checkouts;

public class CheckoutsService:ICheckoutsService
{
    private readonly ICheckoutsRepository _checkoutsRepository;

    public CheckoutsService(ICheckoutsRepository checkoutsRepository)
    {
        _checkoutsRepository = checkoutsRepository;
    }

    public async Task<List<Data.Entities.Checkouts>> GetAllCheckouts()=>
         _checkoutsRepository.Where(c => c.IsActive == true).Result.ToList();

    public async Task<List<Data.Entities.Checkouts>> GetUserCheckouts(Guid UserId)=>
         _checkoutsRepository.Where(c => c.UserId == UserId).Result.ToList();
       

    public async Task<EntityEntry<Data.Entities.Checkouts>> AddCheckout(AddCheckoutRequestModel model)
    {
        var checkout = new Data.Entities.Checkouts()
        {
            BookId = model.BookId,
            UserId = model.UserId,
            DueDate = model.Duedate,
            CreatedDate = DateTime.Now,
            IsActive = true
        };
       return _checkoutsRepository.AddAsync(checkout).Result;
    }

    public void DeleteCheckout(Guid Id)
    {
        var checkout = _checkoutsRepository.SingleOrDefaultAsync(c => c.Id == Id).Result;
        checkout.IsActive = false;
        _checkoutsRepository.Update(checkout);
    }

    public EntityEntry<Data.Entities.Checkouts> UpdateCheckout(UpdateCheckoutRequestModel model)
    {
        var checkout = _checkoutsRepository.SingleOrDefaultAsync(c => c.Id == model.Id).Result;
        checkout.DueDate = model.DueDate;
        return _checkoutsRepository.Update(checkout);

    }
}