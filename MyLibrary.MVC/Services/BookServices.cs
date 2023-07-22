using System.Text.Json.Serialization;
using MyLibrary.MVC.Models.Book.Response;
using Newtonsoft.Json;

namespace MyLibrary.MVC.Services;

public class BookServices : IBookServices
{
    private readonly ISendApiRequestService _sendApiRequestService;
    public BookServices(ISendApiRequestService sendApiRequestService)
    {
        _sendApiRequestService = sendApiRequestService;
    }
    
    public List<GetAllBooksResponseModel> GetAllBooks()
    {
        var result = _sendApiRequestService.SendApiRequest("GetAllBooks");
        var books = JsonConvert.DeserializeObject<List<GetAllBooksResponseModel>>(result);
        return books;
    }
}