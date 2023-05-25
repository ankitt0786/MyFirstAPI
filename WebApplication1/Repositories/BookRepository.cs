using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class BookRepository: IBookRepository
    {
        private List<BookModel> books = new List<BookModel>();

        public int AddBook(BookModel book)
        {
            book.Id = books.Count + 1; // Create the incremental Id
            books.Add(book);
            return book.Id;
        }

        public List<BookModel> GetAllBooks()
        {
            return books;
        }
    }
}
