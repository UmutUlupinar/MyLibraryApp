using Book.API.Models.Book;
using Book.Service.Book;
using Microsoft.AspNetCore.Mvc;

namespace Book.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class BookController : Controller
{
    private readonly IBookService _bookService;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }
    
    [HttpGet]
    public async Task<List<Data.Entities.Book>> GetAllBooks()=> await _bookService.GetAllBooks();

    [HttpPost]
    public async Task<Data.Entities.Book> AddBook(AddBookRequestModel bookRequestModel)
    {
        var request = new Data.Entities.Book
        {
            Name = bookRequestModel.Name,
            CategoryType = bookRequestModel.CategoryType,
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now
        };
        return _bookService.AddBook(request).Result.Entity;
    }
    
}