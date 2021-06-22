using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Core
{
    public interface IBookServices
    {
        List<Book> GetBooks();
        Book GetBook(string id);
        Book AddBook(Book book);
        void DeleteBook(string id);
        Book UpdateBook(Book book);
    }
}
