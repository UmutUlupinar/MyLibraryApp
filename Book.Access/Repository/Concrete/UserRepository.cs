using Book.Access.Repository.Abstract;
using Book.Data.Entities;

namespace Book.Access.Repository.Concrete;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(Context context) : base(context)
    {
    }
}