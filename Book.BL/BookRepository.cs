using Book.Data;
using Book.IBL;
using Book.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.BL
{
    public class BookRepository : IBookRepository
    {
        private TestApiDBEntities objBookDbEntities;
        public BookRepository()
        {
              objBookDbEntities = new TestApiDBEntities();

        }

        public int AddBook(BookModel objBookModel)
        {
            Data.Book objBook = new Data.Book()
            {
                Author = objBookModel.Author,
                BestPrice = objBookModel.BestPrice,
                BookName = objBookModel.BookName,
                PublishYear = objBookModel.PublishYear,
                Title = objBookModel.Title
            };
            objBookDbEntities.Books.Add(objBook);
            return objBookDbEntities.SaveChanges();
        }

        public IEnumerable<BookModel> GetAllBooks()
        {
            IEnumerable<BookModel> listOfBooks = (from objBook in objBookDbEntities.Books select new BookModel()
            {
                Author = objBook.Author,
                BestPrice = (decimal)objBook.BestPrice,
                BookId = objBook.BookId,
                BookName = objBook.BookName,
                PublishYear = (int)objBook.PublishYear,
                Title = objBook.Title
            }).ToList();
            return listOfBooks;
        }

        public BookModel GetByBookId(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
