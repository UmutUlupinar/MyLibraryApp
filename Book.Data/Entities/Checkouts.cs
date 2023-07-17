namespace Book.Data.Entities;

public class Checkouts
{
    public DateTime LoanDate { get; set; }
    public Guid UserId{ get; set; }
    public Guid BookId { get; set; }
}