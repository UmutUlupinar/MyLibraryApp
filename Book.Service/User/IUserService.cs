namespace Book.Service.User;

public interface IUserService
{
    Data.Entities.User Authenticate(string name, string password);
}