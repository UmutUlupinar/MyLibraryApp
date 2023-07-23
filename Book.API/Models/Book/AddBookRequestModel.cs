using Book.Data.Enums;

namespace Book.API.Models.Book;

public class AddBookRequestModel
{
    public string Name { get; set; }
    public CategoryType CategoryType { get; set; }
}