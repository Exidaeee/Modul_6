using books.api.Models;

namespace books.api.Core
{
    public class BookRepository : IBookRepository
    {
        private readonly IBookRepository _bookRepository;

        public BookRepository(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<List<Book>> GetAllProducts()
        {
            return await _bookRepository.GetAllProducts();
        }

        public async Task<Book> GetProductById(int id)
        {
            return await _bookRepository.GetProductById(id);
        }

        public async Task<int> CreateProduct(Book book)
        {
            return await _bookRepository.CreateProduct(book);
        }

        public async Task<bool> UpdateProduct(Book book)
        {
            return await _bookRepository.UpdateProduct(book);
        }

        public async Task<bool> DeleteProduct(string name)
        {
            return await _bookRepository.DeleteProduct(name);
        }
    }
}
