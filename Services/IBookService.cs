using MasteringBlazor.Models;

namespace MasteringBlazor.Services;

public interface IBookService
{
    Task<List<Book>> GetAllBooksAsync();
    Task<Book?> GetBookByIdAsync(string? id);
}