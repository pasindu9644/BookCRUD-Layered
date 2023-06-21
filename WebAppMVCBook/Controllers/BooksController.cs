using Book.IBL;
using Book.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMVCBook.Controllers
{
    public class BooksController : Controller
    {
        private IBookRepository iBookRepository;
        public BooksController(IBookRepository _iBookRepository)
        {
            iBookRepository = _iBookRepository;
        }
        // GET: Books
        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<BookModel> listOfBookModels = iBookRepository.GetAllBooks();
            return View(listOfBookModels);
        }
    }
}