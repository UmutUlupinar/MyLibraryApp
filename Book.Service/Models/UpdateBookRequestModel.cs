using Book.Data.Enums;

namespace Book.API.Models.Book;

public class UpdateBookRequestModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public CategoryType CategoryType { get; set; }
}