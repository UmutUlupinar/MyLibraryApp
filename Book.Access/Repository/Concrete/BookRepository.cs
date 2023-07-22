using Book.Access.Repository.Abstract;

namespace Book.Access.Repository.Concrete;

public class BookRepository : GenericRepository<Data.Entities.Book>, IBookRepository
{
    public BookRepository(Context context) : base(context)
    {
    }
}