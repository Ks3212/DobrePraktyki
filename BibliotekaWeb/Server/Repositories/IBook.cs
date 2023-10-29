using BibliotekaWeb.Shared;
namespace BibliotekaWeb.Server.Repositoires
{
    public interface IBook
    {
        public List<Book> GetAllBooks();
        public void AddBook(Book book);
        public void RemoveBook(int id);
        public void UpdateBook(Book book);
        public Book GetBook(int id);

    }
}
