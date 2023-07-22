using MyLibrary.MVC.Models.GenericModels;

namespace MyLibrary.MVC.Models.Book.Response;

public class GetAllBooksResponseModel
{
    public string Name { get; set; }
    public CategoryType CategoryType { get; set; }
}