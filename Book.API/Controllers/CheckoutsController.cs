using Book.API.Models.Book;
using Book.Data.Entities;
using Book.Service.Checkouts;
using Microsoft.AspNetCore.Mvc;

namespace Book.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class CheckoutsController : Controller
{
    private readonly ICheckoutsService _checkoutsService;

    public CheckoutsController(ICheckoutsService checkoutsService)
    {
        _checkoutsService = checkoutsService;
    }

    [HttpGet]
    public async Task<List<Checkouts>> GetAllCheckouts() => await _checkoutsService.GetAllCheckouts();

    [HttpGet]
    public async Task<List<Checkouts>> GetUserCheckouts(Guid UserId) => await _checkoutsService.GetUserCheckouts(UserId);

    [HttpPost]
    public async Task<Checkouts> AddCheckout(AddCheckoutRequestModel checkoutModel) =>
        _checkoutsService.AddCheckout(checkoutModel).Result.Entity;

    [HttpPost]
    public async Task DeleteCheckout(Guid id) => _checkoutsService.DeleteCheckout(id);

    [HttpPost]
    public async Task<Checkouts> UpdateCheckout(UpdateCheckoutRequestModel model)
    {
       return _checkoutsService.UpdateCheckout(model).Entity;
    }
}