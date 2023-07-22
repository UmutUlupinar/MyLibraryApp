namespace Book.Service.Book;

public interface IBookService
{
    Task<List<Data.Entities.Book>> GetAllBooks();
}