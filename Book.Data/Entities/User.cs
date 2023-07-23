using Book.Data.Enums;

namespace Book.Data.Entities;

public partial class User : BaseEntity 
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string Token { get; set; }
    public UserType UserType { get; set; }
    public DateTime SignUpDate { get; set; }
}

public partial class User
{
    public ICollection<Checkouts> Checkouts { get; set; }
}
