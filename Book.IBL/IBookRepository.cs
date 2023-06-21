using Book.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.IBL
{
    public interface IBookRepository
    {
        IEnumerable<BookModel> GetAllBooks();
        int AddBook(BookModel objBookModel);
        BookModel GetByBookId(int bookId);
    }
}
