using Book.Data.Enums;

namespace Book.Data.Entities;

public class User : BaseEntity 
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public UserType UserType { get; set; }
    public DateTime SignUpDate { get; set; }
}