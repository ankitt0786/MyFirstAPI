using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        private readonly IBookRepository _bookRepository;
        //private readonly IBookRepository _bookRepository2;

       
        // Constructor Injection
        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
           // _bookRepository2 = bookRepository2;
        }

        [HttpPost("")]
        public IActionResult AddBook([FromBody] BookModel book)
        {
            int id = _bookRepository.AddBook(book);
            //var books = _bookRepository2.GetAllBooks();
            return Ok(id);
        }

        [HttpGet("")]
        public IActionResult GetAllBooks()
        {
            var books = _bookRepository.GetAllBooks();
            return Ok(books);
        }
    }
}
