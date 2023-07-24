using Book.Access.Repository.Abstract;
using Book.API.Models.Book;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Book.Service.Book;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    /// <summary>
    /// this method provides to get all active books 
    /// </summary>
    /// <returns></returns>
    public async Task<List<Data.Entities.Book>> GetAllBooks() =>
        _bookRepository.Where(b => b.IsDeleted == false).Result.ToList();

    /// <summary>
    /// this methods provides to add new book. 
    /// </summary>
    /// <param name="book"></param>
    /// <returns></returns>
    public async Task<EntityEntry<Data.Entities.Book>> AddBook(Data.Entities.Book book) 
                                               => _bookRepository.AddAsync(book).Result;
    public void DeleteBook(Guid Id)
    {
        var book = _bookRepository.SingleOrDefaultAsync(b => b.Id == Id).Result;
        book.IsDeleted = true;
        _bookRepository.Update(book);
    }

    public async Task<Data.Entities.Book> UpdateBook(UpdateBookRequestModel book)
    {

        var updatedBook = _bookRepository.SingleOrDefaultAsync(b => b.Id == book.Id).Result;
        updatedBook.CategoryType = book.CategoryType;
        updatedBook.Name = book.Name;
        updatedBook.UpdatedDate = DateTime.Now;

        return _bookRepository.Update(updatedBook).Entity;
    }

    }