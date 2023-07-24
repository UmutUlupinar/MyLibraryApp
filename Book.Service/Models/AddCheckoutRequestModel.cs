namespace Book.API.Models.Book;

public class AddCheckoutRequestModel
{
    public Guid BookId { get; set; }
    public Guid UserId { get; set; }
    public DateTime Duedate { get; set; }
}