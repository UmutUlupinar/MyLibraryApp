using Book.Data.Enums;

namespace Book.Data.Entities;

public class Book : BaseEntity
{
    public string Name { get; set; }
    public CategoryType CategoryType { get; set; }
    public bool IsDeleted { get; set; }
}