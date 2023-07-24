namespace Book.Data.Entities;

public partial class Checkouts : BaseEntity
{
    public Guid UserId{ get; set; }
    public Guid BookId { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsActive { get; set; }
    
}

public partial class Checkouts
{
    public User User { get; set; }
    public Book Book { get; set; }
}