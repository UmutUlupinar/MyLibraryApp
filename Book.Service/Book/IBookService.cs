using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Book.Service.Book;

public interface IBookService
{
    Task<List<Data.Entities.Book>> GetAllBooks();
    Task<EntityEntry<Data.Entities.Book>> AddBook(Data.Entities.Book book);
}