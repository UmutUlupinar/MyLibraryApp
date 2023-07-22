using Book.Access.Repository.Abstract;
using Book.Data.Entities;

namespace Book.Access.Repository.Concrete;

public class CheckoutsRepository : GenericRepository<Checkouts>, ICheckoutsRepository
{
    public CheckoutsRepository(Context context) : base(context)
    {
    }
}