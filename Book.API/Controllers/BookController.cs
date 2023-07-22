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
    
    
}