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
    /// <summary>
    /// this action is for listing books
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<List<Data.Entities.Book>> GetAllBooks()=> await _bookService.GetAllBooks();
    
    /// <summary>
    /// this method is for adding new book
    /// </summary>
    /// <param name="bookRequestModel"></param>
    /// <returns></returns>
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
    
    /// <summary>
    /// this action convert bookd Isdeleted prop to true
    /// </summary>
    /// <param name="Id"></param>
    [HttpPost]
    public async void DeleteBook(Guid Id) => _bookService.DeleteBook(Id);

        /// <summary>
    /// this action provides to change name and categories of books.
    /// </summary>
    /// <param name="updateBook"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<Data.Entities.Book> UpdateBook(UpdateBookRequestModel updateBook)
    {
        return _bookService.UpdateBook(updateBook).Result;
    }
}