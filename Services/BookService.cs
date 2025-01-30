using MasteringBlazor.Models;

namespace MasteringBlazor.Services;

public class BookService : IBookService
{
    static List<Book> _allBooks = new List<Book>
        {
            new Book
            {
                AuthorName = "resh",
                PublishingDate = new DateTime(1990, 2, 1),
                Title = "The book"
            },
            new Book
            {
                AuthorName = "Mezz",
                PublishingDate = new DateTime(1932, 2, 1),
                Title = "The Start"
            }
        };
    
    public Task<List<Book>> GetAllBooksAsync()
    {
        return Task.FromResult(_allBooks);
    }
    
}