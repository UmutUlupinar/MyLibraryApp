namespace Book.API.Models.Book;

public class UpdateCheckoutRequestModel
{
    public Guid Id { get; set; }
    public DateTime DueDate { get; set; }
}