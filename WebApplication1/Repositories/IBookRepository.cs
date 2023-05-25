using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public interface IBookRepository
    {
        int AddBook(BookModel book);
        List<BookModel> GetAllBooks();
    }
}
