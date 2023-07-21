using Book.Data.Enums;

namespace Book.Data.Entities;

public partial class Book : BaseEntity
{
    public string Name { get; set; }
    public CategoryType CategoryType { get; set; }
    public bool IsDeleted { get; set; }
}

public partial class Book
{
    public ICollection<Checkouts> Checkouts { get; set; }
}