using BibliotekaWeb.Server.Repositoires;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BibliotekaWeb.Shared;

namespace BibliotekaWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBook _book;
        public BookController(IBook book)
        {
            _book = book;
        }
        [HttpGet]
        public async Task<List<Book>> Get() 
        {
            return await Task.FromResult(_book.GetAllBooks());
        }
      
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Book book = _book.GetBook(id);
            if (book != null)
            {
                return Ok(book);
            }
            return NotFound();
        }
        [HttpPost]
        public void Post(Book book)
        {
            _book.AddBook(book);
        }
        [HttpPut]
        public void Put(Book book)
        {
            _book.UpdateBook(book);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _book.RemoveBook(id);
            return Ok();
        }


    }
}
