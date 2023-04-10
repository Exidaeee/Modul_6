using books.api.Core;
using books.api.Models;
using Microsoft.AspNetCore.Mvc;

namespace books.api.Controller
{
    [ApiController]
    [Route("books")]

    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private readonly IBookRepository _bookRepository;


        public BookController( ILogger<BookController> logger, IBookRepository bookRepository)
        {
            _logger = logger;
            _bookRepository = bookRepository;
        }
        [HttpGet]
        public async Task GetAllProductsAsync()
        {
            _logger.LogInformation("GetBooksAsync is executed");
             await _bookRepository.GetAllProducts();
        }

        [HttpGet("{id}")]
        public async Task GetProductById(int id)
        {
            await _bookRepository.GetProductById(id);
        }

        [HttpPost]
        public async Task CreateProduct(Book book)
        {
            await _bookRepository.CreateProduct(book);            
        }

        [HttpPut("{id}")]
        public async Task UpdateProduct(int id, Book book)
        {

             await _bookRepository.UpdateProduct(book);
        }

        [HttpDelete("{name}")]
        public async Task DeleteProduct(string name)
        {
           await _bookRepository.DeleteProduct(name);
        }
    }
}

