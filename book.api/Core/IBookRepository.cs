using books.api.Models;

namespace books.api.Core
{
    public interface IBookRepository
    {
            Task<List<Book>> GetAllProducts();
            Task<Book> GetProductById(int id);
            Task<int> CreateProduct(Book book);
            Task<bool> UpdateProduct(Book book);
            Task<bool> DeleteProduct(string name);
    }
}
