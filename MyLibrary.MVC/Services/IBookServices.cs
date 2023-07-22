using MyLibrary.MVC.Models.Book.Response;

namespace MyLibrary.MVC.Services;

public interface IBookServices
{
    List<GetAllBooksResponseModel> GetAllBooks();
}