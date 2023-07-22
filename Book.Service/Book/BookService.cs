using Book.Access.Repository.Abstract;

namespace Book.Service.Book;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<List<Data.Entities.Book>> GetAllBooks() =>
        _bookRepository.Where(b => b.IsDeleted == false).Result.ToList();
    }