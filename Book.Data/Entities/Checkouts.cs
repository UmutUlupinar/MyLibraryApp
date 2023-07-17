namespace Book.Data.Entities;

public class Checkouts : BaseEntity
{
    public Guid UserId{ get; set; }
    public Guid BookId { get; set; }
    public DateTime DueDate { get; set; }
}